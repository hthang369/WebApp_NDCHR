using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICProductDocs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICProductDocsController
	//Created Date:Tuesday, April 24, 2012
	//-----------------------------------------------------------
	
	public class ICProductDocsController:BaseBusinessController
	{
		public ICProductDocsController()
		{
			dal= new DALBaseProvider("ICProductDocs",typeof(ICProductDocsInfo));
		}
	}
	#endregion
}