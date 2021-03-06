using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICProductAttrs
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICProductAttrsInfo
    //Created Date:Tuesday, May 15, 2012
    //-----------------------------------------------------------

    public class ICProductAttrsInfo : BusinessObject
    {
        public ICProductAttrsInfo()
        {
        }
        #region Variables
        protected int _iCProductAttrID;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICProductID;
        protected String _iCProductAttrName = String.Empty;
        protected String _iCProductAttrValue = String.Empty;
        protected int _fK_ICProductGroupAttrID;
        #endregion

        #region Public properties
        public int ICProductAttrID
        {
            get { return _iCProductAttrID; }
            set
            {
                if (value != this._iCProductAttrID)
                {
                    _iCProductAttrID = value;
                    NotifyChanged("ICProductAttrID");
                }
            }
        }
        public DateTime AACreatedDate
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
        public DateTime AAUpdatedDate
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
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public String ICProductAttrName
        {
            get { return _iCProductAttrName; }
            set
            {
                if (value != this._iCProductAttrName)
                {
                    _iCProductAttrName = value;
                    NotifyChanged("ICProductAttrName");
                }
            }
        }
        public String ICProductAttrValue
        {
            get { return _iCProductAttrValue; }
            set
            {
                if (value != this._iCProductAttrValue)
                {
                    _iCProductAttrValue = value;
                    NotifyChanged("ICProductAttrValue");
                }
            }
        }
        public int FK_ICProductGroupAttrID
        {
            get { return _fK_ICProductGroupAttrID; }
            set
            {
                if (value != this._fK_ICProductGroupAttrID)
                {
                    _fK_ICProductGroupAttrID = value;
                    NotifyChanged("FK_ICProductGroupAttrID");
                }
            }
        }
        #endregion
    }
    #endregion
}