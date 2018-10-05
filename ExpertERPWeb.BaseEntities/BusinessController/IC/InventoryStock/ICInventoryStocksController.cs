using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region ICInventoryStocks
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICInventoryStocksController
	//Created Date:Monday, March 24, 2008
	//-----------------------------------------------------------
	
	public class ICInventoryStocksController:BaseBusinessController
	{

        private readonly string spGetInventoryStockByProductAndStock =
                                "ICInventoryStocks_SelectByProductAndStock";
        //hieu nguyen modified,store name in database not exists by
        //private readonly string spGetTotalStockQuantityByProduct =
        //                        "ICInventoryStocks_SelectTotalStockQuantityByProduct";
        private readonly string spGetTotalStockQuantityByProduct =
                              "ICInventoryStocks_SelectTotalStockQuantityProduct";

        private readonly string spGetTotalStockProposalQuantityByProduct =
                                "ICInventoryStocks_SelectTotalStockProposalQuantityByProduct";

        private readonly string spGetTotalStockSaleOrderQuantityByProduct =
                                "ICInventoryStocks_SelectTotalStockSaleOrderQuantityByProduct";

        private readonly string spGetTotalStockPurchaseOrderQuantityByProduct =
                                "ICInventoryStocks_SelectTotalStockPurchaseOrderQuantityByProduct";

		public ICInventoryStocksController()
		{
			dal= new DALBaseProvider("ICInventoryStocks",typeof(ICInventoryStocksInfo));
		}

        public ICInventoryStocksInfo GetInventoryStockByProductAndStock(int iICProductID, int iICStockID)
        {
            return (ICInventoryStocksInfo)dal.GetDataObject(spGetInventoryStockByProductAndStock, iICProductID, iICStockID);
        }

        public double GetTotalStockQuantityByProduct(int iICProductID)
        {
            double dbTotalStockQuantity = 0;
            try
            {
                DataSet ds = dal.GetDataSet(spGetTotalStockQuantityByProduct, iICProductID);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dbTotalStockQuantity += Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                    }
                }
                return dbTotalStockQuantity;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double GetTotalStockProposalQuantityByProduct(int iICProductID)
        {
            double dbTotalProposalQuantity = 0;
            try
            {
                DataSet ds = dal.GetDataSet(spGetTotalStockProposalQuantityByProduct, iICProductID);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dbTotalProposalQuantity += Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                    }
                }
                return dbTotalProposalQuantity;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double GetTotalStockSaleOrderQuantityByProduct(int iICProductID)
        {
            double dbTotalSaleOrderQuantity = 0;
            try
            {
                DataSet ds = dal.GetDataSet(spGetTotalStockSaleOrderQuantityByProduct, iICProductID);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dbTotalSaleOrderQuantity += Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                    }
                }
                return dbTotalSaleOrderQuantity;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double GetTotalStockPurchaseOrderQuantityByProduct(int iICProductID)
        {
            double dbTotalPurchaseOrderQuantity = 0;
            try
            {
                DataSet ds = dal.GetDataSet(spGetTotalStockPurchaseOrderQuantityByProduct, iICProductID);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        dbTotalPurchaseOrderQuantity += Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                    }
                }
                return dbTotalPurchaseOrderQuantity;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double GetStockQuantityByProductAndStock(int iICProductID, int iICStockID)
        {
            double dbStockQuantity = 0;
            ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
            if (objICInventoryStockInfo != null)
                dbStockQuantity = objICInventoryStockInfo.ICInventoryStockQuantity;
            
            return dbStockQuantity;
        }

        public double GetStockProposalQuantityByProductAndStock(int iICProductID, int iICStockID)
        {
            double dbStockProposalQuantity = 0;
            ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
            if (objICInventoryStockInfo != null)
                dbStockProposalQuantity = objICInventoryStockInfo.ICInventoryStockProposalQuantity;

            return dbStockProposalQuantity;
        }

        public double GetStockSaleOrderQuantityByProductAndStock(int iICProductID, int iICStockID)
        {
            double dbStockSaleOrderQuantity = 0;
            ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
            if (objICInventoryStockInfo != null)
                dbStockSaleOrderQuantity = objICInventoryStockInfo.ICInventoryStockSaleOrderQuantity;

            return dbStockSaleOrderQuantity;
        }

        public double GetStockPurchaseOrderQuantityByProductAndStock(int iICProductID, int iICStockID)
        {
            double dbStockPurchaseOrderQuantity = 0;
            ICInventoryStocksInfo objICInventoryStockInfo = GetInventoryStockByProductAndStock(iICProductID, iICStockID);
            if (objICInventoryStockInfo != null)
                dbStockPurchaseOrderQuantity = objICInventoryStockInfo.ICInventoryStockPurchaseOrderQuantity;

            return dbStockPurchaseOrderQuantity;
        }

        //Thanh Trung adds, 23/07/2008
        public List<ICInventoryStocksInfo> GetInventoryStocksFromBranch(BRBranchsInfo objBranchsInfo)
        {
            List<ICInventoryStocksInfo> lstICInventoryStocksInfo = new List<ICInventoryStocksInfo>();

            DataSet dsStocks = new ICStocksController().GetAllDataByForeignColumn("FK_BRBranchID", objBranchsInfo.BRBranchID);
            if (dsStocks.Tables.Count > 0)
            {
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                //String strICStocksPrimaryColumn = new GMCDbUtil().GetTablePrimaryColumn(GMCUtil.GetTableNameFromBusinessObjectType(typeof(ICStocksInfo)));
                String strICStocksPrimaryColumn =  GMCDbUtil.GetTablePrimaryColumn(GMCUtil.GetTableNameFromBusinessObjectType(typeof(ICStocksInfo)));

                foreach (DataRow rowStock in dsStocks.Tables[0].Rows)
                {
                    DataSet dsInventoryStocks = objInventoryStocksController.GetAllDataByForeignColumn("FK_ICStockID", rowStock[strICStocksPrimaryColumn]);
                    if (dsInventoryStocks.Tables.Count > 0)
                    {
                        foreach (DataRow rowInventoryStock in dsInventoryStocks.Tables[0].Rows)
                        {
                            ICInventoryStocksInfo objInventoryStocksInfo = (ICInventoryStocksInfo)objInventoryStocksController.GetObjectFromDataRow(rowInventoryStock);
                            if (objInventoryStocksInfo != null)
                                lstICInventoryStocksInfo.Add(objInventoryStocksInfo);
                        }
                    }
                }
            }

            return lstICInventoryStocksInfo;
        }
        //Hoang.nguyen Added, 091125
        public DataSet GetDataSetICInventoryStocks_SelectAllByBRBranchIDForFK_ICStocks(int iBRBranchID)
        {
             return dal.GetDataSet("ICInventoryStocks_SelectAllByBRBranchIDForFK_ICStocks", iBRBranchID);
        }

        public DataSet GetDataSetICInventoryStocks_SelectAllByBRBranchIDForFK_ICStocks1(int iBRBranchID)
        {
            String strQery = String.Format("SELECT * FROM ICInventoryStocks WHERE AAStatus = 'Alive' AND FK_ICStockID in (SELECT ICStockID FROM ICStocks WHERE AAStatus = 'Alive' AND FK_BRBranchID = '{0}')", iBRBranchID);
            return dal.GetDataSet(strQery);
        }
        #region--hieu nguyen created for Inventory statistics--
        public DataSet GetInventoryStockByBranch(int iBranchID)
        {
            String strQuery = String.Format("SELECT * FROM [dbo].[ICInventoryStocks] WHERE [FK_ICStockID] IN (SELECT [ICStockID]	FROM [dbo].[ICStocks] WHERE  [FK_BRBranchID] = {0} AND [AAStatus] = '{1}' ) AND [AAStatus]='{2}'", iBranchID, BusinessObject.DefaultAAStatus);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetInventoryByProduct(int iProductID)
        {
            String strQuery = String.Format("SELECT * FROM [dbo].[ICInventoryStocks] WHERE [FK_ICProductID] ={0} AND [AAStatus]='{1}'", iProductID, BusinessObject.DefaultAAStatus);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetInventoryStockByDelete()
        {
            String strQuery = String.Format("Select * from ICIventoryStocks where AAStatus='Delete'");
            return dal.GetDataSet(strQuery);
        }
        public ICInventoryStocksInfo GetICInventorySotckByStockAndProduct(int iStockID, int iProductID)
        {
            string strQuery = String.Format("Select * from ICInventoryStocks where AAStatus='Alive' and FK_ICStockID={0} and FK_ICProductID={1} ", iStockID, iProductID);
            DataSet ds = dal.GetDataSet(strQuery);
            
            if (ds != null&&ds.Tables[0].Rows.Count>0)
            {
               return (ICInventoryStocksInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);    
            }
            return null;
        }

        public DataSet GetAllObjectAliveAndDelete()
        {
            string strQuery = string.Format("Select * from ICInventoryStocks");
            return dal.GetDataSet(strQuery);
        }

        public object GetObject_ByStockID_AndProductID(int iICStockID, int iICProductID)
        {
            String strQuery = String.Format("SELECT * FROM ICInventoryStocks WHERE FK_ICStockID = {0} AND FK_ICProductID = {1} AND AAStatus = 'Alive'", iICStockID, iICProductID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }        
        #endregion

        public DataSet GetAllObjectByProductAndQty(int iICProductID)
        {
            string str = string.Format(@"Select * from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                            (ICInventoryStockQuantity<>0 OR ICInventoryStockProposalQuantity<>0 OR ICInventoryStockSaleOrderQuantity<>0) ",iICProductID);
            return dal.GetDataSet(str);
        }

        public DataSet GetAllObjectByProductAllternative(int iICProductID)
        {
            string str = string.Format(@"SELECT * FROM dbo.ICInventoryStocks WHERE AAStatus='Alive' 
		                                AND FK_ICProductID IN 
			                        (SELECT FK_ICProductAlternativeChildID FROM dbo.ICProductAlternatives WHERE AAStatus='Alive' AND FK_ICProductAlternativeParentID={0} )
                                        AND FK_ICStockID IN 
                                        (SELECT ICStockID FROM dbo.ICStocks WHERE AAStatus='Alive')"
                                        , iICProductID);
            return dal.GetDataSet(str);
        }
        
        //Add QuocTrung 11/05/2012
        public DataSet GetAllObjectByProductSubplement(int iICProductID)
        {
            string str = string.Format(@"SELECT * FROM dbo.ICInventoryStocks WHERE AAStatus='Alive' 
		                                AND FK_ICProductID IN 
			                        (SELECT FK_ICProductSubplementChildID FROM dbo.ICProductSubplements WHERE AAStatus='Alive' AND FK_ICProductSubplementParentID={0} )
                                        AND FK_ICStockID IN 
                                        (SELECT ICStockID FROM dbo.ICStocks WHERE AAStatus='Alive')"
                                        , iICProductID);
            return dal.GetDataSet(str);
        }
        public DataSet GetAllObjectByProduct(int iICProductID)
        {
            string str = string.Format(@"Select * from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                                    FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive')
                                                    AND ICInventoryStockQuantity>0
                                            ", iICProductID);
            return dal.GetDataSet(str);
        }

		public double GetTotalStockQtyByProductIDAndPhaseCfg(int iProductID, int iPPPhaseCfgID)
        {
            string strQuery = string.Format(@"Select SUM(ICInventoryStockQuantity) from ICInventoryStocks where AAStatus='Alive' AND
                                                FK_ICProductID={0} and FK_ICStockID in (Select FK_ICStockID From PPPhaseCfgs where AAStatus='Alive' AND PPPhaseCfgID={1})", iProductID, iPPPhaseCfgID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0&&ds.Tables[0].Rows[0][0]!=DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }

        public double GetTotalStockQuantityByProductAndStockType(int iICProductID,string strStockType)
        {
            double dbTotalStockQuantity = 0;
            try
            {
                string strQuery = string.Format(@"Select SUM(ICInventoryStockQuantity) from ICInventoryStocks where 
                                                       AAStatus='Alive' AND FK_ICProductID={0} AND
                                                       FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive' 
                                                            AND FK_ICStockTypeID in (Select ICStockTypeID from ICStockTypes where AAStatus='Alive' And ICStockTypeNo='{1}'))"
                                            , iICProductID, strStockType);
                DataSet ds = dal.GetDataSet(strQuery);
                if (ds!=null&& ds.Tables.Count > 0&&ds.Tables[0].Rows.Count>0&&ds.Tables[0].Rows[0][0]!=DBNull.Value)
                {
                        dbTotalStockQuantity = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
            }
            catch (Exception)
            {
            }
            return dbTotalStockQuantity;
        }

        public double GetStockQtyByProduct(int iICProductID)
        {
            string str = string.Format(@"Select SUM(ICInventoryStockQuantity) from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                                    FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive')
                                            ", iICProductID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }

        /// <summary>
        /// Get Stock Quantity By Query in Doc
        /// </summary>
        public double GetStockQuantityByProductAndStockType(int iICProductID, string strStockType)
        {
            double dbTotalStockQuantity = 0;
            try
            {
                #region Query

                string strQuery = string.Format(@"SELECT SUM(Qty) as Qty
                            
                            FROM
                             (
                        --Receipt
                            select SUM(ICReceiptItemQty) as Qty
                            from ICReceiptItems 
                            inner join ICReceipts on ICReceipts.ICReceiptID=ICReceiptItems.FK_ICReceiptID
							inner join ICStocks on ICStocks.ICStockID=ICReceiptItems.FK_ICStockID
							inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICReceiptItems.AAStatus='Alive' 
                            AND ICReceipts.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
							AND ICStockTypes.AAStatus='Alive'
							AND ICReceiptItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
                           
               Union All    
       
       --Receipt in ProductionOrdr                     
     select SUM(ICReceiptItemQty) as Qty
                            from ICReceiptItems 
                            inner join PPProductionOrdrs on PPProductionOrdrs.PPProductionOrdrID=ICReceiptItems.FK_PPProductionOrdrID 
                            inner join ICStocks on ICStocks.ICStockID=ICReceiptItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICReceiptItems.AAStatus='Alive' 
                             AND PPProductionOrdrs.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
							AND ICStockTypes.AAStatus='Alive'
							AND ICReceiptItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
       Union All
       
 --Transfer In
       select SUM(ICTransferItemQty) As Qty
                            from ICTransferItems
                            inner join ICTransfers on ICTransfers.ICTransferID=ICTransferItems.FK_ICTransferID inner join
                            ICStocks on ICStocks.ICStockID=ICTransferItems.FK_ICToStockID
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICTransferItems.AAStatus='Alive'                        
                            AND ICTransfers.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive'                           
                            AND ICStockTypes.AAStatus='Alive'
							AND ICTransferItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
        Union All
        
-- Adj IncQty
				select SUM(ICAdjInvItemQty) AS Qty
                            from ICAdjInvItems 
							inner join ICAdjInvs on ICAdjInvs.ICAdjInvID=ICAdjInvItems.FK_ICAdjInvID 
                            inner join ICStocks on ICStocks.ICStockID=ICAdjInvItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICAdjInvItems.AAStatus='Alive' 
                            AND ICAdjInvs.AAStatus='Alive'
                            AND ICStocks.AAStatus='Alive' 
                            AND ICStockTypes.AAStatus='Alive'
                            AND ICAdjInvItemTypeCombo='IncQty'
							AND ICAdjInvItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
         Union All
-- Shipment
					select SUM(-1*ICShipmentItemQty) as Qty
                            from ICShipmentItems 
                            inner join ICShipments on ICShipments.ICShipmentID=ICShipmentItems.FK_ICShipmentID inner join
                            ICStocks on ICStocks.ICStockID=ICShipmentItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICShipmentItems.AAStatus='Alive' 
                            AND ICShipments.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                            AND ICStockTypes.AAStatus='Alive'
                            AND ICShipmentItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
                            
       Union All 
--Shipment in Producion
       select SUM(-1*ICShipmentItemQty) as Qty
                            from ICShipmentItems 
                            inner join PPProductionOrdrs on PPProductionOrdrs.PPProductionOrdrID=ICShipmentItems.FK_PPProductionOrdrID inner join
                            ICStocks on ICStocks.ICStockID=ICShipmentItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICShipmentItems.AAStatus='Alive' 
                           AND PPProductionOrdrs.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                            AND ICStockTypes.AAStatus='Alive'
                            AND ICShipmentItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
  Union All
-- Transfer Out
			select SUM(-1*ICTransferItemQty) As Qty
                            from ICTransferItems 
                            inner join ICTransfers on ICTransfers.ICTransferID=ICTransferItems.FK_ICTransferID inner join
                            ICStocks on ICStocks.ICStockID=ICTransferItems.FK_ICFromStockID 
							inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICTransferItems.AAStatus='Alive' 
                            AND ICTransfers.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                            AND ICStockTypes.AAStatus='Alive'
                            AND ICTransferItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
     Union All
-- Adj Dec    
     select SUM(-1*ICAdjInvItemQty) as Qty
                            from ICAdjInvItems 
							inner join ICAdjInvs on ICAdjInvs.ICAdjInvID=ICAdjInvItems.FK_ICAdjInvID inner join
                            ICStocks on ICStocks.ICStockID=ICAdjInvItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICAdjInvItems.AAStatus='Alive' 
                           AND ICAdjInvs.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                           AND ICStockTypes.AAStatus='Alive'
                           AND ICAdjInvItemTypeCombo='DecQty'
                           AND ICAdjInvItems.FK_ICProductID={0}
							AND ICStockTypes.ICStockTypeNo='{1}'
                          ) 
                          as ABC
                        ", iICProductID, strStockType);
                #endregion

                DataSet ds = dal.GetDataSet(strQuery);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    dbTotalStockQuantity = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
            }
            catch (Exception)
            {
            }
            return dbTotalStockQuantity;
        }

        /// <summary>
        /// Get Stock Quantity By Query in Doc
        /// </summary>
        public double GetStockQuantityByProductAndStockType(int iICProductID)
        {
            double dbTotalStockQuantity = 0;
            try
            {
                #region Query

                string strQuery = string.Format(@"SELECT SUM(Qty) as Qty
                            
                            FROM
                             (
                        --Receipt
                            select SUM(ICReceiptItemQty) as Qty
                            from ICReceiptItems 
                            inner join ICReceipts on ICReceipts.ICReceiptID=ICReceiptItems.FK_ICReceiptID
							inner join ICStocks on ICStocks.ICStockID=ICReceiptItems.FK_ICStockID
                            where 
                            ICReceiptItems.AAStatus='Alive' 
                            AND ICReceipts.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
							AND ICReceiptItems.FK_ICProductID={0}
                           
               Union All    
       
       --Receipt in ProductionOrdr                     
     select SUM(ICReceiptItemQty) as Qty
                            from ICReceiptItems 
                            inner join PPProductionOrdrs on PPProductionOrdrs.PPProductionOrdrID=ICReceiptItems.FK_PPProductionOrdrID 
                            inner join ICStocks on ICStocks.ICStockID=ICReceiptItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICReceiptItems.AAStatus='Alive' 
                             AND PPProductionOrdrs.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
							AND ICReceiptItems.FK_ICProductID={0}
       Union All
       
 --Transfer In
       select SUM(ICTransferItemQty) As Qty
                            from ICTransferItems
                            inner join ICTransfers on ICTransfers.ICTransferID=ICTransferItems.FK_ICTransferID inner join
                            ICStocks on ICStocks.ICStockID=ICTransferItems.FK_ICToStockID
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICTransferItems.AAStatus='Alive'                        
                            AND ICTransfers.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive'                           
							AND ICTransferItems.FK_ICProductID={0}
        Union All
        
-- Adj IncQty
				select SUM(ICAdjInvItemQty) AS Qty
                            from ICAdjInvItems 
							inner join ICAdjInvs on ICAdjInvs.ICAdjInvID=ICAdjInvItems.FK_ICAdjInvID 
                            inner join ICStocks on ICStocks.ICStockID=ICAdjInvItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICAdjInvItems.AAStatus='Alive' 
                            AND ICAdjInvs.AAStatus='Alive'
                            AND ICStocks.AAStatus='Alive' 
                            AND ICAdjInvItemTypeCombo='IncQty'
							AND ICAdjInvItems.FK_ICProductID={0}
         Union All
-- Shipment
					select SUM(-1*ICShipmentItemQty) as Qty
                            from ICShipmentItems 
                            inner join ICShipments on ICShipments.ICShipmentID=ICShipmentItems.FK_ICShipmentID inner join
                            ICStocks on ICStocks.ICStockID=ICShipmentItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICShipmentItems.AAStatus='Alive' 
                            AND ICShipments.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                            AND ICShipmentItems.FK_ICProductID={0}
                            
       Union All 
--Shipment in Producion
       select SUM(-1*ICShipmentItemQty) as Qty
                            from ICShipmentItems 
                            inner join PPProductionOrdrs on PPProductionOrdrs.PPProductionOrdrID=ICShipmentItems.FK_PPProductionOrdrID inner join
                            ICStocks on ICStocks.ICStockID=ICShipmentItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICShipmentItems.AAStatus='Alive' 
                           AND PPProductionOrdrs.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                            AND ICShipmentItems.FK_ICProductID={0}
  Union All
-- Transfer Out
			select SUM(-1*ICTransferItemQty) As Qty
                            from ICTransferItems 
                            inner join ICTransfers on ICTransfers.ICTransferID=ICTransferItems.FK_ICTransferID inner join
                            ICStocks on ICStocks.ICStockID=ICTransferItems.FK_ICFromStockID 
							inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICTransferItems.AAStatus='Alive' 
                            AND ICTransfers.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                            AND ICTransferItems.FK_ICProductID={0}
     Union All
-- Adj Dec    
     select SUM(-1*ICAdjInvItemQty) as Qty
                            from ICAdjInvItems 
							inner join ICAdjInvs on ICAdjInvs.ICAdjInvID=ICAdjInvItems.FK_ICAdjInvID inner join
                            ICStocks on ICStocks.ICStockID=ICAdjInvItems.FK_ICStockID 
                            inner join ICStockTypes on ICStocks.FK_ICStockTypeID=ICStockTypes.ICStockTypeID
                            where 
                            ICAdjInvItems.AAStatus='Alive' 
                           AND ICAdjInvs.AAStatus='Alive' 
                            AND ICStocks.AAStatus='Alive' 
                           AND ICAdjInvItemTypeCombo='DecQty'
                           AND ICAdjInvItems.FK_ICProductID={0}
                          ) 
                          as ABC
                        ", iICProductID);
                #endregion

                DataSet ds = dal.GetDataSet(strQuery);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    dbTotalStockQuantity = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
            }
            catch (Exception)
            {
            }
            return dbTotalStockQuantity;
        }

        public double GetStockQtyByProductAndPhaseCft(int iICProductID,int iPPPhaseCfgID)
        {
            string str = string.Format(@"Select SUM(ICInventoryStockQuantity) from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                                    FK_ICStockID in (Select FK_ICStockID from PPPhaseCfgs where AAStatus='Alive' AND PPPhaseCfgID={1})
                                            ", iICProductID, iPPPhaseCfgID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public DataSet GetAllDataByProductAndPhaseCfg(int iICProductID, int iPPPhaseCfgID)
        {
            string str = string.Format(@"Select * from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                                    FK_ICStockID in (Select FK_ICStockID from PPPhaseCfgs where AAStatus='Alive' AND PPPhaseCfgID={1})
                                            ", iICProductID, iPPPhaseCfgID);
            return dal.GetDataSet(str);
        }


        public DataSet GetAllObjectByProductAndStockType(int iICProductID, string strStockType)
        {
            string strQuery = string.Format(@"Select * from ICInventoryStocks where 
                                                       AAStatus='Alive' AND FK_ICProductID={0} AND ICInventoryStockQuantity<>0 AND 
                                                       FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive' 
                                                            AND FK_ICStockTypeID in (Select ICStockTypeID from ICStockTypes where AAStatus='Alive' And ICStockTypeNo='{1}'))"
                                           , iICProductID, strStockType);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllObjectByProductAndStock(int iICProductID, int iStockID)
        {
            string strQuery = string.Format(@"Select * from ICInventoryStocks where 
                                                       AAStatus='Alive' AND FK_ICProductID={0} AND ICInventoryStockQuantity<>0 AND 
                                                       (FK_ICStockID ={1} or {1}=0)"
                                           , iICProductID, iStockID);
            return dal.GetDataSet(strQuery);
        }

        public double GetStockQtyByStandardGroupModelAndColor(int iProductModelID, int iProductStandardID, int iProductGroupID, int iProductColorSchemaID)
        {
            string strQuery = String.Format(@"Select SUM(ICInventoryStockQuantity)
                                                    from ICInventoryStocks 
                                                    INNER JOIN ICProducts ON dbo.ICInventoryStocks.FK_ICProductID = dbo.ICProducts.ICProductID
                                                    WHERE dbo.ICInventoryStocks.AAStatus='Alive' AND dbo.ICProducts.AAStatus='Alive' 
                                                    AND (FK_ICProductModelID={0} or {0}=0) AND (FK_ICProductStandardID={1} or 0={1})
                                                    AND ICProducts.FK_ICProductGroupID={2} AND (FK_ICProductColorSchemaID={3} or {3}=0)
                                                    AND ICInventoryStocks.FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive')", iProductModelID, iProductStandardID, iProductGroupID, iProductColorSchemaID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public DataSet GetAllDataByStandardGroupModelAndColor(int iProductModelID, int iProductStandardID, int iProductGroupID, int iProductColorSchemaID)
        {
            string strQuery = String.Format(@"Select ICInventoryStocks.*
                                                    from ICInventoryStocks 
                                                    INNER JOIN ICProducts ON dbo.ICInventoryStocks.FK_ICProductID = dbo.ICProducts.ICProductID
                                                    WHERE dbo.ICInventoryStocks.AAStatus='Alive' AND dbo.ICProducts.AAStatus='Alive' 
                                                    AND (FK_ICProductModelID={0} or {0}=0) AND (FK_ICProductStandardID={1} or 0={1})
                                                    AND ICProducts.FK_ICProductGroupID={2} AND (FK_ICProductColorSchemaID={3} or {3}=0)
                                                    AND ICInventoryStocks.FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive')", iProductModelID, iProductStandardID, iProductGroupID, iProductColorSchemaID);
            return dal.GetDataSet(strQuery);
        }

        public double GetStockQuantiyByProductReOrderPointExceptionStock(int iProductID)
        {
            string str = string.Format(@"Select SUM(ICInventoryStockQuantity) from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                                    FK_ICStockID in (Select FK_ICStockID from ICSetupReOrderPointExceptionStocks where AAStatus='Alive')
                                            ", iProductID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public DataSet GetAllObjectByProductAndReOrderPointExceptionStock(int iICProductID)
        {
            string str = string.Format(@"Select * from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                                    FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive')
                                                    AND ICInventoryStockQuantity>0
                                                    and
                                                    FK_ICStockID Not in (Select FK_ICStockID from ICSetupReOrderPointExceptionStocks where AAStatus='Alive')
                                            ", iICProductID);
            return dal.GetDataSet(str);
        }

        //Thang add - 2/2/2016
        public DataSet GetAllObjectByProduct1(int iProductID)
        {
            string str = string.Format(@"Select * from ICInventoryStocks where AAStatus='Alive' AND FK_ICProductID={0} and
                                                    FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive')
                                            ", iProductID);
            return dal.GetDataSet(str);
        }
    }
	#endregion
}