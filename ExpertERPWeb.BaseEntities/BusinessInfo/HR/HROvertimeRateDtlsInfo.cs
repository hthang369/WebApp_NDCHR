using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HROvertimeRateDtls
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HROvertimeRateDtlsInfo
	//Created Date:10 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HROvertimeRateDtlsInfo:BusinessObject
	{
		public HROvertimeRateDtlsInfo()
		{
		}
		#region Variables
		protected int _hROvertimeRateDtlID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected int _fK_HROvertimeRateID;
		protected int _fK_HRShiftID;
		protected DateTime _hROvertimeRateDtlStartDateTime=DefaultDate;
		protected DateTime _hROvertimeRateDtlEndDateTime=DateTime.Now;
		protected String _hROvertimeRateDtlDesc=String.Empty;
		#endregion

		#region Public properties
		public int HROvertimeRateDtlID
		{
			get{return _hROvertimeRateDtlID;}
			set
			{
				if (value != this._hROvertimeRateDtlID)
				{
				_hROvertimeRateDtlID=value;
				NotifyChanged("HROvertimeRateDtlID");
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
		public int FK_HROvertimeRateID
		{
			get{return _fK_HROvertimeRateID;}
			set
			{
				if (value != this._fK_HROvertimeRateID)
				{
				_fK_HROvertimeRateID=value;
				NotifyChanged("FK_HROvertimeRateID");
				}
			}
		}
		public int FK_HRShiftID
		{
			get{return _fK_HRShiftID;}
			set
			{
				if (value != this._fK_HRShiftID)
				{
				_fK_HRShiftID=value;
				NotifyChanged("FK_HRShiftID");
				}
			}
		}
		public DateTime HROvertimeRateDtlStartDateTime
		{
			get{return _hROvertimeRateDtlStartDateTime;}
			set
			{
				if (value != this._hROvertimeRateDtlStartDateTime)
				{
				_hROvertimeRateDtlStartDateTime=value;
				NotifyChanged("HROvertimeRateDtlStartDateTime");
				}
			}
		}
		public DateTime HROvertimeRateDtlEndDateTime
		{
			get{return _hROvertimeRateDtlEndDateTime;}
			set
			{
				if (value != this._hROvertimeRateDtlEndDateTime)
				{
				_hROvertimeRateDtlEndDateTime=value;
				NotifyChanged("HROvertimeRateDtlEndDateTime");
				}
			}
		}
		public String HROvertimeRateDtlDesc
		{
			get{return _hROvertimeRateDtlDesc;}
			set
			{
				if (value != this._hROvertimeRateDtlDesc)
				{
				_hROvertimeRateDtlDesc=value;
				NotifyChanged("HROvertimeRateDtlDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}