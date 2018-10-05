using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLPeriodTransferItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLPeriodTransferItemsController
	//Created Date:06 Tháng Ba 2013
	//-----------------------------------------------------------
	
	public class GLPeriodTransferItemsController:BaseBusinessController
	{
		public GLPeriodTransferItemsController()
		{
			dal= new DALBaseProvider("GLPeriodTransferItems",typeof(GLPeriodTransferItemsInfo));
		}

        public DataSet GetAllItemOrderAction(int iPeriodTransferID)
        {
            String strQuery = String.Format(@"SELECT * FROM GLPeriodTransferItems
                                                WHERE FK_GLPeriodTransferID = {0}
                                                ORDER BY ActionOrdr", iPeriodTransferID);
            return GetDataSet(strQuery);
        }
	}
	#endregion
}