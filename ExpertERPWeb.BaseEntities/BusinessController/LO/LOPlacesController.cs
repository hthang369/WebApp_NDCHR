using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOPlaces
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:LOPlacesController
	//Created Date:Tuesday, October 19, 2010
	//-----------------------------------------------------------
	
	public class LOPlacesController:BaseBusinessController
	{
		public LOPlacesController()
		{
			dal= new DALBaseProvider("LOPlaces",typeof(LOPlacesInfo));
		}
	}
	#endregion
}