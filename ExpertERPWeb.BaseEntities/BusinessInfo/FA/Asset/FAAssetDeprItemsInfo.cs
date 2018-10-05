using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region FAAssetDeprItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:FAAssetDeprItemsInfo
    //Created Date:20 July 2015
    //-----------------------------------------------------------

    public class FAAssetDeprItemsInfo : BusinessObject
    {
        public FAAssetDeprItemsInfo()
        {
        }
        #region Variables
        protected int _fAAssetDeprItemID;
        protected int _fK_FAAssetDeprID;
        protected int _fK_FAAssetID;
        protected int _fK_HRDepartmentID;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        protected double _fAAssetCostAmt;
        protected double _fAAssetDeprAmt;
        protected double _fAAssetAccumDeprAmt;
        protected double _fAAssetNetBookAmt;
        protected double _fAAssetDeprItemAmt;
        protected String _fAAssetDeprItemDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _fAAssetDeprItemStatusCombo = DefaultStatus;
        protected bool _fAAssetDeprItemCanAdjust = true;
        protected String _fAAssetDeprItemTypeCombo = String.Empty;
        protected double _fAAssetCurrentNetBookAmt;
        protected double _fAAssetCurrentAccumDeprAmt;
        protected int _fK_GLCostCenterID;
        protected int _fK_LOCarID;
        protected int _fAAssetDeprPeriod;
        protected int _fAAssetDeprYear;
        protected int _fK_GLCostDistID;
        protected double _fAAssetDeprItemFAmt;
        protected double _fAAssetDeprItemExcRate;
        protected int _fK_GECurrencyID;
        #endregion

        #region Public properties
        public int FAAssetDeprItemID
        {
            get { return _fAAssetDeprItemID; }
            set
            {
                if (value != this._fAAssetDeprItemID)
                {
                    _fAAssetDeprItemID = value;
                    NotifyChanged("FAAssetDeprItemID");
                }
            }
        }
        public int FK_FAAssetDeprID
        {
            get { return _fK_FAAssetDeprID; }
            set
            {
                if (value != this._fK_FAAssetDeprID)
                {
                    _fK_FAAssetDeprID = value;
                    NotifyChanged("FK_FAAssetDeprID");
                }
            }
        }
        public int FK_FAAssetID
        {
            get { return _fK_FAAssetID; }
            set
            {
                if (value != this._fK_FAAssetID)
                {
                    _fK_FAAssetID = value;
                    NotifyChanged("FK_FAAssetID");
                }
            }
        }
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public int FK_GLDebitAccountID
        {
            get { return _fK_GLDebitAccountID; }
            set
            {
                if (value != this._fK_GLDebitAccountID)
                {
                    _fK_GLDebitAccountID = value;
                    NotifyChanged("FK_GLDebitAccountID");
                }
            }
        }
        public int FK_GLCreditAccountID
        {
            get { return _fK_GLCreditAccountID; }
            set
            {
                if (value != this._fK_GLCreditAccountID)
                {
                    _fK_GLCreditAccountID = value;
                    NotifyChanged("FK_GLCreditAccountID");
                }
            }
        }
        public double FAAssetCostAmt
        {
            get { return _fAAssetCostAmt; }
            set
            {
                if (value != this._fAAssetCostAmt)
                {
                    _fAAssetCostAmt = value;
                    NotifyChanged("FAAssetCostAmt");
                }
            }
        }
        public double FAAssetDeprAmt
        {
            get { return _fAAssetDeprAmt; }
            set
            {
                if (value != this._fAAssetDeprAmt)
                {
                    _fAAssetDeprAmt = value;
                    NotifyChanged("FAAssetDeprAmt");
                }
            }
        }
        public double FAAssetAccumDeprAmt
        {
            get { return _fAAssetAccumDeprAmt; }
            set
            {
                if (value != this._fAAssetAccumDeprAmt)
                {
                    _fAAssetAccumDeprAmt = value;
                    NotifyChanged("FAAssetAccumDeprAmt");
                }
            }
        }
        public double FAAssetNetBookAmt
        {
            get { return _fAAssetNetBookAmt; }
            set
            {
                if (value != this._fAAssetNetBookAmt)
                {
                    _fAAssetNetBookAmt = value;
                    NotifyChanged("FAAssetNetBookAmt");
                }
            }
        }
        public double FAAssetDeprItemAmt
        {
            get { return _fAAssetDeprItemAmt; }
            set
            {
                if (value != this._fAAssetDeprItemAmt)
                {
                    _fAAssetDeprItemAmt = value;
                    NotifyChanged("FAAssetDeprItemAmt");
                }
            }
        }
        public String FAAssetDeprItemDesc
        {
            get { return _fAAssetDeprItemDesc; }
            set
            {
                if (value != this._fAAssetDeprItemDesc)
                {
                    _fAAssetDeprItemDesc = value;
                    NotifyChanged("FAAssetDeprItemDesc");
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
        public String FAAssetDeprItemStatusCombo
        {
            get { return _fAAssetDeprItemStatusCombo; }
            set
            {
                if (value != this._fAAssetDeprItemStatusCombo)
                {
                    _fAAssetDeprItemStatusCombo = value;
                    NotifyChanged("FAAssetDeprItemStatusCombo");
                }
            }
        }
        public bool FAAssetDeprItemCanAdjust
        {
            get { return _fAAssetDeprItemCanAdjust; }
            set
            {
                if (value != this._fAAssetDeprItemCanAdjust)
                {
                    _fAAssetDeprItemCanAdjust = value;
                    NotifyChanged("FAAssetDeprItemCanAdjust");
                }
            }
        }
        public String FAAssetDeprItemTypeCombo
        {
            get { return _fAAssetDeprItemTypeCombo; }
            set
            {
                if (value != this._fAAssetDeprItemTypeCombo)
                {
                    _fAAssetDeprItemTypeCombo = value;
                    NotifyChanged("FAAssetDeprItemTypeCombo");
                }
            }
        }
        public double FAAssetCurrentNetBookAmt
        {
            get { return _fAAssetCurrentNetBookAmt; }
            set
            {
                if (value != this._fAAssetCurrentNetBookAmt)
                {
                    _fAAssetCurrentNetBookAmt = value;
                    NotifyChanged("FAAssetCurrentNetBookAmt");
                }
            }
        }
        public double FAAssetCurrentAccumDeprAmt
        {
            get { return _fAAssetCurrentAccumDeprAmt; }
            set
            {
                if (value != this._fAAssetCurrentAccumDeprAmt)
                {
                    _fAAssetCurrentAccumDeprAmt = value;
                    NotifyChanged("FAAssetCurrentAccumDeprAmt");
                }
            }
        }
        public int FK_GLCostCenterID
        {
            get { return _fK_GLCostCenterID; }
            set
            {
                if (value != this._fK_GLCostCenterID)
                {
                    _fK_GLCostCenterID = value;
                    NotifyChanged("FK_GLCostCenterID");
                }
            }
        }
        public int FK_LOCarID
        {
            get { return _fK_LOCarID; }
            set
            {
                if (value != this._fK_LOCarID)
                {
                    _fK_LOCarID = value;
                    NotifyChanged("FK_LOCarID");
                }
            }
        }
        public int FAAssetDeprPeriod
        {
            get { return _fAAssetDeprPeriod; }
            set
            {
                if (value != this._fAAssetDeprPeriod)
                {
                    _fAAssetDeprPeriod = value;
                    NotifyChanged("FAAssetDeprPeriod");
                }
            }
        }
        public int FAAssetDeprYear
        {
            get { return _fAAssetDeprYear; }
            set
            {
                if (value != this._fAAssetDeprYear)
                {
                    _fAAssetDeprYear = value;
                    NotifyChanged("FAAssetDeprYear");
                }
            }
        }
        public int FK_GLCostDistID
        {
            get { return _fK_GLCostDistID; }
            set
            {
                if (value != this._fK_GLCostDistID)
                {
                    _fK_GLCostDistID = value;
                    NotifyChanged("FK_GLCostDistID");
                }
            }
        }
        public double FAAssetDeprItemFAmt
        {
            get { return _fAAssetDeprItemFAmt; }
            set
            {
                if (value != this._fAAssetDeprItemFAmt)
                {
                    _fAAssetDeprItemFAmt = value;
                    NotifyChanged("FAAssetDeprItemFAmt");
                }
            }
        }
        public double FAAssetDeprItemExcRate
        {
            get { return _fAAssetDeprItemExcRate; }
            set
            {
                if (value != this._fAAssetDeprItemExcRate)
                {
                    _fAAssetDeprItemExcRate = value;
                    NotifyChanged("FAAssetDeprItemExcRate");
                }
            }
        }
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        #endregion
    }
    #endregion
}