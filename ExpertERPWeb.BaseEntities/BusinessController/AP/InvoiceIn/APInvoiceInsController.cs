using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
    #region APInvoiceIns
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:APInvoiceInsController
    //Created Date:Thursday, May 29, 2008
    //-----------------------------------------------------------

    public class APInvoiceInsController : BaseBusinessController
    {
        public APInvoiceInsController()
        {
            dal = new DALBaseProvider("APInvoiceIns", typeof(APInvoiceInsInfo));
        }
    }
    #endregion
}