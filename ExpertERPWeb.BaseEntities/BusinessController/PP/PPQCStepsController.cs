using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPQCSteps
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPQCStepsController
	//Created Date:12 Tháng Mười Hai 2013
	//-----------------------------------------------------------
	
	public class PPQCStepsController:BaseBusinessController
	{
		public PPQCStepsController()
		{
			dal= new DALBaseProvider("PPQCSteps",typeof(PPQCStepsInfo));
		}
	}
	#endregion
}