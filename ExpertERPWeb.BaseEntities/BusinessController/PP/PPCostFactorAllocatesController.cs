using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPCostFactorAllocates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPCostFactorAllocatesController
	//Created Date:14 Tháng Mười Một 2014
	//-----------------------------------------------------------
	
	public class PPCostFactorAllocatesController:BaseBusinessController
	{
		public PPCostFactorAllocatesController()
		{
			dal= new DALBaseProvider("PPCostFactorAllocates",typeof(PPCostFactorAllocatesInfo));
		}

        public PPCostFactorAllocatesInfo GetDataByCostCenterANDCostFactor(int iPPCostCenterID, int iPPCostFactorID)
        {
            String str = String.Format(@"SELECT * FROM dbo.PPCostFactorAllocates
                                            WHERE FK_PPCostCenterID = {0}
                                            AND FK_PPCostFactorID = {1}"
                                        , iPPCostCenterID, iPPCostFactorID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPCostFactorAllocatesInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        public DataSet GetAllData_CostFactorAllocate(string strPPCostFactorTypeCombo,int iPPCostCenterID)
        {
            string strQuery = String.Format(@"SELECT * FROM dbo.PPCostFactorAllocates
                                              WHERE FK_PPCostFactorID IS NOT NULL
                                              AND FK_PPCostFactorID IN (
                                                                        SELECT PPCostFactorID  FROM dbo.PPCostFactors 
                                                                        WHERE PPCostFactorTypeCombo='{0}' AND AAStatus='Alive')
                                              AND FK_PPCostCenterID IN (
                                                                         SELECT PPCostCenterID FROM dbo.PPCostCenters
									                                     WHERE PPCostCenterID='{1}' AND AAStatus='Alive')
                                           ", strPPCostFactorTypeCombo, iPPCostCenterID);
            return GetDataSet(strQuery);
        }

        
        public int GetFKFactorIDByCostCenterID(int iPPCostCenterID)
        {
            String str = String.Format(@"SELECT * FROM dbo.PPCostFactorAllocates
                                            WHERE FK_PPCostCenterID = '{0}'"
                                        , iPPCostCenterID);
            DataSet ds = dal.GetDataSet(str);
            int iFK_PPCostFactorID = 0;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                PPCostFactorAllocatesInfo obj = (PPCostFactorAllocatesInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                if (obj != null)
                {
                    iFK_PPCostFactorID = obj.FK_PPCostFactorID;
                }
            }
            return iFK_PPCostFactorID;
        }

        //Lấy tập phí là con có YTCP  của tập phí ps trong kỳ
        public DataSet LayTapConCungYTCPCuaTapPhiTrongKY(int iPPCostCenterID,int iPPCostFactor)
        {
            string strQuery = string.Format(@"
                                            SELECT  *
                                            FROM    dbo.PPCostFactorAllocates
                                            WHERE   FK_PPCostCenterID IN ( SELECT   FK_PPCostCenterID
                                                                            FROM     dbo.PPCostCenterChilds
                                                                            WHERE    FK_PPCostCenterParentID = '{0}'
                                                                                    AND AAStatus = 'Alive' )
                                                    AND FK_PPCostFactorID = '{1}'
            ", iPPCostCenterID, iPPCostFactor);
            return GetDataSet(strQuery);
        }
       public DataSet GetAllChildByCostCenterParentAndFactorID(int iPPCostCenterParentID,int iPPCostFactorID)
        {
            string strQuery = string.Format(@"
                                            SELECT  *
                                            FROM    dbo.PPCostFactorAllocates
                                            WHERE   FK_PPCostCenterID IN ( SELECT   FK_PPCostCenterID
                                                                           FROM     dbo.PPCostCenterChilds
                                                                           WHERE    FK_PPCostCenterParentID = '{0}' )
                                                    AND FK_PPCostFactorID = ( SELECT    PPCostFactorID
                                                                              FROM      dbo.PPCostFactors
                                                                              WHERE     PPCostFactorID = '{1}'
                                                                            )
                                            ", iPPCostCenterParentID, iPPCostFactorID);
            return GetDataSet(strQuery);
        }

        public DataSet GetAllDataByCostCenter(int pPPCostCenterID)
        {
            String str = String.Format(@"SELECT * FROM dbo.PPCostFactorAllocates
                                            WHERE FK_PPCostCenterID = {0}"
                                        , pPPCostCenterID);
            return dal.GetDataSet(str);
        }


    }
    #endregion
}