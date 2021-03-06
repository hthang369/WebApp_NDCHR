﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARSOItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ARSOItemsController
    //Created Date:Wednesday, April 01, 2009
    //-----------------------------------------------------------

    public class ARSOItemsController : BaseBusinessController
    {
        private readonly string spGetBestSellersByFK_ARSellerID = "ARSOItems_SelectBestSellersByARSellerID";
        private readonly string spGetSlowSellersByFK_ARSellerID = "ARSOItems_SelectSlowSellersByARSellerID";
        private readonly String spARSOItems_SelectByProductAndARSOShpDate = "ARSOItems_SelectByProductAndARSOShpDate";
        private readonly String spARSOItems_SelectByProductStockAndARSOShpDate = "ARSOItems_SelectByProductStockAndARSOShpDate";
        public ARSOItemsController()
        {
            dal = new DALBaseProvider("ARSOItems", typeof(ARSOItemsInfo));
        }
        public DataSet GetItemARSOByID(int ObjectID)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARSOItems WHERE AAStatus='Alive' AND FK_ARSOID = {0}", ObjectID);
            return dal.GetDataSet(strQuery);
        }
        public List<ARSOItemsInfo> GetListSOItemByARSellerIDFromFDateAndTDate(int iARSellerID, DateTime dteFDate, DateTime dteTDate)
        {
            List<ARSOItemsInfo> lstARSOItems = new List<ARSOItemsInfo>();
            DataSet dsARSOs = new DataSet();
            String strQuery = String.Format("SELECT * FROM [dbo].[ARSOs] WHERE [FK_ARSellerID]={0} AND CONVERT(VARCHAR(10), [ARSODate], 112)>= CONVERT(VARCHAR(10), '{1}', 112) AND CONVERT(VARCHAR(10), [ARSODate], 112)<= CONVERT(VARCHAR(10), '{2}', 112) AND [AAStatus]='{3}'", iARSellerID, dteFDate.ToString("yyyyMMdd"), dteTDate.ToString("yyyyMMdd"), BusinessObject.DefaultAAStatus);
            dsARSOs = dal.GetDataSet(strQuery);
            if (dsARSOs != null)
            {
                foreach (DataRow row in dsARSOs.Tables[0].Rows)
                {
                    ARSOsInfo objARSOsInfo = (ARSOsInfo)new ARSOsController().GetObjectFromDataRow(row);
                    DataSet dsARSOItems = new ARSOItemsController().GetAllDataByForeignColumn("FK_ARSOID", objARSOsInfo.ARSOID);
                    if (dsARSOItems != null)
                    {

                        foreach (DataRow rowItem in dsARSOItems.Tables[0].Rows)
                        {
                            ARSOItemsInfo objARSOItemsInfo = (ARSOItemsInfo)new ARSOItemsController().GetObjectFromDataRow(rowItem);
                            if (objARSOItemsInfo != null)
                                lstARSOItems.Add(objARSOItemsInfo);
                        }
                    }
                }
            }
            return lstARSOItems;
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created date 10.03.01
        /// Desc:
        /// </summary>
        /// <param name="iFK_ARSellerID"></param>
        /// <param name="dtFDate"></param>
        /// <param name="dtTDate"></param>
        /// <returns></returns>
        public DataSet GetBestSellersByFK_ARSellerID(int iFK_ARSellerID, DateTime dtFDate, DateTime dtTDate)
        {
            DataSet ds = dal.GetDataSet(spGetBestSellersByFK_ARSellerID, iFK_ARSellerID, dtFDate, dtTDate);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    ARSOItemsInfo objARSOItemsInfo = (ARSOItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                    if (objARSOItemsInfo != null)
                    {
                        int iMaxQty = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                        if (objARSOItemsInfo.ARSOItemQty != iMaxQty)
                        {
                            ds.Tables[0].Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            return ds;
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.01
        /// Desc:
        /// </summary>
        /// <param name="iFK_ARSellerID"></param>
        /// <param name="dtFDate"></param>
        /// <param name="dtTDate"></param>
        /// <returns></returns>
        public DataSet GetSlowSellersByFK_ARSellerID(int iFK_ARSellerID, DateTime dtFDate, DateTime dtTDate)
        {
            DataSet ds = dal.GetDataSet(spGetSlowSellersByFK_ARSellerID, iFK_ARSellerID, dtFDate, dtTDate);
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    ARSOItemsInfo objARSOItemsInfo = (ARSOItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[i]);
                    if (objARSOItemsInfo != null)
                    {
                        int iMaxQty = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                        if (objARSOItemsInfo.ARSOItemQty != iMaxQty)
                        {
                            ds.Tables[0].Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            return ds;
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.08
        /// </summary>
        /// <param name="iICProductID"></param>
        /// <param name="dtFDate"></param>
        /// <param name="dtTDate"></param>
        /// <returns></returns>
        public DataSet GetDataSetARSOItemsByICProductIDAndFDateTDate(int iICProductID, DateTime dtFDate, DateTime dtTDate)
        {
            DataSet dsARSOItems = new DataSet();
            String strQuery = String.Format("SELECT * FROM [dbo].[ARSOItems] WHERE [FK_ARSOID] IN (SELECT [ARSOID] FROM [dbo].[ARSOs] WHERE CONVERT(VARCHAR(10), [ARSODate], 112)>= CONVERT(VARCHAR(10), '{1}', 112) AND CONVERT(VARCHAR(10), [ARSODate], 112)<= CONVERT(VARCHAR(10), '{2}', 112) AND [AAStatus] ='{3}') AND [FK_ICProductID]={0} AND [AAStatus] ='{3}'", iICProductID, dtFDate.ToString("yyyyMMdd"), dtTDate.ToString("yyyyMMdd"), BusinessObject.DefaultAAStatus);
            return (DataSet)dal.GetDataSet(strQuery);
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.19
        /// Desc:
        /// </summary>
        /// <param name="iFK_ICProductID"></param>
        /// <param name="dtShpDate"></param>
        /// <param name="strAAStatus"></param>
        /// <returns></returns>
        public DataSet GetDataSetARSOItemsByICProductAndShpDate(int iFK_ICProductID, DateTime dtShpDate, String strAAStatus)
        {
            return (DataSet)dal.GetDataSet(spARSOItems_SelectByProductAndARSOShpDate, iFK_ICProductID, dtShpDate, strAAStatus);
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 10.03.19
        /// Desc:
        /// </summary>
        /// <param name="iFK_ICProductID"></param>
        /// <param name="dtShpDate"></param>
        /// <param name="strAAStatus"></param>
        /// <returns></returns>
        public DataSet GetDataSetARSOItemsByICProductICStockAndShpDate(int iFK_ICProductID, int iFK_ICStockID, DateTime dtShpDate, String strAAStatus)
        {
            return (DataSet)dal.GetDataSet(spARSOItems_SelectByProductStockAndARSOShpDate, iFK_ICProductID, iFK_ICStockID, dtShpDate, strAAStatus);
        }

        public DataSet GetARSOItemsInCompleteByARSOID(int iARSOID)
        {
            String strQuery = String.Format("SELECT * FROM [ARSOItems] WHERE [FK_ARSOID] = {0} AND [ARSOItemRQty] > 0 AND [AAStatus] = 'Alive'", iARSOID);
            return dal.GetDataSet(strQuery);
        }

        public double GetTotalProductQtyByProductAndLessThanDeliveryDate(int iFK_ICProductID, int iFK_ICStockID, DateTime dteDeliveryDate)
        {
            string str = string.Format(@"Select SUM(ARSOItemRQty) from ARSOItems where AAStatus='Alive' AND FK_ICProductID={0} AND FK_ICStockID={1} AND
                                                        CONVERT(VARCHAR(10), [ARSOItemShpDate], 112)<= CONVERT(VARCHAR(10), '{2}', 112) ", iFK_ICProductID, iFK_ICStockID, dteDeliveryDate.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public double GetTotalProductQtyByProductAndStock(int iFK_ICProductID, int iFK_ICStockID)
        {
            string str = string.Format(@"Select SUM(ARSOItemRQty) from ARSOItems where AAStatus='Alive' AND FK_ICProductID={0} AND FK_ICStockID={1}", iFK_ICProductID, iFK_ICStockID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }
            return 0;
        }

        public DataSet GetAllDataByProductAndLessThanDeliveryDate(int iFK_ICProductID, DateTime dteDeliveryDate)
        {
            string str = string.Format(@"Select * from ARSOItems where AAStatus='Alive' AND FK_ICProductID={0}  AND ARSOItemRQty>0 AND
                                                        CONVERT(VARCHAR(10), [ARSOItemShpDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112) ", iFK_ICProductID, dteDeliveryDate.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        public double GetTotalSOAmtByCampaignInRange(int iCampaignID, DateTime dtFrom, DateTime dtTo)
        {
            string strQuery = string.Format(@"Select SUM(ARSOItemAmtTot) from ARSOItems where AAStatus='Alive' AND FK_ARCampaignID = {0} 
                                                        AND CONVERT(VARCHAR(10), [ARSOItemShpDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112) 
                                                        AND CONVERT(VARCHAR(10), [ARSOItemShpDate], 112) >= CONVERT(VARCHAR(10), '{2}', 112) ", iCampaignID, dtTo.ToString("yyyyMMdd"), dtFrom.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }

        public double GetTotalSOCountByCampaignInRange(int iCampaignID, DateTime dtFrom, DateTime dtTo)
        {
            string strQuery = string.Format(@"Select Count(FK_ARSOID) from ARSOItems where AAStatus='Alive' AND FK_ARCampaignID = {0} 
                                                        AND CONVERT(VARCHAR(10), [ARSOItemShpDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112) 
                                                        AND CONVERT(VARCHAR(10), [ARSOItemShpDate], 112) >= CONVERT(VARCHAR(10), '{2}', 112) ", iCampaignID, dtTo.ToString("yyyyMMdd"), dtFrom.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }

        public double GetTotalSOItemRQtyInRange(int iProductID, DateTime dtFrom, DateTime dtTo)
        {
            string strQuery = String.Format(@"SELECT SUM(ARSOItemRQty) FROM ARSOItems 
                                    WHERE AAStatus='Alive' 
                                    AND ARSOItemRQty > 0
                                    AND FK_ICProductID = {0}
                                    AND ARSOItemShpDate BETWEEN '{1}' AND '{2}'
                                    AND FK_ARSOID IN (SELECT ARSOID 
                                                        FROM ARSOs 
                                                        WHERE AAStatus = 'Alive'
                                                        )", iProductID, String.Format("{0:yyyy/M/d HH:mm:ss}", dtFrom), String.Format("{0:yyyy/M/d HH:mm:ss}", dtTo));

            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }

        public DataSet GetAllSOItemHasRQtyInRange(int iProductID, DateTime dtFrom, DateTime dtTo)
        {
            string strQuery = String.Format(@"SELECT * FROM ARSOItems 
                                    WHERE AAStatus='Alive' 
                                    AND ARSOItemRQty > 0
                                    AND FK_ICProductID = {0}
                                    AND ARSOItemShpDate BETWEEN '{1}' AND '{2}'
                                    AND FK_ARSOID IN (SELECT ARSOID 
                                                        FROM ARSOs 
                                                        WHERE AAStatus = 'Alive'
                                                        )", iProductID, String.Format("{0:yyyy/M/d HH:mm:ss}", dtFrom), String.Format("{0:yyyy/M/d HH:mm:ss}", dtTo));

            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllSOItemsByCompaignInRange(int iCampaignID, DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Format(@"SELECT * 
                                                FROM ARSOItems 
                                                WHERE AAStatus = 'Alive' 
                                                    AND FK_ARCampaignID = {0} 
                                                    AND FK_ARSOID IN (SELECT ARSOID FROM ARSOs WHERE AAStatus='Alive' 
                                                    AND ARSODate BETWEEN '{1}' AND '{2}')", iCampaignID, String.Format("{0:yyyy/M/d HH:mm:ss}", dtFrom), String.Format("{0:yyyy/M/d HH:mm:ss}", dtTo));
            return dal.GetDataSet(strQuery);
        }

        public double GetSumByMonthAndCompaignInRange(int iCampaignID, int iMonth, int iYear)
        {
            String strQuery = String.Format(@"SELECT SUM(ARSOItemAmtTot)
                                                FROM ARSOItems INNER JOIN ARSOs ON FK_ARSOID = ARSOID 
                                                WHERE 
                                                ARSOItems.AAStatus = 'Alive' 
                                                AND ARSOs.AAStatus = 'Alive' 
                                                AND FK_ARCampaignID = {0} 
                                                AND Month(ARSODate) = {1}
                                                AND Year(ARSODate) = {2}", iCampaignID, iMonth, iYear);
            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }

        public DataSet GetSOItemByShpDate(DateTime dateFrom, DateTime dateTo)
        {
            DataSet dsSOItem = new DataSet();

            String StrQuery = "SELECT * FROM ARSOItems Where AAStatus='Alive' AND [ARSOItemShpDate] BETWEEN '" + String.Format(@"{0: yyyy/MM/dd HH:mm:ss }", dateFrom) + "' AND '" + String.Format(@"{0: yyyy/MM/dd HH:mm:ss }", dateTo) + "' AND [ARSOItemQty] >0 ";// String.Format(@"{0: yyyy/MM/dd HH:mm:ss }", dateFrom), String.Format(@"{0: yyyy/MM/dd HH:mm:ss }", dateTo) );
            dsSOItem = dal.GetDataSet(StrQuery);
            return dsSOItem;
        }

        /// <summary>
        /// Viet Nguyen 2013.01.23
        /// Get Qty ShpPlanItem Create From SOItem
        /// </summary>
        public double GetQtyInShpPlan(int iEstSOItemID)
        {
            string strQuery = string.Format(@"Select SUM(ARShpPlanItemQty) from ARShpPlanItems where AAStatus='Alive' AND FK_ARSOItemID={0}", iEstSOItemID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                try
                {
                    return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
                catch (System.Exception ex)
                {

                }
            }
            return 0;
        }

        /// <summary>
        /// Viet Nguyen 2013.01.24
        /// Get SO Item By Product & SOID
        /// </summary>
        public ARSOItemsInfo GetSOItemByProductAndSOID(int iProductID, int iSOID)
        {
            string strQuery = string.Format(@"Select * from ARSOItems where AAStatus='Alive' and FK_ICProductID={0} and FK_ARSOID={1}", iProductID, iSOID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ARSOItemsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }


        /// <summary>
        /// Lấy về giá trị tất cả SOItems mà có RQty > 0
        /// </summary>
        /// <param name="dtFrom"></param>
        /// <param name="dtTo"></param>
        /// <returns></returns>
        public double GetSUMSOItemInComplete(DateTime dtFrom, DateTime dtTo)
        {
            String strDateCond = DALUtil.GenerateBeetween("DATEADD(DAY, ARCUstomers.ARCustomerPmtDueDays, ARSOs.ARSOShpDate)", dtFrom, dtTo);

            String strQuery = String.Format(@"SELECT SUM(ARSOItems.ARSOItemRQty * ARSOItems.ARSOItemUnitPrice)
                                                FROM dbo.ARSOItems,
                                                dbo.ARSOs,
                                                dbo.ARCustomers
                                                WHERE ARSOItemRQty > 0 
                                                AND ARSOItems.FK_ARSOID = ARSOID
                                                AND ARSOs.FK_ARCustomerID = ARCustomers.ARCustomerID
                                                AND ARSOItems.AAStatus = 'Alive'
                                                AND ARSOs.AAStatus = 'Alive'
                                                AND ARCustomers.AAStatus = 'ALive'
                                                AND {0}", strDateCond);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);

            return 0;
        }

        /// <summary>
        /// Lấy về giá trị tất cả SO mà có RQty > 0
        /// </summary>
        /// <param name="dtFrom"></param>
        /// <param name="dtTo"></param>
        /// <returns></returns>
        public DataSet GetAllSOItemInComplete(DateTime dtFrom, DateTime dtTo)
        {
            String strDateCond = DALUtil.GenerateBeetween("DATEADD(DAY, ARCUstomers.ARCustomerPmtDueDays, ARSOs.ARSOShpDate)", dtFrom, dtTo);

            String strQuery = String.Format(@"SELECT ARSOItems.*
                                                FROM dbo.ARSOItems,
                                                dbo.ARSOs,
                                                dbo.ARCustomers
                                                WHERE ARSOItemRQty > 0 
                                                AND ARSOItems.FK_ARSOID = ARSOID
                                                AND ARSOs.FK_ARCustomerID = ARCustomers.ARCustomerID
                                                AND ARSOItems.AAStatus = 'Alive'
                                                AND ARSOs.AAStatus = 'Alive'
                                                AND ARCustomers.AAStatus = 'ALive'
                                                AND {0}", strDateCond);

            return GetDataSet(strQuery);
        }

        /// <summary>
        /// Lấy số lượng còn phải xuất trong SO
        /// </summary>
        public double GetTotalHTSQtyByProductAndSODateInRange(int iProductID, DateTime dteFromDate, DateTime dteToDate)
        {
            string strQueryDate = DALUtil.GenerateBeetween("ARSODate", dteFromDate, dteToDate);
            string strQuery = string.Format(@"   select SUM(ARSOItemRQty)
                                                   from ARSOItems
                                                   where ARSOItemRQty>0
                                                    AND FK_ICProductID={0}
                                                  AND FK_ARSOID in (Select ARSOID from ARSOs where AAStatus='Alive' AND {1})", iProductID, strQueryDate);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        /// <summary>
        /// Lấy số lượng còn phải xuất trong SO
        /// </summary>
        public DataSet GetAllDataByProductAndSODateInRange(int iProductID, DateTime dteFromDate, DateTime dteToDate)
        {
            string strQueryDate = DALUtil.GenerateBeetween("ARSODate", dteFromDate, dteToDate);
            string strQuery = string.Format(@"select *
                                                   from ARSOItems
                                                   where ARSOItemRQty>0
                                                    AND FK_ICProductID={0}
                                                  AND FK_ARSOID in (Select ARSOID from ARSOs where AAStatus='Alive' AND {1})", iProductID, strQueryDate);
            return GetDataSet(strQuery);
        }

        /// <summary>
        /// Viet Nguyen 2014.08.01
        /// Lấy danh sách SOItem có RQty>0
        /// DeliveryDate SOItem is NULL lấy ARSOShpDate của SO.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllSOItemNeedToShip(DateTime dte)
        {
            string strQuery = string.Format(@"  IF OBJECT_ID('tempdb..#ICProductTmps') IS NOT NULL
                                                    DROP TABLE #ICProductTmps;
                                                IF OBJECT_ID('tempdb..#ARShps') IS NOT NULL
                                                    DROP TABLE #ARShps;

                                                -- ICProductTmps
                                                SELECT ICProducts.ICProductID
                                                INTO #ICProductTmps
                                                FROM ICProducts
                                                    INNER JOIN PPRoutings
                                                        ON ICProducts.FK_PPRoutingID = PPRoutings.PPRoutingID
                                                           AND PPRoutings.AAStatus = 'Alive';
                                                --ShpPln
                                                SELECT 
	                                                SUM(ISNULL(ARShpPlanItems.ARShpPlanItemHTSQty * ARShpPlanItems.ARShpPlanItemFact, 0)) AS ARShpPlanItemHTSQty,
                                                    ARShpPlanItems.FK_ARSOItemID,
                                                    ARShpPlanItems.FK_ICProductID
                                                INTO #ARShps
                                                FROM ARShpPlanItems
                                                    INNER JOIN ARShpPlans
                                                        ON ARShpPlanItems.FK_ARShpPlanID = ARShpPlans.ARShpPlanID
                                                        AND ARShpPlans.AAStatus = 'Alive'
                                                    INNER JOIN #ICProductTmps
                                                        ON ARShpPlanItems.FK_ICProductID = #ICProductTmps.ICProductID
                                                WHERE ARShpPlanItems.ARShpPlanItemHTSQty > 0
                                                    AND ARShpPlanItems.AAStatus = 'Alive'
                                                GROUP BY ARShpPlanItems.FK_ARSOItemID,
                                                        ARShpPlanItems.FK_ICProductID;
                                                -- Get MDS
                                                SELECT CASE
                                                           WHEN ARSOItemShpDate IS NOT NULL THEN
                                                               ARSOItemShpDate
                                                           ELSE
                                                               ARSOs.ARSOShpDate
                                                       END AS ARSOItemDeliveryDate,
                                                       ARSOItems.FK_ARSOID AS FK_ARSOID,
                                                       ARSOItems.FK_ICStkUOMID AS FK_ICStkUOMID,
                                                       ARSOItems.FK_ICProductID AS FK_ICProductID,
                                                       CASE
                                                           WHEN #ARShps.ARShpPlanItemHTSQty > 0 THEN
                                                               #ARShps.ARShpPlanItemHTSQty
                                                           ELSE
                                                               (ARSOItems.ARSOItemRQty) * ARSOItems.ARSOItemFact
                                                       END ARSOItemRStkQty
                                                FROM ARSOItems
                                                    INNER JOIN ARSOs
                                                        ON ARSOItems.FK_ARSOID = ARSOs.ARSOID
                                                           AND ARSOs.ApprovalStatusCombo LIKE 'Approved'
		                                                   AND ARSOs.AAStatus = 'Alive'
                                                    INNER JOIN #ICProductTmps
                                                        ON ARSOItems.FK_ICProductID = #ICProductTmps.ICProductID
                                                    LEFT JOIN #ARShps ON #ARShps.FK_ARSOItemID = ARSOItems.ARSOItemID
                                                           AND #ARShps.FK_ICProductID = ARSOItems.FK_ICProductID
                                                WHERE ARSOItems.ARSOItemRQty > 0
                                                      AND ARSOItems.AAStatus = 'Alive'      
                                                      AND CONVERT(VARCHAR(10), ARSOItems.ARSOItemShpDate, 112) >= CONVERT(VARCHAR(10), '{0}', 112);
                                                -- 
                                                IF OBJECT_ID('tempdb..#ICProductTmps') IS NOT NULL
                                                    DROP TABLE #ICProductTmps;
                                                IF OBJECT_ID('tempdb..#ARShps') IS NOT NULL
                                                    DROP TABLE #ARShps;", dte.ToString("yyyyMMdd"));
            return dal.GetDataSet(strQuery);
        }

        /// <summary>
        /// Viet Nguyen 2014.10.22
        /// Get SO Item By Product & SOID
        /// </summary>
        public DataSet GetAllSOItemByProductAndSOID(int iProductID, int iSOID)
        {
            string strQuery = string.Format(@"Select * from ARSOItems where AAStatus='Alive' and FK_ICProductID={0} and FK_ARSOID={1}", iProductID, iSOID);
            return dal.GetDataSet(strQuery);
        }
        /// <summary>
        /// NhamNDH -29/11/2016- Lấy danh sách SO còn số lượng chưa tạo lệnh sản xuất.
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllObjetHasRemainQty(int iARSOID)
        {
            string strQuery = string.Format(@"  SELECT  ARSOItems.*
                                                FROM    dbo.ARSOItems
                                                INNER JOIN ARSOs ON ARSOs.ARSOID = ARSOItems.FK_ARSOID AND dbo.ARSOs.AAStatus = 'Alive'
                                                WHERE   
                                                        ARSOItems.AAStatus = 'Alive' 
                                                        AND ARSOItems.ARSOItemQty > ARSOItems.ARSOItemOnWOQty
                                                        AND ARSOItems.FK_ARSOID = {0}
                                                ", iARSOID);
            return GetDataSet(strQuery);
        }

        //NhamNDH add -05/12/2016- lấy SOItem theo ID và ProductID
        public DataSet GetAllSOItemByProductAndSOItemID(int iProductID, int iSOItemID)
        {
            string strQuery = string.Format(@"Select * from ARSOItems where AAStatus='Alive' and FK_ICProductID={0} and ARSOItemID={1}", iProductID, iSOItemID);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetRQtySOItemsToWORBySOID(int iARSOID)
        {
            string strQuery = string.Format(@"SELECT ARSOItems.ARSOItemID,
                                                       ARSOItems.ARSOItemQty - ISNULL(WOR.PPWORItemQty,0) AS ARSOItemQty
                                                FROM dbo.ARSOs
                                                    INNER JOIN dbo.ARSOItems
                                                        ON ARSOItems.FK_ARSOID = ARSOs.ARSOID
                                                           AND ARSOItems.AAStatus = 'Alive'
                                                    LEFT JOIN
                                                     (
                                                         SELECT PPWORItems.FK_ARSOItemID AS FK_ARSOItemID,
                                                                SUM(PPWORItems.PPWORItemQty) AS PPWORItemQty
                                                         FROM dbo.PPWORs
                                                             INNER JOIN dbo.PPWORItems
                                                                 ON PPWORItems.FK_PPWORID = PPWORs.PPWORID
                                                                    AND PPWORItems.AAStatus = 'Alive'
                                                         WHERE PPWORs.AAStatus = 'Alive'
				                                                AND PPWORItems.FK_ARSOID = {0}
                                                         GROUP BY PPWORItems.FK_ARSOItemID
                                                     )WOR ON WOR.FK_ARSOItemID = ARSOItems.ARSOItemID
                                                WHERE 
                                                        ARSOs.AAStatus = 'Alive'                                                        
		                                                AND ARSOItems.ARSOItemQty > ISNULL(WOR.PPWORItemQty,0) 
		                                                AND dbo.ARSOs.ARSOID = {0};
                                                ", iARSOID);
            return dal.GetDataSet(strQuery);
        }
    #endregion
    }
}