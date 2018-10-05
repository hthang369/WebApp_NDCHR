using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APSemiOrdPlans
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APSemiOrdPlansController
	//Created Date:Wednesday, November 14, 2012
	//-----------------------------------------------------------
	
	public class APSemiOrdPlansController:BaseBusinessController
	{
		public APSemiOrdPlansController()
		{
			dal= new DALBaseProvider("APSemiOrdPlans",typeof(APSemiOrdPlansInfo));
		}
        public double GetTotalPOQtyByProduct(int iShpPlanItemID, int iProductID)
        {
            String str = String.Format(@"SELECT SUM(APSemiOrdPlanOnPOQty) FROM APSemiOrdPlans WHERE AAStatus='Alive' AND FK_ARShpPlanItemID={0} AND FK_ICProductID={1}", iShpPlanItemID, iProductID);
            DataSet ds = dal.GetDataSet(str);
            if (ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0 && ds.Tables[0].Rows[0][0]!=DBNull.Value)
            {
                return double.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return 0;
        }
        public double GetTotalPORcpQtyByProduct(int iShpPlanItemID, int iProductID)
        {
            String str = String.Format(@"SELECT SUM(APSemiOrdPlanOnPORcpQty) FROM APSemiOrdPlans WHERE AAStatus='Alive' AND FK_ARShpPlanItemID={0} AND FK_ICProductID={1}", iShpPlanItemID, iProductID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return double.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return 0;
        }
        public DataSet GetAllDataByPOItemID(int iPOItemID)
        {
            string strQuery = string.Format(@"Select * from APSemiOrdPlans where AAStatus='Alive' AND 
                                                  APSemiOrdPlanID in (select FK_APSemiOrdPlanID from APPOItemSemiOrdPlans where FK_APPOItemID={0})", iPOItemID);
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}