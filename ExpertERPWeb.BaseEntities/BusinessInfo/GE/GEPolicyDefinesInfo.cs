
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GEPolicyDefines
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.88)
    //Class: GEPolicyDefinesInfo
    //Created Date: Friday, 05 May 2017
    //-----------------------------------------------------------

    public class GEPolicyDefinesInfo : BusinessObject
    {
        public GEPolicyDefinesInfo()
        {
        }
        #region Variables
        protected int _gEPolicyDefineID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aAModule = String.Empty;
        protected String _aAOrgDocNo = String.Empty;
        protected String _gEPolicyDefineNo = String.Empty;
        protected String _gEPolicyDefineName = String.Empty;
        protected Nullable<DateTime> _gEPolicyDefineDate;
        protected String _gEPolicyDefineDesc = String.Empty;
        protected Nullable<DateTime> _gEPolicyDefineEffectDate;
        protected Nullable<DateTime> _gEPolicyDefineFDate;
        protected Nullable<DateTime> _gEPolicyDefineTDate;
        protected String _gEPolicyDefineFreqCombo = String.Empty;
        protected int _fK_GECurrencyID;
        protected int _fK_GEFuncTypeID;
        protected bool _gEPolicyDefineCalculateCheck = true;
        protected String _gEPolicyDefineTypeCombo = String.Empty;
        protected int _fK_GEPolicyTypeID;
        protected String _gEPayrollTypeAttributeCombo = String.Empty;

        #endregion

        #region Public properties
        public int GEPolicyDefineID
        {
            get { return _gEPolicyDefineID; }
            set
            {
                if (value != this._gEPolicyDefineID)
                {
                    _gEPolicyDefineID = value;
                    NotifyChanged("GEPolicyDefineID");
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
        public String AAModule
        {
            get { return _aAModule; }
            set
            {
                if (value != this._aAModule)
                {
                    _aAModule = value;
                    NotifyChanged("AAModule");
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
        public String GEPolicyDefineNo
        {
            get { return _gEPolicyDefineNo; }
            set
            {
                if (value != this._gEPolicyDefineNo)
                {
                    _gEPolicyDefineNo = value;
                    NotifyChanged("GEPolicyDefineNo");
                }
            }
        }
        public String GEPolicyDefineName
        {
            get { return _gEPolicyDefineName; }
            set
            {
                if (value != this._gEPolicyDefineName)
                {
                    _gEPolicyDefineName = value;
                    NotifyChanged("GEPolicyDefineName");
                }
            }
        }
        public Nullable<DateTime> GEPolicyDefineDate
        {
            get { return _gEPolicyDefineDate; }
            set
            {
                if (value != this._gEPolicyDefineDate)
                {
                    _gEPolicyDefineDate = value;
                    NotifyChanged("GEPolicyDefineDate");
                }
            }
        }
        public String GEPolicyDefineDesc
        {
            get { return _gEPolicyDefineDesc; }
            set
            {
                if (value != this._gEPolicyDefineDesc)
                {
                    _gEPolicyDefineDesc = value;
                    NotifyChanged("GEPolicyDefineDesc");
                }
            }
        }
        public Nullable<DateTime> GEPolicyDefineEffectDate
        {
            get { return _gEPolicyDefineEffectDate; }
            set
            {
                if (value != this._gEPolicyDefineEffectDate)
                {
                    _gEPolicyDefineEffectDate = value;
                    NotifyChanged("GEPolicyDefineEffectDate");
                }
            }
        }
        public Nullable<DateTime> GEPolicyDefineFDate
        {
            get { return _gEPolicyDefineFDate; }
            set
            {
                if (value != this._gEPolicyDefineFDate)
                {
                    _gEPolicyDefineFDate = value;
                    NotifyChanged("GEPolicyDefineFDate");
                }
            }
        }
        public Nullable<DateTime> GEPolicyDefineTDate
        {
            get { return _gEPolicyDefineTDate; }
            set
            {
                if (value != this._gEPolicyDefineTDate)
                {
                    _gEPolicyDefineTDate = value;
                    NotifyChanged("GEPolicyDefineTDate");
                }
            }
        }
        public String GEPolicyDefineFreqCombo
        {
            get { return _gEPolicyDefineFreqCombo; }
            set
            {
                if (value != this._gEPolicyDefineFreqCombo)
                {
                    _gEPolicyDefineFreqCombo = value;
                    NotifyChanged("GEPolicyDefineFreqCombo");
                }
            }
        }
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        public int FK_GEFuncTypeID
        {
            get { return _fK_GEFuncTypeID; }
            set
            {
                if (value != this._fK_GEFuncTypeID)
                {
                    _fK_GEFuncTypeID = value;
                    NotifyChanged("FK_GEFuncTypeID");
                }
            }
        }
        public bool GEPolicyDefineCalculateCheck
        {
            get { return _gEPolicyDefineCalculateCheck; }
            set
            {
                if (value != this._gEPolicyDefineCalculateCheck)
                {
                    _gEPolicyDefineCalculateCheck = value;
                    NotifyChanged("GEPolicyDefineCalculateCheck");
                }
            }
        }
        public String GEPolicyDefineTypeCombo
        {
            get { return _gEPolicyDefineTypeCombo; }
            set
            {
                if (value != this._gEPolicyDefineTypeCombo)
                {
                    _gEPolicyDefineTypeCombo = value;
                    NotifyChanged("GEPolicyDefineTypeCombo");
                }
            }
        }
        public int FK_GEPolicyTypeID
        {
            get { return _fK_GEPolicyTypeID; }
            set
            {
                if (value != this._fK_GEPolicyTypeID)
                {
                    _fK_GEPolicyTypeID = value;
                    NotifyChanged("FK_GEPolicyTypeID");
                }
            }
        }
        public String GEPayrollTypeAttributeCombo
        {
            get { return _gEPayrollTypeAttributeCombo; }
            set
            {
                if (value != this._gEPayrollTypeAttributeCombo)
                {
                    _gEPayrollTypeAttributeCombo = value;
                    NotifyChanged("GEPayrollTypeAttributeCombo");
                }
            }
        }

        #endregion
    }
    #endregion
}