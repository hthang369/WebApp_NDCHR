using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleReturnItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleReturnItemsController
	//Created Date:27 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ARSaleReturnItemsController:BaseBusinessController
	{
		public ARSaleReturnItemsController()
		{
			dal= new DALBaseProvider("ARSaleReturnItems",typeof(ARSaleReturnItemsInfo));
		}
	}
	#endregion
}