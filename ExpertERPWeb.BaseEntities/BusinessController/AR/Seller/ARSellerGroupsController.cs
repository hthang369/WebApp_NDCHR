using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerGroups
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARSellerGroupsController
	//Created Date:Friday, April 27, 2012
	//-----------------------------------------------------------
	
	public class ARSellerGroupsController:BaseBusinessController
	{
		public ARSellerGroupsController()
		{
			dal= new DALBaseProvider("ARSellerGroups",typeof(ARSellerGroupsInfo));
		}
	}
	#endregion
}