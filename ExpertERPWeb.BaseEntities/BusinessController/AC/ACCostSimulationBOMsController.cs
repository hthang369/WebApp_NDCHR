using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationBOMs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationBOMsController
	//Created Date:Monday, July 21, 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationBOMsController:BaseBusinessController
	{
		public ACCostSimulationBOMsController()
		{
			dal= new DALBaseProvider("ACCostSimulationBOMs",typeof(ACCostSimulationBOMsInfo));
		}
	}
	#endregion
}