using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICReceiptValRelations
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICReceiptValRelationsController
	//Created Date:08 Tháng Mười Một 2011
	//-----------------------------------------------------------
	
	public class ICReceiptValRelationsController:BaseBusinessController
	{
		public ICReceiptValRelationsController()
		{
			dal= new DALBaseProvider("ICReceiptValRelations",typeof(ICReceiptValRelationsInfo));
		}

        public DataSet GetAllRelationByTransactionItemIDAndType(int iTransactionItemID, String strType)
        {
            String strQuery = String.Format("SELECT * FROM ICReceiptValRelations WHERE FK_ICTransactionItemID = {0} AND ICTransactionType = '{1}'", iTransactionItemID, strType);
            return dal.GetDataSet(strQuery);
        }

        public void DeleteAllRelationByTransactionItemIDAndType(int iTransactionItemID, String strType)
        {
            String strQuery = String.Format("DELETE FROM ICReceiptValRelations WHERE FK_ICTransactionItemID = {0} AND ICTransactionType = '{1}'", iTransactionItemID, strType);
            dal.GetDataSet(strQuery);
        }

        public void DeleteAllRelationByReceiptValID(int iReceiptValID)
        {
            String strQuery = String.Format("DELETE FROM ICReceiptValRelations WHERE FK_ICReceiptValID = {0}", iReceiptValID);
            dal.GetDataSet(strQuery);
        }

        public DataSet GetAllRelationToShipmentInPeriodAndBehind(int iProductID, int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM ICReceiptValRelations WHERE ICTransactionType = '{0}'", "Shipment");
            strQuery += String.Format(@" AND FK_ICTransactionItemID IN (SELECT ICShipmentItemID FROM ICShipmentItems WHERE ICShipmentItems.AAStatus = 'Alive' AND FK_ICProductID = {0} AND FK_ICShipmentID IN (SELECT ICShipmentID FROM ICShipments WHERE ICShipments.AAStatus = 'Alive' AND ( (Month(ICShipmentDate) + Year(ICShipmentDate) * 12) >= ({1} + {2} * 12 ))))", iProductID, iPeriod, iYear);

            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllRelationToTransferOutInPeriodAndBehind(int iProductID, int iPeriod, int iYear)
        {
            String strQuery = String.Format(@"SELECT * FROM ICReceiptValRelations WHERE ICTransactionType = '{0}'", "TransferOut");
            strQuery += String.Format(@" AND FK_ICTransactionItemID IN (SELECT ICTransferItemID FROM ICTransferItems WHERE ICTransferItems.AAStatus = 'Alive' AND FK_ICProductID = {0} AND FK_ICTransferID IN (SELECT ICTransferID FROM ICTransfers WHERE ICTransfers.AAStatus = 'Alive' AND ( (Month(ICTransferDate) + Year(ICTransferDate) * 12) >= ({1} + {2} * 12 ))))", iProductID, iPeriod, iYear);

            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}