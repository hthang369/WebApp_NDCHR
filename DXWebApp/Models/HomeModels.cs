using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using ExpertERPProcedure.Utilities;
using System.Web.Mvc;
using ExpertWebLib;
using ExpertERPWeb.BaseEntities;
using ExpertERP.BusinessEntities;

namespace DXWebApp.Models
{
    public class HomeModels
    {
        DataSet dsTmp;
        public HomeModels()
        {
            dsTmp = new DataSet();
        }
        public IEnumerable GetScreenByModuleID(int iModuleID)
        {
            STModulesInfo objModule = (STModulesInfo)new STModulesController().GetObjectByID(iModuleID);
            List<STScreensInfo> lstScreens = new List<STScreensInfo>();
            STScreensController ScreenCtrl = new STScreensController();
            STFieldsController STFieldsCtrl = new STFieldsController();
            STGridColumnsController STGridColumnCtrl = new STGridColumnsController();
            STFieldColumnsController STFieldColumnCtrl = new STFieldColumnsController();
            DataSet ds = GetScreenByModuleNameAndUserGroupName(objModule.STModuleName, AuthConfig.CurrenUserGroupInfo.ADUserGroupName);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 0)
                ds = GetScreenByModuleNameAndUserGroupName(objModule.STModuleName, "ADMIN");
            Dictionary<STScreensInfo, Dictionary<STFieldsInfo, List<BusinessObject>>> dicControls = new Dictionary<STScreensInfo, Dictionary<STFieldsInfo, List<BusinessObject>>>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    STScreensInfo objScreen = (STScreensInfo)ScreenCtrl.GetObjectFromDataRow(dr);
                    lstScreens.Add(objScreen);
                }
                lstScreens.Sort((st1, st2) => st1.STScreenSortOrder.CompareTo(st2.STScreenSortOrder));
                foreach (STScreensInfo item in lstScreens)
                {
                    if(item.STScreenSortOrder >= 0)
                    {
                        ds = STFieldsCtrl.GetActiveFieldsByScreenIDAndUserGroupID(item.STScreenID, AuthConfig.CurrenUserGroupInfo.ADUserGroupID);
                        Dictionary<STFieldsInfo, List<BusinessObject>> dicFields = new Dictionary<STFieldsInfo, List<BusinessObject>>();
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                STFieldsInfo objField = (STFieldsInfo)STFieldsCtrl.GetObjectFromDataRow(dr);
                                if(objField.STFieldType.EndsWith("GridControl"))
                                {
                                    DataSet dsInfo = STGridColumnCtrl.GetAllDataByGridColumnAndUserIDOrderByTabIndex(objField.STFieldID, AuthConfig.CurrenUserInfo.ADUserID);
                                    if(!dicFields.ContainsKey(objField))
                                        dicFields.Add(objField, STGridColumnCtrl.GetListFromDataset(dsInfo));
                                }
                                else if (objField.STFieldType.EndsWith("LookupEdit"))
                                {
                                    DataSet dsInfo = STFieldColumnCtrl.GetAllDataByForeignColumn("STFieldID", objField.STFieldID);
                                    if (!dicFields.ContainsKey(objField))
                                        dicFields.Add(objField, STFieldColumnCtrl.GetListFromDataset(dsInfo));
                                }
                                else
                                    if (!dicFields.ContainsKey(objField))
                                    dicFields.Add(objField, new List<BusinessObject>());
                            }
                        }
                        if(!dicControls.ContainsKey(item))
                            dicControls.Add(item, dicFields);
                    }
                }
                return dicControls;
            }
            return null;
        }
        public IEnumerable GetScreenByModuleID(string strModuleName)
        {
            int iModuleID = new STModulesController().GetObjectIDByName(strModuleName);
            return GetScreenByModuleID(iModuleID);
        }
        public Dictionary<STFieldsInfo, List<BusinessObject>> GetFieldInfo(int id)
        {
            STFieldsInfo objField = (STFieldsInfo)new STFieldsController().GetObjectByID(id);
            Dictionary<STFieldsInfo, List<BusinessObject>> dicFields = new Dictionary<STFieldsInfo, List<BusinessObject>>();
            STGridColumnsController STGridColumnCtrl = new STGridColumnsController();
            if (objField != null)
            {
                DataSet dsInfo = STGridColumnCtrl.GetAllDataByGridColumnAndUserIDOrderByTabIndex(objField.STFieldID, AuthConfig.CurrenUserInfo.ADUserID);
                dicFields.Add(objField, STGridColumnCtrl.GetListFromDataset(dsInfo));
            }
            return dicFields;
        }
        public XMLTreeFieldNode CalculateTreeFields(List<STFieldsInfo> lstSTFields)
        {
            XMLTreeFieldNode node = new XMLTreeFieldNode(null);
            STFieldsController FieldCtrl = new STFieldsController();
            SortedList<int, XMLTreeFieldNode> list = new SortedList<int, XMLTreeFieldNode>();
            foreach (STFieldsInfo field in lstSTFields)
            {
                XMLTreeFieldNode node2 = new XMLTreeFieldNode(field);
                list.Add(field.STFieldID, node2);
            }
            foreach (XMLTreeFieldNode node3 in list.Values)
            {
                if (node3.fieldValue.STFieldParentID != 0)
                {
                    if (list.ContainsKey(node3.fieldValue.STFieldParentID))
                    {
                        node3.parentNode = list[node3.fieldValue.STFieldParentID];
                        if (node3.parentNode.ChildrenNodes.ContainsKey(node3.fieldValue.STFieldZOrder))
                        {
                            int key = node3.parentNode.ChildrenNodes.Keys[node3.parentNode.ChildrenNodes.Keys.Count - 1] + 1;
                            node3.parentNode.ChildrenNodes.Add(key, node3);
                        }
                        else
                        {
                            node3.parentNode.ChildrenNodes.Add(node3.fieldValue.STFieldZOrder, node3);
                        }
                        node3.level = node3.parentNode.level + 1;
                        foreach (XMLTreeFieldNode local1 in node3.ChildrenNodes.Values)
                        {
                            local1.level++;
                        }
                    }
                }
                else if (node.ChildrenNodes.ContainsKey(node3.fieldValue.STFieldZOrder))
                {
                    int num2 = node.ChildrenNodes.Keys[node.ChildrenNodes.Keys.Count - 1] + 1;
                    node.ChildrenNodes.Add(num2, node3);
                }
                else
                {
                    node.ChildrenNodes.Add(node3.fieldValue.STFieldZOrder, node3);
                }
            }
            return node;
        }
        public Dictionary<List<STGridColumnsInfo>, DataSet> ShowModuleByJournal(String strSourceLeger, String strDocumentNo, ADInboxItemsInfo objInbox, STFieldsInfo objOldField)
        {
            STModulesController ModuleCtrl = new STModulesController();
            STModuleTablesController ModuleTableCtrl = new STModuleTablesController();

            int iMainObjectID = -1;
            String strTable = String.Empty;
            String strTablePrefix = String.Empty;
            String strPrimaryKey = String.Empty;
            Object MainObj = null;

            int iModuleID = 0;
            List<DataRow> dr = GetLocalDataSet("STModuleID,STModuleName", "STModules", string.Format("STModuleName = '{0}'", strSourceLeger));
            if (dr.Count > 0) iModuleID = Convert.ToInt32(dr.First()["STModuleID"]);

            dr = GetLocalDataSet("STModuleTableID,STModuleTableName,STModuleID,STModuleTableLevelIndex", "STModuleTables", string.Format("STModuleID = {0} AND STModuleTableLevelIndex = 0", iModuleID));
            if (dr.Count > 0) strTable = dr.First()["STModuleTableName"].ToString();

            if (String.IsNullOrEmpty(strTable) == false)
            {
                strTablePrefix = strTable.Substring(0, strTable.Length - 1);
                strPrimaryKey = strTablePrefix + "ID";
            }

            BaseBusinessController Ctrl = BusinessControllerFactory.GetBusinessController(strTable + "Controller");

            if (Ctrl != null)
                MainObj = Ctrl.GetObjectByNo(strDocumentNo);

            if (MainObj != null)
            {
                iMainObjectID = Convert.ToInt32(GMCDbUtil.GetPropertyValue(MainObj, strPrimaryKey));
                if (GMCDbUtil.GetPropertyValue(MainObj, "FK_HREmployeeID") != null)
                {
                    int iEmployeeID = Convert.ToInt32(GMCDbUtil.GetPropertyValue(MainObj, "FK_HREmployeeID"));
                    objInbox.FK_HRFromEmployeeID = iEmployeeID;
                }
                if (GMCDbUtil.GetPropertyValue(MainObj, strTable.TrimEnd('s') + "Desc") != null)
                {
                    //TextEdit txtRemark = (TextEdit)GetControlByName("fld_medADInboxItemRemark1");
                    //if (txtRemark != null)
                    //{
                    //    txtRemark.EditValue = GMCDbUtil.GetPropertyValue(MainObj, strTable.TrimEnd('s') + "Desc");
                    //}
                    objInbox.ADInboxItemMessage = Convert.ToString(GMCDbUtil.GetPropertyValue(MainObj, strTable.TrimEnd('s') + "Desc"));
                }
            }
            //ShowModuleByJournal(strSourceLeger, iMainObjectID, false);
            //Thang - edit 26/4/2016 hiển thị chi tiêt chứng từ

            ADUserGroupsInfo objUserGroup = AuthConfig.CurrenUserGroupInfo;
            dr = GetLocalDataSet("STScreenID,STScreenNumber,STModuleID,STUserGroupID,STScreenSortOrder", "STScreens", string.Format(@"STModuleID = {0} AND STUserGroupID = {1} 
                AND STScreenNumber like 'DM%' AND STScreenSortOrder > 0 AND STScreenSortOrder <= 1", iModuleID, objUserGroup.ADUserGroupID));
            int iScreenID = 0;
            if (dr.Count > 0) iScreenID = Convert.ToInt32(dr.First()["STScreenID"]);
            //Thang edit - 8/2/2017 Chỉnh sửa nếu 1 user group không có giao diện riêng thì sẽ lấy mặc định giao diện admin
            if (iScreenID == 0)
            {
                int iUserGroupDefaultID = new ADUserGroupsController().GetObjectIDByName("ADMIN");
                dr = GetLocalDataSet("STScreenID,STScreenNumber,STModuleID,STUserGroupID,STScreenSortOrder", "STScreens", string.Format(@"STModuleID = {0} AND STUserGroupID = {1} 
                AND STScreenNumber like 'DM%' AND STScreenSortOrder > 0 AND STScreenSortOrder <= 1", iModuleID, iUserGroupDefaultID));
                if (dr.Count > 0) iScreenID = Convert.ToInt32(dr.First()["STScreenID"]);
            }

            dr = GetLocalDataSet("*", "STFields", string.Format(@"STScreenID = {0} AND STFieldType = 'GMCGridControl' 
                                        AND(STFieldDataSource like '%Items' OR STFieldDataSource like '%Details')
                                        AND STFieldGroup <> ''", iScreenID));
            if (dr.Count == 0) return null;
            STFieldsInfo objField = (STFieldsInfo)new STFieldsController().GetObjectFromDataRow(dr[0]);
            if (objField == null) return null;

            BaseBusinessController itemCtrl = BusinessControllerFactory.GetBusinessController(objField.STFieldDataSource + "Controller");
            DataSet ds = new DataSet();
            if (itemCtrl != null)
                ds = itemCtrl.GetAllDataByForeignColumn("FK_" + strPrimaryKey, iMainObjectID);

            List<STGridColumnsInfo> lstGridColumns = new List<STGridColumnsInfo>();
            if (objOldField == null || !objOldField.STFieldID.Equals(objField.STFieldID))
            {
                objOldField = objField;
                dr = GetLocalDataSet("*", "STGridColumns", string.Format("FK_STFieldID = {0}", objField.STFieldID));
                STGridColumnsController GridColCtrl = new STGridColumnsController();
                dr.Distinct().ToList().ForEach(x =>
                {
                    STGridColumnsInfo colInfo = (STGridColumnsInfo)GridColCtrl.GetObjectFromDataRow(x);
                    lstGridColumns.Add(colInfo);
                });
            }
            return new Dictionary<List<STGridColumnsInfo>, DataSet>() { { lstGridColumns, ds } };
        }
        private List<DataRow> GetLocalDataSet(string strSelect, string strTable, string strWhere)
        {
            List<DataRow> lstDr = new List<DataRow>();
            if (dsTmp.Tables.Cast<DataTable>().Where(x => x.TableName.Equals(strTable)).Count() > 0)
                lstDr = dsTmp.Tables[strTable].Select(strWhere).ToList();
            if (lstDr.Count == 0)
            {
                DataSet ds = GMCDbUtil.ExecuteQuery(string.Format("SELECT {0} FROM {1} WHERE {2}", strSelect, strTable, strWhere));
                if (ds != null && ds.Tables.Count > 0)
                    lstDr = ds.Tables[0].Rows.Cast<DataRow>().ToList();
            }
            lstDr.ForEach(x => AddRowToDataSet(x, strTable));
            return lstDr;
        }
        private void AddRowToDataSet(DataRow row, string tblName)
        {
            if (dsTmp.Tables.Cast<DataTable>().Where(t => t.TableName.Equals(tblName)).Count() == 0)
            {
                DataTable dt = row.Table.Clone();
                dt.TableName = tblName;
                dt.ImportRow(row);
                dsTmp.Tables.Add(dt);
            }
            else
            {
                string primary = string.Format("{0}ID", tblName.TrimEnd('s'));
                if (dsTmp.Tables[tblName].Select(string.Format("{0} = '{1}'", primary, row[primary])).Length == 0)
                    dsTmp.Tables[tblName].ImportRow(row);
            }
        }
        public bool CheckUnReadMailBox(ADInboxItemsInfo InboxItemInfo, string strUserName)
        {
            #region Check Approval
            if (InboxItemInfo.ADInboxItemProtocol == MailUtil.strProtocol_Approval &&
                string.IsNullOrEmpty(InboxItemInfo.ADInboxItemAction))
                return true;
            #endregion

            #region Check User Read
            string[] strListUsers = InboxItemInfo.ADMailReadUsers.Split(';');
            foreach (string strUser in strListUsers)
            {
                if (strUser == strUserName)
                    return false;
            }
            #endregion

            return true;
        }
        public bool CheckUnReadOffWork(HREmployeeOffWorksInfo DocItemInfo, string strUserName)
        {
            #region Check User Read
            string[] strListUsers = DocItemInfo.HREmployeeOffWorkReadUsers.Split(';');
            foreach (string strUser in strListUsers)
            {
                if (strUser == strUserName)
                    return false;
            }
            #endregion

            return true;
        }
        public bool CheckUserApprovalMailBox(ADInboxItemsInfo InboxItemInfo, string strUserName)
        {
            string[] strListUsers = InboxItemInfo.ADMailToUsers.Split(';');
            foreach (string strUser in strListUsers)
            {
                if (strUser == strUserName)
                    return true;
            }
            return false;
        }
        public List<BusinessObject> GetFieldInfoByModuleName(string strModuleName)
        {
            DataSet ds = new STScreensController().GetScreenByModuleNameAndUserGroupName(strModuleName, AuthConfig.CurrenUserGroupInfo.ADUserGroupName);
            if (ds != null && ds.Tables.Count > 0)
            {
                DataRow[] drs = ds.Tables[0].Select("STScreenText like '%Message%' AND STScreenNumber like 'DS%'");
                if (drs.Length > 0)
                {
                    int iScreenID = Convert.ToInt32(drs.FirstOrDefault()["STScreenID"]);
                    ds = new STFieldsController().GetActiveFieldsByScreenIDAndUserGroupID(iScreenID, AuthConfig.CurrenUserGroupInfo.ADUserGroupID);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        DataRow[] rows = ds.Tables[0].Select("STFieldType = 'GMCGridControl'");
                        if(rows.Length > 0)
                        {
                            STGridColumnsController GridColumnCtrl = new STGridColumnsController();
                            int iFieldID = Convert.ToInt32(rows.FirstOrDefault()["STFieldID"]);
                            ds = GridColumnCtrl.GetAllDataByGridColumnAndUserIDOrderByTabIndex(iFieldID, AuthConfig.CurrenUserInfo.ADUserID);
                            return GridColumnCtrl.GetListFromDataset(ds);
                        }
                    }
                }
            }
            return new List<BusinessObject>();
        }
        private DataSet GetScreenByModuleNameAndUserGroupName(string sModuleName, string sUserGroupName)
        {
            if (GMCDbUtil.StoredProcedureIsExist("STScreenWebApps_SelectBySTModuleNameAndADUserGroupName"))
                return SqlDatabaseHelper.RunStoredProcedure("STScreenWebApps_SelectBySTModuleNameAndADUserGroupName", sModuleName, sUserGroupName);
            else
                return new STScreensController().GetScreenByModuleNameAndUserGroupName(sModuleName, sUserGroupName);
        }
        public List<SelectListItem> GetEmployeeLeaveTypes()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            DataSet dsLeaveType = new HREmployeeLeaveTypesController().GetAllObjects();
            if(dsLeaveType != null && dsLeaveType.Tables.Count > 0)
            {
                foreach (DataRow item in dsLeaveType.Tables[0].Rows)
                {
                    SelectListItem idx = new SelectListItem();
                    idx.Text = Convert.ToString(item["HREmployeeLeaveTypeName"]);
                    idx.Value = Convert.ToString(item["HREmployeeLeaveTypeID"]);
                    lst.Add(idx);
                }
            }
            return lst;
        }
        public DataSet GetEmployeeOffWorkByApprovalStatus(int iEmployeeID, string sApprovalStatus, string sStatus = "Alive")
        {
            return SqlDatabaseHelper.RunStoredProcedure("spl_GetDataEmployeeOffWorkByEmployeeID", iEmployeeID, sApprovalStatus, sStatus);
        }
        public Dictionary<List<STGridColumnsInfo>, DataSet> GetScreenEmployeeOffWork(string sModuleName, int iObjectID)
        {
            DataSet dsScreen = GetScreenByModuleNameAndUserGroupName(sModuleName, "ADMIN");
            if (dsScreen == null || dsScreen.Tables.Count == 0 && dsScreen.Tables[0].Rows.Count == 0) return null;
            STScreensInfo objScreen = new STScreensController().GetObjectFromDataRow(dsScreen.Tables[0].Rows[0]) as STScreensInfo;
            List<DataRow> dr = GetLocalDataSet("*", "STFields", string.Format(@"STScreenID = {0} AND STFieldType = 'GMCGridControl' 
                                    AND STFieldGroup <> 'HiddenWeb'", objScreen.STScreenID));
            if (dr.Count == 0) return null;
            STFieldsInfo objField = (STFieldsInfo)new STFieldsController().GetObjectFromDataRow(dr[0]);
            if (objField == null) return null;
            BaseBusinessController itemCtrl = BusinessControllerFactory.GetBusinessController(objField.STFieldDataSource + "Controller");
            DataSet ds = new DataSet();
            if (itemCtrl != null)
                ds = itemCtrl.GetDataSetByID(iObjectID);

            List<STGridColumnsInfo> lstGridColumns = new List<STGridColumnsInfo>();
            dr = GetLocalDataSet("*", "STGridColumns", string.Format("FK_STFieldID = {0}", objField.STFieldID));
            STGridColumnsController GridColCtrl = new STGridColumnsController();
            dr.Distinct().ToList().ForEach(x =>
            {
                STGridColumnsInfo colInfo = (STGridColumnsInfo)GridColCtrl.GetObjectFromDataRow(x);
                lstGridColumns.Add(colInfo);
            });
            return new Dictionary<List<STGridColumnsInfo>, DataSet>() { { lstGridColumns, ds } };
        }
        public int GetEmployeeManagerLevel(int iEmplID, string sColumnName = "FK_HREmployeeManagerID")
        {
            DataSet ds = GMCDbUtil.ExecuteQuery(string.Format("SELECT {0} FROM HREmployees WHERE HREmployeeID = {1}", sColumnName, iEmplID));
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public Dictionary<string, double> GetTonPhepTheoNhanVien(HREmployeesInfo objEmployee)
        {
            Dictionary<string, double> dicPheps = new Dictionary<string, double>();
            int iYear = Convert.ToInt32(AuthConfig.GetSession("WorkingYear"));
            int iMonth = Convert.ToInt32(AuthConfig.GetSession("WorkingPeriod"));
            HREmployeeLRegsInfo objHREmployeeLRegOldYear = (HREmployeeLRegsInfo)new HREmployeeLRegsController().GetEmployeeLRegByEmployeeIDAndYear(objEmployee.HREmployeeID, iYear - 1);
            double dbRemainDays = 0;
            if (objHREmployeeLRegOldYear != null) dbRemainDays = objHREmployeeLRegOldYear.HREmployeeLRegRemainDays;
            double dbSoNgayPhepNam = new HREmployeeAnnualRegsController().TotalDaynnualRegByEmployeeIDAndYear(objEmployee.HREmployeeID, iYear);
            double dbSoNgayNghiThangNay = ExpertERP.Procedure.HR.HR_CalculateEmployeeLeave.TinhSoNgayNghiPhepNamChoNhanVienTrongThang(objEmployee, new DateTime(iYear, iMonth, 1));
            double dbSoNgayNghiThangTruoc = 0;
            for (int i = 1; i < iMonth; i++)
            {
                dbSoNgayNghiThangTruoc += ExpertERP.Procedure.HR.HR_CalculateEmployeeLeave.TinhSoNgayNghiPhepNamChoNhanVienTrongThang(objEmployee, new DateTime(iYear, i, 1));
            }
            double dbConLai = dbRemainDays + dbSoNgayPhepNam - dbSoNgayNghiThangTruoc - dbSoNgayNghiThangNay;
            dicPheps.Add("TonNamTruoc", dbRemainDays);
            dicPheps.Add("SoNgayPhepNam", dbSoNgayPhepNam);
            dicPheps.Add("SoNgayNghiThangNay", dbSoNgayNghiThangNay);
            dicPheps.Add("SoNgayNghiThangTruoc", dbSoNgayNghiThangTruoc);
            dicPheps.Add("ConLai", dbConLai);
            return dicPheps;
        }
        public DataTable GetAllDataByEmployeeOffWorkID(int iObjectID)
        {
            DataSet ds = SqlDatabaseHelper.RunStoredProcedure("spl_GetAllDataByEmployeeOffWorkID", iObjectID);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
    }
}