using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARPmtTerms
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARPmtTermsController
	//Created Date:14 Tháng Sáu 2011
	//-----------------------------------------------------------
	
	public class ARPmtTermsController:BaseBusinessController
	{
		public ARPmtTermsController()
		{
			dal= new DALBaseProvider("ARPmtTerms",typeof(ARPmtTermsInfo));
		}
	}
	#endregion
}