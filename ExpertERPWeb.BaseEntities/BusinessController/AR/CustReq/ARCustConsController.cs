using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustCons
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustConsController
	//Created Date:Tuesday, January 06, 2015
	//-----------------------------------------------------------
	
	public class ARCustConsController:BaseBusinessController
	{
		public ARCustConsController()
		{
			dal= new DALBaseProvider("ARCustCons",typeof(ARCustConsInfo));
		}
	}
	#endregion
}