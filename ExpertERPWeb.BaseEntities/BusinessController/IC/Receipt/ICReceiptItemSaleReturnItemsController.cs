using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICReceiptItemSaleReturnItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICReceiptItemSaleReturnItemsController
	//Created Date:27 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ICReceiptItemSaleReturnItemsController:BaseBusinessController
	{
		public ICReceiptItemSaleReturnItemsController()
		{
			dal= new DALBaseProvider("ICReceiptItemSaleReturnItems",typeof(ICReceiptItemSaleReturnItemsInfo));
		}
	}
	#endregion
}