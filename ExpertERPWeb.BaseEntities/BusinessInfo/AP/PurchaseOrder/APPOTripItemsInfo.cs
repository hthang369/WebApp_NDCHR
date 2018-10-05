using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOTripItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPOTripItemsInfo
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class APPOTripItemsInfo:BusinessObject
	{
		public APPOTripItemsInfo()
		{
		}
		#region Variables
		protected int _aPPOTripItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_LOPortPOLID;
		protected int _fK_LOPortPODID;
		protected int _fK_APPOID;
		protected String _aPPOTripItemTranspotType=String.Empty;
		protected String _aPPOTripItemTranspotStatus=DefaultStatus;
		protected Nullable<DateTime> _aPPOTripItemETD;
		protected Nullable<DateTime> _aPPOTripItemETA;
		protected Nullable<DateTime> _aPPOTripItemRTD;
		protected Nullable<DateTime> _aPPOTripItemRTA;
		#endregion

		#region Public properties
		public int APPOTripItemID
		{
			get{return _aPPOTripItemID;}
			set
			{
				if (value != this._aPPOTripItemID)
				{
				_aPPOTripItemID=value;
				NotifyChanged("APPOTripItemID");
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
		public int FK_LOPortPOLID
		{
			get{return _fK_LOPortPOLID;}
			set
			{
				if (value != this._fK_LOPortPOLID)
				{
				_fK_LOPortPOLID=value;
				NotifyChanged("FK_LOPortPOLID");
				}
			}
		}
		public int FK_LOPortPODID
		{
			get{return _fK_LOPortPODID;}
			set
			{
				if (value != this._fK_LOPortPODID)
				{
				_fK_LOPortPODID=value;
				NotifyChanged("FK_LOPortPODID");
				}
			}
		}
		public int FK_APPOID
		{
			get{return _fK_APPOID;}
			set
			{
				if (value != this._fK_APPOID)
				{
				_fK_APPOID=value;
				NotifyChanged("FK_APPOID");
				}
			}
		}
		public String APPOTripItemTranspotType
		{
			get{return _aPPOTripItemTranspotType;}
			set
			{
				if (value != this._aPPOTripItemTranspotType)
				{
				_aPPOTripItemTranspotType=value;
				NotifyChanged("APPOTripItemTranspotType");
				}
			}
		}
		public String APPOTripItemTranspotStatus
		{
			get{return _aPPOTripItemTranspotStatus;}
			set
			{
				if (value != this._aPPOTripItemTranspotStatus)
				{
				_aPPOTripItemTranspotStatus=value;
				NotifyChanged("APPOTripItemTranspotStatus");
				}
			}
		}
		public Nullable<DateTime> APPOTripItemETD
		{
			get{return _aPPOTripItemETD;}
			set
			{
				if (value != this._aPPOTripItemETD)
				{
				_aPPOTripItemETD=value;
				NotifyChanged("APPOTripItemETD");
				}
			}
		}
		public Nullable<DateTime> APPOTripItemETA
		{
			get{return _aPPOTripItemETA;}
			set
			{
				if (value != this._aPPOTripItemETA)
				{
				_aPPOTripItemETA=value;
				NotifyChanged("APPOTripItemETA");
				}
			}
		}
		public Nullable<DateTime> APPOTripItemRTD
		{
			get{return _aPPOTripItemRTD;}
			set
			{
				if (value != this._aPPOTripItemRTD)
				{
				_aPPOTripItemRTD=value;
				NotifyChanged("APPOTripItemRTD");
				}
			}
		}
		public Nullable<DateTime> APPOTripItemRTA
		{
			get{return _aPPOTripItemRTA;}
			set
			{
				if (value != this._aPPOTripItemRTA)
				{
				_aPPOTripItemRTA=value;
				NotifyChanged("APPOTripItemRTA");
				}
			}
		}
		#endregion
	}
	#endregion
}