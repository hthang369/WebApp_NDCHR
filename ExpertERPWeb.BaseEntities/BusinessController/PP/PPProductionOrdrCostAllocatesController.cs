using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionOrdrCostAllocates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionOrdrCostAllocatesController
	//Created Date:09 May 2013
	//-----------------------------------------------------------
	
	public class PPProductionOrdrCostAllocatesController:BaseBusinessController
	{
		public PPProductionOrdrCostAllocatesController()
		{
			dal= new DALBaseProvider("PPProductionOrdrCostAllocates",typeof(PPProductionOrdrCostAllocatesInfo));
		}
	}
	#endregion
}