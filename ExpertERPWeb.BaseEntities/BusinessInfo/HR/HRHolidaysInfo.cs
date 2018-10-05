
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRHolidays
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.83)
    //Class: HRHolidaysInfo
    //Created Date: Wednesday, 08 Feb 2017
    //-----------------------------------------------------------

    public class HRHolidaysInfo : BusinessObject
    {
        public HRHolidaysInfo()
        {
        }
        #region Variables
        protected int _hRHolidayID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _hRHolidayName = String.Empty;
        protected String _hRHolidayDesc = String.Empty;
        protected Nullable<DateTime> _hRHolidayFromDate;
        protected String _hRHolidayTypeCombo = String.Empty;
        protected int _hRHolidayPeriod;
        protected int _hRHolidayFiscalYear;
        protected double _hRHolidaySalaryLevel;
        protected double _hRHolidaySalaryRate;
        protected bool _aASelected = true;
        protected String _aAOrgDocNo = String.Empty;
        protected Nullable<DateTime> _hRHolidayToDate;
        protected Nullable<DateTime> _hRHolidayDate;

        #endregion

        #region Public properties
        public int HRHolidayID
        {
            get { return _hRHolidayID; }
            set
            {
                if (value != this._hRHolidayID)
                {
                    _hRHolidayID = value;
                    NotifyChanged("HRHolidayID");
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
        public String HRHolidayName
        {
            get { return _hRHolidayName; }
            set
            {
                if (value != this._hRHolidayName)
                {
                    _hRHolidayName = value;
                    NotifyChanged("HRHolidayName");
                }
            }
        }
        public String HRHolidayDesc
        {
            get { return _hRHolidayDesc; }
            set
            {
                if (value != this._hRHolidayDesc)
                {
                    _hRHolidayDesc = value;
                    NotifyChanged("HRHolidayDesc");
                }
            }
        }
        public Nullable<DateTime> HRHolidayFromDate
        {
            get { return _hRHolidayFromDate; }
            set
            {
                if (value != this._hRHolidayFromDate)
                {
                    _hRHolidayFromDate = value;
                    NotifyChanged("HRHolidayFromDate");
                }
            }
        }
        public String HRHolidayTypeCombo
        {
            get { return _hRHolidayTypeCombo; }
            set
            {
                if (value != this._hRHolidayTypeCombo)
                {
                    _hRHolidayTypeCombo = value;
                    NotifyChanged("HRHolidayTypeCombo");
                }
            }
        }
        public int HRHolidayPeriod
        {
            get { return _hRHolidayPeriod; }
            set
            {
                if (value != this._hRHolidayPeriod)
                {
                    _hRHolidayPeriod = value;
                    NotifyChanged("HRHolidayPeriod");
                }
            }
        }
        public int HRHolidayFiscalYear
        {
            get { return _hRHolidayFiscalYear; }
            set
            {
                if (value != this._hRHolidayFiscalYear)
                {
                    _hRHolidayFiscalYear = value;
                    NotifyChanged("HRHolidayFiscalYear");
                }
            }
        }
        public double HRHolidaySalaryLevel
        {
            get { return _hRHolidaySalaryLevel; }
            set
            {
                if (value != this._hRHolidaySalaryLevel)
                {
                    _hRHolidaySalaryLevel = value;
                    NotifyChanged("HRHolidaySalaryLevel");
                }
            }
        }
        public double HRHolidaySalaryRate
        {
            get { return _hRHolidaySalaryRate; }
            set
            {
                if (value != this._hRHolidaySalaryRate)
                {
                    _hRHolidaySalaryRate = value;
                    NotifyChanged("HRHolidaySalaryRate");
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
        public Nullable<DateTime> HRHolidayToDate
        {
            get { return _hRHolidayToDate; }
            set
            {
                if (value != this._hRHolidayToDate)
                {
                    _hRHolidayToDate = value;
                    NotifyChanged("HRHolidayToDate");
                }
            }
        }
        public Nullable<DateTime> HRHolidayDate
        {
            get { return _hRHolidayDate; }
            set
            {
                if (value != this._hRHolidayDate)
                {
                    _hRHolidayDate = value;
                    NotifyChanged("HRHolidayDate");
                }
            }
        }

        #endregion
    }
    #endregion
}