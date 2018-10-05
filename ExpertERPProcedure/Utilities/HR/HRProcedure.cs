using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Transactions;
using ExpertERPProcedure.Utilities;
using ExpertERPWeb.BaseEntities;
using ExpertERP.BusinessEntities;
using ExpertWebLib;

namespace ExpertERP.Procedure.HR
{
    public class BonusAllowanceProcedure
    {
        #region Const

        public static readonly string cstUpward = "Upward";
        public static readonly string cstReduce = "Reduce";
        public static readonly string cstThuongThang13 = "TCS";
        public static readonly string cstThuongNangSuat = "TNX";
        public static readonly string cstThuongLe = "TL";
        public static readonly string cstThuongKhac = "TK";
        public static readonly string cstPhuCapCongTac = "PCCT";
        public static readonly string cstPhuCapComTangCa = "PCCTC";
        public static readonly string cstTamUngLuong = "TUL";
        public static readonly string cstPhat = "PHAT";
        public static readonly string cstKhauTruKhac = "KTK";
        public static readonly string cstChuyenCan = "CC";
        public static readonly string cstTraPhepNam = "TPN";
        public static readonly string cstBuLuong = "BL";
        public static readonly string cstTruLuong = "TRULUONG";
        public static readonly string cstTruLuongThucLanh = "TRULUONGTHUCLANH";

        public static readonly string cstLiability = "Liability";
        public static readonly string cstNoxious = "Noxious";
        public static readonly string cstRide = "Ride";
        public static readonly string cstRice = "Rice";
        public static readonly string cstTravelingRice = "TravelingRice";
        public static readonly string cstTravelingGas = "TravelingGas";
        public static readonly string cstDifference = "Difference";
        public static readonly string cstPayCut = "PayCut";

        public static readonly string cstContractTypeHDXDTH1N = "HDXDTH1N";
        public static readonly string cstContractTypeHDXDTH3N = "HDXDTH3N";
        public static readonly string cstContractTypeHDKXDTH = "HDKXDTH";
        public static readonly string cstContractTypeHDTV = "HDTV";

        public static readonly string strPhuCapTrachNhiem = "Liability";
        public static readonly string strPhuCapTayNghe = "Skilled";
        public static readonly string strPhuCapCongTac = "Traveling";
        public static readonly string strPhuCapDiLai = "Ride";
        public static readonly string strPhuCapCom = "Rice";
        public static readonly string strPhuCapDocHai = "Noxious";
        public static readonly string strPhuCapKhac = "PCK";
        public static readonly string strPhuCapGiaoNhan = "PCGN";
        public static readonly string strPhuCapDienThoai = "PCDT";
        public static readonly string strPhuCapKiemNhiem = "PCKN";
        public static readonly string strGiamTruPCComVuotMuc = "RiceExceed";
        public static readonly string strPhuCapTienNha = "House";
        public static readonly string strPhuCapSinhHoat = "Activity";
        public static readonly string strPhuCapMay = "Machine";
        public static readonly string strPhucapSinhNhat = "Birthday";
        public static readonly string strPhucapConNho = "Children";
        public static readonly string strPhucapThamNien = "Seniority";
        public static readonly string strPhucapCC = "Deligent";


        public static readonly string strGiamTruDongPhuc = "DONGPHUC";


        #endregion

        //Hàm này trả về sống ngày tăng ca của 1 tháng được dựa trên tăng ca 2 --Vinh --29/03/2013
        public static double GetCountDayOvertimeInMonth(String strDepartment, DateTime dt)
        {
            double db = 0;

            HRShiftsController ShiftCtrl = new HRShiftsController();

            HRShiftsInfo ShiftInfo = ShiftCtrl.LayTangCa2CuaNhanVien(strDepartment, "Overtime 150");
            Dictionary<DayOfWeek, DayOfWeek> dicDay = new Dictionary<DayOfWeek, DayOfWeek>();
            if (ShiftInfo != null && ShiftInfo.HRShiftStartWeek != null && ShiftInfo.HRShiftEndWeek != null)
            {
                DayOfWeek dayStart = ((DateTime)ShiftInfo.HRShiftStartWeek).DayOfWeek;
                DayOfWeek dayEnd = ((DateTime)ShiftInfo.HRShiftEndWeek).DayOfWeek;
                for (int i = 0; i <= (((DateTime)ShiftInfo.HRShiftEndWeek) - ((DateTime)ShiftInfo.HRShiftStartWeek)).TotalDays; i++)
                {
                    DateTime dtDay = ((DateTime)ShiftInfo.HRShiftStartWeek).AddDays(i);
                    if (!dicDay.ContainsKey(dtDay.DayOfWeek))
                    {
                        dicDay.Add(dtDay.DayOfWeek, dtDay.DayOfWeek);
                    }
                }
                for (int i = 0; i <= (dt.AddMonths(1).AddDays(-1) - dt).TotalDays; i++)
                {
                    DateTime dtDay = dt.AddDays(i);
                    if (dicDay.ContainsKey(dtDay.DayOfWeek))
                    {
                        db++;
                    }
                }
            }

            return db;
        }

        public static double LayTongSoNgayLamViecTrongThang(DateTime dtCurrent)
        {
            double dbTongNgay = 0;
            for (DateTime dt = dtCurrent; dt <= dtCurrent.AddMonths(1).AddDays(-1); dt = dt.AddDays(1))
            {
                if (!KiemTraCoPhaiNgayNghiTrongTuan(dt))
                {
                    dbTongNgay++;
                }
            }
            return dbTongNgay;
        }

