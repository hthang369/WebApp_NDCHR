using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeDocs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HREmployeeDocsController
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HREmployeeDocsController:BaseBusinessController
	{
		public HREmployeeDocsController()
		{
			dal= new DALBaseProvider("HREmployeeDocs",typeof(HREmployeeDocsInfo));
		}
	}
	#endregion
}