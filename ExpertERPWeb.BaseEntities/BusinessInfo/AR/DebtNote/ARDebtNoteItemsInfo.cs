using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARDebtNoteItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARDebtNoteItemsInfo
	//Created Date:Monday, January 19, 2015
	//-----------------------------------------------------------
	
	public class ARDebtNoteItemsInfo:BusinessObject
	{
		public ARDebtNoteItemsInfo()
		{
		}
		#region Variables
		protected int _aRDebtNoteItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARDebtNoteID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ARPriceListID;
		protected int _fK_TXTaxCodeID;
		protected String _aRDebtNoteItemSerialNo=String.Empty;
		protected bool _aRDebtNoteItemIsStkItm=true;
		protected String _aRDebtNoteItemType=String.Empty;
		protected int _aRDebtNoteItemDebtNotertOrder;
		protected String _aRDebtNoteItemDesc=String.Empty;
		protected String _aRDebtNoteItemUOM=String.Empty;
		protected String _aRDebtNoteItemStkUOM=String.Empty;
		protected double _aRDebtNoteItemFact;
		protected String _aRSalePriceCombo=String.Empty;
		protected double _aRDebtNoteItemUnitPrice;
		protected double _aRDebtNoteItemUnitCost;
		protected double _aRDebtNoteItemDiscPct;
		protected double _aRDebtNoteItemTxPct;
		protected double _aRDebtNoteItemQty;
		protected double _aRDebtNoteItemStkQty;
		protected double _aRDebtNoteItemRQty;
		protected double _aRDebtNoteItemRStkQty;
		protected double _aRDebtNoteItemPrice;
		protected String _aRDebtNoteItemComment=String.Empty;
		protected double _aRDebtNoteItemUnitVolumn;
		protected double _aRDebtNoteItemUnitWeight;
		protected double _aRDebtNoteItemTxAmt;
		protected double _aRDebtNoteItemDiscAmt;
		protected double _aRDebtNoteItemNetAmt;
		protected double _aRDebtNoteItemAmtTot;
		protected double _aRDebtNoteItemCostTot;
		protected String _aRDebtNoteItemStatus=DefaultStatus;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _aRDebtNoteItemWTot;
		protected double _aRDebtNoteItemVTot;
		#endregion

		#region Public properties
		public int ARDebtNoteItemID
		{
			get{return _aRDebtNoteItemID;}
			set
			{
				if (value != this._aRDebtNoteItemID)
				{
				_aRDebtNoteItemID=value;
				NotifyChanged("ARDebtNoteItemID");
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
		public int FK_ARDebtNoteID
		{
			get{return _fK_ARDebtNoteID;}
			set
			{
				if (value != this._fK_ARDebtNoteID)
				{
				_fK_ARDebtNoteID=value;
				NotifyChanged("FK_ARDebtNoteID");
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
		public String ARDebtNoteItemSerialNo
		{
			get{return _aRDebtNoteItemSerialNo;}
			set
			{
				if (value != this._aRDebtNoteItemSerialNo)
				{
				_aRDebtNoteItemSerialNo=value;
				NotifyChanged("ARDebtNoteItemSerialNo");
				}
			}
		}
		public bool ARDebtNoteItemIsStkItm
		{
			get{return _aRDebtNoteItemIsStkItm;}
			set
			{
				if (value != this._aRDebtNoteItemIsStkItm)
				{
				_aRDebtNoteItemIsStkItm=value;
				NotifyChanged("ARDebtNoteItemIsStkItm");
				}
			}
		}
		public String ARDebtNoteItemType
		{
			get{return _aRDebtNoteItemType;}
			set
			{
				if (value != this._aRDebtNoteItemType)
				{
				_aRDebtNoteItemType=value;
				NotifyChanged("ARDebtNoteItemType");
				}
			}
		}
		public int ARDebtNoteItemDebtNotertOrder
		{
			get{return _aRDebtNoteItemDebtNotertOrder;}
			set
			{
				if (value != this._aRDebtNoteItemDebtNotertOrder)
				{
				_aRDebtNoteItemDebtNotertOrder=value;
				NotifyChanged("ARDebtNoteItemDebtNotertOrder");
				}
			}
		}
		public String ARDebtNoteItemDesc
		{
			get{return _aRDebtNoteItemDesc;}
			set
			{
				if (value != this._aRDebtNoteItemDesc)
				{
				_aRDebtNoteItemDesc=value;
				NotifyChanged("ARDebtNoteItemDesc");
				}
			}
		}
		public String ARDebtNoteItemUOM
		{
			get{return _aRDebtNoteItemUOM;}
			set
			{
				if (value != this._aRDebtNoteItemUOM)
				{
				_aRDebtNoteItemUOM=value;
				NotifyChanged("ARDebtNoteItemUOM");
				}
			}
		}
		public String ARDebtNoteItemStkUOM
		{
			get{return _aRDebtNoteItemStkUOM;}
			set
			{
				if (value != this._aRDebtNoteItemStkUOM)
				{
				_aRDebtNoteItemStkUOM=value;
				NotifyChanged("ARDebtNoteItemStkUOM");
				}
			}
		}
		public double ARDebtNoteItemFact
		{
			get{return _aRDebtNoteItemFact;}
			set
			{
				if (value != this._aRDebtNoteItemFact)
				{
				_aRDebtNoteItemFact=value;
				NotifyChanged("ARDebtNoteItemFact");
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
		public double ARDebtNoteItemUnitPrice
		{
			get{return _aRDebtNoteItemUnitPrice;}
			set
			{
				if (value != this._aRDebtNoteItemUnitPrice)
				{
				_aRDebtNoteItemUnitPrice=value;
				NotifyChanged("ARDebtNoteItemUnitPrice");
				}
			}
		}
		public double ARDebtNoteItemUnitCost
		{
			get{return _aRDebtNoteItemUnitCost;}
			set
			{
				if (value != this._aRDebtNoteItemUnitCost)
				{
				_aRDebtNoteItemUnitCost=value;
				NotifyChanged("ARDebtNoteItemUnitCost");
				}
			}
		}
		public double ARDebtNoteItemDiscPct
		{
			get{return _aRDebtNoteItemDiscPct;}
			set
			{
				if (value != this._aRDebtNoteItemDiscPct)
				{
				_aRDebtNoteItemDiscPct=value;
				NotifyChanged("ARDebtNoteItemDiscPct");
				}
			}
		}
		public double ARDebtNoteItemTxPct
		{
			get{return _aRDebtNoteItemTxPct;}
			set
			{
				if (value != this._aRDebtNoteItemTxPct)
				{
				_aRDebtNoteItemTxPct=value;
				NotifyChanged("ARDebtNoteItemTxPct");
				}
			}
		}
		public double ARDebtNoteItemQty
		{
			get{return _aRDebtNoteItemQty;}
			set
			{
				if (value != this._aRDebtNoteItemQty)
				{
				_aRDebtNoteItemQty=value;
				NotifyChanged("ARDebtNoteItemQty");
				}
			}
		}
		public double ARDebtNoteItemStkQty
		{
			get{return _aRDebtNoteItemStkQty;}
			set
			{
				if (value != this._aRDebtNoteItemStkQty)
				{
				_aRDebtNoteItemStkQty=value;
				NotifyChanged("ARDebtNoteItemStkQty");
				}
			}
		}
		public double ARDebtNoteItemRQty
		{
			get{return _aRDebtNoteItemRQty;}
			set
			{
				if (value != this._aRDebtNoteItemRQty)
				{
				_aRDebtNoteItemRQty=value;
				NotifyChanged("ARDebtNoteItemRQty");
				}
			}
		}
		public double ARDebtNoteItemRStkQty
		{
			get{return _aRDebtNoteItemRStkQty;}
			set
			{
				if (value != this._aRDebtNoteItemRStkQty)
				{
				_aRDebtNoteItemRStkQty=value;
				NotifyChanged("ARDebtNoteItemRStkQty");
				}
			}
		}
		public double ARDebtNoteItemPrice
		{
			get{return _aRDebtNoteItemPrice;}
			set
			{
				if (value != this._aRDebtNoteItemPrice)
				{
				_aRDebtNoteItemPrice=value;
				NotifyChanged("ARDebtNoteItemPrice");
				}
			}
		}
		public String ARDebtNoteItemComment
		{
			get{return _aRDebtNoteItemComment;}
			set
			{
				if (value != this._aRDebtNoteItemComment)
				{
				_aRDebtNoteItemComment=value;
				NotifyChanged("ARDebtNoteItemComment");
				}
			}
		}
		public double ARDebtNoteItemUnitVolumn
		{
			get{return _aRDebtNoteItemUnitVolumn;}
			set
			{
				if (value != this._aRDebtNoteItemUnitVolumn)
				{
				_aRDebtNoteItemUnitVolumn=value;
				NotifyChanged("ARDebtNoteItemUnitVolumn");
				}
			}
		}
		public double ARDebtNoteItemUnitWeight
		{
			get{return _aRDebtNoteItemUnitWeight;}
			set
			{
				if (value != this._aRDebtNoteItemUnitWeight)
				{
				_aRDebtNoteItemUnitWeight=value;
				NotifyChanged("ARDebtNoteItemUnitWeight");
				}
			}
		}
		public double ARDebtNoteItemTxAmt
		{
			get{return _aRDebtNoteItemTxAmt;}
			set
			{
				if (value != this._aRDebtNoteItemTxAmt)
				{
				_aRDebtNoteItemTxAmt=value;
				NotifyChanged("ARDebtNoteItemTxAmt");
				}
			}
		}
		public double ARDebtNoteItemDiscAmt
		{
			get{return _aRDebtNoteItemDiscAmt;}
			set
			{
				if (value != this._aRDebtNoteItemDiscAmt)
				{
				_aRDebtNoteItemDiscAmt=value;
				NotifyChanged("ARDebtNoteItemDiscAmt");
				}
			}
		}
		public double ARDebtNoteItemNetAmt
		{
			get{return _aRDebtNoteItemNetAmt;}
			set
			{
				if (value != this._aRDebtNoteItemNetAmt)
				{
				_aRDebtNoteItemNetAmt=value;
				NotifyChanged("ARDebtNoteItemNetAmt");
				}
			}
		}
		public double ARDebtNoteItemAmtTot
		{
			get{return _aRDebtNoteItemAmtTot;}
			set
			{
				if (value != this._aRDebtNoteItemAmtTot)
				{
				_aRDebtNoteItemAmtTot=value;
				NotifyChanged("ARDebtNoteItemAmtTot");
				}
			}
		}
		public double ARDebtNoteItemCostTot
		{
			get{return _aRDebtNoteItemCostTot;}
			set
			{
				if (value != this._aRDebtNoteItemCostTot)
				{
				_aRDebtNoteItemCostTot=value;
				NotifyChanged("ARDebtNoteItemCostTot");
				}
			}
		}
		public String ARDebtNoteItemStatus
		{
			get{return _aRDebtNoteItemStatus;}
			set
			{
				if (value != this._aRDebtNoteItemStatus)
				{
				_aRDebtNoteItemStatus=value;
				NotifyChanged("ARDebtNoteItemStatus");
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
		public int FK_ICWeightUOMID
		{
			get{return _fK_ICWeightUOMID;}
			set
			{
				if (value != this._fK_ICWeightUOMID)
				{
				_fK_ICWeightUOMID=value;
				NotifyChanged("FK_ICWeightUOMID");
				}
			}
		}
		public int FK_ICVolumeUOMID
		{
			get{return _fK_ICVolumeUOMID;}
			set
			{
				if (value != this._fK_ICVolumeUOMID)
				{
				_fK_ICVolumeUOMID=value;
				NotifyChanged("FK_ICVolumeUOMID");
				}
			}
		}
		public double ARDebtNoteItemWTot
		{
			get{return _aRDebtNoteItemWTot;}
			set
			{
				if (value != this._aRDebtNoteItemWTot)
				{
				_aRDebtNoteItemWTot=value;
				NotifyChanged("ARDebtNoteItemWTot");
				}
			}
		}
		public double ARDebtNoteItemVTot
		{
			get{return _aRDebtNoteItemVTot;}
			set
			{
				if (value != this._aRDebtNoteItemVTot)
				{
				_aRDebtNoteItemVTot=value;
				NotifyChanged("ARDebtNoteItemVTot");
				}
			}
		}
		#endregion
	}
	#endregion
}