using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICReceiptCreditNotes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICReceiptCreditNotesController
	//Created Date:19 Tháng Bảy 2011
	//-----------------------------------------------------------
	
	public class ICReceiptCreditNotesController:BaseBusinessController
	{
		public ICReceiptCreditNotesController()
		{
			dal= new DALBaseProvider("ICReceiptCreditNotes",typeof(ICReceiptCreditNotesInfo));
		}
	}
	#endregion
}