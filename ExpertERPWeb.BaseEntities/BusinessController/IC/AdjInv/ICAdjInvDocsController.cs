using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICAdjInvDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICAdjInvDocsController
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class ICAdjInvDocsController:BaseBusinessController
	{
		public ICAdjInvDocsController()
		{
			dal= new DALBaseProvider("ICAdjInvDocs",typeof(ICAdjInvDocsInfo));
		}
	}
	#endregion
}