using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PRSalarys
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PRSalarysController
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class PRSalarysController:BaseBusinessController
	{
		public PRSalarysController()
		{
			dal= new DALBaseProvider("PRSalarys",typeof(PRSalarysInfo));
        }

        public void XoaTinhLuong(int iHREmployeeID, DateTime dtFrom, DateTime dtTo)
        {
            string strQry = string.Format(@"DELETE dbo.PRSalarys
                                            WHERE FK_HREmployeeID={0} 
                                            AND CONVERT(VARCHAR,PRSalaryFromDate, 112) >= '{1}'
                                            AND CONVERT(VARCHAR,PRSalaryToDate, 112) <= '{2}'",
                                          iHREmployeeID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            dal.GetDataSet(strQry);
        }

        #region Copy From PS --Vinh --10/01/2013

        public PRSalarysInfo GetObjectByEmployeeIDAndExtractTimeSpan(int iEmployeeID, DateTime dStartDate, DateTime dEndDate)
        {
            DataSet ds = dal.GetDataSet("PRSalarys_SelectByFK_HREmployeeIDAndExtractTimeSpan", iEmployeeID, dStartDate.Date, dEndDate.Date);
            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
                return null;
            else
                return (PRSalarysInfo)this.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
        }
        public Boolean CheckSalaryByMonthANDYear(DateTime dt)
        {
            String str = String.Format(@"SELECT * FROM PRSalarys WHERE AAStatus='Alive' AND Year(PRSalaryFromDatetime)={0} AND MONTH(PRSalaryFromDatetime)={1}", dt.Year, dt.Month);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Lấy tất cả bảng lương trong năm --Vinh

        public DataSet GetAllSalaryByYear(int iYear)
        {
            String str = String.Format(@"SELECT * FROM PRSalarys WHERE AAStatus='Alive' AND Year(PRSalaryFromDatetime)={0}", iYear);
            return dal.GetDataSet(str);

        }

        #endregion

        #region Lấy tất cả chi tiết lương của nhân viên theo SlrID và nhân viên --Vinh

        public DataSet GetSalaryBySlrANDEmployee(int iSlrID, int iEmployeeID)
        {
            String str = String.Format(@"   SELECT * FROM PRSalarys 
                                            WHERE AAStatus='Alive'
                                            AND FK_PRSlrID IN (SELECT PRSlrID FROM dbo.PRSlrs WHERE AAStatus='Alive' AND PRSlrID = {0})
                                            AND FK_HREmployeeID = {1}", iSlrID, iEmployeeID);
            return dal.GetDataSet(str);

        }

        #endregion

        #region Lấy tất cả chi tiết lương của nhân viên theo SlrID và nhân viên --Vinh -- 2013.11.11

        public DataSet GetSalaryByEmployeeANDDate(int iHREmployeeID, int iYearFrom, int iPeriodFrom, int iYearTo, int iPeriodTo)
        {
            String str = String.Format(@"   SELECT * FROM PRSalarys 
                                            WHERE AAStatus='Alive'
                                            AND FK_HREmployeeID = {0}
                                            AND FK_PRSlrID IN (
                                                                    SELECT PRSlrID FROM dbo.PRSlrs 
                                                                    WHERE AAStatus='Alive'
                                                                    AND PRSlrYear * 12 + PRSlrPeriod >= {1}
                                                                    AND PRSlrYear * 12 + PRSlrPeriod <= {2}
                                                                )
                                            ORDER BY PRSalaryFromDatetime ASC
                                           ", iHREmployeeID, iYearFrom * 12 + iPeriodFrom, iYearTo * 12 + iPeriodTo);
            return dal.GetDataSet(str);

        }

        #endregion
    }
	#endregion
}