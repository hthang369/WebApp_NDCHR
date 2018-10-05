using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region APCreditNoteItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:APCreditNoteItemsInfo
    //Created Date:Thursday, August 27, 2015
    //-----------------------------------------------------------

    public class APCreditNoteItemsInfo : BusinessObject
    {
        public APCreditNoteItemsInfo()
        {
        }
        #region Variables
        protected int _aPCreditNoteItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APCreditNoteID;
        protected int _fK_APPInvoiceID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockSlotID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ARPriceListID;
        protected int _fK_TXTaxCodeID;
        protected String _aPCreditNoteItemStatusCombo = DefaultStatus;
        protected String _aPCreditNoteItemTypeCombo = String.Empty;
        protected String _aPCreditNoteItemSerialNo = String.Empty;
        protected bool _aPCreditNoteItemIsStkItm = true;
        protected int _aPCreditNoteItemInvoiceSortOrder;
        protected String _aPCreditNoteItemDesc = String.Empty;
        protected String _aPCreditNoteItemUOM = String.Empty;
        protected String _aPCreditNoteItemStkUOM = String.Empty;
        protected double _aPCreditNoteItemFact;
        protected String _aPSalePriceCombo = String.Empty;
        protected double _aPCreditNoteItemUnitPrice;
        protected double _aPCreditNoteItemUnitCost;
        protected double _aPCreditNoteItemDiscPct;
        protected double _aPCreditNoteItemTxPct;
        protected double _aPCreditNoteItemQty;
        protected double _aPCreditNoteItemStkQty;
        protected double _aPCreditNoteItemRQty;
        protected double _aPCreditNoteItemRStkQty;
        protected double _aPCreditNoteItemPrice;
        protected String _aPCreditNoteItemComment = String.Empty;
        protected double _aPCreditNoteItemUnitVolumn;
        protected double _aPCreditNoteItemUnitWeight;
        protected double _aPCreditNoteItemTxAmt;
        protected double _aPCreditNoteItemDiscAmt;
        protected double _aPCreditNoteItemNetAmt;
        protected double _aPCreditNoteItemAmtTot;
        protected double _aPCreditNoteItemCostTot;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected double _aPCreditNoteItemWTot;
        protected double _aPCreditNoteItemVTot;
        protected String _gLTOF01Combo = String.Empty;
        protected String _gLTOF02Combo = String.Empty;
        protected String _gLTOF03Combo = String.Empty;
        protected String _gLTOF04Combo = String.Empty;
        protected String _gLTOF05Combo = String.Empty;
        protected String _gLTOF06Combo = String.Empty;
        protected String _gLTOF07Combo = String.Empty;
        protected String _gLTOF08Combo = String.Empty;
        protected String _gLTOF09Combo = String.Empty;
        protected String _gLTOF10Combo = String.Empty;
        protected double _aPCreditNoteItemFUnitPrice;
        protected double _aPCreditNoteItemFPrice;
        protected double _aPCreditNoteItemExcQty;
        protected double _aPCreditNoteItemOrgQty;
        protected int _fK_ICOrgUOMID;
        protected double _aPCreditNoteItemFTxAmt;
        protected double _aPCreditNoteItemFAmtTot;
        #endregion

        #region Public properties
        public int APCreditNoteItemID
        {
            get { return _aPCreditNoteItemID; }
            set
            {
                if (value != this._aPCreditNoteItemID)
                {
                    _aPCreditNoteItemID = value;
                    NotifyChanged("APCreditNoteItemID");
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
        public int FK_APCreditNoteID
        {
            get { return _fK_APCreditNoteID; }
            set
            {
                if (value != this._fK_APCreditNoteID)
                {
                    _fK_APCreditNoteID = value;
                    NotifyChanged("FK_APCreditNoteID");
                }
            }
        }
        public int FK_APPInvoiceID
        {
            get { return _fK_APPInvoiceID; }
            set
            {
                if (value != this._fK_APPInvoiceID)
                {
                    _fK_APPInvoiceID = value;
                    NotifyChanged("FK_APPInvoiceID");
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
        public int FK_ICStockSlotID
        {
            get { return _fK_ICStockSlotID; }
            set
            {
                if (value != this._fK_ICStockSlotID)
                {
                    _fK_ICStockSlotID = value;
                    NotifyChanged("FK_ICStockSlotID");
                }
            }
        }
        public int FK_ICProductTypeID
        {
            get { return _fK_ICProductTypeID; }
            set
            {
                if (value != this._fK_ICProductTypeID)
                {
                    _fK_ICProductTypeID = value;
                    NotifyChanged("FK_ICProductTypeID");
                }
            }
        }
        public int FK_ARPriceListID
        {
            get { return _fK_ARPriceListID; }
            set
            {
                if (value != this._fK_ARPriceListID)
                {
                    _fK_ARPriceListID = value;
                    NotifyChanged("FK_ARPriceListID");
                }
            }
        }
        public int FK_TXTaxCodeID
        {
            get { return _fK_TXTaxCodeID; }
            set
            {
                if (value != this._fK_TXTaxCodeID)
                {
                    _fK_TXTaxCodeID = value;
                    NotifyChanged("FK_TXTaxCodeID");
                }
            }
        }
        public String APCreditNoteItemStatusCombo
        {
            get { return _aPCreditNoteItemStatusCombo; }
            set
            {
                if (value != this._aPCreditNoteItemStatusCombo)
                {
                    _aPCreditNoteItemStatusCombo = value;
                    NotifyChanged("APCreditNoteItemStatusCombo");
                }
            }
        }
        public String APCreditNoteItemTypeCombo
        {
            get { return _aPCreditNoteItemTypeCombo; }
            set
            {
                if (value != this._aPCreditNoteItemTypeCombo)
                {
                    _aPCreditNoteItemTypeCombo = value;
                    NotifyChanged("APCreditNoteItemTypeCombo");
                }
            }
        }
        public String APCreditNoteItemSerialNo
        {
            get { return _aPCreditNoteItemSerialNo; }
            set
            {
                if (value != this._aPCreditNoteItemSerialNo)
                {
                    _aPCreditNoteItemSerialNo = value;
                    NotifyChanged("APCreditNoteItemSerialNo");
                }
            }
        }
        public bool APCreditNoteItemIsStkItm
        {
            get { return _aPCreditNoteItemIsStkItm; }
            set
            {
                if (value != this._aPCreditNoteItemIsStkItm)
                {
                    _aPCreditNoteItemIsStkItm = value;
                    NotifyChanged("APCreditNoteItemIsStkItm");
                }
            }
        }
        public int APCreditNoteItemInvoiceSortOrder
        {
            get { return _aPCreditNoteItemInvoiceSortOrder; }
            set
            {
                if (value != this._aPCreditNoteItemInvoiceSortOrder)
                {
                    _aPCreditNoteItemInvoiceSortOrder = value;
                    NotifyChanged("APCreditNoteItemInvoiceSortOrder");
                }
            }
        }
        public String APCreditNoteItemDesc
        {
            get { return _aPCreditNoteItemDesc; }
            set
            {
                if (value != this._aPCreditNoteItemDesc)
                {
                    _aPCreditNoteItemDesc = value;
                    NotifyChanged("APCreditNoteItemDesc");
                }
            }
        }
        public String APCreditNoteItemUOM
        {
            get { return _aPCreditNoteItemUOM; }
            set
            {
                if (value != this._aPCreditNoteItemUOM)
                {
                    _aPCreditNoteItemUOM = value;
                    NotifyChanged("APCreditNoteItemUOM");
                }
            }
        }
        public String APCreditNoteItemStkUOM
        {
            get { return _aPCreditNoteItemStkUOM; }
            set
            {
                if (value != this._aPCreditNoteItemStkUOM)
                {
                    _aPCreditNoteItemStkUOM = value;
                    NotifyChanged("APCreditNoteItemStkUOM");
                }
            }
        }
        public double APCreditNoteItemFact
        {
            get { return _aPCreditNoteItemFact; }
            set
            {
                if (value != this._aPCreditNoteItemFact)
                {
                    _aPCreditNoteItemFact = value;
                    NotifyChanged("APCreditNoteItemFact");
                }
            }
        }
        public String APSalePriceCombo
        {
            get { return _aPSalePriceCombo; }
            set
            {
                if (value != this._aPSalePriceCombo)
                {
                    _aPSalePriceCombo = value;
                    NotifyChanged("APSalePriceCombo");
                }
            }
        }
        public double APCreditNoteItemUnitPrice
        {
            get { return _aPCreditNoteItemUnitPrice; }
            set
            {
                if (value != this._aPCreditNoteItemUnitPrice)
                {
                    _aPCreditNoteItemUnitPrice = value;
                    NotifyChanged("APCreditNoteItemUnitPrice");
                }
            }
        }
        public double APCreditNoteItemUnitCost
        {
            get { return _aPCreditNoteItemUnitCost; }
            set
            {
                if (value != this._aPCreditNoteItemUnitCost)
                {
                    _aPCreditNoteItemUnitCost = value;
                    NotifyChanged("APCreditNoteItemUnitCost");
                }
            }
        }
        public double APCreditNoteItemDiscPct
        {
            get { return _aPCreditNoteItemDiscPct; }
            set
            {
                if (value != this._aPCreditNoteItemDiscPct)
                {
                    _aPCreditNoteItemDiscPct = value;
                    NotifyChanged("APCreditNoteItemDiscPct");
                }
            }
        }
        public double APCreditNoteItemTxPct
        {
            get { return _aPCreditNoteItemTxPct; }
            set
            {
                if (value != this._aPCreditNoteItemTxPct)
                {
                    _aPCreditNoteItemTxPct = value;
                    NotifyChanged("APCreditNoteItemTxPct");
                }
            }
        }
        public double APCreditNoteItemQty
        {
            get { return _aPCreditNoteItemQty; }
            set
            {
                if (value != this._aPCreditNoteItemQty)
                {
                    _aPCreditNoteItemQty = value;
                    NotifyChanged("APCreditNoteItemQty");
                }
            }
        }
        public double APCreditNoteItemStkQty
        {
            get { return _aPCreditNoteItemStkQty; }
            set
            {
                if (value != this._aPCreditNoteItemStkQty)
                {
                    _aPCreditNoteItemStkQty = value;
                    NotifyChanged("APCreditNoteItemStkQty");
                }
            }
        }
        public double APCreditNoteItemRQty
        {
            get { return _aPCreditNoteItemRQty; }
            set
            {
                if (value != this._aPCreditNoteItemRQty)
                {
                    _aPCreditNoteItemRQty = value;
                    NotifyChanged("APCreditNoteItemRQty");
                }
            }
        }
        public double APCreditNoteItemRStkQty
        {
            get { return _aPCreditNoteItemRStkQty; }
            set
            {
                if (value != this._aPCreditNoteItemRStkQty)
                {
                    _aPCreditNoteItemRStkQty = value;
                    NotifyChanged("APCreditNoteItemRStkQty");
                }
            }
        }
        public double APCreditNoteItemPrice
        {
            get { return _aPCreditNoteItemPrice; }
            set
            {
                if (value != this._aPCreditNoteItemPrice)
                {
                    _aPCreditNoteItemPrice = value;
                    NotifyChanged("APCreditNoteItemPrice");
                }
            }
        }
        public String APCreditNoteItemComment
        {
            get { return _aPCreditNoteItemComment; }
            set
            {
                if (value != this._aPCreditNoteItemComment)
                {
                    _aPCreditNoteItemComment = value;
                    NotifyChanged("APCreditNoteItemComment");
                }
            }
        }
        public double APCreditNoteItemUnitVolumn
        {
            get { return _aPCreditNoteItemUnitVolumn; }
            set
            {
                if (value != this._aPCreditNoteItemUnitVolumn)
                {
                    _aPCreditNoteItemUnitVolumn = value;
                    NotifyChanged("APCreditNoteItemUnitVolumn");
                }
            }
        }
        public double APCreditNoteItemUnitWeight
        {
            get { return _aPCreditNoteItemUnitWeight; }
            set
            {
                if (value != this._aPCreditNoteItemUnitWeight)
                {
                    _aPCreditNoteItemUnitWeight = value;
                    NotifyChanged("APCreditNoteItemUnitWeight");
                }
            }
        }
        public double APCreditNoteItemTxAmt
        {
            get { return _aPCreditNoteItemTxAmt; }
            set
            {
                if (value != this._aPCreditNoteItemTxAmt)
                {
                    _aPCreditNoteItemTxAmt = value;
                    NotifyChanged("APCreditNoteItemTxAmt");
                }
            }
        }
        public double APCreditNoteItemDiscAmt
        {
            get { return _aPCreditNoteItemDiscAmt; }
            set
            {
                if (value != this._aPCreditNoteItemDiscAmt)
                {
                    _aPCreditNoteItemDiscAmt = value;
                    NotifyChanged("APCreditNoteItemDiscAmt");
                }
            }
        }
        public double APCreditNoteItemNetAmt
        {
            get { return _aPCreditNoteItemNetAmt; }
            set
            {
                if (value != this._aPCreditNoteItemNetAmt)
                {
                    _aPCreditNoteItemNetAmt = value;
                    NotifyChanged("APCreditNoteItemNetAmt");
                }
            }
        }
        public double APCreditNoteItemAmtTot
        {
            get { return _aPCreditNoteItemAmtTot; }
            set
            {
                if (value != this._aPCreditNoteItemAmtTot)
                {
                    _aPCreditNoteItemAmtTot = value;
                    NotifyChanged("APCreditNoteItemAmtTot");
                }
            }
        }
        public double APCreditNoteItemCostTot
        {
            get { return _aPCreditNoteItemCostTot; }
            set
            {
                if (value != this._aPCreditNoteItemCostTot)
                {
                    _aPCreditNoteItemCostTot = value;
                    NotifyChanged("APCreditNoteItemCostTot");
                }
            }
        }
        public int FK_ICUOMID
        {
            get { return _fK_ICUOMID; }
            set
            {
                if (value != this._fK_ICUOMID)
                {
                    _fK_ICUOMID = value;
                    NotifyChanged("FK_ICUOMID");
                }
            }
        }
        public int FK_ICStkUOMID
        {
            get { return _fK_ICStkUOMID; }
            set
            {
                if (value != this._fK_ICStkUOMID)
                {
                    _fK_ICStkUOMID = value;
                    NotifyChanged("FK_ICStkUOMID");
                }
            }
        }
        public int FK_ICWeightUOMID
        {
            get { return _fK_ICWeightUOMID; }
            set
            {
                if (value != this._fK_ICWeightUOMID)
                {
                    _fK_ICWeightUOMID = value;
                    NotifyChanged("FK_ICWeightUOMID");
                }
            }
        }
        public int FK_ICVolumeUOMID
        {
            get { return _fK_ICVolumeUOMID; }
            set
            {
                if (value != this._fK_ICVolumeUOMID)
                {
                    _fK_ICVolumeUOMID = value;
                    NotifyChanged("FK_ICVolumeUOMID");
                }
            }
        }
        public double APCreditNoteItemWTot
        {
            get { return _aPCreditNoteItemWTot; }
            set
            {
                if (value != this._aPCreditNoteItemWTot)
                {
                    _aPCreditNoteItemWTot = value;
                    NotifyChanged("APCreditNoteItemWTot");
                }
            }
        }
        public double APCreditNoteItemVTot
        {
            get { return _aPCreditNoteItemVTot; }
            set
            {
                if (value != this._aPCreditNoteItemVTot)
                {
                    _aPCreditNoteItemVTot = value;
                    NotifyChanged("APCreditNoteItemVTot");
                }
            }
        }
        public String GLTOF01Combo
        {
            get { return _gLTOF01Combo; }
            set
            {
                if (value != this._gLTOF01Combo)
                {
                    _gLTOF01Combo = value;
                    NotifyChanged("GLTOF01Combo");
                }
            }
        }
        public String GLTOF02Combo
        {
            get { return _gLTOF02Combo; }
            set
            {
                if (value != this._gLTOF02Combo)
                {
                    _gLTOF02Combo = value;
                    NotifyChanged("GLTOF02Combo");
                }
            }
        }
        public String GLTOF03Combo
        {
            get { return _gLTOF03Combo; }
            set
            {
                if (value != this._gLTOF03Combo)
                {
                    _gLTOF03Combo = value;
                    NotifyChanged("GLTOF03Combo");
                }
            }
        }
        public String GLTOF04Combo
        {
            get { return _gLTOF04Combo; }
            set
            {
                if (value != this._gLTOF04Combo)
                {
                    _gLTOF04Combo = value;
                    NotifyChanged("GLTOF04Combo");
                }
            }
        }
        public String GLTOF05Combo
        {
            get { return _gLTOF05Combo; }
            set
            {
                if (value != this._gLTOF05Combo)
                {
                    _gLTOF05Combo = value;
                    NotifyChanged("GLTOF05Combo");
                }
            }
        }
        public String GLTOF06Combo
        {
            get { return _gLTOF06Combo; }
            set
            {
                if (value != this._gLTOF06Combo)
                {
                    _gLTOF06Combo = value;
                    NotifyChanged("GLTOF06Combo");
                }
            }
        }
        public String GLTOF07Combo
        {
            get { return _gLTOF07Combo; }
            set
            {
                if (value != this._gLTOF07Combo)
                {
                    _gLTOF07Combo = value;
                    NotifyChanged("GLTOF07Combo");
                }
            }
        }
        public String GLTOF08Combo
        {
            get { return _gLTOF08Combo; }
            set
            {
                if (value != this._gLTOF08Combo)
                {
                    _gLTOF08Combo = value;
                    NotifyChanged("GLTOF08Combo");
                }
            }
        }
        public String GLTOF09Combo
        {
            get { return _gLTOF09Combo; }
            set
            {
                if (value != this._gLTOF09Combo)
                {
                    _gLTOF09Combo = value;
                    NotifyChanged("GLTOF09Combo");
                }
            }
        }
        public String GLTOF10Combo
        {
            get { return _gLTOF10Combo; }
            set
            {
                if (value != this._gLTOF10Combo)
                {
                    _gLTOF10Combo = value;
                    NotifyChanged("GLTOF10Combo");
                }
            }
        }
        public double APCreditNoteItemFUnitPrice
        {
            get { return _aPCreditNoteItemFUnitPrice; }
            set
            {
                if (value != this._aPCreditNoteItemFUnitPrice)
                {
                    _aPCreditNoteItemFUnitPrice = value;
                    NotifyChanged("APCreditNoteItemFUnitPrice");
                }
            }
        }
        public double APCreditNoteItemFPrice
        {
            get { return _aPCreditNoteItemFPrice; }
            set
            {
                if (value != this._aPCreditNoteItemFPrice)
                {
                    _aPCreditNoteItemFPrice = value;
                    NotifyChanged("APCreditNoteItemFPrice");
                }
            }
        }
        public double APCreditNoteItemExcQty
        {
            get { return _aPCreditNoteItemExcQty; }
            set
            {
                if (value != this._aPCreditNoteItemExcQty)
                {
                    _aPCreditNoteItemExcQty = value;
                    NotifyChanged("APCreditNoteItemExcQty");
                }
            }
        }
        public double APCreditNoteItemOrgQty
        {
            get { return _aPCreditNoteItemOrgQty; }
            set
            {
                if (value != this._aPCreditNoteItemOrgQty)
                {
                    _aPCreditNoteItemOrgQty = value;
                    NotifyChanged("APCreditNoteItemOrgQty");
                }
            }
        }
        public int FK_ICOrgUOMID
        {
            get { return _fK_ICOrgUOMID; }
            set
            {
                if (value != this._fK_ICOrgUOMID)
                {
                    _fK_ICOrgUOMID = value;
                    NotifyChanged("FK_ICOrgUOMID");
                }
            }
        }
        public double APCreditNoteItemFTxAmt
        {
            get { return _aPCreditNoteItemFTxAmt; }
            set
            {
                if (value != this._aPCreditNoteItemFTxAmt)
                {
                    _aPCreditNoteItemFTxAmt = value;
                    NotifyChanged("APCreditNoteItemFTxAmt");
                }
            }
        }
        public double APCreditNoteItemFAmtTot
        {
            get { return _aPCreditNoteItemFAmtTot; }
            set
            {
                if (value != this._aPCreditNoteItemFAmtTot)
                {
                    _aPCreditNoteItemFAmtTot = value;
                    NotifyChanged("APCreditNoteItemFAmtTot");
                }
            }
        }
        #endregion
    }
    #endregion
}