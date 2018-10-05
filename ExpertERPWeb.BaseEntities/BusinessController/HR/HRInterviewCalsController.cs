using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRInterviewCals
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRInterviewCalsController
	//Created Date:Friday, July 14, 2017
	//-----------------------------------------------------------
	
	public class HRInterviewCalsController:BaseBusinessController
	{
		public HRInterviewCalsController()
		{
			dal= new DALBaseProvider("HRInterviewCals",typeof(HRInterviewCalsInfo));
		}
        public DataSet LayDanhSachLichPhongVanNgayHomSau()
        {
            string strSQL = @"SELECT * 
                            FROM dbo.HRInterviewCals
                            WHERE AAStatus='Alive' 
                            AND (CONVERT(NVARCHAR(10),ISNULL(HRInterviewCalDate,GETDATE()),112)=CONVERT(NVARCHAR(10),DATEADD(DAY,1,GETDATE()),112)
                            OR CONVERT(NVARCHAR(10),ISNULL(HRInterviewCal1Date,GETDATE()),112)=CONVERT(NVARCHAR(10),DATEADD(DAY,1,GETDATE()),112)
                            OR CONVERT(NVARCHAR(10),ISNULL(HRInterviewCal2Date,GETDATE()),112)=CONVERT(NVARCHAR(10),DATEADD(DAY,1,GETDATE()),112))";
            return dal.GetDataSet(strSQL);
        }
	}
	#endregion
}