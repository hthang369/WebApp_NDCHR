using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRRiceConfigs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRRiceConfigsController
	//Created Date:Tuesday, March 21, 2017
	//-----------------------------------------------------------
	
	public class HRRiceConfigsController:BaseBusinessController
	{
		public HRRiceConfigsController()
		{
			dal= new DALBaseProvider("HRRiceConfigs",typeof(HRRiceConfigsInfo));
		}
	}
	#endregion
}