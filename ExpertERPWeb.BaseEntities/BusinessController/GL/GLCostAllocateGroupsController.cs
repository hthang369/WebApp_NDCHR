using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLCostAllocateGroups
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLCostAllocateGroupsController
	//Created Date:01 Tháng Bảy 2013
	//-----------------------------------------------------------
	
	public class GLCostAllocateGroupsController:BaseBusinessController
	{
		public GLCostAllocateGroupsController()
		{
			dal= new DALBaseProvider("GLCostAllocateGroups",typeof(GLCostAllocateGroupsInfo));
		}
	}
	#endregion
}