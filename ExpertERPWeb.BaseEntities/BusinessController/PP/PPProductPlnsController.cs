using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductPlns
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPProductPlnsController
	//Created Date:Tuesday, September 27, 2011
	//-----------------------------------------------------------
	
	public class PPProductPlnsController:BaseBusinessController
	{
		public PPProductPlnsController()
		{
			dal= new DALBaseProvider("PPProductPlns",typeof(PPProductPlnsInfo));
		}
        public PPProductPlnsInfo GetFirstObjectByPeriodYear(int iPeriod, int iYear)
        {
            string strQuery = string.Format(@"Select Top 1 * from PPProductPlns where AAStatus='Alive' And PPProductPlnPeriod={0} and PPProductPlnYear={1}", iPeriod, iYear);
            DataSet ds = dal.GetDataSet(strQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPProductPlnsInfo)dal.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }

        public DataSet GetAllDataInRange(int iFromPeriod, int iFromYear, int iToPeriod, int iToYear)
        {
            string strQuery = string.Format(@"Select * from PPProductPlns where AAStatus='Alive' And (PPProductPlnYear*12+PPProductPlnPeriod)>={0} And (PPProductPlnYear*12+PPProductPlnPeriod)<={1} ",iFromYear*12+iFromPeriod,iToYear*12+ iToPeriod);
            return dal.GetDataSet(strQuery);
        }
    }
	#endregion
}