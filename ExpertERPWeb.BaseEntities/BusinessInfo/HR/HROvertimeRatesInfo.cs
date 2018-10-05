
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HROvertimeRates
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.88)
    //Class: HROvertimeRatesInfo
    //Created Date: Wednesday, 31 May 2017
    //-----------------------------------------------------------

    public class HROvertimeRatesInfo : BusinessObject
    {
        public HROvertimeRatesInfo()
        {
        }
        #region Variables
        protected int _hROvertimeRateID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _hROvertimeRateName = String.Empty;
        protected String _hROvertimeRateDesc = String.Empty;
        protected String _hROvertimeRateTypeCombo = String.Empty;
        protected double _hROvertimeRate;
        protected String _hROvertimeRateCondition = String.Empty;
        protected bool _aASelected = true;
        protected String _aAOrgDocNo = String.Empty;
        protected double _hROvertimeRatesTaxCal;
        protected String _hROvertimeRateNo = String.Empty;

        #endregion

        #region Public properties
        public int HROvertimeRateID
        {
            get { return _hROvertimeRateID; }
            set
            {
                if (value != this._hROvertimeRateID)
                {
                    _hROvertimeRateID = value;
                    NotifyChanged("HROvertimeRateID");
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
        public String HROvertimeRateName
        {
            get { return _hROvertimeRateName; }
            set
            {
                if (value != this._hROvertimeRateName)
                {
                    _hROvertimeRateName = value;
                    NotifyChanged("HROvertimeRateName");
                }
            }
        }
        public String HROvertimeRateDesc
        {
            get { return _hROvertimeRateDesc; }
            set
            {
                if (value != this._hROvertimeRateDesc)
                {
                    _hROvertimeRateDesc = value;
                    NotifyChanged("HROvertimeRateDesc");
                }
            }
        }
        public String HROvertimeRateTypeCombo
        {
            get { return _hROvertimeRateTypeCombo; }
            set
            {
                if (value != this._hROvertimeRateTypeCombo)
                {
                    _hROvertimeRateTypeCombo = value;
                    NotifyChanged("HROvertimeRateTypeCombo");
                }
            }
        }
        public double HROvertimeRate
        {
            get { return _hROvertimeRate; }
            set
            {
                if (value != this._hROvertimeRate)
                {
                    _hROvertimeRate = value;
                    NotifyChanged("HROvertimeRate");
                }
            }
        }
        public String HROvertimeRateCondition
        {
            get { return _hROvertimeRateCondition; }
            set
            {
                if (value != this._hROvertimeRateCondition)
                {
                    _hROvertimeRateCondition = value;
                    NotifyChanged("HROvertimeRateCondition");
                }
            }
        }
        public bool AASelected
        {
            get { return _aASelected; }
            set
            {
                if (value != this._aASelected)
                {
                    _aASelected = value;
                    NotifyChanged("AASelected");
                }
            }
        }
        public String AAOrgDocNo
        {
            get { return _aAOrgDocNo; }
            set
            {
                if (value != this._aAOrgDocNo)
                {
                    _aAOrgDocNo = value;
                    NotifyChanged("AAOrgDocNo");
                }
            }
        }
        public double HROvertimeRatesTaxCal
        {
            get { return _hROvertimeRatesTaxCal; }
            set
            {
                if (value != this._hROvertimeRatesTaxCal)
                {
                    _hROvertimeRatesTaxCal = value;
                    NotifyChanged("HROvertimeRatesTaxCal");
                }
            }
        }
        public String HROvertimeRateNo
        {
            get { return _hROvertimeRateNo; }
            set
            {
                if (value != this._hROvertimeRateNo)
                {
                    _hROvertimeRateNo = value;
                    NotifyChanged("HROvertimeRateNo");
                }
            }
        }

        #endregion
    }
    #endregion
}