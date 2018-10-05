using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ADOFs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: ADOFsInfo
    //Created Date: Monday, 06 Aug 2018
    //-----------------------------------------------------------

    public class ADOFsInfo : BusinessObject
    {
        public ADOFsInfo()
        {
        }
        #region Variables
        protected int _aDOFID;
        protected String _aDOFColumnName = String.Empty;
        protected String _aDOFValue = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aDOFNo = String.Empty;
        protected String _aDOFName = String.Empty;
        protected String _aDOFTypeCombo = String.Empty;
        
        #endregion

        #region Public properties
        public int ADOFID
        {
            get { return _aDOFID; }
            set
            {
                if (value != this._aDOFID)
                {
                    _aDOFID = value;
                    NotifyChanged("ADOFID");
                }
            }
        }
        public String ADOFColumnName
        {
            get { return _aDOFColumnName; }
            set
            {
                if (value != this._aDOFColumnName)
                {
                    _aDOFColumnName = value;
                    NotifyChanged("ADOFColumnName");
                }
            }
        }
        public String ADOFValue
        {
            get { return _aDOFValue; }
            set
            {
                if (value != this._aDOFValue)
                {
                    _aDOFValue = value;
                    NotifyChanged("ADOFValue");
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
        public String ADOFNo
        {
            get { return _aDOFNo; }
            set
            {
                if (value != this._aDOFNo)
                {
                    _aDOFNo = value;
                    NotifyChanged("ADOFNo");
                }
            }
        }
        public String ADOFName
        {
            get { return _aDOFName; }
            set
            {
                if (value != this._aDOFName)
                {
                    _aDOFName = value;
                    NotifyChanged("ADOFName");
                }
            }
        }
        public String ADOFTypeCombo
        {
            get { return _aDOFTypeCombo; }
            set
            {
                if (value != this._aDOFTypeCombo)
                {
                    _aDOFTypeCombo = value;
                    NotifyChanged("ADOFTypeCombo");
                }
            }
        }
        
        #endregion
    }
    #endregion
}