
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPWOPItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.89)
    //Class: PPWOPItemsInfo
    //Created Date: Thursday, 29 Jun 2017
    //-----------------------------------------------------------

    public class PPWOPItemsInfo : BusinessObject
    {
        public PPWOPItemsInfo()
        {
        }
        #region Variables
		protected int _pPWOPItemID;
		protected bool _aASelected = true;
		protected String _aAStatus = DefaultAAStatus;
		protected int _fK_PPWOID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ARPriceListID;
		protected int _fK_TXTaxCodeID;
		protected String _pPWOPItemSerialNo = String.Empty;
		protected String _pPWOPItemType = String.Empty;
		protected bool _pPWOPItemIsStkItm = true;
		protected String _pPWOPItemDesc = String.Empty;
		protected String _pPWOPItemUOM = String.Empty;
		protected String _pPWOPItemStkUOM = String.Empty;
		protected double _pPWOPItemFact;
		protected double _pPWOPItemUnitPrice;
		protected double _pPWOPItemUnitCost;
		protected double _pPWOPItemDiscPct;
		protected double _pPWOPItemTxPct;
		protected double _pPWOPItemQty;
		protected double _pPWOPItemStkQty;
		protected double _pPWOPItemRQty;
		protected double _pPWOPItemRStkQty;
		protected double _pPWOPItemPrice;
		protected String _pPWOPItemComment = String.Empty;
		protected double _pPWOPItemUnitVol;
		protected double _pPWOPItemUnitWeight;
		protected double _pPWOPItemTxAmt;
		protected double _pPWOPItemDiscAmt;
		protected double _pPWOPItemNetAmt;
		protected double _pPWOPItemAmtTot;
		protected double _pPWOPItemCostTot;
		protected String _pPWOPItemStatus = DefaultStatus;
		protected double _pPWOPItemRORQty;
		protected String _pPWOPItemROStatusCombo = DefaultStatus;
		protected double _pPWOPItemROQty;
		protected double _pPWOItemShpQty;
		protected String _pPWOPItemNo = String.Empty;
		protected String _pPWOPItemName = String.Empty;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_PPMPSItemID;
		protected int _fK_ARSOItemID;
		protected Nullable<DateTime> _pPWOPItemPlanDate;
		protected int _fK_ARSOID;
		protected int _fK_ARShpPlanItemID;
		protected String _pPWOPItemLotNo = String.Empty;
		protected int _fK_PPWORID;
		protected int _fK_PPWORItemID;
		
        #endregion

        #region Public properties
		public int PPWOPItemID
		{
			get { return _pPWOPItemID; }
			set
			{
				if (value != this._pPWOPItemID)
				{
					_pPWOPItemID = value;
					NotifyChanged("PPWOPItemID");
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
		public String PPWOPItemSerialNo
		{
			get { return _pPWOPItemSerialNo; }
			set
			{
				if (value != this._pPWOPItemSerialNo)
				{
					_pPWOPItemSerialNo = value;
					NotifyChanged("PPWOPItemSerialNo");
				}
			}
		}
		public String PPWOPItemType
		{
			get { return _pPWOPItemType; }
			set
			{
				if (value != this._pPWOPItemType)
				{
					_pPWOPItemType = value;
					NotifyChanged("PPWOPItemType");
				}
			}
		}
		public bool PPWOPItemIsStkItm
		{
			get { return _pPWOPItemIsStkItm; }
			set
			{
				if (value != this._pPWOPItemIsStkItm)
				{
					_pPWOPItemIsStkItm = value;
					NotifyChanged("PPWOPItemIsStkItm");
				}
			}
		}
		public String PPWOPItemDesc
		{
			get { return _pPWOPItemDesc; }
			set
			{
				if (value != this._pPWOPItemDesc)
				{
					_pPWOPItemDesc = value;
					NotifyChanged("PPWOPItemDesc");
				}
			}
		}
		public String PPWOPItemUOM
		{
			get { return _pPWOPItemUOM; }
			set
			{
				if (value != this._pPWOPItemUOM)
				{
					_pPWOPItemUOM = value;
					NotifyChanged("PPWOPItemUOM");
				}
			}
		}
		public String PPWOPItemStkUOM
		{
			get { return _pPWOPItemStkUOM; }
			set
			{
				if (value != this._pPWOPItemStkUOM)
				{
					_pPWOPItemStkUOM = value;
					NotifyChanged("PPWOPItemStkUOM");
				}
			}
		}
		public double PPWOPItemFact
		{
			get { return _pPWOPItemFact; }
			set
			{
				if (value != this._pPWOPItemFact)
				{
					_pPWOPItemFact = value;
					NotifyChanged("PPWOPItemFact");
				}
			}
		}
		public double PPWOPItemUnitPrice
		{
			get { return _pPWOPItemUnitPrice; }
			set
			{
				if (value != this._pPWOPItemUnitPrice)
				{
					_pPWOPItemUnitPrice = value;
					NotifyChanged("PPWOPItemUnitPrice");
				}
			}
		}
		public double PPWOPItemUnitCost
		{
			get { return _pPWOPItemUnitCost; }
			set
			{
				if (value != this._pPWOPItemUnitCost)
				{
					_pPWOPItemUnitCost = value;
					NotifyChanged("PPWOPItemUnitCost");
				}
			}
		}
		public double PPWOPItemDiscPct
		{
			get { return _pPWOPItemDiscPct; }
			set
			{
				if (value != this._pPWOPItemDiscPct)
				{
					_pPWOPItemDiscPct = value;
					NotifyChanged("PPWOPItemDiscPct");
				}
			}
		}
		public double PPWOPItemTxPct
		{
			get { return _pPWOPItemTxPct; }
			set
			{
				if (value != this._pPWOPItemTxPct)
				{
					_pPWOPItemTxPct = value;
					NotifyChanged("PPWOPItemTxPct");
				}
			}
		}
		public double PPWOPItemQty
		{
			get { return _pPWOPItemQty; }
			set
			{
				if (value != this._pPWOPItemQty)
				{
					_pPWOPItemQty = value;
					NotifyChanged("PPWOPItemQty");
				}
			}
		}
		public double PPWOPItemStkQty
		{
			get { return _pPWOPItemStkQty; }
			set
			{
				if (value != this._pPWOPItemStkQty)
				{
					_pPWOPItemStkQty = value;
					NotifyChanged("PPWOPItemStkQty");
				}
			}
		}
		public double PPWOPItemRQty
		{
			get { return _pPWOPItemRQty; }
			set
			{
				if (value != this._pPWOPItemRQty)
				{
					_pPWOPItemRQty = value;
					NotifyChanged("PPWOPItemRQty");
				}
			}
		}
		public double PPWOPItemRStkQty
		{
			get { return _pPWOPItemRStkQty; }
			set
			{
				if (value != this._pPWOPItemRStkQty)
				{
					_pPWOPItemRStkQty = value;
					NotifyChanged("PPWOPItemRStkQty");
				}
			}
		}
		public double PPWOPItemPrice
		{
			get { return _pPWOPItemPrice; }
			set
			{
				if (value != this._pPWOPItemPrice)
				{
					_pPWOPItemPrice = value;
					NotifyChanged("PPWOPItemPrice");
				}
			}
		}
		public String PPWOPItemComment
		{
			get { return _pPWOPItemComment; }
			set
			{
				if (value != this._pPWOPItemComment)
				{
					_pPWOPItemComment = value;
					NotifyChanged("PPWOPItemComment");
				}
			}
		}
		public double PPWOPItemUnitVol
		{
			get { return _pPWOPItemUnitVol; }
			set
			{
				if (value != this._pPWOPItemUnitVol)
				{
					_pPWOPItemUnitVol = value;
					NotifyChanged("PPWOPItemUnitVol");
				}
			}
		}
		public double PPWOPItemUnitWeight
		{
			get { return _pPWOPItemUnitWeight; }
			set
			{
				if (value != this._pPWOPItemUnitWeight)
				{
					_pPWOPItemUnitWeight = value;
					NotifyChanged("PPWOPItemUnitWeight");
				}
			}
		}
		public double PPWOPItemTxAmt
		{
			get { return _pPWOPItemTxAmt; }
			set
			{
				if (value != this._pPWOPItemTxAmt)
				{
					_pPWOPItemTxAmt = value;
					NotifyChanged("PPWOPItemTxAmt");
				}
			}
		}
		public double PPWOPItemDiscAmt
		{
			get { return _pPWOPItemDiscAmt; }
			set
			{
				if (value != this._pPWOPItemDiscAmt)
				{
					_pPWOPItemDiscAmt = value;
					NotifyChanged("PPWOPItemDiscAmt");
				}
			}
		}
		public double PPWOPItemNetAmt
		{
			get { return _pPWOPItemNetAmt; }
			set
			{
				if (value != this._pPWOPItemNetAmt)
				{
					_pPWOPItemNetAmt = value;
					NotifyChanged("PPWOPItemNetAmt");
				}
			}
		}
		public double PPWOPItemAmtTot
		{
			get { return _pPWOPItemAmtTot; }
			set
			{
				if (value != this._pPWOPItemAmtTot)
				{
					_pPWOPItemAmtTot = value;
					NotifyChanged("PPWOPItemAmtTot");
				}
			}
		}
		public double PPWOPItemCostTot
		{
			get { return _pPWOPItemCostTot; }
			set
			{
				if (value != this._pPWOPItemCostTot)
				{
					_pPWOPItemCostTot = value;
					NotifyChanged("PPWOPItemCostTot");
				}
			}
		}
		public String PPWOPItemStatus
		{
			get { return _pPWOPItemStatus; }
			set
			{
				if (value != this._pPWOPItemStatus)
				{
					_pPWOPItemStatus = value;
					NotifyChanged("PPWOPItemStatus");
				}
			}
		}
		public double PPWOPItemRORQty
		{
			get { return _pPWOPItemRORQty; }
			set
			{
				if (value != this._pPWOPItemRORQty)
				{
					_pPWOPItemRORQty = value;
					NotifyChanged("PPWOPItemRORQty");
				}
			}
		}
		public String PPWOPItemROStatusCombo
		{
			get { return _pPWOPItemROStatusCombo; }
			set
			{
				if (value != this._pPWOPItemROStatusCombo)
				{
					_pPWOPItemROStatusCombo = value;
					NotifyChanged("PPWOPItemROStatusCombo");
				}
			}
		}
		public double PPWOPItemROQty
		{
			get { return _pPWOPItemROQty; }
			set
			{
				if (value != this._pPWOPItemROQty)
				{
					_pPWOPItemROQty = value;
					NotifyChanged("PPWOPItemROQty");
				}
			}
		}
		public double PPWOItemShpQty
		{
			get { return _pPWOItemShpQty; }
			set
			{
				if (value != this._pPWOItemShpQty)
				{
					_pPWOItemShpQty = value;
					NotifyChanged("PPWOItemShpQty");
				}
			}
		}
		public String PPWOPItemNo
		{
			get { return _pPWOPItemNo; }
			set
			{
				if (value != this._pPWOPItemNo)
				{
					_pPWOPItemNo = value;
					NotifyChanged("PPWOPItemNo");
				}
			}
		}
		public String PPWOPItemName
		{
			get { return _pPWOPItemName; }
			set
			{
				if (value != this._pPWOPItemName)
				{
					_pPWOPItemName = value;
					NotifyChanged("PPWOPItemName");
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
		public int FK_PPMPSItemID
		{
			get { return _fK_PPMPSItemID; }
			set
			{
				if (value != this._fK_PPMPSItemID)
				{
					_fK_PPMPSItemID = value;
					NotifyChanged("FK_PPMPSItemID");
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
		public Nullable<DateTime> PPWOPItemPlanDate
		{
			get { return _pPWOPItemPlanDate; }
			set
			{
				if (value != this._pPWOPItemPlanDate)
				{
					_pPWOPItemPlanDate = value;
					NotifyChanged("PPWOPItemPlanDate");
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
		public String PPWOPItemLotNo
		{
			get { return _pPWOPItemLotNo; }
			set
			{
				if (value != this._pPWOPItemLotNo)
				{
					_pPWOPItemLotNo = value;
					NotifyChanged("PPWOPItemLotNo");
				}
			}
		}
		public int FK_PPWORID
		{
			get { return _fK_PPWORID; }
			set
			{
				if (value != this._fK_PPWORID)
				{
					_fK_PPWORID = value;
					NotifyChanged("FK_PPWORID");
				}
			}
		}
		public int FK_PPWORItemID
		{
			get { return _fK_PPWORItemID; }
			set
			{
				if (value != this._fK_PPWORItemID)
				{
					_fK_PPWORItemID = value;
					NotifyChanged("FK_PPWORItemID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}