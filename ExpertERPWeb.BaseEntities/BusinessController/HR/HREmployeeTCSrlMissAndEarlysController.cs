using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTCSrlMissAndEarlys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTCSrlMissAndEarlysController
	//Created Date:Monday, June 16, 2014
	//-----------------------------------------------------------
	
	public class HREmployeeTCSrlMissAndEarlysController:BaseBusinessController
	{
		public HREmployeeTCSrlMissAndEarlysController()
		{
			dal= new DALBaseProvider("HREmployeeTCSrlMissAndEarlys",typeof(HREmployeeTCSrlMissAndEarlysInfo));
		}

        public void XoaChiTietVaoTreRaSom(int iHREmployeeID, DateTime dtDayFirstMonth)
        {
            string strQry = string.Format(@"DELETE dbo.HREmployeeTCSrlMissAndEarlys
                                          WHERE FK_HREmployeeID = {0} 
                                          AND YEAR(HREmployeeTCSrlMissAndEarlyDate) = {1}
                                          AND MONTH(HREmployeeTCSrlMissAndEarlyDate) = {2}",
                                          iHREmployeeID, dtDayFirstMonth.Year, dtDayFirstMonth.Month);
            dal.GetDataSet(strQry);
        }

        public DataSet LayChiTietVaoTreRaSom(int iHREmployeeID, DateTime dtFrom, DateTime dtTo, String strTypeCombo)
        {
            string strQry = string.Format(@"  SELECT * FROM dbo.HREmployeeTCSrlMissAndEarlys
                                              WHERE FK_HREmployeeID = {0} 
                                              AND CONVERT(NVARCHAR(10),HREmployeeTCSrlMissAndEarlyDate, 112) >= '{1}'
                                              AND CONVERT(NVARCHAR(10),HREmployeeTCSrlMissAndEarlyDate, 112) <= '{2}'
                                              AND HREmployeeTCSrlMissAndEarlyTypeCombo LIKE '{3}'",
                                              iHREmployeeID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"), strTypeCombo);
            return dal.GetDataSet(strQry);
        }
	}
	#endregion
}