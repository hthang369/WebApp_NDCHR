using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRVacancyCandidates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRVacancyCandidatesController
	//Created Date:28 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRVacancyCandidatesController:BaseBusinessController
	{
		public HRVacancyCandidatesController()
		{
			dal= new DALBaseProvider("HRVacancyCandidates",typeof(HRVacancyCandidatesInfo));
		}
	}
	#endregion
}