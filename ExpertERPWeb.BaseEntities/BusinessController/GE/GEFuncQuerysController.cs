using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEFuncQuerys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEFuncQuerysController
	//Created Date:Monday, April 03, 2017
	//-----------------------------------------------------------
	
	public class GEFuncQuerysController:BaseBusinessController
	{
		public GEFuncQuerysController()
		{
			dal= new DALBaseProvider("GEFuncQuerys",typeof(GEFuncQuerysInfo));
		}
	}
	#endregion
}