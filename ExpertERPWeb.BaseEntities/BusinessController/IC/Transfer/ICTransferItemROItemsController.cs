using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICTransferItemROItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICTransferItemROItemsController
	//Created Date:04 Tháng Ba 2013
	//-----------------------------------------------------------
	
	public class ICTransferItemROItemsController:BaseBusinessController
	{
		public ICTransferItemROItemsController()
		{
			dal= new DALBaseProvider("ICTransferItemROItems",typeof(ICTransferItemROItemsInfo));
		}
	}
	#endregion
}