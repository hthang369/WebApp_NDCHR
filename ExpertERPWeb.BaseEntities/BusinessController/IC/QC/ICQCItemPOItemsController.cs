using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICQCItemPOItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICQCItemPOItemsController
	//Created Date:11 Tháng Mười Hai 2013
	//-----------------------------------------------------------
	
	public class ICQCItemPOItemsController:BaseBusinessController
	{
		public ICQCItemPOItemsController()
		{
			dal= new DALBaseProvider("ICQCItemPOItems",typeof(ICQCItemPOItemsInfo));
		}
	}
	#endregion
}