using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICPromotionItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICPromotionItemsInfo
	//Created Date:05 November 2014
	//-----------------------------------------------------------
	
	public class ICPromotionItemsInfo:BusinessObject
	{
		public ICPromotionItemsInfo()
		{
		}
		#region Variables
		protected int _iCPromotionItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _iCPromotionItemNo=String.Empty;
		protected int _fK_ICPromotionID;
		protected int _fK_ICProductID;
		protected double _iCPromotionItemQty;
		protected double _iCPromotionItemUnitPrice;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _iCPromotionItemRQty;
		protected double _iCPromotionItemStkQty;
		protected double _iCPromotionItemRStkQty;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _iCPromotionItemWTot;
		protected double _iCPromotionItemVTot;
		#endregion

		#region Public properties
		public int ICPromotionItemID
		{
			get{return _iCPromotionItemID;}
			set
			{
				if (value != this._iCPromotionItemID)
				{
				_iCPromotionItemID=value;
				NotifyChanged("ICPromotionItemID");
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
		public String ICPromotionItemNo
		{
			get{return _iCPromotionItemNo;}
			set
			{
				if (value != this._iCPromotionItemNo)
				{
				_iCPromotionItemNo=value;
				NotifyChanged("ICPromotionItemNo");
				}
			}
		}
		public int FK_ICPromotionID
		{
			get{return _fK_ICPromotionID;}
			set
			{
				if (value != this._fK_ICPromotionID)
				{
				_fK_ICPromotionID=value;
				NotifyChanged("FK_ICPromotionID");
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
		public double ICPromotionItemQty
		{
			get{return _iCPromotionItemQty;}
			set
			{
				if (value != this._iCPromotionItemQty)
				{
				_iCPromotionItemQty=value;
				NotifyChanged("ICPromotionItemQty");
				}
			}
		}
		public double ICPromotionItemUnitPrice
		{
			get{return _iCPromotionItemUnitPrice;}
			set
			{
				if (value != this._iCPromotionItemUnitPrice)
				{
				_iCPromotionItemUnitPrice=value;
				NotifyChanged("ICPromotionItemUnitPrice");
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
		public double ICPromotionItemRQty
		{
			get{return _iCPromotionItemRQty;}
			set
			{
				if (value != this._iCPromotionItemRQty)
				{
				_iCPromotionItemRQty=value;
				NotifyChanged("ICPromotionItemRQty");
				}
			}
		}
		public double ICPromotionItemStkQty
		{
			get{return _iCPromotionItemStkQty;}
			set
			{
				if (value != this._iCPromotionItemStkQty)
				{
				_iCPromotionItemStkQty=value;
				NotifyChanged("ICPromotionItemStkQty");
				}
			}
		}
		public double ICPromotionItemRStkQty
		{
			get{return _iCPromotionItemRStkQty;}
			set
			{
				if (value != this._iCPromotionItemRStkQty)
				{
				_iCPromotionItemRStkQty=value;
				NotifyChanged("ICPromotionItemRStkQty");
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
		public double ICPromotionItemWTot
		{
			get{return _iCPromotionItemWTot;}
			set
			{
				if (value != this._iCPromotionItemWTot)
				{
				_iCPromotionItemWTot=value;
				NotifyChanged("ICPromotionItemWTot");
				}
			}
		}
		public double ICPromotionItemVTot
		{
			get{return _iCPromotionItemVTot;}
			set
			{
				if (value != this._iCPromotionItemVTot)
				{
				_iCPromotionItemVTot=value;
				NotifyChanged("ICPromotionItemVTot");
				}
			}
		}
		#endregion
	}
	#endregion
}