using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOConsignmentHistorys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOConsignmentHistorysController
	//Created Date:Saturday, February 21, 2009
	//-----------------------------------------------------------
	
	public class LOConsignmentHistorysController:BaseBusinessController
	{
		public LOConsignmentHistorysController()
		{
			dal= new DALBaseProvider("LOConsignmentHistorys",typeof(LOConsignmentHistorysInfo));
		}
	}
	#endregion
}