using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPProductionCostingCalcs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v1.0.19)
    //Class: PPProductionCostingCalcsInfo
    //Created Date: Wednesday, 05 Apr 2017
    //-----------------------------------------------------------

    public class PPProductionCostingCalcsInfo : BusinessObject
    {
        public PPProductionCostingCalcsInfo()
        {
        }
        #region Variables
        protected int _pPProductionCostingCalcID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected String _pPProductionCostingCalcNo = String.Empty;
        protected String _pPProductionCostingCalcName = String.Empty;
        protected String _pPProductionCostingCalcDesc = String.Empty;
        protected Nullable<DateTime> _pPProductionCostingCalcDate;
        protected String _aAModule = String.Empty;
        protected int _pPPeriod;
        protected int _pPYear;
        protected int _fK_PPCostCenterStepParentID;
        protected int _fK_PPCostingNormID;
        protected int _fK_PPProductFactorID;

        #endregion

        #region Public properties
        public int PPProductionCostingCalcID
        {
            get { return _pPProductionCostingCalcID; }
            set
            {
                if (value != this._pPProductionCostingCalcID)
                {
                    _pPProductionCostingCalcID = value;
                    NotifyChanged("PPProductionCostingCalcID");
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
        public String PPProductionCostingCalcNo
        {
            get { return _pPProductionCostingCalcNo; }
            set
            {
                if (value != this._pPProductionCostingCalcNo)
                {
                    _pPProductionCostingCalcNo = value;
                    NotifyChanged("PPProductionCostingCalcNo");
                }
            }
        }
        public String PPProductionCostingCalcName
        {
            get { return _pPProductionCostingCalcName; }
            set
            {
                if (value != this._pPProductionCostingCalcName)
                {
                    _pPProductionCostingCalcName = value;
                    NotifyChanged("PPProductionCostingCalcName");
                }
            }
        }
        public String PPProductionCostingCalcDesc
        {
            get { return _pPProductionCostingCalcDesc; }
            set
            {
                if (value != this._pPProductionCostingCalcDesc)
                {
                    _pPProductionCostingCalcDesc = value;
                    NotifyChanged("PPProductionCostingCalcDesc");
                }
            }
        }
        public Nullable<DateTime> PPProductionCostingCalcDate
        {
            get { return _pPProductionCostingCalcDate; }
            set
            {
                if (value != this._pPProductionCostingCalcDate)
                {
                    _pPProductionCostingCalcDate = value;
                    NotifyChanged("PPProductionCostingCalcDate");
                }
            }
        }
        public String AAModule
        {
            get { return _aAModule; }
            set
            {
                if (value != this._aAModule)
                {
                    _aAModule = value;
                    NotifyChanged("AAModule");
                }
            }
        }
        public int PPPeriod
        {
            get { return _pPPeriod; }
            set
            {
                if (value != this._pPPeriod)
                {
                    _pPPeriod = value;
                    NotifyChanged("PPPeriod");
                }
            }
        }
        public int PPYear
        {
            get { return _pPYear; }
            set
            {
                if (value != this._pPYear)
                {
                    _pPYear = value;
                    NotifyChanged("PPYear");
                }
            }
        }
        public int FK_PPCostCenterStepParentID
        {
            get { return _fK_PPCostCenterStepParentID; }
            set
            {
                if (value != this._fK_PPCostCenterStepParentID)
                {
                    _fK_PPCostCenterStepParentID = value;
                    NotifyChanged("FK_PPCostCenterStepParentID");
                }
            }
        }
        public int FK_PPCostingNormID
        {
            get { return _fK_PPCostingNormID; }
            set
            {
                if (value != this._fK_PPCostingNormID)
                {
                    _fK_PPCostingNormID = value;
                    NotifyChanged("FK_PPCostingNormID");
                }
            }
        }
        public int FK_PPProductFactorID
        {
            get { return _fK_PPProductFactorID; }
            set
            {
                if (value != this._fK_PPProductFactorID)
                {
                    _fK_PPProductFactorID = value;
                    NotifyChanged("FK_PPProductFactorID");
                }
            }
        }

        #endregion
    }
    #endregion
}