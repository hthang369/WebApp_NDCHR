using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region BRGVouchers
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:BRGVouchersController
	//Created Date:Thursday, March 25, 2010
	//-----------------------------------------------------------
	
	public class BRGVouchersController:BaseBusinessController
	{
		public BRGVouchersController()
		{
			dal= new DALBaseProvider("BRGVouchers",typeof(BRGVouchersInfo));
		}
	}
	#endregion
}