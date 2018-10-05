using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region APPOItemSemiDetailOrdPlans
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:APPOItemSemiDetailOrdPlansInfo
    //Created Date:Tuesday, January 29, 2013
    //-----------------------------------------------------------

    public class APPOItemSemiDetailOrdPlansInfo : BusinessObject
    {
        public APPOItemSemiDetailOrdPlansInfo()
        {
        }
        #region Variables
        protected int _aPPOItemSemiDetailOrdPlanID;
        protected int _fK_APPOItemID;
        protected int _fK_APSemiDetailOrdPlanID;
        #endregion

        #region Public properties
        public int APPOItemSemiDetailOrdPlanID
        {
            get { return _aPPOItemSemiDetailOrdPlanID; }
            set
            {
                if (value != this._aPPOItemSemiDetailOrdPlanID)
                {
                    _aPPOItemSemiDetailOrdPlanID = value;
                    NotifyChanged("APPOItemSemiDetailOrdPlanID");
                }
            }
        }
        public int FK_APPOItemID
        {
            get { return _fK_APPOItemID; }
            set
            {
                if (value != this._fK_APPOItemID)
                {
                    _fK_APPOItemID = value;
                    NotifyChanged("FK_APPOItemID");
                }
            }
        }
        public int FK_APSemiDetailOrdPlanID
        {
            get { return _fK_APSemiDetailOrdPlanID; }
            set
            {
                if (value != this._fK_APSemiDetailOrdPlanID)
                {
                    _fK_APSemiDetailOrdPlanID = value;
                    NotifyChanged("FK_APSemiDetailOrdPlanID");
                }
            }
        }
        #endregion
    }
    #endregion
}