using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APSupplierStats
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APSupplierStatsController
	//Created Date:Thursday, March 11, 2010
	//-----------------------------------------------------------
	
	public class APSupplierStatsController:BaseBusinessController
	{
		public APSupplierStatsController()
		{
			dal= new DALBaseProvider("APSupplierStats",typeof(APSupplierStatsInfo));
		}
	}
	#endregion
}