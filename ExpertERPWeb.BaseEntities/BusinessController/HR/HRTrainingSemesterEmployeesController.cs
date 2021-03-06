using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRTrainingSemesterEmployees
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRTrainingSemesterEmployeesController
	//Created Date:29 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRTrainingSemesterEmployeesController:BaseBusinessController
	{
		public HRTrainingSemesterEmployeesController()
		{
			dal= new DALBaseProvider("HRTrainingSemesterEmployees",typeof(HRTrainingSemesterEmployeesInfo));
		}

        public HRTrainingSemesterEmployeesInfo GetFirstDataByTrainingSemesterANDCourse(int iTrainingSemesterID, int iCourseID)
        {
            String str = String.Format(@"", iTrainingSemesterID, iCourseID);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (HRTrainingSemesterEmployeesInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }
	}
	#endregion
}