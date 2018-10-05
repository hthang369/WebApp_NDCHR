
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPResourceSynthetics
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.86)
	//Class: PPResourceSyntheticsController
	//Created Date: Wednesday, 08 Feb 2017
	//-----------------------------------------------------------
	
	public class PPResourceSyntheticsController : BaseBusinessController
	{
		public PPResourceSyntheticsController()
		{
			dal = new DALBaseProvider("PPResourceSynthetics",typeof(PPResourceSyntheticsInfo));
		}
        // NhamNDH add -10/02/2017- tổng hợp danh sách nguồn lực theo sản phẩm, công đoạn
        public DataSet GetAllResourceByProductAndPhaseCfgID(int iICProductID, int iPPPhaseCfgID)
        {
            string strQuery = string.Format(@"  SELECT	PPResourceID AS 'FK_PPResourceID',PPResourceItemID AS 'FK_PPResourceItemID',PPResourceProductivitys.FK_PPResourceRegimeID AS 'FK_PPResourceRegimeID'
			                                    FROM dbo.PPResources
                                                LEFT JOIN dbo.PPResourceItems ON PPResourceItems.FK_PPResourceID = PPResources.PPResourceID AND PPResourceItems.AAStatus ='Alive'
                                                LEFT JOIN dbo.PPResourceProductivitys ON PPResourceProductivitys.FK_PPResourceItemID = PPResourceItems.PPResourceItemID AND PPResourceProductivitys.AAStatus = 'Alive'
                                                WHERE PPResources.AAStatus='Alive' AND (FK_ICProductID = {0} OR FK_ICProductID IS NULL) AND FK_PPPhaseCfgID = {1}
                                                GROUP BY PPResourceID,PPResourceItemID,PPResourceProductivitys.FK_PPResourceRegimeID
			                                    ORDER BY FK_PPResourceID,FK_PPResourceItemID"
                                                , iICProductID, iPPPhaseCfgID);
            return dal.GetDataSet(strQuery);
        }
        // NhamNDH add -10/02/2017- tổng hợp danh sách nguồn lực theo công đoạn
        public DataSet GetAllResourceByPhaseCfgIDAndProduct(int iPPPhaseCfgID)
        {
            string strQuery = string.Format(@"  SELECT	PPResourceID AS 'FK_PPResourceID',PPResourceItemID AS 'FK_PPResourceItemID',PPResourceProductivitys.FK_PPResourceRegimeID AS 'FK_PPResourceRegimeID'
			                                    FROM dbo.PPResources
                                                LEFT JOIN dbo.PPResourceItems ON PPResourceItems.FK_PPResourceID = PPResources.PPResourceID AND PPResourceItems.AAStatus ='Alive'
                                                LEFT JOIN dbo.PPResourceProductivitys ON PPResourceProductivitys.FK_PPResourceItemID = PPResourceItems.PPResourceItemID AND PPResourceProductivitys.AAStatus = 'Alive'
                                                WHERE PPResources.AAStatus='Alive' AND (FK_PPPhaseCfgID = {0} OR {0}=0)
                                                GROUP BY PPResourceID,PPResourceItemID,PPResourceProductivitys.FK_PPResourceRegimeID
			                                    ORDER BY FK_PPResourceID,FK_PPResourceItemID"
                                                , iPPPhaseCfgID);
            return dal.GetDataSet(strQuery);
        }
        // NhamNDH add -13/02/2017-Lấy định mức tiêu hao nguồn lực của sản phẩm
        public double GetResourceSyntheticProductivityQtyByProductAndPhaseCfgID(PPResourceSyntheticsInfo objPPResourceSynthetic, int iICProductID, int iPPPhaseCfgID)
        {
            string strQuery = string.Format(@"  SELECT	CASE WHEN (PPResourceProductivitys.PPResourceProductivityQty IS NOT NULL AND PPResourceProductivitys.PPResourceProductivityQty > 0) THEN ROUND((SELECT PPResourceUOMSQty FROM PPResourceUOMs WHERE PPResourceUOMID = PPResourceProductivitys.FK_PPResourceUOMID)/PPResourceProductivitys.PPResourceProductivityQty,2) 
                                                             ELSE ROUND((SELECT PPResourceUOMSQty FROM PPResourceUOMs WHERE PPResourceUOMID = PPResources.FK_PPResourceUOMID)/PPResources.PPResourceProductivityQty,2) END AS 'PPResourceSyntheticProductivityQty'
			                                    FROM dbo.PPResources
                                                LEFT JOIN dbo.PPResourceItems ON PPResourceItems.FK_PPResourceID = PPResources.PPResourceID AND PPResourceItems.AAStatus ='Alive'
                                                LEFT JOIN dbo.PPResourceProductivitys ON PPResourceProductivitys.FK_PPResourceItemID = PPResourceItems.PPResourceItemID AND PPResourceProductivitys.AAStatus = 'Alive'
                                                WHERE PPResources.AAStatus='Alive' 
                                                      AND (FK_ICProductID = {0} OR  FK_ICProductID IS NULL)
                                                      AND FK_PPPhaseCfgID = {1} AND PPResourceID = {2} 
                                                      AND (PPResourceItemID = {3} OR PPResourceItemID IS NULL)  
                                                      AND (PPResourceProductivitys.FK_PPResourceRegimeID = {4} OR PPResourceProductivitys.FK_PPResourceRegimeID IS NULL)
			                                    "
                                                , iICProductID, iPPPhaseCfgID, objPPResourceSynthetic.FK_PPResourceID, objPPResourceSynthetic.FK_PPResourceItemID, objPPResourceSynthetic.FK_PPResourceRegimeID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        // NhamNDH add -27/03/2017-Lấy thời gian tiêu hao Setup của sản phẩm
        public double GetResourceSyntheticSetupQtyByProductAndPhaseCfgID(PPResourceSyntheticsInfo objPPResourceSynthetic, int iICProductID, int iPPPhaseCfgID)
        {
            string strQuery = string.Format(@"  SELECT	CASE WHEN (PPResourceProductivitys.PPResourceProductivitySetupQty IS NOT NULL AND PPResourceProductivitys.PPResourceProductivitySetupQty > 0) THEN ROUND((SELECT PPResourceUOMSQty FROM PPResourceUOMs WHERE PPResourceUOMID = PPResourceProductivitys.FK_PPResourceUOMID)*PPResourceProductivitys.PPResourceProductivitySetupQty,2)
				                                             ELSE ROUND((SELECT PPResourceUOMSQty FROM PPResourceUOMs WHERE PPResourceUOMID = PPResources.FK_PPResourceUOMID)*PPResources.PPResourceSetupQty,2) END	AS 'PPResourceSyntheticSetupQty'
			                                    FROM dbo.PPResources
                                                LEFT JOIN dbo.PPResourceItems ON PPResourceItems.FK_PPResourceID = PPResources.PPResourceID AND PPResourceItems.AAStatus ='Alive'
                                                LEFT JOIN dbo.PPResourceProductivitys ON PPResourceProductivitys.FK_PPResourceItemID = PPResourceItems.PPResourceItemID AND PPResourceProductivitys.AAStatus = 'Alive'
                                                WHERE PPResources.AAStatus='Alive'  
                                                      AND (FK_ICProductID = {0} OR  FK_ICProductID IS NULL)
                                                      AND FK_PPPhaseCfgID = {1} AND PPResourceID = {2} 
                                                      AND (PPResourceItemID = {3} OR PPResourceItemID IS NULL)  
                                                      AND (PPResourceProductivitys.FK_PPResourceRegimeID = {4} OR PPResourceProductivitys.FK_PPResourceRegimeID IS NULL)
			                                    "
                                                , iICProductID, iPPPhaseCfgID, objPPResourceSynthetic.FK_PPResourceID, objPPResourceSynthetic.FK_PPResourceItemID, objPPResourceSynthetic.FK_PPResourceRegimeID);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }

        public DataSet GetListResourceSynthetic()
        {
            string strQuery = @"    IF OBJECT_ID('tempdb..#Resources') IS NOT NULL
                                        DROP TABLE #Resources;
                                    IF OBJECT_ID('tempdb..#Productivity') IS NOT NULL
                                        DROP TABLE #Productivity;

                                    DELETE dbo.PPResourceSynthetics;
                                    -- Năng suất theo nguồn lực
                                    SELECT PPResources.PPResourceID,
                                           PPResourceItems.PPResourceItemID,
                                           PPResources.PPResourceNo,
                                           PPResources.PPResourceDesc,
                                           PPResources.PPResourceQty,
                                           PPResourceItems.FK_PPPhaseCfgID,
                                           PPResourceItems.FK_PPWorkCenterID,
                                           PPResourceItems.FK_PPResourceToolID,
                                           PPResourceItems.FK_PPResourceRegimeID,
                                           PPResourceItems.FK_PPResourceItemivityUOMID,
                                           PPResourceItems.PPResourceItemSetupQty,
                                           PPResourceItems.PPResourceItemivityQty,
                                           ROUND(ISNULL(PPResourceItems.PPResourceItemivityQty, 0) / PPResources.PPResourceQty, 2) AS OneProcesResourceivityQty,
                                           CASE
                                               WHEN ROUND(ISNULL(PPResourceItems.PPResourceItemivityQty, 0) / PPResources.PPResourceQty, 2) = 0 THEN
                                                   0
                                               ELSE
                                                   ROUND(
                                                            ISNULL(
                                                            (
                                                                SELECT PPResourceUOMSQty
                                                                FROM dbo.PPResourceUOMs
                                                                WHERE AAStatus = 'Alive'
                                                                      AND PPResourceUOMID = PPResourceItems.FK_PPResourceItemivityUOMID
								                                      AND ISNULL(PPResourceUOMSQty,0) > 0
                                                            ),
                                                            0
                                                                  )
                                                            / ROUND(ISNULL(PPResourceItems.PPResourceItemivityQty, 0) / PPResources.PPResourceQty, 2),
                                                            2
                                                        )
                                           END AS OneProductTimeAtOneResource
                                    INTO #Resources
                                    FROM dbo.PPResources
                                        LEFT JOIN dbo.PPResourceItems
                                            ON PPResourceItems.FK_PPResourceID = PPResources.PPResourceID
                                               AND PPResourceItems.AAStatus = 'Alive'
                                    WHERE PPResources.AAStatus = 'Alive'
                                          AND ISNULL(PPResources.PPResourceQty, 0) > 0;
                                    -- Năng suất theo sản phẩm
                                    SELECT PP.FK_PPResourceID
		                                    ,CASE WHEN (PP.FK_ICProductUOMID IS NULL OR PP.FK_ICProductUOMID = 0) THEN IC.FK_ICStkUOMID
			                                      ELSE PP.FK_ICProductUOMID END AS FK_ICProductUOMID
		                                    ,IC.ICProductID AS FK_ICProductID
		                                    ,PP.FK_PPResourceItemID
		                                    ,PP.FK_PPResourceUOMID
		                                    ,PPResourceProductivityQty
		                                    ,CASE WHEN PP.PPResourceProductivityQty > 0 THEN ROUND(ISNULL((SELECT PPResourceUOMSQty 
																	                                    FROM dbo.PPResourceUOMs 
																	                                    WHERE AAStatus = 'Alive' 
																	                                    AND PPResourceUOMID =PP.FK_ICProductUOMID),0)/PP.PPResourceProductivityQty,2)
												                                     ELSE 0 END AS OneProductTime
		                                    ,PP.PPResourceProductivityIOF01Combo
		                                    ,PP.PPResourceProductivityIOF02Combo
		                                    ,PP.PPResourceProductivityIOF03Combo
		                                    ,PP.PPResourceProductivityIOF04Combo
		                                    ,PP.PPResourceProductivityIOF05Combo
		                                    ,PP.PPResourceProductivityIOF06Combo
		                                    ,PP.PPResourceProductivityIOF07Combo
		                                    ,PP.PPResourceProductivityIOF08Combo
		                                    ,PP.PPResourceProductivityIOF09Combo
		                                    ,PP.PPResourceProductivityIOF10Combo 
                                    INTO #Productivity
                                    FROM dbo.PPResourceProductivitys PP
                                    INNER JOIN dbo.ICProducts IC ON (IC.ICProductID = PP.FK_ICProductID 
								                                    OR
								                                    (IC.ICProductIOF01Combo =  PP.PPResourceProductivityIOF01Combo
								                                    AND IC.ICProductIOF02Combo =  PP.PPResourceProductivityIOF02Combo
								                                    AND IC.ICProductIOF03Combo =  PP.PPResourceProductivityIOF03Combo
								                                    AND IC.ICProductIOF04Combo =  PP.PPResourceProductivityIOF04Combo
								                                    AND IC.ICProductIOF05Combo =  PP.PPResourceProductivityIOF05Combo
								                                    AND IC.ICProductIOF06Combo =  PP.PPResourceProductivityIOF06Combo
								                                    AND IC.ICProductIOF07Combo =  PP.PPResourceProductivityIOF07Combo
								                                    AND IC.ICProductIOF08Combo =  PP.PPResourceProductivityIOF08Combo
								                                    AND IC.ICProductIOF09Combo =  PP.PPResourceProductivityIOF09Combo
								                                    AND IC.ICProductIOF10Combo =  PP.PPResourceProductivityIOF10Combo 
                                                                    AND PP.FK_ICProductID = 0)
							                                    )
							                                    AND IC.AAStatus ='Alive'
                                    WHERE PP.AAStatus = 'Alive'
                                    --Tổng hợp năng suất (ResourceSynthetic)
                                    SELECT #Resources.PPResourceID AS FK_PPResourceID,
                                           ISNULL(#Resources.FK_PPPhaseCfgID, 0) AS FK_PPPhaseCfgID,
                                           ISNULL(#Resources.FK_PPWorkCenterID, 0) AS FK_PPWorkCenterID,
                                           #Resources.PPResourceQty AS PPResourceSyntheticQty,
                                           ISNULL(#Resources.FK_PPResourceItemivityUOMID, 0) AS FK_PPResourceUOMID,
                                           #Resources.PPResourceItemSetupQty AS PPResourceSyntheticSetupQty,
                                           #Resources.PPResourceItemivityQty AS PPResourceSyntheticivityQty,
                                           #Resources.OneProcesResourceivityQty AS PPResourceSyntheticOneResourceivityQty,
                                           #Resources.OneProductTimeAtOneResource AS PPResourceSyntheticOneProductInResourceTime,
                                           ISNULL(#Resources.FK_PPResourceToolID, 0) AS FK_PPResourceToolID,
                                           ISNULL(#Resources.FK_PPResourceRegimeID, 0) AS FK_PPResourceRegimeID,
                                           ISNULL(#Productivity.FK_ICProductUOMID,0) AS FK_ICProductUOMID,
                                           ISNULL(#Productivity.FK_ICProductID, 0) AS FK_ICProductID,
                                           ISNULL(#Productivity.FK_PPResourceUOMID, 0) AS FK_ICProductivityUOMID,
                                           #Productivity.PPResourceProductivityQty AS PPResourceSyntheticProductivityQty,
                                           #Productivity.OneProductTime AS PPResourceSyntheticOneProductTime,
                                           #Productivity. PPResourceProductivityIOF01Combo AS PPResourceSyntheticIOF01Combo,
		                                   #Productivity. PPResourceProductivityIOF02Combo AS PPResourceSyntheticIOF02Combo,
		                                   #Productivity. PPResourceProductivityIOF03Combo AS PPResourceSyntheticIOF03Combo,
		                                   #Productivity. PPResourceProductivityIOF04Combo AS PPResourceSyntheticIOF04Combo,
		                                   #Productivity. PPResourceProductivityIOF05Combo AS PPResourceSyntheticIOF05Combo,
		                                   #Productivity. PPResourceProductivityIOF06Combo AS PPResourceSyntheticIOF06Combo,
		                                   #Productivity. PPResourceProductivityIOF07Combo AS PPResourceSyntheticIOF07Combo,
		                                   #Productivity. PPResourceProductivityIOF08Combo AS PPResourceSyntheticIOF08Combo,
		                                   #Productivity. PPResourceProductivityIOF09Combo AS PPResourceSyntheticIOF09Combo,
		                                   #Productivity. PPResourceProductivityIOF10Combo AS PPResourceSyntheticIOF10Combo
                                    FROM #Resources
                                        LEFT JOIN #Productivity
                                            ON #Productivity.FK_PPResourceItemID = #Resources.PPResourceItemID;

                                    IF OBJECT_ID('tempdb..#Resources') IS NOT NULL
                                        DROP TABLE #Resources;
                                    IF OBJECT_ID('tempdb..#Productivity') IS NOT NULL
                                        DROP TABLE #Productivity;";
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetDataByCondition(int iPhaseCfgID = 0, int iWorkCenterID = 0, int iProductID = 0)
        {
            string strQuery = string.Format(@"  SELECT *
                                                FROM dbo.PPResourceSynthetics
                                                WHERE AAStatus = 'Alive'
	                                                AND (FK_PPPhaseCfgID = {0} OR {0}=0)
                                                    AND (FK_PPWorkCenterID = {1} OR {1}=0)
                                                    AND (FK_ICProductID = {2} OR FK_ICProductID = 0 OR {2}=0)
                                             ", iPhaseCfgID,iWorkCenterID,iProductID);
            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}