using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMCorrespondenceDeparts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMCorrespondenceDepartsController
	//Created Date:Thursday, April 09, 2009
	//-----------------------------------------------------------
	
	public class CMCorrespondenceDepartsController:BaseBusinessController
	{
		public CMCorrespondenceDepartsController()
		{
			dal= new DALBaseProvider("CMCorrespondenceDeparts",typeof(CMCorrespondenceDepartsInfo));
		}
	}
	#endregion
}