using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTranCfgRules
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLTranCfgRulesController
	//Created Date:Friday, August 22, 2014
	//-----------------------------------------------------------
	
	public class GLTranCfgRulesController:BaseBusinessController
	{
		public GLTranCfgRulesController()
		{
			dal= new DALBaseProvider("GLTranCfgRules",typeof(GLTranCfgRulesInfo));
		}
	}
	#endregion
}