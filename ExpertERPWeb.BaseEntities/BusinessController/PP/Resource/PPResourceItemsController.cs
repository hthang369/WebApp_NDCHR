using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPResourceItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPResourceItemsController
	//Created Date:Friday, January 06, 2017
	//-----------------------------------------------------------
	
	public class PPResourceItemsController:BaseBusinessController
	{
		public PPResourceItemsController()
		{
			dal= new DALBaseProvider("PPResourceItems",typeof(PPResourceItemsInfo));
		}
	}
	#endregion
}