﻿using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
	#region ARSaleOrderItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleOrderItemsController
	//Created Date:Wednesday, March 26, 2008
	//-----------------------------------------------------------
	
	public class ARSaleOrderItemsController:BaseBusinessController
	{
		public ARSaleOrderItemsController()
		{
			dal= new DALBaseProvider("ARSaleOrderItems",typeof(ARSaleOrderItemsInfo));
		}

        
	}
	#endregion
}