using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRDivisions
	//-----------------------------------------------------------
	//Generated By: SQLDBTools.NET ? H??? £i?? (v2.0.60)
	//Class: HRDivisionsController
	//Created Date: Friday, 08 Dec 2017
	//-----------------------------------------------------------
	
	public class HRDivisionsController : BaseBusinessController
	{
		public HRDivisionsController()
		{
			dal = new DALBaseProvider("HRDivisions",typeof(HRDivisionsInfo));
		}
	}
	#endregion
}