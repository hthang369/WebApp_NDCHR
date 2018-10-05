using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARPmtTermItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARPmtTermItemsController
	//Created Date:14 Tháng Sáu 2011
	//-----------------------------------------------------------
	
	public class ARPmtTermItemsController:BaseBusinessController
	{
		public ARPmtTermItemsController()
		{
			dal= new DALBaseProvider("ARPmtTermItems",typeof(ARPmtTermItemsInfo));
		}

        public ARPmtTermItemsInfo GetObjectByPmtTermIDAndDayDue(int PmtTermID, int daydue)
        {
            String query = String.Format("Select * From ARPmtTermItems Where AAStatus = 'Alive' And FK_ARPmtTermID = {0} And ARPmtMthTermDueDateRange >= {1} Order By ARPmtMthTermDueDateRange", PmtTermID, daydue);
            DataSet ds = dal.GetDataSet(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ARPmtTermItemsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }
	}
	#endregion
}