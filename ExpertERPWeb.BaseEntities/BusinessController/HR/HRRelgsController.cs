using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRRelgs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRRelgsController
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HRRelgsController:BaseBusinessController
	{
		public HRRelgsController()
		{
			dal= new DALBaseProvider("HRRelgs",typeof(HRRelgsInfo));
		}
	}
	#endregion
}