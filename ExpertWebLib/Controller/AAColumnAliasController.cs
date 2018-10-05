using System;
using System.Data;
using System.Linq;

namespace ExpertWebLib
{
    public class AAColumnAliasController : BaseBusinessController
    {
        private readonly string spGetAAColumnAliasByColumnNameAndTableName = "AAColumnAlias_SelectByColumnNameAndTableName";
        private readonly string spGetAAColumnAliasByTableName = "AAColumnAlias_SelectByTableName";

        public AAColumnAliasController()
        {
            base.dal = new DALBaseProvider("AAColumnAlias", typeof(AAColumnAliasInfo));
        }

        public void DeleteAllAliasByTableName(string strTableName)
        {
            string strQuery = string.Format("Delete From [AAColumnAlias] Where [AATableName]='{0}'", strTableName);
            base.dal.GetDataSet(strQuery);
        }

        public AAColumnAliasInfo GetAAColumnAliasByColumnNameAndTableName(string strColumnName, string strTableName)
        {
            object[] paramValues = new object[] { strColumnName, strTableName };
            return (AAColumnAliasInfo)base.dal.GetDataObject(this.spGetAAColumnAliasByColumnNameAndTableName, paramValues);
        }

        public DataSet GetAAColumnAliasByTableName(string strTableName)
        {
            object[] paramValues = new object[] { strTableName };
            return base.dal.GetDataSet(this.spGetAAColumnAliasByTableName, paramValues);
        }
    }
}
