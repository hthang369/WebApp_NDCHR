using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLExAdjCfgs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLExAdjCfgsController
	//Created Date:23 Tháng Tám 2013
	//-----------------------------------------------------------
	
	public class GLExAdjCfgsController:BaseBusinessController
	{
		public GLExAdjCfgsController()
		{
			dal= new DALBaseProvider("GLExAdjCfgs",typeof(GLExAdjCfgsInfo));
		}
	}
	#endregion
}