
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARMSDSFlowCharts
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.72)
	//Class: ARMSDSFlowChartsController
	//Created Date: Tuesday, 30 Aug 2016
	//-----------------------------------------------------------
	
	public class ARMSDSFlowChartsController : BaseBusinessController
	{
		public ARMSDSFlowChartsController()
		{
			dal = new DALBaseProvider("ARMSDSFlowCharts",typeof(ARMSDSFlowChartsInfo));
		}
	}
	#endregion
}