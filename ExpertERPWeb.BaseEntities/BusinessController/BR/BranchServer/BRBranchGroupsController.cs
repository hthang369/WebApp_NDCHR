using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region BRBranchGroups
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:BRBranchGroupsController
	//Created Date:Friday, June 03, 2011
	//-----------------------------------------------------------
	
	public class BRBranchGroupsController:BaseBusinessController
	{
		public BRBranchGroupsController()
		{
			dal= new DALBaseProvider("BRBranchGroups",typeof(BRBranchGroupsInfo));
		}
	}
	#endregion
}