using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLBussinessRules
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLBussinessRulesController
	//Created Date:Saturday, August 23, 2014
	//-----------------------------------------------------------
	
	public class GLBussinessRulesController:BaseBusinessController
	{
		public GLBussinessRulesController()
		{
			dal= new DALBaseProvider("GLBussinessRules",typeof(GLBussinessRulesInfo));
		}
        public DataSet GetAllDataByTranCfg(int iGLTranCfgID)
        {
            string strQuery = string.Format(@"SELECT  *
                                                FROM    GLBussinessRules
                                                WHERE   GLBussinessRuleID IN ( SELECT   FK_GLBussinessRuleID
                                                                               FROM     dbo.GLTranCfgRules
                                                                               WHERE    FK_GLTranCfgID = {0} )"
                                                                   , iGLTranCfgID);
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}