using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertWebLib
{
    public class BaseBusinessController
    {
        protected DALBaseProvider dal;
        public string TableName;
        public BaseBusinessController _command;

        public BaseBusinessController()
        {
            this.TableName = "";
            this._command = null;
        }

        public BaseBusinessController(Type objType)
        {
            this.TableName = "";
            this._command = null;
            string strTableName = objType.Name.Substring(0, objType.Name.Length - 4);
            this.dal = new DALBaseProvider(strTableName, objType);
        }

        public BaseBusinessController(string strTableName, Type objType)
        {
            this.TableName = "";
            this._command = null;
            this.dal = new DALBaseProvider(strTableName, objType);
        }

        public virtual int CreateObject(BusinessObject obj)
        {
            try
            {
                if ((GMCDbUtil.ColumnIsExist(this.dal.TableName, "FK_BRBranchID") && (Convert.ToInt32(GMCDbUtil.GetPropertyValue(obj, "FK_BRBranchID")) == 0)) && (GMCUtil.Branch != null))
                {
                    int num2 = Convert.ToInt32(GMCDbUtil.GetPropertyValue(GMCUtil.Branch, "BRBranchID"));
                    GMCDbUtil.SetPropertyValue(obj, "FK_BRBranchID", num2);
                }
            }
            catch
            {
            }
            if (SqlDatabaseHelper.IsPKIdentity(this.dal.TableName))
            {
                return this.CreateObject(obj, true);
            }
            this.dal.SetValueToPrimaryColumn(obj, this.GetMaxID());
            return this.dal.CreateObject(obj);
        }

        public virtual int CreateObject(BusinessObject obj, bool bIsIdentityPrimaryKey)
        {
            int iObjectID = this.dal.CreateObject(obj, bIsIdentityPrimaryKey);
            this.dal.SetValueToPrimaryColumn(obj, iObjectID);
            return iObjectID;
        }

        public virtual int CreateObject(BusinessObject obj, DbTransaction transaction)
        {
            this.dal.SetValueToPrimaryColumn(obj, this.GetMaxID());
            return this.dal.CreateObject(obj, transaction);
        }

        public virtual int CreateObject(BusinessObject obj, int iObjectID)
        {
            if (this.IsExist(iObjectID))
            {
                return -1;
            }
            if (iObjectID == 0)
            {
                return 0;
            }
            this.dal.SetValueToPrimaryColumn(obj, iObjectID);
            return this.dal.CreateObject(obj);
        }

        public void DeleteAllObjects()
        {
            this.dal.DeleteAllObjects();
        }

        public void DeleteAllObjectsByObjectParentID(int iObjectParentID)
        {
            this.dal.DeleteAllObjectsByObjectParentID(iObjectParentID);
        }

        public virtual void DeleteByForeignColumn(string strForeignColumn, object objForeignColumnValue)
        {
            this.dal.DeleteByForeignColumn(strForeignColumn, objForeignColumnValue);
        }

        public virtual void DeleteFromOwner(string strOwnerTable, int iOwnerID, string strSwitcherTable)
        {
            this.dal.DeleteMembersFromOwner(strOwnerTable, iOwnerID, this.dal.TableName, strSwitcherTable);
        }

        public virtual void DeleteObject(int iObjectID)
        {
            this.dal.DeleteObject(iObjectID);
        }

        public virtual void DeleteObject(int iObjectID, DbTransaction transaction)
        {
            this.dal.DeleteObject(iObjectID, transaction);
        }

        public virtual DataSet GetAllAliveObjects()
        {
            return this.dal.GetAllAliveObjects();
        }

        public virtual DataSet GetAllDataByColumns(string[] arrColumns, params object[] arrColumnValues)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("Select * From [{0}] Where ", this.dal.TableName));
            for (int i = 0; i < arrColumns.Length; i++)
            {
                if (GMCDbUtil.GetColumnDbType(this.dal.TableName, arrColumns[i]).Contains("varchar"))
                {
                    if (GMCDbUtil.GetColumnDbType(this.dal.TableName, arrColumns[i]).Contains("nvarchar"))
                    {
                        builder.Append(string.Format("([{0}]=N'{1}')", arrColumns[i], arrColumnValues[i]));
                    }
                    else
                    {
                        builder.Append(string.Format("([{0}]='{1}')", arrColumns[i], arrColumnValues[i]));
                    }
                }
                else
                {
                    builder.Append(string.Format("([{0}]={1})", arrColumns[i], arrColumnValues[i]));
                }
                if (i < (arrColumns.Length - 1))
                {
                    builder.Append(" And ");
                }
            }
            string strQuery = builder.ToString();
            if (GMCDbUtil.ColumnIsExist(this.dal.TableName, "AAStatus"))
            {
                strQuery = strQuery + " AND AAStatus = 'Alive'";
            }
            return this.dal.GetDataSet(strQuery);
        }

        public virtual DataSet GetAllDataByForeignColumn(string strForeignColumnName, object objForeignColumnValue)
        {
            return this.dal.GetAllDataByForeignColumn(strForeignColumnName, objForeignColumnValue);
        }

        public virtual DataSet GetAllFromOwner(string strOwnerTable, int iOwnerID, string strSwitcherTable)
        {
            return this.dal.GetMembersFromOwner(strOwnerTable, iOwnerID, this.dal.TableName, strSwitcherTable);
        }

        public virtual DataSet GetAllNewObjectInSession(string strUserName)
        {
            return this.dal.GetNewObjectInSession(strUserName);
        }

        public virtual DataSet GetAllObjectForDataLookups(params string[] columns)
        {
            string str = string.Empty;
            Type businessObjectType = BusinessObjectFactory.GetBusinessObjectType(this.dal.TableName + "Info");
            if ((businessObjectType != null) && (columns.Length != 0))
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    if (!string.IsNullOrEmpty(columns[i]) && (businessObjectType.GetProperty(columns[i]) != null))
                    {
                        str = str + string.Format("{0},", columns[i]);
                    }
                }
            }
            if (string.IsNullOrEmpty(str))
            {
                str = "*";
            }
            if (str.Substring(str.Length - 1).Equals(","))
            {
                str = str.Substring(0, str.Length - 1);
            }
            string strQueryCommand = string.Empty;
            if (businessObjectType != null)
            {
                if (businessObjectType.GetProperty("AAStatus") != null)
                {
                    strQueryCommand = string.Format("Select {0} From [{1}] Where [AAStatus]='Alive'", str, this.dal.TableName);
                }
                else
                {
                    strQueryCommand = string.Format("Select {0} From [{1}]", str, this.dal.TableName);
                }
            }
            else
            {
                strQueryCommand = string.Format("Select {0} From [{1}]", str, this.dal.TableName);
            }
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(strQueryCommand));
        }

        public virtual DataSet GetAllObjectForDataLookups(string strQueryColumn)
        {
            Type businessObjectType = BusinessObjectFactory.GetBusinessObjectType(this.dal.TableName + "Info");
            string strQueryCommand = string.Empty;
            if (businessObjectType != null)
            {
                if (businessObjectType.GetProperty("AAStatus") != null)
                {
                    strQueryCommand = string.Format("Select {0} From [{1}] Where [AAStatus]='Alive'", strQueryColumn, this.dal.TableName);
                }
                else
                {
                    strQueryCommand = string.Format("Select {0} From [{1}]", strQueryColumn, this.dal.TableName);
                }
            }
            else
            {
                strQueryCommand = string.Format("Select {0} From [{1}]", strQueryColumn, this.dal.TableName);
            }
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(strQueryCommand));
        }

        public virtual DataSet GetAllObjects()
        {
            return this.dal.GetAllObject();
        }

        public DataSet GetAllObjectsByObjectParentID(int iObjectParentID)
        {
            return this.dal.GetAllObjectsByObjectParentID(iObjectParentID);
        }

        public virtual DataSet GetAllProfileObjects()
        {
            return this.dal.GetAllProfileObjects();
        }

        public virtual DataSet GetAllTemplateObjects()
        {
            return this.dal.GetAllTemplateObjects();
        }

        public DataRow GetDataRowFromBusinessObject(DataRow row, object obj)
        {
            foreach (DataColumn column in row.Table.Columns)
            {
                PropertyInfo property = obj.GetType().GetProperty(column.ColumnName);
                if ((property != null) && (property.GetValue(obj, null) != null))
                {
                    row[column.ColumnName] = property.GetValue(obj, null);
                }
            }
            return row;
        }

        public virtual DataSet GetDataSet(string strQuery)
        {
            return this.dal.GetDataSet(strQuery);
        }
        public virtual DataTable GetDataTable(string strQuery)
        {
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        public virtual DataSet GetDataSetByID(int iObjectID)
        {
            return this.dal.GetDataSetByID(iObjectID);
        }

        public DataTable GetDataTableStructByBusinessObject(object obj)
        {
            DataTable table = new DataTable();
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo info in properties)
            {
                table.Columns.Add(info.Name, info.PropertyType);
            }
            return table;
        }

        public virtual DataSet GetDefaultObjectsForDataLookup()
        {
            string str = this.dal.TableName.Substring(0, this.dal.TableName.Length - 1) + "ID";
            string str2 = this.dal.TableName.Substring(0, this.dal.TableName.Length - 1) + "No";
            string str3 = this.dal.TableName.Substring(0, this.dal.TableName.Length - 1) + "Name";
            string str4 = this.dal.TableName.Substring(0, this.dal.TableName.Length - 1) + "Desc";
            string[] columns = new string[] { str, str2, str3, str4 };
            return this.GetAllObjectForDataLookups(columns);
        }

        public virtual object GetDeletedObjectByID(int iObjectID)
        {
            return this.dal.GetDeletedObjectByID(iObjectID);
        }

        public virtual object GetFirstObject()
        {
            return this.dal.GetFirstObject();
        }

        public virtual BusinessObject GetFirstObjectByForeignColumn(string strForeignColumnName, object objForeignColumnValue)
        {
            DataSet allDataByForeignColumn = this.GetAllDataByForeignColumn(strForeignColumnName, objForeignColumnValue);
            return (BusinessObject)this.dal.GetSingleObject(allDataByForeignColumn.Tables[0]);
        }

        public virtual int GetFirstObjectID()
        {
            try
            {
                object firstObject = this.GetFirstObject();
                if (firstObject != null)
                {
                    return Convert.ToInt32(this.dal.GetPrimaryColumnValue(firstObject));
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public virtual List<BusinessObject> GetListBusinessObjects()
        {
            List<BusinessObject> list = new List<BusinessObject>();
            DataSet allObjects = this.GetAllObjects();
            if (allObjects.Tables.Count > 0)
            {
                foreach (DataRow row in allObjects.Tables[0].Rows)
                {
                    BusinessObject objectFromDataRow = (BusinessObject)SqlDatabaseHelper.GetObjectFromDataRow(row, this.dal.ObjectType);
                    list.Add(objectFromDataRow);
                }
            }
            return list;
        }

        public List<BusinessObject> GetListFromDataset(DataSet ds)
        {
            List<BusinessObject> list = new List<BusinessObject>();
            if (((ds != null) && (ds.Tables[0] != null)) && (ds.Tables[0].Rows.Count > 0))
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    BusinessObject objectFromDataRow = (BusinessObject)this.GetObjectFromDataRow(row);
                    list.Add(objectFromDataRow);
                }
            }
            return list;
        }

        public int GetMaxID()
        {
            return (this.dal.GetMaxID() + 1);
        }

        public int GetMaxNumberingByPrefix(string strPrefix, int iLength)
        {
            int num = 0;
            string str = this.dal.TableName.Substring(0, this.dal.TableName.Length - 1) + "No";
            string strQuery = string.Empty;
            if (GMCDbUtil.ColumnIsExist(this.dal.TableName, "AAStatus"))
            {
                strQuery = string.Format("Select Max(Right([{0}],{1})) From {2} Where [{0}] LIKE '{3}%'And [AAStatus]='Alive'", new object[] { str, iLength, this.dal.TableName, strPrefix });
            }
            else
            {
                strQuery = string.Format("Select Max(Right([{0}],{1})) From {2} Where [{0}] LIKE '{3}%'", new object[] { str, iLength, this.dal.TableName, strPrefix });
            }
            DataSet dataSet = this.GetDataSet(strQuery);
            if (dataSet != null)
            {
                return num;
            }
            if (dataSet.Tables[0] != null)
            {
                return num;
            }
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                return num;
            }
            try
            {
                return Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public virtual DataSet GetNewObjectsByAACreatdDate(string strTableName, DateTime dtValue)
        {
            return this.dal.GetNewObjectsByAACreatedDate(strTableName, dtValue);
        }

        public virtual object GetObjectByAANumberInt(int iAANumberInt)
        {
            return this.dal.GetObjectByAANumberInt(iAANumberInt);
        }

        public virtual object GetObjectByColumnName(string strColumnName, object objValue)
        {
            return this.dal.GetObjectByColumnName(strColumnName, objValue);
        }

        public virtual object GetObjectByID(int iObjectID)
        {
            return this.dal.GetObjectById(iObjectID);
        }

        public virtual object GetObjectByName(string strObjectName)
        {
            return this.dal.GetObjectByName(strObjectName);
        }

        public virtual object GetObjectByNo(string strObjectNo)
        {
            return this.dal.GetObjectByNo(strObjectNo);
        }

        public virtual object GetObjectFromDataRow(DataRow row)
        {
            return this.dal.GetObjectFromDataRow(row);
        }

        public virtual int GetObjectIDByName(string strObjectName)
        {
            return this.dal.GetObjectIDByName(strObjectName);
        }

        public virtual int GetObjectIDByNo(string strObjectNo)
        {
            return this.dal.GetObjectIDByNo(strObjectNo);
        }

        public virtual string GetObjectNameByID(int iObjectID)
        {
            return this.dal.GetObjectNameByID(iObjectID);
        }

        public virtual string GetObjectNoByID(int iObjectID)
        {
            return this.dal.GetObjectNoByID(iObjectID);
        }

        public virtual DataSet GetObjectsByAAUpdatedDate(string strTableName, DateTime dateValue)
        {
            return this.dal.GetObjectsByUpdatedDate(strTableName, dateValue);
        }

        public virtual DataSet GetObjectsByIDForDataLookup(string[] arrColumns, int iObjectID)
        {
            string str = "Select ";
            string tablePrimaryColumn = GMCDbUtil.GetTablePrimaryColumn(this.dal.TableName);
            foreach (string str3 in arrColumns)
            {
                str = str + string.Format("[{0}],", str3);
            }
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(str.Remove(str.Length - 1, 1) + string.Format(" FROM [{0}] WHERE [{1}]={2} AND [AAStatus]='Alive'", this.dal.TableName, tablePrimaryColumn, iObjectID)));
        }

        public virtual DataSet GetObjectsForDataLookup(params object[] columns)
        {
            string str = string.Format("SELECT ", new object[0]);
            for (int i = 0; i < columns.Length; i++)
            {
                if (i < (columns.Length - 1))
                {
                    str = str + columns[i].ToString() + ",";
                }
                else
                {
                    str = str + columns[i].ToString() + " ";
                }
            }
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(str + string.Format(" FROM [{0}] WHERE [AAStatus]='Alive'", this.dal.TableName)));
        }

        public virtual DataSet GetObjectsForDataLookup(string[] arrColumns, int iMaxResults)
        {
            string str = string.Format("Select TOP({0}) ", iMaxResults);
            foreach (string str2 in arrColumns)
            {
                str = str + string.Format("[{0}],", str2);
            }
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(str.Remove(str.Length - 1, 1) + string.Format(" FROM [{0}] WHERE [AAStatus]='Alive'", this.dal.TableName)));
        }

        public virtual DataSet GetObjectsForDataLookup(string[] arrColumns, int iMaxResults, string strCondition)
        {
            string str = string.Format("Select TOP({0}) ", iMaxResults);
            foreach (string str2 in arrColumns)
            {
                str = str + string.Format("[{0}],", str2);
            }
            return SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery((str.Remove(str.Length - 1, 1) + string.Format(" FROM [{0}] WHERE [AAStatus]='Alive'", this.dal.TableName)) + " AND " + strCondition));
        }

        public virtual int GetRecordsCount()
        {
            string str = this.dal.TableName.Substring(0, this.dal.TableName.Length - 1) + "ID";
            string[] textArray1 = new string[] { "SELECT COUNT(", str, ") AS Count From ", this.dal.TableName, " Where [AAStatus] <> 'Delete' " };
            DataSet set = SqlDatabaseHelper.RunQuery(SqlDatabaseHelper.GetQuery(string.Format(string.Concat(textArray1), new object[0])));
            if ((set.Tables.Count > 0) && (set.Tables[0].Rows.Count > 0))
            {
                return Convert.ToInt32(set.Tables[0].Rows[0][0]);
            }
            return -1;
        }

        public virtual object GetTemplateObject()
        {
            return this.dal.GetTemplateObject();
        }

        public virtual object GetTemplateObjectByID(int iObjectID)
        {
            return this.dal.GetTemplateObjectByID(iObjectID);
        }

        public void InitController()
        {
            if (this.Command != null)
            {
                this.dal = this.Command.dal;
            }
            else
            {
                Type businessObjectType = BusinessObjectFactory.GetBusinessObjectType(this.TableName + "Info");
                this.dal = new DALBaseProvider(this.TableName, businessObjectType);
                BusinessControllerFactory.AddNewBusinessController(this, this.TableName);
            }
        }

        public bool IsExist(int iObjectID)
        {
            return (this.GetObjectByID(iObjectID) != null);
        }

        public bool IsExist(string strObjectNo)
        {
            return (this.GetObjectByNo(strObjectNo) != null);
        }

        public bool IsExist(string strColumnName, object objValue)
        {
            return (this.GetObjectByColumnName(strColumnName, objValue) != null);
        }

        public bool IsExistAANumberInt(int iAANumberInt)
        {
            return (this.GetObjectByAANumberInt(iAANumberInt) != null);
        }

        public bool IsExistObjectName(string strObjectName)
        {
            return (this.GetObjectByName(strObjectName) != null);
        }

        public virtual void PermanentDeleteByForeignColumn(string strForeignColumn, object objForeignColumnValue)
        {
            this.dal.PermanentDeleteByForeignColumn(strForeignColumn, objForeignColumnValue);
        }

        public virtual void PermanentDeleteObject(int iObjectID)
        {
            this.dal.PermanentDeleteObject(iObjectID);
        }

        public virtual int RunQuery(string strQuery)
        {
            return this.dal.RunQuery(strQuery);
        }

        public virtual DataSet SearchObject(object objSearch)
        {
            return this.dal.SearchObject(objSearch);
        }

        public virtual int UpdateObject(BusinessObject obj)
        {
            int iObjectID = Convert.ToInt32(this.dal.GetPrimaryColumnValue(obj));
            if (iObjectID == 0)
            {
                return 0;
            }
            if (this.dal.GetObjectById(iObjectID) == null)
            {
                return this.dal.CreateObject(obj);
            }
            return this.dal.UpdateObject(obj);
        }

        public virtual int UpdateObject(BusinessObject obj, DbTransaction transaction)
        {
            if (Convert.ToInt32(this.dal.GetPrimaryColumnValue(obj)) == 0)
            {
                return 0;
            }
            return this.dal.UpdateObject(obj, transaction);
        }

        public virtual int UpdateObject(BusinessObject obj, bool pbUpdateDate, params string[] psFieldName)
        {
            int num = Convert.ToInt32(this.dal.GetPrimaryColumnValue(obj));
            if (num == 0)
            {
                return 0;
            }
            this.dal.UpdateObject(obj, pbUpdateDate, psFieldName);
            return num;
        }

        public virtual int UpdateObjectNoUpdateDate(BusinessObject obj)
        {
            if (Convert.ToInt32(this.dal.GetPrimaryColumnValue(obj)) == 0)
            {
                return 0;
            }
            return this.dal.UpdateObjectNoUpdateDate(obj);
        }

        public virtual void UpdateObjectSaveStatusInSession(string strUserName)
        {
            this.dal.UpdateObjectSaveStatusInSession(strUserName);
        }

        public BaseBusinessController Command
        {
            get
            {
                if (this._command == null)
                {
                    return BusinessControllerFactory.GetBusinessController(this.dal.TableName + "Controller");
                }
                return this._command;
            }
        }
    }
    public class BusinessControllerFactory
    {
        public static Dictionary<string, BaseBusinessController> lstBusinessController = new Dictionary<string, BaseBusinessController>();

        public static void AddNewBusinessController(BaseBusinessController businessCtrl, string strBusinessTableName)
        {
            if (!string.IsNullOrEmpty(strBusinessTableName))
            {
                lstBusinessController.Add(strBusinessTableName + "Controller", businessCtrl);
            }
        }

        public static BaseBusinessController GetBusinessController(string strBusinessControllerName)
        {
            BaseBusinessController businessControllerInAppDomain = null;
            lstBusinessController.TryGetValue(strBusinessControllerName, out businessControllerInAppDomain);
            if (businessControllerInAppDomain == null)
            {
                try
                {
                    businessControllerInAppDomain = (BaseBusinessController)DynamicInvoker.DynamicCreateInstanceObject(Assembly.LoadFrom(Application.StartupPath + @"\ExpertERP.BusinessEntities.dll").GetType("ExpertERP.BusinessEntities." + strBusinessControllerName));
                    if (businessControllerInAppDomain == null)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Type type = Assembly.GetExecutingAssembly().GetType("ExpertLib." + strBusinessControllerName);
                    if (type != null)
                    {
                        businessControllerInAppDomain = (BaseBusinessController)DynamicInvoker.DynamicCreateInstanceObject(type);
                    }
                }
                if (businessControllerInAppDomain != null)
                {
                    lstBusinessController.Add(strBusinessControllerName, businessControllerInAppDomain);
                }
            }
            if (businessControllerInAppDomain == null)
            {
                businessControllerInAppDomain = GetBusinessControllerInAppDomain(strBusinessControllerName);
            }
            return businessControllerInAppDomain;
        }

        public static BaseBusinessController GetBusinessControllerInAppDomain(string strBusinessControllerName)
        {
            Type typeObj = null;
            try
            {
                Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (Assembly assembly in assemblies)
                {
                    typeObj = assembly.GetType("ExpertERP.BusinessEntities." + strBusinessControllerName, false, true);
                    if (typeObj != null)
                    {
                        break;
                    }
                }
                return (BaseBusinessController)DynamicInvoker.DynamicCreateInstanceObject(typeObj);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Type GetBusinessControllerType(string strBusinessControllerName)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            try
            {
                BaseBusinessController businessController = GetBusinessController(strBusinessControllerName);
                if (businessController != null)
                {
                    return businessController.GetType();
                }
                return executingAssembly.GetType("ExpertLib." + strBusinessControllerName);
            }
            catch (Exception)
            {
                return executingAssembly.GetType("ExpertLib." + strBusinessControllerName);
            }
        }
    }
}
