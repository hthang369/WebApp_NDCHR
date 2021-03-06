using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPPrdQCItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPPrdQCItemsInfo
	//Created Date:10 Tháng Mười Hai 2014
	//-----------------------------------------------------------
	
	public class PPPrdQCItemsInfo:BusinessObject
	{
		public PPPrdQCItemsInfo()
		{
		}
		#region Variables
		protected int _pPPrdQCItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_PPPrdQCID;
		protected int _fK_ICProductID;
		protected int _fK_PPWOID;
		protected int _fK_PPPhaseCfgID;
		protected String _pPPrdQCItemDesc=String.Empty;
		protected double _pPPrdQCItemQty;
		protected double _pPPrdQCItemRQty;
		protected double _pPPrdQCItemValidQty;
		protected double _pPPrdQCItemInValidQty;
		protected int _fK_ICReceiptItemID;
		protected double _pPPrdQCItemValidRQty;
		protected double _pPPrdQCItemInValidRQty;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _pPPrdQCItemStkQty;
		protected double _pPPrdQCItemRStkQty;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _pPPrdQCItemWTot;
		protected double _pPPrdQCItemVTot;
		protected double _pPPrdQCItemFact;
		protected int _fK_PPProductionOrdrEstFGID;
		#endregion

		#region Public properties
		public int PPPrdQCItemID
		{
			get{return _pPPrdQCItemID;}
			set
			{
				if (value != this._pPPrdQCItemID)
				{
				_pPPrdQCItemID=value;
				NotifyChanged("PPPrdQCItemID");
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
		public int FK_PPPrdQCID
		{
			get{return _fK_PPPrdQCID;}
			set
			{
				if (value != this._fK_PPPrdQCID)
				{
				_fK_PPPrdQCID=value;
				NotifyChanged("FK_PPPrdQCID");
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
		public int FK_PPPhaseCfgID
		{
			get{return _fK_PPPhaseCfgID;}
			set
			{
				if (value != this._fK_PPPhaseCfgID)
				{
				_fK_PPPhaseCfgID=value;
				NotifyChanged("FK_PPPhaseCfgID");
				}
			}
		}
		public String PPPrdQCItemDesc
		{
			get{return _pPPrdQCItemDesc;}
			set
			{
				if (value != this._pPPrdQCItemDesc)
				{
				_pPPrdQCItemDesc=value;
				NotifyChanged("PPPrdQCItemDesc");
				}
			}
		}
		public double PPPrdQCItemQty
		{
			get{return _pPPrdQCItemQty;}
			set
			{
				if (value != this._pPPrdQCItemQty)
				{
				_pPPrdQCItemQty=value;
				NotifyChanged("PPPrdQCItemQty");
				}
			}
		}
		public double PPPrdQCItemRQty
		{
			get{return _pPPrdQCItemRQty;}
			set
			{
				if (value != this._pPPrdQCItemRQty)
				{
				_pPPrdQCItemRQty=value;
				NotifyChanged("PPPrdQCItemRQty");
				}
			}
		}
		public double PPPrdQCItemValidQty
		{
			get{return _pPPrdQCItemValidQty;}
			set
			{
				if (value != this._pPPrdQCItemValidQty)
				{
				_pPPrdQCItemValidQty=value;
				NotifyChanged("PPPrdQCItemValidQty");
				}
			}
		}
		public double PPPrdQCItemInValidQty
		{
			get{return _pPPrdQCItemInValidQty;}
			set
			{
				if (value != this._pPPrdQCItemInValidQty)
				{
				_pPPrdQCItemInValidQty=value;
				NotifyChanged("PPPrdQCItemInValidQty");
				}
			}
		}
		public int FK_ICReceiptItemID
		{
			get{return _fK_ICReceiptItemID;}
			set
			{
				if (value != this._fK_ICReceiptItemID)
				{
				_fK_ICReceiptItemID=value;
				NotifyChanged("FK_ICReceiptItemID");
				}
			}
		}
		public double PPPrdQCItemValidRQty
		{
			get{return _pPPrdQCItemValidRQty;}
			set
			{
				if (value != this._pPPrdQCItemValidRQty)
				{
				_pPPrdQCItemValidRQty=value;
				NotifyChanged("PPPrdQCItemValidRQty");
				}
			}
		}
		public double PPPrdQCItemInValidRQty
		{
			get{return _pPPrdQCItemInValidRQty;}
			set
			{
				if (value != this._pPPrdQCItemInValidRQty)
				{
				_pPPrdQCItemInValidRQty=value;
				NotifyChanged("PPPrdQCItemInValidRQty");
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
		public double PPPrdQCItemStkQty
		{
			get{return _pPPrdQCItemStkQty;}
			set
			{
				if (value != this._pPPrdQCItemStkQty)
				{
				_pPPrdQCItemStkQty=value;
				NotifyChanged("PPPrdQCItemStkQty");
				}
			}
		}
		public double PPPrdQCItemRStkQty
		{
			get{return _pPPrdQCItemRStkQty;}
			set
			{
				if (value != this._pPPrdQCItemRStkQty)
				{
				_pPPrdQCItemRStkQty=value;
				NotifyChanged("PPPrdQCItemRStkQty");
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
		public double PPPrdQCItemWTot
		{
			get{return _pPPrdQCItemWTot;}
			set
			{
				if (value != this._pPPrdQCItemWTot)
				{
				_pPPrdQCItemWTot=value;
				NotifyChanged("PPPrdQCItemWTot");
				}
			}
		}
		public double PPPrdQCItemVTot
		{
			get{return _pPPrdQCItemVTot;}
			set
			{
				if (value != this._pPPrdQCItemVTot)
				{
				_pPPrdQCItemVTot=value;
				NotifyChanged("PPPrdQCItemVTot");
				}
			}
		}
		public double PPPrdQCItemFact
		{
			get{return _pPPrdQCItemFact;}
			set
			{
				if (value != this._pPPrdQCItemFact)
				{
				_pPPrdQCItemFact=value;
				NotifyChanged("PPPrdQCItemFact");
				}
			}
		}
		public int FK_PPProductionOrdrEstFGID
		{
			get{return _fK_PPProductionOrdrEstFGID;}
			set
			{
				if (value != this._fK_PPProductionOrdrEstFGID)
				{
				_fK_PPProductionOrdrEstFGID=value;
				NotifyChanged("FK_PPProductionOrdrEstFGID");
				}
			}
		}
		#endregion
	}
	#endregion
}