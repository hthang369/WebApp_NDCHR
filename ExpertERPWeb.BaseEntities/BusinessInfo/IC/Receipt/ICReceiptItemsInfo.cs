 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICReceiptItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.2)
    //Class: ICReceiptItemsInfo
    //Created Date: Thursday, 01 Jun 2017
    //-----------------------------------------------------------

    public class ICReceiptItemsInfo : BusinessObject
    {
        public ICReceiptItemsInfo()
        {
        }
        #region Variables
		protected int _iCReceiptItemID;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected int _fK_ICReceiptID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ARPriceListID;
		protected int _fK_TXTaxCodeID;
		protected String _iCReceiptItemSerialNo = String.Empty;
		protected String _iCReceiptItemType = String.Empty;
		protected bool _iCReceiptItemIsStkItm = true;
		protected String _iCReceiptItemDesc = String.Empty;
		protected String _iCReceiptItemUOM = String.Empty;
		protected String _iCReceiptItemStkUOM = String.Empty;
		protected double _iCReceiptItemFact;
		protected String _aRSalePriceCombo = String.Empty;
		protected double _iCReceiptItemUnitPrice;
		protected double _iCReceiptItemUnitCost;
		protected double _iCReceiptItemDiscPct;
		protected double _iCReceiptItemTxPct;
		protected double _iCReceiptItemVolume;
		protected double _iCReceiptItemQty;
		protected double _iCReceiptItemStkQty;
		protected double _iCReceiptItemRQty;
		protected double _iCReceiptItemRStkQty;
		protected double _iCReceiptItemPrice;
		protected String _iCReceiptItemComment = String.Empty;
		protected double _iCReceiptItemUnitVol;
		protected double _iCReceiptItemUnitWeight;
		protected double _iCReceiptItemTxAmt;
		protected double _iCReceiptItemDiscAmt;
		protected double _iCReceiptItemNetAmt;
		protected double _iCReceiptItemAmtTot;
		protected double _iCReceiptItemDirectCostTot;
		protected double _iCReceiptItemInDirectCostTot;
		protected double _iCReceiptItemInDirectAllocateCostTot;
		protected double _iCReceiptItemCostTot;
		protected String _iCReceiptItemStatus = DefaultStatus;
		protected double _iCReceiptItemAmt;
		protected double _iCReceiptItemCAmt;
		protected double _iCReceiptItemShpAmt;
		protected double _iCReceiptItemMiscChargeAmt;
		protected double _iCReceiptItemImpTxAmt;
		protected int _fK_TXImpTaxCodeID;
		protected int _fK_PPPhaseCfgID;
		protected int _fK_ICProductIDWO;
		protected Nullable<DateTime> _iCReceiptItemExpiredDate;
		protected Nullable<DateTime> _iCReceiptItemDate;
		protected double _iCReceiptItemShpQty;
		protected double _iCReceiptItemShpRQty;
		protected int _fK_ICProductParentID;
		protected double _iCReceiptItemFUnitPrice;
		protected double _iCReceiptItemFPrice;
		protected double _iCReceiptItemFTxAmt;
		protected double _iCReceiptItemFNetAmt;
		protected double _iCReceiptItemFAmtTot;
		protected double _iCReceiptItemFImpTxAmt;
		protected Nullable<DateTime> _iCReceiptItemExpireDate;
		protected int _fK_GLDebitAccountID;
		protected int _fK_GLCreditAccountID;
		protected int _fK_GLDebitVATAccountID;
		protected int _fK_GLCreditVATAccountID;
		protected String _iCReceiptItemPurchaseReturnStatusCombo = DefaultStatus;
		protected double _iCReceiptItemPurchaseReturnRQty;
		protected String _iCReceiptItemLotNo = String.Empty;
		protected double _iCReceiptItemFreightAmt;
		protected double _iCReceiptItemSealedBankQty;
		protected double _iCReceiptItemSealedBankRQty;
		protected int _fK_ARLendContractID;
		protected int _fK_ICStockUOMID;
		protected double _iCReceiptItemAllocateQty;
		protected double _iCReceiptItemPOQty;
		protected double _iCReceiptItemPOReceiptQty;
		protected double _iCReceiptItemPORQty;
		protected String _iCPackageLockTypeCombo = String.Empty;
		protected bool _iCReceiptItemIsCostingItemCheck = true;
		protected int _fK_PPProductionOrdrID;
		protected double _iCReceiptItemHeight;
		protected double _iCReceiptItemWidth;
		protected double _iCReceiptItemLength;
		protected String _iCReceiptItemProductionTypeCombo = String.Empty;
		protected int _fK_GLCostDistID;
		protected int _fK_GLTranCfgID;
		protected int _fK_PPWOID;
		protected double _iCReceiptItemOverheadCost;
		protected double _iCReceiptItemLaborCost;
		protected double _iCReceiptItemBeginCostAmt;
		protected double _iCReceiptItemIndirectRMCost;
		protected int _fK_PPRoutingID;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _iCReceiptItemWTot;
		protected double _iCReceiptItemVTot;
		protected double _iCReceiptItemOrgQty;
		protected double _iCReceiptItemExcQty;
		protected int _fK_ICOrgUOMID;
		protected double _iCReceiptItemCQty;
		protected int _fK_PPCostCenterID;
		protected int _fK_ICAssemblyID;
		protected int _fK_ICKitID;
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
		protected String _iCReceiptItemProductNo = String.Empty;
		protected String _iCReceiptItemProductName = String.Empty;
		protected double _iCReceiptItemImportCostAmt;
		protected double _iCReceiptItemFImportCostAmt;
		protected int _fK_ICShipmentItemID;
		protected int _fK_PPNormID;
		protected int _fK_ARSOItemID;
		protected int _fK_ARInvoiceItemID;
		protected int _iCReceiptItemLine;
		protected double _iCReceiptItemFCostTot;
		protected int _fK_ARShpPlanItemID;
		protected int _fK_ARSOID;
		protected double _iCReceiptItemFreightFAmt;
		protected String _iCReceiptItemFGLotNo = String.Empty;
		
        #endregion

        #region Public properties
		public int ICReceiptItemID
		{
			get { return _iCReceiptItemID; }
			set
			{
				if (value != this._iCReceiptItemID)
				{
					_iCReceiptItemID = value;
					NotifyChanged("ICReceiptItemID");
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
		public int FK_ICReceiptID
		{
			get { return _fK_ICReceiptID; }
			set
			{
				if (value != this._fK_ICReceiptID)
				{
					_fK_ICReceiptID = value;
					NotifyChanged("FK_ICReceiptID");
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
		public String ICReceiptItemSerialNo
		{
			get { return _iCReceiptItemSerialNo; }
			set
			{
				if (value != this._iCReceiptItemSerialNo)
				{
					_iCReceiptItemSerialNo = value;
					NotifyChanged("ICReceiptItemSerialNo");
				}
			}
		}
		public String ICReceiptItemType
		{
			get { return _iCReceiptItemType; }
			set
			{
				if (value != this._iCReceiptItemType)
				{
					_iCReceiptItemType = value;
					NotifyChanged("ICReceiptItemType");
				}
			}
		}
		public bool ICReceiptItemIsStkItm
		{
			get { return _iCReceiptItemIsStkItm; }
			set
			{
				if (value != this._iCReceiptItemIsStkItm)
				{
					_iCReceiptItemIsStkItm = value;
					NotifyChanged("ICReceiptItemIsStkItm");
				}
			}
		}
		public String ICReceiptItemDesc
		{
			get { return _iCReceiptItemDesc; }
			set
			{
				if (value != this._iCReceiptItemDesc)
				{
					_iCReceiptItemDesc = value;
					NotifyChanged("ICReceiptItemDesc");
				}
			}
		}
		public String ICReceiptItemUOM
		{
			get { return _iCReceiptItemUOM; }
			set
			{
				if (value != this._iCReceiptItemUOM)
				{
					_iCReceiptItemUOM = value;
					NotifyChanged("ICReceiptItemUOM");
				}
			}
		}
		public String ICReceiptItemStkUOM
		{
			get { return _iCReceiptItemStkUOM; }
			set
			{
				if (value != this._iCReceiptItemStkUOM)
				{
					_iCReceiptItemStkUOM = value;
					NotifyChanged("ICReceiptItemStkUOM");
				}
			}
		}
		public double ICReceiptItemFact
		{
			get { return _iCReceiptItemFact; }
			set
			{
				if (value != this._iCReceiptItemFact)
				{
					_iCReceiptItemFact = value;
					NotifyChanged("ICReceiptItemFact");
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
		public double ICReceiptItemUnitPrice
		{
			get { return _iCReceiptItemUnitPrice; }
			set
			{
				if (value != this._iCReceiptItemUnitPrice)
				{
					_iCReceiptItemUnitPrice = value;
					NotifyChanged("ICReceiptItemUnitPrice");
				}
			}
		}
		public double ICReceiptItemUnitCost
		{
			get { return _iCReceiptItemUnitCost; }
			set
			{
				if (value != this._iCReceiptItemUnitCost)
				{
					_iCReceiptItemUnitCost = value;
					NotifyChanged("ICReceiptItemUnitCost");
				}
			}
		}
		public double ICReceiptItemDiscPct
		{
			get { return _iCReceiptItemDiscPct; }
			set
			{
				if (value != this._iCReceiptItemDiscPct)
				{
					_iCReceiptItemDiscPct = value;
					NotifyChanged("ICReceiptItemDiscPct");
				}
			}
		}
		public double ICReceiptItemTxPct
		{
			get { return _iCReceiptItemTxPct; }
			set
			{
				if (value != this._iCReceiptItemTxPct)
				{
					_iCReceiptItemTxPct = value;
					NotifyChanged("ICReceiptItemTxPct");
				}
			}
		}
		public double ICReceiptItemVolume
		{
			get { return _iCReceiptItemVolume; }
			set
			{
				if (value != this._iCReceiptItemVolume)
				{
					_iCReceiptItemVolume = value;
					NotifyChanged("ICReceiptItemVolume");
				}
			}
		}
		public double ICReceiptItemQty
		{
			get { return _iCReceiptItemQty; }
			set
			{
				if (value != this._iCReceiptItemQty)
				{
					_iCReceiptItemQty = value;
					NotifyChanged("ICReceiptItemQty");
				}
			}
		}
		public double ICReceiptItemStkQty
		{
			get { return _iCReceiptItemStkQty; }
			set
			{
				if (value != this._iCReceiptItemStkQty)
				{
					_iCReceiptItemStkQty = value;
					NotifyChanged("ICReceiptItemStkQty");
				}
			}
		}
		public double ICReceiptItemRQty
		{
			get { return _iCReceiptItemRQty; }
			set
			{
				if (value != this._iCReceiptItemRQty)
				{
					_iCReceiptItemRQty = value;
					NotifyChanged("ICReceiptItemRQty");
				}
			}
		}
		public double ICReceiptItemRStkQty
		{
			get { return _iCReceiptItemRStkQty; }
			set
			{
				if (value != this._iCReceiptItemRStkQty)
				{
					_iCReceiptItemRStkQty = value;
					NotifyChanged("ICReceiptItemRStkQty");
				}
			}
		}
		public double ICReceiptItemPrice
		{
			get { return _iCReceiptItemPrice; }
			set
			{
				if (value != this._iCReceiptItemPrice)
				{
					_iCReceiptItemPrice = value;
					NotifyChanged("ICReceiptItemPrice");
				}
			}
		}
		public String ICReceiptItemComment
		{
			get { return _iCReceiptItemComment; }
			set
			{
				if (value != this._iCReceiptItemComment)
				{
					_iCReceiptItemComment = value;
					NotifyChanged("ICReceiptItemComment");
				}
			}
		}
		public double ICReceiptItemUnitVol
		{
			get { return _iCReceiptItemUnitVol; }
			set
			{
				if (value != this._iCReceiptItemUnitVol)
				{
					_iCReceiptItemUnitVol = value;
					NotifyChanged("ICReceiptItemUnitVol");
				}
			}
		}
		public double ICReceiptItemUnitWeight
		{
			get { return _iCReceiptItemUnitWeight; }
			set
			{
				if (value != this._iCReceiptItemUnitWeight)
				{
					_iCReceiptItemUnitWeight = value;
					NotifyChanged("ICReceiptItemUnitWeight");
				}
			}
		}
		public double ICReceiptItemTxAmt
		{
			get { return _iCReceiptItemTxAmt; }
			set
			{
				if (value != this._iCReceiptItemTxAmt)
				{
					_iCReceiptItemTxAmt = value;
					NotifyChanged("ICReceiptItemTxAmt");
				}
			}
		}
		public double ICReceiptItemDiscAmt
		{
			get { return _iCReceiptItemDiscAmt; }
			set
			{
				if (value != this._iCReceiptItemDiscAmt)
				{
					_iCReceiptItemDiscAmt = value;
					NotifyChanged("ICReceiptItemDiscAmt");
				}
			}
		}
		public double ICReceiptItemNetAmt
		{
			get { return _iCReceiptItemNetAmt; }
			set
			{
				if (value != this._iCReceiptItemNetAmt)
				{
					_iCReceiptItemNetAmt = value;
					NotifyChanged("ICReceiptItemNetAmt");
				}
			}
		}
		public double ICReceiptItemAmtTot
		{
			get { return _iCReceiptItemAmtTot; }
			set
			{
				if (value != this._iCReceiptItemAmtTot)
				{
					_iCReceiptItemAmtTot = value;
					NotifyChanged("ICReceiptItemAmtTot");
				}
			}
		}
		public double ICReceiptItemDirectCostTot
		{
			get { return _iCReceiptItemDirectCostTot; }
			set
			{
				if (value != this._iCReceiptItemDirectCostTot)
				{
					_iCReceiptItemDirectCostTot = value;
					NotifyChanged("ICReceiptItemDirectCostTot");
				}
			}
		}
		public double ICReceiptItemInDirectCostTot
		{
			get { return _iCReceiptItemInDirectCostTot; }
			set
			{
				if (value != this._iCReceiptItemInDirectCostTot)
				{
					_iCReceiptItemInDirectCostTot = value;
					NotifyChanged("ICReceiptItemInDirectCostTot");
				}
			}
		}
		public double ICReceiptItemInDirectAllocateCostTot
		{
			get { return _iCReceiptItemInDirectAllocateCostTot; }
			set
			{
				if (value != this._iCReceiptItemInDirectAllocateCostTot)
				{
					_iCReceiptItemInDirectAllocateCostTot = value;
					NotifyChanged("ICReceiptItemInDirectAllocateCostTot");
				}
			}
		}
		public double ICReceiptItemCostTot
		{
			get { return _iCReceiptItemCostTot; }
			set
			{
				if (value != this._iCReceiptItemCostTot)
				{
					_iCReceiptItemCostTot = value;
					NotifyChanged("ICReceiptItemCostTot");
				}
			}
		}
		public String ICReceiptItemStatus
		{
			get { return _iCReceiptItemStatus; }
			set
			{
				if (value != this._iCReceiptItemStatus)
				{
					_iCReceiptItemStatus = value;
					NotifyChanged("ICReceiptItemStatus");
				}
			}
		}
		public double ICReceiptItemAmt
		{
			get { return _iCReceiptItemAmt; }
			set
			{
				if (value != this._iCReceiptItemAmt)
				{
					_iCReceiptItemAmt = value;
					NotifyChanged("ICReceiptItemAmt");
				}
			}
		}
		public double ICReceiptItemCAmt
		{
			get { return _iCReceiptItemCAmt; }
			set
			{
				if (value != this._iCReceiptItemCAmt)
				{
					_iCReceiptItemCAmt = value;
					NotifyChanged("ICReceiptItemCAmt");
				}
			}
		}
		public double ICReceiptItemShpAmt
		{
			get { return _iCReceiptItemShpAmt; }
			set
			{
				if (value != this._iCReceiptItemShpAmt)
				{
					_iCReceiptItemShpAmt = value;
					NotifyChanged("ICReceiptItemShpAmt");
				}
			}
		}
		public double ICReceiptItemMiscChargeAmt
		{
			get { return _iCReceiptItemMiscChargeAmt; }
			set
			{
				if (value != this._iCReceiptItemMiscChargeAmt)
				{
					_iCReceiptItemMiscChargeAmt = value;
					NotifyChanged("ICReceiptItemMiscChargeAmt");
				}
			}
		}
		public double ICReceiptItemImpTxAmt
		{
			get { return _iCReceiptItemImpTxAmt; }
			set
			{
				if (value != this._iCReceiptItemImpTxAmt)
				{
					_iCReceiptItemImpTxAmt = value;
					NotifyChanged("ICReceiptItemImpTxAmt");
				}
			}
		}
		public int FK_TXImpTaxCodeID
		{
			get { return _fK_TXImpTaxCodeID; }
			set
			{
				if (value != this._fK_TXImpTaxCodeID)
				{
					_fK_TXImpTaxCodeID = value;
					NotifyChanged("FK_TXImpTaxCodeID");
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
		public int FK_ICProductIDWO
		{
			get { return _fK_ICProductIDWO; }
			set
			{
				if (value != this._fK_ICProductIDWO)
				{
					_fK_ICProductIDWO = value;
					NotifyChanged("FK_ICProductIDWO");
				}
			}
		}
		public Nullable<DateTime> ICReceiptItemExpiredDate
		{
			get { return _iCReceiptItemExpiredDate; }
			set
			{
				if (value != this._iCReceiptItemExpiredDate)
				{
					_iCReceiptItemExpiredDate = value;
					NotifyChanged("ICReceiptItemExpiredDate");
				}
			}
		}
		public Nullable<DateTime> ICReceiptItemDate
		{
			get { return _iCReceiptItemDate; }
			set
			{
				if (value != this._iCReceiptItemDate)
				{
					_iCReceiptItemDate = value;
					NotifyChanged("ICReceiptItemDate");
				}
			}
		}
		public double ICReceiptItemShpQty
		{
			get { return _iCReceiptItemShpQty; }
			set
			{
				if (value != this._iCReceiptItemShpQty)
				{
					_iCReceiptItemShpQty = value;
					NotifyChanged("ICReceiptItemShpQty");
				}
			}
		}
		public double ICReceiptItemShpRQty
		{
			get { return _iCReceiptItemShpRQty; }
			set
			{
				if (value != this._iCReceiptItemShpRQty)
				{
					_iCReceiptItemShpRQty = value;
					NotifyChanged("ICReceiptItemShpRQty");
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
		public double ICReceiptItemFUnitPrice
		{
			get { return _iCReceiptItemFUnitPrice; }
			set
			{
				if (value != this._iCReceiptItemFUnitPrice)
				{
					_iCReceiptItemFUnitPrice = value;
					NotifyChanged("ICReceiptItemFUnitPrice");
				}
			}
		}
		public double ICReceiptItemFPrice
		{
			get { return _iCReceiptItemFPrice; }
			set
			{
				if (value != this._iCReceiptItemFPrice)
				{
					_iCReceiptItemFPrice = value;
					NotifyChanged("ICReceiptItemFPrice");
				}
			}
		}
		public double ICReceiptItemFTxAmt
		{
			get { return _iCReceiptItemFTxAmt; }
			set
			{
				if (value != this._iCReceiptItemFTxAmt)
				{
					_iCReceiptItemFTxAmt = value;
					NotifyChanged("ICReceiptItemFTxAmt");
				}
			}
		}
		public double ICReceiptItemFNetAmt
		{
			get { return _iCReceiptItemFNetAmt; }
			set
			{
				if (value != this._iCReceiptItemFNetAmt)
				{
					_iCReceiptItemFNetAmt = value;
					NotifyChanged("ICReceiptItemFNetAmt");
				}
			}
		}
		public double ICReceiptItemFAmtTot
		{
			get { return _iCReceiptItemFAmtTot; }
			set
			{
				if (value != this._iCReceiptItemFAmtTot)
				{
					_iCReceiptItemFAmtTot = value;
					NotifyChanged("ICReceiptItemFAmtTot");
				}
			}
		}
		public double ICReceiptItemFImpTxAmt
		{
			get { return _iCReceiptItemFImpTxAmt; }
			set
			{
				if (value != this._iCReceiptItemFImpTxAmt)
				{
					_iCReceiptItemFImpTxAmt = value;
					NotifyChanged("ICReceiptItemFImpTxAmt");
				}
			}
		}
		public Nullable<DateTime> ICReceiptItemExpireDate
		{
			get { return _iCReceiptItemExpireDate; }
			set
			{
				if (value != this._iCReceiptItemExpireDate)
				{
					_iCReceiptItemExpireDate = value;
					NotifyChanged("ICReceiptItemExpireDate");
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
		public int FK_GLDebitVATAccountID
		{
			get { return _fK_GLDebitVATAccountID; }
			set
			{
				if (value != this._fK_GLDebitVATAccountID)
				{
					_fK_GLDebitVATAccountID = value;
					NotifyChanged("FK_GLDebitVATAccountID");
				}
			}
		}
		public int FK_GLCreditVATAccountID
		{
			get { return _fK_GLCreditVATAccountID; }
			set
			{
				if (value != this._fK_GLCreditVATAccountID)
				{
					_fK_GLCreditVATAccountID = value;
					NotifyChanged("FK_GLCreditVATAccountID");
				}
			}
		}
		public String ICReceiptItemPurchaseReturnStatusCombo
		{
			get { return _iCReceiptItemPurchaseReturnStatusCombo; }
			set
			{
				if (value != this._iCReceiptItemPurchaseReturnStatusCombo)
				{
					_iCReceiptItemPurchaseReturnStatusCombo = value;
					NotifyChanged("ICReceiptItemPurchaseReturnStatusCombo");
				}
			}
		}
		public double ICReceiptItemPurchaseReturnRQty
		{
			get { return _iCReceiptItemPurchaseReturnRQty; }
			set
			{
				if (value != this._iCReceiptItemPurchaseReturnRQty)
				{
					_iCReceiptItemPurchaseReturnRQty = value;
					NotifyChanged("ICReceiptItemPurchaseReturnRQty");
				}
			}
		}
		public String ICReceiptItemLotNo
		{
			get { return _iCReceiptItemLotNo; }
			set
			{
				if (value != this._iCReceiptItemLotNo)
				{
					_iCReceiptItemLotNo = value;
					NotifyChanged("ICReceiptItemLotNo");
				}
			}
		}
		public double ICReceiptItemFreightAmt
		{
			get { return _iCReceiptItemFreightAmt; }
			set
			{
				if (value != this._iCReceiptItemFreightAmt)
				{
					_iCReceiptItemFreightAmt = value;
					NotifyChanged("ICReceiptItemFreightAmt");
				}
			}
		}
		public double ICReceiptItemSealedBankQty
		{
			get { return _iCReceiptItemSealedBankQty; }
			set
			{
				if (value != this._iCReceiptItemSealedBankQty)
				{
					_iCReceiptItemSealedBankQty = value;
					NotifyChanged("ICReceiptItemSealedBankQty");
				}
			}
		}
		public double ICReceiptItemSealedBankRQty
		{
			get { return _iCReceiptItemSealedBankRQty; }
			set
			{
				if (value != this._iCReceiptItemSealedBankRQty)
				{
					_iCReceiptItemSealedBankRQty = value;
					NotifyChanged("ICReceiptItemSealedBankRQty");
				}
			}
		}
		public int FK_ARLendContractID
		{
			get { return _fK_ARLendContractID; }
			set
			{
				if (value != this._fK_ARLendContractID)
				{
					_fK_ARLendContractID = value;
					NotifyChanged("FK_ARLendContractID");
				}
			}
		}
		public int FK_ICStockUOMID
		{
			get { return _fK_ICStockUOMID; }
			set
			{
				if (value != this._fK_ICStockUOMID)
				{
					_fK_ICStockUOMID = value;
					NotifyChanged("FK_ICStockUOMID");
				}
			}
		}
		public double ICReceiptItemAllocateQty
		{
			get { return _iCReceiptItemAllocateQty; }
			set
			{
				if (value != this._iCReceiptItemAllocateQty)
				{
					_iCReceiptItemAllocateQty = value;
					NotifyChanged("ICReceiptItemAllocateQty");
				}
			}
		}
		public double ICReceiptItemPOQty
		{
			get { return _iCReceiptItemPOQty; }
			set
			{
				if (value != this._iCReceiptItemPOQty)
				{
					_iCReceiptItemPOQty = value;
					NotifyChanged("ICReceiptItemPOQty");
				}
			}
		}
		public double ICReceiptItemPOReceiptQty
		{
			get { return _iCReceiptItemPOReceiptQty; }
			set
			{
				if (value != this._iCReceiptItemPOReceiptQty)
				{
					_iCReceiptItemPOReceiptQty = value;
					NotifyChanged("ICReceiptItemPOReceiptQty");
				}
			}
		}
		public double ICReceiptItemPORQty
		{
			get { return _iCReceiptItemPORQty; }
			set
			{
				if (value != this._iCReceiptItemPORQty)
				{
					_iCReceiptItemPORQty = value;
					NotifyChanged("ICReceiptItemPORQty");
				}
			}
		}
		public String ICPackageLockTypeCombo
		{
			get { return _iCPackageLockTypeCombo; }
			set
			{
				if (value != this._iCPackageLockTypeCombo)
				{
					_iCPackageLockTypeCombo = value;
					NotifyChanged("ICPackageLockTypeCombo");
				}
			}
		}
		public bool ICReceiptItemIsCostingItemCheck
		{
			get { return _iCReceiptItemIsCostingItemCheck; }
			set
			{
				if (value != this._iCReceiptItemIsCostingItemCheck)
				{
					_iCReceiptItemIsCostingItemCheck = value;
					NotifyChanged("ICReceiptItemIsCostingItemCheck");
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
		public double ICReceiptItemHeight
		{
			get { return _iCReceiptItemHeight; }
			set
			{
				if (value != this._iCReceiptItemHeight)
				{
					_iCReceiptItemHeight = value;
					NotifyChanged("ICReceiptItemHeight");
				}
			}
		}
		public double ICReceiptItemWidth
		{
			get { return _iCReceiptItemWidth; }
			set
			{
				if (value != this._iCReceiptItemWidth)
				{
					_iCReceiptItemWidth = value;
					NotifyChanged("ICReceiptItemWidth");
				}
			}
		}
		public double ICReceiptItemLength
		{
			get { return _iCReceiptItemLength; }
			set
			{
				if (value != this._iCReceiptItemLength)
				{
					_iCReceiptItemLength = value;
					NotifyChanged("ICReceiptItemLength");
				}
			}
		}
		public String ICReceiptItemProductionTypeCombo
		{
			get { return _iCReceiptItemProductionTypeCombo; }
			set
			{
				if (value != this._iCReceiptItemProductionTypeCombo)
				{
					_iCReceiptItemProductionTypeCombo = value;
					NotifyChanged("ICReceiptItemProductionTypeCombo");
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
		public int FK_GLTranCfgID
		{
			get { return _fK_GLTranCfgID; }
			set
			{
				if (value != this._fK_GLTranCfgID)
				{
					_fK_GLTranCfgID = value;
					NotifyChanged("FK_GLTranCfgID");
				}
			}
		}
		public int FK_PPWOID
		{
			get { return _fK_PPWOID; }
			set
			{
				if (value != this._fK_PPWOID)
				{
					_fK_PPWOID = value;
					NotifyChanged("FK_PPWOID");
				}
			}
		}
		public double ICReceiptItemOverheadCost
		{
			get { return _iCReceiptItemOverheadCost; }
			set
			{
				if (value != this._iCReceiptItemOverheadCost)
				{
					_iCReceiptItemOverheadCost = value;
					NotifyChanged("ICReceiptItemOverheadCost");
				}
			}
		}
		public double ICReceiptItemLaborCost
		{
			get { return _iCReceiptItemLaborCost; }
			set
			{
				if (value != this._iCReceiptItemLaborCost)
				{
					_iCReceiptItemLaborCost = value;
					NotifyChanged("ICReceiptItemLaborCost");
				}
			}
		}
		public double ICReceiptItemBeginCostAmt
		{
			get { return _iCReceiptItemBeginCostAmt; }
			set
			{
				if (value != this._iCReceiptItemBeginCostAmt)
				{
					_iCReceiptItemBeginCostAmt = value;
					NotifyChanged("ICReceiptItemBeginCostAmt");
				}
			}
		}
		public double ICReceiptItemIndirectRMCost
		{
			get { return _iCReceiptItemIndirectRMCost; }
			set
			{
				if (value != this._iCReceiptItemIndirectRMCost)
				{
					_iCReceiptItemIndirectRMCost = value;
					NotifyChanged("ICReceiptItemIndirectRMCost");
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
		public double ICReceiptItemWTot
		{
			get { return _iCReceiptItemWTot; }
			set
			{
				if (value != this._iCReceiptItemWTot)
				{
					_iCReceiptItemWTot = value;
					NotifyChanged("ICReceiptItemWTot");
				}
			}
		}
		public double ICReceiptItemVTot
		{
			get { return _iCReceiptItemVTot; }
			set
			{
				if (value != this._iCReceiptItemVTot)
				{
					_iCReceiptItemVTot = value;
					NotifyChanged("ICReceiptItemVTot");
				}
			}
		}
		public double ICReceiptItemOrgQty
		{
			get { return _iCReceiptItemOrgQty; }
			set
			{
				if (value != this._iCReceiptItemOrgQty)
				{
					_iCReceiptItemOrgQty = value;
					NotifyChanged("ICReceiptItemOrgQty");
				}
			}
		}
		public double ICReceiptItemExcQty
		{
			get { return _iCReceiptItemExcQty; }
			set
			{
				if (value != this._iCReceiptItemExcQty)
				{
					_iCReceiptItemExcQty = value;
					NotifyChanged("ICReceiptItemExcQty");
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
		public double ICReceiptItemCQty
		{
			get { return _iCReceiptItemCQty; }
			set
			{
				if (value != this._iCReceiptItemCQty)
				{
					_iCReceiptItemCQty = value;
					NotifyChanged("ICReceiptItemCQty");
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
		public int FK_ICAssemblyID
		{
			get { return _fK_ICAssemblyID; }
			set
			{
				if (value != this._fK_ICAssemblyID)
				{
					_fK_ICAssemblyID = value;
					NotifyChanged("FK_ICAssemblyID");
				}
			}
		}
		public int FK_ICKitID
		{
			get { return _fK_ICKitID; }
			set
			{
				if (value != this._fK_ICKitID)
				{
					_fK_ICKitID = value;
					NotifyChanged("FK_ICKitID");
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
		public String ICReceiptItemProductNo
		{
			get { return _iCReceiptItemProductNo; }
			set
			{
				if (value != this._iCReceiptItemProductNo)
				{
					_iCReceiptItemProductNo = value;
					NotifyChanged("ICReceiptItemProductNo");
				}
			}
		}
		public String ICReceiptItemProductName
		{
			get { return _iCReceiptItemProductName; }
			set
			{
				if (value != this._iCReceiptItemProductName)
				{
					_iCReceiptItemProductName = value;
					NotifyChanged("ICReceiptItemProductName");
				}
			}
		}
		public double ICReceiptItemImportCostAmt
		{
			get { return _iCReceiptItemImportCostAmt; }
			set
			{
				if (value != this._iCReceiptItemImportCostAmt)
				{
					_iCReceiptItemImportCostAmt = value;
					NotifyChanged("ICReceiptItemImportCostAmt");
				}
			}
		}
		public double ICReceiptItemFImportCostAmt
		{
			get { return _iCReceiptItemFImportCostAmt; }
			set
			{
				if (value != this._iCReceiptItemFImportCostAmt)
				{
					_iCReceiptItemFImportCostAmt = value;
					NotifyChanged("ICReceiptItemFImportCostAmt");
				}
			}
		}
		public int FK_ICShipmentItemID
		{
			get { return _fK_ICShipmentItemID; }
			set
			{
				if (value != this._fK_ICShipmentItemID)
				{
					_fK_ICShipmentItemID = value;
					NotifyChanged("FK_ICShipmentItemID");
				}
			}
		}
		public int FK_PPNormID
		{
			get { return _fK_PPNormID; }
			set
			{
				if (value != this._fK_PPNormID)
				{
					_fK_PPNormID = value;
					NotifyChanged("FK_PPNormID");
				}
			}
		}
		public int FK_ARSOItemID
		{
			get { return _fK_ARSOItemID; }
			set
			{
				if (value != this._fK_ARSOItemID)
				{
					_fK_ARSOItemID = value;
					NotifyChanged("FK_ARSOItemID");
				}
			}
		}
		public int FK_ARInvoiceItemID
		{
			get { return _fK_ARInvoiceItemID; }
			set
			{
				if (value != this._fK_ARInvoiceItemID)
				{
					_fK_ARInvoiceItemID = value;
					NotifyChanged("FK_ARInvoiceItemID");
				}
			}
		}
		public int ICReceiptItemLine
		{
			get { return _iCReceiptItemLine; }
			set
			{
				if (value != this._iCReceiptItemLine)
				{
					_iCReceiptItemLine = value;
					NotifyChanged("ICReceiptItemLine");
				}
			}
		}
		public double ICReceiptItemFCostTot
		{
			get { return _iCReceiptItemFCostTot; }
			set
			{
				if (value != this._iCReceiptItemFCostTot)
				{
					_iCReceiptItemFCostTot = value;
					NotifyChanged("ICReceiptItemFCostTot");
				}
			}
		}
		public int FK_ARShpPlanItemID
		{
			get { return _fK_ARShpPlanItemID; }
			set
			{
				if (value != this._fK_ARShpPlanItemID)
				{
					_fK_ARShpPlanItemID = value;
					NotifyChanged("FK_ARShpPlanItemID");
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
		public double ICReceiptItemFreightFAmt
		{
			get { return _iCReceiptItemFreightFAmt; }
			set
			{
				if (value != this._iCReceiptItemFreightFAmt)
				{
					_iCReceiptItemFreightFAmt = value;
					NotifyChanged("ICReceiptItemFreightFAmt");
				}
			}
		}
		public String ICReceiptItemFGLotNo
		{
			get { return _iCReceiptItemFGLotNo; }
			set
			{
				if (value != this._iCReceiptItemFGLotNo)
				{
					_iCReceiptItemFGLotNo = value;
					NotifyChanged("ICReceiptItemFGLotNo");
				}
			}
		}
		
        #endregion
    }
    #endregion
}