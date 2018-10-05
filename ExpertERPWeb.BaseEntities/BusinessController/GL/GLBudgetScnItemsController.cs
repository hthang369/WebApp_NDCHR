using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLBudgetScnItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLBudgetScnItemsController
	//Created Date:21 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class GLBudgetScnItemsController:BaseBusinessController
	{
		public GLBudgetScnItemsController()
		{
			dal= new DALBaseProvider("GLBudgetScnItems",typeof(GLBudgetScnItemsInfo));
		}

        public double GetSummaryItemAmt(int iBudgetScnID, String strFieldName)
        {
            String strQuery = String.Format(@"SELECT SUM({0}) FROM GLBudgetScnItems
                                                WHERE AAStatus = 'Alive' AND FK_GLBudgetScnID = {1}", strFieldName, iBudgetScnID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)

                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }
	}
	#endregion
}