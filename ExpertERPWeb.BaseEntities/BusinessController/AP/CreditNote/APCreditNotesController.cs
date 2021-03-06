using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APCreditNotes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APCreditNotesController
	//Created Date:06 Tháng Chín 2012
	//-----------------------------------------------------------
	
	public class APCreditNotesController:BaseBusinessController
	{
		public APCreditNotesController()
		{
			dal= new DALBaseProvider("APCreditNotes",typeof(APCreditNotesInfo));
		}

        public DataSet GetAllCreditNoteNeedPayment(int iSupplierID)
        {
            String strQuery = String.Format(@"SELECT * FROM APCreditNotes 
                                                    WHERE AAStatus = 'Alive' 
                                                    AND FK_APSupplierID = {0}
                                                    AND APCreditNoteRFAmtTot > 0
                                                    ORDER BY APCreditNoteExpireDate", iSupplierID);

            return GetDataSet(strQuery);

        }
	}
	#endregion
}