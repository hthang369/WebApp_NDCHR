using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOAgents
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOAgentsController
	//Created Date:Saturday, February 21, 2009
	//-----------------------------------------------------------
	
	public class LOAgentsController:BaseBusinessController
	{
		public LOAgentsController()
		{
			dal= new DALBaseProvider("LOAgents",typeof(LOAgentsInfo));
		}
	}
	#endregion
}