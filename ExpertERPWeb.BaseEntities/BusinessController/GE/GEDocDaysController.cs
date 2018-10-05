using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEDocDays
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GEDocDaysController
	//Created Date:Tuesday, December 18, 2012
	//-----------------------------------------------------------
	
	public class GEDocDaysController:BaseBusinessController
	{
		public GEDocDaysController()
		{
			dal= new DALBaseProvider("GEDocDays",typeof(GEDocDaysInfo));
		}
        public GEDocDaysInfo GetObjectByUserGroupAndModule(string strUserGroup,string strModule)
        {
            string strQuery = string.Format(@"Select * from GEDocDays where AAStatus='Alive' AND 
                                                     FK_STModuleID in (Select STModuleID from STModules where STModuleName='{0}')
                                                    AND FK_ADUserID=0
                                                    AND FK_ADUserGroupID in (Select ADUserGroupID from ADUserGroups where ADUserGroupName='{1}')", strModule, strUserGroup);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (GEDocDaysInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
        public GEDocDaysInfo GetObjectByUserAndModule(string strUser, string strModule)
        {
            string strQuery = string.Format(@"Select * from GEDocDays where AAStatus='Alive' AND 
                                                     FK_STModuleID in (Select STModuleID from STModules where STModuleName='{0}')
                                                    AND FK_ADUserID in (Select ADUserID from ADUsers where ADUserName='{1}')", strModule, strUser);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (GEDocDaysInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
	}
	#endregion
}