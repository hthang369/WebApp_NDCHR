using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOAdvances
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOAdvancesController
	//Created Date:Saturday, February 21, 2009
	//-----------------------------------------------------------
	
	public class LOAdvancesController:BaseBusinessController
	{
		public LOAdvancesController()
		{
			dal= new DALBaseProvider("LOAdvances",typeof(LOAdvancesInfo));
		}
        public DataSet getAdvancesByLOConsignmentID(int iLOConsignmentID)
        {
            return dal.GetDataSet("LOAdvances_SelectByLOConsignmentID", iLOConsignmentID);
        }
	}
	#endregion
}