using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMGoals
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:CMGoalsController
	//Created Date:24 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMGoalsController:BaseBusinessController
	{
		public CMGoalsController()
		{
			dal= new DALBaseProvider("CMGoals",typeof(CMGoalsInfo));
		}
	}
	#endregion
}