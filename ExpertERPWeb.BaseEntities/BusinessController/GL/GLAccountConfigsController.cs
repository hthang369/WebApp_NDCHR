using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLAccountConfigs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLAccountConfigsController
	//Created Date:Wednesday, December 07, 2011
	//-----------------------------------------------------------
	
	public class GLAccountConfigsController:BaseBusinessController
	{
		public GLAccountConfigsController()
		{
			dal= new DALBaseProvider("GLAccountConfigs",typeof(GLAccountConfigsInfo));
		}
	}
	#endregion
}