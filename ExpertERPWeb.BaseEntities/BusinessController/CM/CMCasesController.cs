using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMCases
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMCasesController
	//Created Date:10 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class CMCasesController:BaseBusinessController
	{
		public CMCasesController()
		{
			dal= new DALBaseProvider("CMCases",typeof(CMCasesInfo));
		}
	}
	#endregion
}