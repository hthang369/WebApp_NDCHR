using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTCSrlOverTimes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTCSrlOverTimesInfo
	//Created Date:Tuesday, June 17, 2014
	//-----------------------------------------------------------
	
	public class HREmployeeTCSrlOverTimesInfo:BusinessObject
	{
		public HREmployeeTCSrlOverTimesInfo()
		{
		}
		#region Variables
		protected int _hREmployeeTCSrlOverTimeID;
		protected double _hREmployeeTCSrlOverTimeHourAmt;
		protected double _hREmployeeTCSrlOverTimeDayAmt;
		protected double _hREmployeeTCSrlOverTimeRateAmt;
		protected Nullable<DateTime> _hREmployeeTCSrlOverTimeDate;
		protected int _fK_HRShiftID;
		protected int _fK_HREmployeeID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _hRShiftName=String.Empty;
		protected int _fK_HROvertimeRateID;
		protected String _hROvertimeRateName=String.Empty;
		#endregion

		#region Public properties
		public int HREmployeeTCSrlOverTimeID
		{
			get{return _hREmployeeTCSrlOverTimeID;}
			set
			{
				if (value != this._hREmployeeTCSrlOverTimeID)
				{
				_hREmployeeTCSrlOverTimeID=value;
				NotifyChanged("HREmployeeTCSrlOverTimeID");
				}
			}
		}
		public double HREmployeeTCSrlOverTimeHourAmt
		{
			get{return _hREmployeeTCSrlOverTimeHourAmt;}
			set
			{
				if (value != this._hREmployeeTCSrlOverTimeHourAmt)
				{
				_hREmployeeTCSrlOverTimeHourAmt=value;
				NotifyChanged("HREmployeeTCSrlOverTimeHourAmt");
				}
			}
		}
		public double HREmployeeTCSrlOverTimeDayAmt
		{
			get{return _hREmployeeTCSrlOverTimeDayAmt;}
			set
			{
				if (value != this._hREmployeeTCSrlOverTimeDayAmt)
				{
				_hREmployeeTCSrlOverTimeDayAmt=value;
				NotifyChanged("HREmployeeTCSrlOverTimeDayAmt");
				}
			}
		}
		public double HREmployeeTCSrlOverTimeRateAmt
		{
			get{return _hREmployeeTCSrlOverTimeRateAmt;}
			set
			{
				if (value != this._hREmployeeTCSrlOverTimeRateAmt)
				{
				_hREmployeeTCSrlOverTimeRateAmt=value;
				NotifyChanged("HREmployeeTCSrlOverTimeRateAmt");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlOverTimeDate
		{
			get{return _hREmployeeTCSrlOverTimeDate;}
			set
			{
				if (value != this._hREmployeeTCSrlOverTimeDate)
				{
				_hREmployeeTCSrlOverTimeDate=value;
				NotifyChanged("HREmployeeTCSrlOverTimeDate");
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
		public int FK_HREmployeeID
		{
			get{return _fK_HREmployeeID;}
			set
			{
				if (value != this._fK_HREmployeeID)
				{
				_fK_HREmployeeID=value;
				NotifyChanged("FK_HREmployeeID");
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
		public String HRShiftName
		{
			get{return _hRShiftName;}
			set
			{
				if (value != this._hRShiftName)
				{
				_hRShiftName=value;
				NotifyChanged("HRShiftName");
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
		public String HROvertimeRateName
		{
			get{return _hROvertimeRateName;}
			set
			{
				if (value != this._hROvertimeRateName)
				{
				_hROvertimeRateName=value;
				NotifyChanged("HROvertimeRateName");
				}
			}
		}
		#endregion
	}
	#endregion
}