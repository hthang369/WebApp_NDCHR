 using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPMDSCfgs
	//-----------------------------------------------------------
	//Generated By: SQLDBTools.NET - LINHCLH (v2.0.5)
	//Class: PPMDSCfgsController
	//Created Date: Wednesday, 21 Jun 2017
	//-----------------------------------------------------------
	
	public class PPMDSCfgsController : BaseBusinessController
	{
		public PPMDSCfgsController()
		{
			dal = new DALBaseProvider("PPMDSCfgs",typeof(PPMDSCfgsInfo));
		}
	}
	#endregion
}