using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRCandidateDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRCandidateDocsController
	//Created Date:28 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class HRCandidateDocsController:BaseBusinessController
	{
		public HRCandidateDocsController()
		{
			dal= new DALBaseProvider("HRCandidateDocs",typeof(HRCandidateDocsInfo));
		}
	}
	#endregion
}