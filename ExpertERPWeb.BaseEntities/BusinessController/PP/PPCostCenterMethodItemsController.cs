using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPCostCenterMethodItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPCostCenterMethodItemsController
	//Created Date:28 Tháng Mười Một 2014
	//-----------------------------------------------------------
	
	public class PPCostCenterMethodItemsController:BaseBusinessController
	{
		public PPCostCenterMethodItemsController()
		{
			dal= new DALBaseProvider("PPCostCenterMethodItems",typeof(PPCostCenterMethodItemsInfo));
		}

        public DataSet GetAllDataByCostCenterMethod(int iPPCostCenterMethodID)
        {
            String str = String.Format(@"   SELECT * FROM dbo.PPCostCenterMethodItems
                                            WHERE FK_PPCostCenterMethodID = {0}
                                            ORDER BY PPCostCenterMethodItemOrder ASC"
                                            , iPPCostCenterMethodID);
            return dal.GetDataSet(str);
        }
	}
	#endregion
}