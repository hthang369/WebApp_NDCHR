using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region ICProductComponents
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICProductComponentsController
	//Created Date:Friday, March 21, 2008
	//-----------------------------------------------------------
	
	public class ICProductComponentsController:BaseBusinessController
	{
		public ICProductComponentsController()
		{
			dal= new DALBaseProvider("ICProductComponents",typeof(ICProductComponentsInfo));
		}
	}
	#endregion
}