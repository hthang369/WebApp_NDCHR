using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOPriceLists
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOPriceListsController
	//Created Date:Saturday, February 21, 2009
	//-----------------------------------------------------------
	
	public class LOPriceListsController:BaseBusinessController
	{
		public LOPriceListsController()
		{
			dal= new DALBaseProvider("LOPriceLists",typeof(LOPriceListsInfo));
		}
	}
	#endregion
}