using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICShipmentROs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICShipmentROsController
	//Created Date:28 Tháng Hai 2013
	//-----------------------------------------------------------
	
	public class ICShipmentROsController:BaseBusinessController
	{
		public ICShipmentROsController()
		{
			dal= new DALBaseProvider("ICShipmentROs",typeof(ICShipmentROsInfo));
		}
	}
	#endregion
}