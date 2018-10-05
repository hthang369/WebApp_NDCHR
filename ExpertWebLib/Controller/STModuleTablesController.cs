using System;
using System.Data;
using System.Linq;

namespace ExpertWebLib
{
    public class STModuleTablesController : BaseBusinessController
    {
        private readonly string spGetSTModuleTablesBySTModuleID = "STModuleTables_SelectBySTModuleID";
        private readonly string spGetTablesOfSTModuleTablesBySTModuleID = "STModuleTables_SelectTablesOfSTModuleTablesBySTModuleID";
        private readonly string spGetTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableName = "STModuleTables_SelectTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableName";
        private readonly string spGetTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex = "STModuleTables_SelectTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex";
        private readonly string spGetMaxSTModuleTableLevelIndexOfTablesBySTModuleID = "STModuleTables_SelectMaxSTModuleTableLevelIndexOfTablesBySTModuleID";
        private readonly string spGetViewsOfSTModuleTablesBySTModuleID = "STModuleTables_SelectViewsOfSTModuleTablesBySTModuleID";
        private readonly string spGetViewsOfSTModuleTablesBySTModuleIDAndSTModuleTableName = "STModuleTables_SelectViewsOfSTModuleTablsBySTModuleIDAndSTModuleTableName";
        private readonly string spGetViewsOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex = "STModuleTables_SelectViewsOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex";
        private readonly string spGetMaxSTModuleTableLevelIndexOfViewsBySTModuleID = "STModuleTables_SelectMaxSTModuleTableLevelIndexOfViewsBySTModuleID";
        private readonly string spDeleteSTModuleTablesBySTModuleID = "STModuleTables_DeleteBySTModuleID";

        public STModuleTablesController()
        {
            base.dal = new DALBaseProvider("STModuleTables", typeof(STModuleTablesInfo));
        }

        public void DeleteSTModuleTablesBySTModuleID(int iSTModuleID)
        {
            object[] paramValues = new object[] { iSTModuleID };
            base.dal.GetDataSet(this.spDeleteSTModuleTablesBySTModuleID, paramValues);
        }

        public int GetMaxLevelIndexOfTablesBySTModuleID(int iSTModuleID)
        {
            int num = 0;
            try
            {
                object[] paramValues = new object[] { iSTModuleID };
                DataSet dataSet = base.dal.GetDataSet(this.spGetMaxSTModuleTableLevelIndexOfTablesBySTModuleID, paramValues);
                if (dataSet.Tables.Count <= 0)
                {
                    return num;
                }
                if (dataSet.Tables[0].Rows.Count <= 0)
                {
                    return num;
                }
                if (dataSet.Tables[0].Rows[0][0] != null)
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

        public int GetMaxLevelIndexOfViewsBySTModuleID(int iSTModuleID)
        {
            int num = 0;
            try
            {
                object[] paramValues = new object[] { iSTModuleID };
                DataSet dataSet = base.dal.GetDataSet(this.spGetMaxSTModuleTableLevelIndexOfViewsBySTModuleID, paramValues);
                if (dataSet.Tables.Count <= 0)
                {
                    return num;
                }
                if (dataSet.Tables[0].Rows.Count <= 0)
                {
                    return num;
                }
                if (dataSet.Tables[0].Rows[0][0] != null)
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

        public DataSet GetModuleTablesByModuleID(int iModuleID)
        {
            object[] paramValues = new object[] { iModuleID };
            return base.dal.GetDataSet(this.spGetSTModuleTablesBySTModuleID, paramValues);
        }

        public STModuleTablesInfo GetTableOfModuleTablesByModuleIDAndTableName(int iModuleID, string strTableName)
        {
            object[] paramValues = new object[] { iModuleID, strTableName };
            return (STModuleTablesInfo)base.dal.GetDataObject(this.spGetTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableName, paramValues);
        }

        public DataSet GetTablesOfModuleTablesByModuleID(int iModuleID)
        {
            object[] paramValues = new object[] { iModuleID };
            return base.dal.GetDataSet(this.spGetTablesOfSTModuleTablesBySTModuleID, paramValues);
        }

        public DataSet GetTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex(int iSTModuleID, int iSTModuleTableLevelIndex)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTModuleTableLevelIndex };
            return base.dal.GetDataSet(this.spGetTablesOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex, paramValues);
        }

        public STModuleTablesInfo GetViewOfModuleTablesByModuleIDAndTableName(int iModuleID, string strTableName)
        {
            object[] paramValues = new object[] { iModuleID, strTableName };
            return (STModuleTablesInfo)base.dal.GetDataObject(this.spGetViewsOfSTModuleTablesBySTModuleIDAndSTModuleTableName, paramValues);
        }

        public DataSet GetViewsOfModuleTablesByModuleID(int iModuleID)
        {
            object[] paramValues = new object[] { iModuleID };
            return base.dal.GetDataSet(this.spGetViewsOfSTModuleTablesBySTModuleID, paramValues);
        }

        public DataSet GetViewsOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex(int iSTModuleID, int iSTModuleTableLevelIndex)
        {
            object[] paramValues = new object[] { iSTModuleID, iSTModuleTableLevelIndex };
            return base.dal.GetDataSet(this.spGetViewsOfSTModuleTablesBySTModuleIDAndSTModuleTableLevelIndex, paramValues);
        }
    }
}
