using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRInsAdjs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRInsAdjsController
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HRInsAdjsController:BaseBusinessController
	{
		public HRInsAdjsController()
		{
			dal= new DALBaseProvider("HRInsAdjs",typeof(HRInsAdjsInfo));
		}
	}
	#endregion
}