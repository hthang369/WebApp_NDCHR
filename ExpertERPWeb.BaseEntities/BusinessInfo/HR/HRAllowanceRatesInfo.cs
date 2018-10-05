
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRAllowanceRates
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.83)
    //Class: HRAllowanceRatesInfo
    //Created Date: Tuesday, 14 Feb 2017
    //-----------------------------------------------------------

    public class HRAllowanceRatesInfo : BusinessObject
    {
        public HRAllowanceRatesInfo()
        {
        }
        #region Variables
        protected int _hRAllowanceRateID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _hRAllowanceRateNo = String.Empty;
        protected String _hRAllowanceRateName = String.Empty;
        protected String _hRAllowanceRateTypeCombo = String.Empty;
        protected double _hRAllowanceRate;
        protected String _hRAllowanceRateDesc = String.Empty;
        protected String _hRAllowanceRankCombo = String.Empty;
        protected bool _hRAllowanceRateIsCalcShiftCntCheck = true;
        protected bool _aASelected = true;
        protected String _aAOrgDocNo = String.Empty;
        protected int _fK_HRAllowanceRateTypeID;

        #endregion

        #region Public properties
        public int HRAllowanceRateID
        {
            get { return _hRAllowanceRateID; }
            set
            {
                if (value != this._hRAllowanceRateID)
                {
                    _hRAllowanceRateID = value;
                    NotifyChanged("HRAllowanceRateID");
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
        public String HRAllowanceRateNo
        {
            get { return _hRAllowanceRateNo; }
            set
            {
                if (value != this._hRAllowanceRateNo)
                {
                    _hRAllowanceRateNo = value;
                    NotifyChanged("HRAllowanceRateNo");
                }
            }
        }
        public String HRAllowanceRateName
        {
            get { return _hRAllowanceRateName; }
            set
            {
                if (value != this._hRAllowanceRateName)
                {
                    _hRAllowanceRateName = value;
                    NotifyChanged("HRAllowanceRateName");
                }
            }
        }
        public String HRAllowanceRateTypeCombo
        {
            get { return _hRAllowanceRateTypeCombo; }
            set
            {
                if (value != this._hRAllowanceRateTypeCombo)
                {
                    _hRAllowanceRateTypeCombo = value;
                    NotifyChanged("HRAllowanceRateTypeCombo");
                }
            }
        }
        public double HRAllowanceRate
        {
            get { return _hRAllowanceRate; }
            set
            {
                if (value != this._hRAllowanceRate)
                {
                    _hRAllowanceRate = value;
                    NotifyChanged("HRAllowanceRate");
                }
            }
        }
        public String HRAllowanceRateDesc
        {
            get { return _hRAllowanceRateDesc; }
            set
            {
                if (value != this._hRAllowanceRateDesc)
                {
                    _hRAllowanceRateDesc = value;
                    NotifyChanged("HRAllowanceRateDesc");
                }
            }
        }
        public String HRAllowanceRankCombo
        {
            get { return _hRAllowanceRankCombo; }
            set
            {
                if (value != this._hRAllowanceRankCombo)
                {
                    _hRAllowanceRankCombo = value;
                    NotifyChanged("HRAllowanceRankCombo");
                }
            }
        }
        public bool HRAllowanceRateIsCalcShiftCntCheck
        {
            get { return _hRAllowanceRateIsCalcShiftCntCheck; }
            set
            {
                if (value != this._hRAllowanceRateIsCalcShiftCntCheck)
                {
                    _hRAllowanceRateIsCalcShiftCntCheck = value;
                    NotifyChanged("HRAllowanceRateIsCalcShiftCntCheck");
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
        public int FK_HRAllowanceRateTypeID
        {
            get { return _fK_HRAllowanceRateTypeID; }
            set
            {
                if (value != this._fK_HRAllowanceRateTypeID)
                {
                    _fK_HRAllowanceRateTypeID = value;
                    NotifyChanged("FK_HRAllowanceRateTypeID");
                }
            }
        }

        #endregion
    }
    #endregion
}