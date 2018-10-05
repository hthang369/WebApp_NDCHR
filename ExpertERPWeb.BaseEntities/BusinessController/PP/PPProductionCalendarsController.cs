using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCalendars
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionCalendarsController
	//Created Date:22 Tháng Tám 2014
	//-----------------------------------------------------------
	
	public class PPProductionCalendarsController:BaseBusinessController
	{
		public PPProductionCalendarsController()
		{
			dal= new DALBaseProvider("PPProductionCalendars",typeof(PPProductionCalendarsInfo));
		}
        public PPProductionCalendarsInfo GetObjectByProductFODatePhaseWorkCenter(int iProductID, DateTime dteFODate, int iPhaseCfgID, int iWorkCenterID)
        {
            string strQueryDate=DALUtil.GennerateCondition("PPProductionCalendarFODate",CompareType.Equal,dteFODate);
            string strQuery = string.Format(@"select * from PPProductionCalendars where AAStatus='Alive' AND FK_ICProductID={0}
                                                AND FK_PPPhaseCfgID={1} AND FK_PPWorkCenterID={2} AND {3}", iProductID, iPhaseCfgID, iWorkCenterID, strQueryDate);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPProductionCalendarsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
        public DataSet GetAllObjectExistQty()
        {
            string strQuery = string.Format(@"Select (PPProductionCalendarQty-PPProductionCalendarFGQty) as PPProductionCalendarQty,* from PPProductionCalendars where AAStatus='Alive' AND (PPProductionCalendarQty-PPProductionCalendarFGQty)>0");
            return dal.GetDataSet(strQuery);
        }
        public double GetSUMQtyByProductPhaseWorkCenterInRange(int iProductID, int iPhaseCfgID, int iWorkCenterID, DateTime dteFromdate, DateTime dteTodate)
        {
            string strQueryDate = DALUtil.GenerateBeetween("PPProductionCalendarFODate", dteFromdate, dteTodate);
            string strQuery = string.Format(@"Select SUM(PPProductionCalendarQty - PPProductionCalendarFGQty) from PPProductionCalendars where AAStatus='Alive' AND FK_ICProductID={0}
                                                                    AND FK_PPPhaseCfgID= {1} AND FK_PPWorkCenterID={2} AND {3}"
                                                                    , iProductID, iPhaseCfgID, iWorkCenterID, strQueryDate);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
        public DataSet GetAllObjectByFODate(DateTime dteFODate)
        {
            string strQueryDate = DALUtil.GennerateCondition("PPProductionCalendarFODate", CompareType.Equal, dteFODate);
            string strQuery = string.Format(@"select * from PPProductionCalendars where AAStatus='Alive' AND {0}", strQueryDate);
            return dal.GetDataSet(strQuery);
        }

        //NhamNDH -06/12/2016- lấy danh sách theo CalendarDate
        public DataSet GetAllObjectByCalendarDate(DateTime dteCalendarDate)
        {
            string strQueryDate = DALUtil.GennerateCondition("PPProductionCalendarDate", CompareType.Equal, dteCalendarDate);
            string strQuery = string.Format(@"select * from PPProductionCalendars where AAStatus='Alive' AND {0}", strQueryDate);
            return dal.GetDataSet(strQuery);
        }

        #region 

        public double GetAllDataByRoutingANDProductANDPhaseCfgANDWorkCenter(int iPPRoutingID, int iICProductID, int iPPPhaseCfgID, int iPPWorkCenterID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT SUM(PPProductionCalendarQty) FROM dbo.PPProductionCalendars
                                            WHERE AAStatus = 'Alive'
                                            AND FK_PPRoutingID = {0}
                                            AND FK_ICProductID = {1}
                                            AND FK_PPPhaseCfgID = {2}
                                            AND FK_PPWorkCenterID = {3}
                                            AND CONVERT(VARCHAR, PPProductionCalendarFODate, 112) >= '{4}'
                                            AND CONVERT(VARCHAR, PPProductionCalendarFODate, 112) <= '{5}'"
                                        , iPPRoutingID, iICProductID, iPPPhaseCfgID, iPPWorkCenterID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if(ds!=null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }
		 
	    #endregion
        // NhamNDH add -25/11/2016- Move Lịch sản xuất từ CHF
        public double GetCalendarQtyByProductANDdate(int iICProductID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT SUM(PPProductionCalendarQty) FROM dbo.PPProductionCalendars
                                            WHERE AAStatus = 'Alive'
                                            AND FK_ICProductID = {0}
                                            AND CONVERT(VARCHAR, PPProductionCalendarFODate, 112) >= '{1}'
                                            AND CONVERT(VARCHAR, PPProductionCalendarFODate, 112) <= '{2}'"
                                        , iICProductID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }
        // NhamNDH add -09/12/2016- lấy số lượng đã lên lịch của SO
        public double GetCalendarQtyByProductANDWOANDPhaseCfgANDdateSO(int iARSOItemID, int iICProductID, int iPPWOID, int iPPPhaseCfgID, int iARShpPlanItemID)
        {
            String str = String.Format(@"   SELECT SUM(PPProductionCalendarQty) FROM dbo.PPProductionCalendars
                                            WHERE AAStatus = 'Alive'
                                            AND FK_ICProductID = {0}
                                            AND FK_PPWOID = {1}
                                            AND FK_PPPhaseCfgID = {2}
                                            AND FK_ARSOItemID = {3}
                                            AND FK_ARShpPlanItemID = '{4}'"
                                        , iICProductID, iPPWOID, iPPPhaseCfgID, iARSOItemID, iARShpPlanItemID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }
        // NhamNDH add -25/11/2016- Move Lịch sản xuất từ CHF
        public double GetCalendarQtyByProductANDWOANDPhaseCfgANDdate(int iICProductID, int iPPWOID, int iPPPhaseCfgID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT SUM(PPProductionCalendarQty) FROM dbo.PPProductionCalendars
                                            WHERE AAStatus = 'Alive'
                                            AND FK_ICProductID = {0}
                                            AND FK_PPWOID = {1}
                                            AND FK_PPPhaseCfgID = {2}
                                            AND CONVERT(VARCHAR, PPProductionCalendarDate, 112) >= '{3}'
                                            AND CONVERT(VARCHAR, PPProductionCalendarDate, 112) <= '{4}'"
                                        , iICProductID, iPPWOID, iPPPhaseCfgID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }
        // NhamNDH add -28/11/2016- Move Phiếu sản xuất từ CHF
        public double GetAllDataByRoutingANDProductANDPhaseCfgANDWorkCenterANDPPWO(int iPPRoutingID, int iICProductID, int iPPPhaseCfgID, int iPPWorkCenterID, int iPPWOID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT SUM(PPProductionCalendarQty) FROM dbo.PPProductionCalendars
                                            WHERE AAStatus = 'Alive'
                                            --AND FK_PPRoutingID = {0}
                                            AND FK_ICProductID = {1}
                                            AND (FK_PPPhaseCfgID = {2} OR {2} = 0)
                                            AND (FK_PPWorkCenterID = {3} OR {3} = 0)
                                            AND FK_PPWOID = {4} 
                                            AND CONVERT(VARCHAR, PPProductionCalendarFODate, 112) >= '{5}'
                                            AND CONVERT(VARCHAR, PPProductionCalendarFODate, 112) <= '{6}'"
                                        , iPPRoutingID, iICProductID, iPPPhaseCfgID, iPPWorkCenterID, iPPWOID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }
        //
        // NhamNDH add -08/12/2016- lấy số lượng đã lênh lịch theo SO
        public double GetAllDataByRoutingANDProductANDPhaseCfgANDWorkCenterANDPPWOSO(int iARSOItemID, int iPPRoutingID, int iICProductID, int iPPPhaseCfgID, int iPPWorkCenterID, int iPPWOID, int iARShpPlanItemID)
        {
            String str = String.Format(@"   SELECT SUM(PPProductionCalendarQty) FROM dbo.PPProductionCalendars
                                            WHERE AAStatus = 'Alive'
                                            AND FK_PPRoutingID = {0}
                                            AND FK_ICProductID = {1}
                                            AND (FK_PPPhaseCfgID = {2} OR {2} = 0)
                                            AND (FK_PPWorkCenterID = {3} OR {3} = 0)
                                            AND FK_PPWOID = {4} 
                                            AND FK_ARSOItemID = {6}
                                            AND FK_ARShpPlanItemID = '{5}'"
                                        , iPPRoutingID, iICProductID, iPPPhaseCfgID, iPPWorkCenterID, iPPWOID, iARShpPlanItemID, iARSOItemID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            }

            return 0;
        }
        //NhamNDH add -13/12/2016- Lấy danh sánh Calendar theo SO (ARSOItem, ARShpPlanItem)
        public DataSet GetAllObjectsBySO(int iARSOItemID, int iICProductID, int iWOID, int iARShpPlanItemID)
        {
            string strQuery = string.Format(@"   SELECT *
                                                 FROM dbo.PPProductionCalendars
                                                 WHERE AAStatus = 'Alive'
	                                                   AND FK_PPWOID = {0} AND FK_ICProductID = {1}
	                                                   AND FK_ARSOItemID = {2} AND FK_ARShpPlanItemID = {3}"
                                              ,iWOID,iICProductID,iARSOItemID,iARShpPlanItemID);
            return dal.GetDataSet(strQuery);
        }

	}
	#endregion
}