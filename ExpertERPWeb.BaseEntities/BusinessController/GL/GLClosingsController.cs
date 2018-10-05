using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLClosings
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLClosingsController
	//Created Date:14 Tháng Mười Một 2013
	//-----------------------------------------------------------
	
	public class GLClosingsController:BaseBusinessController
	{
		public GLClosingsController()
		{
			dal= new DALBaseProvider("GLClosings",typeof(GLClosingsInfo));
        }

        #region Lấy khóa số theo chứng từ --Vinh -- 2013.11.15

        public GLClosingsInfo GetClosingByModuleName(String strSTModuleName)
        {
            String str = String.Format(@"   SELECT * FROM dbo.GLClosings
                                            WHERE AAStatus = 'Alive'
                                            AND FK_STModuleID IN (
						                                            SELECT STModuleID FROM dbo.STModules
						                                            WHERE STModuleName LIKE '{0}'
					                                              )", strSTModuleName);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return (GLClosingsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        #endregion

        #region Kiểm tra chứng từ có bị khóa số theo ngày--Vinh -- 2013.11.15

        public Boolean CheckModuleNameLock(String strSTModuleName, DateTime dtLock)
        {
            String str = String.Format(@"   SELECT * FROM dbo.GLClosings
                                            WHERE AAStatus = 'Alive'
                                            AND CONVERT(VARCHAR, GLClosingDateLock, 112) >= '{0}'
                                            AND FK_STModuleID IN (
						                                            SELECT STModuleID FROM dbo.STModules
						                                            WHERE STModuleName LIKE '{1}'
					                                              )", dtLock.ToString("yyyyMMdd"), strSTModuleName);
            DataSet ds = dal.GetDataSet(str);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Lay Danh Sach Cac Module Dang Duoc Su Dung --Vinh -- 2013.11.29

        public DataSet GetAllModuleUse()
        {
            String str = String.Format(@"   SELECT * FROM dbo.STModules
                                            WHERE STModuleID IN (
						                                            SELECT STModuleID FROM dbo.STModuleToUserGroupSections
						                                            WHERE STUserGroupSectionID IN (
															                                            SELECT ADUserGroupSectionID FROM dbo.ADUserGroupSections
															                                            WHERE ADUserGroupID IN (
																						                                            SELECT ADUserGroupID FROM dbo.ADUserGroups
																						                                            WHERE AAStatus = 'Alive'
																					                                            )
														                                            )
					                                            )");
            return dal.GetDataSet(str);
        }

        #endregion
    }
	#endregion
}