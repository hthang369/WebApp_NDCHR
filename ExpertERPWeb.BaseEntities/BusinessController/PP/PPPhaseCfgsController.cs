﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPPhaseCfgs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPPhaseCfgsController
	//Created Date:Tuesday, April 26, 2011
	//-----------------------------------------------------------
	
	public class PPPhaseCfgsController:BaseBusinessController
	{
		public PPPhaseCfgsController()
		{
			dal= new DALBaseProvider("PPPhaseCfgs",typeof(PPPhaseCfgsInfo));
		}
        public DataSet GetPhaseByStockType(int iStockTypeID)
        {
            string strQuery = string.Format(@"select * from PPPhaseCfgs where AAStatus='Alive' AND 
                                                FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive' AND FK_ICStockTypeID={0})
                                                  order by  PPPhaseCfgSortOrder ", iStockTypeID);
            return dal.GetDataSet(strQuery);
        }
        public PPPhaseCfgsInfo GetPhaseCfgBeforeBySortOrder(int iSortOrder)
        {
            String str = String.Format(@"SELECT * FROM PPPhaseCfgs WHERE AAStatus='Alive' AND PPPhaseCfgSortOrder<{0} ORDER BY PPPhaseCfgSortOrder DESC", iSortOrder);
            DataSet ds = dal.GetDataSet(str);
            if (ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                return (PPPhaseCfgsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        /// <summary>
        /// Trung - 15/12/2012 - Lay cong doan cuoi theo Loai Kho
        /// </summary>
        /// <param name="strStockType"></param>
        /// <returns></returns>
        public PPPhaseCfgsInfo GetLastPhaseCfgByStockType(string strStockType)
        {
            string strQuery = string.Format(@"select TOP(1) * from PPPhaseCfgs where AAStatus='Alive' AND 
                                                FK_ICStockID in (Select ICStockID from ICStocks where AAStatus='Alive' AND FK_ICStockTypeID IN (SELECT ICStockTypeID FROM ICStockTypes WHERE AAStatus='Alive' AND ICStockTypeNo='{0}'))
                                                  order by  PPPhaseCfgSortOrder DESC", strStockType);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPPhaseCfgsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        public DataSet GetAllPhase()
        {
            string strQuery = string.Format(@"SELECT * from PPPhaseCfgs where AAStatus='Alive' 
                                                  order by  PPPhaseCfgSortOrder ");
            return dal.GetDataSet(strQuery);
        }

        public PPPhaseCfgsInfo GetPhaseCfgByStockID(int iStockID)
        {
            String str = String.Format(@"SELECT TOP(1) * FROM PPPhaseCfgs WHERE AAStatus='Alive' FK_ICStockID = {0}", iStockID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPPhaseCfgsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public PPPhaseCfgsInfo GetPhaseByMinSortOrder()
        {
            String str = String.Format(@"SELECT Top 1 * FROM PPPhaseCfgs WHERE AAStatus='Alive'  ORDER BY PPPhaseCfgSortOrder");
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPPhaseCfgsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public int GetNextStockByStock(int iStockID)
        {
            String str = String.Format(@"SELECT FK_ICStockID FROM PPPhaseCfgs WHERE AAStatus='Alive' AND PPPhaseCfgSortOrder = (SELECT PPPhaseCfgSortOrder FROM PPPhaseCfgs WHERE AAStatus='Alive' AND FK_ICStockID={0})+1", iStockID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                try
                {
                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                catch (System.Exception ex)
                {

                }
            }
            return 0;
        }

        public int GetPreStockByStock(int iStockID)
        {
            String str = String.Format(@"SELECT FK_ICStockID FROM PPPhaseCfgs WHERE AAStatus='Alive' AND PPPhaseCfgSortOrder = (SELECT PPPhaseCfgSortOrder FROM PPPhaseCfgs WHERE AAStatus='Alive' AND FK_ICStockID={0})-1", iStockID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                try
                {
                    return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                }
                catch (System.Exception ex)
                {

                }
            }
            return 0;
        }

        public PPPhaseCfgsInfo GetPhaseCfgAfterCurrentPhaseCfg(int PhaseCfgID)
        {
            String str = String.Format(@"SELECT Top 1 * FROM PPPhaseCfgs WHERE AAStatus='Alive' AND PPPhaseCfgSortOrder > 
                                                (Select PPPhaseCfgSortOrder from  PPPhaseCfgs where AAStatus='Alive' AND PPPhaseCfgID={0})
                                            ORDER BY PPPhaseCfgSortOrder", PhaseCfgID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (PPPhaseCfgsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
        public DataSet GetAllDataPhase()
        {
            string strQuery = string.Format(@"SELECT PPPhaseCfgID,PPPhaseCfgNo,PPPhaseCfgName from PPPhaseCfgs where AAStatus='Alive' 
                                                  order by  PPPhaseCfgSortOrder ");
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllDataProduct()
        {
            string strQuery = string.Format(@"SELECT ICProductID,ICProductNo,ICProductName from dbo.ICProducts where AAStatus='Alive'  ");
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllDataByICProductID(int iICProductID)
        {
            string strQuery = string.Format(@"  SELECT *
                                                FROM dbo.PPPhaseCfgs
                                                WHERE PPPhaseCfgs.AAStatus = 'Alive'
                                                      AND EXISTS
                                                (
                                                    SELECT 'x'
                                                    FROM dbo.PPRoutingOperations
                                                        INNER JOIN dbo.PPRoutings
                                                            ON PPRoutings.PPRoutingID = PPRoutingOperations.FK_PPRoutingID
                                                               AND PPRoutings.AAStatus = 'Alive'
                                                        INNER JOIN dbo.ICProducts
                                                            ON ICProducts.FK_PPRoutingID = PPRoutings.PPRoutingID
                                                               AND ICProducts.FK_PPRoutingID = PPRoutings.PPRoutingID
                                                               AND ICProducts.AAStatus = 'Alive'
                                                    WHERE PPRoutingOperations.AAStatus = 'Alive'
                                                          AND (
                                                                  ICProducts.ICProductID = {0}
                                                                  OR 0 = {0}
                                                              )
                                                          AND PPPhaseCfgs.PPPhaseCfgID = PPRoutingOperations.FK_PPPhaseCfgID
                                                );", iICProductID);
            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}