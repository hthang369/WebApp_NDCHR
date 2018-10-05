using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTCSrlMissAndEarlys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTCSrlMissAndEarlysInfo
	//Created Date:Monday, June 16, 2014
	//-----------------------------------------------------------
	
	public class HREmployeeTCSrlMissAndEarlysInfo:BusinessObject
	{
		public HREmployeeTCSrlMissAndEarlysInfo()
		{
		}
		#region Variables
		protected int _hREmployeeTCSrlMissAndEarlyID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected Nullable<DateTime> _hREmployeeTCSrlMissAndEarlyDate;
		protected double _hREmployeeTCSrlMissAndEarlyMinuteAmt;
		protected String _hREmployeeTCSrlMissAndEarlyTypeCombo=String.Empty;
		protected int _fK_HREmployeeID;
		protected int _fK_ShiftID;
		protected String _hRShiftName=String.Empty;
		#endregion

		#region Public properties
		public int HREmployeeTCSrlMissAndEarlyID
		{
			get{return _hREmployeeTCSrlMissAndEarlyID;}
			set
			{
				if (value != this._hREmployeeTCSrlMissAndEarlyID)
				{
				_hREmployeeTCSrlMissAndEarlyID=value;
				NotifyChanged("HREmployeeTCSrlMissAndEarlyID");
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
		public Nullable<DateTime> HREmployeeTCSrlMissAndEarlyDate
		{
			get{return _hREmployeeTCSrlMissAndEarlyDate;}
			set
			{
				if (value != this._hREmployeeTCSrlMissAndEarlyDate)
				{
				_hREmployeeTCSrlMissAndEarlyDate=value;
				NotifyChanged("HREmployeeTCSrlMissAndEarlyDate");
				}
			}
		}
		public double HREmployeeTCSrlMissAndEarlyMinuteAmt
		{
			get{return _hREmployeeTCSrlMissAndEarlyMinuteAmt;}
			set
			{
				if (value != this._hREmployeeTCSrlMissAndEarlyMinuteAmt)
				{
				_hREmployeeTCSrlMissAndEarlyMinuteAmt=value;
				NotifyChanged("HREmployeeTCSrlMissAndEarlyMinuteAmt");
				}
			}
		}
		public String HREmployeeTCSrlMissAndEarlyTypeCombo
		{
			get{return _hREmployeeTCSrlMissAndEarlyTypeCombo;}
			set
			{
				if (value != this._hREmployeeTCSrlMissAndEarlyTypeCombo)
				{
				_hREmployeeTCSrlMissAndEarlyTypeCombo=value;
				NotifyChanged("HREmployeeTCSrlMissAndEarlyTypeCombo");
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
		public int FK_ShiftID
		{
			get{return _fK_ShiftID;}
			set
			{
				if (value != this._fK_ShiftID)
				{
				_fK_ShiftID=value;
				NotifyChanged("FK_ShiftID");
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
		#endregion
	}
	#endregion
}