using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;


namespace ExpertERP.BusinessEntities
{
    #region ICProductGroupRelations
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICProductGroupRelationsController
    //Created Date:Thursday, June 19, 2008
    //-----------------------------------------------------------

    public class ICProductGroupRelationsController : BaseBusinessController
    {
        public ICProductGroupRelationsController()
        {
            dal = new DALBaseProvider("ICProductGroupRelations", typeof(ICProductGroupRelationsInfo));
        }
    }
    #endregion
}