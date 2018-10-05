using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEFuncs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEFuncsController
	//Created Date:Monday, April 03, 2017
	//-----------------------------------------------------------
	
	public class GEFuncsController:BaseBusinessController
	{
		public GEFuncsController()
		{
			dal= new DALBaseProvider("GEFuncs",typeof(GEFuncsInfo));
		}

        public double GetResultByCondition(GEFuncsInfo objGEFuncsInfo, int iARCustomerID, int iHREmployees, DateTime dtFrom, DateTime dtTo, string strWhere)
        {
            String strQuery = String.Format(objGEFuncsInfo.GEFuncQuery, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"), strWhere, iARCustomerID, iHREmployees);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        public double GetResultByCondition_Allowance(GEFuncsInfo objGEFuncsInfo,int iHREmployees, DateTime dtFrom, DateTime dtTo, string strWhere)
        {
            String strQuery = String.Format(objGEFuncsInfo.GEFuncQuery, iHREmployees,dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"), strWhere);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }
    }
	#endregion
}