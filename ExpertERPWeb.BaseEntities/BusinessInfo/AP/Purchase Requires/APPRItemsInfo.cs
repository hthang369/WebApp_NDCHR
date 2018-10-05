using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPRItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPRItemsInfo
	//Created Date:Thursday, April 16, 2015
	//-----------------------------------------------------------
	
	public class APPRItemsInfo:BusinessObject
	{
		public APPRItemsInfo()
		{
		}
		#region Variables
		protected int _aPPRItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aPPRItemStatus=DefaultStatus;
		protected int _fK_APPRID;
		protected int _fK_ICProductID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ARPriceListID;
		protected int _fK_TXTaxCodeID;
		protected String _aPPRItemSerialNo=String.Empty;
		protected bool _aPPRItemIsStkItm=true;
		protected String _aPPRItemUOM=String.Empty;
		protected String _aPPRItemType=String.Empty;
		protected int _aPPRItemSrtOrder;
		protected String _aPPRItemDesc=String.Empty;
		protected String _aPPRItemSellUnit=String.Empty;
		protected String _aPPRItemBasicUnit=String.Empty;
		protected String _aPPRItemPackUnit=String.Empty;
		protected double _aPPRItemSellFact;
		protected double _aPPRItemPackFact;
		protected double _aPPRItemUnitPrice;
		protected double _aPPRItemUnitCost;
		protected double _aPPRItemGrpDisc;
		protected double _aPPRItemDisc;
		protected double _aPPRItemTxPct;
		protected double _aPPRItemQtyOld;
		protected double _aPPRItemRQty;
		protected double _aPPRItemQty;
		protected double _aPPRItemBasicQty;
		protected double _aPPRItemPckQty;
		protected double _aPPRItemQty1;
		protected double _aPPRItemQty2;
		protected double _aPPRItemQty3;
		protected double _aPPRItemQty4;
		protected double _aPPRItemQty5;
		protected double _aPPRItemQty6;
		protected double _aPPRItemPrice;
		protected String _aPPRItemComment=String.Empty;
		protected double _aPPRItemUnitVolumn;
		protected double _aPPRItemUnitWeight;
		protected double _aPPRItemTxAmt;
		protected double _aPPRItemDiscAmt;
		protected double _aPPRItemDiscPct;
		protected double _aPPRItemNetAmt;
		protected double _aPPRItemAmtTot;
		protected double _aPPRItemCostTot;
		protected double _aPPRItemFUnitPrice;
		protected double _aPPRItemFTxAmt;
		protected double _aPPRItemFDiscAmt;
		protected double _aPPRItemFPrice;
		protected double _aPPRItemFAmtTot;
		protected Nullable<DateTime> _aPPRItemArrivalDate;
		protected double _aPPRItemMinStockQty;
		protected Nullable<DateTime> _aPPRItemUseDate;
		protected String _aPPRItemUsePurposes=String.Empty;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _aPPRItemStkQty;
		protected double _aPPRItemRStkQty;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _aPPRItemWTot;
		protected double _aPPRItemVTot;
		protected int _fK_ARSOID;
		protected double _aPPRItemFact;
		protected double _aPPRItemExcQty;
		protected int _fK_ICOrgUOMID;
		protected double _aPPRItemOrgQty;
		protected double _aPPRItemCQty;
		protected String _aPPRItemProductNo=String.Empty;
		protected String _aPPRItemProductName=String.Empty;
		protected String _aPPRItemLine=String.Empty;
		protected int _fK_APSupplierID;
		protected int _fK_APRFQItemID;
		protected double _aPPRItemInvQty;
		protected double _aPPRItemBOQQty;
		protected String _aPPRItemOrigin=String.Empty;
		protected int _fK_APProcurementPlnItemID;
		#endregion

		#region Public properties
		public int APPRItemID
		{
			get{return _aPPRItemID;}
			set
			{
				if (value != this._aPPRItemID)
				{
				_aPPRItemID=value;
				NotifyChanged("APPRItemID");
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
		public String APPRItemStatus
		{
			get{return _aPPRItemStatus;}
			set
			{
				if (value != this._aPPRItemStatus)
				{
				_aPPRItemStatus=value;
				NotifyChanged("APPRItemStatus");
				}
			}
		}
		public int FK_APPRID
		{
			get{return _fK_APPRID;}
			set
			{
				if (value != this._fK_APPRID)
				{
				_fK_APPRID=value;
				NotifyChanged("FK_APPRID");
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
		public String APPRItemSerialNo
		{
			get{return _aPPRItemSerialNo;}
			set
			{
				if (value != this._aPPRItemSerialNo)
				{
				_aPPRItemSerialNo=value;
				NotifyChanged("APPRItemSerialNo");
				}
			}
		}
		public bool APPRItemIsStkItm
		{
			get{return _aPPRItemIsStkItm;}
			set
			{
				if (value != this._aPPRItemIsStkItm)
				{
				_aPPRItemIsStkItm=value;
				NotifyChanged("APPRItemIsStkItm");
				}
			}
		}
		public String APPRItemUOM
		{
			get{return _aPPRItemUOM;}
			set
			{
				if (value != this._aPPRItemUOM)
				{
				_aPPRItemUOM=value;
				NotifyChanged("APPRItemUOM");
				}
			}
		}
		public String APPRItemType
		{
			get{return _aPPRItemType;}
			set
			{
				if (value != this._aPPRItemType)
				{
				_aPPRItemType=value;
				NotifyChanged("APPRItemType");
				}
			}
		}
		public int APPRItemSrtOrder
		{
			get{return _aPPRItemSrtOrder;}
			set
			{
				if (value != this._aPPRItemSrtOrder)
				{
				_aPPRItemSrtOrder=value;
				NotifyChanged("APPRItemSrtOrder");
				}
			}
		}
		public String APPRItemDesc
		{
			get{return _aPPRItemDesc;}
			set
			{
				if (value != this._aPPRItemDesc)
				{
				_aPPRItemDesc=value;
				NotifyChanged("APPRItemDesc");
				}
			}
		}
		public String APPRItemSellUnit
		{
			get{return _aPPRItemSellUnit;}
			set
			{
				if (value != this._aPPRItemSellUnit)
				{
				_aPPRItemSellUnit=value;
				NotifyChanged("APPRItemSellUnit");
				}
			}
		}
		public String APPRItemBasicUnit
		{
			get{return _aPPRItemBasicUnit;}
			set
			{
				if (value != this._aPPRItemBasicUnit)
				{
				_aPPRItemBasicUnit=value;
				NotifyChanged("APPRItemBasicUnit");
				}
			}
		}
		public String APPRItemPackUnit
		{
			get{return _aPPRItemPackUnit;}
			set
			{
				if (value != this._aPPRItemPackUnit)
				{
				_aPPRItemPackUnit=value;
				NotifyChanged("APPRItemPackUnit");
				}
			}
		}
		public double APPRItemSellFact
		{
			get{return _aPPRItemSellFact;}
			set
			{
				if (value != this._aPPRItemSellFact)
				{
				_aPPRItemSellFact=value;
				NotifyChanged("APPRItemSellFact");
				}
			}
		}
		public double APPRItemPackFact
		{
			get{return _aPPRItemPackFact;}
			set
			{
				if (value != this._aPPRItemPackFact)
				{
				_aPPRItemPackFact=value;
				NotifyChanged("APPRItemPackFact");
				}
			}
		}
		public double APPRItemUnitPrice
		{
			get{return _aPPRItemUnitPrice;}
			set
			{
				if (value != this._aPPRItemUnitPrice)
				{
				_aPPRItemUnitPrice=value;
				NotifyChanged("APPRItemUnitPrice");
				}
			}
		}
		public double APPRItemUnitCost
		{
			get{return _aPPRItemUnitCost;}
			set
			{
				if (value != this._aPPRItemUnitCost)
				{
				_aPPRItemUnitCost=value;
				NotifyChanged("APPRItemUnitCost");
				}
			}
		}
		public double APPRItemGrpDisc
		{
			get{return _aPPRItemGrpDisc;}
			set
			{
				if (value != this._aPPRItemGrpDisc)
				{
				_aPPRItemGrpDisc=value;
				NotifyChanged("APPRItemGrpDisc");
				}
			}
		}
		public double APPRItemDisc
		{
			get{return _aPPRItemDisc;}
			set
			{
				if (value != this._aPPRItemDisc)
				{
				_aPPRItemDisc=value;
				NotifyChanged("APPRItemDisc");
				}
			}
		}
		public double APPRItemTxPct
		{
			get{return _aPPRItemTxPct;}
			set
			{
				if (value != this._aPPRItemTxPct)
				{
				_aPPRItemTxPct=value;
				NotifyChanged("APPRItemTxPct");
				}
			}
		}
		public double APPRItemQtyOld
		{
			get{return _aPPRItemQtyOld;}
			set
			{
				if (value != this._aPPRItemQtyOld)
				{
				_aPPRItemQtyOld=value;
				NotifyChanged("APPRItemQtyOld");
				}
			}
		}
		public double APPRItemRQty
		{
			get{return _aPPRItemRQty;}
			set
			{
				if (value != this._aPPRItemRQty)
				{
				_aPPRItemRQty=value;
				NotifyChanged("APPRItemRQty");
				}
			}
		}
		public double APPRItemQty
		{
			get{return _aPPRItemQty;}
			set
			{
				if (value != this._aPPRItemQty)
				{
				_aPPRItemQty=value;
				NotifyChanged("APPRItemQty");
				}
			}
		}
		public double APPRItemBasicQty
		{
			get{return _aPPRItemBasicQty;}
			set
			{
				if (value != this._aPPRItemBasicQty)
				{
				_aPPRItemBasicQty=value;
				NotifyChanged("APPRItemBasicQty");
				}
			}
		}
		public double APPRItemPckQty
		{
			get{return _aPPRItemPckQty;}
			set
			{
				if (value != this._aPPRItemPckQty)
				{
				_aPPRItemPckQty=value;
				NotifyChanged("APPRItemPckQty");
				}
			}
		}
		public double APPRItemQty1
		{
			get{return _aPPRItemQty1;}
			set
			{
				if (value != this._aPPRItemQty1)
				{
				_aPPRItemQty1=value;
				NotifyChanged("APPRItemQty1");
				}
			}
		}
		public double APPRItemQty2
		{
			get{return _aPPRItemQty2;}
			set
			{
				if (value != this._aPPRItemQty2)
				{
				_aPPRItemQty2=value;
				NotifyChanged("APPRItemQty2");
				}
			}
		}
		public double APPRItemQty3
		{
			get{return _aPPRItemQty3;}
			set
			{
				if (value != this._aPPRItemQty3)
				{
				_aPPRItemQty3=value;
				NotifyChanged("APPRItemQty3");
				}
			}
		}
		public double APPRItemQty4
		{
			get{return _aPPRItemQty4;}
			set
			{
				if (value != this._aPPRItemQty4)
				{
				_aPPRItemQty4=value;
				NotifyChanged("APPRItemQty4");
				}
			}
		}
		public double APPRItemQty5
		{
			get{return _aPPRItemQty5;}
			set
			{
				if (value != this._aPPRItemQty5)
				{
				_aPPRItemQty5=value;
				NotifyChanged("APPRItemQty5");
				}
			}
		}
		public double APPRItemQty6
		{
			get{return _aPPRItemQty6;}
			set
			{
				if (value != this._aPPRItemQty6)
				{
				_aPPRItemQty6=value;
				NotifyChanged("APPRItemQty6");
				}
			}
		}
		public double APPRItemPrice
		{
			get{return _aPPRItemPrice;}
			set
			{
				if (value != this._aPPRItemPrice)
				{
				_aPPRItemPrice=value;
				NotifyChanged("APPRItemPrice");
				}
			}
		}
		public String APPRItemComment
		{
			get{return _aPPRItemComment;}
			set
			{
				if (value != this._aPPRItemComment)
				{
				_aPPRItemComment=value;
				NotifyChanged("APPRItemComment");
				}
			}
		}
		public double APPRItemUnitVolumn
		{
			get{return _aPPRItemUnitVolumn;}
			set
			{
				if (value != this._aPPRItemUnitVolumn)
				{
				_aPPRItemUnitVolumn=value;
				NotifyChanged("APPRItemUnitVolumn");
				}
			}
		}
		public double APPRItemUnitWeight
		{
			get{return _aPPRItemUnitWeight;}
			set
			{
				if (value != this._aPPRItemUnitWeight)
				{
				_aPPRItemUnitWeight=value;
				NotifyChanged("APPRItemUnitWeight");
				}
			}
		}
		public double APPRItemTxAmt
		{
			get{return _aPPRItemTxAmt;}
			set
			{
				if (value != this._aPPRItemTxAmt)
				{
				_aPPRItemTxAmt=value;
				NotifyChanged("APPRItemTxAmt");
				}
			}
		}
		public double APPRItemDiscAmt
		{
			get{return _aPPRItemDiscAmt;}
			set
			{
				if (value != this._aPPRItemDiscAmt)
				{
				_aPPRItemDiscAmt=value;
				NotifyChanged("APPRItemDiscAmt");
				}
			}
		}
		public double APPRItemDiscPct
		{
			get{return _aPPRItemDiscPct;}
			set
			{
				if (value != this._aPPRItemDiscPct)
				{
				_aPPRItemDiscPct=value;
				NotifyChanged("APPRItemDiscPct");
				}
			}
		}
		public double APPRItemNetAmt
		{
			get{return _aPPRItemNetAmt;}
			set
			{
				if (value != this._aPPRItemNetAmt)
				{
				_aPPRItemNetAmt=value;
				NotifyChanged("APPRItemNetAmt");
				}
			}
		}
		public double APPRItemAmtTot
		{
			get{return _aPPRItemAmtTot;}
			set
			{
				if (value != this._aPPRItemAmtTot)
				{
				_aPPRItemAmtTot=value;
				NotifyChanged("APPRItemAmtTot");
				}
			}
		}
		public double APPRItemCostTot
		{
			get{return _aPPRItemCostTot;}
			set
			{
				if (value != this._aPPRItemCostTot)
				{
				_aPPRItemCostTot=value;
				NotifyChanged("APPRItemCostTot");
				}
			}
		}
		public double APPRItemFUnitPrice
		{
			get{return _aPPRItemFUnitPrice;}
			set
			{
				if (value != this._aPPRItemFUnitPrice)
				{
				_aPPRItemFUnitPrice=value;
				NotifyChanged("APPRItemFUnitPrice");
				}
			}
		}
		public double APPRItemFTxAmt
		{
			get{return _aPPRItemFTxAmt;}
			set
			{
				if (value != this._aPPRItemFTxAmt)
				{
				_aPPRItemFTxAmt=value;
				NotifyChanged("APPRItemFTxAmt");
				}
			}
		}
		public double APPRItemFDiscAmt
		{
			get{return _aPPRItemFDiscAmt;}
			set
			{
				if (value != this._aPPRItemFDiscAmt)
				{
				_aPPRItemFDiscAmt=value;
				NotifyChanged("APPRItemFDiscAmt");
				}
			}
		}
		public double APPRItemFPrice
		{
			get{return _aPPRItemFPrice;}
			set
			{
				if (value != this._aPPRItemFPrice)
				{
				_aPPRItemFPrice=value;
				NotifyChanged("APPRItemFPrice");
				}
			}
		}
		public double APPRItemFAmtTot
		{
			get{return _aPPRItemFAmtTot;}
			set
			{
				if (value != this._aPPRItemFAmtTot)
				{
				_aPPRItemFAmtTot=value;
				NotifyChanged("APPRItemFAmtTot");
				}
			}
		}
		public Nullable<DateTime> APPRItemArrivalDate
		{
			get{return _aPPRItemArrivalDate;}
			set
			{
				if (value != this._aPPRItemArrivalDate)
				{
				_aPPRItemArrivalDate=value;
				NotifyChanged("APPRItemArrivalDate");
				}
			}
		}
		public double APPRItemMinStockQty
		{
			get{return _aPPRItemMinStockQty;}
			set
			{
				if (value != this._aPPRItemMinStockQty)
				{
				_aPPRItemMinStockQty=value;
				NotifyChanged("APPRItemMinStockQty");
				}
			}
		}
		public Nullable<DateTime> APPRItemUseDate
		{
			get{return _aPPRItemUseDate;}
			set
			{
				if (value != this._aPPRItemUseDate)
				{
				_aPPRItemUseDate=value;
				NotifyChanged("APPRItemUseDate");
				}
			}
		}
		public String APPRItemUsePurposes
		{
			get{return _aPPRItemUsePurposes;}
			set
			{
				if (value != this._aPPRItemUsePurposes)
				{
				_aPPRItemUsePurposes=value;
				NotifyChanged("APPRItemUsePurposes");
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
		public double APPRItemStkQty
		{
			get{return _aPPRItemStkQty;}
			set
			{
				if (value != this._aPPRItemStkQty)
				{
				_aPPRItemStkQty=value;
				NotifyChanged("APPRItemStkQty");
				}
			}
		}
		public double APPRItemRStkQty
		{
			get{return _aPPRItemRStkQty;}
			set
			{
				if (value != this._aPPRItemRStkQty)
				{
				_aPPRItemRStkQty=value;
				NotifyChanged("APPRItemRStkQty");
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
		public double APPRItemWTot
		{
			get{return _aPPRItemWTot;}
			set
			{
				if (value != this._aPPRItemWTot)
				{
				_aPPRItemWTot=value;
				NotifyChanged("APPRItemWTot");
				}
			}
		}
		public double APPRItemVTot
		{
			get{return _aPPRItemVTot;}
			set
			{
				if (value != this._aPPRItemVTot)
				{
				_aPPRItemVTot=value;
				NotifyChanged("APPRItemVTot");
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
		public double APPRItemFact
		{
			get{return _aPPRItemFact;}
			set
			{
				if (value != this._aPPRItemFact)
				{
				_aPPRItemFact=value;
				NotifyChanged("APPRItemFact");
				}
			}
		}
		public double APPRItemExcQty
		{
			get{return _aPPRItemExcQty;}
			set
			{
				if (value != this._aPPRItemExcQty)
				{
				_aPPRItemExcQty=value;
				NotifyChanged("APPRItemExcQty");
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
		public double APPRItemOrgQty
		{
			get{return _aPPRItemOrgQty;}
			set
			{
				if (value != this._aPPRItemOrgQty)
				{
				_aPPRItemOrgQty=value;
				NotifyChanged("APPRItemOrgQty");
				}
			}
		}
		public double APPRItemCQty
		{
			get{return _aPPRItemCQty;}
			set
			{
				if (value != this._aPPRItemCQty)
				{
				_aPPRItemCQty=value;
				NotifyChanged("APPRItemCQty");
				}
			}
		}
		public String APPRItemProductNo
		{
			get{return _aPPRItemProductNo;}
			set
			{
				if (value != this._aPPRItemProductNo)
				{
				_aPPRItemProductNo=value;
				NotifyChanged("APPRItemProductNo");
				}
			}
		}
		public String APPRItemProductName
		{
			get{return _aPPRItemProductName;}
			set
			{
				if (value != this._aPPRItemProductName)
				{
				_aPPRItemProductName=value;
				NotifyChanged("APPRItemProductName");
				}
			}
		}
		public String APPRItemLine
		{
			get{return _aPPRItemLine;}
			set
			{
				if (value != this._aPPRItemLine)
				{
				_aPPRItemLine=value;
				NotifyChanged("APPRItemLine");
				}
			}
		}
		public int FK_APSupplierID
		{
			get{return _fK_APSupplierID;}
			set
			{
				if (value != this._fK_APSupplierID)
				{
				_fK_APSupplierID=value;
				NotifyChanged("FK_APSupplierID");
				}
			}
		}
		public int FK_APRFQItemID
		{
			get{return _fK_APRFQItemID;}
			set
			{
				if (value != this._fK_APRFQItemID)
				{
				_fK_APRFQItemID=value;
				NotifyChanged("FK_APRFQItemID");
				}
			}
		}
		public double APPRItemInvQty
		{
			get{return _aPPRItemInvQty;}
			set
			{
				if (value != this._aPPRItemInvQty)
				{
				_aPPRItemInvQty=value;
				NotifyChanged("APPRItemInvQty");
				}
			}
		}
		public double APPRItemBOQQty
		{
			get{return _aPPRItemBOQQty;}
			set
			{
				if (value != this._aPPRItemBOQQty)
				{
				_aPPRItemBOQQty=value;
				NotifyChanged("APPRItemBOQQty");
				}
			}
		}
		public String APPRItemOrigin
		{
			get{return _aPPRItemOrigin;}
			set
			{
				if (value != this._aPPRItemOrigin)
				{
				_aPPRItemOrigin=value;
				NotifyChanged("APPRItemOrigin");
				}
			}
		}
		public int FK_APProcurementPlnItemID
		{
			get{return _fK_APProcurementPlnItemID;}
			set
			{
				if (value != this._fK_APProcurementPlnItemID)
				{
				_fK_APProcurementPlnItemID=value;
				NotifyChanged("FK_APProcurementPlnItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}