using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLPeriodCostCenterDivs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLPeriodCostCenterDivsController
	//Created Date:14 March 2013
	//-----------------------------------------------------------
	
	public class PPCostingConsWgtsController:BaseBusinessController
	{
		public PPCostingConsWgtsController()
		{
            dal = new DALBaseProvider("PPCostingConsWgts", typeof(PPCostingConsWgtsInfo));
		}

        public DataSet GetAllConsWgts(int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM PPCostingConsWgts
                                                WHERE PPPeriod = {0} AND PPYear = {1}", iPeriod, iYear);

            return GetDataSet(strQuery);
        }

        public PPCostingConsWgtsInfo GetConsWgt(int iPeriod, int iYear, int iCostCenterID)
        {
            String strQuery = String.Format(@"SELECT * FROM PPCostingConsWgts
                                                WHERE PPPeriod = {0} AND PPYear = {1}
                                                AND FK_GLCostCenterID = {2}", iPeriod, iYear, iCostCenterID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPCostingConsWgtsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }

        public DataSet GenerateCostingConsWgts(int iYear, int iPeriod)
        {
            String strQuery = String.Format(@"SELECT GLCostCenters.GLCostCenterID AS FK_GLCostCenterID,
                                                0 AS Weight
                                                FROM GLCostCenters, ICStocks
                                                WHERE GLCostCenters.FK_ICStockID = ICStocks.ICStockID
                                                AND GLCostCenters.AAStatus = 'Alive'
                                                AND ICStocks.AAStatus = 'Alive'
                                                ");
            return GetDataSet(strQuery);
        }

        public void DeleteAllCostingConsWgtsInPeriod(int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"DELETE PPCostingConsItemWgts
                                                    WHERE FK_PPCostingConsWgtID
                                                    IN (SELECT PPCostingConsWgtID FROM PPCostingConsWgts
                                                            WHERE PPPeriod = {0}
                                                            AND PPYear = {1})
                                            DELETE PPCostingConsWgts
                                                    WHERE PPPeriod = {0}
                                                    AND PPYear = {1} ", iPeriod, iYear);

            GetDataSet(strQuery);
        }

        public PPCostingConsWgtsInfo GetConsWgtsByStockANDPeriod(int iStockID, int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"  SELECT * FROM PPCostingConsWgts
                                                WHERE FK_ICStockID = {0}
                                                AND PPPeriod = {1} AND PPYear = {2}",iStockID, iPeriod, iYear);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPCostingConsWgtsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
	}
	#endregion
}