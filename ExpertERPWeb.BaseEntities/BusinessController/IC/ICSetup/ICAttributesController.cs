using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICAttributes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICAttributesController
	//Created Date:Saturday, May 9, 2015
	//-----------------------------------------------------------
	
	public class ICAttributesController:BaseBusinessController
	{
		public ICAttributesController()
		{
			dal= new DALBaseProvider("ICAttributes",typeof(ICAttributesInfo));
		}
	}
	#endregion
}