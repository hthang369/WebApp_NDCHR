using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeLeaveConfigs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeLeaveConfigsController
	//Created Date:Friday, February 17, 2017
	//-----------------------------------------------------------
	
	public class HREmployeeLeaveConfigsController:BaseBusinessController
	{
		public HREmployeeLeaveConfigsController()
		{
			dal= new DALBaseProvider("HREmployeeLeaveConfigs",typeof(HREmployeeLeaveConfigsInfo));
		}
	}
	#endregion
}