using System;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STFields
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STFieldsController
    //Created Date: Friday, 03 Aug 2018
    //-----------------------------------------------------------
    
    public class STFieldsController : BaseBusinessController
    {
        private readonly string spGetSTFieldsBySTScreenID = "STFields_SelectBySTScreenID";
        private readonly string spGetSTFieldsBySTUserGroupIDAndSTScreenID = "STFields_SelectBySTUserGroupIDAndSTScreenID";
        private readonly string spGetActiveSTFieldsBySTUserGroupIDAndSTScreenID = "STFields_SelectActiveSTFieldsBySTUserGroupIDAndSTScreenID";
        private readonly string spGetSTFieldsBySTFieldNameAndSTScreenID = "STFields_SelectBySTFieldNameAndSTScreenID";
        private readonly string spGetSTFieldBySTFieldNameAndSTScreenIDAndSTUserGroupID = "STFields_SelectBySTFieldNameAndSTScreenIDAndSTUserGroupID";
        private readonly string spGetSTFieldBySTScreenIDAndSTUserGroupIDAndSTFieldType = "STFields_SelectBySTScreenIDAndSTUserGroupIDAndSTFieldType";
        private readonly string spGetSTFieldByModuleNameAndSTUserGroupIDAndSTFieldType = "STFields_SelectBySTModuleNameAndSTUserGroupIDAndSTFieldType";
        private readonly string spGetSTFieldsBySTModuleIDAndSTUserGroupID = "STFields_SelectBySTModuleIDAndSTUserGroupID";
        private readonly string spGetSTFieldBySTModuleIDAndSTUserGroupIDAndSTFieldTag = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldTag";
        private readonly string spGetSTFieldBySTModuleIDAndSTUserGroupIDAndSTFieldGroup = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldGroup";
        private readonly string spGetSTFieldBySTScreenIDAndSTUserGroupIDAndSTFieldTag = "STFields_SelectBySTScreenIDAndSTUserGroupIDAndSTFieldTag";
        private readonly string spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMember = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMember";
        private readonly string spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldTag = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldTag";
        private readonly string spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldGroup = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberANDSTFieldGroup";
        private readonly string spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldType = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldType";
        private readonly string spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldTypeAndSTFieldTag = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldTypeAndSTFieldTag";
        private readonly string spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldName = "STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldName";
        private readonly string spGetSTFieldsBySTFieldParentID = "STFields_SelectBySTFieldParentID";
        private readonly string spDeleteSTFieldsBySTScreenID = "STFields_DeleteBySTScreenID";
        private readonly string spDeleteSTFieldsBySTScreenIDAndSTUserGroupID = "STFields_DeleteBySTScreenIDAndSTUserGroupID";
        private readonly string spGetSTFieldsBySTScreenIDAndSTFieldDataMemberNotNullAndNotSpaceAndNotDash = "STFields_SelectBySTScreenIDAndSTFieldDataMemberNotNullAndNotSpaceAndNotDash";
        public STFieldsController()
        {
            dal = new DALBaseProvider("STFields",typeof(STFieldsInfo));
        }
        public void DeleteFieldsByScreenID(int iScreenID)
        {
            object[] paramValues = new object[] { iScreenID };
            base.dal.GetDataSet(this.spDeleteSTFieldsBySTScreenID, paramValues);
        }

        public void DeleteSTFieldsBySTScreenIDAndSTUserGroupID(int iSTScreenID, int iSTUserGroupID)
        {
            object[] paramValues = new object[] { iSTScreenID, iSTUserGroupID };
            base.dal.GetDataSet(this.spDeleteSTFieldsBySTScreenIDAndSTUserGroupID, paramValues);
        }

        public DataSet GetActiveFieldsByScreenIDAndUserGroupID(int iScreenID, int iUserGroupID)
        {
            object[] paramValues = new object[] { iScreenID, iUserGroupID };
            DataSet dataSet = base.dal.GetDataSet(this.spGetActiveSTFieldsBySTUserGroupIDAndSTScreenID, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iScreenID, 1 };
            return base.dal.GetDataSet(this.spGetActiveSTFieldsBySTUserGroupIDAndSTScreenID, objArray2);
        }

        public DataSet GetAllFieldsByScreenID(int iScreenID)
        {
            object[] paramValues = new object[] { iScreenID };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTScreenID, paramValues);
        }

        public DataSet GetAllFieldsByScreenIDAndSTFieldDataMemberNotNullAndNotSpaceAndNotDash(int iScreenID)
        {
            object[] paramValues = new object[] { iScreenID };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTScreenIDAndSTFieldDataMemberNotNullAndNotSpaceAndNotDash, paramValues);
        }

        public DataSet GetAllFieldsByScreenIDOrderByTabIndex(int iScreenID)
        {
            string strQuery = string.Format("Select * From [STFields] Where [STScreenID] IN ( Select [STScreenID] From [STScreens] Where [STScreenID]={0}) Order By [STFieldTabIndex]", iScreenID);
            return this.GetDataSet(strQuery);
        }

        public DataSet GetAllFieldsBySTFieldParentID(int iFieldParentID)
        {
            object[] paramValues = new object[] { iFieldParentID };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTFieldParentID, paramValues);
        }

        public STFieldsInfo GetField(string strFieldName, int iScreenID)
        {
            object[] paramValues = new object[] { strFieldName, iScreenID };
            return (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTFieldNameAndSTScreenID, paramValues);
        }

        public STFieldsInfo GetFieldByFieldNameAndScreenIDAndUserGroupID(string strFieldName, int iScreenID, int iUserGroupID)
        {
            object[] paramValues = new object[] { iScreenID, iUserGroupID, strFieldName };
            STFieldsInfo dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldBySTFieldNameAndSTScreenIDAndSTUserGroupID, paramValues);
            if (dataObject == null)
            {
                object[] objArray2 = new object[] { iScreenID, 1, strFieldName };
                dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldBySTFieldNameAndSTScreenIDAndSTUserGroupID, objArray2);
            }
            return dataObject;
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldDataMember(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataMember)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataMember };
            DataSet dataSet = base.dal.GetDataSet("STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldDataMember", paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataMember };
            return base.dal.GetDataSet("STFields_SelectBySTModuleIDAndSTUserGroupIDAndSTFieldDataMember", objArray2);
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldDataMember(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldDataMember)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldDataMember };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMember, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldDataMember };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMember, objArray2);
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldDataMemberAndFieldGroup(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldDataMember, string strSTFieldGroup)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldDataMember, strSTFieldGroup };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldGroup, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldDataMember, strSTFieldGroup };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldGroup, objArray2);
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldDataMemberAndFieldTag(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldDataMember, string strSTFieldTag)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldDataMember, strSTFieldTag };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldTag, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldDataMember, strSTFieldTag };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldTag, objArray2);
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldType(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldType)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldType };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldType, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldType };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldType, objArray2);
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldTypeAndFieldTag(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldType, string strSTFieldTag)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldType, strSTFieldTag };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldTypeAndSTFieldTag, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldType, strSTFieldTag };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldTypeAndSTFieldTag, objArray2);
        }

        public STFieldsInfo GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldTypeAndFieldTagAndLikeFieldDataMember(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldType, string strSTFieldTag, string strLikeSTFieldName)
        {
            DataSet set = this.GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldTypeAndFieldTag(iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldType, strSTFieldTag);
            if (((set == null) || (set.Tables.Count == 0)) || (set.Tables[0].Rows.Count == 0))
            {
                set = this.GetFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldTypeAndFieldTag(iSTModuleID, 1, strSTFieldDataSource, strSTFieldType, strSTFieldTag);
            }
            foreach (DataRow row in set.Tables[0].Rows)
            {
                STFieldsInfo objectFromDataRow = (STFieldsInfo)this.GetObjectFromDataRow(row);
                if (objectFromDataRow.STFieldName.Contains(strLikeSTFieldName))
                {
                    return objectFromDataRow;
                }
            }
            return null;
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldGroup(int iModuleID, int iUserGroupID, string strFieldGroup)
        {
            object[] paramValues = new object[] { iModuleID, iUserGroupID, strFieldGroup };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldBySTModuleIDAndSTUserGroupIDAndSTFieldGroup, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iModuleID, 1, strFieldGroup };
            return base.dal.GetDataSet(this.spGetSTFieldBySTModuleIDAndSTUserGroupIDAndSTFieldGroup, objArray2);
        }

        public DataSet GetFieldByModuleIDAndUserGroupIDAndFieldTag(int iModuleID, int iUserGroupID, string strFieldTag)
        {
            object[] paramValues = new object[] { iModuleID, iUserGroupID, strFieldTag };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldBySTModuleIDAndSTUserGroupIDAndSTFieldTag, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iModuleID, 1, strFieldTag };
            return base.dal.GetDataSet(this.spGetSTFieldBySTModuleIDAndSTUserGroupIDAndSTFieldTag, objArray2);
        }

        public DataSet GetFieldByModuleNameAndUserGroupIDAndFieldType(string strModuleName, int iUserGroupID, string strFieldType)
        {
            object[] paramValues = new object[] { strModuleName, iUserGroupID, strFieldType };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldByModuleNameAndSTUserGroupIDAndSTFieldType, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { strModuleName, 1, strFieldType };
            return base.dal.GetDataSet(this.spGetSTFieldByModuleNameAndSTUserGroupIDAndSTFieldType, objArray2);
        }

        public DataSet GetFieldByScreenIDAndUserGroupID(int iScreenID, int iUserGroupID)
        {
            object[] paramValues = new object[] { iScreenID, iUserGroupID };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldsBySTUserGroupIDAndSTScreenID, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iScreenID, 1 };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTUserGroupIDAndSTScreenID, objArray2);
        }

        public DataSet GetFieldByScreenIDAndUserGroupIDAndFieldTag(int iScreenID, int iUserGroupID, string strFieldTag)
        {
            object[] paramValues = new object[] { iScreenID, iUserGroupID, strFieldTag };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldBySTScreenIDAndSTUserGroupIDAndSTFieldTag, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iScreenID, 1, strFieldTag };
            return base.dal.GetDataSet(this.spGetSTFieldBySTScreenIDAndSTUserGroupIDAndSTFieldTag, objArray2);
        }

        public DataSet GetFieldByScreenIDAndUserGroupIDAndFieldType(int iScreenID, int iUserGroupID, string strFieldType)
        {
            object[] paramValues = new object[] { iScreenID, iUserGroupID, strFieldType };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldBySTScreenIDAndSTUserGroupIDAndSTFieldType, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iScreenID, 1, strFieldType };
            return base.dal.GetDataSet(this.spGetSTFieldBySTScreenIDAndSTUserGroupIDAndSTFieldType, objArray2);
        }

        public DataSet GetFieldBySTModuleIDAndSTUserGroupID(int iSTModuleID, int iSTUserGroupID)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupID, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1 };
            return base.dal.GetDataSet(this.spGetSTFieldsBySTModuleIDAndSTUserGroupID, objArray2);
        }

        public STFieldsInfo GetFieldBySTModuleIDAndSTUserGroupIDAndSTFieldName(int iSTModuleID, int iSTUserGroupID, string strSTFieldName)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldName };
            STFieldsInfo dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldName, paramValues);
            if (dataObject == null)
            {
                object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldName };
                dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldName, objArray2);
            }
            return dataObject;
        }

        public STFieldsInfo GetFirstFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldDataMember(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldDataMember)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldDataMember };
            STFieldsInfo dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMember, paramValues);
            if (dataObject == null)
            {
                object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldDataMember };
                dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMember, objArray2);
            }
            return dataObject;
        }

        public STFieldsInfo GetFirstFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldDataMemberAndFieldGroup(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldDataMember, string strSTFieldGroup)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldDataMember, strSTFieldGroup };
            STFieldsInfo dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldGroup, paramValues);
            if (dataObject == null)
            {
                object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldDataMember, strSTFieldGroup };
                dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldGroup, objArray2);
            }
            return dataObject;
        }

        public STFieldsInfo GetFirstFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldDataMemberAndFieldTag(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldDataMember, string strSTFieldTag)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldDataMember, strSTFieldTag };
            STFieldsInfo dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldTag, paramValues);
            if (dataObject == null)
            {
                object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldDataMember, strSTFieldTag };
                dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldDataMemberAndSTFieldTag, objArray2);
            }
            return dataObject;
        }

        public STFieldsInfo GetFirstFieldByModuleIDAndUserGroupIDAndFieldDataSourceAndFieldTypeAndFieldTag(int iSTModuleID, int iSTUserGroupID, string strSTFieldDataSource, string strSTFieldType, string strSTFieldTag)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID, strSTFieldDataSource, strSTFieldType, strSTFieldTag };
            STFieldsInfo dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldTypeAndSTFieldTag, paramValues);
            if (dataObject == null)
            {
                object[] objArray2 = new object[] { iSTModuleID, 1, strSTFieldDataSource, strSTFieldType, strSTFieldTag };
                dataObject = (STFieldsInfo)base.dal.GetDataObject(this.spGetSTFieldsBySTModuleIDAndSTUserGroupIDAndSTFieldDataSourceAndSTFieldTypeAndSTFieldTag, objArray2);
            }
            return dataObject;
        }

        public bool IsExist(string strFieldName, int iScreenID)
        {
            new STFieldsInfo();
            return (this.GetField(strFieldName, iScreenID) != null);
        }
    }
    #endregion
}