using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPODocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPODocsController
	//Created Date:23 Tháng Tư 2012
	//-----------------------------------------------------------
	
	public class APPODocsController:BaseBusinessController
	{
		public APPODocsController()
		{
			dal= new DALBaseProvider("APPODocs",typeof(APPODocsInfo));
		}
	}
	#endregion
}