using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewEmployeeOffWorks
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewEmployeeOffWorksController
	//Created Date:12 Tháng Ba 2013
	//-----------------------------------------------------------
	
	public class ViewEmployeeOffWorksController:BaseBusinessController
	{
		public ViewEmployeeOffWorksController()
		{
			dal= new DALBaseProvider("ViewEmployeeOffWorks",typeof(ViewEmployeeOffWorksInfo));
        }
    }
	#endregion
}