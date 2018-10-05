using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPCostingNormLabours
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPCostingNormLaboursController
	//Created Date:Tuesday, September 20, 2016
	//-----------------------------------------------------------
	
	public class PPCostingNormLaboursController:BaseBusinessController
	{
		public PPCostingNormLaboursController()
		{
			dal= new DALBaseProvider("PPCostingNormLabours",typeof(PPCostingNormLaboursInfo));
		}
        public DataSet GetAllDataByArrayPPCostingNormProductID(string[] arrPPCostingNormProductID)
        {
            string strQuery = string.Format(@"
                                            SELECT  *
                                            FROM    dbo.PPCostingNormLabours
                                            WHERE   FK_PPCostingNormProductID IN ({0})
                                                    AND AAStatus = 'Alive'
                                            ", string.Join(",", arrPPCostingNormProductID)
                                            );
            return GetDataSet(strQuery);
        }
        public DataSet GetAllDataByArrayPPNormID(string[] arrPPNormID)
        {
            string strSubQuery = DALUtil.GenerateColumnsFromTable("PPNormLabours", dal.TableName);
            string strQuery = string.Format(@"{0}
                            DECLARE @sql NVARCHAR(MAX)
                            SET @sql = 'SELECT  ' + @column + '
                                        FROM    {1}
                                        WHERE   FK_PPNormID IN ({2})
                                                AND AAStatus =  ''Alive'''
                            EXEC sp_executesql @sql
                                            ", strSubQuery, "PPNormLabours", string.Join(",", arrPPNormID)
                                            );
            return GetDataSet(strQuery);
        }

        public void UpdateAAStatusByCostingNormProduct(string[] arrPPCostingNormProductID,string pAAStatus)
        {
            string strQuery = string.Format(@"
                                            UPDATE dbo.PPCostingNormLabours
                                            SET AAStatus='{1}'
                                            WHERE FK_PPCostingNormProductID IN ({0})                                                
                                            ", string.Join(",", arrPPCostingNormProductID), pAAStatus);
            GetDataSet(strQuery);
        }
    }
	#endregion
}