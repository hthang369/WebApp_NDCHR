using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleOppStages
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleOppStagesController
	//Created Date:Tuesday, May 22, 2012
	//-----------------------------------------------------------
	
	public class ARSaleOppStagesController:BaseBusinessController
	{
		public ARSaleOppStagesController()
		{
			dal= new DALBaseProvider("ARSaleOppStages",typeof(ARSaleOppStagesInfo));
		}
	}
	#endregion
}