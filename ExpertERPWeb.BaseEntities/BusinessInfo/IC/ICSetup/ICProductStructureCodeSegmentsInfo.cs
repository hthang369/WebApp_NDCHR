using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICProductStructureCodeSegments
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICProductStructureCodeSegmentsInfo
    //Created Date:Monday, November 5, 2012
    //-----------------------------------------------------------

    public class ICProductStructureCodeSegmentsInfo : BusinessObject
    {
        public ICProductStructureCodeSegmentsInfo()
        {
        }
        #region Variables
        protected int _iCProductStructureCodeSegmentID;
        protected String _iCProductStructureCodeSegmentNo = String.Empty;
        protected String _iCProductStructureCodeSegmentName = String.Empty;
        protected String _iCProductStructureCodeSegmentDesc = String.Empty;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected String _aACreatedUser = String.Empty;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICProductStructureCodeID;
        protected String _iCProductStructureCodeSegmentMapping = String.Empty;
        protected String _iCProductStructureCodeSegmentSeperate = String.Empty;
        protected int _iCProductStructureCodeSegmentLength;
        protected String _iCProductStructureCodeSegmentTypeCombo = String.Empty;
        #endregion

        #region Public properties
        public int ICProductStructureCodeSegmentID
        {
            get { return _iCProductStructureCodeSegmentID; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentID)
                {
                    _iCProductStructureCodeSegmentID = value;
                    NotifyChanged("ICProductStructureCodeSegmentID");
                }
            }
        }
        public String ICProductStructureCodeSegmentNo
        {
            get { return _iCProductStructureCodeSegmentNo; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentNo)
                {
                    _iCProductStructureCodeSegmentNo = value;
                    NotifyChanged("ICProductStructureCodeSegmentNo");
                }
            }
        }
        public String ICProductStructureCodeSegmentName
        {
            get { return _iCProductStructureCodeSegmentName; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentName)
                {
                    _iCProductStructureCodeSegmentName = value;
                    NotifyChanged("ICProductStructureCodeSegmentName");
                }
            }
        }
        public String ICProductStructureCodeSegmentDesc
        {
            get { return _iCProductStructureCodeSegmentDesc; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentDesc)
                {
                    _iCProductStructureCodeSegmentDesc = value;
                    NotifyChanged("ICProductStructureCodeSegmentDesc");
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
        public int FK_ICProductStructureCodeID
        {
            get { return _fK_ICProductStructureCodeID; }
            set
            {
                if (value != this._fK_ICProductStructureCodeID)
                {
                    _fK_ICProductStructureCodeID = value;
                    NotifyChanged("FK_ICProductStructureCodeID");
                }
            }
        }
        public String ICProductStructureCodeSegmentMapping
        {
            get { return _iCProductStructureCodeSegmentMapping; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentMapping)
                {
                    _iCProductStructureCodeSegmentMapping = value;
                    NotifyChanged("ICProductStructureCodeSegmentMapping");
                }
            }
        }
        public String ICProductStructureCodeSegmentSeperate
        {
            get { return _iCProductStructureCodeSegmentSeperate; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentSeperate)
                {
                    _iCProductStructureCodeSegmentSeperate = value;
                    NotifyChanged("ICProductStructureCodeSegmentSeperate");
                }
            }
        }
        public int ICProductStructureCodeSegmentLength
        {
            get { return _iCProductStructureCodeSegmentLength; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentLength)
                {
                    _iCProductStructureCodeSegmentLength = value;
                    NotifyChanged("ICProductStructureCodeSegmentLength");
                }
            }
        }
        public String ICProductStructureCodeSegmentTypeCombo
        {
            get { return _iCProductStructureCodeSegmentTypeCombo; }
            set
            {
                if (value != this._iCProductStructureCodeSegmentTypeCombo)
                {
                    _iCProductStructureCodeSegmentTypeCombo = value;
                    NotifyChanged("ICProductStructureCodeSegmentTypeCombo");
                }
            }
        }
        #endregion
    }
    #endregion
}