using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOContainers
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOContainersController
	//Created Date:Saturday, February 21, 2009
	//-----------------------------------------------------------
	
	public class LOContainersController:BaseBusinessController
	{
		public LOContainersController()
		{
			dal= new DALBaseProvider("LOContainers",typeof(LOContainersInfo));
		}
	}
	#endregion
}