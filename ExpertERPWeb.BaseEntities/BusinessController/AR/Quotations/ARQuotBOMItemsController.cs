using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARQuotBOMItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARQuotBOMItemsController
	//Created Date:Thursday, June 23, 2011
	//-----------------------------------------------------------
	
	public class ARQuotBOMItemsController:BaseBusinessController
	{
		public ARQuotBOMItemsController()
		{
			dal= new DALBaseProvider("ARQuotBOMItems",typeof(ARQuotBOMItemsInfo));
		}
	}
	#endregion
}