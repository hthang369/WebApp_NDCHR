using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPOBWIPs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPOBWIPsController
	//Created Date:Tuesday, June 21, 2016
	//-----------------------------------------------------------
	
	public class PPOBWIPsController:BaseBusinessController
	{
		public PPOBWIPsController()
		{
			dal= new DALBaseProvider("PPOBWIPs",typeof(PPOBWIPsInfo));
		}
	}
	#endregion
}