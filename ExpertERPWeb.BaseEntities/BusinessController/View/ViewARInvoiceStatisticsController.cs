
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewARInvoiceStatistics
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.51)
	//Class: ViewARInvoiceStatisticsController
	//Created Date: Friday, 06 May 2016
	//-----------------------------------------------------------
	
	public class ViewARInvoiceStatisticsController : BaseBusinessController
	{
		public ViewARInvoiceStatisticsController()
		{
			dal = new DALBaseProvider("ViewARInvoiceStatistics",typeof(ViewARInvoiceStatisticsInfo));
		}
	}
	#endregion
}