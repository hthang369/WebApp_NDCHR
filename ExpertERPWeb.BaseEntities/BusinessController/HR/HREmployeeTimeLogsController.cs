using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTimeLogs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HREmployeeTimeLogsController
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HREmployeeTimeLogsController:BaseBusinessController
	{
		public HREmployeeTimeLogsController()
		{
			dal= new DALBaseProvider("HREmployeeTimeLogs",typeof(HREmployeeTimeLogsInfo));
        }

        #region Copy From PS --Vinh --10/01/2013

        public DataSet dsGetDataFromTimeLog(DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            return dal.GetDataSet("AAA_dsTimeLog", dtStartDateTime, dtEndDateTime);
        }
        public DataSet dsGetDataFromTimeLog_MonthYear(int iMonth, int iYear)
        {
            return dal.GetDataSet("AAA_dsTimeLog_WithMonthYear", iMonth, iYear);
        }


        public DataSet GetTimeLogFromEmployeeCardNo(DateTime dtStartDateTime, DateTime dtEndDateTime, string strEmployeeCardNo)
        {
            return dal.GetDataSet("HREmployeeTimeLogs_SelectFromEmployeeCardNoAndTimeSpan", dtStartDateTime, dtEndDateTime, strEmployeeCardNo);
        }

        public DataSet GetTimeLogFromTimeSpan(DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            return dal.GetDataSet("HREmployeeTimeLogs_SelectFromTimeSpan", dtStartDateTime, dtEndDateTime);
        }


        public Boolean IsExistTimeLog(HREmployeeTimeLogsInfo objHREmployeeTimeLogsInfo)
        {

            DataSet ds = dal.GetDataSet("HREmployeeTimeLogs_SelectFromEmployeeCardNoAndDateTime", objHREmployeeTimeLogsInfo.HREmployeeCardNo, objHREmployeeTimeLogsInfo.HREmployeeTimeLogDateTime);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }


        public DataSet dsGetDataFromTimeLog_WithEmployeeNo_MonthYear(string strCardNo, int iMonth, int iYear)
        {
            return dal.GetDataSet("AAA_dsTimeLog_WithEmpCardNo_MonthYear", strCardNo, iMonth, iYear);
        }

        public DataSet dsGetDataFromTimeLog_EmployeeList(DateTime dtStartDateTime, DateTime dtEndDateTime)
        {
            return dal.GetDataSet("AAA_dsTimeLog_EmployeeList", dtStartDateTime, dtEndDateTime);
        }

        #endregion
    }
	#endregion
}