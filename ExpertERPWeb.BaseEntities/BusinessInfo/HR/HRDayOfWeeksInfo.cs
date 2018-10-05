using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRDayOfWeeks
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRDayOfWeeksInfo
	//Created Date:Tuesday, March 21, 2017
	//-----------------------------------------------------------
	
	public class HRDayOfWeeksInfo:BusinessObject
	{
		public HRDayOfWeeksInfo()
		{
		}
		#region Variables
		protected int _hRDayOfWeekID;
		protected String _hRDayOfWeekNo=String.Empty;
		protected String _hRDayOfWeekName=String.Empty;
		protected Nullable<DateTime> _hRDayOfWeekDate;
		protected String _hRDayOfWeekDesc=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected bool _aASelected=true;
		protected bool _hRDayOfWeekOffCheck=true;
		#endregion

		#region Public properties
		public int HRDayOfWeekID
		{
			get{return _hRDayOfWeekID;}
			set
			{
				if (value != this._hRDayOfWeekID)
				{
				_hRDayOfWeekID=value;
				NotifyChanged("HRDayOfWeekID");
				}
			}
		}
		public String HRDayOfWeekNo
		{
			get{return _hRDayOfWeekNo;}
			set
			{
				if (value != this._hRDayOfWeekNo)
				{
				_hRDayOfWeekNo=value;
				NotifyChanged("HRDayOfWeekNo");
				}
			}
		}
		public String HRDayOfWeekName
		{
			get{return _hRDayOfWeekName;}
			set
			{
				if (value != this._hRDayOfWeekName)
				{
				_hRDayOfWeekName=value;
				NotifyChanged("HRDayOfWeekName");
				}
			}
		}
		public Nullable<DateTime> HRDayOfWeekDate
		{
			get{return _hRDayOfWeekDate;}
			set
			{
				if (value != this._hRDayOfWeekDate)
				{
				_hRDayOfWeekDate=value;
				NotifyChanged("HRDayOfWeekDate");
				}
			}
		}
		public String HRDayOfWeekDesc
		{
			get{return _hRDayOfWeekDesc;}
			set
			{
				if (value != this._hRDayOfWeekDesc)
				{
				_hRDayOfWeekDesc=value;
				NotifyChanged("HRDayOfWeekDesc");
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
		public bool HRDayOfWeekOffCheck
		{
			get{return _hRDayOfWeekOffCheck;}
			set
			{
				if (value != this._hRDayOfWeekOffCheck)
				{
				_hRDayOfWeekOffCheck=value;
				NotifyChanged("HRDayOfWeekOffCheck");
				}
			}
		}
		#endregion
	}
	#endregion
}