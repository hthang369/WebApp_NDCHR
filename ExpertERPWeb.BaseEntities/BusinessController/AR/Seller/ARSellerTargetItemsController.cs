using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerTargetItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARSellerTargetItemsController
	//Created Date:Thursday, May 10, 2012
	//-----------------------------------------------------------
	
	public class ARSellerTargetItemsController:BaseBusinessController
	{
		public ARSellerTargetItemsController()
		{
			dal= new DALBaseProvider("ARSellerTargetItems",typeof(ARSellerTargetItemsInfo));
		}
        public DataSet GetAllDataBySellerPeriodYear(int iARSellerID, int iPeriod, int iYear)
        {
            string strQuery = string.Format("select * from ARSellerTargetItems where FK_ARSellerID={0} AND ARSellerTargetItemPeriod={1} AND ARSellerTargetItemYear={2} AND AAStatus='Alive'"
                ,iARSellerID,iPeriod,iYear);
            return dal.GetDataSet(strQuery);
        }
        public double GetTargetAmtBySellerIDProductIDPeriodYear(int iSellerID,int iICProductID, int iPeriod, int iYear)
        {
            string str = string.Format(@"SELECT ARSellerTargetItemAmt FROM ARSellerTargetItems WHERE AAStatus='Alive' AND FK_ARSellerID={0} AND 
                                                ARSellerTargetItemPeriod={1} AND ARSellerTargetItemYear={2} AND FK_ICProductID={3}"
                                        , iSellerID, iPeriod, iYear,iICProductID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
	}
	#endregion
}