        public static Boolean KiemTraCoPhaiNgayNghiTrongTuan(DateTime dtCurrent)
        {
            HRConfigsInfo ConfigInfo = (HRConfigsInfo)new HRConfigsController().GetFirstObject();
            if (ConfigInfo != null)
            {
                if (ConfigInfo.HRConfigOffWork1.Contains(dtCurrent.DayOfWeek.ToString()) || ConfigInfo.HRConfigOffWork2.Contains(dtCurrent.DayOfWeek.ToString()) || ConfigInfo.HRConfigOffWork3.Contains(dtCurrent.DayOfWeek.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean KiemTraCoPhaiNgayNghiTrongBangXepCa(DateTime dtCurrent, int iHREmployeeID)
        {
            //Lấy lịch làm việc của nhân viên ngày hôm đó. --Vinh -- 04/10/2013
            //Nếu ngày này không có xếp ca làm việc nào thì thứ đó trong tuần là ngày nghỉ của NV.
            HREmployeeTimeSheetsController objHREmployeeTimeSheetCtrl = new HREmployeeTimeSheetsController();
            String strColumnNameDay = ExpertERP.Procedure.HR.EmployeeTimeSheetProcedure.strHREmployeeTimeSheetDay + dtCurrent.Day;

            if (objHREmployeeTimeSheetCtrl.KiemTraCoXepCaChoNhanVien(dtCurrent.Year, dtCurrent.Month, iHREmployeeID, strColumnNameDay))
            {
                return false;
            }

            return true;
        }

        public static double GetHolidayWorkInMonth(int iEmployeeID, DateTime dtCurrent)
        {
            HRHolidaysController HolidayCtrl = new HRHolidaysController();
            HREmpActivitysController EmpActivityCtrl = new HREmpActivitysController();
            double dbTongNgay = 0;
            for (DateTime dt = dtCurrent; dt <= dtCurrent.AddMonths(1).AddDays(-1); dt = dt.AddDays(1))
            {
                if (dt.DayOfWeek != DayOfWeek.Sunday && HolidayCtrl.CheckDateIsHoliday(dt) && EmpActivityCtrl.CheckEmployeeWorking(iEmployeeID, dt))
                {
                    dbTongNgay++;
                }
            }
            return dbTongNgay;
        }

        public static int GetSumHolidayWorkInMonth(int iHREmployeeID, DateTime dtCurrent, Boolean isTrying)
        {
            HRHolidaysController HolidayCtrl = new HRHolidaysController();
            HREmpActivitysController objHREmpActivityCtrl = new HREmpActivitysController();

            HRConfigsInfo objHRConfigInfo = (HRConfigsInfo)new HRConfigsController().GetFirstObject();

            int iTongNgay = 0;
            for (DateTime dt = dtCurrent; dt <= dtCurrent.AddMonths(1).AddDays(-1); dt = dt.AddDays(1))
            {
                if (
                    (objHRConfigInfo != null && (
                        dt.DayOfWeek.ToString() != objHRConfigInfo.HRConfigOffWork1 ||
                        dt.DayOfWeek.ToString() != objHRConfigInfo.HRConfigOffWork2 ||
                        dt.DayOfWeek.ToString() != objHRConfigInfo.HRConfigOffWork3)
                    ) &&
                    HolidayCtrl.CheckDateIsHoliday(dt) &&
                    objHREmpActivityCtrl.CheckEmployeeWorking(iHREmployeeID, dt)
                  )
                {
                    if (isTrying == objHREmpActivityCtrl.CheckEmployeeTrying(iHREmployeeID, dt))
                    {
                        //Kiểm tra nếu có tăng ca thì không có trả về nghỉ lễ --Vinh
                        HREmployeeTCSrlDtlsInfo objHREmployeeTCSrlDtlInfo = new HREmployeeTCSrlDtlsController().GetEmployeeTCSrlDtlByEmployeeANDDate(iHREmployeeID, dt);
                        if (objHREmployeeTCSrlDtlInfo != null && objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount == 0)
                        {
                            iTongNgay++;
                        }
                    }
                }
            }
            return iTongNgay;
        }

        public static double GetCountDayOvertimeHolidayInMonth(String strDepartment, int iEmployeeID, DateTime dt)
        {
            double db = 0;

            HRShiftsController ShiftCtrl = new HRShiftsController();
            HRHolidaysController HolidayCtrl = new HRHolidaysController();
            HREmpActivitysController EmpActivityCtrl = new HREmpActivitysController();
            HRShiftsInfo ShiftInfo = ShiftCtrl.LayTangCa2CuaNhanVien(strDepartment, "Overtime 150");
            Dictionary<DayOfWeek, DayOfWeek> dicDay = new Dictionary<DayOfWeek, DayOfWeek>();
            if (ShiftInfo != null && ShiftInfo.HRShiftStartWeek != null && ShiftInfo.HRShiftEndWeek != null)
            {
                DayOfWeek dayStart = ((DateTime)ShiftInfo.HRShiftStartWeek).DayOfWeek;
                DayOfWeek dayEnd = ((DateTime)ShiftInfo.HRShiftEndWeek).DayOfWeek;
                for (int i = 0; i <= (((DateTime)ShiftInfo.HRShiftEndWeek) - ((DateTime)ShiftInfo.HRShiftStartWeek)).TotalDays; i++)
                {
                    DateTime dtDay = ((DateTime)ShiftInfo.HRShiftStartWeek).AddDays(i);
                    if (!dicDay.ContainsKey(dtDay.DayOfWeek))
                    {
                        dicDay.Add(dtDay.DayOfWeek, dtDay.DayOfWeek);
                    }
                }
                for (int i = 0; i <= (dt.AddMonths(1).AddDays(-1) - dt).TotalDays; i++)
                {
                    DateTime dtDay = dt.AddDays(i);
                    if (dicDay.ContainsKey(dtDay.DayOfWeek) && HolidayCtrl.CheckDateIsHoliday(dtDay) && EmpActivityCtrl.CheckEmployeeWorking(iEmployeeID, dtDay))
                    {
                        db++;
                    }
                }
            }

            return db;
        }

    }

    public class EmployeeAllowanceProcedure
    {
        #region Const

        public static readonly string cstLiability = "Liability";
        public static readonly string cstNoxious = "Noxious";
        public static readonly string cstRide = "Ride";
        public static readonly string cstRice = "Rice";
        public static readonly string cstTraveling = "Traveling";
        public static readonly string cstDifference = "Other";
        public static readonly string cstPayCut = "PayCut";
        public static readonly string strSkill = "Skilled";
        public static readonly string Deligent = "Deligent";
        public static readonly string cstTienNha = "House";
        public static readonly string cstPhuCapSinhHoat = "Activity";
        public static readonly string cstPhuCapMay = "Machine";
        public static readonly string cstPhucapSinhNhat = "Birthday";
        public static readonly string cstPhucapConNho = "Children";
        public static readonly string cstPhucapThamNien = "Seniority";

        public static readonly string cstContractTypeHDXDTH1N = "HDXDTH1N";
        public static readonly string cstContractTypeHDXDTH3N = "HDXDTH3N";
        public static readonly string cstContractTypeHDKXDTH = "HDKXDTH";
        public static readonly string cstContractTypeHDTV = "HDTV";

        #endregion        
    }


    public class EmployeeOffWorkProcedure
    {
        #region Const

        public static readonly string cstHREmployeeOffWorkTypeComboPermision = "Permision";
        public static readonly string cstHREmployeeOffWorkTypeComboUnPermision = "UnPermision";
        public static string cstHREmployeeLeaveTypeNameComboAnnualLeave = "AnnualLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboSickLeave = "SickLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboPregnantLeave = "PregnantLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboCompassionateLeave = "CompassionateLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboUnsalariedLeave = "UnsalariedLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboMourningLeave = "MourningLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboMarriedLeave = "MarriedLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboWaitLeave = "WaitLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboOffsetLeave = "OffsetLeave";
        public static readonly string cstHREmployeeLeaveTypeNameComboUnpermisionLeave = "UnpermisionLeave";
        #endregion
    }

    public class EmployeeProcedure
    {
        #region Const
        public static readonly string cstHREmployeeSalaryCalcTypeComboProfit = "Profit";
        public static readonly string cstHREmployeeSalaryCalcTypeComboManual = "Manual";
        #endregion

        public static void CheckChangeSalaryEmployee(HREmployeesInfo objHREmployeeNewInfo, HREmployeesInfo objHREmployeeOldInfo)
        {
            if (objHREmployeeOldInfo == null || objHREmployeeOldInfo.HREmployeeWorkingSalaryAmount != objHREmployeeNewInfo.HREmployeeWorkingSalaryAmount ||
               objHREmployeeOldInfo.HREmployeeContractSalaryAmount != objHREmployeeNewInfo.HREmployeeContractSalaryAmount)
            {
                CreateHREmployeeSalaryHistory(objHREmployeeNewInfo.HREmployeeID,
                                              objHREmployeeNewInfo.HREmployeeWorkingSalaryAmount,
                                              objHREmployeeNewInfo.HREmployeeContractSalaryAmount);
            }
        }

        public static void CreateHREmployeeSalaryHistory(int iHREmployeeID, double dbHREmployeeWorkingSalary, double dbHREmployeeContractSalary)
        {
            HREmployeeSalaryHistorysInfo objHREmployeeSalaryHistorysInfo = new HREmployeeSalaryHistorysInfo();
            objHREmployeeSalaryHistorysInfo.FK_HREmployeeID = iHREmployeeID;
            objHREmployeeSalaryHistorysInfo.HREmployeeSalaryHistoryContractSalary = dbHREmployeeContractSalary;
            objHREmployeeSalaryHistorysInfo.HREmployeeSalaryHistoryWorkingSalary = dbHREmployeeWorkingSalary;
            objHREmployeeSalaryHistorysInfo.HREmployeeSalaryHistoryDate = GMCWebApp.WorkingDate;
            objHREmployeeSalaryHistorysInfo.AACreatedDate = DateTime.Now;
            objHREmployeeSalaryHistorysInfo.AACreatedUser = GMCWebApp.CurrentUser;
            new HREmployeeSalaryHistorysController().CreateObject(objHREmployeeSalaryHistorysInfo);

        }
    }

    public class EmployeeTimeSheetProcedure
    {
        #region Const

        public const String strHREmployeeTimeSheetDay = "HREmployeeTimeSheetD";

        #endregion
    }

    public class InsuranceProcedure
    {
        #region Const

        public const String strHRInsuranceNameComboPublic = "PublicInsurance";
        public const String strHRInsuranceNameComboHealth = "HealthInsurance";
        public const String strHRInsuranceNameComboUnemployment = "UnemploymentInsurance";

        #endregion
    }

    public class EmployeeSalaryProcedure
    {
        #region Const

        public static readonly string cstLoaiCongThuong = "WorkingHour";
        public static readonly string cstLoaiCongLamBu = "Offset";
        public static readonly string cstLoaiCongTangCa = "Overtime";

        public static readonly string cstHRTCSrlTypeComboNoWork = "NoWork";
        public static readonly string cstHRTCSrlTypeComboSunday = "Sunday";
        public static readonly string cstHRTCSrlTypeComboHoliday = "Holiday";
        public static readonly string cstHRTCSrlTypeComboOffWork = "OffWork";
        public static readonly string cstHRTCSrlTypeComboUnPermission = "UnPermission";
        public static readonly string cstHRTCSrlTypeComboTrying = "Trying";

        public static readonly string cstLoaiTinhCongDefault = "Default";
        public static readonly string cstLoaiTinhCongTheoBangXepCa = "TimeSheet";

        public static readonly string strHREmployeeTCSrlDetailResultColumn = "HREmployeeTCSrlDetailResult";

        #endregion
    }

    public class SlrAdjProcedure
    {
        #region Const

        public static readonly string cstSlrAdjTypeLuong = "Luong";
        public static readonly string cstSlrAdjTypeTrachNhiem = "TrachNhiem";
        public static readonly string cstSlrAdjTypeDocHai = "DocHai";
        public static readonly string cstSlrAdjTypePhuCapDiLai = "PhuCapDiLai";

        public static readonly string cstSlrAdjStatusNew = "New";
        public static readonly string cstSlrAdjStatusInComplete = "InComplete";
        public static readonly string cstSlrAdjStatusComplete = "Complete";

        public static readonly string cstSlrAdjItemStatusNew = "New";
        public static readonly string cstSlrAdjItemStatusComplete = "Complete";


        #endregion
        public static void RecalculateSlrAdj(int iSlrAdjID)
        {
            PRSlrAdjsInfo SlrAdj = (PRSlrAdjsInfo)new PRSlrAdjsController().GetObjectByID(iSlrAdjID);
            if (SlrAdj != null)
                RecalculateSlrAdj(SlrAdj);
        }

        public static void RecalculateSlrAdj(PRSlrAdjsInfo SlrAdj)
        {
            PRSlrAdjItemsController objPRSlrAdjItemCtrl = new PRSlrAdjItemsController();
            DataSet ds = objPRSlrAdjItemCtrl.GetAllDataByForeignColumn("FK_PRSlrAdjID", SlrAdj.PRSlrAdjID);
            List<BusinessObject> lst = objPRSlrAdjItemCtrl.GetListFromDataset(ds);
            bool bIsComplete = true;
            foreach (PRSlrAdjItemsInfo SlrAdjItem in lst)
            {
                if (SlrAdjItem.FK_HREmployeeContractID > 0 && Controller.EmployeeContractCtrl.GetObjectByID(SlrAdjItem.FK_HREmployeeContractID) != null)
                {
                    SlrAdjItem.PRSlrAdjItemStatusCombo = SlrAdjProcedure.cstSlrAdjItemStatusComplete;
                }
                else
                {
                    SlrAdjItem.PRSlrAdjItemStatusCombo = SlrAdjProcedure.cstSlrAdjItemStatusNew;
                    bIsComplete = false;
                }
                objPRSlrAdjItemCtrl.UpdateObject(SlrAdjItem);
            }

            if (bIsComplete)
                SlrAdj.PRSlrAdjStatusCombo = SlrAdjProcedure.cstSlrAdjStatusComplete;

            objPRSlrAdjItemCtrl.UpdateObject(SlrAdj);
        }

        public static void RecalculateSlrAdjByEmployeeContract(int iHREmployeeContractID)
        {
            PRSlrAdjItemsController objPRSlrAdjItemCtrl = new PRSlrAdjItemsController();
            DataSet ds = objPRSlrAdjItemCtrl.GetAllDataByForeignColumn("FK_HREmployeeContractID", iHREmployeeContractID);
            List<BusinessObject> lst = objPRSlrAdjItemCtrl.GetListFromDataset(ds);
            foreach (PRSlrAdjItemsInfo objSlrAdjItem in lst)
            {
                SlrAdjProcedure.RecalculateSlrAdj(objSlrAdjItem.FK_PRSlrAdjID);
            }
        }

        public static void ProcessAlert(String strDocType, String strModuleName, BusinessObject obj, String strSubject, String strMessage)
        {
            ADAlertConfigsInfo objAlertConfig = new ADAlertConfigsController().GetAllConfigManualByDocType(strDocType);
            if (objAlertConfig != null && objAlertConfig.ToUser.Length > 0)
            {
                //MailUtil.ProcessAlert(strModuleName, obj, MailUtil.strTransactionEdit, strSubject, strMessage, objAlertConfig.ToUser);
            }
        }
    }

    public class HRConfigProcedure
    {
        #region Const

        public const String strHRConfigTimeSheetMthComboShift = "Shift";
        public const String strHRConfigTimeSheetMthComboHour = "Hour";

        #endregion
    }

    public class EmployeeContractProcedure
    {

        public static void CopyEmpInfoForContract(HREmployeesInfo Employee, ref HREmployeeContractsInfo EmployeeContract, bool bIsCopySlr)
        {
            if (Employee != null && EmployeeContract != null)
            {
                EmployeeContract.FK_HREmployeeID = Employee.HREmployeeID;
                if (bIsCopySlr)
                {
                    EmployeeContract.HREmployeeContractSlrAmt = Employee.HREmployeeWorkingSalaryAmount;
                    EmployeeContract.HREmployeeContractInsuranceAmt = Employee.HREmployeeContractSalaryAmount;
                }

                EmployeeContract.HREmployeeContractEmployeeNo = Employee.HREmployeeNo;
                EmployeeContract.HREmployeeContractEmployeeName = Employee.HREmployeeName;
                EmployeeContract.FK_HREmployeeContractEmployeePositionID = Employee.FK_HRPositionID;
                EmployeeContract.HREmployeeContractEmployeeCountry = Employee.HREmployeeTemporaryAddressCountry;
                EmployeeContract.HREmployeeContractEmployeeDob = Employee.HREmployeeDob;
                EmployeeContract.HREmployeeContractEmployeeIDCard = Employee.HREmployeeIDNumber;
                EmployeeContract.HREmployeeContractEmployeeIDCardDate = Employee.HREmployeeIDCardDate;
                EmployeeContract.HREmployeeContractEmployeeIDCardPlace = Employee.HREmployeeIDCardPlace;
            }
        }

        public static void CopyCompanyInfoForContract(CSCompanysInfo Company, ref HREmployeeContractsInfo EmployeeContract)
        {
            if (Company != null && EmployeeContract != null)
            {
                EmployeeContract.HREmployeeContractCompanyDesc = Company.CSCompanyDesc;
                EmployeeContract.HREmployeeContractCompanyAddressCity = Company.CSCompanyAddressCity;
                EmployeeContract.HREmployeeContractCompanyAddressCountry = Company.CSCompanyAddressCountry;
                EmployeeContract.HREmployeeContractCompanyAddressLine1 = Company.CSCompanyAddressLine1;
                EmployeeContract.HREmployeeContractCompanyAddressLine2 = Company.CSCompanyAddressLine2;
                EmployeeContract.HREmployeeContractCompanyAddressLine3 = Company.CSCompanyAddressLine3;
                EmployeeContract.HREmployeeContractCompanyAddressPostalCode = Company.CSCompanyAddressPostalCode;
                EmployeeContract.HREmployeeContractCompanyAddressStateProvince = Company.CSCompanyAddressStateProvince;
                EmployeeContract.HREmployeeContractCompanyAddressStreet = Company.CSCompanyAddressStreet;
                EmployeeContract.HREmployeeContractCompanyAddressZipCode = Company.CSCompanyAddressZipCode;
                EmployeeContract.HREmployeeContractCompanyBankCode = Company.CSCompanyBankCode;
                EmployeeContract.HREmployeeContractCompanyBankName = Company.CSCompanyBankName;
                EmployeeContract.HREmployeeContractCompanyCellPhone = Company.CSCompanyCellPhone;
                EmployeeContract.HREmployeeContractCompanyCFO = Company.CSCompanyCFO;
                EmployeeContract.HREmployeeContractCompanyEmail = Company.CSCompanyEmail;
                EmployeeContract.HREmployeeContractCompanyFax = Company.CSCompanyFax;
                EmployeeContract.HREmployeeContractCompanyInformation = Company.CSCompanyInformation;
                EmployeeContract.HREmployeeContractCompanyLogo = Company.CSCompanyLogo;
                EmployeeContract.HREmployeeContractCompanyManager = Company.CSCompanyManager;
                EmployeeContract.HREmployeeContractCompanyPhone = Company.CSCompanyPhone;
                EmployeeContract.HREmployeeContractCompanyTaxNumber = Company.CSCompanyTaxNumber;
                EmployeeContract.HREmployeeContractCompanyWebsite = Company.CSCompanyWebsite;
            }
        }
    }
    public class HRRecruitReq
    {
        public static readonly string HRRecruitReqStatusNew = "New";
        public static readonly string HRRecruitReqStatusComplete = "Complete";
        public static void RecalculateRecruitReq(int iHRRecruitReqID)
        {
            HRRecruitReqsController HRRecruitReqCtrl = new HRRecruitReqsController();
            HRRecruitReqsInfo RecruitReq = (HRRecruitReqsInfo)HRRecruitReqCtrl.GetObjectByID(iHRRecruitReqID);
            if (RecruitReq != null)
                RecalculateRecruitReq(RecruitReq);
        }
        public static void RecalculateRecruitReq(HRRecruitReqsInfo RecruitReq)
        {
            HRRecruitReqsController HRRecruitReqCtrl = new HRRecruitReqsController();
            HRRecruitPlnItemsController RecruitPlnItemCtrl = new HRRecruitPlnItemsController();
            HRRecruitPlnItemsInfo RecruitPlnItem = (HRRecruitPlnItemsInfo)RecruitPlnItemCtrl.GetFirstObjectByForeignColumn("FK_HRRecruitReqID", RecruitReq.HRRecruitReqID);
            if (RecruitPlnItem != null)
                RecruitReq.HRRecruitReqStatusCombo = HRRecruitReqStatusComplete;
            else
                RecruitReq.HRRecruitReqStatusCombo = HRRecruitReqStatusNew;
            HRRecruitReqCtrl.UpdateObject(RecruitReq);
        }
    }

    public class HRTraining
    {
        public static readonly string HRTrainingSemesterCourseEmployeeTimeCardTypeAbsent = "Absent";
        public static readonly string HRTrainingSemesterCourseEmployeeTimeCardTypePresent = "Present";
    }
    public class HRUtil
    {
        public static SortedList<DayOfWeek, double> OffWorkDays;
        public static List<double> TimeRounds;
        public static SortedList<double, int> BreakTimeOfOTs;
        public static SortedList<double, double> SenioritySalarys;
        public static List<HRInTaxRatesInfo> InTaxRates;
        public static int ShiftPerMonth;
        public static double NoneContractSalary = 942000;
        public static double DiligentSalary;
        public static double RiceSalary;
        public static double UnionFee;
        public static double MinimumInTax;

        static HRUtil()
        {

            OffWorkDays = new SortedList<DayOfWeek, double>();
            TimeRounds = new List<double>();
            BreakTimeOfOTs = new SortedList<double, int>();
            InTaxRates = new List<HRInTaxRatesInfo>();

            HRConfigsController configCtrl = new HRConfigsController();
            HRConfigsInfo configInfo = (HRConfigsInfo)configCtrl.GetFirstObject();
            if (configInfo != null)
            {

                #region OffWorkDays

                for (int i = 1; i <= 3; i++)
                {
                    object objOffWork = DynamicInvoker.DynamicGetValue(configInfo, configInfo.GetType().GetProperty("HRConfigOffWork" + i));
                    if (String.IsNullOrEmpty(objOffWork.ToString()) == false)
                    {
                        DayOfWeek day;
                        if (Enum.IsDefined(typeof(DayOfWeek), objOffWork.ToString()))
                        {

                            double offWorkRate = (double)DynamicInvoker.DynamicGetValue(configInfo, configInfo.GetType().GetProperty("HRConfigOffWorkRate" + i));
                            day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), objOffWork.ToString(), true);
                            OffWorkDays.Add(day, offWorkRate);
                        }
                    }
                }
                #endregion

                #region TimeRounds

                for (int i = 1; i <= 9; i++)
                {
                    double timeRound = (double)DynamicInvoker.DynamicGetValue(configInfo, configInfo.GetType().GetProperty("HRConfigRound" + i));
                    if (timeRound >= 0)
                    {
                        TimeRounds.Add(timeRound);
                    }
                }

                TimeRounds.Sort();
                #endregion

                #region BreakTimeOfOTs

                BreakTimeOfOTs.Add(1.5, configInfo.HRConfigBreakOT150);
                BreakTimeOfOTs.Add(1.8, configInfo.HRConfigBreakOT180);
                BreakTimeOfOTs.Add(2.0, configInfo.HRConfigBreakOT200);
                BreakTimeOfOTs.Add(2.3, configInfo.HRConfigBreakOT230);
                BreakTimeOfOTs.Add(3.0, configInfo.HRConfigBreakOT300);

                #endregion

                ShiftPerMonth = configInfo.HRConfigShiftPerMonth;

                #region Seniority Salary
                SenioritySalarys = new SortedList<double, double>();
                DataSet ds = new HRSeniorityCfgsController().GetAllObjects();
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        HRSeniorityCfgsInfo SeniorityCfgInfo = (HRSeniorityCfgsInfo)new HRSeniorityCfgsController().GetObjectFromDataRow(dr);
                        if (SeniorityCfgInfo != null)
                        {
                            SenioritySalarys.Add(SeniorityCfgInfo.HRSeniorityCfgID, SeniorityCfgInfo.HRSeniorityCfgAmt);
                        }
                    }
                }
                #endregion

                DiligentSalary = configInfo.HRConfigDiligentAmt;
                RiceSalary = configInfo.HRConfigRiceAmt;
                UnionFee = configInfo.HRConfigUnionAmt;

                #region Tax
                MinimumInTax = configInfo.HRConfigMinimumInTaxAmt;

                HRInTaxRatesController inTaxRateCtrl = new HRInTaxRatesController();
                DataSet dsTax = inTaxRateCtrl.GetAllObjects();
                if (dsTax != null && dsTax.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow drowTax in dsTax.Tables[0].Rows)
                    {
                        HRInTaxRatesInfo taxRateInfo = (HRInTaxRatesInfo)inTaxRateCtrl.GetObjectFromDataRow(drowTax);
                        if (taxRateInfo != null)
                            InTaxRates.Add(taxRateInfo);
                    }
                }
                #endregion
            }
        }

