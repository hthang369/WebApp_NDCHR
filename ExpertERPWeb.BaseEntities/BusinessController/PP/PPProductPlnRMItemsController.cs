﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductPlnRMItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPProductPlnRMItemsController
	//Created Date:Tuesday, September 27, 2011
	//-----------------------------------------------------------
	
	public class PPProductPlnRMItemsController:BaseBusinessController
	{
		public PPProductPlnRMItemsController()
		{
			dal= new DALBaseProvider("PPProductPlnRMItems",typeof(PPProductPlnRMItemsInfo));
		}
        public override int CreateObject(BusinessObject obj)
        {
            ((PPProductPlnRMItemsInfo)obj).AASelected = false;
            return base.CreateObject(obj);
        }

        public PPProductPlnRMItemsInfo GetObjectByPlnIDAndProductID(int iPlnID, int iProductID)
        {
            String strQuery = String.Format(@"SELECT * FROM PPProductPlnRMItems WHERE FK_PPProductPlnID = {0} AND FK_ICProductID = {1}", iPlnID, iProductID);

            DataSet ds = GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPProductPlnRMItemsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }

            return null;

        }

        /// <summary>
        /// Viet Nguyen 2013.03.25
        /// Lấy các NVL được cấu hình trong PPSubMaterialGroups được dùng trong KHSX
        /// </summary>
        public DataSet GetAllMaterialInProductPlnByProductPlnProductPlnItemType(int iProductPlnID,string strProductPlnItemType)
        {
            string strQuery = string.Format(@"select PPNormRMS.FK_ICProductID as FK_ICProductID,ICProducts.ICProductStockMin as PPProductPlnRMItemStockMinQty
                                                    ,sum(PPProductPlnItemQty*PPNormRMS.PPNormRMQty) as PPProductPlnRMItemPlnQty,PPSubMaterialGroups.FK_ICProductGroupID
                                                    ,ICProducts.FK_ICStkUOMID as FK_ICUOMID
                                                    from 
                                                    dbo.PPProductPlnItems 
                                                    inner join PPNorms on PPProductPlnItems.FK_ICProductID=PPNorms.FK_ICProductID
                                                    inner join PPNormRMS on PPNorms.PPNormID=PPNormRMS.FK_PPNormID
                                                    inner join ICProducts on ICProducts.ICProductID=PPNormRMS.FK_ICProductID
                                                    inner join PPSubMaterialGroups on ICProducts.FK_ICProductGroupID=PPSubMaterialGroups.FK_ICProductGroupID
                                                    where PPProductPlnItems.AAStatus='Alive'
                                                    AND ICProducts.AAStatus='Alive' AND PPNorms.AAStatus='Alive' AND PPSubMaterialGroups.AAStatus='Alive'
                                                    AND PPProductPlnItems.FK_PPProductPlnID={0}
                                                    AND PPProductPlnItems.PPProductPlnItemTypeCombo='{1}'
                                                    group by PPNormRMS.FK_ICProductID,PPSubMaterialGroups.FK_ICProductGroupID,ICProducts.ICProductStockMin,ICProducts.FK_ICStkUOMID"
                                                    , iProductPlnID,strProductPlnItemType);
            return dal.GetDataSet(strQuery);
        }
        /// <summary>
        /// Viet Nguyen 2013.03.28
        /// Lấy các NVL được cấu hình trong PPSubMaterialGroups được dùng trong KHXH
        /// ARShpPlnItems Inner JOin PPNorms, Inner Join PPNormRMs để lấy được NVL.
        /// Inner Join ICProduct inner join PPSubMaterialGroups để lấy được nhóm sản phẩm nằm trong table cấu hình
        /// </summary>
        public DataSet GetAllMaterialInShpPlnByARShpPlanID(int iARShpPlnID)
        {
            string strQuery = string.Format(@"select PPNormRMS.FK_ICProductID as FK_ICProductID,ICProducts.ICProductStockMin as PPProductPlnRMItemStockMinQty
                                                    ,sum(ARShpPlanItemNTSQty*PPNormRMS.PPNormRMQty) as PPProductPlnRMItemPlnQty,PPSubMaterialGroups.FK_ICProductGroupID
                                                    from 
                                                    dbo.ARShpPlanItems 
                                                    inner join PPNorms on ARShpPlanItems.FK_ICProductID=PPNorms.FK_ICProductID
                                                    inner join PPNormRMS on PPNorms.PPNormID=PPNormRMS.FK_PPNormID
                                                    inner join ICProducts on ICProducts.ICProductID=PPNormRMS.FK_ICProductID
                                                    inner join PPSubMaterialGroups on ICProducts.FK_ICProductGroupID=PPSubMaterialGroups.FK_ICProductGroupID
                                                    where   
                                                    ICProducts.AAStatus='Alive' AND PPNorms.AAStatus='Alive' AND PPSubMaterialGroups.AAStatus='Alive'
                                                    AND ARShpPlanItems.FK_ARShpPlanID={0}
                                                    group by PPNormRMS.FK_ICProductID,PPSubMaterialGroups.FK_ICProductGroupID,ICProducts.ICProductStockMin"
                                                    , iARShpPlnID);
            return dal.GetDataSet(strQuery);
        }
        /// <summary>
        /// Viet Nguyen 2013.03.28
        /// Lấy các NVL được cấu hình trong PPSubMaterialGroups được dùng trong KHXH (Lấy trong Norm Level 2)
        /// ARShpPlnItems Inner Join PPNorms, Inner Join PPNormRMs để lấy được định mức của thành phẩm.
        /// Inner Join PPNorms, Inner Join PPNormRMs để lấy được định mức trong định mức của thành phẩm.
        /// Inner Join ICProduct inner join PPSubMaterialGroups để lấy được nhóm sản phẩm nằm trong table cấu hình
        /// </summary>
        public DataSet GetAllMaterialInNormOfShpPlnByARShpPlnID(int iARShpPlnID)
        {
            string strQuery = string.Format(@"select PPNormRMSLevel2.FK_ICProductID as FK_ICProductID,ICProducts.ICProductStockMin as PPProductPlnRMItemStockMinQty
                                                    ,sum(ARShpPlanItemNTSQty*PPNormRMS.PPNormRMQty*PPNormRMSLevel2.PPNormRMQty) as PPProductPlnRMItemPlnQty
                                                    ,PPSubMaterialGroups.FK_ICProductGroupID
                                                    from 
                                                    dbo.ARShpPlanItems 
                                                    inner join PPNorms on ARShpPlanItems.FK_ICProductID=PPNorms.FK_ICProductID
                                                    inner join PPNormRMS on PPNorms.PPNormID=PPNormRMS.FK_PPNormID
                                                    inner join PPNorms as PPNormsLevel2 on PPNormsLevel2.FK_ICProductID=PPNormRMS.FK_ICProductID
                                                    inner join PPNormRMS as PPNormRMSLevel2 on PPNormRMSLevel2.FK_PPNormID=PPNormsLevel2.PPNormID
                                                    inner join ICProducts on ICProducts.ICProductID=PPNormRMSLevel2.FK_ICProductID
                                                    inner join PPSubMaterialGroups on ICProducts.FK_ICProductGroupID=PPSubMaterialGroups.FK_ICProductGroupID
                                                    where   
                                                    ICProducts.AAStatus='Alive' AND PPNorms.AAStatus='Alive' AND PPSubMaterialGroups.AAStatus='Alive' AND PPNormsLevel2.AAStatus='Alive'
                                                    AND ARShpPlanItems.FK_ARShpPlanID={0}
                                                    group by PPNormRMSLevel2.FK_ICProductID,PPSubMaterialGroups.FK_ICProductGroupID,ICProducts.ICProductStockMin"
                                                    , iARShpPlnID);
            return dal.GetDataSet(strQuery);
        }
        //Tong so luong kh phai xuat cho cac KHSX truoc KHSX nay
        public double GetPlnQtyByProductAndProductPlnID(int iProductID, int iPPProductPlnID)
        {
            string strQuery = string.Format(@"
SELECT SUM(a.PPProductPlnRMItemPlnQty) 
FROM dbo.PPProductPlnRMItems a 
WHERE (a.FK_ICProductID={0})
    AND a.FK_PPProductPlnID > 0 AND a.FK_PPProductPlnID < {1}
", iProductID, iPPProductPlnID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        //Tong so luong da xuat cho cac KHSX truoc KHSX nay
        public double GetShpQtyByProductAndProductPlnID(int iProductID, int iPPProductPlnID)
        {
            string strQuery = string.Format(@"
SELECT SUM(a.ICShipmentItemQty) 
FROM dbo.ICShipmentItems a 
    INNER JOIN dbo.PPWOs b ON a.FK_PPWOID = b.PPWOID 
        AND a.AAStatus = 'Alive' AND b.AAStatus = 'ALive'
    INNER JOIN dbo.PPProductPlns c ON b.FK_PPProductPlnID = c.PPProductPlnID 
        AND c.AAStatus = 'ALive'
WHERE (a.FK_ICProductID={0})
    AND c.PPProductPlnID > 0 AND c.PPProductPlnID < {1}
", iProductID, iPPProductPlnID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        //SL dat hang da phan bo cho KHSX truoc 
        public double GetAllocateQtyByProductAndProductPlnID(int iProductID, int iPPProductPlnID)
        {
            string strQuery = string.Format(@"
SELECT SUM(APPOItemRQty) 
    FROM dbo.APPOItems a 
        INNER JOIN dbo.APPOs b ON a.FK_APPOID = b.APPOID 
            AND a.AAStatus = 'Alive' AND b.AAStatus = 'ALive'
WHERE (FK_ICProductID={0})
    AND FK_PPProductPlnID > 0 AND FK_PPProductPlnID < {1}
", iProductID, iPPProductPlnID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public double GetAllocateQtyByProductAndProductPlnID(int iProductID, int iFromPeriod,int iFromYear,int iToPeriod,int iToYear)
        {
            string strQuery = string.Format(@"SELECT SUM(PPProductPlnRMItemQty) FROM dbo.PPProductPlnRMItems
                                                    WHERE (FK_ICProductID={0})
                                                    AND FK_PPProductPlnID IN (SELECT PPProductPlnID FROM dbo.PPProductPlns WHERE AAStatus='Alive'
		                                                    AND PPProductPlnYear*12+PPProductPlnPeriod>={1} AND PPProductPlnYear*12+PPProductPlnPeriod<={2})
                                                    "
                                                    , iProductID, iFromPeriod + iFromYear * 12, iToPeriod + iToYear * 12);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public DataSet GetAllDataByProductPlnAndRMType(int iProductPlnID, string strRMItemType)
        {
            string strQuery = string.Format(@"Select * from PPProductPlnRMItems where FK_PPProductPlnID={0} AND PPProductPlnRMItemTypeCombo='{1}'"
                                                        ,iProductPlnID,strRMItemType);
            return dal.GetDataSet(strQuery);
        }
        public double GetAllocateQtyByProductInRange(int iProductID, DateTime dteFromDate,DateTime dteToDate)
        {
            string strQueryDate = DALUtil.GenerateBeetween("PPProductPlnRMItemProductPlnDate", dteFromDate, dteToDate);
            string strQuery = string.Format(@"SELECT SUM(PPProductPlnRMItemQty) FROM dbo.PPProductPlnRMItems
                                                    WHERE (FK_ICProductID={0})
                                                    AND {1}
                                                    "
                                                    , iProductID, strQueryDate);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }

	}
	#endregion
}