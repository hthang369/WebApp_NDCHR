using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICReceiptPInvoices
	//-----------------------------------------------------------
	//Generated By: SQLDBTools
	//Class:ICReceiptPInvoicesController
	//Created Date: 18 Apr 2015
	//-----------------------------------------------------------
	
	public class ICReceiptPInvoicesController:BaseBusinessController
	{
		public ICReceiptPInvoicesController()
		{
			dal= new DALBaseProvider("ICReceiptPInvoices",typeof(ICReceiptPInvoicesInfo));
		}
	}
	#endregion
}