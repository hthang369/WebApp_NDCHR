using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region FAAssetDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:FAAssetDocsController
	//Created Date:24 Tháng Mười Một 2012
	//-----------------------------------------------------------
	
	public class FAAssetDocsController:BaseBusinessController
	{
		public FAAssetDocsController()
		{
			dal= new DALBaseProvider("FAAssetDocs",typeof(FAAssetDocsInfo));
		}
	}
	#endregion
}