using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustomerReqItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustomerReqItemsController
	//Created Date:16 Tháng Tư 2014
	//-----------------------------------------------------------
	
	public class ARCustomerReqItemsController:BaseBusinessController
	{
		public ARCustomerReqItemsController()
		{
			dal= new DALBaseProvider("ARCustomerReqItems",typeof(ARCustomerReqItemsInfo));
        }

        #region Lấy tất cả ARCustomerReqItems mà có Value không phải là con của thuộc tính --Vinh

        public DataSet GetAllARCustomerReqItemValueNotInConfig(int iARCustomerReqAttrID)
        {
            String str = String.Format(@"   SELECT * FROM dbo.ARCustomerReqItems
                                            WHERE AAStatus = 'Alive'
                                            AND FK_ARCustomerReqAttrID = {0}
                                            AND ARCustomerReqItemValue NOT IN (
                                                                                SELECT ARCustomerReqAttrItemNo FROM dbo.ARCustomerReqAttrItems
                                                                                WHERE AAStatus = 'Alive'
                                                                                AND FK_ARCustomerReqAttrID = {0}
                                                                                )
                                            ", iARCustomerReqAttrID);
            return dal.GetDataSet(str);
        }

        #endregion
        #region Lấy ARCustomerReqItems By ARCustomerReqID
        //public DataSet LayARCustomerReqItems(int iARCustomerReqID)
        //{
        //    String strQuery = String.Format(@"SELECT * FROM dbo.ARCustomerReqItems WHERE FK_ARCustomerReqID = {0}", iARCustomerReqID);
        //    return GetDataSet(strQuery);
        //}
        public DataSet LayARCustomerReqItems(int iARCustomerProductReqID)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARCustomerReqItems WHERE AAStatus='Alive' AND FK_ARCustomerProductReqItemID IN(
										SELECT ARCustomerProductReqItemID FROM dbo.ARCustomerProductReqItems
										WHERE AAStatus='Alive' AND ARCustomerProductReqItemID ={0})", iARCustomerProductReqID);
            return GetDataSet(strQuery);
        }
        #endregion
        public DataSet GetAllDataByTypeAndCustomerReqID(int iObjectID, string strType = "Type")
        {
            return GetAllDataByColumns(new string[] { "ARCustomerReqItemTypeCombo", "FK_ARCustomerReqID" }, new object[] { strType, iObjectID });
        }
        public DataSet GetAllDataByListTypeAndCustomerReqID(int iObjectID, params string[] arrType)
        {
            return GetDataSet(string.Format("SELECT * FROM {0} WHERE AAStatus = 'Alive' AND FK_ARCustomerReqID = {1} AND ARCustomerReqItemTypeCombo IN('{2}')", dal.TableName, iObjectID, string.Join("','", arrType)));
        }
        public DataSet GetAllDataByListTypeAndReqIDAndProReqID(int iObjectID, int iProObjectID, params string[] arrType)
        {
            string strSubQuery = "";
            if (iProObjectID > 0) strSubQuery = string.Format(" AND FK_ARCustomerProductReqItemID = {0}", iProObjectID);
            return GetDataSet(string.Format("SELECT * FROM {0} WHERE AAStatus = 'Alive' AND FK_ARCustomerReqID = {1} {3} AND ARCustomerReqItemTypeCombo IN('{2}')", dal.TableName, iObjectID, string.Join("','", arrType), strSubQuery));
        }
    }
	#endregion
}