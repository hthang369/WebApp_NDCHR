using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPriceListDetails
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPriceListDetailsInfo
	//Created Date:Monday, May 18, 2015
	//-----------------------------------------------------------
	
	public class APPriceListDetailsInfo:BusinessObject
	{
		public APPriceListDetailsInfo()
		{
		}
		#region Variables
		protected int _aPPriceListDetailID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_APPriceListID;
		protected int _fK_ICProductID;
		protected int _fK_GECurrencyID;
		protected String _aPPriceListDetailName=String.Empty;
		protected double _aPPriceListDetailOrgPrice;
		protected double _aPPriceListDetailProductSalePrice;
		protected double _aPPriceListDetailProductDiscountPercent;
		protected Nullable<DateTime> _aPPriceListDetailFromDate;
		protected Nullable<DateTime> _aPPriceListDetailToDate;
		protected double _aPPriceListDetailFromQuantity;
		protected double _aPPriceListDetailToQuantity;
		protected int _fK_TXTaxCodeID;
		protected String _aPPriceListDetailSerialNo=String.Empty;
		protected bool _aPPriceListDetailIsStkItm=true;
		protected String _aPPriceListDetailType=String.Empty;
		protected int _aPPriceListDetailInvoicertOrder;
		protected String _aPPriceListDetailDesc=String.Empty;
		protected String _aPPriceListDetailUOM=String.Empty;
		protected String _aPPriceListDetailStkUOM=String.Empty;
		protected double _aPPriceListDetailFact;
		protected String _aPSalePriceCombo=String.Empty;
		protected double _aPPriceListDetailUnitPrice;
		protected double _aPPriceListDetailFUnitPrice;
		protected double _aPPriceListDetailUnitCost;
		protected double _aPPriceListDetailDiscPct;
		protected double _aPPriceListDetailTxPct;
		protected double _aPPriceListDetailQty;
		protected double _aPPriceListDetailStkQty;
		protected double _aPPriceListDetailRQty;
		protected double _aPPriceListDetailRStkQty;
		protected double _aPPriceListDetailPrice;
		protected double _aPPriceListDetailFPrice;
		protected String _aPPriceListDetailComment=String.Empty;
		protected double _aPPriceListDetailUnitVolumn;
		protected double _aPPriceListDetailUnitWeight;
		protected double _aPPriceListDetailTxAmt;
		protected double _aPPriceListDetailFTxAmt;
		protected double _aPPriceListDetailDiscAmt;
		protected double _aPPriceListDetailFDiscAmt;
		protected double _aPPriceListDetailNetAmt;
		protected double _aPPriceListDetailFNetAmt;
		protected double _aPPriceListDetailAmtTot;
		protected double _aPPriceListDetailFAmtTot;
		protected double _aPPriceListDetailCostTot;
		protected String _aPPriceListDetailStatus=DefaultStatus;
		protected double _aPPriceListDetailImpTxAmt;
		protected double _aPPriceListDetailImpTxPct;
		protected double _aPPriceListDetailFImpTxAmt;
		protected double _aPPriceListDetailShpAmt;
		protected double _aPPriceListDetailMiscChargeAmt;
		protected String _aPPriceListDetailPurchaseReturnStatusCombo=DefaultStatus;
		protected double _aPPriceListDetailPurchaseReturnRQty;
		protected String _aPPriceListDetailAPCreditNoteStatusCombo=DefaultStatus;
		protected double _aPPriceListDetailAPCreditNoteRQty;
		protected String _aPPriceListDetailRcpNo=String.Empty;
		protected double _aPPriceListDetailAllocateLife;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _aPPriceListDetailWTot;
		protected double _aPPriceListDetailVTot;
		protected int _fK_ADOFID;
		protected int _fK_ADOFItemID;
		#endregion

		#region Public properties
		public int APPriceListDetailID
		{
			get{return _aPPriceListDetailID;}
			set
			{
				if (value != this._aPPriceListDetailID)
				{
				_aPPriceListDetailID=value;
				NotifyChanged("APPriceListDetailID");
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
		public int FK_APPriceListID
		{
			get{return _fK_APPriceListID;}
			set
			{
				if (value != this._fK_APPriceListID)
				{
				_fK_APPriceListID=value;
				NotifyChanged("FK_APPriceListID");
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
		public int FK_GECurrencyID
		{
			get{return _fK_GECurrencyID;}
			set
			{
				if (value != this._fK_GECurrencyID)
				{
				_fK_GECurrencyID=value;
				NotifyChanged("FK_GECurrencyID");
				}
			}
		}
		public String APPriceListDetailName
		{
			get{return _aPPriceListDetailName;}
			set
			{
				if (value != this._aPPriceListDetailName)
				{
				_aPPriceListDetailName=value;
				NotifyChanged("APPriceListDetailName");
				}
			}
		}
		public double APPriceListDetailOrgPrice
		{
			get{return _aPPriceListDetailOrgPrice;}
			set
			{
				if (value != this._aPPriceListDetailOrgPrice)
				{
				_aPPriceListDetailOrgPrice=value;
				NotifyChanged("APPriceListDetailOrgPrice");
				}
			}
		}
		public double APPriceListDetailProductSalePrice
		{
			get{return _aPPriceListDetailProductSalePrice;}
			set
			{
				if (value != this._aPPriceListDetailProductSalePrice)
				{
				_aPPriceListDetailProductSalePrice=value;
				NotifyChanged("APPriceListDetailProductSalePrice");
				}
			}
		}
		public double APPriceListDetailProductDiscountPercent
		{
			get{return _aPPriceListDetailProductDiscountPercent;}
			set
			{
				if (value != this._aPPriceListDetailProductDiscountPercent)
				{
				_aPPriceListDetailProductDiscountPercent=value;
				NotifyChanged("APPriceListDetailProductDiscountPercent");
				}
			}
		}
		public Nullable<DateTime> APPriceListDetailFromDate
		{
			get{return _aPPriceListDetailFromDate;}
			set
			{
				if (value != this._aPPriceListDetailFromDate)
				{
				_aPPriceListDetailFromDate=value;
				NotifyChanged("APPriceListDetailFromDate");
				}
			}
		}
		public Nullable<DateTime> APPriceListDetailToDate
		{
			get{return _aPPriceListDetailToDate;}
			set
			{
				if (value != this._aPPriceListDetailToDate)
				{
				_aPPriceListDetailToDate=value;
				NotifyChanged("APPriceListDetailToDate");
				}
			}
		}
		public double APPriceListDetailFromQuantity
		{
			get{return _aPPriceListDetailFromQuantity;}
			set
			{
				if (value != this._aPPriceListDetailFromQuantity)
				{
				_aPPriceListDetailFromQuantity=value;
				NotifyChanged("APPriceListDetailFromQuantity");
				}
			}
		}
		public double APPriceListDetailToQuantity
		{
			get{return _aPPriceListDetailToQuantity;}
			set
			{
				if (value != this._aPPriceListDetailToQuantity)
				{
				_aPPriceListDetailToQuantity=value;
				NotifyChanged("APPriceListDetailToQuantity");
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
		public String APPriceListDetailSerialNo
		{
			get{return _aPPriceListDetailSerialNo;}
			set
			{
				if (value != this._aPPriceListDetailSerialNo)
				{
				_aPPriceListDetailSerialNo=value;
				NotifyChanged("APPriceListDetailSerialNo");
				}
			}
		}
		public bool APPriceListDetailIsStkItm
		{
			get{return _aPPriceListDetailIsStkItm;}
			set
			{
				if (value != this._aPPriceListDetailIsStkItm)
				{
				_aPPriceListDetailIsStkItm=value;
				NotifyChanged("APPriceListDetailIsStkItm");
				}
			}
		}
		public String APPriceListDetailType
		{
			get{return _aPPriceListDetailType;}
			set
			{
				if (value != this._aPPriceListDetailType)
				{
				_aPPriceListDetailType=value;
				NotifyChanged("APPriceListDetailType");
				}
			}
		}
		public int APPriceListDetailInvoicertOrder
		{
			get{return _aPPriceListDetailInvoicertOrder;}
			set
			{
				if (value != this._aPPriceListDetailInvoicertOrder)
				{
				_aPPriceListDetailInvoicertOrder=value;
				NotifyChanged("APPriceListDetailInvoicertOrder");
				}
			}
		}
		public String APPriceListDetailDesc
		{
			get{return _aPPriceListDetailDesc;}
			set
			{
				if (value != this._aPPriceListDetailDesc)
				{
				_aPPriceListDetailDesc=value;
				NotifyChanged("APPriceListDetailDesc");
				}
			}
		}
		public String APPriceListDetailUOM
		{
			get{return _aPPriceListDetailUOM;}
			set
			{
				if (value != this._aPPriceListDetailUOM)
				{
				_aPPriceListDetailUOM=value;
				NotifyChanged("APPriceListDetailUOM");
				}
			}
		}
		public String APPriceListDetailStkUOM
		{
			get{return _aPPriceListDetailStkUOM;}
			set
			{
				if (value != this._aPPriceListDetailStkUOM)
				{
				_aPPriceListDetailStkUOM=value;
				NotifyChanged("APPriceListDetailStkUOM");
				}
			}
		}
		public double APPriceListDetailFact
		{
			get{return _aPPriceListDetailFact;}
			set
			{
				if (value != this._aPPriceListDetailFact)
				{
				_aPPriceListDetailFact=value;
				NotifyChanged("APPriceListDetailFact");
				}
			}
		}
		public String APSalePriceCombo
		{
			get{return _aPSalePriceCombo;}
			set
			{
				if (value != this._aPSalePriceCombo)
				{
				_aPSalePriceCombo=value;
				NotifyChanged("APSalePriceCombo");
				}
			}
		}
		public double APPriceListDetailUnitPrice
		{
			get{return _aPPriceListDetailUnitPrice;}
			set
			{
				if (value != this._aPPriceListDetailUnitPrice)
				{
				_aPPriceListDetailUnitPrice=value;
				NotifyChanged("APPriceListDetailUnitPrice");
				}
			}
		}
		public double APPriceListDetailFUnitPrice
		{
			get{return _aPPriceListDetailFUnitPrice;}
			set
			{
				if (value != this._aPPriceListDetailFUnitPrice)
				{
				_aPPriceListDetailFUnitPrice=value;
				NotifyChanged("APPriceListDetailFUnitPrice");
				}
			}
		}
		public double APPriceListDetailUnitCost
		{
			get{return _aPPriceListDetailUnitCost;}
			set
			{
				if (value != this._aPPriceListDetailUnitCost)
				{
				_aPPriceListDetailUnitCost=value;
				NotifyChanged("APPriceListDetailUnitCost");
				}
			}
		}
		public double APPriceListDetailDiscPct
		{
			get{return _aPPriceListDetailDiscPct;}
			set
			{
				if (value != this._aPPriceListDetailDiscPct)
				{
				_aPPriceListDetailDiscPct=value;
				NotifyChanged("APPriceListDetailDiscPct");
				}
			}
		}
		public double APPriceListDetailTxPct
		{
			get{return _aPPriceListDetailTxPct;}
			set
			{
				if (value != this._aPPriceListDetailTxPct)
				{
				_aPPriceListDetailTxPct=value;
				NotifyChanged("APPriceListDetailTxPct");
				}
			}
		}
		public double APPriceListDetailQty
		{
			get{return _aPPriceListDetailQty;}
			set
			{
				if (value != this._aPPriceListDetailQty)
				{
				_aPPriceListDetailQty=value;
				NotifyChanged("APPriceListDetailQty");
				}
			}
		}
		public double APPriceListDetailStkQty
		{
			get{return _aPPriceListDetailStkQty;}
			set
			{
				if (value != this._aPPriceListDetailStkQty)
				{
				_aPPriceListDetailStkQty=value;
				NotifyChanged("APPriceListDetailStkQty");
				}
			}
		}
		public double APPriceListDetailRQty
		{
			get{return _aPPriceListDetailRQty;}
			set
			{
				if (value != this._aPPriceListDetailRQty)
				{
				_aPPriceListDetailRQty=value;
				NotifyChanged("APPriceListDetailRQty");
				}
			}
		}
		public double APPriceListDetailRStkQty
		{
			get{return _aPPriceListDetailRStkQty;}
			set
			{
				if (value != this._aPPriceListDetailRStkQty)
				{
				_aPPriceListDetailRStkQty=value;
				NotifyChanged("APPriceListDetailRStkQty");
				}
			}
		}
		public double APPriceListDetailPrice
		{
			get{return _aPPriceListDetailPrice;}
			set
			{
				if (value != this._aPPriceListDetailPrice)
				{
				_aPPriceListDetailPrice=value;
				NotifyChanged("APPriceListDetailPrice");
				}
			}
		}
		public double APPriceListDetailFPrice
		{
			get{return _aPPriceListDetailFPrice;}
			set
			{
				if (value != this._aPPriceListDetailFPrice)
				{
				_aPPriceListDetailFPrice=value;
				NotifyChanged("APPriceListDetailFPrice");
				}
			}
		}
		public String APPriceListDetailComment
		{
			get{return _aPPriceListDetailComment;}
			set
			{
				if (value != this._aPPriceListDetailComment)
				{
				_aPPriceListDetailComment=value;
				NotifyChanged("APPriceListDetailComment");
				}
			}
		}
		public double APPriceListDetailUnitVolumn
		{
			get{return _aPPriceListDetailUnitVolumn;}
			set
			{
				if (value != this._aPPriceListDetailUnitVolumn)
				{
				_aPPriceListDetailUnitVolumn=value;
				NotifyChanged("APPriceListDetailUnitVolumn");
				}
			}
		}
		public double APPriceListDetailUnitWeight
		{
			get{return _aPPriceListDetailUnitWeight;}
			set
			{
				if (value != this._aPPriceListDetailUnitWeight)
				{
				_aPPriceListDetailUnitWeight=value;
				NotifyChanged("APPriceListDetailUnitWeight");
				}
			}
		}
		public double APPriceListDetailTxAmt
		{
			get{return _aPPriceListDetailTxAmt;}
			set
			{
				if (value != this._aPPriceListDetailTxAmt)
				{
				_aPPriceListDetailTxAmt=value;
				NotifyChanged("APPriceListDetailTxAmt");
				}
			}
		}
		public double APPriceListDetailFTxAmt
		{
			get{return _aPPriceListDetailFTxAmt;}
			set
			{
				if (value != this._aPPriceListDetailFTxAmt)
				{
				_aPPriceListDetailFTxAmt=value;
				NotifyChanged("APPriceListDetailFTxAmt");
				}
			}
		}
		public double APPriceListDetailDiscAmt
		{
			get{return _aPPriceListDetailDiscAmt;}
			set
			{
				if (value != this._aPPriceListDetailDiscAmt)
				{
				_aPPriceListDetailDiscAmt=value;
				NotifyChanged("APPriceListDetailDiscAmt");
				}
			}
		}
		public double APPriceListDetailFDiscAmt
		{
			get{return _aPPriceListDetailFDiscAmt;}
			set
			{
				if (value != this._aPPriceListDetailFDiscAmt)
				{
				_aPPriceListDetailFDiscAmt=value;
				NotifyChanged("APPriceListDetailFDiscAmt");
				}
			}
		}
		public double APPriceListDetailNetAmt
		{
			get{return _aPPriceListDetailNetAmt;}
			set
			{
				if (value != this._aPPriceListDetailNetAmt)
				{
				_aPPriceListDetailNetAmt=value;
				NotifyChanged("APPriceListDetailNetAmt");
				}
			}
		}
		public double APPriceListDetailFNetAmt
		{
			get{return _aPPriceListDetailFNetAmt;}
			set
			{
				if (value != this._aPPriceListDetailFNetAmt)
				{
				_aPPriceListDetailFNetAmt=value;
				NotifyChanged("APPriceListDetailFNetAmt");
				}
			}
		}
		public double APPriceListDetailAmtTot
		{
			get{return _aPPriceListDetailAmtTot;}
			set
			{
				if (value != this._aPPriceListDetailAmtTot)
				{
				_aPPriceListDetailAmtTot=value;
				NotifyChanged("APPriceListDetailAmtTot");
				}
			}
		}
		public double APPriceListDetailFAmtTot
		{
			get{return _aPPriceListDetailFAmtTot;}
			set
			{
				if (value != this._aPPriceListDetailFAmtTot)
				{
				_aPPriceListDetailFAmtTot=value;
				NotifyChanged("APPriceListDetailFAmtTot");
				}
			}
		}
		public double APPriceListDetailCostTot
		{
			get{return _aPPriceListDetailCostTot;}
			set
			{
				if (value != this._aPPriceListDetailCostTot)
				{
				_aPPriceListDetailCostTot=value;
				NotifyChanged("APPriceListDetailCostTot");
				}
			}
		}
		public String APPriceListDetailStatus
		{
			get{return _aPPriceListDetailStatus;}
			set
			{
				if (value != this._aPPriceListDetailStatus)
				{
				_aPPriceListDetailStatus=value;
				NotifyChanged("APPriceListDetailStatus");
				}
			}
		}
		public double APPriceListDetailImpTxAmt
		{
			get{return _aPPriceListDetailImpTxAmt;}
			set
			{
				if (value != this._aPPriceListDetailImpTxAmt)
				{
				_aPPriceListDetailImpTxAmt=value;
				NotifyChanged("APPriceListDetailImpTxAmt");
				}
			}
		}
		public double APPriceListDetailImpTxPct
		{
			get{return _aPPriceListDetailImpTxPct;}
			set
			{
				if (value != this._aPPriceListDetailImpTxPct)
				{
				_aPPriceListDetailImpTxPct=value;
				NotifyChanged("APPriceListDetailImpTxPct");
				}
			}
		}
		public double APPriceListDetailFImpTxAmt
		{
			get{return _aPPriceListDetailFImpTxAmt;}
			set
			{
				if (value != this._aPPriceListDetailFImpTxAmt)
				{
				_aPPriceListDetailFImpTxAmt=value;
				NotifyChanged("APPriceListDetailFImpTxAmt");
				}
			}
		}
		public double APPriceListDetailShpAmt
		{
			get{return _aPPriceListDetailShpAmt;}
			set
			{
				if (value != this._aPPriceListDetailShpAmt)
				{
				_aPPriceListDetailShpAmt=value;
				NotifyChanged("APPriceListDetailShpAmt");
				}
			}
		}
		public double APPriceListDetailMiscChargeAmt
		{
			get{return _aPPriceListDetailMiscChargeAmt;}
			set
			{
				if (value != this._aPPriceListDetailMiscChargeAmt)
				{
				_aPPriceListDetailMiscChargeAmt=value;
				NotifyChanged("APPriceListDetailMiscChargeAmt");
				}
			}
		}
		public String APPriceListDetailPurchaseReturnStatusCombo
		{
			get{return _aPPriceListDetailPurchaseReturnStatusCombo;}
			set
			{
				if (value != this._aPPriceListDetailPurchaseReturnStatusCombo)
				{
				_aPPriceListDetailPurchaseReturnStatusCombo=value;
				NotifyChanged("APPriceListDetailPurchaseReturnStatusCombo");
				}
			}
		}
		public double APPriceListDetailPurchaseReturnRQty
		{
			get{return _aPPriceListDetailPurchaseReturnRQty;}
			set
			{
				if (value != this._aPPriceListDetailPurchaseReturnRQty)
				{
				_aPPriceListDetailPurchaseReturnRQty=value;
				NotifyChanged("APPriceListDetailPurchaseReturnRQty");
				}
			}
		}
		public String APPriceListDetailAPCreditNoteStatusCombo
		{
			get{return _aPPriceListDetailAPCreditNoteStatusCombo;}
			set
			{
				if (value != this._aPPriceListDetailAPCreditNoteStatusCombo)
				{
				_aPPriceListDetailAPCreditNoteStatusCombo=value;
				NotifyChanged("APPriceListDetailAPCreditNoteStatusCombo");
				}
			}
		}
		public double APPriceListDetailAPCreditNoteRQty
		{
			get{return _aPPriceListDetailAPCreditNoteRQty;}
			set
			{
				if (value != this._aPPriceListDetailAPCreditNoteRQty)
				{
				_aPPriceListDetailAPCreditNoteRQty=value;
				NotifyChanged("APPriceListDetailAPCreditNoteRQty");
				}
			}
		}
		public String APPriceListDetailRcpNo
		{
			get{return _aPPriceListDetailRcpNo;}
			set
			{
				if (value != this._aPPriceListDetailRcpNo)
				{
				_aPPriceListDetailRcpNo=value;
				NotifyChanged("APPriceListDetailRcpNo");
				}
			}
		}
		public double APPriceListDetailAllocateLife
		{
			get{return _aPPriceListDetailAllocateLife;}
			set
			{
				if (value != this._aPPriceListDetailAllocateLife)
				{
				_aPPriceListDetailAllocateLife=value;
				NotifyChanged("APPriceListDetailAllocateLife");
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
		public double APPriceListDetailWTot
		{
			get{return _aPPriceListDetailWTot;}
			set
			{
				if (value != this._aPPriceListDetailWTot)
				{
				_aPPriceListDetailWTot=value;
				NotifyChanged("APPriceListDetailWTot");
				}
			}
		}
		public double APPriceListDetailVTot
		{
			get{return _aPPriceListDetailVTot;}
			set
			{
				if (value != this._aPPriceListDetailVTot)
				{
				_aPPriceListDetailVTot=value;
				NotifyChanged("APPriceListDetailVTot");
				}
			}
		}
		public int FK_ADOFID
		{
			get{return _fK_ADOFID;}
			set
			{
				if (value != this._fK_ADOFID)
				{
				_fK_ADOFID=value;
				NotifyChanged("FK_ADOFID");
				}
			}
		}
		public int FK_ADOFItemID
		{
			get{return _fK_ADOFItemID;}
			set
			{
				if (value != this._fK_ADOFItemID)
				{
				_fK_ADOFItemID=value;
				NotifyChanged("FK_ADOFItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}