using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICTransferItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICTransferItemsInfo
	//Created Date:Monday, November 28, 2016
	//-----------------------------------------------------------
	
	public class ICTransferItemsInfo:BusinessObject
	{
		public ICTransferItemsInfo()
		{
		}
		#region Variables
		protected int _iCTransferItemID;
		protected string _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ICTransferID;
		protected int _fK_ICProductID;
		protected int _fK_ICFromStockID;
		protected int _fK_ICToStockID;
		protected int _fK_ICTransitStockID;
		protected int _fK_ICStockSlotID;
		protected int _fK_ICProductTypeID;
		protected int _fK_ARPriceListID;
		protected int _fK_TXTaxCodeID;
		protected string _iCTransferItemSerialNo=string.Empty;
		protected bool _iCTransferItemIsStkItm=true;
		protected string _iCTransferItemType=string.Empty;
		protected string _iCTransferItemDesc=string.Empty;
		protected string _iCTransferItemUOM=string.Empty;
		protected string _iCTransferItemStkUOM=string.Empty;
		protected double _iCTransferItemFact;
		protected string _iCSalePriceCombo=string.Empty;
		protected double _iCTransferItemUnitPrice;
		protected double _iCTransferItemUnitCost;
		protected double _iCTransferItemDiscPct;
		protected double _iCTransferItemTxPct;
		protected double _iCTransferItemVolume;
		protected double _iCTransferItemQty;
		protected double _iCTransferItemStkQty;
		protected double _iCTransferItemRQty;
		protected double _iCTransferItemRStkQty;
		protected double _iCTransferItemPrice;
		protected string _iCTransferItemComment=string.Empty;
		protected double _iCTransferItemUnitVol;
		protected double _iCTransferItemUnitWeight;
		protected double _iCTransferItemTxAmt;
		protected double _iCTransferItemDiscAmt;
		protected double _iCTransferItemNetAmt;
		protected double _iCTransferItemAmtTot;
		protected double _iCTransferItemCostTot;
		protected string _iCTransferItemStatus=DefaultStatus;
		protected double _iCTransferItemAmt;
		protected double _iCTransferItemCAmt;
		protected string _iCTransferItemLotNo=string.Empty;
		protected int _fK_PPWOID;
		protected int _fK_PPPrdQCItemID;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _iCTransferItemWTot;
		protected double _iCTransferItemVTot;
		protected Nullable<DateTime> _iCTransferItemExpireDate;
		protected string _gLTOF01Combo=string.Empty;
		protected string _gLTOF02Combo=string.Empty;
		protected string _gLTOF03Combo=string.Empty;
		protected string _gLTOF04Combo=string.Empty;
		protected string _gLTOF05Combo=string.Empty;
		protected string _gLTOF06Combo=string.Empty;
		protected string _gLTOF07Combo=string.Empty;
		protected string _gLTOF08Combo=string.Empty;
		protected string _gLTOF09Combo=string.Empty;
		protected string _gLTOF10Combo=string.Empty;
		protected int _fK_PPCostCenterID;
		protected int _fK_ICFromStockSlotID;
		protected int _fK_ICToStockSlotID;
		protected double _iCTransferItemFCostTot;
		protected string _iCTransferItemFGLotNo=string.Empty;
		#endregion

		#region Public properties
		public int ICTransferItemID
		{
			get{return _iCTransferItemID;}
			set
			{
				if (value != this._iCTransferItemID)
				{
				_iCTransferItemID=value;
				NotifyChanged("ICTransferItemID");
				}
			}
		}
		public string AAStatus
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
		public int FK_ICTransferID
		{
			get{return _fK_ICTransferID;}
			set
			{
				if (value != this._fK_ICTransferID)
				{
				_fK_ICTransferID=value;
				NotifyChanged("FK_ICTransferID");
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
		public int FK_ICFromStockID
		{
			get{return _fK_ICFromStockID;}
			set
			{
				if (value != this._fK_ICFromStockID)
				{
				_fK_ICFromStockID=value;
				NotifyChanged("FK_ICFromStockID");
				}
			}
		}
		public int FK_ICToStockID
		{
			get{return _fK_ICToStockID;}
			set
			{
				if (value != this._fK_ICToStockID)
				{
				_fK_ICToStockID=value;
				NotifyChanged("FK_ICToStockID");
				}
			}
		}
		public int FK_ICTransitStockID
		{
			get{return _fK_ICTransitStockID;}
			set
			{
				if (value != this._fK_ICTransitStockID)
				{
				_fK_ICTransitStockID=value;
				NotifyChanged("FK_ICTransitStockID");
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
		public string ICTransferItemSerialNo
		{
			get{return _iCTransferItemSerialNo;}
			set
			{
				if (value != this._iCTransferItemSerialNo)
				{
				_iCTransferItemSerialNo=value;
				NotifyChanged("ICTransferItemSerialNo");
				}
			}
		}
		public bool ICTransferItemIsStkItm
		{
			get{return _iCTransferItemIsStkItm;}
			set
			{
				if (value != this._iCTransferItemIsStkItm)
				{
				_iCTransferItemIsStkItm=value;
				NotifyChanged("ICTransferItemIsStkItm");
				}
			}
		}
		public string ICTransferItemType
		{
			get{return _iCTransferItemType;}
			set
			{
				if (value != this._iCTransferItemType)
				{
				_iCTransferItemType=value;
				NotifyChanged("ICTransferItemType");
				}
			}
		}
		public string ICTransferItemDesc
		{
			get{return _iCTransferItemDesc;}
			set
			{
				if (value != this._iCTransferItemDesc)
				{
				_iCTransferItemDesc=value;
				NotifyChanged("ICTransferItemDesc");
				}
			}
		}
		public string ICTransferItemUOM
		{
			get{return _iCTransferItemUOM;}
			set
			{
				if (value != this._iCTransferItemUOM)
				{
				_iCTransferItemUOM=value;
				NotifyChanged("ICTransferItemUOM");
				}
			}
		}
		public string ICTransferItemStkUOM
		{
			get{return _iCTransferItemStkUOM;}
			set
			{
				if (value != this._iCTransferItemStkUOM)
				{
				_iCTransferItemStkUOM=value;
				NotifyChanged("ICTransferItemStkUOM");
				}
			}
		}
		public double ICTransferItemFact
		{
			get{return _iCTransferItemFact;}
			set
			{
				if (value != this._iCTransferItemFact)
				{
				_iCTransferItemFact=value;
				NotifyChanged("ICTransferItemFact");
				}
			}
		}
		public string ICSalePriceCombo
		{
			get{return _iCSalePriceCombo;}
			set
			{
				if (value != this._iCSalePriceCombo)
				{
				_iCSalePriceCombo=value;
				NotifyChanged("ICSalePriceCombo");
				}
			}
		}
		public double ICTransferItemUnitPrice
		{
			get{return _iCTransferItemUnitPrice;}
			set
			{
				if (value != this._iCTransferItemUnitPrice)
				{
				_iCTransferItemUnitPrice=value;
				NotifyChanged("ICTransferItemUnitPrice");
				}
			}
		}
		public double ICTransferItemUnitCost
		{
			get{return _iCTransferItemUnitCost;}
			set
			{
				if (value != this._iCTransferItemUnitCost)
				{
				_iCTransferItemUnitCost=value;
				NotifyChanged("ICTransferItemUnitCost");
				}
			}
		}
		public double ICTransferItemDiscPct
		{
			get{return _iCTransferItemDiscPct;}
			set
			{
				if (value != this._iCTransferItemDiscPct)
				{
				_iCTransferItemDiscPct=value;
				NotifyChanged("ICTransferItemDiscPct");
				}
			}
		}
		public double ICTransferItemTxPct
		{
			get{return _iCTransferItemTxPct;}
			set
			{
				if (value != this._iCTransferItemTxPct)
				{
				_iCTransferItemTxPct=value;
				NotifyChanged("ICTransferItemTxPct");
				}
			}
		}
		public double ICTransferItemVolume
		{
			get{return _iCTransferItemVolume;}
			set
			{
				if (value != this._iCTransferItemVolume)
				{
				_iCTransferItemVolume=value;
				NotifyChanged("ICTransferItemVolume");
				}
			}
		}
		public double ICTransferItemQty
		{
			get{return _iCTransferItemQty;}
			set
			{
				if (value != this._iCTransferItemQty)
				{
				_iCTransferItemQty=value;
				NotifyChanged("ICTransferItemQty");
				}
			}
		}
		public double ICTransferItemStkQty
		{
			get{return _iCTransferItemStkQty;}
			set
			{
				if (value != this._iCTransferItemStkQty)
				{
				_iCTransferItemStkQty=value;
				NotifyChanged("ICTransferItemStkQty");
				}
			}
		}
		public double ICTransferItemRQty
		{
			get{return _iCTransferItemRQty;}
			set
			{
				if (value != this._iCTransferItemRQty)
				{
				_iCTransferItemRQty=value;
				NotifyChanged("ICTransferItemRQty");
				}
			}
		}
		public double ICTransferItemRStkQty
		{
			get{return _iCTransferItemRStkQty;}
			set
			{
				if (value != this._iCTransferItemRStkQty)
				{
				_iCTransferItemRStkQty=value;
				NotifyChanged("ICTransferItemRStkQty");
				}
			}
		}
		public double ICTransferItemPrice
		{
			get{return _iCTransferItemPrice;}
			set
			{
				if (value != this._iCTransferItemPrice)
				{
				_iCTransferItemPrice=value;
				NotifyChanged("ICTransferItemPrice");
				}
			}
		}
		public string ICTransferItemComment
		{
			get{return _iCTransferItemComment;}
			set
			{
				if (value != this._iCTransferItemComment)
				{
				_iCTransferItemComment=value;
				NotifyChanged("ICTransferItemComment");
				}
			}
		}
		public double ICTransferItemUnitVol
		{
			get{return _iCTransferItemUnitVol;}
			set
			{
				if (value != this._iCTransferItemUnitVol)
				{
				_iCTransferItemUnitVol=value;
				NotifyChanged("ICTransferItemUnitVol");
				}
			}
		}
		public double ICTransferItemUnitWeight
		{
			get{return _iCTransferItemUnitWeight;}
			set
			{
				if (value != this._iCTransferItemUnitWeight)
				{
				_iCTransferItemUnitWeight=value;
				NotifyChanged("ICTransferItemUnitWeight");
				}
			}
		}
		public double ICTransferItemTxAmt
		{
			get{return _iCTransferItemTxAmt;}
			set
			{
				if (value != this._iCTransferItemTxAmt)
				{
				_iCTransferItemTxAmt=value;
				NotifyChanged("ICTransferItemTxAmt");
				}
			}
		}
		public double ICTransferItemDiscAmt
		{
			get{return _iCTransferItemDiscAmt;}
			set
			{
				if (value != this._iCTransferItemDiscAmt)
				{
				_iCTransferItemDiscAmt=value;
				NotifyChanged("ICTransferItemDiscAmt");
				}
			}
		}
		public double ICTransferItemNetAmt
		{
			get{return _iCTransferItemNetAmt;}
			set
			{
				if (value != this._iCTransferItemNetAmt)
				{
				_iCTransferItemNetAmt=value;
				NotifyChanged("ICTransferItemNetAmt");
				}
			}
		}
		public double ICTransferItemAmtTot
		{
			get{return _iCTransferItemAmtTot;}
			set
			{
				if (value != this._iCTransferItemAmtTot)
				{
				_iCTransferItemAmtTot=value;
				NotifyChanged("ICTransferItemAmtTot");
				}
			}
		}
		public double ICTransferItemCostTot
		{
			get{return _iCTransferItemCostTot;}
			set
			{
				if (value != this._iCTransferItemCostTot)
				{
				_iCTransferItemCostTot=value;
				NotifyChanged("ICTransferItemCostTot");
				}
			}
		}
		public string ICTransferItemStatus
		{
			get{return _iCTransferItemStatus;}
			set
			{
				if (value != this._iCTransferItemStatus)
				{
				_iCTransferItemStatus=value;
				NotifyChanged("ICTransferItemStatus");
				}
			}
		}
		public double ICTransferItemAmt
		{
			get{return _iCTransferItemAmt;}
			set
			{
				if (value != this._iCTransferItemAmt)
				{
				_iCTransferItemAmt=value;
				NotifyChanged("ICTransferItemAmt");
				}
			}
		}
		public double ICTransferItemCAmt
		{
			get{return _iCTransferItemCAmt;}
			set
			{
				if (value != this._iCTransferItemCAmt)
				{
				_iCTransferItemCAmt=value;
				NotifyChanged("ICTransferItemCAmt");
				}
			}
		}
		public string ICTransferItemLotNo
		{
			get{return _iCTransferItemLotNo;}
			set
			{
				if (value != this._iCTransferItemLotNo)
				{
				_iCTransferItemLotNo=value;
				NotifyChanged("ICTransferItemLotNo");
				}
			}
		}
		public int FK_PPWOID
		{
			get{return _fK_PPWOID;}
			set
			{
				if (value != this._fK_PPWOID)
				{
				_fK_PPWOID=value;
				NotifyChanged("FK_PPWOID");
				}
			}
		}
		public int FK_PPPrdQCItemID
		{
			get{return _fK_PPPrdQCItemID;}
			set
			{
				if (value != this._fK_PPPrdQCItemID)
				{
				_fK_PPPrdQCItemID=value;
				NotifyChanged("FK_PPPrdQCItemID");
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
		public double ICTransferItemWTot
		{
			get{return _iCTransferItemWTot;}
			set
			{
				if (value != this._iCTransferItemWTot)
				{
				_iCTransferItemWTot=value;
				NotifyChanged("ICTransferItemWTot");
				}
			}
		}
		public double ICTransferItemVTot
		{
			get{return _iCTransferItemVTot;}
			set
			{
				if (value != this._iCTransferItemVTot)
				{
				_iCTransferItemVTot=value;
				NotifyChanged("ICTransferItemVTot");
				}
			}
		}
		public Nullable<DateTime> ICTransferItemExpireDate
		{
			get{return _iCTransferItemExpireDate;}
			set
			{
				if (value != this._iCTransferItemExpireDate)
				{
				_iCTransferItemExpireDate=value;
				NotifyChanged("ICTransferItemExpireDate");
				}
			}
		}
		public string GLTOF01Combo
		{
			get{return _gLTOF01Combo;}
			set
			{
				if (value != this._gLTOF01Combo)
				{
				_gLTOF01Combo=value;
				NotifyChanged("GLTOF01Combo");
				}
			}
		}
		public string GLTOF02Combo
		{
			get{return _gLTOF02Combo;}
			set
			{
				if (value != this._gLTOF02Combo)
				{
				_gLTOF02Combo=value;
				NotifyChanged("GLTOF02Combo");
				}
			}
		}
		public string GLTOF03Combo
		{
			get{return _gLTOF03Combo;}
			set
			{
				if (value != this._gLTOF03Combo)
				{
				_gLTOF03Combo=value;
				NotifyChanged("GLTOF03Combo");
				}
			}
		}
		public string GLTOF04Combo
		{
			get{return _gLTOF04Combo;}
			set
			{
				if (value != this._gLTOF04Combo)
				{
				_gLTOF04Combo=value;
				NotifyChanged("GLTOF04Combo");
				}
			}
		}
		public string GLTOF05Combo
		{
			get{return _gLTOF05Combo;}
			set
			{
				if (value != this._gLTOF05Combo)
				{
				_gLTOF05Combo=value;
				NotifyChanged("GLTOF05Combo");
				}
			}
		}
		public string GLTOF06Combo
		{
			get{return _gLTOF06Combo;}
			set
			{
				if (value != this._gLTOF06Combo)
				{
				_gLTOF06Combo=value;
				NotifyChanged("GLTOF06Combo");
				}
			}
		}
		public string GLTOF07Combo
		{
			get{return _gLTOF07Combo;}
			set
			{
				if (value != this._gLTOF07Combo)
				{
				_gLTOF07Combo=value;
				NotifyChanged("GLTOF07Combo");
				}
			}
		}
		public string GLTOF08Combo
		{
			get{return _gLTOF08Combo;}
			set
			{
				if (value != this._gLTOF08Combo)
				{
				_gLTOF08Combo=value;
				NotifyChanged("GLTOF08Combo");
				}
			}
		}
		public string GLTOF09Combo
		{
			get{return _gLTOF09Combo;}
			set
			{
				if (value != this._gLTOF09Combo)
				{
				_gLTOF09Combo=value;
				NotifyChanged("GLTOF09Combo");
				}
			}
		}
		public string GLTOF10Combo
		{
			get{return _gLTOF10Combo;}
			set
			{
				if (value != this._gLTOF10Combo)
				{
				_gLTOF10Combo=value;
				NotifyChanged("GLTOF10Combo");
				}
			}
		}
		public int FK_PPCostCenterID
		{
			get{return _fK_PPCostCenterID;}
			set
			{
				if (value != this._fK_PPCostCenterID)
				{
				_fK_PPCostCenterID=value;
				NotifyChanged("FK_PPCostCenterID");
				}
			}
		}
		public int FK_ICFromStockSlotID
		{
			get{return _fK_ICFromStockSlotID;}
			set
			{
				if (value != this._fK_ICFromStockSlotID)
				{
				_fK_ICFromStockSlotID=value;
				NotifyChanged("FK_ICFromStockSlotID");
				}
			}
		}
		public int FK_ICToStockSlotID
		{
			get{return _fK_ICToStockSlotID;}
			set
			{
				if (value != this._fK_ICToStockSlotID)
				{
				_fK_ICToStockSlotID=value;
				NotifyChanged("FK_ICToStockSlotID");
				}
			}
		}
		public double ICTransferItemFCostTot
		{
			get{return _iCTransferItemFCostTot;}
			set
			{
				if (value != this._iCTransferItemFCostTot)
				{
				_iCTransferItemFCostTot=value;
				NotifyChanged("ICTransferItemFCostTot");
				}
			}
		}
		public string ICTransferItemFGLotNo
		{
			get{return _iCTransferItemFGLotNo;}
			set
			{
				if (value != this._iCTransferItemFGLotNo)
				{
				_iCTransferItemFGLotNo=value;
				NotifyChanged("ICTransferItemFGLotNo");
				}
			}
		}
		#endregion
	}
	#endregion
}