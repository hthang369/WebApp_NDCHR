using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOShpPlans
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:LOShpPlansController
	//Created Date:Monday, October 18, 2010
	//-----------------------------------------------------------
	
	public class LOShpPlansController:BaseBusinessController
	{
		public LOShpPlansController()
		{
			dal= new DALBaseProvider("LOShpPlans",typeof(LOShpPlansInfo));
		}
	}
	#endregion
}