using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICProductClasss
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICProductClasssController
	//Created Date:Wednesday, October 24, 2012
	//-----------------------------------------------------------
	
	public class ICProductClasssController:BaseBusinessController
	{
		public ICProductClasssController()
		{
			dal= new DALBaseProvider("ICProductClasss",typeof(ICProductClasssInfo));
		}
	}
	#endregion
}