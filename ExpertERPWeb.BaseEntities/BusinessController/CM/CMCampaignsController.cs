using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMCampaigns
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMCampaignsController
	//Created Date:24 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMCampaignsController:BaseBusinessController
	{
		public CMCampaignsController()
		{
			dal= new DALBaseProvider("CMCampaigns",typeof(CMCampaignsInfo));
		}
	}
	#endregion
}