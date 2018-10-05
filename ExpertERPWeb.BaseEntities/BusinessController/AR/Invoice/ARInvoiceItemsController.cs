﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
using System.Globalization;

namespace ExpertERP.BusinessEntities
{
	#region ARInvoiceItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARInvoiceItemsController
	//Created Date:Sunday, June 15, 2008
	//-----------------------------------------------------------

    public class ARInvoiceItemsController : BaseBusinessController
    {
        public static CultureInfo culture = new CultureInfo("en-US");
        private readonly String spARInvoiceItems_SelectMaxProductQtyByARCustomerIDAndFDateTDate = "ARInvoiceItems_SelectMaxProductQtyByARCustomerIDAndFDateTDate";
        private readonly String spARInvoiceItems_SelectMinProductQtyByARCustomerIDAndFDateTDate = "ARInvoiceItems_SelectMinProductQtyByARCustomerIDAndFDateTDate";
        public ARInvoiceItemsController()
        {
            dal = new DALBaseProvider("ARInvoiceItems", typeof(ARInvoiceItemsInfo));
        }
        public DataSet GetItemARInvoiceByID(int ObjectID)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARInvoiceItems WHERE AAStatus='Alive' AND FK_ARInvoiceID = {0}", ObjectID);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetInvoiceItemsByProductSerialNo(String strProductSerialNo)
        {
            return dal.GetDataSet("ARInvoiceItems_SelectByProductSerialNo", strProductSerialNo);
        }

        public ARInvoiceItemsInfo GetInvoiceItemByProductSerialNo(String strProductSerialNo)
        {
            return (ARInvoiceItemsInfo)dal.GetDataObject("ARInvoiceItems_SelectByProductSerialNo", strProductSerialNo);
        }

        public DataSet GetInvoiceItemsByProductID(int iProductID)
        {
            return dal.GetDataSet("ARInvoiceItems_SelectByFK_ICProductID", iProductID);
        }

        public ARInvoiceItemsInfo GetInvoiceItemByProductID(int iProductID)
        {
            return (ARInvoiceItemsInfo)dal.GetDataObject("ARInvoiceItems_SelectByProductID", iProductID);
        }

