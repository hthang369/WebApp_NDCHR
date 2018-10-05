using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Transactions;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Collections;
using System.Reflection;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using GMCGATE;

namespace ExpertWebLib
{
    public class SqlDatabaseHelper
    {
        public const int COMMANDTIMEOUT = 150;
        public static SqlDatabase LocalDatabase = null;
        public static SqlDatabase CurrentDatabase = null;
        private static Hashtable GMCDatabaseCollection = new Hashtable();
        private static string _connectionString = string.Empty;
        private static string _companyName = string.Empty;
        public static string TableName = string.Empty;
        public static string AAStatusColumn = "AAStatus";
        private static Dictionary<string, string> lstPrimaryColumns = new Dictionary<string, string>();
        private static Dictionary<string, DataSet> lstForeignColumns = new Dictionary<string, DataSet>();
        public static Dictionary<string, DataSet> TableColumnList = new Dictionary<string, DataSet>();
        public static Dictionary<string, Dictionary<string, PropertyInfo>> ColumnPropertyList = new Dictionary<string, Dictionary<string, PropertyInfo>>();
        public static Dictionary<string, DbCommand> StoredProCommandList = new Dictionary<string, DbCommand>();
        private static Dictionary<string, DbCommand> MaxIDDbCommandList = new Dictionary<string, DbCommand>();
        private static Dictionary<string, bool> IsPKIdentityList = new Dictionary<string, bool>();
        private static Dictionary<string, PropertyInfo> BusinessObjectPropertyList = new Dictionary<string, PropertyInfo>();
        private static System.Windows.Forms.Timer autoTestConTimer;

        static SqlDatabaseHelper()
        {
            try
            {
            }
            catch (Exception exception)
            {
                //XtraMessageBox.Show(exception.Message);
            }
        }

