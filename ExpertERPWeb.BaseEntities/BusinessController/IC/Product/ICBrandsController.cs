using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICBrands
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICBrandsController
	//Created Date:Tuesday, January 26, 2010
	//-----------------------------------------------------------
	
	public class ICBrandsController:BaseBusinessController
	{
		public ICBrandsController()
		{
			dal= new DALBaseProvider("ICBrands",typeof(ICBrandsInfo));
		}
	}
	#endregion
}