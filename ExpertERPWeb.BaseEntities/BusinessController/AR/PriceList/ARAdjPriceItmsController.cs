using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARAdjPriceItms
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARAdjPriceItmsController
	//Created Date:Wednesday, November 04, 2009
	//-----------------------------------------------------------
	
	public class ARAdjPriceItmsController:BaseBusinessController
	{
		public ARAdjPriceItmsController()
		{
			dal= new DALBaseProvider("ARAdjPriceItms",typeof(ARAdjPriceItmsInfo));
		}
	}
	#endregion
}