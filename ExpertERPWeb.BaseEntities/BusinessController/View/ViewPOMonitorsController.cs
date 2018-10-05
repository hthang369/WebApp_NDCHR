
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewPOMonitors
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.63)
	//Class: ViewPOMonitorsController
	//Created Date: Monday, 11 Jul 2016
	//-----------------------------------------------------------
	
	public class ViewPOMonitorsController : BaseBusinessController
	{
		public ViewPOMonitorsController()
		{
			dal = new DALBaseProvider("ViewPOMonitors",typeof(ViewPOMonitorsInfo));
		}
        #region Thang add - 9/4/2016 
        public DataSet GetAllDataMonitor(DateTime dt, int iSupplierID, DateTime dtFrom, DateTime dtTo)
        {
            //string strDate = string.Format("'{0:yyyy-MM-dd}'", dt);
            //Thang - edit comment đưa vào store để tăng tốc độ truy vấn
            #region
            //string searchDate = DALUtil.GenerateBeetween("APPODate", dtFrom, dtTo);
            /*string strQuery = string.Format(@"
				IF OBJECT_ID('tempdb..#tKQRcp') IS NOT NULL
	                DROP TABLE #tKQRcp
                SELECT * INTO #tKQRcp
                FROM (
	                SELECT 
		                a.APPOID,
		                a.APPONo,
		                c.FK_APPOItemID,
		                ICRequestReceiptID AS APPInvoiceID,
		                ICRequestReceiptNo AS APPInvoiceNo,
		                NULL AS APPInvoiceInvNo,
		                NULL AS APPInvoiceInvDate,
		                ICReceiptID,
		                ICReceiptNo,
		                ICReceiptDate,
		                ICReceiptItemQty
	                FROM APPOs a 
		                JOIN APPOItems b ON a.APPOID = b.FK_APPOID AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive'
		                JOIN ICRequestReceiptPOs d ON a.APPOID = d.FK_APPOID AND d.AAStatus = 'Alive'
		                JOIN ICRequestReceiptItemPOItems c ON b.APPOItemID = c.FK_APPOItemID AND c.AAStatus = 'Alive'
		                JOIN ICRequestReceipts e ON e.ICRequestReceiptID = d.FK_ICRequestReceiptID AND e.AAStatus = 'Alive'
		                LEFT JOIN ICReceiptRequestReceipts f ON e.ICRequestReceiptID = f.FK_ICRequestReceiptID AND f.AAStatus = 'Alive'
		                LEFT JOIN ICReceipts g ON f.FK_ICReceiptID = g.ICReceiptID AND g.AAStatus = 'Alive'
		                LEFT JOIN ICReceiptItems h ON g.ICReceiptID = h.FK_ICReceiptID
	                UNION
	                SELECT 
		                a.APPOID,
		                a.APPONo,
		                c.FK_APPOItemID,
		                NULL as APPInvoiceID,
		                NULL as APPInvoiceNo,
		                NULL AS APPInvoiceInvNo,
		                NULL AS APPInvoiceInvDate,
		                ICReceiptID,
		                ICReceiptNo,
		                ICReceiptDate,
		                ICReceiptItemQty
	                FROM APPOs a 
		                JOIN APPOItems b ON a.APPOID = b.FK_APPOID AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive'
		                JOIN ICReceiptItemPurchaseOrderItems c ON b.APPOItemID = c.FK_APPOItemID AND c.AAStatus = 'Alive'
		                JOIN ICReceiptItems d ON d.ICReceiptItemID = c.FK_ICReceiptItemID AND d.AAStatus = 'Alive'
		                JOIN ICReceipts e ON d.FK_ICReceiptID = e.ICReceiptID AND e.AAStatus = 'ALive'
	                UNION
	                SELECT 
		                APPOID,
		                APPONo,
		                c.FK_APPOItemID,
		                APPInvoiceID,
		                APPInvoiceNo,
		                APPInvoiceInvNo,
		                APPInvoiceInvDate,
		                ICReceiptID,
		                ICReceiptNo,
		                ICReceiptDate,
		                ICReceiptItemQty
	                FROM APPOs a 
		                JOIN APPOItems b ON a.APPOID = b.FK_APPOID AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive'
		                JOIN APPInvoiceItemPurchaseOrderItems c ON b.APPOItemID = c.FK_APPOItemID AND c.AAStatus = 'Alive'
		                JOIN APPInvoiceItems d ON d.APPInvoiceItemID = c.FK_APPInvoiceItemID AND d.AAStatus = 'Alive'
		                JOIN APPInvoices e ON d.FK_APPInvoiceID = e.APPInvoiceID AND e.AAStatus = 'Alive'
		                LEFT JOIN APPInvoiceItemReceiptItems f ON f.FK_APPInvoiceItemID = d.APPInvoiceItemID AND f.AAStatus = 'Alive'
		                LEFT JOIN ICReceiptItems g ON f.FK_ICReceiptItemID = g.ICReceiptItemID AND g.AAStatus = 'Alive'
		                LEFT JOIN ICReceipts h ON g.FK_ICReceiptID = h.ICReceiptID AND h.AAStatus = 'Alive'
                ) AS rcp
                
                IF OBJECT_ID('tempdb..#tNV') IS NOT NULL
					DROP TABLE #tNV

				SELECT HRDepartmentID,HRDepartmentNo,HRDepartmentName,HREmployeeID,APPOID 
                INTO #tNV
				FROM HRDepartments a 
                    JOIN HREmployees b ON FK_HRDepartmentID = HRDepartmentID AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive'
				    JOIN APPOs c ON b.HREmployeeID = c.FK_HREmployeeID AND c.AAStatus = 'Alive'

				IF OBJECT_ID('tempdb..#tKQ') IS NOT NULL
					DROP TABLE #tKQ

				DECLARE @ngay AS date
				SET @ngay = {0}
				SELECT DISTINCT 
					APPOID as FK_APPOID,
					b.FK_ICProductID,
					a.FK_APSupplierID,
					c.FK_APPRID,
					APPOItemQty AS ViewPOMonitorQty,
					APPOItemRQty AS ViewPOMonitorRQty,
                    APPOItemID AS FK_APPOItemID,
					ISNULL(CASE WHEN APPOItemQty > 0 THEN 
								(((APPOItemQty - APPOItemRQty) * 100) / APPOItemQty) 
							END, 0) AS ViewPOMonitorRcpPct,
					ISNULL(CASE WHEN 
								CASE WHEN DATEDIFF(day, APPODate, APPOItemArrivalDate) > 0 THEN
									100 * DATEDIFF(day, APPODate, @ngay) / DATEDIFF(day, APPODate, APPOItemArrivalDate) 
								END > 100 THEN 100 
							ELSE 
								CASE WHEN DATEDIFF(day, APPODate, APPOItemArrivalDate) > 0 THEN
									100 * DATEDIFF(day, APPODate, @ngay) / DATEDIFF(day, APPODate, APPOItemArrivalDate) 
								END 
							END, 0) AS ViewPOMonitorQty1,
					ISNULL((SELECT SUM(ICReceiptItemQty) FROM #tKQRcp WHERE FK_APPOItemID = APPOItemID), 0) AS ViewPOMonitorQty2,
					CASE WHEN CEILING(ISNULL(DATEDIFF(day, APPOItemArrivalDate, @ngay), 0)) < 0 THEN 0
					ELSE CEILING(ISNULL(DATEDIFF(day, APPOItemArrivalDate, @ngay), 0))
					END AS ViewPOMonitorQty4,
					APPOItemArrivalDate AS ViewPOMonitorArrivalDate,
					(SELECT MAX(ICReceiptDate) FROM #tKQRcp WHERE APPOID = b.FK_APPOID) AS ViewPOMonitorLastDate,
                    (SELECT MAX(APPInvoiceInvNo) FROM #tKQRcp WHERE APPOID = b.FK_APPOID) AS ViewPOMonitorSerialNo,
					(SELECT MAX(APPInvoiceInvDate) FROM #tKQRcp WHERE APPOID = b.FK_APPOID) AS ViewPOMonitorSerialDate 
				INTO #tKQ
				FROM    APPOItems b
                        INNER JOIN APPOs a ON FK_APPOID = APPOID
                                              AND b.AAStatus = 'Alive'
                                              AND a.AAStatus = 'Alive'
      LEFT JOIN dbo.APPRItemPOItems d ON (d.FK_APPOItemID = b.APPOItemID
             AND d.AAStatus = 'Alive')
      LEFT JOIN dbo.APPRItems c ON (c.APPRItemID = d.FK_APPRItemID
           AND c.AAStatus = 'Alive')
                WHERE {2}

				SELECT *,
					CASE WHEN ViewPOMonitorQty2 = ViewPOMonitorQty THEN N'Hoàn thành'
						ELSE N'Chưa hoàn thành'
					END as ViewPOMonitorStatus,
					ISNULL(DATEDIFF(day, ViewPOMonitorLastDate, ViewPOMonitorArrivalDate), 0) AS ViewPOMonitorQty3,
					CASE WHEN ViewPOMonitorQty2 = ViewPOMonitorQty THEN
						CASE WHEN DATEDIFF(day, ViewPOMonitorArrivalDate, ViewPOMonitorLastDate) = 0 THEN N'Đúng hạn'
							 WHEN DATEDIFF(day, ViewPOMonitorArrivalDate, ViewPOMonitorLastDate) < 0 THEN N'Trước hạn'
						    ELSE N'Quá hạn'
						END
					ELSE 
						CASE WHEN DATEDIFF(day, ViewPOMonitorArrivalDate, @ngay) >= 0 THEN N'Trễ hạn'
							 WHEN DATEDIFF(day, ViewPOMonitorArrivalDate, @ngay) < 0 THEN N'Chưa đến hạn'
						END
					END AS ViewPOMonitorComment,
                    (SELECT HRDepartmentID FROM #tNV WHERE APPOID = FK_APPOID) AS FK_HRDepartmentID
				FROM #tKQ WHERE (FK_APSupplierID = {1} or {1} = 0)", strDate, iSupplierID, searchDate);*/
            #endregion
            return SqlDatabaseHelper.RunStoredProcedure("sp_ViewPOMonitor", dt, dtFrom, dtTo, iSupplierID);
        }
        #endregion
    }
    #endregion
}