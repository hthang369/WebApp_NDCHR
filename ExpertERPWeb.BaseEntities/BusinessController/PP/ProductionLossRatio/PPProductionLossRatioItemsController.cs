using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionLossRatioItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionLossRatioItemsController
	//Created Date:Friday, November 11, 2016
	//-----------------------------------------------------------
	
	public class PPProductionLossRatioItemsController:BaseBusinessController
	{
		public PPProductionLossRatioItemsController()
		{
			dal= new DALBaseProvider("PPProductionLossRatioItems",typeof(PPProductionLossRatioItemsInfo));
		}
	}
	#endregion
}