using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICInventoryStockLotNos
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICInventoryStockLotNosController
	//Created Date:11 Tháng Mười 2012
	//-----------------------------------------------------------
	
	public class ICInventoryStockLotNosController:BaseBusinessController
	{
		public ICInventoryStockLotNosController()
		{
			dal= new DALBaseProvider("ICInventoryStockLotNos",typeof(ICInventoryStockLotNosInfo));
		}
        public ICInventoryStockLotNosInfo GetInventoryStockLotNoByProductANDStockANDLotNo(int iProductID, int iStockID, String strLotNo)
        {
            String str = String.Format(@"SELECT * FROM ICInventoryStockLotNos WHERE AAStatus='Alive' AND FK_ICProductID={0} AND FK_ICStockID={1} AND ICInventoryStockLotNoProductLotNo='{2}'", iProductID, iStockID, strLotNo);
            DataSet ds = dal.GetDataSet(str);
            if (ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                ICInventoryStockLotNosInfo InventoryStockLotNoInfo = (ICInventoryStockLotNosInfo)new ICInventoryStockLotNosController().GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return InventoryStockLotNoInfo;
            }
            return null;
        }

        /// <summary>
        /// Viet Nguyen 
        /// Get InvStockLotNo By Product, Stock, And Like '?LotNo'
        /// </summary>
        public DataSet GetAllDataByProductANDStockANDLotNo(int iProductID, int iStockID, String strLotNo = null)
        {
            String str = String.Format(@"SELECT * FROM ICInventoryStockLotNos WHERE AAStatus='Alive' AND (FK_ICProductID={0} OR {0}=0) AND (FK_ICStockID={1} OR {1}=0)                                        
                                      AND ICInventoryStockLotNoQuantity>0 ", iProductID, iStockID, strLotNo);

            if(strLotNo != null&&strLotNo!=string.Empty)
            {
                str += String.Format(@" AND ICInventoryStockLotNoProductLotNo LIKE '{0}'", strLotNo);
            }
            return dal.GetDataSet(str);
        }

        /// <summary>
        /// Viet Nguyen 
        /// Get InvStockLotNo By  Stock, And Like '?LotNo'
        /// </summary>
        public DataSet GetAllDataByStockANDLotNo(int iStockID, String strLotNo)
        {
            String str = String.Format(@"SELECT * FROM ICInventoryStockLotNos WHERE AAStatus='Alive'  AND FK_ICStockID={0} 
                                        AND ICInventoryStockLotNoProductLotNo like N'%{1}'
                                      AND ICInventoryStockLotNoQuantity>0 ", iStockID, strLotNo);
            return dal.GetDataSet(str);
        }

        /// <summary>
        /// QQuyen - 5.11.14
        /// </summary>
        public DataSet GetDataLotNo(String strLotNo)
        {
            String str = String.Format(@" SELECT TOP 1 ICInventoryStockLotNoProductLotNo
                                          FROM dbo.ICInventoryStockLotNos
                                          WHERE AAStatus = 'Alive'  
                                                AND ICInventoryStockLotNoProductLotNo LIKE '{0}%'   
                                                ORDER BY ICInventoryStockLotNoProductLotNo DESC", strLotNo);
            return dal.GetDataSet(str);
        }

        public Boolean CheckLotNoExist(String strLotNo)
        {
            String str = String.Format(@" SELECT TOP 1 ICInventoryStockLotNoProductLotNo
                                          FROM dbo.ICInventoryStockLotNos
                                          WHERE AAStatus = 'Alive'  
                                                AND ICInventoryStockLotNoProductLotNo = '{0}'   
                                                ORDER BY ICInventoryStockLotNoProductLotNo DESC", strLotNo);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }
	}
	#endregion
}