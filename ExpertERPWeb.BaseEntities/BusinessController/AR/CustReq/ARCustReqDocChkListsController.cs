using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustReqDocChkLists
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustReqDocChkListsController
	//Created Date:Monday, January 05, 2015
	//-----------------------------------------------------------
	
	public class ARCustReqDocChkListsController:BaseBusinessController
	{
		public ARCustReqDocChkListsController()
		{
			dal= new DALBaseProvider("ARCustReqDocChkLists",typeof(ARCustReqDocChkListsInfo));
		}
	}
	#endregion
}