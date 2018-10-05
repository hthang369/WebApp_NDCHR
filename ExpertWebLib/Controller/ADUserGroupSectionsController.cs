using System;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region ADUserGroupSections
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: ADUserGroupSectionsController
    //Created Date: Friday, 03 Aug 2018
    //-----------------------------------------------------------
    
    public class ADUserGroupSectionsController : BaseBusinessController
    {
        private readonly string spGetADUserGroupSectionsByADUserGroupID = "ADUserGroupSections_SelectByADUserGroupID";
        private readonly string spGetADUserGroupSectionBySectionNameAndUserGroupID = "ADUserGroupSections_SelectByADUserGroupSectionNameAndADUserGroupID";
        private readonly string spGetMaxADUserGroupSortOrderSectionByADUserGroupID = "ADUserGroupSections_SelectMaxADUserGroupSortOrderSectionByADUserGroupID";
        public ADUserGroupSectionsController()
        {
            dal = new DALBaseProvider("ADUserGroupSections",typeof(ADUserGroupSectionsInfo));
        }
        public DataSet GetAllADUserGroupSectionsByAUserGroup(int iADUserGroupID, int iADUserGroupSectionID)
        {
            string strQuery = string.Format(@"   
                SELECT * FROM dbo.ADUserGroupSections
                WHERE ADUserGroupID = {0}
                    AND FK_ADParentUserGroupSectionID = {1}
                ORDER BY ADUserGroupSectionSortOrder ASC", iADUserGroupID, iADUserGroupSectionID);
            return base.dal.GetDataSet(strQuery);
        }

        public int GetMaxSortOrderSectionByUserGroupID(int iUserGroupID)
        {
            int num = 0;
            try
            {
                object[] paramValues = new object[] { iUserGroupID };
                DataSet dataSet = base.dal.GetDataSet(this.spGetMaxADUserGroupSortOrderSectionByADUserGroupID, paramValues);
                if ((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows[0][0] != null))
                {
                    num = Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
                }
            }
            catch (Exception)
            {
                num = 0;
            }
            return num;
        }

        public ADUserGroupSectionsInfo GetUserGroupSectionBySectionNameAndUserGroupID(string strADUserGroupSectionName, int iUserGroupID)
        {
            object[] paramValues = new object[] { iUserGroupID, strADUserGroupSectionName };
            return (ADUserGroupSectionsInfo)base.dal.GetDataObject(this.spGetADUserGroupSectionBySectionNameAndUserGroupID, paramValues);
        }

        public DataSet GetUserGroupSectionByUserGroupID(int iUserGroupID)
        {
            object[] paramValues = new object[] { iUserGroupID };
            return base.dal.GetDataSet(this.spGetADUserGroupSectionsByADUserGroupID, paramValues);
        }

        public int GetUserGroupSectionIDBySectionNameAndUserGroupID(string strADUserGroupSectionName, int iUserGroupID)
        {
            int aDUserGroupSectionID = 0;
            ADUserGroupSectionsInfo userGroupSectionBySectionNameAndUserGroupID = new ADUserGroupSectionsInfo();
            userGroupSectionBySectionNameAndUserGroupID = this.GetUserGroupSectionBySectionNameAndUserGroupID(strADUserGroupSectionName, iUserGroupID);
            if (userGroupSectionBySectionNameAndUserGroupID != null)
            {
                aDUserGroupSectionID = userGroupSectionBySectionNameAndUserGroupID.ADUserGroupSectionID;
            }
            return aDUserGroupSectionID;
        }

        public bool IsExist(string strADUserGroupSectionName, int iUserGroupID)
        {
            bool flag = false;
            if (this.GetUserGroupSectionBySectionNameAndUserGroupID(strADUserGroupSectionName, iUserGroupID) != null)
            {
                flag = true;
            }
            return flag;
        }
    }
    #endregion
}