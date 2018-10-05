using System;
using System.Linq;

namespace ExpertWebLib
{
    public class AATableNameAliasController : BaseBusinessController
    {
        private readonly string spGetAATableNameAliasByTableName = "AATableNameAlias_SelectByTableName";

        public AATableNameAliasController()
        {
            base.dal = new DALBaseProvider("AATableNameAlias", typeof(AATableNameAliasInfo));
        }

        public AATableNameAliasInfo GetAATableNameAliasByTableName(string strTableName)
        {
            object[] paramValues = new object[] { strTableName };
            return (AATableNameAliasInfo)base.dal.GetDataObject(this.spGetAATableNameAliasByTableName, paramValues);
        }
    }
}