        public static double CalculatePersonalIncomeTax(double personalTax)
        {
            if (personalTax <= 0)
                return 0;

            double percent = 100;
            HRInTaxRatesInfo taxRate = null;
            double totalTax = 0;

            foreach (HRInTaxRatesInfo taxRateInfo in InTaxRates)
            {
                if (taxRateInfo.HRInTaxFromAmt < personalTax && personalTax <= taxRateInfo.HRInTaxToAmt)
                {
                    percent = taxRateInfo.HRInTaxRatePct;
                    taxRate = taxRateInfo;
                    break;
                }
            }

            foreach (HRInTaxRatesInfo taxRateInfo in InTaxRates)
            {
                if (taxRate != null && taxRateInfo.HRInTaxFromAmt < taxRate.HRInTaxFromAmt)
                {
                    //Số tiền tính thuế TNCN
                    double dbThue = taxRateInfo.HRInTaxRatePct / 100 * (taxRateInfo.HRInTaxToAmt - taxRateInfo.HRInTaxFromAmt);

                    //personalTax -= dbThue;
                    totalTax += dbThue;
                }
            }
            //Tính phần lẻ rơi vào khung biểu suất tính thuế cuối cùng
            if (taxRate != null)
            {
                totalTax += (percent / 100 * (personalTax - taxRate.HRInTaxFromAmt));
            }
            return totalTax;
        }

