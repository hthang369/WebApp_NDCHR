
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRCandidateRelatives
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.80)
    //Class: HRCandidateRelativesInfo
    //Created Date: Friday, 04 Nov 2016
    //-----------------------------------------------------------

    public class HRCandidateRelativesInfo : BusinessObject
    {
        public HRCandidateRelativesInfo()
        {
        }
        #region Variables
        protected int _hRCandidateRelativeID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected int _fK_HRCandidateID;
        protected String _hRCandidateRelativeName = String.Empty;
        protected String _hRCandidateRelativeRelationshipCombo = String.Empty;
        protected String _hRCandidateRelativeStatusCombo = DefaultStatus;
        protected Nullable<DateTime> _hRCandidateRelativeDoB;
        protected String _hRCandidateRelativeOccupation = String.Empty;
        protected bool _isDependCheck = true;
        protected Nullable<DateTime> _hRCandidateRelativeDPEffectDate;
        protected String _hRCandidateRelativeRelationship = String.Empty;

        #endregion

        #region Public properties
        public int HRCandidateRelativeID
        {
            get { return _hRCandidateRelativeID; }
            set
            {
                if (value != this._hRCandidateRelativeID)
                {
                    _hRCandidateRelativeID = value;
                    NotifyChanged("HRCandidateRelativeID");
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
        public int FK_HRCandidateID
        {
            get { return _fK_HRCandidateID; }
            set
            {
                if (value != this._fK_HRCandidateID)
                {
                    _fK_HRCandidateID = value;
                    NotifyChanged("FK_HRCandidateID");
                }
            }
        }
        public String HRCandidateRelativeName
        {
            get { return _hRCandidateRelativeName; }
            set
            {
                if (value != this._hRCandidateRelativeName)
                {
                    _hRCandidateRelativeName = value;
                    NotifyChanged("HRCandidateRelativeName");
                }
            }
        }
        public String HRCandidateRelativeRelationshipCombo
        {
            get { return _hRCandidateRelativeRelationshipCombo; }
            set
            {
                if (value != this._hRCandidateRelativeRelationshipCombo)
                {
                    _hRCandidateRelativeRelationshipCombo = value;
                    NotifyChanged("HRCandidateRelativeRelationshipCombo");
                }
            }
        }
        public String HRCandidateRelativeStatusCombo
        {
            get { return _hRCandidateRelativeStatusCombo; }
            set
            {
                if (value != this._hRCandidateRelativeStatusCombo)
                {
                    _hRCandidateRelativeStatusCombo = value;
                    NotifyChanged("HRCandidateRelativeStatusCombo");
                }
            }
        }
        public Nullable<DateTime> HRCandidateRelativeDoB
        {
            get { return _hRCandidateRelativeDoB; }
            set
            {
                if (value != this._hRCandidateRelativeDoB)
                {
                    _hRCandidateRelativeDoB = value;
                    NotifyChanged("HRCandidateRelativeDoB");
                }
            }
        }
        public String HRCandidateRelativeOccupation
        {
            get { return _hRCandidateRelativeOccupation; }
            set
            {
                if (value != this._hRCandidateRelativeOccupation)
                {
                    _hRCandidateRelativeOccupation = value;
                    NotifyChanged("HRCandidateRelativeOccupation");
                }
            }
        }
        public bool IsDependCheck
        {
            get { return _isDependCheck; }
            set
            {
                if (value != this._isDependCheck)
                {
                    _isDependCheck = value;
                    NotifyChanged("IsDependCheck");
                }
            }
        }
        public Nullable<DateTime> HRCandidateRelativeDPEffectDate
        {
            get { return _hRCandidateRelativeDPEffectDate; }
            set
            {
                if (value != this._hRCandidateRelativeDPEffectDate)
                {
                    _hRCandidateRelativeDPEffectDate = value;
                    NotifyChanged("HRCandidateRelativeDPEffectDate");
                }
            }
        }
        public String HRCandidateRelativeRelationship
        {
            get { return _hRCandidateRelativeRelationship; }
            set
            {
                if (value != this._hRCandidateRelativeRelationship)
                {
                    _hRCandidateRelativeRelationship = value;
                    NotifyChanged("HRCandidateRelativeRelationship");
                }
            }
        }

        #endregion
    }
    #endregion
}