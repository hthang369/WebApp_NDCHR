using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region GEFiscalPeriods
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEFiscalPeriodsController
	//Created Date:Sunday, April 13, 2008
	//-----------------------------------------------------------
	
	public class GEFiscalPeriodsController:BaseBusinessController
	{
		public GEFiscalPeriodsController()
		{
			dal= new DALBaseProvider("GEFiscalPeriods",typeof(GEFiscalPeriodsInfo));
		}
	}
	#endregion
}