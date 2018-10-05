using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCostInCompletes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionCostInCompletesController
	//Created Date:27 Tháng Mười Một 2014
	//-----------------------------------------------------------
	
	public class PPProductionCostInCompletesController:BaseBusinessController
	{
		public PPProductionCostInCompletesController()
		{
			dal= new DALBaseProvider("PPProductionCostInCompletes",typeof(PPProductionCostInCompletesInfo));
		}

        public void DeleteAllDataByYearANDPeriod(int iYear, int iPeriod)
        {
            String str = String.Format(@"   DELETE dbo.PPProductionCostInCompletes
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}"
                                            , iYear, iPeriod);
            dal.GetDataSet(str);
        }
        public DataSet GetAllDataByYearANDPeriod(int iYear, int iPeriod)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPProductionCostInCompletes
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}"
                                            , iYear, iPeriod);
            return dal.GetDataSet(str);
        }

        public DataSet GetAllDataByYearANDPeriod(int iYear, int iPeriod, int iPPProductionCostCenterID)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPProductionCostInCompletes
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}
                                            AND FK_PPProductionCostCenterID = {2}"
                                            , iYear, iPeriod, iPPProductionCostCenterID);
            return dal.GetDataSet(str);
        }

        public Boolean CheckDataInYearANDPeriod(int iYear, int iPeriod)
        {
            DataSet ds = GetAllDataByYearANDPeriod(iYear, iPeriod);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0) return true;
            return false;
        }
        
        public DataSet TapHopSanPhamDoDangCuoiKy(int iYear, int iPeriod)
        {
            String str = String.Format(@"SELECT  FK_ICProductID ,
                                                PPInCompleteStatisticItems.FK_PPCostCenterID ,
		                                        PPProductionCostCenterID AS FK_PPProductionCostCenterID,
                                                FK_PPPhaseCfgID ,
                                                PPInCompleteStatisticItemID AS FK_PPInCompleteStatisticItemID,
                                                PPInCompleteStatisticItemNVLPct AS PPProductionCostInCompleteNVLPct ,
                                                PPInCompleteStatisticItemNCPct AS PPProductionCostInCompleteNCPct,
                                                PPInCompleteStatisticItemSXCPct AS PPProductionCostInCompleteSXCPct,
		                                        PPYear, PPPeriod,
                                                PPInCompleteStatisticItemQty AS PPProductionCostInCompleteQty
                                        FROM    dbo.PPInCompleteStatisticItems
                                                INNER JOIN dbo.PPInCompleteStatistics ON ( PPInCompleteStatistics.PPInCompleteStatisticID = PPInCompleteStatisticItems.FK_PPInCompleteStatisticID
                                                                                           AND PPInCompleteStatistics.AAStatus = PPInCompleteStatisticItems.AAStatus
                                                                                           AND YEAR(PPInCompleteStatisticDate) = {0}
                                                                                           AND MONTH(PPInCompleteStatisticDate) = {1}
                                                                                         )
                                                INNER JOIN dbo.PPProductionCostCenters ON ( PPProductionCostCenters.FK_PPCostCenterID = PPInCompleteStatisticItems.FK_PPCostCenterID
                                                                                            AND PPYear = {0}
                                                                                            AND PPPeriod = {1}
                                                                                          )
                                        "
                                        , iYear, iPeriod);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}