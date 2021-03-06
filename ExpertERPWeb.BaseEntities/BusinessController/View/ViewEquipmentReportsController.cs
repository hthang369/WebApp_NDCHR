using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewEquipmentReports
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewEquipmentReportsController
	//Created Date:18 Tháng Mười Hai 2012
	//-----------------------------------------------------------
	
	public class ViewEquipmentReportsController:BaseBusinessController
	{
		public ViewEquipmentReportsController()
		{
			dal= new DALBaseProvider("ViewEquipmentReports",typeof(ViewEquipmentReportsInfo));
		}
        public void DeleteAllData()
        {
            String str = String.Format(@"DELETE dbo.ViewEquipmentReports");
            dal.GetDataSet(str);
        }
        public void CreateAllData()
        {
            #region Get String Query

            String str = String.Format(@"   SELECT
	                                            FK_ICProductID,
	                                            FK_HRDepartmentID,
	                                            ViewEquipmentReportDocDate,
	                                            ViewEquipmentReportDocNo,
	                                            ViewEquipmentReportDocQty,
	                                            ViewEquipmentReportDocMonth,
	                                            ViewEquipmentReportDocRMonth,
	                                            ViewEquipmentReportDocAmt,
	                                            ViewEquipmentReportDocShpAmt,
	                                            ViewEquipmentReportDocRAmt,
	                                            ViewEquipmentReportDocDesc,
	                                            ViewEquipmentReportPeriod,
	                                            ViewEquipmentReportYear,
	                                            ViewEquipmentReportTypeCombo
                                            FROM
	                                            (
		                                            SELECT
			                                            PEAI.FK_ICProductID,
			                                            PEAI.FK_HRDeparmentID AS FK_HRDepartmentID,
			                                            PEA.GLPeriodEquipmentAllocateDate AS ViewEquipmentReportDocDate,
			                                            PEA.GLPeriodEquipmentAllocateNo AS ViewEquipmentReportDocNo,
			                                            PEAI.GLPeriodEquipmentAllocateItemQty AS ViewEquipmentReportDocQty,
			                                            EA.GLEquipmentAllocateLife AS ViewEquipmentReportDocMonth,
			                                            (EA.GLEquipmentAllocateLife - (SELECT COUNT(*) FROM dbo.GLPeriodEquipmentAllocateItems WHERE AAStatus='Alive' AND FK_GLPeriodEquipmentAllocateID IN (SELECT GLPeriodEquipmentAllocateID FROM dbo.GLPeriodEquipmentAllocates WHERE AAStatus='Alive' AND (GLPeriodEquipmentAllocatePeriod + GLPeriodEquipmentAllocateYear *12) <= (PEA.GLPeriodEquipmentAllocatePeriod + PEA.GLPeriodEquipmentAllocateYear*12)))) AS ViewEquipmentReportDocRMonth,
			                                            PEAI.GLPeriodEquipmentAllocateItemShipAmt AS ViewEquipmentReportDocAmt,
			                                            EA.GLEquipmentShipAmt AS ViewEquipmentReportDocShpAmt,
			                                            (EA.GLEquipmentShipAmt - (SELECT ISNULL(SUM(GLPeriodEquipmentAllocateItemShipAmt),0) FROM dbo.GLPeriodEquipmentAllocateItems WHERE AAStatus='Alive' AND FK_GLPeriodEquipmentAllocateID IN (SELECT GLPeriodEquipmentAllocateID FROM dbo.GLPeriodEquipmentAllocates WHERE AAStatus='Alive' AND (GLPeriodEquipmentAllocatePeriod + GLPeriodEquipmentAllocateYear *12) <= (PEA.GLPeriodEquipmentAllocatePeriod + PEA.GLPeriodEquipmentAllocateYear*12)))) AS ViewEquipmentReportDocRAmt,
			                                            '' AS ViewEquipmentReportDocDesc,
			                                            PEA.GLPeriodEquipmentAllocatePeriod AS ViewEquipmentReportPeriod,
			                                            PEA.GLPeriodEquipmentAllocateYear AS ViewEquipmentReportYear,
			                                            'PeriodEquipmentAllocateItem' AS ViewEquipmentReportTypeCombo
		                                            FROM dbo.GLPeriodEquipmentAllocateItems PEAI
		                                            INNER JOIN dbo.GLPeriodEquipmentAllocates PEA ON PEAI.FK_GLPeriodEquipmentAllocateID = PEA.GLPeriodEquipmentAllocateID
		                                            INNER JOIN dbo.GLEquipmentAllocates EA ON PEAI.FK_GLEquipmentAllocateID = EA.GLEquipmentAllocateID
		                                            WHERE PEA.AAStatus='Alive'
		                                            AND PEAI.AAStatus='Alive'
		                                            AND EA.AAStatus='Alive'
		
		                                            UNION ALL
		
		                                            SELECT
			                                            dbo.GLEquipmentDecreaseItems.FK_ICProductID,
			                                            dbo.GLEquipmentDecreaseItems.FK_HRDeparmentID AS FK_HRDepartmentID,
			                                            dbo.GLEquipmentDecreases.GLEquipmentDecreaseDate AS ViewEquipmentReportDocDate,
			                                            dbo.GLEquipmentDecreases.GLEquipmentDecreaseNo AS ViewEquipmentReportDocNo,
			                                            dbo.GLEquipmentDecreaseItems.GLEquipmentDecreaseItemQty AS ViewEquipmentReportDocQty,
			                                            dbo.GLEquipmentDecreaseItems.GLEquipmentDecreaseItemLife AS ViewEquipmentReportDocMonth,
			                                            dbo.GLEquipmentDecreaseItems.GLEquipmentRLife AS ViewEquipmentReportDocRMonth,
			                                            dbo.GLEquipmentDecreaseItems.GLEquipmentDecreaseItemAmt AS ViewEquipmentReportDocAmt,
			                                            dbo.GLEquipmentAllocates.GLEquipmentShipAmt AS ViewEquipmentReportDocShpAmt,
			                                            dbo.GLEquipmentDecreaseItems.GLEquipmentDecreaseItemRAmt AS ViewEquipmentReportDocRAmt,
			                                            dbo.GLEquipmentDecreaseItems.GLEquipmentDecreaseItemDesc AS ViewEquipmentReportDocDesc,
			                                            MONTH(dbo.GLEquipmentDecreases.GLEquipmentDecreaseDate) AS ViewEquipmentReportPeriod,
			                                            YEAR(dbo.GLEquipmentDecreases.GLEquipmentDecreaseDate) AS ViewEquipmentReportYear,
			                                            'EquipmentDecreaseItem' AS ViewEquipmentReportTypeCombo
		                                            FROM dbo.GLEquipmentDecreaseItems
		                                            INNER JOIN dbo.GLEquipmentDecreases ON dbo.GLEquipmentDecreaseItems.FK_GLEquipmentDecreaseID = dbo.GLEquipmentDecreases.GLEquipmentDecreaseID
		                                            INNER JOIN dbo.GLEquipmentAllocates ON dbo.GLEquipmentDecreaseItems.FK_GLEquipmentAllocateID = dbo.GLEquipmentAllocates.GLEquipmentAllocateID
		                                            WHERE dbo.GLEquipmentDecreaseItems.AAStatus='Alive'
		                                            AND dbo.GLEquipmentDecreases.AAStatus='Alive'
		                                            AND dbo.GLEquipmentAllocates.AAStatus='Alive'
		
		                                            UNION ALL
		
		                                            SELECT
			                                            dbo.GLEquipmentTransferItems.FK_ICProductID,
			                                            dbo.GLEquipmentTransferItems.FK_FromHRDepartmentID AS FK_HRDepartmentID,
			                                            dbo.GLEquipmentTransfers.GLEquipmentTransferDate AS ViewEquipmentReportDocDate,
			                                            dbo.GLEquipmentTransfers.GLEquipmentTransferNo AS ViewEquipmentReportDocNo,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemQty AS ViewEquipmentReportDocQty,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemLife AS ViewEquipmentReportDocMonth,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemRLife AS ViewEquipmentReportDocRMonth,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemAmt AS ViewEquipmentReportDocAmt,
			                                            dbo.GLEquipmentAllocates.GLEquipmentShipAmt AS ViewEquipmentReportDocShpAmt,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemRAmt AS ViewEquipmentReportDocRAmt,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemDesc AS ViewEquipmentReportDocDesc,
			                                            MONTH(dbo.GLEquipmentTransfers.GLEquipmentTransferDate) AS ViewEquipmentReportPeriod,
			                                            YEAR(dbo.GLEquipmentTransfers.GLEquipmentTransferDate) AS ViewEquipmentReportYear,
			                                            'EquipmentTransferItemFrom' AS ViewEquipmentReportTypeCombo
		                                            FROM dbo.GLEquipmentTransferItems
		                                            INNER JOIN dbo.GLEquipmentTransfers ON dbo.GLEquipmentTransferItems.FK_GLEquipmentTransferID = dbo.GLEquipmentTransfers.GLEquipmentTransferID
		                                            INNER JOIN dbo.GLEquipmentAllocates ON dbo.GLEquipmentTransferItems.FK_GLEquipmentAllocateID = dbo.GLEquipmentAllocates.GLEquipmentAllocateID
		                                            WHERE dbo.GLEquipmentTransferItems.AAStatus='Alive'
		                                            AND dbo.GLEquipmentTransfers.AAStatus='Alive'
		                                            AND dbo.GLEquipmentAllocates.AAStatus='Alive'
		
		                                            UNION ALL
		
		                                            SELECT
			                                            dbo.GLEquipmentTransferItems.FK_ICProductID,
			                                            dbo.GLEquipmentTransferItems.FK_ToHRDepartmentID AS FK_HRDepartmentID,
			                                            dbo.GLEquipmentTransfers.GLEquipmentTransferDate AS ViewEquipmentReportDocDate,
			                                            dbo.GLEquipmentTransfers.GLEquipmentTransferNo AS ViewEquipmentReportDocNo,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemQty AS ViewEquipmentReportDocQty,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemLife AS ViewEquipmentReportDocMonth,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemRLife AS ViewEquipmentReportDocRMonth,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemAmt AS ViewEquipmentReportDocAmt,
			                                            dbo.GLEquipmentAllocates.GLEquipmentShipAmt AS ViewEquipmentReportDocShpAmt,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemRAmt AS ViewEquipmentReportDocRAmt,
			                                            dbo.GLEquipmentTransferItems.GLEquipmentTransferItemDesc AS ViewEquipmentReportDocDesc,
			                                            MONTH(dbo.GLEquipmentTransfers.GLEquipmentTransferDate) AS ViewEquipmentReportPeriod,
			                                            YEAR(dbo.GLEquipmentTransfers.GLEquipmentTransferDate) AS ViewEquipmentReportYear,
			                                            'EquipmentTransferItemTo' AS ViewEquipmentReportTypeCombo
		                                            FROM dbo.GLEquipmentTransferItems
		                                            INNER JOIN dbo.GLEquipmentTransfers ON dbo.GLEquipmentTransferItems.FK_GLEquipmentTransferID = dbo.GLEquipmentTransfers.GLEquipmentTransferID
		                                            INNER JOIN dbo.GLEquipmentAllocates ON dbo.GLEquipmentTransferItems.FK_GLEquipmentAllocateID = dbo.GLEquipmentAllocates.GLEquipmentAllocateID
		                                            WHERE dbo.GLEquipmentTransferItems.AAStatus='Alive'
		                                            AND dbo.GLEquipmentTransfers.AAStatus='Alive'
		                                            AND dbo.GLEquipmentAllocates.AAStatus='Alive'
		
		                                            UNION ALL
		
		                                            SELECT
			                                            dbo.ICShipmentItems.FK_ICProductID,
			                                            dbo.ICShipmentItems.FK_HRDerpamentID AS FK_HRDepartmentID,
			                                            dbo.ICShipments.ICShipmentDate AS ViewEquipmentReportDocDate,
			                                            dbo.ICShipments.ICShipmentNo AS ViewEquipmentReportDocNo,
			                                            dbo.ICShipmentItems.ICShipmentItemQty AS ViewEquipmentReportDocQty,
			                                            ICShipmentItemAllocateLife AS ViewEquipmentReportDocMonth,
			                                            0 AS ViewEquipmentReportDocRMonth,
			                                            dbo.ICShipmentItems.ICShipmentItemAmtTot AS ViewEquipmentReportDocAmt,
			                                            dbo.ICShipmentItems.ICShipmentItemAmtTot AS ViewEquipmentReportDocShpAmt,
			                                            dbo.ICShipmentItems.ICShipmentItemAmtTot AS ViewEquipmentReportDocRAmt,
			                                            CONVERT(NVARCHAR(350),dbo.ICShipmentItems.ICShipmentItemDesc) AS ViewEquipmentReportDocDesc,
			                                            MONTH(dbo.ICShipments.ICShipmentDate) AS ViewEquipmentReportPeriod,
			                                            YEAR(dbo.ICShipments.ICShipmentDate) AS ViewEquipmentReportYear,
			                                            'ShipmentItem' AS ViewEquipmentReportTypeCombo
		                                            FROM dbo.ICShipmentItems
		                                            INNER JOIN dbo.ICshipments ON dbo.ICShipmentItems.FK_ICShipmentID = dbo.ICShipments.ICShipmentID
		                                            WHERE dbo.ICShipments.AAStatus='Alive'
		                                            AND dbo.ICShipmentItems.AAStatus='Alive'
		                                            AND FK_ICProductID IN (SELECT ICProductID FROM dbo.ICProducts WHERE AAStatus='Alive' AND ICProductTypeCombo='Equipment')
				
		                                            UNION ALL
		
		                                            SELECT
			                                            dbo.ICEquipmentIncreaseItems.FK_ICProductID,
			                                            dbo.ICEquipmentIncreaseItems.FK_HRDepartmentID AS FK_HRDepartmentID,
			                                            dbo.ICEquipmentIncreases.ICEquipmentIncreaseDate AS ViewEquipmentReportDocDate,
			                                            dbo.ICEquipmentIncreases.ICEquipmentIncreaseNo AS ViewEquipmentReportDocNo,
			                                            dbo.ICEquipmentIncreaseItems.ICEquipmentIncreaseItemQty AS ViewEquipmentReportDocQty,
			                                            dbo.ICEquipmentIncreaseItems.ICEquipmentIncreaseItemAllocateLife AS ViewEquipmentReportDocMonth,
			                                            0 AS ViewEquipmentReportDocRMonth,
			                                            dbo.ICEquipmentIncreaseItems.ICEquipmentIncreaseItemAmtTot AS ViewEquipmentReportDocAmt,
			                                            dbo.ICEquipmentIncreaseItems.ICEquipmentIncreaseItemAmtTot AS ViewEquipmentReportDocShpAmt,
			                                            dbo.ICEquipmentIncreaseItems.ICEquipmentIncreaseItemAmtTot AS ViewEquipmentReportDocRAmt,
			                                            CONVERT(NVARCHAR(350),dbo.ICEquipmentIncreaseItems.ICEquipmentIncreaseItemDesc) AS ViewEquipmentReportDocDesc,
			                                            MONTH(dbo.ICEquipmentIncreases.ICEquipmentIncreaseDate) AS ViewEquipmentReportPeriod,
			                                            YEAR(dbo.ICEquipmentIncreases.ICEquipmentIncreaseDate) AS ViewEquipmentReportYear,
			                                            'EquipmentIncreaseItem' AS ViewEquipmentReportTypeCombo
		                                            FROM dbo.ICEquipmentIncreaseItems
		                                            INNER JOIN dbo.ICEquipmentIncreases ON dbo.ICEquipmentIncreaseItems.FK_ICEquipmentIncreaseID = dbo.ICEquipmentIncreases.ICEquipmentIncreaseID
		                                            WHERE dbo.ICEquipmentIncreases.AAStatus='Alive'
		                                            AND dbo.ICEquipmentIncreaseItems.AAStatus='Alive'
				
	                                            ) AS TB");

            #endregion

            DeleteAllData();

            DataSet ds = dal.GetDataSet(str);

            if (ds!=null && ds.Tables.Count>0)
            {ViewEquipmentReportsController EquipmentReportCtrl=new ViewEquipmentReportsController();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ViewEquipmentReportsInfo EquipmentReportInfo = (ViewEquipmentReportsInfo)EquipmentReportCtrl.GetObjectFromDataRow(dr);
                    if (EquipmentReportInfo!=null)
                    {
                        EquipmentReportCtrl.CreateObject(EquipmentReportInfo);
                    }
                    
                }
                
            }
        }
	}
	#endregion
}