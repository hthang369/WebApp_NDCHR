using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewRecptMonitors
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ViewRecptMonitorsController
	//Created Date:Wednesday, January 7, 2015
	//-----------------------------------------------------------
	
	public class ViewRecptMonitorsController:BaseBusinessController
	{
		public ViewRecptMonitorsController()
		{
			dal= new DALBaseProvider("ViewRecptMonitors",typeof(ViewRecptMonitorsInfo));
		}
	}
	#endregion
}