using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRAreas
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET ? H??? £i?? (v2.0.60)
    //Class: HRAreasInfo
    //Created Date: Monday, 11 Dec 2017
    //-----------------------------------------------------------

    public class HRAreasInfo : BusinessObject
    {
        public HRAreasInfo()
        {
        }
        #region Variables
        protected int _hRAreaID;
        protected String _hRAreaNo = String.Empty;
        protected String _hRAreaName = String.Empty;
        protected Nullable<DateTime> _hRAreaDate;
        protected String _hRAreaDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected bool _aASelected = true;
        protected int _fK_HRRegionID;
        protected int _fK_HRMangerID;
        protected int _fK_HRAsmApprovalID;
        protected int _fK_HRRsmApprovalID;
        protected int _fK_HRDmApprovalID;

        #endregion

        #region Public properties
        public int HRAreaID
        {
            get { return _hRAreaID; }
            set
            {
                if (value != this._hRAreaID)
                {
                    _hRAreaID = value;
                    NotifyChanged("HRAreaID");
                }
            }
        }
        public String HRAreaNo
        {
            get { return _hRAreaNo; }
            set
            {
                if (value != this._hRAreaNo)
                {
                    _hRAreaNo = value;
                    NotifyChanged("HRAreaNo");
                }
            }
        }
        public String HRAreaName
        {
            get { return _hRAreaName; }
            set
            {
                if (value != this._hRAreaName)
                {
                    _hRAreaName = value;
                    NotifyChanged("HRAreaName");
                }
            }
        }
        public Nullable<DateTime> HRAreaDate
        {
            get { return _hRAreaDate; }
            set
            {
                if (value != this._hRAreaDate)
                {
                    _hRAreaDate = value;
                    NotifyChanged("HRAreaDate");
                }
            }
        }
        public String HRAreaDesc
        {
            get { return _hRAreaDesc; }
            set
            {
                if (value != this._hRAreaDesc)
                {
                    _hRAreaDesc = value;
                    NotifyChanged("HRAreaDesc");
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
        public int FK_HRRegionID
        {
            get { return _fK_HRRegionID; }
            set
            {
                if (value != this._fK_HRRegionID)
                {
                    _fK_HRRegionID = value;
                    NotifyChanged("FK_HRRegionID");
                }
            }
        }
        public int FK_HRMangerID
        {
            get { return _fK_HRMangerID; }
            set
            {
                if (value != this._fK_HRMangerID)
                {
                    _fK_HRMangerID = value;
                    NotifyChanged("FK_HRMangerID");
                }
            }
        }
        public int FK_HRAsmApprovalID
        {
            get { return _fK_HRAsmApprovalID; }
            set
            {
                if (value != this._fK_HRAsmApprovalID)
                {
                    _fK_HRAsmApprovalID = value;
                    NotifyChanged("FK_HRAsmApprovalID");
                }
            }
        }
        public int FK_HRRsmApprovalID
        {
            get { return _fK_HRRsmApprovalID; }
            set
            {
                if (value != this._fK_HRRsmApprovalID)
                {
                    _fK_HRRsmApprovalID = value;
                    NotifyChanged("FK_HRRsmApprovalID");
                }
            }
        }
        public int FK_HRDmApprovalID
        {
            get { return _fK_HRDmApprovalID; }
            set
            {
                if (value != this._fK_HRDmApprovalID)
                {
                    _fK_HRDmApprovalID = value;
                    NotifyChanged("FK_HRDmApprovalID");
                }
            }
        }

        #endregion
    }
    #endregion
}