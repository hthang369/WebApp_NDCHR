using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLJrnEntrys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLJrnEntrysController
	//Created Date:Monday, July 06, 2009
	//-----------------------------------------------------------
	
	public class GLJrnEntrysController:BaseBusinessController
	{
		public GLJrnEntrysController()
		{
			dal= new DALBaseProvider("GLJrnEntrys",typeof(GLJrnEntrysInfo));
		}
	}
	#endregion
}