using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APRFQs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APRFQsController
	//Created Date:Thursday, January 8, 2015
	//-----------------------------------------------------------
	
	public class APRFQsController:BaseBusinessController
	{
		public APRFQsController()
		{
			dal= new DALBaseProvider("APRFQs",typeof(APRFQsInfo));
		}

        
	}
	#endregion
}