using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOLogisticItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPOLogisticItemsController
	//Created Date:12 Tháng Năm 2012
	//-----------------------------------------------------------
	
	public class APPOLogisticItemsController:BaseBusinessController
	{
		public APPOLogisticItemsController()
		{
			dal= new DALBaseProvider("APPOLogisticItems",typeof(APPOLogisticItemsInfo));
		}
	}
	#endregion
}