using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPurchaseReturnItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPurchaseReturnItemsController
	//Created Date:04 Tháng Chín 2012
	//-----------------------------------------------------------
	
	public class APPurchaseReturnItemsController:BaseBusinessController
	{
		public APPurchaseReturnItemsController()
		{
			dal= new DALBaseProvider("APPurchaseReturnItems",typeof(APPurchaseReturnItemsInfo));
		}
	}
	#endregion
}