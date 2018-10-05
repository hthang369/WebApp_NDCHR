using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
using System.Linq;
namespace ExpertERP.BusinessEntities
{
	#region PPPkgOrderItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPPkgOrderItemsController
	//Created Date:Tuesday, December 18, 2012
	//-----------------------------------------------------------
	
	public class PPPkgOrderItemsController:BaseBusinessController
	{
		public PPPkgOrderItemsController()
		{
			dal= new DALBaseProvider("PPPkgOrderItems",typeof(PPPkgOrderItemsInfo));
		}
        public DataSet GetAllDataInARShpPlan(int iARShpPlanID)
        {
            string strQuery = string.Format(@"select ICProductID,ICProductNo,ICProducts.ICProductName,ICProductPkgCBM,ICProductPrice01
                                            ,ARShpPlanItemPriority,ARShpPlanItemNTSQty,ARShpPlanItemHTSQty 
                                            ,ICInventoryStockQuantity,ICInventoryStockSaleOrderQuantity
                                            ,ICStockNo,ICProductPkgCBM*ICInventoryStockQuantity as CBM
                                            ,ICProductPkgCBM*ICInventoryStockSaleOrderQuantity as CBMAllocate
                                            ,ICInventoryStockQuantity-ICInventoryStockSaleOrderQuantity as QtyAvai
                                            ,ICProductPkgCBM*ICInventoryStockQuantity-ICProductPkgCBM*ICInventoryStockSaleOrderQuantity as CBMAvai
                                            from ARShpPlanItems 
                                            inner join ICInventoryStocks on ARShpPlanItems.FK_ICProductID=ICInventoryStocks.FK_ICProductID
                                            inner join PPPkgStocks on PPPkgStocks.FK_ICStockID=ICInventoryStocks.FK_ICStockID
                                            inner join ICProducts on ICProducts.ICProductID=ARShpPlanItems.FK_ICProductID
                                            inner join ICStocks on PPPkgStocks.FK_ICStockID=ICStocks.ICStockID
                                            where ARShpPlanItems.FK_ARShpPlanID={0}
                                            AND ARShpPlanItems.AAStatus='Alive' AND ICInventoryStocks.AAStatus='Alive'
                                            AND PPPkgStocks.AAStatus='Alive' AND ICProducts.AAStatus='Alive' 
                                            AND ICStocks.AAStatus='Alive'
                                            Order by ARShpPlanItemPriority,ICProductNo", iARShpPlanID);
            return dal.GetDataSet(strQuery);
        }
        public double GetQtyInShipment(int iPkgOrderItemID)
        {
            string strQuery = string.Format(@"SELECT  SUM(ICShipmentItemOrgQty)
                                                FROM    ICShipmentItems
                                                        INNER JOIN dbo.ICShipments ON ( ICShipments.ICShipmentID = ICShipmentItems.FK_ICShipmentID
                                                                                        AND ICShipments.AAStatus = ICShipmentItems.AAStatus
                                                                                        AND ICShipments.AAStatus = 'Alive'
                                                                                        AND FK_PPPkgOrderItemID = {0}
                                                                                      )"
                                    , iPkgOrderItemID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0&&ds.Tables[0].Rows[0][0]!=DBNull.Value)
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
        public double GetTotalRQtyBySOIDAndProduct(int iARSOID, int iProductID)
        {
            string strQuery = string.Format(@"Select SUM(PPPkgOrderItemRQty) from PPPkgOrderItems where AAStatus='Alive'
                                                AND FK_ICProductID={0} AND (FK_ARSOID={1} or {1}=0) AND FK_PPPkgOrderID in (Select PPPkgOrderID from PPPkgOrders where AAStatus='Alive')
                                            ", iProductID,iARSOID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public DataSet GetAllDataBTPInARShpPlan(int iARShpPlanID,int iProductTypeID)
        {
            string strQuery = string.Format(@"select  ICProductID,ICInventoryStockQuantity,ICStockNo,PPNormRMQty,ARShpPlanItems.FK_ICProductID as ICFGProductID
                                                ,ARShpPlanItemPriority,ARShpPlanItemNTSQty,ARShpPlanItemHTSQty
                                            from ARShpPlanItems 
                                            inner join PPNorms on ARShpPlanItems.FK_ICProductID=PPNorms.FK_ICProductID
                                            inner join PPNormRMs on PPNormRMs.FK_PPNormID=PPNorms.PPNormID
                                            inner join ICInventoryStocks on PPNormRMs.FK_ICProductID=ICInventoryStocks.FK_ICProductID
                                            inner join PPPkgStocks on PPPkgStocks.FK_ICStockID=ICInventoryStocks.FK_ICStockID
                                            inner join ICStocks on PPPkgStocks.FK_ICStockID=ICStocks.ICStockID
                                            inner join ICProducts on PPNormRMs.FK_ICProductID=ICProducts.ICProductID
                                            where ARShpPlanItems.FK_ARShpPlanID={0}
                                            AND ARShpPlanItems.AAStatus='Alive' AND ICInventoryStocks.AAStatus='Alive' 
                                            AND PPPkgStocks.AAStatus='Alive' AND PPNorms.AAStatus='Alive' 
                                            AND ICStocks.AAStatus='Alive' AND ICProducts.AAStatus='Alive'
                                            AND PPNormRMQty>0
                                            AND ICProducts.FK_ICProductTypeID={1}
                                            AND ICInventoryStockQuantity>0
                                            Order By ICProductID,ICStockNo", iARShpPlanID, iProductTypeID);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllFGExistBTPInInv(int iARShpPlanID, int iProductTypeID)
        {
            string strQuery = string.Format(@"select  ARShpPlanItems.FK_ICProductID as ICProductID,ARShpPlanItemPriority,ARShpPlanItemNTSQty,ARShpPlanItemHTSQty
                                            from ARShpPlanItems 
                                            inner join PPNorms on ARShpPlanItems.FK_ICProductID=PPNorms.FK_ICProductID
                                            inner join PPNormRMs on PPNormRMs.FK_PPNormID=PPNorms.PPNormID
                                            inner join ICInventoryStocks on PPNormRMs.FK_ICProductID=ICInventoryStocks.FK_ICProductID
                                            inner join PPPkgStocks on PPPkgStocks.FK_ICStockID=ICInventoryStocks.FK_ICStockID
                                            inner join ICStocks on PPPkgStocks.FK_ICStockID=ICStocks.ICStockID
                                            inner join ICProducts on PPNormRMs.FK_ICProductID=ICProducts.ICProductID
                                            where ARShpPlanItems.FK_ARShpPlanID={0}
                                            AND ARShpPlanItems.AAStatus='Alive' AND ICInventoryStocks.AAStatus='Alive' 
                                            AND PPPkgStocks.AAStatus='Alive' AND PPNorms.AAStatus='Alive' 
                                            AND ICStocks.AAStatus='Alive' AND ICProducts.AAStatus='Alive'
                                            AND PPNormRMQty>0
                                            AND ICProducts.FK_ICProductTypeID={1}
                                            AND ICInventoryStockQuantity>0
                                            Order By ARShpPlanItemPriority", iARShpPlanID, iProductTypeID);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetDataViewByICProduct(int iICProductID)
        {
            string strQuery = string.Format(@"SELECT  
                                                    ISNULL(ICInventoryStockQuantity, 0) AS ICInventoryStockQuantity ,
                                                    ISNULL(ICInventoryStockSaleOrderQuantity, 0) AS ICInventoryStockSaleOrderQuantity ,
                                                    ICStockNo ,
                                                    ICProductPkgCBM * ISNULL(ICInventoryStockQuantity, 0) AS CBM ,
                                                    ICProductPkgCBM * ISNULL(ICInventoryStockSaleOrderQuantity, 0) AS CBMAllocate ,
                                                    (ISNULL(ICInventoryStockQuantity, 0) - ISNULL(ICInventoryStockSaleOrderQuantity, 0)) AS QtyAvai ,
                                                    (ICProductPkgCBM * ISNULL(ICInventoryStockQuantity, 0) - ICProductPkgCBM * ISNULL(ICInventoryStockSaleOrderQuantity, 0)) AS CBMAvai
                                            FROM    dbo.ICProducts
		                                            INNER JOIN ICInventoryStocks ON (ICInventoryStocks.FK_ICProductID = ICProducts.ICProductID
		                                            AND ICInventoryStocks.AAStatus = ICProducts.AAStatus 
		                                            AND ICProducts.AAStatus = 'Alive'
		                                            AND ICProducts.ICProductID = {0})
		                                            INNER JOIN dbo.ICStocks ON (ICStocks.ICStockID = ICInventoryStocks.FK_ICStockID
		                                            AND ICStocks.AAStatus = ICInventoryStocks.AAStatus)
		                                            INNER JOIN PPPkgStocks ON (PPPkgStocks.FK_ICStockID = ICStocks.ICStockID
		                                            AND PPPkgStocks.AAStatus = ICStocks.AAStatus)
                                            ORDER BY ICProductID "
                                        , iICProductID);
            return dal.GetDataSet(strQuery);
        }

        /// <summary>
        /// Viet Nguyen 2013.01.26
        /// Get SUM ActQty By Product And SO
        /// </summary>
        public double GetSumQtyByProductAndSO(int iProductID, int iARSOID)
        {
            String strQuery = String.Format(@"SELECT SUM(PPPkgOrderItemActQty) FROM PPPkgOrderItems WHERE AAStatus='Alive' AND FK_ICProductID = {0} AND FK_ARSOID = {1}
                                                            AND FK_PPPkgOrderID IN (SELECT PPPkgOrderID FROM PPPkgOrders WHERE AAStatus = 'Alive' 
                                                                            )"
                                                , iProductID, iARSOID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }

        public DataSet GetAllFGExistBTPInInv(int iARShpPlanID, int iARSOID, int iProductTypeID)
        {
            string strQuery = string.Format(@"select  ARShpPlanItems.FK_ICProductID as ICProductID,ARShpPlanItemPriority,ARShpPlanItemNTSQty,ARShpPlanItemHTSQty
                                            from ARShpPlanItems 
                                            inner join PPNorms on ARShpPlanItems.FK_ICProductID=PPNorms.FK_ICProductID
                                            inner join PPNormRMs on PPNormRMs.FK_PPNormID=PPNorms.PPNormID
                                            inner join ICInventoryStocks on PPNormRMs.FK_ICProductID=ICInventoryStocks.FK_ICProductID
                                            inner join PPPkgStocks on PPPkgStocks.FK_ICStockID=ICInventoryStocks.FK_ICStockID
                                            inner join ICStocks on PPPkgStocks.FK_ICStockID=ICStocks.ICStockID
                                            inner join ICProducts on PPNormRMs.FK_ICProductID=ICProducts.ICProductID
                                            inner join ARSOs on ARShpPlanItems.FK_ARSOID=ARSOs.ARSOID
                                            where ARShpPlanItems.FK_ARShpPlanID={0} AND (ARShpPlanItems.FK_ARSOID={1} or {1}=0)
                                            AND ARShpPlanItems.AAStatus='Alive' AND ICInventoryStocks.AAStatus='Alive' 
                                            AND PPPkgStocks.AAStatus='Alive' AND PPNorms.AAStatus='Alive' 
                                            AND ICStocks.AAStatus='Alive' AND ICProducts.AAStatus='Alive'
                                            AND PPNormRMQty>0
                                            AND ICProducts.FK_ICProductTypeID={1}
                                            AND ICInventoryStockQuantity>0
                                            Order By ARShpPlanItemPriority", iARShpPlanID, iProductTypeID);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllDataExistRQtyByProduct(int iProductID)
        {
            string strQuery = string.Format(@"Select * from PPPkgOrderItems where AAStatus='Alive' AND PPPkgOrderItemRQty<>0 AND FK_ICProductID={0} AND
                                                    FK_PPPkgOrderID in (select PPPkgOrderID from PPPkgOrders where AAStatus='Alive')", iProductID);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllObjectByARSOItemID(int iARSOItemID)
        {
            String strQuery = String.Format(@" Select *
                                               From PPPkgOrderItems
                                               Where AAStatus = 'Alive' AND FK_ARSOItemID = {0}   
                                            ", iARSOItemID);
            return GetDataSet(strQuery);
        }
        public bool CheckAllObjectToShipmentByID(int iObjectID, out string strShpNo)
        {
            string strQuery = string.Format(@"SELECT a.*,c.ICShipmentNo FROM PPPkgOrderItems a 
                                                JOIN ICShipmentItems b ON a.PPPkgOrderItemID = b.FK_PPPkgOrderItemID 
                                                    AND a.AAStatus = 'Alive' AND b.AAStatus = 'Alive'
                                                JOIN ICShipments c ON b.FK_ICShipmentID = c.ICShipmentID 
                                                    AND c.AAStatus = 'Alive' WHERE FK_PPPkgOrderID = {0}", iObjectID);
            DataSet ds = GetDataSet(strQuery);
            strShpNo = string.Empty;
            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                strShpNo = string.Join(", ", ds.Tables[0].Select().Select(x => Convert.ToString(x["ICShipmentNo"])).ToArray());
                return true;
            }
            return false;
        }
	}
	#endregion
}