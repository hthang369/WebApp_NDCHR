using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace ExpertWebLib
{
    public class DALBaseProvider
    {
        protected string _tableName;
        protected Type _objectType;

        public DALBaseProvider()
        {
        }

        public DALBaseProvider(string strTableName, Type objType)
        {
            this._tableName = strTableName;
            this._objectType = objType;
        }

        public DbTransaction BeginTransaction()
        {
            return SqlDatabaseHelper.BeginTransaction();
        }

        public void CommitTransaction(DbTransaction transaction)
        {
            SqlDatabaseHelper.CommitTransaction(transaction);
        }

        public virtual int CreateObject(object obj)
        {
            if (SqlDatabaseHelper.IsPKIdentity(this.TableName))
            {
                return this.CreateObject(obj, true);
            }
            DateTime now = DateTime.Now;
            GMCDbUtil.SetPropertyValue(obj, "AACreatedDate", now);
            GMCDbUtil.SetPropertyValue(obj, "AAUpdatedDate", now);
            return SqlDatabaseHelper.InsertObject(obj, this, this.GenerateInsertStoredProcedureName());
        }

        public virtual int CreateObject(object obj, bool bIsIdentityPrimaryKey)
        {
            DateTime now = DateTime.Now;
            GMCDbUtil.SetPropertyValue(obj, "AACreatedDate", now);
            GMCDbUtil.SetPropertyValue(obj, "AAUpdatedDate", now);
            return SqlDatabaseHelper.InsertObject(obj, this, bIsIdentityPrimaryKey, this.GenerateInsertStoredProcedureName());
        }

        public virtual int CreateObject(object obj, DbTransaction transaction)
        {
            DateTime now = DateTime.Now;
            GMCDbUtil.SetPropertyValue(obj, "AACreatedDate", now);
            GMCDbUtil.SetPropertyValue(obj, "AAUpdatedDate", now);
            return SqlDatabaseHelper.InsertObject(obj, this, this.GenerateInsertStoredProcedureName(), transaction);
        }

        public virtual void DeleteAllObjects()
        {
            SqlDatabaseHelper.TableName = this.TableName;
            SqlDatabaseHelper.RunStoredProcedure(this.GenerateDeleteAllStoredProcedureName());
        }

        public void DeleteAllObjectsByObjectParentID(int iObjectParentID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName);
            string strColumnName = "FK_" + primaryKeyColumn.Substring(0, primaryKeyColumn.Length - 2) + "ParentID";
            if (SqlDatabaseHelper.ColumnIsExistInTable(this.TableName, strColumnName))
            {
                SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Delete From [{0}] Where ([{1}]={2}) And ({2}>0)", this.TableName, strColumnName, iObjectParentID)));
            }
        }

        public virtual void DeleteByForeignColumn(string strForeignColumn, object objValue)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            object[] values = new object[] { objValue };
            SqlDatabaseHelper.RunStoredProcedure(this.GenerateDeleteByForeignColumnStoredProcedureName(strForeignColumn), values);
        }

        public DataSet DeleteMembersFromOwner(string strOwnerTable, int iOwnerID, string strMemberTable, string strSwitcherTable)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strOwnerTable);
            string str2 = SqlDatabaseHelper.GetPrimaryKeyColumn(strSwitcherTable);
            string str3 = SqlDatabaseHelper.GetPrimaryKeyColumn(strMemberTable);
            string str4 = string.Format("Select [{0}] From [{1}] Where [{1}].[{2}] IN (Select [{2}] From [{3}] Where [{3}].[{2}]={4}))", new object[] { str3, strSwitcherTable, primaryKeyColumn, strOwnerTable, iOwnerID });
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Detete From [{0}] Where [{1}] IN ({2})", strMemberTable, str3, str4)));
        }

        public virtual void DeleteObject(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            DbCommand storedProcedure = SqlDatabaseHelper.GetStoredProcedure(this.GenerateDeleteStoredProcedureName());
            SqlDatabaseHelper.AddInParameter(storedProcedure, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), SqlDbType.Int, iObjectID);
            SqlDatabaseHelper.RunStoredProcedure(storedProcedure);
        }

        public virtual void DeleteObject(int iObjectID, DbTransaction transaction)
        {
            try
            {
                SqlDatabaseHelper.TableName = this.TableName;
                DbCommand storedProcedure = SqlDatabaseHelper.GetStoredProcedure(this.GenerateDeleteStoredProcedureName());
                SqlDatabaseHelper.AddInParameter(storedProcedure, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), SqlDbType.Int, iObjectID);
                storedProcedure.Transaction = transaction;
                SqlDatabaseHelper.RunStoredProcedure(storedProcedure);
                SqlDatabaseHelper.CommitTransaction(transaction);
            }
            catch (Exception)
            {
                SqlDatabaseHelper.RollbackTransaction(transaction);
            }
        }

        private string GenerateDeleteAllObjectsQuery()
        {
            return string.Format("DELETE FROM [dbo].[{0}]", this.TableName);
        }

        private string GenerateDeleteAllStoredProcedureName()
        {
            return string.Format("{0}_DeleteAll", this.TableName);
        }

        private string GenerateDeleteByForeignColumnStoredProcedureName(string strForeignColumn)
        {
            return string.Format("{0}_DeleteBy{1}", this.TableName, strForeignColumn);
        }

        private string GenerateDeleteQuery()
        {
            return string.Format("DELETE FROM [dbo].[{0}] WHERE [{1}]=@{2}", this.TableName, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName));
        }

        private string GenerateDeleteStoredProcedureName()
        {
            return string.Format("{0}_Delete", this.TableName);
        }

        private string GenerateInsertColumnParameters(DataSet dsTableColumns)
        {
            string str = "(";
            for (int i = 0; i < dsTableColumns.Tables[0].Rows.Count; i++)
            {
                if (i == (dsTableColumns.Tables[0].Rows.Count - 1))
                {
                    str = str + "@" + dsTableColumns.Tables[0].Rows[i]["COLUMN_NAME"].ToString() + ")";
                }
                else
                {
                    str = str + "@" + dsTableColumns.Tables[0].Rows[i]["COLUMN_NAME"].ToString() + ",";
                }
            }
            return str;
        }

        private string GenerateInsertColumns(DataSet dsTableColumns)
        {
            string str = "(";
            for (int i = 0; i < dsTableColumns.Tables[0].Rows.Count; i++)
            {
                if (i == (dsTableColumns.Tables[0].Rows.Count - 1))
                {
                    str = str + "[" + dsTableColumns.Tables[0].Rows[i]["COLUMN_NAME"].ToString() + "])";
                }
                else
                {
                    str = str + "[" + dsTableColumns.Tables[0].Rows[i]["COLUMN_NAME"].ToString() + "],";
                }
            }
            return str;
        }

        private string GenerateInsertQuery()
        {
            string str = string.Format("INSERT INTO [dbo].[{0}] ", this.TableName);
            DataSet allTableColumns = SqlDatabaseHelper.GetAllTableColumns(this.TableName);
            if (allTableColumns.Tables.Count > 0)
            {
                str = str + this.GenerateInsertColumns(allTableColumns) + " VALUES " + this.GenerateInsertColumnParameters(allTableColumns);
            }
            return str;
        }

        private string GenerateInsertStoredProcedureName()
        {
            return string.Format("{0}_Insert", this.TableName);
        }

        private string GenerateSearchObjectStoredProcedureName()
        {
            return string.Format("{0}_Search", this.TableName);
        }

        private string GenerateSelectAllAlivesStoredProcedureName()
        {
            return string.Format("{0}_SelectAlive{0}", this.TableName);
        }

        private string GenerateSelectAllProfilesStoredProcedureName()
        {
            return string.Format("{0}_SelectAllProfiles", this.TableName);
        }

        private string GenerateSelectAllQuery()
        {
            return string.Format("SELECT * FROM [dbo].[{0}]", this.TableName);
        }

        private string GenerateSelectAllStoredProcedureName()
        {
            return string.Format("{0}_SelectAll", this.TableName);
        }

        private string GenerateSelectByAANumberIntStoredProcedureName()
        {
            return string.Format("{0}_SelectByAANumberInt", this.TableName);
        }

        private string GenerateSelectByForeignColumnStoredProcedureName(string strForeignColumnName)
        {
            return string.Format("{0}_SelectBy{1}", this.TableName, strForeignColumnName);
        }

        private string GenerateSelectByNameStoredProcedureName()
        {
            return string.Format("{0}_SelectByName", this.TableName);
        }

        private string GenerateSelectByNoStoredProcedureName()
        {
            return string.Format("{0}_SelectByNo", this.TableName);
        }

        private string GenerateSelectByPrimaryKeyQuery()
        {
            return string.Format("SELECT * FROM [dbo].[{0}] WHERE [{1}]=@{2}", this.TableName, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName));
        }

        private string GenerateSelectByPrimaryKeyStoredProcedureName()
        {
            return string.Format("{0}_Select", this.TableName);
        }

        private string GenerateSelectDeletedByPrimayKeyStoredProcedureName()
        {
            return string.Format("{0}_SelectDeletedByID", this.TableName);
        }

        private string GenerateSelectNewObjectInSessionStoredProcedureName()
        {
            return string.Format("{0}_SelectNewInSession", this.TableName);
        }

        private string GenerateUpdateObjectSaveStatusInSessionStoredProcedureName()
        {
            return string.Format("{0}_UpdateSaveStatusInSession", this.TableName);
        }

        private string GenerateUpdateQuery()
        {
            string str = string.Format("UPDATE [dbo].[{0}] SET ", this.TableName);
            DataSet allTableColumns = SqlDatabaseHelper.GetAllTableColumns(this.TableName);
            if (allTableColumns.Tables.Count > 0)
            {
                str = str + this.GenerateUpdateSetStatement(allTableColumns) + " WHERE " + this.GenerateUpdateQueryWhereClause(allTableColumns);
            }
            return str;
        }

        private string GenerateUpdateQueryWhereClause(DataSet dsTableColumns)
        {
            string str = string.Empty;
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName);
            string[] textArray1 = new string[] { str, "[", primaryKeyColumn, "] = @", primaryKeyColumn };
            return string.Concat(textArray1);
        }

        private string GenerateUpdateSetStatement(DataSet dsTableColumns)
        {
            string str = string.Empty;
            for (int i = 0; i < dsTableColumns.Tables[0].Rows.Count; i++)
            {
                string strColumnName = dsTableColumns.Tables[0].Rows[i]["COLUMN_NAME"].ToString();
                if (!SqlDatabaseHelper.ColumnIsPrimaryKey(this.TableName, strColumnName))
                {
                    if (i == (dsTableColumns.Tables[0].Rows.Count - 1))
                    {
                        string[] textArray1 = new string[] { str, "[", strColumnName, "] = @", strColumnName };
                        str = string.Concat(textArray1);
                    }
                    else
                    {
                        string[] textArray2 = new string[] { str, "[", strColumnName, "] = @", strColumnName, "," };
                        str = string.Concat(textArray2);
                    }
                }
            }
            return str;
        }

        private string GenerateUpdateStoredProcedureName()
        {
            return string.Format("{0}_Update", this.TableName);
        }

        public virtual DataSet GetAllAliveObjects()
        {
            SqlDatabaseHelper.TableName = this.TableName;
            return SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectAllAlivesStoredProcedureName());
        }

        public DataSet GetAllDataByForeignColumn(string strForeignColumnName, object objValue)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            object[] values = new object[] { objValue };
            return SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectByForeignColumnStoredProcedureName(strForeignColumnName), values);
        }

        public virtual DataSet GetAllObject()
        {
            SqlDatabaseHelper.TableName = this.TableName;
            return SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectAllStoredProcedureName());
        }

        public DataSet GetAllObjectsByObjectParentID(int iObjectParentID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName);
            string str2 = "FK_" + primaryKeyColumn.Substring(0, primaryKeyColumn.Length - 2) + "ParentID";
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select * From [{0}] Where ([{1}]={2}) And ({2}>0)", this.TableName, str2, iObjectParentID)));
        }

        public virtual DataSet GetAllProfileObjects()
        {
            SqlDatabaseHelper.TableName = this.TableName;
            return SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectAllProfilesStoredProcedureName());
        }

        public virtual DataSet GetAllTemplateObjects()
        {
            SqlDatabaseHelper.TableName = this.TableName;
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select * From [dbo].[{0}] Where [{1}]='Template'", this.TableName, SqlDatabaseHelper.AAStatusColumn)));
        }

        public object GetDataObject(string spName, params object[] paramValues)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            SqlDatabaseHelper.TableName = this.TableName;
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(spName, paramValues);
            if (set != null)
            {
                return this.GetSingleObject(set.Tables[0]);
            }
            return null;
        }

        public DataSet GetDataSet(string strQuery)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(strQuery));
        }

        public DataSet GetDataSet(string spName, params object[] paramValues)
        {
            return SqlDatabaseHelper.RunStoredProcedure(spName, paramValues);
        }

        public virtual DataSet GetDataSetByID(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            DbCommand storedProcedure = SqlDatabaseHelper.GetStoredProcedure(this.GenerateSelectByPrimaryKeyStoredProcedureName());
            SqlDatabaseHelper.AddInParameter(storedProcedure, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), SqlDbType.Int, iObjectID);
            return SqlDatabaseHelper.RunStoredProcedure(storedProcedure);
        }

        public virtual object GetDeletedObjectByID(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            DbCommand storedProcedure = SqlDatabaseHelper.GetStoredProcedure(this.GenerateSelectDeletedByPrimayKeyStoredProcedureName());
            SqlDatabaseHelper.AddInParameter(storedProcedure, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), SqlDbType.Int, iObjectID);
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(storedProcedure);
            if (set.Tables.Count <= 0)
            {
                return null;
            }
            return SqlDatabaseHelper.GetSingleObject(set.Tables[0], this.ObjectType);
        }

        public object GetFirstObject()
        {
            string strQuery = string.Format("Select Top(1) * From [{0}]", this.TableName);
            if (this._objectType.GetProperty("AAStatus") != null)
            {
                strQuery = strQuery + " Where [AAStatus]='Alive'";
            }
            SqlDatabaseHelper.TableName = this.TableName;
            DataSet dataSet = this.GetDataSet(strQuery);
            if (dataSet != null)
            {
                return this.GetSingleObject(dataSet.Tables[0]);
            }
            return null;
        }

        public virtual int GetMaxID()
        {
            return SqlDatabaseHelper.GetMaxID(this.TableName);
        }

        public DataSet GetMembersFromOwner(string strOwnerTable, int iOwnerID, string strMemberTable, string strSwitcherTable)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            string primaryKeyColumn = SqlDatabaseHelper.GetPrimaryKeyColumn(strOwnerTable);
            string str2 = SqlDatabaseHelper.GetPrimaryKeyColumn(strSwitcherTable);
            string str3 = SqlDatabaseHelper.GetPrimaryKeyColumn(strMemberTable);
            string str4 = string.Format("Select [{0}] From [{1}] Where [{1}].[{2}] IN (Select [{2}] From [{3}] Where [{3}].[{2}]={4})", new object[] { str3, strSwitcherTable, primaryKeyColumn, strOwnerTable, iOwnerID });
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select * From [{0}] Where [{1}] IN ({2})", strMemberTable, str3, str4)));
        }

        public DataSet GetNewObjectInSession(string strUserName)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            object[] values = new object[] { strUserName };
            return SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectNewObjectInSessionStoredProcedureName(), values);
        }

        public DataSet GetNewObjectsByAACreatedDate(string strTableName, DateTime dateValue)
        {
            SqlDatabaseHelper.TableName = strTableName;
            string str = "AACreatedDate";
            string str2 = dateValue.ToString("yyyy-MM-dd hh:mm:ss");
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("SELECT * FROM [dbo].{0} WHERE CONVERT(VARCHAR(20), {1}, 120) > CONVERT(VARCHAR(20),'{2}', 120)", strTableName, str, str2)));
        }

        public virtual object GetObjectByAANumberInt(int iAANumberInt)
        {
            try
            {
                SqlDatabaseHelper.TableName = this.TableName;
                object[] values = new object[] { iAANumberInt };
                DataSet set = SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectByAANumberIntStoredProcedureName(), values);
                if (set.Tables.Count > 0)
                {
                    return SqlDatabaseHelper.GetSingleObject(set.Tables[0], this.ObjectType);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public virtual object GetObjectByColumnName(string strColumnName, object objValue)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            string columnDbType = GMCDbUtil.GetColumnDbType(this.TableName, strColumnName);
            string str2 = string.Format("{0}", objValue);
            if ((columnDbType.Contains("varchar") || columnDbType.Contains("nvarchar")) || columnDbType.Contains("ntext"))
            {
                str2 = string.Format("N'{0}'", objValue);
            }
            else if (columnDbType.Contains("date"))
            {
                str2 = string.Format("'{0}'", objValue);
            }
            else if (columnDbType.Contains("int") || columnDbType.Contains("float"))
            {
                str2 = string.Format("{0}", objValue);
            }
            else if (columnDbType.Contains("bit"))
            {
                if (objValue.ToString().Equals("true"))
                {
                    str2 = string.Format("{0}", 1);
                }
                else
                {
                    str2 = string.Format("{0}", 0);
                }
            }
            else if (columnDbType.Contains("varbinary"))
            {
                str2 = string.Format("0X{0}", objValue);
            }
            DataSet set = SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("SELECT * FROM [dbo].[{0}] WHERE ([{1}]={2}) AND ([AAStatus]='Alive')", this.TableName, strColumnName, str2)));
            if (set.Tables.Count <= 0)
            {
                return null;
            }
            return SqlDatabaseHelper.GetSingleObject(set.Tables[0], this.ObjectType);
        }

        public virtual object GetObjectById(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            DbCommand storedProcCommand = SqlDatabaseHelper.GetStoredProcCommand(this.GenerateSelectByPrimaryKeyStoredProcedureName());
            storedProcCommand.Parameters.Clear();
            SqlDatabaseHelper.AddInParameter(storedProcCommand, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), SqlDbType.Int, iObjectID);
            DataSet set = SqlDatabaseHelper.RunStoredProcedure(storedProcCommand);
            if (set == null)
            {
                return null;
            }
            if (set.Tables.Count <= 0)
            {
                return null;
            }
            return SqlDatabaseHelper.GetSingleObject(set.Tables[0], this.ObjectType);
        }

        public virtual object GetObjectByName(string strObjectName)
        {
            try
            {
                SqlDatabaseHelper.TableName = this.TableName;
                object[] values = new object[] { strObjectName };
                DataSet set = SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectByNameStoredProcedureName(), values);
                if (set.Tables.Count > 0)
                {
                    return SqlDatabaseHelper.GetSingleObject(set.Tables[0], this.ObjectType);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public virtual object GetObjectByNo(string strObjectNo)
        {
            try
            {
                SqlDatabaseHelper.TableName = this.TableName;
                object[] values = new object[] { strObjectNo };
                DataSet set = SqlDatabaseHelper.RunStoredProcedure(this.GenerateSelectByNoStoredProcedureName(), values);
                if (set.Tables.Count > 0)
                {
                    return SqlDatabaseHelper.GetSingleObject(set.Tables[0], this.ObjectType);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        public object GetObjectFromDataRow(DataRow row)
        {
            return SqlDatabaseHelper.GetObjectFromDataRow(row, this.ObjectType);
        }

        public virtual int GetObjectIDByName(string strObjectName)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            int num = 0;
            object objectByName = this.GetObjectByName(strObjectName);
            if (objectByName != null)
            {
                num = Convert.ToInt32(SqlDatabaseHelper.GetPrimaryColumnValue(objectByName, this));
            }
            return num;
        }

        public virtual int GetObjectIDByNo(string strObjectNo)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            int num = 0;
            object objectByNo = this.GetObjectByNo(strObjectNo);
            if (objectByNo != null)
            {
                num = Convert.ToInt32(SqlDatabaseHelper.GetPrimaryColumnValue(objectByNo, this));
            }
            return num;
        }

        public virtual string GetObjectNameByID(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            object objectById = this.GetObjectById(iObjectID);
            if (objectById != null)
            {
                string name = SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName).Substring(0, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName).Length - 2) + "Name";
                PropertyInfo property = this.ObjectType.GetProperty(name);
                if (property != null)
                {
                    return DynamicInvoker.DynamicGetValue(objectById, property).ToString();
                }
            }
            return string.Empty;
        }

        public virtual string GetObjectNoByID(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            object objectById = this.GetObjectById(iObjectID);
            if (objectById != null)
            {
                string name = SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName).Substring(0, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName).Length - 2) + "No";
                PropertyInfo property = this.ObjectType.GetProperty(name);
                if (property != null)
                {
                    return DynamicInvoker.DynamicGetValue(objectById, property).ToString();
                }
            }
            return string.Empty;
        }

        public DataSet GetObjectsByUpdatedDate(string strTableName, DateTime dateValue)
        {
            SqlDatabaseHelper.TableName = strTableName;
            string str2 = "AAUpdatedDate";
            string str3 = dateValue.ToString("yyyy-MM-dd hh:mm:ss");
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("SELECT * FROM [dbo].[{0}] WHERE CONVERT(VARCHAR(20), [{1}], 120) > CONVERT(VARCHAR(20), '{2}', 120) AND  CONVERT(VARCHAR(20), {1}, 120) <  CONVERT(VARCHAR(20), '9999-12-31 00:00:00', 120)  ", strTableName, str2, str3)));
        }

        public object GetPrimaryColumnValue(object obj)
        {
            return SqlDatabaseHelper.GetPrimaryColumnValue(obj, this);
        }

        public object GetSingleObject(DataTable dt)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            return SqlDatabaseHelper.GetSingleObject(dt, this.ObjectType);
        }

        public virtual object GetTemplateObject()
        {
            SqlDatabaseHelper.TableName = this.TableName;
            DataSet set = SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select * From [dbo].[{0}] Where [{1}]='Template'", this.TableName, SqlDatabaseHelper.AAStatusColumn)));
            if ((set.Tables.Count > 0) && (set.Tables[0].Rows.Count > 0))
            {
                return SqlDatabaseHelper.GetObjectFromDataRow(set.Tables[0].Rows[0], this.ObjectType);
            }
            return null;
        }

        public virtual object GetTemplateObjectByID(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            DataSet set = SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("Select * From [dbo].[{0}] Where [{1}]='Template' AND [{2}]={3}", new object[] { this.TableName, SqlDatabaseHelper.AAStatusColumn, GMCDbUtil.GetTablePrimaryColumn(this.TableName), iObjectID })));
            if ((set.Tables.Count > 0) && (set.Tables[0].Rows.Count > 0))
            {
                return SqlDatabaseHelper.GetObjectFromDataRow(set.Tables[0].Rows[0], this.ObjectType);
            }
            return null;
        }

        public virtual void PermanentDeleteByForeignColumn(string strForeignColumn, object objValue)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("DELETE FROM [dbo].[{0}] WHERE [{1}]={2}", this.TableName, strForeignColumn, objValue)));
        }

        public virtual void PermanentDeleteObject(int iObjectID)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format("DELETE FROM [dbo].[{0}] WHERE [{1}]={2}", this.TableName, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), iObjectID)));
        }

        public void RollbackTransaction(DbTransaction transaction)
        {
            SqlDatabaseHelper.RollbackTransaction(transaction);
        }

        public int RunQuery(string strQuery)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            return SqlDatabaseHelper.RunQueryNonDataSet(SqlDatabaseHelper.GetQuery(strQuery));
        }

        public DataSet SearchObject(object objSearch)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            DbCommand storedProcedure = SqlDatabaseHelper.GetStoredProcedure(this.GenerateSearchObjectStoredProcedureName());
            SqlDatabaseHelper.AddParameterForSearchProperties(objSearch, storedProcedure);
            return SqlDatabaseHelper.RunStoredProcedure(storedProcedure);
        }

        public void SetValueToIDStringColumn(object obj, int iObjectID)
        {
            SqlDatabaseHelper.SetValueToIDStringColumn(obj, this, iObjectID);
        }

        public void SetValueToPrimaryColumn(object obj, int iObjectID)
        {
            SqlDatabaseHelper.SetValueToPrimaryColumn(obj, this, iObjectID);
        }

        public virtual int UpdateObject(object obj)
        {
            DateTime now = DateTime.Now;
            GMCDbUtil.SetPropertyValue(obj, "AAUpdatedDate", now);
            return SqlDatabaseHelper.InsertObject(obj, this, this.GenerateUpdateStoredProcedureName());
        }

        public virtual int UpdateObject(object obj, DbTransaction transaction)
        {
            DateTime now = DateTime.Now;
            GMCDbUtil.SetPropertyValue(obj, "AAUpdatedDate", now);
            return SqlDatabaseHelper.InsertObject(obj, this, this.GenerateUpdateStoredProcedureName(), transaction);
        }

        public virtual int UpdateObject(object obj, bool pbUpdatedDate, params string[] pUpdateColumns)
        {
            string str = string.Format("", new object[0]);
            for (int i = 0; i < pUpdateColumns.Length; i++)
            {
                if (this.ObjectType.GetProperty(pUpdateColumns[i]) != null)
                {
                    str = str + string.Format(",{0} = @{0}", pUpdateColumns[i]);
                }
            }
            if (!string.IsNullOrEmpty(str))
            {
                PropertyInfo property;
                object obj2;
                if (pbUpdatedDate)
                {
                    DateTime now = DateTime.Now;
                    GMCDbUtil.SetPropertyValue(obj, "AAUpdatedDate", now);
                    if (this.ObjectType.GetProperty("AAUpdatedDate") != null)
                    {
                        str = str + string.Format(",{0} = @{0}", "AAUpdatedDate");
                    }
                }
                str = str.Substring(1);
                DbCommand query = SqlDatabaseHelper.GetQuery(string.Format("\r\nUPDATE {0} \r\n    SET {1}\r\n    WHERE {2} = {3}\r\n", new object[] { this.TableName, str, SqlDatabaseHelper.GetPrimaryKeyColumn(this.TableName), this.GetPrimaryColumnValue(obj) }));
                for (int j = 0; j < pUpdateColumns.Length; j++)
                {
                    property = this.ObjectType.GetProperty(pUpdateColumns[j]);
                    if (property != null)
                    {
                        obj2 = DynamicInvoker.DynamicGetValue(obj, property);
                        SqlDatabaseHelper.AddInParameter(query, property, obj2);
                    }
                }
                if (pbUpdatedDate)
                {
                    property = this.ObjectType.GetProperty("AAUpdatedDate");
                    obj2 = DynamicInvoker.DynamicGetValue(obj, property);
                    if (property != null)
                    {
                        SqlDatabaseHelper.AddInParameter(query, property, obj2);
                    }
                }
                SqlDatabaseHelper.GMCDatabase.ExecuteNonQuery(query);
            }
            return (int)this.GetPrimaryColumnValue(obj);
        }

        public virtual int UpdateObjectNoUpdateDate(object obj)
        {
            return SqlDatabaseHelper.InsertObject(obj, this, this.GenerateUpdateStoredProcedureName());
        }

        public void UpdateObjectSaveStatusInSession(string strUserName)
        {
            SqlDatabaseHelper.TableName = this.TableName;
            object[] values = new object[] { strUserName };
            SqlDatabaseHelper.RunStoredProcedure(this.GenerateUpdateObjectSaveStatusInSessionStoredProcedureName(), values);
        }

        public string TableName
        {
            get
            {
                return this._tableName;
            }
            set
            {
                this._tableName = value;
            }
        }

        public Type ObjectType
        {
            get
            {
                return this._objectType;
            }
            set
            {
                this._objectType = value;
            }
        }
    }
}
