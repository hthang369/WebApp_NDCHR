using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICShipmentItemSOItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICShipmentItemSOItemsController
	//Created Date:Wednesday, August 17, 2011
	//-----------------------------------------------------------
	
	public class ICShipmentItemSOItemsController:BaseBusinessController
	{
		public ICShipmentItemSOItemsController()
		{
			dal= new DALBaseProvider("ICShipmentItemSOItems",typeof(ICShipmentItemSOItemsInfo));
		}
	}
	#endregion
}