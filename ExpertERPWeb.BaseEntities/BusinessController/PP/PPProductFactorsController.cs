using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductFactors
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductFactorsController
	//Created Date:Thursday, June 23, 2016
	//-----------------------------------------------------------
	
	public class PPProductFactorsController:BaseBusinessController
	{
		public PPProductFactorsController()
		{
			dal= new DALBaseProvider("PPProductFactors",typeof(PPProductFactorsInfo));
		}

        //public DataSet GetAllDataByApplyDate()
        //{

        //}
	}
	#endregion
}