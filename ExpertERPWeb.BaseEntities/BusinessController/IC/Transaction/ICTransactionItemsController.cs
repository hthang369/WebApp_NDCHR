using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICTransactionItems
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICTransactionItemsController
    //Created Date:Tuesday, February 15, 2011
    //-----------------------------------------------------------

    public class ICTransactionItemsController : BaseBusinessController
    {
        public ICTransactionItemsController ( )
        {
            dal=new DALBaseProvider( "ICTransactionItems" , typeof( ICTransactionItemsInfo ) );
        }
    }
    #endregion
}