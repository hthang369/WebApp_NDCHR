using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APRFQItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APRFQItemsController
	//Created Date:Thursday, January 8, 2015
	//-----------------------------------------------------------
	
	public class APRFQItemsController:BaseBusinessController
	{
		public APRFQItemsController()
		{
			dal= new DALBaseProvider("APRFQItems",typeof(APRFQItemsInfo));
		}
	}
	#endregion
}