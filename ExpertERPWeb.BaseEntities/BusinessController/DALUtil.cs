using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpertWebLib;
using System.Reflection;
using System.Data;
using System.Collections.ObjectModel;
using ExpertERPWeb.BaseEntities;

namespace ExpertERP.BusinessEntities
{
    public enum CompareType
    {
        GreaterThan = 0,
        LessThan = 1,
        Equal = 2,
        GreaterEqualThan = 3,
        LessEqualThan = 4

    }
    public class DALUtil
    {

        public static String GennerateCondition(String strFieldName, CompareType type, DateTime dt, bool isDateTime)
        {
            /*
             * variable : isDateTime
             *   false : only compare day,month,year (default)
             *   true  : compare day,month,year,hour,minute,second 
            */
            StringBuilder StrBuild = new StringBuilder();
            String strDate = String.Empty;
            String strCompareOperator = String.Empty;
            if (isDateTime)
                strDate = String.Format("'{0:yyyy/M/d HH:mm:ss}'", dt);
            else
            {
                strFieldName = String.Format("(CONVERT(VARCHAR(20), {0}, 112)", strFieldName);
                strDate = String.Format("CONVERT(VARCHAR(20),'{0}',112))", dt.ToString("yyyyMMdd"));
            }


            #region Compare Type
            if (type.Equals(CompareType.Equal))
            {
                strCompareOperator = " = ";
            }
            else if (type.Equals(CompareType.GreaterThan))
            {
                strCompareOperator = " > ";
            }
            else if (type.Equals(CompareType.LessThan))
            {
                strCompareOperator = " < ";
            }
            else if (type.Equals(CompareType.GreaterEqualThan))
            {
                strCompareOperator = " >= ";
            }
            else if (type.Equals(CompareType.LessEqualThan))
            {
                strCompareOperator = " <= ";
            }
            #endregion

            StrBuild.Append(strFieldName);
            StrBuild.Append(strCompareOperator);
            StrBuild.Append(strDate);

            return StrBuild.ToString();
        }

        public static String GenerateBeetween(String strFieldName, DateTime dtFrom, DateTime dtTo, bool isDateTime)
        {
            /*
             * variable : isDateTime
             *   false : only compare day,month,year (default)
             *   true  : compare day,month,year,hour,minute,second 
            */
            StringBuilder StrBuild = new StringBuilder();
            String strDateFrom = String.Empty;
            String strDateTo = String.Empty;

            if (isDateTime)
            {
                strDateFrom = String.Format("'{0:yyyy/M/d HH:mm:ss}'", dtFrom);
                strDateTo = String.Format("'{0:yyyy/M/d HH:mm:ss}'", dtTo);
            }
            else
            {
                strFieldName = String.Format("(CONVERT(VARCHAR(20), {0}, 112)", strFieldName);
                strDateFrom = String.Format("CONVERT(VARCHAR(20),'{0}',112)", dtFrom.ToString("yyyyMMdd"));
                strDateTo = String.Format("CONVERT(VARCHAR(20),'{0}',112))", dtTo.ToString("yyyyMMdd"));
            }

            StrBuild.Append(strFieldName);
            StrBuild.Append(" BETWEEN ");
            StrBuild.Append(strDateFrom);
            StrBuild.Append(" AND ");
            StrBuild.Append(strDateTo);
            return StrBuild.ToString();
        }

        public static String GennerateCondition(String strFieldName, CompareType type, DateTime dt)
        {
            return GennerateCondition(strFieldName, type, dt, false);
        }

        public static String GenerateBeetween(String strFieldName, DateTime dtFrom, DateTime dtTo)
        {
            return GenerateBeetween(strFieldName, dtFrom, dtTo, false);
        }

