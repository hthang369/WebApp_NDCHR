using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRSalaryLadderRanks
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRSalaryLadderRanksController
	//Created Date:Tuesday, May 23, 2017
	//-----------------------------------------------------------
	
	public class HRSalaryLadderRanksController:BaseBusinessController
	{
		public HRSalaryLadderRanksController()
		{
			dal= new DALBaseProvider("HRSalaryLadderRanks",typeof(HRSalaryLadderRanksInfo));
		}
	}
	#endregion
}