        //public static double CalculateAllowanceAmt ( HREmployeeTCSrlsInfo objHREmployeeTCSrlsInfo , HREmployeeAllowancesInfo allowanceInfo ,HREmployeesInfo objEmployee , int IShiftInMonth )
        //{

        //if ( IShiftInMonth>=DONGHUNGUtil.ShiftPerMonth )
        //{
        //    return objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalShiftcount*( allowanceInfo.HREmployeeAllowanceAmt/IShiftInMonth );
        //}
        //else
        //{
        //    HRDepartmentsController deparmentCtrl=new HRDepartmentsController();
        //    HRDepartmentsInfo departmentInfo=(HRDepartmentsInfo)deparmentCtrl.GetObjectByID( objEmployee.FK_HRDepartmentID );
        //    if ( departmentInfo!=null&&departmentInfo.HRDepartmentNo.Equals( "VP" ) )
        //        return objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalShiftcount*( allowanceInfo.HREmployeeAllowanceAmt/IShiftInMonth );
        //    else
        //        return objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalShiftcount*( allowanceInfo.HREmployeeAllowanceAmt/DONGHUNGUtil.ShiftPerMonth );
        //}
        //}

        public static void CalculateContacAndWorkingSalary(ref double contractShiftSalary, ref double workingShiftSalary, double ContractSalaryAmt, int IShiftInMonth)
        {
            contractShiftSalary = ContractSalaryAmt / IShiftInMonth;
            if (contractShiftSalary == 0)
                contractShiftSalary = HRUtil.NoneContractSalary;
            workingShiftSalary = ContractSalaryAmt / IShiftInMonth;
        }

        //public static double CalculateDiligentSalary ( HREmployeeTCSrlsInfo objHREmployeeTCSrlsInfo , HREmployeesInfo objEmployee , int iRealShiftInMonth )
        //{

        //    HRDepartmentsController deparmentCtrl=new HRDepartmentsController();
        //    HRDepartmentsInfo departmentInfo=(HRDepartmentsInfo)deparmentCtrl.GetObjectByID( objEmployee.FK_HRDepartmentID );
        //    if ( departmentInfo!=null&&( departmentInfo.HRDepartmentNo.Equals( "VP" )||departmentInfo.Equals( "PTM" ) ) )
        //        return 0;
        //    if ( objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalOffWorkUnPermission>0 )
        //        return 0;
        //    if ( objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalLateInTimeCount2+objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalLateInTimeCount3+objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalLateInTimeCount4>=3 )
        //        return 0;
        //    if ( objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalLateInTimeCount3+objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalLateInTimeCount4>=2 )
        //        return 0;


        //    double diligentAmt=DiligentSalary/iRealShiftInMonth*objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalShiftcount;
        //    if ( objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalLateInTimeCount2==2 )
        //        diligentAmt-=( objHREmployeeTCSrlsInfo.HREmployeeTCSrlTotalLateInTimeCount2*10000 );

