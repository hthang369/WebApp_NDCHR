using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationMethodItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationMethodItemsController
	//Created Date:21 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationMethodItemsController:BaseBusinessController
	{
		public ACCostSimulationMethodItemsController()
		{
			dal= new DALBaseProvider("ACCostSimulationMethodItems",typeof(ACCostSimulationMethodItemsInfo));
		}

        public ACCostSimulationMethodItemsInfo GetDataByCatalogANDFactor(int iACCostSimulationFactorID, int iACCostSimulationMethodCatalogID)
        {
            String str = String.Format(@"SELECT * FROM dbo.ACCostSimulationMethodItems
                                        WHERE AAStatus = 'Alive'
                                        AND FK_ACCostSimulationMethodCatalogID = {0}
                                        AND FK_ACCostSimulationFactorID = {1}"
                                        , iACCostSimulationMethodCatalogID, iACCostSimulationFactorID);
            DataSet ds = dal.GetDataSet(str);
            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (ACCostSimulationMethodItemsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public DataSet GetAllDataByMethodANDObjectType(int iACCostSimulationMethodID, String strObjectTypeCombo)
        {
            String str = String.Format(@"SELECT * FROM dbo.ACCostSimulationMethodItems MethodItem
                                        INNER JOIN dbo.ACCostSimulationMethods Method ON Method.ACCostSimulationMethodID = MethodItem.FK_ACCostSimulationMethodID
                                        INNER JOIN dbo.ACCostSimulationMethodCatalogs MethodCatalog ON MethodCatalog.ACCostSimulationMethodCatalogID = MethodItem.FK_ACCostSimulationMethodCatalogID
                                        WHERE Method.AAStatus = 'Alive' AND MethodItem.AAStatus = 'Alive' AND MethodCatalog.AAStatus = 'Alive'
                                        AND Method.ACCostSimulationMethodID = {0}
                                        AND MethodCatalog.ACCostSimulationObjectTypeCombo LIKE '{1}'
                                        ORDER BY ACCostSimulationMethodItemSortOrder ASC"
                                        , iACCostSimulationMethodID, strObjectTypeCombo);
            return dal.GetDataSet(str);            
        }
	}
	#endregion
}