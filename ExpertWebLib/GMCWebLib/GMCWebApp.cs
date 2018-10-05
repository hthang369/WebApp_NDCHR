using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI;
using Microsoft.VisualBasic.FileIO;
using System.Xml.Serialization;
using System.Globalization;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ExpertWebLib
{
    public class GMCUtil
    {
        public static long countInvoke = 0L;
        public static bool IsLocalCache = false;
        public static bool IsSQLDependency = false;
        public const string cstDummyTable = "CSDummy";
        private static string _companyName;
        private static string _currentLanguage = "vn";
        public static string CacheDir = (Application.StartupPath + @"\Cache\");
        public static Dictionary<string, DateTime> dicSTCaches = new Dictionary<string, DateTime>();
        private static DateTime dtLastCache;
        private static BusinessObject _bRBranchInfo = null;
        public static STFieldsController STFieldsCtrl = new STFieldsController();
        public static STScreensController STScreensCtrl = new STScreensController();
        public static STGridColumnsController objSTGridColumnsCtrl = new STGridColumnsController();
        public static STFieldColumnsController STFieldColumnsCtrl = new STFieldColumnsController();
        public static STModuleConfigsController objSTModuleConfigsCtrl = new STModuleConfigsController();
        public static STModulesController objSTModulesCtrl = new STModulesController();
        public static STModuleToUserGroupSectionsController objModuleToUserGroupSectionCtrl = new STModuleToUserGroupSectionsController();
        public static STToolbarsController objSTToolbarsCtrl = new STToolbarsController();
        public static STFieldEventFunctionsController STFieldEventFunctionsCtrl = new STFieldEventFunctionsController();
        public static STFieldEventsController STFieldEventsCtrl = new STFieldEventsController();
        public static STToolbarFunctionsController objSTToolbarFunctionsController = new STToolbarFunctionsController();
        public static void CopyObject(BusinessObject objFromObject, BusinessObject objToObject)
        {
            string tableNameFromBusinessObject = GetTableNameFromBusinessObject(objFromObject);
            string strTableName = GetTableNameFromBusinessObject(objToObject);
            PropertyInfo[] properties = objToObject.GetType().GetProperties();
            foreach (PropertyInfo info in properties)
            {
                if (!GMCDbUtil.IsPrimaryKey(strTableName, info.Name))
                {
                    if (!GMCDbUtil.IsForeignKey(strTableName, info.Name))
                    {
                        if (info.Name.StartsWith(strTableName.Substring(0, strTableName.Length - 1)))
                        {
                            string name = tableNameFromBusinessObject.Substring(0, tableNameFromBusinessObject.Length - 1) + info.Name.Substring(strTableName.Length - 1);
                            if ((name != (tableNameFromBusinessObject.Substring(0, tableNameFromBusinessObject.Length - 1) + "No")) && (name != (tableNameFromBusinessObject.Substring(0, tableNameFromBusinessObject.Length - 1) + "JrnNo")))
                            {
                                PropertyInfo property = objFromObject.GetType().GetProperty(name);
                                if (property != null)
                                {
                                    object obj2 = property.GetValue(objFromObject, null);
                                    info.SetValue(objToObject, obj2, null);
                                }
                            }
                        }
                        else if (info.Name.EndsWith("Combo") && info.Name.Contains("OF"))
                        {
                            PropertyInfo property = objFromObject.GetType().GetProperty(info.Name);
                            if (property != null)
                            {
                                object obj3 = property.GetValue(objFromObject, null);
                                info.SetValue(objToObject, obj3, null);
                            }
                        }
                    }
                    else
                    {
                        PropertyInfo property = objFromObject.GetType().GetProperty(info.Name);
                        if (property != null)
                        {
                            object obj4 = property.GetValue(objFromObject, null);
                            info.SetValue(objToObject, obj4, null);
                        }
                    }
                }
            }
        }

        public static object CopyObject(object objFromObject, object objToObject)
        {
            PropertyInfo[] properties = objToObject.GetType().GetProperties();
            Type type = objToObject.GetType();
            foreach (PropertyInfo info in properties)
            {
                PropertyInfo property = type.GetProperty(info.Name);
                if (property != null)
                {
                    object obj2 = DynamicInvoker.DynamicGetValue(objFromObject, info);
                    property.SetValue(objToObject, obj2, null);
                }
            }
            return objToObject;
        }

        public static void CopyObject(BusinessObject objFromObject, BusinessObject objToObject, bool isCopyAllFields)
        {
            if (!isCopyAllFields)
            {
                CopyObject(objFromObject, objToObject);
            }
            else
            {
                string tableNameFromBusinessObject = GetTableNameFromBusinessObject(objFromObject);
                string str2 = GetTableNameFromBusinessObject(objToObject);
                PropertyInfo[] properties = objToObject.GetType().GetProperties();
                foreach (PropertyInfo info in properties)
                {
                    PropertyInfo property = objFromObject.GetType().GetProperty(info.Name);
                    if (property != null)
                    {
                        object obj2 = DynamicInvoker.DynamicGetValue(objFromObject, property);
                        property.SetValue(objToObject, obj2, null);
                    }
                }
            }
        }

        public static void CopyObjectItems(BusinessObject objFromObjectItems, BusinessObject objToObjectItems, string strToObjectTableName)
        {
            string tableNameFromBusinessObject = GetTableNameFromBusinessObject(objFromObjectItems);
            string strTableName = GetTableNameFromBusinessObject(objToObjectItems);
            string tablePrimaryColumn = GMCDbUtil.GetTablePrimaryColumn(strToObjectTableName);
            PropertyInfo[] properties = objToObjectItems.GetType().GetProperties();
            foreach (PropertyInfo info in properties)
            {
                if (!GMCDbUtil.IsPrimaryKey(strTableName, info.Name))
                {
                    if (!GMCDbUtil.IsForeignKey(strTableName, info.Name))
                    {
                        if (info.Name.StartsWith(strTableName.Substring(0, strTableName.Length - 1)))
                        {
                            string name = tableNameFromBusinessObject.Substring(0, tableNameFromBusinessObject.Length - 1) + info.Name.Substring(strTableName.Length - 1);
                            PropertyInfo property = objFromObjectItems.GetType().GetProperty(name);
                            if (property != null)
                            {
                                object obj2 = property.GetValue(objFromObjectItems, null);
                                info.SetValue(objToObjectItems, obj2, null);
                            }
                        }
                        else if (info.Name.EndsWith("Combo") && info.Name.Contains("OF"))
                        {
                            PropertyInfo property = objFromObjectItems.GetType().GetProperty(info.Name);
                            if (property != null)
                            {
                                object obj3 = property.GetValue(objFromObjectItems, null);
                                info.SetValue(objToObjectItems, obj3, null);
                            }
                        }
                    }
                    else if (!info.Name.Equals("FK_" + tablePrimaryColumn))
                    {
                        PropertyInfo property = objFromObjectItems.GetType().GetProperty(info.Name);
                        if (property != null)
                        {
                            object obj4 = property.GetValue(objFromObjectItems, null);
                            info.SetValue(objToObjectItems, obj4, null);
                        }
                    }
                }
            }
        }
        public static void DeleteAllCacheXML()
        {
            DeleteAllCacheXML(CacheDir);
        }

        public static void DeleteAllCacheXML(string Dir)
        {
            if (Directory.Exists(Dir))
            {
                Parallel.ForEach<string>(Directory.EnumerateFiles(Dir, "*.*", System.IO.SearchOption.AllDirectories), delegate (string sFile)
                {
                    try
                    {
                        System.IO.File.Delete(sFile);
                    }
                    catch
                    {
                    }
                });
            }
        }

        public static void DeleteCacheXML(string CacheNo, params object[] Paras)
        {
            if (IsLocalCache)
            {
                string cacheFile = GetCacheFile(CacheNo, Paras);
                if (System.IO.File.Exists(cacheFile))
                {
                    try
                    {
                        System.IO.File.Delete(cacheFile);
                    }
                    catch
                    {
                    }
                }
            }
        }

        public static void DisableAllCacheXML()
        {
            CacheDir = Application.StartupPath + string.Format(@"\Cache\");
            DisableCacheXML();
            CacheDir = CacheDir;
        }

        public static void DisableCacheXML()
        {
            if (Directory.Exists(CacheDir))
            {
                DeleteAllCacheXML();
                try
                {
                    Directory.Delete(CacheDir, true);
                }
                catch
                {
                }
            }
            IsLocalCache = false;
        }
        public static string GetBusinessControllerNameFromBusinessObject(BusinessObject objInfo)
        {
            return (GetTableNameFromBusinessObject(objInfo) + "Controller");
        }
        public static string GetCacheFile(string CacheNo, params object[] Paras)
        {
            string cacheDir = CacheDir;
            if ((Paras.Length != 0) && !CacheNo.StartsWith(@"LookupTables\"))
            {
                cacheDir = cacheDir + string.Format(@"{0}\", CacheNo);
                try
                {
                    foreach (object obj2 in Paras)
                    {
                        cacheDir = cacheDir + "_" + Convert.ToString(obj2);
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                cacheDir = cacheDir + string.Format("{0}", CacheNo);
            }
            return (cacheDir + string.Format(".gmc"));
        }
        public static void GetCacheInfo()
        {
        }
        public static DataSet LoadCacheXML(string CacheNo, params object[] Paras)
        {
            string cacheFile = GetCacheFile(CacheNo, Paras);
            DataSet ds = null;
            if (IsLocalCache && IsValidCacheXMLFile(cacheFile, CacheNo))
            {
                ds = new DataSet();
                Label_0524:;
                try
                {
                    ds.ReadXml(cacheFile);
                }
                catch
                {
                    goto Label_0524;
                }
                return ds;
            }
            switch (CacheNo)
            {
                case "ModuleConfigs":
                    ds = objSTModuleConfigsCtrl.GetAllDataByForeignColumn("FK_ADUserGroupID", (int)Paras[0]);
                    goto Label_050D;
                    break;
                case "FieldFormats":
                    string strQuery = "SELECT [STFieldFormats].*,[STFieldFormatGroups].[STFieldFormatGroupName] FROM [STFieldFormats] INNER JOIN [STFieldFormatGroups] ON [STFieldFormats].[STFieldFormatGroupID] = [STFieldFormatGroups].[STFieldFormatGroupID]";
                    ds = new STFieldFormatsController().GetDataSet(strQuery);
                    goto Label_050D;
                    break;

                case "AdjPriceListCfgs":
                    ds = BusinessControllerFactory.GetBusinessController("ARAdjPriceListCfgsController").GetAllObjects();
                    goto Label_050D;
                    break;

                case "ModuleToUserGroupSections":
                    ds = objModuleToUserGroupSectionCtrl.GetAllModuleToUserGroupSectionByUserGroupSectionID((int)Paras[0]);
                    goto Label_050D;
                    break;

                case "ConfigValues":
                    ds = new ADConfigValuesController().GetAllObjects();
                    goto Label_050D;
                    break;

                case "LookupTables":
                    ds = new GELookupTablesController().GetAllObjects();
                    goto Label_050D;
                    break;

                case "LookupExColumns":
                    ds = new STLookupExColumnsController().GetAllObjects();
                    goto Label_050D;
                    break;

                case "UserGroupSections":
                    ds = new ADUserGroupSectionsController().GetAllADUserGroupSectionsByAUserGroup((int)Paras[0], (int)Paras[1]);
                    goto Label_050D;
                    break;

                case "FieldFormatGroups":
                    ds = new STFieldFormatGroupsController().GetAllObjects();
                    goto Label_050D;
                    break;

                case "Modules":
                    ds = objSTModulesCtrl.GetAllObjects();
                    goto Label_050D;
                    break;

                case "Dictionarys":
                    ds = new GEDictionarysController().GetAllObjects();
                    goto Label_050D;
                    break;
            }
            if (CacheNo.StartsWith(@"Modules\"))
            {
                if (CacheNo.EndsWith(@"\Ctrls"))
                {
                    ds = STFieldsCtrl.GetActiveFieldsByScreenIDAndUserGroupID((int)Paras[0], (int)Paras[1]);
                }
                else if (CacheNo.EndsWith(@"\SearchCtrls"))
                {
                    ds = STFieldsCtrl.GetFieldByModuleIDAndUserGroupIDAndFieldTag((int)Paras[0], (int)Paras[1], (string)Paras[2]);
                }
                else if (CacheNo.EndsWith(@"\ScreenSearchCtrls"))
                {
                    ds = STFieldsCtrl.GetFieldByScreenIDAndUserGroupIDAndFieldTag((int)Paras[0], (int)Paras[1], (string)Paras[2]);
                }
                else if (CacheNo.EndsWith(@"\Screens"))
                {
                    ds = STScreensCtrl.GetScreenByModuleNameAndUserGroupName((string)Paras[0], (string)Paras[1]);
                }
                else if (CacheNo.EndsWith(@"\Grids"))
                {
                    ds = objSTGridColumnsCtrl.GetAllDataByGridColumnAndUserIDOrderByTabIndex((int)Paras[0], (int)Paras[1]);
                }
                else if (CacheNo.EndsWith(@"\FieldColumns"))
                {
                    ds = STFieldColumnsCtrl.GetAllDataByForeignColumn("STFieldID", (int)Paras[0]);
                }
                else if (CacheNo.EndsWith(@"\Toolbars"))
                {
                    ds = objSTToolbarsCtrl.GetSTToolbarsBySTModuleIDAndSTUserGroupIDAndSTToolbarGroup((int)Paras[0], (int)Paras[1], (string)Paras[2]);
                }
                else if (CacheNo.EndsWith(@"\ToolbarItems"))
                {
                    ds = objSTToolbarsCtrl.GetSTToolbarsBySTModuleIDAndSTUserGroupIDAndSTToolbarGroupAndSTParentID((int)Paras[0], (int)Paras[1], (string)Paras[2], (int)Paras[3]);
                }
                else if (CacheNo.EndsWith(@"\FieldEventFuncs"))
                {
                    ds = STFieldEventFunctionsCtrl.GetFieldEventFunctionByFieldEventID((int)Paras[0]);
                }
                else if (CacheNo.EndsWith(@"\FieldEvents"))
                {
                    ds = STFieldEventsCtrl.GetFieldEventByFieldID((int)Paras[0]);
                }
                else if (CacheNo.EndsWith(@"\ToolbarFncs"))
                {
                    ds = objSTToolbarFunctionsController.GetAllDataByForeignColumn("STToolbarID", (int)Paras[0]);
                }
            }
            else if (CacheNo.StartsWith(@"LookupTables\splk_"))
            {
                ds = SqlDatabaseHelper.RunStoredProcedure(string.Format("splk_{0}", (string)Paras[0]));
            }
            else if (CacheNo.StartsWith(@"LookupTables\"))
            {
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(((string)Paras[0]) + "Controller");
                if (businessController != null)
                {
                    ds = businessController.GetAllObjectForDataLookups((string)Paras[1]);
                }
            }
            else
            {
                return null;
            }
            Label_050D:
            if (IsLocalCache)
            {
                SaveCacheXMLToFile(ds, cacheFile);
            }
            return ds;
        }
        public static string GetColumnAlias(string strColName, string strTblName)
        {
            AAColumnAliasInfo aAColumnAliasByColumnNameAndTableName = new AAColumnAliasController().GetAAColumnAliasByColumnNameAndTableName(strColName, strTblName);
            if (aAColumnAliasByColumnNameAndTableName != null)
            {
                return aAColumnAliasByColumnNameAndTableName.AAColumnAliasCaption;
            }
            return "";
        }

        public static Type GetColumnDataType(string strTableName, string strColumnName)
        {
            string columnDataType = GMCDbUtil.GetColumnDataType(strTableName, strColumnName);
            switch (columnDataType)
            {
                case "decimal":
                    return typeof(decimal);
                    break;
                case "nvarchar":
                case "text":
                case "nchar":
                case "ntext":
                case "varchar":
                    return typeof(string);
                    break;
                case "bit":
                    return typeof(bool);
                    break;
                case "image":
                case "varbinary":
                    return typeof(byte[]);
                    break;
                case "int":
                    return typeof(int);
                    break;
                case "float":
                case "real":
                    return typeof(double);
                    break;
                case "datetime":
                case "date":
                    return typeof(DateTime);
                    break;
                default:
                    return typeof(string);
                    break;
            }
        }

        public static string GetCSharpVariableType(string strTableName, string strColumnName)
        {
            string columnDataType = GMCDbUtil.GetColumnDataType(strTableName, strColumnName);
            switch (columnDataType)
            {
                case "decimal":
                    return "decimal";
                    break;
                case "nvarchar":
                case "text":
                case "nchar":
                case "ntext":
                case "varchar":
                    return "String";
                    break;
                case "bit":
                    return "bool";
                    break;
                case "image":
                case "varbinary":
                    return "byte[]";
                    break;
                case "int":
                    return "int";
                    break;
                case "float":
                case "real":
                    return "double";
                    break;
                case "datetime":
                case "date":
                    return "DateTime";
                    break;
                default:
                    return "_UNKNOWN_";
                    break;
            }
        }

        public static DateTime GetDocDate(BusinessObject objMainObject)
        {
            DateTime now = DateTime.Now;
            string tableNameFromBusinessObject = GetTableNameFromBusinessObject(objMainObject);
            string strPropertyName = tableNameFromBusinessObject.Substring(0, tableNameFromBusinessObject.Length - 1) + "Date";
            object propertyValue = GMCDbUtil.GetPropertyValue(objMainObject, strPropertyName);
            if (propertyValue != null)
            {
                now = Convert.ToDateTime(propertyValue);
            }
            return now;
        }

        public static string GetFullTypeName(string strTypeName)
        {
            string str = strTypeName;
            if (strTypeName == "Int32")
            {
                str = "System." + strTypeName;
            }
            return str;
        }

        public static Type GetGMCType(string strFullTypeName, string strAssembly)
        {
            try
            {
                Assembly assembly = Assembly.Load(strAssembly);
                if (assembly != null)
                {
                    return assembly.GetType(strFullTypeName);
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<string> GetLocalIPAddress()
        {
            List<string> list = new List<string>();
            string item = string.Empty;
            string str2 = string.Empty;
            item = Dns.GetHostName();
            list.Add(item);
            IPAddress[] addressList = Dns.GetHostByName(item).AddressList;
            foreach (IPAddress address in addressList)
            {
                str2 = address.ToString();
                list.Add(str2);
            }
            return list;
        }

        public static string GetModuleName(string strTableName)
        {
            string str = strTableName.Substring(2, strTableName.Length - 3);
            if (str.EndsWith("ie"))
            {
                str = str.Substring(0, str.Length - 2) + "y";
            }
            return str;
        }

        public static DateTime GetMonthBeginDate()
        {
            return GetMonthBeginDate(new DateTime?(DateTime.Now)).Value;
        }

        public static DateTime? GetMonthBeginDate(DateTime? pdt)
        {
            if (!pdt.HasValue)
            {
                return pdt;
            }
            return new DateTime(pdt.Value.Year, pdt.Value.Month, 1);
        }

        public static DateTime GetMonthEndDate()
        {
            return GetMonthEndDate(new DateTime?(DateTime.Now)).Value;
        }

        public static DateTime? GetMonthEndDate(DateTime? pdt)
        {
            if (!pdt.HasValue)
            {
                return pdt;
            }
            return new DateTime?(GetMonthBeginDate(pdt).Value.AddMonths(1).Date.AddDays(-1.0));
        }

        public static DateTime GetQuarterBeginDate()
        {
            return GetQuarterBeginDate(new DateTime?(DateTime.Now)).Value;
        }

        public static DateTime? GetQuarterBeginDate(DateTime? pdt)
        {
            if (!pdt.HasValue)
            {
                return pdt;
            }
            return new DateTime(pdt.Value.Year, (Convert.ToInt32((int)((pdt.Value.Month + 2) / 3)) * 3) - 2, 1);
        }

        public static DateTime GetQuarterEndDate()
        {
            return GetQuarterEndDate(new DateTime?(DateTime.Now)).Value;
        }

        public static DateTime? GetQuarterEndDate(DateTime? pdt)
        {
            if (!pdt.HasValue)
            {
                return pdt;
            }
            return new DateTime?(GetQuarterBeginDate(pdt).Value.AddMonths(3).AddDays(-1.0));
        }

        //public static RepositoryItem GetRepositoryItemFromText(string strRepositoryItem)
        //{
        //    switch (strRepositoryItem)
        //    {
        //        case "RepositoryItemTextEdit":
        //            return new RepositoryItemTextEdit();

        //        case "RepositoryItemHyperLinkEdit":
        //            return new RepositoryItemHyperLinkEdit();

        //        case "RepositoryItemComboBox":
        //            return new RepositoryItemComboBox();

        //        case "RepositoryItemDateEdit":
        //            return new RepositoryItemDateEdit();

        //        case "RepositoryItemTimeEdit":
        //            return new RepositoryItemTimeEdit();

        //        case "RepositoryItemLookupEdit":
        //            return new RepositoryItemLookUpEdit();
        //    }
        //    return null;
        //}

        public static string GetTableNameAlias(string strTblName)
        {
            AATableNameAliasInfo aATableNameAliasByTableName = new AATableNameAliasController().GetAATableNameAliasByTableName(strTblName);
            if (aATableNameAliasByTableName != null)
            {
                return aATableNameAliasByTableName.AATableNameAliasCaption;
            }
            return "";
        }

        public static string GetTableNameFromBusinessObject(BusinessObject objInfo)
        {
            if (objInfo != null)
            {
                if (!string.IsNullOrEmpty(objInfo.TableName))
                {
                    return objInfo.TableName;
                }
                string name = objInfo.GetType().Name;
                return name.Substring(0, name.Length - 4);
            }
            return "CSDummy";
        }

        public static string GetTableNameFromBusinessObjectType(Type tpBusinessObject)
        {
            string name = tpBusinessObject.Name;
            return name.Substring(0, name.Length - 4);
        }

        public static DateTime GetYearBeginDate()
        {
            return GetYearBeginDate(new DateTime?(DateTime.Now)).Value;
        }

        public static DateTime? GetYearBeginDate(DateTime? pdt)
        {
            if (!pdt.HasValue)
            {
                return pdt;
            }
            return new DateTime(pdt.Value.Year, 1, 1);
        }

        public static DateTime GetYearEndDate()
        {
            return GetYearEndDate(new DateTime?(DateTime.Now)).Value;
        }

        public static DateTime? GetYearEndDate(DateTime? pdt)
        {
            if (!pdt.HasValue)
            {
                return pdt;
            }
            return new DateTime?(GetYearBeginDate(pdt).Value.AddYears(1).AddDays(-1.0));
        }

        public static bool IsDirectory(string path)
        {
            try
            {
                FileInfo info = new FileInfo(path);
                string name = info.Name;
                if ((name != "") && Directory.Exists(path.Replace(name, "")))
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        public static bool IsDrive(string val)
        {
            char[] separator = new char[] { '\\' };
            string[] strArray = val.Split(separator);
            string[] logicalDrives = Directory.GetLogicalDrives();
            foreach (string str in logicalDrives)
            {
                foreach (string str2 in strArray)
                {
                    if (str.Equals(str2.ToUpper() + @"\"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //public static bool IsEditControl(Control ctrl)
        //{
        //    return ctrl.GetType().Name.Contains("Edit");
        //}

        //public static bool IsEditRepository(RepositoryItem rep)
        //{
        //    return ((rep.GetType() == typeof(RepositoryItemTextEdit)) || ((rep.GetType() == typeof(RepositoryItemComboBox)) || ((rep.GetType() == typeof(RepositoryItemDateEdit)) || ((rep.GetType() == typeof(RepositoryItemTimeEdit)) || (rep.GetType() == typeof(RepositoryItemLookUpEdit))))));
        //}

        public static bool IsFile(string path)
        {
            return File.Exists(path);
        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static bool IsFileNull(string path)
        {
            try
            {
                FileInfo info = new FileInfo(path);
                string name = info.Name;
                if (name != "")
                {
                    if (name.EndsWith(".xlsx"))
                    {
                        return true;
                    }
                    if (name.EndsWith(".xls"))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return false;
        }
        private static bool IsValidCacheXMLFile(string fileXML, string CacheNo)
        {
            if (!System.IO.File.Exists(fileXML))
            {
                return false;
            }
            if (dicSTCaches.ContainsKey(CacheNo) && (dicSTCaches[CacheNo] >= System.IO.File.GetLastWriteTime(fileXML)))
            {
                return false;
            }
            return true;
        }
        public static bool IsValidPath(string path)
        {
            try
            {
                char[] chArray = path.ToCharArray();
                for (int i = 0; i < chArray.Length; i++)
                {
                    if (chArray[i].ToString().Equals(@"\") && chArray.GetValue((int)(i + 1)).ToString().Equals(@"\"))
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
            }
            return true;
        }
        public static void InitSTCache()
        {
            string connectionStringFromRegistry = SqlDatabaseHelper.GetConnectionStringFromRegistry(_companyName);
            using (SqlConnection connection = new SqlConnection(connectionStringFromRegistry))
            {
                if (StartSQLDependency(connectionStringFromRegistry))
                {
                    using (SqlCommand command = new SqlCommand("SELECT STCacheNo, STCacheDate FROM dbo.[STCaches]", connection))
                    {
                        command.Notification = null;
                        command.CommandType = CommandType.Text;
                        new SqlDependency(command).OnChange += new OnChangeEventHandler(GMCUtil.OnDependencyChange);
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            using (DataSet set = new DataSet())
                            {
                                try
                                {
                                    adapter.Fill(set);
                                    connection.Close();
                                    dicSTCaches = set.Tables[0].AsEnumerable().ToDictionary<DataRow, string, DateTime>(row => row.Field<string>("STCacheNo"), row => row.Field<DateTime>("STCacheDate"));
                                    dtLastCache = dicSTCaches.Values.Max<DateTime>();
                                }
                                catch (Exception)
                                {
                                    dicSTCaches.Clear();
                                    StopSQLDependency(connectionStringFromRegistry);
                                }
                                if (dicSTCaches.ContainsKey("") && (dicSTCaches[""] > Directory.GetLastWriteTime(CacheDir)))
                                {
                                    DeleteAllCacheXML();
                                }
                                IsLocalCache = dicSTCaches.Count > 0;
                            }
                        }
                    }
                }
            }
        }
        public static bool ObjectIsEditingByOtherUser(string strModuleName, int iObjectID)
        {
            if (iObjectID > 0)
            {
                GEUserAuditsController controller = new GEUserAuditsController();
                if (controller.GetGEUserAuditsByModuleNameAndParameterAndAction(strModuleName, iObjectID.ToString(), "Edit") != null)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SaveCacheXML(DataSet ds, string CacheNo)
        {
            string cacheFile = GetCacheFile(CacheNo);
            SaveCacheXMLToFile(ds, cacheFile);
            return true;
        }

        public static bool SaveCacheXML(DataTable dt, string CacheNo)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dt.Copy());
            return SaveCacheXML(ds, CacheNo);
        }

        public static bool SaveCacheXMLToFile(DataSet ds, string fileXML)
        {
            Task.Factory.StartNew(delegate {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileXML));
                    ds.WriteXml(fileXML, XmlWriteMode.WriteSchema);
                    System.IO.File.SetLastWriteTime(fileXML, SqlDatabaseHelper.GetServerDateTime());
                }
                catch
                {
                }
            });
            return true;
        }
        private static void OnDependencyChange(object sender, SqlNotificationEventArgs e)
        {
            if (IsLocalCache)
            {
                Task.Factory.StartNew(delegate {
                    using (DataSet set = SqlDatabaseHelper.GMCDatabase.ExecuteDataSet(CommandType.Text, string.Format("SELECT STCacheNo, STCacheDate FROM dbo.[STCaches](NOLOCK) WHERE STCacheDate > '{0}'", dtLastCache.ToString("yyyyMMdd hh:mm:ss"))))
                    {
                        Dictionary<string, DateTime> dicSTCaches = GMCUtil.dicSTCaches;
                        lock (dicSTCaches)
                        {
                            Parallel.ForEach<DataRow>(set.Tables[0].AsEnumerable(), delegate (DataRow dr) {
                                if (!GMCUtil.dicSTCaches.ContainsKey(dr.Field<string>("STCacheNo")))
                                {
                                    GMCUtil.dicSTCaches.Add(dr.Field<string>("STCacheNo"), dr.Field<DateTime>("STCacheDate"));
                                }
                                else
                                {
                                    GMCUtil.dicSTCaches[dr.Field<string>("STCacheNo")] = dr.Field<DateTime>("STCacheDate");
                                }
                                DeleteAllCacheXML(CacheDir + dr.Field<string>("STCacheNo"));
                            });
                            ReOnDependencyChange();
                        }
                    }
                });
            }
        }

        public static void ReOnDependencyChange()
        {
            using (SqlConnection connection = new SqlConnection(SqlDatabaseHelper.GetConnectionStringFromRegistry(_companyName)))
            {
                using (SqlCommand command = new SqlCommand("SELECT STCacheNo, STCacheDate FROM dbo.[STCaches]", connection))
                {
                    command.Notification = null;
                    command.CommandType = CommandType.Text;
                    new SqlDependency(command).OnChange += new OnChangeEventHandler(GMCUtil.OnDependencyChange);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        try
                        {
                            adapter.Fill(dataSet);
                            connection.Close();
                        }
                        catch (Exception)
                        {
                        }
                        finally
                        {
                            if (dataSet != null)
                            {
                                dataSet.Dispose();
                            }
                        }
                    }
                }
            }
        }
        public static bool StartSQLDependency(string ConnectString)
        {
            try
            {
                SqlDependency.Stop(ConnectString);
                SqlDependency.Start(ConnectString);
                IsSQLDependency = true;
            }
            catch (InvalidOperationException)
            {
                IsSQLDependency = false;
            }
            return IsSQLDependency;
        }

        public static bool StopSQLDependency()
        {
            return StopSQLDependency(SqlDatabaseHelper.GetConnectionStringFromRegistry(_companyName));
        }

        public static bool StopSQLDependency(string ConnectString)
        {
            try
            {
                SqlDependency.Stop(ConnectString);
                IsSQLDependency = false;
            }
            catch (InvalidOperationException)
            {
            }
            return IsSQLDependency;
        }
        public static double Round(double dbNumber, int iDigit)
        {
            return Math.Round(dbNumber, iDigit, MidpointRounding.AwayFromZero);
        }

        public static string NewLine
        {
            get
            {
                return "\n";
            }
        }

        public static string Tab
        {
            get
            {
                return "\t";
            }
        }
        public static string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                _companyName = value;
                CacheDir = Application.StartupPath + string.Format(@"\Cache\{0}\", _companyName);
                IsLocalCache = Directory.Exists(CacheDir);
                InitSTCache();
            }
        }
        public static string CurrentLanguage
        {
            get
            {
                return _currentLanguage;
            }
            set
            {
                _currentLanguage = value;
            }
        }
        public static BusinessObject Branch
        {
            get
            {
                return _bRBranchInfo;
            }
            set
            {
                _bRBranchInfo = value;
            }
        }
    }
    public class Crypto
    {
        private const string CRYPT_DEFAULT_PASSWORD = "namtrung";
        private const CryptoTypes CRYPT_DEFAULT_METHOD = CryptoTypes.encTypeRijndael;
        private byte[] mKey;
        private byte[] mIV;
        private byte[] SaltByteArray;
        private CryptoTypes mCryptoType;
        private string mPassword;

        public Crypto()
        {
            this.mKey = new byte[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0x10,
                0x11, 0x12, 0x13, 20, 0x15, 0x16, 0x17, 0x18
            };
            this.mIV = new byte[] { 0x41, 110, 0x44, 0x1a, 0x45, 0xb2, 200, 0xdb };
            this.SaltByteArray = new byte[] { 0x49, 0x76, 0x61, 110, 0x20, 0x4d, 0x65, 100, 0x76, 0x65, 100, 0x65, 0x76 };
            this.mCryptoType = CryptoTypes.encTypeRijndael;
            this.mPassword = "namtrung";
            this.calculateNewKeyAndIV();
        }

        public Crypto(CryptoTypes CryptoType)
        {
            this.mKey = new byte[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0x10,
                0x11, 0x12, 0x13, 20, 0x15, 0x16, 0x17, 0x18
            };
            this.mIV = new byte[] { 0x41, 110, 0x44, 0x1a, 0x45, 0xb2, 200, 0xdb };
            this.SaltByteArray = new byte[] { 0x49, 0x76, 0x61, 110, 0x20, 0x4d, 0x65, 100, 0x76, 0x65, 100, 0x65, 0x76 };
            this.mCryptoType = CryptoTypes.encTypeRijndael;
            this.mPassword = "namtrung";
            this.CryptoType = CryptoType;
        }

        private void calculateNewKeyAndIV()
        {
            PasswordDeriveBytes bytes = new PasswordDeriveBytes(this.mPassword, this.SaltByteArray);
            SymmetricAlgorithm algorithm = this.selectAlgorithm();
            this.mKey = bytes.GetBytes(algorithm.KeySize / 8);
            this.mIV = bytes.GetBytes(algorithm.BlockSize / 8);
        }

        public void calculateRandomKeyAndIV(CryptoTypes cryptoType)
        {
            this.CryptoType = cryptoType;
            byte[] data = new byte[5];
            new RNGCryptoServiceProvider().GetNonZeroBytes(data);
            this.mPassword = Convert.ToBase64String(data);
            byte[] buffer2 = new byte[Math.Max(0x20 - this.mPassword.Length, 0)];
            new RNGCryptoServiceProvider().GetBytes(buffer2);
            this.SaltByteArray = buffer2;
            PasswordDeriveBytes bytes = new PasswordDeriveBytes(this.mPassword, this.SaltByteArray);
            SymmetricAlgorithm algorithm = this.selectAlgorithm();
            this.mKey = bytes.GetBytes(algorithm.KeySize / 8);
            this.mIV = new byte[algorithm.BlockSize / 8];
            for (int i = 0; i < this.mIV.Length; i++)
            {
                this.mIV[i] = 0;
            }
        }

        public byte[] Decrypt(byte[] input)
        {
            return this.EncryptDecrypt(input, false);
        }

        public string Decrypt(string inputText)
        {
            try
            {
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] inputBytes = Convert.FromBase64String(inputText);
                return encoding.GetString(this.EncryptDecrypt(inputBytes, false));
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string Decrypt(string inputText, string password)
        {
            this.Password = password;
            return this.Decrypt(inputText);
        }

        public string Decrypt(string inputText, string password, CryptoTypes cryptoType)
        {
            this.mCryptoType = cryptoType;
            this.Password = password;
            return this.Decrypt(inputText);
        }

        public string Encrypt(string inputText)
        {
            byte[] bytes = new UTF8Encoding().GetBytes(inputText);
            return Convert.ToBase64String(this.EncryptDecrypt(bytes, true));
        }

        public byte[] Encrypt(byte[] input)
        {
            return this.EncryptDecrypt(input, true);
        }

        public string Encrypt(string inputText, string password)
        {
            this.Password = password;
            return this.Encrypt(inputText);
        }

        public string Encrypt(string inputText, string password, CryptoTypes cryptoType)
        {
            this.mCryptoType = cryptoType;
            this.Password = password;
            return this.Encrypt(inputText);
        }

        private byte[] EncryptDecrypt(byte[] inputBytes, bool Encrpyt)
        {
            byte[] buffer2;
            ICryptoTransform transform = this.getCryptoTransform(Encrpyt);
            MemoryStream stream = new MemoryStream();
            try
            {
                CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
                stream2.Write(inputBytes, 0, inputBytes.Length);
                stream2.FlushFinalBlock();
                byte[] buffer = stream.ToArray();
                stream2.Close();
                buffer2 = buffer;
            }
            catch (Exception exception)
            {
                throw new Exception("Error in symmetric engine. Error : " + exception.Message, exception);
            }
            return buffer2;
        }

        private ICryptoTransform getCryptoTransform(bool encrypt)
        {
            SymmetricAlgorithm algorithm = this.selectAlgorithm();
            algorithm.Key = this.mKey;
            algorithm.IV = this.mIV;
            if (encrypt)
            {
                return algorithm.CreateEncryptor();
            }
            return algorithm.CreateDecryptor();
        }

        public void InitIV()
        {
            SymmetricAlgorithm algorithm = this.selectAlgorithm();
            this.mIV = new byte[algorithm.BlockSize / 8];
            for (int i = 0; i < this.mIV.Length; i++)
            {
                this.mIV[i] = 0;
            }
        }

        private SymmetricAlgorithm selectAlgorithm()
        {
            switch (this.mCryptoType)
            {
                case CryptoTypes.encTypeDES:
                    return DES.Create();

                case CryptoTypes.encTypeRC2:
                    return RC2.Create();

                case CryptoTypes.encTypeRijndael:
                    return Rijndael.Create();

                case CryptoTypes.encTypeTripleDES:
                    return TripleDES.Create();
            }
            return TripleDES.Create();
        }

        public CryptoTypes CryptoType
        {
            get
            {
                return this.mCryptoType;
            }
            set
            {
                if (this.mCryptoType != value)
                {
                    this.mCryptoType = value;
                    this.calculateNewKeyAndIV();
                }
            }
        }

        public string Password
        {
            get
            {
                return this.mPassword;
            }
            set
            {
                if (this.mPassword != value)
                {
                    this.mPassword = value;
                    this.calculateNewKeyAndIV();
                }
            }
        }

        public byte[] Key
        {
            get
            {
                return this.mKey;
            }
            set
            {
                this.mKey = value;
            }
        }

        public enum CryptoTypes
        {
            encTypeDES,
            encTypeRC2,
            encTypeRijndael,
            encTypeTripleDES
        }
    }
    public class RegistryWorker
    {
        public const string ExpriredDate = "ExpriredDate";
        public const string ProductLimited = "ProductLimited";
        public const string CustomerLimited = "CustomerLimited";
        private bool showError = false;
        private string subKey = (@"SOFTWARE\" + Application.ProductName.ToUpper());
        private RegistryKey baseRegistryKey = Registry.LocalMachine;

        public bool DeleteKey(string KeyName)
        {
            try
            {
                RegistryKey key2 = this.baseRegistryKey.CreateSubKey(this.subKey);
                if (key2 != null)
                {
                    key2.DeleteValue(KeyName);
                }
                return true;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Deleting SubKey " + this.subKey);
                return false;
            }
        }

        public bool DeleteSubKeyTree()
        {
            try
            {
                RegistryKey baseRegistryKey = this.baseRegistryKey;
                if (baseRegistryKey.OpenSubKey(this.subKey) != null)
                {
                    baseRegistryKey.DeleteSubKeyTree(this.subKey);
                }
                return true;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Deleting SubKey " + this.subKey);
                return false;
            }
        }

        public string[] GetSubKeys(string ParentKeyName)
        {
            RegistryKey key2 = this.baseRegistryKey.OpenSubKey(ParentKeyName);
            if (key2 == null)
            {
                return null;
            }
            try
            {
                return key2.GetSubKeyNames();
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Reading registry " + ParentKeyName.ToUpper());
                return null;
            }
        }

        public string Read(string KeyName)
        {
            RegistryKey key2 = this.baseRegistryKey.OpenSubKey(this.subKey);
            if (key2 == null)
            {
                return null;
            }
            try
            {
                return (string)key2.GetValue(KeyName.ToUpper());
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Reading registry " + KeyName.ToUpper());
                return null;
            }
        }

        public string Read(string ParentKeyName, string ValueName)
        {
            RegistryKey key2 = this.baseRegistryKey.OpenSubKey(ParentKeyName);
            if (key2 == null)
            {
                return string.Empty;
            }
            try
            {
                return (string)key2.GetValue(ValueName.ToUpper());
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Reading registry " + ValueName.ToUpper());
                return string.Empty;
            }
        }

        private void ShowErrorMessage(Exception e, string Title)
        {
            if (this.showError)
            {
                //XtraMessageBox.Show(e.Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public int SubKeyCount()
        {
            try
            {
                RegistryKey key2 = this.baseRegistryKey.OpenSubKey(this.subKey);
                if (key2 != null)
                {
                    return key2.SubKeyCount;
                }
                return 0;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Retriving subkeys of " + this.subKey);
                return 0;
            }
        }

        public int ValueCount()
        {
            try
            {
                RegistryKey key2 = this.baseRegistryKey.OpenSubKey(this.subKey);
                if (key2 != null)
                {
                    return key2.ValueCount;
                }
                return 0;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Retriving keys of " + this.subKey);
                return 0;
            }
        }

        public bool Write(string KeyName, object Value)
        {
            try
            {
                this.baseRegistryKey.OpenSubKey(this.subKey).SetValue(KeyName, Value);
                return true;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Writing registry " + KeyName);
                return false;
            }
        }

        public bool Write(string KeyName, string strValue, object objValue)
        {
            try
            {
                this.baseRegistryKey.CreateSubKey(KeyName).SetValue(strValue.ToUpper(), objValue);
                return true;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Writing registry " + KeyName.ToUpper());
                return false;
            }
        }

        public bool Write(string KeyName, string strValue, object objValue, RegistryValueKind regType)
        {
            try
            {
                this.baseRegistryKey.OpenSubKey(KeyName).SetValue(strValue.ToUpper(), objValue, regType);
                return true;
            }
            catch (Exception exception)
            {
                this.ShowErrorMessage(exception, "Writing registry " + KeyName.ToUpper());
                return false;
            }
        }

        public bool ShowError
        {
            get
            {
                return this.showError;
            }
            set
            {
                this.showError = value;
            }
        }

        public string SubKey
        {
            get
            {
                return this.subKey;
            }
            set
            {
                this.subKey = value;
            }
        }

        public RegistryKey BaseRegistryKey
        {
            get
            {
                return this.baseRegistryKey;
            }
            set
            {
                this.baseRegistryKey = value;
            }
        }
    }
    public class Hashlist : IDictionary, ICollection, IEnumerable
    {
        protected ArrayList m_oKeys = new ArrayList();
        protected Hashtable m_oValues = new Hashtable();

        public void Add(object oKey, object oValue)
        {
            this.m_oKeys.Add(oKey);
            this.m_oValues.Add(oKey, oValue);
        }

        public void Clear()
        {
            this.m_oValues.Clear();
            this.m_oKeys.Clear();
        }

        public bool Contains(object oKey)
        {
            return this.m_oValues.Contains(oKey);
        }

        public bool ContainsKey(object oKey)
        {
            return this.m_oValues.ContainsKey(oKey);
        }

        public void CopyTo(Array oArray, int iArrayIndex)
        {
            this.m_oValues.CopyTo(oArray, iArrayIndex);
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return this.m_oValues.GetEnumerator();
        }

        public object GetKey(int iIndex)
        {
            return this.m_oKeys[iIndex];
        }

        public void Remove(object oKey)
        {
            this.m_oValues.Remove(oKey);
            this.m_oKeys.Remove(oKey);
        }

        public void SetKey(int iIndex, object value)
        {
            this.m_oKeys[iIndex] = value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.m_oValues.GetEnumerator();
        }

        public int Count
        {
            get
            {
                return this.m_oValues.Count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return this.m_oValues.IsSynchronized;
            }
        }

        public object SyncRoot
        {
            get
            {
                return this.m_oValues.SyncRoot;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return this.m_oKeys.IsFixedSize;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return this.m_oKeys.IsReadOnly;
            }
        }

        public ICollection Keys
        {
            get
            {
                return this.m_oValues.Keys;
            }
        }

        public object this[object oKey]
        {
            get
            {
                return this.m_oValues[oKey];
            }
            set
            {
                this.m_oValues[oKey] = value;
            }
        }

        public ICollection Values
        {
            get
            {
                return this.m_oValues.Values;
            }
        }

        public object this[string Key]
        {
            get
            {
                return this.m_oValues[Key];
            }
            set
            {
                this.m_oValues[Key] = value;
            }
        }

        public object this[int Index]
        {
            get
            {
                return this.m_oValues[this.m_oKeys[Index]];
            }
            set
            {
                this.m_oValues[this.m_oKeys[Index]] = value;
            }
        }
    }
    public class VersionInfo
    {
        public VersionInfo()
        {
            this.VersionCode = string.Empty;
            this.VersionName = string.Empty;
        }

        public DateTime ReleaseDate { get; set; }

        public DateTime UpdatedTime { get; set; }

        public string VersionCode { get; set; }

        public string VersionName { get; set; }
    }
    public class XtraMessageBox
    {
        public static void Show(string sContent, string sCaption = "")
        {
            System.Web.HttpContext.Current.Response.Write("<script>alert('ok');</script>");
        }
    }
    public class XMLTreeFieldNode
    {
        public XMLTreeFieldNode parentNode;
        public SortedList<int, XMLTreeFieldNode> ChildrenNodes;
        public STFieldsInfo fieldValue;
        public int level;
        public bool isSetIndex;

        public XMLTreeFieldNode(STFieldsInfo objFieldInfo)
        {
            this.fieldValue = objFieldInfo;
            this.ChildrenNodes = new SortedList<int, XMLTreeFieldNode>();
        }

        public static XMLTreeFieldNode CalculateTreeFields(ref DataSet dsSTFields)
        {
            XMLTreeFieldNode node = new XMLTreeFieldNode(null);
            STFieldsController controller = new STFieldsController();
            SortedList<int, XMLTreeFieldNode> list = new SortedList<int, XMLTreeFieldNode>();
            foreach (DataRow row in dsSTFields.Tables[0].Rows)
            {
                STFieldsInfo objectFromDataRow = (STFieldsInfo)controller.GetObjectFromDataRow(row);
                XMLTreeFieldNode node2 = new XMLTreeFieldNode(objectFromDataRow);
                list.Add(objectFromDataRow.STFieldID, node2);
                if (node2.fieldValue.STFieldParentID != 0)
                {
                    if (list.ContainsKey(node2.fieldValue.STFieldParentID))
                    {
                        node2.parentNode = list[node2.fieldValue.STFieldParentID];
                        if (node2.parentNode.ChildrenNodes.ContainsKey(node2.fieldValue.STFieldZOrder))
                        {
                            int key = node2.parentNode.ChildrenNodes.Keys[node2.parentNode.ChildrenNodes.Keys.Count - 1] + 1;
                            node2.parentNode.ChildrenNodes.Add(key, node2);
                        }
                        else
                        {
                            node2.parentNode.ChildrenNodes.Add(node2.fieldValue.STFieldZOrder, node2);
                        }
                        node2.level = node2.parentNode.level + 1;
                        Parallel.ForEach<XMLTreeFieldNode>(node2.ChildrenNodes.Values, delegate (XMLTreeFieldNode childNode)
                        {
                            childNode.level++;
                        });
                    }
                }
                else if (node.ChildrenNodes.ContainsKey(node2.fieldValue.STFieldZOrder))
                {
                    int key = node.ChildrenNodes.Keys[node.ChildrenNodes.Keys.Count - 1] + 1;
                    node.ChildrenNodes.Add(key, node2);
                }
                else
                {
                    node.ChildrenNodes.Add(node2.fieldValue.STFieldZOrder, node2);
                }
            }
            return node;
        }

        public static List<XMLTreeFieldNode> CalculateTreeFields(List<STFieldsInfo> lstInfo)
        {
            List<XMLTreeFieldNode> list = new List<XMLTreeFieldNode>();
            new STFieldsController();
            using (List<STFieldsInfo>.Enumerator enumerator = lstInfo.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    XMLTreeFieldNode item = new XMLTreeFieldNode(enumerator.Current);
                    list.Add(item);
                }
            }
            foreach (XMLTreeFieldNode node2 in list)
            {
                foreach (XMLTreeFieldNode node3 in list)
                {
                    if ((node3 != node2) && (node3.fieldValue.STFieldParentID == node2.fieldValue.STFieldID))
                    {
                        node3.parentNode = node2;
                    }
                }
            }
            foreach (XMLTreeFieldNode node4 in list)
            {
                int num = 0;
                for (XMLTreeFieldNode node5 = node4; node5.parentNode != null; node5 = node5.parentNode)
                {
                    num++;
                }
                node4.level = num;
            }
            return list;
        }
    }
}
