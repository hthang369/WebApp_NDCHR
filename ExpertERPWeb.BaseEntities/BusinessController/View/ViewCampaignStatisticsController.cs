using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewCampaignStatistics
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewCampaignStatisticsController
	//Created Date:28 Tháng Tư 2012
	//-----------------------------------------------------------
	
	public class ViewCampaignStatisticsController:BaseBusinessController
	{
		public ViewCampaignStatisticsController()
		{
			dal= new DALBaseProvider("ViewCampaignStatistics",typeof(ViewCampaignStatisticsInfo));
		}
	}
	#endregion
}