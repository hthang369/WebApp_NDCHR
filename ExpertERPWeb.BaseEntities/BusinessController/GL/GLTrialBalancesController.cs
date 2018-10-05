using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTrialBalances
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLTrialBalancesController
	//Created Date:Saturday, July 11, 2009
	//-----------------------------------------------------------
	
	public class GLTrialBalancesController:BaseBusinessController
	{
		public GLTrialBalancesController()
		{
			dal= new DALBaseProvider("GLTrialBalances",typeof(GLTrialBalancesInfo));
		}
        
        public void DeleteAllRow()
        {
            string strQuery = "DELETE FROM GLTrialBalances";
            GMCDbUtil.ExecuteQuery(strQuery);
        }

        public double GetSumEndDebit()
        {
            string strQuery = String.Format(@"SELECT SUM(GLAccountEndDebitAmt) FROM dbo.GLTrialBalances");
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
    }

    
	#endregion
}