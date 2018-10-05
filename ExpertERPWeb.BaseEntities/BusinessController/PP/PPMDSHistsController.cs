using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPMDSHists
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPMDSHistsController
    //Created Date:01 Tháng Tám 2014
    //-----------------------------------------------------------

    public class PPMDSHistsController : BaseBusinessController
    {
        public PPMDSHistsController()
        {
            dal = new DALBaseProvider("PPMDSHists", typeof(PPMDSHistsInfo));
        }
        public PPMDSHistsInfo GetLastObject()
        {
            string strQuery = string.Format(@"Select top 1 * from PPMDSHists where AAStatus='Alive' order by PPMDSHistID Desc");
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPMDSHistsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }

        public PPMDSHistsInfo GetPreLastMDSHist()
        {
            string strQuery = string.Format(@"SELECT TOP 1
                                                        *
                                                FROM    ( SELECT TOP 2
                                                                    *
                                                          FROM      PPMDSHists
                                                          WHERE     AAStatus = 'Alive'
                                                          ORDER BY  PPMDSHistID DESC
                                                        ) AS dfd
                                                ORDER BY PPMDSHistID");
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPMDSHistsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
    }
    #endregion
}