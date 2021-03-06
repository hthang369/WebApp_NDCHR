﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICInventoryStatistics
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICInventoryStatisticsController
    //Created Date:Friday, May 13, 2011
    //-----------------------------------------------------------

    public class ICInventoryStatisticsController : BaseBusinessController
    {
        public ICInventoryStatisticsController()
        {
            dal = new DALBaseProvider("ICInventoryStatistics", typeof(ICInventoryStatisticsInfo));
        }

        public DataSet ProductStatistic(DateTime fromdaybefore, DateTime todaybefore, DateTime fromdayafter, DateTime todayafter, int stockid, int productid)
        {
            return dal.GetDataSet("Statistic_Product", fromdaybefore.ToString("yyyyMMdd"), todaybefore.ToString("yyyyMMdd"), fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, productid);
        }
        public DataSet ICProductStatistic(DateTime fromdayafter, DateTime todayafter, int stockid, int productid)
        {
            return dal.GetDataSet("ICStatistic_Product", fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, productid);
        }
        public DataSet ProductStatistic_Receipt(DateTime fromdayafter, DateTime todayafter, int stockid, int productid, String ReceiptType)
        {
            return dal.GetDataSet("Statistic_Product_Receipt", fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, productid, ReceiptType);
        }

        public DataSet ProductStatistic_Shipment(DateTime fromdayafter, DateTime todayafter, int stockid, int productid, String ShipmentType)
        {
            return dal.GetDataSet("Statistic_Product_Shipment", fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, productid, ShipmentType);
        }

        public DataSet ProductStatistic_Receipt_InnerJoin(DateTime fromdayafter, DateTime todayafter, int stockid, int productid)
        {
            return dal.GetDataSet("Statistic_Product_Receipt_InnerJoin", fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, productid);
        }

        public DataSet ProductStatistic_Shipment_InnerJoin(DateTime fromdayafter, DateTime todayafter, int stockid, int productid)
        {
            return dal.GetDataSet("Statistic_Product_Shipment_InnerJoin", fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, productid);
        }

        public DataSet ProductStatistic_WithType(DateTime fromdaybefore, DateTime todaybefore, DateTime fromdayafter, DateTime todayafter, int stockid, int productid)
        {
            return dal.GetDataSet("Statistic_Product_withType", fromdaybefore.ToString("yyyyMMdd"), todaybefore.ToString("yyyyMMdd"), fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, productid);
        }
        public DataSet ProductStatistic_UpdateByStore(DateTime fromdaybefore, DateTime todaybefore, DateTime fromdayafter, DateTime todayafter, int stockid, int Period, int Year)
        {
            return dal.GetDataSet("Statistic_Product_Cursor", fromdaybefore.ToString("yyyyMMdd"), todaybefore.ToString("yyyyMMdd"), fromdayafter.ToString("yyyyMMdd"), todayafter.ToString("yyyyMMdd"), stockid, Period, Year);
        }
        public ICInventoryStatisticsInfo GetObjectByStockIDProductIDPeriodAndYear(int StockID, int ProductID, int Period, int Year)
        {
            String strQuery = String.Format(@"SELECT * FROM ICInventoryStatistics WHERE AAStatus = 'Alive'
                                                            AND FK_ICProductID = {0}
                                                            AND FK_ICStockID = {1}
                                                            AND ICInventoryStatisticPeriod = {2}
                                                            AND ICInventoryStatisticYear = {3}",
                                                            ProductID,
                                                            StockID,
                                                            Period,
                                                            Year);
            //return (ICInventoryStatisticsInfo)dal.GetDataObject("InventoryStatistic_GetByStockIDProductIDPeriodAndYear", StockID, ProductID, Period, Year);
            DataSet ds = dal.GetDataSet(strQuery);
            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ICInventoryStatisticsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }
        public DataSet GetObjectByStockIDProductIDPeriodAndYear(int Period, int Year)
        {
            String strQuery = String.Format(@"SELECT FK_ICProductID,FK_ICStockID,ICInventoryStatisticEndQty,ICInventoryStatisticEndCostAmt FROM ICInventoryStatistics WHERE AAStatus = 'Alive'
                                                            AND ICInventoryStatisticPeriod = {0}
                                                            AND ICInventoryStatisticYear = {1}
                                                            AND FK_ICProductID in (Select ICProductID from ICProducts where AAStatus='Alive')
                                                            AND FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive')",
                                                            Period,
                                                            Year);
            //return (ICInventoryStatisticsInfo)dal.GetDataObject("InventoryStatistic_GetByStockIDProductIDPeriodAndYear", StockID, ProductID, Period, Year);
            strQuery += string.Format(" order by FK_ICStockID,FK_ICProductID");
            DataSet ds = dal.GetDataSet(strQuery);

            return ds;
        }

        public void DelectAllObjectByPeriodAndYear(int Period, int Year)
        {
            dal.GetDataSet("InventoryStatistic_DeleteByPeriodAndYear", Period, Year);
        }

        public void DelectAllObjectByPeriodAndYear(int Period, int Year,int iProductID)
        {
            dal.GetDataSet("delete from ICInventorystatistics where  ICInventoryStatisticPeriod=" + Period + " and ICInventoryStatisticYear=" + Year + " and FK_ICProductID="+iProductID);
        }   
        public void DelectObjectByBranchProductStockAndTime(int iBranchID, int iProductID, int iStockID, int Period, int Year)
        {
            String strQuery = String.Format(@"DELETE ICInventoryStatistics 
                                                    WHERE FK_ICProductID = {0}
                                                    AND FK_BRBranchID = {1}
                                                    AND FK_ICStockID = {2} 
                                                    AND ICInventoryStatisticPeriod = {3} 
                                                    AND ICInventoryStatisticYear = {4}",
                                                    iProductID,
                                                    iBranchID,
                                                    iStockID,
                                                    Period,
                                                    Year);
            dal.GetDataSet(strQuery);
        }
        public DataSet GetAllInformationStatistic_Company(DateTime FromDay, DateTime Today)
        {
            DateTime dt = FromDay.AddDays(-1);
            return dal.GetDataSet("InventoryStatistic_GetAllStatistic_inCompany", FromDay.ToString("yyyyMMdd"), Today.ToString("yyyyMMdd"), dt.Month, dt.Year, FromDay.Month, FromDay.Year);
        }

        public DataSet GetAllInformationStatistic(DateTime FromDay, DateTime Today)
        {
            DateTime dt = FromDay.AddDays(-1);
            return dal.GetDataSet("InventoryStatistic_GetAllStatistic", FromDay.ToString("yyyyMMdd"), Today.ToString("yyyyMMdd"), dt.Month, dt.Year, FromDay.Month, FromDay.Year);
        }

        public DataSet GetAllObjectInCompanyByPeriodAndYear(DateTime PeriodDay)
        {
            return dal.GetDataSet("InventoryStatistic_GetAllObject_InCompany", PeriodDay.Month, PeriodDay.Year);
        }
        public DataSet GetAllObjectByStockIDPerdiodAndYear(int StockID, DateTime PeriodDay)
        {
            return dal.GetDataSet("InventoryStatistic_GetAllProduct_ByStockPeriodAndYear", StockID, PeriodDay.Month, PeriodDay.Year);
        }
        public DataSet GetProductByStockPeriodAndYear(int ProductID, DateTime PeriodDay)
        {
            return dal.GetDataSet("InventotyStatistic_GetProduct_byPeriodAndYear", ProductID, PeriodDay.Month, PeriodDay.Year);
        }
        public DataSet GetObjectByStockProductPeriodAndYear(int StockID, int ProductID, DateTime PeriodDay)
        {
            return dal.GetDataSet("InventotyStatistic_GetObject_byStockIDProductIDPeriodAndYear", StockID, ProductID, PeriodDay.Month, PeriodDay.Year);
        }

        public void InsertObject(ICInventoryStatisticsInfo InventoryStatisticsInfo)
        {
            dal.GetDataSet("ICInventoryStatistics_Insert_Identity", InventoryStatisticsInfo.FK_ICStockID, InventoryStatisticsInfo.FK_ICProductID, InventoryStatisticsInfo.ICInventoryStatisticBeginQty, InventoryStatisticsInfo.ICInventoryStatisticBeginCostAmt, InventoryStatisticsInfo.ICInventoryStatisticEndQty,
                     InventoryStatisticsInfo.ICInventoryStatisticEndCostAmt, InventoryStatisticsInfo.ICInventoryStatisticShipmentNewQty, InventoryStatisticsInfo.ICInventoryStatisticShipmentNewCostAmt, InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustQty,
                     InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustCostAmt, InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftQty, InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftCostAmt,
                     InventoryStatisticsInfo.ICInventoryStatisticReceiptNewQty, InventoryStatisticsInfo.ICInventoryStatisticReceiptNewCostAmt, InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustQty,
                     InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustCostAmt, InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnQty, InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnCostAmt, InventoryStatisticsInfo.AAStatus,
                     0, InventoryStatisticsInfo.ICInventoryStatisticPeriod, InventoryStatisticsInfo.ICInventoryStatisticYear, InventoryStatisticsInfo.ICInventoryStatisticDate.Value);
            //            String  s =String.Format(@"INSERT INTO [dbo].[ICInventoryStatistics](	[FK_ICStockID],	[FK_ICProductID],	[ICInventoryStatisticBeginQty],	[ICInventoryStatisticBeginCostAmt],
            //                            	[ICInventoryStatisticEndQty],	[ICInventoryStatisticEndCostAmt],	[ICInventoryStatisticShipmentNewQty],	[ICInventoryStatisticShipmentNewCostAmt],
            //	                            [ICInventoryStatisticShipmentAdjustQty],	[ICInventoryStatisticShipmentAdjustCostAmt],	[ICInventoryStatisticShipmentGiftQty],	[ICInventoryStatisticShipmentGiftCostAmt],
            //	                            [ICInventoryStatisticReceiptNewQty],	[ICInventoryStatisticReceiptNewCostAmt],	[ICInventoryStatisticReceiptAdjustQty],	[ICInventoryStatisticReceiptAdjustCostAmt],
            //                            	[ICInventoryStatisticReceiptReturnQty],	[ICInventoryStatisticReceiptReturnCostAmt],	[AAStatus],	[AASelected],
            //	                            [ICInventoryStatisticPeriod],	[ICInventoryStatisticYear],	[ICInventoryStatisticDate])
            //                                VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},'{18}',{19},{20},{21},'{22}')",
            //                                 InventoryStatisticsInfo.FK_ICStockID, InventoryStatisticsInfo.FK_ICProductID, InventoryStatisticsInfo.ICInventoryStatisticBeginQty, InventoryStatisticsInfo.ICInventoryStatisticBeginCostAmt, InventoryStatisticsInfo.ICInventoryStatisticEndQty,
            //                                 InventoryStatisticsInfo.ICInventoryStatisticEndCostAmt, InventoryStatisticsInfo.ICInventoryStatisticShipmentNewQty, InventoryStatisticsInfo.ICInventoryStatisticShipmentNewCostAmt, InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustQty,
            //                                 InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustCostAmt, InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftQty, InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftCostAmt,
            //                                 InventoryStatisticsInfo.ICInventoryStatisticReceiptNewQty, InventoryStatisticsInfo.ICInventoryStatisticReceiptNewCostAmt, InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustQty,
            //                                 InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustCostAmt, InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnQty, InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnCostAmt, InventoryStatisticsInfo.AAStatus,
            //                                 0, InventoryStatisticsInfo.ICInventoryStatisticPeriod, InventoryStatisticsInfo.ICInventoryStatisticYear, InventoryStatisticsInfo.ICInventoryStatisticDate);
            //            dal.GetDataSet(s);
        }
        public void InsertObject(ref List<ICInventoryStatisticsInfo> lst)
        {
            //GMCWaitingDialog.SetTitle("Cập nhật dữ liệu tồn kho ...");
            //GMCWaitingDialog.SetCaption("Đang xử lý...");
            //GMCWaitingDialog.Show();
            //GMCWaitingDialog.SetProgress(0, lst.Count);
            ICInventoryStatisticsInfo InventoryStatisticsInfo = new ICInventoryStatisticsInfo();
            if (lst.Count == 0) return;
            InventoryStatisticsInfo = lst[0];

            System.Globalization.NumberFormatInfo info = new
            System.Globalization.NumberFormatInfo();
            info.NumberDecimalSeparator = ".";
            info.NumberGroupSeparator = ",";

            #region Initial String
            String s = String.Format(@"INSERT INTO [dbo].[ICInventoryStatistics](	[FK_ICStockID],	[FK_ICProductID],	[ICInventoryStatisticBeginQty],	[ICInventoryStatisticBeginCostAmt],
                                        	[ICInventoryStatisticEndQty],	[ICInventoryStatisticEndCostAmt],	[ICInventoryStatisticShipmentNewQty],	[ICInventoryStatisticShipmentNewCostAmt],
            	                            [ICInventoryStatisticShipmentAdjustQty],	[ICInventoryStatisticShipmentAdjustCostAmt],	[ICInventoryStatisticShipmentGiftQty],	[ICInventoryStatisticShipmentGiftCostAmt],
            	                            [ICInventoryStatisticReceiptNewQty],	[ICInventoryStatisticReceiptNewCostAmt],	[ICInventoryStatisticReceiptAdjustQty],	[ICInventoryStatisticReceiptAdjustCostAmt],
                                        	[ICInventoryStatisticReceiptReturnQty],	[ICInventoryStatisticReceiptReturnCostAmt],	[AAStatus],	[AASelected],
            	                            [ICInventoryStatisticPeriod],	[ICInventoryStatisticYear],	[ICInventoryStatisticDate],[ICInventoryStatisticProductName],[ICInventoryStatisticStockName], [FK_BRBranchID], [ICInventoryStatisticProductNo])
                                            Select {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},'{18}',{19},{20},{21},'{22}',N'{23}','{24}', {25}, N'{26}'",
                                 InventoryStatisticsInfo.FK_ICStockID, InventoryStatisticsInfo.FK_ICProductID, Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticBeginQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticBeginCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticEndQty, info),
                                Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticEndCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentNewQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentNewCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustQty, info),
                                 Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftCostAmt, info),
                                 Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptNewQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptNewCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustQty, info),
                                 Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnCostAmt, info), InventoryStatisticsInfo.AAStatus,
                                 0, InventoryStatisticsInfo.ICInventoryStatisticPeriod, InventoryStatisticsInfo.ICInventoryStatisticYear, InventoryStatisticsInfo.ICInventoryStatisticDate.Value.ToString("yyyy/MM/dd hh:mm:ss"), InventoryStatisticsInfo.ICInventoryStatisticProductName, InventoryStatisticsInfo.ICInventoryStatisticStockName, InventoryStatisticsInfo.FK_BRBranchID, InventoryStatisticsInfo.ICInventoryStatisticProductNo);
            #endregion

            string Union = "";

            for (int i = 1; i < lst.Count; i++)
            {
                InventoryStatisticsInfo = lst[i];
                Union = "";

                #region Add Union insert
                Union = String.Format(" union all Select {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},'{18}',{19},{20},{21},'{22}',N'{23}','{24}', {25}, N'{26}'",
                    InventoryStatisticsInfo.FK_ICStockID, InventoryStatisticsInfo.FK_ICProductID, Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticBeginQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticBeginCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticEndQty, info),
                                 Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticEndCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentNewQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentNewCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustQty, info),
                                  Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftCostAmt, info),
                                  Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptNewQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptNewCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustQty, info),
                                  Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnCostAmt, info), InventoryStatisticsInfo.AAStatus,
                                 0, InventoryStatisticsInfo.ICInventoryStatisticPeriod, InventoryStatisticsInfo.ICInventoryStatisticYear, InventoryStatisticsInfo.ICInventoryStatisticDate.Value.ToString("yyyy/MM/dd hh:mm:ss"), InventoryStatisticsInfo.ICInventoryStatisticProductName, InventoryStatisticsInfo.ICInventoryStatisticStockName, InventoryStatisticsInfo.FK_BRBranchID, InventoryStatisticsInfo.ICInventoryStatisticProductNo);
                #endregion

                s += Union;
                if (i % 25 == 0)
                {
                    dal.GetDataSet(s);
                    s = "";
                    i++;
                    if (i < lst.Count)
                    {
                        InventoryStatisticsInfo = lst[i];

                        #region ReInitial String
                        s = String.Format(@"INSERT INTO [dbo].[ICInventoryStatistics](	[FK_ICStockID],	[FK_ICProductID],	[ICInventoryStatisticBeginQty],	[ICInventoryStatisticBeginCostAmt],
                                        	[ICInventoryStatisticEndQty],	[ICInventoryStatisticEndCostAmt],	[ICInventoryStatisticShipmentNewQty],	[ICInventoryStatisticShipmentNewCostAmt],
            	                            [ICInventoryStatisticShipmentAdjustQty],	[ICInventoryStatisticShipmentAdjustCostAmt],	[ICInventoryStatisticShipmentGiftQty],	[ICInventoryStatisticShipmentGiftCostAmt],
            	                            [ICInventoryStatisticReceiptNewQty],	[ICInventoryStatisticReceiptNewCostAmt],	[ICInventoryStatisticReceiptAdjustQty],	[ICInventoryStatisticReceiptAdjustCostAmt],
                                        	[ICInventoryStatisticReceiptReturnQty],	[ICInventoryStatisticReceiptReturnCostAmt],	[AAStatus],	[AASelected],
            	                            [ICInventoryStatisticPeriod],	[ICInventoryStatisticYear],	[ICInventoryStatisticDate],[ICInventoryStatisticProductName],[ICInventoryStatisticStockName], [FK_BRBranchID], [ICInventoryStatisticProductNo])
                                            Select {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},'{18}',{19},{20},{21},'{22}',N'{23}','{24}', {25}, N'{26}'",
                                            InventoryStatisticsInfo.FK_ICStockID, InventoryStatisticsInfo.FK_ICProductID, Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticBeginQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticBeginCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticEndQty, info),
                                            Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticEndCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentNewQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentNewCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustQty, info),
                                            Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentAdjustCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticShipmentGiftCostAmt, info),
                                            Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptNewQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptNewCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustQty, info),
                                            Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptAdjustCostAmt, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnQty, info), Convert.ToString(InventoryStatisticsInfo.ICInventoryStatisticReceiptReturnCostAmt, info), InventoryStatisticsInfo.AAStatus,
                                            0, InventoryStatisticsInfo.ICInventoryStatisticPeriod, InventoryStatisticsInfo.ICInventoryStatisticYear, InventoryStatisticsInfo.ICInventoryStatisticDate.Value.ToString("yyyy/MM/dd hh:mm:ss"), InventoryStatisticsInfo.ICInventoryStatisticProductName, InventoryStatisticsInfo.ICInventoryStatisticStockName, InventoryStatisticsInfo.FK_BRBranchID, InventoryStatisticsInfo.ICInventoryStatisticProductNo);
                        #endregion

                        //GMCWaitingDialog.SetPosition(i);
                    }

                }
            }
            if (!string.IsNullOrEmpty(s))
                dal.GetDataSet(s);
            //GMCWaitingDialog.HideDialog();
        }

        public ICInventoryStatisticsInfo GetInventoryStatisticFromPeriod(int iProductID, int iStockID, int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM ICInventoryStatistics 
                                                        WHERE FK_ICProductID = {0}
                                                        AND FK_ICStockID = {1}
                                                        AND ICInventoryStatisticPeriod = {2}
                                                        AND ICInventoryStatisticYear = {3}",
                                                        iProductID,
                                                        iStockID,
                                                        iPeriod,
                                                        iYear);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ICInventoryStatisticsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }

        public DataSet GetInventoryStatisticFromPeriod(int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM ICInventoryStatistics 
                                                        WHERE ICInventoryStatisticPeriod = {0}
                                                        AND ICInventoryStatisticYear = {1} order by FK_ICProductID,FK_ICStockID",
                                                        iPeriod,
                                                        iYear);
            DataSet ds = dal.GetDataSet(strQuery);
            return ds;
        }
        
        #region Lấy tổng số lượng sản phẩm theo kho và ngày từ các phiếu chuyển kho và điều chỉnh giảm --Vinh --07/06/2013

        public DataSet LayTongSoLuongCuaSPTheoKhoVaNgay(int iStockID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT
	                                            FK_ICProductID,
                                                FK_ICStockID,
                                                ISNULL((SELECT FK_ICProductGroupID FROM ICProducts WHERE AAStatus='Alive' AND ICProductID = FK_ICProductID), 0) AS FK_ICProductGroupID,
	                                            SUM(Qty) AS ViewInventoryStatisticAfterQty
                                            FROM (
	                                            SELECT
		                                            TransferItem.FK_ICProductID,
                                                    TransferItem.FK_ICFromStockID AS FK_ICStockID,
		                                            SUM(TransferItem.ICTransferItemQty) AS Qty
	                                            FROM dbo.ICTransferItems TransferItem
	                                            WHERE TransferItem.AAStatus='Alive'
	                                            AND FK_ICTransferID IN (
								                                            SELECT Tranfer.ICTransferID 
								                                            FROM dbo.ICTransfers Tranfer 
								                                            WHERE Tranfer.AAStatus='Alive'
								                                            AND CONVERT(NVARCHAR(10),Tranfer.ICTransferDate,112) >= '{1}'
								                                            AND CONVERT(NVARCHAR(10),Tranfer.ICTransferDate,112) <= '{2}'
							                                            )
	                                            AND TransferItem.FK_ICFromStockID = {0}
	                                            GROUP BY TransferItem.FK_ICProductID, TransferItem.FK_ICFromStockID

	                                            --UNION ALL

	                                            --SELECT 
		                                        --    AdjInvItem.FK_ICProductID,
                                                --    AdjInvItem.FK_ICStockID,
		                                        --    SUM(AdjInvItem.ICAdjInvItemQty) AS Qty
	                                            --FROM dbo.ICAdjInvItems AdjInvItem
	                                            --WHERE AdjInvItem.AAStatus='Alive'
	                                            --AND FK_ICAdjInvID IN (
							                    --                        SELECT AdjInv.ICAdjInvID 
							                    --                        FROM dbo.ICAdjInvs AdjInv 
							                    --                        WHERE AdjInv.AAStatus='Alive'
							                    --                        AND CONVERT(NVARCHAR(10),AdjInv.ICAdjInvDate,112) >= '{1}'
							                    --                        AND CONVERT(NVARCHAR(10),AdjInv.ICAdjInvDate,112) <= '{2}'
						                        --                      )
	                                            --AND AdjInvItem.FK_ICStockID = {0}
	                                            --AND AdjInvItem.ICAdjInvItemTypeCombo = 'DecQty'
	                                            --GROUP BY AdjInvItem.FK_ICProductID, AdjInvItem.FK_ICStockID
                                            ) AS TB
                                            GROUP BY FK_ICProductID, FK_ICStockID
                                            ", iStockID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        #endregion

        #region Lấy tổng số lượng sản phẩm nhập kho theo nhóm sản phẩm và ngày từ các phiếu chuyển quy trình --Vinh --07/06/2013

        public DataSet LayTongSoLuongNhapCuaSPTrongNXQTTheoLoaiSPVaNgay(int iProductGroupID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT 
	                                            ReceiptItem.FK_ICProductID,
                                                ReceiptItem.FK_ICStockID,
                                                ISNULL((SELECT FK_ICProductGroupID FROM ICProducts WHERE AAStatus='Alive' AND ICProductID = ReceiptItem.FK_ICProductID), 0) AS FK_ICProductGroupID,
	                                            SUM(ReceiptItem.ICReceiptItemQty) AS ViewInventoryStatisticAfterQty
                                            FROM dbo.ICReceiptItems ReceiptItem
                                            WHERE ReceiptItem.AAStatus='Alive'
                                            AND FK_PPProductionOrdrID IN (
								                                            SELECT ProOrd.PPProductionOrdrID 
								                                            FROM dbo.PPProductionOrdrs ProOrd 
								                                            WHERE ProOrd.AAStatus = 'Alive'
								                                            AND CONVERT(NVARCHAR(10),ProOrd.PPProductionOrdrDate, 112) >= '{1}'
								                                            AND CONVERT(NVARCHAR(10),ProOrd.PPProductionOrdrDate, 112) <= '{2}'
							                                             )
                                            AND FK_ICProductID IN (
							                                            SELECT Product.ICProductID 
							                                            FROM dbo.ICProducts Product
							                                            WHERE Product.AAStatus = 'Alive'
							                                            AND FK_ICProductGroupID = {0}
					                                              )
                                            GROUP BY ReceiptItem.FK_ICProductID, ReceiptItem.FK_ICStockID
                                            ", iProductGroupID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        #endregion

        #region Lấy tổng số lượng sản phẩm xuất kho theo nhóm sản phẩm và ngày từ các phiếu chuyển quy trình --Vinh --07/06/2013

        public DataSet LayTongSoLuongXuatCuaSPTrongNXQTTheoLoaiSPVaNgay(int iProductGroupID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT 
	                                            ShipmentItem.FK_ICProductID,
                                                ShipmentItem.FK_ICStockID,
                                                ISNULL((SELECT FK_ICProductGroupID FROM ICProducts WHERE AAStatus='Alive' AND ICProductID = ShipmentItem.FK_ICProductID), 0) AS FK_ICProductGroupID,
	                                            SUM(ShipmentItem.ICShipmentItemQty) AS ViewInventoryStatisticAfterQty
                                            FROM dbo.ICShipmentItems ShipmentItem
                                            WHERE ShipmentItem.AAStatus='Alive'
                                            AND FK_PPProductionOrdrID IN (
								                                            SELECT ProOrd.PPProductionOrdrID 
								                                            FROM dbo.PPProductionOrdrs ProOrd 
								                                            WHERE ProOrd.AAStatus = 'Alive'
								                                            AND CONVERT(NVARCHAR(10),ProOrd.PPProductionOrdrDate, 112) >= '{1}'
								                                            AND CONVERT(NVARCHAR(10),ProOrd.PPProductionOrdrDate, 112) <= '{2}'
							                                             )
                                            AND FK_ICProductID IN (
							                                            SELECT Product.ICProductID 
							                                            FROM dbo.ICProducts Product
							                                            WHERE Product.AAStatus = 'Alive'
							                                            AND FK_ICProductGroupID = {0}
					                                              )
                                            GROUP BY ShipmentItem.FK_ICProductID, ShipmentItem.FK_ICStockID
                                            ", iProductGroupID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        #endregion
    }
    #endregion
}