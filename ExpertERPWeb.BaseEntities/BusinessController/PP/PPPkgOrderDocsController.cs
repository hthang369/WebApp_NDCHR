using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPPkgOrderDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPPkgOrderDocsController
	//Created Date:11 Tháng Tám 2014
	//-----------------------------------------------------------
	
	public class PPPkgOrderDocsController:BaseBusinessController
	{
		public PPPkgOrderDocsController()
		{
			dal= new DALBaseProvider("PPPkgOrderDocs",typeof(PPPkgOrderDocsInfo));
		}
	}
	#endregion
}