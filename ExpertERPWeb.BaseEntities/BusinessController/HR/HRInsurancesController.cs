using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRInsurances
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRInsurancesController
	//Created Date:Monday, April 13, 2009
	//-----------------------------------------------------------
	
	public class HRInsurancesController:BaseBusinessController
	{
		public HRInsurancesController()
		{
			dal= new DALBaseProvider("HRInsurances",typeof(HRInsurancesInfo));
		}
	}
	#endregion
}