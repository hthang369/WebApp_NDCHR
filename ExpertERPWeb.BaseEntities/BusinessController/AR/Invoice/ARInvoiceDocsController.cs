using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARInvoiceDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARInvoiceDocsController
	//Created Date:23 Tháng Tư 2012
	//-----------------------------------------------------------
	
	public class ARInvoiceDocsController:BaseBusinessController
	{
		public ARInvoiceDocsController()
		{
			dal= new DALBaseProvider("ARInvoiceDocs",typeof(ARInvoiceDocsInfo));
		}
	}
	#endregion
}