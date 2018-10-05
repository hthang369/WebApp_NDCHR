using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;

namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTCSrlOffWorks
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTCSrlOffWorksController
	//Created Date:Monday, June 16, 2014
	//-----------------------------------------------------------
	
	public class HREmployeeTCSrlOffWorksController:BaseBusinessController
	{
		public HREmployeeTCSrlOffWorksController()
		{
			dal= new DALBaseProvider("HREmployeeTCSrlOffWorks",typeof(HREmployeeTCSrlOffWorksInfo));
		}

        public void XoaChiTietNgayNghi(int iHREmployeeID, DateTime dtDayFirstMonth)
        {
            string strQry = string.Format(@"DELETE dbo.HREmployeeTCSrlOffWorks
                                          WHERE FK_HREmployeeID = {0} 
                                          AND YEAR(HREmployeeTCSrlOffWorkDate) = {1}
                                          AND MONTH(HREmployeeTCSrlOffWorkDate) = {2}",
                                          iHREmployeeID, dtDayFirstMonth.Year, dtDayFirstMonth.Month);
            dal.GetDataSet(strQry);
        }

        public DataSet LayThongTinNghiViecCuaNhanVien(int iHREmployeeID, DateTime dtFrom,DateTime dtTo)
        {
            String str = String.Format(@"   SELECT * FROM dbo.HREmployeeTCSrlOffWorks
                                            WHERE AAStatus='Alive'
                                            AND (FK_HREmployeeID = {0} OR {0} = 0)
                                            AND CONVERT(NVARCHAR(10),HREmployeeTCSrlOffWorkDate, 112) >= '{1}'
                                            AND CONVERT(NVARCHAR(10),HREmployeeTCSrlOffWorkDate, 112) <= '{2}'", iHREmployeeID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        public DataSet LayThongTinNghiPhepTheoLoai(int iHREmployeeID, DateTime dtFrom, DateTime dtTo, String strTCSrlOffWorkTypeCombo)
        {
            String str = String.Format(@"   SELECT * FROM dbo.HREmployeeTCSrlOffWorks
                                            WHERE AAStatus='Alive'
                                            AND (FK_HREmployeeID = {0} OR {0} = 0)
                                            AND CONVERT(NVARCHAR(10),HREmployeeTCSrlOffWorkDate, 112) >= '{1}'
                                            AND CONVERT(NVARCHAR(10),HREmployeeTCSrlOffWorkDate, 112) <= '{2}'
                                            AND HREmployeeTCSrlOffWorkTypeCombo='{3}'",
                                           iHREmployeeID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"),strTCSrlOffWorkTypeCombo);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}