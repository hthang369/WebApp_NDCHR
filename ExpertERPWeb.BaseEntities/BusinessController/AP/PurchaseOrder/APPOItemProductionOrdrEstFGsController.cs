using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOItemProductionOrdrEstFGs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APPOItemProductionOrdrEstFGsController
	//Created Date:24 Tháng Mười Hai 2014
	//-----------------------------------------------------------
	
	public class APPOItemProductionOrdrEstFGsController:BaseBusinessController
	{
		public APPOItemProductionOrdrEstFGsController()
		{
			dal= new DALBaseProvider("APPOItemProductionOrdrEstFGs",typeof(APPOItemProductionOrdrEstFGsInfo));
		}
	}
	#endregion
}