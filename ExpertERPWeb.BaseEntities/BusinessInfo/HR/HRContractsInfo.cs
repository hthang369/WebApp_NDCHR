
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRContracts
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.83)
    //Class: HRContractsInfo
    //Created Date: Wednesday, 15 Feb 2017
    //-----------------------------------------------------------

    public class HRContractsInfo : BusinessObject
    {
        public HRContractsInfo()
        {
        }
        #region Variables
        protected int _hRContractID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected String _hRContractNo = String.Empty;
        protected String _hRContractName = String.Empty;
        protected int _fK_HRSalaryLevelID;
        protected DateTime _hRContractDate = DateTime.Now;
        protected String _hRContractDesc = String.Empty;
        protected double _hRContractInsuranceAmt;
        protected double _hRContractSlrAmt;
        protected bool _hRContractInclInsCheck = true;
        protected double _hRContractMaxLDays;
        protected double _hRContractIncSeniority;
        protected bool _hRContractDefaultCheck = true;
        protected String _hRContractDocumentPath = String.Empty;
        protected double _hRContractAdvPmtAmt;
        protected String _hRContractTypeCombo = String.Empty;
        protected bool _aASelected = true;
        protected String _aAOrgDocNo = String.Empty;
        protected int _fK_HRContractTypeID;

        #endregion

        #region Public properties
        public int HRContractID
        {
            get { return _hRContractID; }
            set
            {
                if (value != this._hRContractID)
                {
                    _hRContractID = value;
                    NotifyChanged("HRContractID");
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
        public String HRContractNo
        {
            get { return _hRContractNo; }
            set
            {
                if (value != this._hRContractNo)
                {
                    _hRContractNo = value;
                    NotifyChanged("HRContractNo");
                }
            }
        }
        public String HRContractName
        {
            get { return _hRContractName; }
            set
            {
                if (value != this._hRContractName)
                {
                    _hRContractName = value;
                    NotifyChanged("HRContractName");
                }
            }
        }
        public int FK_HRSalaryLevelID
        {
            get { return _fK_HRSalaryLevelID; }
            set
            {
                if (value != this._fK_HRSalaryLevelID)
                {
                    _fK_HRSalaryLevelID = value;
                    NotifyChanged("FK_HRSalaryLevelID");
                }
            }
        }
        public DateTime HRContractDate
        {
            get { return _hRContractDate; }
            set
            {
                if (value != this._hRContractDate)
                {
                    _hRContractDate = value;
                    NotifyChanged("HRContractDate");
                }
            }
        }
        public String HRContractDesc
        {
            get { return _hRContractDesc; }
            set
            {
                if (value != this._hRContractDesc)
                {
                    _hRContractDesc = value;
                    NotifyChanged("HRContractDesc");
                }
            }
        }
        public double HRContractInsuranceAmt
        {
            get { return _hRContractInsuranceAmt; }
            set
            {
                if (value != this._hRContractInsuranceAmt)
                {
                    _hRContractInsuranceAmt = value;
                    NotifyChanged("HRContractInsuranceAmt");
                }
            }
        }
        public double HRContractSlrAmt
        {
            get { return _hRContractSlrAmt; }
            set
            {
                if (value != this._hRContractSlrAmt)
                {
                    _hRContractSlrAmt = value;
                    NotifyChanged("HRContractSlrAmt");
                }
            }
        }
        public bool HRContractInclInsCheck
        {
            get { return _hRContractInclInsCheck; }
            set
            {
                if (value != this._hRContractInclInsCheck)
                {
                    _hRContractInclInsCheck = value;
                    NotifyChanged("HRContractInclInsCheck");
                }
            }
        }
        public double HRContractMaxLDays
        {
            get { return _hRContractMaxLDays; }
            set
            {
                if (value != this._hRContractMaxLDays)
                {
                    _hRContractMaxLDays = value;
                    NotifyChanged("HRContractMaxLDays");
                }
            }
        }
        public double HRContractIncSeniority
        {
            get { return _hRContractIncSeniority; }
            set
            {
                if (value != this._hRContractIncSeniority)
                {
                    _hRContractIncSeniority = value;
                    NotifyChanged("HRContractIncSeniority");
                }
            }
        }
        public bool HRContractDefaultCheck
        {
            get { return _hRContractDefaultCheck; }
            set
            {
                if (value != this._hRContractDefaultCheck)
                {
                    _hRContractDefaultCheck = value;
                    NotifyChanged("HRContractDefaultCheck");
                }
            }
        }
        public String HRContractDocumentPath
        {
            get { return _hRContractDocumentPath; }
            set
            {
                if (value != this._hRContractDocumentPath)
                {
                    _hRContractDocumentPath = value;
                    NotifyChanged("HRContractDocumentPath");
                }
            }
        }
        public double HRContractAdvPmtAmt
        {
            get { return _hRContractAdvPmtAmt; }
            set
            {
                if (value != this._hRContractAdvPmtAmt)
                {
                    _hRContractAdvPmtAmt = value;
                    NotifyChanged("HRContractAdvPmtAmt");
                }
            }
        }
        public String HRContractTypeCombo
        {
            get { return _hRContractTypeCombo; }
            set
            {
                if (value != this._hRContractTypeCombo)
                {
                    _hRContractTypeCombo = value;
                    NotifyChanged("HRContractTypeCombo");
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
        public int FK_HRContractTypeID
        {
            get { return _fK_HRContractTypeID; }
            set
            {
                if (value != this._fK_HRContractTypeID)
                {
                    _fK_HRContractTypeID = value;
                    NotifyChanged("FK_HRContractTypeID");
                }
            }
        }

        #endregion
    }
    #endregion
}