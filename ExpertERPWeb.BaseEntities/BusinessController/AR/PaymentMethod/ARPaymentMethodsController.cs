using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARPaymentMethods
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARPaymentMethodsController
	//Created Date:Thursday, July 03, 2014
	//-----------------------------------------------------------
	
	public class ARPaymentMethodsController:BaseBusinessController
	{
		public ARPaymentMethodsController()
		{
			dal= new DALBaseProvider("ARPaymentMethods",typeof(ARPaymentMethodsInfo));
		}
	}
	#endregion
}