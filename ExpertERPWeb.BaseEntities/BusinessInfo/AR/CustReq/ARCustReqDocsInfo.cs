using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARCustReqDocs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ARCustReqDocsInfo
    //Created Date:Tuesday, December 16, 2014
    //-----------------------------------------------------------

    public class ARCustReqDocsInfo : BusinessObject
    {
        public ARCustReqDocsInfo()
        {
        }
        #region Variables
        protected int _aRCustReqDocID;
        protected String _aRCustReqDocNo = String.Empty;
        protected String _aRCustReqDocDesc = String.Empty;
        protected String _aRCustReqDocUser = String.Empty;
        protected Nullable<DateTime> _aRCustReqDocDate;
        protected String _aRCustReqDocServerPath = String.Empty;
        protected int _fK_ARCustReqID;
        protected int _fK_ADUserID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        #endregion

        #region Public properties
        public int ARCustReqDocID
        {
            get { return _aRCustReqDocID; }
            set
            {
                if (value != this._aRCustReqDocID)
                {
                    _aRCustReqDocID = value;
                    NotifyChanged("ARCustReqDocID");
                }
            }
        }
        public String ARCustReqDocNo
        {
            get { return _aRCustReqDocNo; }
            set
            {
                if (value != this._aRCustReqDocNo)
                {
                    _aRCustReqDocNo = value;
                    NotifyChanged("ARCustReqDocNo");
                }
            }
        }
        public String ARCustReqDocDesc
        {
            get { return _aRCustReqDocDesc; }
            set
            {
                if (value != this._aRCustReqDocDesc)
                {
                    _aRCustReqDocDesc = value;
                    NotifyChanged("ARCustReqDocDesc");
                }
            }
        }
        public String ARCustReqDocUser
        {
            get { return _aRCustReqDocUser; }
            set
            {
                if (value != this._aRCustReqDocUser)
                {
                    _aRCustReqDocUser = value;
                    NotifyChanged("ARCustReqDocUser");
                }
            }
        }
        public Nullable<DateTime> ARCustReqDocDate
        {
            get { return _aRCustReqDocDate; }
            set
            {
                if (value != this._aRCustReqDocDate)
                {
                    _aRCustReqDocDate = value;
                    NotifyChanged("ARCustReqDocDate");
                }
            }
        }
        public String ARCustReqDocServerPath
        {
            get { return _aRCustReqDocServerPath; }
            set
            {
                if (value != this._aRCustReqDocServerPath)
                {
                    _aRCustReqDocServerPath = value;
                    NotifyChanged("ARCustReqDocServerPath");
                }
            }
        }
        public int FK_ARCustReqID
        {
            get { return _fK_ARCustReqID; }
            set
            {
                if (value != this._fK_ARCustReqID)
                {
                    _fK_ARCustReqID = value;
                    NotifyChanged("FK_ARCustReqID");
                }
            }
        }
        public int FK_ADUserID
        {
            get { return _fK_ADUserID; }
            set
            {
                if (value != this._fK_ADUserID)
                {
                    _fK_ADUserID = value;
                    NotifyChanged("FK_ADUserID");
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
        #endregion
    }
    #endregion
}