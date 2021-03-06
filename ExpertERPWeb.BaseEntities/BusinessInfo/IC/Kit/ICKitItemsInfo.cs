using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICKitItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICKitItemsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class ICKitItemsInfo:BusinessObject
	{
		public ICKitItemsInfo()
		{
		}
		#region Variables
		protected int _iCKitItemID;
		protected int _fK_ICKitID;
		protected int _fK_ICProductID;
		protected int _fK_ICUOMID;
		protected double _iCKitItemQty;
		protected double _iCKitItemMinQty;
		protected double _iCKitItemMaxQty;
		protected bool _iCKitItemAllowVariance=true;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		#endregion

		#region Public properties
		public int ICKitItemID
		{
			get{return _iCKitItemID;}
			set
			{
				if (value != this._iCKitItemID)
				{
				_iCKitItemID=value;
				NotifyChanged("ICKitItemID");
				}
			}
		}
		public int FK_ICKitID
		{
			get{return _fK_ICKitID;}
			set
			{
				if (value != this._fK_ICKitID)
				{
				_fK_ICKitID=value;
				NotifyChanged("FK_ICKitID");
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
		public double ICKitItemQty
		{
			get{return _iCKitItemQty;}
			set
			{
				if (value != this._iCKitItemQty)
				{
				_iCKitItemQty=value;
				NotifyChanged("ICKitItemQty");
				}
			}
		}
		public double ICKitItemMinQty
		{
			get{return _iCKitItemMinQty;}
			set
			{
				if (value != this._iCKitItemMinQty)
				{
				_iCKitItemMinQty=value;
				NotifyChanged("ICKitItemMinQty");
				}
			}
		}
		public double ICKitItemMaxQty
		{
			get{return _iCKitItemMaxQty;}
			set
			{
				if (value != this._iCKitItemMaxQty)
				{
				_iCKitItemMaxQty=value;
				NotifyChanged("ICKitItemMaxQty");
				}
			}
		}
		public bool ICKitItemAllowVariance
		{
			get{return _iCKitItemAllowVariance;}
			set
			{
				if (value != this._iCKitItemAllowVariance)
				{
				_iCKitItemAllowVariance=value;
				NotifyChanged("ICKitItemAllowVariance");
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
		#endregion
	}
	#endregion
}