using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMMailAttms
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMMailAttmsController
	//Created Date:Wednesday, April 29, 2009
	//-----------------------------------------------------------
	
	public class CMMailAttmsController:BaseBusinessController
	{
		public CMMailAttmsController()
		{
			dal= new DALBaseProvider("CMMailAttms",typeof(CMMailAttmsInfo));
		}
	}
	#endregion
}