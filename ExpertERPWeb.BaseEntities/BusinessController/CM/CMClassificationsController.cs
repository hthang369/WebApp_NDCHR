using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMClassifications
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMClassificationsController
	//Created Date:23 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMClassificationsController:BaseBusinessController
	{
		public CMClassificationsController()
		{
			dal= new DALBaseProvider("CMClassifications",typeof(CMClassificationsInfo));
		}
	}
	#endregion
}