        //  return diligentAmt;
        //}
        /// <summary>
        /// Tính số ngày phải đi làm trong tháng
        /// </summary>
        /// <param name="objHREmployeeTCSrlsInfo"></param>
        /// <returns>Số ngày phải đi làm trong tháng</returns>
        public static int GetRealShiftInMonth(HREmployeeTCSrlsInfo objHREmployeeTCSrlsInfo)
        {
            int iDayCount = 0;
            for (DateTime currentDate = objHREmployeeTCSrlsInfo.HREmployeeTCSrlFromDatetime.Value.Date; currentDate <= objHREmployeeTCSrlsInfo.HREmployeeTCSrlToDatetime.Value.Date; currentDate = currentDate.AddDays(1))
            {
                if (HRUtil.OffWorkDays.ContainsKey(currentDate.DayOfWeek) == false)
                    iDayCount++;
            }

            return iDayCount;
        }

        public static int GetRealShiftInMonth(DateTime fromDate, DateTime toDate)
        {
            int iDayCount = 0;
            for (DateTime currentDate = fromDate; currentDate <= toDate; currentDate = currentDate.AddDays(1))
            {
                if (HRUtil.OffWorkDays.ContainsKey(currentDate.DayOfWeek) == false)
                    iDayCount++;
            }

            return iDayCount;
        }

        public static Boolean IsHolidayPerWeek(DayOfWeek day)
        {
            return OffWorkDays.Keys.Contains(day);
        }

        public static double GetRateByHolidayPerWeek(DayOfWeek day)
        {
            if (OffWorkDays.Keys.Contains(day))
                return OffWorkDays[day];
            return -1;
        }
        public static void SetHaveRiceToTimeCard(HREmployeeTimeCardsInfo timecardInfo, Boolean isHaveRice)
        {
            if (isHaveRice)
                timecardInfo.HREmployeeTimeCardBreakOT1 = HRUtil.BreakTimeOfOTs[1.5];
            else
                timecardInfo.HREmployeeTimeCardBreakOT1 = 0;

        }

        public static Boolean IsHaveRice(HREmployeeTimeCardsInfo timecardInfo)
        {
            return (timecardInfo.HREmployeeTimeCardBreakOT1 != 0);
        }

