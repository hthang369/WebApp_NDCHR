using DevExpress.Web.Mvc;
using DXWebApp.Models;
using ExpertERP.BusinessEntities;
using ExpertERPProcedure.Utilities;
using ExpertERPWeb.BaseEntities;
using ExpertWebLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApp.Controllers
{
    public class EmployeeOffWorkController : Controller
    {
        // GET: EmployeeOffWork
        public ActionResult Index()
        {
            AuthConfig.SetMailConfig();
            if (AuthConfig.GetSession("CurrentUser") != null)
            {
                HomeModels home = new HomeModels();
                IEnumerable lstt = home.GetScreenByModuleID("EmployeeOffWork");
                ViewData["title"] = AuthConfig.CurrentCompanyInfo.CSCompanyDesc;
                ViewData["lstBranchs"] = Helpers.HtmlControls.GetDropDownListObjects("BRBranchs", "BRBranchID", "BRBranchName");
                //ViewData["lstEmployees"] = Helpers.HtmlControls.GetDropDownListObjects("HREmployees", "HREmployeeID", "HREmployeeFullName");
                ViewData["lstDeparments"] = Helpers.HtmlControls.GetDropDownListObjects("HRDepartments", "HRDepartmentID", "HRDepartmentName");
                ViewData["lstPositions"] = Helpers.HtmlControls.GetDropDownListObjects("HRPositions", "HRPositionID", "HRPositionName");
                ViewData["lstSections"] = Helpers.HtmlControls.GetDropDownListObjects("HRSections", "HRSectionID", "HRSectionName");
                ViewData["lstAreas"] = Helpers.HtmlControls.GetDropDownListObjects("HRAreas", "HRAreaID", "HRAreaName");
                ViewData["lstLocalitys"] = Helpers.HtmlControls.GetDropDownListObjects("HRLocalitys", "HRLocalityID", "HRLocalityName");
                return View(lstt);
            }
            else
                return RedirectToAction("Login", "Account");
        }
        public ActionResult GridViewPartialView(int iFieldID, string sType, string sDocType, string sStatus)
        {
            // DXCOMMENT: Pass a data model for GridView in the PartialView method's second parameter
            HomeModels home = new HomeModels();
            Dictionary<STFieldsInfo, List<BusinessObject>> dic = home.GetFieldInfo(iFieldID);
            ViewData["sType"] = sType;
            ViewData["control"] = dic;
            string sApproval = Request.Url.Query.Split('=').LastOrDefault();
            string sApprovalStatus = (sApproval == "Register") ? "New" : ((sApproval == "Submit" ? "Approving" : "Approved"));
            sStatus = (sApproval == "Cancel") ? "Cancel" : "Alive";
            HREmployeesInfo objEmployee = GMCWebApp.GetEmployeeByUserName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
            int iEmployeeID = 0;
            if (objEmployee != null) iEmployeeID = objEmployee.HREmployeeID;
            ViewData["data"] = home.GetEmployeeOffWorkByApprovalStatus(iEmployeeID, sApprovalStatus, sStatus);
            return PartialView("GridViewAjaxPartialView", null);
        }
        public ActionResult ShowSubScreenCancel(int iObjectID)
        {
            HomeModels home = new HomeModels();
            ViewData["ModalTitle"] = "Hủy đăng ký phép";
            DataTable dt = home.GetAllDataByEmployeeOffWorkID(iObjectID);
            ViewData["EmployeeName"] = dt.Rows[0]["HREmployeeFullName"];
            ViewData["EmployeeLeaveType"] = dt.Rows[0]["HREmployeeLeaveTypeName"];
            ViewData["EmployeeReqDays"] = dt.Rows[0]["HREmployeeOffWorkRegDays"];
            ViewData["EmployeeFromDate"] = Convert.ToDateTime(dt.Rows[0]["HREmployeeOffWorkFromDate"]).ToShortDateString();
            ViewData["EmployeeToDate"] = Convert.ToDateTime(dt.Rows[0]["HREmployeeOffWorkToDate"]).ToShortDateString();
            ViewData["iObjectID"] = iObjectID;
            return PartialView("ShowSubScreenMessage");
        }
        public ActionResult ShowSubScreenRegisterOffWork(string sType)
        {
            HomeModels home = new HomeModels();
            ViewData["type"] = sType;
            DataTable dtSource = ADConfigValueUtility.InitConfigValueTable("EmployeeOffWorkShiftType");
            ViewData["ModalTitle"] = "Thông tin đăng ký nghỉ phép";
            ViewData["lstEmployeeLeaveType"] = home.GetEmployeeLeaveTypes();
            ViewData["objEmployeeOffWork"] = new HREmployeeOffWorksInfo();
            ViewData["lstShiftTypeCombo"] = Helpers.HtmlControls.GetDropDownListObjects(dtSource, "Value", "Text");
            HREmployeesInfo objCurrent = GMCWebApp.GetEmployeeByUserName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
            if (objCurrent != null)
            {
                dtSource = new HREmployeesController().GetDataTableByDataSet(new HREmployeesController().GetAllDataByForeignColumn("FK_HREmployeeManagerID", objCurrent.HREmployeeID));
                if (dtSource == null) dtSource = new DataTable();
                DataRow dr = dtSource.NewRow();
                if (dtSource.Columns.Contains("HREmployeeID"))
                    dr.SetField("HREmployeeID", objCurrent.HREmployeeID);
                if (dtSource.Columns.Contains("HREmployeeFullName"))
                    dr.SetField("HREmployeeFullName", objCurrent.HREmployeeFullName);
                dtSource.Rows.InsertAt(dr, 0);
            }
            ViewData["EmployeeID"] = objCurrent.HREmployeeID;
            ViewData["lstEmployee"] = Helpers.HtmlControls.GetDropDownListObjects(dtSource, "HREmployeeID", "HREmployeeFullName");
            foreach (KeyValuePair<string, double> item in home.GetTonPhepTheoNhanVien(objCurrent))
            {
                ViewData[item.Key] = item.Value;
            }
            return PartialView("ShowSubScreenRegisterOffWork");
        }
        [HttpPost]
        public ActionResult LoadData(int id, string type)
        {
            HomeModels home = new HomeModels();
            Dictionary<STFieldsInfo, List<BusinessObject>> dic = home.GetFieldInfo(id);
            ViewData["sType"] = type;
            var viewModel = GridViewExtension.GetViewModel("gv" + dic.Keys.FirstOrDefault().STFieldName);
            if (type == "Inbox")
            {
                DataTable dtInbox = MailUtil.GetListInboxItem_ByUserName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
                ViewData["control"] = dic;
                ViewData["data"] = dtInbox;
            }
            else
            {
                DataTable dtOutbox = MailUtil.GetListOutboxItem_ByUserName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
                ViewData["control"] = dic;
                ViewData["data"] = dtOutbox;
            }
            return PartialView("GridViewAjaxPartialView", null);
        }
        [HttpPost]
        public ActionResult RegisterOffWork(string oEmplOffWork)
        {
            string[] arr = oEmplOffWork.Split('&');
            HREmployeeOffWorksInfo objEmplOffWork = new HREmployeeOffWorksInfo();
            HREmployeeOffWorksController EmployeeOffWorkCtrl = new HREmployeeOffWorksController();
            arr.ToList().ForEach(x =>
            {
                string[] arrItem = x.Split('=');
                GMCDbUtil.SetPropertyValue(objEmplOffWork, arrItem.FirstOrDefault(), Convert.ChangeType(arrItem.LastOrDefault(), GMCDbUtil.GetCSharpVariableType("HREmployeeOffWorks", arrItem.FirstOrDefault())));
            });
            int iLeaveTypeID = new HREmployeeLeaveTypesController().GetObjectIDByNo("PN");
            if (objEmplOffWork.FK_HREmployeeLeaveTypeID == iLeaveTypeID && objEmplOffWork.HREmployeeOffWorkRegDays > Convert.ToDouble(AuthConfig.GetSession("TongNgayPhep")))
                return Content("Số ngày nghỉ phép vượt quá tổng số ngày nghỉ phép còn lại! Kiểm tra lại");
            HREmployeesInfo objEmpl = ExpertERP.Controller.EmployeeCtrl.GetObjectByID(objEmplOffWork.FK_HREmployeeID) as HREmployeesInfo;
            if (objEmpl == null)
                objEmpl = GMCWebApp.GetEmployeeByUserName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
            if (objEmpl != null)
            {
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetAllDataEmployeeOffWorkByEmployeeIDAndDate", objEmpl.HREmployeeID, objEmplOffWork.HREmployeeOffWorkFromDate.Value, objEmplOffWork.HREmployeeOffWorkToDate.Value);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return Content(string.Format("Bạn đã đăng ký phép trong thời gian {0} - {1}! Vui lòng kiểm tra lại!", objEmplOffWork.HREmployeeOffWorkFromDate.Value.ToShortDateString(), objEmplOffWork.HREmployeeOffWorkToDate.Value.ToShortDateString()));
                if (objEmplOffWork.FK_HREmployeeID == 0)
                    objEmplOffWork.FK_HREmployeeID = objEmpl.HREmployeeID;
                objEmplOffWork.AACreatedUser = Convert.ToString(AuthConfig.GetSession("CurrentUser"));
                objEmplOffWork.ApprovalStatusCombo = "New";
                objEmplOffWork.HREmployeeOffWorkTypeCombo = "Permision";
                EmployeeOffWorkCtrl.SaveObject(objEmplOffWork);
                return Content("OK");
            }
            else
                return Content("User hiện chưa cấu hình nhân viên! Không thể đăng ký!");
            
        }
        [HttpPost]
        public ActionResult SubmitDocument(int iObjectID)
        {
            HREmployeeOffWorksInfo DocInfo = new HREmployeeOffWorksController().GetObjectByID(iObjectID) as HREmployeeOffWorksInfo;
            int iEmpManagerID = Convert.ToInt32(ExpertERP.Controller.EmployeeCtrl.GetObjectColumnByID(DocInfo.FK_HREmployeeID, "FK_HREmployeeManagerID"));
            HREmployeesInfo objEmployee = ExpertERP.Controller.EmployeeCtrl.GetObjectByID(iEmpManagerID) as HREmployeesInfo;
            if(string.IsNullOrEmpty(ExpertERP.Controller.UserCtrl.GetObjectNameByID(objEmployee.FK_ADUserID)))
                return Content(string.Format("Nhân viên quản lý {0} chưa có cấu hình tài khoản đăng nhập! Vui lòng kiểm tra lại!"));
            string strError = "OK";
            MailUtil.ActionSubmit(DocInfo, "EmployeeOffWork", Convert.ToString(AuthConfig.GetSession("CurrentUser")), out strError);
            return Content(strError);
        }
        [HttpPost]
        public ActionResult DeleteDocument(int iObjectID)
        {
            new HREmployeeOffWorksController().DeleteObject(iObjectID);
            return Content("OK");
        }
        [HttpPost]
        public ActionResult CancelDocument(int iObjectID, string sContent)
        {
            HREmployeeOffWorksInfo DocInfo = new HREmployeeOffWorksController().GetObjectByID(iObjectID) as HREmployeeOffWorksInfo;
            DocInfo.HREmployeeOffWorkCancelReason = sContent;
            DocInfo.HREmployeeOffWorkCancelDate = DateTime.Now;
            DocInfo.HREmployeeOffWorkCancelUser = Convert.ToString(AuthConfig.GetSession("CurrentUser"));
            MailUtil.CancelDocument(DocInfo, "EmployeeOffWork");
            return Content("OK");
        }
        [HttpPost]
        public ActionResult ReloadEmployeeOffWork(int iObjectID)
        {
            HREmployeesInfo EmployeeInfo = ExpertERP.Controller.EmployeeCtrl.GetObjectByID(iObjectID) as HREmployeesInfo;
            HomeModels home = new HomeModels();
            List<string> lstVals = new List<string>();
            Dictionary<string, double> dicitem = home.GetTonPhepTheoNhanVien(EmployeeInfo);
            AuthConfig.SetSession("TongNgayPhep", dicitem["ConLai"]);
            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();
            return Content(json.Serialize(dicitem));
        }
    }
}