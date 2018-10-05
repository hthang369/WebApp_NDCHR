using System;
using System.Collections.Generic;
using System.Text;
using ExpertWebLib;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Reflection;
using System.Globalization;
using ExpertERP.Procedure;
using System.Linq;
using ExpertERPWeb.BaseEntities;
using ExpertERP.BusinessEntities;

namespace ExpertERPProcedure.Utilities
{

    public class MailUtil
    {
        public static String strButtonApprove = "Approve";
        public static String strColumnNameApproval = "ApprovalStatusCombo";
        public static String strApprovalStatusApproving = "Approving";
        public static String strApprovalStatusApproved = "Approved";
        public static String strApprovalStatusInProgress = "InProgress";
        public static String strApprovalStatusNew = "New";

        public static String strProtocol_Approval = "Approval";
        public static String strProtocol_Message = "Message";

        public static String strTransactionCreate = "Create";
        public static String strTransactionEdit = "Edit";
        public static String strTransactionDelete = "Delete";
        public static String strTransactionPost = "Post";
        public static String strTransactionCancel = "Cancel";
        public static String strTransactionApproved = "Approved";

        public static String strApprovalAction_Submit = "Submit";
        public static String strApprovalAction_Rejected = "Rejected";
        public static String strApprovalAction_Approved = "Approved";
        private static string WebEmail = "";
        private static string WebEmailServer = "";
        private static string WebEmailUser = "";
        private static string WebEmailPass = "";
        private static int WebEmailPort = 0;

        #region ADApprovalTypeCombo
        public static string strADApprovalTypeComboWBS = "ApprovedWBS";
        public static string strADApprovalTypeComboEmployeePln = "ApprovedEmployeePln";
        public static string strADApprovalTypeComboCostPlanning = "ApprovedCostPlanning";
        public static string strADApprovalTypeComboQC = "ApprovedQC";
        public static string strADApprovalTypeComboHSE = "ApprovedHSE";
        public static string strADApprovalTypeComboOrgChart = "ApprovedOrgChart";
        public static string strADApprovalTypeComboWBSProcurement = "ApprovedWBSProcurement";
        public static string strADApprovalTypeComboEngineering = "ApprovedEngineering";
        public static string strADApprovalTypeComboBiddingPlnEstimator = "BiddingPlnEstimator";
        #endregion

