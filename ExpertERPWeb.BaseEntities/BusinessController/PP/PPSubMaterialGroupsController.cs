using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPSubMaterialGroups
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPSubMaterialGroupsController
	//Created Date:27 Tháng Mười Một 2012
	//-----------------------------------------------------------
	
	public class PPSubMaterialGroupsController:BaseBusinessController
	{
		public PPSubMaterialGroupsController()
		{
			dal= new DALBaseProvider("PPSubMaterialGroups",typeof(PPSubMaterialGroupsInfo));
		}
	}
	#endregion
}