using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICAccountSets
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICAccountSetsController
	//Created Date:Friday, May 13, 2011
	//-----------------------------------------------------------
	
	public class ICAccountSetsController:BaseBusinessController
	{
		public ICAccountSetsController()
		{
			dal= new DALBaseProvider("ICAccountSets",typeof(ICAccountSetsInfo));
		}

        public ICAccountSetsInfo GetDefault()
        {
            String strQuery = String.Format(@"SELECT * FROM ICAccountSets WHERE AADefault = 'true' AND AAStatus='Alive' ");

            DataSet ds = dal.GetDataSet(strQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ICAccountSetsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);

            return null;
        }


	}
	#endregion
}