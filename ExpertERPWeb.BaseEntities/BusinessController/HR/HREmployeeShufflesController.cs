using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeShuffles
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeShufflesController
	//Created Date:Wednesday, April 08, 2009
	//-----------------------------------------------------------
	
	public class HREmployeeShufflesController:BaseBusinessController
	{
		public HREmployeeShufflesController()
		{
			dal= new DALBaseProvider("HREmployeeShuffles",typeof(HREmployeeShufflesInfo));
		}
	}
	#endregion
}