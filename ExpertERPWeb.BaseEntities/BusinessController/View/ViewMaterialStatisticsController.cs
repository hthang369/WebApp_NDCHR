using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewMaterialStatistics
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewMaterialStatisticsController
	//Created Date:26 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class ViewMaterialStatisticsController:BaseBusinessController
	{
		public ViewMaterialStatisticsController()
		{
			dal= new DALBaseProvider("ViewMaterialStatistics",typeof(ViewMaterialStatisticsInfo));
		}

        #region Lấy tất cả NVL trong module chuyển quy trình mà có thành phẩm --Vinh --25/02/2013
        /*Ghi chú
         * Gồm các table PPProductionOrdrs, ICShipmentItems, ICReceiptItems được INNER JOIN với nhau thông qua mã PPProductionOrdrs có PPProductionOrdrTypeCombo LIKE 'ProductionOrdr'
         * RcpItem.FK_ICProductID = ShipItem.FK_ICProductIDWO && ShipItem.FK_ICProductIDWO<>0
         */

        public DataSet DSNVLcoTPTrongChuyenQuyTrinh(int iProductID, int IProductGroupID, int iProductTypeID, int iPhaseCfgID, int iWOID, int iStockID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"SELECT 
	                                        FK_ICProductID,
	                                        MaterialQty,
	                                        FK_ICProductFinishGoods,
	                                        FinishGoodsQty,
	                                        NormFGQty,
                                            NormLossPct as ViewMaterialStatisticLossPct,
	                                        FK_PPPhaseCfgID AS FK_PPPhaseCfgID,
	                                        FK_ICProductGroupID,
	                                        FK_ICProductTypeID, 
	                                        ICProductLength,
	                                        ICProductHeight,
	                                        ICProductWidth,
	                                        FK_ICStockID,
	                                        FK_PPWOID,
	                                        PPProductionOrdrNo,
	                                        PPProductionOrdrDate,
                                            CONVERT(bit,    CASE 
                                                            WHEN (((FinishGoodsQty * NormFGQty) = MaterialQty) OR FK_ICProductID = FK_ICProductFinishGoods) THEN 'False'
                                                            ELSE 'True'
                                                            END) AS AASelected
                                            ,FK_ICUOMID
                                        FROM
                                            (SELECT 
	                                            ShipItem.FK_ICProductID,
	                                            SUM(ShipItem.ICShipmentItemQty) AS MaterialQty,
	                                            ShipItem.FK_ICProductIDWO AS FK_ICProductFinishGoods,
	                                            SUM(RcpItem.ICReceiptItemQty) AS FinishGoodsQty,
	                                            CASE 
                                                    WHEN (ShipItem.FK_ICProductID = ShipItem.FK_ICProductIDWO) THEN 0
                                                    ELSE ISNULL((SELECT TOP 1 NormRM.PPNormRMQty FROM dbo.PPNormRMs NormRM WHERE NormRM.FK_ICProductID=ShipItem.FK_ICProductID AND NormRM.FK_PPPhaseCfgID = ShipItem.FK_PPPhaseCfgID AND FK_PPNormID IN (SELECT Norm.PPNormID FROM dbo.PPNorms Norm WHERE Norm.AAStatus='Alive' AND Norm.FK_ICProductID=ShipItem.FK_ICProductIDWO) ), 0)
                                                END AS NormFGQty,
                                                CASE 
                                                    WHEN (ShipItem.FK_ICProductID = ShipItem.FK_ICProductIDWO) THEN 0
                                                    ELSE ISNULL((SELECT TOP 1 NormRM.PPNormRMLossPct FROM dbo.PPNormRMs NormRM WHERE NormRM.FK_ICProductID=ShipItem.FK_ICProductID AND NormRM.FK_PPPhaseCfgID = ShipItem.FK_PPPhaseCfgID AND FK_PPNormID IN (SELECT Norm.PPNormID FROM dbo.PPNorms Norm WHERE Norm.AAStatus='Alive' AND Norm.FK_ICProductID=ShipItem.FK_ICProductIDWO) ), 0)
                                                END AS NormLossPct,
	                                            ShipItem.FK_PPPhaseCfgID AS FK_PPPhaseCfgID,
	                                            Product.FK_ICProductGroupID,
	                                            Product.FK_ICProductTypeID, 
	                                            Product.ICProductLength,
	                                            Product.ICProductHeight,
	                                            Product.ICProductWidth,
	                                            ShipItem.FK_ICStockID,
	                                            RcpItem.FK_PPWOID,
	                                            ProductOrd.PPProductionOrdrNo,
	                                            ProductOrd.PPProductionOrdrDate,
                                                Product.FK_ICStkUOMID as FK_ICUOMID
                                            FROM dbo.PPProductionOrdrs  ProductOrd
                                            INNER JOIN  
                                                    (select FK_PPProductionOrdrID,FK_ICProductID,FK_ICStockID,FK_ICProductIDWO,FK_PPWOID,FK_PPPhaseCfgID,AAStatus,SUM(ICShipmentItemQty) as ICShipmentItemQty  from ICShipmentItems
											group by FK_PPProductionOrdrID,FK_ICProductID,FK_ICStockID,FK_ICProductIDWO,FK_PPWOID,FK_PPPhaseCfgID,AAStatus)as  ShipItem 
                                                    ON ProductOrd.PPProductionOrdrID = ShipItem.FK_PPProductionOrdrID
                                            INNER JOIN  
                                                (select FK_PPProductionOrdrID,FK_ICProductID,FK_ICStockID,FK_PPWOID,FK_PPPhaseCfgID,AAStatus,SUM(ICReceiptItemQty) as ICReceiptItemQty  from ICReceiptItems
											group by FK_PPProductionOrdrID,FK_ICProductID,FK_ICStockID,FK_PPWOID,FK_PPPhaseCfgID,AAStatus) as RcpItem  
                                                    ON (RcpItem.FK_PPProductionOrdrID=ProductOrd.PPProductionOrdrID AND RcpItem.FK_ICProductID = ShipItem.FK_ICProductIDWO AND RcpItem.FK_PPWOID=ShipItem.FK_PPWOID)
                                            INNER JOIN dbo.ICProducts Product ON Product.ICProductID=ShipItem.FK_ICProductID
                                            WHERE ProductOrd.AAStatus='Alive' AND ShipItem.AAStatus='Alive' AND RcpItem.AAStatus='Alive' AND Product.AAStatus='Alive'
                                            AND ShipItem.FK_ICProductIDWO<>0
                                            AND ProductOrd.PPProductionOrdrTypeCombo LIKE 'ProductionOrdr'
                                            AND (ShipItem.FK_ICProductID= {0} OR 0={0})
                                            AND (Product.FK_ICProductTypeID = {1} OR 0={1})
                                            AND (Product.FK_ICProductGroupID = {2} OR 0={2})
                                            AND (ShipItem.FK_PPPhaseCfgID = {3} OR 0={3})
                                            AND (ShipItem.FK_ICStockID = {4} OR 0={4})
                                            AND (RcpItem.FK_PPWOID = {5} OR 0={5})
                                            AND (CONVERT(VARCHAR(10), [PPProductionOrdrDate], 112)>= CONVERT(VARCHAR(10), '{6}', 112))
                                            AND (CONVERT(VARCHAR(10), [PPProductionOrdrDate], 112)<= CONVERT(VARCHAR(10), '{7}', 112))
                                            GROUP BY ShipItem.FK_ICProductID, ShipItem.FK_ICProductIDWO, ShipItem.FK_PPPhaseCfgID, Product.FK_ICProductGroupID, Product.FK_ICProductTypeID, Product.ICProductLength, Product.ICProductHeight, Product.ICProductWidth, ShipItem.FK_ICStockID, RcpItem.FK_PPWOID, ProductOrd.PPProductionOrdrNo, ProductOrd.PPProductionOrdrDate
                                            ,Product.FK_ICStkUOMID
                                            ) AS TB
                                        ", iProductID, iProductTypeID, IProductGroupID, iPhaseCfgID, iStockID, iWOID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
          return dal.GetDataSet(str);
        }

        #endregion

        #region Lấy tất cả các thành phẩm trong phiếu chuyển quy trình mà không có bán thành phẩm (NVL). --Vinh --25/02/2013
        /*Ghi chú
         * Gồm các table PPProductionOrdrs, ICReceiptItems, ICProducts được INNER JOIN với nhau và có PPProductionOrdrTypeCombo LIKE 'ProductionOrdr'
         * RcpItem.FK_ICProductID NOT IN (SELECT ShipItem.FK_ICProductIDWO FROM dbo.ICShipmentItems ShipItem WHERE AAStatus='Alive' AND ProductOrd.PPProductionOrdrID = ShipItem.FK_PPProductionOrdrID)
         */

        public DataSet DSThanhPhamKhongCoNVLTrongChuyenQuyTrinh(int iProductID, int IProductGroupID, int iProductTypeID, int iPhaseCfgID, int iWOID, int iStockID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"SELECT 
                                            0 AS FK_ICProductID,
                                            0 AS MaterialQty,
                                            RcpItem.FK_ICProductID AS FK_ICProductFinishGoods,
                                            SUM(RcpItem.ICReceiptItemQty) AS FinishGoodsQty,
                                            RcpItem.FK_PPPhaseCfgID AS FK_PPPhaseCfgID,
                                            Product.FK_ICProductGroupID,
                                            Product.FK_ICProductTypeID, 
                                            Product.ICProductLength,
                                            Product.ICProductHeight,
                                            Product.ICProductWidth,
                                            RcpItem.FK_ICStockID,
                                            RcpItem.FK_PPWOID,
                                            ProductOrd.PPProductionOrdrNo,
                                            ProductOrd.PPProductionOrdrDate,
                                            Product.FK_ICStkUOMID AS FK_ICUOMID
                                        FROM dbo.PPProductionOrdrs  ProductOrd
                                        INNER JOIN dbo.ICReceiptItems RcpItem ON (RcpItem.FK_PPProductionOrdrID=ProductOrd.PPProductionOrdrID AND RcpItem.FK_ICProductID NOT IN (SELECT ShipItem.FK_ICProductIDWO FROM dbo.ICShipmentItems ShipItem WHERE AAStatus='Alive' AND ProductOrd.PPProductionOrdrID = ShipItem.FK_PPProductionOrdrID))
                                        INNER JOIN dbo.ICProducts Product ON Product.ICProductID=RcpItem.FK_ICProductID
                                        WHERE ProductOrd.AAStatus='Alive' AND RcpItem.AAStatus='Alive' AND Product.AAStatus='Alive'
                                        AND RcpItem.FK_ICProductID<>0
                                        AND ProductOrd.PPProductionOrdrTypeCombo LIKE 'ProductionOrdr'
                                        AND (Product.FK_ICProductTypeID = {1} OR 0={1})
                                        AND (Product.FK_ICProductGroupID = {2} OR 0={2})
                                        AND (RcpItem.FK_PPPhaseCfgID = {3} OR 0={3})
                                        AND (RcpItem.FK_ICStockID = {4} OR 0={4})
                                        AND (RcpItem.FK_PPWOID = {5} OR 0={5})
                                        AND (CONVERT(VARCHAR(10), [PPProductionOrdrDate], 112)>= CONVERT(VARCHAR(10), '{6}', 112))
                                        AND (CONVERT(VARCHAR(10), [PPProductionOrdrDate], 112)<= CONVERT(VARCHAR(10), '{7}', 112))
                                        GROUP BY FK_ICProductID, RcpItem.FK_ICProductID, RcpItem.FK_PPPhaseCfgID, Product.FK_ICProductGroupID, Product.FK_ICProductTypeID, Product.ICProductLength, Product.ICProductHeight, Product.ICProductWidth, RcpItem.FK_ICStockID, RcpItem.FK_PPWOID, ProductOrd.PPProductionOrdrNo, ProductOrd.PPProductionOrdrDate
                                        ,Product.FK_ICStkUOMID
                                        ", iProductID, IProductGroupID, iProductTypeID, iPhaseCfgID, iWOID, iStockID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        #endregion

    }
	#endregion
}