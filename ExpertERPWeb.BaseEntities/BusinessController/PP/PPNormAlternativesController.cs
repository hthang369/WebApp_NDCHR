using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPNormAlternatives
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPNormAlternativesController
	//Created Date:08 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class PPNormAlternativesController:BaseBusinessController
	{
		public PPNormAlternativesController()
		{
			dal= new DALBaseProvider("PPNormAlternatives",typeof(PPNormAlternativesInfo));
		}
	}
	#endregion
}