using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMWarantyHistoryItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMWarantyHistoryItemsController
	//Created Date:Thursday, June 23, 2011
	//-----------------------------------------------------------
	
	public class CMWarantyHistoryItemsController:BaseBusinessController
	{
		public CMWarantyHistoryItemsController()
		{
			dal= new DALBaseProvider("CMWarantyHistoryItems",typeof(CMWarantyHistoryItemsInfo));
		}
        public DataSet GetCMWarantyHistoryItemStatusNew(int iWarantyID)
        {
            string strQuery = String.Format("Select * from CMWarantyHistoryItems where FK_CMWarantyHistoryID={0} and AAStatus = 'Alive' AND CMWarantyHistoryItemStatusCombo<>'Complete'", iWarantyID);
            DataSet ds = dal.GetDataSet(strQuery);
            return ds;
        }

        public DataSet GetAllWarantyItemsByProduct(int iProductID, DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Format(@"SELECT * FROM CMWarantyHistoryItems
                                                WHERE AAStatus = 'ALive'
                                                AND FK_ICProductID = {0}
                                                AND FK_CMWarantyHistoryID 
                                                IN (SELECT CMWarantyHistoryID FROM CMWarantyHistorys WHERE AAStatus = 'ALive'
                                                AND {1})", iProductID, DALUtil.GenerateBeetween("CMWarantyHistoryDate", dtFrom, dtTo));
            return dal.GetDataSet(strQuery);
        }

        public DataSet GetAllWarantyItemsByCustoner(int iCustID, DateTime dtFrom, DateTime dtTo)
        {
            String strQuery = String.Empty;
            if (iCustID > 0)
            {
                strQuery = String.Format(@"SELECT * FROM CMWarantyHistoryItems
                                                WHERE AAStatus = 'ALive'
                                                AND FK_CMWarantyHistoryID 
                                                IN (SELECT CMWarantyHistoryID FROM CMWarantyHistorys WHERE FK_ARCustomerID = {0} AND AAStatus = 'ALive'
                                                AND {1})", iCustID, DALUtil.GenerateBeetween("CMWarantyHistoryDate", dtFrom, dtTo));
            }
            else if (iCustID == 0)
            {
                strQuery = String.Format(@"SELECT * FROM CMWarantyHistoryItems
                                                WHERE AAStatus = 'ALive'
                                                AND FK_CMWarantyHistoryID 
                                                IN (SELECT CMWarantyHistoryID FROM CMWarantyHistorys WHERE FK_ARCusttomerID NOT IN (SELECT ARCustomerID FROM ARCustomers WHERE ARCustomers.AAStatus = 'Alive') AND AAStatus = 'ALive'
                                                AND {1})", iCustID, DALUtil.GenerateBeetween("CMWarantyHistoryDate", dtFrom, dtTo));
            }
            return dal.GetDataSet(strQuery);
        }
	}
	#endregion
}