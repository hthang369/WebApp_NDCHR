using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleLevelInterests
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleLevelInterestsController
	//Created Date:Wednesday, May 23, 2012
	//-----------------------------------------------------------
	
	public class ARSaleLevelInterestsController:BaseBusinessController
	{
		public ARSaleLevelInterestsController()
		{
			dal= new DALBaseProvider("ARSaleLevelInterests",typeof(ARSaleLevelInterestsInfo));
		}
	}
	#endregion
}