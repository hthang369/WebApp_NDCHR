using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APConfigPriceListPrioritys
	//-----------------------------------------------------------
	//Generated By: SQLDBTools
	//Class:APConfigPriceListPrioritysController
	//Created Date: 05 May 2015
	//-----------------------------------------------------------
	
	public class APConfigPriceListPrioritysController:BaseBusinessController
	{
		public APConfigPriceListPrioritysController()
		{
			dal= new DALBaseProvider("APConfigPriceListPrioritys",typeof(APConfigPriceListPrioritysInfo));
		}
	}
	#endregion
}