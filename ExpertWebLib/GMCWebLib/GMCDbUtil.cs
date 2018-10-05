using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExpertWebLib
{
    public class GMCDbUtil : BaseBusinessController
    {
        private static readonly string spGetAllTables = "GEDBUtil_SelectAllTables";
        private static readonly string spGetTableByName = "GEDBUtil_SelectTableByName";
        private static readonly string spGetTableColumns = "GEDBUtil_SelectTableColumns";
        private static readonly string spGetColumnsByTableNameAndColumnNameBeginWith = "GEDBUtil_SelectColumnsByTableNameAndColumnNameBeginWith";
        private static readonly string spGetNotAllowNullTableColumns = "GEDBUtil_SelectNotAllowNullTableColumns";
        private static readonly string spGetAllowNullTableColumn = "GEDBUtil_SelectAllowNullTableColumn";
        private static readonly string spGetTableHaveMCode = "GEDBUtil_SelectTableHaveMCode";
        private static readonly string spGetMCodeColumnsFromTable = "GEDBUtil_SelectMCodeColumnsFromTable";
        private static readonly string spGetTableKeyColumns = "GEDBUtil_SelectTableKeyColumns";
        private static readonly string spGetTableForeignKeys = "GEDBUtil_SelectTableForeignKeys";
        private static readonly string spGetTablePrimaryKeys = "GEDBUtil_SelectTablePrimaryKeys";
        private static readonly string spGetTableForeignKey = "GEDBUtil_SelectTableForeignKey";
        private static readonly string spGetTablePrimaryKey = "GEDBUtil_SelectTablePrimaryKey";
        private static readonly string spGetTableUniqueContraint = "GEDBUtil_SelectTableUniqueConstraint";
        private static readonly string spGetPrimaryTableAndColumnWhichForeignColumnReferenceTo = "GEDBUtil_SelectPrimaryTableAndColumnWhichForeignColumnReferenceTo";
        private static readonly string spGetTableColumn = "GEDBUtil_SelectTableColumn";
        private static readonly string spGetSaveStatusInSessionColumn = "GEDBUtil_SelectSaveStatusInSessionColumn";
        private static readonly string spGetAllStoredProcedures = "GEDBUtil_SelectAllStoredProcedures";
        private static readonly string spGetStoredProcedureByTableName = "GEDBUtil_SelectStoredProcedureByTableName";
        private static readonly string spGetStoredProcedureByName = "GEDBUtil_SelectStoredProcedureByName";
        private static readonly string spGetStoredProcedureTextByID = "GEDBUtil_SelectStoredProcedureTextByID";
        private static readonly string spGetStoredProcedureTextByStoredProcedureName = "GEDBUtil_SelectStoredProcedureTextByStoredProcedureName";
        private static readonly string spGetColumnDescriptionByTableNameAndColumnName = "GEDBUtil_SelectColumnDescriptionByTableNameAndColumnName";
        private static readonly string spGetAllViews = "GEDBUtil_SelectAllViews";
        private static readonly string spGetViewTextByViewName = "GEDBUtil_SelectViewTextByViewName";
        private static readonly string spGetViewColumns = "GEDBUtil_SelectViewColumns";
        private static readonly string spGetViewColumn = "GEDBUtil_SelectViewColumn";
        private static readonly string spGetForeignColumnByPrimaryTableAndForeignTable = "GEDBUtil_SelectForeignColumnByPrimaryTableAndForeignTable";

        public GMCDbUtil()
        {
            base.dal = new DALBaseProvider();
        }

        public static bool ColumnIsAllowNull(string strTableName, string strColumnName)
        {
            DataRow tableColumn = GetTableColumn(strTableName, strColumnName);
            if (tableColumn != null)
            {
                return (tableColumn["IS_NULLABLE"].ToString() == "YES");
            }
            return true;
        }

        public static bool ColumnIsExist(string strTableName, string strColumnName)
        {
            return (GetTableColumn(strTableName, strColumnName) != null);
        }

        public static bool ColumnIsExistInBaseBusinessObject(string strPropertyName)
        {
            PropertyInfo[] properties = typeof(BusinessObject).GetProperties();
            foreach (PropertyInfo info in properties)
            {
                if (info.Name.Equals(strPropertyName))
                {
                    return true;
                }
            }
            return false;
        }

        public static void CreateColumnDescription(string strTableName, string strColumnName, string strColumnDescription)
        {
            object[] values = new object[] { "MS_Description", strColumnDescription, "Schema", "dbo", "Table", strTableName, "Column", strColumnName };
            SqlDatabaseHelper.RunStoredProcedure("sp_addextendedproperty", values);
        }

        public static DataSet ExecuteQuery(string strQuery)
        {
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(strQuery));
        }
        public static object ExecuteScalar(string strQuery)
        {
            return SqlDatabaseHelper.GMCDatabase.ExecuteScalar(SqlDatabaseHelper.GetQuery(strQuery));
        }
        public static string ExecuteStoredProcedureScript(string strStoredProcedureScript)
        {
            return SqlDatabaseHelper.ExecuteStoredProcedureScript(strStoredProcedureScript);
        }
        public static object ExecuteStoredProcedure(string spName, params object[] values)
        {
            try
            {
                DbCommand storedProcCommand = SqlDatabaseHelper.GMCDatabase.GetStoredProcCommand(spName, values);
                storedProcCommand.CommandTimeout = 150;
                return SqlDatabaseHelper.GMCDatabase.ExecuteScalar(storedProcCommand);
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
        public static DataSet GetAllowNullTableColumn(string strTableName, string colName)
        {
            object[] values = new object[] { strTableName, colName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetAllowNullTableColumn, values);
        }

        public static DataSet GetAllStoredProcedures()
        {
            return SqlDatabaseHelper.RunStoredProcedure(spGetAllStoredProcedures);
        }

        public static DataSet GetAllTables()
        {
            return SqlDatabaseHelper.RunStoredProcedure(spGetAllTables);
        }

        public static DataSet GetAllViews()
        {
            return SqlDatabaseHelper.RunStoredProcedure(spGetAllViews);
        }

        public static int GetColumnCharacterMaximumLength(string strTableName, string strColumnName)
        {
            int num = 0;
            DataRow tableColumn = GetTableColumn(strTableName, strColumnName);
            if (tableColumn != null)
            {
                switch (tableColumn["DATA_TYPE"].ToString())
                {
                    case "varchar":
                    case "nvarchar":
                        num = Convert.ToInt32(tableColumn["CHARACTER_MAXIMUM_LENGTH"]);
                        break;
                }
            }
            return num;
        }

        public static string GetColumnDataType(string strTableName, string strColumnName)
        {
            string str = string.Empty;
            DataRow tableColumn = GetTableColumn(strTableName, strColumnName);
            if (tableColumn != null)
            {
                str = tableColumn["DATA_TYPE"].ToString();
            }
            return str;
        }

        public static string GetColumnDbType(string strTableName, string strColumnName)
        {
            string str = string.Empty;
            DataRow tableColumn = GetTableColumn(strTableName, strColumnName);
            if (tableColumn != null)
            {
                str = tableColumn["DATA_TYPE"].ToString();
                switch (str)
                {
                    case "varchar":
                    case "nvarchar":
                    case "varbinary":
                        str = str + "(" + tableColumn["CHARACTER_MAXIMUM_LENGTH"].ToString() + ")";
                        break;
                }
            }
            return str;
        }

        public static string GetColumnDescriptionFromTableNameAndColumnName(string strTableName, string strColumName)
        {
            string str = string.Empty;
            object[] values = new object[] { strTableName, strColumName };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetColumnDescriptionByTableNameAndColumnName, values);
            if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
            {
                str = set.Tables[0].Rows[0]["value"].ToString();
            }
            return str;
        }

        public static Type GetCSharpVariableType(string strTableName, string strColumnName)
        {
            return GMCUtil.GetColumnDataType(strTableName, strColumnName);
        }

        public static DataSet GetDataByTableNameAndObjectID(string strTableName, int iObjectID)
        {
            BaseBusinessController controller = new BaseBusinessController();
            string tablePrimaryColumn = GetTablePrimaryColumn(strTableName);
            string strQuery = string.Format("Select * From [{0}] Where [{1}]={2}", strTableName, tablePrimaryColumn, iObjectID);
            return controller.GetDataSet(strQuery);
        }

        public static DataSet GetDataFromTableNameWithTableColumnLikeColumnValue(string strTableName, string strColumnName, string strColumnValue)
        {
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("SELECT * FROM [dbo].[{0}] WHERE [{1}] LIKE '%{2}%' ORDER BY [{1}]", strTableName, strColumnName, strColumnValue)));
        }

        public static string GetForeignColumn(string strPrimaryTable, string strForeignTable)
        {
            string str = string.Empty;
            object[] values = new object[] { strPrimaryTable, strForeignTable };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetForeignColumnByPrimaryTableAndForeignTable, values);
            if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
            {
                str = set.Tables[0].Rows[0][0].ToString();
            }
            return str;
        }

        public static string GetForeignColumnByPrimaryTableAndForeignTable(string strPrimaryTable, string strForeignTable)
        {
            string str = string.Empty;
            DataSet tableForeignKeys = GetTableForeignKeys(strForeignTable);
            if (tableForeignKeys != null)
            {
                foreach (DataRow row in tableForeignKeys.Tables[0].Rows)
                {
                    string strForeignColumnName = row["COLUMN_NAME"].ToString();
                    if (GetPrimaryTableWhichForeignColumnReferenceTo(strForeignTable, strForeignColumnName) == strPrimaryTable)
                    {
                        str = strForeignColumnName;
                    }
                }
            }
            return str;
        }

        public static DateTime GetLastCreatedDateOfTable(string strTableName)
        {
            try
            {
                DateTime minValue = DateTime.MinValue;
                string str = "AACreatedDate";
                DataSet set = SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select MAX([{0}]) From [{1}] WHERE [{2}]<'99991231 23:59:59:000' ", str, strTableName, str)));
                if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
                {
                    minValue = Convert.ToDateTime(set.Tables[0].Rows[0][0]);
                }
                return minValue;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        public static DateTime GetLastUpdatedDateOfTable(string strTableName)
        {
            try
            {
                DateTime minValue = DateTime.MinValue;
                string strColumnName = "AAUpdatedDate";
                if (ColumnIsExist(strTableName, strColumnName))
                {
                    DataSet set = SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select MAX([{0}]) From [{1}] WHERE [{2}]<'99991231 23:59:59:000' ", strColumnName, strTableName, strColumnName)));
                    if ((set.Tables.Count > 0) && (set.Tables[0].Rows.Count > 0))
                    {
                        minValue = Convert.ToDateTime(set.Tables[0].Rows[0][0]);
                    }
                }
                return minValue;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
        }

        public static List<BusinessObject> GetListFromDataset(DataSet ds, Type _type)
        {
            List<BusinessObject> list = new List<BusinessObject>();
            if (((ds != null) && (ds.Tables[0] != null)) && (ds.Tables[0].Rows.Count > 0))
            {
                BaseBusinessController businessController = BusinessControllerFactory.GetBusinessController(GMCUtil.GetTableNameFromBusinessObjectType(_type) + "Controller");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    BusinessObject objectFromDataRow = (BusinessObject)businessController.GetObjectFromDataRow(row);
                    list.Add(objectFromDataRow);
                }
            }
            return list;
        }

        public static List<STModuleTablesInfo> GetListModuleObjectByModuleID(int iSTModuleID)
        {
            STModuleTablesController controller = new STModuleTablesController();
            DataSet tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex = controller.GetTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex(iSTModuleID, 1);
            if ((tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex != null) && (tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex.Tables[0].Rows.Count > 0))
            {
                List<STModuleTablesInfo> list = new List<STModuleTablesInfo>();
                foreach (DataRow row in tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex.Tables[0].Rows)
                {
                    STModuleTablesInfo objectFromDataRow = (STModuleTablesInfo)controller.GetObjectFromDataRow(row);
                    if (objectFromDataRow != null)
                    {
                        list.Add(objectFromDataRow);
                    }
                }
                return list;
            }
            return null;
        }

        public static STModuleTablesInfo GetMainObjectByModuleID(int iSTModuleID)
        {
            STModuleTablesController controller = new STModuleTablesController();
            DataSet tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex = controller.GetTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex(iSTModuleID, 0);
            if ((tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex != null) && (tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex.Tables[0].Rows.Count > 0))
            {
                STModuleTablesInfo objectFromDataRow = (STModuleTablesInfo)controller.GetObjectFromDataRow(tablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex.Tables[0].Rows[0]);
                if (objectFromDataRow != null)
                {
                    return objectFromDataRow;
                }
            }
            return null;
        }

        public static DataSet GetMCodeColumnsFromTable(string strTableName)
        {
            object[] values = new object[] { strTableName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetMCodeColumnsFromTable, values);
        }

        public static string GetNameColumnOfTable(string strTableName)
        {
            string tablePrimaryColumn = GetTablePrimaryColumn(strTableName);
            if (!string.IsNullOrEmpty(tablePrimaryColumn))
            {
                return (tablePrimaryColumn.Substring(0, tablePrimaryColumn.Length - 2) + "Name");
            }
            return string.Empty;
        }

        public static DataSet GetNotAllowNullTableColumns(string strTableName)
        {
            object[] values = new object[] { strTableName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetNotAllowNullTableColumns, values);
        }

        public static string GetPrimaryColumnWhichForeignColumnReferenceTo(string strForeignTableName, string strForeignColumnName)
        {
            string key = strForeignColumnName.Substring(3, strForeignColumnName.Length - 5) + "s";
            if (SqlDatabaseHelper.PrimaryColumnsList.ContainsKey(key))
            {
                return SqlDatabaseHelper.PrimaryColumnsList[key].ToString();
            }
            string str2 = string.Empty;
            object[] values = new object[] { strForeignTableName, strForeignColumnName };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetPrimaryTableAndColumnWhichForeignColumnReferenceTo, values);
            if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
            {
                str2 = set.Tables[0].Rows[0][1].ToString();
            }
            return str2;
        }

        public static string GetPrimaryTableWhichForeignColumnReferenceTo(string strForeignTableName, string strForeignColumnName)
        {
            string key = strForeignColumnName.Substring(3, strForeignColumnName.Length - 5) + "s";
            if (!SqlDatabaseHelper.PrimaryColumnsList.ContainsKey(key))
            {
                key = string.Empty;
                object[] values = new object[] { strForeignTableName, strForeignColumnName };
                DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetPrimaryTableAndColumnWhichForeignColumnReferenceTo, values);
                if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
                {
                    key = set.Tables[0].Rows[0][0].ToString();
                }
            }
            return key;
        }

        public static object GetPropertyValue(BusinessObject obj, string strPropertyName)
        {
            PropertyInfo property = obj.GetType().GetProperty(strPropertyName);
            if (property != null)
            {
                return property.GetValue(obj, null);
            }
            return null;
        }

        public static object GetPropertyValue(object obj, string strPropertyName)
        {
            PropertyInfo property = obj.GetType().GetProperty(strPropertyName);
            if (property != null)
            {
                return property.GetValue(obj, null);
            }
            return null;
        }

        public static DataSet GetStoredProcedureByTableName(string strTableName)
        {
            object[] values = new object[] { strTableName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetStoredProcedureByTableName, values);
        }

        public static string GetStoredProcedureTextByID(int id)
        {
            string str = string.Empty;
            object[] values = new object[] { id };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetStoredProcedureTextByID, values);
            if (set.Tables.Count > 0)
            {
                foreach (DataRow row in set.Tables[0].Rows)
                {
                    str = str + row["text"].ToString();
                }
            }
            return str;
        }

        public static string GetStoredProcedureTextByStoredProcedureName(string strStoredProcedureName)
        {
            string str = string.Empty;
            object[] values = new object[] { strStoredProcedureName };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetStoredProcedureTextByStoredProcedureName, values);
            if ((set != null) && (set.Tables.Count > 0))
            {
                foreach (DataRow row in set.Tables[0].Rows)
                {
                    str = str + row["text"].ToString();
                }
            }
            return str;
        }

        public static DataRow GetTableColumn(string strTableName, string strColumnName)
        {
            if (!SqlDatabaseHelper.TableColumnList.ContainsKey(strTableName))
            {
                GetTableColumns(strTableName);
            }
            if ((SqlDatabaseHelper.TableColumnList[strTableName] != null) && (SqlDatabaseHelper.TableColumnList[strTableName].Tables[0].Rows.Count > 0))
            {
                DataRow[] rowArray = SqlDatabaseHelper.TableColumnList[strTableName].Tables[0].Select(string.Format("[COLUMN_NAME]='{0}'", strColumnName));
                if (rowArray.Length != 0)
                {
                    return rowArray[0];
                }
            }
            return null;
        }

        public static int GetTableColumnCount(string strTableName)
        {
            try
            {
                int count = 0;
                DataSet tableColumns = GetTableColumns(strTableName);
                if (tableColumns != null)
                {
                    count = tableColumns.Tables[0].Rows.Count;
                }
                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static DataSet GetTableColumns(string strTableName)
        {
            DataSet set = SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select [TABLE_NAME],[COLUMN_NAME],[DATA_TYPE],[CHARACTER_MAXIMUM_LENGTH],[IS_NULLABLE] From INFORMATION_SCHEMA.COLUMNS Where [TABLE_NAME]='{0}'", strTableName)));
            if (!SqlDatabaseHelper.TableColumnList.ContainsKey(strTableName))
            {
                SqlDatabaseHelper.TableColumnList.Add(strTableName, set);
            }
            return set;
        }

        public static DataSet GetTableColumnsByTableNameAndColumnBeginWith(string strTableName, string strColumnName)
        {
            object[] values = new object[] { strTableName, strColumnName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetColumnsByTableNameAndColumnNameBeginWith, values);
        }

        public static DataRow GetTableForeignKey(string strTableName, string strColumnName)
        {
            DataSet tableForeignKeys = GetTableForeignKeys(strTableName);
            if ((tableForeignKeys != null) && (tableForeignKeys.Tables[0].Rows.Count > 0))
            {
                DataRow[] rowArray = tableForeignKeys.Tables[0].Select(string.Format("[COLUMN_NAME]='{0}'", strColumnName));
                if (rowArray.Length != 0)
                {
                    return rowArray[0];
                }
            }
            return null;
        }

        public static DataSet GetTableForeignKeys(string strTableName)
        {
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            table.Columns.Add("COLUMN_NAME", typeof(string));
            Type businessObjectType = BusinessObjectFactory.GetBusinessObjectType(strTableName + "Info");
            if (businessObjectType != null)
            {
                foreach (PropertyInfo info in businessObjectType.GetProperties())
                {
                    if (info.Name.StartsWith("FK_"))
                    {
                        DataRow row = table.NewRow();
                        row[0] = info.Name;
                        table.Rows.Add(row);
                    }
                }
            }
            set.Tables.Add(table);
            return set;
        }

        public static DataSet GetTableKeyColumns(string strTableName)
        {
            object[] values = new object[] { strTableName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetTableKeyColumns, values);
        }

        public static string GetTableNameByViewNameAndColumnName(string strViewName, string strColumnName)
        {
            DataSet viewColumn = GetViewColumn(strViewName, strColumnName);
            if (((viewColumn != null) && (viewColumn.Tables.Count > 0)) && (viewColumn.Tables[0].Rows.Count > 0))
            {
                return viewColumn.Tables[0].Rows[0]["TABLE_NAME"].ToString();
            }
            return string.Empty;
        }

        public static string GetTablePrimaryColumn(string strTableName)
        {
            string str = string.Empty;
            if (SqlDatabaseHelper.PrimaryColumnsList.ContainsKey(strTableName))
            {
                return SqlDatabaseHelper.PrimaryColumnsList[strTableName];
            }
            if (!strTableName.EndsWith("s"))
            {
                str = strTableName + "ID";
            }
            else if (((strTableName == "STModuleStatus") || (strTableName == "AAColumnAlias")) || (strTableName == "AATableNameAlias"))
            {
                str = strTableName + "ID";
            }
            else if (strTableName.EndsWith("ies"))
            {
                str = strTableName.Substring(0, strTableName.Length - 3) + "yID";
            }
            else
            {
                str = strTableName.Substring(0, strTableName.Length - 1) + "ID";
            }
            SqlDatabaseHelper.PrimaryColumnsList.Add(strTableName, str);
            return str;
        }

        public static DataSet GetTablePrimaryKeys(string strTableName)
        {
            object[] values = new object[] { strTableName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetTablePrimaryKeys, values);
        }

        public static DataSet GetTablesHaveMCode()
        {
            return SqlDatabaseHelper.RunStoredProcedure(spGetTableHaveMCode);
        }

        public static DataSet GetTableUniqueConstraint(string strTableName)
        {
            object[] values = new object[] { strTableName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetTableUniqueContraint, values);
        }

        public static DataSet GetViewColumn(string strViewName, string strColumnName)
        {
            object[] values = new object[] { strViewName, strColumnName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetViewColumn, values);
        }

        public static DataSet GetViewColumns(string strViewName)
        {
            object[] values = new object[] { strViewName };
            return SqlDatabaseHelper.RunStoredProcedure(spGetViewColumns, values);
        }

        public static string GetViewTextByViewName(string strViewName)
        {
            string str = string.Empty;
            object[] values = new object[] { strViewName };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetViewTextByViewName, values);
            if ((set != null) && (set.Tables.Count > 0))
            {
                foreach (DataRow row in set.Tables[0].Rows)
                {
                    str = str + row["text"].ToString();
                }
            }
            return str;
        }

        public static bool IsExistReport(string strReportName)
        {
            bool flag = false;
            STRptsInfo objectByName = (STRptsInfo)new STRptsController().GetObjectByName(strReportName);
            if (objectByName != null)
            {
                flag = true;
            }
            return flag;
        }

        public static bool IsExistTable(string strTableName)
        {
            bool flag = false;
            object[] values = new object[] { strTableName };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetTableByName, values);
            if (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0))
            {
                flag = true;
            }
            return flag;
        }

        public static bool IsForeignKey(string strTableName, string strColumnName)
        {
            return strColumnName.StartsWith("FK_");
        }

        public static bool IsPrimaryKey(string strTableName, string strColumnName)
        {
            return GetTablePrimaryColumn(strTableName).ToUpper().Equals(strColumnName.ToUpper());
        }

        public static void SetPropertyValue(BusinessObject obj, string strPropertyName, object value)
        {
            PropertyInfo property = obj.GetType().GetProperty(strPropertyName);
            if (property != null)
            {
                property.SetValue(obj, value, null);
            }
        }

        public static void SetPropertyValue(object obj, string strPropertyName, object value)
        {
            PropertyInfo property = obj.GetType().GetProperty(strPropertyName);
            if (property != null)
            {
                property.SetValue(obj, value, null);
            }
        }

        public static bool StoredProcedureIsExist(string strStoredProcedureName)
        {
            object[] values = new object[] { strStoredProcedureName };
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spGetStoredProcedureByName, values);
            return (((set != null) && (set.Tables.Count > 0)) && (set.Tables[0].Rows.Count > 0));
        }

        public static void UpdateColumnDescription(string strTableName, string strColumnName, string strColumnDescription)
        {
            object[] values = new object[] { "MS_Description", strColumnDescription, "Schema", "dbo", "Table", strTableName, "Column", strColumnName };
            SqlDatabaseHelper.RunStoredProcedure("sp_updateextendedproperty", values);
        }
    }
}
