using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRVacancyJurys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRVacancyJurysController
	//Created Date:28 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRVacancyJurysController:BaseBusinessController
	{
		public HRVacancyJurysController()
		{
			dal= new DALBaseProvider("HRVacancyJurys",typeof(HRVacancyJurysInfo));
		}
	}
	#endregion
}