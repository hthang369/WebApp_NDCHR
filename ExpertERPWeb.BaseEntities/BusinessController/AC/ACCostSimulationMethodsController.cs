using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationMethods
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationMethodsController
	//Created Date:21 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationMethodsController:BaseBusinessController
	{
		public ACCostSimulationMethodsController()
		{
			dal= new DALBaseProvider("ACCostSimulationMethods",typeof(ACCostSimulationMethodsInfo));
		}
	}
	#endregion
}