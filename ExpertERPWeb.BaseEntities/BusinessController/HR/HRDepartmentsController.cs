using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRDepartments
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRDepartmentsController
	//Created Date:Tuesday, March 03, 2009
	//-----------------------------------------------------------
	
	public class HRDepartmentsController:BaseBusinessController
	{
		public HRDepartmentsController()
		{
			dal= new DALBaseProvider("HRDepartments",typeof(HRDepartmentsInfo));
		}
	}
	#endregion
}