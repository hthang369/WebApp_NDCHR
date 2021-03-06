
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEPolicyDefineMthMapCols
	//-----------------------------------------------------------
	//Generated By: SQLDBTools - LINHCLH (v2.1.88)
	//Class: GEPolicyDefineMthMapColsController
	//Created Date: Wednesday, 05 Apr 2017
	//-----------------------------------------------------------
	
	public class GEPolicyDefineMthMapColsController : BaseBusinessController
	{
		public GEPolicyDefineMthMapColsController()
		{
			dal = new DALBaseProvider("GEPolicyDefineMthMapCols",typeof(GEPolicyDefineMthMapColsInfo));
		}

        public DataSet GetAllDataByTableName(String strTableName, bool isColumn)
        {
            String strQuery = "";

            if (isColumn == false)
            {
                strQuery = String.Format(@"  Select *
                                                From GEPolicyDefineMthMapCols 
                                                Where GEPolicyDefineMthMapCols.GEPolicyDefineMthMapColTableName = '{0}'", strTableName);
            }
            else
            {
                strQuery = String.Format(@"  Select GEPolicyDefineMthMapColParameter,GEPolicyDefineMthMapColCaption
                                                From GEPolicyDefineMthMapCols 
                                                Where GEPolicyDefineMthMapCols.GEPolicyDefineMthMapColTableName = '{0}'", strTableName);
            }
            DataSet ds = GetDataSet(strQuery);
            return ds;
        }
    }
	#endregion
}