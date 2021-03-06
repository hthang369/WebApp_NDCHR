using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HREmployeeTCSrlDetailResults
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HREmployeeTCSrlDetailResultsInfo
	//Created Date:Friday, August 29, 2014
	//-----------------------------------------------------------
	
	public class HREmployeeTCSrlDetailResultsInfo:BusinessObject
	{
		public HREmployeeTCSrlDetailResultsInfo()
		{
		}
		#region Variables
		protected int _hREmployeeTCSrlDetailResultID;
		protected int _fK_HREmployeeID;
		protected DateTime _hREmployeeTCSrlDetailResultMonth=DateTime.Now;
		protected String _hREmployeeTCSrlDetailResult1=String.Empty;
		protected String _hREmployeeTCSrlDetailResult2=String.Empty;
		protected String _hREmployeeTCSrlDetailResult3=String.Empty;
		protected String _hREmployeeTCSrlDetailResult4=String.Empty;
		protected String _hREmployeeTCSrlDetailResult5=String.Empty;
		protected String _hREmployeeTCSrlDetailResult6=String.Empty;
		protected String _hREmployeeTCSrlDetailResult7=String.Empty;
		protected String _hREmployeeTCSrlDetailResult8=String.Empty;
		protected String _hREmployeeTCSrlDetailResult9=String.Empty;
		protected String _hREmployeeTCSrlDetailResult10=String.Empty;
		protected String _hREmployeeTCSrlDetailResult11=String.Empty;
		protected String _hREmployeeTCSrlDetailResult12=String.Empty;
		protected String _hREmployeeTCSrlDetailResult13=String.Empty;
		protected String _hREmployeeTCSrlDetailResult14=String.Empty;
		protected String _hREmployeeTCSrlDetailResult15=String.Empty;
		protected String _hREmployeeTCSrlDetailResult16=String.Empty;
		protected String _hREmployeeTCSrlDetailResult17=String.Empty;
		protected String _hREmployeeTCSrlDetailResult18=String.Empty;
		protected String _hREmployeeTCSrlDetailResult19=String.Empty;
		protected String _hREmployeeTCSrlDetailResult20=String.Empty;
		protected String _hREmployeeTCSrlDetailResult21=String.Empty;
		protected String _hREmployeeTCSrlDetailResult22=String.Empty;
		protected String _hREmployeeTCSrlDetailResult23=String.Empty;
		protected String _hREmployeeTCSrlDetailResult24=String.Empty;
		protected String _hREmployeeTCSrlDetailResult25=String.Empty;
		protected String _hREmployeeTCSrlDetailResult26=String.Empty;
		protected String _hREmployeeTCSrlDetailResult27=String.Empty;
		protected String _hREmployeeTCSrlDetailResult28=String.Empty;
		protected String _hREmployeeTCSrlDetailResult29=String.Empty;
		protected String _hREmployeeTCSrlDetailResult30=String.Empty;
		protected String _hREmployeeTCSrlDetailResult31=String.Empty;
		protected double _hREmployeeTCSrlDetailResultTotalShiftCount;
		protected int _hREmployeeTCSrlDetailResultTotalWorkingHolidayCount;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkUnPermission;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkPermission;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkPermissionAnnualLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkPermissionSickLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkPermissionWaitLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkPermissionPregnantLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkPermissionMarriedLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkPermissionMourningLeave;
		protected double _hREmployeeTCSrlDetailResultTotalLateInTime;
		protected int _hREmployeeTCSrlDetailResultTotalLateInTimeCount1;
		protected int _hREmployeeTCSrlDetailResultTotalLateInTimeCount2;
		protected int _hREmployeeTCSrlDetailResultTotalLateInTimeCount3;
		protected int _hREmployeeTCSrlDetailResultTotalLateInTimeCount4;
		protected double _hREmployeeTCSrlDetailResultTotalShiftManualAmt;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime1;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime2;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime3;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime4;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime5;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime6;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkCompassionateLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkUnsalariedLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkHolidayLeave;
		protected double _hREmployeeTCSrlDetailResultTotalOffWorkOffsetLeave;
		protected bool _hREmployeeTCSrlDetailResultIsOvertime=true;
		protected double _hREmployeeTCSrlDetailResultShiftDayAmt;
		protected double _hREmployeeTCSrlDetailResultTotalEarlyOutTime;
		protected double _hREmployeeTCSrlDetailResultTotalMissHour;
		protected double _hREmployeeTCSrlDetailResultTotalOffsetCount;
		protected int _fK_HRSectionID;
		protected int _fK_HRPositionID;
		protected int _fK_HRDepartmentID;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime7;
		protected double _hREmployeeTCSrlDetailResultTotalOvertime8;
		#endregion

		#region Public properties
		public int HREmployeeTCSrlDetailResultID
		{
			get{return _hREmployeeTCSrlDetailResultID;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultID)
				{
				_hREmployeeTCSrlDetailResultID=value;
				NotifyChanged("HREmployeeTCSrlDetailResultID");
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
		public DateTime HREmployeeTCSrlDetailResultMonth
		{
			get{return _hREmployeeTCSrlDetailResultMonth;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultMonth)
				{
				_hREmployeeTCSrlDetailResultMonth=value;
				NotifyChanged("HREmployeeTCSrlDetailResultMonth");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult1
		{
			get{return _hREmployeeTCSrlDetailResult1;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult1)
				{
				_hREmployeeTCSrlDetailResult1=value;
				NotifyChanged("HREmployeeTCSrlDetailResult1");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult2
		{
			get{return _hREmployeeTCSrlDetailResult2;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult2)
				{
				_hREmployeeTCSrlDetailResult2=value;
				NotifyChanged("HREmployeeTCSrlDetailResult2");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult3
		{
			get{return _hREmployeeTCSrlDetailResult3;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult3)
				{
				_hREmployeeTCSrlDetailResult3=value;
				NotifyChanged("HREmployeeTCSrlDetailResult3");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult4
		{
			get{return _hREmployeeTCSrlDetailResult4;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult4)
				{
				_hREmployeeTCSrlDetailResult4=value;
				NotifyChanged("HREmployeeTCSrlDetailResult4");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult5
		{
			get{return _hREmployeeTCSrlDetailResult5;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult5)
				{
				_hREmployeeTCSrlDetailResult5=value;
				NotifyChanged("HREmployeeTCSrlDetailResult5");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult6
		{
			get{return _hREmployeeTCSrlDetailResult6;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult6)
				{
				_hREmployeeTCSrlDetailResult6=value;
				NotifyChanged("HREmployeeTCSrlDetailResult6");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult7
		{
			get{return _hREmployeeTCSrlDetailResult7;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult7)
				{
				_hREmployeeTCSrlDetailResult7=value;
				NotifyChanged("HREmployeeTCSrlDetailResult7");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult8
		{
			get{return _hREmployeeTCSrlDetailResult8;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult8)
				{
				_hREmployeeTCSrlDetailResult8=value;
				NotifyChanged("HREmployeeTCSrlDetailResult8");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult9
		{
			get{return _hREmployeeTCSrlDetailResult9;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult9)
				{
				_hREmployeeTCSrlDetailResult9=value;
				NotifyChanged("HREmployeeTCSrlDetailResult9");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult10
		{
			get{return _hREmployeeTCSrlDetailResult10;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult10)
				{
				_hREmployeeTCSrlDetailResult10=value;
				NotifyChanged("HREmployeeTCSrlDetailResult10");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult11
		{
			get{return _hREmployeeTCSrlDetailResult11;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult11)
				{
				_hREmployeeTCSrlDetailResult11=value;
				NotifyChanged("HREmployeeTCSrlDetailResult11");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult12
		{
			get{return _hREmployeeTCSrlDetailResult12;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult12)
				{
				_hREmployeeTCSrlDetailResult12=value;
				NotifyChanged("HREmployeeTCSrlDetailResult12");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult13
		{
			get{return _hREmployeeTCSrlDetailResult13;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult13)
				{
				_hREmployeeTCSrlDetailResult13=value;
				NotifyChanged("HREmployeeTCSrlDetailResult13");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult14
		{
			get{return _hREmployeeTCSrlDetailResult14;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult14)
				{
				_hREmployeeTCSrlDetailResult14=value;
				NotifyChanged("HREmployeeTCSrlDetailResult14");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult15
		{
			get{return _hREmployeeTCSrlDetailResult15;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult15)
				{
				_hREmployeeTCSrlDetailResult15=value;
				NotifyChanged("HREmployeeTCSrlDetailResult15");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult16
		{
			get{return _hREmployeeTCSrlDetailResult16;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult16)
				{
				_hREmployeeTCSrlDetailResult16=value;
				NotifyChanged("HREmployeeTCSrlDetailResult16");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult17
		{
			get{return _hREmployeeTCSrlDetailResult17;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult17)
				{
				_hREmployeeTCSrlDetailResult17=value;
				NotifyChanged("HREmployeeTCSrlDetailResult17");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult18
		{
			get{return _hREmployeeTCSrlDetailResult18;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult18)
				{
				_hREmployeeTCSrlDetailResult18=value;
				NotifyChanged("HREmployeeTCSrlDetailResult18");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult19
		{
			get{return _hREmployeeTCSrlDetailResult19;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult19)
				{
				_hREmployeeTCSrlDetailResult19=value;
				NotifyChanged("HREmployeeTCSrlDetailResult19");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult20
		{
			get{return _hREmployeeTCSrlDetailResult20;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult20)
				{
				_hREmployeeTCSrlDetailResult20=value;
				NotifyChanged("HREmployeeTCSrlDetailResult20");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult21
		{
			get{return _hREmployeeTCSrlDetailResult21;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult21)
				{
				_hREmployeeTCSrlDetailResult21=value;
				NotifyChanged("HREmployeeTCSrlDetailResult21");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult22
		{
			get{return _hREmployeeTCSrlDetailResult22;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult22)
				{
				_hREmployeeTCSrlDetailResult22=value;
				NotifyChanged("HREmployeeTCSrlDetailResult22");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult23
		{
			get{return _hREmployeeTCSrlDetailResult23;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult23)
				{
				_hREmployeeTCSrlDetailResult23=value;
				NotifyChanged("HREmployeeTCSrlDetailResult23");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult24
		{
			get{return _hREmployeeTCSrlDetailResult24;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult24)
				{
				_hREmployeeTCSrlDetailResult24=value;
				NotifyChanged("HREmployeeTCSrlDetailResult24");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult25
		{
			get{return _hREmployeeTCSrlDetailResult25;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult25)
				{
				_hREmployeeTCSrlDetailResult25=value;
				NotifyChanged("HREmployeeTCSrlDetailResult25");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult26
		{
			get{return _hREmployeeTCSrlDetailResult26;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult26)
				{
				_hREmployeeTCSrlDetailResult26=value;
				NotifyChanged("HREmployeeTCSrlDetailResult26");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult27
		{
			get{return _hREmployeeTCSrlDetailResult27;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult27)
				{
				_hREmployeeTCSrlDetailResult27=value;
				NotifyChanged("HREmployeeTCSrlDetailResult27");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult28
		{
			get{return _hREmployeeTCSrlDetailResult28;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult28)
				{
				_hREmployeeTCSrlDetailResult28=value;
				NotifyChanged("HREmployeeTCSrlDetailResult28");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult29
		{
			get{return _hREmployeeTCSrlDetailResult29;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult29)
				{
				_hREmployeeTCSrlDetailResult29=value;
				NotifyChanged("HREmployeeTCSrlDetailResult29");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult30
		{
			get{return _hREmployeeTCSrlDetailResult30;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult30)
				{
				_hREmployeeTCSrlDetailResult30=value;
				NotifyChanged("HREmployeeTCSrlDetailResult30");
				}
			}
		}
		public String HREmployeeTCSrlDetailResult31
		{
			get{return _hREmployeeTCSrlDetailResult31;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResult31)
				{
				_hREmployeeTCSrlDetailResult31=value;
				NotifyChanged("HREmployeeTCSrlDetailResult31");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalShiftCount
		{
			get{return _hREmployeeTCSrlDetailResultTotalShiftCount;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalShiftCount)
				{
				_hREmployeeTCSrlDetailResultTotalShiftCount=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalShiftCount");
				}
			}
		}
		public int HREmployeeTCSrlDetailResultTotalWorkingHolidayCount
		{
			get{return _hREmployeeTCSrlDetailResultTotalWorkingHolidayCount;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalWorkingHolidayCount)
				{
				_hREmployeeTCSrlDetailResultTotalWorkingHolidayCount=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalWorkingHolidayCount");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkUnPermission
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkUnPermission;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkUnPermission)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkUnPermission=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkUnPermission");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkPermission
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkPermission;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkPermission)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkPermission=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkPermission");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkPermissionAnnualLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkPermissionAnnualLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkPermissionAnnualLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkPermissionAnnualLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkPermissionAnnualLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkPermissionSickLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkPermissionSickLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkPermissionSickLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkPermissionSickLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkPermissionSickLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkPermissionWaitLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkPermissionWaitLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkPermissionWaitLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkPermissionWaitLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkPermissionWaitLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkPermissionPregnantLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkPermissionPregnantLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkPermissionPregnantLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkPermissionPregnantLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkPermissionPregnantLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkPermissionMarriedLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkPermissionMarriedLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkPermissionMarriedLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkPermissionMarriedLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkPermissionMarriedLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkPermissionMourningLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkPermissionMourningLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkPermissionMourningLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkPermissionMourningLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkPermissionMourningLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalLateInTime
		{
			get{return _hREmployeeTCSrlDetailResultTotalLateInTime;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalLateInTime)
				{
				_hREmployeeTCSrlDetailResultTotalLateInTime=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalLateInTime");
				}
			}
		}
		public int HREmployeeTCSrlDetailResultTotalLateInTimeCount1
		{
			get{return _hREmployeeTCSrlDetailResultTotalLateInTimeCount1;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalLateInTimeCount1)
				{
				_hREmployeeTCSrlDetailResultTotalLateInTimeCount1=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalLateInTimeCount1");
				}
			}
		}
		public int HREmployeeTCSrlDetailResultTotalLateInTimeCount2
		{
			get{return _hREmployeeTCSrlDetailResultTotalLateInTimeCount2;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalLateInTimeCount2)
				{
				_hREmployeeTCSrlDetailResultTotalLateInTimeCount2=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalLateInTimeCount2");
				}
			}
		}
		public int HREmployeeTCSrlDetailResultTotalLateInTimeCount3
		{
			get{return _hREmployeeTCSrlDetailResultTotalLateInTimeCount3;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalLateInTimeCount3)
				{
				_hREmployeeTCSrlDetailResultTotalLateInTimeCount3=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalLateInTimeCount3");
				}
			}
		}
		public int HREmployeeTCSrlDetailResultTotalLateInTimeCount4
		{
			get{return _hREmployeeTCSrlDetailResultTotalLateInTimeCount4;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalLateInTimeCount4)
				{
				_hREmployeeTCSrlDetailResultTotalLateInTimeCount4=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalLateInTimeCount4");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalShiftManualAmt
		{
			get{return _hREmployeeTCSrlDetailResultTotalShiftManualAmt;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalShiftManualAmt)
				{
				_hREmployeeTCSrlDetailResultTotalShiftManualAmt=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalShiftManualAmt");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime1
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime1;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime1)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime1=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime1");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime2
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime2;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime2)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime2=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime2");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime3
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime3;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime3)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime3=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime3");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime4
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime4;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime4)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime4=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime4");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime5
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime5;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime5)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime5=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime5");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime6
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime6;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime6)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime6=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime6");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkCompassionateLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkCompassionateLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkCompassionateLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkCompassionateLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkCompassionateLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkUnsalariedLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkUnsalariedLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkUnsalariedLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkUnsalariedLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkUnsalariedLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkHolidayLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkHolidayLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkHolidayLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkHolidayLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkHolidayLeave");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffWorkOffsetLeave
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffWorkOffsetLeave;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffWorkOffsetLeave)
				{
				_hREmployeeTCSrlDetailResultTotalOffWorkOffsetLeave=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffWorkOffsetLeave");
				}
			}
		}
		public bool HREmployeeTCSrlDetailResultIsOvertime
		{
			get{return _hREmployeeTCSrlDetailResultIsOvertime;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultIsOvertime)
				{
				_hREmployeeTCSrlDetailResultIsOvertime=value;
				NotifyChanged("HREmployeeTCSrlDetailResultIsOvertime");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultShiftDayAmt
		{
			get{return _hREmployeeTCSrlDetailResultShiftDayAmt;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultShiftDayAmt)
				{
				_hREmployeeTCSrlDetailResultShiftDayAmt=value;
				NotifyChanged("HREmployeeTCSrlDetailResultShiftDayAmt");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalEarlyOutTime
		{
			get{return _hREmployeeTCSrlDetailResultTotalEarlyOutTime;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalEarlyOutTime)
				{
				_hREmployeeTCSrlDetailResultTotalEarlyOutTime=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalEarlyOutTime");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalMissHour
		{
			get{return _hREmployeeTCSrlDetailResultTotalMissHour;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalMissHour)
				{
				_hREmployeeTCSrlDetailResultTotalMissHour=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalMissHour");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOffsetCount
		{
			get{return _hREmployeeTCSrlDetailResultTotalOffsetCount;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOffsetCount)
				{
				_hREmployeeTCSrlDetailResultTotalOffsetCount=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOffsetCount");
				}
			}
		}
		public int FK_HRSectionID
		{
			get{return _fK_HRSectionID;}
			set
			{
				if (value != this._fK_HRSectionID)
				{
				_fK_HRSectionID=value;
				NotifyChanged("FK_HRSectionID");
				}
			}
		}
		public int FK_HRPositionID
		{
			get{return _fK_HRPositionID;}
			set
			{
				if (value != this._fK_HRPositionID)
				{
				_fK_HRPositionID=value;
				NotifyChanged("FK_HRPositionID");
				}
			}
		}
		public int FK_HRDepartmentID
		{
			get{return _fK_HRDepartmentID;}
			set
			{
				if (value != this._fK_HRDepartmentID)
				{
				_fK_HRDepartmentID=value;
				NotifyChanged("FK_HRDepartmentID");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime7
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime7;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime7)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime7=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime7");
				}
			}
		}
		public double HREmployeeTCSrlDetailResultTotalOvertime8
		{
			get{return _hREmployeeTCSrlDetailResultTotalOvertime8;}
			set
			{
				if (value != this._hREmployeeTCSrlDetailResultTotalOvertime8)
				{
				_hREmployeeTCSrlDetailResultTotalOvertime8=value;
				NotifyChanged("HREmployeeTCSrlDetailResultTotalOvertime8");
				}
			}
		}
		#endregion
	}
	#endregion
}