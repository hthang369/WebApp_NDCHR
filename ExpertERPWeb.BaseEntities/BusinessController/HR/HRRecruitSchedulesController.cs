using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRRecruitSchedules
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRRecruitSchedulesController
	//Created Date:29 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRRecruitSchedulesController:BaseBusinessController
	{
		public HRRecruitSchedulesController()
		{
			dal= new DALBaseProvider("HRRecruitSchedules",typeof(HRRecruitSchedulesInfo));
		}

        public DataSet LayLichTheoDoiTheoUngVienVaThoiGian(int iCandidateID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT * FROM dbo.HRRecruitSchedules
                                            WHERE AAStatus='Alive'
                                            AND (FK_HRCandidateID = {0} OR {0} = 0)
                                            AND CONVERT(NVARCHAR(10), HRRecruitScheduleExamDate, 112) >= '{1}'
                                            AND CONVERT(NVARCHAR(10), HRRecruitScheduleExamDate, 112) <= '{2}'", iCandidateID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }
	}
	#endregion
}