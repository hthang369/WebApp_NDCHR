using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPInvoiceJournals
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPInvoiceJournalsController
	//Created Date:21 Tháng Hai 2012
	//-----------------------------------------------------------
	
	public class APPInvoiceJournalsController:BaseBusinessController
	{
		public APPInvoiceJournalsController()
		{
			dal= new DALBaseProvider("APPInvoiceJournals",typeof(APPInvoiceJournalsInfo));
		}
	}
	#endregion
}