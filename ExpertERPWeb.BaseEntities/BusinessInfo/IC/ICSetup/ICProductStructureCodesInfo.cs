using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICProductStructureCodes
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICProductStructureCodesInfo
    //Created Date:Monday, November 5, 2012
    //-----------------------------------------------------------

    public class ICProductStructureCodesInfo : BusinessObject
    {
        public ICProductStructureCodesInfo()
        {
        }
        #region Variables
        protected int _iCProductStructureCodeID;
        protected String _iCProductStructureCodeNo = String.Empty;
        protected String _iCProductStructureCodeName = String.Empty;
        protected String _iCProductStructureCodeDesc = String.Empty;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        #endregion

        #region Public properties
        public int ICProductStructureCodeID
        {
            get { return _iCProductStructureCodeID; }
            set
            {
                if (value != this._iCProductStructureCodeID)
                {
                    _iCProductStructureCodeID = value;
                    NotifyChanged("ICProductStructureCodeID");
                }
            }
        }
        public String ICProductStructureCodeNo
        {
            get { return _iCProductStructureCodeNo; }
            set
            {
                if (value != this._iCProductStructureCodeNo)
                {
                    _iCProductStructureCodeNo = value;
                    NotifyChanged("ICProductStructureCodeNo");
                }
            }
        }
        public String ICProductStructureCodeName
        {
            get { return _iCProductStructureCodeName; }
            set
            {
                if (value != this._iCProductStructureCodeName)
                {
                    _iCProductStructureCodeName = value;
                    NotifyChanged("ICProductStructureCodeName");
                }
            }
        }
        public String ICProductStructureCodeDesc
        {
            get { return _iCProductStructureCodeDesc; }
            set
            {
                if (value != this._iCProductStructureCodeDesc)
                {
                    _iCProductStructureCodeDesc = value;
                    NotifyChanged("ICProductStructureCodeDesc");
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
        #endregion
    }
    #endregion
}