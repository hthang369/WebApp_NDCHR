using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRPerformances
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRPerformancesController
	//Created Date:20 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRPerformancesController:BaseBusinessController
	{
		public HRPerformancesController()
		{
			dal= new DALBaseProvider("HRPerformances",typeof(HRPerformancesInfo));
		}
	}
	#endregion
}