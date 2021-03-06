using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICReceiptVals
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICReceiptValsController
	//Created Date:08 Tháng Mười Một 2011
	//-----------------------------------------------------------
	
	public class ICReceiptValsController:BaseBusinessController
	{
		public ICReceiptValsController()
		{
			dal= new DALBaseProvider("ICReceiptVals",typeof(ICReceiptValsInfo));
		}

        public DataSet GetAllReceiptValsByStockBeforeDate_FIFO(int iStockID, DateTime dt)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptVals WHERE FK_ICStockID = {0} AND ICReceiptValDate <= '{1}' ORDER BY ICReceiptValDate", iStockID, String.Format("{0:yyyy/M/d HH:mm:ss}", dt));
            return dal.GetDataSet(strQuery);
        }


        public DataSet GetAllReceiptValsByProductBeforeDate_FIFO(int iICProductID,int iStockID, DateTime dt)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptVals WHERE FK_ICProductID={0} AND FK_ICStockID = {1} AND ICReceiptValDate <= '{2}' ORDER BY ICReceiptValDate",iICProductID, iStockID, String.Format("{0:yyyy/M/d HH:mm:ss}", dt));
            return dal.GetDataSet(strQuery);
        }


        public DataSet GetAllReceiptValsByStockBeforeDate_LIFO(int iStockID, DateTime dt)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptVals WHERE FK_ICStockID = {0} AND ICReceiptValDate <= '{1}' ORDER BY ICReceiptValDate DESC", iStockID, String.Format("{0:yyyy/M/d HH:mm:ss}", dt));
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllReceiptValsByProductBeforeDate_LIFO(int iICProductID,int iStockID, DateTime dt)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptVals WHERE FK_ICStockID = {0} AND FK_ICStockID = {1} AND ICReceiptValDate <= '{2}' ORDER BY ICReceiptValDate DESC",iICProductID, iStockID, String.Format("{0:yyyy/M/d HH:mm:ss}", dt));
            return dal.GetDataSet(strQuery);
        }

        public DataSet DeleteAllReceiptValsByTransactionItemIDAndType(int iTransactionItemID, String strType)
        {
            String strQuery = String.Format("DELETE  FROM ICReceiptVals WHERE FK_ICTransactionItemID = {0} AND ICTransactionType= '{1}'", iTransactionItemID, strType);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllReceiptValsByTransactionItemIDAndType(int iTransactionItemID, String strType)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptVals WHERE FK_ICTransactionItemID = {0} AND ICTransactionType= '{1}'", iTransactionItemID, strType);
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllReceiptValsByProductIDInPeriod(int iProductID, int iPeriod, int iYear)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptVals WHERE FK_ICProductID = {0} AND Month(ICReceiptValDate) = {1} AND Year(ICReceiptValDate) = {2}",iProductID, iPeriod, iYear);
            return dal.GetDataSet(strQuery);
        }

        public void DeleteAllReceiptValsByProductIDInPeriod(int iProductID, int iPeriod, int iYear)
        {
            String strQuery = String.Format("DELETE FROM ICReceiptVals WHERE FK_ICProductID = {0} AND Month(ICReceiptValDate) = {1} AND Year(ICReceiptValDate) = {2}",iProductID, iPeriod, iYear);
            dal.GetDataSet(strQuery);
        }

        public DataSet GetAllReceiptValsByProductIDInPeriodAndBehind(int iProductID, int iPeriod, int iYear)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptVals WHERE FK_ICProductID = {0} AND ( (Month(ICReceiptValDate) + Year(ICReceiptValDate) * 12) >= ({1} + {2} * 12 ))", iProductID, iPeriod, iYear);
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}