        public static void AddInParameter(DbCommand cmd, PropertyInfo property, object objValue)
        {
            if (property.PropertyType.Equals(typeof(int)))
            {
                GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.Int, objValue);
            }
            else if (property.PropertyType.Equals(typeof(bool)))
            {
                GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.Bit, objValue);
            }
            else if (property.PropertyType.Equals(typeof(short)))
            {
                GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.SmallInt, objValue);
            }
            else if (property.PropertyType.Equals(typeof(double)))
            {
                GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.Float, objValue);
            }
            else if (property.PropertyType.Equals(typeof(decimal)))
            {
                GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.Decimal, objValue);
            }
            else if (property.PropertyType.Equals(typeof(string)) || property.PropertyType.Equals(typeof(string)))
            {
                GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.NVarChar, objValue);
            }
            else if (property.PropertyType.Equals(typeof(DateTime)))
            {
                if (((DateTime)objValue) != DateTime.MinValue)
                {
                    GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.DateTime, objValue);
                }
            }
            else if (property.PropertyType.Equals(typeof(DateTime?)))
            {
                if ((objValue == null) || (((DateTime)objValue) == DateTime.MinValue))
                {
                    GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.DateTime, null);
                }
                else
                {
                    GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.DateTime, objValue);
                }
            }
            else if (property.PropertyType.Equals(typeof(byte[])))
            {
                GMCDatabase.AddInParameter(cmd, property.Name, SqlDbType.VarBinary, objValue);
            }
        }

        public static void AddInParameter(DbCommand cmd, string name, SqlDbType type, object objValue)
        {
            GMCDatabase.AddInParameter(cmd, name, type, objValue);
        }

        public static void AddParameterForObject(object obj, DALBaseProvider provider, DbCommand cmd)
        {
            try
            {
                TableName = provider.TableName;
                if (cmd.Parameters.Count == 0)
                {
                    PropertyInfo[] properties = provider.ObjectType.GetProperties();
                    for (int i = 0; i < properties.Length; i++)
                    {
                        if (!ColumnIsExistInBaseBusinessObject(properties[i].Name))
                        {
                            object obj2 = DynamicInvoker.DynamicGetValue(obj, properties[i]);
                            if (properties[i].PropertyType.Equals(typeof(int)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Int, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(bool)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Bit, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(short)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.SmallInt, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(double)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Float, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(decimal)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Decimal, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(string)) || properties[i].PropertyType.Equals(typeof(string)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.NVarChar, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(DateTime)))
                            {
                                if (((DateTime)obj2) != DateTime.MinValue)
                                {
                                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.DateTime, obj2);
                                }
                            }
                            else if (properties[i].PropertyType.Equals(typeof(DateTime?)))
                            {
                                if ((obj2 == null) || (((DateTime)obj2) == DateTime.MinValue))
                                {
                                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.DateTime, null);
                                }
                                else
                                {
                                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.DateTime, obj2);
                                }
                            }
                            else if (properties[i].PropertyType.Equals(typeof(byte[])))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.VarBinary, obj2);
                            }
                        }
                    }
                }
                else
                {
                    foreach (DbParameter parameter in cmd.Parameters)
                    {
                        object obj3 = DynamicInvoker.DynamicGetValue(obj, parameter.ParameterName.Replace("@", ""));
                        if (obj3 != parameter.Value)
                        {
                            GMCDatabase.SetParameterValue(cmd, parameter.ParameterName, obj3);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                //XtraMessageBox.Show(exception.Source + exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw exception;
            }
        }

        public static void AddParameterForObject(object obj, DALBaseProvider provider, DbCommand cmd, bool bIsIdentityPrimaryKey)
        {
            try
            {
                TableName = provider.TableName;
                string primaryKeyColumn = GetPrimaryKeyColumn(TableName);
                if (cmd.Parameters.Count == 0)
                {
                    PropertyInfo[] properties = provider.ObjectType.GetProperties();
                    for (int i = 0; i < properties.Length; i++)
                    {
                        if (!ColumnIsExistInBaseBusinessObject(properties[i].Name))
                        {
                            object obj2 = DynamicInvoker.DynamicGetValue(obj, properties[i]);
                            if (properties[i].PropertyType.Equals(typeof(int)))
                            {
                                if (properties[i].Name.Equals(primaryKeyColumn))
                                {
                                    if (!bIsIdentityPrimaryKey)
                                    {
                                        GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Int, obj2);
                                    }
                                }
                                else
                                {
                                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Int, obj2);
                                }
                            }
                            else if (properties[i].PropertyType.Equals(typeof(bool)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Bit, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(short)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.SmallInt, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(double)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Float, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(decimal)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Decimal, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(string)) || properties[i].PropertyType.Equals(typeof(string)))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.NVarChar, obj2);
                            }
                            else if (properties[i].PropertyType.Equals(typeof(DateTime)))
                            {
                                if (((DateTime)obj2) != DateTime.MinValue)
                                {
                                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.DateTime, obj2);
                                }
                            }
                            else if (properties[i].PropertyType.Equals(typeof(DateTime?)))
                            {
                                if ((obj2 == null) || (((DateTime)obj2) == DateTime.MinValue))
                                {
                                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.DateTime, null);
                                }
                                else
                                {
                                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.DateTime, obj2);
                                }
                            }
                            else if (properties[i].PropertyType.Equals(typeof(byte[])))
                            {
                                GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.VarBinary, obj2);
                            }
                        }
                    }
                }
                else
                {
                    foreach (DbParameter parameter in cmd.Parameters)
                    {
                        object obj3 = DynamicInvoker.DynamicGetValue(obj, parameter.ParameterName.Replace("@", ""));
                        if (obj3 != parameter.Value)
                        {
                            GMCDatabase.SetParameterValue(cmd, parameter.ParameterName, obj3);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                //XtraMessageBox.Show(exception.Source + exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw exception;
            }
        }

        public static void AddParameterForSearchProperties(object obj, DbCommand cmd)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                object obj2 = properties[i].GetValue(obj, null);
                string name = properties[i].Name;
                if (properties[i].Name.Equals("TopResults"))
                {
                    GMCDatabase.AddInParameter(cmd, name, SqlDbType.Int, obj2);
                }
                else if (properties[i].PropertyType.Equals(typeof(int)))
                {
                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Int, obj2);
                }
                else if (properties[i].PropertyType.Equals(typeof(bool)))
                {
                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Bit, obj2);
                }
                else if (properties[i].PropertyType.Equals(typeof(short)))
                {
                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.SmallInt, obj2);
                }
                else if (properties[i].PropertyType.Equals(typeof(double)))
                {
                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Float, obj2);
                }
                else if (properties[i].PropertyType.Equals(typeof(decimal)))
                {
                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.Decimal, obj2);
                }
                else if (properties[i].PropertyType.Equals(typeof(string)) || properties[i].PropertyType.Equals(typeof(string)))
                {
                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.NVarChar, obj2);
                }
                else if (properties[i].PropertyType.Equals(typeof(DateTime)))
                {
                    if (((DateTime)obj2) != DateTime.MinValue)
                    {
                        GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.DateTime, obj2);
                    }
                }
                else if (properties[i].PropertyType.Equals(typeof(byte[])))
                {
                    GMCDatabase.AddInParameter(cmd, properties[i].Name, SqlDbType.VarBinary, obj2);
                }
            }
        }

        private static void AutoTestConnectionTimer_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (TestConnection())
            {
                //GMCWaitingDialog.Close();
                autoTestConTimer.Enabled = false;
            }
        }

        public static DbTransaction BeginTransaction()
        {
            return GMCDatabase.CreateConnection().BeginTransaction();
        }

        public static void ChangeCompanyConnection(string strCompanyName)
        {
            string connectionStringFromRegistry = GetConnectionStringFromRegistry(strCompanyName);
            _connectionString = connectionStringFromRegistry;
            _companyName = strCompanyName;
            LocalDatabase = new GMCSQLDatabase(connectionStringFromRegistry, strCompanyName);
            CurrentDatabase = LocalDatabase;
        }

        public static void ChangeCompanyConnectionFromWebConfig()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            _connectionString = strConnectionString;
            _companyName = "GMC";
            LocalDatabase = new GMCSQLDatabase(strConnectionString, _companyName);
            CurrentDatabase = LocalDatabase;
        }

        private static bool ColumnIsExistInBaseBusinessObject(string strPropertyName)
        {
            if (BusinessObjectPropertyList.Count <= 0)
            {
                PropertyInfo[] properties = typeof(BusinessObject).GetProperties();
                BusinessObjectPropertyList = properties.ToDictionary<PropertyInfo, string>(info => info.Name);
            }
            return BusinessObjectPropertyList.ContainsKey(strPropertyName);
        }

        public static bool ColumnIsExistInTable(string strTableName, string strColumnName)
        {
            try
            {
                TableName = strTableName;
                object[] parameterValues = new object[] { strTableName, strColumnName };
                DataSet set = GMCDatabase.ExecuteDataSet("GEDBUtil_SelectTableColumn", parameterValues);
                return ((set.Tables.Count > 0) && (set.Tables[0].Rows.Count > 0));
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return true;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return true;
            }
        }

        public static bool ColumnIsForeignKey(string strTableName, string strColumnName)
        {
            try
            {
                TableName = strTableName;
                object[] parameterValues = new object[] { strTableName, strColumnName };
                DataSet set = GMCDatabase.ExecuteDataSet("GEDBUtil_SelectTableForeignKey", parameterValues);
                return (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0));
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return true;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return true;
            }
        }

        public static bool ColumnIsPrimaryKey(string strTableName, string strColumnName)
        {
            try
            {
                TableName = strTableName;
                object[] parameterValues = new object[] { strColumnName };
                DataSet set = GMCDatabase.ExecuteDataSet("GEDBUtil_SelectTablePrimaryKey", parameterValues);
                return (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0));
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return false;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return false;
            }
        }

        public static void CommitTransaction(DbTransaction transaction)
        {
            transaction.Commit();
        }

        public static string ExecuteStoredProcedureScript(string strStoredProcedureScript)
        {
            try
            {
                GMCDatabase.ExecuteNonQuery(CommandType.Text, strStoredProcedureScript);
                return "Command excute succesfully!";
            }
            catch (Exception exception)
            {
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                return exception.Message;
            }
        }

        public static DataSet GetAllTableColumns(string strTableName)
        {
            try
            {
                object[] parameterValues = new object[] { strTableName };
                return GMCDatabase.ExecuteDataSet("GEDBUtil_SelectTableColumns", parameterValues);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return null;
            }
        }

        public static Dictionary<string, string> GetAllTablePrimaryColumns()
        {
            try
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                DbCommand query = GetQuery("SELECT tc.TABLE_NAME,kcu.COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE kcu,INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc WHERE" + "(kcu.TABLE_NAME IN (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES\tWHERE(TABLE_TYPE='BASE TABLE')AND(TABLE_NAME<>'sysdiagrams')))" + " AND(kcu.CONSTRAINT_NAME=tc.CONSTRAINT_NAME)AND(tc.CONSTRAINT_TYPE='PRIMARY KEY')");
                query.CommandTimeout = 150;
                DataSet set = RunQuery(query);
                if ((set != null) && (set.Tables.Count > 0))
                {
                    return set.Tables[0].Rows.Cast<DataRow>().ToDictionary(dr => dr["TABLE_NAME"].ToString(), dr => dr["COLUMN_NAME"].ToString());
                    //foreach (DataRow row in set.Tables[0].Rows)
                    //{
                    //    string key = row["TABLE_NAME"].ToString();
                    //    string str3 = row["COLUMN_NAME"].ToString();
                    //    dictionary.Add(key, str3);
                    //}
                }
                return dictionary;
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return null;
            }
        }

        public static string GetConnectionStringFromRegistry()
        {
            RegistryWorker worker = new RegistryWorker
            {
                SubKey = @"SOFTWARE\GMC"
            };
            worker.SubKey = worker.SubKey + @"\ConnectionString";
            string str2 = worker.Read("Database");
            string str3 = worker.Read("Server");
            string str4 = worker.Read("User");
            string inputText = worker.Read("Password");
            inputText = new Crypto().Decrypt(inputText);
            return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", new object[] { str3, str2, str4, inputText });
        }

        public static string GetConnectionStringFromRegistry(string strCompanyName)
        {
            _companyName = strCompanyName;
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
            string str2 = worker.Read("Server");
            string str3 = worker.Read("User");
            string inputText = worker.Read("Password");
            inputText = new Crypto().Decrypt(inputText);
            return string.Format("Application Name={4};Data Source={0};Initial Catalog={1};User ID={2};Password={3}", new object[] { str2, str, str3, inputText, Application.ProductName });
        }

        public static int GetMaxID(string tableName)
        {
            TableName = tableName;
            DbCommand sqlStringCommand = null;
            if (!MaxIDDbCommandList.TryGetValue(tableName, out sqlStringCommand))
            {
                string query = string.Format("SELECT Max({0}) AS MaxID FROM [{1}]", GetPrimaryKeyColumn(tableName), tableName);
                sqlStringCommand = GMCDatabase.GetSqlStringCommand(query);
                sqlStringCommand.CommandTimeout = 150;
                MaxIDDbCommandList.Add(tableName, sqlStringCommand);
            }
            DataSet set = GMCDatabase.ExecuteDataSet(sqlStringCommand);
            if ((set != null) && (set.Tables.Count > 0))
            {
                if (set.Tables[0].Rows[0][0] == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToInt32(set.Tables[0].Rows[0][0]);
            }
            return -1;
        }

        public static DataSet GetObjectbyId(string tableName, int id)
        {
            try
            {
                TableName = tableName;
                string query = string.Format("Select * From {0} where {1} = {2}", GetPrimaryKeyColumn(tableName), id);
                DbCommand sqlStringCommand = GMCDatabase.GetSqlStringCommand(query);
                sqlStringCommand.CommandTimeout = 150;
                return GMCDatabase.ExecuteDataSet(sqlStringCommand);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return null;
            }
        }

        public static ArrayList GetObjectCollection(DataTable dt, Type type, string tableName)
        {
            PropertyInfo[] properties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public);
            ArrayList list = new ArrayList();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(GetObjectFromDataRow(row, type));
            }
            return list;
        }

        public static object GetObjectFromDataRow(DataRow row, Type type)
        {
            Dictionary<string, PropertyInfo> dictionary;
            ColumnPropertyList.TryGetValue(type.FullName, out dictionary);
            if (dictionary == null)
            {
                dictionary = new Dictionary<string, PropertyInfo>();
                try
                {
                    ColumnPropertyList.Add(type.FullName, dictionary);
                }
                catch (Exception)
                {
                    //XtraMessageBox.Show(type.FullName);
                }
            }
            object obj2 = DynamicInvoker.DynamicCreateInstanceObject(type);
            foreach (DataColumn column in row.Table.Columns)
            {
                object obj3 = row[column];
                if (obj3 != DBNull.Value)
                {
                    PropertyInfo property = null;
                    dictionary.TryGetValue(column.ColumnName, out property);
                    if (property == null)
                    {
                        property = type.GetProperty(column.ColumnName);
                        if (property != null)
                        {
                            dictionary.Add(column.ColumnName, property);
                        }
                    }
                    if (property != null)
                    {
                        DynamicInvoker.DynamicSetValue(obj2, property, obj3);
                    }
                }
            }
            return obj2;
        }

        public static string[] GetParameters(string strQueryCommand)
        {
            string[] array = new string[0];
            string whereClause = GetWhereClause(strQueryCommand);
            if (!string.IsNullOrEmpty(whereClause))
            {
                do
                {
                    whereClause = whereClause.Substring(whereClause.IndexOf("@"));
                    string str2 = whereClause.Substring(1, whereClause.IndexOf(")") - 1);
                    Array.Resize<string>(ref array, array.Length + 1);
                    array[array.Length - 1] = str2;
                    whereClause = whereClause.Substring(str2.Length + 1);
                    if (whereClause.StartsWith(")"))
                    {
                        whereClause = whereClause.Substring(1);
                    }
                }
                while (whereClause.Contains("@"));
                return array;
            }
            return null;
        }

        public static object GetPrimaryColumnValue(object obj, DALBaseProvider provider)
        {
            TableName = provider.TableName;
            string primaryKeyColumn = GetPrimaryKeyColumn(provider.TableName);
            return provider.ObjectType.GetProperty(primaryKeyColumn).GetValue(obj, null);
        }

        public static string GetPrimaryKeyColumn(string strTableName)
        {
            if (!strTableName.EndsWith("s"))
            {
                return (strTableName + "ID");
            }
            if ((strTableName == "STModuleStatus") || (strTableName == "AAColumnAlias"))
            {
                return (strTableName + "ID");
            }
            if (strTableName.EndsWith("ies"))
            {
                return (strTableName.Substring(0, strTableName.Length - 3) + "yID");
            }
            return (strTableName.Substring(0, strTableName.Length - 1) + "ID");
        }

        public static DbCommand GetQuery(string strQueryCommand)
        {
            DbCommand sqlStringCommand = GMCDatabase.GetSqlStringCommand(strQueryCommand);
            sqlStringCommand.CommandTimeout = 150;
            return sqlStringCommand;
        }

        public static DbCommand GetQuery(string strTableName, string strTableQueryKey, string strQueryCommand)
        {
            TableName = strTableName;
            string queryCommandByTableNameAndTableQueryKey = GetQueryCommandByTableNameAndTableQueryKey(strTableName, strTableQueryKey);
            DbCommand sqlStringCommand = null;
            if (string.IsNullOrEmpty(queryCommandByTableNameAndTableQueryKey))
            {
                InsertQueryCommand(strQueryCommand, strTableName, strTableQueryKey);
                sqlStringCommand = GMCDatabase.GetSqlStringCommand(strQueryCommand);
            }
            else
            {
                sqlStringCommand = GMCDatabase.GetSqlStringCommand(queryCommandByTableNameAndTableQueryKey);
            }
            sqlStringCommand.CommandTimeout = 150;
            return sqlStringCommand;
        }

        public static string GetQueryCommandByTableNameAndTableQueryKey(string strTableName, string strTableQueryKey)
        {
            try
            {
                TableName = strTableName;
                string str = string.Empty;
                DataSet set = RunQuery(GetQuery(string.Format("SELECT * FROM [dbo].[STTableQueries] WHERE ([STTableQueryTableName]='{0}')AND([STTableQueryKey]='{1}')", strTableName, strTableQueryKey)));
                if ((set.Tables.Count > 0) && (set.Tables[0].Rows.Count > 0))
                {
                    str = set.Tables[0].Rows[0]["STTableQueryCommand"].ToString();
                }
                return str;
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return null;
            }
        }
        public static DateTime GetServerDateTime()
        {
            DataSet set = RunQuery(GetQuery(string.Format("SELECT GetDate()")));
            if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
            {
                return Convert.ToDateTime(set.Tables[0].Rows[0][0]);
            }
            return DateTime.Now;
        }
        public static object GetSingleObject(DataTable dt, Type type)
        {
            try
            {
                if (dt.Rows.Count <= 0)
                {
                    return null;
                }
                object objectFromDataRow = new object();
                if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                {
                    objectFromDataRow = GetObjectFromDataRow(dt.Rows[1], type);
                }
                else
                {
                    objectFromDataRow = GetObjectFromDataRow(dt.Rows[0], type);
                }
                return objectFromDataRow;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DbCommand GetStoredProcCommand(string strStoredProName)
        {
            DbCommand storedProcCommand = null;
            storedProcCommand = GMCDatabase.GetStoredProcCommand(strStoredProName);
            storedProcCommand.CommandTimeout = 150;
            return storedProcCommand;
        }

        public static DbCommand GetStoredProcedure(string spName)
        {
            try
            {
                DbCommand storedProcCommand = GMCDatabase.GetStoredProcCommand(spName);
                storedProcCommand.CommandTimeout = 150;
                return storedProcCommand;
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }
        }

        private static string GetWhereClause(string strQueryCommand)
        {
            if (strQueryCommand.Contains("WHERE"))
            {
                return strQueryCommand.Substring(strQueryCommand.IndexOf("WHERE"));
            }
            return string.Empty;
        }

        private static void GMCWaitingDialog_StopDialogEvent()
        {
            Process.GetCurrentProcess().Kill();
        }

        public static int InsertObject(object obj, DALBaseProvider provider, string spName)
        {
            try
            {
                TableName = provider.TableName;
                DbCommand storedProcCommand = GetStoredProcCommand(spName);
                AddParameterForObject(obj, provider, storedProcCommand);
                GMCDatabase.ExecuteNonQuery(storedProcCommand);
                return (int)GMCDatabase.GetParameterValue(storedProcCommand, GetPrimaryKeyColumn(provider.TableName));
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return 0;
                }
                if (Transaction.Current != null)
                {
                    throw new Exception("Failed to Insert Object - " + exception.Message);
                }
                //XtraMessageBox.Show(exception.Source + exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }
        }

        public static int InsertObject(object obj, DALBaseProvider provider, bool bIsIdentityPrimaryKey, string spName)
        {
            try
            {
                TableName = provider.TableName;
                DbCommand storedProcCommand = GetStoredProcCommand(spName);
                AddParameterForObject(obj, provider, storedProcCommand, bIsIdentityPrimaryKey);
                DataSet set = GMCDatabase.ExecuteDataSet(storedProcCommand);
                int num = 0;
                if (((set != null) && (set.Tables.Count > 0)) && ((set.Tables[0].Rows.Count > 0) && (set.Tables[0].Rows[0][0] != DBNull.Value)))
                {
                    try
                    {
                        num = Convert.ToInt32(set.Tables[0].Rows[0][0]);
                    }
                    catch (Exception)
                    {
                        num = 0;
                    }
                }
                return num;
            }
            catch (Exception exception2)
            {
                if ((exception2 is SqlException) && ((((SqlException)exception2).ErrorCode == -2146232060) && exception2.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception2;
                    }
                    return 0;
                }
                if (Transaction.Current != null)
                {
                    throw new Exception("Failed to Insert Object - " + exception2.Message);
                }
                //XtraMessageBox.Show(exception2.Source + exception2.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }
        }

        public static int InsertObject(object obj, DALBaseProvider provider, string spName, DbTransaction transaction)
        {
            try
            {
                TableName = provider.TableName;
                DbCommand storedProcCommand = GetStoredProcCommand(spName);
                AddParameterForObject(obj, provider, storedProcCommand);
                storedProcCommand.Transaction = transaction;
                GMCDatabase.ExecuteNonQuery(storedProcCommand, transaction);
                transaction.Commit();
                return (int)GMCDatabase.GetParameterValue(storedProcCommand, GetPrimaryKeyColumn(provider.TableName));
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    transaction.Rollback();
                    return 0;
                }
                transaction.Rollback();
                //XtraMessageBox.Show(exception.Source + exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return 0;
            }
        }

        public static void InsertQueryCommand(string strQueryCommand, string strTableName, string strQueryKey)
        {
            try
            {
                TableName = strTableName;
                DbCommand query = GetQuery(string.Format("INSERT INTO [dbo].[STTableQueries] ([STTableQueryID],[STTableQueryTableName],[STTableQueryKey],[STTableQueryCommand]) VALUES({0},'{1}','{2}','{3}')", new object[] { GetMaxID("STTableQueries") + 1, strTableName, strQueryKey, strQueryCommand }));
                GMCDatabase.ExecuteNonQuery(query);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                }
                else
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    //XtraMessageBox.Show(exception.Message);
                }
            }
        }

        public static bool IsColumnAllowNull(string strTableName, string strColumnName)
        {
            try
            {
                TableName = strTableName;
                object[] parameterValues = new object[] { strTableName, strColumnName };
                DataSet set = GMCDatabase.ExecuteDataSet("GEDBUtil_SelectTableColumn", parameterValues);
                if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
                {
                    return (set.Tables[0].Rows[0]["IS_NULLABLE"].ToString() == "YES");
                }
                return true;
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return false;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return false;
            }
        }

        public static bool IsPKIdentity(string tableName)
        {
            TableName = tableName;
            bool flag = false;
            try
            {
                if (IsPKIdentityList.TryGetValue(tableName, out flag))
                {
                    return flag;
                }
                string query = string.Format("\r\n    IF COLUMNPROPERTY(OBJECT_ID(N'[dbo].[{0}]'), '{1}','IsIdentity') = 1\r\n        SELECT 1\r\n    ", tableName, GetPrimaryKeyColumn(tableName));
                DbCommand sqlStringCommand = GMCDatabase.GetSqlStringCommand(query);
                sqlStringCommand.CommandTimeout = 150;
                DataSet set = GMCDatabase.ExecuteDataSet(sqlStringCommand);
                if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
                {
                    flag = true;
                }
                IsPKIdentityList.Add(tableName, flag);
            }
            catch (Exception)
            {
            }
            return flag;
        }

        public static void RollbackToLocalConnection()
        {
            CurrentDatabase = LocalDatabase;
        }

        public static void RollbackTransaction(DbTransaction transaction)
        {
            transaction.Rollback();
        }

        public static DataSet RunQuery(DbCommand cmd)
        {
            try
            {
                cmd.CommandTimeout = 150;
                return GMCDatabase.ExecuteDataSet(cmd);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return null;
            }
        }

        public static DataSet RunQuery(string strTableName, string strQueryCommandKey, string strQueryCommand, params object[] paramValues)
        {
            TableName = strTableName;
            DbCommand command = GetQuery(strTableName, strQueryCommandKey, strQueryCommand);
            string[] parameters = GetParameters(strQueryCommand);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (paramValues[i].GetType().Equals(typeof(int)))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.Int, paramValues[i]);
                    }
                    else if (paramValues[i].GetType().Equals(typeof(bool)))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.Bit, paramValues[i]);
                    }
                    else if (paramValues[i].GetType().Equals(typeof(short)))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.SmallInt, paramValues[i]);
                    }
                    else if (paramValues[i].GetType().Equals(typeof(double)))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.Float, paramValues[i]);
                    }
                    else if (paramValues[i].GetType().Equals(typeof(decimal)))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.Decimal, paramValues[i]);
                    }
                    else if (paramValues[i].GetType().Equals(typeof(string)) || paramValues[i].GetType().Equals(typeof(string)))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.NVarChar, paramValues[i]);
                    }
                    else if (paramValues[i].GetType().Equals(typeof(DateTime)))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.DateTime, paramValues[i]);
                    }
                    else if (paramValues[i].GetType().Equals(typeof(byte[])))
                    {
                        GMCDatabase.AddInParameter(command, parameters[i], SqlDbType.VarBinary, paramValues[i]);
                    }
                }
            }
            return RunQuery(command);
        }

        public static int RunQueryNonDataSet(DbCommand cmd)
        {
            try
            {
                cmd.CommandTimeout = 150;
                return GMCDatabase.ExecuteNonQuery(cmd);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return 0;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message);
                return 0;
            }
        }

        public static DataSet RunStoredProcedure(DbCommand cmd)
        {
            try
            {
                cmd.CommandTimeout = 150;
                return GMCDatabase.ExecuteDataSet(cmd);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                return null;
            }
        }

        public static DataSet RunStoredProcedure(string spName)
        {
            try
            {
                DbCommand storedProcCommand = GetStoredProcCommand(spName);
                return GMCDatabase.ExecuteDataSet(storedProcCommand);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }
        }

        public static DataSet RunStoredProcedure(string spName, params object[] values)
        {
            try
            {
                DbCommand storedProcCommand = GMCDatabase.GetStoredProcCommand(spName, values);
                storedProcCommand.CommandTimeout = 150;
                return GMCDatabase.ExecuteDataSet(storedProcCommand);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }
        }

        public static object RunStoreProcedure(DbCommand cmd, string retVariable)
        {
            try
            {
                cmd.CommandTimeout = 150;
                GMCDatabase.ExecuteNonQuery(cmd);
                return GMCDatabase.GetParameterValue(cmd, retVariable);
            }
            catch (Exception exception)
            {
                if ((exception is SqlException) && ((((SqlException)exception).ErrorCode == -2146232060) && exception.Message.Contains("TCP Provider")))
                {
                    if (Transaction.Current != null)
                    {
                        throw exception;
                    }
                    return null;
                }
                if (Transaction.Current != null)
                {
                    throw exception;
                }
                //XtraMessageBox.Show(exception.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }
        }

        public static void SetValueToIDStringColumn(object obj, DALBaseProvider provider, int iObjectID)
        {
            TableName = provider.TableName;
            string primaryKeyColumn = GetPrimaryKeyColumn(provider.TableName);
            PropertyInfo property = provider.ObjectType.GetProperty(primaryKeyColumn + "String");
            if (property != null)
            {
                property.SetValue(obj, iObjectID.ToString(), null);
            }
        }

        public static void SetValueToPrimaryColumn(object obj, DALBaseProvider provider, int iObjectID)
        {
            TableName = provider.TableName;
            string primaryKeyColumn = GetPrimaryKeyColumn(provider.TableName);
            provider.ObjectType.GetProperty(primaryKeyColumn).SetValue(obj, iObjectID, null);
        }

        public static void ShowDisconnectWaitingDialog()
        {
            //GMCWaitingDialog.Caption = "Waiting or pressing ESC to exit application.";
            //GMCWaitingDialog.Title = "Disconnect to server....";
            try
            {
                //GMCWaitingDialog.CleanStopEventHandler();
                //GMCWaitingDialog.StopDialogEvent += new GMCWaitingDialog.StopDialogDelegate(SqlDatabaseHelper.GMCWaitingDialog_StopDialogEvent);
            }
            catch (Exception)
            {
            }
            //GMCWaitingDialog.Show(null);
            Application.DoEvents();
            if (autoTestConTimer == null)
            {
                autoTestConTimer = new System.Windows.Forms.Timer();
                autoTestConTimer.Tick += new EventHandler(SqlDatabaseHelper.AutoTestConnectionTimer_Tick);
                autoTestConTimer.Interval = 0xbb8;
            }
            autoTestConTimer.Enabled = true;
        }

        public static void SwitchConnection(string strConnectionString)
        {
            if (!GMCDatabaseCollection.ContainsKey(strConnectionString))
            {
                GMCSQLDatabase database = new GMCSQLDatabase(strConnectionString);
                if (database != null)
                {
                    GMCDatabaseCollection.Add(strConnectionString, database);
                }
                else
                {
                    CurrentDatabase = LocalDatabase;
                    return;
                }
            }
            CurrentDatabase = (GMCSQLDatabase)GMCDatabaseCollection[strConnectionString];
        }

        public static bool TestConnection()
        {
            try
            {
                TableName = "CSCompanys";
                string query = "Select * From [CSCompanys]";
                DbCommand sqlStringCommand = GMCDatabase.GetSqlStringCommand(query);
                GMCDatabase.ExecuteDataSet(sqlStringCommand);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static SqlDatabase GMCDatabase
        {
            get
            {
                return CurrentDatabase;
            }
        }

        public static Dictionary<string, string> PrimaryColumnsList
        {
            get
            {
                return lstPrimaryColumns;
            }
        }

        public static Dictionary<string, DataSet> ForeignColumnsList
        {
            get
            {
                return lstForeignColumns;
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
            }
        }
    }
}
