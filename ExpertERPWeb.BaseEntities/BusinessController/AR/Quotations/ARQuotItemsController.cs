using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARQuotItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARQuotItemsController
	//Created Date:Friday, January 15, 2010
	//-----------------------------------------------------------
	
	public class ARQuotItemsController:BaseBusinessController
	{
		public ARQuotItemsController()
		{
			dal= new DALBaseProvider("ARQuotItems",typeof(ARQuotItemsInfo));
		}

        public List<ARQuotItemsInfo> GetListQuotItemByARSellerIDFromFDateAndTDate(int iARSellerID, DateTime dteFDate, DateTime dteTDate)
        {
            List<ARQuotItemsInfo> lstARQuotItems = new List<ARQuotItemsInfo>();
            DataSet dsARQuots = new DataSet();
            String strQuery = String.Format("SELECT * FROM [dbo].[ARQuots] WHERE [FK_ARSellerID]={0} AND CONVERT(VARCHAR(10), [ARQuotDate], 112)>= CONVERT(VARCHAR(10), '{1}', 112) AND CONVERT(VARCHAR(10), [ARQuotDate], 112)<= CONVERT(VARCHAR(10), '{2}', 112) AND [AAStatus]='{3}'", iARSellerID, dteFDate.ToString("yyyyMMdd"), dteTDate.ToString("yyyyMMdd"), BusinessObject.DefaultAAStatus);
            dsARQuots = dal.GetDataSet(strQuery);
            if (dsARQuots != null)
            {
                foreach (DataRow row in dsARQuots.Tables[0].Rows)
                { 
                    ARQuotsInfo  objARQuotsInfo = (ARQuotsInfo)new ARQuotsController().GetObjectFromDataRow(row);
                    DataSet dsARQuotItems = new ARQuotItemsController().GetAllDataByForeignColumn("FK_ARQuotID", objARQuotsInfo.ARQuotID);
                    if (dsARQuotItems != null)
                    {

                        foreach (DataRow rowItem in dsARQuotItems.Tables[0].Rows)
                        {
                            ARQuotItemsInfo objARQuotItemsInfo = (ARQuotItemsInfo)new ARQuotItemsController().GetObjectFromDataRow(rowItem);
                            if(objARQuotItemsInfo != null)
                                lstARQuotItems.Add(objARQuotItemsInfo);
                        }
                    }
                }
            }
            return lstARQuotItems;
        }

	}
	#endregion
}