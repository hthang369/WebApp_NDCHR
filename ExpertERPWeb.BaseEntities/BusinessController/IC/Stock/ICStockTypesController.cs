﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICStockTypes
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICStockTypesController
	//Created Date:Wednesday, September 26, 2012
	//-----------------------------------------------------------
	
	public class ICStockTypesController:BaseBusinessController
	{
		public ICStockTypesController()
		{
			dal= new DALBaseProvider("ICStockTypes",typeof(ICStockTypesInfo));
		}

        #region Get CBM By Stock And From Date To Date --Vinh --21/02/2013 --Tính tổng các CBM xuất ra của 1 kho từ ngày đến ngày của BTP
        
        public double GetCBMByStockANDFromToDate(int iStockID, DateTime dtFrom, DateTime dtTo, int iProductTypeID)
        {
            String str = String.Format(@"   SELECT SUM(CBM) AS CBM
                                            FROM
                                            (
	                                            /*Xuất nhập kho*/
	                                            SELECT ShpItem.ICShipmentItemQty * ISNULL((SELECT TOP 1 Product.ICProductMaterialCBM FROM dbo.ICProducts Product WHERE Product.AAStatus='Alive' AND Product.FK_ICProductTypeID = {3} AND ShpItem.FK_ICProductID = Product.ICProductID ), 0) AS CBM
	                                            FROM dbo.ICShipmentItems ShpItem
	                                            WHERE ShpItem.AAStatus='Alive'
	                                            AND ShpItem.FK_ICStockID={0}
	                                            AND 
	                                            (
		                                            ShpItem.FK_ICShipmentID IN (SELECT Shp.ICShipmentID FROM dbo.ICShipments Shp WHERE Shp.AAStatus='Alive' AND CONVERT(VARCHAR(10),Shp.ICShipmentDate,112) >= CONVERT(VARCHAR(10),'{1}',112) AND CONVERT(VARCHAR(10),Shp.ICShipmentDate,112) <= CONVERT(VARCHAR(10),'{2}',112) )
		                                            OR
		                                            ShpItem.FK_PPProductionOrdrID IN (SELECT ProductionOrd.PPProductionOrdrID FROM dbo.PPProductionOrdrs ProductionOrd WHERE ProductionOrd.AAStatus='Alive' AND CONVERT(VARCHAR(10),ProductionOrd.PPProductionOrdrDate,112) >= CONVERT(VARCHAR(10),'{1}',112) AND CONVERT(VARCHAR(10),ProductionOrd.PPProductionOrdrDate,112) <= CONVERT(VARCHAR(10),'{2}',112) )
	                                            )
	
	                                            UNION ALL
	
	                                            /*Chuyển đi*/
	                                            SELECT TranItem.ICTransferItemQty * ISNULL((SELECT TOP 1 Product.ICProductMaterialCBM FROM dbo.ICProducts Product WHERE Product.AAStatus='Alive' AND Product.FK_ICProductTypeID = {3} AND TranItem.FK_ICProductID = Product.ICProductID), 0) AS CBM
	                                            FROM dbo.ICTransferItems TranItem
	                                            WHERE AAStatus='Alive'
	                                            AND TranItem.FK_ICFromStockID={0}
	                                            AND TranItem.FK_ICTransferID IN (SELECT Tranf.ICTransferID FROM dbo.ICTransfers Tranf WHERE Tranf.AAStatus='Alive' AND CONVERT(VARCHAR(10),Tranf.ICTransferDate,112) >= CONVERT(VARCHAR(10),'{1}',112) AND CONVERT(VARCHAR(10),Tranf.ICTransferDate,112) <= CONVERT(VARCHAR(10),'{2}',112) )
	
                                            ) AS TB", iStockID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"), iProductTypeID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return double.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return 0;
        }

        #endregion

        #region Get USD By Stock And From Date To Date --Vinh --21/02/2013 --Tính tổng tiền USD các đợt xuất ra của 1 kho từ ngày đến ngày

        public double GetAmtByStockANDFromToDate(int iStockID, DateTime dtFrom, DateTime dtTo, int iProductTypeID)
        {
            String str = String.Format(@"   SELECT SUM(USD) AS USD
                                            FROM
                                            (
	                                            /*Xuất nhập kho*/
	                                            SELECT ShpItem.ICShipmentItemQty * ISNULL((SELECT TOP 1 Product.ICProductPrice01 FROM dbo.ICProducts Product WHERE Product.AAStatus='Alive' AND Product.FK_ICProductTypeID = {3} AND ShpItem.FK_ICProductID = Product.ICProductID), 0) AS USD
	                                            FROM dbo.ICShipmentItems ShpItem
	                                            WHERE ShpItem.AAStatus='Alive'
	                                            AND ShpItem.FK_ICStockID={0}
	                                            AND 
	                                            (
		                                            ShpItem.FK_ICShipmentID IN (SELECT Shp.ICShipmentID FROM dbo.ICShipments Shp WHERE Shp.AAStatus='Alive' AND CONVERT(VARCHAR(10),Shp.ICShipmentDate,112) >= CONVERT(VARCHAR(10),'{1}',112) AND CONVERT(VARCHAR(10),Shp.ICShipmentDate,112) <= CONVERT(VARCHAR(10),'{2}',112) )
		                                            OR
		                                            ShpItem.FK_PPProductionOrdrID IN (SELECT ProductionOrd.PPProductionOrdrID FROM dbo.PPProductionOrdrs ProductionOrd WHERE ProductionOrd.AAStatus='Alive' AND CONVERT(VARCHAR(10),ProductionOrd.PPProductionOrdrDate,112) >= CONVERT(VARCHAR(10),'{1}',112) AND CONVERT(VARCHAR(10),ProductionOrd.PPProductionOrdrDate,112) <= CONVERT(VARCHAR(10),'{2}',112) )
	                                            )
	
	                                            UNION ALL
	
	                                            /*Chuyển đi*/
	                                            SELECT TranItem.ICTransferItemQty * ISNULL((SELECT TOP 1 Product.ICProductPrice01 FROM dbo.ICProducts Product WHERE Product.AAStatus='Alive' AND Product.FK_ICProductTypeID = {3} AND TranItem.FK_ICProductID = Product.ICProductID), 0) AS USD
	                                            FROM dbo.ICTransferItems TranItem
	                                            WHERE AAStatus='Alive'
	                                            AND TranItem.FK_ICFromStockID={0}
	                                            AND TranItem.FK_ICTransferID IN (SELECT Tranf.ICTransferID FROM dbo.ICTransfers Tranf WHERE Tranf.AAStatus='Alive' AND CONVERT(VARCHAR(10),Tranf.ICTransferDate,112) >= CONVERT(VARCHAR(10),'{1}',112) AND CONVERT(VARCHAR(10),Tranf.ICTransferDate,112) <= CONVERT(VARCHAR(10),'{2}',112) )
	
                                            ) AS TB", iStockID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"), iProductTypeID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return double.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            return 0;
        }

        #endregion
    }
	#endregion
}