        public static string GenerateColumnsFromTable(string sTableName, string sReplaceTableName)
        {
            return string.Format(@"
                DECLARE @column NVARCHAR(MAX)
                SELECT @column = STUFF((
                    SELECT ','+name+' AS '+REPLACE(name,'{0}','{1}') 
                    FROM sys.columns 
                    WHERE OBJECT_ID = OBJECT_ID('{2}') FOR XML PATH('')),1,1,'')", sTableName.TrimEnd('s'), sReplaceTableName.TrimEnd('s'), sTableName);
        }
    }

    public static class BaseBusinessControllerExtra
    {
        public static string GenerateDBTable(this BaseBusinessController ctrl, string sTableName, string sDBName, string sSchema = "dbo", string strSperator = ".")
        {
            List<string> lst = new List<string>() { sDBName, sSchema, sTableName };
            lst.RemoveAll(x => string.IsNullOrEmpty(x));
            return string.Join(strSperator, lst.ToArray());
        }
        public static object GetObjectColumnByID(this BaseBusinessController ctrl, int iObjectID, string strColumn)
        {
            object objInfo = ctrl.GetObjectByID(iObjectID);
            if (objInfo != null)
            {
                return GetValueProperty(objInfo, strColumn);
            }
            return null;
        }
        public static object GetObjectColumnByNo(this BaseBusinessController ctrl, string strObjectNo, string strColumn)
        {
            object objInfo = ctrl.GetObjectByNo(strObjectNo);
            if (objInfo != null)
                return GetValueProperty(objInfo, strColumn);
            return null;
        }
        public static object GetObjectColumnByName(this BaseBusinessController ctrl, string strObjectName, string strColumn)
        {
            object objInfo = ctrl.GetObjectByName(strObjectName);
            if (objInfo != null)
                return GetValueProperty(objInfo, strColumn);
            return null;
        }
        public static object GetObjectColumnByColumnName(this BaseBusinessController ctrl, string strColumnName, object objValue, string strColumn)
        {
            object objInfo = ctrl.GetObjectByColumnName(strColumnName, objValue);
            if (objInfo != null)
                return GetValueProperty(objInfo, strColumn);
            return null;
        }
        public static DataSet GetObjectForDataLookup(this BaseBusinessController ctrl, string[] lstColumns, string strCondition)
        {
            string strName = ctrl.GetType().Name.Replace("Controller", "");
            List<string> lstWhere = new List<string>();
            if (GMCDbUtil.ColumnIsExist(strName, "AAStatus")) lstWhere.Add("AAStatus = 'Alive'");
            if (!string.IsNullOrEmpty(strCondition)) lstWhere.Add(strCondition);
            string strWhere = string.Empty;
            if (lstWhere.Count > 0) strWhere = string.Format("WHERE {0}", string.Join(" AND ", lstWhere.ToArray()));
            return ctrl.GetDataSet(string.Format("SELECT {0} FROM {1} {2}", string.Join(",", lstColumns), strName, strWhere));
        }
        private static object GetValueProperty(object objInfo, string strColumn)
        {
            PropertyInfo property = objInfo.GetType().GetProperty(strColumn);
            if (property != null)
                return property.GetValue(objInfo, null);
            return null;
        }
        public static List<BusinessObject> GetListFromDataTable(this BaseBusinessController ctrl, DataTable dt)
        {
            List<BusinessObject> lst = new List<BusinessObject>();
            if (dt == null) return lst;
            return ctrl.GetListFromDataTable(dt.Select());
        }
        public static List<BusinessObject> GetListFromDataTable(this BaseBusinessController ctrl, DataRow[] arrRow)
        {
            List<BusinessObject> lst = new List<BusinessObject>();
            if (arrRow.Length == 0) return lst;
            foreach (DataRow row in arrRow)
            {
                object obj = ctrl.GetObjectFromDataRow(row);
                if (obj == null) continue;
                if (!lst.Contains((BusinessObject)obj))
                    lst.Add((BusinessObject)obj);
            }
            return lst;
        }
        public static DataTable GetDataTableFromList<T>(this BaseBusinessController ctrl, Collection<T> lstObjects)
        {
            DataTable dt = new DataTable();
            if (lstObjects.Count == 0) return dt;
            dt = GetDataTableStructByBusinessObject(lstObjects.FirstOrDefault());
            foreach (T item in lstObjects)
            {
                DataRow dr = ctrl.GetDataRowFromBusinessObject(dt.NewRow(), item);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public static DataTable GetDataTableStructByBusinessObject(object obj, string strColumns = "")
        {
            DataTable dt = new DataTable();
            if (obj == null) return dt;
            string sTableName = GMCUtil.GetTableNameFromBusinessObject((BusinessObject)obj);
            if (!string.IsNullOrEmpty(sTableName))
            {
                string sColumns = string.IsNullOrEmpty(strColumns) ? GMCWebApp.GetLookupQueryColumn(sTableName) : "*";
                DataSet ds = GMCDbUtil.ExecuteQuery(string.Format("SELECT TOP 1 {1} FROM {0} WHERE 1 = 2", sTableName, sColumns));
                if (ds != null)
                {
                    dt = ds.Tables[0];
                    dt.TableName = sTableName;
                }
                dt.Clear();
            }
            return dt;
        }
        public static DataTable GetDataTableByDataSet(this BaseBusinessController ctrl, DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        public static int SaveObject(this BaseBusinessController ctrl, BusinessObject obj)
        {
            string strTable = GMCUtil.GetTableNameFromBusinessObject(obj);
            string strPrimaryID = GMCDbUtil.GetTablePrimaryColumn(strTable);
            int iObjectID = Convert.ToInt32(GMCDbUtil.GetPropertyValue(obj, strPrimaryID));
            int iNewObjectID = 0;
            BusinessObject objTmp = obj;
            //if (obj.GetType().BaseType == typeof(BaseProvider.ERPModuleItemsEntity))
            //{
            //    objTmp = BusinessObjectFactory.GetBusinessObject(strTable + "Info");
            //    objTmp.GetFromBusinessObject(obj);
            //}
            bool isFlag = true;
            //if (GMCWebApp.CurrentModule.Toolbar.ObjectCollection != null) isFlag = GMCWebApp.CurrentModule.Toolbar.IsEditAction();
            if (iObjectID > 0 && ctrl.IsExist(iObjectID) && isFlag)
                iNewObjectID = ctrl.UpdateObject(objTmp);
            else
                iNewObjectID = ctrl.CreateObject(objTmp);
            //if (obj.GetType().BaseType == typeof(BaseProvider.ERPModuleItemsEntity))
            //    obj.GetFromBusinessObject(objTmp);
            return iNewObjectID;
        }
        public static int GetCurrenMaxID(this BaseBusinessController ctrl)
        {
            string sTableName = ctrl.GetType().Name.Replace("Controller", "");
            if (SqlDatabaseHelper.IsPKIdentity(sTableName))
            {
                System.Data.DataSet ds = ctrl.GetDataSet(string.Format("SELECT IDENT_CURRENT('{0}') ", sTableName));
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
                return 1;
            }
            else
                return ctrl.GetMaxID();
        }
    }
    public static class ADOFConfigUtility
    {
        static ADOFItemsController ADOFItemCtrl = new ADOFItemsController();
        static ADOFsController ADOFCtrl = new ADOFsController();
        public static DataTable InitADOFConfig(string strType)
        {
            string strSubQuery = "";
            if (!string.IsNullOrEmpty(strType))
                strSubQuery = string.Format("WHERE ADOFTypeCombo = '{0}'", strType);
            string strQuery = string.Format(@"SELECT ADOFID,ADOFNo,ADOFName,ADOFTypeCombo,ADOFItemID,ADOFItemNo,ADOFItemName
                                FROM ADOFs a
                                JOIN ADOFItems b ON a.ADOFID = b.FK_ADOFID AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive'
                                {0}", strSubQuery);
            return ADOFCtrl.GetDataTableByDataSet(ADOFCtrl.GetDataSet(strQuery));
        }
    }
}
