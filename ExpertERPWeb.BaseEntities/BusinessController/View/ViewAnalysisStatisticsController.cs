using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewAnalysisStatistics
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewAnalysisStatisticsController
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class ViewAnalysisStatisticsController:BaseBusinessController
	{
		public ViewAnalysisStatisticsController()
		{
			dal= new DALBaseProvider("ViewAnalysisStatistics",typeof(ViewAnalysisStatisticsInfo));
		}

        public DataSet GetAllData(int iProductID, int iSupplierID, int iCustomerID, String strType, DateTime? dtFrom, DateTime? dtTo, int iDimention1ID, int iDimention2ID, int iDimention3ID, int iDimention4ID, int iDimention5ID)
        {
            String strDimention = "";
            if (iDimention1ID != 0)
            {
                strDimention += String.Format(@"AND FK_ICProductID IN (SELECT ICProductID FROM ICProducts WHERE AAStatus='Alive' AND (FK_ICProductDimention1ID ={0} OR FK_ICProductDimention2ID ={0} OR FK_ICProductDimention3ID ={0} OR FK_ICProductDimention4ID ={0} OR FK_ICProductDimention5ID ={0}))", iDimention1ID);
            }

            if (iDimention2ID != 0)
            {
                strDimention += String.Format(@"AND FK_ICProductID IN (SELECT ICProductID FROM ICProducts WHERE AAStatus='Alive' AND (FK_ICProductDimention1ID ={0} OR FK_ICProductDimention2ID ={0} OR FK_ICProductDimention3ID ={0} OR FK_ICProductDimention4ID ={0} OR FK_ICProductDimention5ID ={0}))", iDimention2ID);
            }

            if (iDimention3ID != 0)
            {
                strDimention += String.Format(@"AND FK_ICProductID IN (SELECT ICProductID FROM ICProducts WHERE AAStatus='Alive' AND (FK_ICProductDimention1ID ={0} OR FK_ICProductDimention2ID ={0} OR FK_ICProductDimention3ID ={0} OR FK_ICProductDimention4ID ={0} OR FK_ICProductDimention5ID ={0}))", iDimention3ID);
            }

            if (iDimention4ID != 0)
            {
                strDimention += String.Format(@"AND FK_ICProductID IN (SELECT ICProductID FROM ICProducts WHERE AAStatus='Alive' AND (FK_ICProductDimention1ID ={0} OR FK_ICProductDimention2ID ={0} OR FK_ICProductDimention3ID ={0} OR FK_ICProductDimention4ID ={0} OR FK_ICProductDimention5ID ={0}))", iDimention4ID);
            }

            if (iDimention5ID != 0)
            {
                strDimention += String.Format(@"AND FK_ICProductID IN (SELECT ICProductID FROM ICProducts WHERE AAStatus='Alive' AND (FK_ICProductDimention1ID ={0} OR FK_ICProductDimention2ID ={0} OR FK_ICProductDimention3ID ={0} OR FK_ICProductDimention4ID ={0} OR FK_ICProductDimention5ID ={0}))", iDimention5ID);
            }

            if (iProductID != 0)
            {
                strDimention += String.Format(@"AND FK_ICProductID = {0}", iProductID);
            }

            strDimention += String.Format(@" AND FK_ICProductID IN (SELECT ICProductID FROM ICProducts WHERE AAStatus='Alive' AND ICProductIsStkItm='True')");

            String str = "";

            if (strType == "SO")
            {
                str += String.Format(@"SELECT   D.ARCustomerID AS FK_ARCustomerID, 
                                                D.ARCustomerName, 
                                                A.ARSONo AS ViewAnalysisStatisticDocNo, 
                                                A.ARSODate AS ViewAnalysisStatisticDocDate,
                                                C.ICProductID AS FK_ICProductID, 
                                                C.ICProductName, 
                                                B.ARSOItemQty AS ViewAnalysisStatisticQty, 
                                                B.ARSOItemUnitPrice AS ViewAnalysisStatisticUnitPrice, 
                                                B.ARSOItemFUnitPrice AS ViewAnalysisStatisticFUnitPrice, 
                                                B.ARSOItemPrice AS ViewAnalysisStatisticPrice, 
                                                B.ARSOItemFPrice AS ViewAnalysisStatisticFPrice,
                                                'SO' AS ViewAnalysisStatisticTypeCombo
                                        FROM dbo.ARSOs A INNER JOIN dbo.ARSOItems B ON A.ARSOID = B.FK_ARSOID LEFT JOIN ICProducts C ON C.ICProductID=B.FK_ICProductID LEFT JOIN ARCustomers D ON D.ARCustomerID=A.FK_ARCustomerID
                                        WHERE A.AAStatus='Alive' AND B.AAStatus='Alive'");
                if (iCustomerID != 0)
                {
                    str += String.Format(@"AND A.FK_ARCustomerID={0}", iCustomerID);
                }
                str += strDimention + ConvertDateFromDateToByColumn("ARSODate", dtFrom, dtTo);
            }
            else if (strType == "Invoice")
            {
                str += String.Format(@"SELECT   D.ARCustomerID AS FK_ARCustomerID,  
                                                D.ARCustomerName,
                                                A.ARInvoiceNo AS ViewAnalysisStatisticDocNo, 
                                                A.ARInvoiceDate AS ViewAnalysisStatisticDocDate,
                                                C.ICProductID AS FK_ICProductID, 
                                                C.ICProductName, 
                                                B.ARInvoiceItemQty AS ViewAnalysisStatisticQty, 
                                                B.ARInvoiceItemUnitPrice AS ViewAnalysisStatisticUnitPrice, 
                                                B.ARInvoiceItemFUnitPrice AS ViewAnalysisStatisticFUnitPrice, 
                                                B.ARInvoiceItemPrice AS ViewAnalysisStatisticPrice, 
                                                B.ARInvoiceItemFPrice AS ViewAnalysisStatisticFPrice,
                                                'Invoice' AS ViewAnalysisStatisticTypeCombo
                                        FROM dbo.ARInvoices A INNER JOIN dbo.ARInvoiceItems B ON A.ARInvoiceID = B.FK_ARInvoiceID LEFT JOIN ICProducts C ON C.ICProductID=B.FK_ICProductID LEFT JOIN ARCustomers D ON D.ARCustomerID=A.FK_ARCustomerID
                                        WHERE A.AAStatus='Alive' AND B.AAStatus='Alive'");
                if (iCustomerID != 0)
                {
                    str += String.Format(@"AND A.FK_ARCustomerID={0}", iCustomerID);
                }
                str += strDimention + ConvertDateFromDateToByColumn("ARInvoiceDate", dtFrom, dtTo);
            }
            else if (strType == "PO")
            {
                str += String.Format(@"SELECT   D.APSupplierID AS FK_APSupplierID, 
                                                D.APSupplierName,
                                                A.APPONo AS ViewAnalysisStatisticDocNo, 
                                                A.APPODate AS ViewAnalysisStatisticDocDate,
                                                C.ICProductID AS FK_ICProductID, 
                                                C.ICProductName, 
                                                B.APPOItemQty AS ViewAnalysisStatisticQty, 
                                                B.APPOItemUnitPrice AS ViewAnalysisStatisticUnitPrice, 
                                                B.APPOItemFUnitPrice AS ViewAnalysisStatisticFUnitPrice, 
                                                B.APPOItemPrice AS ViewAnalysisStatisticPrice, 
                                                B.APPOItemFPrice AS ViewAnalysisStatisticFPrice,
                                                'PO' AS ViewAnalysisStatisticTypeCombo
                                        FROM dbo.APPOs A INNER JOIN dbo.APPOItems B ON A.APPOID = B.FK_APPOID LEFT JOIN ICProducts C ON C.ICProductID=B.FK_ICProductID LEFT JOIN APSuppliers D ON D.APSupplierID=A.FK_APSupplierID
                                        WHERE A.AAStatus='Alive' AND B.AAStatus='Alive'");
                if (iSupplierID != 0)
                {
                    str += String.Format(@"AND A.FK_APSupplierID={0}", iSupplierID);
                }
                str += strDimention + ConvertDateFromDateToByColumn("APPODate", dtFrom, dtTo);
            }
            else if (strType == "PInvoice")
            {
                str += String.Format(@"SELECT   D.APSupplierID AS FK_APSupplierID, 
                                                D.APSupplierName,
                                                A.APPInvoiceNo AS ViewAnalysisStatisticDocNo, 
                                                A.APPInvoiceDate AS ViewAnalysisStatisticDocDate,
                                                C.ICProductID AS FK_ICProductID, 
                                                C.ICProductName, 
                                                B.APPInvoiceItemQty AS ViewAnalysisStatisticQty, 
                                                B.APPInvoiceItemUnitPrice AS ViewAnalysisStatisticUnitPrice, 
                                                B.APPInvoiceItemFUnitPrice AS ViewAnalysisStatisticFUnitPrice, 
                                                B.APPInvoiceItemPrice AS ViewAnalysisStatisticPrice, 
                                                B.APPInvoiceItemFPrice AS ViewAnalysisStatisticFPrice,
                                                'PInvoice' AS ViewAnalysisStatisticTypeCombo
                                        FROM dbo.APPInvoices A INNER JOIN dbo.APPInvoiceItems B ON A.APPInvoiceID = B.FK_APPInvoiceID LEFT JOIN ICProducts C ON C.ICProductID=B.FK_ICProductID LEFT JOIN APSuppliers D ON D.APSupplierID=A.FK_APSupplierID
                                        WHERE A.AAStatus='Alive' AND B.AAStatus='Alive'");
                if (iSupplierID != 0)
                {
                    str += String.Format(@"AND A.FK_APSupplierID={0}", iSupplierID);
                }
                str += strDimention + ConvertDateFromDateToByColumn("APPInvoiceDate", dtFrom, dtTo);
            }
            return dal.GetDataSet(str);
        }
        public String ConvertDateFromDateToByColumn(String strColumnName, DateTime? dtFrom, DateTime? dtTo)
        {
            String str = "";
            if (dtFrom == null && dtTo != null)
            {
                str += String.Format(@"   AND CONVERT(VARCHAR(20), {0}, 112) <= CONVERT(VARCHAR(20),'{1}',112)", strColumnName, dtTo.Value.ToString("yyyyMMdd"));
            }
            else if (dtFrom != null && dtTo == null)
            {
                str += String.Format(@"   AND CONVERT(VARCHAR(20), {0}, 112) >= CONVERT(VARCHAR(20),'{1}',112)", strColumnName, dtFrom.Value.ToString("yyyyMMdd"));
            }
            else if (dtFrom != null && dtTo != null)
            {
                str += String.Format(@"   AND CONVERT(VARCHAR(20), {0}, 112) >= CONVERT(VARCHAR(20),'{1}',112)
                                          AND CONVERT(VARCHAR(20), {0}, 112) <= CONVERT(VARCHAR(20),'{2}',112)", strColumnName, dtFrom.Value.ToString("yyyyMMdd"), dtTo.Value.ToString("yyyyMMdd"));
            }
            return str;
        }
	}
	#endregion
}