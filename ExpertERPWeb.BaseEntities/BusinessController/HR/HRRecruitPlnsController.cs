using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRRecruitPlns
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRRecruitPlnsController
	//Created Date:28 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRRecruitPlnsController:BaseBusinessController
	{
		public HRRecruitPlnsController()
		{
			dal= new DALBaseProvider("HRRecruitPlns",typeof(HRRecruitPlnsInfo));
		}
	}
	#endregion
}