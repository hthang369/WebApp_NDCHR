using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTrainings
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTrainingsController
	//Created Date:Sunday, May 17, 2009
	//-----------------------------------------------------------
	
	public class HREmployeeTrainingsController:BaseBusinessController
	{
		public HREmployeeTrainingsController()
		{
			dal= new DALBaseProvider("HREmployeeTrainings",typeof(HREmployeeTrainingsInfo));
		}
	}
	#endregion
}