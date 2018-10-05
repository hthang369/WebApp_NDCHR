 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICRequestReceiptItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.4)
    //Class: ICRequestReceiptItemsInfo
    //Created Date: Friday, 16 Jun 2017
    //-----------------------------------------------------------

    public class ICRequestReceiptItemsInfo : BusinessObject
    {
        public ICRequestReceiptItemsInfo()
        {
        }
        #region Variables
		protected int _iCRequestReceiptItemID;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected int _fK_ICRequestReceiptID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ICProductTypeID;
		protected int _fK_TXTaxCodeID;
		protected String _iCRequestReceiptItemSerialNo = String.Empty;
		protected String _iCRequestReceiptItemType = String.Empty;
		protected bool _iCRequestReceiptItemIsStkItm = true;
		protected String _iCRequestReceiptItemDesc = String.Empty;
		protected double _iCRequestReceiptItemFact;
		protected double _iCRequestReceiptItemUnitPrice;
		protected double _iCRequestReceiptItemUnitCost;
		protected double _iCRequestReceiptItemDiscPct;
		protected double _iCRequestReceiptItemTxPct;
		protected double _iCRequestReceiptItemQty;
		protected double _iCRequestReceiptItemStkQty;
		protected double _iCRequestReceiptItemRQty;
		protected double _iCRequestReceiptItemRStkQty;
		protected double _iCRequestReceiptItemPrice;
		protected String _iCRequestReceiptItemComment = String.Empty;
		protected double _iCRequestReceiptItemUnitVol;
		protected double _iCRequestReceiptItemUnitWeight;
		protected double _iCRequestReceiptItemTxAmt;
		protected double _iCRequestReceiptItemDiscAmt;
		protected double _iCRequestReceiptItemNetAmt;
		protected double _iCRequestReceiptItemAmtTot;
		protected double _iCRequestReceiptItemCostTot;
		protected String _iCRequestReceiptItemStatus = DefaultStatus;
		protected double _iCRequestReceiptItemAmt;
		protected double _iCRequestReceiptItemCAmt;
		protected double _iCRequestReceiptItemWTot;
		protected double _iCRequestReceiptItemVTot;
		protected int _iCRequestReceiptItemSortOrder;
		protected int _fK_PPPhaseCfgID;
		protected Nullable<DateTime> _iCRequestReceiptItemExpireDate;
		protected int _fK_ICProductParentID;
		protected double _iCRequestReceiptItemFUnitPrice;
		protected double _iCRequestReceiptItemFPrice;
		protected double _iCRequestReceiptItemFTxAmt;
		protected double _iCRequestReceiptItemFNetAmt;
		protected double _iCRequestReceiptItemFAmtTot;
		protected double _iCRequestReceiptItemFImpTxAmt;
		protected int _fK_GLDebitAccountID;
		protected int _fK_GLCreditAccountID;
		protected int _fK_GLDebitVATAccountID;
		protected int _fK_GLCreditVATAccountID;
		protected double _iCRequestReceiptItemAllocateLife;
		protected int _fK_FAAssetID;
		protected int _fK_HRDepartmentID;
		protected double _iCRequestReceiptItemAssetLife;
		protected String _iCRequestReceiptItemLotNo = String.Empty;
		protected double _iCRequestReceiptItemDriverPmtAmt;
		protected double _iCRequestReceiptItemDriverPmtPct;
		protected bool _iCRequestReceiptItemIsValidInv = true;
		protected double _iCRequestReceiptItemAllocateQty;
		protected double _iCRequestReceiptItemRequestQty;
		protected String _iCPackageLockTypeCombo = String.Empty;
		protected bool _iCRequestReceiptItemIsCostingItemCheck = true;
		protected int _fK_GLCostDistID;
		protected int _fK_GLCostCenterID;
		protected int _fK_GLTranCfgID;
		protected double _iCRequestReceiptItemTransferRQty;
		protected String _iCRequestReceiptItemTransferStatusCombo = DefaultStatus;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected String _iCRequestReceiptItemQCStatusCombo = DefaultStatus;
		protected double _iCRequestReceiptItemOrgQty;
		protected double _iCRequestReceiptItemExcQty;
		protected int _fK_ICOrgUOMID;
		protected double _iCRequestReceiptItemCQty;
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
		protected int _fK_PPCostCenterID;
		
        #endregion

        #region Public properties
		public int ICRequestReceiptItemID
		{
			get { return _iCRequestReceiptItemID; }
			set
			{
				if (value != this._iCRequestReceiptItemID)
				{
					_iCRequestReceiptItemID = value;
					NotifyChanged("ICRequestReceiptItemID");
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
		public int FK_ICRequestReceiptID
		{
			get { return _fK_ICRequestReceiptID; }
			set
			{
				if (value != this._fK_ICRequestReceiptID)
				{
					_fK_ICRequestReceiptID = value;
					NotifyChanged("FK_ICRequestReceiptID");
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
		public String ICRequestReceiptItemSerialNo
		{
			get { return _iCRequestReceiptItemSerialNo; }
			set
			{
				if (value != this._iCRequestReceiptItemSerialNo)
				{
					_iCRequestReceiptItemSerialNo = value;
					NotifyChanged("ICRequestReceiptItemSerialNo");
				}
			}
		}
		public String ICRequestReceiptItemType
		{
			get { return _iCRequestReceiptItemType; }
			set
			{
				if (value != this._iCRequestReceiptItemType)
				{
					_iCRequestReceiptItemType = value;
					NotifyChanged("ICRequestReceiptItemType");
				}
			}
		}
		public bool ICRequestReceiptItemIsStkItm
		{
			get { return _iCRequestReceiptItemIsStkItm; }
			set
			{
				if (value != this._iCRequestReceiptItemIsStkItm)
				{
					_iCRequestReceiptItemIsStkItm = value;
					NotifyChanged("ICRequestReceiptItemIsStkItm");
				}
			}
		}
		public String ICRequestReceiptItemDesc
		{
			get { return _iCRequestReceiptItemDesc; }
			set
			{
				if (value != this._iCRequestReceiptItemDesc)
				{
					_iCRequestReceiptItemDesc = value;
					NotifyChanged("ICRequestReceiptItemDesc");
				}
			}
		}
		public double ICRequestReceiptItemFact
		{
			get { return _iCRequestReceiptItemFact; }
			set
			{
				if (value != this._iCRequestReceiptItemFact)
				{
					_iCRequestReceiptItemFact = value;
					NotifyChanged("ICRequestReceiptItemFact");
				}
			}
		}
		public double ICRequestReceiptItemUnitPrice
		{
			get { return _iCRequestReceiptItemUnitPrice; }
			set
			{
				if (value != this._iCRequestReceiptItemUnitPrice)
				{
					_iCRequestReceiptItemUnitPrice = value;
					NotifyChanged("ICRequestReceiptItemUnitPrice");
				}
			}
		}
		public double ICRequestReceiptItemUnitCost
		{
			get { return _iCRequestReceiptItemUnitCost; }
			set
			{
				if (value != this._iCRequestReceiptItemUnitCost)
				{
					_iCRequestReceiptItemUnitCost = value;
					NotifyChanged("ICRequestReceiptItemUnitCost");
				}
			}
		}
		public double ICRequestReceiptItemDiscPct
		{
			get { return _iCRequestReceiptItemDiscPct; }
			set
			{
				if (value != this._iCRequestReceiptItemDiscPct)
				{
					_iCRequestReceiptItemDiscPct = value;
					NotifyChanged("ICRequestReceiptItemDiscPct");
				}
			}
		}
		public double ICRequestReceiptItemTxPct
		{
			get { return _iCRequestReceiptItemTxPct; }
			set
			{
				if (value != this._iCRequestReceiptItemTxPct)
				{
					_iCRequestReceiptItemTxPct = value;
					NotifyChanged("ICRequestReceiptItemTxPct");
				}
			}
		}
		public double ICRequestReceiptItemQty
		{
			get { return _iCRequestReceiptItemQty; }
			set
			{
				if (value != this._iCRequestReceiptItemQty)
				{
					_iCRequestReceiptItemQty = value;
					NotifyChanged("ICRequestReceiptItemQty");
				}
			}
		}
		public double ICRequestReceiptItemStkQty
		{
			get { return _iCRequestReceiptItemStkQty; }
			set
			{
				if (value != this._iCRequestReceiptItemStkQty)
				{
					_iCRequestReceiptItemStkQty = value;
					NotifyChanged("ICRequestReceiptItemStkQty");
				}
			}
		}
		public double ICRequestReceiptItemRQty
		{
			get { return _iCRequestReceiptItemRQty; }
			set
			{
				if (value != this._iCRequestReceiptItemRQty)
				{
					_iCRequestReceiptItemRQty = value;
					NotifyChanged("ICRequestReceiptItemRQty");
				}
			}
		}
		public double ICRequestReceiptItemRStkQty
		{
			get { return _iCRequestReceiptItemRStkQty; }
			set
			{
				if (value != this._iCRequestReceiptItemRStkQty)
				{
					_iCRequestReceiptItemRStkQty = value;
					NotifyChanged("ICRequestReceiptItemRStkQty");
				}
			}
		}
		public double ICRequestReceiptItemPrice
		{
			get { return _iCRequestReceiptItemPrice; }
			set
			{
				if (value != this._iCRequestReceiptItemPrice)
				{
					_iCRequestReceiptItemPrice = value;
					NotifyChanged("ICRequestReceiptItemPrice");
				}
			}
		}
		public String ICRequestReceiptItemComment
		{
			get { return _iCRequestReceiptItemComment; }
			set
			{
				if (value != this._iCRequestReceiptItemComment)
				{
					_iCRequestReceiptItemComment = value;
					NotifyChanged("ICRequestReceiptItemComment");
				}
			}
		}
		public double ICRequestReceiptItemUnitVol
		{
			get { return _iCRequestReceiptItemUnitVol; }
			set
			{
				if (value != this._iCRequestReceiptItemUnitVol)
				{
					_iCRequestReceiptItemUnitVol = value;
					NotifyChanged("ICRequestReceiptItemUnitVol");
				}
			}
		}
		public double ICRequestReceiptItemUnitWeight
		{
			get { return _iCRequestReceiptItemUnitWeight; }
			set
			{
				if (value != this._iCRequestReceiptItemUnitWeight)
				{
					_iCRequestReceiptItemUnitWeight = value;
					NotifyChanged("ICRequestReceiptItemUnitWeight");
				}
			}
		}
		public double ICRequestReceiptItemTxAmt
		{
			get { return _iCRequestReceiptItemTxAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemTxAmt)
				{
					_iCRequestReceiptItemTxAmt = value;
					NotifyChanged("ICRequestReceiptItemTxAmt");
				}
			}
		}
		public double ICRequestReceiptItemDiscAmt
		{
			get { return _iCRequestReceiptItemDiscAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemDiscAmt)
				{
					_iCRequestReceiptItemDiscAmt = value;
					NotifyChanged("ICRequestReceiptItemDiscAmt");
				}
			}
		}
		public double ICRequestReceiptItemNetAmt
		{
			get { return _iCRequestReceiptItemNetAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemNetAmt)
				{
					_iCRequestReceiptItemNetAmt = value;
					NotifyChanged("ICRequestReceiptItemNetAmt");
				}
			}
		}
		public double ICRequestReceiptItemAmtTot
		{
			get { return _iCRequestReceiptItemAmtTot; }
			set
			{
				if (value != this._iCRequestReceiptItemAmtTot)
				{
					_iCRequestReceiptItemAmtTot = value;
					NotifyChanged("ICRequestReceiptItemAmtTot");
				}
			}
		}
		public double ICRequestReceiptItemCostTot
		{
			get { return _iCRequestReceiptItemCostTot; }
			set
			{
				if (value != this._iCRequestReceiptItemCostTot)
				{
					_iCRequestReceiptItemCostTot = value;
					NotifyChanged("ICRequestReceiptItemCostTot");
				}
			}
		}
		public String ICRequestReceiptItemStatus
		{
			get { return _iCRequestReceiptItemStatus; }
			set
			{
				if (value != this._iCRequestReceiptItemStatus)
				{
					_iCRequestReceiptItemStatus = value;
					NotifyChanged("ICRequestReceiptItemStatus");
				}
			}
		}
		public double ICRequestReceiptItemAmt
		{
			get { return _iCRequestReceiptItemAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemAmt)
				{
					_iCRequestReceiptItemAmt = value;
					NotifyChanged("ICRequestReceiptItemAmt");
				}
			}
		}
		public double ICRequestReceiptItemCAmt
		{
			get { return _iCRequestReceiptItemCAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemCAmt)
				{
					_iCRequestReceiptItemCAmt = value;
					NotifyChanged("ICRequestReceiptItemCAmt");
				}
			}
		}
		public double ICRequestReceiptItemWTot
		{
			get { return _iCRequestReceiptItemWTot; }
			set
			{
				if (value != this._iCRequestReceiptItemWTot)
				{
					_iCRequestReceiptItemWTot = value;
					NotifyChanged("ICRequestReceiptItemWTot");
				}
			}
		}
		public double ICRequestReceiptItemVTot
		{
			get { return _iCRequestReceiptItemVTot; }
			set
			{
				if (value != this._iCRequestReceiptItemVTot)
				{
					_iCRequestReceiptItemVTot = value;
					NotifyChanged("ICRequestReceiptItemVTot");
				}
			}
		}
		public int ICRequestReceiptItemSortOrder
		{
			get { return _iCRequestReceiptItemSortOrder; }
			set
			{
				if (value != this._iCRequestReceiptItemSortOrder)
				{
					_iCRequestReceiptItemSortOrder = value;
					NotifyChanged("ICRequestReceiptItemSortOrder");
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
		public Nullable<DateTime> ICRequestReceiptItemExpireDate
		{
			get { return _iCRequestReceiptItemExpireDate; }
			set
			{
				if (value != this._iCRequestReceiptItemExpireDate)
				{
					_iCRequestReceiptItemExpireDate = value;
					NotifyChanged("ICRequestReceiptItemExpireDate");
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
		public double ICRequestReceiptItemFUnitPrice
		{
			get { return _iCRequestReceiptItemFUnitPrice; }
			set
			{
				if (value != this._iCRequestReceiptItemFUnitPrice)
				{
					_iCRequestReceiptItemFUnitPrice = value;
					NotifyChanged("ICRequestReceiptItemFUnitPrice");
				}
			}
		}
		public double ICRequestReceiptItemFPrice
		{
			get { return _iCRequestReceiptItemFPrice; }
			set
			{
				if (value != this._iCRequestReceiptItemFPrice)
				{
					_iCRequestReceiptItemFPrice = value;
					NotifyChanged("ICRequestReceiptItemFPrice");
				}
			}
		}
		public double ICRequestReceiptItemFTxAmt
		{
			get { return _iCRequestReceiptItemFTxAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemFTxAmt)
				{
					_iCRequestReceiptItemFTxAmt = value;
					NotifyChanged("ICRequestReceiptItemFTxAmt");
				}
			}
		}
		public double ICRequestReceiptItemFNetAmt
		{
			get { return _iCRequestReceiptItemFNetAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemFNetAmt)
				{
					_iCRequestReceiptItemFNetAmt = value;
					NotifyChanged("ICRequestReceiptItemFNetAmt");
				}
			}
		}
		public double ICRequestReceiptItemFAmtTot
		{
			get { return _iCRequestReceiptItemFAmtTot; }
			set
			{
				if (value != this._iCRequestReceiptItemFAmtTot)
				{
					_iCRequestReceiptItemFAmtTot = value;
					NotifyChanged("ICRequestReceiptItemFAmtTot");
				}
			}
		}
		public double ICRequestReceiptItemFImpTxAmt
		{
			get { return _iCRequestReceiptItemFImpTxAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemFImpTxAmt)
				{
					_iCRequestReceiptItemFImpTxAmt = value;
					NotifyChanged("ICRequestReceiptItemFImpTxAmt");
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
		public double ICRequestReceiptItemAllocateLife
		{
			get { return _iCRequestReceiptItemAllocateLife; }
			set
			{
				if (value != this._iCRequestReceiptItemAllocateLife)
				{
					_iCRequestReceiptItemAllocateLife = value;
					NotifyChanged("ICRequestReceiptItemAllocateLife");
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
		public double ICRequestReceiptItemAssetLife
		{
			get { return _iCRequestReceiptItemAssetLife; }
			set
			{
				if (value != this._iCRequestReceiptItemAssetLife)
				{
					_iCRequestReceiptItemAssetLife = value;
					NotifyChanged("ICRequestReceiptItemAssetLife");
				}
			}
		}
		public String ICRequestReceiptItemLotNo
		{
			get { return _iCRequestReceiptItemLotNo; }
			set
			{
				if (value != this._iCRequestReceiptItemLotNo)
				{
					_iCRequestReceiptItemLotNo = value;
					NotifyChanged("ICRequestReceiptItemLotNo");
				}
			}
		}
		public double ICRequestReceiptItemDriverPmtAmt
		{
			get { return _iCRequestReceiptItemDriverPmtAmt; }
			set
			{
				if (value != this._iCRequestReceiptItemDriverPmtAmt)
				{
					_iCRequestReceiptItemDriverPmtAmt = value;
					NotifyChanged("ICRequestReceiptItemDriverPmtAmt");
				}
			}
		}
		public double ICRequestReceiptItemDriverPmtPct
		{
			get { return _iCRequestReceiptItemDriverPmtPct; }
			set
			{
				if (value != this._iCRequestReceiptItemDriverPmtPct)
				{
					_iCRequestReceiptItemDriverPmtPct = value;
					NotifyChanged("ICRequestReceiptItemDriverPmtPct");
				}
			}
		}
		public bool ICRequestReceiptItemIsValidInv
		{
			get { return _iCRequestReceiptItemIsValidInv; }
			set
			{
				if (value != this._iCRequestReceiptItemIsValidInv)
				{
					_iCRequestReceiptItemIsValidInv = value;
					NotifyChanged("ICRequestReceiptItemIsValidInv");
				}
			}
		}
		public double ICRequestReceiptItemAllocateQty
		{
			get { return _iCRequestReceiptItemAllocateQty; }
			set
			{
				if (value != this._iCRequestReceiptItemAllocateQty)
				{
					_iCRequestReceiptItemAllocateQty = value;
					NotifyChanged("ICRequestReceiptItemAllocateQty");
				}
			}
		}
		public double ICRequestReceiptItemRequestQty
		{
			get { return _iCRequestReceiptItemRequestQty; }
			set
			{
				if (value != this._iCRequestReceiptItemRequestQty)
				{
					_iCRequestReceiptItemRequestQty = value;
					NotifyChanged("ICRequestReceiptItemRequestQty");
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
		public bool ICRequestReceiptItemIsCostingItemCheck
		{
			get { return _iCRequestReceiptItemIsCostingItemCheck; }
			set
			{
				if (value != this._iCRequestReceiptItemIsCostingItemCheck)
				{
					_iCRequestReceiptItemIsCostingItemCheck = value;
					NotifyChanged("ICRequestReceiptItemIsCostingItemCheck");
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
		public double ICRequestReceiptItemTransferRQty
		{
			get { return _iCRequestReceiptItemTransferRQty; }
			set
			{
				if (value != this._iCRequestReceiptItemTransferRQty)
				{
					_iCRequestReceiptItemTransferRQty = value;
					NotifyChanged("ICRequestReceiptItemTransferRQty");
				}
			}
		}
		public String ICRequestReceiptItemTransferStatusCombo
		{
			get { return _iCRequestReceiptItemTransferStatusCombo; }
			set
			{
				if (value != this._iCRequestReceiptItemTransferStatusCombo)
				{
					_iCRequestReceiptItemTransferStatusCombo = value;
					NotifyChanged("ICRequestReceiptItemTransferStatusCombo");
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
		public String ICRequestReceiptItemQCStatusCombo
		{
			get { return _iCRequestReceiptItemQCStatusCombo; }
			set
			{
				if (value != this._iCRequestReceiptItemQCStatusCombo)
				{
					_iCRequestReceiptItemQCStatusCombo = value;
					NotifyChanged("ICRequestReceiptItemQCStatusCombo");
				}
			}
		}
		public double ICRequestReceiptItemOrgQty
		{
			get { return _iCRequestReceiptItemOrgQty; }
			set
			{
				if (value != this._iCRequestReceiptItemOrgQty)
				{
					_iCRequestReceiptItemOrgQty = value;
					NotifyChanged("ICRequestReceiptItemOrgQty");
				}
			}
		}
		public double ICRequestReceiptItemExcQty
		{
			get { return _iCRequestReceiptItemExcQty; }
			set
			{
				if (value != this._iCRequestReceiptItemExcQty)
				{
					_iCRequestReceiptItemExcQty = value;
					NotifyChanged("ICRequestReceiptItemExcQty");
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
		public double ICRequestReceiptItemCQty
		{
			get { return _iCRequestReceiptItemCQty; }
			set
			{
				if (value != this._iCRequestReceiptItemCQty)
				{
					_iCRequestReceiptItemCQty = value;
					NotifyChanged("ICRequestReceiptItemCQty");
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
		
        #endregion
    }
    #endregion
}