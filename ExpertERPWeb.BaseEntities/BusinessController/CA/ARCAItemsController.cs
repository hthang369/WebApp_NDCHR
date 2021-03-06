using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCAItems
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.28)
	//Class: ARCAItemsController
	//Created Date: 27 Nov 2015
	//-----------------------------------------------------------
	
	public class ARCAItemsController:BaseBusinessController
	{
		public ARCAItemsController()
		{
			dal= new DALBaseProvider("ARCAItems",typeof(ARCAItemsInfo));
		}
        public DataSet GetDataByARCAIDOrderByLV(int piID)
        {
            String strQuery = String.Format(@"
SELECT *
    FROM ARCAItems
    WHERE AAStatus = 'Alive' 
        AND FK_ARCAID = {0}
    ORDER BY ARCAItemLevel", piID);
            return GetDataSet(strQuery);
        }

	}
	#endregion
}