using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APLandedCostSourceItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APLandedCostSourceItemsController
	//Created Date:Wednesday, October 17, 2012
	//-----------------------------------------------------------
	
	public class APLandedCostSourceItemsController:BaseBusinessController
	{
		public APLandedCostSourceItemsController()
		{
			dal= new DALBaseProvider("APLandedCostSourceItems",typeof(APLandedCostSourceItemsInfo));
		}
	}
	#endregion
}