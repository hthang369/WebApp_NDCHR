using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPMPSItemWeeklySchedules
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPMPSItemWeeklySchedulesController
	//Created Date:Friday, November 25, 2016
	//-----------------------------------------------------------
	
	public class PPMPSItemWeeklySchedulesController:BaseBusinessController
	{
		public PPMPSItemWeeklySchedulesController()
		{
			dal= new DALBaseProvider("PPMPSItemWeeklySchedules",typeof(PPMPSItemWeeklySchedulesInfo));
		}
	}
	#endregion
}