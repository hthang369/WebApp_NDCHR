using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPConsolidateCosts
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPConsolidateCostsController
	//Created Date:20 Tháng Tư 2011
	//-----------------------------------------------------------
	
	public class PPConsolidateCostsController:BaseBusinessController
	{
		public PPConsolidateCostsController()
		{
			dal= new DALBaseProvider("PPConsolidateCosts",typeof(PPConsolidateCostsInfo));
		}

        public void DeleteAllObjectBYPeriodAndYear(int period, int year)
        {
            string strQuery = String.Format("delete PPConsolidateCosts where PPPeriod = {0} and PPYear = {1}", period, year);
            GMCDbUtil.ExecuteQuery(strQuery);
        }

        public DataSet GetConsolidateCostIDBYPeriodAndYear(int period, int year)
        {
            string strQuery = String.Format("Select PPConsolidateCostID from PPConsolidateCosts where PPPeriod = {0} and PPYear = {1}", period, year);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllObjectBYPeriodAndYear(int period, int year)
        {
            string strQuery = String.Format("Select * from PPConsolidateCosts where PPPeriod = {0} and PPYear = {1}", period, year);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetConsolidateCostInPeriod(int iPeriod, int iYear)
        {
            String strQuery = String.Format("SELECT * FROM PPConsolidateCosts WHERE PPPeriod = {0} and PPYear = {1}", iPeriod, iYear);
            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}