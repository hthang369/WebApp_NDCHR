using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APRFQDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APRFQDocsController
	//Created Date:Thursday, January 8, 2015
	//-----------------------------------------------------------
	
	public class APRFQDocsController:BaseBusinessController
	{
		public APRFQDocsController()
		{
			dal= new DALBaseProvider("APRFQDocs",typeof(APRFQDocsInfo));
		}
	}
	#endregion
}