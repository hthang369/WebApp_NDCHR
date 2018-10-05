using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GECurrencyExs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GECurrencyExsController
	//Created Date:Tuesday, April 05, 2011
	//-----------------------------------------------------------
	
	public class GECurrencyExsController:BaseBusinessController
	{
		public GECurrencyExsController()
		{
			dal= new DALBaseProvider("GECurrencyExs",typeof(GECurrencyExsInfo));
		}

        public GECurrencyExsInfo GetLastDataByCurrencyID(int currecyID, DateTime date)
        {
            string strQuery = string.Format(@"
SELECT TOP 1 * 
    FROM GECurrencyExs 
    WHERE FK_GECurrencyID = {0}
        AND CONVERT(VARCHAR(20), GECurrencyExDate, 112) <= '{1}'
    ORDER BY GECurrencyExDate DESC"
                , currecyID, date.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                GECurrencyExsInfo CurrencyExsInfo = (GECurrencyExsInfo)new GECurrencyExsController().GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return CurrencyExsInfo;
            }
            return null;
        }
        public GECurrencyExsInfo GetLastDataByCurrencyID(int currecyID, DateTime date, int piCurrencyExObjID)
        {
            string strQuery = string.Format(@"
SELECT TOP 1 * 
    FROM GECurrencyExs 
    WHERE FK_GECurrencyID = {0}
        AND (FK_GECurrencyExObjID = {2})
        AND CONVERT(VARCHAR(20), GECurrencyExDate, 112) <= '{1}'
    ORDER BY GECurrencyExDate DESC"
                , currecyID, date.ToString("yyyyMMdd"), piCurrencyExObjID);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                GECurrencyExsInfo CurrencyExsInfo = (GECurrencyExsInfo)new GECurrencyExsController().GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return CurrencyExsInfo;
            }
            return null;
        }
	}
	#endregion
}