using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMSpecialitys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMSpecialitysController
	//Created Date:30 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMSpecialitysController:BaseBusinessController
	{
		public CMSpecialitysController()
		{
			dal= new DALBaseProvider("CMSpecialitys",typeof(CMSpecialitysInfo));
		}
	}
	#endregion
}