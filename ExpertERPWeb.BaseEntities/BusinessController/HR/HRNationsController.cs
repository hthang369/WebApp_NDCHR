using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRNations
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRNationsController
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HRNationsController:BaseBusinessController
	{
		public HRNationsController()
		{
			dal= new DALBaseProvider("HRNations",typeof(HRNationsInfo));
		}
	}
	#endregion
}