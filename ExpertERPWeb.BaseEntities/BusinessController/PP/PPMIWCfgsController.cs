using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPMIWCfgs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPMIWCfgsController
	//Created Date:27 Tháng Mười Một 2012
	//-----------------------------------------------------------
	
	public class PPMIWCfgsController:BaseBusinessController
	{
		public PPMIWCfgsController()
		{
			dal= new DALBaseProvider("PPMIWCfgs",typeof(PPMIWCfgsInfo));
		}

        //Summary
        //Trung
        //27-11-2012
        //To màu các Grid theo Priority lấy từ PPMIWCfgs
        public PPMIWCfgsInfo GetMIWCfgByPriority(double dPriority)
        {
            System.Globalization.CultureInfo culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string strQuery = String.Format(@"SELECT * FROM PPMIWCfgs WHERE AAStatus='Alive' AND PPMIWCfgFromPriority<={0} AND PPMIWCfgToPriority>={0}", dPriority);
            DataSet ds = GetDataSet(strQuery);
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (PPMIWCfgsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
    }
	#endregion
}