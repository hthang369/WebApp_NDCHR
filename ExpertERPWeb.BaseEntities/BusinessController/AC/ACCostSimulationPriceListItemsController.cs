using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationPriceListItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationPriceListItemsController
	//Created Date:21 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationPriceListItemsController:BaseBusinessController
	{
		public ACCostSimulationPriceListItemsController()
		{
			dal= new DALBaseProvider("ACCostSimulationPriceListItems",typeof(ACCostSimulationPriceListItemsInfo));
		}

        public double GetUnitPriceByCostSimulationFactor(int iACCostSimulationFactorID, DateTime dt)
        {
            String str = String.Format(@"   SELECT ACCostSimulationPriceListItemUnitPrice FROM dbo.ACCostSimulationPriceListItems
                                            WHERE AAStatus = 'Alive'
                                            AND FK_ACCostSimulationPriceListID IN (
										                                            SELECT ACCostSimulationPriceListID FROM dbo.ACCostSimulationPriceLists
										                                            WHERE AAStatus = 'Alive'
										                                            )
										    AND CONVERT(VARCHAR, ACCostSimulationPriceListItemFromDate, 112) <= '{1}'
										    AND CONVERT(VARCHAR, ACCostSimulationPriceListItemToDate, 112) >= '{1}'
                                            AND FK_ACCostSimulationFactorID = {0}
                                            ", iACCostSimulationFactorID, dt.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }
	}
	#endregion
}