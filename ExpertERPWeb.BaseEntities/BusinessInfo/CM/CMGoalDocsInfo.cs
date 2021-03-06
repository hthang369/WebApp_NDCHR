using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region CMGoalDocs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:CMGoalDocsInfo
    //Created Date:27 Tháng Bảy 2012
    //-----------------------------------------------------------

    public class CMGoalDocsInfo : BusinessObject
    {
        public CMGoalDocsInfo()
        {
        }
        #region Variables
        protected int _cMGoalDocID;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _cMGoalDocNo = String.Empty;
        protected String _cMGoalDocDesc = String.Empty;
        protected int _fK_ADUserID;
        protected Nullable<DateTime> _cMGoalDocDate;
        protected String _cMGoalDocServerPath = String.Empty;
        protected int _fK_CMGoalID;
        protected String _cMGoalDocName = String.Empty;
        protected String _cMGoalDocServerFileName = String.Empty;
        protected String _cMGoalDocFileName = String.Empty;
        protected String _cMGoalDocClientPath = String.Empty;
        #endregion

        #region Public properties
        public int CMGoalDocID
        {
            get { return _cMGoalDocID; }
            set
            {
                if (value != this._cMGoalDocID)
                {
                    _cMGoalDocID = value;
                    NotifyChanged("CMGoalDocID");
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
        public String CMGoalDocNo
        {
            get { return _cMGoalDocNo; }
            set
            {
                if (value != this._cMGoalDocNo)
                {
                    _cMGoalDocNo = value;
                    NotifyChanged("CMGoalDocNo");
                }
            }
        }
        public String CMGoalDocDesc
        {
            get { return _cMGoalDocDesc; }
            set
            {
                if (value != this._cMGoalDocDesc)
                {
                    _cMGoalDocDesc = value;
                    NotifyChanged("CMGoalDocDesc");
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
        public Nullable<DateTime> CMGoalDocDate
        {
            get { return _cMGoalDocDate; }
            set
            {
                if (value != this._cMGoalDocDate)
                {
                    _cMGoalDocDate = value;
                    NotifyChanged("CMGoalDocDate");
                }
            }
        }
        public String CMGoalDocServerPath
        {
            get { return _cMGoalDocServerPath; }
            set
            {
                if (value != this._cMGoalDocServerPath)
                {
                    _cMGoalDocServerPath = value;
                    NotifyChanged("CMGoalDocServerPath");
                }
            }
        }
        public int FK_CMGoalID
        {
            get { return _fK_CMGoalID; }
            set
            {
                if (value != this._fK_CMGoalID)
                {
                    _fK_CMGoalID = value;
                    NotifyChanged("FK_CMGoalID");
                }
            }
        }
        public String CMGoalDocName
        {
            get { return _cMGoalDocName; }
            set
            {
                if (value != this._cMGoalDocName)
                {
                    _cMGoalDocName = value;
                    NotifyChanged("CMGoalDocName");
                }
            }
        }
        public String CMGoalDocServerFileName
        {
            get { return _cMGoalDocServerFileName; }
            set
            {
                if (value != this._cMGoalDocServerFileName)
                {
                    _cMGoalDocServerFileName = value;
                    NotifyChanged("CMGoalDocServerFileName");
                }
            }
        }
        public String CMGoalDocFileName
        {
            get { return _cMGoalDocFileName; }
            set
            {
                if (value != this._cMGoalDocFileName)
                {
                    _cMGoalDocFileName = value;
                    NotifyChanged("CMGoalDocFileName");
                }
            }
        }
        public String CMGoalDocClientPath
        {
            get { return _cMGoalDocClientPath; }
            set
            {
                if (value != this._cMGoalDocClientPath)
                {
                    _cMGoalDocClientPath = value;
                    NotifyChanged("CMGoalDocClientPath");
                }
            }
        }
        #endregion
    }
    #endregion
}