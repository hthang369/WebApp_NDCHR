using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRSalaryLevels
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRSalaryLevelsController
	//Created Date:Monday, December 11, 2017
	//-----------------------------------------------------------
	
	public class HRSalaryLevelsController:BaseBusinessController
	{
		public HRSalaryLevelsController()
		{
			dal= new DALBaseProvider("HRSalaryLevels",typeof(HRSalaryLevelsInfo));
		}
	}
	#endregion
}