using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICRequestReceiptItemPOItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICRequestReceiptItemPOItemsController
	//Created Date:Friday, April 17, 2015
	//-----------------------------------------------------------
	
	public class ICRequestReceiptItemPOItemsController:BaseBusinessController
	{
		public ICRequestReceiptItemPOItemsController()
		{
			dal= new DALBaseProvider("ICRequestReceiptItemPOItems",typeof(ICRequestReceiptItemPOItemsInfo));
		}
	}
	#endregion
}