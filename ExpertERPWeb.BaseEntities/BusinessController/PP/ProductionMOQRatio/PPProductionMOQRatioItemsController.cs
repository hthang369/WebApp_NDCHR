using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionMOQRatioItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionMOQRatioItemsController
	//Created Date:Friday, November 11, 2016
	//-----------------------------------------------------------
	
	public class PPProductionMOQRatioItemsController:BaseBusinessController
	{
		public PPProductionMOQRatioItemsController()
		{
			dal= new DALBaseProvider("PPProductionMOQRatioItems",typeof(PPProductionMOQRatioItemsInfo));
		}
	}
	#endregion
}