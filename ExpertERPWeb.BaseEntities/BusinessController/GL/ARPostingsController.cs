using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARPostings
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARPostingsController
	//Created Date:Saturday, June 18, 2011
	//-----------------------------------------------------------
	
	public class ARPostingsController:BaseBusinessController
	{
		public ARPostingsController()
		{
			dal= new DALBaseProvider("ARPostings",typeof(ARPostingsInfo));
		}
	}
	#endregion
}