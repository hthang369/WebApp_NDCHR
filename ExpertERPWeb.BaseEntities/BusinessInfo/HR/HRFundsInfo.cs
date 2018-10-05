using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRFunds
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: HRFundsInfo
    //Created Date: Thursday, 26 Jul 2018
    //-----------------------------------------------------------

    public class HRFundsInfo : BusinessObject
    {
        public HRFundsInfo()
        {
        }
        #region Variables
        protected int _hRFundID;
        protected String _hRFundNo = String.Empty;
        protected String _hRFundName = String.Empty;
        protected Nullable<DateTime> _hRFundDate;
        protected String _hRFundDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRPeriodID;
        protected int _hRFundMonth;
        protected int _hRFundYear;
        
        #endregion

        #region Public properties
        public int HRFundID
        {
            get { return _hRFundID; }
            set
            {
                if (value != this._hRFundID)
                {
                    _hRFundID = value;
                    NotifyChanged("HRFundID");
                }
            }
        }
        public String HRFundNo
        {
            get { return _hRFundNo; }
            set
            {
                if (value != this._hRFundNo)
                {
                    _hRFundNo = value;
                    NotifyChanged("HRFundNo");
                }
            }
        }
        public String HRFundName
        {
            get { return _hRFundName; }
            set
            {
                if (value != this._hRFundName)
                {
                    _hRFundName = value;
                    NotifyChanged("HRFundName");
                }
            }
        }
        public Nullable<DateTime> HRFundDate
        {
            get { return _hRFundDate; }
            set
            {
                if (value != this._hRFundDate)
                {
                    _hRFundDate = value;
                    NotifyChanged("HRFundDate");
                }
            }
        }
        public String HRFundDesc
        {
            get { return _hRFundDesc; }
            set
            {
                if (value != this._hRFundDesc)
                {
                    _hRFundDesc = value;
                    NotifyChanged("HRFundDesc");
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
        public int HRFundMonth
        {
            get { return _hRFundMonth; }
            set
            {
                if (value != this._hRFundMonth)
                {
                    _hRFundMonth = value;
                    NotifyChanged("HRFundMonth");
                }
            }
        }
        public int HRFundYear
        {
            get { return _hRFundYear; }
            set
            {
                if (value != this._hRFundYear)
                {
                    _hRFundYear = value;
                    NotifyChanged("HRFundYear");
                }
            }
        }
        
        #endregion
    }
    #endregion
}