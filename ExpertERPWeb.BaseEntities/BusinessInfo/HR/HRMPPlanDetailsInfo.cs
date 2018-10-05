using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRMPPlanDetails
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: HRMPPlanDetailsInfo
    //Created Date: Thursday, 02 Aug 2018
    //-----------------------------------------------------------

    public class HRMPPlanDetailsInfo : BusinessObject
    {
        public HRMPPlanDetailsInfo()
        {
        }
        #region Variables
        protected int _hRMPPlanDetailID;
        protected int _fK_HRMPPlanID;
        protected int _fK_HRMPPlanItemID;
        protected int _hRMPPlanDetailOfYear;
        protected int _hRMPPlanDetailOfMonth;
        protected Nullable<DateTime> _hRMPPlanDetailFDate;
        protected Nullable<DateTime> _hRMPPlanDetailTDate;
        protected int _hRMPPlanDetailHeadCount;
        protected int _hRMPPlanDetailReality;
        protected int _hRMPPlanDetailNextToHeadCount;
        protected int _hRMPPlanDetailNextToNeed;
        protected int _hRMPPlanDetailDiffHeadcount;
        protected int _hRMPPlanDetailDiffToNeed;
        protected int _hRMPPlanDetailNextToOffwork;
        protected int _hRMPPlanDetailNextToMaternity;
        protected int _hRMPPlanDetailNextToDisplace;
        protected int _hRMPPlanDetailInternalReserve;
        protected int _hRMPPlanDetailNextToRecruit;
        protected int _hRMPPlanDetailNeedToRecruit;
        
        #endregion

        #region Public properties
        public int HRMPPlanDetailID
        {
            get { return _hRMPPlanDetailID; }
            set
            {
                if (value != this._hRMPPlanDetailID)
                {
                    _hRMPPlanDetailID = value;
                    NotifyChanged("HRMPPlanDetailID");
                }
            }
        }
        public int FK_HRMPPlanID
        {
            get { return _fK_HRMPPlanID; }
            set
            {
                if (value != this._fK_HRMPPlanID)
                {
                    _fK_HRMPPlanID = value;
                    NotifyChanged("FK_HRMPPlanID");
                }
            }
        }
        public int FK_HRMPPlanItemID
        {
            get { return _fK_HRMPPlanItemID; }
            set
            {
                if (value != this._fK_HRMPPlanItemID)
                {
                    _fK_HRMPPlanItemID = value;
                    NotifyChanged("FK_HRMPPlanItemID");
                }
            }
        }
        public int HRMPPlanDetailOfYear
        {
            get { return _hRMPPlanDetailOfYear; }
            set
            {
                if (value != this._hRMPPlanDetailOfYear)
                {
                    _hRMPPlanDetailOfYear = value;
                    NotifyChanged("HRMPPlanDetailOfYear");
                }
            }
        }
        public int HRMPPlanDetailOfMonth
        {
            get { return _hRMPPlanDetailOfMonth; }
            set
            {
                if (value != this._hRMPPlanDetailOfMonth)
                {
                    _hRMPPlanDetailOfMonth = value;
                    NotifyChanged("HRMPPlanDetailOfMonth");
                }
            }
        }
        public Nullable<DateTime> HRMPPlanDetailFDate
        {
            get { return _hRMPPlanDetailFDate; }
            set
            {
                if (value != this._hRMPPlanDetailFDate)
                {
                    _hRMPPlanDetailFDate = value;
                    NotifyChanged("HRMPPlanDetailFDate");
                }
            }
        }
        public Nullable<DateTime> HRMPPlanDetailTDate
        {
            get { return _hRMPPlanDetailTDate; }
            set
            {
                if (value != this._hRMPPlanDetailTDate)
                {
                    _hRMPPlanDetailTDate = value;
                    NotifyChanged("HRMPPlanDetailTDate");
                }
            }
        }
        public int HRMPPlanDetailHeadCount
        {
            get { return _hRMPPlanDetailHeadCount; }
            set
            {
                if (value != this._hRMPPlanDetailHeadCount)
                {
                    _hRMPPlanDetailHeadCount = value;
                    NotifyChanged("HRMPPlanDetailHeadCount");
                }
            }
        }
        public int HRMPPlanDetailReality
        {
            get { return _hRMPPlanDetailReality; }
            set
            {
                if (value != this._hRMPPlanDetailReality)
                {
                    _hRMPPlanDetailReality = value;
                    NotifyChanged("HRMPPlanDetailReality");
                }
            }
        }
        public int HRMPPlanDetailNextToHeadCount
        {
            get { return _hRMPPlanDetailNextToHeadCount; }
            set
            {
                if (value != this._hRMPPlanDetailNextToHeadCount)
                {
                    _hRMPPlanDetailNextToHeadCount = value;
                    NotifyChanged("HRMPPlanDetailNextToHeadCount");
                }
            }
        }
        public int HRMPPlanDetailNextToNeed
        {
            get { return _hRMPPlanDetailNextToNeed; }
            set
            {
                if (value != this._hRMPPlanDetailNextToNeed)
                {
                    _hRMPPlanDetailNextToNeed = value;
                    NotifyChanged("HRMPPlanDetailNextToNeed");
                }
            }
        }
        public int HRMPPlanDetailDiffHeadcount
        {
            get { return _hRMPPlanDetailDiffHeadcount; }
            set
            {
                if (value != this._hRMPPlanDetailDiffHeadcount)
                {
                    _hRMPPlanDetailDiffHeadcount = value;
                    NotifyChanged("HRMPPlanDetailDiffHeadcount");
                }
            }
        }
        public int HRMPPlanDetailDiffToNeed
        {
            get { return _hRMPPlanDetailDiffToNeed; }
            set
            {
                if (value != this._hRMPPlanDetailDiffToNeed)
                {
                    _hRMPPlanDetailDiffToNeed = value;
                    NotifyChanged("HRMPPlanDetailDiffToNeed");
                }
            }
        }
        public int HRMPPlanDetailNextToOffwork
        {
            get { return _hRMPPlanDetailNextToOffwork; }
            set
            {
                if (value != this._hRMPPlanDetailNextToOffwork)
                {
                    _hRMPPlanDetailNextToOffwork = value;
                    NotifyChanged("HRMPPlanDetailNextToOffwork");
                }
            }
        }
        public int HRMPPlanDetailNextToMaternity
        {
            get { return _hRMPPlanDetailNextToMaternity; }
            set
            {
                if (value != this._hRMPPlanDetailNextToMaternity)
                {
                    _hRMPPlanDetailNextToMaternity = value;
                    NotifyChanged("HRMPPlanDetailNextToMaternity");
                }
            }
        }
        public int HRMPPlanDetailNextToDisplace
        {
            get { return _hRMPPlanDetailNextToDisplace; }
            set
            {
                if (value != this._hRMPPlanDetailNextToDisplace)
                {
                    _hRMPPlanDetailNextToDisplace = value;
                    NotifyChanged("HRMPPlanDetailNextToDisplace");
                }
            }
        }
        public int HRMPPlanDetailInternalReserve
        {
            get { return _hRMPPlanDetailInternalReserve; }
            set
            {
                if (value != this._hRMPPlanDetailInternalReserve)
                {
                    _hRMPPlanDetailInternalReserve = value;
                    NotifyChanged("HRMPPlanDetailInternalReserve");
                }
            }
        }
        public int HRMPPlanDetailNextToRecruit
        {
            get { return _hRMPPlanDetailNextToRecruit; }
            set
            {
                if (value != this._hRMPPlanDetailNextToRecruit)
                {
                    _hRMPPlanDetailNextToRecruit = value;
                    NotifyChanged("HRMPPlanDetailNextToRecruit");
                }
            }
        }
        public int HRMPPlanDetailNeedToRecruit
        {
            get { return _hRMPPlanDetailNeedToRecruit; }
            set
            {
                if (value != this._hRMPPlanDetailNeedToRecruit)
                {
                    _hRMPPlanDetailNeedToRecruit = value;
                    NotifyChanged("HRMPPlanDetailNeedToRecruit");
                }
            }
        }
        
        #endregion
    }
    #endregion
}