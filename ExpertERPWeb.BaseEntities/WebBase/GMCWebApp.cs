using ExpertERP.BusinessEntities;
using ExpertWebLib;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExpertERPWeb.BaseEntities
{
    public class GMCWebApp
    {
        public static string CurrentModuleName = string.Empty;
        //public static Form ActiveScreen;
        public static Hashlist OpenModules = new Hashlist();
        public static Assembly ExpertERPAssembly;
        public static string CompanyName = string.Empty;
        public static int NumOfOpenedModules = 5;
        public static string CurrentLang;
        public static string CurrentUser;
        private static DateTime _workingDate;
        private static int _workingPeriod;
        private static int _workingYear;
        private static string _currentServer;
        private static string _currentDatabase;
        private static string strBranch;
        private static string strOnlyModule;
        private static string _sesssionTableName;
        private static string strLoginMethod;
        private static int _sessionObjectID;
        private static int _currentUserGroupID;
        private static ADUserGroupsInfo _currentUserGroupsInfo;
        private static CSCompanysInfo _currentCompanyInfo;
        private static GELanguagesInfo _languageInfo;
        private static string _currentLanguage;
        public static ImageList ToolbarImageList = new ImageList();
        public static ImageList SectionImageList = new ImageList();
        public static ImageList ControlImageList = new ImageList();
        public static Image BackGroundImage = null;
        //public static TreeListMenu AppMenu = null;
        //public static BarSubItem AppMenuModule = null;
        private static Dictionary<string, DataTable> _lookupTables;
        private static SortedList _lookupTableUpdatedDate;
        private static SortedList _fieldFormatGroups;
        public static SortedList FieldFormatList;
        public static Dictionary<string, string> _dictionary;
        public static Dictionary<string, string> LookupExColumsList = new Dictionary<string, string>();
        public static int _systemCurrencyDecimal = 0;
        public static int _systemUnitPriceCurrencyDecimal = 0;
        public static GECurrencysInfo _systemCurrencysInfo;
        private static int _priceDecimal = 2;
        private static int _countLogonFail = 0;
        private static string _pcName;
        private static string _ipAddress;
        public static string StatUpPath = (Application.StartupPath + @"\Img");
        private static VersionInfo currentVersion = null;
        public static SortedList<string, string> CurrentPermissions;
        public static bool EnableCachingControl = false;
        public const string cstTopResultsSearchControl = "fld_txtTopResults";
        public const int cstTopResults = 10000;//0x2710;
        public static bool IsLoggingOff = false;

        //public static void AddModuleToGroupSection(NavBarGroup fld_navBarGroupApp, int iUserGroupSectionID)
        //{
        //    //STModuleToUserGroupSectionsController controller = new STModuleToUserGroupSectionsController();
        //    //DataSet allModuleToUserGroupSectionByUserGroupSectionID = controller.GetAllModuleToUserGroupSectionByUserGroupSectionID(iUserGroupSectionID);
        //    //if (allModuleToUserGroupSectionByUserGroupSectionID.Tables.Count > 0)
        //    //{
        //    //    foreach (DataRow row in allModuleToUserGroupSectionByUserGroupSectionID.Tables[0].Rows)
        //    //    {
        //    //        STModuleToUserGroupSectionsInfo objectFromDataRow = (STModuleToUserGroupSectionsInfo)controller.GetObjectFromDataRow(row);
        //    //        STModulesController controller2 = new STModulesController();
        //    //        STModulesInfo objSTModulesInfo = new STModulesInfo();
        //    //        objSTModulesInfo = (STModulesInfo)controller2.GetObjectByID(objectFromDataRow.STModuleID);
        //    //        NavBarItem item = new NavBarItem();
        //    //        item.set_Caption(GetModuleDescription(objSTModulesInfo));
        //    //        item.set_Name("fld_navBar" + objSTModulesInfo.STModuleName);
        //    //        item.set_SmallImageIndex(SectionImageList.Images.IndexOfKey(objSTModulesInfo.STModuleName));
        //    //        item.set_Tag(objSTModulesInfo.STModuleName);
        //    //        item.add_LinkClicked(new NavBarLinkEventHandler(null, ModuleItem_LinkClicked));
        //    //        MainScreen.SectionManager.get_Items().Add(item);
        //    //        fld_navBarGroupApp.get_ItemLinks().Add(new NavBarItemLink(item));
        //    //    }
        //    //}
        //    //allModuleToUserGroupSectionByUserGroupSectionID.Dispose();
        //}

        public static void AddOpenModuleToOpenModulesToolStrip(string strModuleName)
        {
            //ToolStripButton button = PopulateOpenModulesToolStripButton(strModuleName);
            //Application.DoEvents();
            //MainScreen.OpenModulesToolStrip.Items.Add(button);
            //Application.DoEvents();
            //button.Visible = false;
            //CheckOpenModuleToolStripButton(button);
            //Application.DoEvents();
        }

        public static bool CheckLicense()
        {
            RegistryWorker worker = new RegistryWorker
            {
                SubKey = @"SOFTWARE\GMC"
            };
            DateTime time = DateTime.Parse(worker.Read("ExpiredDate"));
            return (DateTime.Now > time);
        }

        public static bool CheckLoginCard()
        {
            strLoginMethod = string.Empty;
            bool flag = false;
            RegistryWorker worker = new RegistryWorker();
            try
            {
                strLoginMethod = worker.Read(@"SOFTWARE\GMC\ConnectionString\", "LoginMethod");
            }
            catch
            {
                strLoginMethod = string.Empty;
            }
            if (!string.IsNullOrEmpty(strLoginMethod) && strLoginMethod.ToUpper().Equals("CARD"))
            {
                flag = true;
            }
            return flag;
        }

        public static void CheckOpenModuleToolStripButton(ToolStripButton tsbtnModule)
        {
            tsbtnModule.Checked = true;
            //foreach (ToolStripButton button in MainScreen.OpenModulesToolStrip.Items)
            //{
            //    if (button.Name != tsbtnModule.Name)
            //    {
            //        button.Checked = false;
            //    }
            //    Application.DoEvents();
            //}
        }

        public static void CloseAllOpenModules()
        {
            //while (OpenModules.Count > 0)
            //{
            //    BaseModuleERP eerp = (BaseModuleERP)OpenModules[0];
            //    eerp.Close();
            //    if (OpenModules.Contains(eerp.Name))
            //    {
            //        OpenModules.Remove(eerp.Name);
            //    }
            //}
        }

        public static string ConvertLocalFileNameToFTPFileName(string strLocalFileName)
        {
            return strLocalFileName.Replace(CurrentCompanyInfo.CSCompanyFileServerPath, CurrentCompanyInfo.CSCompanyFTP).Replace(@"\", "//");
        }

        public static string CopyFileToServer(string strFilePath, string strFileName, string strSubFolderName)
        {
            string str = @"\\";
            string str2 = string.Empty;
            if (strFilePath == string.Empty)
            {
                return str2;
            }
            if (!File.Exists(strFilePath))
            {
                XtraMessageBox.Show("File n\x00e0y kh\x00f4ng tồn tại, bạn h\x00e3y kiểm tra v\x00e0 thử l\x00e0m lại", "#Message#");
                return string.Empty;
            }
            string str3 = strSubFolderName + str;
            string path = CurrentCompanyInfo.CSCompanyFileServerPath + str + str3;
            FileInfo info = new FileInfo(strFilePath);
            bool flag2 = true;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
                flag2 = false;
                XtraMessageBox.Show("Đường dẫn đến nơi lưu trữ t\x00e0i liệu kh\x00f4ng ch\x00ednh x\x00e1c \n File t\x00e0i liệu sẽ kh\x00f4ng được lưu lại tr\x00ean server", "#Message#");
                return string.Empty;
            }
            if (!flag2)
            {
                return str2;
            }
            string str7 = string.Empty;
            if (File.Exists(path + @"\" + strFileName))
            {
                str7 = strFileName.Substring(0, strFileName.Length - info.Extension.Length) + "_" + DateTime.Now.ToString();
                if ((str7.Contains("/") || str7.Contains(":")) || str7.Contains(@"\"))
                {
                    str7 = str7.Replace('/', '_').Replace(':', '_').Replace('\\', '_');
                }
                try
                {
                    info.CopyTo(path + @"\" + str7 + info.Extension);
                    str7 = str7 + info.Extension;
                }
                catch
                {
                    XtraMessageBox.Show("You have not permission to access file on server", "Permission"/*, MessageBoxButtons.OK, MessageBoxIcon.Asterisk*/);
                    return string.Empty;
                }
            }
            else
            {
                try
                {
                    FileSystem.CopyFile(strFilePath, path + @"\" + strFileName);
                    str7 = strFileName;
                }
                catch
                {
                    XtraMessageBox.Show("You have not permission to access file on server", "Permission"/*, MessageBoxButtons.OK, MessageBoxIcon.Asterisk*/);
                    return string.Empty;
                }
            }
            return (path + @"\" + str7);
        }

        public static string CopyFileToServer(string strFilePath, string strFileName, string strModuleName, string strObjectNo)
        {
            string str = @"\\";
            string str2 = string.Empty;
            if (strFilePath == string.Empty)
            {
                return str2;
            }
            if (!File.Exists(strFilePath))
            {
                XtraMessageBox.Show("File is not exist", "#Message#");
                return string.Empty;
            }
            string str3 = strModuleName + str + strObjectNo;
            string path = CurrentCompanyInfo.CSCompanyFileServerPath + str + str3;
            FileInfo info = new FileInfo(strFilePath);
            bool flag2 = true;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {
                flag2 = false;
                XtraMessageBox.Show("Đường dẫn đến nơi lưu trữ t\x00e0i liệu kh\x00f4ng ch\x00ednh x\x00e1c \n File t\x00e0i liệu sẽ kh\x00f4ng được lưu lại tr\x00ean server", "#Message#");
                return string.Empty;
            }
            if (!flag2)
            {
                return str2;
            }
            string str7 = string.Empty;
            if (File.Exists(path + @"\" + strFileName))
            {
                str7 = strFileName.Substring(0, strFileName.Length - info.Extension.Length) + "_" + DateTime.Now.ToString();
                if ((str7.Contains("/") || str7.Contains(":")) || str7.Contains(@"\"))
                {
                    str7 = str7.Replace('/', '_').Replace(':', '_').Replace('\\', '_');
                }
                try
                {
                    info.CopyTo(path + @"\" + str7 + info.Extension);
                    str7 = str7 + info.Extension;
                }
                catch
                {
                    XtraMessageBox.Show("You have not permission to access file on server", "Permission"/*, MessageBoxButtons.OK, MessageBoxIcon.Asterisk*/);
                    return string.Empty;
                }
            }
            else
            {
                try
                {
                    FileSystem.CopyFile(strFilePath, path + @"\" + strFileName);
                    str7 = strFileName;
                }
                catch
                {
                    XtraMessageBox.Show("You have not permission to access file on server", "Permission"/*, MessageBoxButtons.OK, MessageBoxIcon.Asterisk*/);
                    return string.Empty;
                }
            }
            return (path + @"\" + str7);
        }

        public static void DisableActionToolbarOfOpenModules(string strCurrentModuleName)
        {
            //foreach (string str in OpenModules.Keys)
            //{
            //    if (!str.Equals(strCurrentModuleName))
            //    {
            //        BaseModuleERP eerp = (BaseModuleERP)OpenModules[str];
            //        if (eerp.ParentScreen.ToolbarManager.get_Bars().get_Item("Action") != null)
            //        {
            //            eerp.ParentScreen.ToolbarManager.get_Bars().get_Item("Action").set_Visible(false);
            //        }
            //    }
            //}
        }

        public static void Download(string strClientFileName, string strFTPFileName, string ftpUserName, string ftpPassword)
        {
            //WaitDialogForm form = new WaitDialogForm();
            //form.set_Caption("Download file");
            try
            {
                FileStream stream = new FileStream(strClientFileName, FileMode.Create);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(strFTPFileName));
                request.Method = "RETR";
                request.UseBinary = true;
                request.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                long contentLength = response.ContentLength;
                int count = 0x800;
                byte[] buffer = new byte[count];
                for (int i = responseStream.Read(buffer, 0, count); i > 0; i = responseStream.Read(buffer, 0, count))
                {
                    stream.Write(buffer, 0, i);
                }
                responseStream.Close();
                stream.Close();
                response.Close();
                //form.Close();
            }
            catch (Exception exception)
            {
                //form.Close();
                XtraMessageBox.Show(exception.Message);
            }
        }

        public static void EnableActionToolbarOfOpenModules(string strCurrentModuleName)
        {
            //foreach (string str in OpenModules.Keys)
            //{
            //    if (!str.Equals(strCurrentModuleName))
            //    {
            //        BaseModuleERP eerp = (BaseModuleERP)OpenModules[str];
            //        if (eerp.ParentScreen.ToolbarManager.get_Bars().get_Item("Action") != null)
            //        {
            //            eerp.ParentScreen.ToolbarManager.get_Bars().get_Item("Action").set_Visible(true);
            //        }
            //    }
            //}
        }

        public static string ForeignKeyValue(string strTableName, string strColumName, int iValue)
        {
            string objectNoByID = string.Empty;
            try
            {
                string primaryTableWhichForeignColumnReferenceTo = GMCDbUtil.GetPrimaryTableWhichForeignColumnReferenceTo(strTableName, strColumName);
                if (string.IsNullOrEmpty(primaryTableWhichForeignColumnReferenceTo))
                {
                    return objectNoByID;
                }
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(primaryTableWhichForeignColumnReferenceTo + "Controller");
                if (businessController != null)
                {
                    objectNoByID = businessController.GetObjectNoByID(iValue);
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show("here fail +" + exception.Message);
            }
            return objectNoByID;
        }

        public static string GetControlText(string strDefaultText)
        {
            string str = strDefaultText;
            if (_currentLanguage == "en")
            {
                if (!_dictionary.ContainsKey(strDefaultText.Trim()))
                {
                    return str;
                }
                string str2 = _dictionary[strDefaultText.Trim()];
                if (!string.IsNullOrEmpty(str2))
                {
                    str = str2;
                }
            }
            return str;
        }

        public static HREmployeesInfo GetEmployeeByUserName(string strUserName)
        {
            HREmployeesController controller = new HREmployeesController();
            ADUsersController controller2 = new ADUsersController();
            ADUsersInfo objectByName = (ADUsersInfo)controller2.GetObjectByName(strUserName);
            if (objectByName == null)
            {
                return null;
            }
            return (HREmployeesInfo)controller.GetFirstObjectByForeignColumn("FK_ADUserID", objectByName.ADUserID);
        }

        public static STFieldFormatGroupsInfo GetFieldFormatGroup(string strModuleName, string strTableName, string strColumnName)
        {
            STFieldFormatGroupsInfo info = null;
            string[] textArray1 = new string[] { strModuleName, "_", strTableName, "_", strColumnName };
            string str = string.Concat(textArray1);
            DataRow row = (DataRow)FieldFormatList[str];
            if (row != null)
            {
                string str2 = row["STFieldFormatGroupName"].ToString();
                info = (STFieldFormatGroupsInfo)FieldFormatGroups[str2];
            }
            return info;
        }

        public static void GetFunctionalDecimal(BusinessObject objMainObject, ref int iFTotalCurrencyDecimal, ref int iFUnitPriceCurrencyDecimal)
        {
            GECurrencysController controller = new GECurrencysController();
            int iObjectID = 0;
            try
            {
                iObjectID = Convert.ToInt32(GMCDbUtil.GetPropertyValue(objMainObject, "FK_GECurrencyID"));
            }
            catch
            {
            }
            if ((CurrentCompanyInfo != null) && (CurrentCompanyInfo.FK_GECurrencyID == iObjectID))
            {
                iFTotalCurrencyDecimal = _systemCurrencyDecimal;
                iFUnitPriceCurrencyDecimal = _systemUnitPriceCurrencyDecimal;
            }
            else
            {
                GECurrencysInfo objectByID = (GECurrencysInfo)controller.GetObjectByID(iObjectID);
                if (objectByID != null)
                {
                    iFTotalCurrencyDecimal = objectByID.GECurrencyDecimalRound;
                    iFUnitPriceCurrencyDecimal = objectByID.GECurrencyPriceDecimalRound;
                }
                else
                {
                    iFTotalCurrencyDecimal = _systemCurrencyDecimal;
                    iFUnitPriceCurrencyDecimal = _systemUnitPriceCurrencyDecimal;
                }
            }
        }

        //public static GENumberingsInfo GetGENumbering(BaseModuleERP Module)
        //{
        //    GENumberingsInfo objectByName = null;
        //    if (Module.CurrentModuleEntity.MainObject != null)
        //    {
        //        object propertyValue = GMCDbUtil.GetPropertyValue(Module.CurrentModuleEntity.MainObject, "FK_GLTranCfgID");
        //        if (propertyValue != null)
        //        {
        //            int iObjectID = Convert.ToInt32(propertyValue);
        //            if (iObjectID > 0)
        //            {
        //                GLTranCfgsInfo objectByID = (GLTranCfgsInfo)new GLTranCfgsController().GetObjectByID(iObjectID);
        //                if (objectByID != null)
        //                {
        //                    objectByName = (GENumberingsInfo)new GENumberingsController().GetObjectByID(objectByID.FK_GENumberingID);
        //                }
        //            }
        //        }
        //    }
        //    if (objectByName == null)
        //    {
        //        objectByName = (GENumberingsInfo)new GENumberingsController().GetObjectByName(Module.Name);
        //    }
        //    return objectByName;
        //}

        public static double GetItemUOMFactor(int iICFromUOMID, int iICToUOMID)
        {
            ICUOMFactorsController controller = new ICUOMFactorsController();
            return controller.GetUOMFactor(iICFromUOMID, iICToUOMID);
        }

        public static void GetLocalMachineInfo()
        {
            PCName = Dns.GetHostName();
            System.Net.IPAddress[] addressList = Dns.GetHostByName(PCName).AddressList;
            foreach (System.Net.IPAddress address in addressList)
            {
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    IPAddress = address.ToString();
            }
        }

        public static string GetLookupQueryColumn(string strTableName)
        {
            string str = string.Empty;
            string tablePrimaryColumn = GMCDbUtil.GetTablePrimaryColumn(strTableName);
            str = str + string.Format("{0},", tablePrimaryColumn);
            string name = tablePrimaryColumn.Substring(0, tablePrimaryColumn.Length - 2) + "No";
            string str4 = tablePrimaryColumn.Substring(0, tablePrimaryColumn.Length - 2) + "Name";
            Type businessObjectType = BusinessObjectFactory.GetBusinessObjectType(strTableName + "Info");
            if (businessObjectType != null)
            {
                if (businessObjectType.GetProperty(name) != null)
                {
                    str = str + string.Format("{0},", name);
                }
                if (businessObjectType.GetProperty(str4) != null)
                {
                    str = str + string.Format("{0},", str4);
                }
            }
            if (LookupExColumsList.ContainsKey(strTableName))
            {
                str = str + string.Format("{0},", LookupExColumsList[strTableName]);
            }
            if (str.Substring(str.Length - 1).Equals(","))
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }

        public static string GetMainObjectNo(string strModuleName, BusinessObject objMainObject)
        {
            string str = string.Empty;
            GENumberingsController controller = new GENumberingsController();
            GENumberingsInfo objectByName = (GENumberingsInfo)new GENumberingsController().GetObjectByName(strModuleName);
            BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(GMCUtil.GetTableNameFromBusinessObject(objMainObject) + "Controller");
            if (objectByName != null)
            {
                return str;
            }
            if (objectByName.GENumberingByDate)
            {
                string str2 = WorkingDate.ToString(objectByName.GENumberingDateFormat);
                string strPrefix = string.Format("{0}{1}{2}", objectByName.GENumberingPrefix, str2, objectByName.GENumberingSeparate.Trim());
                int iMaxNumbering = businessController.GetMaxNumberingByPrefix(strPrefix, objectByName.GENumberingLength) + 1;
                return "";// ERPModuleEntities.GenerateMainObjectNo(strPrefix, iMaxNumbering, objectByName.GENumberingLength);
            }
            string str4 = objectByName.GENumberingStart.ToString();
            if (str4.Length < objectByName.GENumberingLength)
            {
                string str5 = objectByName.GENumberingStart.ToString();
                for (int i = 0; i < (objectByName.GENumberingLength - str4.Length); i++)
                {
                    str5 = str5.Insert(0, "0");
                }
                return string.Format("{0}{1}", objectByName.GENumberingPrefix, str5);
            }
            return string.Format("{0}{1}", objectByName.GENumberingPrefix, objectByName.GENumberingStart);
        }

        public static string GetModuleDescription(STModulesInfo objSTModulesInfo)
        {
            string controlText = GetControlText(objSTModulesInfo.STModuleDesc);
            if (string.IsNullOrEmpty(controlText))
            {
                controlText = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(objSTModulesInfo.STModuleName, CurrentLang);
            }
            return controlText;
        }

        public static string GetModuleDescription(string strModuleName)
        {
            string controlText = string.Empty;
            STModulesInfo objectByName = (STModulesInfo)new STModulesController().GetObjectByName(strModuleName);
            if (objectByName != null)
            {
                controlText = GetControlText(objectByName.STModuleDesc);
            }
            if (string.IsNullOrEmpty(controlText))
            {
                controlText = new STModuleDescriptionsController().GetDescriptionByModuleNameAndLanguageName(strModuleName, CurrentLang);
            }
            return controlText;
        }

        private static void GetServerAndDatabaseInformation(string strCompanyName)
        {
            RegistryWorker worker = new RegistryWorker();
            if (!string.IsNullOrEmpty(strCompanyName))
            {
                worker.SubKey = @"SOFTWARE\GMC\ConnectionString\" + strCompanyName;
            }
            else
            {
                worker.SubKey = @"SOFTWARE\GMC\ConnectionString";
            }
            string str = worker.Read("Database");
            CurrentServer = worker.Read("Server");
            CurrentDatabase = str;
            try
            {
                strBranch = worker.Read("Branch");
            }
            catch
            {
                strBranch = "";
            }
            try
            {
                strOnlyModule = worker.Read("OnlyModule");
            }
            catch
            {
                strOnlyModule = "";
            }
        }

        private static string GetServerName()
        {
            string str = string.Empty;
            if (CurrentCompanyInfo.CSCompanyFileServerPath.IndexOf(@"\\") >= 0)
            {
                string str2 = CurrentCompanyInfo.CSCompanyFileServerPath.Substring(2);
                int index = str2.IndexOf(@"\");
                if (index >= 0)
                {
                    str = str2.Substring(0, index);
                }
            }
            return str;
        }

        //public static BaseModuleERP GetSubFormModuleWithDataMainScreenToolBar(string strModuleName, int iObjectID = 0, bool isShowDialog = false)
        //{
        //    try
        //    {
        //        GMCWaitingDialog.Caption = "Please waiting...";
        //        GMCWaitingDialog.Title = "Loading module....";
        //        GMCWaitingDialog.Show(null);
        //        string currentModuleName = CurrentModuleName;
        //        BaseModuleERP currentModule = CurrentModule;
        //        BaseModuleERP module = BaseModuleFactory.GetModule(strModuleName);
        //        if (module == null)
        //        {
        //            GMCWaitingDialog.Close();
        //            return null;
        //        }
        //        module.ParentScreen.SetScreenStyle();
        //        Application.DoEvents();
        //        GMCWaitingDialog.Close();
        //        GMCScreen firstDataMainScreenAfterSearch = module.GetFirstDataMainScreenAfterSearch();
        //        if (((firstDataMainScreenAfterSearch != null) && firstDataMainScreenAfterSearch.IsDataMainScreen()) && (firstDataMainScreenAfterSearch.SortOrder >= 0))
        //        {
        //            firstDataMainScreenAfterSearch.ControlBox = true;
        //            firstDataMainScreenAfterSearch.MaximizeBox = false;
        //            firstDataMainScreenAfterSearch.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        //            firstDataMainScreenAfterSearch.Size = new Size(0x343, 600);
        //            CurrentModule.ParentScreen.Activate();
        //            module.ActiveScreen = firstDataMainScreenAfterSearch;
        //            if (iObjectID != 0)
        //            {
        //                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(GMCUtil.GetTableNameFromBusinessObject(module.CurrentModuleEntity.MainObject) + "Controller");
        //                module.Invalidate(iObjectID);
        //            }
        //        }
        //        module.ShowSubForm(firstDataMainScreenAfterSearch, isShowDialog, currentModule, currentModuleName);
        //        return module;
        //    }
        //    catch (Exception)
        //    {
        //        GMCWaitingDialog.Close();
        //        GMCLogging.CloseDiaglog();
        //        XtraMessageBox.Show("This function has not supported!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        Application.DoEvents();
        //    }
        //    Application.DoEvents();
        //    return null;
        //}

        public static string GetUOMText(int iICUOMID)
        {
            ICUOMsController controller = new ICUOMsController();
            return controller.GetObjectNoByID(iICUOMID);
        }

        public static void InitControlImageList()
        {
            ControlImageList.ImageSize = new Size(0x10, 0x10);
            ControlImageList.ColorDepth = ColorDepth.Depth32Bit;
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + @"\img\Control");
            if (info.Exists)
            {
                foreach (FileInfo info2 in info.GetFiles())
                {
                    if ((((info2.Extension.ToLower() == ".ico") || (info2.Extension.ToLower() == ".png")) || (info2.Extension.ToLower() == ".jpg")) || (info2.Extension.ToLower() == ".bmp"))
                    {
                        int index = info2.Name.IndexOf(".");
                        if (index > 0)
                        {
                            string key = info2.Name.Substring(0, index);
                            try
                            {
                                Image image = Image.FromFile(info2.FullName);
                                ControlImageList.Images.Add(key, image);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
            }
        }

        public static void InitDictionary()
        {
            GEDictionarysController controller = new GEDictionarysController();
            DataSet allObjects = controller.GetAllObjects();
            _dictionary = new Dictionary<string, string>();
            _dictionary.Clear();
            if (allObjects != null)
            {
                foreach (DataRow row in allObjects.Tables[0].Rows)
                {
                    GEDictionarysInfo objectFromDataRow = (GEDictionarysInfo)controller.GetObjectFromDataRow(row);
                    if (!_dictionary.ContainsKey(objectFromDataRow.GEDictionaryText))
                    {
                        _dictionary.Add(objectFromDataRow.GEDictionaryText, objectFromDataRow.GEDictionaryText1);
                    }
                }
            }
        }

        public static void InitFieldFormatGroups()
        {
            FieldFormatGroups = new SortedList();
            STFieldFormatGroupsController controller = new STFieldFormatGroupsController();
            DataSet allObjects = controller.GetAllObjects();
            if (allObjects.Tables.Count > 0)
            {
                foreach (DataRow row in allObjects.Tables[0].Rows)
                {
                    STFieldFormatGroupsInfo objectFromDataRow = (STFieldFormatGroupsInfo)controller.GetObjectFromDataRow(row);
                    if (objectFromDataRow != null)
                    {
                        FieldFormatGroups.Add(objectFromDataRow.STFieldFormatGroupName, objectFromDataRow);
                    }
                }
            }
        }

        public static void InitFieldFormats()
        {
            FieldFormatList = new SortedList();
            STFieldFormatsController controller = new STFieldFormatsController();
            string strQuery = "SELECT [STFieldFormats].*,[STFieldFormatGroups].[STFieldFormatGroupName] FROM [STFieldFormats] INNER JOIN [STFieldFormatGroups] ON [STFieldFormats].[STFieldFormatGroupID] = [STFieldFormatGroups].[STFieldFormatGroupID]";
            DataSet dataSet = controller.GetDataSet(strQuery);
            if (dataSet.Tables.Count > 0)
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string[] textArray1 = new string[] { row["STFieldFormatModuleName"].ToString(), "_", row["STFieldFormatTableName"].ToString(), "_", row["STFieldFormatColumnName"].ToString() };
                    string key = string.Concat(textArray1);
                    if (FieldFormatList.ContainsKey(key))
                    {
                        FieldFormatList[key] = row;
                    }
                    else
                    {
                        FieldFormatList.Add(key, row);
                    }
                }
            }
        }

        public static void InitLookupExColumns()
        {
            LookupExColumsList.Clear();
            STLookupExColumnsController controller = new STLookupExColumnsController();
            try
            {
                DataSet allObjects = controller.GetAllObjects();
                if (allObjects != null)
                {
                    foreach (DataRow row in allObjects.Tables[0].Rows)
                    {
                        string key = row["STLookupExColumnTable"].ToString();
                        string str2 = row["STLookupExColumnColumn"].ToString();
                        if (LookupExColumsList.ContainsKey(key))
                        {
                            LookupExColumsList[key] = str2;
                        }
                        else
                        {
                            LookupExColumsList.Add(key, str2);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static void InitLookupTables()
        {
            _lookupTables = new Dictionary<string, DataTable>();
            _lookupTableUpdatedDate = new SortedList();
            _lookupTables.Clear();
            _lookupTableUpdatedDate.Clear();
        }

        public static void InitMainFormTitle()
        {
            RegistryWorker worker = new RegistryWorker
            {
                SubKey = @"SOFTWARE\GMC"
            };
            string cSCompanyDesc = CurrentCompanyInfo.CSCompanyDesc;
            //MainScreen.Text = cSCompanyDesc;
            //MainScreen.Text = MainScreen.Text + " - " + DateTime.Now.ToShortDateString();
            //MainScreen.Text = MainScreen.Text + " - " + CurrentUser;
            //MainScreen.Text = MainScreen.Text + "/" + new ADUserGroupsController().GetObjectNameByID(new ADUsersController().GetUserGroupOfUser(CurrentUser));
        }

        private static void InitProductSuggestEdit(string strColumnName)
        {
            //RepositoryItemMRUEdit edit = new RepositoryItemMRUEdit();
            //edit.set_CaseSensitiveSearch(false);
            //edit.add_AddingMRUItem(new AddingMRUItemEventHandler(null, mruEdit_AddingMRUItem));
            //_suggestEdit.Add(strColumnName, edit);
            //DataSet allObjects = new ICProductsController().GetAllObjects();
            //foreach (DataRow row in allObjects.Tables[0].Rows)
            //{
            //    _suggestEdit[strColumnName].get_Items().Add(row[strColumnName].ToString());
            //}
        }

        private static void InitProductSuggestEdit(DataSet ds, string strColumnName)
        {
            //RepositoryItemMRUEdit edit = new RepositoryItemMRUEdit();
            //edit.set_CaseSensitiveSearch(false);
            //edit.add_AddingMRUItem(new AddingMRUItemEventHandler(null, mruEdit_AddingMRUItem));
            //_suggestEdit.Add(strColumnName, edit);
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    _suggestEdit[strColumnName].get_Items().Add(row[strColumnName].ToString());
            //}
        }

        public static void InitSectionImageList()
        {
            SectionImageList.ImageSize = new Size(0x20, 0x20);
            SectionImageList.ColorDepth = ColorDepth.Depth32Bit;
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + @"\img\Section");
            foreach (FileInfo info2 in info.GetFiles())
            {
                if ((((info2.Extension.ToLower() == ".ico") || (info2.Extension.ToLower() == ".png")) || ((info2.Extension.ToLower() == ".jpg") || (info2.Extension.ToLower() == ".bmp"))) || (info2.Extension.ToLower() == ".gif"))
                {
                    int index = info2.Name.IndexOf(".");
                    if (index > 0)
                    {
                        string key = info2.Name.Substring(0, index);
                        try
                        {
                            Image image = Image.FromFile(info2.FullName);
                            SectionImageList.Images.Add(key, image);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        public static void InitSectionManagerByCurrentUser(string strUserName)
        {
            int userGroupOfUser = new ADUsersController().GetUserGroupOfUser(strUserName);
            ADUserGroupSectionsController controller2 = new ADUserGroupSectionsController();
            DataSet userGroupSectionByUserGroupID = controller2.GetUserGroupSectionByUserGroupID(userGroupOfUser);
            if (userGroupSectionByUserGroupID.Tables.Count > 0)
            {
                foreach (DataRow row in userGroupSectionByUserGroupID.Tables[0].Rows)
                {
                    ADUserGroupSectionsInfo objectFromDataRow = (ADUserGroupSectionsInfo)controller2.GetObjectFromDataRow(row);
                    //NavBarGroup group = new NavBarGroup();
                    //group.get_Appearance().set_Font(new Font("Tahoma", 10.25f, FontStyle.Bold, GraphicsUnit.Point, 0));
                    //group.get_Appearance().get_Options().set_UseFont(true);
                    //group.set_Caption(objectFromDataRow.ADUserGroupSectionName);
                    //group.set_Expanded(true);
                    //group.set_Name("fld_navBarGroup" + objectFromDataRow.ADUserGroupSectionID);
                    //AddModuleToGroupSection(group, objectFromDataRow.ADUserGroupSectionID);
                    //MainScreen.SectionManager.get_Groups().Add(group);
                    //MainScreen.SectionManager.set_ActiveGroup(MainScreen.SectionManager.get_Groups().get_Item(0));
                }
            }
            userGroupSectionByUserGroupID.Dispose();
        }

        public static void InitToolbarImageList()
        {
            ToolbarImageList.ImageSize = new Size(0x10, 0x10);
            ToolbarImageList.ColorDepth = ColorDepth.Depth32Bit;
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + @"\img\Toolbar");
            foreach (FileInfo info2 in info.GetFiles())
            {
                if ((((info2.Extension.ToLower() == ".ico") || (info2.Extension.ToLower() == ".png")) || (info2.Extension.ToLower() == ".jpg")) || (info2.Extension.ToLower() == ".bmp"))
                {
                    int index = info2.Name.IndexOf(".");
                    if (index > 0)
                    {
                        string key = info2.Name.Substring(0, index);
                        try
                        {
                            Image image = Image.FromFile(info2.FullName);
                            ToolbarImageList.Images.Add(key, image);
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        public static bool InvalidateLookupTable(string strLookupTable)
        {
            TryToInitLookupTable(strLookupTable);
            if (LookupTables.ContainsKey(strLookupTable) && (LookupTablesUpdatedDate[strLookupTable] != null))
            {
                DataTable table = LookupTables[strLookupTable];
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (!(GMCDbUtil.ColumnIsExist(strLookupTable, "AAUpdatedDate") && GMCDbUtil.ColumnIsExist(strLookupTable, "AAStatus")))
                {
                    try
                    {
                        DateTime time5 = (DateTime)LookupTablesUpdatedDate[strLookupTable];
                        TimeSpan span = (TimeSpan)(DateTime.Now - time5);
                        if (span.TotalMinutes < 2.0)
                        {
                            return false;
                        }
                        string lookupQueryColumn = GetLookupQueryColumn(strLookupTable);
                        DataSet allObjectForDataLookups = businessController.GetAllObjectForDataLookups(lookupQueryColumn);
                        LookupTables[strLookupTable] = allObjectForDataLookups.Tables[0];
                        return true;
                    }
                    catch
                    {
                    }
                }
                else
                {
                    DateTime lastCreatedDateOfTable = GMCDbUtil.GetLastCreatedDateOfTable(strLookupTable);
                    DateTime lastUpdatedDateOfTable = GMCDbUtil.GetLastUpdatedDateOfTable(strLookupTable);
                    if (lastCreatedDateOfTable > lastUpdatedDateOfTable)
                    {
                        lastUpdatedDateOfTable = lastCreatedDateOfTable;
                    }
                    DateTime time4 = (DateTime)LookupTablesUpdatedDate[strLookupTable];
                    if (lastUpdatedDateOfTable.CompareTo(time4) > 0)
                    {
                        DataSet objectsByAAUpdatedDate = businessController.GetObjectsByAAUpdatedDate(strLookupTable, time4);
                        if (objectsByAAUpdatedDate.Tables.Count > 0)
                        {
                            string tablePrimaryColumn = GMCDbUtil.GetTablePrimaryColumn(strLookupTable);
                            foreach (DataRow row in objectsByAAUpdatedDate.Tables[0].Rows)
                            {
                                BusinessObject objectFromDataRow = (BusinessObject)businessController.GetObjectFromDataRow(row);
                                int num2 = Convert.ToInt32(GMCDbUtil.GetPropertyValue(objectFromDataRow, tablePrimaryColumn));
                                string filterExpression = string.Format("{0}={1}", tablePrimaryColumn, num2);
                                DataRow[] rowArray = table.Select(filterExpression);
                                if (rowArray.Length == 0)
                                {
                                    table.ImportRow(row);
                                }
                                else
                                {
                                    int num3 = table.Rows.IndexOf(rowArray[0]);
                                    if (GMCDbUtil.GetPropertyValue(objectFromDataRow, "AAStatus").ToString().Equals(BusinessObject.DeletedAAStatus))
                                    {
                                        table.Rows.RemoveAt(num3);
                                    }
                                    else
                                    {
                                        table.Rows.RemoveAt(num3);
                                        table.ImportRow(row);
                                    }
                                }
                            }
                        }
                        int index = -1;
                        do
                        {
                            index = -1;
                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                BusinessObject objectFromDataRow = (BusinessObject)businessController.GetObjectFromDataRow(table.Rows[i]);
                                if (GMCDbUtil.GetPropertyValue(objectFromDataRow, "AAStatus").ToString().Equals(BusinessObject.DeletedAAStatus))
                                {
                                    index = i;
                                    break;
                                }
                            }
                            if (index >= 0)
                            {
                                table.Rows.RemoveAt(index);
                            }
                        }
                        while (index >= 0);
                        LookupTablesUpdatedDate[strLookupTable] = lastUpdatedDateOfTable;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool InvalidateLookupTable(string strLookupTable, string[] columns)
        {
            TryToInitLookupTable(strLookupTable, columns);
            if (LookupTables.ContainsKey(strLookupTable) && (LookupTablesUpdatedDate[strLookupTable] != null))
            {
                DataTable table = LookupTables[strLookupTable];
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (!(GMCDbUtil.ColumnIsExist(strLookupTable, "AAUpdatedDate") && GMCDbUtil.ColumnIsExist(strLookupTable, "AAStatus")))
                {
                    try
                    {
                        DataSet allObjects = businessController.GetAllObjects();
                        LookupTables[strLookupTable] = allObjects.Tables[0];
                        return true;
                    }
                    catch
                    {
                    }
                }
                else
                {
                    DateTime lastCreatedDateOfTable = GMCDbUtil.GetLastCreatedDateOfTable(strLookupTable);
                    DateTime lastUpdatedDateOfTable = GMCDbUtil.GetLastUpdatedDateOfTable(strLookupTable);
                    if (lastCreatedDateOfTable > lastUpdatedDateOfTable)
                    {
                        lastUpdatedDateOfTable = lastCreatedDateOfTable;
                    }
                    DateTime time4 = (DateTime)LookupTablesUpdatedDate[strLookupTable];
                    if (lastUpdatedDateOfTable.CompareTo(time4) > 0)
                    {
                        DataSet objectsByAAUpdatedDate = businessController.GetObjectsByAAUpdatedDate(strLookupTable, time4);
                        if (objectsByAAUpdatedDate.Tables.Count > 0)
                        {
                            string tablePrimaryColumn = GMCDbUtil.GetTablePrimaryColumn(strLookupTable);
                            foreach (DataRow row in objectsByAAUpdatedDate.Tables[0].Rows)
                            {
                                BusinessObject objectFromDataRow = (BusinessObject)businessController.GetObjectFromDataRow(row);
                                int num2 = Convert.ToInt32(GMCDbUtil.GetPropertyValue(objectFromDataRow, tablePrimaryColumn));
                                string filterExpression = string.Format("{0}={1}", tablePrimaryColumn, num2);
                                DataRow[] rowArray = table.Select(filterExpression);
                                if (rowArray.Length == 0)
                                {
                                    table.ImportRow(row);
                                }
                                else
                                {
                                    int num3 = table.Rows.IndexOf(rowArray[0]);
                                    if (GMCDbUtil.GetPropertyValue(objectFromDataRow, "AAStatus").ToString().Equals(BusinessObject.DeletedAAStatus))
                                    {
                                        table.Rows.RemoveAt(num3);
                                    }
                                    else
                                    {
                                        table.Rows.RemoveAt(num3);
                                        table.ImportRow(row);
                                    }
                                }
                            }
                        }
                        int index = -1;
                        do
                        {
                            index = -1;
                            for (int i = 0; i < table.Rows.Count; i++)
                            {
                                BusinessObject objectFromDataRow = (BusinessObject)businessController.GetObjectFromDataRow(table.Rows[i]);
                                if (GMCDbUtil.GetPropertyValue(objectFromDataRow, "AAStatus").ToString().Equals(BusinessObject.DeletedAAStatus))
                                {
                                    index = i;
                                    break;
                                }
                            }
                            if (index >= 0)
                            {
                                table.Rows.RemoveAt(index);
                            }
                        }
                        while (index >= 0);
                        LookupTablesUpdatedDate[strLookupTable] = lastUpdatedDateOfTable;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsExistOpenModulesInAction()
        {
            foreach (string str in OpenModules.Keys)
            {
                //BaseModuleERP eerp = (BaseModuleERP)OpenModules[str];
                //if (!eerp.Toolbar.IsNullOrNoneAction())
                //{
                //    return true;
                //}
            }
            return false;
        }

        public static bool IsOpenedModule(string strModuleName)
        {
            return OpenModules.ContainsKey(strModuleName);
        }

        public static bool IsRemoteUser()
        {
            RegistryWorker worker = new RegistryWorker
            {
                SubKey = @"SOFTWARE\GMC"
            };
            return (worker.Read("ClientStatus") == "Remote");
        }

        public static bool IsTranslate(string strDefaultText)
        {
            bool flag = false;
            if (_dictionary.ContainsKey(strDefaultText))
            {
                string str = _dictionary[strDefaultText];
                if (!string.IsNullOrEmpty(str))
                {
                    flag = true;
                }
                return flag;
            }
            if (_dictionary.ContainsValue(strDefaultText))
            {
                flag = true;
            }
            return flag;
        }

        private static VersionInfo LoadCurentVersionFromXML(string strXMLFile)
        {
            VersionInfo info = null;
            FileStream stream = null;
            try
            {
                stream = new FileStream(strXMLFile, FileMode.Open, FileAccess.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(VersionInfo));
                info = (VersionInfo)serializer.Deserialize(stream);
            }
            catch (Exception)
            {
            }
            if (stream != null)
            {
                stream.Close();
            }
            return info;
        }

        public static void LogOff(bool isShowMessage = true)
        {
            //if ((OpenModules.Count > 0) && IsExistOpenModulesInAction())
            //{
            //    new guiLogOffWarning().ShowDialog();
            //}
            //else if (!isShowMessage || (MessageQuestion.ShowMessageLogOffQuestion(CurrentUser) == DialogResult.Yes))
            //{
            //    IsLoggingOff = true;
            //    MainScreen.SectionManager.get_Groups().Clear();
            //    MainScreen.SectionManager.Enabled = true;
            //    AppMenu = null;
            //    AppMenuModule = null;
            //    LookupTables.Clear();
            //    LookupExColumsList.Clear();
            //    CloseAllOpenModules();
            //    OpenModules.Clear();
            //    MainScreen.OpenModulesToolStrip.Items.Clear();
            //    MainScreen.OpenModulesToolStrip.Enabled = true;
            //    if (CurrentUser != null)
            //    {
            //        int objectIDByName = new ADUsersController().GetObjectIDByName(CurrentUser);
            //        new GEUserAuditsController().DeleteGEUserAuditsByADUserID(objectIDByName);
            //    }
            //    MainScreen.Activate();
            //    LogOn();
            //    IsLoggingOff = false;
            //}
        }

        public static void LogOffBySwitchUser()
        {
            IsLoggingOff = true;
            //MainScreen.Activate();
            //LogOnBySwitchUser();
            IsLoggingOff = false;
        }

        //public static void LogOn()
        //{
        //    GetLocalMachineInfo();
        //    if (CheckLoginCard())
        //    {
        //        guiCardLogin login = new guiCardLogin();
        //        if (login.ShowDialog() == DialogResult.OK)
        //        {
        //            SkinManager.EnableFormSkins();
        //            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        //            ADUsersController controller = new ADUsersController();
        //            ADUsersInfo objectByName = (ADUsersInfo)controller.GetObjectByName(CurrentUser);
        //            if (objectByName != null)
        //            {
        //                SetApplicationStyle(objectByName.ADUserStyle, objectByName.ADUserStyleSkin);
        //            }
        //            _currentLanguage = "vn";
        //            if ((objectByName != null) && !string.IsNullOrEmpty(objectByName.ADUserCurLang))
        //            {
        //                _currentLanguage = objectByName.ADUserCurLang;
        //            }
        //            InitToolbarImageList();
        //            InitSectionImageList();
        //            InitControlImageList();
        //            try
        //            {
        //                BackGroundImage = Image.FromFile(Application.StartupPath + @"\img\background.png");
        //            }
        //            catch
        //            {
        //            }
        //            InitDictionary();
        //            ADConfigValueUtility.InitGlobalConfigValueTables();
        //            InitLookupTables();
        //            InitLookupExColumns();
        //            InitFieldFormatGroups();
        //            InitFieldFormats();
        //            _currentUserGroupID = new ADUsersController().GetUserGroupOfUser(CurrentUser);
        //            _currentUserGroupsInfo = (ADUserGroupsInfo)new ADUserGroupsController().GetObjectByID(_currentUserGroupID);
        //            GetServerAndDatabaseInformation(CompanyName);
        //            CSCompanysController controller2 = new CSCompanysController();
        //            if (_currentCompanyInfo == null)
        //            {
        //                _currentCompanyInfo = (CSCompanysInfo)controller2.GetFirstObject();
        //            }
        //            GECurrencysInfo objectByID = (GECurrencysInfo)new GECurrencysController().GetObjectByID(_currentCompanyInfo.FK_GECurrencyID);
        //            if (objectByID != null)
        //            {
        //                try
        //                {
        //                    _systemCurrencysInfo = objectByID;
        //                    _systemCurrencyDecimal = objectByID.GECurrencyDecimalRound;
        //                    _systemUnitPriceCurrencyDecimal = objectByID.GECurrencyPriceDecimalRound;
        //                }
        //                catch (Exception)
        //                {
        //                    _systemCurrencyDecimal = 0;
        //                    _systemUnitPriceCurrencyDecimal = 0;
        //                }
        //            }
        //            BRBranchsInfo objectByNo = (BRBranchsInfo)new BRBranchsController().GetObjectByNo(strBranch);
        //            if (objectByNo != null)
        //            {
        //                GMCUtil.Branch = (BusinessObject)objectByNo;
        //            }
        //            else
        //            {
        //                GMCUtil.Branch = (BusinessObject)new BRBranchsInfo();
        //            }
        //            _sesssionTableName = string.Empty;
        //            _sessionObjectID = 0;
        //            SetApplicationCulture();
        //            ReportHelper.SetReportConnection(CompanyName);
        //            GMCDataAuthenticationUtil.RefreshPermissionOfCurrentUser();
        //            if (string.IsNullOrEmpty(strOnlyModule))
        //            {
        //                ShowModuleOnHomePage();
        //            }
        //            else
        //            {
        //                ShowModule(strOnlyModule, false);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        guiLogin login2 = new guiLogin();
        //        if (login2.ShowDialog() == DialogResult.OK)
        //        {
        //            SkinManager.EnableFormSkins();
        //            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        //            ADUsersController controller3 = new ADUsersController();
        //            ADUsersInfo objectByName = (ADUsersInfo)controller3.GetObjectByName(CurrentUser);
        //            if (objectByName != null)
        //            {
        //                SetApplicationStyle(objectByName.ADUserStyle, objectByName.ADUserStyleSkin);
        //            }
        //            _currentLanguage = "vn";
        //            if ((objectByName != null) && !string.IsNullOrEmpty(objectByName.ADUserCurLang))
        //            {
        //                _currentLanguage = objectByName.ADUserCurLang;
        //            }
        //            InitToolbarImageList();
        //            InitSectionImageList();
        //            InitControlImageList();
        //            try
        //            {
        //                BackGroundImage = Image.FromFile(Application.StartupPath + @"\img\background.png");
        //            }
        //            catch
        //            {
        //            }
        //            InitDictionary();
        //            ADConfigValueUtility.InitGlobalConfigValueTables();
        //            InitLookupTables();
        //            InitLookupExColumns();
        //            InitFieldFormatGroups();
        //            InitFieldFormats();
        //            _currentUserGroupID = new ADUsersController().GetUserGroupOfUser(CurrentUser);
        //            _currentUserGroupsInfo = (ADUserGroupsInfo)new ADUserGroupsController().GetObjectByID(_currentUserGroupID);
        //            GetServerAndDatabaseInformation(CompanyName);
        //            CSCompanysController controller4 = new CSCompanysController();
        //            if (_currentCompanyInfo == null)
        //            {
        //                _currentCompanyInfo = (CSCompanysInfo)controller4.GetFirstObject();
        //            }
        //            GECurrencysInfo objectByID = (GECurrencysInfo)new GECurrencysController().GetObjectByID(_currentCompanyInfo.FK_GECurrencyID);
        //            if (objectByID != null)
        //            {
        //                try
        //                {
        //                    _systemCurrencysInfo = objectByID;
        //                    _systemCurrencyDecimal = objectByID.GECurrencyDecimalRound;
        //                    _systemUnitPriceCurrencyDecimal = objectByID.GECurrencyPriceDecimalRound;
        //                }
        //                catch (Exception)
        //                {
        //                    _systemCurrencyDecimal = 0;
        //                    _systemUnitPriceCurrencyDecimal = 0;
        //                }
        //            }
        //            BRBranchsInfo objectByNo = (BRBranchsInfo)new BRBranchsController().GetObjectByNo(strBranch);
        //            if (objectByNo != null)
        //            {
        //                GMCUtil.Branch = (BusinessObject)objectByNo;
        //            }
        //            else
        //            {
        //                GMCUtil.Branch = (BusinessObject)new BRBranchsInfo();
        //            }
        //            _sesssionTableName = string.Empty;
        //            _sessionObjectID = 0;
        //            SetApplicationCulture();
        //            ReportHelper.SetReportConnection(CompanyName);
        //            GMCDataAuthenticationUtil.RefreshPermissionOfCurrentUser();
        //            if (string.IsNullOrEmpty(strOnlyModule))
        //            {
        //                ShowModuleOnHomePage();
        //            }
        //            else
        //            {
        //                ShowModule(strOnlyModule, false);
        //            }
        //        }
        //    }
        //}

        //public static void LogOnBySwitchUser()
        //{
        //    if (CheckLoginCard())
        //    {
        //        guiCardLogin login = new guiCardLogin();
        //        if (login.ShowDialog() == DialogResult.OK)
        //        {
        //            //SkinManager.EnableFormSkins();
        //            //LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        //            ADUsersController controller = new ADUsersController();
        //            ADUsersInfo objectByName = (ADUsersInfo)controller.GetObjectByName(CurrentUser);
        //            if (objectByName != null)
        //            {
        //                SetApplicationStyle(objectByName.ADUserStyle, objectByName.ADUserStyleSkin);
        //            }
        //            _currentLanguage = "vn";
        //            if ((objectByName != null) && !string.IsNullOrEmpty(objectByName.ADUserCurLang))
        //            {
        //                _currentLanguage = objectByName.ADUserCurLang;
        //            }
        //            _currentUserGroupID = new ADUsersController().GetUserGroupOfUser(CurrentUser);
        //            _currentUserGroupsInfo = (ADUserGroupsInfo)new ADUserGroupsController().GetObjectByID(_currentUserGroupID);
        //            GetServerAndDatabaseInformation(CompanyName);
        //            CSCompanysController controller2 = new CSCompanysController();
        //            if (_currentCompanyInfo == null)
        //            {
        //                _currentCompanyInfo = (CSCompanysInfo)controller2.GetFirstObject();
        //            }
        //            GECurrencysInfo objectByID = (GECurrencysInfo)new GECurrencysController().GetObjectByID(_currentCompanyInfo.FK_GECurrencyID);
        //            if (objectByID != null)
        //            {
        //                try
        //                {
        //                    _systemCurrencysInfo = objectByID;
        //                    _systemCurrencyDecimal = objectByID.GECurrencyDecimalRound;
        //                    _systemUnitPriceCurrencyDecimal = objectByID.GECurrencyPriceDecimalRound;
        //                }
        //                catch (Exception)
        //                {
        //                    _systemCurrencyDecimal = 0;
        //                    _systemUnitPriceCurrencyDecimal = 0;
        //                }
        //            }
        //            _sesssionTableName = string.Empty;
        //            _sessionObjectID = 0;
        //        }
        //    }
        //    else
        //    {
        //        guiLogin login2 = new guiLogin();
        //        if (login2.ShowDialog() == DialogResult.OK)
        //        {
        //            SkinManager.EnableFormSkins();
        //            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        //            ADUsersController controller3 = new ADUsersController();
        //            ADUsersInfo objectByName = (ADUsersInfo)controller3.GetObjectByName(CurrentUser);
        //            if (objectByName != null)
        //            {
        //                SetApplicationStyle(objectByName.ADUserStyle, objectByName.ADUserStyleSkin);
        //            }
        //            _currentLanguage = "vn";
        //            if ((objectByName != null) && !string.IsNullOrEmpty(objectByName.ADUserCurLang))
        //            {
        //                _currentLanguage = objectByName.ADUserCurLang;
        //            }
        //            _currentUserGroupID = new ADUsersController().GetUserGroupOfUser(CurrentUser);
        //            _currentUserGroupsInfo = (ADUserGroupsInfo)new ADUserGroupsController().GetObjectByID(_currentUserGroupID);
        //            GetServerAndDatabaseInformation(CompanyName);
        //            CSCompanysController controller4 = new CSCompanysController();
        //            if (_currentCompanyInfo == null)
        //            {
        //                _currentCompanyInfo = (CSCompanysInfo)controller4.GetFirstObject();
        //            }
        //            GECurrencysInfo objectByID = (GECurrencysInfo)new GECurrencysController().GetObjectByID(_currentCompanyInfo.FK_GECurrencyID);
        //            if (objectByID != null)
        //            {
        //                try
        //                {
        //                    _systemCurrencysInfo = objectByID;
        //                    _systemCurrencyDecimal = objectByID.GECurrencyDecimalRound;
        //                    _systemUnitPriceCurrencyDecimal = objectByID.GECurrencyPriceDecimalRound;
        //                }
        //                catch (Exception)
        //                {
        //                    _systemCurrencyDecimal = 0;
        //                    _systemUnitPriceCurrencyDecimal = 0;
        //                }
        //            }
        //            _sesssionTableName = string.Empty;
        //            _sessionObjectID = 0;
        //        }
        //    }
        //}

        //private static void ModuleItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        //{
        //    string str = e.get_Link().get_Item().get_Tag().ToString();
        //    if (!string.IsNullOrEmpty(str))
        //    {
        //        ShowModule(str);
        //    }
        //}

        //private static void mruEdit_AddingMRUItem(object sender, AddingMRUItemEventArgs e)
        //{
        //    e.Cancel = false;
        //}

        //private static void MRUEdit_AddingMRUItem(object sender, AddingMRUItemEventArgs e)
        //{
        //    TryInitRepositoryItemMRUEdit(((MRUEdit)sender).get_ToolTipTitle()).get_Items().Add(e.get_Item());
        //}

        private static void OpenModulesToolStrip_Click(object sender, EventArgs e)
        {
            ToolStripButton tsbtnModule = (ToolStripButton)sender;
            CheckOpenModuleToolStripButton(tsbtnModule);
            //ShowModule(tsbtnModule.Name);
        }

        private static ToolStripButton PopulateOpenModulesToolStripButton(string strModuleName)
        {
            return new ToolStripButton(GetControlText(GetModuleDescription(strModuleName)), SectionImageList.Images[strModuleName], new EventHandler(GMCWebApp.OpenModulesToolStrip_Click), strModuleName)
            {
                TextImageRelation = TextImageRelation.ImageBeforeText,
                CheckOnClick = true
            };
        }

        public static void RefreshDataSourceForAllControls(string strTableName)
        {
            try
            {
                //GMCLookupEdit.RefreshDataSourceForAllControls(strTableName);
            }
            catch (Exception)
            {
            }
            try
            {
                //GMCRepositoryLookupEdit.RefreshDataSourceForAllControls(strTableName);
            }
            catch (Exception)
            {
            }
        }

        //public static void RemoveOpenedModule(BaseModuleERP module)
        //{
        //    if (IsOpenedModule(module.Name))
        //    {
        //        ((BaseModuleERP)OpenModules[module.Name]).Close();
        //        OpenModules.Remove(module.Name);
        //    }
        //}

        public static void RemoveOpenedModule(string strModuleName)
        {
            if (IsOpenedModule(strModuleName))
            {
                OpenModules.Remove(strModuleName);
            }
        }

        public static void RollbackLocalConnection()
        {
            SqlDatabaseHelper.RollbackToLocalConnection();
        }

        public static double Round(double dbNumber, GECurrencysInfo objCurr, bool bUnitPrice = false)
        {
            int digits = 0;
            if (objCurr != null)
            {
                if (bUnitPrice)
                {
                    digits = objCurr.GECurrencyPriceDecimalRound;
                }
                else
                {
                    digits = objCurr.GECurrencyDecimalRound;
                }
            }
            return Math.Round(dbNumber, digits, MidpointRounding.AwayFromZero);
        }

        public static double Round(double dbNumber, int iCurrencyID = 0, bool bUnitPrice = false)
        {
            if ((iCurrencyID == 0) || (iCurrencyID == CurrentCompanyInfo.FK_GECurrencyID))
            {
                if (bUnitPrice)
                {
                    return Math.Round(dbNumber, _systemUnitPriceCurrencyDecimal, MidpointRounding.AwayFromZero);
                }
                return Math.Round(dbNumber, _systemCurrencyDecimal, MidpointRounding.AwayFromZero);
            }
            GECurrencysInfo objectByID = (GECurrencysInfo)new GECurrencysController().GetObjectByID(iCurrencyID);
            return Round(dbNumber, objectByID, bUnitPrice);
        }

        public static void RunMailServices()
        {
            string strModuleName = "MailManagement";
            //BaseModuleERP module = BaseModuleFactory.GetModule(strModuleName);
        }

        public static void SaveUserStyle(string strLookAndFeelStyle, string strLookAndFeelStyleSkin)
        {
            ADUsersInfo objectByName = (ADUsersInfo)new ADUsersController().GetObjectByName(CurrentUser);
            objectByName.ADUserStyle = strLookAndFeelStyle;
            objectByName.ADUserStyleSkin = strLookAndFeelStyleSkin;
            new ADUsersController().UpdateObject(objectByName);
        }

        public static void SetActiveGroupByModule(string strModuleName)
        {
            //NavBarItemLink link = MainScreen.SectionManager.get_Items().get_Item("fld_navBar" + strModuleName).get_Links().get_Item(0);
            //MainScreen.SectionManager.set_ActiveGroup(link.get_Group());
            //MainScreen.SectionManager.set_SelectedLink(link);
        }

        private static void SetApplicationCulture()
        {
            try
            {
                if (CurrentLang == "vn")
                {
                    Application.CurrentCulture = new CultureInfo("vi-VN", true);
                }
                else
                {
                    Application.CurrentCulture = new CultureInfo("en-us", true);
                }
                if (_currentCompanyInfo != null)
                {
                    if (!string.IsNullOrEmpty(_currentCompanyInfo.CSCompanyDateFormat))
                    {
                        Application.CurrentCulture.DateTimeFormat.ShortDatePattern = _currentCompanyInfo.CSCompanyDateFormat;
                    }
                    if (!string.IsNullOrEmpty(_currentCompanyInfo.CSCompanyNumDecSeparator))
                    {
                        Application.CurrentCulture.NumberFormat.NumberDecimalSeparator = _currentCompanyInfo.CSCompanyNumDecSeparator;
                        Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = _currentCompanyInfo.CSCompanyNumDecSeparator;
                    }
                    if (!string.IsNullOrEmpty(_currentCompanyInfo.CSCompanyNumGroupSeparator))
                    {
                        Application.CurrentCulture.NumberFormat.NumberGroupSeparator = _currentCompanyInfo.CSCompanyNumGroupSeparator;
                        Application.CurrentCulture.NumberFormat.CurrencyGroupSeparator = _currentCompanyInfo.CSCompanyNumGroupSeparator;
                    }
                }
            }
            catch (Exception)
            {
                Application.CurrentCulture = new CultureInfo("en-us", true);
                Application.CurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
                Application.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
                Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = ".";
                Application.CurrentCulture.NumberFormat.NumberGroupSeparator = ",";
                Application.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ",";
            }
            CurrentLanguageInfo = (GELanguagesInfo)new GELanguagesController().GetObjectByID(_currentCompanyInfo.FK_GELanguageID);
            if ((CurrentLanguageInfo != null) && CurrentLanguageInfo.GELanguageName.Equals("vn"))
            {
                //GridLocalizer.set_Active(new VietNamGridLocalizer());
                //Localizer.set_Active(new VietNamLocalizer());
            }
        }

        public static void SetApplicationStyle(string strLookAndFeelStyle, string strLookAndFeelStyleSkin)
        {
            //LookAndFeelStyle style = 4;
            //try
            //{
            //    style = (LookAndFeelStyle)Enum.Parse(typeof(LookAndFeelStyle), strLookAndFeelStyle);
            //}
            //catch (Exception)
            //{
            //}
            //UserLookAndFeel.get_Default().SetStyle(style, false, true);
            //if (!string.IsNullOrEmpty(strLookAndFeelStyleSkin))
            //{
            //    UserLookAndFeel.get_Default().SetSkinStyle(strLookAndFeelStyleSkin);
            //}
            //else
            //{
            //    UserLookAndFeel.get_Default().SetSkinStyle("Black");
            //}
        }

        public static void SetDefaultDate(BusinessObject objBusinessObject, DateTime dtDefaultDate)
        {
            foreach (PropertyInfo info in objBusinessObject.GetType().GetProperties())
            {
                if (!info.Name.StartsWith("AA") && info.PropertyType.Equals(typeof(DateTime)))
                {
                    GMCDbUtil.SetPropertyValue(objBusinessObject, info.Name, dtDefaultDate);
                }
            }
        }

        //public static void SetDummy(DataView dvLookupTable, STGridColumnsInfo objSTGridColumnsInfo, string strLookupTableName)
        //{
        //    SetDummy(dvLookupTable, GMCDbUtil.GetTablePrimaryColumn(strLookupTableName), objSTGridColumnsInfo.STGridColumnRepoDsplMem);
        //}

        public static void SetDummy(DataView dvLookupTable, string psValMem, string psDsplMem)
        {
            if (dvLookupTable != null)
            {
                try
                {
                    string sort = dvLookupTable.Sort;
                    dvLookupTable.Sort = psValMem;
                    int num = -1;
                    DataRow row = dvLookupTable.Table.NewRow();
                    if (psValMem.ToUpper().EndsWith("ID"))
                    {
                        num = dvLookupTable.Find(0);
                        row[psValMem] = 0;
                    }
                    else
                    {
                        row[psValMem] = "";
                        num = dvLookupTable.Find("");
                    }
                    if (!string.IsNullOrEmpty(psDsplMem) && (row[psDsplMem] != null))
                    {
                        row[psDsplMem] = "";
                    }
                    if (num < 0)
                    {
                        dvLookupTable.Table.Rows.InsertAt(row, 0);
                    }
                    dvLookupTable.Sort = sort;
                }
                catch (Exception)
                {
                }
            }
        }

        //public static BaseModuleERP ShowModule(string strModuleName)
        //{
        //    return ShowModule(strModuleName, true);
        //}

        //public static BaseModuleERP ShowModule(string strModuleName, bool bEnableProgressBar)
        //{
        //    try
        //    {
        //        Cursor.Current = Cursors.WaitCursor;
        //        if (IsOpenedModule(strModuleName))
        //        {
        //            return ShowOpenedModule(strModuleName);
        //        }
        //        BaseModuleERP currentModule = CurrentModule;
        //        if (bEnableProgressBar)
        //        {
        //            string moduleDescription = GetModuleDescription(strModuleName);
        //            if (string.IsNullOrEmpty(moduleDescription))
        //            {
        //                moduleDescription = strModuleName;
        //            }
        //            GMCWaitingDialog.Caption = GetControlText(moduleDescription);
        //            GMCWaitingDialog.Title = GetControlText("Đang nạp....");
        //            GMCWaitingDialog.Show(null);
        //            GMCWaitingDialog.SetProgress(0, 100);
        //            GMCWaitingDialog.SetAutoProgress(0, 100);
        //            Application.DoEvents();
        //        }
        //        BaseModuleERP module = BaseModuleFactory.GetModule(strModuleName);
        //        if (module != null)
        //        {
        //            ShowNewModule(module);
        //            if (string.IsNullOrEmpty(module.ParentScreen.strModuleParent))
        //            {
        //                CurrentModuleName = module.Name;
        //                CurrentModule = module;
        //            }
        //            else
        //            {
        //                CurrentModuleName = module.ParentScreen.strModuleParent;
        //                CurrentModule = module.ParentScreen.moduleParent;
        //            }
        //            if (bEnableProgressBar)
        //            {
        //                GMCWaitingDialog.SetAutoProgress(0x5f, 100);
        //                Application.DoEvents();
        //            }
        //        }
        //        if (bEnableProgressBar)
        //        {
        //            GMCWaitingDialog.SetPosition(100);
        //            GMCWaitingDialog.Close();
        //        }
        //        return module;
        //    }
        //    catch (Exception exception)
        //    {
        //        GMCWaitingDialog.HideDialog();
        //        GMCLogging.LogNewMessage(strModuleName, CurrentUser, "ShowModule", string.Format("{0}", exception.Message), "FAILE", true);
        //        return null;
        //    }
        //}

        public static void ShowModule(string strModuleName, int iObjectID)
        {
            //BaseModuleERP eerp = ShowModule(strModuleName);
            //Application.DoEvents();
            //if ((eerp != null) && (eerp.CurrentModuleEntity.MainObject != null))
            //{
            //    BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(GMCUtil.GetTableNameFromBusinessObject(eerp.CurrentModuleEntity.MainObject) + "Controller");
            //    eerp.Toolbar.SetToolbar(businessController.GetDataSetByID(iObjectID));
            //    eerp.Invalidate(iObjectID);
            //    eerp.ActivateDataMainScreen();
            //}
        }

        protected static void ShowModuleOnHomePage()
        {
            try
            {
                bool flag = true;
                STModuleConfigsController controller = new STModuleConfigsController();
                DataSet allDataByForeignColumn = controller.GetAllDataByForeignColumn("FK_ADUserGroupID", CurrentUserGroupInfo.ADUserGroupID);
                if (allDataByForeignColumn.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in allDataByForeignColumn.Tables[0].Rows)
                    {
                        STModuleConfigsInfo objectFromDataRow = (STModuleConfigsInfo)controller.GetObjectFromDataRow(row);
                        if (objectFromDataRow.STModuleConfigHomePage)
                        {
                            STModulesController controller2 = new STModulesController();
                            STModulesInfo objectByID = (STModulesInfo)controller2.GetObjectByID(objectFromDataRow.FK_STModuleID);
                            if (objectByID != null)
                            {
                                flag = false;
                                //BaseModuleERP eerp = ShowModule(objectByID.STModuleName);
                                //if ((eerp != null) && !objectFromDataRow.STModuleConfigDsplNav)
                                //{
                                //    eerp.ParentScreen.SetVisibleNarBarSection(false);
                                //}
                            }
                        }
                    }
                }
                if (flag)
                {
                    //ShowModule("Home", false);
                }
            }
            catch (Exception)
            {
                //ShowModule("Home", false);
            }
        }

        public static void ShowModuleWithDataMainScreen(string strModuleName, int iObjectID)
        {
            try
            {
                //GMCWaitingDialog.Caption = "Please waiting...";
                //GMCWaitingDialog.Title = "Loading module....";
                //GMCWaitingDialog.Show(null);
                //BaseModuleERP module = null;
                //if (CachingQuicklyModule == null)
                //{
                //    CachingQuicklyModule = new Dictionary<string, BaseModuleERP>();
                //}
                //if (!CachingQuicklyModule.ContainsKey(strModuleName))
                //{
                //    BaseModuleERP.IsShowMainScreenOnly = false;
                //    module = BaseModuleFactory.GetModule(strModuleName);
                //    if (module == null)
                //    {
                //        GMCWaitingDialog.Close();
                //        return;
                //    }
                //    CachingQuicklyModule.Add(strModuleName, module);
                //}
                //if (module == null)
                //{
                //    module = CachingQuicklyModule[strModuleName];
                //}
                //module.ParentScreen.SetScreenStyle();
                //Application.DoEvents();
                //GMCWaitingDialog.Close();
                //GMCScreen firstDataMainScreenAfterSearch = module.GetFirstDataMainScreenAfterSearch();
                //if (firstDataMainScreenAfterSearch.IsDataMainScreen() && (firstDataMainScreenAfterSearch.SortOrder >= 0))
                //{
                //    firstDataMainScreenAfterSearch.ControlBox = true;
                //    firstDataMainScreenAfterSearch.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                //    firstDataMainScreenAfterSearch.Size = new Size(0x343, 600);
                //    foreach (Control control in firstDataMainScreenAfterSearch.Controls)
                //    {
                //        GMCDbUtil.SetPropertyValue(control, "ReadOnly", true);
                //    }
                //    CurrentModule.ParentScreen.Activate();
                //    module.ActiveScreen = firstDataMainScreenAfterSearch;
                //    BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(GMCUtil.GetTableNameFromBusinessObject(module.CurrentModuleEntity.MainObject) + "Controller");
                //    module.Invalidate(iObjectID);
                //    firstDataMainScreenAfterSearch.ShowDialog();
                //}
            }
            catch (Exception)
            {
                //GMCWaitingDialog.Close();
                //GMCLogging.CloseDiaglog();
                //XtraMessageBox.Show("This function has not supported!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.DoEvents();
            }
            Application.DoEvents();
        }

        //private static void ShowNewModule(BaseModuleERP module)
        //{
        //    AddOpenModuleToOpenModulesToolStrip(module.Name);
        //    module.Show();
        //    module.MaximizeParentScreen();
        //}

        //private static BaseModuleERP ShowOpenedModule(string strModuleName)
        //{
        //    ToolStripButton tsbtnModule = (ToolStripButton)MainScreen.OpenModulesToolStrip.Items[strModuleName];
        //    CheckOpenModuleToolStripButton(tsbtnModule);
        //    BaseModuleERP eerp = (BaseModuleERP)OpenModules[strModuleName];
        //    eerp.ParentScreen.SuspendLayout();
        //    eerp.ParentScreen.ShowAndActivate();
        //    eerp.ParentScreen.ResumeLayout();
        //    return eerp;
        //}

        //public static void ShowScreen(GMCScreen scr, bool bIsShowDialog)
        //{
        //    ADUsersInfo objectByName = (ADUsersInfo)new ADUsersController().GetObjectByName(CurrentUser);
        //    if (string.IsNullOrEmpty(objectByName.ADUserStyle))
        //    {
        //        objectByName.ADUserStyle = "Black";
        //    }
        //    LookAndFeelStyle style = 4;
        //    try
        //    {
        //        style = (LookAndFeelStyle)Enum.Parse(typeof(LookAndFeelStyle), objectByName.ADUserStyle);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    scr.get_LookAndFeel().SetStyle(style, false, false, objectByName.ADUserStyleSkin);
        //    scr.Parent = ActiveScreen;
        //    scr.StartPosition = FormStartPosition.CenterParent;
        //    if (bIsShowDialog)
        //    {
        //        scr.ShowDialog();
        //    }
        //    else
        //    {
        //        scr.Show();
        //    }
        //}

        public static void ShowSectionProcess(string strSectionName)
        {
            try
            {
                if (!OpenModules.ContainsKey("Home"))
                {
                    return;
                }
                //BaseModuleERP eerp = (BaseModuleERP)OpenModules["Home"];
                //eerp.ParentScreen.SuspendLayout();
                //foreach (Control control in eerp.Controls.Values)
                //{
                //    if (((control is XtraTabControl) && (control.Tag != null)) && control.Tag.ToString().Equals("Iconic"))
                //    {
                //        XtraTabControl control2 = (XtraTabControl)control;
                //        foreach (XtraTabPage page in control2.get_TabPages())
                //        {
                //            if ((page.Text != null) && page.Text.ToString().Equals(strSectionName))
                //            {
                //                control2.set_SelectedTabPage(page);
                //                foreach (Control control3 in eerp.Controls.Values)
                //                {
                //                    if ((((control3 is PanelControl) && (control3.Tag != null)) && control3.Tag.ToString().Equals("Iconic")) && (control3.Left != Convert.ToInt32((int)((control3.Parent.ClientSize.Width - control3.Width) / 2))))
                //                    {
                //                        control3.Left = Convert.ToInt32((int)((control3.Parent.ClientSize.Width - control3.Width) / 2));
                //                        control3.Top = 0;
                //                    }
                //                }
                //                CurrentModule.ParentScreen.ShowModule("Home");
                //                CurrentModule = eerp;
                //                CurrentModuleName = eerp.Name;
                //                foreach (NavBarGroup group in eerp.ParentScreen.SectionManager.get_Groups())
                //                {
                //                    if (group.get_Caption().Equals(strSectionName))
                //                    {
                //                        eerp.ParentScreen.SectionManager.set_ActiveGroup(group);
                //                        break;
                //                    }
                //                }
                //                return;
                //            }
                //        }
                //    }
                //}
                //eerp.ParentScreen.ResumeLayout();
            }
            catch (Exception)
            {
                //XtraMessageBox.Show("This function has not supported!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.DoEvents();
            }
            Application.DoEvents();
        }

        //public static bool SimpleLogOn()
        //{
        //    //guiLogin login = new guiLogin();
        //    //return (login.ShowDialog() == DialogResult.OK);
        //}

        public static void SwitchConnection(string strBranchName)
        {
            SwitchConnection(strBranchName, false);
        }

        public static void SwitchConnection(string strBranchName, bool bDecrypt)
        {
            BRBranchsController controller = new BRBranchsController();
            BRBranchsInfo objectByName = (BRBranchsInfo)controller.GetObjectByName(strBranchName);
            if (((objectByName != null) && (CurrentCompanyInfo != null)) && (objectByName.BRBranchID != CurrentCompanyInfo.FK_BRBranchID))
            {
                string bRBranchDatabase = objectByName.BRBranchDatabase;
                string bRBranchServerName = objectByName.BRBranchServerName;
                string bRBranchDatabaseUser = objectByName.BRBranchDatabaseUser;
                string bRBranchDatabasePassword = objectByName.BRBranchDatabasePassword;
                if (bDecrypt)
                {
                    bRBranchDatabasePassword = new Crypto().Decrypt(bRBranchDatabasePassword);
                }
                SqlDatabaseHelper.SwitchConnection(string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", new object[] { bRBranchServerName, bRBranchDatabase, bRBranchDatabaseUser, bRBranchDatabasePassword }));
            }
        }

        public static void SwitchConnection(string strServer, string strDatabase, string strUser, string strPassword)
        {
            strPassword = new Crypto().Decrypt(strPassword);
            SqlDatabaseHelper.SwitchConnection(string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", new object[] { strServer, strDatabase, strUser, strPassword }));
        }

        public static void SwitchConnectionNotCheckBranch(string strBranchName)
        {
            SwitchConnectionNotCheckBranch(strBranchName, false);
        }

        public static void SwitchConnectionNotCheckBranch(string strBranchName, bool bDecrypt)
        {
            BRBranchsController controller = new BRBranchsController();
            BRBranchsInfo objectByName = (BRBranchsInfo)controller.GetObjectByName(strBranchName);
            if ((objectByName != null) && (CurrentCompanyInfo != null))
            {
                if (objectByName.BRBranchID != CurrentCompanyInfo.FK_BRBranchID)
                {
                    string bRBranchDatabase = objectByName.BRBranchDatabase;
                    string bRBranchServerName = objectByName.BRBranchServerName;
                    string bRBranchDatabaseUser = objectByName.BRBranchDatabaseUser;
                    string bRBranchDatabasePassword = objectByName.BRBranchDatabasePassword;
                    if (bDecrypt)
                    {
                        bRBranchDatabasePassword = new Crypto().Decrypt(bRBranchDatabasePassword);
                    }
                    SqlDatabaseHelper.SwitchConnection(string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", new object[] { bRBranchServerName, bRBranchDatabase, bRBranchDatabaseUser, bRBranchDatabasePassword }));
                }
                else
                {
                    RollbackLocalConnection();
                }
            }
        }

        public static bool TestCurrentConnection()
        {
            return SqlDatabaseHelper.TestConnection();
        }

        //public static MRUEdit TryInitMRUEdit(string strFieldName)
        //{
        //    MRUEdit edit = TryInitRepositoryItemMRUEdit(strFieldName).CreateEditor();
        //    edit.set_ToolTipTitle(strFieldName);
        //    edit.get_Properties().set_CaseSensitiveSearch(false);
        //    edit.add_AddingMRUItem(new AddingMRUItemEventHandler(null, MRUEdit_AddingMRUItem));
        //    edit.get_Properties().get_Items().AddRange(TryInitRepositoryItemMRUEdit(strFieldName).get_Items());
        //    return edit;
        //}

        //public static RepositoryItemMRUEdit TryInitRepositoryItemMRUEdit(string strFieldName)
        //{
        //    if (!_suggestEdit.Keys.Contains(strFieldName))
        //    {
        //        RepositoryItemMRUEdit edit = new RepositoryItemMRUEdit();
        //        edit.set_CaseSensitiveSearch(false);
        //        _suggestEdit.Add(strFieldName, edit);
        //    }
        //    return _suggestEdit[strFieldName];
        //}

        public static bool TryToInitLookupTable(string strLookupTable)
        {
            if (LookupTables == null)
            {
                InitLookupTables();
            }
            if (!LookupTables.ContainsKey(strLookupTable))
            {
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (businessController != null)
                {
                    string lookupQueryColumn = GetLookupQueryColumn(strLookupTable);
                    DataSet allObjectForDataLookups = businessController.GetAllObjectForDataLookups(lookupQueryColumn);
                    if ((allObjectForDataLookups != null) && (allObjectForDataLookups.Tables.Count > 0))
                    {
                        LookupTables.Add(strLookupTable, allObjectForDataLookups.Tables[0]);
                        LookupTablesUpdatedDate.Add(strLookupTable, DateTime.Now);
                    }
                    return true;
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        public static bool TryToInitLookupTable(string strLookupTable, params string[] columns)
        {
            if (LookupTables == null)
            {
                InitLookupTables();
            }
            if (!LookupTables.ContainsKey(strLookupTable))
            {
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (businessController != null)
                {
                    DataSet allObjectForDataLookups = businessController.GetAllObjectForDataLookups(columns);
                    if ((allObjectForDataLookups != null) && (allObjectForDataLookups.Tables.Count > 0))
                    {
                        LookupTables.Add(strLookupTable, allObjectForDataLookups.Tables[0]);
                        LookupTablesUpdatedDate.Add(strLookupTable, DateTime.Now);
                    }
                    return true;
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        public static bool TryToInitLookupTable(string strLookupTable, string strQueryColumn)
        {
            if (LookupTables == null)
            {
                InitLookupTables();
            }
            if (!LookupTables.ContainsKey(strLookupTable))
            {
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(strLookupTable + "Controller");
                if (businessController != null)
                {
                    DataSet allObjectForDataLookups = businessController.GetAllObjectForDataLookups(strQueryColumn);
                    if ((allObjectForDataLookups != null) && (allObjectForDataLookups.Tables.Count > 0))
                    {
                        LookupTables.Add(strLookupTable, allObjectForDataLookups.Tables[0]);
                        LookupTablesUpdatedDate.Add(strLookupTable, DateTime.Now);
                    }
                    return true;
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        //public static void UpdateObjectNumbering(BaseModuleERP Module)
        //{
        //    GENumberingsController controller = new GENumberingsController();
        //    GENumberingsInfo gENumbering = GetGENumbering(Module);
        //    if (gENumbering != null)
        //    {
        //        if (gENumbering.GENumberingByDate)
        //        {
        //            gENumbering.GENumberingDateStart++;
        //            controller.UpdateObject(gENumbering);
        //        }
        //        else
        //        {
        //            string tableNameFromBusinessObject = GMCUtil.GetTableNameFromBusinessObject(Module.CurrentModuleEntity.MainObject);
        //            tableNameFromBusinessObject = tableNameFromBusinessObject.Substring(0, tableNameFromBusinessObject.Length - 1);
        //            string str2 = Convert.ToString(GMCDbUtil.GetPropertyValue(Module.CurrentModuleEntity.MainObject, tableNameFromBusinessObject + "No"));
        //            string str3 = str2.Substring(str2.Length - gENumbering.GENumberingLength);
        //            if (!string.IsNullOrEmpty(str3))
        //            {
        //                try
        //                {
        //                    int num2 = 0;
        //                    num2 = Convert.ToInt32(str3) + 1;
        //                    gENumbering.GENumberingStart = num2;
        //                    controller.UpdateObject(gENumbering);
        //                }
        //                catch (Exception)
        //                {
        //                }
        //            }
        //        }
        //    }
        //}

        public static void UpdateObjectNumbering(string strModuleName)
        {
            GENumberingsController controller = new GENumberingsController();
            GENumberingsInfo objectByName = (GENumberingsInfo)controller.GetObjectByName(strModuleName);
            if (objectByName != null)
            {
                if (objectByName.GENumberingByDate)
                {
                    objectByName.GENumberingDateStart++;
                    controller.UpdateObject(objectByName);
                }
                else
                {
                    objectByName.GENumberingStart++;
                    controller.UpdateObject(objectByName);
                }
            }
        }

        public static void UpdateObjectNumbering(string strModuleName, BusinessObject objMainObject)
        {
            GENumberingsController controller = new GENumberingsController();
            GENumberingsInfo objectByName = (GENumberingsInfo)controller.GetObjectByName(strModuleName);
            if (objectByName != null)
            {
                if (objectByName.GENumberingByDate)
                {
                    string tableNameFromBusinessObject = GMCUtil.GetTableNameFromBusinessObject(objMainObject);
                    string str2 = string.Empty;
                    string strPropertyName = tableNameFromBusinessObject.Substring(0, tableNameFromBusinessObject.Length - 1) + "No";
                    object propertyValue = GMCDbUtil.GetPropertyValue(objMainObject, strPropertyName);
                    if (propertyValue != null)
                    {
                        str2 = propertyValue.ToString();
                        if (!string.IsNullOrEmpty(str2))
                        {
                            int num = str2.LastIndexOf("/");
                            if (num >= 0)
                            {
                                int num2 = Convert.ToInt32(str2.Substring(num + 1, objectByName.GENumberingLength));
                                objectByName.GENumberingDateStart = num2 + 1;
                                controller.UpdateObject(objectByName);
                            }
                            else
                            {
                                objectByName.GENumberingStart++;
                                controller.UpdateObject(objectByName);
                            }
                        }
                    }
                }
                else
                {
                    objectByName.GENumberingStart++;
                    controller.UpdateObject(objectByName);
                }
            }
        }

        //public static void UpdateOpenedModule(BaseModuleERP module)
        //{
        //    //if (!IsOpenedModule(module.Name))
        //    //{
        //    //    OpenModules.Add(module.Name, module);
        //    //}
        //    //else
        //    //{
        //    //    OpenModules[module.Name] = module;
        //    //}
        //}

        public static void Upload(string strClientFileName, string strFTPFileName, string ftpUserName, string ftpPassword)
        {
            //WaitDialogForm form = new WaitDialogForm();
            //form.set_Caption("Upload file");
            FileInfo info = new FileInfo(strClientFileName);
            string str = strFTPFileName;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(strFTPFileName));
            request.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
            request.KeepAlive = false;
            request.Method = "STOR";
            request.UseBinary = true;
            request.ContentLength = info.Length;
            int count = 0x800;
            byte[] buffer = new byte[count];
            FileStream stream = info.OpenRead();
            try
            {
                Stream requestStream = request.GetRequestStream();
                for (int i = stream.Read(buffer, 0, count); i != 0; i = stream.Read(buffer, 0, count))
                {
                    requestStream.Write(buffer, 0, i);
                }
                requestStream.Close();
                stream.Close();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Upload Error");
            }
            //form.Close();
        }

        public static bool ValidUserStatus(string strModuleName)
        {
            try
            {
                int objectIDByName = new ADUsersController().GetObjectIDByName(CurrentUser);
                GEUserAuditsInfo gEUserAuditsByADUserIDAndModuleName = new GEUserAuditsController().GetGEUserAuditsByADUserIDAndModuleName(objectIDByName, strModuleName);
                if (gEUserAuditsByADUserIDAndModuleName != null)
                {
                    if (gEUserAuditsByADUserIDAndModuleName.GEUserAuditPCName.Equals(PCName) && gEUserAuditsByADUserIDAndModuleName.GEUserAuditIP.Equals(IPAddress))
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        public static int CountLogonFail
        {
            get
            {
                return _countLogonFail;
            }
            set
            {
                _countLogonFail = value;
            }
        }

        public static ADUserGroupsInfo CurrentUserGroupInfo
        {
            get
            {
                return _currentUserGroupsInfo;
            }
        }

        public static CSCompanysInfo CurrentCompanyInfo
        {
            get
            {
                return _currentCompanyInfo;
            }
            set
            {
                _currentCompanyInfo = value;
            }
        }

        public static string CurrentServer
        {
            get
            {
                return _currentServer;
            }
            set
            {
                _currentServer = value;
            }
        }

        public static string CurrentDatabase
        {
            get
            {
                return _currentDatabase;
            }
            set
            {
                _currentDatabase = value;
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

        public static GELanguagesInfo CurrentLanguageInfo
        {
            get
            {
                return _languageInfo;
            }
            set
            {
                _languageInfo = value;
            }
        }

        public static DateTime WorkingDate
        {
            get
            {
                return _workingDate;
            }
            set
            {
                _workingDate = value;
            }
        }

        public static int WorkingPeriod
        {
            get
            {
                return _workingPeriod;
            }
            set
            {
                _workingPeriod = value;
            }
        }

        public static int WorkingYear
        {
            get
            {
                return _workingYear;
            }
            set
            {
                _workingYear = value;
            }
        }

        public static string SessionTableName
        {
            get
            {
                return _sesssionTableName;
            }
            set
            {
                _sesssionTableName = value;
            }
        }

        public static int SessionObjectID
        {
            get
            {
                return _sessionObjectID;
            }
            set
            {
                _sessionObjectID = value;
            }
        }

        public static Dictionary<string, DataTable> LookupTables
        {
            get
            {
                return _lookupTables;
            }
            set
            {
                _lookupTables = value;
            }
        }

        public static SortedList LookupTablesUpdatedDate
        {
            get
            {
                return _lookupTableUpdatedDate;
            }
            set
            {
                _lookupTableUpdatedDate = value;
            }
        }

        public static SortedList FieldFormatGroups
        {
            get
            {
                return _fieldFormatGroups;
            }
            set
            {
                _fieldFormatGroups = value;
            }
        }

        public static int PriceDecimal
        {
            get
            {
                return _priceDecimal;
            }
            set
            {
                _priceDecimal = value;
            }
        }

        public static string PCName
        {
            get
            {
                return _pcName;
            }
            set
            {
                _pcName = value;
            }
        }

        public static string IPAddress
        {
            get
            {
                return _ipAddress;
            }
            set
            {
                _ipAddress = value;
            }
        }

        public static VersionInfo GetVersionInfo
        {
            get
            {
                if (currentVersion == null)
                {
                    currentVersion = LoadCurentVersionFromXML("VersionInfo.xml");
                }
                if (currentVersion == null)
                {
                    currentVersion = new VersionInfo();
                }
                return currentVersion;
            }
        }

        //public class VietNamGridLocalizer : GridLocalizer
        //{
        //    public override string GetLocalizedString(GridStringId id)
        //    {
        //        switch (id)
        //        {
        //            case 2:
        //                return "T\x00f9y biến";

        //            case 5:
        //                return "Bộ lọc";

        //            case 6:
        //                return "(Tất cả)";

        //            case 7:
        //                return "T\x00f9y chọn";

        //            case 8:
        //                return "(Rỗng)";

        //            case 9:
        //                return "(Kh\x00f4ng rỗng)";

        //            case 10:
        //                return "Lọc theo ti\x00eau ch\x00ed";

        //            case 11:
        //                return "Hiển thị d\x00f2ng với điều kiện :";

        //            case 12:
        //                return "v\x00e0";

        //            case 13:
        //                return "hoặc";

        //            case 14:
        //                return "Chấp thuận";

        //            case 0x10:
        //                return "Trường";

        //            case 0x11:
        //                return "Hủy bỏ";

        //            case 0x12:
        //                return "=";

        //            case 0x13:
        //                return " kh\x00e1c ";

        //            case 20:
        //                return ">";

        //            case 0x15:
        //                return ">=";

        //            case 0x16:
        //                return "<";

        //            case 0x17:
        //                return "<=";

        //            case 0x19:
        //                return " kh\x00f4ng trống";

        //            case 0x1a:
        //                return "bắt đầu với";

        //            case 0x1b:
        //                return " kh\x00f4ng bắt đầu với";

        //            case 0x1c:
        //                return "Nhập gi\x00e1 trị";

        //            case 0x1d:
        //                return "chọn 1 ph\x00e9p so s\x00e1nh";

        //            case 0x20:
        //                return "Tổng";

        //            case 0x21:
        //                return "Nhỏ nhất";

        //            case 0x22:
        //                return "Lớn nhất";

        //            case 0x23:
        //                return "Đếm";

        //            case 0x24:
        //                return "Trung b\x00ecnh";

        //            case 0x25:
        //                return "Kh\x00f4ng";

        //            case 0x26:
        //                return "TỔNG={0:#.##}";

        //            case 0x27:
        //                return "NHỎ NHẤT={0}";

        //            case 40:
        //                return "LỚN NHẤT={0}";

        //            case 0x29:
        //                return "{0}";

        //            case 0x2a:
        //                return "TRUNG B\x00ccNH={0:#.##}";

        //            case 0x2b:
        //                return "Sắp xếp tăng";

        //            case 0x2c:
        //                return "Sắp xếp giảm";

        //            case 0x2d:
        //                return "Hiển thị cột";

        //            case 0x2e:
        //                return "Bỏ cột";

        //            case 0x2f:
        //                return "Nh\x00f3m theo cột n\x00e0y";

        //            case 0x30:
        //                return "Bỏ nh\x00f3m";

        //            case 0x31:
        //                return "T\x00f9y biến cột khi chạy";

        //            case 50:
        //                return "Vừa xem nhất";

        //            case 0x33:
        //                return "C\x00f3 thể lọc";

        //            case 0x34:
        //                return "Bỏ lọc";

        //            case 0x35:
        //                return "Vừa xem nhất (tất cả cột)";

        //            case 0x39:
        //                return "Mở rộng tất";

        //            case 0x3a:
        //                return "Thu hẹp tất";

        //            case 0x3b:
        //                return "X\x00f3a nh\x00f3m";

        //            case 0x41:
        //                return "Bật/Tắt chức năng Nh\x00f3m";

        //            case 0x47:
        //                return "K\x00e9o cột dữ liệu v\x00e0o đ\x00e2y để tạo bộ lọc";

        //            case 0x4d:
        //                return "Bỏ sắp xếp";

        //            case 0x4e:
        //                return "T\x00f9y biến bộ lọc";

        //            case 0x4f:
        //                return "Đồng \x00fd";

        //            case 80:
        //                return "Tho\x00e1t";

        //            case 0x51:
        //                return "\x00c1p dụng";

        //            case 0x52:
        //                return "Lọc dữ liệu theo ti\x00eau ch\x00ed";

        //            case 0x53:
        //                return "K\x00e9o thả Cột v\x00e0o đ\x00e2y t\x00f9y biến hiển thị cho bảng.";
        //        }
        //        return base.GetLocalizedString(id);
        //    }

        //    public override string Language
        //    {
        //        get
        //        {
        //            return "VietNam";
        //        }
        //    }
        //}

        //public class VietNamLocalizer : Localizer
        //{
        //    public override string GetLocalizedString(StringId id)
        //    {
        //        switch (id)
        //        {
        //            case 1:
        //                return "Lỗi";

        //            case 2:
        //                return "Gi\x00e1 trị kh\x00f4ng hợp lệ";

        //            case 3:
        //                return "Chọn";

        //            case 4:
        //                return "Bỏ chọn";

        //            case 5:
        //                return "Kh\x00f4ng x\x00e1c định";

        //            case 6:
        //                return "H\x00f4m nay";

        //            case 7:
        //                return "X\x00f3a";

        //            case 8:
        //                return "Đồng  \x00fd";

        //            case 9:
        //                return "Bỏ qua";

        //            case 10:
        //                return "Về đầu";

        //            case 11:
        //                return "Ph\x00eda trước";

        //            case 12:
        //                return "Ph\x00eda trước";

        //            case 13:
        //                return "Tiếp theo";

        //            case 14:
        //                return "Tiếp theo";

        //            case 15:
        //                return "Cuối";

        //            case 0x10:
        //                return "Ch\x00e8n v\x00e0o cuối";

        //            case 0x11:
        //                return "X\x00f3a";

        //            case 0x12:
        //                return "Sửa";

        //            case 0x13:
        //                return "Ho\x00e0n tất";

        //            case 20:
        //                return "Ho\x00e0n tất";

        //            case 0x15:
        //                return "D\x00f2ng thứ {0} / {1}";

        //            case 0x16:
        //                return "Cắt";

        //            case 0x17:
        //                return "Copy";

        //            case 0x18:
        //                return "D\x00e1n";

        //            case 0x19:
        //                return "X\x00f3a";

        //            case 0x1a:
        //                return "Nạp";

        //            case 0x1b:
        //                return "Lưu";

        //            case 30:
        //                return "Mở file";

        //            case 0x1f:
        //                return "Lưu dạng kh\x00e1c";

        //            case 0x20:
        //                return "Sai định dạng h\x00ecnh ảnh";

        //            case 0x21:
        //                return "C\x00f3 lỗi";

        //            case 0x23:
        //                return "[ nhập d\x00f2ng mới ]";

        //            case 0x24:
        //                return "Sai kiểu dữ liệu";

        //            case 0x25:
        //                return "T\x00ean";

        //            case 0x26:
        //                return "Gi\x00e1 trị nhập liệu kh\x00f4ng hợp lệ. Bạn c\x00f3 muốn sửa n\x00f3 kh\x00f4ng ?";

        //            case 0x27:
        //                return "Kh\x00f4ng hiểu định dạng h\x00ecnh ảnh";

        //            case 40:
        //                return "Kh\x00f4ng tồn tại gi\x00e1 trị h\x00ecnh ảnh";

        //            case 0x29:
        //                return "Danh s\x00e1ch c\x00f3 chiều d\x00e0i kh\x00f4ng hợp lệ";

        //            case 0x2a:
        //                return "(Trống)";

        //            case 0x2b:
        //                return "(H\x00ecnh ảnh)";

        //            case 0x2c:
        //                return "T\x00f9y chỉnh";

        //            case 0x2e:
        //                return "Hệ thống";

        //            case 0x3a:
        //                return "Tho\x00e1t";

        //            case 0x3b:
        //                return "Đồng \x00fd";

        //            case 60:
        //                return "Bỏ qua";

        //            case 0x3d:
        //                return "C\x00f3";

        //            case 0x3e:
        //                return "Kh\x00f4ng";

        //            case 0x3f:
        //                return "Kết th\x00fac";

        //            case 0x40:
        //                return "Thử lại";

        //            case 0x41:
        //                return "Ignore";

        //            case 0x42:
        //                return "Quay lại";

        //            case 0x43:
        //                return "Cắt";

        //            case 0x44:
        //                return "Sao ch\x00e9p";

        //            case 0x45:
        //                return "D\x00e1n";

        //            case 70:
        //                return "X\x00f3a";

        //            case 0x47:
        //                return "Chọn tất cả";

        //            case 0x49:
        //                return "(v\x00e0)";

        //            case 0x4a:
        //                return "(v\x00e0 kh\x00f4ng:)";

        //            case 0x4b:
        //                return "(hoặc kh\x00f4ng:)";

        //            case 0x4c:
        //                return "(hoặc)";

        //            case 0x4d:
        //                return "(l\x00e0 một phần trong)";

        //            case 0x4e:
        //                return "(bắt đầu với)";

        //            case 0x4f:
        //                return "(nằm giữa)";

        //            case 80:
        //                return "v\x00e0";

        //            case 0x51:
        //                return "(chứa)";

        //            case 0x52:
        //                return "(kết th\x00fac bằng)";

        //            case 0x54:
        //                return "(lớn hơn)";

        //            case 0x55:
        //                return "(lớn hơn hoặc bằng)";

        //            case 0x56:
        //                return "kh\x00e1c rỗng";

        //            case 0x57:
        //                return "rỗng";
        //        }
        //        return base.GetLocalizedString(id);
        //    }

        //    public override string Language
        //    {
        //        get
        //        {
        //            return "VietNam";
        //        }
        //    }
        //}
    }
    public class WebBrowserHelper
    {
        #region Definitions/DLL Imports
        /// 
        /// For PInvoke: Contains information about an entry in the Internet cache
        /// 
        [StructLayout(LayoutKind.Explicit)]
        public struct ExemptDeltaOrReserverd
        {
            [FieldOffset(0)]
            public UInt32 dwReserved;
            [FieldOffset(0)]
            public UInt32 dwExemptDelta;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct INTERNET_CACHE_ENTRY_INFOA
        {
            public UInt32 dwStructSize;
            public IntPtr lpszSourceUrlName;
            public IntPtr lpszLocalFileName;
            public UInt32 CacheEntryType;
            public UInt32 dwUseCount;
            public UInt32 dwHitRate;
            public UInt32 dwSizeLow;
            public UInt32 dwSizeHigh;
            public FILETIME LastModifiedTime;
            public FILETIME ExpireTime;
            public FILETIME LastAccessTime;
            public FILETIME LastSyncTime;
            public IntPtr lpHeaderInfo;
            public UInt32 dwHeaderInfoSize;
            public IntPtr lpszFileExtension;
            public ExemptDeltaOrReserverd dwExemptDeltaOrReserved;
        }

        // For PInvoke: Initiates the enumeration of the cache groups in the Internet cache
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "FindFirstUrlCacheGroup",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FindFirstUrlCacheGroup(
            int dwFlags,
            int dwFilter,
            IntPtr lpSearchCondition,
        int dwSearchCondition,
        ref long lpGroupId,
        IntPtr lpReserved);

        // For PInvoke: Retrieves the next cache group in a cache group enumeration
        [DllImport(@"wininet",
        SetLastError = true,
            CharSet = CharSet.Auto,
        EntryPoint = "FindNextUrlCacheGroup",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool FindNextUrlCacheGroup(
            IntPtr hFind,
            ref long lpGroupId,
            IntPtr lpReserved);

        // For PInvoke: Releases the specified GROUPID and any associated state in the cache index file
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "DeleteUrlCacheGroup",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteUrlCacheGroup(
            long GroupId,
            int dwFlags,
            IntPtr lpReserved);

        // For PInvoke: Begins the enumeration of the Internet cache
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "FindFirstUrlCacheEntryA",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FindFirstUrlCacheEntry(
            [MarshalAs(UnmanagedType.LPTStr)] string lpszUrlSearchPattern,
            IntPtr lpFirstCacheEntryInfo,
            ref int lpdwFirstCacheEntryInfoBufferSize);

        // For PInvoke: Retrieves the next entry in the Internet cache
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "FindNextUrlCacheEntryA",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool FindNextUrlCacheEntry(
            IntPtr hFind,
            IntPtr lpNextCacheEntryInfo,
            ref int lpdwNextCacheEntryInfoBufferSize);

        // For PInvoke: Removes the file that is associated with the source name from the cache, if the file exists
        [DllImport(@"wininet",
            SetLastError = true,
            CharSet = CharSet.Auto,
            EntryPoint = "DeleteUrlCacheEntryA",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteUrlCacheEntry(
            IntPtr lpszUrlName);
        #endregion

        /// 
        /// Clears the cache of the web browser
        /// 
        public static void ClearCache()
        {
            // Indicates that all of the cache groups in the user's system should be enumerated
            const int CACHEGROUP_SEARCH_ALL = 0x0;
            // Indicates that all the cache entries that are associated with the cache group
            // should be deleted, unless the entry belongs to another cache group.
            const int CACHEGROUP_FLAG_FLUSHURL_ONDELETE = 0x2;
            const int ERROR_INSUFFICIENT_BUFFER = 0x7A;

            // Delete the groups first.
            // Groups may not always exist on the system.
            // For more information, visit the following Microsoft Web site:
            // http://msdn.microsoft.com/library/?url=/workshop/networking/wininet/overview/cache.asp            
            // By default, a URL does not belong to any group. Therefore, that cache may become
            // empty even when the CacheGroup APIs are not used because the existing URL does not belong to any group.            
            long groupId = 0;
            IntPtr enumHandle = FindFirstUrlCacheGroup(0, CACHEGROUP_SEARCH_ALL, IntPtr.Zero, 0, ref groupId, IntPtr.Zero);
            if (enumHandle != IntPtr.Zero)
            {
                bool more;
                do
                {
                    // Delete a particular Cache Group.
                    DeleteUrlCacheGroup(groupId, CACHEGROUP_FLAG_FLUSHURL_ONDELETE, IntPtr.Zero);
                    more = FindNextUrlCacheGroup(enumHandle, ref groupId, IntPtr.Zero);
                } while (more);
            }

            // Start to delete URLs that do not belong to any group.
            int cacheEntryInfoBufferSizeInitial = 0;
            FindFirstUrlCacheEntry(null, IntPtr.Zero, ref cacheEntryInfoBufferSizeInitial);  // should always fail because buffer is too small
            if (Marshal.GetLastWin32Error() == ERROR_INSUFFICIENT_BUFFER)
            {
                int cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial;
                IntPtr cacheEntryInfoBuffer = Marshal.AllocHGlobal(cacheEntryInfoBufferSize);
                enumHandle = FindFirstUrlCacheEntry(null, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);
                if (enumHandle != IntPtr.Zero)
                {
                    bool more;
                    do
                    {
                        INTERNET_CACHE_ENTRY_INFOA internetCacheEntry = (INTERNET_CACHE_ENTRY_INFOA)Marshal.PtrToStructure(cacheEntryInfoBuffer, typeof(INTERNET_CACHE_ENTRY_INFOA));
                        cacheEntryInfoBufferSizeInitial = cacheEntryInfoBufferSize;
                        DeleteUrlCacheEntry(internetCacheEntry.lpszSourceUrlName);
                        more = FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);
                        if (Marshal.GetLastWin32Error() == ERROR_INSUFFICIENT_BUFFER)
                        {
                            cacheEntryInfoBufferSize = cacheEntryInfoBufferSizeInitial;
                            cacheEntryInfoBuffer = Marshal.ReAllocHGlobal(cacheEntryInfoBuffer, (IntPtr)cacheEntryInfoBufferSize);
                            more = FindNextUrlCacheEntry(enumHandle, cacheEntryInfoBuffer, ref cacheEntryInfoBufferSizeInitial);
                        }
                    } while (more);
                }
                Marshal.FreeHGlobal(cacheEntryInfoBuffer);
            }
        }
    }
}
