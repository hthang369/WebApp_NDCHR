using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRSections
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRSectionsController
	//Created Date:Monday, April 13, 2009
	//-----------------------------------------------------------
	
	public class HRSectionsController:BaseBusinessController
	{
		public HRSectionsController()
		{
			dal= new DALBaseProvider("HRSections",typeof(HRSectionsInfo));
		}
	}
	#endregion
}