using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLOBCostAllocates
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.23)
	//Class: GLOBCostAllocatesController
	//Created Date: 06 Jan 2009
	//-----------------------------------------------------------
	
	public class GLOBCostAllocatesController:BaseBusinessController
	{
		public GLOBCostAllocatesController()
		{
			dal= new DALBaseProvider("GLOBCostAllocates",typeof(GLOBCostAllocatesInfo));
		}
	}
	#endregion
}