using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
    #region APInvoiceInItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:APInvoiceInItemsController
    //Created Date:Thursday, May 29, 2008
    //-----------------------------------------------------------

    public class APInvoiceInItemsController : BaseBusinessController
    {
        public APInvoiceInItemsController()
        {
            dal = new DALBaseProvider("APInvoiceInItems", typeof(APInvoiceInItemsInfo));
        }
    }
    #endregion
}