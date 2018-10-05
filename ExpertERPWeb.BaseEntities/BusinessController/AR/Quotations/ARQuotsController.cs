using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARQuots
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARQuotsController
	//Created Date:Friday, January 15, 2010
	//-----------------------------------------------------------
	
	public class ARQuotsController:BaseBusinessController
	{
		public ARQuotsController()
		{
			dal= new DALBaseProvider("ARQuots",typeof(ARQuotsInfo));
		}
        public DataSet GetDataSetByARSellerIDFromFDateAndTDate(int iARSellerID, DateTime dteFDate, DateTime dteTDate)
        {
            DataSet dsARQuots = new DataSet();
            String strQuery = String.Format("SELECT * FROM [dbo].[ARQuots] WHERE [FK_ARSellerID]={0} AND CONVERT(VARCHAR(10), [ARQuotDate], 112)>= CONVERT(VARCHAR(10), '{1}', 112) AND CONVERT(VARCHAR(10), [ARQuotDate], 112)<= CONVERT(VARCHAR(10), '{2}', 112) AND [AAStatus]='{3}'", iARSellerID, dteFDate.ToString("yyyyMMdd"), dteTDate.ToString("yyyyMMdd"), BusinessObject.DefaultAAStatus);
            dsARQuots = dal.GetDataSet(strQuery);
            if (dsARQuots != null)
                return dsARQuots;
            return dsARQuots;
        }
        public double GetTotalAmtByARSellerIDInPeriodYear(int iHREmployeeID, int iPeriod, int iYear,ref double count)
        {
            String strQuery = String.Format(@"SELECT SUM(ARQuotAmtTot),COUNT(*) FROM dbo.ARQuots WHERE AAStatus='Alive' AND FK_HREmployeeID={0}
	                                                    	AND MONTH(ARQuotDate)={1} AND YEAR(ARQuotDate)={2}"
                                                        , iHREmployeeID, iPeriod, iYear);
            DataSet dsARQuots = dal.GetDataSet(strQuery);
            count = 0;
            if (dsARQuots != null && dsARQuots.Tables.Count > 0 && dsARQuots.Tables[0].Rows.Count > 0 && dsARQuots.Tables[0].Rows[0][0] != DBNull.Value && dsARQuots.Tables[0].Rows[0][1] != DBNull.Value)
            {
                count = Convert.ToDouble(dsARQuots.Tables[0].Rows[0][1]);
                return Convert.ToDouble(dsARQuots.Tables[0].Rows[0][0]);
            }
            return 0;
        }
        public DataSet GetAllDataByARSellerIDInPeriodYear(int iHREmployeeID, int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM dbo.ARQuots WHERE AAStatus='Alive' AND FK_HREmployeeID={0} AND ARQuotAmtTot>0 
	                                                    	AND MONTH(ARQuotDate)={1} AND YEAR(ARQuotDate)={2}"
                                                        , iHREmployeeID, iPeriod, iYear);
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}