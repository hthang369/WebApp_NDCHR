
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPNorms
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.82)
    //Class: PPNormsInfo
    //Created Date: Tuesday, 20 Dec 2016
    //-----------------------------------------------------------

    public class PPNormsInfo : BusinessObject
    {
        public PPNormsInfo()
        {
        }
        #region Variables
        protected int _pPNormID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _pPNormNo = String.Empty;
        protected String _pPNormName = String.Empty;
        protected String _pPNormDesc = String.Empty;
        protected DateTime _pPNormDate = DateTime.Now;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ARCustomerID;
        protected double _pPNormEstRMCost;
        protected double _pPNormEstLabourCost;
        protected double _pPNormEstOverheadCost;
        protected double _pPNormEstCost;
        protected String _approvalStatusCombo = DefaultStatus;
        protected String _pPNormRevision = String.Empty;
        protected int _pPNormAllocatePct;
        protected bool _aASelected = true;
        protected bool _pPNormActiveCheck = true;
        protected String _aAModule = String.Empty;

        #endregion

        #region Public properties
        public int PPNormID
        {
            get { return _pPNormID; }
            set
            {
                if (value != this._pPNormID)
                {
                    _pPNormID = value;
                    NotifyChanged("PPNormID");
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
        public String PPNormNo
        {
            get { return _pPNormNo; }
            set
            {
                if (value != this._pPNormNo)
                {
                    _pPNormNo = value;
                    NotifyChanged("PPNormNo");
                }
            }
        }
        public String PPNormName
        {
            get { return _pPNormName; }
            set
            {
                if (value != this._pPNormName)
                {
                    _pPNormName = value;
                    NotifyChanged("PPNormName");
                }
            }
        }
        public String PPNormDesc
        {
            get { return _pPNormDesc; }
            set
            {
                if (value != this._pPNormDesc)
                {
                    _pPNormDesc = value;
                    NotifyChanged("PPNormDesc");
                }
            }
        }
        public DateTime PPNormDate
        {
            get { return _pPNormDate; }
            set
            {
                if (value != this._pPNormDate)
                {
                    _pPNormDate = value;
                    NotifyChanged("PPNormDate");
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                    NotifyChanged("FK_ICStockID");
                }
            }
        }
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
                }
            }
        }
        public double PPNormEstRMCost
        {
            get { return _pPNormEstRMCost; }
            set
            {
                if (value != this._pPNormEstRMCost)
                {
                    _pPNormEstRMCost = value;
                    NotifyChanged("PPNormEstRMCost");
                }
            }
        }
        public double PPNormEstLabourCost
        {
            get { return _pPNormEstLabourCost; }
            set
            {
                if (value != this._pPNormEstLabourCost)
                {
                    _pPNormEstLabourCost = value;
                    NotifyChanged("PPNormEstLabourCost");
                }
            }
        }
        public double PPNormEstOverheadCost
        {
            get { return _pPNormEstOverheadCost; }
            set
            {
                if (value != this._pPNormEstOverheadCost)
                {
                    _pPNormEstOverheadCost = value;
                    NotifyChanged("PPNormEstOverheadCost");
                }
            }
        }
        public double PPNormEstCost
        {
            get { return _pPNormEstCost; }
            set
            {
                if (value != this._pPNormEstCost)
                {
                    _pPNormEstCost = value;
                    NotifyChanged("PPNormEstCost");
                }
            }
        }
        public String ApprovalStatusCombo
        {
            get { return _approvalStatusCombo; }
            set
            {
                if (value != this._approvalStatusCombo)
                {
                    _approvalStatusCombo = value;
                    NotifyChanged("ApprovalStatusCombo");
                }
            }
        }
        public String PPNormRevision
        {
            get { return _pPNormRevision; }
            set
            {
                if (value != this._pPNormRevision)
                {
                    _pPNormRevision = value;
                    NotifyChanged("PPNormRevision");
                }
            }
        }
        public int PPNormAllocatePct
        {
            get { return _pPNormAllocatePct; }
            set
            {
                if (value != this._pPNormAllocatePct)
                {
                    _pPNormAllocatePct = value;
                    NotifyChanged("PPNormAllocatePct");
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
        public bool PPNormActiveCheck
        {
            get { return _pPNormActiveCheck; }
            set
            {
                if (value != this._pPNormActiveCheck)
                {
                    _pPNormActiveCheck = value;
                    NotifyChanged("PPNormActiveCheck");
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

        #endregion
    }
    #endregion
}