using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPInCompleteStatistics
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPInCompleteStatisticsController
    //Created Date:02 Tháng Mười Hai 2014
    //-----------------------------------------------------------

    public class PPInCompleteStatisticsController : BaseBusinessController
    {
        public PPInCompleteStatisticsController()
        {
            dal = new DALBaseProvider("PPInCompleteStatistics", typeof(PPInCompleteStatisticsInfo));
        }
        public PPInCompleteStatisticsInfo GetAllDataInPeriod(int pPeriod, int pYear, string pModuleName)
        {
            string strQuery = string.Format(@"
                                            SELECT  *
                                            FROM    dbo.PPInCompleteStatistics
                                            WHERE   AAStatus = 'Alive'
                                                    AND MONTH(PPInCompleteStatisticDate) = '{0}'
                                                    AND YEAR(PPInCompleteStatisticDate) = '{1}'
                                                    AND AAModule = '{2}'
                                            ", pPeriod, pYear, pModuleName);
            DataSet ds= GetDataSet(strQuery);
            if(ds!=null)
            {
                if(ds.Tables[0].Rows.Count>0&& ds.Tables[0].Rows[0] !=null)
                {
                    PPInCompleteStatisticsInfo objPPInCompleteStatisticInfo = (PPInCompleteStatisticsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                    return objPPInCompleteStatisticInfo;
                }
            }

            return null;

        }
    }
    #endregion
}