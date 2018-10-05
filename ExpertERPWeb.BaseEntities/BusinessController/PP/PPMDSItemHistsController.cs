using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPMDSItemHists
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPMDSItemHistsController
    //Created Date:01 Tháng Tám 2014
    //-----------------------------------------------------------

    public class PPMDSItemHistsController : BaseBusinessController
    {
        public PPMDSItemHistsController()
        {
            dal = new DALBaseProvider("PPMDSItemHists", typeof(PPMDSItemHistsInfo));
        }
        public DataSet GetAllDataByMDSHistProductInRange(int iPPMDSHistID, int FK_ICProductID, DateTime dteFromDate, DateTime dteToDate)
        {
            string strQueryDate = DALUtil.GenerateBeetween("PPMDSItemHistETDDate", dteFromDate, dteToDate);
            string strQuery = string.Format(@"Select * from PPMDSItemHists where AAStatus='Alive' AND (FK_PPMDSHistID={0} or {0}=0)
                                                AND (FK_ICProductID={1} or {1}=0) AND {2}
                                                    ", iPPMDSHistID, FK_ICProductID, strQueryDate);
            return dal.GetDataSet(strQuery);
        }
    }
    #endregion
}