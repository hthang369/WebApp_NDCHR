using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPPhaseCfgDetails
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPPhaseCfgDetailsController
	//Created Date:13 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class PPPhaseCfgDetailsController:BaseBusinessController
	{
		public PPPhaseCfgDetailsController()
		{
			dal= new DALBaseProvider("PPPhaseCfgDetails",typeof(PPPhaseCfgDetailsInfo));
		}
	}
	#endregion
}