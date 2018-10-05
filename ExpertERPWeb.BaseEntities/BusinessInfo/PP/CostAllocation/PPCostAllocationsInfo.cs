using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPCostAllocations
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPCostAllocationsInfo
    //Created Date:Thursday, October 20, 2016
    //-----------------------------------------------------------

    public class PPCostAllocationsInfo : BusinessObject
    {
        public PPCostAllocationsInfo()
        {
        }
        #region Variables
        protected int _pPCostAllocationID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _pPCostAllocationNo = String.Empty;
        protected String _pPCostAllocationName = String.Empty;
        protected String _pPCostAllocationDesc = String.Empty;
        protected Nullable<DateTime> _pPCostAllocationDate;
        protected int _pPPeriod;
        protected int _pPYear;
        protected bool _pPCostAllocationCheck = false;
        #endregion

        #region Public properties
        public int PPCostAllocationID
        {
            get { return _pPCostAllocationID; }
            set
            {
                if (value != this._pPCostAllocationID)
                {
                    _pPCostAllocationID = value;
                    NotifyChanged("PPCostAllocationID");
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
        public String PPCostAllocationNo
        {
            get { return _pPCostAllocationNo; }
            set
            {
                if (value != this._pPCostAllocationNo)
                {
                    _pPCostAllocationNo = value;
                    NotifyChanged("PPCostAllocationNo");
                }
            }
        }
        public String PPCostAllocationName
        {
            get { return _pPCostAllocationName; }
            set
            {
                if (value != this._pPCostAllocationName)
                {
                    _pPCostAllocationName = value;
                    NotifyChanged("PPCostAllocationName");
                }
            }
        }
        public String PPCostAllocationDesc
        {
            get { return _pPCostAllocationDesc; }
            set
            {
                if (value != this._pPCostAllocationDesc)
                {
                    _pPCostAllocationDesc = value;
                    NotifyChanged("PPCostAllocationDesc");
                }
            }
        }
        public Nullable<DateTime> PPCostAllocationDate
        {
            get { return _pPCostAllocationDate; }
            set
            {
                if (value != this._pPCostAllocationDate)
                {
                    _pPCostAllocationDate = value;
                    NotifyChanged("PPCostAllocationDate");
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
        public bool PPCostAllocationCheck
        {
            get { return _pPCostAllocationCheck; }
            set
            {
                if (value != this._pPCostAllocationCheck)
                {
                    _pPCostAllocationCheck = value;
                    NotifyChanged("PPCostAllocationCheck");
                }
            }
        }
        #endregion
    }
    #endregion
}