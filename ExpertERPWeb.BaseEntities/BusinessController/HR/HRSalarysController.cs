using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRSalarys
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET ? H??? £i?? (v2.0.58)
    //Class: HRSalarysController
    //Created Date: Monday, 27 Nov 2017
    //-----------------------------------------------------------

    public class HRSalarysController : BaseBusinessController
    {
        public HRSalarysController()
        {
            dal = new DALBaseProvider("HRSalarys", typeof(HRSalarysInfo));
        }
        public DataSet GetAllDataByPeriodAndYear(int iPeriod, int iYear)
        {
            string strQuery = string.Format(@"SELECT *
                                            FROM    HRSalarys
                                            WHERE HRSalaryPeriod = {0}
                                                    AND HRSalaryYear = {1}
                                                    AND HRSalaryEmployeeNo = (SELECT TOP 1
                                                                                        HRSalaryEmployeeNo
                                                                               FROM     HRSalarys
                                                                               WHERE HRSalaryPeriod = {0}
                                                                                        AND HRSalaryYear = {1}
                                                                             )", iPeriod, iYear);
            return dal.GetDataSet(strQuery);
            // return GetAllDataByColumns(new string[] { "HRSalaryMonth", "HRSalaryYear" }, iMonth, iYear);
        }
        public DataSet GetDataSalaryByPeriodAndYear(int iPeriod, int iYear, string sEmployeeNo, string sDepartmentName, string sSectionName)
        {
            return SqlDatabaseHelper.RunStoredProcedure("spl_GetDataSalaryByPeriodAndYear", iPeriod, iYear, sEmployeeNo, sDepartmentName, sSectionName);
        }
        public DataSet DeleteDataSalaryByPeriodAndYear(int iPeriod, int iYear, string sEmployeeNo, string sDepartmentName, string sSectionName)
        {
            return SqlDatabaseHelper.RunStoredProcedure("spl_DeleteDataSalaryByPeriodAndYear", iPeriod, iYear, sEmployeeNo, sDepartmentName, sSectionName);
        }
        public bool CheckExistDataByByPeriodAndYear(int iPeriod, int iYear)
        {
            string strQuery = string.Format(@"SELECT COUNT(HRSalaryID)
                                            FROM dbo.HRSalarys
                                            WHERE HRSalaryPeriod={0}
                                            AND HRSalaryYear={1}", iPeriod, iYear);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public DataSet GetAllAmtByPeriodYearAndColName(int iYear,int iPeriod,string strColName)
        {
            try
            {
                string str = string.Format(@"
                                SELECT HRSalaryEmployeeNo,SUM(CONVERT(FLOAT,ISNULL(HRSalaryValue,'0'))) HRSalaryValue
                                FROM
                                dbo.HRSalarys
                                WHERE HRSalaryYear ={0}
                                            AND HRSalaryPeriod<={1}
                                            AND HRSalaryColName = '{2}'
                                GROUP BY HRSalaryEmployeeNo", iYear, iPeriod, strColName);
                return dal.GetDataSet(str);
            }
            catch
            {
                return null;
            }
        }

    }
	#endregion
}