using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRKPISugges
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.93)
    //Class: HRKPISuggesInfo
    //Created Date: Tuesday, 10 Jul 2018
    //-----------------------------------------------------------

    public class HRKPISuggesInfo : BusinessObject
    {
        public HRKPISuggesInfo()
        {
        }
        #region Variables
        protected int _hRKPISuggeID;
        protected String _hRKPISuggeNo = String.Empty;
        protected String _hRKPISuggeName = String.Empty;
        protected Nullable<DateTime> _hRKPISuggeDate;
        protected String _hRKPISuggeDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRPeriodID;
        protected int _fK_HRTargetID;
        
        #endregion

        #region Public properties
        public int HRKPISuggeID
        {
            get { return _hRKPISuggeID; }
            set
            {
                if (value != this._hRKPISuggeID)
                {
                    _hRKPISuggeID = value;
                    NotifyChanged("HRKPISuggeID");
                }
            }
        }
        public String HRKPISuggeNo
        {
            get { return _hRKPISuggeNo; }
            set
            {
                if (value != this._hRKPISuggeNo)
                {
                    _hRKPISuggeNo = value;
                    NotifyChanged("HRKPISuggeNo");
                }
            }
        }
        public String HRKPISuggeName
        {
            get { return _hRKPISuggeName; }
            set
            {
                if (value != this._hRKPISuggeName)
                {
                    _hRKPISuggeName = value;
                    NotifyChanged("HRKPISuggeName");
                }
            }
        }
        public Nullable<DateTime> HRKPISuggeDate
        {
            get { return _hRKPISuggeDate; }
            set
            {
                if (value != this._hRKPISuggeDate)
                {
                    _hRKPISuggeDate = value;
                    NotifyChanged("HRKPISuggeDate");
                }
            }
        }
        public String HRKPISuggeDesc
        {
            get { return _hRKPISuggeDesc; }
            set
            {
                if (value != this._hRKPISuggeDesc)
                {
                    _hRKPISuggeDesc = value;
                    NotifyChanged("HRKPISuggeDesc");
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if (value != this._aAStatus)
                {
                    _aAStatus = value;
                    NotifyChanged("AAStatus");
                }
            }
        }
        public Nullable<DateTime> AACreatedDate
        {
            get { return _aACreatedDate; }
            set
            {
                if (value != this._aACreatedDate)
                {
                    _aACreatedDate = value;
                    NotifyChanged("AACreatedDate");
                }
            }
        }
        public String AACreatedUser
        {
            get { return _aACreatedUser; }
            set
            {
                if (value != this._aACreatedUser)
                {
                    _aACreatedUser = value;
                    NotifyChanged("AACreatedUser");
                }
            }
        }
        public Nullable<DateTime> AAUpdatedDate
        {
            get { return _aAUpdatedDate; }
            set
            {
                if (value != this._aAUpdatedDate)
                {
                    _aAUpdatedDate = value;
                    NotifyChanged("AAUpdatedDate");
                }
            }
        }
        public String AAUpdatedUser
        {
            get { return _aAUpdatedUser; }
            set
            {
                if (value != this._aAUpdatedUser)
                {
                    _aAUpdatedUser = value;
                    NotifyChanged("AAUpdatedUser");
                }
            }
        }
        public int FK_HRPeriodID
        {
            get { return _fK_HRPeriodID; }
            set
            {
                if (value != this._fK_HRPeriodID)
                {
                    _fK_HRPeriodID = value;
                    NotifyChanged("FK_HRPeriodID");
                }
            }
        }
        public int FK_HRTargetID
        {
            get { return _fK_HRTargetID; }
            set
            {
                if (value != this._fK_HRTargetID)
                {
                    _fK_HRTargetID = value;
                    NotifyChanged("FK_HRTargetID");
                }
            }
        }
        
        #endregion
    }
    #endregion
}