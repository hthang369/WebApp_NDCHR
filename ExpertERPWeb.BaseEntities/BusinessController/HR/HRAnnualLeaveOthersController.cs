using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRAnnualLeaveOthers
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRAnnualLeaveOthersController
	//Created Date:Thursday, August 31, 2017
	//-----------------------------------------------------------
	
	public class HRAnnualLeaveOthersController:BaseBusinessController
	{
		public HRAnnualLeaveOthersController()
		{
			dal= new DALBaseProvider("HRAnnualLeaveOthers",typeof(HRAnnualLeaveOthersInfo));
		}
	}
	#endregion
}