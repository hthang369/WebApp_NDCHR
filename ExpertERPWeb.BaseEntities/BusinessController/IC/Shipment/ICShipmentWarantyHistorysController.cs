using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICShipmentWarantyHistorys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICShipmentWarantyHistorysController
	//Created Date:14 Tháng Bảy 2011
	//-----------------------------------------------------------
	
	public class ICShipmentWarantyHistorysController:BaseBusinessController
	{
		public ICShipmentWarantyHistorysController()
		{
			dal= new DALBaseProvider("ICShipmentWarantyHistorys",typeof(ICShipmentWarantyHistorysInfo));
		}
	}
	#endregion
}