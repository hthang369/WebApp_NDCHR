using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRCandidateLevels
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRCandidateLevelsController
	//Created Date:28 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRCandidateLevelsController:BaseBusinessController
	{
		public HRCandidateLevelsController()
		{
			dal= new DALBaseProvider("HRCandidateLevels",typeof(HRCandidateLevelsInfo));
		}
	}
	#endregion
}