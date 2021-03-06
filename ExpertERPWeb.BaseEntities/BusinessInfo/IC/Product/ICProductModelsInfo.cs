using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICProductModels
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICProductModelsInfo
    //Created Date:Saturday, December 29, 2012
    //-----------------------------------------------------------

    public class ICProductModelsInfo : BusinessObject
    {
        public ICProductModelsInfo()
        {
        }
        #region Variables
        protected int _iCProductModelID;
        protected String _iCProductModelName = String.Empty;
        protected String _iCProductModelNo = String.Empty;
        protected String _iCProductModelDesc = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICProductGroupID;
        protected String _iCProductModelCountry = String.Empty;
        protected bool _iCProductModelIsShowLayceForm = true;
        #endregion

        #region Public properties
        public int ICProductModelID
        {
            get { return _iCProductModelID; }
            set
            {
                if (value != this._iCProductModelID)
                {
                    _iCProductModelID = value;
                    NotifyChanged("ICProductModelID");
                }
            }
        }
        public String ICProductModelName
        {
            get { return _iCProductModelName; }
            set
            {
                if (value != this._iCProductModelName)
                {
                    _iCProductModelName = value;
                    NotifyChanged("ICProductModelName");
                }
            }
        }
        public String ICProductModelNo
        {
            get { return _iCProductModelNo; }
            set
            {
                if (value != this._iCProductModelNo)
                {
                    _iCProductModelNo = value;
                    NotifyChanged("ICProductModelNo");
                }
            }
        }
        public String ICProductModelDesc
        {
            get { return _iCProductModelDesc; }
            set
            {
                if (value != this._iCProductModelDesc)
                {
                    _iCProductModelDesc = value;
                    NotifyChanged("ICProductModelDesc");
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
        public int FK_ICProductGroupID
        {
            get { return _fK_ICProductGroupID; }
            set
            {
                if (value != this._fK_ICProductGroupID)
                {
                    _fK_ICProductGroupID = value;
                    NotifyChanged("FK_ICProductGroupID");
                }
            }
        }
        public String ICProductModelCountry
        {
            get { return _iCProductModelCountry; }
            set
            {
                if (value != this._iCProductModelCountry)
                {
                    _iCProductModelCountry = value;
                    NotifyChanged("ICProductModelCountry");
                }
            }
        }
        public bool ICProductModelIsShowLayceForm
        {
            get { return _iCProductModelIsShowLayceForm; }
            set
            {
                if (value != this._iCProductModelIsShowLayceForm)
                {
                    _iCProductModelIsShowLayceForm = value;
                    NotifyChanged("ICProductModelIsShowLayceForm");
                }
            }
        }
        #endregion
    }
    #endregion
}