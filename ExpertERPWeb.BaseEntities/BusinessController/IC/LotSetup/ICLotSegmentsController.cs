using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICLotSegments
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICLotSegmentsController
	//Created Date:Friday, October 31, 2014
	//-----------------------------------------------------------
	
	public class ICLotSegmentsController:BaseBusinessController
	{
		public ICLotSegmentsController()
		{
			dal= new DALBaseProvider("ICLotSegments",typeof(ICLotSegmentsInfo));
		}

        public DataSet GetLotIDByModuleNameAndICProductID(int iLotID)
        {
            String strQuery = String.Format(@"  SELECT *
                                                FROM dbo.ICLotSegments
                                                WHERE AAStatus = 'Alive'
                                                      AND FK_ICLotID = {0} 
                                                ORDER BY ICLotSegmentSortOrder ASC", iLotID);
            return GetDataSet(strQuery);
        }

        public DataSet GetMolduleTable()
        {
            String strQuery = String.Format(@"   SELECT a.STModuleTableName, c.STModuleDescriptionDescription
                                                 FROM   dbo.STModuleTables a, STModuleDescriptions c , STModules b
					                             WHERE  a.STModuleID = b.STModuleID	AND b.STModuleID = c.STModuleID
					                             GROUP BY a.STModuleTableName, c.STModuleDescriptionDescription ");
            return dal.GetDataSet(strQuery);
        }

        public DataTable GetDataTableAliasColumnCombo(ref String strValue, ref String strDisplay, String strTableName)
        {
            String strQuery = String.Format(@"SELECT Parent.AAColumnAliasCaption, Parent.AAColumnAliasName FROM dbo.AAColumnAlias Parent
                                                INNER JOIN (
                                                            SELECT MAX(AAColumnAliasID) AS AAColumnAliasID FROM dbo.AAColumnAlias
                                                            WHERE AAStatus = 'Alive'
                                                            AND AATableName LIKE '{0}'
                                                            GROUP BY AAColumnAliasName
                                                ) AS Child ON Child.AAColumnAliasID = Parent.AAColumnAliasID
                                                INNER JOIN (
												            SELECT tab.name AS TableName, col.name AS ColumnName 
												            FROM sys.columns col
												            INNER JOIN sys.tables tab ON tab.object_id = col.object_id 
																			            AND tab.name LIKE '{0}'
												) AS Col ON Parent.AAColumnAliasName = Col.ColumnName
                                                ORDER BY Parent.AAColumnAliasCaption
                                                ", strTableName);
            DataSet ds = new AAColumnAliasController().GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0)
            {
                strValue = "AAColumnAliasName";
                strDisplay = "AAColumnAliasCaption";
                return ds.Tables[0];
            }
            return new DataTable();
        }

        public DataTable GetDataTableAllTableCombo(ref String strValue, ref String strDisplay)
        {
            String strQuery = String.Format(@" SELECT AATableName,AATableNameAliasCaption
					                           FROM dbo.AATableNameAlias
					                           WHERE AAStatus = 'Alive'");
            DataSet ds = new AAColumnAliasController().GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0)
            {
                strValue = "AATableName";
                strDisplay = "AATableNameAliasCaption";
                return ds.Tables[0];
            }
            return new DataTable();
        }

        public DataSet GetAAColumnAliasNameByTableName(String strTableName)
        {
            String strquery = string.Format(@"SELECT    AATableName ,
                                                        AAColumnAliasName,
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

        public bool CheckLotSegmentHasSubAuto(int iICProductID, string strModuleName)
        {
            bool isTrue = false;
            int iLotID = 0;
            string sQry = "";

            iLotID = new ICProductLotsController().GetLotIDByModuleNameAndICProductID(iICProductID, strModuleName);
            if (iLotID == 0)
            {
                ICProductsInfo ICProducts = (ICProductsInfo)new ICProductsController().GetObjectByID(iICProductID);
                if (ICProducts != null)
                    iLotID = ICProducts.FK_ICLotID;

                if (iLotID == 0)
                    iLotID = ((ICLotsInfo)new ICLotsController().GetFirstObject()).ICLotID;

                if (iLotID == 0)
                    isTrue = false;

                sQry = string.Format(@"SELECT *
                        FROM dbo.ICLotSegments
                        WHERE AAStatus = 'Alive'
                                AND FK_ICLotID = {0} 
                    AND ICLotSegments.ICLotSegmentTypeCombo = 'SubAutoNumber'", iLotID);

                DataSet dsICLotSegments = GetDataSet(sQry);
                if (dsICLotSegments != null && dsICLotSegments.Tables.Count > 0 && dsICLotSegments.Tables[0].Rows.Count > 0)
                    isTrue = true;
            }
            return isTrue;
        }
	}
	#endregion
}