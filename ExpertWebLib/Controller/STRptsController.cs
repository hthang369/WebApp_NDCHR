using System;
using System.Data;
using System.Linq;

namespace ExpertWebLib
{
    public class STRptsController : BaseBusinessController
    {
        public STRptsController()
        {
            base.dal = new DALBaseProvider("STRpts", typeof(STRptsInfo));
        }

        public DataSet GetAllData_ByAll_FK_STUserGroup(int iFK_ADUserGroupID, int iFK_STModuleID)
        {
            object[] paramValues = new object[] { iFK_ADUserGroupID, iFK_STModuleID };
            DataSet dataSet = base.dal.GetDataSet("STRpts_SelectAllSTRpts_ByAll_FK_STUserGroup", paramValues);
            if (((dataSet == null) || (dataSet.Tables.Count == 0)) || (dataSet.Tables[0].Rows.Count == 0))
            {
                object[] objArray2 = new object[] { 1, iFK_STModuleID };
                dataSet = base.dal.GetDataSet("STRpts_SelectAllSTRpts_ByAll_FK_STUserGroup", objArray2);
            }
            return dataSet;
        }

        public DataSet GetAllData_ByGroupName(string strGroupName)
        {
            object[] paramValues = new object[] { strGroupName };
            return base.dal.GetDataSet("STRpts_SelectAll_ByGroup", paramValues);
        }

        public DataSet GetAllData_ByGroupName_And_FK_STUserGroup(string strGroupName, int iFK_ADUserGroupID, int iFK_STModuleID)
        {
            object[] paramValues = new object[] { strGroupName, iFK_ADUserGroupID, iFK_STModuleID };
            DataSet dataSet = base.dal.GetDataSet("STRpts_SelectAll_ByGroupName_And_FK_STUserGroup", paramValues);
            if (((dataSet == null) || (dataSet.Tables.Count == 0)) || (dataSet.Tables[0].Rows.Count == 0))
            {
                object[] objArray2 = new object[] { strGroupName, 1, iFK_STModuleID };
                dataSet = base.dal.GetDataSet("STRpts_SelectAll_ByGroupName_And_FK_STUserGroup", objArray2);
            }
            return dataSet;
        }

        public DataSet GetAllGroup()
        {
            return base.dal.GetDataSet("STRpts_SelectAllGroup");
        }

        public DataSet GetAllGroup_ByAll_FK_STUserGroup(int iFK_ADUserGroupID, int iFK_STModuleID)
        {
            object[] paramValues = new object[] { iFK_ADUserGroupID, iFK_STModuleID };
            DataSet dataSet = base.dal.GetDataSet("STRpts_SelectAllSTRptGroup_ByAll_FK_STUserGroup", paramValues);
            if (((dataSet == null) || (dataSet.Tables.Count == 0)) || (dataSet.Tables[0].Rows.Count == 0))
            {
                object[] objArray2 = new object[] { 1, iFK_STModuleID };
                dataSet = base.dal.GetDataSet("STRpts_SelectAllSTRptGroup_ByAll_FK_STUserGroup", objArray2);
            }
            return dataSet;
        }
    }
}
