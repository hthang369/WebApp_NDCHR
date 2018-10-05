using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ADTransferDocHistorys
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.36)
    //Class: ADTransferDocHistorysController
    //Created Date: Monday, 02 Oct 2017
    //-----------------------------------------------------------

    public class ADTransferDocHistorysController : BaseBusinessController
    {
        public ADTransferDocHistorysController()
        {
            dal = new DALBaseProvider("ADTransferDocHistorys", typeof(ADTransferDocHistorysInfo));
        }
        public DataTable GetAllDataByTableNameAndDatabase(string sTableName, string sDBName)
        {
            DataTable dt = this.GetDataTableByDataSet(GetAllDataByColumns(new string[] { "TableName", "ADTransferDocHistoryToDB" }, sTableName, sDBName));
            dt.TableName = dal.TableName;
            return dt;
        }
        public void DeleteObjectByIDAndModuleName(int iObjectID, string sModuleName, string sTableName)
        {
            DataTable dt = this.GetDataTableByDataSet(GetAllDataByColumns(new string[] { "ObjectID", "TableName", "ADTransferDocHistoryDocType" }, iObjectID, sTableName, sModuleName));
            if (dt != null && dt.Rows.Count > 0)
            {
                ADTransferDocHistorysInfo obj = (ADTransferDocHistorysInfo)GetObjectFromDataRow(dt.Rows[0]);
                string strQuery = "IF OBJECT_ID('{0}') IS NOT NULL DELETE FROM {0} WHERE ObjectID = {1} AND ADTransferDocHistoryDocType = '{2}' AND TableName = '{3}'";
                string sFromDBName = this.GenerateDBTable(dal.TableName, obj.ADTransferDocHistoryFromDB);
                string sToDBName = this.GenerateDBTable(dal.TableName, obj.ADTransferDocHistoryToDB);
                GMCDbUtil.ExecuteQuery(string.Format(strQuery, sFromDBName, iObjectID, sModuleName, sTableName));
                GMCDbUtil.ExecuteQuery(string.Format(strQuery, sToDBName, iObjectID, sModuleName, sTableName));
            }
        }

        public ADTransferDocHistorysInfo GetObjectByIDAndModuleTableName(int iObjectID, string strModuleName, string strTableName)
        {
            DataTable dt = this.GetDataTableByDataSet(GetAllDataByColumns(new string[] { "ObjectID", "TableName", "ADTransferDocHistoryDocType" }, iObjectID, strTableName, strModuleName));
            if (dt != null && dt.Rows.Count > 0)
                return (ADTransferDocHistorysInfo)dal.GetObjectFromDataRow(dt.Rows[0]);
            return null;
        }
    }
    #endregion
}