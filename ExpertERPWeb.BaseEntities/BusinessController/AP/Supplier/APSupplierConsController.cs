using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APSupplierCons
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APSupplierConsController
	//Created Date:Saturday, October 24, 2009
	//-----------------------------------------------------------
	
	public class APSupplierConsController:BaseBusinessController
	{
		public APSupplierConsController()
		{
			dal= new DALBaseProvider("APSupplierCons",typeof(APSupplierConsInfo));
		}
	}
	#endregion
}