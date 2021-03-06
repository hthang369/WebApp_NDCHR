using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ExpertWebLib
{
    #region ADConfigValues
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: ADConfigValuesController
    //Created Date: Monday, 06 Aug 2018
    //-----------------------------------------------------------
    
    public class ADConfigValuesController : BaseBusinessController
    {
        public ADConfigValuesController()
        {
            dal = new DALBaseProvider("ADConfigValues",typeof(ADConfigValuesInfo));
        }
        public List<string> GetADConfigValueGroups()
        {
            List<string> list = new List<string>();
            using (DataSet set = GMCUtil.LoadCacheXML("ConfigValueGroups"))
            {
                if (set.Tables.Count > 0)
                {
                    set.Tables[0].AsEnumerable().Select<DataRow, string>(x => x.Field<string>("ADConfigKeyGroup")).ToList<string>();
                }
            }
            return list;
        }

        public ADConfigValuesInfo GetADConfigValuesByConfigKey(string strADConfigKey)
        {
            object[] paramValues = new object[] { strADConfigKey };
            return (ADConfigValuesInfo)base.dal.GetDataObject("ADConfigValues_SelectByADConfigKey", paramValues);
        }

        public DataSet GetADConfigValuesByGroup(string strADConfigKeyGroup)
        {
            object[] paramValues = new object[] { strADConfigKeyGroup };
            return base.dal.GetDataSet("ADConfigValues_SelectByADConfigKeyGroup", paramValues);
        }

        public string GetADConfigValueText(string strKeyGroup, string strKeyValue)
        {
            string strQuery = string.Format(@"SELECT ADConfigText
FROM dbo.ADConfigValues(NOLOCK)
WHERE AAStatus = 'Alive'
    AND ADConfigKeyGroup = '{0}'
    AND ADConfigKeyValue = '{1}'", strKeyGroup, strKeyValue);
            DataSet dataSet = base.dal.GetDataSet(strQuery);
            if (((dataSet != null) && (dataSet.Tables.Count > 0)) && ((dataSet.Tables[0].Rows.Count > 0) && (dataSet.Tables[0].Rows[0][0] != DBNull.Value)))
            {
                return Convert.ToString(dataSet.Tables[0].Rows[0][0]);
            }
            return "";
        }
    }
    #endregion
}