        public double GetTotalInvoicedQuantityOfSaleOrderItem(int iARSOItemID)
        {
            double dbTotalInvoicedQuantity = 0;
            try
            {
                DataSet ds = dal.GetDataSet("ARInvoiceItems_SelectTotalInvoicedQuantityByARSOItemID", iARSOItemID);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dbTotalInvoicedQuantity += Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                    }
                }
                return dbTotalInvoicedQuantity;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double GetTotalInvoicedQuantityOfShipmentItem(int iICShipmentItemID)
        {
            double dbTotalInvoicedQuantity = 0;
            try
            {
                DataSet ds = dal.GetDataSet("ARInvoiceItems_SelectTotalInvoicedQuantityByICShipmentItemID", iICShipmentItemID);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dbTotalInvoicedQuantity += Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                    }
                }
                return dbTotalInvoicedQuantity;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.17
        /// Desc: Get DataSet Max Product Qty within ARInvoiceItems
        /// </summary>
        /// <param name="iFK_ARCustomerID"></param>
        /// <param name="dtFDate"></param>
        /// <param name="dtTDate"></param>
        /// <returns></returns>
        public DataSet GetMaxProductQtyByFK_ARCustomerID(int iFK_ARCustomerID, DateTime dtFDate, DateTime dtTDate)
        {
            DataSet dsARInvoiceItems = new DataSet();
            DataSet ds = dal.GetDataSet(spARInvoiceItems_SelectMaxProductQtyByARCustomerIDAndFDateTDate, iFK_ARCustomerID, dtFDate, dtTDate);
            if (ds != null)
            {
                dsARInvoiceItems = ds.Clone();
                if (ds.Tables.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        ARInvoiceItemsInfo objARInvoiceItemsInfo = (ARInvoiceItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                        if (objARInvoiceItemsInfo != null)
                        {
                            int iMaxQty = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                            if (objARInvoiceItemsInfo.ARInvoiceItemQty == iMaxQty)
                            {
                                DataRow row = (DataRow)ds.Tables[0].Rows[i];
                                dsARInvoiceItems.Tables[0].ImportRow(row);
                            }
                            else
                                break;
                        }
                    }
                }
            }
            return dsARInvoiceItems;
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.17
        /// Desc: Get DataSet Min Product Qty within ARInvoiceItems
        /// </summary>
        /// <param name="iFK_ARCustomerID"></param>
        /// <param name="dtFDate"></param>
        /// <param name="dtTDate"></param>
        /// <returns></returns>
        public DataSet GetMinProductQtyByFK_ARCustomerID(int iFK_ARCustomerID, DateTime dtFDate, DateTime dtTDate)
        {
            DataSet dsARInvoiceItems = new DataSet();
            DataSet ds = dal.GetDataSet(spARInvoiceItems_SelectMinProductQtyByARCustomerIDAndFDateTDate, iFK_ARCustomerID, dtFDate, dtTDate);
            if (ds != null)
            {
                dsARInvoiceItems = ds.Clone();
                if (ds.Tables.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        ARInvoiceItemsInfo objARInvoiceItemsInfo = (ARInvoiceItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                        if (objARInvoiceItemsInfo != null)
                        {
                            int iMinQty = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                            if (objARInvoiceItemsInfo.ARInvoiceItemQty == iMinQty)
                            {
                                DataRow row = (DataRow)ds.Tables[0].Rows[i];
                                dsARInvoiceItems.Tables[0].ImportRow(row);
                            }
                            else
                                break;
                        }
                    }
                }
            }
            return dsARInvoiceItems;
        }

        public DataSet GetAllDataBySellerIDProductIDInRange(int iHREmployeeID, int iFromPeriod, int iFromYear, int iToPeriod, int iToYear, int iICProductID)
        {
            string str = string.Format(@"SELECT * FROM dbo.ARInvoiceItems INNER JOIN dbo.ARInvoices 
                                                ON dbo.ARInvoiceItems.FK_ARInvoiceID = dbo.ARInvoices.ARInvoiceID 
                                                WHERE dbo.ARInvoiceItems.AAStatus='Alive' AND dbo.ARInvoices.AAStatus='Alive'
                                                    AND FK_HREmployeeID={1} AND FK_ICProductID={0}
                                                AND MONTH(ARInvoiceDate) + YEAR(ARInvoiceDate)*12>={2}
                                                AND MONTH(ARInvoiceDate) + YEAR(ARInvoiceDate)*12<={3}"
                                                , iICProductID, iHREmployeeID, iFromPeriod + iFromYear * 12, iToPeriod + iToYear * 12);
            return dal.GetDataSet(str);
        }

        public double GetTotalRevenueByCampaignInRange(int iCampaignID, DateTime dtFrom, DateTime dtTo)
        {
            string strQuery = string.Format(@"Select SUM(ARInvoiceItemAmtTot) from ARInvoiceItems where AAStatus='Alive' AND FK_ARCampaignID = {0} 
                                                        AND FK_ARInvoiceID IN 
                                                        (SELECT ARInvoiceID FROM ARInvoices 
                                                        WHERE
                                                        CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112) 
                                                        AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112) >= CONVERT(VARCHAR(10), '{2}', 112)) ", iCampaignID, dtTo.ToString("yyyyMMdd"), dtFrom.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }

        public DataSet GetAllInvoiceItemsByCompaignInRange(int iCampaignID, DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Format(@"SELECT * 
                                                FROM ARInvoiceItems 
                                                WHERE AAStatus = 'Alive' 
                                                    AND FK_ARCampaignID = {0} 
                                                    AND FK_ARInvoiceID IN (SELECT ARInvoiceID FROM ARInvoices WHERE AAStatus='Alive' 
                                                    AND ARInvoiceDate BETWEEN '{1}' AND '{2}')", iCampaignID, String.Format("{0:yyyy/M/d HH:mm:ss}", dtFrom), String.Format("{0:yyyy/M/d HH:mm:ss}", dtTo));
            return dal.GetDataSet(strQuery);
        }

        public double GetSumByMonthAndCompaignInRange(int iCampaignID, int iMonth, int iYear)
        {
            String strQuery = String.Format(@"SELECT SUM(ARInvoiceItemAmtTot)
                                                FROM ARInvoiceItems INNER JOIN ARInvoices ON FK_ARInvoiceID = ARInvoiceID 
                                                WHERE 
                                                ARInvoiceItems.AAStatus = 'Alive' 
                                                AND ARInvoices.AAStatus = 'Alive' 
                                                AND FK_ARCampaignID = {0} 
                                                AND Month(ARInvoiceDate) = {1}
                                                AND Year(ARInvoiceDate) = {2}", iCampaignID, iMonth, iYear);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }

        public DataSet GetDataTotAmtByProductAndInRange(int ProductID, int fromMonth, int toMonth, int iYear)
        {
            String strQuery = String.Format(@"SELECT FK_ARCampaignID, FK_ARCampaignItemID, SUM(ARInvoiceItemAmtTot), SUM(ARInvoiceItemQty)
                                                FROM ARInvoiceItems INNER JOIN ARInvoices ON FK_ARInvoiceID = ARInvoiceID 
                                                WHERE 
                                                ARInvoiceItems.AAStatus = 'Alive' 
                                                AND ARInvoices.AAStatus = 'Alive' 
                                                AND ((FK_ARCampaignID > 0 And ARInvoiceItemType = 'ForSale') OR FK_ARCampaignID = 0)
                                                AND FK_ICProductID = {0} 
                                                AND Month(ARInvoiceDate) >= {1}
                                                And Month(ARInvoiceDate) <= {2}
                                                AND Year(ARInvoiceDate) = {3} Group by FK_ARCampaignID, FK_ARCampaignItemID", ProductID, fromMonth, toMonth, iYear);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;

            return null;
        }

        public DataSet GetDataTotAmtByAndInRange(int fromMonth, int toMonth, int iYear)
        {
            String strQuery = String.Format(@"SELECT FK_ICProductID, FK_ARCampaignID, FK_ARCampaignItemID, SUM(ARInvoiceItemAmtTot), SUM(ARInvoiceItemQty)
                                                FROM ARInvoiceItems INNER JOIN ARInvoices ON FK_ARInvoiceID = ARInvoiceID 
                                                WHERE 
                                                ARInvoiceItems.AAStatus = 'Alive' 
                                                AND ARInvoices.AAStatus = 'Alive' 
                                                AND ((FK_ARCampaignID > 0 And ARInvoiceItemType = 'ForSale') OR FK_ARCampaignID = 0)
                                                AND Month(ARInvoiceDate) >= {0}
                                                And Month(ARInvoiceDate) <= {1}
                                                AND Year(ARInvoiceDate) = {2} Group by FK_ICProductID, FK_ARCampaignID, FK_ARCampaignItemID Order By FK_ICProductID", fromMonth, toMonth, iYear);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;

            return null;
        }

        public DataSet GetCustomerCountByCampaignAndInRange(int ProductID, int CampaignID, int fromMonth, int toMonth, int iYear)
        {
            String strQuery = String.Format(@"SELECT ARInvoices.FK_ARCustomerID
                                                FROM ARInvoiceItems INNER JOIN ARInvoices ON FK_ARInvoiceID = ARInvoiceID 
                                                WHERE 
                                                ARInvoiceItems.AAStatus = 'Alive' 
                                                AND ARInvoices.AAStatus = 'Alive' 
                                                AND ((FK_ARCampaignID > 0 And ARInvoiceItemType = 'ForSale') OR FK_ARCampaignID = 0)
                                                AND FK_ARCampaignID = {0}
                                                AND FK_ICProductID = {1} 
                                                AND Month(ARInvoiceDate) >= {2}
                                                And Month(ARInvoiceDate) <= {3}
                                                AND Year(ARInvoiceDate) = {4} Group by ARInvoices.FK_ARCustomerID", CampaignID, ProductID, fromMonth, toMonth, iYear);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;

            return null;
        }

        public DataSet GetAllDataByProductAndCampaignAndInRange(int ProductID, int CampaignID, int fromMonth, int toMonth, int iYear)
        {
            String strQuery = String.Format(@"SELECT *
                                                FROM ARInvoiceItems 
                                                WHERE 
                                                AAStatus = 'Alive' 
                                                AND ((FK_ARCampaignID > 0 And ARInvoiceItemType = 'ForSale') OR FK_ARCampaignID = 0)
                                                AND FK_ARCampaignID = {0}
                                                AND FK_ICProductID = {1} 
                                                AND FK_ARInvoiceID In(
                                                    Select ARInvoiceID From ARInvoices Where AAStatus = 'Alive'
                                                        AND Month(ARInvoiceDate) >= {2}
                                                        And Month(ARInvoiceDate) <= {3}
                                                        AND Year(ARInvoiceDate) = {4}) ", CampaignID, ProductID, fromMonth, toMonth, iYear);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;

            return null;
        }

        public DataSet GetAllDataCampaignByMonthAndCompaignInRange(int CampaignItemID, int iCampaignID, int fromMonth, int toMonth, int iYear)
        {
            String strQuery = String.Format(@"SELECT FK_ICProductID, ARInvoiceItemQty
                                                FROM ARInvoiceItems INNER JOIN ARInvoices ON FK_ARInvoiceID = ARInvoiceID 
                                                WHERE 
                                                ARInvoiceItems.AAStatus = 'Alive' 
                                                AND ARInvoices.AAStatus = 'Alive' 
                                                AND FK_ARCampaignID = {1} AND ARInvoiceItemType = 'ForCampaign'
                                                AND FK_ARCampaignItemID = {0}
                                                AND Month(ARInvoiceDate) >= {2}
                                                AND Month(ARInvoiceDate) <= {3}
                                                AND Year(ARInvoiceDate) = {4}", CampaignItemID, iCampaignID, fromMonth, toMonth, iYear);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds;

            return null;
        }

        public double GetTotalAmtByARSellerIDProductIDInPeriodYear(int iHREmployeeID, int iICProductID, int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT SUM(ARInvoiceItemAmtTot),COUNT(*) FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'  AND FK_HREmployeeID={0}
	                                                    	AND MONTH(ARInvoiceDate)={1} AND YEAR(ARInvoiceDate)={2} AND FK_ICProductID={3}"
                                                        , iHREmployeeID, iPeriod, iYear, iICProductID);
            DataSet dsARQuots = dal.GetDataSet(strQuery);
            // count = 0;
            if (dsARQuots != null && dsARQuots.Tables.Count > 0 && dsARQuots.Tables[0].Rows.Count > 0 && dsARQuots.Tables[0].Rows[0][0] != DBNull.Value && dsARQuots.Tables[0].Rows[0][1] != DBNull.Value)
            {
                // count = Convert.ToDouble(dsARQuots.Tables[0].Rows[0][1]);
                return Convert.ToDouble(dsARQuots.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public DataSet GetAllDataByARSellerIDProductIDInPeriodYear(int iHREmployeeID, int iICProductID, int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARInvoiceItems 
                                                        WHERE  ARInvoiceItems.AAStatus='Alive' 
                                                        AND FK_ICProductID={3}
                                                        AND FK_ARInvoiceID in (Select ARInvoiceID from ARInvoices where AAStatus='Alive' and FK_HREmployeeID={0}
	                                                    	AND MONTH(ARInvoiceDate)={1} AND YEAR(ARInvoiceDate)={2})"
                                                        , iHREmployeeID, iPeriod, iYear, iICProductID);
            return dal.GetDataSet(strQuery);
        }

        public double GetTotalAmtByProductGroupProductAttrInRange(int iProductGroupID, string AttrNameLevel1, string AttrValueLevel1, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT SUM(ARInvoiceItemAmtTot) FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrNameLevel1, AttrValueLevel1, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"));
            DataSet dsARQuots = dal.GetDataSet(strQuery);
            // count = 0;
            if (dsARQuots != null && dsARQuots.Tables.Count > 0 && dsARQuots.Tables[0].Rows.Count > 0 && dsARQuots.Tables[0].Rows[0][0] != DBNull.Value)
            {
                // count = Convert.ToDouble(dsARQuots.Tables[0].Rows[0][1]);
                return Convert.ToDouble(dsARQuots.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public DataSet GetDatasetByProductGroupProductAttrInRange(int iProductGroupID, string AttrName, string AttrValue, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrName, AttrValue, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"));
            return dal.GetDataSet(strQuery);

        }

        public double GetTotalAmtByProductGroupProductAttrInRange(int iProductGroupID, string AttrName, string AttrValue, string subAttrName, string SubAttrVale, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT SUM(ARInvoiceItemAmtTot) FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{5}' and ICProductAttrValue='{6}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrName, AttrValue, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"), subAttrName, SubAttrVale);
            DataSet dsARQuots = dal.GetDataSet(strQuery);
            // count = 0;
            if (dsARQuots != null && dsARQuots.Tables.Count > 0 && dsARQuots.Tables[0].Rows.Count > 0 && dsARQuots.Tables[0].Rows[0][0] != DBNull.Value)
            {
                // count = Convert.ToDouble(dsARQuots.Tables[0].Rows[0][1]);
                return Convert.ToDouble(dsARQuots.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public DataSet GetDatasetByProductGroupProductAttrInRange(int iProductGroupID, string AttrName, string AttrValue, string subAttrName, string SubAttrVale, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{5}' and ICProductAttrValue='{6}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrName, AttrValue, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"), subAttrName, SubAttrVale);
            return dal.GetDataSet(strQuery);
        }

        public double GetTotalAmtByProductGroupProductAttrInRange(int iProductGroupID, string AttrNameLevel1, string AttrValueLevel1, string AttrNameLevel2, string AttrValueLevel2, string AttrNameLevel3, string AttrValueLevel3, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT SUM(ARInvoiceItemAmtTot) FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{5}' and ICProductAttrValue='{6}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{7}' and ICProductAttrValue='{8}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrNameLevel1, AttrValueLevel1, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"), AttrNameLevel2, AttrValueLevel2, AttrNameLevel3, AttrValueLevel3);
            DataSet dsARQuots = dal.GetDataSet(strQuery);
            // count = 0;
            if (dsARQuots != null && dsARQuots.Tables.Count > 0 && dsARQuots.Tables[0].Rows.Count > 0 && dsARQuots.Tables[0].Rows[0][0] != DBNull.Value)
            {
                // count = Convert.ToDouble(dsARQuots.Tables[0].Rows[0][1]);
                return Convert.ToDouble(dsARQuots.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public DataSet GetDatasetByProductGroupProductAttrInRange(int iProductGroupID, string AttrNameLevel1, string AttrValueLevel1, string AttrNameLevel2, string AttrValueLevel2, string AttrNameLevel3, string AttrValueLevel3, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{5}' and ICProductAttrValue='{6}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{7}' and ICProductAttrValue='{8}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrNameLevel1, AttrValueLevel1, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"), AttrNameLevel2, AttrValueLevel2, AttrNameLevel3, AttrValueLevel3);
            return dal.GetDataSet(strQuery);
        }

        public double GetTotalAmtByProductGroupProductAttrInRange(int iProductGroupID, string AttrNameLevel1, string AttrValueLevel1, string AttrNameLevel2, string AttrValueLevel2, string AttrNameLevel3, string AttrValueLevel3, string AttrNameLevel4, string AttrValueLevel4, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT SUM(ARInvoiceItemAmtTot) FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{5}' and ICProductAttrValue='{6}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{7}' and ICProductAttrValue='{8}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{9}' and ICProductAttrValue='{10}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrNameLevel1, AttrValueLevel1, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"), AttrNameLevel2, AttrValueLevel2, AttrNameLevel3, AttrValueLevel3, AttrNameLevel4, AttrValueLevel4);
            DataSet dsARQuots = dal.GetDataSet(strQuery);
            // count = 0;
            if (dsARQuots != null && dsARQuots.Tables.Count > 0 && dsARQuots.Tables[0].Rows.Count > 0 && dsARQuots.Tables[0].Rows[0][0] != DBNull.Value)
            {
                // count = Convert.ToDouble(dsARQuots.Tables[0].Rows[0][1]);
                return Convert.ToDouble(dsARQuots.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public DataSet GetDatasetByProductGroupProductAttrInRange(int iProductGroupID, string AttrNameLevel1, string AttrValueLevel1, string AttrNameLevel2, string AttrValueLevel2, string AttrNameLevel3, string AttrValueLevel3, string AttrNameLevel4, string AttrValueLevel4, DateTime FromDate, DateTime ToDate)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARInvoices inner join ARInvoiceItems on ARInvoices.ARInvoiceID = ARInvoiceItems.FK_ARInvoiceID
                                                        WHERE ARInvoices.AAStatus='Alive' AND ARInvoiceItems.AAStatus='Alive'
	                                                    	AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive' and FK_ICProductGroupID={0})
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{1}' and ICProductAttrValue='{2}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{5}' and ICProductAttrValue='{6}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{7}' and ICProductAttrValue='{8}')
                                                            AND FK_ICProductID in (Select FK_ICProductID from ICProductAttrs where AAStatus='Alive' AND ICProductAttrName='{9}' and ICProductAttrValue='{10}')
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)>= CONVERT(VARCHAR(10), '{3}', 112) 
                                                            AND CONVERT(VARCHAR(10), [ARInvoiceDate], 112)<= CONVERT(VARCHAR(10), '{4}', 112)
                                                        ", iProductGroupID, AttrNameLevel1, AttrValueLevel1, FromDate.ToString("yyyyMMdd"), ToDate.ToString("yyyyMMdd"), AttrNameLevel2, AttrValueLevel2, AttrNameLevel3, AttrValueLevel3, AttrNameLevel4, AttrValueLevel4);
            return dal.GetDataSet(strQuery);
        }

        public void UpdateValuationToInvoiceItems(int iProductId, int iPeriod, int iYear, double dUnitCost)
        {
            String strQuery = String.Format(culture, @"UPDATE ARInvoiceItems SET ARInvoiceItemUnitCost = {0}, ARInvoiceItemCostTot = {0} * ARInvoiceItemQty
                                                                    WHERE AAStatus = 'Alive' AND FK_ICProductID = {1}
                                                                    AND FK_ARInvoiceID IN 
                                                                        (SELECT ARInvoiceID FROM ARInvoices WHERE AASTatus = 'Alive'
                                                                                            AND Month(ARInvoiceDate) = {2} AND Year(ARInvoiceDate) = {3})",
                                                                  dUnitCost, iProductId, iPeriod, iYear);

            dal.GetDataSet(strQuery);
        }

        public DataSet GetAllShipmentItemsForFinishGooodsAndWOAndPhase(int iICProductID, int iPPWOID, int iPPPhaseCfgID)
        {
            String strQuery = String.Format("Select * From [ICShipmentItems] Where ([FK_ICProductIDWO]={0}) AND ([FK_PPPhaseCfgID]={1}) AND ([AAStatus]= 'Alive') AND ([FK_ICShipmentID] IN (SELECT [ICShipmentID] FROM [ICShipments] WHERE [FK_PPWOID]={2} AND [AAStatus]='Alive'))", iICProductID, iPPPhaseCfgID, iPPWOID);
            return GetDataSet(strQuery);
        }

        #region Valuation
        public void UpdateValuationToInvoiceItems(int iStockID, int iProductId, int iPeriod, int iYear, double dUnitCost)
        {
            String strQuery = String.Format(culture, @"UPDATE ARInvoiceItems SET ARInvoiceItemUnitCost = {0}, ARInvoiceItemCostTot = ROUND({0} * ARInvoiceItemQty, 0)
                                                                    WHERE AAStatus = 'Alive' AND FK_ICProductID = {1}
                                                                    AND FK_ARInvoiceID IN 
                                                                        (SELECT ARInvoiceID FROM ARInvoices WHERE AASTatus = 'Alive'
                                                                                            AND Month(ARInvoiceDate) = {2} AND Year(ARInvoiceDate) = {3})",
                                                                  dUnitCost, iProductId, iPeriod, iYear);

            if (iStockID > 0)
                strQuery += String.Format(@" AND FK_ICStockID = {0}", iStockID);

            dal.GetDataSet(strQuery);
        }
        #endregion

        public DataSet GetAllObjectByConditionID(String strCondition, int iARSOItemID)
        {
            String strQuery = String.Format(@" Select *
                                               From ARInvoiceItems
                                               Where AAStatus = 'Alive' AND {0} = {1}   
                                            ", strCondition, iARSOItemID);
            return GetDataSet(strQuery);
        }

        #region Lấy hệ số sum ItemPrice theo date
        public DataSet GetSumPrice_ByDate(int iICProductID, DateTime dateSearchFrom, DateTime dateSearchTo)
        {
            string strQuerySearchDate = string.Format(@"AND ARInvoiceDate >= '{0}' AND ARInvoiceDate <= '{1}'", dateSearchFrom.ToString("yyyyMMdd"), dateSearchTo.ToString("yyyyMMdd"));

            string strQuery = string.Format(@"SELECT  SUM(ARInvoiceItemPrice)
                                                      FROM    dbo.ARInvoiceItems
                                                      WHERE   FK_ICProductID = {0}
                                                              AND AAStatus = 'Alive'
                                                              AND FK_ARInvoiceID IN ( SELECT  ARInvoiceID
                                                                                    FROM    dbo.ARInvoices
                                                                                    WHERE  AAStatus='Alive' {1})
                                            ", iICProductID, strQuerySearchDate);
            return GetDataSet(strQuery);
        }
        #endregion
    }
    #endregion
}