using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCreditNoteItems
	//-----------------------------------------------------------
	//Generated By: VTD Studio
	//Class:ARCreditNoteItemsController
	//Created Date:Monday, April 12, 2010
	//-----------------------------------------------------------
	
	public class ARCreditNoteItemsController:BaseBusinessController
	{
		public ARCreditNoteItemsController()
		{
			dal= new DALBaseProvider("ARCreditNoteItems",typeof(ARCreditNoteItemsInfo));
		}
        public DataSet GetCreditNoteItemStatusDiffComplete(int iCreditNoteID)
        {
            string strQuery = String.Format("Select * from ARCreditNoteItems where FK_ARCreditNoteID={0} and AAStatus = 'Alive' and ARCreditNoteItemStatus<>'Complete'", iCreditNoteID);
            DataSet ds = dal.GetDataSet(strQuery);
            return ds;
        }
	}
	#endregion
}