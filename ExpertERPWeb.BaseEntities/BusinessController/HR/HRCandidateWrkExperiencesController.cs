using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRCandidateWrkExperiences
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRCandidateWrkExperiencesController
	//Created Date:28 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRCandidateWrkExperiencesController:BaseBusinessController
	{
		public HRCandidateWrkExperiencesController()
		{
			dal= new DALBaseProvider("HRCandidateWrkExperiences",typeof(HRCandidateWrkExperiencesInfo));
		}
	}
	#endregion
}