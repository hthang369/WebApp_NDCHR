using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPConfigModelColors
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPConfigModelColorsController
	//Created Date:28 Tháng Mười Hai 2012
	//-----------------------------------------------------------
	
	public class PPConfigModelColorsController:BaseBusinessController
	{
		public PPConfigModelColorsController()
		{
			dal= new DALBaseProvider("PPConfigModelColors",typeof(PPConfigModelColorsInfo));
		}
	}
	#endregion
}