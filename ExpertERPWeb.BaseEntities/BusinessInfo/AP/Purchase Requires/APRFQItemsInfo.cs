using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APRFQItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APRFQItemsInfo
	//Created Date:Tuesday, October 20, 2015
	//-----------------------------------------------------------
	
	public class APRFQItemsInfo:BusinessObject
	{
		public APRFQItemsInfo()
		{
		}
		#region Variables
		protected int _aPRFQItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aPRFQItemStatus=DefaultStatus;
		protected int _fK_APRFQID;
		protected int _fK_ICProductID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ICStockID;
		protected int _fK_ICUOMID;
		protected String _aPRFQItemDesc=String.Empty;
		protected double _aPRFQItemUnitPrice;
		protected double _aPRFQItemUnitCost;
		protected double _aPRFQItemDisc;
		protected double _aPRFQItemTxPct;
		protected double _aPRFQItemRQty;
		protected double _aPRFQItemQty;
		protected double _aPRFQItemPrice;
		protected String _aPRFQItemComment=String.Empty;
		protected double _aPRFQItemTxAmt;
		protected double _aPRFQItemDiscAmt;
		protected double _aPRFQItemDiscPct;
		protected double _aPRFQItemNetAmt;
		protected double _aPRFQItemAmtTot;
		protected double _aPRFQItemCostTot;
		protected double _aPRFQItemFUnitPrice;
		protected double _aPRFQItemFPrice;
		protected double _aPRFQItemFTxAmt;
		protected double _aPRFQItemFNetAmt;
		protected double _aPRFQItemFAmtTot;
		protected double _aPRFQItemFImpTxAmt;
		protected double _aPRFQItemFDiscAmt;
		protected Nullable<DateTime> _aPRFQItemArrivalDate;
		protected int _fK_APPRItemID;
		protected double _aPRFQItemFact;
		protected String _aPRFQItemOrigin=String.Empty;
		protected String _aPRFQItemProductNo=String.Empty;
		protected String _aPRFQItemProductName=String.Empty;
		protected double _aPRFQItemExcQty;
		protected double _aPRFQItemOrgQty;
		protected int _fK_ICOrgUOMID;
		protected double _aPRFQItemStkQty;
		protected int _fK_ICStkUOMID;
		protected int _fK_APPriceListDetailID;
		#endregion

		#region Public properties
		public int APRFQItemID
		{
			get{return _aPRFQItemID;}
			set
			{
				if (value != this._aPRFQItemID)
				{
				_aPRFQItemID=value;
				NotifyChanged("APRFQItemID");
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
		public String APRFQItemStatus
		{
			get{return _aPRFQItemStatus;}
			set
			{
				if (value != this._aPRFQItemStatus)
				{
				_aPRFQItemStatus=value;
				NotifyChanged("APRFQItemStatus");
				}
			}
		}
		public int FK_APRFQID
		{
			get{return _fK_APRFQID;}
			set
			{
				if (value != this._fK_APRFQID)
				{
				_fK_APRFQID=value;
				NotifyChanged("FK_APRFQID");
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
		public String APRFQItemDesc
		{
			get{return _aPRFQItemDesc;}
			set
			{
				if (value != this._aPRFQItemDesc)
				{
				_aPRFQItemDesc=value;
				NotifyChanged("APRFQItemDesc");
				}
			}
		}
		public double APRFQItemUnitPrice
		{
			get{return _aPRFQItemUnitPrice;}
			set
			{
				if (value != this._aPRFQItemUnitPrice)
				{
				_aPRFQItemUnitPrice=value;
				NotifyChanged("APRFQItemUnitPrice");
				}
			}
		}
		public double APRFQItemUnitCost
		{
			get{return _aPRFQItemUnitCost;}
			set
			{
				if (value != this._aPRFQItemUnitCost)
				{
				_aPRFQItemUnitCost=value;
				NotifyChanged("APRFQItemUnitCost");
				}
			}
		}
		public double APRFQItemDisc
		{
			get{return _aPRFQItemDisc;}
			set
			{
				if (value != this._aPRFQItemDisc)
				{
				_aPRFQItemDisc=value;
				NotifyChanged("APRFQItemDisc");
				}
			}
		}
		public double APRFQItemTxPct
		{
			get{return _aPRFQItemTxPct;}
			set
			{
				if (value != this._aPRFQItemTxPct)
				{
				_aPRFQItemTxPct=value;
				NotifyChanged("APRFQItemTxPct");
				}
			}
		}
		public double APRFQItemRQty
		{
			get{return _aPRFQItemRQty;}
			set
			{
				if (value != this._aPRFQItemRQty)
				{
				_aPRFQItemRQty=value;
				NotifyChanged("APRFQItemRQty");
				}
			}
		}
		public double APRFQItemQty
		{
			get{return _aPRFQItemQty;}
			set
			{
				if (value != this._aPRFQItemQty)
				{
				_aPRFQItemQty=value;
				NotifyChanged("APRFQItemQty");
				}
			}
		}
		public double APRFQItemPrice
		{
			get{return _aPRFQItemPrice;}
			set
			{
				if (value != this._aPRFQItemPrice)
				{
				_aPRFQItemPrice=value;
				NotifyChanged("APRFQItemPrice");
				}
			}
		}
		public String APRFQItemComment
		{
			get{return _aPRFQItemComment;}
			set
			{
				if (value != this._aPRFQItemComment)
				{
				_aPRFQItemComment=value;
				NotifyChanged("APRFQItemComment");
				}
			}
		}
		public double APRFQItemTxAmt
		{
			get{return _aPRFQItemTxAmt;}
			set
			{
				if (value != this._aPRFQItemTxAmt)
				{
				_aPRFQItemTxAmt=value;
				NotifyChanged("APRFQItemTxAmt");
				}
			}
		}
		public double APRFQItemDiscAmt
		{
			get{return _aPRFQItemDiscAmt;}
			set
			{
				if (value != this._aPRFQItemDiscAmt)
				{
				_aPRFQItemDiscAmt=value;
				NotifyChanged("APRFQItemDiscAmt");
				}
			}
		}
		public double APRFQItemDiscPct
		{
			get{return _aPRFQItemDiscPct;}
			set
			{
				if (value != this._aPRFQItemDiscPct)
				{
				_aPRFQItemDiscPct=value;
				NotifyChanged("APRFQItemDiscPct");
				}
			}
		}
		public double APRFQItemNetAmt
		{
			get{return _aPRFQItemNetAmt;}
			set
			{
				if (value != this._aPRFQItemNetAmt)
				{
				_aPRFQItemNetAmt=value;
				NotifyChanged("APRFQItemNetAmt");
				}
			}
		}
		public double APRFQItemAmtTot
		{
			get{return _aPRFQItemAmtTot;}
			set
			{
				if (value != this._aPRFQItemAmtTot)
				{
				_aPRFQItemAmtTot=value;
				NotifyChanged("APRFQItemAmtTot");
				}
			}
		}
		public double APRFQItemCostTot
		{
			get{return _aPRFQItemCostTot;}
			set
			{
				if (value != this._aPRFQItemCostTot)
				{
				_aPRFQItemCostTot=value;
				NotifyChanged("APRFQItemCostTot");
				}
			}
		}
		public double APRFQItemFUnitPrice
		{
			get{return _aPRFQItemFUnitPrice;}
			set
			{
				if (value != this._aPRFQItemFUnitPrice)
				{
				_aPRFQItemFUnitPrice=value;
				NotifyChanged("APRFQItemFUnitPrice");
				}
			}
		}
		public double APRFQItemFPrice
		{
			get{return _aPRFQItemFPrice;}
			set
			{
				if (value != this._aPRFQItemFPrice)
				{
				_aPRFQItemFPrice=value;
				NotifyChanged("APRFQItemFPrice");
				}
			}
		}
		public double APRFQItemFTxAmt
		{
			get{return _aPRFQItemFTxAmt;}
			set
			{
				if (value != this._aPRFQItemFTxAmt)
				{
				_aPRFQItemFTxAmt=value;
				NotifyChanged("APRFQItemFTxAmt");
				}
			}
		}
		public double APRFQItemFNetAmt
		{
			get{return _aPRFQItemFNetAmt;}
			set
			{
				if (value != this._aPRFQItemFNetAmt)
				{
				_aPRFQItemFNetAmt=value;
				NotifyChanged("APRFQItemFNetAmt");
				}
			}
		}
		public double APRFQItemFAmtTot
		{
			get{return _aPRFQItemFAmtTot;}
			set
			{
				if (value != this._aPRFQItemFAmtTot)
				{
				_aPRFQItemFAmtTot=value;
				NotifyChanged("APRFQItemFAmtTot");
				}
			}
		}
		public double APRFQItemFImpTxAmt
		{
			get{return _aPRFQItemFImpTxAmt;}
			set
			{
				if (value != this._aPRFQItemFImpTxAmt)
				{
				_aPRFQItemFImpTxAmt=value;
				NotifyChanged("APRFQItemFImpTxAmt");
				}
			}
		}
		public double APRFQItemFDiscAmt
		{
			get{return _aPRFQItemFDiscAmt;}
			set
			{
				if (value != this._aPRFQItemFDiscAmt)
				{
				_aPRFQItemFDiscAmt=value;
				NotifyChanged("APRFQItemFDiscAmt");
				}
			}
		}
		public Nullable<DateTime> APRFQItemArrivalDate
		{
			get{return _aPRFQItemArrivalDate;}
			set
			{
				if (value != this._aPRFQItemArrivalDate)
				{
				_aPRFQItemArrivalDate=value;
				NotifyChanged("APRFQItemArrivalDate");
				}
			}
		}
		public int FK_APPRItemID
		{
			get{return _fK_APPRItemID;}
			set
			{
				if (value != this._fK_APPRItemID)
				{
				_fK_APPRItemID=value;
				NotifyChanged("FK_APPRItemID");
				}
			}
		}
		public double APRFQItemFact
		{
			get{return _aPRFQItemFact;}
			set
			{
				if (value != this._aPRFQItemFact)
				{
				_aPRFQItemFact=value;
				NotifyChanged("APRFQItemFact");
				}
			}
		}
		public String APRFQItemOrigin
		{
			get{return _aPRFQItemOrigin;}
			set
			{
				if (value != this._aPRFQItemOrigin)
				{
				_aPRFQItemOrigin=value;
				NotifyChanged("APRFQItemOrigin");
				}
			}
		}
		public String APRFQItemProductNo
		{
			get{return _aPRFQItemProductNo;}
			set
			{
				if (value != this._aPRFQItemProductNo)
				{
				_aPRFQItemProductNo=value;
				NotifyChanged("APRFQItemProductNo");
				}
			}
		}
		public String APRFQItemProductName
		{
			get{return _aPRFQItemProductName;}
			set
			{
				if (value != this._aPRFQItemProductName)
				{
				_aPRFQItemProductName=value;
				NotifyChanged("APRFQItemProductName");
				}
			}
		}
		public double APRFQItemExcQty
		{
			get{return _aPRFQItemExcQty;}
			set
			{
				if (value != this._aPRFQItemExcQty)
				{
				_aPRFQItemExcQty=value;
				NotifyChanged("APRFQItemExcQty");
				}
			}
		}
		public double APRFQItemOrgQty
		{
			get{return _aPRFQItemOrgQty;}
			set
			{
				if (value != this._aPRFQItemOrgQty)
				{
				_aPRFQItemOrgQty=value;
				NotifyChanged("APRFQItemOrgQty");
				}
			}
		}
		public int FK_ICOrgUOMID
		{
			get{return _fK_ICOrgUOMID;}
			set
			{
				if (value != this._fK_ICOrgUOMID)
				{
				_fK_ICOrgUOMID=value;
				NotifyChanged("FK_ICOrgUOMID");
				}
			}
		}
		public double APRFQItemStkQty
		{
			get{return _aPRFQItemStkQty;}
			set
			{
				if (value != this._aPRFQItemStkQty)
				{
				_aPRFQItemStkQty=value;
				NotifyChanged("APRFQItemStkQty");
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
		public int FK_APPriceListDetailID
		{
			get{return _fK_APPriceListDetailID;}
			set
			{
				if (value != this._fK_APPriceListDetailID)
				{
				_fK_APPriceListDetailID=value;
				NotifyChanged("FK_APPriceListDetailID");
				}
			}
		}
		#endregion
	}
	#endregion
}