        public static double DONGHUNG_Round(double dbValue)
        {
            double dbTemp = Math.Round(dbValue, 0);
            if (dbTemp > dbValue)
                dbTemp -= 1;
            double dbTemp2 = dbValue - dbTemp;

            for (int i = 0; i < TimeRounds.Count - 1; i++)
            {
                if (TimeRounds[i] <= dbTemp2 && dbTemp2 < TimeRounds[i + 1])
                {
                    if (Math.Round(TimeRounds[i + 1] - dbTemp2, 3) > Math.Round(dbTemp2 - TimeRounds[i], 3))
                        dbTemp2 = TimeRounds[i];
                    else
                        dbTemp2 = TimeRounds[i + 1];
                }
            }

            double dbResult = GMCUtil.Round(dbTemp + dbTemp2, 3);
            //if ( dbResult<0.5 )
            //    dbResult=0;
            return dbResult;
        }
    }
    public class HR_Extra
    {
        #region Lấy số tiền phụ cấp của nhân viên theo hợp đồng và loại phụ cấp --Vinh --07/05/2013

        public static int iSoNgayDaTinhPhuCap = 0;

        public static double GetEmployeeAllowanceByTypeComboANDEmployeeContract(int iEmployeeID, int iEmployeeContractID, DateTime dtCurrentMonth, String strAllowanceTypeCombo, double dbCongPhaiLamCuaThang, double dbCongDaLamCuaThang, Boolean isTrying, int iSoNgayPhuCap)
        {
            HREmployeeAllowancesController objHREmployeeAllowanceCtrl = new HREmployeeAllowancesController();
            HRAllowanceRatesController objHRAllowanceRateCtrl = new HRAllowanceRatesController();
            double dbAllowanceAmt = 0;
            DataSet dsHREmployeeAllowances = objHREmployeeAllowanceCtrl.GetEmployeeAllowanceByEmployeeANDTypeComboANDEmployeeContract(iEmployeeID, iEmployeeContractID, strAllowanceTypeCombo, dtCurrentMonth);
            if (dsHREmployeeAllowances != null && dsHREmployeeAllowances.Tables.Count > 0)
            {
                List<BusinessObject> lstHREmployeeAllowances = objHREmployeeAllowanceCtrl.GetListFromDataset(dsHREmployeeAllowances);
                foreach (HREmployeeAllowancesInfo objHREmployeeAllowanceInfo in lstHREmployeeAllowances)
                {
                    HRAllowanceRatesInfo objHRAllowanceRateInfo = (HRAllowanceRatesInfo)objHRAllowanceRateCtrl.GetObjectByID(objHREmployeeAllowanceInfo.FK_HRAllowanceRateID);
                    if (objHRAllowanceRateInfo != null)
                    {
                        dbAllowanceAmt += GetAmtAllowance(objHREmployeeAllowanceInfo, objHRAllowanceRateInfo.HRAllowanceRateIsCalcShiftCntCheck, strAllowanceTypeCombo, dtCurrentMonth, dbCongPhaiLamCuaThang, dbCongDaLamCuaThang, isTrying, iSoNgayPhuCap);
                    }
                }
            }

            return dbAllowanceAmt;
        }

        public static double GetAmtAllowance(HREmployeeAllowancesInfo objHREmployeeAllowanceInfo, Boolean isHRAllowanceRateIsCalcShiftCntCheck, String strAllowanceTypeCombo, DateTime dtCurrentMonth, double dbCongPhaiLamCuaThang, double dbCongDaLamCuaThang, Boolean isTrying, int iSoNgayPhuCap)
        {
            double dbAllowanceAmt = 0;

            //Nếu phụ cấp tính theo công làm việc
            if (isHRAllowanceRateIsCalcShiftCntCheck)
            {
                dbAllowanceAmt = LaySoTienPhuCap(objHREmployeeAllowanceInfo, isHRAllowanceRateIsCalcShiftCntCheck, strAllowanceTypeCombo, dtCurrentMonth, dbCongPhaiLamCuaThang, dbCongDaLamCuaThang, isTrying, iSoNgayPhuCap);
            }
            //Nếu phụ cấp không tính theo công làm việc thì được hưởng trọn tiền phụ cấp tháng đó.
            else
            {
                dbAllowanceAmt = objHREmployeeAllowanceInfo.HREmployeeAllowanceAmt;
            }

            return dbAllowanceAmt;
        }

        #endregion

        public static double LaySoTienPhuCapCom(HREmployeeTCSrlDtlsInfo objHREmployeeTCSrlDtlInfo, double dbSoTienComMotCaLamThuong, Boolean isTangCa, ref int iSoPhuCap)
        {
            double dbAllowanceAmt = 0;
            if (isTangCa)
            {
                if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount > 0.5 &&
                    objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount <= 1.5)
                {
                    dbAllowanceAmt = dbSoTienComMotCaLamThuong;
                }
                else if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount > 1.5 &&
                         objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount <= 2.5)
                {
                    dbAllowanceAmt = dbSoTienComMotCaLamThuong * 2;
                }
            }
            else
            {
                //Nếu số công làm việc hay công tăng ca của nhân viên trong ngày nếu > 0.5  thì được hưởng 1 phụ cấp cơm thường --Vinh --02/10/2013
                if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount > 0.5 &&
                    objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount <= 1.5)
                {
                    dbAllowanceAmt = dbSoTienComMotCaLamThuong;
                    iSoPhuCap = 1;
                }
                //Nếu số công làm việc của nhân viên trong ngày nếu > 1.5  thì được hưởng 2 phụ cấp cơm thường --Vinh --02/10/2013
                else if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount > 1.5 &&
                         objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount <= 2.5)
                {
                    dbAllowanceAmt = dbSoTienComMotCaLamThuong * 2;
                    iSoPhuCap = 2;
                }
            }
            return dbAllowanceAmt;
        }

        public static double LaySoTienPhuCap(HREmployeeAllowancesInfo objHREmployeeAllowanceInfo, Boolean isHRAllowanceRateIsCalcShiftCntCheck, String strAllowanceTypeCombo, DateTime dtCurrentMonth, double dbCongPhaiLamCuaThang, double dbCongDaLamCuaThang, Boolean isTrying, int iSoNgayPhuCap)
        {
            HREmpActivitysController objHREmpActivityCtrl = new HREmpActivitysController();
            HREmployeeTCSrlDtlsController objHREmployeeTCSrlDtlCtrl = new HREmployeeTCSrlDtlsController();

            double dbSoNgayCongCuaThang = 26;
            double dbSoNgayTinhPhuCap = 0;
            double dbSoTienPhuCapThuong = 0;
            double dbSoTienPhuCapTangCa = 0;

            HREmployeesInfo objHREmployeeInfo = (HREmployeesInfo)new HREmployeesController().GetObjectByID(objHREmployeeAllowanceInfo.FK_HREmployeeID);
            if (objHREmployeeInfo == null)
            {
                return 0;
            }

            HRConfigsInfo ConfigInfo = (HRConfigsInfo)new HRConfigsController().GetFirstObject();
            if (ConfigInfo != null)
            {
                dbSoNgayCongCuaThang = ConfigInfo.HRConfigMinDayFullSalary;
            }

            double dbSoTienPhuCapMotCaLamThuong = GMCUtil.Round(objHREmployeeAllowanceInfo.HREmployeeAllowanceAmt / dbSoNgayCongCuaThang, GMCWebApp._systemCurrencyDecimal);
            int iSoPhuCap = 0;

            //Nếu NV làm tính theo lương tháng mà có số ngày nhận phụ cấp cơm > số ngày công phải làm thì được hưởng đúng bằng phụ cấp quy định.
            if (objHREmployeeInfo.HREmployeeSalaryCalcTypeCombo == ExpertERP.Procedure.HR.EmployeeProcedure.cstHREmployeeSalaryCalcTypeComboProfit)
            {
                if (dbCongDaLamCuaThang >= dbCongPhaiLamCuaThang)
                {
                    dbSoTienPhuCapThuong = objHREmployeeAllowanceInfo.HREmployeeAllowanceAmt;

                    for (DateTime dt = dtCurrentMonth; dt <= dtCurrentMonth.AddMonths(1).AddDays(-1); dt = dt.AddDays(1))
                    {
                        HREmployeeTCSrlDtlsInfo objHREmployeeTCSrlDtlInfo = objHREmployeeTCSrlDtlCtrl.GetEmployeeTCSrlDtlByEmployeeANDDate(objHREmployeeInfo.HREmployeeID, dt);
                        if (objHREmployeeTCSrlDtlInfo != null &&
                           (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlWorkingHour + objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeHour) > 0 &&
                           (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount + objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount) > 0)
                        {
                            if (strAllowanceTypeCombo == ExpertERP.Procedure.HR.BonusAllowanceProcedure.cstRice)
                            {
                                dbSoTienPhuCapTangCa += LaySoTienPhuCapCom(objHREmployeeTCSrlDtlInfo, dbSoTienPhuCapMotCaLamThuong, true, ref iSoPhuCap);
                            }
                            else
                            {
                                dbSoTienPhuCapTangCa += LaySoTienPhuCapTheoNgay(objHREmployeeTCSrlDtlInfo, dbSoTienPhuCapMotCaLamThuong, true, ref iSoPhuCap);
                            }
                        }
                    }
                    return dbSoTienPhuCapThuong + dbSoTienPhuCapTangCa;
                }
            }

            for (DateTime dt = dtCurrentMonth; dt <= dtCurrentMonth.AddMonths(1).AddDays(-1); dt = dt.AddDays(1))
            {
                HREmployeeTCSrlDtlsInfo objHREmployeeTCSrlDtlInfo = objHREmployeeTCSrlDtlCtrl.GetEmployeeTCSrlDtlByEmployeeANDDate(objHREmployeeInfo.HREmployeeID, dt);
                if (objHREmployeeTCSrlDtlInfo != null &&
                   (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlWorkingHour + objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeHour) > 0 &&
                   (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount + objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount) > 0)
                {
                    double dbSoTiemPhuCapNgayThuong = 0, dbSoTienPhuCapNgayTangCa = 0;
                    iSoPhuCap = 0;
                    //Nếu phụ cấp cơm
                    if (strAllowanceTypeCombo == ExpertERP.Procedure.HR.BonusAllowanceProcedure.cstRice)
                    {
                        dbSoTiemPhuCapNgayThuong = LaySoTienPhuCapCom(objHREmployeeTCSrlDtlInfo, dbSoTienPhuCapMotCaLamThuong, false, ref iSoPhuCap);
                        dbSoTienPhuCapNgayTangCa = LaySoTienPhuCapCom(objHREmployeeTCSrlDtlInfo, dbSoTienPhuCapMotCaLamThuong, true, ref iSoPhuCap);
                    }
                    //Nếu số công làm việc hay công tăng ca của nhân viên trong ngày nếu >= 0.5 thì được hưởng 1 phụ cấp cơm thường --Vinh --02/10/2013
                    else
                    {
                        dbSoTiemPhuCapNgayThuong = LaySoTienPhuCapTheoNgay(objHREmployeeTCSrlDtlInfo, dbSoTienPhuCapMotCaLamThuong, false, ref iSoPhuCap);
                        dbSoTienPhuCapNgayTangCa = LaySoTienPhuCapTheoNgay(objHREmployeeTCSrlDtlInfo, dbSoTienPhuCapMotCaLamThuong, true, ref iSoPhuCap);
                    }

                    if (isTrying == objHREmpActivityCtrl.CheckEmployeeTrying(objHREmployeeTCSrlDtlInfo.FK_HREmployeeID, (DateTime)objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlStartDatetime))
                    {
                        if (dbSoTiemPhuCapNgayThuong > 0)
                        {
                            dbSoNgayTinhPhuCap++;
                            iSoNgayDaTinhPhuCap += iSoPhuCap;
                            dbSoTienPhuCapThuong += dbSoTiemPhuCapNgayThuong;
                        }
                        if (dbSoTienPhuCapNgayTangCa > 0)
                        {
                            dbSoTienPhuCapTangCa += dbSoTienPhuCapNgayTangCa;
                        }
                    }
                }
            }

            //Nếu số ngày được hưởng phụ cấp = số ngày công làm của tháng thì được tính trọn lương tháng
            //Nếu số tiền phụ cấp thực nhận lớn hơn số tiền theo qui định thì lấy bằng số tiền theo qui định.
            if (dbSoNgayTinhPhuCap == dbSoNgayCongCuaThang || dbSoTienPhuCapThuong > objHREmployeeAllowanceInfo.HREmployeeAllowanceAmt)
            {
                dbSoTienPhuCapThuong = objHREmployeeAllowanceInfo.HREmployeeAllowanceAmt;
            }

            if (iSoNgayDaTinhPhuCap + iSoNgayPhuCap > dbSoNgayCongCuaThang)
            {
                dbSoTienPhuCapThuong = dbSoTienPhuCapThuong - (iSoNgayDaTinhPhuCap + iSoNgayPhuCap - dbSoNgayCongCuaThang) * dbSoTienPhuCapMotCaLamThuong;
            }

            return dbSoTienPhuCapThuong + dbSoTienPhuCapTangCa;
        }

        public static double LaySoTienPhuCapTheoNgay(HREmployeeTCSrlDtlsInfo objHREmployeeTCSrlDtlInfo, double dbSoTienPhuCapMotCaLamThuong, Boolean isTangCa, ref int iSoPhuCap)
        {
            double dbSoTiemPhuCapNgay = 0;
            if (isTangCa)
            {
                if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount >= 0.5 &&
                    objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount < 1.5)
                {
                    dbSoTiemPhuCapNgay = dbSoTienPhuCapMotCaLamThuong;
                }
                //Nếu số công làm việc hay công tăng ca của nhân viên trong ngày nếu >= 1.5 thì được hưởng 2 phụ cấp thường --Vinh --02/10/2013
                else if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount >= 1.5 &&
                         objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlOvertimeShiftCount < 2.5)
                {
                    dbSoTiemPhuCapNgay = dbSoTienPhuCapMotCaLamThuong * 2;
                }
            }
            else
            {
                if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount >= 0.5 &&
                    objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount < 1.5)
                {
                    dbSoTiemPhuCapNgay = dbSoTienPhuCapMotCaLamThuong;
                    iSoPhuCap = 1;
                }
                //Nếu số công làm việc hay công tăng ca của nhân viên trong ngày nếu >= 1.5 và < 2.5 thì được hưởng 2 phụ cấp thường --Vinh --02/10/2013
                else if (objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount >= 1.5 &&
                         objHREmployeeTCSrlDtlInfo.HREmployeeTCSrlDtlShiftCount < 2.5)
                {
                    dbSoTiemPhuCapNgay = dbSoTienPhuCapMotCaLamThuong * 2;
                    iSoPhuCap = 2;
                }
            }
            return dbSoTiemPhuCapNgay;
        }

        public static Boolean KiemTraNghiPhepChinhThucCuaNhanVien(HREmployeesInfo objHREmployeeInfo, DateTime dtCurrentDay)
        {
            if (objHREmployeeInfo.HREmployeeTCSlrTypeCombo == ExpertERP.Procedure.HR.EmployeeSalaryProcedure.cstLoaiTinhCongDefault)
            {
                return ExpertERP.Procedure.HR.BonusAllowanceProcedure.KiemTraCoPhaiNgayNghiTrongTuan(dtCurrentDay);
            }
            else if (objHREmployeeInfo.HREmployeeTCSlrTypeCombo == ExpertERP.Procedure.HR.EmployeeSalaryProcedure.cstLoaiTinhCongTheoBangXepCa)
            {
                if (ExpertERP.Procedure.HR.BonusAllowanceProcedure.KiemTraCoPhaiNgayNghiTrongBangXepCa(dtCurrentDay, objHREmployeeInfo.HREmployeeID))
                {
                    return true;
                }
            }
            return false;
        }

        #region Lấy số tiền phụ cấp của nhân viên trong biến động tiền lương --Vinh --07/05/2013

        public static double GetEmployeeBonusAllowanceByTypeComboANDEmployee(int iHREmployeeID, DateTime dtCurrentMonth,int iPayrollTypeID)
        {
            HRBonusAllowanceItemsController objHRBonusAllowanceItemCtrl = new HRBonusAllowanceItemsController();
            HREmpActivitysController objHREmpActivityCtrl = new HREmpActivitysController();
            double dbAllowanceAmt = 0;
            //Biến động tăng-giảm
            DataSet dsHRBonusAllowances = objHRBonusAllowanceItemCtrl.GetAllBonusByEmployeeANDStatusANDDate(iHREmployeeID, iPayrollTypeID, dtCurrentMonth);// "Upward", "Reduce";
            if (dsHRBonusAllowances != null && dsHRBonusAllowances.Tables.Count > 0 && dsHRBonusAllowances.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in dsHRBonusAllowances.Tables[0].Rows)
                {
                    if (dr["HRBonusAllowanceTypeCombo"].ToString() == "Upward")
                        dbAllowanceAmt += Convert.ToDouble(dr["HRBonusAllowanceItemAmt"]);

                    if (dr["HRBonusAllowanceTypeCombo"].ToString() == "Reduce")
                        dbAllowanceAmt -= Convert.ToDouble(dr["HRBonusAllowanceItemAmt"]);
                }
            }
            return dbAllowanceAmt;
        }

        #endregion

        #region Tinh số ngày làm việc trong tháng (Công chuẩn)=tổng số ngày của tháng-số ngày nghỉ V.Việt
        public static double LaySoCongChuan(HREmployeesInfo objEmployee, DateTime dtFdate, DateTime dtTdate)
        {
            HRConfigsController objHRConfigsCtrl = new HRConfigsController();
            if (objEmployee.HREmployeeStdWorkdayTypeCombo == "Day")
            {
                string strType = objHRConfigsCtrl.LayLoaiCongChuan();
                if (strType == "Fix")
                {
                    HRConfigsInfo objHRConfig = (HRConfigsInfo)objHRConfigsCtrl.GetFirstObject();
                    if (objHRConfig != null)
                    {
                        return objHRConfig.HRConfigMinDayFullSalary;
                    }
                }
                if (strType == "Cal")
                {
                    HRDayOfWeeksController objDayOfWeekCtrl = new HRDayOfWeeksController();
                    DataSet ds = objDayOfWeekCtrl.LayCacNgayNghiTrongTuan();
                    List<BusinessObject> lst = objDayOfWeekCtrl.GetListFromDataset(ds);

                    int iSongayNghi = 0;
                    for (int iDay = 0; iDay <= (dtTdate - dtFdate).TotalDays; iDay++)
                    {
                        DateTime dtCurrent = dtFdate.AddDays(iDay);
                        foreach (HRDayOfWeeksInfo item in lst)
                        {
                            if (item != null)
                            {
                                if (item.HRDayOfWeekNo.ToUpper() == dtCurrent.DayOfWeek.ToString().ToUpper())
                                    iSongayNghi++;
                            }
                        }
                    }
                    return (int)(dtTdate - dtFdate).TotalDays + 1 - iSongayNghi;
                }
            }
            else if (objEmployee.HREmployeeStdWorkdayTypeCombo == "Limit")
            {
                return objEmployee.HREmloyeeStdWorkDay;
            }

            return 0;
        }
        public static double LayHanMucCong(HREmployeesInfo objEmployee,DateTime  dtFdate, DateTime dtTdate)
        {
            HRConfigsController objHRConfigsCtrl = new HRConfigsController();
            if (objEmployee.HREmployeeStdWorkdayTypeCombo == "Day")
            {
                string strType = objHRConfigsCtrl.LayLoaiCongChuan();
                if (strType == "Fix")
                {
                    HRConfigsInfo objHRConfig = (HRConfigsInfo)objHRConfigsCtrl.GetFirstObject();
                    if (objHRConfig != null)
                    {
                        return objHRConfig.HRConfigMinDayFullSalary;
                    }
                }
                if (strType == "Cal")
                {
                    HRDayOfWeeksController objDayOfWeekCtrl = new HRDayOfWeeksController();
                    DataSet ds = objDayOfWeekCtrl.LayCacNgayNghiTrongTuan();
                    List<BusinessObject> lst = objDayOfWeekCtrl.GetListFromDataset(ds);

                    int iSongayNghi = 0;
                    for (int iDay = 0; iDay <= (dtTdate - dtFdate).TotalDays; iDay++)
                    {
                        DateTime dtCurrent = dtFdate.AddDays(iDay);
                        foreach (HRDayOfWeeksInfo item in lst)
                        {
                            if (item != null)
                            {
                                if (item.HRDayOfWeekNo.ToUpper() == dtCurrent.DayOfWeek.ToString().ToUpper())
                                    iSongayNghi++;
                            }
                        }
                    }
                    return (int)(dtTdate - dtFdate).TotalDays + 1 - iSongayNghi;
                }
            }
            else if (objEmployee.HREmployeeStdWorkdayTypeCombo == "Limit")
            {
                return objEmployee.HREmployeeCeilingWorkDay;
            }

            return 0;
        }
        #endregion
        public static int SoThangLamviec(DateTime dtEnd, DateTime dtStart)
        {
            TimeSpan ts = (dtEnd - dtStart);
            double dbSoThang = ts.TotalDays * 12 / 365.25;
            return (int)dbSoThang;
        }
        public static double LamTronPhep(double dbsoPhep)
        {
            double dbPhanDu = 0, dbKQ = 0; ;
            dbPhanDu = dbsoPhep % 1;
            dbPhanDu = dbPhanDu * 10;
            if (dbPhanDu > 5)
            {
                dbKQ = (int)dbsoPhep + 1;
            }
            else
            {
                if (dbPhanDu == 5)
                    dbKQ = (int)dbsoPhep + 0.5;
                else
                    dbKQ = (int)dbsoPhep;
            }
            return dbKQ;
        }

        public static double SoThangLamviecDenLucNghi(DateTime dtEnd, DateTime dtStart)
        {
            double dbSoThang = (dtEnd.Year * 12 + dtEnd.Month) - (dtStart.Year * 12 + dtStart.Month);
            if (dtEnd.Day > 15)
                dbSoThang = dbSoThang + 1;
            else
                dbSoThang = dbSoThang + 0.5;
            return dbSoThang;
        }
    }

    public class HR_CalculateEmployeeLeave
    {
        public static Boolean LayThoiGianNghiPhepTrongThang(DateTime dtFirstDayOfMonth, HREmployeeOffWorksInfo objHREmployeeOffWorkInfo, ref DateTime dtOffWorkInMonthFrom, ref DateTime dtOffWorkInMonthTo)
        {
            dtOffWorkInMonthFrom = (DateTime)objHREmployeeOffWorkInfo.HREmployeeOffWorkFromDate;
            dtOffWorkInMonthTo = (DateTime)objHREmployeeOffWorkInfo.HREmployeeOffWorkToDate;
            if ((dtOffWorkInMonthFrom.Year * 12 + dtOffWorkInMonthFrom.Month <= dtFirstDayOfMonth.Year * 12 + dtFirstDayOfMonth.Month) &&
                (dtOffWorkInMonthTo.Year * 12 + dtOffWorkInMonthTo.Month >= dtFirstDayOfMonth.Year * 12 + dtFirstDayOfMonth.Month))
            {
                if (dtOffWorkInMonthFrom < dtFirstDayOfMonth)
                {
                    dtOffWorkInMonthFrom = dtFirstDayOfMonth;
                }
                if (dtOffWorkInMonthTo > dtFirstDayOfMonth.AddMonths(1).AddDays(-1))
                {
                    dtOffWorkInMonthTo = dtFirstDayOfMonth.AddMonths(1).AddDays(-1);
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public static List<HREmployeeOffWorksInfo> LayTatCaDangKyNghiPhepNamCuaNhanVien(int iHREmployeeID, DateTime dtFrom, DateTime dtTo)
        {

            HREmployeeOffWorksController objHREmployeeOffWorkCtrl = new HREmployeeOffWorksController();
            List<HREmployeeOffWorksInfo> lstHREmployeeOffWorks = new List<HREmployeeOffWorksInfo>();
            DataSet dsHREmployeeOffWork = objHREmployeeOffWorkCtrl.GetAllDataByEmployeeLeaveFromToByLeaveType(iHREmployeeID, dtFrom, dtTo, EmployeeOffWorkProcedure.cstHREmployeeLeaveTypeNameComboAnnualLeave);//loại là phép năm
            if (dsHREmployeeOffWork != null && dsHREmployeeOffWork.Tables.Count > 0)
            {
                List<BusinessObject> lstHREmployeeOffworkTemp = objHREmployeeOffWorkCtrl.GetListFromDataset(dsHREmployeeOffWork);
                foreach (HREmployeeOffWorksInfo objHREmployeeOffWorkInfo in lstHREmployeeOffworkTemp)
                {
                    if (objHREmployeeOffWorkInfo != null)
                    {
                        lstHREmployeeOffWorks.Add(objHREmployeeOffWorkInfo);
                    }
                }
            }
            return lstHREmployeeOffWorks;
        }
        public static double TinhSoNgayNghiCuaNhanVienTheoThang(HREmployeesInfo objHREmployeeInfo, HREmployeeOffWorksInfo objHREmployeeOffWorkInfo, DateTime dtOffWorkFrom, DateTime dtOffWorkTo, String strHRTCSrlTypeCombo, int iHREmployeeLeaveTypeID)
        {
            double dbSoNgayDaNghi = 0;
            for (int i = 0; i <= (dtOffWorkTo - dtOffWorkFrom).TotalDays; i++)
            {
                DateTime dtCurrentDay = dtOffWorkFrom.AddDays(i);

                if (Procedure.HR.HR_Extra.KiemTraNghiPhepChinhThucCuaNhanVien(objHREmployeeInfo, dtCurrentDay))
                {
                    continue;
                }
                else
                {
                    double dbSoNgayNghi = 1;
                    if (objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays > 0 && objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays <= 1)
                    {
                        dbSoNgayNghi = objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays;
                    }

                    if (dbSoNgayNghi + dbSoNgayDaNghi <= objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays)
                    {
                        dbSoNgayDaNghi += dbSoNgayNghi;

                    }
                }
            }
            return dbSoNgayDaNghi;
        }


        public static double TinhSoNgayNghiPhepNamChoNhanVienTrongThang(HREmployeesInfo objHREmployeeInfo, DateTime dtFirstDayOfMonth)
        {
            double dbTongngaynghi = 0;
            List<HREmployeeOffWorksInfo> lstHREmployeeOffWorks = LayTatCaDangKyNghiPhepNamCuaNhanVien(objHREmployeeInfo.HREmployeeID, dtFirstDayOfMonth, dtFirstDayOfMonth.AddMonths(1).AddDays(-1));
            foreach (HREmployeeOffWorksInfo objHREmployeeOffWorkInfo in lstHREmployeeOffWorks)
            {
                DateTime dtOffWorkFrom = DateTime.Now, dtOffWorkTo = DateTime.Now;
                if (LayThoiGianNghiPhepTrongThang(dtFirstDayOfMonth, objHREmployeeOffWorkInfo, ref dtOffWorkFrom, ref dtOffWorkTo) == false)
                {
                    return 0;
                }

                HREmployeeLeaveTypesInfo objHREmployeeLeaveTypeInfo = (HREmployeeLeaveTypesInfo)new HREmployeeLeaveTypesController().GetObjectByID(objHREmployeeOffWorkInfo.FK_HREmployeeLeaveTypeID);
                if (objHREmployeeLeaveTypeInfo != null)
                {
                    double dbSoNgayNghi = TinhSoNgayNghiCuaNhanVienTheoThang(objHREmployeeInfo, objHREmployeeOffWorkInfo,
                                                                    dtOffWorkFrom, dtOffWorkTo,
                                                                    objHREmployeeOffWorkInfo.HREmployeeOffWorkTypeCombo,
                                                                    objHREmployeeLeaveTypeInfo.HREmployeeLeaveTypeID);
                    dbTongngaynghi += dbSoNgayNghi;
                }
            }
            return dbTongngaynghi;
        }
        public static double TinhSoNgayNghiPhepNamChoNhanVienTudauThangDenNgayTrongThang(HREmployeesInfo objHREmployeeInfo, DateTime dtFirstDayOfMonth, DateTime dteTodate)
        {
            double dbTongngaynghi = 0;
            List<HREmployeeOffWorksInfo> lstHREmployeeOffWorks = LayTatCaDangKyNghiPhepNamCuaNhanVien(objHREmployeeInfo.HREmployeeID, dtFirstDayOfMonth, dteTodate);
            foreach (HREmployeeOffWorksInfo objHREmployeeOffWorkInfo in lstHREmployeeOffWorks)
            {
                DateTime dtOffWorkFrom = DateTime.Now, dtOffWorkTo = DateTime.Now;
                if (LayThoiGianNghiPhepTrongThang(dtFirstDayOfMonth, objHREmployeeOffWorkInfo, ref dtOffWorkFrom, ref dtOffWorkTo) == false)
                {
                    return 0;
                }

                HREmployeeLeaveTypesInfo objHREmployeeLeaveTypeInfo = (HREmployeeLeaveTypesInfo)new HREmployeeLeaveTypesController().GetObjectByID(objHREmployeeOffWorkInfo.FK_HREmployeeLeaveTypeID);
                if (objHREmployeeLeaveTypeInfo != null)
                {
                    double dbSoNgayNghi = TinhSoNgayNghiCuaNhanVienTuNgayDenngay(dtFirstDayOfMonth, dteTodate, objHREmployeeInfo, objHREmployeeOffWorkInfo,
                                                                    dtOffWorkFrom, dtOffWorkTo,
                                                                    objHREmployeeOffWorkInfo.HREmployeeOffWorkTypeCombo,
                                                                    objHREmployeeLeaveTypeInfo.HREmployeeLeaveTypeID);
                    dbTongngaynghi += dbSoNgayNghi;
                }
            }
            return dbTongngaynghi;
        }

        public static double TinhSoNgayNghiCuaNhanVienTuNgayDenngay(DateTime dtFromdate, DateTime dteTodate, HREmployeesInfo objHREmployeeInfo, HREmployeeOffWorksInfo objHREmployeeOffWorkInfo, DateTime dtOffWorkFrom, DateTime dtOffWorkTo, String strHRTCSrlTypeCombo, int iHREmployeeLeaveTypeID)
        {
            double dbSoNgayDaNghi = 0;
            for (int i = 0; i <= (dtOffWorkTo - dtOffWorkFrom).TotalDays; i++)
            {
                DateTime dtCurrentDay = dtOffWorkFrom.AddDays(i);
                if (dtCurrentDay < dtFromdate || dtCurrentDay > dteTodate) continue;

                if (Procedure.HR.HR_Extra.KiemTraNghiPhepChinhThucCuaNhanVien(objHREmployeeInfo, dtCurrentDay))
                {
                    continue;
                }
                else
                {
                    double dbSoNgayNghi = 1;
                    if (objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays > 0 && objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays <= 1)
                    {
                        dbSoNgayNghi = objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays;
                    }

                    if (dbSoNgayNghi + dbSoNgayDaNghi <= objHREmployeeOffWorkInfo.HREmployeeOffWorkRegDays)
                    {
                        dbSoNgayDaNghi += dbSoNgayNghi;

                    }
                }
            }
            return dbSoNgayDaNghi;
        }
        public static double TinhSongayNghiDauNamDenHienTai(HREmployeesInfo objHREmployeeInfo, DateTime dtTodate)
        {
            double dbnumber = 0;
            // if (dtTodate.Month == 1) return 0;
            //  dbnumber=new HREmployeeLRegsController().TinhSoNgayNghiTuThangDenThangTrongNam(objHREmployeeInfo.HREmployeeID,1, dtFirstDayOfMonth.AddMonths(-1).Month, dtFirstDayOfMonth.Year);
            DateTime dtFirstDayOfMonthCal;
            for (int i = 1; i < dtTodate.Month; i++) //tổng số ngày nghỉ đến trước tháng hiện tại
            {
                dtFirstDayOfMonthCal = new DateTime(dtTodate.Year, i, 1);
                dbnumber += Procedure.HR.HR_CalculateEmployeeLeave.TinhSoNgayNghiPhepNamChoNhanVienTrongThang(objHREmployeeInfo, dtFirstDayOfMonthCal);
            }
            dtFirstDayOfMonthCal = new DateTime(dtTodate.Year, dtTodate.Month, 1); //Tổng ngày nghỉ của tháng đang xem, tính tới ngày xem hiện tại
            dbnumber += Procedure.HR.HR_CalculateEmployeeLeave.TinhSoNgayNghiPhepNamChoNhanVienTudauThangDenNgayTrongThang(objHREmployeeInfo, dtFirstDayOfMonthCal, dtTodate);
            return dbnumber;
        }
    }

}
