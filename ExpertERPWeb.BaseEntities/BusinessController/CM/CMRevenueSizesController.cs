using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMRevenueSizes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMRevenueSizesController
	//Created Date:23 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMRevenueSizesController:BaseBusinessController
	{
		public CMRevenueSizesController()
		{
			dal= new DALBaseProvider("CMRevenueSizes",typeof(CMRevenueSizesInfo));
		}
	}
	#endregion
}