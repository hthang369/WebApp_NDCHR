using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPProductFactors
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPProductFactorsInfo
    //Created Date:Friday, September 23, 2016
    //-----------------------------------------------------------

    public class PPProductFactorsInfo : BusinessObject
    {
        public PPProductFactorsInfo()
        {
        }
        #region Variables
        protected int _pPProductFactorID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPProductFactorNo = String.Empty;
        protected String _pPProductFactorName = String.Empty;
        protected String _pPProductFactorDesc = String.Empty;
        protected int _pPYear;
        protected int _pPPeriod;
        protected Nullable<DateTime> _pPProductFactorDate;
        protected Nullable<DateTime> _pPProductFactorApplyFromDate;
        protected Nullable<DateTime> _pPProductFactorApplyToDate;
        #endregion

        #region Public properties
        public int PPProductFactorID
        {
            get { return _pPProductFactorID; }
            set
            {
                if (value != this._pPProductFactorID)
                {
                    _pPProductFactorID = value;
                    NotifyChanged("PPProductFactorID");
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
        public String PPProductFactorNo
        {
            get { return _pPProductFactorNo; }
            set
            {
                if (value != this._pPProductFactorNo)
                {
                    _pPProductFactorNo = value;
                    NotifyChanged("PPProductFactorNo");
                }
            }
        }
        public String PPProductFactorName
        {
            get { return _pPProductFactorName; }
            set
            {
                if (value != this._pPProductFactorName)
                {
                    _pPProductFactorName = value;
                    NotifyChanged("PPProductFactorName");
                }
            }
        }
        public String PPProductFactorDesc
        {
            get { return _pPProductFactorDesc; }
            set
            {
                if (value != this._pPProductFactorDesc)
                {
                    _pPProductFactorDesc = value;
                    NotifyChanged("PPProductFactorDesc");
                }
            }
        }
        public int PPYear
        {
            get { return _pPYear; }
            set
            {
                if (value != this._pPYear)
                {
                    _pPYear = value;
                    NotifyChanged("PPYear");
                }
            }
        }
        public int PPPeriod
        {
            get { return _pPPeriod; }
            set
            {
                if (value != this._pPPeriod)
                {
                    _pPPeriod = value;
                    NotifyChanged("PPPeriod");
                }
            }
        }
        public Nullable<DateTime> PPProductFactorDate
        {
            get { return _pPProductFactorDate; }
            set
            {
                if (value != this._pPProductFactorDate)
                {
                    _pPProductFactorDate = value;
                    NotifyChanged("PPProductFactorDate");
                }
            }
        }
        public Nullable<DateTime> PPProductFactorApplyFromDate
        {
            get { return _pPProductFactorApplyFromDate; }
            set
            {
                if (value != this._pPProductFactorApplyFromDate)
                {
                    _pPProductFactorApplyFromDate = value;
                    NotifyChanged("PPProductFactorApplyFromDate");
                }
            }
        }
        public Nullable<DateTime> PPProductFactorApplyToDate
        {
            get { return _pPProductFactorApplyToDate; }
            set
            {
                if (value != this._pPProductFactorApplyToDate)
                {
                    _pPProductFactorApplyToDate = value;
                    NotifyChanged("PPProductFactorApplyToDate");
                }
            }
        }
        #endregion
    }
    #endregion
}