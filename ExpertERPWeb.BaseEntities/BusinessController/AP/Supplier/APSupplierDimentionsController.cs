using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APSupplierDimentions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APSupplierDimentionsController
	//Created Date:Monday, November 5, 2012
	//-----------------------------------------------------------
	
	public class APSupplierDimentionsController:BaseBusinessController
	{
		public APSupplierDimentionsController()
		{
			dal= new DALBaseProvider("APSupplierDimentions",typeof(APSupplierDimentionsInfo));
		}
	}
	#endregion
}