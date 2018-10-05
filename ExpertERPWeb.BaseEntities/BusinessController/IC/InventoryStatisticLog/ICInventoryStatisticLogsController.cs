using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICInventoryStatisticLogs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICInventoryStatisticLogsController
	//Created Date:Thursday, February 23, 2012
	//-----------------------------------------------------------
	
	public class ICInventoryStatisticLogsController:BaseBusinessController
	{
		public ICInventoryStatisticLogsController()
		{
			dal= new DALBaseProvider("ICInventoryStatisticLogs",typeof(ICInventoryStatisticLogsInfo));
		}
        public int GetCountObjectByMonthAndYear(int iMonth, int iYear)
        {
            int result = -1;
            string strQuery = string.Format("select count(*) from ICInventoryStatisticLogs where ICInventoryStatisticLogPeriod={0} AND ICInventoryStatisticLogYear={1}", iMonth, iYear);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                result = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
            return result;
        }
	}
	#endregion
}