using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleOppItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleOppItemsController
	//Created Date:23 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class ARSaleOppItemsController:BaseBusinessController
	{
		public ARSaleOppItemsController()
		{
			dal= new DALBaseProvider("ARSaleOppItems",typeof(ARSaleOppItemsInfo));
		}
	}
	#endregion
}