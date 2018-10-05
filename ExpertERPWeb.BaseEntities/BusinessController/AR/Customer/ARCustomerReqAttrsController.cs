using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustomerReqAttrs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustomerReqAttrsController
	//Created Date:16 Tháng Tư 2014
	//-----------------------------------------------------------
	
	public class ARCustomerReqAttrsController:BaseBusinessController
	{
		public ARCustomerReqAttrsController()
		{
			dal= new DALBaseProvider("ARCustomerReqAttrs",typeof(ARCustomerReqAttrsInfo));
		}

        #region Kiểm tra ARCustomerReqAttrs có tồn tại chưa --Vinh

        public Boolean CheckARCustomerReqAttrsExist(int iARCustomerReqAttrID, String strARCustomerReqAttrNo, int iICProductModelID, String strARCustomerReqAttrGroup)
        {
            String str = String.Format(@"   SELECT * FROM dbo.ARCustomerReqAttrs
                                            WHERE AAStatus = 'Alive'
                                            AND ARCustomerReqAttrNo LIKE '{0}'
                                            AND FK_ICProductModelID = {1}
                                            AND ARCustomerReqAttrGroup LIKE '{2}'
                                            AND (ARCustomerReqAttrID != {3} OR {3} = 0)"
                                        , strARCustomerReqAttrNo, iICProductModelID, strARCustomerReqAttrGroup, iARCustomerReqAttrID);

            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        #endregion
        
        #region Lấy tất cả ARCustomerReqAttrs theo loại thuộc tính --Vinh

        public DataSet GetAllARCustomerReqAttrByType(int iICProductModelID, Boolean isGetTypeAll)
        {
            String strType = "";
            if (isGetTypeAll)
            {
                strType = String.Format(String.Format(@" AND (
                                                                FK_ICProductModelID = {0} 
                                                                OR 
                                                                FK_ICProductModelID = 0
                                                            )", iICProductModelID));
            }
            else
            {
                strType = String.Format(String.Format(@" AND FK_ICProductModelID = {0}", iICProductModelID));
            }

            String str = String.Format(@"   SELECT * FROM dbo.ARCustomerReqAttrs
                                            WHERE AAStatus = 'Alive'
                                            {0}
                                        ", strType);

            return dal.GetDataSet(str);
        }

        #endregion

        #region Lấy tất cả ARCustomerReqAttrs theo loại thuộc tính --Vinh

        public DataSet GetAllARCustomerReqAttrByType(String strARCustomerReqAttrTypeCombo, Boolean isGetTypeAll)
        {
            String strType = "";
            if (isGetTypeAll)
            {
                strType = String.Format(String.Format(@" AND (
                                                                ARCustomerReqAttrTypeCombo LIKE '{0}' 
                                                                OR 
                                                                ARCustomerReqAttrTypeCombo LIKE 'All'
                                                            )", strARCustomerReqAttrTypeCombo));
            }
            else
            {
                strType = String.Format(String.Format(@" AND ARCustomerReqAttrTypeCombo LIKE '{0}'", strARCustomerReqAttrTypeCombo));
            }

            String str = String.Format(@"   SELECT * FROM dbo.ARCustomerReqAttrs
                                            WHERE AAStatus = 'Alive'
                                            {0}
                                        ", strType);

            return dal.GetDataSet(str);
        }

        #endregion
        
        #region Lấy tất cả ARCustomerReqAttrs là cha cùng nhất --Vinh

        public DataSet GetAllARCustomerReqAttrByFirstParent()
        {
            String str = String.Format(@"   SELECT  *
                                            FROM    dbo.ARCustomerReqAttrs
                                            WHERE   AAStatus = 'Alive'
                                                    AND ( FK_ARCustomerReqAttrID = 0
                                                          OR FK_ARCustomerReqAttrID NOT IN ( SELECT ARCustomerReqAttrID
                                                                                             FROM   dbo.ARCustomerReqAttrs
                                                                                             WHERE  AAStatus = 'Alive' )
                                                        );
                                        ");

            return dal.GetDataSet(str);
        }

        #endregion

        public int DeleteAllDataInID(List<string> lstID)
        {
            string strLstID = string.Join(",", lstID.ToArray());
            string strQuery = string.Format("DELETE FROM ARCustomerReqAttrs WHERE ARCustomerReqAttrID IN({0})", strLstID);
            return SqlDatabaseHelper.RunQueryNonDataSet(SqlDatabaseHelper.GetQuery(strQuery));
        }
        public object GetObjectColumnByID(string strColumn, int iObjectID)
        {
            ARCustomerReqAttrsInfo objCusReqAttr = (ARCustomerReqAttrsInfo)GetObjectByID(iObjectID);
            if (objCusReqAttr == null)
                objCusReqAttr = new ARCustomerReqAttrsInfo();
            return GMCDbUtil.GetPropertyValue(objCusReqAttr, strColumn);
        }
	}
	#endregion
}