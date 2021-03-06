using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPInvoiceItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPInvoiceItemsController
	//Created Date:Friday, July 10, 2009
	//-----------------------------------------------------------
	
	public class APPInvoiceItemsController:BaseBusinessController
	{
        private readonly String spAPPInvoiceItems_SelectMaxProductQtyByAPSupplierIDAndFDateTDate = "APPInvoiceItems_SelectMaxProductQtyByAPSupplierIDAndFDateTDate";
        private readonly String spAPPInvoiceItems_SelectMinProductQtyByAPSupplierIDAndFDateTDate = "APPInvoiceItems_SelectMinProductQtyByAPSupplierIDAndFDateTDate";
		public APPInvoiceItemsController()
		{
			dal= new DALBaseProvider("APPInvoiceItems",typeof(APPInvoiceItemsInfo));
		}

        public DataSet GetItemAPPInvoiceByID(int ObjectID)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.APPInvoiceItems WHERE AAStatus='Alive' AND FK_APPInvoiceID = {0}", ObjectID);
            return dal.GetDataSet(strQuery);
        }
        public double GetTotalPInvoicedQuantityOfReceiptItem ( int iICReceiptItemID )
        {
            double dbTotalPInvoicedQuantity = 0;
            try
            {
                DataSet ds = dal.GetDataSet( "APPInvoiceItems_SelectTotalPInvoicedQuantityByICReceiptItemID" , iICReceiptItemID );
                if ( ds.Tables.Count > 0 )
                {
                    if ( ds.Tables[0].Rows.Count > 0 )
                    {
                        dbTotalPInvoicedQuantity += Convert.ToDouble( ds.Tables[0].Rows[0][0] );
                    }
                }
                return dbTotalPInvoicedQuantity;
            } catch ( Exception )
            {
                return 0;
            }
        }

        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.17
        /// Desc: Get DataSet Max Product Qty within APPInvoiceItems
        /// </summary>
        /// <param name="iFK_APSupplierID"></param>
        /// <param name="dtFDate"></param>
        /// <param name="dtTDate"></param>
        /// <returns></returns>
        public DataSet GetMaxProductQtyByFK_APSupplierID(int iFK_APSupplierID, DateTime dtFDate, DateTime dtTDate)
        {
            DataSet dsAPPInvoiceItems = new DataSet();
            DataSet ds = dal.GetDataSet(spAPPInvoiceItems_SelectMaxProductQtyByAPSupplierIDAndFDateTDate, iFK_APSupplierID, dtFDate, dtTDate);
            if (ds != null)
            {
                dsAPPInvoiceItems = ds.Clone();
                if (ds.Tables.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        APPInvoiceItemsInfo objAPPInvoiceItemsInfo = (APPInvoiceItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                        if (objAPPInvoiceItemsInfo != null)
                        {
                            int iMaxQty = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                            if (objAPPInvoiceItemsInfo.APPInvoiceItemQty == iMaxQty)
                            {
                                DataRow row = (DataRow)ds.Tables[0].Rows[i];
                                dsAPPInvoiceItems.Tables[0].ImportRow(row);
                            }
                            else
                                break;
                        }
                    }
                }
            }
            return dsAPPInvoiceItems;
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.17
        /// Desc: Get DataSet Min Product Qty within APPInvoiceItems
        /// </summary>
        /// <param name="iFK_APSupplierID"></param>
        /// <param name="dtFDate"></param>
        /// <param name="dtTDate"></param>
        /// <returns></returns>
        public DataSet GetMinProductQtyByFK_APSupplierID(int iFK_APSupplierID, DateTime dtFDate, DateTime dtTDate)
        {
            DataSet dsAPPInvoiceItems = new DataSet();
            DataSet ds = dal.GetDataSet(spAPPInvoiceItems_SelectMinProductQtyByAPSupplierIDAndFDateTDate, iFK_APSupplierID, dtFDate, dtTDate);
            if (ds != null)
            {
                dsAPPInvoiceItems = ds.Clone();
                if (ds.Tables.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        APPInvoiceItemsInfo objAPPInvoiceItemsInfo = (APPInvoiceItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                        if (objAPPInvoiceItemsInfo != null)
                        {
                            int iMinQty = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                            if (objAPPInvoiceItemsInfo.APPInvoiceItemQty == iMinQty)
                            {
                                DataRow row = (DataRow)ds.Tables[0].Rows[i];
                                dsAPPInvoiceItems.Tables[0].ImportRow(row);
                            }
                            else
                                break;
                        }
                    }
                }
            }
            return dsAPPInvoiceItems;
        }

        public double GetSumFAmtTotByPO(int iPOID)
        {
            String strQuery = String.Format(@"SELECT     SUM(dbo.APPInvoiceItems.APPInvoiceItemFAmtTot)
                                                FROM         dbo.APPInvoiceItems 
				                                                INNER JOIN dbo.APPInvoices ON dbo.APPInvoiceItems.FK_APPInvoiceID = dbo.APPInvoices.APPInvoiceID 
				                                                INNER JOIN dbo.APPInvoiceItemReceiptItems ON dbo.APPInvoiceItems.APPInvoiceItemID = dbo.APPInvoiceItemReceiptItems.FK_APPInvoiceItemID 
				                                                INNER JOIN dbo.APPInvoiceReceipts ON dbo.APPInvoices.APPInvoiceID = dbo.APPInvoiceReceipts.FK_APPInvoiceID 
				                                                INNER JOIN dbo.ICReceiptItems ON dbo.APPInvoiceItemReceiptItems.FK_ICReceiptItemID = dbo.ICReceiptItems.ICReceiptItemID 
				                                                INNER JOIN dbo.ICReceipts ON dbo.APPInvoiceReceipts.FK_ICReceiptID = dbo.ICReceipts.ICReceiptID AND  dbo.ICReceiptItems.FK_ICReceiptID = dbo.ICReceipts.ICReceiptID 
                                                                INNER JOIN dbo.ICReceiptItemPurchaseOrderItems ON dbo.ICReceiptItems.ICReceiptItemID = dbo.ICReceiptItemPurchaseOrderItems.FK_ICReceiptItemID 
                                                                INNER JOIN dbo.ICReceiptPOs ON dbo.ICReceipts.ICReceiptID = dbo.ICReceiptPOs.FK_ICReceiptID 
                                                                INNER JOIN dbo.APPOItems ON dbo.ICReceiptItemPurchaseOrderItems.FK_APPOItemID = dbo.APPOItems.APPOItemID 
                                                                INNER JOIN dbo.APPOs ON dbo.ICReceiptPOs.FK_APPOID = dbo.APPOs.APPOID AND dbo.APPOItems.FK_APPOID = dbo.APPOs.APPOID
                                                    WHERE dbo.APPInvoices.AAStatus='Alive' 
		                                                AND dbo.APPInvoiceItems.AAStatus='Alive'
		                                                AND dbo.ICReceipts.AAStatus='Alive'
		                                                AND dbo.ICReceiptItems.AAStatus='Alive'
		                                                AND dbo.APPOs.AAStatus='Alive'
		                                                AND dbo.APPOItems.AAStatus='Alive'
		                                                AND dbo.APPOs.APPOID={0}", iPOID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }
	}
	#endregion
}