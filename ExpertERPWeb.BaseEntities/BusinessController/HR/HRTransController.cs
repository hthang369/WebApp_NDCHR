using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRTrans
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRTransController
	//Created Date:Friday, July 13, 2018
	//-----------------------------------------------------------
	
	public class HRTransController:BaseBusinessController
	{
		public HRTransController()
		{
			dal= new DALBaseProvider("HRTrans",typeof(HRTransInfo));
		}
	}
	#endregion
}