using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmpInsuranceDeclarations
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HREmpInsuranceDeclarationsController
	//Created Date:26 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HREmpInsuranceDeclarationsController:BaseBusinessController
	{
		public HREmpInsuranceDeclarationsController()
		{
			dal= new DALBaseProvider("HREmpInsuranceDeclarations",typeof(HREmpInsuranceDeclarationsInfo));
		}
	}
	#endregion
}