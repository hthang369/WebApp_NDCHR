using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOItemSemiDetailOrdPlans
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APPOItemSemiDetailOrdPlansController
	//Created Date:Tuesday, January 29, 2013
	//-----------------------------------------------------------
	
	public class APPOItemSemiDetailOrdPlansController:BaseBusinessController
	{
		public APPOItemSemiDetailOrdPlansController()
		{
			dal= new DALBaseProvider("APPOItemSemiDetailOrdPlans",typeof(APPOItemSemiDetailOrdPlansInfo));
		}
	}
	#endregion
}