using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPRoutingCustomerReqDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPRoutingCustomerReqDocsController
	//Created Date:Tuesday, July 29, 2014
	//-----------------------------------------------------------
	
	public class PPRoutingCustomerReqDocsController:BaseBusinessController
	{
		public PPRoutingCustomerReqDocsController()
		{
			dal= new DALBaseProvider("PPRoutingCustomerReqDocs",typeof(PPRoutingCustomerReqDocsInfo));
		}
	}
	#endregion
}