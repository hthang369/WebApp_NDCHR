using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMPositions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMPositionsController
	//Created Date:30 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMPositionsController:BaseBusinessController
	{
		public CMPositionsController()
		{
			dal= new DALBaseProvider("CMPositions",typeof(CMPositionsInfo));
		}
	}
	#endregion
}