using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMWarantyHistoryActions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMWarantyHistoryActionsController
	//Created Date:Friday, June 24, 2011
	//-----------------------------------------------------------
	
	public class CMWarantyHistoryActionsController:BaseBusinessController
	{
		public CMWarantyHistoryActionsController()
		{
			dal= new DALBaseProvider("CMWarantyHistoryActions",typeof(CMWarantyHistoryActionsInfo));
		}
	}
	#endregion
}