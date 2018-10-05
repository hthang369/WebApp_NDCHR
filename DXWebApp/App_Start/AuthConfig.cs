using System.Xml.Linq;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Data;
using ExpertWebLib;
using ExpertERPWeb.BaseEntities;
using ExpertERP.BusinessEntities;
using DevExpress.Web.Localization;

namespace DXWebApp
{
    public static class AuthConfig
    {
        private static CSCompanysInfo CurrenCompanyInfo = null;
        public static CSCompanysInfo CurrentCompanyInfo { get; set; }
        public static ADUserGroupsInfo CurrenUserGroupInfo { get; set; }
        public static ADUsersInfo CurrenUserInfo { get; set; }
        public static string strFilePath = @"~/App_Data/ListServer.xml";
        public static string strCfgPath = @"~/App_Data/config.xml";

        public static void RegisterAuth() {
        }
        public static object GetSession(string name)
        {
            return HttpContext.Current.Session[name];
        }
        public static void SetSession(string name, object value)
        {
            HttpContext.Current.Session.Add(name, value);
        }
        public static void SetCookie(string name, string value)
        {
            HttpCookie cookie = null;
            if (HttpContext.Current.Response.Cookies.AllKeys.Length == 0 || !HttpContext.Current.Response.Cookies.AllKeys.Contains(name))
            {
                cookie = new HttpCookie(name, value);
                cookie.Expires = DateTime.Now.AddMonths(1);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            else
            {
                cookie = HttpContext.Current.Response.Cookies.Get(name);
                if (cookie != null)
                {
                    cookie.Value = value;
                }       
            }
        }
        public static string GetCookie(string name)
        {
            if (HttpContext.Current.Request.Cookies.AllKeys.Length == 0)
                return string.Empty;
            else if (!HttpContext.Current.Request.Cookies.AllKeys.Contains(name))
                return string.Empty;
            else
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies.Get(name);
                if (cookie != null)
                    return cookie.Value;
                return string.Empty;
            }
        }
        public static void ConnectionAuth(string strServer)
        {
            XDocument xDoc = XDocument.Load(System.Web.HttpContext.Current.Server.MapPath(strFilePath));
            var xElements = xDoc.Element("Servers").Elements("item").Where(x=>x.Attribute("Name").Value.Equals(strServer));
            XElement xElement = xElements.FirstOrDefault();
            if (xElement == null) return;
            string strSrv = xElement.Attribute("Server").Value;
            string strDBName = xElement.Attribute("Database").Value;
            SetSession("CurrentServer", strSrv);
            SetSession("CurrentDatabase", strDBName);
            SqlDatabaseHelper.SwitchConnection(string.Format(System.Configuration.ConfigurationManager.ConnectionStrings["MyDbConn"].ToString(), strSrv, strDBName));
        }
        public static string LogIn(string strSrv, string strUser, string strPassword, System.DateTime dt)
        {
            ConnectionAuth(strSrv);
            if (!SqlDatabaseHelper.TestConnection())
                return "Không kết nối được CSDL! Vui lòng liên hệ người quản trị!";
            ADUsersController ADUserCtrl = new ADUsersController();
            CurrenUserInfo = (ADUsersInfo)ADUserCtrl.GetObjectByName(strUser);
            ADUserConfigsInfo UserCfgInfo = new ADUserConfigsController().GetFirstObject() as ADUserConfigsInfo;
            GMCWebApp.GetLocalMachineInfo();
            if (CurrenUserInfo != null && CurrenUserInfo.ADUserIsLockedCheck)
                return "Tài khoản đăng nhập này đã bị khóa! Vui lòng liên hệ người quản trị!";
            else if (IsUserLoggedIn(strUser))
            {
                GEUserAuditsInfo UserAudisInfo = new GEUserAuditsController().GetGEUserAuditsByADUserName(strUser);
                return string.Format("Người dùng này đã đăng nhập trên máy {0} với địa chỉ IP {1}!", UserAudisInfo.GEUserAuditPCName, UserAudisInfo.GEUserAuditIP);
            }
            else if(IsAuthenticated(strUser, strPassword))
            {
                if (!new ADUserGroupsController().IsExist(CurrenUserInfo.ADUserGroupID))
                    return string.Format("Nhóm người dùng của tài khoản {0} không tồn tại trên hệ thống!", strUser);
                else
                {
                    SetCurrentUserLogin(dt);
                    SaveUserAuditLogin("Login");
                    if(UserCfgInfo != null && UserCfgInfo.ADUserConfigPassDayExpires > 0)
                    {
                        if (new ADUserPassHistorysController().IsOldPassExpired(CurrenUserInfo.ADUserID, UserCfgInfo.ADUserConfigPassDayExpires))
                            return "Mật khẩu đã hết hạn! Vui lòng đổi mật khẩu mới!";
                    }
                }
            }
            else
            {
                int iCountLoginFail = new GEUserAuditsController().GetCountLoginFail(strUser, "WebHome", dt);
                iCountLoginFail++;
                if(UserCfgInfo != null && (iCountLoginFail >= UserCfgInfo.ADUserConfigMaxLogonCount) && UserCfgInfo.ADUserConfigMaxLogonCount > 0)
                {
                    SaveUserAuditLogin("LoginFailLock", 0, strUser);
                    if(CurrenUserInfo != null)
                    {
                        CurrenUserInfo.ADUserIsLockedCheck = true;
                        CurrenUserInfo.ADUserLockedInfo = Environment.MachineName + ", " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        ADUserCtrl.UpdateObject(CurrenUserInfo, true, "ADUserIsLockedCheck", "ADUserLockedInfo");
                    }
                    return string.Format("Vượt quá số lần đăng nhập sai cho phép! Tài khoản đăng nhập {0} đã bị khóa", strUser);
                }
                SaveUserAuditLogin("LoginFail", 0, strUser);
                string strError = "Tên đăng nhập/ Mật khẩu không hợp lệ!";
                if (UserCfgInfo != null && UserCfgInfo.ADUserConfigMaxLogonCount > 0)
                    strError += string.Format(" Còn lại {0} lần thử", UserCfgInfo.ADUserConfigMaxLogonCount - iCountLoginFail);
                return strError;
            }
            ADConfigValueUtility.InitGlobalConfigValueTables();
            return "";
        }
        public static bool IsUserLoggedIn(string strUserName)
        {
            GMCWebApp.CurrentCompanyInfo = (CSCompanysInfo)new CSCompanysController().GetFirstObject();
            if (GMCWebApp.CurrentCompanyInfo != null && !GMCWebApp.CurrentCompanyInfo.CSCompanyIsUserAudit)
                return false;
            return (new GEUserAuditsController().GetGEUserAuditsByADUserName(strUserName) != null);
        }
        public static bool IsAuthenticated(string strUser, string strPassword)
        {
            ADUsersController ADUserCtrl = new ADUsersController();
            ADUsersInfo UserInfo = (ADUsersInfo)ADUserCtrl.GetObjectByName(strUser);
            return (UserInfo != null && UserInfo.ADPassword.Equals(new Crypto().Encrypt(strPassword)));
        }
        private static void SetCurrentUserLogin(System.DateTime dt)
        {
            if (CurrenUserInfo != null)
            {
                ADUsersController ADUserCtrl = new ADUsersController();
                SetSession("IsLoggingOff", false);
                CurrentCompanyInfo = (CSCompanysInfo)new CSCompanysController().GetFirstObject();
                CurrenUserGroupInfo = (ADUserGroupsInfo)new ADUserGroupsController().GetObjectByID(ADUserCtrl.GetUserGroupOfUser(CurrenUserInfo.ADUserName));
                GMCWebApp.CurrentLanguage = CurrenUserInfo.ADUserCurLang;
                GMCWebApp.InitDictionary();
                SetSession("CurrentUser", CurrenUserInfo.ADUserName);
                SetSession("WorkingDate", dt);
                SetSession("WorkingPeriod", dt.Month);
                SetSession("WorkingYear", dt.Year);
                //SetCookie("RecentUser", CurrenUserInfo.ADUserName);
                SetCookie("Server", Convert.ToString(GetSession("CurrentServer")));
                //SetValueConfigSettings("RecentUser", CurrenUserInfo.ADUserName);
                SetValueConfigSettings("Server", Convert.ToString(GetSession("CurrentServer")));
            }
        }
        public static void SaveUserAuditLogin(string strUserAction)
        {
            SaveUserAuditLogin(strUserAction, CurrenUserInfo.ADUserID, CurrenUserInfo.ADUserName);
        }
        public static void SaveUserAuditLogin(string strUserAction, int iADUserID, string ADUserName)
        {
            GEUserAuditsInfo info = new GEUserAuditsInfo
            {
                ADUserID = iADUserID,
                ADUserName = ADUserName,
                GEUserAuditModuleName = "WebHome",
                GEUserAuditBeginDate = DateTime.Now,
                GEUserAuditAction = strUserAction,
                GEUserAuditPCName = GMCWebApp.PCName,
                GEUserAuditIP = GMCWebApp.IPAddress
            };
            new GEUserAuditsController().CreateObject(info);
        }
        public static void LogOff()
        {
            SetSession("IsLoggingOff", true);
            SetSession("CurrentUser", null);
            SetSession("WorkingDate", System.DateTime.MinValue);
            SetSession("WorkingPeriod", GMCWebApp.WorkingDate.Month);
            SetSession("WorkingYear", GMCWebApp.WorkingDate.Year);
            SetSession("CurrentServer", null);
            SetSession("CurrentDatabase", null);
        }
        public static HREmployeesInfo GetEmployeeByUserName(string strUserName)
        {
            int iUserID = new ADUsersController().GetObjectIDByName(strUserName);
            return (HREmployeesInfo)new HREmployeesController().GetFirstObjectByForeignColumn("FK_ADUserID", iUserID);
        }
        public static void SetValueConfigSettings(string strKey, string strValue)
        {
            try
            {
                XDocument xDoc = XDocument.Load(System.Web.HttpContext.Current.Server.MapPath(strCfgPath));
                var xElements = xDoc.Element("configs").Elements("item");
                xElements.SingleOrDefault(x => x.Attribute("Key").Value.Equals(strKey)).Attribute("Value").Value = strValue;
                xDoc.Save(System.Web.HttpContext.Current.Server.MapPath(strCfgPath));
            }
            catch { }
        }
        public static string GetValueConfigSettings(string strKey)
        {
            XDocument xDoc = XDocument.Load(System.Web.HttpContext.Current.Server.MapPath(strCfgPath));
            return xDoc.Element("configs").Elements("item").SingleOrDefault(x => x.Attribute("Key").Value.Equals(strKey)).Attribute("Value").Value;
        }
        public static void SetMailConfig()
        {
            ExpertERPProcedure.Utilities.MailUtil.SetMailConfig(Properties.Settings.Default.WebEmail, Properties.Settings.Default.WebEmailServer, Properties.Settings.Default.WebEmailUser, Properties.Settings.Default.WebEmailPass, Properties.Settings.Default.WebEmailPort);
        }
    }
    public class VietNamGridLocalizer : DevExpress.Web.Localization.ASPxGridViewLocalizer
    {
        public override string GetLocalizedString(ASPxGridViewStringId id)
        {
            switch (id)
            {
                case ASPxGridViewStringId.GroupPanel:
                    return "";
                    break;
                case ASPxGridViewStringId.EmptyDataRow:
                    return "Không có dữ liệu hiển thị";
                    break;
                case ASPxGridViewStringId.EmptyHeaders:
                    return "";
                    break;
                case ASPxGridViewStringId.ConfirmDelete:
                    return "";
                    break;
                case ASPxGridViewStringId.ConfirmOnLosingBatchChanges:
                    break;
                case ASPxGridViewStringId.GroupContinuedOnNextPage:
                    break;
                case ASPxGridViewStringId.CustomizationWindowCaption:
                    break;
                case ASPxGridViewStringId.PopupEditFormCaption:
                    break;
                case ASPxGridViewStringId.HeaderFilterShowAllItem:
                    break;
                case ASPxGridViewStringId.HeaderFilterShowBlanksItem:
                    break;
                case ASPxGridViewStringId.HeaderFilterShowNonBlanksItem:
                    break;
                case ASPxGridViewStringId.HeaderFilterSelectAll:
                    break;
                case ASPxGridViewStringId.HeaderFilterOkButton:
                    break;
                case ASPxGridViewStringId.HeaderFilterCancelButton:
                    break;
                case ASPxGridViewStringId.HeaderFilterFrom:
                    break;
                case ASPxGridViewStringId.HeaderFilterTo:
                    break;
                case ASPxGridViewStringId.HeaderFilterYesterday:
                    break;
                case ASPxGridViewStringId.HeaderFilterToday:
                    break;
                case ASPxGridViewStringId.HeaderFilterTomorrow:
                    break;
                case ASPxGridViewStringId.HeaderFilterLastWeek:
                    break;
                case ASPxGridViewStringId.HeaderFilterThisWeek:
                    break;
                case ASPxGridViewStringId.HeaderFilterNextWeek:
                    break;
                case ASPxGridViewStringId.HeaderFilterLastMonth:
                    break;
                case ASPxGridViewStringId.HeaderFilterThisMonth:
                    break;
                case ASPxGridViewStringId.HeaderFilterNextMonth:
                    break;
                case ASPxGridViewStringId.HeaderFilterLastYear:
                    break;
                case ASPxGridViewStringId.HeaderFilterThisYear:
                    break;
                case ASPxGridViewStringId.HeaderFilterNextYear:
                    break;
                case ASPxGridViewStringId.SearchPanelEditorNullText:
                    break;
                case ASPxGridViewStringId.CommandEdit:
                    break;
                case ASPxGridViewStringId.CommandNew:
                    break;
                case ASPxGridViewStringId.CommandDelete:
                    break;
                case ASPxGridViewStringId.CommandRecover:
                    break;
                case ASPxGridViewStringId.CommandSelect:
                    break;
                case ASPxGridViewStringId.CommandCancel:
                    break;
                case ASPxGridViewStringId.CommandUpdate:
                    break;
                case ASPxGridViewStringId.CommandShowAdaptiveDetail:
                    break;
                case ASPxGridViewStringId.CommandHideAdaptiveDetail:
                    break;
                case ASPxGridViewStringId.CommandClearFilter:
                    break;
                case ASPxGridViewStringId.CommandApplyFilter:
                    break;
                case ASPxGridViewStringId.CommandBatchEditUpdate:
                    break;
                case ASPxGridViewStringId.CommandBatchEditCancel:
                    break;
                case ASPxGridViewStringId.SelectAllCheckBoxInPageMode:
                    break;
                case ASPxGridViewStringId.SelectAllCheckBoxInAllPagesMode:
                    break;
                case ASPxGridViewStringId.CommandApplySearchPanelFilter:
                    break;
                case ASPxGridViewStringId.CommandClearSearchPanelFilter:
                    break;
                case ASPxGridViewStringId.AutoFilterBeginsWith:
                    break;
                case ASPxGridViewStringId.AutoFilterContains:
                    break;
                case ASPxGridViewStringId.AutoFilterDoesNotContain:
                    break;
                case ASPxGridViewStringId.AutoFilterEndsWith:
                    break;
                case ASPxGridViewStringId.AutoFilterEquals:
                    break;
                case ASPxGridViewStringId.AutoFilterGreater:
                    break;
                case ASPxGridViewStringId.AutoFilterGreaterOrEqual:
                    break;
                case ASPxGridViewStringId.AutoFilterLess:
                    break;
                case ASPxGridViewStringId.AutoFilterLessOrEqual:
                    break;
                case ASPxGridViewStringId.AutoFilterNotEqual:
                    break;
                case ASPxGridViewStringId.AutoFilterLike:
                    break;
                case ASPxGridViewStringId.AutoFilterLikeToolTip:
                    break;
                case ASPxGridViewStringId.Alt_HeaderFilterButton:
                    break;
                case ASPxGridViewStringId.Alt_HeaderFilterButtonActive:
                    break;
                case ASPxGridViewStringId.Alt_SortedAscending:
                    break;
                case ASPxGridViewStringId.Alt_SortedDescending:
                    break;
                case ASPxGridViewStringId.Alt_DragAndDropHideColumnIcon:
                    break;
                case ASPxGridViewStringId.Alt_Expand:
                    break;
                case ASPxGridViewStringId.Alt_Collapse:
                    break;
                case ASPxGridViewStringId.Alt_FilterRowButton:
                    break;
                case ASPxGridViewStringId.Outlook_Older:
                    break;
                case ASPxGridViewStringId.Outlook_LastMonth:
                    break;
                case ASPxGridViewStringId.Outlook_EarlierThisMonth:
                    break;
                case ASPxGridViewStringId.Outlook_ThreeWeeksAgo:
                    break;
                case ASPxGridViewStringId.Outlook_TwoWeeksAgo:
                    break;
                case ASPxGridViewStringId.Outlook_LastWeek:
                    break;
                case ASPxGridViewStringId.Outlook_Yesterday:
                    break;
                case ASPxGridViewStringId.Outlook_Today:
                    break;
                case ASPxGridViewStringId.Outlook_Tomorrow:
                    break;
                case ASPxGridViewStringId.Outlook_NextWeek:
                    break;
                case ASPxGridViewStringId.Outlook_TwoWeeksAway:
                    break;
                case ASPxGridViewStringId.Outlook_ThreeWeeksAway:
                    break;
                case ASPxGridViewStringId.Outlook_LaterThisMonth:
                    break;
                case ASPxGridViewStringId.Outlook_NextMonth:
                    break;
                case ASPxGridViewStringId.Outlook_BeyondNextMonth:
                    break;
                case ASPxGridViewStringId.Summary_Sum:
                    break;
                case ASPxGridViewStringId.Summary_Sum_OtherColumn:
                    break;
                case ASPxGridViewStringId.Summary_Min:
                    break;
                case ASPxGridViewStringId.Summary_Min_OtherColumn:
                    break;
                case ASPxGridViewStringId.Summary_Max:
                    break;
                case ASPxGridViewStringId.Summary_Max_OtherColumn:
                    break;
                case ASPxGridViewStringId.Summary_Average:
                    break;
                case ASPxGridViewStringId.Summary_Average_OtherColumn:
                    break;
                case ASPxGridViewStringId.Summary_Count:
                    break;
                case ASPxGridViewStringId.ContextMenu_FullExpand:
                    break;
                case ASPxGridViewStringId.ContextMenu_FullCollapse:
                    break;
                case ASPxGridViewStringId.ContextMenu_SortAscending:
                    break;
                case ASPxGridViewStringId.ContextMenu_SortDescending:
                    break;
                case ASPxGridViewStringId.ContextMenu_ClearSorting:
                    break;
                case ASPxGridViewStringId.ContextMenu_ClearFilter:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowFilterEditor:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowFilterRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowFilterRowMenu:
                    break;
                case ASPxGridViewStringId.ContextMenu_GroupByColumn:
                    break;
                case ASPxGridViewStringId.ContextMenu_UngroupColumn:
                    break;
                case ASPxGridViewStringId.ContextMenu_ClearGrouping:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowGroupPanel:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowSearchPanel:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowColumn:
                    break;
                case ASPxGridViewStringId.ContextMenu_HideColumn:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowCustomizationWindow:
                    break;
                case ASPxGridViewStringId.ContextMenu_ShowFooter:
                    break;
                case ASPxGridViewStringId.ContextMenu_NewRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_EditRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_DeleteRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_ExpandRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_CollapseRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_ExpandDetailRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_CollapseDetailRow:
                    break;
                case ASPxGridViewStringId.ContextMenu_Refresh:
                    break;
                case ASPxGridViewStringId.ContextMenu_SummarySum:
                    break;
                case ASPxGridViewStringId.ContextMenu_SummaryMin:
                    break;
                case ASPxGridViewStringId.ContextMenu_SummaryMax:
                    break;
                case ASPxGridViewStringId.ContextMenu_SummaryAverage:
                    break;
                case ASPxGridViewStringId.ContextMenu_SummaryCount:
                    break;
                case ASPxGridViewStringId.ContextMenu_SummaryNone:
                    break;
                case ASPxGridViewStringId.ContextMenu_GroupSummaryMenu:
                    break;
                case ASPxGridViewStringId.CardView_CustomizationWindowCaption:
                    break;
                case ASPxGridViewStringId.CardView_EndlessPagingShowMoreCardsButton:
                    break;
                case ASPxGridViewStringId.CardView_PagerRowPerPage:
                    break;
                case ASPxGridViewStringId.VerticalGrid_AltExpandRow:
                    break;
                case ASPxGridViewStringId.VerticalGrid_AltCollapseRow:
                    break;
                case ASPxGridViewStringId.VerticalGrid_AltExpandCategory:
                    break;
                case ASPxGridViewStringId.VerticalGrid_AltCollapseCategory:
                    break;
                case ASPxGridViewStringId.CommandSelectAllOnPage:
                    break;
                case ASPxGridViewStringId.CommandSelectAllOnAllPages:
                    break;
                case ASPxGridViewStringId.CommandDeselectAllOnPage:
                    break;
                case ASPxGridViewStringId.CommandDeselectAllOnAllPages:
                    break;
                default:
                    break;
            }
            return base.GetLocalizedString(id);
        }
        public override string Language
        {
            get
            {
                return "VietNam";
            }
        }
    }
}