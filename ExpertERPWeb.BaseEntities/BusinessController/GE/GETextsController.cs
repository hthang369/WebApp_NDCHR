using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region GETexts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GETextsController
	//Created Date:Dienstag, 24. April 2007
	//-----------------------------------------------------------
	
	public class GETextsController:BaseBusinessController
	{
		public GETextsController()
		{
			dal= new DALBaseProvider("GETexts",typeof(GETextsInfo));
		}
	}
	#endregion
}