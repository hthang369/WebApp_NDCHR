using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSOItemAttrs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSOItemAttrsController
	//Created Date:26 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class ARSOItemAttrsController:BaseBusinessController
	{
		public ARSOItemAttrsController()
		{
			dal= new DALBaseProvider("ARSOItemAttrs",typeof(ARSOItemAttrsInfo));
		}
	}
	#endregion
}