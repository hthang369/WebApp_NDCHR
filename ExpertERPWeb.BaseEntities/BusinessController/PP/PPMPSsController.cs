using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPMPSs
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:PPMPSsController
    //Created Date:01 Tháng Tám 2014
    //-----------------------------------------------------------

    public class PPMPSsController : BaseBusinessController
    {
        public PPMPSsController()
        {
            dal = new DALBaseProvider("PPMPSs", typeof(PPMPSsInfo));
        }

        public PPMPSsInfo GetObjectByYearANDPeriod(int iYear, int iPeriod)
        {
            string strQuery = string.Format(@"SELECT * FROM PPMPSs WHERE AAStatus = 'Alive' AND PPMPSYear = {0} AND PPMPSPeriod = {1}", iYear, iPeriod);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPMPSsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            else
                return null;
        }
    }
    #endregion
}