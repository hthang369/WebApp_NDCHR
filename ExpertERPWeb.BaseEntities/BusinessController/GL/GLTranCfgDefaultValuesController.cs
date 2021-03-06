using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTranCfgDefaultValues
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLTranCfgDefaultValuesController
	//Created Date:Monday, August 25, 2014
	//-----------------------------------------------------------
	
	public class GLTranCfgDefaultValuesController:BaseBusinessController
	{
		public GLTranCfgDefaultValuesController()
		{
			dal= new DALBaseProvider("GLTranCfgDefaultValues",typeof(GLTranCfgDefaultValuesInfo));
		}
        public string GetDataType(string psTableName, string psColumnName)
        {
            String strQuery = String.Format(@"SELECT c.Name
                            FROM syscolumns a
                            INNER JOIN sysobjects b ON a.id = b.id
                            INNER JOIN sysTypes c ON a.xtype = c.xtype
                                   AND a.xusertype = c.xusertype
                            WHERE a.Name = '{0}' and b.Name = '{1}'", psColumnName, psTableName);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return Convert.ToString(ds.Tables[0].Rows[0][0]);
            return string.Empty;
            
        }
        public DataSet GetAllDataHasValueByTranCfgIDAndTable(int piTranCfgID,string psTable)
        {
            String strQuery = String.Format(@"SELECT GLTranCfgGroupDefaultValueTable
    ,GLTranCfgGroupDefaultValueField
    ,GLTranCfgDefaultValueValue
    ,GLTranCfgGroupDefaultValueField as GLTranCfgDefaultValueField
    ,GLTranCfgDefaultValueLine
    ,FK_GLTranCfgGroupDefaultValueID
FROM GLTranCfgDefaultValues a
INNER JOIN GLTranCfgGroupDefaultValues b ON a.FK_GLTranCfgGroupDefaultValueID = b.GLTranCfgGroupDefaultValueID
WHERE a.GLTranCfgDefaultValueValue <> '' and a.FK_GLTranCfgID = {0} AND GLTranCfgGroupDefaultValueTable = '{1}'", piTranCfgID, psTable);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAAColumnAliasNameByTableName(String strTableName)
        {
            String strquery = string.Format(@"SELECT    AATableName ,
                                                        AAColumnAliasName AS GLTranCfgGroupDefaultValueField ,
                                                        AAColumnAliasCaption
                                                FROM    dbo.AAColumnAlias a
                                                        INNER JOIN ( SELECT MAX(AAColumnAliasID) AS AAColumnAliasID
                                                                     FROM   dbo.AAColumnAlias
                                                                     WHERE  AATableName = '{0}'
                                                                     GROUP BY AAColumnAliasName ,
                                                                            AATableName
                                                                   ) b ON a.AAColumnAliasID = b.AAColumnAliasID", strTableName);
            return GetDataSet(strquery);
        }
	}
	#endregion
}