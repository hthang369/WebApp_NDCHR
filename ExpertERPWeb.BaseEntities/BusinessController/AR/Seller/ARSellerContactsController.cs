using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region ARSellerContacts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSellerContactsController
	//Created Date:Friday, March 14, 2008
	//-----------------------------------------------------------
	
	public class ARSellerContactsController:BaseBusinessController
	{
		public ARSellerContactsController()
		{
			dal= new DALBaseProvider("ARSellerContacts",typeof(ARSellerContactsInfo));
		}
	}
	#endregion
}