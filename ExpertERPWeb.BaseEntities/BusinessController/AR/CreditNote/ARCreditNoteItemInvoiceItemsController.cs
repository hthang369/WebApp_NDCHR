using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCreditNoteItemInvoiceItems
	//-----------------------------------------------------------
	//Generated By: VTD Studio
	//Class:ARCreditNoteItemInvoiceItemsController
	//Created Date:Monday, April 12, 2010
	//-----------------------------------------------------------
	
	public class ARCreditNoteItemInvoiceItemsController:BaseBusinessController
	{
		public ARCreditNoteItemInvoiceItemsController()
		{
			dal= new DALBaseProvider("ARCreditNoteItemInvoiceItems",typeof(ARCreditNoteItemInvoiceItemsInfo));
		}
	}
	#endregion
}