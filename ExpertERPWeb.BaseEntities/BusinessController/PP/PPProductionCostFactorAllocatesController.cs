using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCostFactorAllocates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionCostFactorAllocatesController
	//Created Date:20 Tháng Mười Một 2014
	//-----------------------------------------------------------
	
	public class PPProductionCostFactorAllocatesController:BaseBusinessController
	{
		public PPProductionCostFactorAllocatesController()
		{
			dal= new DALBaseProvider("PPProductionCostFactorAllocates",typeof(PPProductionCostFactorAllocatesInfo));
		}

        public void DeleteAllDataByYearANDPeriod(int iYear, int iPeriod)
        {
            String str = String.Format(@"   DELETE dbo.PPProductionCostFactorAllocates
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}"
                                            , iYear, iPeriod);
            dal.GetDataSet(str);
        }

        public DataSet GetAllDataByYearANDPeriod(int iYear, int iPeriod)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPProductionCostFactorAllocates
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}"
                                            , iYear, iPeriod);
            return dal.GetDataSet(str);
        }

        public DataSet GetAllDataByYearANDPeriod(int iYear, int iPeriod, int iPPCostCenterID)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPProductionCostFactorAllocates
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}
                                            AND FK_PPCostCenterID = {2}"
                                            , iYear, iPeriod);
            return dal.GetDataSet(str);
        }

        public PPProductionCostFactorAllocatesInfo GetDataByYearANDPeriodANDCostCenterANDCostFactor(int iYear, int iPeriod, int iPPProductionCostCenterID, int iPPProductionCostFactorID)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPProductionCostFactorAllocates
                                            WHERE PPYear = {0}
                                            AND PPPeriod = {1}
                                            AND FK_PPProductionCostCenterID = {2}
                                            AND FK_PPProductionCostFactorID = {3}"
                                            , iYear, iPeriod, iPPProductionCostCenterID, iPPProductionCostFactorID);
            DataSet ds = dal.GetDataSet(str);
            if(ds!=null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPProductionCostFactorAllocatesInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public Boolean CheckDataInYearANDPeriod(int iYear, int iPeriod)
        {
            DataSet ds = GetAllDataByYearANDPeriod(iYear, iPeriod);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0) return true;
            return false;
        }
	}
	#endregion
}