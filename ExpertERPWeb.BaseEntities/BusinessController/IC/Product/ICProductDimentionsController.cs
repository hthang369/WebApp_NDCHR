using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICProductDimentions
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICProductDimentionsController
	//Created Date:Monday, November 5, 2012
	//-----------------------------------------------------------
	
	public class ICProductDimentionsController:BaseBusinessController
	{
		public ICProductDimentionsController()
		{
			dal= new DALBaseProvider("ICProductDimentions",typeof(ICProductDimentionsInfo));
		}
	}
	#endregion
}