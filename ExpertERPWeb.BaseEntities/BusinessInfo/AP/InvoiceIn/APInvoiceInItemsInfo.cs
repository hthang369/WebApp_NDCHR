using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APInvoiceInItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APInvoiceInItemsInfo
	//Created Date:05 November 2014
	//-----------------------------------------------------------
	
	public class APInvoiceInItemsInfo:BusinessObject
	{
		public APInvoiceInItemsInfo()
		{
		}
		#region Variables
		protected int _aPInvoiceInItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APInvoiceInID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICStockSlotID;
		protected String _aPInvoiceInItemProductType=String.Empty;
		protected int _aPInvoiceInItemSortOrder;
		protected String _aPInvoiceInItemProductDesc=String.Empty;
		protected String _aPInvoiceInItemProductSellUnit=String.Empty;
		protected String _aPInvoiceInItemProductBasicUnit=String.Empty;
		protected String _aPInvoiceInItemProductPackagingUnit=String.Empty;
		protected double _aPInvoiceInItemProductSellFactor;
		protected double _aPInvoiceInItemProductPackagingFactor;
		protected double _aPInvoiceInItemProductUnitPrice;
		protected double _aPInvoiceInItemProductUnitCost;
		protected double _aPInvoiceInItemProductGroupDiscount;
		protected double _aPInvoiceInItemProductDiscount;
		protected double _aPInvoiceInItemProductTaxPercent;
		protected double _aPInvoiceInItemProductQtyOld;
		protected double _aPInvoiceInItemProductQty;
		protected double _aPInvoiceInItemProductBasicQty;
		protected double _aPInvoiceInItemProductPakagingQty;
		protected double _aPInvoiceInItemQty1;
		protected double _aPInvoiceInItemQty2;
		protected double _aPInvoiceInItemQty3;
		protected double _aPInvoiceInItemQty4;
		protected double _aPInvoiceInItemQty5;
		protected double _aPInvoiceInItemQty6;
		protected double _aPInvoiceInItemPrice;
		protected String _aPInvoiceInItemComment=String.Empty;
		protected double _aPInvoiceInItemUnitVolumn;
		protected double _aPInvoiceInItemUnitWeight;
		protected double _aPInvoiceInItemTaxAmount;
		protected double _aPInvoiceInItemDiscountAmount;
		protected double _aPInvoiceInItemNetAmount;
		protected double _aPInvoiceInItemTotalAmount;
		protected double _aPInvoiceInItemTotalCost;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _aPInvoiceInItemRQty;
		protected double _aPInvoiceInItemStkQty;
		protected double _aPInvoiceInItemRStkQty;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _aPInvoiceInItemWTot;
		protected double _aPInvoiceInItemVTot;
		#endregion

		#region Public properties
		public int APInvoiceInItemID
		{
			get{return _aPInvoiceInItemID;}
			set
			{
				if (value != this._aPInvoiceInItemID)
				{
				_aPInvoiceInItemID=value;
				NotifyChanged("APInvoiceInItemID");
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
		public int FK_APInvoiceInID
		{
			get{return _fK_APInvoiceInID;}
			set
			{
				if (value != this._fK_APInvoiceInID)
				{
				_fK_APInvoiceInID=value;
				NotifyChanged("FK_APInvoiceInID");
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
		public String APInvoiceInItemProductType
		{
			get{return _aPInvoiceInItemProductType;}
			set
			{
				if (value != this._aPInvoiceInItemProductType)
				{
				_aPInvoiceInItemProductType=value;
				NotifyChanged("APInvoiceInItemProductType");
				}
			}
		}
		public int APInvoiceInItemSortOrder
		{
			get{return _aPInvoiceInItemSortOrder;}
			set
			{
				if (value != this._aPInvoiceInItemSortOrder)
				{
				_aPInvoiceInItemSortOrder=value;
				NotifyChanged("APInvoiceInItemSortOrder");
				}
			}
		}
		public String APInvoiceInItemProductDesc
		{
			get{return _aPInvoiceInItemProductDesc;}
			set
			{
				if (value != this._aPInvoiceInItemProductDesc)
				{
				_aPInvoiceInItemProductDesc=value;
				NotifyChanged("APInvoiceInItemProductDesc");
				}
			}
		}
		public String APInvoiceInItemProductSellUnit
		{
			get{return _aPInvoiceInItemProductSellUnit;}
			set
			{
				if (value != this._aPInvoiceInItemProductSellUnit)
				{
				_aPInvoiceInItemProductSellUnit=value;
				NotifyChanged("APInvoiceInItemProductSellUnit");
				}
			}
		}
		public String APInvoiceInItemProductBasicUnit
		{
			get{return _aPInvoiceInItemProductBasicUnit;}
			set
			{
				if (value != this._aPInvoiceInItemProductBasicUnit)
				{
				_aPInvoiceInItemProductBasicUnit=value;
				NotifyChanged("APInvoiceInItemProductBasicUnit");
				}
			}
		}
		public String APInvoiceInItemProductPackagingUnit
		{
			get{return _aPInvoiceInItemProductPackagingUnit;}
			set
			{
				if (value != this._aPInvoiceInItemProductPackagingUnit)
				{
				_aPInvoiceInItemProductPackagingUnit=value;
				NotifyChanged("APInvoiceInItemProductPackagingUnit");
				}
			}
		}
		public double APInvoiceInItemProductSellFactor
		{
			get{return _aPInvoiceInItemProductSellFactor;}
			set
			{
				if (value != this._aPInvoiceInItemProductSellFactor)
				{
				_aPInvoiceInItemProductSellFactor=value;
				NotifyChanged("APInvoiceInItemProductSellFactor");
				}
			}
		}
		public double APInvoiceInItemProductPackagingFactor
		{
			get{return _aPInvoiceInItemProductPackagingFactor;}
			set
			{
				if (value != this._aPInvoiceInItemProductPackagingFactor)
				{
				_aPInvoiceInItemProductPackagingFactor=value;
				NotifyChanged("APInvoiceInItemProductPackagingFactor");
				}
			}
		}
		public double APInvoiceInItemProductUnitPrice
		{
			get{return _aPInvoiceInItemProductUnitPrice;}
			set
			{
				if (value != this._aPInvoiceInItemProductUnitPrice)
				{
				_aPInvoiceInItemProductUnitPrice=value;
				NotifyChanged("APInvoiceInItemProductUnitPrice");
				}
			}
		}
		public double APInvoiceInItemProductUnitCost
		{
			get{return _aPInvoiceInItemProductUnitCost;}
			set
			{
				if (value != this._aPInvoiceInItemProductUnitCost)
				{
				_aPInvoiceInItemProductUnitCost=value;
				NotifyChanged("APInvoiceInItemProductUnitCost");
				}
			}
		}
		public double APInvoiceInItemProductGroupDiscount
		{
			get{return _aPInvoiceInItemProductGroupDiscount;}
			set
			{
				if (value != this._aPInvoiceInItemProductGroupDiscount)
				{
				_aPInvoiceInItemProductGroupDiscount=value;
				NotifyChanged("APInvoiceInItemProductGroupDiscount");
				}
			}
		}
		public double APInvoiceInItemProductDiscount
		{
			get{return _aPInvoiceInItemProductDiscount;}
			set
			{
				if (value != this._aPInvoiceInItemProductDiscount)
				{
				_aPInvoiceInItemProductDiscount=value;
				NotifyChanged("APInvoiceInItemProductDiscount");
				}
			}
		}
		public double APInvoiceInItemProductTaxPercent
		{
			get{return _aPInvoiceInItemProductTaxPercent;}
			set
			{
				if (value != this._aPInvoiceInItemProductTaxPercent)
				{
				_aPInvoiceInItemProductTaxPercent=value;
				NotifyChanged("APInvoiceInItemProductTaxPercent");
				}
			}
		}
		public double APInvoiceInItemProductQtyOld
		{
			get{return _aPInvoiceInItemProductQtyOld;}
			set
			{
				if (value != this._aPInvoiceInItemProductQtyOld)
				{
				_aPInvoiceInItemProductQtyOld=value;
				NotifyChanged("APInvoiceInItemProductQtyOld");
				}
			}
		}
		public double APInvoiceInItemProductQty
		{
			get{return _aPInvoiceInItemProductQty;}
			set
			{
				if (value != this._aPInvoiceInItemProductQty)
				{
				_aPInvoiceInItemProductQty=value;
				NotifyChanged("APInvoiceInItemProductQty");
				}
			}
		}
		public double APInvoiceInItemProductBasicQty
		{
			get{return _aPInvoiceInItemProductBasicQty;}
			set
			{
				if (value != this._aPInvoiceInItemProductBasicQty)
				{
				_aPInvoiceInItemProductBasicQty=value;
				NotifyChanged("APInvoiceInItemProductBasicQty");
				}
			}
		}
		public double APInvoiceInItemProductPakagingQty
		{
			get{return _aPInvoiceInItemProductPakagingQty;}
			set
			{
				if (value != this._aPInvoiceInItemProductPakagingQty)
				{
				_aPInvoiceInItemProductPakagingQty=value;
				NotifyChanged("APInvoiceInItemProductPakagingQty");
				}
			}
		}
		public double APInvoiceInItemQty1
		{
			get{return _aPInvoiceInItemQty1;}
			set
			{
				if (value != this._aPInvoiceInItemQty1)
				{
				_aPInvoiceInItemQty1=value;
				NotifyChanged("APInvoiceInItemQty1");
				}
			}
		}
		public double APInvoiceInItemQty2
		{
			get{return _aPInvoiceInItemQty2;}
			set
			{
				if (value != this._aPInvoiceInItemQty2)
				{
				_aPInvoiceInItemQty2=value;
				NotifyChanged("APInvoiceInItemQty2");
				}
			}
		}
		public double APInvoiceInItemQty3
		{
			get{return _aPInvoiceInItemQty3;}
			set
			{
				if (value != this._aPInvoiceInItemQty3)
				{
				_aPInvoiceInItemQty3=value;
				NotifyChanged("APInvoiceInItemQty3");
				}
			}
		}
		public double APInvoiceInItemQty4
		{
			get{return _aPInvoiceInItemQty4;}
			set
			{
				if (value != this._aPInvoiceInItemQty4)
				{
				_aPInvoiceInItemQty4=value;
				NotifyChanged("APInvoiceInItemQty4");
				}
			}
		}
		public double APInvoiceInItemQty5
		{
			get{return _aPInvoiceInItemQty5;}
			set
			{
				if (value != this._aPInvoiceInItemQty5)
				{
				_aPInvoiceInItemQty5=value;
				NotifyChanged("APInvoiceInItemQty5");
				}
			}
		}
		public double APInvoiceInItemQty6
		{
			get{return _aPInvoiceInItemQty6;}
			set
			{
				if (value != this._aPInvoiceInItemQty6)
				{
				_aPInvoiceInItemQty6=value;
				NotifyChanged("APInvoiceInItemQty6");
				}
			}
		}
		public double APInvoiceInItemPrice
		{
			get{return _aPInvoiceInItemPrice;}
			set
			{
				if (value != this._aPInvoiceInItemPrice)
				{
				_aPInvoiceInItemPrice=value;
				NotifyChanged("APInvoiceInItemPrice");
				}
			}
		}
		public String APInvoiceInItemComment
		{
			get{return _aPInvoiceInItemComment;}
			set
			{
				if (value != this._aPInvoiceInItemComment)
				{
				_aPInvoiceInItemComment=value;
				NotifyChanged("APInvoiceInItemComment");
				}
			}
		}
		public double APInvoiceInItemUnitVolumn
		{
			get{return _aPInvoiceInItemUnitVolumn;}
			set
			{
				if (value != this._aPInvoiceInItemUnitVolumn)
				{
				_aPInvoiceInItemUnitVolumn=value;
				NotifyChanged("APInvoiceInItemUnitVolumn");
				}
			}
		}
		public double APInvoiceInItemUnitWeight
		{
			get{return _aPInvoiceInItemUnitWeight;}
			set
			{
				if (value != this._aPInvoiceInItemUnitWeight)
				{
				_aPInvoiceInItemUnitWeight=value;
				NotifyChanged("APInvoiceInItemUnitWeight");
				}
			}
		}
		public double APInvoiceInItemTaxAmount
		{
			get{return _aPInvoiceInItemTaxAmount;}
			set
			{
				if (value != this._aPInvoiceInItemTaxAmount)
				{
				_aPInvoiceInItemTaxAmount=value;
				NotifyChanged("APInvoiceInItemTaxAmount");
				}
			}
		}
		public double APInvoiceInItemDiscountAmount
		{
			get{return _aPInvoiceInItemDiscountAmount;}
			set
			{
				if (value != this._aPInvoiceInItemDiscountAmount)
				{
				_aPInvoiceInItemDiscountAmount=value;
				NotifyChanged("APInvoiceInItemDiscountAmount");
				}
			}
		}
		public double APInvoiceInItemNetAmount
		{
			get{return _aPInvoiceInItemNetAmount;}
			set
			{
				if (value != this._aPInvoiceInItemNetAmount)
				{
				_aPInvoiceInItemNetAmount=value;
				NotifyChanged("APInvoiceInItemNetAmount");
				}
			}
		}
		public double APInvoiceInItemTotalAmount
		{
			get{return _aPInvoiceInItemTotalAmount;}
			set
			{
				if (value != this._aPInvoiceInItemTotalAmount)
				{
				_aPInvoiceInItemTotalAmount=value;
				NotifyChanged("APInvoiceInItemTotalAmount");
				}
			}
		}
		public double APInvoiceInItemTotalCost
		{
			get{return _aPInvoiceInItemTotalCost;}
			set
			{
				if (value != this._aPInvoiceInItemTotalCost)
				{
				_aPInvoiceInItemTotalCost=value;
				NotifyChanged("APInvoiceInItemTotalCost");
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
		public double APInvoiceInItemRQty
		{
			get{return _aPInvoiceInItemRQty;}
			set
			{
				if (value != this._aPInvoiceInItemRQty)
				{
				_aPInvoiceInItemRQty=value;
				NotifyChanged("APInvoiceInItemRQty");
				}
			}
		}
		public double APInvoiceInItemStkQty
		{
			get{return _aPInvoiceInItemStkQty;}
			set
			{
				if (value != this._aPInvoiceInItemStkQty)
				{
				_aPInvoiceInItemStkQty=value;
				NotifyChanged("APInvoiceInItemStkQty");
				}
			}
		}
		public double APInvoiceInItemRStkQty
		{
			get{return _aPInvoiceInItemRStkQty;}
			set
			{
				if (value != this._aPInvoiceInItemRStkQty)
				{
				_aPInvoiceInItemRStkQty=value;
				NotifyChanged("APInvoiceInItemRStkQty");
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
		public double APInvoiceInItemWTot
		{
			get{return _aPInvoiceInItemWTot;}
			set
			{
				if (value != this._aPInvoiceInItemWTot)
				{
				_aPInvoiceInItemWTot=value;
				NotifyChanged("APInvoiceInItemWTot");
				}
			}
		}
		public double APInvoiceInItemVTot
		{
			get{return _aPInvoiceInItemVTot;}
			set
			{
				if (value != this._aPInvoiceInItemVTot)
				{
				_aPInvoiceInItemVTot=value;
				NotifyChanged("APInvoiceInItemVTot");
				}
			}
		}
		#endregion
	}
	#endregion
}