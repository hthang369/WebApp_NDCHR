using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustomerReqAttrTemplates
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustomerReqAttrTemplatesController
	//Created Date:Wednesday, December 9, 2015
	//-----------------------------------------------------------
	
	public class ARCustomerReqAttrTemplatesController:BaseBusinessController
	{
		public ARCustomerReqAttrTemplatesController()
		{
			dal= new DALBaseProvider("ARCustomerReqAttrTemplates",typeof(ARCustomerReqAttrTemplatesInfo));
		}
	}
	#endregion
}