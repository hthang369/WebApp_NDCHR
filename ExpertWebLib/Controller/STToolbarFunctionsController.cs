using System;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STToolbarFunctions
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STToolbarFunctionsController
    //Created Date: Monday, 06 Aug 2018
    //-----------------------------------------------------------
    
    public class STToolbarFunctionsController : BaseBusinessController
    {
        readonly string spGetSTToolbarFunctionsBySTToolbarIDAndSTToolbarFunctionFullNameAndSTToolbarFunctionClass = "STToolbarFunctions_SelectBySTToolbarIDAndSTToolbarFunctionFullNameAndSTToolbarFunctionClass";
        private readonly string spGetMaxSortOrderFunctionBySTToolbarID = "STToolbarFunctions_SelectMaxSTToolbarFunctionSortOrderBySTToolbarID";
        private readonly string spGetSTToolbarFunctionsBySTModuleIDAndSTUserGroupID = "STToolbarFunctions_SelectBySTModuleIDAndSTUserGroupID";
        public STToolbarFunctionsController()
        {
            dal = new DALBaseProvider("STToolbarFunctions",typeof(STToolbarFunctionsInfo));
        }
        public int GetMaxSortOrderFunctionByToolbarID(int iToolbarID)
        {
            int num = 0;
            try
            {
                object[] paramValues = new object[] { iToolbarID };
                DataSet dataSet = base.dal.GetDataSet(this.spGetMaxSortOrderFunctionBySTToolbarID, paramValues);
                if (((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows.Count > 0)) && (dataSet.Tables[0].Rows[0][0] != null))
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

        public STToolbarFunctionsInfo GetToolbarFunctionByToolbarIDAndFunctionFullNameAndFunctionClass(int iSTToobarID, string strSTToolbarFunctionFullName, string strSTToolbarFunctionClass)
        {
            object[] paramValues = new object[] { iSTToobarID, strSTToolbarFunctionFullName, strSTToolbarFunctionClass };
            return (STToolbarFunctionsInfo)base.dal.GetDataObject(this.spGetSTToolbarFunctionsBySTToolbarIDAndSTToolbarFunctionFullNameAndSTToolbarFunctionClass, paramValues);
        }

        public DataSet GetToolbarFunctionsBySTModuleIDAndSTUserGroupID(int iSTModuleID, int iSTUserGroupID)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTUserGroupID };
            DataSet dataSet = base.dal.GetDataSet(this.spGetSTToolbarFunctionsBySTModuleIDAndSTUserGroupID, paramValues);
            if (((dataSet != null) && (dataSet.Tables.Count != 0)) && (dataSet.Tables[0].Rows.Count != 0))
            {
                return dataSet;
            }
            object[] objArray2 = new object[] { iSTModuleID, 1 };
            return base.dal.GetDataSet(this.spGetSTToolbarFunctionsBySTModuleIDAndSTUserGroupID, objArray2);
        }
    }
    #endregion
}