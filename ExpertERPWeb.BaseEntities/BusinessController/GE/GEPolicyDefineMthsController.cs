
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEPolicyDefineMths
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.88)
	//Class: GEPolicyDefineMthsController
	//Created Date: Tuesday, 04 Apr 2017
	//-----------------------------------------------------------
	
	public class GEPolicyDefineMthsController : BaseBusinessController
	{
		public GEPolicyDefineMthsController()
		{
			dal = new DALBaseProvider("GEPolicyDefineMths",typeof(GEPolicyDefineMthsInfo));
		}
        public GEPolicyDefineMthsInfo GetGEPolicyDefineMthByOrder(int iGEPolicyDefineID)
        {
            string strQuery = string.Format(@"  SELECT  *
                                                FROM    dbo.GEPolicyDefineMths
                                                WHERE   AAStatus = 'Alive'
                                                        AND FK_GEPolicyDefineID = {0}
                                                ORDER BY GEPolicyDefineMthOrder DESC", iGEPolicyDefineID);
            DataSet ds = GetDataSet(strQuery);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                return (GEPolicyDefineMthsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public DataSet GetAllGEPolicyDefineMthByGEPolicyDefineID(int iGEPolicyDefineID)
        {
            string strQuery = string.Format(@"  SELECT  *
                                                FROM    dbo.GEPolicyDefineMths
                                                WHERE   AAStatus = 'Alive'
                                                        AND FK_GEPolicyDefineID = {0}
                                                ORDER BY GEPolicyDefineMthOrder ASC;", iGEPolicyDefineID);
            return GetDataSet(strQuery);
        }

    }
	#endregion
}