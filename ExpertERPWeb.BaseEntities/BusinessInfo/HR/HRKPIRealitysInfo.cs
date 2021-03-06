using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRKPIRealitys
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.93)
    //Class: HRKPIRealitysInfo
    //Created Date: Tuesday, 10 Jul 2018
    //-----------------------------------------------------------

    public class HRKPIRealitysInfo : BusinessObject
    {
        public HRKPIRealitysInfo()
        {
        }
        #region Variables
        protected int _hRKPIRealityID;
        protected String _hRKPIRealityNo = String.Empty;
        protected String _hRKPIRealityName = String.Empty;
        protected Nullable<DateTime> _hRKPIRealityDate;
        protected String _hRKPIRealityDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected int _fK_HRPeriodID;
        protected int _fK_HRTargetID;
        
        #endregion

        #region Public properties
        public int HRKPIRealityID
        {
            get { return _hRKPIRealityID; }
            set
            {
                if (value != this._hRKPIRealityID)
                {
                    _hRKPIRealityID = value;
                    NotifyChanged("HRKPIRealityID");
                }
            }
        }
        public String HRKPIRealityNo
        {
            get { return _hRKPIRealityNo; }
            set
            {
                if (value != this._hRKPIRealityNo)
                {
                    _hRKPIRealityNo = value;
                    NotifyChanged("HRKPIRealityNo");
                }
            }
        }
        public String HRKPIRealityName
        {
            get { return _hRKPIRealityName; }
            set
            {
                if (value != this._hRKPIRealityName)
                {
                    _hRKPIRealityName = value;
                    NotifyChanged("HRKPIRealityName");
                }
            }
        }
        public Nullable<DateTime> HRKPIRealityDate
        {
            get { return _hRKPIRealityDate; }
            set
            {
                if (value != this._hRKPIRealityDate)
                {
                    _hRKPIRealityDate = value;
                    NotifyChanged("HRKPIRealityDate");
                }
            }
        }
        public String HRKPIRealityDesc
        {
            get { return _hRKPIRealityDesc; }
            set
            {
                if (value != this._hRKPIRealityDesc)
                {
                    _hRKPIRealityDesc = value;
                    NotifyChanged("HRKPIRealityDesc");
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
        public int FK_HRPeriodID
        {
            get { return _fK_HRPeriodID; }
            set
            {
                if (value != this._fK_HRPeriodID)
                {
                    _fK_HRPeriodID = value;
                    NotifyChanged("FK_HRPeriodID");
                }
            }
        }
        public int FK_HRTargetID
        {
            get { return _fK_HRTargetID; }
            set
            {
                if (value != this._fK_HRTargetID)
                {
                    _fK_HRTargetID = value;
                    NotifyChanged("FK_HRTargetID");
                }
            }
        }
        
        #endregion
    }
    #endregion
}