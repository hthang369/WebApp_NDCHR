using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICProductGroupAttrs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICProductGroupAttrsController
	//Created Date:10 Tháng Năm 2012
	//-----------------------------------------------------------
	
	public class ICProductGroupAttrsController:BaseBusinessController
	{
		public ICProductGroupAttrsController()
		{
			dal= new DALBaseProvider("ICProductGroupAttrs",typeof(ICProductGroupAttrsInfo));
		}
	}
	#endregion
}