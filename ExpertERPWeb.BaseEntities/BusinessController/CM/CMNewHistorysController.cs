using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMNewHistorys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMNewHistorysController
	//Created Date:Wednesday, May 06, 2009
	//-----------------------------------------------------------
	
	public class CMNewHistorysController:BaseBusinessController
	{
		public CMNewHistorysController()
		{
			dal= new DALBaseProvider("CMNewHistorys",typeof(CMNewHistorysInfo));
		}
	}
	#endregion
}