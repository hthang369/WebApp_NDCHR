using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEPolicyTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEPolicyTypesController
	//Created Date:Monday, April 03, 2017
	//-----------------------------------------------------------
	
	public class GEPolicyTypesController:BaseBusinessController
	{
		public GEPolicyTypesController()
		{
			dal= new DALBaseProvider("GEPolicyTypes",typeof(GEPolicyTypesInfo));
		}
	}
	#endregion
}