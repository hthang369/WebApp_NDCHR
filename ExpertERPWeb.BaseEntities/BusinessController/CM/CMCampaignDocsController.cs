using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMCampaignDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMCampaignDocsController
	//Created Date:24 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMCampaignDocsController:BaseBusinessController
	{
		public CMCampaignDocsController()
		{
			dal= new DALBaseProvider("CMCampaignDocs",typeof(CMCampaignDocsInfo));
		}
	}
	#endregion
}