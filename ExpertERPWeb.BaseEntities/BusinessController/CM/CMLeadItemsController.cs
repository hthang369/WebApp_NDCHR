using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMLeadItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMLeadItemsController
	//Created Date:24 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMLeadItemsController:BaseBusinessController
	{
		public CMLeadItemsController()
		{
			dal= new DALBaseProvider("CMLeadItems",typeof(CMLeadItemsInfo));
		}
	}
	#endregion
}