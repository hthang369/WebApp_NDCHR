using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRLevs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRLevsController
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HRLevsController:BaseBusinessController
	{
		public HRLevsController()
		{
			dal= new DALBaseProvider("HRLevs",typeof(HRLevsInfo));
		}
	}
	#endregion
}