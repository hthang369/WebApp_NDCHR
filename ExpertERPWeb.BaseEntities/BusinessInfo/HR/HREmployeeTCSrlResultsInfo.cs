using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTCSrlResults
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTCSrlResultsInfo
	//Created Date:13 Tháng Mười Một 2013
	//-----------------------------------------------------------
	
	public class HREmployeeTCSrlResultsInfo:BusinessObject
	{
		public HREmployeeTCSrlResultsInfo()
		{
		}
		#region Variables
		protected int _hREmployeeTCSrlResultID;
		protected int _fK_HREmployeeID;
		protected Nullable<DateTime> _hREmployeeTCSrlResultMonth;
		protected double _hREmployeeTCSrlResultTotalShiftCount;
		protected double _hREmployeeTCSrlResultTotalOvertimeInRate1;
		protected double _hREmployeeTCSrlResultTotalOvertimeInRate2;
		protected double _hREmployeeTCSrlResultTotalOvertimeInRate3;
		protected double _hREmployeeTCSrlResultTotalOvertimeInRate4;
		protected double _hREmployeeTCSrlResultTotalOvertimeInRate5;
		protected double _hREmployeeTCSrlResultTotalOvertimeInRate6;
		protected int _hREmployeeTCSrlResultTotalWorkingHolidayCount;
		protected double _hREmployeeTCSrlResultTotalOffWorkUnPermission;
		protected double _hREmployeeTCSrlResultTotalOffWorkPermission;
		protected int _hREmployeeTCSrlResultTotalOffWorkPermissionAnnualLeave;
		protected int _hREmployeeTCSrlResultTotalOffWorkPermissionSickLeave;
		protected int _hREmployeeTCSrlResultTotalOffWorkPermissionWaitLeave;
		protected int _hREmployeeTCSrlResultTotalOffWorkPermissionPregnantLeave;
		protected int _hREmployeeTCSrlResultTotalOffWorkPermissionMarriedLeave;
		protected int _hREmployeeTCSrlResultTotalOffWorkPermissionMourningLeave;
		protected double _hREmployeeTCSrlResultTotalLateInTime;
		protected int _hREmployeeTCSrlResultTotalLateInTimeCount1;
		protected int _hREmployeeTCSrlResultTotalLateInTimeCount2;
		protected int _hREmployeeTCSrlResultTotalLateInTimeCount3;
		protected int _hREmployeeTCSrlResultTotalLateInTimeCount4;
		protected double _hREmployeeTCSrlResultTotalOffWorkCompassionateLeave;
		protected double _hREmployeeTCSrlResultTotalOffWorkUnsalariedLeave;
		protected double _hREmployeeTCSrlResultTotalOffWorkHolidayLeave;
		protected double _hREmployeeTCSrlResultTotalOffWorkOffsetLeave;
		protected double _hREmployeeTCSrlResultTotalOvertimeInRate7;
		#endregion

		#region Public properties
		public int HREmployeeTCSrlResultID
		{
			get{return _hREmployeeTCSrlResultID;}
			set
			{
				if (value != this._hREmployeeTCSrlResultID)
				{
				_hREmployeeTCSrlResultID=value;
				NotifyChanged("HREmployeeTCSrlResultID");
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
		public Nullable<DateTime> HREmployeeTCSrlResultMonth
		{
			get{return _hREmployeeTCSrlResultMonth;}
			set
			{
				if (value != this._hREmployeeTCSrlResultMonth)
				{
				_hREmployeeTCSrlResultMonth=value;
				NotifyChanged("HREmployeeTCSrlResultMonth");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalShiftCount
		{
			get{return _hREmployeeTCSrlResultTotalShiftCount;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalShiftCount)
				{
				_hREmployeeTCSrlResultTotalShiftCount=value;
				NotifyChanged("HREmployeeTCSrlResultTotalShiftCount");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOvertimeInRate1
		{
			get{return _hREmployeeTCSrlResultTotalOvertimeInRate1;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOvertimeInRate1)
				{
				_hREmployeeTCSrlResultTotalOvertimeInRate1=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOvertimeInRate1");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOvertimeInRate2
		{
			get{return _hREmployeeTCSrlResultTotalOvertimeInRate2;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOvertimeInRate2)
				{
				_hREmployeeTCSrlResultTotalOvertimeInRate2=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOvertimeInRate2");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOvertimeInRate3
		{
			get{return _hREmployeeTCSrlResultTotalOvertimeInRate3;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOvertimeInRate3)
				{
				_hREmployeeTCSrlResultTotalOvertimeInRate3=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOvertimeInRate3");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOvertimeInRate4
		{
			get{return _hREmployeeTCSrlResultTotalOvertimeInRate4;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOvertimeInRate4)
				{
				_hREmployeeTCSrlResultTotalOvertimeInRate4=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOvertimeInRate4");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOvertimeInRate5
		{
			get{return _hREmployeeTCSrlResultTotalOvertimeInRate5;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOvertimeInRate5)
				{
				_hREmployeeTCSrlResultTotalOvertimeInRate5=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOvertimeInRate5");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOvertimeInRate6
		{
			get{return _hREmployeeTCSrlResultTotalOvertimeInRate6;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOvertimeInRate6)
				{
				_hREmployeeTCSrlResultTotalOvertimeInRate6=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOvertimeInRate6");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalWorkingHolidayCount
		{
			get{return _hREmployeeTCSrlResultTotalWorkingHolidayCount;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalWorkingHolidayCount)
				{
				_hREmployeeTCSrlResultTotalWorkingHolidayCount=value;
				NotifyChanged("HREmployeeTCSrlResultTotalWorkingHolidayCount");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOffWorkUnPermission
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkUnPermission;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkUnPermission)
				{
				_hREmployeeTCSrlResultTotalOffWorkUnPermission=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkUnPermission");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOffWorkPermission
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkPermission;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkPermission)
				{
				_hREmployeeTCSrlResultTotalOffWorkPermission=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkPermission");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalOffWorkPermissionAnnualLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkPermissionAnnualLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkPermissionAnnualLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkPermissionAnnualLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkPermissionAnnualLeave");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalOffWorkPermissionSickLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkPermissionSickLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkPermissionSickLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkPermissionSickLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkPermissionSickLeave");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalOffWorkPermissionWaitLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkPermissionWaitLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkPermissionWaitLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkPermissionWaitLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkPermissionWaitLeave");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalOffWorkPermissionPregnantLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkPermissionPregnantLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkPermissionPregnantLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkPermissionPregnantLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkPermissionPregnantLeave");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalOffWorkPermissionMarriedLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkPermissionMarriedLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkPermissionMarriedLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkPermissionMarriedLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkPermissionMarriedLeave");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalOffWorkPermissionMourningLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkPermissionMourningLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkPermissionMourningLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkPermissionMourningLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkPermissionMourningLeave");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalLateInTime
		{
			get{return _hREmployeeTCSrlResultTotalLateInTime;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalLateInTime)
				{
				_hREmployeeTCSrlResultTotalLateInTime=value;
				NotifyChanged("HREmployeeTCSrlResultTotalLateInTime");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalLateInTimeCount1
		{
			get{return _hREmployeeTCSrlResultTotalLateInTimeCount1;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalLateInTimeCount1)
				{
				_hREmployeeTCSrlResultTotalLateInTimeCount1=value;
				NotifyChanged("HREmployeeTCSrlResultTotalLateInTimeCount1");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalLateInTimeCount2
		{
			get{return _hREmployeeTCSrlResultTotalLateInTimeCount2;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalLateInTimeCount2)
				{
				_hREmployeeTCSrlResultTotalLateInTimeCount2=value;
				NotifyChanged("HREmployeeTCSrlResultTotalLateInTimeCount2");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalLateInTimeCount3
		{
			get{return _hREmployeeTCSrlResultTotalLateInTimeCount3;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalLateInTimeCount3)
				{
				_hREmployeeTCSrlResultTotalLateInTimeCount3=value;
				NotifyChanged("HREmployeeTCSrlResultTotalLateInTimeCount3");
				}
			}
		}
		public int HREmployeeTCSrlResultTotalLateInTimeCount4
		{
			get{return _hREmployeeTCSrlResultTotalLateInTimeCount4;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalLateInTimeCount4)
				{
				_hREmployeeTCSrlResultTotalLateInTimeCount4=value;
				NotifyChanged("HREmployeeTCSrlResultTotalLateInTimeCount4");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOffWorkCompassionateLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkCompassionateLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkCompassionateLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkCompassionateLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkCompassionateLeave");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOffWorkUnsalariedLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkUnsalariedLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkUnsalariedLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkUnsalariedLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkUnsalariedLeave");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOffWorkHolidayLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkHolidayLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkHolidayLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkHolidayLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkHolidayLeave");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOffWorkOffsetLeave
		{
			get{return _hREmployeeTCSrlResultTotalOffWorkOffsetLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOffWorkOffsetLeave)
				{
				_hREmployeeTCSrlResultTotalOffWorkOffsetLeave=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOffWorkOffsetLeave");
				}
			}
		}
		public double HREmployeeTCSrlResultTotalOvertimeInRate7
		{
			get{return _hREmployeeTCSrlResultTotalOvertimeInRate7;}
			set
			{
				if (value != this._hREmployeeTCSrlResultTotalOvertimeInRate7)
				{
				_hREmployeeTCSrlResultTotalOvertimeInRate7=value;
				NotifyChanged("HREmployeeTCSrlResultTotalOvertimeInRate7");
				}
			}
		}
		#endregion
	}
	#endregion
}