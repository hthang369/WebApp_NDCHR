using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPResources
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPResourcesController
	//Created Date:18 Tháng Sáu 2013
	//-----------------------------------------------------------
	
	public class PPResourcesController:BaseBusinessController
	{
		public PPResourcesController()
		{
			dal= new DALBaseProvider("PPResources",typeof(PPResourcesInfo));
		}
        public DataSet GetAllDataByRoutingAndPhaseCfg(int iRoutingID,int iPPPhaseCfgID)
        {
            string strQuery = string.Format(@"Select * from PPResources where AAStatus='Alive' AND PPResourceID in 
                                               (select FK_PPResourceID from PPRoutingOperationResources where AAStatus='Alive' AND FK_PPRoutingID={0}
                                                    AND FK_PPRoutingOperationID in (select PPRoutingOperationID from PPRoutingOperations where AAStatus='Alive'
                                                                                        AND FK_PPRoutingID={0} AND FK_PPPhaseCfgID={1})
                                               )
                                                 ", iRoutingID, iPPPhaseCfgID);
            return dal.GetDataSet(strQuery);
        }

        /// <summary>
        /// Viet Nguyen 2013.08.27
        /// </summary>
        public DataSet GetAllResourceByType(string strResourceType)
        {
            string strQuery = string.Format(@"Select * from PPResources where AAStatus='Alive' AND PPResourceTypeCombo='{0}'", strResourceType);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllResourceByResourceProductivityID(int iResourceProductivityID)
        {
            string strQuery = string.Format(@"  SELECT *
                                                FROM dbo.PPResources INNER JOIN dbo.PPResourceProductivitys ON dbo.PPResources.PPResourceID = dbo.PPResourceProductivitys.FK_PPResourceID
                                                WHERE PPResources.AAStatus = 'Alive'
                                                      AND PPResourceProductivitys.AAStatus = 'Alive'
                                                      AND PPResourceProductivitys.FK_PPResourceID = {0}", iResourceProductivityID);
            return dal.GetDataSet(strQuery);
        }
        // NhamNDH add -25/11/2016- Move Lịch sản xuất từ CHF
        public DataSet GetAllResourceByProductAndPhaseCfgID(int iICProductID, int iPPPhaseCfgID)
        {
            string strQuery = string.Format(@"
            SELECT  PPResources.PPResourceID ,
                    PPResources.PPResourceNo ,
                    PPResources.PPResourceDesc ,
                    PPResources.PPResourceTypeCombo ,
                    PPResources.PPResourceQty ,
                    PPResources.FK_PPPhaseCfgID ,
                    PPResources.FK_PPResourceGroupID ,
                    PPResources.PPResourceEfficiencyPercentage,
                    PPResourceProductivitys.PPResourceProductivityQty AS PPResourceProductivityQty ,
                    PPResources.PPResourceProcessQty,
                    CAST(PPResourceProductivitys.PPResourceProductivityQty * PPResources.PPResourceProcessQty *(PPResources.PPResourceEfficiencyPercentage/100) * PPResources.PPResourceQty AS FLOAT) AS PPResourceCapacityQty
            FROM    dbo.PPResources
                    INNER JOIN dbo.PPResourceProductivitys ON ( PPResourceProductivitys.FK_PPResourceID = PPResources.PPResourceID
                                                                AND PPResourceProductivitys.AAStatus = PPResources.AAStatus
                                                                AND PPResourceProductivitys.AAStatus = 'Alive'
                                                                AND PPResourceProductivitys.FK_ICProductID = {0}
                                                              )
            WHERE   PPResources.FK_PPPhaseCfgID = {1}
            ", iICProductID, iPPPhaseCfgID);
            return dal.GetDataSet(strQuery);
        }
        // NhamNDH add -23/12/2016- lấy số lượng nguồn lực có thể cung ứng sản xuất theo sản phẩm, công đoạn
        public double GetSumQtyByProductAndPhaseCfg(int iPPPhaseCfgID, int iICProductID)
        {
            string strQuery = string.Format(@"
            SELECT  
                    SUM(CAST(PPResourceProductivitys.PPResourceProductivityQty * PPResources.PPResourceProcessQty * (PPResources.PPResourceEfficiencyPercentage/100) * PPResources.PPResourceQty AS FLOAT)) AS PPResourceCapacityQty
            FROM    dbo.PPResources
                    INNER JOIN dbo.PPResourceProductivitys ON ( PPResourceProductivitys.FK_PPResourceID = PPResources.PPResourceID
                                                                AND PPResourceProductivitys.AAStatus = PPResources.AAStatus
                                                                AND PPResourceProductivitys.AAStatus = 'Alive'
                                                                AND PPResourceProductivitys.FK_ICProductID = {0}
                                                              )
            WHERE   PPResources.FK_PPPhaseCfgID = {1}
            ", iICProductID, iPPPhaseCfgID);
             DataSet ds = dal.GetDataSet(strQuery);
             if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
             {
                 return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
             }
             return 0;
        }
        // NhamNDH add -10/01/2017- Lấy danh sách nguồn lực Search theo Phân xưởng và công đoạn
        public DataSet GetDataSearchByWorkCenterAndPhaseCfg(int iWorkCenterID, int iPhaseCfg)
        {
            string strQuery = string.Format(@"  SELECT *
                                                FROM dbo.PPResources
                                                WHERE AAStatus = 'Alive' AND (FK_PPWorkCenterID = {0} OR {0}=0)
	                                                  AND (FK_PPPhaseCfgID = {1} OR {1}=0)"
                                            , iWorkCenterID, iPhaseCfg);
            return dal.GetDataSet(strQuery);
        }
        // NhamNDH add -10/01/2017- Kiểm tra mã số đã tồn tại
        public bool CheckResourceNo(PPResourcesInfo objPPResourceInfo)
        {
            string strQuery = string.Format(@"  SELECT *
                                                FROM dbo.PPResources
                                                WHERE AAStatus = 'Alive' AND PPResourceNo = N'{0}'
	                                                  AND PPResourceID != {1}"
                                            , objPPResourceInfo.PPResourceNo, objPPResourceInfo.PPResourceID);
            DataSet ds = GetDataSet(strQuery);
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
    }
	#endregion
}