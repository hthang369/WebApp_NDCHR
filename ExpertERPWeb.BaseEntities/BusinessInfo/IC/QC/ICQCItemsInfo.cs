
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICQCItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.63)
    //Class: ICQCItemsInfo
    //Created Date: Tuesday, 09 Aug 2016
    //-----------------------------------------------------------

    public class ICQCItemsInfo : BusinessObject
    {
        public ICQCItemsInfo()
        {
        }
        #region Variables
		protected int _iCQCItemID;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected int _fK_ICQCID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ARPriceListID;
		protected int _fK_TXTaxCodeID;
		protected String _iCQCItemSerialNo = String.Empty;
		protected String _iCQCItemType = String.Empty;
		protected bool _iCQCItemIsStkItm = true;
		protected String _iCQCItemDesc = String.Empty;
		protected String _iCQCItemUOM = String.Empty;
		protected String _iCQCItemStkUOM = String.Empty;
		protected double _iCQCItemFact;
		protected double _iCQCItemUnitPrice;
		protected double _iCQCItemUnitCost;
		protected double _iCQCItemDiscPct;
		protected double _iCQCItemTxPct;
		protected double _iCQCItemVolume;
		protected double _iCQCItemQty;
		protected double _iCQCItemRQty;
		protected double _iCQCItemRcpQty;
		protected double _iCQCItemInValidQty;
		protected double _iCQCItemPrice;
		protected String _iCQCItemComment = String.Empty;
		protected double _iCQCItemUnitVol;
		protected double _iCQCItemUnitWeight;
		protected double _iCQCItemTxAmt;
		protected double _iCQCItemDiscAmt;
		protected double _iCQCItemNetAmt;
		protected double _iCQCItemAmtTot;
		protected double _iCQCItemCostTot;
		protected double _iCQCItemAmt;
		protected int _fK_TXImpTaxCodeID;
		protected int _fK_PPPhaseCfgID;
		protected int _fK_ICProductIDWO;
		protected Nullable<DateTime> _iCQCItemDate;
		protected int _fK_ICProductParentID;
		protected double _iCQCItemFUnitPrice;
		protected double _iCQCItemFPrice;
		protected double _iCQCItemFTxAmt;
		protected double _iCQCItemFNetAmt;
		protected double _iCQCItemFAmtTot;
		protected double _iCQCItemFImpTxAmt;
		protected int _fK_GLDebitAccountID;
		protected int _fK_GLCreditAccountID;
		protected int _fK_GLDebitVATAccountID;
		protected int _fK_GLCreditVATAccountID;
		protected String _iCQCItemStatusCombo = DefaultStatus;
		protected String _iCQCItemLotNo = String.Empty;
		protected double _iCQCItemFreightAmt;
		protected int _fK_ARLendContractID;
		protected int _fK_ICStockUOMID;
		protected int _fK_PPProductionOrdrID;
		protected double _iCQCItemHeight;
		protected double _iCQCItemWidth;
		protected double _iCQCItemLength;
		protected int _fK_GLCostDistID;
		protected int _fK_GLTranCfgID;
		protected int _fK_PPWOID;
		protected double _iCQCItemOverheadCost;
		protected double _iCQCItemLaborCost;
		protected double _iCQCItemBeginCostAmt;
		protected double _iCQCItemIndirectRMCost;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _iCQCItemWTot;
		protected double _iCReceiptItemVTot;
		protected double _iCQCItemStkQty;
		protected double _iCQCItemOrgQty;
		protected double _iCQCItemPctInvalid;
		protected double _iCQCItemPctValid;
		protected double _iCQCItemRInValidQty;
		
        #endregion

        #region Public properties
		public int ICQCItemID
		{
			get { return _iCQCItemID; }
			set
			{
				if (value != this._iCQCItemID)
				{
					_iCQCItemID = value;
					NotifyChanged("ICQCItemID");
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
		public int FK_ICQCID
		{
			get { return _fK_ICQCID; }
			set
			{
				if (value != this._fK_ICQCID)
				{
					_fK_ICQCID = value;
					NotifyChanged("FK_ICQCID");
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
		public String ICQCItemSerialNo
		{
			get { return _iCQCItemSerialNo; }
			set
			{
				if (value != this._iCQCItemSerialNo)
				{
					_iCQCItemSerialNo = value;
					NotifyChanged("ICQCItemSerialNo");
				}
			}
		}
		public String ICQCItemType
		{
			get { return _iCQCItemType; }
			set
			{
				if (value != this._iCQCItemType)
				{
					_iCQCItemType = value;
					NotifyChanged("ICQCItemType");
				}
			}
		}
		public bool ICQCItemIsStkItm
		{
			get { return _iCQCItemIsStkItm; }
			set
			{
				if (value != this._iCQCItemIsStkItm)
				{
					_iCQCItemIsStkItm = value;
					NotifyChanged("ICQCItemIsStkItm");
				}
			}
		}
		public String ICQCItemDesc
		{
			get { return _iCQCItemDesc; }
			set
			{
				if (value != this._iCQCItemDesc)
				{
					_iCQCItemDesc = value;
					NotifyChanged("ICQCItemDesc");
				}
			}
		}
		public String ICQCItemUOM
		{
			get { return _iCQCItemUOM; }
			set
			{
				if (value != this._iCQCItemUOM)
				{
					_iCQCItemUOM = value;
					NotifyChanged("ICQCItemUOM");
				}
			}
		}
		public String ICQCItemStkUOM
		{
			get { return _iCQCItemStkUOM; }
			set
			{
				if (value != this._iCQCItemStkUOM)
				{
					_iCQCItemStkUOM = value;
					NotifyChanged("ICQCItemStkUOM");
				}
			}
		}
		public double ICQCItemFact
		{
			get { return _iCQCItemFact; }
			set
			{
				if (value != this._iCQCItemFact)
				{
					_iCQCItemFact = value;
					NotifyChanged("ICQCItemFact");
				}
			}
		}
		public double ICQCItemUnitPrice
		{
			get { return _iCQCItemUnitPrice; }
			set
			{
				if (value != this._iCQCItemUnitPrice)
				{
					_iCQCItemUnitPrice = value;
					NotifyChanged("ICQCItemUnitPrice");
				}
			}
		}
		public double ICQCItemUnitCost
		{
			get { return _iCQCItemUnitCost; }
			set
			{
				if (value != this._iCQCItemUnitCost)
				{
					_iCQCItemUnitCost = value;
					NotifyChanged("ICQCItemUnitCost");
				}
			}
		}
		public double ICQCItemDiscPct
		{
			get { return _iCQCItemDiscPct; }
			set
			{
				if (value != this._iCQCItemDiscPct)
				{
					_iCQCItemDiscPct = value;
					NotifyChanged("ICQCItemDiscPct");
				}
			}
		}
		public double ICQCItemTxPct
		{
			get { return _iCQCItemTxPct; }
			set
			{
				if (value != this._iCQCItemTxPct)
				{
					_iCQCItemTxPct = value;
					NotifyChanged("ICQCItemTxPct");
				}
			}
		}
		public double ICQCItemVolume
		{
			get { return _iCQCItemVolume; }
			set
			{
				if (value != this._iCQCItemVolume)
				{
					_iCQCItemVolume = value;
					NotifyChanged("ICQCItemVolume");
				}
			}
		}
		public double ICQCItemQty
		{
			get { return _iCQCItemQty; }
			set
			{
				if (value != this._iCQCItemQty)
				{
					_iCQCItemQty = value;
					NotifyChanged("ICQCItemQty");
				}
			}
		}
		public double ICQCItemRQty
		{
			get { return _iCQCItemRQty; }
			set
			{
				if (value != this._iCQCItemRQty)
				{
					_iCQCItemRQty = value;
					NotifyChanged("ICQCItemRQty");
				}
			}
		}
		public double ICQCItemRcpQty
		{
			get { return _iCQCItemRcpQty; }
			set
			{
				if (value != this._iCQCItemRcpQty)
				{
					_iCQCItemRcpQty = value;
					NotifyChanged("ICQCItemRcpQty");
				}
			}
		}
		public double ICQCItemInValidQty
		{
			get { return _iCQCItemInValidQty; }
			set
			{
				if (value != this._iCQCItemInValidQty)
				{
					_iCQCItemInValidQty = value;
					NotifyChanged("ICQCItemInValidQty");
				}
			}
		}
		public double ICQCItemPrice
		{
			get { return _iCQCItemPrice; }
			set
			{
				if (value != this._iCQCItemPrice)
				{
					_iCQCItemPrice = value;
					NotifyChanged("ICQCItemPrice");
				}
			}
		}
		public String ICQCItemComment
		{
			get { return _iCQCItemComment; }
			set
			{
				if (value != this._iCQCItemComment)
				{
					_iCQCItemComment = value;
					NotifyChanged("ICQCItemComment");
				}
			}
		}
		public double ICQCItemUnitVol
		{
			get { return _iCQCItemUnitVol; }
			set
			{
				if (value != this._iCQCItemUnitVol)
				{
					_iCQCItemUnitVol = value;
					NotifyChanged("ICQCItemUnitVol");
				}
			}
		}
		public double ICQCItemUnitWeight
		{
			get { return _iCQCItemUnitWeight; }
			set
			{
				if (value != this._iCQCItemUnitWeight)
				{
					_iCQCItemUnitWeight = value;
					NotifyChanged("ICQCItemUnitWeight");
				}
			}
		}
		public double ICQCItemTxAmt
		{
			get { return _iCQCItemTxAmt; }
			set
			{
				if (value != this._iCQCItemTxAmt)
				{
					_iCQCItemTxAmt = value;
					NotifyChanged("ICQCItemTxAmt");
				}
			}
		}
		public double ICQCItemDiscAmt
		{
			get { return _iCQCItemDiscAmt; }
			set
			{
				if (value != this._iCQCItemDiscAmt)
				{
					_iCQCItemDiscAmt = value;
					NotifyChanged("ICQCItemDiscAmt");
				}
			}
		}
		public double ICQCItemNetAmt
		{
			get { return _iCQCItemNetAmt; }
			set
			{
				if (value != this._iCQCItemNetAmt)
				{
					_iCQCItemNetAmt = value;
					NotifyChanged("ICQCItemNetAmt");
				}
			}
		}
		public double ICQCItemAmtTot
		{
			get { return _iCQCItemAmtTot; }
			set
			{
				if (value != this._iCQCItemAmtTot)
				{
					_iCQCItemAmtTot = value;
					NotifyChanged("ICQCItemAmtTot");
				}
			}
		}
		public double ICQCItemCostTot
		{
			get { return _iCQCItemCostTot; }
			set
			{
				if (value != this._iCQCItemCostTot)
				{
					_iCQCItemCostTot = value;
					NotifyChanged("ICQCItemCostTot");
				}
			}
		}
		public double ICQCItemAmt
		{
			get { return _iCQCItemAmt; }
			set
			{
				if (value != this._iCQCItemAmt)
				{
					_iCQCItemAmt = value;
					NotifyChanged("ICQCItemAmt");
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
		public Nullable<DateTime> ICQCItemDate
		{
			get { return _iCQCItemDate; }
			set
			{
				if (value != this._iCQCItemDate)
				{
					_iCQCItemDate = value;
					NotifyChanged("ICQCItemDate");
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
		public double ICQCItemFUnitPrice
		{
			get { return _iCQCItemFUnitPrice; }
			set
			{
				if (value != this._iCQCItemFUnitPrice)
				{
					_iCQCItemFUnitPrice = value;
					NotifyChanged("ICQCItemFUnitPrice");
				}
			}
		}
		public double ICQCItemFPrice
		{
			get { return _iCQCItemFPrice; }
			set
			{
				if (value != this._iCQCItemFPrice)
				{
					_iCQCItemFPrice = value;
					NotifyChanged("ICQCItemFPrice");
				}
			}
		}
		public double ICQCItemFTxAmt
		{
			get { return _iCQCItemFTxAmt; }
			set
			{
				if (value != this._iCQCItemFTxAmt)
				{
					_iCQCItemFTxAmt = value;
					NotifyChanged("ICQCItemFTxAmt");
				}
			}
		}
		public double ICQCItemFNetAmt
		{
			get { return _iCQCItemFNetAmt; }
			set
			{
				if (value != this._iCQCItemFNetAmt)
				{
					_iCQCItemFNetAmt = value;
					NotifyChanged("ICQCItemFNetAmt");
				}
			}
		}
		public double ICQCItemFAmtTot
		{
			get { return _iCQCItemFAmtTot; }
			set
			{
				if (value != this._iCQCItemFAmtTot)
				{
					_iCQCItemFAmtTot = value;
					NotifyChanged("ICQCItemFAmtTot");
				}
			}
		}
		public double ICQCItemFImpTxAmt
		{
			get { return _iCQCItemFImpTxAmt; }
			set
			{
				if (value != this._iCQCItemFImpTxAmt)
				{
					_iCQCItemFImpTxAmt = value;
					NotifyChanged("ICQCItemFImpTxAmt");
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
		public String ICQCItemStatusCombo
		{
			get { return _iCQCItemStatusCombo; }
			set
			{
				if (value != this._iCQCItemStatusCombo)
				{
					_iCQCItemStatusCombo = value;
					NotifyChanged("ICQCItemStatusCombo");
				}
			}
		}
		public String ICQCItemLotNo
		{
			get { return _iCQCItemLotNo; }
			set
			{
				if (value != this._iCQCItemLotNo)
				{
					_iCQCItemLotNo = value;
					NotifyChanged("ICQCItemLotNo");
				}
			}
		}
		public double ICQCItemFreightAmt
		{
			get { return _iCQCItemFreightAmt; }
			set
			{
				if (value != this._iCQCItemFreightAmt)
				{
					_iCQCItemFreightAmt = value;
					NotifyChanged("ICQCItemFreightAmt");
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
		public double ICQCItemHeight
		{
			get { return _iCQCItemHeight; }
			set
			{
				if (value != this._iCQCItemHeight)
				{
					_iCQCItemHeight = value;
					NotifyChanged("ICQCItemHeight");
				}
			}
		}
		public double ICQCItemWidth
		{
			get { return _iCQCItemWidth; }
			set
			{
				if (value != this._iCQCItemWidth)
				{
					_iCQCItemWidth = value;
					NotifyChanged("ICQCItemWidth");
				}
			}
		}
		public double ICQCItemLength
		{
			get { return _iCQCItemLength; }
			set
			{
				if (value != this._iCQCItemLength)
				{
					_iCQCItemLength = value;
					NotifyChanged("ICQCItemLength");
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
		public double ICQCItemOverheadCost
		{
			get { return _iCQCItemOverheadCost; }
			set
			{
				if (value != this._iCQCItemOverheadCost)
				{
					_iCQCItemOverheadCost = value;
					NotifyChanged("ICQCItemOverheadCost");
				}
			}
		}
		public double ICQCItemLaborCost
		{
			get { return _iCQCItemLaborCost; }
			set
			{
				if (value != this._iCQCItemLaborCost)
				{
					_iCQCItemLaborCost = value;
					NotifyChanged("ICQCItemLaborCost");
				}
			}
		}
		public double ICQCItemBeginCostAmt
		{
			get { return _iCQCItemBeginCostAmt; }
			set
			{
				if (value != this._iCQCItemBeginCostAmt)
				{
					_iCQCItemBeginCostAmt = value;
					NotifyChanged("ICQCItemBeginCostAmt");
				}
			}
		}
		public double ICQCItemIndirectRMCost
		{
			get { return _iCQCItemIndirectRMCost; }
			set
			{
				if (value != this._iCQCItemIndirectRMCost)
				{
					_iCQCItemIndirectRMCost = value;
					NotifyChanged("ICQCItemIndirectRMCost");
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
		public double ICQCItemWTot
		{
			get { return _iCQCItemWTot; }
			set
			{
				if (value != this._iCQCItemWTot)
				{
					_iCQCItemWTot = value;
					NotifyChanged("ICQCItemWTot");
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
		public double ICQCItemStkQty
		{
			get { return _iCQCItemStkQty; }
			set
			{
				if (value != this._iCQCItemStkQty)
				{
					_iCQCItemStkQty = value;
					NotifyChanged("ICQCItemStkQty");
				}
			}
		}
		public double ICQCItemOrgQty
		{
			get { return _iCQCItemOrgQty; }
			set
			{
				if (value != this._iCQCItemOrgQty)
				{
					_iCQCItemOrgQty = value;
					NotifyChanged("ICQCItemOrgQty");
				}
			}
		}
		public double ICQCItemPctInvalid
		{
			get { return _iCQCItemPctInvalid; }
			set
			{
				if (value != this._iCQCItemPctInvalid)
				{
					_iCQCItemPctInvalid = value;
					NotifyChanged("ICQCItemPctInvalid");
				}
			}
		}
		public double ICQCItemPctValid
		{
			get { return _iCQCItemPctValid; }
			set
			{
				if (value != this._iCQCItemPctValid)
				{
					_iCQCItemPctValid = value;
					NotifyChanged("ICQCItemPctValid");
				}
			}
		}
		public double ICQCItemRInValidQty
		{
			get { return _iCQCItemRInValidQty; }
			set
			{
				if (value != this._iCQCItemRInValidQty)
				{
					_iCQCItemRInValidQty = value;
					NotifyChanged("ICQCItemRInValidQty");
				}
			}
		}
		
        #endregion
    }
    #endregion
}