        public static Boolean OpenMessage = true;
        //public static ADAlertConfigsController AlertConfigCtrl = new ADAlertConfigsController();
        public static ADUsersController UserCtrl = new ADUsersController();
        public static ADInboxItemsController InboxItemCtrl = new ADInboxItemsController();
        public static ADOutboxItemsController OutboxItemCtrl = new ADOutboxItemsController();
        public static ADMessageItemsController MessageItemCtrl = new ADMessageItemsController();
        public static ADDocHistorysController DocHistoryCtrl = new ADDocHistorysController();
        public static string sUserRequest = "";
        public static string sUrlHost = "http://" + System.Web.HttpContext.Current.Request.Url.Authority;
        #region Get Document
        public static string GetDocumentName(string strTableName, string strDocumentNo)
        {
            string strDocumentName = "";
            if (string.IsNullOrEmpty(strTableName)) return strDocumentName;

            String strPrefix = strTableName.Substring(0, strTableName.Length - 1);

            BaseBusinessController objDocCtrl = BusinessControllerFactory.GetBusinessController(strTableName + "Controller");
            Object objDocInfo = null;
            if (objDocCtrl != null)
            {
                objDocInfo = objDocCtrl.GetObjectByNo(strDocumentNo);
            }

            if (objDocInfo != null)
            {
                Object objDocName = GMCDbUtil.GetPropertyValue(objDocInfo, strPrefix + "Name");
                if (objDocName != null) strDocumentName = objDocName.ToString();
            }

            return strDocumentName;
        }
        public static string GetModuleDesc(string strModuleName)
        {
            string strModuleDesc = strModuleName;
            STModulesInfo objSTModuleInfo = (STModulesInfo)new STModulesController().GetObjectByName(strModuleName);
            if (objSTModuleInfo != null)
            {
                STModuleDescriptionsInfo objSTModuleDescriptionInfo = (STModuleDescriptionsInfo)new STModuleDescriptionsController().GetFirstObjectByForeignColumn("STModuleID", objSTModuleInfo.STModuleID);
                if (objSTModuleDescriptionInfo != null)
                    strModuleDesc = GMCWebApp.GetControlText(objSTModuleDescriptionInfo.STModuleDescriptionDescription);
            }
            return strModuleDesc;
        }
        public static string GetSubjectInboxDefault(ADInboxItemsInfo objADInboxInfo)
        {
            string strModuleDesc = GetModuleDesc(objADInboxInfo.ADInboxItemDocType);
            if (objADInboxInfo.ADApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
            {
                strModuleDesc = "Internal Calculation";
            }
            return strModuleDesc;
        }
        public static string GetUserNameByEmployeeID(int iEmployeeID)
        {
            string strQuery = string.Format("SELECT ADUserName FROM ADUsers a JOIN HREmployees b ON a.ADUserID = b.FK_ADUserID AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive' AND HREmployeeID = {0}", iEmployeeID);
            return Convert.ToString(GMCDbUtil.ExecuteScalar(strQuery));
        }
        private static ADOutboxItemsInfo GetOutboxItemApprovalFromInboxItem(ADInboxItemsInfo objADInboxItemInfo, int iADUserCurrentID)
        {
            ADOutboxItemsInfo objADOutboxItemInfo = new ADOutboxItemsInfo();
            GMCUtil.CopyObject(objADInboxItemInfo, objADOutboxItemInfo);
            objADOutboxItemInfo.FK_ADFromUserID = iADUserCurrentID;
            objADOutboxItemInfo.ADMailToUsers = objADInboxItemInfo.ADMailToUsers;
            objADOutboxItemInfo.ADMailCCUsers = objADInboxItemInfo.ADMailCCUsers;
            objADOutboxItemInfo.ADApprovalTypeCombo = objADInboxItemInfo.ADApprovalTypeCombo;
            objADOutboxItemInfo.ADOutboxItemAction = objADInboxItemInfo.ADInboxItemAction;
            objADOutboxItemInfo.ADOutboxItemProtocol = "Approval";
            objADOutboxItemInfo.ADOutboxItemMessage = objADInboxItemInfo.ADInboxItemRemark;
            objADOutboxItemInfo.ADOutboxItemRemark = String.Empty;
            objADOutboxItemInfo.ADOutboxItemDate = DateTime.Now;
            return objADOutboxItemInfo;
        }
        public static ADApprovalProcStepsInfo GetProcStepNextByADApprovalProcStepID(int iADApprovalProcStepID)
        {
            return new ADApprovalProcStepsController().GetProcStepNextByADApprovalProcStepID(iADApprovalProcStepID);
        }
        public static string GetStringUserByADApprovalProcStepCurrent(ADApprovalProcStepsInfo objADApprovalProcStepInfo, Object objDocInfo = null, bool isCheckBranch = true)
        {
            if (objADApprovalProcStepInfo != null) return GetAllUserByListUserAdnPosition(objADApprovalProcStepInfo.AssignUsers, objADApprovalProcStepInfo.AssignPositions, objDocInfo, objADApprovalProcStepInfo.ADApprovalProcStepLevel, isCheckBranch);
            return String.Empty;
        }
        private static string GetAllUserByListUserAdnPosition(string strUsers, string strPositions, Object objDocInfo = null, int iLevel = 2, bool isCheckBranch = true)
        {
            string strListUsers = strUsers;
            if (string.IsNullOrEmpty(strListUsers) == false && strListUsers.EndsWith(";") == false) strListUsers += ";";

            #region Lấy User theo Vị trí
            HREmployeesController objHREmployeeCtrl = new HREmployeesController();
            HRPositionsController objHRPositionCtrl = new HRPositionsController();
            //PMProjectOrgChartItemsController objPMProjectOrgChartItemCtrl = new PMProjectOrgChartItemsController();
            ADUsersController objADUserCtrl = new ADUsersController();

            #region Lấy Table Name của đối tượng chứng từ
            String strTableName = "";
            if (objDocInfo != null)
                strTableName = GMCUtil.GetTableNameFromBusinessObjectType(objDocInfo.GetType());
            #endregion

            #region Kiểm tra vị trí
            // lấy ra user tạo
            int iEmployeeID = 0;
            int iRegionID = 0;
            int iBranchID = 0;
            string sCreateUser = Convert.ToString(GMCDbUtil.GetPropertyValue(objDocInfo, "AACreatedUser"));
            if (string.IsNullOrEmpty(sCreateUser))
            {
                object oEmployeeID = GMCDbUtil.GetPropertyValue(objDocInfo, "FK_HREmployeeID");
                if (oEmployeeID != null && oEmployeeID != DBNull.Value)
                    iEmployeeID = Convert.ToInt32(oEmployeeID);
                //iRegionID = Convert.ToInt32(objHREmployeeCtrl.GetObjectColumnByID(iEmployeeID, "FK_HRRegionChildID"));
                iBranchID = Convert.ToInt32(objHREmployeeCtrl.GetObjectColumnByID(iEmployeeID, "FK_BRBranchID"));
            }
            else
            {
                HREmployeesInfo obj = GMCWebApp.GetEmployeeByUserName(sCreateUser);
                if (obj != null)
                {
                    iRegionID = obj.FK_HRRegionChildID;
                    iBranchID = obj.FK_BRBranchID;
                }
            }
            string strListUserPositions = "";
            if (!string.IsNullOrEmpty(strPositions))
            {
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetDataUserNameByPosition", strPositions.TrimEnd(';'));
                if (ds != null && ds.Tables.Count > 0)
                {
                    strListUserPositions = string.Join(";", ds.Tables[0].Rows.Cast<DataRow>().Select(x => x.Field<string>("ADUserName")).Distinct().ToArray());
                }
            }
            strListUsers += strListUserPositions;
            #endregion

            strListUsers = string.Join(";", strListUsers.Split(';').Distinct().ToArray());
            if (isCheckBranch)
            {
                if (!string.IsNullOrEmpty(strListUsers))
                {
                    DataSet ds1 = SqlDatabaseHelper.RunStoredProcedure("spl_GetAllDataByEmployeeNo", strListUsers);
                    if (ds1 != null && ds1.Tables.Count > 0)
                    {
                        strListUsers = string.Join(";", ds1.Tables[0].Select(string.Format("FK_BRBranchID = {0}", iBranchID)).Select(x => x.Field<string>("ADUserName")).Distinct());
                        if (!string.IsNullOrEmpty(strListUsers))
                            strListUsers += ";";
                    }
                }
                string sUserName = Convert.ToString(GMCDbUtil.ExecuteStoredProcedure("spl_GetUserNameByBranchID", iBranchID, iLevel));
                strListUsers += sUserName + ";";
            }
            #endregion
            return string.Join(";", strListUsers.Split(';').Distinct());
        }
        public static string GetStringUserCCByADApprovalProcStepCurrent(ADApprovalProcStepsInfo objADApprovalProcStepInfo, Object objDocInfo = null)
        {
            if (objADApprovalProcStepInfo != null) return GetAllUserByListUserAdnPosition(objADApprovalProcStepInfo.CCUsers, objADApprovalProcStepInfo.CCPositions, objDocInfo, objADApprovalProcStepInfo.ADApprovalProcStepLevel);
            return String.Empty;
        }
        public static String GetListUser_PreLevelByADApprovalProcStepCurrentID(int iADApprovalProcStepCurrentID, Object objDocInfo = null)
        {
            ADApprovalProcStepsController objADApprovalProcStepCtrl = new ADApprovalProcStepsController();
            String strUsers = "";
            DataSet dsADApprovalProcSteps = objADApprovalProcStepCtrl.GetAllProcStepPreFromADApprovalProcStepID(iADApprovalProcStepCurrentID);
            List<BusinessObject> lstADApprovalProcSteps = objADApprovalProcStepCtrl.GetListFromDataset(dsADApprovalProcSteps);
            foreach (ADApprovalProcStepsInfo objADApprovalProcStepInfo in lstADApprovalProcSteps)
            {
                strUsers += GetStringAllUserByADApprovalProcStepCurrent(objADApprovalProcStepInfo, objDocInfo);
                if (string.IsNullOrEmpty(strUsers) == false && strUsers.EndsWith(";") == false) strUsers += ";";
            }

            return strUsers;
        }
        public static string GetStringAllUserByADApprovalProcStepCurrent(ADApprovalProcStepsInfo objADApprovalProcStepInfo, Object objDocInfo = null)
        {
            string strUsers = "";
            if (objADApprovalProcStepInfo != null)
            {
                strUsers = GetAllUserByListUserAdnPosition(objADApprovalProcStepInfo.AssignUsers, objADApprovalProcStepInfo.AssignPositions, objDocInfo);
                if (string.IsNullOrEmpty(strUsers) == false && strUsers.EndsWith(";") == false) strUsers += ";";
                strUsers += GetAllUserByListUserAdnPosition(objADApprovalProcStepInfo.CCUsers, objADApprovalProcStepInfo.CCPositions, objDocInfo);
            }
            return strUsers;
        }
        public static ADApprovalProcsInfo GetADApprovalProcByModuleAndUserName(string sModuleName, string sUserName, string sPositionName)
        {
            ADApprovalProcsController _objADApprovalProcsCtrl = new ADApprovalProcsController();
            ADApprovalProcsInfo _objADApprovalProcsInfo = null;
            System.Data.DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetApprovalProcByDocTypeAndPositionUser", sModuleName, sUserName, sPositionName);
            if (ds != null && ds.Tables.Count > 0)
            {
                int iUserProcCnt = ds.Tables[0].Rows.Count;
                
                if (iUserProcCnt == 1)
                    _objADApprovalProcsInfo = (ADApprovalProcsInfo)_objADApprovalProcsCtrl.GetObjectFromDataRow(ds.Tables[0].Rows[0]);

                if (_objADApprovalProcsInfo == null)
                    _objADApprovalProcsInfo = _objADApprovalProcsCtrl.GetApprovalProcIDByDocumentTypeLastLevelUserAndAAModule(sModuleName, sUserName);

                if (_objADApprovalProcsInfo == null)
                    _objADApprovalProcsInfo = _objADApprovalProcsCtrl.GetApprovalProcIDByDocumentTypeFirstLevelUserAndAAModule(sModuleName, sUserName);

                if (_objADApprovalProcsInfo == null)
                    _objADApprovalProcsInfo = _objADApprovalProcsCtrl.GetProcByDocumentTypeAndAAModule(sModuleName, "");
            }
            return _objADApprovalProcsInfo;
        }
        #endregion

        #region Approval Document
        public static void ApproveDocument(ADInboxItemsInfo InboxItem, ADUsersInfo CurrentUserInfo)
        {
            if (InboxItem == null) return;
            
            if (String.IsNullOrEmpty(InboxItem.ADInboxItemAction) == false)
                return;

            #region Init Info
            String strTable = InboxItem.ADInboxItemTableName;
            String strPrefix = strTable.Substring(0, strTable.Length - 1);

            BaseBusinessController objDocCtrl = BusinessControllerFactory.GetBusinessController(strTable + "Controller");
            Object objDocInfo = null;
            if (objDocCtrl != null)
            {
                objDocInfo = objDocCtrl.GetObjectByNo(InboxItem.ADInboxItemDocNo);
                if (objDocInfo == null)
                    objDocInfo = objDocCtrl.GetObjectByID(InboxItem.ADInboxItemObjectID);
            }

            #endregion

            InboxItem.ADInboxItemAction = strApprovalAction_Approved;

            #region Get Employee Of User
            int iHREmployeeID = 0;
            string strEmployeeName = CurrentUserInfo.ADUserName;
            HREmployeesInfo objHREmployeeInfo = GMCWebApp.GetEmployeeByUserName(CurrentUserInfo.ADUserName);
            if (objHREmployeeInfo != null)
            {
                iHREmployeeID = objHREmployeeInfo.HREmployeeID;
                strEmployeeName = objHREmployeeInfo.HREmployeeName;
            }
            #endregion

            #region Outbox

            ADOutboxItemsInfo OutboxItem = GetOutboxItemApprovalFromInboxItem(InboxItem, CurrentUserInfo.ADUserID);
            OutboxItem.FK_HRFromEmployeeID = iHREmployeeID;
            new ADOutboxItemsController().CreateObject(OutboxItem);

            #endregion

            #region Create History
            CreateHistory(InboxItem, CurrentUserInfo.ADUserName);
            #endregion

            #region Send Mail to Next Level
            int iNextUserID = 0;
            string strNextUsers = "";
            string strNextCCUsers = "";

            ADApprovalProcStepsInfo objADApprovalProcStepNextInfo = GetApprovalProcStepLevel(InboxItem, objDocInfo, InboxItem.ADInboxItemDocType, CurrentUserInfo);
            //if (objADApprovalProcStepNextInfo != null && (iRegDays > 1 && iRegDays < 3 && objADApprovalProcStepNextInfo.ADApprovalProcStepLevel == 3)) objADApprovalProcStepNextInfo = null;
            if (objADApprovalProcStepNextInfo != null)
            {
                bool isCheck = true;
                if (InboxItem.ADApprovalTypeCombo == "DM" || InboxItem.ADApprovalTypeCombo == "RSM" || InboxItem.ADApprovalTypeCombo == "TL") isCheck = false;
                strNextUsers = MailUtil.GetStringUserByADApprovalProcStepCurrent(objADApprovalProcStepNextInfo, objDocInfo, isCheck);
                strNextCCUsers = MailUtil.GetStringUserCCByADApprovalProcStepCurrent(objADApprovalProcStepNextInfo, objDocInfo);
            }

            if (objADApprovalProcStepNextInfo == null)
            {
                #region Update ApproveStatus = Approve to Document
                UpdateApprovalDoc(InboxItem, objDocCtrl, objDocInfo);
                #endregion
            }
            else
            {
                bool isApprovalNextStepCheck = true;
                if (objDocInfo != null)
                {
                    try
                    {
                        String strColumnNextStepApproved = strPrefix + "ApprovalNextStepCheck";
                        if (GMCDbUtil.ColumnIsExist(strTable, strColumnNextStepApproved))
                            isApprovalNextStepCheck = Convert.ToBoolean(GMCDbUtil.GetPropertyValue(objDocInfo, strColumnNextStepApproved));
                    }
                    catch
                    {
                        isApprovalNextStepCheck = true;
                    }

                    #region Các bảng không kiểm tra có duyệt tiếp không

                    string[] strTableException = { "ARContracts" };
                    foreach (string strTableNameExc in strTableException)
                    {
                        if (strTableNameExc == strTable)
                            isApprovalNextStepCheck = true;
                    }

                    if(string.IsNullOrEmpty(strNextUsers))
                        isApprovalNextStepCheck = false;
                    #endregion

                    ADUsersController objADUserCtrl = new ADUsersController();
                    if (isApprovalNextStepCheck == true)
                    {
                        #region Send Email Next Level
                        String strUserSendEmail = "";

                        ADInboxItemsInfo InboxItemNew = new ADInboxItemsInfo();
                        GMCUtil.CopyObject(InboxItem, InboxItemNew, true);

                        InboxItemNew.ADInboxItemID = 0;
                        InboxItemNew.FK_HRFromEmployeeID = iHREmployeeID;

                        //InboxItemNew.ADInboxItemSubject = string.Format("{0} submit {1} {2}-{3}", strEmployeeName, GetSubjectInboxDefault(InboxItem), InboxItem.ADInboxItemDocNo, GetDocumentName(InboxItem.ADInboxItemTableName, InboxItem.ADInboxItemDocNo));
                        InboxItemNew.ADInboxItemSubject = InboxItem.ADInboxItemSubject;
                        InboxItemNew.ADInboxItemAction = String.Empty;
                        InboxItemNew.ADInboxItemMessage = InboxItem.ADInboxItemRemark;
                        InboxItemNew.ADInboxItemRemark = String.Empty;
                        InboxItemNew.ADInboxItemDate = DateTime.Now;
                        InboxItemNew.FK_ADFromUserID = CurrentUserInfo.ADUserID;
                        InboxItemNew.ADMailToUsers = strNextUsers;
                        InboxItemNew.ADMailCCUsers = strNextCCUsers;
                        InboxItemNew.ADMailReadUsers = "";
                        if (objADApprovalProcStepNextInfo != null)
                            InboxItemNew.FK_ADApprovalProcStepID = objADApprovalProcStepNextInfo.ADApprovalProcStepID;
                        InboxItemNew.FK_ADToUserID = iNextUserID;
                        InboxItemCtrl.CreateObject(InboxItemNew);
                        //(LINHCLH - Them trang thai dang duoc phep duyet
                        UpdateApprovalStatus(objDocInfo, objDocCtrl, strApprovalStatusApproving);
                        //)
                        SendMail(InboxItemNew, strNextUsers);
                        #endregion
                    }
                    else
                    {
                        #region Update ApproveStatus = Approve to Document
                        UpdateApprovalDoc(InboxItem, objDocCtrl, objDocInfo);
                        #endregion
                    }
                }
            }
            #endregion

            #region Send Mail to Pre Level
            String lstUserPreLevel = "";
            ADApprovalProcsInfo ApprovalProc = (ADApprovalProcsInfo)new ADApprovalProcsController().GetObjectByID(InboxItem.FK_ADApprovalProcID);

            //if (ApprovalProc != null && ApprovalProc.ADApprovalProcBroadcast)
            //{
            //    //lstPreLevel = MailUtil.GetListAllUser_PreLevelByUserIDAndProcID(CurrentUserInfo.ADUserID, InboxItem.FK_ADApprovalProcID);
            //    lstUserPreLevel = MailUtil.GetListUser_PreLevelByADApprovalProcStepCurrentID(InboxItem.FK_ADApprovalProcStepID, objDocInfo);
            //}
            //else
            //{
                ADUsersInfo FromUser = (ADUsersInfo)new ADUsersController().GetObjectByID(InboxItem.FK_ADFromUserID);
                if (FromUser != null)
                {
                    lstUserPreLevel += FromUser.ADUserName + ";";
                }
            //}
            if (string.IsNullOrEmpty(lstUserPreLevel) == false)
            {
                #region Bỏ User hiện tại nhận thông báo Approved
                if (lstUserPreLevel.Contains(CurrentUserInfo.ADUserName + ";"))
                {
                    lstUserPreLevel = lstUserPreLevel.Replace(CurrentUserInfo.ADUserName + ";", "");
                }
                else if (lstUserPreLevel.Contains(CurrentUserInfo.ADUserName))
                {
                    lstUserPreLevel = lstUserPreLevel.Replace(CurrentUserInfo.ADUserName, "");
                }
                #endregion

                #region lấy user tạo nhận thông báo và bỏ trong ds cc
                string sCreateUser = Convert.ToString(GMCDbUtil.GetPropertyValue(objDocInfo, "AACreatedUser")) + ";";
                if (string.IsNullOrEmpty(sCreateUser))
                {
                    object oEmp = GMCDbUtil.GetPropertyValue(objDocInfo, "FK_HREmployeeID");
                    if (oEmp != null && oEmp != DBNull.Value)
                    {
                        object oUserID = ExpertERP.Controller.EmployeeCtrl.GetObjectColumnByID(Convert.ToInt32(oEmp), "FK_ADUserID");
                        if (oUserID != null && oUserID != DBNull.Value)
                            sCreateUser = new ADUsersController().GetObjectNameByID(Convert.ToInt32(oUserID));
                    }
                }
                if (lstUserPreLevel.Contains(sCreateUser + ";"))
                    lstUserPreLevel = lstUserPreLevel.Replace(sCreateUser + ";", "");
                else if (lstUserPreLevel.Contains(sCreateUser))
                    lstUserPreLevel = lstUserPreLevel.Replace(sCreateUser, "");
                #endregion

                ADInboxItemsInfo InboxItemNew = new ADInboxItemsInfo();
                GMCUtil.CopyObject(InboxItem, InboxItemNew, true);

                InboxItemNew.ADInboxItemID = 0;
                InboxItemNew.FK_ADApprovalProcStepID = 0;
                InboxItemNew.FK_HRFromEmployeeID = iHREmployeeID;
                //InboxItemNew.ADInboxItemSubject = string.Format(@"{0} approved {1} {2}-{3}", strEmployeeName, GetSubjectInboxDefault(InboxItem), InboxItem.ADInboxItemDocNo, GetDocumentName(InboxItem.ADInboxItemTableName, InboxItem.ADInboxItemDocNo));
                InboxItemNew.ADInboxItemSubject = InboxItem.ADInboxItemSubject;
                InboxItemNew.ADInboxItemAction = strApprovalAction_Approved;
                if (String.IsNullOrEmpty(strNextUsers))
                    InboxItemNew.ADInboxItemDocApprovalStatusCombo = strApprovalAction_Approved;
                InboxItemNew.ADInboxItemMessage = InboxItem.ADInboxItemRemark;
                InboxItemNew.ADInboxItemProtocol = strProtocol_Message;
                InboxItemNew.ADInboxItemRemark = String.Empty;
                InboxItemNew.FK_ADFromUserID = CurrentUserInfo.ADUserID;
                InboxItemNew.ADMailToUsers = sCreateUser;
                InboxItemNew.ADMailCCUsers = lstUserPreLevel;
                InboxItemNew.ADInboxItemDate = DateTime.Now;
                InboxItemNew.ADMailReadUsers = "";

                InboxItemCtrl.CreateObject(InboxItemNew);
                SendMail(InboxItemNew, sCreateUser, lstUserPreLevel, true);
            }
            #endregion

            new ADInboxItemsController().UpdateObject(InboxItem);
        }
        private static void UpdateApprovalDoc(ADInboxItemsInfo objADInboxItemInfo, BaseBusinessController objDocCtrl = null, Object objDocInfo = null)
        {
            #region Update ApproveStatus = Approve to Document
            if (objDocCtrl == null)
            {
                String strTable = objADInboxItemInfo.ADInboxItemTableName;
                String strPrefix = strTable.Substring(0, strTable.Length - 1);
                objDocCtrl = BusinessControllerFactory.GetBusinessController(strTable + "Controller");
            }

            if (objDocCtrl == null)
                return;

            if (objDocInfo == null)
            {
                objDocInfo = objDocCtrl.GetObjectByNo(objADInboxItemInfo.ADInboxItemDocNo);
            }

            if (objDocInfo != null)
            {
                GMCDbUtil.SetPropertyValue(objDocInfo, "FK_ADApprovalProcID", objADInboxItemInfo.FK_ADApprovalProcID);
                //if (string.IsNullOrEmpty(objADInboxItemInfo.ADApprovalTypeCombo))
                //{
                UpdateApprovalStatus(objDocInfo, objDocCtrl, strApprovalStatusApproved);
                //}
                //else
                //{
                //    ApprovalByADApprovalTypeCombo(objDocCtrl, objDocInfo, objADInboxItemInfo.ADApprovalTypeCombo);
                //}

                string strTitle = "";
                if (objADInboxItemInfo.ADApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
                    strTitle = GetSubjectInboxDefault(objADInboxItemInfo);
                //ProcessAlert(objADInboxItemInfo.ADInboxItemDocType, objDocInfo, strTransactionApproved, MailModule, strTitle);
            }
            #endregion
        }
        public static HREmployeesInfo GetEmployeeByPosition(string sPositionName, int iObjectID, string sColumnName)
        {
            DataSet ds = GMCDbUtil.ExecuteQuery(string.Format(@"SELECT a.* FROM HREmployees a 
                            JOIN HRPositions b ON a.FK_HRPositionID = b.HRPositionID
                                AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive'
                            WHERE b.HRPositionName = '{0}' AND a.{2} = {1}", sPositionName, iObjectID, sColumnName));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return new HREmployeesController().GetObjectFromDataRow(ds.Tables[0].Rows[0]) as HREmployeesInfo;
            return null;
        }
        public static void UpdateApprovalStatus(Object DocInfo, BaseBusinessController DocCtrl, String strApprovalStatus, string strColumnApproval = "")
        {
            if (string.IsNullOrEmpty(strColumnApproval)) strColumnApproval = strColumnNameApproval;
            GMCDbUtil.SetPropertyValue(DocInfo, strColumnApproval, strApprovalStatus);
            DocCtrl.UpdateObject((BusinessObject)DocInfo, false, strColumnApproval, "FK_ADApprovalProcID");
        }
        private static void ApprovalByADApprovalTypeCombo(BaseBusinessController objDocCtrl, Object objDocInfo, string strADApprovalTypeCombo)
        {
            UpdateApprovalByADApprovalTypeCombo(objDocCtrl, objDocInfo, strADApprovalTypeCombo, strApprovalAction_Approved);
        }
        private static void UpdateApprovalByADApprovalTypeCombo(BaseBusinessController objDocCtrl, Object objDocInfo, string strADApprovalTypeCombo, string strApprovalAction)
        {
            #region Approval WBS
            if (strADApprovalTypeCombo == strADApprovalTypeComboWBS)
            {
                Boolean isUpdateApproval = false;
                if (strApprovalAction == strApprovalAction_Approved)
                {
                    isUpdateApproval = true;
                }
                GMCDbUtil.SetPropertyValue(objDocInfo, "PMProjectApprovedWBSCheck", isUpdateApproval);
                objDocCtrl.UpdateObject((BusinessObject)objDocInfo);
            }
            #endregion

            #region Approval EmployeePln
            else if (strADApprovalTypeCombo == strADApprovalTypeComboEmployeePln)
            {
                Boolean isUpdateApproval = false;
                if (strApprovalAction == strApprovalAction_Approved)
                {
                    isUpdateApproval = true;
                }
                GMCDbUtil.SetPropertyValue(objDocInfo, "PMProjectApprovedEmployeePlnCheck", isUpdateApproval);
                objDocCtrl.UpdateObject((BusinessObject)objDocInfo);
            }
            #endregion

            #region Approval CostPlanning
            //else if (strADApprovalTypeCombo == strADApprovalTypeComboCostPlanning)
            //{
            //    Boolean isUpdateApproval = false;
            //    if (strApprovalAction == strApprovalAction_Approved)
            //    {
            //        isUpdateApproval = true;
            //    }
            //    #region Update Project Approval

            //    UpdateApprovalStatus(objDocInfo, objDocCtrl, strApprovalAction);

            //    try
            //    {
            //        int iPMProjectID = Convert.ToInt32(GMCDbUtil.GetPropertyValue(objDocInfo, "FK_PMProjectID"));
            //        PMProjectsInfo objPMProjectInfo = (PMProjectsInfo)new PMProjectsController().GetObjectByID(iPMProjectID);
            //        if (objPMProjectInfo != null)
            //        {
            //            objPMProjectInfo.PMProjectApprovedCostPlanningCheck = isUpdateApproval;
            //            new PMProjectsController().UpdateObject(objPMProjectInfo);
            //        }
            //    }
            //    catch { }
            //    #endregion
            //}
            #endregion

            #region Approval QC
            else if (strADApprovalTypeCombo == strADApprovalTypeComboQC)
            {
                Boolean isUpdateApproval = false;
                if (strApprovalAction == strApprovalAction_Approved)
                {
                    isUpdateApproval = true;
                }
                GMCDbUtil.SetPropertyValue(objDocInfo, "PMProjectApprovedQCCheck", isUpdateApproval);
                objDocCtrl.UpdateObject((BusinessObject)objDocInfo);
            }
            #endregion

            #region Approval HSE
            else if (strADApprovalTypeCombo == strADApprovalTypeComboHSE)
            {
                Boolean isUpdateApproval = false;
                if (strApprovalAction == strApprovalAction_Approved)
                {
                    isUpdateApproval = true;
                }
                GMCDbUtil.SetPropertyValue(objDocInfo, "PMProjectApprovedHSECheck", isUpdateApproval);
                objDocCtrl.UpdateObject((BusinessObject)objDocInfo);
            }
            #endregion

            #region Approval OrgChart
            //else if (strADApprovalTypeCombo == strADApprovalTypeComboOrgChart)
            //{
            //    Boolean isUpdateApproval = false;
            //    if (strApprovalAction == strApprovalAction_Approved)
            //    {
            //        isUpdateApproval = true;
            //    }                

            //    #region Update Project Approval

            //    UpdateApprovalStatus(objDocInfo, objDocCtrl, strApprovalAction);

            //    try
            //    {
            //        int iPMProjectID = Convert.ToInt32(GMCDbUtil.GetPropertyValue(objDocInfo, "FK_PMProjectID"));
            //        PMProjectsInfo objPMProjectInfo = (PMProjectsInfo)new PMProjectsController().GetObjectByID(iPMProjectID);
            //        if (objPMProjectInfo != null)
            //        {
            //            objPMProjectInfo.PMProjectApprovedOrgChartCheck = isUpdateApproval;
            //            new PMProjectsController().UpdateObject(objPMProjectInfo);
            //        }
            //    }
            //    catch { }
            //    #endregion

            //}
            #endregion

            #region Approval WBSProcurement
            else if (strADApprovalTypeCombo == strADApprovalTypeComboWBSProcurement)
            {
                Boolean isUpdateApproval = false;
                if (strApprovalAction == strApprovalAction_Approved)
                {
                    isUpdateApproval = true;
                }
                GMCDbUtil.SetPropertyValue(objDocInfo, "PMProjectApprovedWBSProcurementCheck", isUpdateApproval);
                objDocCtrl.UpdateObject((BusinessObject)objDocInfo);
            }
            #endregion

            #region Approval Engineering
            else if (strADApprovalTypeCombo == strADApprovalTypeComboEngineering)
            {
                Boolean isUpdateApproval = false;
                if (strApprovalAction == strApprovalAction_Approved)
                {
                    isUpdateApproval = true;
                }
                GMCDbUtil.SetPropertyValue(objDocInfo, "PMProjectApprovedEngineeringCheck", isUpdateApproval);
                objDocCtrl.UpdateObject((BusinessObject)objDocInfo);
            }
            #endregion

            #region Approval BiddingPlnEstimator
            else if (strADApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
            {
                string strApproval = "";
                if (strApprovalAction == strApprovalAction_Submit)
                    strApproval = strApprovalStatusInProgress;
                else if (strApprovalAction == strApprovalAction_Approved)
                    strApproval = strApprovalStatusApproved;
                else if (strApprovalAction == strApprovalAction_Rejected)
                    strApproval = strApprovalAction_Rejected;

                GMCDbUtil.SetPropertyValue(objDocInfo, "AREstimatorApprovalStatusCombo", strApproval);
                objDocCtrl.UpdateObject((BusinessObject)objDocInfo);
            }
            #endregion
        }
        private static ADApprovalProcStepsInfo GetApprovalProcStepLevel(ADInboxItemsInfo objInboxItem, object objDocInfo, string sModuleName, ADUsersInfo CurrentUserInfo)
        {
            ADApprovalProcStepsInfo objStepLevel = MailUtil.GetProcStepNextByADApprovalProcStepID(objInboxItem.FK_ADApprovalProcStepID);
            ADApprovalProcStepsInfo objStep = new ADApprovalProcStepsController().GetObjectByID(objInboxItem.FK_ADApprovalProcStepID) as ADApprovalProcStepsInfo;
            if (objStepLevel == null) objStepLevel = new ADApprovalProcStepsInfo();
            if (objStep == null) objStep = new ADApprovalProcStepsInfo();
            objStepLevel.AssignPositions = "";
            objStepLevel.AssignUsers = "";
            if (sModuleName == "EmployeeOffWork")
            {
                double iRegDays = 0;
                object objDays = GMCDbUtil.GetPropertyValue(objDocInfo, "HREmployeeOffWorkRegDays");
                if (objDays != null && objDays != DBNull.Value)
                    iRegDays = Convert.ToDouble(objDays);
                int iEmployeeID = Convert.ToInt32(GMCDbUtil.GetPropertyValue(objDocInfo, "FK_HREmployeeID"));
                HREmployeesInfo objCurrentEmpl = ExpertERP.Controller.EmployeeCtrl.GetObjectByID(iEmployeeID) as HREmployeesInfo;
                if (objStep != null && objStep.ADApprovalProcStepLevel == 1)
                {
                    int iRegionChildID = 0, iEmplLevel1 = 0;
                    string sReadUser = objInboxItem.ADApprovalTypeCombo;
                    iRegionChildID = objCurrentEmpl.FK_HRRegionChildID;
                    iEmplLevel1 = objCurrentEmpl.FK_ReportToEmployeeID;
                    // kiểm tra xem nhân viên submit có phải thuộc vùng mekong ?
                    int iCount = Convert.ToInt32(GMCDbUtil.ExecuteScalar(string.Format("SELECT COUNT(HRRegionNo) FROM HRRegions WHERE HRRegionID = {0} AND HRRegionNo = 'MEK'", iRegionChildID)));
                    // kiểm tra xem nhân viên submit có thuộc khối sale ?
                    int iCountDivision = Convert.ToInt32(GMCDbUtil.ExecuteScalar(string.Format("SELECT COUNT(HRDivisionNo) FROM HRDivisions WHERE HRDivisionID = {0} AND HRDivisionNo = 'DI02'", objCurrentEmpl.FK_HRDivisionID)));
                    // bỏ quy trình cũ vùng khác mekong và số ngày <= 1 => k có quy trình tiếp theo
                    // if NV ko thuộc khối sale
                    if(iCountDivision == 0)
                    {
                        if (iRegDays < 3 && objStep.ADApprovalProcStepLevel == 2) objStepLevel = null;
                        else if (iRegDays >= 3)
                        {
                            ADUsersInfo objUserL1 = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(iEmplLevel1);
                            if (objUserL1 != null)
                            {
                                if (sReadUser == "L" || sReadUser == "L1")
                                {
                                    objInboxItem.ADApprovalTypeCombo = "L1";
                                    if ((objUserL1.ADUserID.Equals(CurrentUserInfo.ADUserID)))
                                        objUserL1 = null;
                                }
                                if (objUserL1 == null && sReadUser == "L1")
                                {
                                    try
                                    {
                                        iEmplLevel1 = Convert.ToInt32(ExpertERP.Controller.DepartmentCtrl.GetObjectColumnByID(objCurrentEmpl.FK_HRDepartmentID, "FK_HREmployeeID"));
                                    }
                                    catch { }
                                    objUserL1 = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(iEmplLevel1);
                                    objInboxItem.ADApprovalTypeCombo = "TL";
                                }
                                else if (sReadUser == "TL" && objUserL1 != null)
                                {
                                    objUserL1 = null;
                                    objInboxItem.ADApprovalTypeCombo = "HRKT";
                                }
                            }
                            if (objUserL1 != null)
                            {
                                GMCUtil.CopyObject(objStep, objStepLevel, true);
                                objStepLevel.AssignUsers = objUserL1.ADUserName + ";";
                                objStepLevel.AssignPositions = "";
                            }
                        }
                        else
                            objInboxItem.ADApprovalTypeCombo = "HRKT";
                        return objStepLevel;
                    }
                    else
                    {
                        ADUsersInfo objUserL1 = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(iEmplLevel1);
                        if (objUserL1 != null)
                        {
                            if (sReadUser == "L" || sReadUser == "L1")
                            {
                                objInboxItem.ADApprovalTypeCombo = "L1";
                                if ((objUserL1.ADUserID.Equals(CurrentUserInfo.ADUserID) && sReadUser == "L1"))
                                    objUserL1 = null;
                            }
                            else objUserL1 = null;
                        }
                        if (objUserL1 == null && sReadUser != "DM")
                        {
                            if ((iCount != 0 || (iCount == 0 && iRegDays >= 3)) && sReadUser != "RSM")
                            {
                                int iRsmApprovalID = 0;
                                try
                                {
                                    iRsmApprovalID = Convert.ToInt32(ExpertERP.Controller.HRAreaCtrl.GetObjectColumnByID(objCurrentEmpl.FK_HRAreaID, "FK_HRRsmApprovalID"));
                                }
                                catch { }
                                objUserL1 = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(iRsmApprovalID);
                                if (objUserL1 == null)
                                {
                                    HREmployeesInfo objEmp = GetEmployeeByPosition("RSM", iRegionChildID, "FK_HRRegionChildID");
                                    if (objEmp != null)
                                        objUserL1 = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(objEmp.HREmployeeID);
                                }
                                objInboxItem.ADApprovalTypeCombo = "RSM";
                            }
                            if (iCount != 0 || (iCount == 0 && iRegDays >= 5))
                            {
                                if (objUserL1 == null || sReadUser == "RSM")
                                {
                                    int iDmApprovalID = 0;
                                    try
                                    {
                                        iDmApprovalID = Convert.ToInt32(ExpertERP.Controller.HRAreaCtrl.GetObjectColumnByID(objCurrentEmpl.FK_HRAreaID, "FK_HRDmApprovalID"));
                                    }
                                    catch { }
                                    objUserL1 = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(iDmApprovalID);
                                    if (objUserL1 == null)
                                    {
                                        HREmployeesInfo objEmp = GetEmployeeByPosition("DM", iRegionChildID, "FK_HRRegionChildID");
                                        if (objEmp != null)
                                            objUserL1 = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(objEmp.HREmployeeID);
                                    }
                                    objInboxItem.ADApprovalTypeCombo = "DM";
                                }
                            }
                            if (objUserL1 == null) objInboxItem.ADApprovalTypeCombo = "HRKT";
                        }
                        else if (objUserL1 == null && sReadUser == "DM") objInboxItem.ADApprovalTypeCombo = "HRKT";
                        if (objUserL1 != null)
                        {
                            GMCUtil.CopyObject(objStep, objStepLevel, true);
                            objStepLevel.AssignUsers = objUserL1.ADUserName + ";";
                            objStepLevel.AssignPositions = "";
                        }
                    }
                }
                else if (iRegDays >= 5 && objInboxItem.ADApprovalTypeCombo != "HRD")
                {
                    objInboxItem.ADApprovalTypeCombo = "HRD";
                    HREmployeesInfo objEmp = GetEmployeeByPosition("HRD", objCurrentEmpl.FK_HRRegionChildID, "FK_HRRegionChildID");
                    ADUsersInfo objUserHRD = ExpertERP.Controller.UserCtrl.GetDataByEmployeeID(objEmp.HREmployeeID);
                    if (objUserHRD != null)
                    {
                        objStepLevel = new ADApprovalProcStepsInfo();
                        GMCUtil.CopyObject(objStep, objStepLevel, true);
                        objStepLevel.AssignUsers = objUserHRD.ADUserName + ";";
                        objStepLevel.AssignPositions = "";
                    }
                }
                else if(iRegDays < 3)
                {
                    objStepLevel = null;
                }
            }
            return objStepLevel;
        }
        #endregion

        #region Reject Document
        public static void RejectDocument(ADInboxItemsInfo InboxItem, ADUsersInfo CurrentUserInfo)
        {
            if (InboxItem == null) return;
            if (String.IsNullOrEmpty(InboxItem.ADInboxItemAction) == false)
                return;

            #region Init Info
            String strTable = InboxItem.ADInboxItemTableName;
            String strPrefix = strTable.Substring(0, strTable.Length - 1);
            #endregion

            #region Update DocStatus
            BaseBusinessController objDocCtrl = BusinessControllerFactory.GetBusinessController(strTable + "Controller");
            Object objDocInfo = objDocCtrl.GetObjectByNo(InboxItem.ADInboxItemDocNo);
            if(objDocInfo == null) objDocInfo = objDocCtrl.GetObjectByID(InboxItem.ADInboxItemObjectID);
            UpdateRejectDoc(InboxItem, objDocCtrl, objDocInfo);

            #endregion

            InboxItem.ADInboxItemAction = strApprovalAction_Rejected;

            #region Get Employee Of User
            int iHREmployeeID = 0;
            string strEmployeeName = CurrentUserInfo.ADUserName;
            HREmployeesInfo objHREmployeeInfo = GMCWebApp.GetEmployeeByUserName(CurrentUserInfo.ADUserName);
            if (objHREmployeeInfo != null)
            {
                iHREmployeeID = objHREmployeeInfo.HREmployeeID;
                strEmployeeName = objHREmployeeInfo.HREmployeeName;
            }
            #endregion

            #region Init History
            CreateHistory(InboxItem, CurrentUserInfo.ADUserName);
            #endregion

            #region Send Mail to Pre Level
            String lstPreLevel = "";
            ADApprovalProcsInfo ApprovalProc = (ADApprovalProcsInfo)new ADApprovalProcsController().GetObjectByID(InboxItem.FK_ADApprovalProcID);

            if (ApprovalProc == null) return;

            //if (ApprovalProc.ADApprovalProcBroadcast)
            //    lstPreLevel = MailUtil.GetListUser_PreLevelByADApprovalProcStepCurrentID(InboxItem.FK_ADApprovalProcStepID, objDocInfo);
            //else
            //{
            //    ADApprovalProcStepsInfo objADApprovalProcStepInfo = (ADApprovalProcStepsInfo)new ADApprovalProcStepsController().GetObjectByID(InboxItem.FK_ADApprovalProcStepID);
            //    if (objADApprovalProcStepInfo != null)
            //        lstPreLevel = MailUtil.GetStringAllUserByADApprovalProcStepCurrent(objADApprovalProcStepInfo, objDocInfo);
            //}
            string strCreateUser = Convert.ToString(GMCDbUtil.GetPropertyValue(objDocInfo, "AACreatedUser"));
            if(string.IsNullOrEmpty(strCreateUser))
            {
                int iEmployeeID = 0;
                object oEmployeeID = GMCDbUtil.GetPropertyValue(objDocInfo, "FK_HREmployeeID");
                try
                {
                    iEmployeeID = Convert.ToInt32(oEmployeeID);
                }
                catch { }
                strCreateUser = GetUserNameByEmployeeID(iEmployeeID);
            }
            if (!string.IsNullOrEmpty(strCreateUser))
                lstPreLevel = strCreateUser + ";";

            if (!string.IsNullOrEmpty(lstPreLevel))
            {
                #region Bỏ User hiện tại nhận thông báo Approved
                if (lstPreLevel.Contains(CurrentUserInfo.ADUserName + ";"))
                {
                    lstPreLevel = lstPreLevel.Replace(CurrentUserInfo.ADUserName + ";", "");
                }
                else if (lstPreLevel.Contains(CurrentUserInfo.ADUserName))
                {
                    lstPreLevel = lstPreLevel.Replace(CurrentUserInfo.ADUserName, "");
                }
                #endregion

                ADInboxItemsInfo InboxItemNew = new ADInboxItemsInfo();
                GMCUtil.CopyObject(InboxItem, InboxItemNew, true);

                InboxItemNew.ADInboxItemID = 0;
                InboxItemNew.FK_HRFromEmployeeID = iHREmployeeID;
                InboxItemNew.ADInboxItemSubject = string.Format(@"{0} rejected {1} {2}-{3}", strEmployeeName, GetSubjectInboxDefault(InboxItem), InboxItem.ADInboxItemDocNo, GetDocumentName(InboxItem.ADInboxItemTableName, InboxItem.ADInboxItemDocNo));
                InboxItemNew.ADInboxItemProtocol = strProtocol_Message;
                InboxItemNew.ADInboxItemDate = DateTime.Now;
                InboxItemNew.ADInboxItemMessage = InboxItem.ADInboxItemRemark;
                InboxItemNew.ADInboxItemAction = strApprovalAction_Rejected;
                InboxItemNew.ADInboxItemDocApprovalStatusCombo = strApprovalAction_Rejected;
                InboxItemNew.ADInboxItemRemark = String.Empty;
                InboxItemNew.FK_ADFromUserID = CurrentUserInfo.ADUserID;
                InboxItemNew.ADMailToUsers = lstPreLevel;
                InboxItemNew.ADMailReadUsers = "";

                InboxItemCtrl.CreateObject(InboxItemNew);

                SendMail(InboxItemNew, lstPreLevel);

                #region Outbox
                ADOutboxItemsInfo OutboxItem = GetOutboxItemApprovalFromInboxItem(InboxItem, CurrentUserInfo.ADUserID);
                OutboxItem.FK_HRFromEmployeeID = iHREmployeeID;
                new ADOutboxItemsController().CreateObject(OutboxItem);
                #endregion
            }
            #endregion

            new ADInboxItemsController().UpdateObject(InboxItem);
        }
        private static void UpdateRejectDoc(ADInboxItemsInfo objADInboxItemInfo, BaseBusinessController objDocCtrl = null, Object objDocInfo = null)
        {
            #region Update ApproveStatus = Reject to Document
            if (objDocCtrl == null)
            {
                String strTable = objADInboxItemInfo.ADInboxItemTableName;
                String strPrefix = strTable.Substring(0, strTable.Length - 1);
                objDocCtrl = BusinessControllerFactory.GetBusinessController(strTable + "Controller");
            }

            if (objDocCtrl == null)
                return;

            if (objDocInfo == null)
            {
                objDocInfo = objDocCtrl.GetObjectByNo(objADInboxItemInfo.ADInboxItemDocNo);
            }

            if (objDocInfo != null)
            {
                //if (string.IsNullOrEmpty(objADInboxItemInfo.ADApprovalTypeCombo))
                //{
                    UpdateApprovalStatus(objDocInfo, objDocCtrl, strApprovalAction_Rejected);
                //}
                //else
                //{
                //    RejectedByADApprovalTypeCombo(objDocCtrl, objDocInfo, objADInboxItemInfo.ADApprovalTypeCombo);
                //}
            }
            #endregion
        }
        private static void RejectedByADApprovalTypeCombo(BaseBusinessController objDocCtrl, Object objDocInfo, string strADApprovalTypeCombo)
        {
            UpdateApprovalByADApprovalTypeCombo(objDocCtrl, objDocInfo, strADApprovalTypeCombo, strApprovalAction_Rejected);
        }
        #endregion

        #region Submit Document
        public static void ActionSubmit(object DocInfo, string sModuleName, string sUserName, out string strError, string strApprovalTypeCombo = "")
        {
            strError = "OK";
            #region Lấy Table Name của đối tượng chứng từ
            String strTableName = GMCUtil.GetTableNameFromBusinessObjectType(DocInfo.GetType());
            String strTableNamePrefix = strTableName.Substring(0, strTableName.Length - 1);
            #endregion

            #region Lấy module info
            STModulesInfo objModule = new STModulesController().GetObjectByName(sModuleName) as STModulesInfo;
            if (objModule == null) return;
            #endregion

            #region Kiểm tra chứng từ có column ApprovalStatusCombo
            //if (GMCDbUtil.ColumnIsExist(strTableName, strColumnNameApproval) == false) return;
            #endregion

            #region Lấy mã số của đối tượng chứng từ
            String DocNo = String.Empty;
            object objDocNo = GMCDbUtil.GetPropertyValue(DocInfo, strTableNamePrefix + "No");
            if (objDocNo != null)
                DocNo = objDocNo.ToString();
            #endregion

            #region Lấy ID của đối tượng chứng từ
            int DocID = 0;
            object objDocID = GMCDbUtil.GetPropertyValue(DocInfo, strTableNamePrefix + "ID");
            if (objDocID != null)
                DocID = (int)objDocID;

            if (DocID == 0)
                return;
            if (String.IsNullOrEmpty(DocNo) && objModule.STModuleType == "Approval")
                return;
            #endregion

            #region Lấy Controller của đối tượng chứng từ
            BaseBusinessController DocCtrl = BusinessControllerFactory.GetBusinessController(strTableName + "Controller");
            if (DocCtrl == null) return;
            #endregion

            #region Lấy giá trị của Column ApprovalStatusCombo trong đối tượng chứng từ
            String strDocApprovalStatus = "";
            Object objDocApprovalStatus = null;
            if (strApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
            {
                objDocApprovalStatus = GMCDbUtil.GetPropertyValue(DocInfo, "AREstimatorApprovalStatusCombo");
            }
            else
            {
                objDocApprovalStatus = GMCDbUtil.GetPropertyValue(DocInfo, strColumnNameApproval);
            }
            if (objDocApprovalStatus != null)
                strDocApprovalStatus = objDocApprovalStatus.ToString();

            #endregion

            #region Nếu trạng thái chứng từ là đã phê duyệt thì cập nhật lại trạng thái NEW để gửi lại phê duyệt.
            if (strDocApprovalStatus == strApprovalStatusApproved)
            {
                if (strApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
                {
                    GMCDbUtil.SetPropertyValue(DocInfo, "AREstimatorApprovalStatusCombo", strApprovalStatusNew);
                }
                else
                {
                    GMCDbUtil.SetPropertyValue(DocInfo, strColumnNameApproval, strApprovalStatusNew);
                }
                strDocApprovalStatus = strApprovalStatusNew;
            }
            #endregion

            int iEmplevel = 0, iApprovalProcID = 0, iApprovalProcStepID = 0;
            string DocType = sModuleName, sMailToUser = "", sMailCCUser = "", sPositionName = "";
            sUserRequest = sUserName;
            HREmployeesController EmployeeCtrl = new HREmployeesController();
            HRPositionsController PositionCtrl = new HRPositionsController();
            #region Lấy nhân viên quản lý (chỉ dành cho nhân sự)
            if (sModuleName == "EmployeeOffWork")
            {
                if (Convert.ToBoolean(GMCDbUtil.GetPropertyValue(DocInfo, "HREmployeeOffWorkHelpCheck")))
                    sUserRequest = GetUserNameByEmployeeID(Convert.ToInt32(GMCDbUtil.GetPropertyValue(DocInfo, "FK_HREmployeeID")));
                HREmployeesInfo objCurrentEmpl = GMCWebApp.GetEmployeeByUserName(sUserName);
                HREmployeesInfo objEmpl = GMCWebApp.GetEmployeeByUserName(sUserRequest);
                iEmplevel = objEmpl.FK_HREmployeeManagerID;
                sPositionName = PositionCtrl.GetObjectNoByID(objEmpl.FK_HRPositionID);
                if (objEmpl.FK_HREmployeeManagerID == objCurrentEmpl.HREmployeeID)
                    iEmplevel = objEmpl.FK_ReportToEmployeeID;
                object oUserManager = EmployeeCtrl.GetObjectColumnByID(iEmplevel,"FK_ADUserID");
                if(oUserManager != null && oUserManager != DBNull.Value)
                {
                    sMailToUser = new ADUsersController().GetObjectNameByID(Convert.ToInt32(oUserManager)) + ";";
                }
            }
            #endregion

            #region Lấy quy trình phê duyệt của chứng từ
            ADApprovalProcsInfo ApprovalProc = GetADApprovalProcByModuleAndUserName(sModuleName, sUserRequest, sPositionName);
            if (ApprovalProc == null) strError = string.Format("Người dùng {0} này chưa cấu hình quy trình phê duyệt! Không thể gửi phê duyệt! \n Vui lòng kiểm tra lại", sUserName);
            if (ApprovalProc != null)
            {
                DocType = ApprovalProc.ADDocumentType;
                GMCDbUtil.SetPropertyValue(DocInfo, "FK_ADApprovalProcID", ApprovalProc.ADApprovalProcID);
                iApprovalProcID = ApprovalProc.ADApprovalProcID;
            }
            #endregion

            #region Lấy Level của quy trình phê duyệt theo User hiện tại
            //ExpertERP.BaseProvider.GMCWebApp.CurrentUser;
                                     //object objProp = GMCDbUtil.GetPropertyValue(DocInfo, "AACreatedUser");
                                     //if (objProp != null)
                                     //{
                                     //    sUserRequest = Convert.ToString(objProp);
                                     //}

            ADApprovalProcStepsInfo ApprovalProcStep = null;
            if (ApprovalProc != null)
                ApprovalProcStep = MailUtil.GetProcStepByUserNameAndProcID(sUserRequest.Length == 0 ? GMCWebApp.CurrentUser : sUserRequest, ApprovalProc.ADApprovalProcID, DocInfo);
            if (ApprovalProcStep != null) iApprovalProcStepID = ApprovalProcStep.ADApprovalProcStepID;
            #endregion

            if (iEmplevel == 0)
            {
                #region Lấy quy trình phê duyệt kê tiếp
                ADApprovalProcStepsInfo objADApprovalProcStepNextInfo = null;
                if (ApprovalProcStep != null)
                {
                    objADApprovalProcStepNextInfo = MailUtil.GetProcStepNextByADApprovalProcStepID(ApprovalProcStep.ADApprovalProcStepID);
                    if (objADApprovalProcStepNextInfo != null)
                        iApprovalProcStepID = objADApprovalProcStepNextInfo.ADApprovalProcStepID;
                }
                #endregion

                #region Kiểm tra nếu k có quy trình phê duyệt thì approval
                //Nếu chứng từ không có quy trình phê duyệt thì cập nhật trạng thái chứng từ là đã phê duyệt
                if (ApprovalProc == null)
                {
                    if (strApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
                    {
                        UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved, "AREstimatorApprovalStatusCombo");
                    }
                    else
                    {
                        UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved);
                    }
                    return;
                }
                #endregion

                #region Tự động phê duyệt khi nằm ngoài điều kiện truy vấn trong quy trình phê duyệt chứng từ
                if (!String.IsNullOrEmpty(ApprovalProc.DocumentQueryCritical) && ApprovalProc.DocumentQueryCritical.Trim().Length > 0)
                {
                    String strQueryCritical = String.Format(@"SELECT * FROM {0} WHERE AAStatus = 'Alive' AND {1}ID = {2} AND {3}", strTableName, strTableNamePrefix, DocID, ApprovalProc.DocumentQueryCritical);
                    DataSet ds = DocCtrl.GetDataSet(strQueryCritical);
                    if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    {
                        if (strApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
                        {
                            UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved, "AREstimatorApprovalStatusCombo");
                        }
                        else
                        {
                            UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved);
                        }
                        return;
                    }
                }
                #endregion

                #region Nếu không có Level nào thỏa User hiện tại thì tự động cập nhật đã duyệt chứng từ
                if (ApprovalProcStep == null)
                {
                    if (strApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
                    {
                        UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved, "AREstimatorApprovalStatusCombo");
                    }
                    else
                    {
                        UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved);
                    }
                    return;
                }
                #endregion

                #region Lấy quy trình phê duyệt kê tiếp
                if (objADApprovalProcStepNextInfo == null)
                {
                    if (strApprovalTypeCombo == strADApprovalTypeComboBiddingPlnEstimator)
                    {
                        UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved, "AREstimatorApprovalStatusCombo");
                    }
                    else
                    {
                        UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproved);
                    }
                    return;
                }
                #endregion

                sMailToUser = MailUtil.GetStringUserByADApprovalProcStepCurrent(objADApprovalProcStepNextInfo, DocInfo);
                sMailCCUser = MailUtil.GetStringUserCCByADApprovalProcStepCurrent(objADApprovalProcStepNextInfo, DocInfo);
            }

            #region Tạo đối tượng InboxItem để gửi phê duyệt
            //Update trạng thái chờ duyệt cho chứng từ
            GMCDbUtil.SetPropertyValue(DocInfo, "FK_ADApprovalProcID", iApprovalProcID);
            UpdateApprovalStatus(DocInfo, DocCtrl, strApprovalStatusApproving);

            ADInboxItemsInfo InboxItem = new ADInboxItemsInfo();
            InboxItem.FK_ADApprovalProcID = iApprovalProcID;
            InboxItem.ADInboxItemDocNo = DocNo;
            InboxItem.ADInboxItemTaskStatusCombo = strApprovalAction_Submit;
            InboxItem.ADInboxItemProtocol = MailUtil.strProtocol_Approval;
            InboxItem.ADInboxItemPriorityCombo = "Medium";
            InboxItem.ADInboxItemDate = DateTime.Now;
            InboxItem.ADInboxItemDeadline = DateTime.Now.AddDays(1);
            InboxItem.ADInboxItemTableName = strTableName;
            InboxItem.ADInboxItemObjectID = DocID;
            if (string.IsNullOrEmpty(strApprovalTypeCombo)) strApprovalTypeCombo = SetADApprovalTypeComboByModule(DocType);
            InboxItem.ADApprovalTypeCombo = strApprovalTypeCombo;
            InboxItem.ADInboxItemAction = strApprovalAction_Submit;

            //H.Việt - Thêm trạng thái chờ phê duyệt ghi gửi 
            InboxItem.ADInboxItemDocApprovalStatusCombo = strApprovalStatusInProgress;

            #region Nếu trạng thái chứng từ hiện tại là đang chờ phê duyệt
            if (strDocApprovalStatus == strApprovalStatusInProgress || CheckAllowSubmitDoc(InboxItem) == false)
            {
                //GMCMsgBox.Show("Phiếu này đang chờ phê duyệt trước đó, vui lòng chờ kết quả phê duyệt!");
                return;
            }
            #endregion
            string strEmployeeName = "";
            ADUsersInfo User = (ADUsersInfo)new ADUsersController().GetObjectByName(sUserRequest == sUserName ? sUserRequest : sUserName);
            if (User != null)
            {
                InboxItem.FK_ADFromUserID = User.ADUserID;
                strEmployeeName = User.ADUserName;
                HREmployeesInfo CurrentEmployee = GMCWebApp.GetEmployeeByUserName(sUserRequest == sUserName ? sUserRequest : sUserName);
                if (CurrentEmployee != null)
                {
                    InboxItem.FK_HRFromEmployeeID = CurrentEmployee.HREmployeeID;
                    strEmployeeName = CurrentEmployee.HREmployeeName;
                }
            }
            if (iEmplevel > 0)
            {
                HREmployeesInfo objEmpLevel = EmployeeCtrl.GetObjectByID(iEmplevel) as HREmployeesInfo;
                if (objEmpLevel != null)
                {
                    InboxItem.FK_ADToUserID = objEmpLevel.FK_ADUserID;
                }
            }

            InboxItem.ADInboxItemSubject = string.Format("{0} submit {1} {2}", strEmployeeName, GetSubjectInboxDefault(InboxItem), InboxItem.ADInboxItemDocNo);

            InboxItem.FK_ADApprovalProcStepID = iApprovalProcStepID;
            InboxItem.ADInboxItemDocType = DocType;
            InboxItem.ADMailToUsers = sMailToUser;
            InboxItem.ADMailCCUsers = sMailCCUser;
            //MailModule.CurrentModuleEntity.ModuleObjects["ADInboxItems"] = InboxItem;
            //MailModule.CurrentModuleEntity.UpdateModuleObjectBindingSource("ADInboxItems");

            SubmitDocument(InboxItem, User);
            //vuong add 160511, send email sau khi submit
            //SendMail(InboxItem, InboxItem.ADMailToUsers, InboxItem.ADMailCCUsers);

            #endregion
        }
        public static void SubmitDocument(ADInboxItemsInfo InboxItem, ADUsersInfo CurrentUserInfo)
        {
            InboxItem.ADInboxItemAction = "";
            InboxItem.ADMailReadUsers = "";
            new ADInboxItemsController().CreateObject(InboxItem);

            #region Outbox
            ADOutboxItemsInfo OutboxItem = GetOutboxItemApprovalFromInboxItem(InboxItem, CurrentUserInfo.ADUserID);
            new ADOutboxItemsController().CreateObject(OutboxItem);

            SendMail(InboxItem, OutboxItem.ADMailToUsers, OutboxItem.ADMailCCUsers);
            #endregion

            #region Update DocumentStatus
            String strTable = InboxItem.ADInboxItemTableName;
            String strPrefix = strTable.Substring(0, strTable.Length - 1);
            BaseBusinessController objDocCtrl = BusinessControllerFactory.GetBusinessController(strTable + "Controller");

            if (objDocCtrl != null)
            {
                Object objDocInfo = objDocCtrl.GetObjectByNo(InboxItem.ADInboxItemDocNo);
                if(objDocInfo == null) objDocInfo = objDocCtrl.GetObjectByID(InboxItem.ADInboxItemObjectID);
                if (objDocInfo != null)
                {
                    //if (string.IsNullOrEmpty(InboxItem.ADApprovalTypeCombo))
                    //{
                    GMCDbUtil.SetPropertyValue(objDocInfo, "FK_ADApprovalProcID", InboxItem.FK_ADApprovalProcID);
                    UpdateApprovalStatus(objDocInfo, objDocCtrl, strApprovalStatusInProgress);
                    //}
                    //else
                    //{
                    //    SubmitByADApprovalTypeCombo(objDocCtrl, objDocInfo, InboxItem.ADApprovalTypeCombo);
                    //}
                }
            }
            #endregion

            #region Init Comment
            //Lấy lại bước duyệt hiện tại để lưu lịch sử. Để biết người gửi phê duyệt đang ở bước nào.
            ADApprovalProcStepsInfo objADApprovalProcStepPreInfo = new ADApprovalProcStepsController().GetProcStepPreByADApprovalProcStepID(InboxItem.FK_ADApprovalProcStepID);
            if (objADApprovalProcStepPreInfo != null)
                InboxItem.FK_ADApprovalProcStepID = objADApprovalProcStepPreInfo.ADApprovalProcStepID;

            InboxItem.ADInboxItemRemark = InboxItem.ADInboxItemMessage;
            CreateHistory(InboxItem, CurrentUserInfo.ADUserName);
            #endregion
        }
        private static void SubmitByADApprovalTypeCombo(BaseBusinessController objDocCtrl, Object objDocInfo, string strADApprovalTypeCombo)
        {
            UpdateApprovalByADApprovalTypeCombo(objDocCtrl, objDocInfo, strADApprovalTypeCombo, strApprovalAction_Submit);
        }
        public static ADApprovalProcStepsInfo GetProcStepByUserNameAndProcID(string strUserName, int iADApprovalProcID, Object objDocInfo = null)
        {
            ADApprovalProcStepsController objADApprovalProcStepCtrl = new ADApprovalProcStepsController();
            HRPositionsController objHRPositionCtrl = new HRPositionsController();
            //PMProjectOrgChartItemsController objPMProjectOrgChartItemCtrl = new PMProjectOrgChartItemsController();
            HREmployeesController objHREmployeeCtrl = new HREmployeesController();
            ADUsersController objADUserCtrl = new ADUsersController();

            HREmployeesInfo objHREmployeeOfUserInfo = GMCWebApp.GetEmployeeByUserName(strUserName);

            #region Lấy Table Name của đối tượng chứng từ
            String strTableName = "";
            if (objDocInfo != null)
                strTableName = GMCUtil.GetTableNameFromBusinessObjectType(objDocInfo.GetType());
            #endregion

            //Lấy danh sách bước quy trình phê duyệt theo Level từ cao xuống thấp để kiểm tra User hiện tại gần cấp duyệt nhất
            DataSet dsADApprovalProcSteps = objADApprovalProcStepCtrl.GetAllProcStepByADApprovalProcID(iADApprovalProcID);
            List<BusinessObject> lstADApprovalProcSteps = objADApprovalProcStepCtrl.GetListFromDataset(dsADApprovalProcSteps);
            foreach (ADApprovalProcStepsInfo objADApprovalProcStepInfo in lstADApprovalProcSteps)
            {
                #region Kiểm tra user tồn tại
                if (objADApprovalProcStepInfo.AssignUsers.Split(';').Where(x => x.Equals(strUserName)).Count() > 0)
                    return objADApprovalProcStepInfo;
                #endregion

                #region Kiểm tra vị trí
                if (string.IsNullOrEmpty(objADApprovalProcStepInfo.AssignPositions)) continue;
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetDataUserNameByPosition", objADApprovalProcStepInfo.AssignPositions.TrimEnd(';'));
                if(ds != null && ds.Tables.Count > 0)
                    if(ds.Tables[0].Select(string.Format("ADUserName = '{0}'", strUserName)).Length > 0)
                        return objADApprovalProcStepInfo;
                #endregion
            }

            return lstADApprovalProcSteps.Cast<ADApprovalProcStepsInfo>().Where(x => x.ADApprovalProcStepLevel == 1).FirstOrDefault();
        }
        private static string SetADApprovalTypeComboByModule(string strModuleName)
        {
            string strADApprovalTypeCombo = "";
            #region Approval WBS
            if (strModuleName == "WBSActivities")
                strADApprovalTypeCombo = strADApprovalTypeComboWBS;
            #endregion

            #region Approval EmployeePln
            if (strModuleName == "ProjectEmpPln")
                strADApprovalTypeCombo = strADApprovalTypeComboEmployeePln;
            #endregion

            #region Approval CostPlanning
            if (strModuleName == "CostPlanning")
                strADApprovalTypeCombo = strADApprovalTypeComboCostPlanning;
            #endregion

            #region Approval QC
            if (strModuleName == "PMQCStep")
                strADApprovalTypeCombo = strADApprovalTypeComboQC;
            #endregion

            #region Approval HSE
            if (strModuleName == "RiskAssessmentRegister")
                strADApprovalTypeCombo = strADApprovalTypeComboHSE;
            #endregion

            #region Approval OrgChart
            if (strModuleName == "ProjectOrgChart")
                strADApprovalTypeCombo = strADApprovalTypeComboOrgChart;
            #endregion

            #region Approval WBSProcurement
            if (strModuleName == "Procurement")
                strADApprovalTypeCombo = strADApprovalTypeComboWBSProcurement;
            #endregion

            #region Approval Engineering
            if (strModuleName == "Engineering")
                strADApprovalTypeCombo = strADApprovalTypeComboEngineering;
            #endregion

            if (strModuleName == "EmployeeOffWork")
                strADApprovalTypeCombo = "L";

            return strADApprovalTypeCombo;
        }
        private static Boolean CheckAllowSubmitDoc(ADInboxItemsInfo objADInboxItemInfo)
        {
            //ADApprovalProcSteps được lưu trong ADInboxItems và ADDocHistorys có level Max là Level "CUỐI" trong cấu hình phê duyệt.
            //Level hiện tại (T), Level kế tiếp (T + 1)
            //Lấy lịch sử phê duyệt cuối cùng nhất của chứng từ. Nếu Action là Reject thì đã xong.
            //Ngược lại, Nếu T + 1 tồn tại thì Quy trình phê duyệt chưa xong, tức là đang phê duyệt.
            //Ngược lại (T + 1 không tồn tại) tức là Level hiện tại là duyệt cuối cùng thì kiểm tra Inbox cuối cùng đã duyệt chưa? Nếu chưa duyệt (Action == "") thì phiếu đang chờ duyệt, ngược lại thì phiếu đã duyệt.
            ADDocHistorysController objADDocHistoryCtrl = new ADDocHistorysController();
            ADInboxItemsController objADInboxItemCtrl = new ADInboxItemsController();
            //Lấy lịch sử duyệt cuối cùng của chứng từ
            ADDocHistorysInfo objADDocHistoryInfo = objADDocHistoryCtrl.GetLastDocHistory(objADInboxItemInfo.ADInboxItemDocType, objADInboxItemInfo.ADInboxItemDocNo, objADInboxItemInfo.ADInboxItemObjectID, objADInboxItemInfo.ADInboxItemTableName, objADInboxItemInfo.ADApprovalTypeCombo, objADInboxItemInfo.FK_ADApprovalProcID);
            if (objADDocHistoryInfo != null && objADDocHistoryInfo.Action != strApprovalAction_Rejected)
            {
                //Lấy bước Level Kế tiếp theo bước Level Lịch sử cuối cùng
                ADApprovalProcStepsInfo objADApprovalProcStepNextInfo = GetProcStepNextByADApprovalProcStepID(objADDocHistoryInfo.FK_ADApprovalProdStepID);
                if (objADApprovalProcStepNextInfo != null)
                {
                    //Nếu lịch sử cuối cùng mà có level không phải Level cuối cùng trong quy trình phê duyệt
                    //thì trả về FALSE: Chưa duyệt xong
                    return false;
                }
                else
                {
                    ADInboxItemsInfo objADInboxItemLastInfo = objADInboxItemCtrl.GetLastInbox(objADInboxItemInfo.ADInboxItemDocType, objADInboxItemInfo.ADInboxItemDocNo, objADInboxItemInfo.ADInboxItemTableName, objADInboxItemInfo.ADInboxItemObjectID, objADInboxItemInfo.ADInboxItemProtocol, objADInboxItemInfo.ADApprovalTypeCombo, objADInboxItemInfo.FK_ADApprovalProcID, objADInboxItemInfo.FK_ADApprovalProcStepID);
                    if (objADInboxItemLastInfo != null && string.IsNullOrEmpty(objADInboxItemLastInfo.ADInboxItemAction))
                        return false;
                }
            }
            //Đã duyệt xong hoặc chưa có phê duyệt.
            return true;
        }
        #endregion

        #region Cancel Document
        public static void CancelDocument(object DocInfo, string sModuleName)
        {
            #region Lấy Table Name của đối tượng chứng từ
            String strTableName = GMCUtil.GetTableNameFromBusinessObjectType(DocInfo.GetType());
            String strTableNamePrefix = strTableName.Substring(0, strTableName.Length - 1);
            #endregion

            #region Lấy module info
            STModulesInfo objModule = new STModulesController().GetObjectByName(sModuleName) as STModulesInfo;
            if (objModule == null) return;
            #endregion

            #region Lấy ID của đối tượng chứng từ
            int DocID = 0;
            object objDocID = GMCDbUtil.GetPropertyValue(DocInfo, strTableNamePrefix + "ID");
            if (objDocID != null)
                DocID = (int)objDocID;

            if (DocID == 0)
                return;
            #endregion

            #region Lấy Controller của đối tượng chứng từ
            BaseBusinessController DocCtrl = BusinessControllerFactory.GetBusinessController(strTableName + "Controller");
            if (DocCtrl == null) return;
            #endregion

            GMCDbUtil.SetPropertyValue(DocInfo, "AAStatus", "Cancel");
            DocCtrl.UpdateObject(DocInfo as BusinessObject, true, "AAStatus", "HREmployeeOffWorkCancelReason", "HREmployeeOffWorkCancelDate", "HREmployeeOffWorkCancelUser");

            GMCDbUtil.ExecuteScalar(string.Format(@"UPDATE ADDocHistorys SET Action = '{0}' WHERE ObjectID = {1} AND DocType = '{2}'", "Cancel", DocID, sModuleName));
        }
        #endregion
        private static void CreateHistory(ADInboxItemsInfo objADInboxItemInfo, string strUserName)
        {
            ADDocHistorysInfo DocHistory = new ADDocHistorysInfo();
            DocHistory.DocNo = objADInboxItemInfo.ADInboxItemDocNo;
            DocHistory.DocType = objADInboxItemInfo.ADInboxItemDocType;
            DocHistory.Remark = objADInboxItemInfo.ADInboxItemRemark;
            DocHistory.FK_ADApprovalProcID = objADInboxItemInfo.FK_ADApprovalProcID;
            DocHistory.FK_ADApprovalProdStepID = objADInboxItemInfo.FK_ADApprovalProcStepID;
            DocHistory.Action = objADInboxItemInfo.ADInboxItemAction;
            DocHistory.TableName = objADInboxItemInfo.ADInboxItemTableName;
            DocHistory.ADApprovalTypeCombo = objADInboxItemInfo.ADApprovalTypeCombo;
            DocHistory.ObjectID = objADInboxItemInfo.ADInboxItemObjectID;
            DocHistory.UserName = strUserName;
            DocHistory.Date = DateTime.Now;
            //DocHistory.PositionNo = GetObjectNoByUser(strUserName);
            DocHistoryCtrl.CreateObject(DocHistory);
        }
        public static string GetObjectNoByUser(string strUserName)
        {
            string strQuery = String.Format(@"
SELECT HRPositionNo 
    FROM HRPositions a
        INNER JOIN HREmployees b ON a.HRPositionID = b.FK_HRPositionID
            AND a.AAStatus = 'Alive'
            AND b.AAStatus = 'Alive'
        INNER JOIN ADUsers c ON b.FK_ADUserID = c.ADUserID
            AND c.AAStatus = 'Alive'
            AND c.ADUserName = '{0}'
"
                , strUserName);
            DataSet ds = GMCDbUtil.ExecuteQuery(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (string)ds.Tables[0].Rows[0][0];
            }
            return "";
        }
        public static DataTable GetListInboxItem_ByUserName(string strUserName)
        {
            DataTable dt = new DataTable();
            DataSet ds = new ADInboxItemsController().GetAllInboxItemsByUser(strUserName);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                dt = ds.Tables[0].Select("", "ADInboxItemDate DESC").CopyToDataTable();
            return dt;
        }
        public static DataTable GetListOutboxItem_ByUserName(string strUserName)
        {
            DataTable dt = new DataTable();
            DataSet ds = new ADOutboxItemsController().GetAllOutboxItemsByUser(new ADUsersController().GetObjectIDByName(strUserName));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                dt = ds.Tables[0].Select("", "ADOutboxItemDate DESC").CopyToDataTable();
            return dt;
        }
        public static DataTable GetListInboxItemByUserNameAndDocType(string strUserName, string strDocType, string strApprovalStatus = "")
        {
            DataTable dt = new DataTable();
            DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetAllInboxItemByUserAndDocTypeAndStatus", strUserName, strDocType, strApprovalStatus);
            if (ds != null && ds.Tables.Count > 0)
                dt = ds.Tables[0];
            return dt;
        }
        public static void SetMailConfig(string strWebEmail, string strWebEmailServer, string strWebEmailUser, string strWebEmailPass, int strWebEmailPort)
        {
            WebEmail = strWebEmail;
            WebEmailServer = strWebEmailServer;
            WebEmailUser = strWebEmailUser;
            WebEmailPass = strWebEmailPass;
            WebEmailPort = strWebEmailPort;
        }
        public static void SendMail(ADInboxItemsInfo InboxItem, string strToUsers, string strCCUsers = "", bool isApproval = false)
        {
            #region Lấy danh sách Email để gửi
            if (string.IsNullOrEmpty(strToUsers)) return;
            List<String> arrToUsers = strToUsers.Split(';').ToList();
            if (arrToUsers.Count == 0) return;
            arrToUsers.RemoveAll(x => string.IsNullOrEmpty(x));

            List<string> lstEmail = new List<string>();
            if (arrToUsers.Count > 0)
            {
                //dùng store để tăng tốc độ truy vấn
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetDataEmployeeEmailByUserName", string.Join(";", arrToUsers.Distinct()));
                if (ds != null && ds.Tables.Count > 0)
                    lstEmail.AddRange(ds.Tables[0].Rows.Cast<DataRow>().Select(x => x.Field<string>("HREmployeeEmail")).ToList());
                lstEmail.RemoveAll(x => !GMCUtil.isValidEmail(x));
            }
            if (lstEmail.Count == 0) return;
            //foreach (string strUser in arrToUsers)
            //{
            //    ADUsersInfo User = (ADUsersInfo)UserCtrl.GetObjectByName(strUser);
            //    if (User == null) continue;
            //    HREmployeesInfo Employee = (HREmployeesInfo)new HREmployeesController().GetFirstObjectByForeignColumn("FK_ADUserID", User.ADUserID);
            //    if (Employee != null)
            //    {
            //        if (!string.IsNullOrEmpty(Employee.HREmployeeEmail))
            //            lstEmail.Add(Employee.HREmployeeEmail);
            //    }
            //}
            //lstEmail.Add("huuvinh.nguyen@gmconsulting.com.vn");
            #endregion

            #region Lấy danh sách Email CC để gửi
            List<String> arrCCUsers = strCCUsers.Split(';').ToList();
            if (arrCCUsers.Count == 0) return;
            arrCCUsers.RemoveAll(x => string.IsNullOrEmpty(x));

            List<string> lstEmailCC = new List<string>();
            //dùng store để tăng tốc độ truy vấn
            if (arrCCUsers.Count > 0)
            {
                DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetDataEmployeeEmailByUserName", string.Join(";", arrCCUsers.Distinct()));
                if (ds != null && ds.Tables.Count > 0)
                    lstEmailCC.AddRange(ds.Tables[0].Rows.Cast<DataRow>().Select(x => x.Field<string>("HREmployeeEmail")).ToList());
                lstEmailCC.RemoveAll(x => !GMCUtil.isValidEmail(x));
            }
            //foreach (string strUser in arrCCUsers)
            //{
            //    ADUsersInfo User = (ADUsersInfo)UserCtrl.GetObjectByName(strUser);
            //    if (User == null) continue;
            //    HREmployeesInfo Employee = (HREmployeesInfo)new HREmployeesController().GetFirstObjectByForeignColumn("FK_ADUserID", User.ADUserID);
            //    if (Employee != null)
            //    {
            //        if (!string.IsNullOrEmpty(Employee.HREmployeeEmail))
            //            lstEmailCC.Add(Employee.HREmployeeEmail);
            //    }
            //}
            #endregion

            #region Infor Send Mail
            string strMailForm = WebEmail;
            string strMailServer = WebEmailServer;
            string strMailUser = WebEmailUser;
            string strMailPass = WebEmailPass;
            int strMailPort = WebEmailPort;
            HREmployeeOffWorksInfo objInfo = new HREmployeeOffWorksController().GetObjectByID(InboxItem.ADInboxItemObjectID) as HREmployeeOffWorksInfo;
            string sEmployeeName = Convert.ToString(new HREmployeesController().GetObjectColumnByID(objInfo.FK_HREmployeeID, "HREmployeeFullName"));
            string strSubject = "V/v: Thông báo duyệt đăng ký phép";
            string strContent = "Kính gửi anh/chị <br/>" + GMCUtil.NewLine;
            if(!isApproval)
                strContent += GetMailContentSubmit(objInfo);
            else
                strContent += GetMailContentApproval(objInfo, InboxItem);
            #endregion

            SendMail cSendMail = new SendMail();
            cSendMail.Send(strMailForm, strMailPass, lstEmail, lstEmailCC, strSubject, strContent, strMailServer, strMailPort, true, false, null);
            //ExpertERP.Procedure.GEUtilities.SendEmail(InboxItem, lstEmail, lstEmailCC);
        }
        private static string GetMailContentSubmit(HREmployeeOffWorksInfo objInfo)
        {
            string sEmployeeName = Convert.ToString(new HREmployeesController().GetObjectColumnByID(objInfo.FK_HREmployeeID, "HREmployeeFullName"));
            string strContent = string.Format("Anh chị nhận được 1 yêu cầu xin nghỉ phép của nhân viên: <b>{0}</b> <br/>", sEmployeeName) + GMCUtil.NewLine;
            strContent += string.Format("Thời gian nghỉ phép từ ngày: <b>{0} - {1}</b> <br/>", objInfo.HREmployeeOffWorkFromDate.Value.ToShortDateString(), objInfo.HREmployeeOffWorkToDate.Value.ToShortDateString()) + GMCUtil.NewLine;
            strContent += string.Format("Lý do nghỉ phép: <b>{0}</b> <br/>", objInfo.HREmployeeOffWorkReasonDetail) + GMCUtil.NewLine;
            strContent += "Anh/chị vui lòng đăng nhập vào web portal để duyệt phép cho nhân viên. <br/>" + GMCUtil.NewLine;
            strContent += string.Format("<a href=\"{0}/MailManagement?type=InProgress\">{0}/MailManagement?type=InProgress</a>", sUrlHost);
            return strContent;
        }
        private static string GetMailContentApproval(HREmployeeOffWorksInfo objInfo, ADInboxItemsInfo inboxInfo)
        {
            string sEmployeeName = Convert.ToString(new HREmployeesController().GetObjectColumnByID(objInfo.FK_HREmployeeID, "HREmployeeFullName"));
            string strContent = string.Format("Đơn xin nghỉ phép của anh/chị ngày: <b>{0} - {1}</b> đã được phê duyệt <br/>", objInfo.HREmployeeOffWorkFromDate.Value.ToShortDateString(), objInfo.HREmployeeOffWorkToDate.Value.ToShortDateString()) + GMCUtil.NewLine;
            strContent += string.Format("Nôi dung phê duyệt: <b>{0}</b> <br/>", inboxInfo.ADInboxItemMessage) + GMCUtil.NewLine;
            strContent += "Anh/chị vui lòng đăng nhập vào web portal để xem nội dung chi tiết. <br/>" + GMCUtil.NewLine;
            strContent += string.Format("<a href=\"{0}/MailManagement?type=InProgress\">{0}/MailManagement?type=InProgress</a>", sUrlHost);
            return strContent;
        }
    }

    public class NumberToWord
    {
        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        private static string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }

        private static string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

            }


            return Ktach;

        }

        public static string NumToWord(double gNum)
        {
            if (gNum == 0)
                return "Không đồng";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(gNum, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            // Dau [+ , - ]
            if (gNum < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng chẵn.";

            return lso_chu.ToString().Trim();

        }
    }
}