
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLLoanContractDocs
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.80)
	//Class: GLLoanContractDocsController
	//Created Date: Tuesday, 15 Nov 2016
	//-----------------------------------------------------------
	
	public class GLLoanContractDocsController : BaseBusinessController
	{
		public GLLoanContractDocsController()
		{
			dal = new DALBaseProvider("GLLoanContractDocs",typeof(GLLoanContractDocsInfo));
		}
	}
	#endregion
}