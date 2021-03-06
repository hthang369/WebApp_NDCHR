using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APOrdrPlnItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APOrdrPlnItemsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class APOrdrPlnItemsInfo:BusinessObject
	{
		public APOrdrPlnItemsInfo()
		{
		}
		#region Variables
		protected int _aPOrdrPlnItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _aPOrdrPlnItemPeriod;
		protected int _aPOrdrPlnItemYear;
		protected int _fK_APOrdrPlnID;
		protected int _fK_ICProductID;
		protected String _iCProductName=String.Empty;
		protected double _iCProductLength;
		protected double _iCProductWidth;
		protected double _iCProductHeght;
		protected double _iCProductCBM;
		protected String _iCProductUOM=String.Empty;
		protected double _aPOrdrPlnItemPriority;
		protected double _aPOrdrPlnItemHaveToShpQty;
		protected double _aPOrdrPlnItemProduceQty;
		protected double _aPOrdrPlnItemPOQty;
		protected double _aPOrdrPlnItemPORemainQty;
		protected double _aPOrdrPlnItemNeedToProcess;
		protected double _aPOrdrPlnItemInvQty;
		protected double _aPOrdrPlnItemTotalRPOQty;
		protected double _aPOrdrPlnItemProduceCBM;
		protected double _aPOrdrPlnItemTotalCBM;
		protected int _fK_ICUOMID;
		#endregion

		#region Public properties
		public int APOrdrPlnItemID
		{
			get{return _aPOrdrPlnItemID;}
			set
			{
				if (value != this._aPOrdrPlnItemID)
				{
				_aPOrdrPlnItemID=value;
				NotifyChanged("APOrdrPlnItemID");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get{return _aACreatedDate;}
			set
			{
				if (value != this._aACreatedDate)
				{
				_aACreatedDate=value;
				NotifyChanged("AACreatedDate");
				}
			}
		}
		public String AACreatedUser
		{
			get{return _aACreatedUser;}
			set
			{
				if (value != this._aACreatedUser)
				{
				_aACreatedUser=value;
				NotifyChanged("AACreatedUser");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get{return _aAUpdatedDate;}
			set
			{
				if (value != this._aAUpdatedDate)
				{
				_aAUpdatedDate=value;
				NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String AAUpdatedUser
		{
			get{return _aAUpdatedUser;}
			set
			{
				if (value != this._aAUpdatedUser)
				{
				_aAUpdatedUser=value;
				NotifyChanged("AAUpdatedUser");
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
		public int APOrdrPlnItemPeriod
		{
			get{return _aPOrdrPlnItemPeriod;}
			set
			{
				if (value != this._aPOrdrPlnItemPeriod)
				{
				_aPOrdrPlnItemPeriod=value;
				NotifyChanged("APOrdrPlnItemPeriod");
				}
			}
		}
		public int APOrdrPlnItemYear
		{
			get{return _aPOrdrPlnItemYear;}
			set
			{
				if (value != this._aPOrdrPlnItemYear)
				{
				_aPOrdrPlnItemYear=value;
				NotifyChanged("APOrdrPlnItemYear");
				}
			}
		}
		public int FK_APOrdrPlnID
		{
			get{return _fK_APOrdrPlnID;}
			set
			{
				if (value != this._fK_APOrdrPlnID)
				{
				_fK_APOrdrPlnID=value;
				NotifyChanged("FK_APOrdrPlnID");
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
		public String ICProductName
		{
			get{return _iCProductName;}
			set
			{
				if (value != this._iCProductName)
				{
				_iCProductName=value;
				NotifyChanged("ICProductName");
				}
			}
		}
		public double ICProductLength
		{
			get{return _iCProductLength;}
			set
			{
				if (value != this._iCProductLength)
				{
				_iCProductLength=value;
				NotifyChanged("ICProductLength");
				}
			}
		}
		public double ICProductWidth
		{
			get{return _iCProductWidth;}
			set
			{
				if (value != this._iCProductWidth)
				{
				_iCProductWidth=value;
				NotifyChanged("ICProductWidth");
				}
			}
		}
		public double ICProductHeght
		{
			get{return _iCProductHeght;}
			set
			{
				if (value != this._iCProductHeght)
				{
				_iCProductHeght=value;
				NotifyChanged("ICProductHeght");
				}
			}
		}
		public double ICProductCBM
		{
			get{return _iCProductCBM;}
			set
			{
				if (value != this._iCProductCBM)
				{
				_iCProductCBM=value;
				NotifyChanged("ICProductCBM");
				}
			}
		}
		public String ICProductUOM
		{
			get{return _iCProductUOM;}
			set
			{
				if (value != this._iCProductUOM)
				{
				_iCProductUOM=value;
				NotifyChanged("ICProductUOM");
				}
			}
		}
		public double APOrdrPlnItemPriority
		{
			get{return _aPOrdrPlnItemPriority;}
			set
			{
				if (value != this._aPOrdrPlnItemPriority)
				{
				_aPOrdrPlnItemPriority=value;
				NotifyChanged("APOrdrPlnItemPriority");
				}
			}
		}
		public double APOrdrPlnItemHaveToShpQty
		{
			get{return _aPOrdrPlnItemHaveToShpQty;}
			set
			{
				if (value != this._aPOrdrPlnItemHaveToShpQty)
				{
				_aPOrdrPlnItemHaveToShpQty=value;
				NotifyChanged("APOrdrPlnItemHaveToShpQty");
				}
			}
		}
		public double APOrdrPlnItemProduceQty
		{
			get{return _aPOrdrPlnItemProduceQty;}
			set
			{
				if (value != this._aPOrdrPlnItemProduceQty)
				{
				_aPOrdrPlnItemProduceQty=value;
				NotifyChanged("APOrdrPlnItemProduceQty");
				}
			}
		}
		public double APOrdrPlnItemPOQty
		{
			get{return _aPOrdrPlnItemPOQty;}
			set
			{
				if (value != this._aPOrdrPlnItemPOQty)
				{
				_aPOrdrPlnItemPOQty=value;
				NotifyChanged("APOrdrPlnItemPOQty");
				}
			}
		}
		public double APOrdrPlnItemPORemainQty
		{
			get{return _aPOrdrPlnItemPORemainQty;}
			set
			{
				if (value != this._aPOrdrPlnItemPORemainQty)
				{
				_aPOrdrPlnItemPORemainQty=value;
				NotifyChanged("APOrdrPlnItemPORemainQty");
				}
			}
		}
		public double APOrdrPlnItemNeedToProcess
		{
			get{return _aPOrdrPlnItemNeedToProcess;}
			set
			{
				if (value != this._aPOrdrPlnItemNeedToProcess)
				{
				_aPOrdrPlnItemNeedToProcess=value;
				NotifyChanged("APOrdrPlnItemNeedToProcess");
				}
			}
		}
		public double APOrdrPlnItemInvQty
		{
			get{return _aPOrdrPlnItemInvQty;}
			set
			{
				if (value != this._aPOrdrPlnItemInvQty)
				{
				_aPOrdrPlnItemInvQty=value;
				NotifyChanged("APOrdrPlnItemInvQty");
				}
			}
		}
		public double APOrdrPlnItemTotalRPOQty
		{
			get{return _aPOrdrPlnItemTotalRPOQty;}
			set
			{
				if (value != this._aPOrdrPlnItemTotalRPOQty)
				{
				_aPOrdrPlnItemTotalRPOQty=value;
				NotifyChanged("APOrdrPlnItemTotalRPOQty");
				}
			}
		}
		public double APOrdrPlnItemProduceCBM
		{
			get{return _aPOrdrPlnItemProduceCBM;}
			set
			{
				if (value != this._aPOrdrPlnItemProduceCBM)
				{
				_aPOrdrPlnItemProduceCBM=value;
				NotifyChanged("APOrdrPlnItemProduceCBM");
				}
			}
		}
		public double APOrdrPlnItemTotalCBM
		{
			get{return _aPOrdrPlnItemTotalCBM;}
			set
			{
				if (value != this._aPOrdrPlnItemTotalCBM)
				{
				_aPOrdrPlnItemTotalCBM=value;
				NotifyChanged("APOrdrPlnItemTotalCBM");
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
		#endregion
	}
	#endregion
}