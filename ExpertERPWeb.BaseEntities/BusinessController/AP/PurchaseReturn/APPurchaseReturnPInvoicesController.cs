using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPurchaseReturnPInvoices
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPurchaseReturnPInvoicesController
	//Created Date:04 Tháng Chín 2012
	//-----------------------------------------------------------
	
	public class APPurchaseReturnPInvoicesController:BaseBusinessController
	{
		public APPurchaseReturnPInvoicesController()
		{
			dal= new DALBaseProvider("APPurchaseReturnPInvoices",typeof(APPurchaseReturnPInvoicesInfo));
		}
	}
	#endregion
}