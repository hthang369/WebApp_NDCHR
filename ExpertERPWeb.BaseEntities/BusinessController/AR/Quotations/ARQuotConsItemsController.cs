using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARQuotConsItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARQuotConsItemsController
	//Created Date:20 Tháng Mười Hai 2011
	//-----------------------------------------------------------
	
	public class ARQuotConsItemsController:BaseBusinessController
	{
		public ARQuotConsItemsController()
		{
			dal= new DALBaseProvider("ARQuotConsItems",typeof(ARQuotConsItemsInfo));
		}
	}
	#endregion
}