using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEPolicyObjects
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEPolicyObjectsController
	//Created Date:Monday, April 03, 2017
	//-----------------------------------------------------------
	
	public class GEPolicyObjectsController:BaseBusinessController
	{
		public GEPolicyObjectsController()
		{
			dal= new DALBaseProvider("GEPolicyObjects",typeof(GEPolicyObjectsInfo));
		}
	}
	#endregion
}