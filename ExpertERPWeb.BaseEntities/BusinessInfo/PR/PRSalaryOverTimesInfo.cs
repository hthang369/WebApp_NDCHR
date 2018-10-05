using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PRSalaryOverTimes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PRSalaryOverTimesInfo
	//Created Date:Tuesday, August 12, 2014
	//-----------------------------------------------------------
	
	public class PRSalaryOverTimesInfo:BusinessObject
	{
		public PRSalaryOverTimesInfo()
		{
		}
		#region Variables
		protected int _pRSalaryOverTimeID;
		protected bool _aASelected=true;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected double _pRSalaryOverTimeHourAmt;
		protected double _pRSalaryOverTimeDayAmt;
		protected double _pRSalaryOverTimeRateAmt;
		protected Nullable<DateTime> _pRSalaryOverTimeDate;
		protected int _fK_HRShiftID;
		protected String _hRShiftName=String.Empty;
		protected int _fK_HREmployeeID;
		protected int _fK_HROvertimeRateID;
		protected String _hROvertimeRateName=String.Empty;
		protected double _pRSalaryOverTimeAmt;
		#endregion

		#region Public properties
		public int PRSalaryOverTimeID
		{
			get{return _pRSalaryOverTimeID;}
			set
			{
				if (value != this._pRSalaryOverTimeID)
				{
				_pRSalaryOverTimeID=value;
				NotifyChanged("PRSalaryOverTimeID");
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
		public double PRSalaryOverTimeHourAmt
		{
			get{return _pRSalaryOverTimeHourAmt;}
			set
			{
				if (value != this._pRSalaryOverTimeHourAmt)
				{
				_pRSalaryOverTimeHourAmt=value;
				NotifyChanged("PRSalaryOverTimeHourAmt");
				}
			}
		}
		public double PRSalaryOverTimeDayAmt
		{
			get{return _pRSalaryOverTimeDayAmt;}
			set
			{
				if (value != this._pRSalaryOverTimeDayAmt)
				{
				_pRSalaryOverTimeDayAmt=value;
				NotifyChanged("PRSalaryOverTimeDayAmt");
				}
			}
		}
		public double PRSalaryOverTimeRateAmt
		{
			get{return _pRSalaryOverTimeRateAmt;}
			set
			{
				if (value != this._pRSalaryOverTimeRateAmt)
				{
				_pRSalaryOverTimeRateAmt=value;
				NotifyChanged("PRSalaryOverTimeRateAmt");
				}
			}
		}
		public Nullable<DateTime> PRSalaryOverTimeDate
		{
			get{return _pRSalaryOverTimeDate;}
			set
			{
				if (value != this._pRSalaryOverTimeDate)
				{
				_pRSalaryOverTimeDate=value;
				NotifyChanged("PRSalaryOverTimeDate");
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
		public double PRSalaryOverTimeAmt
		{
			get{return _pRSalaryOverTimeAmt;}
			set
			{
				if (value != this._pRSalaryOverTimeAmt)
				{
				_pRSalaryOverTimeAmt=value;
				NotifyChanged("PRSalaryOverTimeAmt");
				}
			}
		}
		#endregion
	}
	#endregion
}