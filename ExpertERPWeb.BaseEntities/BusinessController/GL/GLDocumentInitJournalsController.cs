 using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLDocumentInitJournals
	//-----------------------------------------------------------
	//Generated By: SQLDBTools.NET - LINHCLH (v1.0.22)
	//Class: GLDocumentInitJournalsController
	//Created Date: Thursday, 27 Apr 2017
	//-----------------------------------------------------------
	
	public class GLDocumentInitJournalsController : BaseBusinessController
	{
		public GLDocumentInitJournalsController()
		{
			dal = new DALBaseProvider("GLDocumentInitJournals",typeof(GLDocumentInitJournalsInfo));
		}
	}
	#endregion
}