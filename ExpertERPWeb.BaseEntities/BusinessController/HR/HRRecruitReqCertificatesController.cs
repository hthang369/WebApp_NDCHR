using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRRecruitReqCertificates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRRecruitReqCertificatesController
	//Created Date:27 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRRecruitReqCertificatesController:BaseBusinessController
	{
		public HRRecruitReqCertificatesController()
		{
			dal= new DALBaseProvider("HRRecruitReqCertificates",typeof(HRRecruitReqCertificatesInfo));
		}
	}
	#endregion
}