using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMNewDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMNewDocsController
	//Created Date:Thursday, April 09, 2009
	//-----------------------------------------------------------
	
	public class CMNewDocsController:BaseBusinessController
	{
		public CMNewDocsController()
		{
			dal= new DALBaseProvider("CMNewDocs",typeof(CMNewDocsInfo));
		}
	}
	#endregion
}