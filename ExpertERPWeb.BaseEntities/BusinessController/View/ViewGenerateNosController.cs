using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewGenerateNos
	//-----------------------------------------------------------
	//Generated By: SQLDBTools
	//Class:ViewGenerateNosController
	//Created Date: 15 May 2015
	//-----------------------------------------------------------
	
	public class ViewGenerateNosController:BaseBusinessController
	{
		public ViewGenerateNosController()
		{
			dal= new DALBaseProvider("ViewGenerateNos",typeof(ViewGenerateNosInfo));
		}
	}
	#endregion
}