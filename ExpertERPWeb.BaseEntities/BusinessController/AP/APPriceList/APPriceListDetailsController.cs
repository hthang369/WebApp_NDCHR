using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPriceListDetails
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPriceListDetailsController
	//Created Date:13 Tháng Ba 2013
	//-----------------------------------------------------------
	
	public class APPriceListDetailsController:BaseBusinessController
	{
		public APPriceListDetailsController()
		{
			dal= new DALBaseProvider("APPriceListDetails",typeof(APPriceListDetailsInfo));
        }

        #region lấy về PricelistDetail có cùng nhà cung cấp và sản phẩm gần nhất --Châu  --13/03/2013

        public APPriceListDetailsInfo GetPriceListDetailLastBySupPro(int iSupplierID, int iProductID)
        {
            String str = String.Format(@"SELECT * FROM dbo.APPriceListDetails
                                        WHERE AAStatus='Alive'
                                        AND (FK_ICProductID = {0} OR {0} = 0)
                                        AND FK_APPriceListID IN (SELECT APPriceListID FROM dbo.APPriceLists WHERE AAStatus='Alive' AND (FK_APSupplierID = {1} OR {1} = 0) )
                                        ORDER BY APPriceListDetailID DESC", iProductID, iSupplierID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (APPriceListDetailsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        #endregion

        public double GetLastPriceListDetailBySupplierAndProductAndPODateAndQty(int iSupplierID, int iProductID, DateTime dateTime)
        {
            String strDate = string.Format(@"(
                                                (CONVERT(VARCHAR, APPriceListDetailFromDate, 112) <= '{0}'
                                                AND APPriceListDetailToDate IS NULL)
                                                OR
                                                (CONVERT(VARCHAR, APPriceListDetailFromDate, 112) <= '{0}'
                                                AND CONVERT(VARCHAR, APPriceListDetailToDate, 112) >= '{0}')
                                        )"
                                            , dateTime.ToString("yyyyMMdd"));

            String strQuery = String.Format(@"SELECT TOP 1 * FROM APPriceListDetails,APPriceLists WHERE APPriceListDetails.AAStatus='Alive' 
                                                AND APPriceLists.AAStatus='Alive' 
                                                AND APPriceListDetails.FK_APPriceListID=APPriceLists.APPriceListID 
                                                AND APPriceLists.APPriceListActiveCheck=1 
                                                AND {0}
                                                AND FK_ICProductID={1} 
                                                AND FK_APSupplierID={2}
                                                ORDER BY APPriceListDetailFromDate DESC"
                                                , strDate, iProductID, iSupplierID);

            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                APPriceListDetailsInfo PriceListDetail = (APPriceListDetailsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                if (PriceListDetail != null)
                    return PriceListDetail.APPriceListDetailFUnitPrice;
            }

            return 0;
        }

        public APPriceListDetailsInfo GetPriceListDetailByProductAndCurrencyAndUOMAndDateAndQty(int iAPPriceListID, int iGECurrencyID,
            int iICUOMID, int iICProductID, DateTime dt, double dbQty, int iAPSupplierID)
        {
            string str = string.Format(@"SELECT APPriceListDetails.* FROM dbo.APPriceListDetails
                                        INNER JOIN dbo.APPriceLists ON (APPriceLists.APPriceListID = APPriceListDetails.FK_APPriceListID
                                        AND APPriceLists.AAStatus = APPriceListDetails.AAStatus
                                        AND APPriceLists.AAStatus = 'Alive'
                                        AND APPriceLists.APPriceListID = {0}
                                        AND (APPriceLists.FK_GECurrencyID = {1} OR {1} = 0)
                                        AND (APPriceListDetails.FK_ICUOMID = {2} OR {2} = 0) )
                                        AND (APPriceLists.FK_APSupplierID = {6} OR {6} = 0)
                                        WHERE (APPriceListDetails.FK_ICProductID = {3} OR {3} = 0)
                                        AND (
                                                (CONVERT(VARCHAR, APPriceListDetailFromDate, 112) <= '{4}'
                                                AND APPriceListDetailToDate IS NULL)
                                                OR
                                                (CONVERT(VARCHAR, APPriceListDetailFromDate, 112) <= '{4}'
                                                AND CONVERT(VARCHAR, APPriceListDetailToDate, 112) >= '{4}')
                                        )
                                        AND (
                                                APPriceListDetails.APPriceListDetailFromQuantity <= {5} 
                                                AND 
                                                (
                                                    {5} <= APPriceListDetails.APPriceListDetailToQuantity
                                                    OR
                                                    APPriceListDetails.APPriceListDetailToQuantity = 0
                                                )
                                            )
                                        ORDER BY APPriceListDetails.APPriceListDetailFromDate DESC"
                                    , iAPPriceListID, iGECurrencyID, iICUOMID, iICProductID, dt.ToString("yyyyMMdd"), dbQty, iAPSupplierID);

            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (APPriceListDetailsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]);

            return null;
        }

        public DataSet GetAllByForeignKey(int iAPPriceListID)
        {
            String strQuery = String.Format(@"SELECT *
                                                              FROM dbo.APPriceListDetails
                                                              WHERE FK_APPriceListID = {0}",iAPPriceListID);
            DataSet ds = GetDataSet(strQuery);
            return ds;
        }

        public Boolean CheckPriceListIsUsed(int iAPPriceListID)
        {
            String strQuery = String.Format(@"SELECT  APPriceListDetails.APPriceListDetailID
                                                FROM    APPriceListDetails
                                                        INNER JOIN APPriceLists ON ( APPriceLists.APPriceListID = APPriceListDetails.FK_APPriceListID
                                                                                     AND APPriceLists.AAStatus = APPriceListDetails.AAStatus
                                                                                     AND APPriceLists.AAStatus = 'Alive'
                                                                                     AND APPriceLists.APPriceListID = {0}
                                                                                   )
                                                        INNER JOIN APRFQItems ON ( APRFQItems.FK_APPriceListDetailID = APPriceListDetails.APPriceListDetailID
                                                                                   AND APRFQItems.AAStatus = APPriceListDetails.AAStatus
                                                                                 )
                                                        INNER JOIN APRFQs ON ( APRFQItems.FK_APRFQID = APRFQs.APRFQID
                                                                               AND APRFQItems.AAStatus = APRFQs.AAStatus
                                                                             )
                                                UNION
                                                SELECT  APPriceListDetails.APPriceListDetailID
                                                FROM    APPriceListDetails
                                                        INNER JOIN APPriceLists ON ( APPriceLists.APPriceListID = APPriceListDetails.FK_APPriceListID
                                                                                     AND APPriceLists.AAStatus = APPriceListDetails.AAStatus
                                                                                     AND APPriceLists.AAStatus = 'Alive'
                                                                                     AND APPriceLists.APPriceListID = {0}
                                                                                   )
                                                        INNER JOIN APPOItems ON ( APPOItems.FK_APPriceListDetailID = APPriceListDetails.APPriceListDetailID
                                                                                  AND APPOItems.AAStatus = APPriceListDetails.AAStatus
                                                                                )
                                                        INNER JOIN APPOs ON ( APPOs.APPOID = APPOItems.FK_APPOID
                                                                              AND APPOs.AAStatus = APPOItems.AAStatus
                                                                            )"
                                            , iAPPriceListID);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }
    }
	#endregion
}