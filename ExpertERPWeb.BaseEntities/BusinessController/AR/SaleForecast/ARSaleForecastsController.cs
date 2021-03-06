using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleForecasts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleForecastsController
	//Created Date:Friday, December 11, 2015
	//-----------------------------------------------------------
	
	public class ARSaleForecastsController:BaseBusinessController
	{
		public ARSaleForecastsController()
		{
			dal= new DALBaseProvider("ARSaleForecasts",typeof(ARSaleForecastsInfo));
		}

        public ARSaleForecastsInfo CheckSaleForecastByYear(int iYear)
        {
            string strQry = string.Format(@"SELECT * FROM dbo.ARSaleForecasts
                                            WHERE AAStatus = 'Alive'
                                            AND ARSaleForecasts.ARSaleForecastYear = {0}", iYear);
            DataSet ds = GetDataSet(strQry);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (ARSaleForecastsInfo)new ARSaleForecastsController().GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }

            return null;
        }

        public int ReturnYearByItemDetail(int iDetailID)
        {
            int iYear = 0;
            string strQry = string.Format(@"SELECT * FROM dbo.ARSaleForecasts, dbo.ARSaleForecastCuss, dbo.ARSaleForecastItems, dbo.ARSaleForecastItemDetails
                                            WHERE ARSaleForecasts.ARSaleForecastID = ARSaleForecastCuss.FK_ARSaleForecastID
                                            AND ARSaleForecastCuss.ARSaleForecastCusID = ARSaleForecastItems.FK_ARSaleForecastCusID
                                            AND ARSaleForecastItems.ARSaleForecastItemID = ARSaleForecastItemDetails.FK_ARSaleForecastItemID
                                            AND ARSaleForecasts.AAStatus = 'Alive'
                                            AND ARSaleForecastCuss.AAStatus = 'Alive'
                                            AND ARSaleForecastItems.AAStatus = 'Alive'
                                            AND ARSaleForecastItemDetails.AAStatus = 'Alive'
                                            AND ARSaleForecastItemDetails.ARSaleForecastItemDetailID = {0}", iDetailID);
            DataSet ds = GetDataSet(strQry);
            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ARSaleForecastsInfo objARSaleForecastsInfo = (ARSaleForecastsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                iYear = objARSaleForecastsInfo.ARSaleForecastYear;
            }

            return iYear;
        }

        public DataSet KtraThangCuaNamCoDuLieu(int iYear, int iMonthOrQuarter, int iCustomerID, string strType)
        {
            string strQry = string.Format(@"SELECT * FROM dbo.ARSaleForecasts, dbo.ARSaleForecastCuss, dbo.ARSaleForecastItems, dbo.ARSaleForecastItemDetails
                                            WHERE ARSaleForecasts.ARSaleForecastID = ARSaleForecastCuss.FK_ARSaleForecastID
                                            AND ARSaleForecastCuss.ARSaleForecastCusID = ARSaleForecastItems.FK_ARSaleForecastCusID
                                            AND ARSaleForecastItems.ARSaleForecastItemID = ARSaleForecastItemDetails.FK_ARSaleForecastItemID
                                            AND ARSaleForecasts.AAStatus = 'Alive'
                                            AND ARSaleForecastCuss.AAStatus = 'Alive'
                                            AND ARSaleForecastItems.AAStatus = 'Alive'
                                            AND ARSaleForecastItemDetails.AAStatus = 'Alive'
											AND ARSaleForecasts.ARSaleForecastYear = {0}
                                            AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeValue = {1}
                                            AND ARSaleForecastCuss.FK_ARCustomerID = {2}
                                            AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeCombo = '{3}'", iYear, iMonthOrQuarter, iCustomerID, strType);

            DataSet ds = GetDataSet(strQry);
            return ds;
        }

        public void DeleteSaleForecastByYear(int iYear, int iMonthOrQuarter, int iCustomerID, string strType)
        {
            string strCondition = "";

            if (strType.Equals("Month"))
                strCondition += string.Format(@"  DELETE  dbo.ARSaleForecastItemDetails
                                                WHERE ARSaleForecastItemDetails.ARSaleForecastItemDetailID IN (SELECT ARSaleForecastItemDetails.ARSaleForecastItemDetailID 
											                                            FROM dbo.ARSaleForecasts, dbo.ARSaleForecastCuss, dbo.ARSaleForecastItems, dbo.ARSaleForecastItemDetails
                                                                                        WHERE ARSaleForecasts.ARSaleForecastID = ARSaleForecastCuss.FK_ARSaleForecastID
                                                                                        AND ARSaleForecastCuss.ARSaleForecastCusID = ARSaleForecastItems.FK_ARSaleForecastCusID
                                                                                        AND ARSaleForecastItems.ARSaleForecastItemID = ARSaleForecastItemDetails.FK_ARSaleForecastItemID
											                                            AND ARSaleForecasts.ARSaleForecastYear = {0}
                                                                                        AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeParentValue = {1}
                                                                                        AND ARSaleForecastCuss.FK_ARCustomerID = {2}
																						AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeCombo = 'Week'
																						AND ARSaleForecastItemDetails.AAStatus = 'Alive')
                                                -- detail month
                                                DELETE  dbo.ARSaleForecastItemDetails
                                                WHERE ARSaleForecastItemDetails.ARSaleForecastItemDetailID IN (SELECT ARSaleForecastItemDetails.ARSaleForecastItemDetailID 
											                                            FROM dbo.ARSaleForecasts, dbo.ARSaleForecastCuss, dbo.ARSaleForecastItems, dbo.ARSaleForecastItemDetails
                                                                                        WHERE ARSaleForecasts.ARSaleForecastID = ARSaleForecastCuss.FK_ARSaleForecastID
                                                                                        AND ARSaleForecastCuss.ARSaleForecastCusID = ARSaleForecastItems.FK_ARSaleForecastCusID
                                                                                        AND ARSaleForecastItems.ARSaleForecastItemID = ARSaleForecastItemDetails.FK_ARSaleForecastItemID
											                                            AND ARSaleForecasts.ARSaleForecastYear = {0}
                                                                                        AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeValue = {1}
                                                                                        AND ARSaleForecastCuss.FK_ARCustomerID = {2}
																						AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeCombo = 'Month'
																						AND ARSaleForecastItemDetails.AAStatus = 'Alive')", iYear, iMonthOrQuarter, iCustomerID);

            if (strType.Equals("Quarter"))
            {
                strCondition += string.Format(@"  DELETE  dbo.ARSaleForecastItemDetails
                                                WHERE ARSaleForecastItemDetails.ARSaleForecastItemDetailID IN (SELECT ARSaleForecastItemDetails.ARSaleForecastItemDetailID 
											                                            FROM dbo.ARSaleForecasts, dbo.ARSaleForecastCuss, dbo.ARSaleForecastItems, dbo.ARSaleForecastItemDetails
                                                                                        WHERE ARSaleForecasts.ARSaleForecastID = ARSaleForecastCuss.FK_ARSaleForecastID
                                                                                        AND ARSaleForecastCuss.ARSaleForecastCusID = ARSaleForecastItems.FK_ARSaleForecastCusID
                                                                                        AND ARSaleForecastItems.ARSaleForecastItemID = ARSaleForecastItemDetails.FK_ARSaleForecastItemID
											                                            AND ARSaleForecasts.ARSaleForecastYear = {0}
                                                                                        AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeParentValue IN (SELECT ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeValue 
																																							        FROM dbo.ARSaleForecastItemDetails 
																																							        WHERE ARSaleForecastItemDetails.AAStatus = 'Alive'
																																							        AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeParentValue = {1}
																																							        AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeCombo = 'Month'
                                                                                                                                                                 )
                                                                                        AND ARSaleForecastCuss.FK_ARCustomerID = {2}
																						AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeCombo = 'Week'
																						AND ARSaleForecastItemDetails.AAStatus = 'Alive')
                                                -- Detail Month
                                                DELETE  dbo.ARSaleForecastItemDetails
                                                WHERE ARSaleForecastItemDetails.ARSaleForecastItemDetailID IN (SELECT ARSaleForecastItemDetails.ARSaleForecastItemDetailID 
											                                            FROM dbo.ARSaleForecasts, dbo.ARSaleForecastCuss, dbo.ARSaleForecastItems, dbo.ARSaleForecastItemDetails
                                                                                        WHERE ARSaleForecasts.ARSaleForecastID = ARSaleForecastCuss.FK_ARSaleForecastID
                                                                                        AND ARSaleForecastCuss.ARSaleForecastCusID = ARSaleForecastItems.FK_ARSaleForecastCusID
                                                                                        AND ARSaleForecastItems.ARSaleForecastItemID = ARSaleForecastItemDetails.FK_ARSaleForecastItemID
											                                            AND ARSaleForecasts.ARSaleForecastYear = {0}
                                                                                        AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeParentValue = {1}
                                                                                        AND ARSaleForecastCuss.FK_ARCustomerID = {2}
																						AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeCombo = 'Month'
																						AND ARSaleForecastItemDetails.AAStatus = 'Alive')
                                                -- Detail Quarter
                                                DELETE  dbo.ARSaleForecastItemDetails
                                                WHERE ARSaleForecastItemDetails.ARSaleForecastItemDetailID IN (SELECT ARSaleForecastItemDetails.ARSaleForecastItemDetailID 
											                                            FROM dbo.ARSaleForecasts, dbo.ARSaleForecastCuss, dbo.ARSaleForecastItems, dbo.ARSaleForecastItemDetails
                                                                                        WHERE ARSaleForecasts.ARSaleForecastID = ARSaleForecastCuss.FK_ARSaleForecastID
                                                                                        AND ARSaleForecastCuss.ARSaleForecastCusID = ARSaleForecastItems.FK_ARSaleForecastCusID
                                                                                        AND ARSaleForecastItems.ARSaleForecastItemID = ARSaleForecastItemDetails.FK_ARSaleForecastItemID
											                                            AND ARSaleForecasts.ARSaleForecastYear = {0}
                                                                                        AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeParentValue = {1}
                                                                                        AND ARSaleForecastCuss.FK_ARCustomerID = {2}
																						AND ARSaleForecastItemDetails.ARSaleForecastItemDetailTypeCombo = 'Quarter'
																						AND ARSaleForecastItemDetails.AAStatus = 'Alive')", iYear, iMonthOrQuarter, iCustomerID);
            }


            string strQry = string.Format(@"{0}", strCondition);
            DataSet ds = GetDataSet(strQry);

        }

        public ARSaleForecastsInfo GetObjAcctive(int iARCustomerID, int iPeriod, int iYear)
        {
            string strQuery = string.Format(@"  SELECT  *
                                                FROM    dbo.ARSaleForecasts
                                                WHERE   AAStatus = 'Alive'
                                                        AND ARSaleForecastActiveCheck = 1
                                                        AND FK_ARCustomerID = {0}
                                                        AND ARSaleForecastPeriod = {1}
                                                        AND ARSaleForecastYear = {2}
                                                ", iARCustomerID, iPeriod, iYear);
            DataSet ds = GetDataSet(strQuery);
            if(ds!=null&&ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0)
            {
                return (ARSaleForecastsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
    }
	#endregion
}