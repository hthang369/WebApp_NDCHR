using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPCostingConsItemWgts
    //-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLPeriodCostCenterDivItemsController
	//Created Date:24 March 2013
	//-----------------------------------------------------------
	
	public class PPCostingConsItemWgtsController:BaseBusinessController
	{
		public PPCostingConsItemWgtsController()
		{
            dal = new DALBaseProvider("PPCostingConsItemWgts", typeof(PPCostingConsItemWgtsInfo));
		}

        public double GetSumWeight(int iWgtID)
        {
            String strQuery = String.Format(@"SELECT SUM(PPCostingConsItemWgt)
                                                FROM PPCostingConsItemWgts
                                                WHERE FK_PPCostingConsWgtID = {0}
                                                ", iWgtID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        public PPCostingConsItemWgtsInfo GetWgtItem(int iProductID, int iStockID, int iYear, int iPeriod)
        {
            String strQuery = String.Format(@"SELECT PPCostingConsItemWgts.*
                                            FROM PPCostingConsItemWgts, PPCostingConsWgts
                                            WHERE PPCostingConsItemWgts.FK_ICProductID = {0}
                                            AND PPCostingConsItemWgts.FK_PPCostingConsWgtID = PPCostingConsWgts.PPCostingConsWgtID
                                            AND PPCostingConsWgts.FK_ICStockID = {1}
                                            AND PPCostingConsWgts.PPPeriod = {2}
                                            AND PPCostingConsWgts.PPYear = {3}", iProductID, iStockID, iPeriod, iYear);
            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPCostingConsItemWgtsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public DataSet GetAllWgtItem(int iStockID, int iYear, int iPeriod)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.PPCostingConsItemWgts
                                                WHERE FK_PPCostingConsWgtID IN (
									                                                SELECT PPCostingConsWgtID FROM dbo.PPCostingConsWgts
									                                                WHERE FK_ICStockID = {0}
									                                                AND PPPeriod = {1} AND PPYear = {2}
								                                                )", iStockID, iPeriod, iYear);
            return GetDataSet(strQuery);
        }
	}
	#endregion
}