using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRCandidateRelatives
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRCandidateRelativesController
	//Created Date:28 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRCandidateRelativesController:BaseBusinessController
	{
		public HRCandidateRelativesController()
		{
			dal= new DALBaseProvider("HRCandidateRelatives",typeof(HRCandidateRelativesInfo));
		}
	}
	#endregion
}