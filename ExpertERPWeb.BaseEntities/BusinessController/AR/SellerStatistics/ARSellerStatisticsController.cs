using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerStatistics
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSellerStatisticsController
	//Created Date:Tuesday, January 03, 2012
	//-----------------------------------------------------------
	
	public class ARSellerStatisticsController:BaseBusinessController
	{
		public ARSellerStatisticsController()
		{
			dal= new DALBaseProvider("ARSellerStatistics",typeof(ARSellerStatisticsInfo));
		}

        public DataSet GetAllQuotByEmployeeInRange(DateTime fromdate, DateTime todate, int iEmployeeID)
        {
            String query = String.Format("Select * From ARQuots Where AAStatus = 'Alive' And ARQuotDate between '{0}' And '{1}' And FK_HREmployeeID = {2}", String.Format("{0:yyyy/M/d HH:mm:ss}", fromdate), String.Format("{0:yyyy/M/d HH:mm:ss}", todate), iEmployeeID);

            return dal.GetDataSet(query);
        }

        public DataSet GetAllSOByEmployeeInRange(DateTime fromdate, DateTime todate, int iEmployeeID)
        {
            String query = String.Format("Select * From ARSOs Where AAStatus = 'Alive' And ARSODate between '{0}' And '{1}' And FK_HREmployeeID = {2}", String.Format("{0:yyyy/M/d HH:mm:ss}", fromdate), String.Format("{0:yyyy/M/d HH:mm:ss}", todate), iEmployeeID);

            return dal.GetDataSet(query);
        }

        public DataSet GetAllInvoiceByEmployeeInRange(DateTime fromdate, DateTime todate, int iEmployeeID)
        {
            String query = String.Format("Select * From ARInvoices Where AAStatus = 'Alive' And ARInvoiceDate between '{0}' And '{1}' And FK_HREmployeeID = {2}", String.Format("{0:yyyy/M/d HH:mm:ss}", fromdate), String.Format("{0:yyyy/M/d HH:mm:ss}", todate), iEmployeeID);

            return dal.GetDataSet(query);
        }
	}
	#endregion
}