﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
    #region ICProducts
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICProductsController
    //Created Date:Friday, March 21, 2008
    //-----------------------------------------------------------

    public class ICProductsController : BaseBusinessController
    {
        public ICProductsController()
        {
            dal = new DALBaseProvider("ICProducts", typeof(ICProductsInfo));
        }

        public DataSet GetProductsByCreatedDate(DateTime dtDateFrom, DateTime dtDateTo)
        {
            return dal.GetDataSet("ICProducts_SelectByCreatedDate", dtDateFrom, dtDateTo);
        }

        public ICProductsInfo GetProductByProductBarCode(String strProductBarCode)
        {
            String strQuery = String.Format("SELECT * FROM [dbo].[ICProducts] WHERE [AAStatus] = 'Alive' AND [ICProductBarCode] = '{0}'", strProductBarCode);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds.Tables.Count > 0)
                return (ICProductsInfo)dal.GetSingleObject(ds.Tables[0]);
            return null;
        }

        public bool IsExistProductSerialNo(int iProductID, String strProductSerialNo)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICInventoryStockSerialsController objInventoryStockSerialsController = new ICInventoryStockSerialsController();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();

            if (!String.IsNullOrEmpty(strProductSerialNo))
            {
                ICReceiptItemsInfo objReceiptItemsInfo = objReceiptItemsController.GetReceiptItemByProductSerialNo(strProductSerialNo);
                if (objReceiptItemsInfo != null)
                    return true;

                ICTransferItemsInfo objTransferItemsInfo = objTransferItemsController.GetTransferItemByProductSerialNo(strProductSerialNo);
                if (objTransferItemsInfo != null)
                    return true;

                ICInventoryStockSerialsInfo objInventoryStockSerialsInfo = objInventoryStockSerialsController.GetInventoryStockSerialByProductSerialNo(strProductSerialNo);
                if (objInventoryStockSerialsInfo != null)
                    return true;

                ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetInvoiceItemByProductSerialNo(strProductSerialNo);
                if (objInvoiceItemsInfo != null)
                    return true;
            }
            else
            {
                ICReceiptItemsInfo objReceiptItemsInfo = objReceiptItemsController.GetReceiptItemByProductID(iProductID);
                if (objReceiptItemsInfo != null)
                    return true;

                ICTransferItemsInfo objTransferItemsInfo = objTransferItemsController.GetTransferItemByProductID(iProductID);
                if (objTransferItemsInfo != null)
                    return true;

                ICInventoryStockSerialsInfo objInventoryStockSerialsInfo = (ICInventoryStockSerialsInfo)objInventoryStockSerialsController.GetInventoryStockSerialByProductID(iProductID);
                if (objInventoryStockSerialsInfo != null)
                    return true;

                ARInvoiceItemsInfo objInvoiceItemsInfo = objInvoiceItemsController.GetInvoiceItemByProductID(iProductID);
                if (objInvoiceItemsInfo != null)
                    return true;
            }

            return false;
        }

        public bool IsExistProductSerialNo(int iProductID, String strProductSerialNo, int iStockID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICInventoryStockSerialsController objInventoryStockSerialsController = new ICInventoryStockSerialsController();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();

            if (!String.IsNullOrEmpty(strProductSerialNo))
            {
                ICReceiptItemsInfo objReceiptItemsInfo = objReceiptItemsController.GetReceiptItemByProductSerialNoAndStockID(strProductSerialNo, iStockID);
                if (objReceiptItemsInfo != null)
                    return true;

                ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetTransferItemByProductSerialNoAndStockID(strProductSerialNo, iStockID);
                if (objTransferItemsInfo != null)
                    return true;

                ICInventoryStockSerialsInfo objInventoryStockSerialsInfo = objInventoryStockSerialsController.GetInventoryStockSerialByProductSerialNoAndStockID(strProductSerialNo, iStockID);
                if (objInventoryStockSerialsInfo != null)
                    return true;
            }
            else
            {
                ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetReceiptItemByProductIDAndStockID(iProductID, iStockID);
                if (objReceiptItemsInfo != null)
                    return true;

                ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetTransferItemByProductIDAndStockID(iProductID, iStockID);
                if (objTransferItemsInfo != null)
                    return true;

                ICInventoryStockSerialsInfo objInventoryStockSerialsInfo = objInventoryStockSerialsController.GetInventoryStockSerialByProductIDAndStockID(iProductID, iStockID);
                if (objInventoryStockSerialsInfo != null)
                    return true;
            }

            return false;
        }

        #region--hieu nguyen --
        public DataSet GetProductByCreateDateAndStockID(DateTime dtFromDate, DateTime dtToDate, int iICStockID)
        {
            String strQuery = String.Format("SELECT * FROM [dbo].[ICProducts] {0}", QueryCondition(dtFromDate, dtToDate, iICStockID));
            return (DataSet)dal.GetDataSet(strQuery);
        }
        private String QueryCondition(DateTime dtFromDate, DateTime dtToDate, int iICStockID)
        {
            String strFormatDate = "yyyyMMdd";
            return String.Format(" WHERE CONVERT(VARCHAR(10), [AACreatedDate], 112)>= CONVERT(VARCHAR(10), '{0}', 112) AND CONVERT(VARCHAR(10), [AACreatedDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112) AND [FK_ICStockID]={2} AND [AAStatus]='{3}'", dtFromDate.ToString(strFormatDate), dtToDate.ToString(strFormatDate), iICStockID, BusinessObject.DefaultAAStatus);
        }
        public DataSet GetProductByDeleteDateAndStockID(DateTime dtFromDate, DateTime dtToDate, int iICStockID)
        {
            String strQuery = String.Format("SELECT * FROM [dbo].[ICProducts] {0}", QueryDeletedCondition(dtFromDate, dtToDate, iICStockID));
            return (DataSet)dal.GetDataSet(strQuery);
        }
        private String QueryDeletedCondition(DateTime dtFromDate, DateTime dtToDate, int iICStockID)
        {
            String strFormatDate = "yyyyMMdd";
            return String.Format(" WHERE CONVERT(VARCHAR(10), [AAUpdatedDate], 112)>= CONVERT(VARCHAR(10), '{0}', 112) AND CONVERT(VARCHAR(10), [AAUpdatedDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112) AND [FK_ICStockID]={2} AND [AAStatus]='{3}'", dtFromDate.ToString(strFormatDate), dtToDate.ToString(strFormatDate), iICStockID, BusinessObject.DeletedAAStatus);
        }
        //
        public List<ICProductsInfo> ListProductByGroupID(int iProductGroupID)
        {
            List<ICProductsInfo> lst = new List<ICProductsInfo>();
            DataSet ds = dal.GetAllDataByForeignColumn("FK_ICProductGroupID", iProductGroupID);
            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ICProductsInfo objICProductsInfo = (ICProductsInfo)dal.GetObjectFromDataRow(row);
                        if (objICProductsInfo != null)
                        {
                            lst.Add(objICProductsInfo);
                        }
                    }
                }

            }
            return lst;
        }
        #endregion

        #region Thien
        public DataSet GetProductDeleteByBranchIDAndDate(DateTime dtFromDate, DateTime dtToDate, int iBranchID)
        {
            String strQuery = String.Format("Select * from ICProducts where  AAStatus='Delete' and  {0} and FK_StockID in (Select ICStockID from ICStocks where AAStatus='Alvie' and FK_BRBranchID={1})", QueryConditionDate(dtFromDate, dtToDate), iBranchID);
            return dal.GetDataSet(strQuery);
        }

        public string QueryConditionDate(DateTime dtFromDate, DateTime dtToDate)
        {
            string strFormatDate = "yyyyMMdd";
            return String.Format("  CONVERT(VARCHAR(10), [AAUpdatedDate], 112)>= CONVERT(VARCHAR(10), '{0}', 112) AND CONVERT(VARCHAR(10), [AAUpdatedDate], 112)<= CONVERT(VARCHAR(10), '{1}', 112) ", dtFromDate.ToString(strFormatDate), dtToDate.ToString(strFormatDate));

        }
        public DataSet GetAllProductDeleteByDateOfStockCentral(DateTime dtFromDate, DateTime dtToDate, int iStockID)
        {
            string strQuery = String.Format("Select * from ICProducts where AAStatus='Delete' and {0} and FK_ICStockID={1} ", QueryConditionDate(dtFromDate, dtToDate), iStockID);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllProductAliveByDateOfStockCentral(DateTime dtFromDate, DateTime dtToDate, int iStockID)
        {
            string strQuery = String.Format("Select * from ICProducts where AAStatus='Alive' and {0} and FK_ICStockID={1} ", QueryConditionDate(dtFromDate, dtToDate), iStockID);
            return dal.GetDataSet(strQuery);
        }
        #endregion

        public DataSet GetAllObjectsByWOID(int WOID)
        {
            string strQuery = "";
            if (WOID > 0)
                strQuery = string.Format("Select * from ICProducts where AAStatus = 'Alive' and ICProductID in (select FK_ICProductID FROM PPWOEstFGItems WHERE FK_PPWOID = {0})", WOID);
            else
                strQuery = string.Format("Select * from ICProducts where AAStatus = 'Alive' and ICProductID in (select FK_ICProductID FROM PPWOEstFGItems)");
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetProductsByType(String strType)
        {
            String strQuery = String.Format("Select * from ICProducts where AAStatus = 'Alive' and ICProductTypeCombo = '{0}'", strType);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllProductOrderBy()
        {
            return dal.GetDataSet("Select * from ICProducts where AAStatus='Alive' order by ICProductID");
        }

        public DataSet GetAllProductInWaranty(int iWarantyID)
        {
            string strQuery = String.Format("Select * from ICProducts where AAStatus='Alive' and ICProductID in (Select FK_ICProductID From CMWarantyITems where FK_CMWarantyID={0})", iWarantyID);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllProductInWarantyHistory(int iWarantyHisrotyID)
        {
            string strQuery = String.Format("Select * from ICProducts where AAStatus='Alive' and ICProductID in (Select FK_ICProductID From CMWarantyHistoryItems where FK_CMWarantyHistoryID={0})", iWarantyHisrotyID);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllProductAverage(int iWarantyHisrotyID)
        {
            string strQuery = String.Format("Select * from ICProducts where AAStatus='Alive' and ICProductCostingMethodCombo = 'Average'");
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllProductHasSOInRange(DateTime dtFrom, DateTime dtTo)
        {
            string strQuery = String.Format(@"Select * 
                                                from ICProducts
                                                where AAStatus='Alive'
                                                and ICProductID IN (SELECT FK_ICProductID 
                                                                        FROM ARSOItems 
                                                                        WHERE AAStatus = 'ALive' AND ARSOItemRqty > 0 AND ARSOItemShpDate BETWEEN '{0}' AND '{1}')", String.Format("{0:yyyy/M/d HH:mm:ss}", dtFrom), String.Format("{0:yyyy/M/d HH:mm:ss}", dtTo));
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllObjectsByProductPlnID(int iProductPlnID)
        {
            string strQuery = string.Format("Select * from ICProducts where AAStatus = 'Alive' and ICProductID in (select FK_ICProductID FROM PPProductPlnItems WHERE FK_PPProductPlnID = {0})", iProductPlnID);
            return dal.GetDataSet(strQuery);
        }

        public int GetMaxExtentionNumber(String StrStart, int ExtentionLength)
        {
            String strQuery = String.Format(@"
                                                drop table Temp1
                                                drop table Temp2
                                                select RIGHT(ICProductNo, 6) AS ProductNo INTO Temp1
                                                FROM ICProducts WHERE AAStatus = 'Alive'

                                                select ISNUMERIC( RIGHT(ProductNo, {0})) AS isNumber,  RIGHT(ProductNo, {0}) AS No
                                                            into Temp2
                                                FROM Temp1 WHERE ProductNo Like '{1}%'

                                                select MAX(CAST(No AS FLOAT)) from Temp2
                                                WHERE isNumber = 1
                                                ", ExtentionLength, StrStart);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                    && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                try
                {
                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }

            return 0;
        }

        public DataSet GetAllProductByCostingType(String strCostingType)
        {
            String strQuery = String.Format(@"SELECT * FROM ICProducts WHERE AAStatus = 'Alive'
                                                    AND ICProductCostingTypeCombo = '{0}'", strCostingType);

            return GetDataSet(strQuery);
        }

        public DataSet GetAllProduction(String strCostingType, bool isHasNorm)
        {
            String strQuery = String.Format(@"SELECT *
                                            FROM ICProducts 
                                            WHERE ICProducts.AAStatus = 'Alive'
                                            AND ICProductCostingTypeCombo = '{0}'", strCostingType);
            if (isHasNorm == false)
                strQuery += String.Format(@"AND ICProducts.ICProductID 
                                                NOT IN (SELECT FK_ICProductID FROM dbo.PPNorms WHERE PPNorms.AAStatus = 'Alive')");
            else
                strQuery += String.Format(@"AND ICProducts.ICProductID 
                                                IN (SELECT FK_ICProductID FROM dbo.PPNorms WHERE PPNorms.AAStatus = 'Alive')");
            return GetDataSet(strQuery);
        }

        public double GetTotalMaterialCBMInNormLevel2ByProductType(int iProductID, int iProductTypeID)
        {
            string strQuery = string.Format(@"select SUM(ICProducts.ICProductMaterialCBM*PPNormRMs.PPNormRMQty*PPNormRMLevel2.PPNormRMQty) from 
                                    PPNorms
                                    inner join PPNormRMs on PPNormRMs.FK_PPNormID = PPNorms.PPNormID
                                    inner join PPNorms as PPNormLevel2 on PPNormLevel2.FK_ICProductID=PPNormRMs.FK_ICProductID
                                    inner join PPNormRMs as PPNormRMLevel2 on PPNormRMLevel2.FK_PPNormID=PPNormLevel2.PPNormID
                                    inner join ICProducts on ICProducts.ICProductID=PPNormRMLevel2.FK_ICProductID
                                    where PPNorms.FK_ICProductID={0} AND ICProducts.FK_ICProductTypeID={1} AND PPNorms.AAStatus='Alive'", iProductID, iProductTypeID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public double GetTotalMaterialCBMInNormByProductType(int iProductID, int iProductTypeID)
        {
            string strQuery = string.Format(@"select SUM(ICProducts.ICProductMaterialCBM*PPNormRMs.PPNormRMQty) from 
                                    PPNorms
                                    inner join PPNormRMs on PPNormRMs.FK_PPNormID = PPNorms.PPNormID
                                    inner join ICProducts on ICProducts.ICProductID=PPNormRMs.FK_ICProductID
                                    where PPNorms.AAStatus='Alive' AND PPNorms.FK_ICProductID={0} AND ICProducts.FK_ICProductTypeID={1}", iProductID, iProductTypeID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }

        /// <summary>
        /// Viet Nguyen 2012/11/29
        /// Get CBM Product By FK_ICProductVolumeID
        /// </summary>
        public double GetPkgCBMByProduct(int iProductID)
        {
            string strQuery = string.Format(@"Select ICProductVolume from ICProducts where AAStatus='Alive' AND ICProductID in 
                                    (Select FK_ICProductVolumeID from ICProducts where AAStatus='Alive' And ICProductID={0})", iProductID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }

        /// <summary>
        /// Viet Nguyen 2012/11/30
        /// Get All Product Exist ARShpPlan
        /// </summary>
        public DataSet GetAllProductInARShpPlan()
        {
            string strQuery = string.Format(@"SELECT DISTINCT ICProducts.* FROM ARShpPlanItems inner join ICProducts on 
                                                ARShpPlanItems.FK_ICProductID=ICProducts.ICProductID
                                                WHERE 
                                                ARShpPlanItems.AAStatus = 'Alive' AND ICProducts.AAStatus='Alive' AND
                                                 FK_ARShpPlanID in (Select ARShpPlanID from ARShpPlans where AAStatus='Alive') 
                                                order by ICProductID
                                                        ");
            return dal.GetDataSet(strQuery);
        }

        /// <summary>
        /// Viet Nguyen 2012/12/10
        /// Get ProductID And Material CBM in Direct Norm (In Norm Level 1)
        /// </summary>
        public DataSet GetProductIDAndMaterialCBMInDirectNorm(string strProductType)
        {
            string strQuery = string.Format(@"select ICProducts.ICProductID,sum(ProductLevel1.ICProductMaterialCBM*PPNormRMs.PPNormRMQty)
                                                from  ICProducts
                                                inner join PPNorms on ICProducts.ICProductID = PPNorms.FK_ICProductID
                                                inner join PPNormRMs on PPNormRMs.FK_PPNormID = PPNorms.PPNormID
                                                inner join ICProducts as ProductLevel1 on ProductLevel1.ICProductID=PPNormRMs.FK_ICProductID
                                                inner join ICProductTypes on ProductLevel1.FK_ICProductTypeID=ICProductTypes.ICProductTypeID
                                                where ICProductTypes.ICProductTypeNo='{0}' AND ICProducts.AAStatus='Alive' AND PPNorms.AAStatus='Alive'
                                                group by ICProducts.ICProductID", strProductType);
            return dal.GetDataSet(strQuery);
        }

        /// <summary>
        /// Viet Nguyen 2012/12/10
        /// Get ProductID And Material CBM in Norm Of Norm (Norm Level 2)
        /// </summary>
        public DataSet GetProductIDAndMaterialCBMInNormLevel2(string strProductType)
        {
            string strQuery = string.Format(@"select ICProducts.ICProductID,sum(ProductLevel2.ICProductMaterialCBM*PPNormRMs.PPNormRMQty*NormRMLevel2.PPNormRMQty) from ICProducts
                                                inner join PPNorms on ICProducts.ICProductID = PPNorms.FK_ICProductID
                                                inner join PPNormRMs on PPNormRMs.FK_PPNormID = PPNorms.PPNormID
                                                inner join PPNorms as NormLevel2 on NormLevel2.FK_ICProductID=PPNormRMs.FK_ICProductID
                                                inner join PPNormRMs as NormRMLevel2 on NormLevel2.PPNormID=NormRMLevel2.FK_PPNormID
                                                inner join ICProducts as ProductLevel2 on ProductLevel2.ICProductID=NormRMLevel2.FK_ICProductID
                                                inner join ICProductTypes on ProductLevel2.FK_ICProductTypeID=ICProductTypes.ICProductTypeID
                                                where ICProductTypes.ICProductTypeNo='{0}' AND ICProducts.AAStatus='Alive' AND PPNorms.AAStatus='Alive' AND NormLevel2.AAStatus='Alive'
                                                group by ICProducts.ICProductID", strProductType);
            return dal.GetDataSet(strQuery);
        }

        public void UpdateAccountSetByGroup(int iGroupID)
        {
            ICProductGroupsInfo Group = (ICProductGroupsInfo)new ICProductGroupsController().GetObjectByID(iGroupID);
            if (Group == null) return;

            String strQuery = String.Format(@"UPDATE ICProducts SET FK_ICAccountSetID = {0} WHERE AAStatus = 'Alive' AND FK_ICProductGroupID = {1}", Group.FK_ICAccountSetID, iGroupID);

            new ICProductsController().GetDataSet(strQuery);
        }

        public void UpdateCostingTypeByGroup(int iGroupID)
        {
            ICProductGroupsInfo Group = (ICProductGroupsInfo)new ICProductGroupsController().GetObjectByID(iGroupID);
            if (Group == null) return;

            String strQuery = String.Format(@"UPDATE ICProducts SET ICProductCostingTypeCombo = '{0}' WHERE AAStatus = 'Alive' AND FK_ICProductGroupID = {1}", Group.ICProductCostingTypeCombo, iGroupID);

            new ICProductsController().GetDataSet(strQuery);
        }
        /// <summary>
        /// Created By Hoang.Nguyen
        /// Created Date 2013.02.20
        /// </summary>
        /// <param name="dbInMonthQty"></param>
        /// <param name="iTypeID"></param>
        public void UpdateInMonthQty(double dbInMonthQty, int iTypeID)
        {
            String strQuery = String.Format(@"UPDATE ICProducts SET ICProductInvInMonthQty = {0} WHERE AAStatus = 'Alive' AND FK_ICProductTypeID = {1}", dbInMonthQty, iTypeID);
            GetDataSet(strQuery);
        }

        public void UpdatePkgCBMAllProduct()
        {
            string strQuery = string.Format(@"Update ICProducts set ICProductPkgCBM=ICProductPkgLength*ICProductPkgWidth*ICProductPkgHeight/1000000000");
            dal.GetDataSet(strQuery);
        }

        public ICProductsInfo GetProductByGroupStandardAndColorSchema(int iProductGroupID, int iProductStandardID, int iProductColorSchema)
        {
            string strQuery = string.Format(@"Select * from ICProducts where AAStatus='Alive' AND FK_ICProductGroupID={0} 
                                                AND FK_ICProductStandardID={1} AND FK_ICProductColorSchemaID={2}", iProductGroupID, iProductStandardID, iProductColorSchema);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ICProductsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }

        public DataSet GetProductsByProductType(int iProductTypeID)
        {
            String strQuery = String.Format(@"  SELECT *
                                                FROM ICProducts
                                                WHERE ICProducts.AAStatus = 'Alive' 
                                                AND (ICProducts.FK_ICProductTypeID = {0} OR {0} = 0)", iProductTypeID);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllProductByGroupStandardVan(int iProductGroupID, int iProductStandardVanID, int iProductModelID)
        {
            string strQuery = string.Format(@"Select * from ICProducts where AAStatus='Alive' AND FK_ICProductGroupID={0} AND FK_ICProductStandardVanID={1} AND FK_ICProductModelID={2}"
                , iProductGroupID, iProductStandardVanID, iProductModelID);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllModule()
        {
            string strQuery = string.Format(@" SELECT b.STModuleName,c.STModuleDescriptionDescription
                                               FROM   STModuleDescriptions c , STModules b
					                           WHERE  b.STModuleID = c.STModuleID AND c.STModuleDescriptionDescription != ''
					                           GROUP BY   b.STModuleName,c.STModuleDescriptionDescription "
                                           );
            return dal.GetDataSet(strQuery);
        }

        public DataSet LaySanPhamTheoIsKit(bool bIsKit)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ICProducts
                                              WHERE AAStatus='Alive'
                                              AND (ICProductIsKit='{0}')
                                              ", bIsKit);
            DataSet ds = dal.GetDataSet(strQuery);
            return ds;
        }

        public DataSet GetAllIOFProduct(int iProductID)
        {
            String strQuery = String.Format(@"SELECT   ICProductIOF01Combo,
                                                       ICProductIOF02Combo,
                                                       ICProductIOF03Combo,
                                                       ICProductIOF04Combo,
                                                       ICProductIOF05Combo,
                                                       ICProductIOF06Combo,
                                                       ICProductIOF07Combo,
                                                       ICProductIOF08Combo,
                                                       ICProductIOF09Combo
                                                       ICProductIOF010Combo  
                                              FROM dbo.icproducts
                                              WHERE AAStatus = 'Alive'
                                                      AND ICProductID = {0}
                                              ", iProductID);
            DataSet ds = dal.GetDataSet(strQuery);
            return ds;
        }
        public DataSet GetAllProductByInventoryAccountType(string sAccType)
        {
            string strQuery = String.Format(@"Select * from ICProducts a 
INNER JOIN ICAccountSets b ON a.FK_ICAccountSetID = b.ICAccountSetID AND a.AAStatus='Alive' AND b.AAStatus = 'Alive'
INNER JOIN GLAccounts c ON b.FK_GLInventoryAccountID = c.GLAccountID AND c.AAStatus = 'Alive' AND GLAccountTypeCombo = '{0}'", sAccType);
            return dal.GetDataSet(strQuery);
        }
        //Thang add - lấy tài khoản chi phí mua hàng trong bộ định khoản sản phẩm
        public int GetPurchaseCostAccountIDByProductID(int iProductID, string fieldName = "FK_GLPurchaseCostAccountID")
        {
            string strQuery = string.Format(@"SELECT CASE WHEN b.{0} IS NOT NULL THEN
                                                        b.{0}
                                                    ELSE a.{0} END AS {0}
                                                FROM ICProducts AS a
                                                JOIN ICAccountSets AS b ON FK_ICAccountSetID = ICAccountSetID
                                                WHERE ICProductID = {1}", fieldName, iProductID);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                try
                {
                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                catch (Exception ex) { }
            }
            return 0;
        }
        // Tuyen- 18/05/2016 - lấy product theo điều kiện I-code
        public DataSet GetProductByCondition(string strCondition)
        {
            if (!string.IsNullOrEmpty(strCondition))
                if (!strCondition.ToUpper().StartsWith(" AND "))
                    strCondition = " AND " + strCondition;

            String str = String.Format(@"SELECT * FROM dbo.ICProducts WHERE AAStatus = 'Alive' {0}", strCondition);
            return GetDataSet(str);
        }
        //
        //03/06/2016
        public DataSet GetAllProductHasSOInRangeSO(DateTime dtFrom, DateTime dtTo, int iARSO)
        {
            string strQuery = String.Format(@"Select * 
                                                from ICProducts
                                                where AAStatus='Alive'
                                                and ICProductID IN (SELECT FK_ICProductID 
                                                                        FROM ARSOItems 
                                                                        WHERE AAStatus = 'ALive' AND ARSOItemRqty > 0 AND ARSOItemShpDate BETWEEN '{0}' AND '{1}'
                                                                        AND FK_ARSOID = {2})", String.Format("{0:yyyy/M/d HH:mm:ss}", dtFrom), String.Format("{0:yyyy/M/d HH:mm:ss}", dtTo), iARSO);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetProductIsRouting()
        {
            String str = String.Format(@"   SELECT  *
                                            FROM    dbo.ICProducts
                                            WHERE   AAStatus = 'Alive'
                                                    AND ICProductActiveCheck = 'true'
                                                    AND EXISTS ( SELECT 'x'
                                                                 FROM   dbo.PPRoutings
                                                                 WHERE  AAStatus = 'Alive'
                                                                        AND ICProducts.FK_PPRoutingID = dbo.ICProducts.FK_PPRoutingID)");
            return GetDataSet(str);
        }
        public DataSet GetProductIsNotRouting()
        {
            String str = String.Format(@"SELECT  *
                                            FROM    dbo.ICProducts
                                            WHERE   AAStatus = 'Alive'
                                                    AND ICProductActiveCheck = 'true'
                                                    AND EXISTS ( SELECT 'x'
                                                                 FROM   dbo.PPRoutings
                                                                 WHERE  AAStatus NOT LIKE 'Alive'
                                                                        AND ICProducts.FK_PPRoutingID = dbo.ICProducts.FK_PPRoutingID)");
            return GetDataSet(str);
        }
        public DataSet GetAllDataByListID(string[] lstID)
        {
            string strQuery = string.Format("SELECT * FROM {0} WHERE AAStatus = 'Alive' AND {1} IN({2})", dal.TableName, GMCDbUtil.GetTablePrimaryColumn(dal.TableName), string.Join(",", lstID));
            return GetDataSet(strQuery);
        }


        /// <summary>
        /// Lấy sản phẩm hoặc nguyên vật liệu theo:
        ///   - Colum ICProductIsMajorMaterialCheck (có sản xuất hay k)
        ///   - Theo Quy trình sản xuất
        /// </summary>
        /// <param name="pisMajorMarerial"></param>
        /// <returns></returns>
        public DataSet GetAllProductByIsMajorMaterial(bool pisMajorMarerial)
        {
            
            string strQuery = "SELECT * FROM dbo.ICProducts WHERE AAStatus='Alive'";            
            ////Lấy NVL theo quy trình sản xuất (
            //string strSubQuery = "IN";
            //if (pisMajorMarerial == false)
            //{
            //    strSubQuery = "NOT IN";
            //}
            ////)

            //if (GMCDbUtil.ColumnIsExist("ICProducts", "ICProductIsMajorMaterialCheck"))
            //{
            //    strQuery += string.Format(" WHERE ICProductIsMajorMaterialCheck={0}", pisMajorMarerial);
            //}
            //else
            //{
            //    strQuery += string.Format(@"
            //                               WHERE   FK_PPRoutingID {0} ( SELECT  PPRoutingID
            //                                                        FROM    dbo.PPRoutings
            //                                                        WHERE   AAStatus = 'Alive' )
            //                                       AND AAStatus = 'Alive'

            //                                ", strSubQuery);
            //}
            return GetDataSet(strQuery);
        }
        public DataSet GetProductByAvgCost(int iPeriod, int iYear)
        {
            DateTime dtFrom = new DateTime(iYear, iPeriod, 1);
            DateTime dtTo  = new DateTime(iYear, iPeriod, DateTime.DaysInMonth(iYear, iPeriod));
            return GetProductByAvgCost(dtFrom, dtTo);
        }
        public DataSet GetProductByAvgCost(DateTime dtFrom, DateTime dtTo)
        {
            object[] _objParrs = {dtFrom
                    ,dtTo
                                };
            return SqlDatabaseHelper.RunStoredProcedure("spL_GetProductCalcAvgCost", _objParrs);
        }
        public bool GetICodeByADOFItemNo(String strADOFNo, String strValue)
        {
            String strQuery = String.Format(@"  SELECT ADOFItems.*
                                                FROM dbo.ADOFs INNER JOIN dbo.ADOFItems ON ADOFItems.FK_ADOFID = ADOFs.ADOFID
                                                WHERE ADOFs.AAStatus = 'Alive' AND ADOFItems.AAStatus ='Alive'
                                                      AND ADOFs.ADOFNo = '{0}'
	                                                  AND ADOFItems.ADOFItemNo = N'{1}'
                                              ", strADOFNo, strValue);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
    #endregion
}