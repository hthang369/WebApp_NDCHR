using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOBOMItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPOBOMItemsController
	//Created Date:Thursday, May 09, 2013
	//-----------------------------------------------------------
	
	public class APPOBOMItemsController:BaseBusinessController
	{
		public APPOBOMItemsController()
		{
			dal= new DALBaseProvider("APPOBOMItems",typeof(APPOBOMItemsInfo));
		}

        public DataSet GetAllDataBySupplierAndProduct(int iSupplierID, int iICProductID)
        {

            string strQuery = string.Format(@"SELECT * FROM dbo.APPOBOMItems WHERE FK_APPOID IN 
                            (SELECT APPOs.APPOID FROM dbo.APPOs WHERE FK_APSupplierID={0} AND APPOs.AAStatus='Alive') AND FK_ICProductID={1} AND dbo.APPOBOMItems.AAStatus='Alive'",iSupplierID,iICProductID);

            return dal.GetDataSet(strQuery);
        }
        public DataSet GetAllDataByPOAndProduct(int iPOID, int iICProductID)
        {
            string strQuery = string.Format(@"SELECT * FROM dbo.APPOBOMItems WHERE FK_APPOID={0} AND FK_ICProductID={1}", iPOID, iICProductID);
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}