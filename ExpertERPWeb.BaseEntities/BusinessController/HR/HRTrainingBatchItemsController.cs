using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRTrainingBatchItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRTrainingBatchItemsController
	//Created Date:Saturday, May 23, 2009
	//-----------------------------------------------------------
	
	public class HRTrainingBatchItemsController:BaseBusinessController
	{
		public HRTrainingBatchItemsController()
		{
			dal= new DALBaseProvider("HRTrainingBatchItems",typeof(HRTrainingBatchItemsInfo));
		}
	}
	#endregion
}