using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLDocPostingItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLDocPostingItemsController
	//Created Date:Wednesday, May 19, 2010
	//-----------------------------------------------------------
	
	public class GLDocPostingItemsController:BaseBusinessController
	{
		public GLDocPostingItemsController()
		{
			dal= new DALBaseProvider("GLDocPostingItems",typeof(GLDocPostingItemsInfo));
		}
	}
	#endregion
}