using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APDebitNoteItemPInvoiceItems
	//-----------------------------------------------------------
	//Generated By: VTD Studio
	//Class:APDebitNoteItemPInvoiceItemsController
	//Created Date:Monday, April 12, 2010
	//-----------------------------------------------------------
	
	public class APDebitNoteItemPInvoiceItemsController:BaseBusinessController
	{
		public APDebitNoteItemPInvoiceItemsController()
		{
			dal= new DALBaseProvider("APDebitNoteItemPInvoiceItems",typeof(APDebitNoteItemPInvoiceItemsInfo));
		}
	}
	#endregion
}