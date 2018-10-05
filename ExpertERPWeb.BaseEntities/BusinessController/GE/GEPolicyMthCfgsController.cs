using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEPolicyMthCfgs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEPolicyMthCfgsController
	//Created Date:Monday, April 03, 2017
	//-----------------------------------------------------------
	
	public class GEPolicyMthCfgsController:BaseBusinessController
	{
		public GEPolicyMthCfgsController()
		{
			dal= new DALBaseProvider("GEPolicyMthCfgs",typeof(GEPolicyMthCfgsInfo));
		}
        public List<BusinessObject> GetAllDataBySortedOrderCondition()
        {
            String strQuery = String.Format(@"SELECT * 
                                                INTO #Tempa
                                                FROM dbo.GEPolicyMthCfgs
                                                WHERE AAStatus = 'Alive' AND LEN(GEPolicyMthCfgOrder) = 3
                                                ORDER BY GEPolicyMthCfgOrder ASC

                                                SELECT * 
                                                INTO #Tempb
                                                FROM dbo.GEPolicyMthCfgs
                                                WHERE AAStatus = 'Alive' AND LEN(GEPolicyMthCfgOrder) = 1
                                                ORDER BY GEPolicyMthCfgOrder ASC

                                                SELECT * 
                                                INTO #Tempc
                                                FROM dbo.GEPolicyMthCfgs
                                                WHERE AAStatus = 'Alive' AND LEN(GEPolicyMthCfgOrder) = 2
                                                ORDER BY GEPolicyMthCfgOrder ASC

                                                SELECT * 
                                                FROM #Tempa 
                                                UNION ALL
                                                SELECT *
                                                FROM #Tempb
                                                UNION ALL 
                                                SELECT *
                                                FROM #Tempc");
            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                List<BusinessObject> lstGEPolicyMthCfgsInfoBySortedOrder = GetListFromDataset(ds);
            }

            return GetListFromDataset(ds);
        }

        public DataTable GetAllDataByCodeTransfer(ref String strValue, ref String strDisplay)
        {
            String strQuery = String.Format(@"( SELECT GEPolicyMthCfgParam 
                                                FROM dbo.GEPolicyMthCfgs
                                                WHERE AAStatus = 'Alive' AND GEPolicyMthCfgCodeTransferCheck = 'True'

                                             )");
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0)
            {
                strValue = "GEPolicyMthCfgParam";
                strDisplay = "GEPolicyMthCfgParam";
                return ds.Tables[0];
            }

            return new DataTable();
        }

        public DataSet GetAllParamByGEFuncTypeID(int iGEFuncTypeID)
        {
            DataSet ds = new DataSet();
            string strQuery = string.Format(@"SELECT * FROM dbo.GEPolicyMthCfgs
                                                WHERE AAStatus = 'Alive'
                                                AND FK_GEFuncTypeID = {0}", iGEFuncTypeID);
            ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;
            else
                return null;
        }
    }
	#endregion
}