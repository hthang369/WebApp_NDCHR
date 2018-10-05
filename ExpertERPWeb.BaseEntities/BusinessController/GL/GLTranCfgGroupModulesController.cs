using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTranCfgGroupModules
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLTranCfgGroupModulesController
	//Created Date:Saturday, September 06, 2014
	//-----------------------------------------------------------
	
	public class GLTranCfgGroupModulesController:BaseBusinessController
	{
		public GLTranCfgGroupModulesController()
		{
			dal= new DALBaseProvider("GLTranCfgGroupModules",typeof(GLTranCfgGroupModulesInfo));
		}
        public DataSet GetModuleSetTranCfg(string sModuleName)
        {
            String strQuery = String.Format(@"
SELECT c.*
FROM GLTranCfgGroupModules a
INNER JOIN GLTranCfgGroups b ON a.FK_GLTranCfgGroupID = b.GLTranCfgGroupID AND a.GLTranCfgGroupModuleName = '{0}'
INNER JOIN GLTranCfgs c ON c.FK_GLTranCfgGroupID = b.GLTranCfgGroupID AND c.AAStatus = 'Alive'
", sModuleName);
            return GetDataSet(strQuery);
        }
		public bool IsModuleSetTranCfg(string sModuleName)
        {
            DataSet ds = GetModuleSetTranCfg(sModuleName);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0
                && ds.Tables[0].Rows[0][0] != null && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return true;
            return false;
        }
	}
	#endregion
}