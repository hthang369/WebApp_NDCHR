using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
    #region APPurchaseOrderItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:APPurchaseOrderItemsController
    //Created Date:Friday, April 18, 2008
    //-----------------------------------------------------------

    public class APPurchaseOrderItemsController : BaseBusinessController
    {
        public APPurchaseOrderItemsController()
        {
            dal = new DALBaseProvider("APPurchaseOrderItems", typeof(APPurchaseOrderItemsInfo));
        }
    }
    #endregion
}