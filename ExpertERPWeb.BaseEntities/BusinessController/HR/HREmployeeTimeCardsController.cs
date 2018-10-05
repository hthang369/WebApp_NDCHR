using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HREmployeeTimeCards
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:HREmployeeTimeCardsController
    //Created Date:09 Tháng Giêng 2013
    //-----------------------------------------------------------

    public class HREmployeeTimeCardsController : BaseBusinessController
    {
        public HREmployeeTimeCardsController()
        {
            dal = new DALBaseProvider("HREmployeeTimeCards", typeof(HREmployeeTimeCardsInfo));
        }

        #region Copy From PS --Vinh --10/01/2013

        public DataSet dsGetDataFromTimeCards(DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            return dal.GetDataSet("AAA_dsTimeCard", dtStartDateTime, dtEndDateTime);
        }

        public DataSet dsDeleteAll_WithTime(DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            return dal.GetDataSet("AAA_TimeCard_DeleteWithTime", dtStartDateTime, dtEndDateTime);
        }

        public DataSet GetAllTimeCard_WithTimeAndEmpID(int iEmpID, DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            String str = String.Format(@"   SELECT * FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus='Alive'
                                            AND (FK_HREmployeeID={0} OR {0} = 0)
                                            AND CONVERT(NVARCHAR(10),HREmployeeTimeCardInDateTime,112) >= CONVERT(NVARCHAR(10),'{1}',112)
                                            AND CONVERT(NVARCHAR(10),HREmployeeTimeCardInDateTime,112) <= CONVERT(NVARCHAR(10),'{2}',112)
                                            ", iEmpID, dtStartDateTime.ToString("yyyyMMdd"), dtEndDateTime.ToString("yyyyMMdd"));
            //dal.GetDataSet("AAA_dsTimeCard_WithTimeAndEmpID", iEmpID, dtStartDateTime, dtEndDateTime);
            return dal.GetDataSet(str);
        }

        public DataSet GetAllTimeCard_WithMonthAndYearAndEmpID(int iEmpID, int imonth, int iyear)
        {
            return dal.GetDataSet("AAA_dsTimeCard_WithMonthAndYearAndEmpID", iEmpID, imonth, iyear);
        }

        public DataSet DeleteAllTimeCard_WithMonthAndYearAndEmpID(int iEmpID, int imonth, int iyear)
        {
            return dal.GetDataSet("AAA_dsTimeCard_DeleteWithMonthAndYearAndEmpID", iEmpID, imonth, iyear);
        }

        public DataSet DeleteAllTimeCard_WithTimeAndEmpID(int iEmpID, DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            return dal.GetDataSet("AAA_dsTimeCard_DeleteWithTimeAndEmpID", iEmpID, dtStartDateTime, dtEndDateTime);
        }

        //  [8/14/2009 namtrung]
        public DataSet GetTimeCardByEmployeeIDAndExtractStartDate(int iEmployeeID, DateTime dtDate)
        {
            return dal.GetDataSet("HREmployeeTimeCards_SelectByFK_EmployeeIDAndExtractStartDate", iEmployeeID, dtDate);
        }

        public DataSet GetTimeCardByEmployeeIDAndTimeSpan(int iEmployeeID, DateTime dtFromDate, DateTime dtToDate)
        {
            return dal.GetDataSet("HREmployeeTimeCards_GetTimeCardByEmployeeIDAndTimeSpan", iEmployeeID, dtFromDate, dtToDate);
        }

        public DataSet DeleteAllTimeCardByEmployeeIDAndTimeSpan(int iEmployeeID, DateTime dtFromDate, DateTime dtToDate)
        {
            return dal.GetDataSet("HREmployeeTimeCards_DeleteAllTimeCardByEmployeeIDAndTimeSpan", iEmployeeID, dtFromDate, dtToDate);
        }

        #endregion

        #region GetDataByDateTime --Vinh --01/02/2013 --Kiểm tra nhân viên ngày hôm đó có chấm công hay chưa, Trả về chấm công hôm đó nếu có.

        public HREmployeeTimeCardsInfo GetDataByTime(int iEmployeeID, DateTime dtStart, DateTime dtEnd, int iEmployeeTimeCardOldID)
        {
            String str = String.Format(@"SELECT * FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus='Alive'
                                            AND HREmployeeTimeCardID != {3}
                                            AND FK_HREmployeeID={0}
                                            AND (
                                                      (
                                                        CONVERT(VARCHAR,HREmployeeTimeCardStartDateTime,120) > '{1}'
                                                        AND 
                                                        CONVERT(VARCHAR,HREmployeeTimeCardStartDateTime,120) < '{2}'
                                                      )
                                                      OR
                                                      (
                                                        CONVERT(VARCHAR,HREmployeeTimeCardEndDateTime,120) > '{1}'
                                                        AND 
                                                        CONVERT(VARCHAR,HREmployeeTimeCardEndDateTime,120) < '{2}'
                                                       )
                                                 )", iEmployeeID, dtStart.ToString("yyyy-MM-dd HH:mm:ss"), dtEnd.ToString("yyyy-MM-dd HH:mm:ss"), iEmployeeTimeCardOldID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (HREmployeeTimeCardsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public HREmployeeTimeCardsInfo GetDataByTime(int iEmployeeID, DateTime dtStart, DateTime dtEnd)
        {
            String str = String.Format(@"SELECT * FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus='Alive'
                                            AND FK_HREmployeeID={0}
                                            AND CONVERT(VARCHAR,HREmployeeTimeCardStartDateTime,120) >= '{1}'
                                            AND CONVERT(VARCHAR,HREmployeeTimeCardEndDateTime,120) <= '{2}'
                                            ", iEmployeeID, dtStart.ToString("yyyy-MM-dd HH:mm:ss"), dtEnd.ToString("yyyy-MM-dd HH:mm:ss"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (HREmployeeTimeCardsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        #endregion

        #region Get All Data By Employee, Department, Session, Date --Vinh --12/03/2013

        public DataSet GetAllTimeCard_WithEmpIDDepartmentSession(int iEmpID, int iDepartmentID, int iSessionID, DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            String str = String.Format(@"   SELECT * FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus='Alive'
                                            AND (FK_HREmployeeID={0} OR {0} = 0)
                                            AND CONVERT(NVARCHAR(10),HREmployeeTimeCardInDateTime,112) >= CONVERT(NVARCHAR(10),'{1}',112)
                                            AND CONVERT(NVARCHAR(10),HREmployeeTimeCardInDateTime,112) <= CONVERT(NVARCHAR(10),'{2}',112)
                                            AND FK_HREmployeeID IN (SELECT HREmployeeID FROM HREmployees WHERE AAStatus='Alive' AND (FK_HRDepartmentID = {3} OR {3} = 0) AND (FK_HRSectionID = {4} OR {4} = 0))
                                            ", iEmpID, dtStartDateTime.ToString("yyyyMMdd"), dtEndDateTime.ToString("yyyyMMdd"), iDepartmentID, iSessionID);
            return dal.GetDataSet(str);
        }

        #endregion

        #region Lấy danh sách chấm công của nhân viên theo ngày làm và theo ca làm việc -- Vinh

        public DataSet GetDataByEmployeeANDDateANDShift(int iEmployeeID, int iShiftID, DateTime dt)
        {
            String str = String.Format(@"   SELECT * FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus='Alive'
                                            AND FK_HREmployeeID IN (SELECT HREmployeeID FROM HREmployees WHERE AAStatus='Alive' AND (HREmployeeID={0} OR {0} = 0))
                                            AND (FK_HRShiftID={1} OR {1} = 0)
                                            AND CONVERT(VARCHAR,HREmployeeTimeCardInDateTime,112) = CONVERT(VARCHAR,'{2}',112)                                       
                                            ", iEmployeeID, iShiftID, dt.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        #endregion

        public int DemSoNgayChamCom(int iEmployeeID, DateTime dteFromdate, DateTime dteTodate)
        {
            String str = String.Format(@"SELECT COUNT(*) FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus = 'Alive'
                                            AND FK_HREmployeeID IN(SELECT HREmployeeID FROM HREmployees WHERE AAStatus = 'Alive' AND(HREmployeeID ={0} OR {0} = 0))
                                            AND HREmployeeTimeCardRiceCheck = 1
                                            AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) >= CONVERT(NVARCHAR(10), '{1}', 112)
                                            AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) <= CONVERT(NVARCHAR(10), '{2}', 112)", iEmployeeID, dteFromdate.ToString("yyyyMMdd"), dteTodate.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public HREmployeeTimeCardsInfo GetEmployeeTimeCardByIdAndInDatetime(int iEmployeeID, DateTime dtInDatetime)
        {
            String str = String.Format(@"SELECT * FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus='Alive'
                                            AND FK_HREmployeeID={0}
                                            AND CONVERT(VARCHAR,HREmployeeTimeCardInDateTime,112)= '{1}'
                                            ", iEmployeeID, dtInDatetime.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (HREmployeeTimeCardsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        public DataSet GetAllEmployeeTimeCardByFDateTDate(DateTime dteFromdate, DateTime dteTodate)
        {
            String str = String.Format(@"SELECT * FROM dbo.HREmployeeTimeCards
                                            WHERE AAStatus = 'Alive'
                                            AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) >= CONVERT(NVARCHAR(10), '{0}', 112)
                                            AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) <= CONVERT(NVARCHAR(10), '{1}', 112)", dteFromdate.ToString("yyyyMMdd"), dteTodate.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }
        public int CountEmployeeTimeCardByValueBySymbolFDateTDate( int iEmployeeID,string strSymbol,DateTime dteFromdate, DateTime dteTodate)
        {
            String str = String.Format(@"SELECT COUNT(HREmployeeTimeCardValue)
                                         FROM dbo.HREmployeeTimeCards
                                         WHERE AAStatus='Alive'
                                         AND FK_HREmployeeID={0}
                                         AND HREmployeeTimeCardValue='{1}'
                                         AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) >= CONVERT(NVARCHAR(10), '{2}', 112)
                                         AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) <= CONVERT(NVARCHAR(10), '{3}', 112)", iEmployeeID, strSymbol, dteFromdate.ToString("yyyyMMdd"), dteTodate.ToString("yyyyMMdd"));
            DataSet ds= dal.GetDataSet(str);
            if(ds!=null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0)
            {
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public DataSet GetAllEmployeeTimeCardValueByFDateTDate(int iEmployeeID, DateTime dteFromdate, DateTime dteTodate)
        {
            String str = String.Format(@"SELECT UPPER(HREmployeeTimeCardValue) AS 'type' ,
                                                COUNT(UPPER(HREmployeeTimeCardValue)) AS 'value'
                                        FROM dbo.HREmployeeTimeCards
                                        WHERE AAStatus='Alive' AND FK_HRTimeKeepingSymbolID>0
                                            AND FK_HREmployeeID={0}
                                         AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) >= CONVERT(NVARCHAR(10), '{1}', 112)
                                         AND CONVERT(NVARCHAR(10), HREmployeeTimeCardInDateTime, 112) <= CONVERT(NVARCHAR(10), '{2}', 112)
                                        GROUP BY UPPER(HREmployeeTimeCardValue)", iEmployeeID, dteFromdate.ToString("yyyyMMdd"), dteTodate.ToString("yyyyMMdd"));
           return dal.GetDataSet(str);
        }

    }
    #endregion
}