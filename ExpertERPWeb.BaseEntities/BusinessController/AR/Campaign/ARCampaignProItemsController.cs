using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCampaignProItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCampaignProItemsController
	//Created Date:Tuesday, April 24, 2012
	//-----------------------------------------------------------
	
	public class ARCampaignProItemsController:BaseBusinessController
	{
		public ARCampaignProItemsController()
		{
			dal= new DALBaseProvider("ARCampaignProItems",typeof(ARCampaignProItemsInfo));
		}
        public DataSet GetDataByProductQtyDate(int iICProductID, double dbQty, DateTime dteDateTime)
        {
            string str = string.Format(@"SELECT * FROM dbo.ARCampaignProItems WHERE AAStatus='Alive'
	                                            AND FK_ARCampaignItemID IN 
		                                                     (SELECT ARCampaignItemID FROM dbo.ARCampaignItems WHERE AAStatus='Alive' AND FK_ICProductID={0} 
                                                                         AND ARCampaignItemFromQty<={1} AND ARCampaignItemToQty>{1}
	                                                                 AND FK_ARCampaignID IN
		                                                                (SELECT ARCampaignID FROM dbo.ARCampaigns WHERE AAStatus='Alive' AND CONVERT(VARCHAR(10), [ARCampaignStartDate], 112)<= CONVERT(VARCHAR(10), '{2}', 112)
							                                                AND	CONVERT(VARCHAR(10), [ARCampaignEndDate], 112)>= CONVERT(VARCHAR(10), '{2}', 112)))"
                                       , iICProductID,dbQty,dteDateTime.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);

        }

        public double GetDiscountPctByCampaignAndProduct(int iCampaignID, int iCampaignItemID, int iProductID)
        {
            String strQuery = String.Format("SELECT ARCampaignProItemDiscPct FROM ARCampaignProItems WHERE AAStatus = 'Alive' AND FK_ARCampaignID = {0} AND FK_ARCampaignItemID = {1} AND FK_ICProductID = {2}",iCampaignID,iCampaignItemID,iProductID);

            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
            }

            return 0;
        }
    }
	#endregion
}