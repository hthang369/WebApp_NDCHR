using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLAccountArising_Views
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLAccountArising_ViewsController
	//Created Date:Tuesday, December 06, 2011
	//-----------------------------------------------------------
	
	public class ViewGLAccountArisingsController:BaseBusinessController
	{
		public ViewGLAccountArisingsController()
		{
			dal= new DALBaseProvider("GLAccountArising_Views",typeof(ViewGLAccountArisingsInfo));
		}
	}
	#endregion
}