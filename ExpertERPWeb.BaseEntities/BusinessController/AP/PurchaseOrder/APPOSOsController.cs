using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOSOs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPOSOsController
	//Created Date:03 Tháng Năm 2012
	//-----------------------------------------------------------
	
	public class APPOSOsController:BaseBusinessController
	{
		public APPOSOsController()
		{
			dal= new DALBaseProvider("APPOSOs",typeof(APPOSOsInfo));
		}
	}
	#endregion
}