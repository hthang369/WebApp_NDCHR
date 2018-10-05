using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICProductStandardCuts
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICProductStandardCutsController
	//Created Date:17 Tháng Bảy 2013
	//-----------------------------------------------------------
	
	public class ICProductStandardCutsController:BaseBusinessController
	{
		public ICProductStandardCutsController()
		{
			dal= new DALBaseProvider("ICProductStandardCuts",typeof(ICProductStandardCutsInfo));
		}
        public double GetInvQtyByProductGroupModelAndLength(int iProductGroup, int iProductModel, double dbFromLength, double dbToLength)
        {
            string strQuery = string.Format(@"Select SUM(ICInventoryStockQuantity) from ICInventoryStocks where AAStatus='Alive' AND 
                                              FK_ICStockID in (select ICStockID from ICStocks where AAStatus='Alive')
                                               AND FK_ICProductID in (select ICProductID from ICProducts where AAStatus='Alive'
                                                                        AND FK_ICProductGroupID={0} AND FK_ICProductModelID={1} AND
                                                                            ICProductLength>={2} AND ICProductLength<={3})"
                                                    , iProductGroup, iProductModel, dbFromLength, dbToLength);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
	}
	#endregion
}