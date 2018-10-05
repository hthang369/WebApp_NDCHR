using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
    #region BRPOSs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:BRPOSsController
    //Created Date:Monday, June 02, 2008
    //-----------------------------------------------------------

    public class BRPOSsController : BaseBusinessController
    {
        public BRPOSsController()
        {
            dal = new DALBaseProvider("BRPOSs", typeof(BRPOSsInfo));
        }
        public DataSet GetAllBRPOSByFK_BRBranchIDAndFromDateToDate(int iBRBranchID, DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Format("SELECT * FROM BRPOSs WHERE [FK_BRBranchID]={0} AND CONVERT(VARCHAR(10), [BRPOSDate], 112)>= CONVERT(VARCHAR(10), '{1}', 112) AND CONVERT(VARCHAR(10), [BRPOSDate], 112)<= CONVERT(VARCHAR(10), '{2}', 112) AND [AAStatus]='{3}'", iBRBranchID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"), BusinessObject.DefaultAAStatus);
            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllBRPOSByFK_BRBranchIDAndFromDateToDateAndShift(int iBRBranchID,int iBRPOSShiftID, DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Format("SELECT * FROM BRPOSs WHERE [FK_BRBranchID]={0} AND CONVERT(VARCHAR(10), [BRPOSDate], 112)>= CONVERT(VARCHAR(10), '{1}', 112) AND CONVERT(VARCHAR(10), [BRPOSDate], 112)<= CONVERT(VARCHAR(10), '{2}', 112) AND FK_BRPOSShiftID = '{3}' AND [AAStatus]='{4}'", iBRBranchID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"),iBRPOSShiftID,  BusinessObject.DefaultAAStatus);
            return dal.GetDataSet(strQuery);
        }
    }
    #endregion
}