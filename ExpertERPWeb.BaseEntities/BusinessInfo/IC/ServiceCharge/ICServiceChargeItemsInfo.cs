using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICServiceChargeItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICServiceChargeItemsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class ICServiceChargeItemsInfo:BusinessObject
	{
		public ICServiceChargeItemsInfo()
		{
		}
		#region Variables
		protected int _iCServiceChargeItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ICServiceChargeID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ARPriceListID;
		protected int _fK_TXTaxCodeID;
		protected int _fK_ARDebtNoteItemID;
		protected String _iCServiceChargeItemSerialNo=String.Empty;
		protected bool _iCServiceChargeItemIsStkItm=true;
		protected String _iCServiceChargeItemType=String.Empty;
		protected String _iCServiceChargeItemDesc=String.Empty;
		protected String _iCServiceChargeItemUOM=String.Empty;
		protected String _iCServiceChargeItemStkUOM=String.Empty;
		protected double _iCServiceChargeItemFact;
		protected String _aRSalePriceCombo=String.Empty;
		protected double _iCServiceChargeItemUnitPrice;
		protected double _iCServiceChargeItemFUnitPrice;
		protected double _iCServiceChargeItemUnitCost;
		protected double _iCServiceChargeItemDiscPct;
		protected double _iCServiceChargeItemTxPct;
		protected double _iCServiceChargeItemQty;
		protected double _iCServiceChargeItemStkQty;
		protected double _iCServiceChargeItemRQty;
		protected double _iCServiceChargeItemRStkQty;
		protected double _iCServiceChargeItemPrice;
		protected double _iCServiceChargeItemFPrice;
		protected String _iCServiceChargeItemComment=String.Empty;
		protected double _iCServiceChargeItemUnitVol;
		protected double _iCServiceChargeItemUnitWeight;
		protected double _iCServiceChargeItemTxAmt;
		protected double _iCServiceChargeItemFTxAmt;
		protected double _iCServiceChargeItemDiscAmt;
		protected double _iCServiceChargeItemFDiscAmt;
		protected double _iCServiceChargeItemNetAmt;
		protected double _iCServiceChargeItemFNetAmt;
		protected double _iCServiceChargeItemAmtTot;
		protected double _iCServiceChargeItemFAmtTot;
		protected double _iCServiceChargeItemCostTot;
		protected String _iCServiceChargeItemStatus=DefaultStatus;
		protected double _iCServiceChargeItemAmt;
		protected double _iCServiceChargeItemCAmt;
		protected int _fK_ICShipmentItemID;
		protected double _iCServiceChargeItemReturnQty;
		protected int _fK_ARSOItemID;
		protected int _fK_ICShipmentID;
		protected int _fK_LOShpPlanID;
		protected int _fK_ARSOID;
		protected int _iCServiceChargeItemSortOrder;
		protected int _fK_GLDebitAccountID;
		protected int _fK_GLCreditAccountID;
		protected int _fK_GLDebitVATAccountID;
		protected int _fK_GLCreditVATAccountID;
		protected int _fK_ARLoanContractID;
		protected double _iCServiceChargeItemFeeAmtTotBeforeTax;
		protected double _iCServiceChargeInterestAmtTotBeforeTax;
		protected double _iCServiceChargeVATFeeInterestAmt;
		protected double _iCServiceChargeItemVATOriginalAmt;
		protected int _fK_LOCarAllocateItemID;
		protected int _fK_GLVoucherItemID;
		protected int _fK_ICReceiptFeeID;
		protected int _fK_ICShipmentFeeID;
		protected int _fK_GLCostCenterID;
		protected int _fK_GLProfitCenterID;
		protected double _iCServiceChargeItemRate;
		protected double _iCServiceChargeItemSupplierUnitPrice;
		protected double _iCServiceChargeItemSupplierFUnitPrice;
		protected String _iCServiceChargeItemFeeTypeCombo=String.Empty;
		protected double _iCServiceChargeItemSupplierPrice;
		protected double _iCServiceChargeItemSupplierFPrice;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		#endregion

		#region Public properties
		public int ICServiceChargeItemID
		{
			get{return _iCServiceChargeItemID;}
			set
			{
				if (value != this._iCServiceChargeItemID)
				{
				_iCServiceChargeItemID=value;
				NotifyChanged("ICServiceChargeItemID");
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
				_aAStatus=value;
				NotifyChanged("AAStatus");
				}
			}
		}
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
				_aASelected=value;
				NotifyChanged("AASelected");
				}
			}
		}
		public int FK_ICServiceChargeID
		{
			get{return _fK_ICServiceChargeID;}
			set
			{
				if (value != this._fK_ICServiceChargeID)
				{
				_fK_ICServiceChargeID=value;
				NotifyChanged("FK_ICServiceChargeID");
				}
			}
		}
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				NotifyChanged("FK_ICProductID");
				}
			}
		}
		public int FK_ICStockID
		{
			get{return _fK_ICStockID;}
			set
			{
				if (value != this._fK_ICStockID)
				{
				_fK_ICStockID=value;
				NotifyChanged("FK_ICStockID");
				}
			}
		}
		public int FK_ICStockSlotID
		{
			get{return _fK_ICStockSlotID;}
			set
			{
				if (value != this._fK_ICStockSlotID)
				{
				_fK_ICStockSlotID=value;
				NotifyChanged("FK_ICStockSlotID");
				}
			}
		}
		public int FK_ICProductTypeID
		{
			get{return _fK_ICProductTypeID;}
			set
			{
				if (value != this._fK_ICProductTypeID)
				{
				_fK_ICProductTypeID=value;
				NotifyChanged("FK_ICProductTypeID");
				}
			}
		}
		public int FK_ARPriceListID
		{
			get{return _fK_ARPriceListID;}
			set
			{
				if (value != this._fK_ARPriceListID)
				{
				_fK_ARPriceListID=value;
				NotifyChanged("FK_ARPriceListID");
				}
			}
		}
		public int FK_TXTaxCodeID
		{
			get{return _fK_TXTaxCodeID;}
			set
			{
				if (value != this._fK_TXTaxCodeID)
				{
				_fK_TXTaxCodeID=value;
				NotifyChanged("FK_TXTaxCodeID");
				}
			}
		}
		public int FK_ARDebtNoteItemID
		{
			get{return _fK_ARDebtNoteItemID;}
			set
			{
				if (value != this._fK_ARDebtNoteItemID)
				{
				_fK_ARDebtNoteItemID=value;
				NotifyChanged("FK_ARDebtNoteItemID");
				}
			}
		}
		public String ICServiceChargeItemSerialNo
		{
			get{return _iCServiceChargeItemSerialNo;}
			set
			{
				if (value != this._iCServiceChargeItemSerialNo)
				{
				_iCServiceChargeItemSerialNo=value;
				NotifyChanged("ICServiceChargeItemSerialNo");
				}
			}
		}
		public bool ICServiceChargeItemIsStkItm
		{
			get{return _iCServiceChargeItemIsStkItm;}
			set
			{
				if (value != this._iCServiceChargeItemIsStkItm)
				{
				_iCServiceChargeItemIsStkItm=value;
				NotifyChanged("ICServiceChargeItemIsStkItm");
				}
			}
		}
		public String ICServiceChargeItemType
		{
			get{return _iCServiceChargeItemType;}
			set
			{
				if (value != this._iCServiceChargeItemType)
				{
				_iCServiceChargeItemType=value;
				NotifyChanged("ICServiceChargeItemType");
				}
			}
		}
		public String ICServiceChargeItemDesc
		{
			get{return _iCServiceChargeItemDesc;}
			set
			{
				if (value != this._iCServiceChargeItemDesc)
				{
				_iCServiceChargeItemDesc=value;
				NotifyChanged("ICServiceChargeItemDesc");
				}
			}
		}
		public String ICServiceChargeItemUOM
		{
			get{return _iCServiceChargeItemUOM;}
			set
			{
				if (value != this._iCServiceChargeItemUOM)
				{
				_iCServiceChargeItemUOM=value;
				NotifyChanged("ICServiceChargeItemUOM");
				}
			}
		}
		public String ICServiceChargeItemStkUOM
		{
			get{return _iCServiceChargeItemStkUOM;}
			set
			{
				if (value != this._iCServiceChargeItemStkUOM)
				{
				_iCServiceChargeItemStkUOM=value;
				NotifyChanged("ICServiceChargeItemStkUOM");
				}
			}
		}
		public double ICServiceChargeItemFact
		{
			get{return _iCServiceChargeItemFact;}
			set
			{
				if (value != this._iCServiceChargeItemFact)
				{
				_iCServiceChargeItemFact=value;
				NotifyChanged("ICServiceChargeItemFact");
				}
			}
		}
		public String ARSalePriceCombo
		{
			get{return _aRSalePriceCombo;}
			set
			{
				if (value != this._aRSalePriceCombo)
				{
				_aRSalePriceCombo=value;
				NotifyChanged("ARSalePriceCombo");
				}
			}
		}
		public double ICServiceChargeItemUnitPrice
		{
			get{return _iCServiceChargeItemUnitPrice;}
			set
			{
				if (value != this._iCServiceChargeItemUnitPrice)
				{
				_iCServiceChargeItemUnitPrice=value;
				NotifyChanged("ICServiceChargeItemUnitPrice");
				}
			}
		}
		public double ICServiceChargeItemFUnitPrice
		{
			get{return _iCServiceChargeItemFUnitPrice;}
			set
			{
				if (value != this._iCServiceChargeItemFUnitPrice)
				{
				_iCServiceChargeItemFUnitPrice=value;
				NotifyChanged("ICServiceChargeItemFUnitPrice");
				}
			}
		}
		public double ICServiceChargeItemUnitCost
		{
			get{return _iCServiceChargeItemUnitCost;}
			set
			{
				if (value != this._iCServiceChargeItemUnitCost)
				{
				_iCServiceChargeItemUnitCost=value;
				NotifyChanged("ICServiceChargeItemUnitCost");
				}
			}
		}
		public double ICServiceChargeItemDiscPct
		{
			get{return _iCServiceChargeItemDiscPct;}
			set
			{
				if (value != this._iCServiceChargeItemDiscPct)
				{
				_iCServiceChargeItemDiscPct=value;
				NotifyChanged("ICServiceChargeItemDiscPct");
				}
			}
		}
		public double ICServiceChargeItemTxPct
		{
			get{return _iCServiceChargeItemTxPct;}
			set
			{
				if (value != this._iCServiceChargeItemTxPct)
				{
				_iCServiceChargeItemTxPct=value;
				NotifyChanged("ICServiceChargeItemTxPct");
				}
			}
		}
		public double ICServiceChargeItemQty
		{
			get{return _iCServiceChargeItemQty;}
			set
			{
				if (value != this._iCServiceChargeItemQty)
				{
				_iCServiceChargeItemQty=value;
				NotifyChanged("ICServiceChargeItemQty");
				}
			}
		}
		public double ICServiceChargeItemStkQty
		{
			get{return _iCServiceChargeItemStkQty;}
			set
			{
				if (value != this._iCServiceChargeItemStkQty)
				{
				_iCServiceChargeItemStkQty=value;
				NotifyChanged("ICServiceChargeItemStkQty");
				}
			}
		}
		public double ICServiceChargeItemRQty
		{
			get{return _iCServiceChargeItemRQty;}
			set
			{
				if (value != this._iCServiceChargeItemRQty)
				{
				_iCServiceChargeItemRQty=value;
				NotifyChanged("ICServiceChargeItemRQty");
				}
			}
		}
		public double ICServiceChargeItemRStkQty
		{
			get{return _iCServiceChargeItemRStkQty;}
			set
			{
				if (value != this._iCServiceChargeItemRStkQty)
				{
				_iCServiceChargeItemRStkQty=value;
				NotifyChanged("ICServiceChargeItemRStkQty");
				}
			}
		}
		public double ICServiceChargeItemPrice
		{
			get{return _iCServiceChargeItemPrice;}
			set
			{
				if (value != this._iCServiceChargeItemPrice)
				{
				_iCServiceChargeItemPrice=value;
				NotifyChanged("ICServiceChargeItemPrice");
				}
			}
		}
		public double ICServiceChargeItemFPrice
		{
			get{return _iCServiceChargeItemFPrice;}
			set
			{
				if (value != this._iCServiceChargeItemFPrice)
				{
				_iCServiceChargeItemFPrice=value;
				NotifyChanged("ICServiceChargeItemFPrice");
				}
			}
		}
		public String ICServiceChargeItemComment
		{
			get{return _iCServiceChargeItemComment;}
			set
			{
				if (value != this._iCServiceChargeItemComment)
				{
				_iCServiceChargeItemComment=value;
				NotifyChanged("ICServiceChargeItemComment");
				}
			}
		}
		public double ICServiceChargeItemUnitVol
		{
			get{return _iCServiceChargeItemUnitVol;}
			set
			{
				if (value != this._iCServiceChargeItemUnitVol)
				{
				_iCServiceChargeItemUnitVol=value;
				NotifyChanged("ICServiceChargeItemUnitVol");
				}
			}
		}
		public double ICServiceChargeItemUnitWeight
		{
			get{return _iCServiceChargeItemUnitWeight;}
			set
			{
				if (value != this._iCServiceChargeItemUnitWeight)
				{
				_iCServiceChargeItemUnitWeight=value;
				NotifyChanged("ICServiceChargeItemUnitWeight");
				}
			}
		}
		public double ICServiceChargeItemTxAmt
		{
			get{return _iCServiceChargeItemTxAmt;}
			set
			{
				if (value != this._iCServiceChargeItemTxAmt)
				{
				_iCServiceChargeItemTxAmt=value;
				NotifyChanged("ICServiceChargeItemTxAmt");
				}
			}
		}
		public double ICServiceChargeItemFTxAmt
		{
			get{return _iCServiceChargeItemFTxAmt;}
			set
			{
				if (value != this._iCServiceChargeItemFTxAmt)
				{
				_iCServiceChargeItemFTxAmt=value;
				NotifyChanged("ICServiceChargeItemFTxAmt");
				}
			}
		}
		public double ICServiceChargeItemDiscAmt
		{
			get{return _iCServiceChargeItemDiscAmt;}
			set
			{
				if (value != this._iCServiceChargeItemDiscAmt)
				{
				_iCServiceChargeItemDiscAmt=value;
				NotifyChanged("ICServiceChargeItemDiscAmt");
				}
			}
		}
		public double ICServiceChargeItemFDiscAmt
		{
			get{return _iCServiceChargeItemFDiscAmt;}
			set
			{
				if (value != this._iCServiceChargeItemFDiscAmt)
				{
				_iCServiceChargeItemFDiscAmt=value;
				NotifyChanged("ICServiceChargeItemFDiscAmt");
				}
			}
		}
		public double ICServiceChargeItemNetAmt
		{
			get{return _iCServiceChargeItemNetAmt;}
			set
			{
				if (value != this._iCServiceChargeItemNetAmt)
				{
				_iCServiceChargeItemNetAmt=value;
				NotifyChanged("ICServiceChargeItemNetAmt");
				}
			}
		}
		public double ICServiceChargeItemFNetAmt
		{
			get{return _iCServiceChargeItemFNetAmt;}
			set
			{
				if (value != this._iCServiceChargeItemFNetAmt)
				{
				_iCServiceChargeItemFNetAmt=value;
				NotifyChanged("ICServiceChargeItemFNetAmt");
				}
			}
		}
		public double ICServiceChargeItemAmtTot
		{
			get{return _iCServiceChargeItemAmtTot;}
			set
			{
				if (value != this._iCServiceChargeItemAmtTot)
				{
				_iCServiceChargeItemAmtTot=value;
				NotifyChanged("ICServiceChargeItemAmtTot");
				}
			}
		}
		public double ICServiceChargeItemFAmtTot
		{
			get{return _iCServiceChargeItemFAmtTot;}
			set
			{
				if (value != this._iCServiceChargeItemFAmtTot)
				{
				_iCServiceChargeItemFAmtTot=value;
				NotifyChanged("ICServiceChargeItemFAmtTot");
				}
			}
		}
		public double ICServiceChargeItemCostTot
		{
			get{return _iCServiceChargeItemCostTot;}
			set
			{
				if (value != this._iCServiceChargeItemCostTot)
				{
				_iCServiceChargeItemCostTot=value;
				NotifyChanged("ICServiceChargeItemCostTot");
				}
			}
		}
		public String ICServiceChargeItemStatus
		{
			get{return _iCServiceChargeItemStatus;}
			set
			{
				if (value != this._iCServiceChargeItemStatus)
				{
				_iCServiceChargeItemStatus=value;
				NotifyChanged("ICServiceChargeItemStatus");
				}
			}
		}
		public double ICServiceChargeItemAmt
		{
			get{return _iCServiceChargeItemAmt;}
			set
			{
				if (value != this._iCServiceChargeItemAmt)
				{
				_iCServiceChargeItemAmt=value;
				NotifyChanged("ICServiceChargeItemAmt");
				}
			}
		}
		public double ICServiceChargeItemCAmt
		{
			get{return _iCServiceChargeItemCAmt;}
			set
			{
				if (value != this._iCServiceChargeItemCAmt)
				{
				_iCServiceChargeItemCAmt=value;
				NotifyChanged("ICServiceChargeItemCAmt");
				}
			}
		}
		public int FK_ICShipmentItemID
		{
			get{return _fK_ICShipmentItemID;}
			set
			{
				if (value != this._fK_ICShipmentItemID)
				{
				_fK_ICShipmentItemID=value;
				NotifyChanged("FK_ICShipmentItemID");
				}
			}
		}
		public double ICServiceChargeItemReturnQty
		{
			get{return _iCServiceChargeItemReturnQty;}
			set
			{
				if (value != this._iCServiceChargeItemReturnQty)
				{
				_iCServiceChargeItemReturnQty=value;
				NotifyChanged("ICServiceChargeItemReturnQty");
				}
			}
		}
		public int FK_ARSOItemID
		{
			get{return _fK_ARSOItemID;}
			set
			{
				if (value != this._fK_ARSOItemID)
				{
				_fK_ARSOItemID=value;
				NotifyChanged("FK_ARSOItemID");
				}
			}
		}
		public int FK_ICShipmentID
		{
			get{return _fK_ICShipmentID;}
			set
			{
				if (value != this._fK_ICShipmentID)
				{
				_fK_ICShipmentID=value;
				NotifyChanged("FK_ICShipmentID");
				}
			}
		}
		public int FK_LOShpPlanID
		{
			get{return _fK_LOShpPlanID;}
			set
			{
				if (value != this._fK_LOShpPlanID)
				{
				_fK_LOShpPlanID=value;
				NotifyChanged("FK_LOShpPlanID");
				}
			}
		}
		public int FK_ARSOID
		{
			get{return _fK_ARSOID;}
			set
			{
				if (value != this._fK_ARSOID)
				{
				_fK_ARSOID=value;
				NotifyChanged("FK_ARSOID");
				}
			}
		}
		public int ICServiceChargeItemSortOrder
		{
			get{return _iCServiceChargeItemSortOrder;}
			set
			{
				if (value != this._iCServiceChargeItemSortOrder)
				{
				_iCServiceChargeItemSortOrder=value;
				NotifyChanged("ICServiceChargeItemSortOrder");
				}
			}
		}
		public int FK_GLDebitAccountID
		{
			get{return _fK_GLDebitAccountID;}
			set
			{
				if (value != this._fK_GLDebitAccountID)
				{
				_fK_GLDebitAccountID=value;
				NotifyChanged("FK_GLDebitAccountID");
				}
			}
		}
		public int FK_GLCreditAccountID
		{
			get{return _fK_GLCreditAccountID;}
			set
			{
				if (value != this._fK_GLCreditAccountID)
				{
				_fK_GLCreditAccountID=value;
				NotifyChanged("FK_GLCreditAccountID");
				}
			}
		}
		public int FK_GLDebitVATAccountID
		{
			get{return _fK_GLDebitVATAccountID;}
			set
			{
				if (value != this._fK_GLDebitVATAccountID)
				{
				_fK_GLDebitVATAccountID=value;
				NotifyChanged("FK_GLDebitVATAccountID");
				}
			}
		}
		public int FK_GLCreditVATAccountID
		{
			get{return _fK_GLCreditVATAccountID;}
			set
			{
				if (value != this._fK_GLCreditVATAccountID)
				{
				_fK_GLCreditVATAccountID=value;
				NotifyChanged("FK_GLCreditVATAccountID");
				}
			}
		}
		public int FK_ARLoanContractID
		{
			get{return _fK_ARLoanContractID;}
			set
			{
				if (value != this._fK_ARLoanContractID)
				{
				_fK_ARLoanContractID=value;
				NotifyChanged("FK_ARLoanContractID");
				}
			}
		}
		public double ICServiceChargeItemFeeAmtTotBeforeTax
		{
			get{return _iCServiceChargeItemFeeAmtTotBeforeTax;}
			set
			{
				if (value != this._iCServiceChargeItemFeeAmtTotBeforeTax)
				{
				_iCServiceChargeItemFeeAmtTotBeforeTax=value;
				NotifyChanged("ICServiceChargeItemFeeAmtTotBeforeTax");
				}
			}
		}
		public double ICServiceChargeInterestAmtTotBeforeTax
		{
			get{return _iCServiceChargeInterestAmtTotBeforeTax;}
			set
			{
				if (value != this._iCServiceChargeInterestAmtTotBeforeTax)
				{
				_iCServiceChargeInterestAmtTotBeforeTax=value;
				NotifyChanged("ICServiceChargeInterestAmtTotBeforeTax");
				}
			}
		}
		public double ICServiceChargeVATFeeInterestAmt
		{
			get{return _iCServiceChargeVATFeeInterestAmt;}
			set
			{
				if (value != this._iCServiceChargeVATFeeInterestAmt)
				{
				_iCServiceChargeVATFeeInterestAmt=value;
				NotifyChanged("ICServiceChargeVATFeeInterestAmt");
				}
			}
		}
		public double ICServiceChargeItemVATOriginalAmt
		{
			get{return _iCServiceChargeItemVATOriginalAmt;}
			set
			{
				if (value != this._iCServiceChargeItemVATOriginalAmt)
				{
				_iCServiceChargeItemVATOriginalAmt=value;
				NotifyChanged("ICServiceChargeItemVATOriginalAmt");
				}
			}
		}
		public int FK_LOCarAllocateItemID
		{
			get{return _fK_LOCarAllocateItemID;}
			set
			{
				if (value != this._fK_LOCarAllocateItemID)
				{
				_fK_LOCarAllocateItemID=value;
				NotifyChanged("FK_LOCarAllocateItemID");
				}
			}
		}
		public int FK_GLVoucherItemID
		{
			get{return _fK_GLVoucherItemID;}
			set
			{
				if (value != this._fK_GLVoucherItemID)
				{
				_fK_GLVoucherItemID=value;
				NotifyChanged("FK_GLVoucherItemID");
				}
			}
		}
		public int FK_ICReceiptFeeID
		{
			get{return _fK_ICReceiptFeeID;}
			set
			{
				if (value != this._fK_ICReceiptFeeID)
				{
				_fK_ICReceiptFeeID=value;
				NotifyChanged("FK_ICReceiptFeeID");
				}
			}
		}
		public int FK_ICShipmentFeeID
		{
			get{return _fK_ICShipmentFeeID;}
			set
			{
				if (value != this._fK_ICShipmentFeeID)
				{
				_fK_ICShipmentFeeID=value;
				NotifyChanged("FK_ICShipmentFeeID");
				}
			}
		}
		public int FK_GLCostCenterID
		{
			get{return _fK_GLCostCenterID;}
			set
			{
				if (value != this._fK_GLCostCenterID)
				{
				_fK_GLCostCenterID=value;
				NotifyChanged("FK_GLCostCenterID");
				}
			}
		}
		public int FK_GLProfitCenterID
		{
			get{return _fK_GLProfitCenterID;}
			set
			{
				if (value != this._fK_GLProfitCenterID)
				{
				_fK_GLProfitCenterID=value;
				NotifyChanged("FK_GLProfitCenterID");
				}
			}
		}
		public double ICServiceChargeItemRate
		{
			get{return _iCServiceChargeItemRate;}
			set
			{
				if (value != this._iCServiceChargeItemRate)
				{
				_iCServiceChargeItemRate=value;
				NotifyChanged("ICServiceChargeItemRate");
				}
			}
		}
		public double ICServiceChargeItemSupplierUnitPrice
		{
			get{return _iCServiceChargeItemSupplierUnitPrice;}
			set
			{
				if (value != this._iCServiceChargeItemSupplierUnitPrice)
				{
				_iCServiceChargeItemSupplierUnitPrice=value;
				NotifyChanged("ICServiceChargeItemSupplierUnitPrice");
				}
			}
		}
		public double ICServiceChargeItemSupplierFUnitPrice
		{
			get{return _iCServiceChargeItemSupplierFUnitPrice;}
			set
			{
				if (value != this._iCServiceChargeItemSupplierFUnitPrice)
				{
				_iCServiceChargeItemSupplierFUnitPrice=value;
				NotifyChanged("ICServiceChargeItemSupplierFUnitPrice");
				}
			}
		}
		public String ICServiceChargeItemFeeTypeCombo
		{
			get{return _iCServiceChargeItemFeeTypeCombo;}
			set
			{
				if (value != this._iCServiceChargeItemFeeTypeCombo)
				{
				_iCServiceChargeItemFeeTypeCombo=value;
				NotifyChanged("ICServiceChargeItemFeeTypeCombo");
				}
			}
		}
		public double ICServiceChargeItemSupplierPrice
		{
			get{return _iCServiceChargeItemSupplierPrice;}
			set
			{
				if (value != this._iCServiceChargeItemSupplierPrice)
				{
				_iCServiceChargeItemSupplierPrice=value;
				NotifyChanged("ICServiceChargeItemSupplierPrice");
				}
			}
		}
		public double ICServiceChargeItemSupplierFPrice
		{
			get{return _iCServiceChargeItemSupplierFPrice;}
			set
			{
				if (value != this._iCServiceChargeItemSupplierFPrice)
				{
				_iCServiceChargeItemSupplierFPrice=value;
				NotifyChanged("ICServiceChargeItemSupplierFPrice");
				}
			}
		}
		public int FK_ICUOMID
		{
			get{return _fK_ICUOMID;}
			set
			{
				if (value != this._fK_ICUOMID)
				{
				_fK_ICUOMID=value;
				NotifyChanged("FK_ICUOMID");
				}
			}
		}
		public int FK_ICStkUOMID
		{
			get{return _fK_ICStkUOMID;}
			set
			{
				if (value != this._fK_ICStkUOMID)
				{
				_fK_ICStkUOMID=value;
				NotifyChanged("FK_ICStkUOMID");
				}
			}
		}
		#endregion
	}
	#endregion
}