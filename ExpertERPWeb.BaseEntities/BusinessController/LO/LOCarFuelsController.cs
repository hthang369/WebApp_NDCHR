using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOCarFuels
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOCarFuelsController
	//Created Date:Thursday, October 21, 2010
	//-----------------------------------------------------------
	
	public class LOCarFuelsController:BaseBusinessController
	{
		public LOCarFuelsController()
		{
			dal= new DALBaseProvider("LOCarFuels",typeof(LOCarFuelsInfo));
		}
	}
	#endregion
}