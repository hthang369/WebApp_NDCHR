using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARPkgPlnItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARPkgPlnItemsController
	//Created Date:Monday, November 19, 2012
	//-----------------------------------------------------------
	
	public class ARPkgPlnItemsController:BaseBusinessController
	{
		public ARPkgPlnItemsController()
		{
			dal= new DALBaseProvider("ARPkgPlnItems",typeof(ARPkgPlnItemsInfo));
		}
	}
	#endregion
}