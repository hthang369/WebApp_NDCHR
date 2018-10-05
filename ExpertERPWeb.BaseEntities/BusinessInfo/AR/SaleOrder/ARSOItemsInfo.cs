
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARSOItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.53)
    //Class: ARSOItemsInfo
    //Created Date: Friday, 27 May 2016
    //-----------------------------------------------------------

    public class ARSOItemsInfo : BusinessObject
    {
        public ARSOItemsInfo()
        {
        }
        #region Variables
        protected int _aRSOItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ARSOID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected int _fK_ICStockSlotID;
        protected int _fK_ICProductTypeID;
        protected int _fK_ARPriceListID;
        protected int _fK_TXTaxCodeID;
        protected String _aRSOItemSerialNo = String.Empty;
        protected bool _aRSOItemIsStkItm = true;
        protected String _aRSOItemType = String.Empty;
        protected int _aRSOItemSortOrder;
        protected String _aRSOItemDesc = String.Empty;
        protected String _aRSOItemUOM = String.Empty;
        protected String _aRSOItemStkUOM = String.Empty;
        protected double _aRSOItemFact;
        protected String _aRSalePriceCombo = String.Empty;
        protected double _aRSOItemUnitPrice;
        protected double _aRSOItemUnitCost;
        protected double _aRSOItemDiscPct;
        protected double _aRSOItemTxPct;
        protected double _aRSOItemQty;
        protected double _aRSOItemStkQty;
        protected double _aRSOItemRQty;
        protected double _aRSOItemRStkQty;
        protected double _aRSOItemPrice;
        protected String _aRSOItemComment = String.Empty;
        protected double _aRSOItemUnitVolumn;
        protected double _aRSOItemUnitWeight;
        protected double _aRSOItemTxAmt;
        protected double _aRSOItemDiscAmt;
        protected double _aRSOItemNetAmt;
        protected double _aRSOItemAmtTot;
        protected double _aRSOItemCostTot;
        protected String _aRSOItemStatus = DefaultStatus;
        protected double _aRSOItemAmt;
        protected double _aRSOItemCAmt;
        protected double _aRSOItemWTot;
        protected double _aRSOItemVTot;
        protected double _aRSOItemShpRQty;
        protected double _aRSOItemShpQty;
        protected String _aRSOItemShpStatus = DefaultStatus;
        protected double _aRSOItemShpPlanRQty;
        protected String _aRSOItemShpPlanStatus = DefaultStatus;
        protected double _aRSOItemRAmt;
        protected double _aRSOItemShpPlanQty;
        protected int _fK_ICProductParentID;
        protected double _aRSOItemFUnitPrice;
        protected double _aRSOItemFPrice;
        protected double _aRSOItemFTxAmt;
        protected double _aRSOItemFNetAmt;
        protected double _aRSOItemFAmtTot;
        protected double _aRSOItemFImpTxAmt;
        protected double _aRSOItemFDiscAmt;
        protected DateTime _aRSOItemShpDate = DateTime.Now;
        protected int _fK_ARCampaignID;
        protected int _fK_ARCampaignItemID;
        protected int _fK_APPOID;
        protected int _fK_APPRID;
        protected double _aRSOItemInvRQty;
        protected String _aRSOItemInvStatus = DefaultStatus;
        protected int _fK_AREstSOItemID;
        protected double _aRSOItemOnProductionQty;
        protected double _aRSOItemOnWOQty;
        protected double _aRSOItemOnFinishQty;
        protected double _aRSOItemPriority;
        protected double _aRSOItemUnitMaterialCBM;
        protected double _aRSOItemMaterialCBM;
        protected double _aRSOItemUnitPkgCBM;
        protected double _aRSOItemPkgCBM;
        protected double _aRSOItemOnPkgOrderQty;
        protected Nullable<DateTime> _aRSOItemDeliveryDate;
        protected int _fK_ACCostSimulationMethodID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected double _aRSOItemOrgQty;
        protected double _aRSOItemExcQty;
        protected int _fK_ICOrgUOMID;
        protected double _aRSOItemCQty;
        protected String _aRSOItemLotNo = String.Empty;
        protected double _aRSOItemContQty;
        protected double _aRSOItemSaleReturnReceiptQty;
        protected double _aRSOItemAdjFUnitPrice01;
        protected double _aRSOItemAdjFUnitPrice02;
        protected double _aRSOItemAdjFUnitPrice03;
        protected double _aRSOItemAdjFUnitPrice04;
        protected double _aRSOItemAdjFUnitPrice05;
        protected double _aRSOItemAdjUnitPrice01;
        protected double _aRSOItemAdjUnitPrice02;
        protected double _aRSOItemAdjUnitPrice03;
        protected double _aRSOItemAdjUnitPrice04;
        protected double _aRSOItemAdjUnitPrice05;
        protected double _aRSOItemOrgFUnitPrice;
        protected double _aRSOItemOrgUnitPrice;

        #endregion

        #region Public properties
        public int ARSOItemID
        {
            get { return _aRSOItemID; }
            set
            {
                if (value != this._aRSOItemID)
                {
                    _aRSOItemID = value;
                    NotifyChanged("ARSOItemID");
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
        public int FK_ARSOID
        {
            get { return _fK_ARSOID; }
            set
            {
                if (value != this._fK_ARSOID)
                {
                    _fK_ARSOID = value;
                    NotifyChanged("FK_ARSOID");
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
        public String ARSOItemSerialNo
        {
            get { return _aRSOItemSerialNo; }
            set
            {
                if (value != this._aRSOItemSerialNo)
                {
                    _aRSOItemSerialNo = value;
                    NotifyChanged("ARSOItemSerialNo");
                }
            }
        }
        public bool ARSOItemIsStkItm
        {
            get { return _aRSOItemIsStkItm; }
            set
            {
                if (value != this._aRSOItemIsStkItm)
                {
                    _aRSOItemIsStkItm = value;
                    NotifyChanged("ARSOItemIsStkItm");
                }
            }
        }
        public String ARSOItemType
        {
            get { return _aRSOItemType; }
            set
            {
                if (value != this._aRSOItemType)
                {
                    _aRSOItemType = value;
                    NotifyChanged("ARSOItemType");
                }
            }
        }
        public int ARSOItemSortOrder
        {
            get { return _aRSOItemSortOrder; }
            set
            {
                if (value != this._aRSOItemSortOrder)
                {
                    _aRSOItemSortOrder = value;
                    NotifyChanged("ARSOItemSortOrder");
                }
            }
        }
        public String ARSOItemDesc
        {
            get { return _aRSOItemDesc; }
            set
            {
                if (value != this._aRSOItemDesc)
                {
                    _aRSOItemDesc = value;
                    NotifyChanged("ARSOItemDesc");
                }
            }
        }
        public String ARSOItemUOM
        {
            get { return _aRSOItemUOM; }
            set
            {
                if (value != this._aRSOItemUOM)
                {
                    _aRSOItemUOM = value;
                    NotifyChanged("ARSOItemUOM");
                }
            }
        }
        public String ARSOItemStkUOM
        {
            get { return _aRSOItemStkUOM; }
            set
            {
                if (value != this._aRSOItemStkUOM)
                {
                    _aRSOItemStkUOM = value;
                    NotifyChanged("ARSOItemStkUOM");
                }
            }
        }
        public double ARSOItemFact
        {
            get { return _aRSOItemFact; }
            set
            {
                if (value != this._aRSOItemFact)
                {
                    _aRSOItemFact = value;
                    NotifyChanged("ARSOItemFact");
                }
            }
        }
        public String ARSalePriceCombo
        {
            get { return _aRSalePriceCombo; }
            set
            {
                if (value != this._aRSalePriceCombo)
                {
                    _aRSalePriceCombo = value;
                    NotifyChanged("ARSalePriceCombo");
                }
            }
        }
        public double ARSOItemUnitPrice
        {
            get { return _aRSOItemUnitPrice; }
            set
            {
                if (value != this._aRSOItemUnitPrice)
                {
                    _aRSOItemUnitPrice = value;
                    NotifyChanged("ARSOItemUnitPrice");
                }
            }
        }
        public double ARSOItemUnitCost
        {
            get { return _aRSOItemUnitCost; }
            set
            {
                if (value != this._aRSOItemUnitCost)
                {
                    _aRSOItemUnitCost = value;
                    NotifyChanged("ARSOItemUnitCost");
                }
            }
        }
        public double ARSOItemDiscPct
        {
            get { return _aRSOItemDiscPct; }
            set
            {
                if (value != this._aRSOItemDiscPct)
                {
                    _aRSOItemDiscPct = value;
                    NotifyChanged("ARSOItemDiscPct");
                }
            }
        }
        public double ARSOItemTxPct
        {
            get { return _aRSOItemTxPct; }
            set
            {
                if (value != this._aRSOItemTxPct)
                {
                    _aRSOItemTxPct = value;
                    NotifyChanged("ARSOItemTxPct");
                }
            }
        }
        public double ARSOItemQty
        {
            get { return _aRSOItemQty; }
            set
            {
                if (value != this._aRSOItemQty)
                {
                    _aRSOItemQty = value;
                    NotifyChanged("ARSOItemQty");
                }
            }
        }
        public double ARSOItemStkQty
        {
            get { return _aRSOItemStkQty; }
            set
            {
                if (value != this._aRSOItemStkQty)
                {
                    _aRSOItemStkQty = value;
                    NotifyChanged("ARSOItemStkQty");
                }
            }
        }
        public double ARSOItemRQty
        {
            get { return _aRSOItemRQty; }
            set
            {
                if (value != this._aRSOItemRQty)
                {
                    _aRSOItemRQty = value;
                    NotifyChanged("ARSOItemRQty");
                }
            }
        }
        public double ARSOItemRStkQty
        {
            get { return _aRSOItemRStkQty; }
            set
            {
                if (value != this._aRSOItemRStkQty)
                {
                    _aRSOItemRStkQty = value;
                    NotifyChanged("ARSOItemRStkQty");
                }
            }
        }
        public double ARSOItemPrice
        {
            get { return _aRSOItemPrice; }
            set
            {
                if (value != this._aRSOItemPrice)
                {
                    _aRSOItemPrice = value;
                    NotifyChanged("ARSOItemPrice");
                }
            }
        }
        public String ARSOItemComment
        {
            get { return _aRSOItemComment; }
            set
            {
                if (value != this._aRSOItemComment)
                {
                    _aRSOItemComment = value;
                    NotifyChanged("ARSOItemComment");
                }
            }
        }
        public double ARSOItemUnitVolumn
        {
            get { return _aRSOItemUnitVolumn; }
            set
            {
                if (value != this._aRSOItemUnitVolumn)
                {
                    _aRSOItemUnitVolumn = value;
                    NotifyChanged("ARSOItemUnitVolumn");
                }
            }
        }
        public double ARSOItemUnitWeight
        {
            get { return _aRSOItemUnitWeight; }
            set
            {
                if (value != this._aRSOItemUnitWeight)
                {
                    _aRSOItemUnitWeight = value;
                    NotifyChanged("ARSOItemUnitWeight");
                }
            }
        }
        public double ARSOItemTxAmt
        {
            get { return _aRSOItemTxAmt; }
            set
            {
                if (value != this._aRSOItemTxAmt)
                {
                    _aRSOItemTxAmt = value;
                    NotifyChanged("ARSOItemTxAmt");
                }
            }
        }
        public double ARSOItemDiscAmt
        {
            get { return _aRSOItemDiscAmt; }
            set
            {
                if (value != this._aRSOItemDiscAmt)
                {
                    _aRSOItemDiscAmt = value;
                    NotifyChanged("ARSOItemDiscAmt");
                }
            }
        }
        public double ARSOItemNetAmt
        {
            get { return _aRSOItemNetAmt; }
            set
            {
                if (value != this._aRSOItemNetAmt)
                {
                    _aRSOItemNetAmt = value;
                    NotifyChanged("ARSOItemNetAmt");
                }
            }
        }
        public double ARSOItemAmtTot
        {
            get { return _aRSOItemAmtTot; }
            set
            {
                if (value != this._aRSOItemAmtTot)
                {
                    _aRSOItemAmtTot = value;
                    NotifyChanged("ARSOItemAmtTot");
                }
            }
        }
        public double ARSOItemCostTot
        {
            get { return _aRSOItemCostTot; }
            set
            {
                if (value != this._aRSOItemCostTot)
                {
                    _aRSOItemCostTot = value;
                    NotifyChanged("ARSOItemCostTot");
                }
            }
        }
        public String ARSOItemStatus
        {
            get { return _aRSOItemStatus; }
            set
            {
                if (value != this._aRSOItemStatus)
                {
                    _aRSOItemStatus = value;
                    NotifyChanged("ARSOItemStatus");
                }
            }
        }
        public double ARSOItemAmt
        {
            get { return _aRSOItemAmt; }
            set
            {
                if (value != this._aRSOItemAmt)
                {
                    _aRSOItemAmt = value;
                    NotifyChanged("ARSOItemAmt");
                }
            }
        }
        public double ARSOItemCAmt
        {
            get { return _aRSOItemCAmt; }
            set
            {
                if (value != this._aRSOItemCAmt)
                {
                    _aRSOItemCAmt = value;
                    NotifyChanged("ARSOItemCAmt");
                }
            }
        }
        public double ARSOItemWTot
        {
            get { return _aRSOItemWTot; }
            set
            {
                if (value != this._aRSOItemWTot)
                {
                    _aRSOItemWTot = value;
                    NotifyChanged("ARSOItemWTot");
                }
            }
        }
        public double ARSOItemVTot
        {
            get { return _aRSOItemVTot; }
            set
            {
                if (value != this._aRSOItemVTot)
                {
                    _aRSOItemVTot = value;
                    NotifyChanged("ARSOItemVTot");
                }
            }
        }
        public double ARSOItemShpRQty
        {
            get { return _aRSOItemShpRQty; }
            set
            {
                if (value != this._aRSOItemShpRQty)
                {
                    _aRSOItemShpRQty = value;
                    NotifyChanged("ARSOItemShpRQty");
                }
            }
        }
        public double ARSOItemShpQty
        {
            get { return _aRSOItemShpQty; }
            set
            {
                if (value != this._aRSOItemShpQty)
                {
                    _aRSOItemShpQty = value;
                    NotifyChanged("ARSOItemShpQty");
                }
            }
        }
        public String ARSOItemShpStatus
        {
            get { return _aRSOItemShpStatus; }
            set
            {
                if (value != this._aRSOItemShpStatus)
                {
                    _aRSOItemShpStatus = value;
                    NotifyChanged("ARSOItemShpStatus");
                }
            }
        }
        public double ARSOItemShpPlanRQty
        {
            get { return _aRSOItemShpPlanRQty; }
            set
            {
                if (value != this._aRSOItemShpPlanRQty)
                {
                    _aRSOItemShpPlanRQty = value;
                    NotifyChanged("ARSOItemShpPlanRQty");
                }
            }
        }
        public String ARSOItemShpPlanStatus
        {
            get { return _aRSOItemShpPlanStatus; }
            set
            {
                if (value != this._aRSOItemShpPlanStatus)
                {
                    _aRSOItemShpPlanStatus = value;
                    NotifyChanged("ARSOItemShpPlanStatus");
                }
            }
        }
        public double ARSOItemRAmt
        {
            get { return _aRSOItemRAmt; }
            set
            {
                if (value != this._aRSOItemRAmt)
                {
                    _aRSOItemRAmt = value;
                    NotifyChanged("ARSOItemRAmt");
                }
            }
        }
        public double ARSOItemShpPlanQty
        {
            get { return _aRSOItemShpPlanQty; }
            set
            {
                if (value != this._aRSOItemShpPlanQty)
                {
                    _aRSOItemShpPlanQty = value;
                    NotifyChanged("ARSOItemShpPlanQty");
                }
            }
        }
        public int FK_ICProductParentID
        {
            get { return _fK_ICProductParentID; }
            set
            {
                if (value != this._fK_ICProductParentID)
                {
                    _fK_ICProductParentID = value;
                    NotifyChanged("FK_ICProductParentID");
                }
            }
        }
        public double ARSOItemFUnitPrice
        {
            get { return _aRSOItemFUnitPrice; }
            set
            {
                if (value != this._aRSOItemFUnitPrice)
                {
                    _aRSOItemFUnitPrice = value;
                    NotifyChanged("ARSOItemFUnitPrice");
                }
            }
        }
        public double ARSOItemFPrice
        {
            get { return _aRSOItemFPrice; }
            set
            {
                if (value != this._aRSOItemFPrice)
                {
                    _aRSOItemFPrice = value;
                    NotifyChanged("ARSOItemFPrice");
                }
            }
        }
        public double ARSOItemFTxAmt
        {
            get { return _aRSOItemFTxAmt; }
            set
            {
                if (value != this._aRSOItemFTxAmt)
                {
                    _aRSOItemFTxAmt = value;
                    NotifyChanged("ARSOItemFTxAmt");
                }
            }
        }
        public double ARSOItemFNetAmt
        {
            get { return _aRSOItemFNetAmt; }
            set
            {
                if (value != this._aRSOItemFNetAmt)
                {
                    _aRSOItemFNetAmt = value;
                    NotifyChanged("ARSOItemFNetAmt");
                }
            }
        }
        public double ARSOItemFAmtTot
        {
            get { return _aRSOItemFAmtTot; }
            set
            {
                if (value != this._aRSOItemFAmtTot)
                {
                    _aRSOItemFAmtTot = value;
                    NotifyChanged("ARSOItemFAmtTot");
                }
            }
        }
        public double ARSOItemFImpTxAmt
        {
            get { return _aRSOItemFImpTxAmt; }
            set
            {
                if (value != this._aRSOItemFImpTxAmt)
                {
                    _aRSOItemFImpTxAmt = value;
                    NotifyChanged("ARSOItemFImpTxAmt");
                }
            }
        }
        public double ARSOItemFDiscAmt
        {
            get { return _aRSOItemFDiscAmt; }
            set
            {
                if (value != this._aRSOItemFDiscAmt)
                {
                    _aRSOItemFDiscAmt = value;
                    NotifyChanged("ARSOItemFDiscAmt");
                }
            }
        }
        public DateTime ARSOItemShpDate
        {
            get { return _aRSOItemShpDate; }
            set
            {
                if (value != this._aRSOItemShpDate)
                {
                    _aRSOItemShpDate = value;
                    NotifyChanged("ARSOItemShpDate");
                }
            }
        }
        public int FK_ARCampaignID
        {
            get { return _fK_ARCampaignID; }
            set
            {
                if (value != this._fK_ARCampaignID)
                {
                    _fK_ARCampaignID = value;
                    NotifyChanged("FK_ARCampaignID");
                }
            }
        }
        public int FK_ARCampaignItemID
        {
            get { return _fK_ARCampaignItemID; }
            set
            {
                if (value != this._fK_ARCampaignItemID)
                {
                    _fK_ARCampaignItemID = value;
                    NotifyChanged("FK_ARCampaignItemID");
                }
            }
        }
        public int FK_APPOID
        {
            get { return _fK_APPOID; }
            set
            {
                if (value != this._fK_APPOID)
                {
                    _fK_APPOID = value;
                    NotifyChanged("FK_APPOID");
                }
            }
        }
        public int FK_APPRID
        {
            get { return _fK_APPRID; }
            set
            {
                if (value != this._fK_APPRID)
                {
                    _fK_APPRID = value;
                    NotifyChanged("FK_APPRID");
                }
            }
        }
        public double ARSOItemInvRQty
        {
            get { return _aRSOItemInvRQty; }
            set
            {
                if (value != this._aRSOItemInvRQty)
                {
                    _aRSOItemInvRQty = value;
                    NotifyChanged("ARSOItemInvRQty");
                }
            }
        }
        public String ARSOItemInvStatus
        {
            get { return _aRSOItemInvStatus; }
            set
            {
                if (value != this._aRSOItemInvStatus)
                {
                    _aRSOItemInvStatus = value;
                    NotifyChanged("ARSOItemInvStatus");
                }
            }
        }
        public int FK_AREstSOItemID
        {
            get { return _fK_AREstSOItemID; }
            set
            {
                if (value != this._fK_AREstSOItemID)
                {
                    _fK_AREstSOItemID = value;
                    NotifyChanged("FK_AREstSOItemID");
                }
            }
        }
        public double ARSOItemOnProductionQty
        {
            get { return _aRSOItemOnProductionQty; }
            set
            {
                if (value != this._aRSOItemOnProductionQty)
                {
                    _aRSOItemOnProductionQty = value;
                    NotifyChanged("ARSOItemOnProductionQty");
                }
            }
        }
        public double ARSOItemOnWOQty
        {
            get { return _aRSOItemOnWOQty; }
            set
            {
                if (value != this._aRSOItemOnWOQty)
                {
                    _aRSOItemOnWOQty = value;
                    NotifyChanged("ARSOItemOnWOQty");
                }
            }
        }
        public double ARSOItemOnFinishQty
        {
            get { return _aRSOItemOnFinishQty; }
            set
            {
                if (value != this._aRSOItemOnFinishQty)
                {
                    _aRSOItemOnFinishQty = value;
                    NotifyChanged("ARSOItemOnFinishQty");
                }
            }
        }
        public double ARSOItemPriority
        {
            get { return _aRSOItemPriority; }
            set
            {
                if (value != this._aRSOItemPriority)
                {
                    _aRSOItemPriority = value;
                    NotifyChanged("ARSOItemPriority");
                }
            }
        }
        public double ARSOItemUnitMaterialCBM
        {
            get { return _aRSOItemUnitMaterialCBM; }
            set
            {
                if (value != this._aRSOItemUnitMaterialCBM)
                {
                    _aRSOItemUnitMaterialCBM = value;
                    NotifyChanged("ARSOItemUnitMaterialCBM");
                }
            }
        }
        public double ARSOItemMaterialCBM
        {
            get { return _aRSOItemMaterialCBM; }
            set
            {
                if (value != this._aRSOItemMaterialCBM)
                {
                    _aRSOItemMaterialCBM = value;
                    NotifyChanged("ARSOItemMaterialCBM");
                }
            }
        }
        public double ARSOItemUnitPkgCBM
        {
            get { return _aRSOItemUnitPkgCBM; }
            set
            {
                if (value != this._aRSOItemUnitPkgCBM)
                {
                    _aRSOItemUnitPkgCBM = value;
                    NotifyChanged("ARSOItemUnitPkgCBM");
                }
            }
        }
        public double ARSOItemPkgCBM
        {
            get { return _aRSOItemPkgCBM; }
            set
            {
                if (value != this._aRSOItemPkgCBM)
                {
                    _aRSOItemPkgCBM = value;
                    NotifyChanged("ARSOItemPkgCBM");
                }
            }
        }
        public double ARSOItemOnPkgOrderQty
        {
            get { return _aRSOItemOnPkgOrderQty; }
            set
            {
                if (value != this._aRSOItemOnPkgOrderQty)
                {
                    _aRSOItemOnPkgOrderQty = value;
                    NotifyChanged("ARSOItemOnPkgOrderQty");
                }
            }
        }
        public Nullable<DateTime> ARSOItemDeliveryDate
        {
            get { return _aRSOItemDeliveryDate; }
            set
            {
                if (value != this._aRSOItemDeliveryDate)
                {
                    _aRSOItemDeliveryDate = value;
                    NotifyChanged("ARSOItemDeliveryDate");
                }
            }
        }
        public int FK_ACCostSimulationMethodID
        {
            get { return _fK_ACCostSimulationMethodID; }
            set
            {
                if (value != this._fK_ACCostSimulationMethodID)
                {
                    _fK_ACCostSimulationMethodID = value;
                    NotifyChanged("FK_ACCostSimulationMethodID");
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
        public double ARSOItemOrgQty
        {
            get { return _aRSOItemOrgQty; }
            set
            {
                if (value != this._aRSOItemOrgQty)
                {
                    _aRSOItemOrgQty = value;
                    NotifyChanged("ARSOItemOrgQty");
                }
            }
        }
        public double ARSOItemExcQty
        {
            get { return _aRSOItemExcQty; }
            set
            {
                if (value != this._aRSOItemExcQty)
                {
                    _aRSOItemExcQty = value;
                    NotifyChanged("ARSOItemExcQty");
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
        public double ARSOItemCQty
        {
            get { return _aRSOItemCQty; }
            set
            {
                if (value != this._aRSOItemCQty)
                {
                    _aRSOItemCQty = value;
                    NotifyChanged("ARSOItemCQty");
                }
            }
        }
        public String ARSOItemLotNo
        {
            get { return _aRSOItemLotNo; }
            set
            {
                if (value != this._aRSOItemLotNo)
                {
                    _aRSOItemLotNo = value;
                    NotifyChanged("ARSOItemLotNo");
                }
            }
        }
        public double ARSOItemContQty
        {
            get { return _aRSOItemContQty; }
            set
            {
                if (value != this._aRSOItemContQty)
                {
                    _aRSOItemContQty = value;
                    NotifyChanged("ARSOItemContQty");
                }
            }
        }
        public double ARSOItemSaleReturnReceiptQty
        {
            get { return _aRSOItemSaleReturnReceiptQty; }
            set
            {
                if (value != this._aRSOItemSaleReturnReceiptQty)
                {
                    _aRSOItemSaleReturnReceiptQty = value;
                    NotifyChanged("ARSOItemSaleReturnReceiptQty");
                }
            }
        }
        public double ARSOItemAdjFUnitPrice01
        {
            get { return _aRSOItemAdjFUnitPrice01; }
            set
            {
                if (value != this._aRSOItemAdjFUnitPrice01)
                {
                    _aRSOItemAdjFUnitPrice01 = value;
                    NotifyChanged("ARSOItemAdjFUnitPrice01");
                }
            }
        }
        public double ARSOItemAdjFUnitPrice02
        {
            get { return _aRSOItemAdjFUnitPrice02; }
            set
            {
                if (value != this._aRSOItemAdjFUnitPrice02)
                {
                    _aRSOItemAdjFUnitPrice02 = value;
                    NotifyChanged("ARSOItemAdjFUnitPrice02");
                }
            }
        }
        public double ARSOItemAdjFUnitPrice03
        {
            get { return _aRSOItemAdjFUnitPrice03; }
            set
            {
                if (value != this._aRSOItemAdjFUnitPrice03)
                {
                    _aRSOItemAdjFUnitPrice03 = value;
                    NotifyChanged("ARSOItemAdjFUnitPrice03");
                }
            }
        }
        public double ARSOItemAdjFUnitPrice04
        {
            get { return _aRSOItemAdjFUnitPrice04; }
            set
            {
                if (value != this._aRSOItemAdjFUnitPrice04)
                {
                    _aRSOItemAdjFUnitPrice04 = value;
                    NotifyChanged("ARSOItemAdjFUnitPrice04");
                }
            }
        }
        public double ARSOItemAdjFUnitPrice05
        {
            get { return _aRSOItemAdjFUnitPrice05; }
            set
            {
                if (value != this._aRSOItemAdjFUnitPrice05)
                {
                    _aRSOItemAdjFUnitPrice05 = value;
                    NotifyChanged("ARSOItemAdjFUnitPrice05");
                }
            }
        }
        public double ARSOItemAdjUnitPrice01
        {
            get { return _aRSOItemAdjUnitPrice01; }
            set
            {
                if (value != this._aRSOItemAdjUnitPrice01)
                {
                    _aRSOItemAdjUnitPrice01 = value;
                    NotifyChanged("ARSOItemAdjUnitPrice01");
                }
            }
        }
        public double ARSOItemAdjUnitPrice02
        {
            get { return _aRSOItemAdjUnitPrice02; }
            set
            {
                if (value != this._aRSOItemAdjUnitPrice02)
                {
                    _aRSOItemAdjUnitPrice02 = value;
                    NotifyChanged("ARSOItemAdjUnitPrice02");
                }
            }
        }
        public double ARSOItemAdjUnitPrice03
        {
            get { return _aRSOItemAdjUnitPrice03; }
            set
            {
                if (value != this._aRSOItemAdjUnitPrice03)
                {
                    _aRSOItemAdjUnitPrice03 = value;
                    NotifyChanged("ARSOItemAdjUnitPrice03");
                }
            }
        }
        public double ARSOItemAdjUnitPrice04
        {
            get { return _aRSOItemAdjUnitPrice04; }
            set
            {
                if (value != this._aRSOItemAdjUnitPrice04)
                {
                    _aRSOItemAdjUnitPrice04 = value;
                    NotifyChanged("ARSOItemAdjUnitPrice04");
                }
            }
        }
        public double ARSOItemAdjUnitPrice05
        {
            get { return _aRSOItemAdjUnitPrice05; }
            set
            {
                if (value != this._aRSOItemAdjUnitPrice05)
                {
                    _aRSOItemAdjUnitPrice05 = value;
                    NotifyChanged("ARSOItemAdjUnitPrice05");
                }
            }
        }
        public double ARSOItemOrgFUnitPrice
        {
            get { return _aRSOItemOrgFUnitPrice; }
            set
            {
                if (value != this._aRSOItemOrgFUnitPrice)
                {
                    _aRSOItemOrgFUnitPrice = value;
                    NotifyChanged("ARSOItemOrgFUnitPrice");
                }
            }
        }
        public double ARSOItemOrgUnitPrice
        {
            get { return _aRSOItemOrgUnitPrice; }
            set
            {
                if (value != this._aRSOItemOrgUnitPrice)
                {
                    _aRSOItemOrgUnitPrice = value;
                    NotifyChanged("ARSOItemOrgUnitPrice");
                }
            }
        }

        #endregion
    }
    #endregion
}