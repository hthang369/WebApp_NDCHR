using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLConfigs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLConfigsController
	//Created Date:Thursday, July 09, 2009
	//-----------------------------------------------------------
	
	public class GLConfigsController:BaseBusinessController
	{
		public GLConfigsController()
		{
			dal= new DALBaseProvider("GLConfigs",typeof(GLConfigsInfo));
		}
	}
	#endregion
}