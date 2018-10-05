using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICPromotionItemDetails
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICPromotionItemDetailsInfo
	//Created Date:05 November 2014
	//-----------------------------------------------------------
	
	public class ICPromotionItemDetailsInfo:BusinessObject
	{
		public ICPromotionItemDetailsInfo()
		{
		}
		#region Variables
		protected int _iCPromotionItemDetailID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ICPromotionItemID;
		protected int _fK_ICProductID;
		protected double _iCPromotionItemDetailQty;
		protected double _iCPromotionItemDetailUnitPrice;
		protected bool _iCPromotionItemDetailIncludeCheckPrice=true;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _iCPromotionItemDetailRQty;
		protected double _iCPromotionItemDetailStkQty;
		protected double _iCPromotionItemDetailRStkQty;
		protected double _iCPromotionItemDetailWTot;
		protected double _iCPromotionItemDetailVTot;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		#endregion

		#region Public properties
		public int ICPromotionItemDetailID
		{
			get{return _iCPromotionItemDetailID;}
			set
			{
				if (value != this._iCPromotionItemDetailID)
				{
				_iCPromotionItemDetailID=value;
				NotifyChanged("ICPromotionItemDetailID");
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
		public int FK_ICPromotionItemID
		{
			get{return _fK_ICPromotionItemID;}
			set
			{
				if (value != this._fK_ICPromotionItemID)
				{
				_fK_ICPromotionItemID=value;
				NotifyChanged("FK_ICPromotionItemID");
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
		public double ICPromotionItemDetailQty
		{
			get{return _iCPromotionItemDetailQty;}
			set
			{
				if (value != this._iCPromotionItemDetailQty)
				{
				_iCPromotionItemDetailQty=value;
				NotifyChanged("ICPromotionItemDetailQty");
				}
			}
		}
		public double ICPromotionItemDetailUnitPrice
		{
			get{return _iCPromotionItemDetailUnitPrice;}
			set
			{
				if (value != this._iCPromotionItemDetailUnitPrice)
				{
				_iCPromotionItemDetailUnitPrice=value;
				NotifyChanged("ICPromotionItemDetailUnitPrice");
				}
			}
		}
		public bool ICPromotionItemDetailIncludeCheckPrice
		{
			get{return _iCPromotionItemDetailIncludeCheckPrice;}
			set
			{
				if (value != this._iCPromotionItemDetailIncludeCheckPrice)
				{
				_iCPromotionItemDetailIncludeCheckPrice=value;
				NotifyChanged("ICPromotionItemDetailIncludeCheckPrice");
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
		public double ICPromotionItemDetailRQty
		{
			get{return _iCPromotionItemDetailRQty;}
			set
			{
				if (value != this._iCPromotionItemDetailRQty)
				{
				_iCPromotionItemDetailRQty=value;
				NotifyChanged("ICPromotionItemDetailRQty");
				}
			}
		}
		public double ICPromotionItemDetailStkQty
		{
			get{return _iCPromotionItemDetailStkQty;}
			set
			{
				if (value != this._iCPromotionItemDetailStkQty)
				{
				_iCPromotionItemDetailStkQty=value;
				NotifyChanged("ICPromotionItemDetailStkQty");
				}
			}
		}
		public double ICPromotionItemDetailRStkQty
		{
			get{return _iCPromotionItemDetailRStkQty;}
			set
			{
				if (value != this._iCPromotionItemDetailRStkQty)
				{
				_iCPromotionItemDetailRStkQty=value;
				NotifyChanged("ICPromotionItemDetailRStkQty");
				}
			}
		}
		public double ICPromotionItemDetailWTot
		{
			get{return _iCPromotionItemDetailWTot;}
			set
			{
				if (value != this._iCPromotionItemDetailWTot)
				{
				_iCPromotionItemDetailWTot=value;
				NotifyChanged("ICPromotionItemDetailWTot");
				}
			}
		}
		public double ICPromotionItemDetailVTot
		{
			get{return _iCPromotionItemDetailVTot;}
			set
			{
				if (value != this._iCPromotionItemDetailVTot)
				{
				_iCPromotionItemDetailVTot=value;
				NotifyChanged("ICPromotionItemDetailVTot");
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
		#endregion
	}
	#endregion
}