using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewICProductAlternatives
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewICProductAlternativesController
	//Created Date:Friday, May 11, 2012
	//-----------------------------------------------------------
	
	public class ViewICProductAlternativesController:BaseBusinessController
	{
		public ViewICProductAlternativesController()
		{
			dal= new DALBaseProvider("ViewICProductAlternatives",typeof(ViewICProductAlternativesInfo));
		}
	}
	#endregion
}