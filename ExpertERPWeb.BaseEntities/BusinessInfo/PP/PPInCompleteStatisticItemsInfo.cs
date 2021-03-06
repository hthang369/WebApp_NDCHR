using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPInCompleteStatisticItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v1.0.8)
    //Class: PPInCompleteStatisticItemsInfo
    //Created Date: Monday, 20 Feb 2017
    //-----------------------------------------------------------

    public class PPInCompleteStatisticItemsInfo : BusinessObject
    {
        public PPInCompleteStatisticItemsInfo()
        {
        }
        #region Variables
        protected int _pPInCompleteStatisticItemID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_PPInCompleteStatisticID;
        protected int _fK_ICProductID;
        protected int _fK_PPCostCenterID;
        protected int _fK_PPPhaseCfgID;
        protected double _pPInCompleteStatisticItemQty;
        protected double _pPInCompleteStatisticItemPct;
        protected double _pPInCompleteStatisticItemNVLPct;
        protected double _pPInCompleteStatisticItemNCPct;
        protected double _pPInCompleteStatisticItemSXCPct;
        protected int _fK_PPCostFactorID;
        protected int _fK_PPProductionOrdrID;
        protected double _pPInCompleteStatisticItemAmt;
        protected int _fK_PPInCompleteStatisticItemParentID;
        protected double _pPInCompleteStatisticItemFAmt;
        protected int _fK_PPRoutingID;
        protected String _pPInCompleteStatisticItemDesc = String.Empty;

        #endregion

        #region Public properties
        public int PPInCompleteStatisticItemID
        {
            get { return _pPInCompleteStatisticItemID; }
            set
            {
                if (value != this._pPInCompleteStatisticItemID)
                {
                    _pPInCompleteStatisticItemID = value;
                    NotifyChanged("PPInCompleteStatisticItemID");
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
        public int FK_PPInCompleteStatisticID
        {
            get { return _fK_PPInCompleteStatisticID; }
            set
            {
                if (value != this._fK_PPInCompleteStatisticID)
                {
                    _fK_PPInCompleteStatisticID = value;
                    NotifyChanged("FK_PPInCompleteStatisticID");
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
        public int FK_PPCostCenterID
        {
            get { return _fK_PPCostCenterID; }
            set
            {
                if (value != this._fK_PPCostCenterID)
                {
                    _fK_PPCostCenterID = value;
                    NotifyChanged("FK_PPCostCenterID");
                }
            }
        }
        public int FK_PPPhaseCfgID
        {
            get { return _fK_PPPhaseCfgID; }
            set
            {
                if (value != this._fK_PPPhaseCfgID)
                {
                    _fK_PPPhaseCfgID = value;
                    NotifyChanged("FK_PPPhaseCfgID");
                }
            }
        }
        public double PPInCompleteStatisticItemQty
        {
            get { return _pPInCompleteStatisticItemQty; }
            set
            {
                if (value != this._pPInCompleteStatisticItemQty)
                {
                    _pPInCompleteStatisticItemQty = value;
                    NotifyChanged("PPInCompleteStatisticItemQty");
                }
            }
        }
        public double PPInCompleteStatisticItemPct
        {
            get { return _pPInCompleteStatisticItemPct; }
            set
            {
                if (value != this._pPInCompleteStatisticItemPct)
                {
                    _pPInCompleteStatisticItemPct = value;
                    NotifyChanged("PPInCompleteStatisticItemPct");
                }
            }
        }
        public double PPInCompleteStatisticItemNVLPct
        {
            get { return _pPInCompleteStatisticItemNVLPct; }
            set
            {
                if (value != this._pPInCompleteStatisticItemNVLPct)
                {
                    _pPInCompleteStatisticItemNVLPct = value;
                    NotifyChanged("PPInCompleteStatisticItemNVLPct");
                }
            }
        }
        public double PPInCompleteStatisticItemNCPct
        {
            get { return _pPInCompleteStatisticItemNCPct; }
            set
            {
                if (value != this._pPInCompleteStatisticItemNCPct)
                {
                    _pPInCompleteStatisticItemNCPct = value;
                    NotifyChanged("PPInCompleteStatisticItemNCPct");
                }
            }
        }
        public double PPInCompleteStatisticItemSXCPct
        {
            get { return _pPInCompleteStatisticItemSXCPct; }
            set
            {
                if (value != this._pPInCompleteStatisticItemSXCPct)
                {
                    _pPInCompleteStatisticItemSXCPct = value;
                    NotifyChanged("PPInCompleteStatisticItemSXCPct");
                }
            }
        }
        public int FK_PPCostFactorID
        {
            get { return _fK_PPCostFactorID; }
            set
            {
                if (value != this._fK_PPCostFactorID)
                {
                    _fK_PPCostFactorID = value;
                    NotifyChanged("FK_PPCostFactorID");
                }
            }
        }
        public int FK_PPProductionOrdrID
        {
            get { return _fK_PPProductionOrdrID; }
            set
            {
                if (value != this._fK_PPProductionOrdrID)
                {
                    _fK_PPProductionOrdrID = value;
                    NotifyChanged("FK_PPProductionOrdrID");
                }
            }
        }
        public double PPInCompleteStatisticItemAmt
        {
            get { return _pPInCompleteStatisticItemAmt; }
            set
            {
                if (value != this._pPInCompleteStatisticItemAmt)
                {
                    _pPInCompleteStatisticItemAmt = value;
                    NotifyChanged("PPInCompleteStatisticItemAmt");
                }
            }
        }
        public int FK_PPInCompleteStatisticItemParentID
        {
            get { return _fK_PPInCompleteStatisticItemParentID; }
            set
            {
                if (value != this._fK_PPInCompleteStatisticItemParentID)
                {
                    _fK_PPInCompleteStatisticItemParentID = value;
                    NotifyChanged("FK_PPInCompleteStatisticItemParentID");
                }
            }
        }
        public double PPInCompleteStatisticItemFAmt
        {
            get { return _pPInCompleteStatisticItemFAmt; }
            set
            {
                if (value != this._pPInCompleteStatisticItemFAmt)
                {
                    _pPInCompleteStatisticItemFAmt = value;
                    NotifyChanged("PPInCompleteStatisticItemFAmt");
                }
            }
        }
        public int FK_PPRoutingID
        {
            get { return _fK_PPRoutingID; }
            set
            {
                if (value != this._fK_PPRoutingID)
                {
                    _fK_PPRoutingID = value;
                    NotifyChanged("FK_PPRoutingID");
                }
            }
        }
        public String PPInCompleteStatisticItemDesc
        {
            get { return _pPInCompleteStatisticItemDesc; }
            set
            {
                if (value != this._pPInCompleteStatisticItemDesc)
                {
                    _pPInCompleteStatisticItemDesc = value;
                    NotifyChanged("PPInCompleteStatisticItemDesc");
                }
            }
        }

        #endregion
    }
    #endregion
}