
using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPMRPs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.80)
    //Class: PPMRPsController
    //Created Date: Monday, 07 Nov 2016
    //-----------------------------------------------------------

    public class PPMRPsController : BaseBusinessController
    {
        public PPMRPsController()
        {
            dal = new DALBaseProvider("PPMRPs", typeof(PPMRPsInfo));
        }
    }
    #endregion
}