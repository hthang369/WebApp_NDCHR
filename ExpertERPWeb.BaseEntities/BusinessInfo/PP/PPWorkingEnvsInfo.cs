using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPWorkingEnvs
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:PPWorkingEnvsInfo
    //Created Date:31 Tháng Tám 2013
    //-----------------------------------------------------------

    public class PPWorkingEnvsInfo : BusinessObject
    {
        public PPWorkingEnvsInfo()
        {
        }
        #region Variables
        protected int _pPWorkingEnvID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPWorkingEnvNo = String.Empty;
        protected String _pPWorkingEnvName = String.Empty;
        protected String _pPWorkingEnvDesc = String.Empty;
        protected Nullable<DateTime> _pPWorkingEnvDate;
        protected double _pPWorkingEnvScore;
        protected double _pPWorkingEnvEfficiencyPct;
        protected double _pPWorkingEnvTotalScore;
        #endregion

        #region Public properties
        public int PPWorkingEnvID
        {
            get { return _pPWorkingEnvID; }
            set
            {
                if (value != this._pPWorkingEnvID)
                {
                    _pPWorkingEnvID = value;
                    NotifyChanged("PPWorkingEnvID");
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
        public String PPWorkingEnvNo
        {
            get { return _pPWorkingEnvNo; }
            set
            {
                if (value != this._pPWorkingEnvNo)
                {
                    _pPWorkingEnvNo = value;
                    NotifyChanged("PPWorkingEnvNo");
                }
            }
        }
        public String PPWorkingEnvName
        {
            get { return _pPWorkingEnvName; }
            set
            {
                if (value != this._pPWorkingEnvName)
                {
                    _pPWorkingEnvName = value;
                    NotifyChanged("PPWorkingEnvName");
                }
            }
        }
        public String PPWorkingEnvDesc
        {
            get { return _pPWorkingEnvDesc; }
            set
            {
                if (value != this._pPWorkingEnvDesc)
                {
                    _pPWorkingEnvDesc = value;
                    NotifyChanged("PPWorkingEnvDesc");
                }
            }
        }
        public Nullable<DateTime> PPWorkingEnvDate
        {
            get { return _pPWorkingEnvDate; }
            set
            {
                if (value != this._pPWorkingEnvDate)
                {
                    _pPWorkingEnvDate = value;
                    NotifyChanged("PPWorkingEnvDate");
                }
            }
        }
        public double PPWorkingEnvScore
        {
            get { return _pPWorkingEnvScore; }
            set
            {
                if (value != this._pPWorkingEnvScore)
                {
                    _pPWorkingEnvScore = value;
                    NotifyChanged("PPWorkingEnvScore");
                }
            }
        }
        public double PPWorkingEnvEfficiencyPct
        {
            get { return _pPWorkingEnvEfficiencyPct; }
            set
            {
                if (value != this._pPWorkingEnvEfficiencyPct)
                {
                    _pPWorkingEnvEfficiencyPct = value;
                    NotifyChanged("PPWorkingEnvEfficiencyPct");
                }
            }
        }
        public double PPWorkingEnvTotalScore
        {
            get { return _pPWorkingEnvTotalScore; }
            set
            {
                if (value != this._pPWorkingEnvTotalScore)
                {
                    _pPWorkingEnvTotalScore = value;
                    NotifyChanged("PPWorkingEnvTotalScore");
                }
            }
        }
        #endregion
    }
    #endregion
}