using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPMPSHists
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:PPMPSHistsController
    //Created Date:01 Tháng Tám 2014
    //-----------------------------------------------------------

    public class PPMPSHistsController : BaseBusinessController
    {
        public PPMPSHistsController()
        {
            dal = new DALBaseProvider("PPMPSHists", typeof(PPMPSHistsInfo));
        }
    }
    #endregion
}