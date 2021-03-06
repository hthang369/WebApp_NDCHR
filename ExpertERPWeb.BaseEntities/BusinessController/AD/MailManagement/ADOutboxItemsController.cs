using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ADOutboxItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ADOutboxItemsController
	//Created Date:29 Tháng Sáu 2012
	//-----------------------------------------------------------
	
	public class ADOutboxItemsController:BaseBusinessController
	{
		public ADOutboxItemsController()
		{
			dal= new DALBaseProvider("ADOutboxItems",typeof(ADOutboxItemsInfo));
		}

        public DataSet GetAllOutboxItemsByUser(int iUserID)
        {
            string strQuery = String.Format(@"SELECT * FROM ADOutboxItems WHERE AAStatus='Alive' AND FK_ADFromUserID = {0}", iUserID);

            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}