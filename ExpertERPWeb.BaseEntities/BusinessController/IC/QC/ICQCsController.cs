using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICQCs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICQCsController
	//Created Date:18 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class ICQCsController:BaseBusinessController
	{
		public ICQCsController()
		{
			dal= new DALBaseProvider("ICQCs",typeof(ICQCsInfo));
		}
	}
	#endregion
}