using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLBanks
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLBanksController
	//Created Date:Saturday, March 12, 2011
	//-----------------------------------------------------------
	
	public class GLBanksController:BaseBusinessController
	{
		public GLBanksController()
		{
			dal= new DALBaseProvider("GLBanks",typeof(GLBanksInfo));
		}
	}
	#endregion
}