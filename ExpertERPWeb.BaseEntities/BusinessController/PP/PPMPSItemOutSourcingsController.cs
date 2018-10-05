using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPMPSItemOutSourcings
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:PPMPSItemOutSourcingsController
    //Created Date:21 Tháng Tám 2014
    //-----------------------------------------------------------

    public class PPMPSItemOutSourcingsController : BaseBusinessController
    {
        public PPMPSItemOutSourcingsController()
        {
            dal = new DALBaseProvider("PPMPSItemOutSourcings", typeof(PPMPSItemOutSourcingsInfo));
        }
        public DataSet GetAllDataByMPSProductInRange(int FK_ICProductID, DateTime dteFromDate, DateTime dteToDate)
        {
            string strQueryDate = DALUtil.GenerateBeetween("PPMPSItemOutSourcingFODate", dteFromDate, dteToDate);
            string strQuery = string.Format(@"Select * from PPMPSItemOutSourcings where AAStatus='Alive'
                                                AND (FK_ICProductID={0} or {0}=0) AND {1}
                                                    ", FK_ICProductID, strQueryDate);
            return dal.GetDataSet(strQuery);
        }
        public double GetQtyByMPSProductInRange(int FK_ICProductID, DateTime dteFromDate, DateTime dteToDate)
        {
            string strQueryDate = DALUtil.GenerateBeetween("PPMPSItemOutSourcingFODate", dteFromDate, dteToDate);
            string strQuery = string.Format(@"Select SUM(PPMPSItemOutSourcingQty) from PPMPSItemOutSourcings where AAStatus='Alive'
                                                AND (FK_ICProductID={0} or {0}=0) AND {1}
                                                    ", FK_ICProductID, strQueryDate);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0
                && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToDouble(ds.Tables[0].Rows[0][0]);
            return 0;
        }
    }
    #endregion
}