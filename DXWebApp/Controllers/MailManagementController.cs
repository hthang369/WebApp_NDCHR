using DXWebApp.Models;
using ExpertERP.BusinessEntities;
using ExpertERPProcedure.Utilities;
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
    public class MailManagementController : Controller
    {
        // GET: MailManagement
        public ActionResult Index()
        {
            if (AuthConfig.GetSession("CurrentUser") != null)
            {
                HomeModels home = new HomeModels();
                IEnumerable lstt = home.GetScreenByModuleID("ApprovalModule");
                ViewData["title"] = AuthConfig.CurrentCompanyInfo.CSCompanyDesc;
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
            if (sType == "Inbox")
            {
                DataTable dtInbox = MailUtil.GetListInboxItemByUserNameAndDocType(Convert.ToString(AuthConfig.GetSession("CurrentUser")), Convert.ToString(sDocType), sStatus);
                ViewData["data"] = dtInbox;
            }
            else
            {
                int iUserID = new ADUsersController().GetObjectIDByName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
                DataSet dsOutbox = new ADOutboxItemsController().GetAllOutboxItemsByUser(iUserID);
                ViewData["data"] = dsOutbox;
            }
            return PartialView("GridViewAjaxPartialView", null);
        }
        public ActionResult ShowSubScreenApproved(string[] InboxItem)
        {
            HomeModels home = new HomeModels();
            ADInboxItemsController InboxItemCtrl = new ADInboxItemsController();
            ADInboxItemsInfo objInboxItem = (ADInboxItemsInfo)InboxItemCtrl.GetObjectByID(Convert.ToInt32(InboxItem[0]));
            string strView = "ShowSubScreenApproved";
            if (objInboxItem.ADInboxItemAction == "Rejected")
                strView = "ShowSubScreenMessage";
            bool isUnRead = home.CheckUnReadMailBox(objInboxItem, Convert.ToString(AuthConfig.GetSession("CurrentUser")));
            if (isUnRead)
            {
                if (!string.IsNullOrEmpty(objInboxItem.ADMailReadUsers) && objInboxItem.ADMailReadUsers.EndsWith(";") == false) objInboxItem.ADMailReadUsers += ";";
                objInboxItem.ADMailReadUsers += Convert.ToString(AuthConfig.GetSession("CurrentUser")) + ";";
                InboxItemCtrl.UpdateObject(objInboxItem, false, "ADMailReadUsers");
            }

            #region Protocol: Approval
            if (objInboxItem.ADInboxItemProtocol == MailUtil.strProtocol_Approval)
            {
                if (String.IsNullOrEmpty(objInboxItem.ADInboxItemAction) && home.CheckUserApprovalMailBox(objInboxItem, Convert.ToString(AuthConfig.GetSession("CurrentUser"))))
                {
                    ViewData["approvalDisable"] = "";
                    ViewData["rejectDisable"] = "";
                }
                else
                {
                    ViewData["approvalDisable"] = "disabled";
                    ViewData["rejectDisable"] = "disabled";
                }

                if (!string.IsNullOrEmpty(objInboxItem.ADInboxItemAction))
                    ViewData["ModalTitle"] = string.Format("{0} ({1})", objInboxItem.ADInboxItemDocNo, objInboxItem.ADInboxItemAction);
                else
                    ViewData["ModalTitle"] = string.Format("Waiting for Approve: {0}", objInboxItem.ADInboxItemDocNo);

                ViewData["inboxID"] = InboxItem[0];
                ViewData["InboxInfo"] = objInboxItem;
                
                ViewData["createUser"] = new HREmployeesController().GetObjectNameByID(objInboxItem.FK_HRFromEmployeeID);
                
                string sApprovalStep = Convert.ToString(new ADApprovalProcStepsController().GetObjectColumnByID(objInboxItem.FK_ADApprovalProcStepID, "ADApprovalProcStepLevel"));
                if (string.IsNullOrEmpty(sApprovalStep)) sApprovalStep = new HREmployeesController().GetObjectNameByID(home.GetEmployeeManagerLevel(objInboxItem.FK_HRFromEmployeeID, "FK_ReportToEmployeeID"));
                ViewData["sApprovalStep"] = sApprovalStep;
                //strView = "ShowSubScreenApproved";
            }
            #endregion

            #region Protocol: Message
            else if (objInboxItem.ADInboxItemProtocol == MailUtil.strProtocol_Message)
            {
                DataSet dsMessageItems = new ADMessageItemsController().GetAllDataByForeignColumn("FK_ADInboxItemID", objInboxItem.ADInboxItemID);
                ViewData["ModalTitle"] = objInboxItem.ADInboxItemSubject;
                ViewData["InboxInfo"] = objInboxItem;
                strView = "ShowSubScreenMessage";
            }
            #endregion
            ViewData["resultDetail"] = new DataTable();
            ViewData["listCol"] = new List<STGridColumnsInfo>();
            Dictionary<List<STGridColumnsInfo>, DataSet> dicInfo = home.GetScreenEmployeeOffWork(objInboxItem.ADInboxItemDocType, objInboxItem.ADInboxItemObjectID);
            if (dicInfo != null)
            {
                KeyValuePair<List<STGridColumnsInfo>, DataSet> dic = dicInfo.FirstOrDefault();
                ViewData["listCol"] = dic.Key;
                if (dic.Value != null && dic.Value.Tables.Count > 0)
                    ViewData["resultDetail"] = dic.Value.Tables[0];
            }

            return PartialView(strView);
        }
        [HttpPost]
        public ActionResult ApprovalDocument(int iInboxItemID, string strMessenger, string strRemark)
        {
            AuthConfig.SetMailConfig();
            ADInboxItemsInfo InboxItem = (ADInboxItemsInfo)new ADInboxItemsController().GetObjectByID(iInboxItemID);
            InboxItem.ADInboxItemMessage = strMessenger;
            InboxItem.ADInboxItemRemark = strRemark;
            ADUsersInfo CurrentUserInfo = (ADUsersInfo)new ADUsersController().GetObjectByName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
            MailUtil.ApproveDocument(InboxItem, CurrentUserInfo);

            return null;
        }
        [HttpPost]
        public ActionResult RejectDocument(int iInboxItemID, string strMessenger, string strRemark)
        {
            AuthConfig.SetMailConfig();
            ADInboxItemsInfo InboxItem = (ADInboxItemsInfo)new ADInboxItemsController().GetObjectByID(iInboxItemID);
            InboxItem.ADInboxItemMessage = strMessenger;
            InboxItem.ADInboxItemRemark = strRemark;
            ADUsersInfo CurrentUserInfo = (ADUsersInfo)new ADUsersController().GetObjectByName(Convert.ToString(AuthConfig.GetSession("CurrentUser")));
            MailUtil.RejectDocument(InboxItem, CurrentUserInfo);
            return null;
        }
    }
}