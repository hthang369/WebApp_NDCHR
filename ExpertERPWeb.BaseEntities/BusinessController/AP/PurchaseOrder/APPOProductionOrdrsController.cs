using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOProductionOrdrs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APPOProductionOrdrsController
	//Created Date:24 Tháng Mười Hai 2014
	//-----------------------------------------------------------
	
	public class APPOProductionOrdrsController:BaseBusinessController
	{
		public APPOProductionOrdrsController()
		{
			dal= new DALBaseProvider("APPOProductionOrdrs",typeof(APPOProductionOrdrsInfo));
		}
	}
	#endregion
}