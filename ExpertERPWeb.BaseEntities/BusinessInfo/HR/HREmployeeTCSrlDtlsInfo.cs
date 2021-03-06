
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HREmployeeTCSrlDtls
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.89)
    //Class: HREmployeeTCSrlDtlsInfo
    //Created Date: Wednesday, 19 Jul 2017
    //-----------------------------------------------------------

    public class HREmployeeTCSrlDtlsInfo : BusinessObject
    {
        public HREmployeeTCSrlDtlsInfo()
        {
        }
        #region Variables
		protected int _hREmployeeTCSrlDtlID;
		protected String _aAStatus = DefaultAAStatus;
		protected int _fK_HREmployeeID;
		protected int _fK_HREmployeeTimeCardID;
		protected int _fK_ShiftID;
		protected int _fK_HREmployeeLeaveTypeID;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlStartDatetime;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlEndDatetime;
		protected double _hREmployeeTCSrlDtlWorkingHour;
		protected double _hREmployeeTCSrlDtlShiftCount;
		protected double _hREmployeeTCSrlDtlOvertimeHour;
		protected String _hRTCSrlTypeCombo = String.Empty;
		protected String _aACreatedUser = String.Empty;
		protected String _aAUpdatedUser = String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected double _hREmployeeTCSrlDtlLateInTime;
		protected double _hREmployeeTCSrlDtlEarlyOutTime;
		protected double _hREmployeeTCSrlDtlTotalMissHour;
		protected String _hREmployeeTCSrlDtlDesc = String.Empty;
		protected double _hREmployeeTCSrlDtlOvertimeShiftCount;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlStartDatetime2;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlStartDatetime3;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlStartDatetime4;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlEndDatetime2;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlEndDatetime3;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlEndDatetime4;
		protected Nullable<DateTime> _hREmployeeTCSrlDtlInDatetime;
		protected int _fK_HROvertimeRateID;
		protected double _hREmployeeTCSrlDtlOvertimeRate;
		protected double _hREmployeeTCSrlDtlOvertimeHourCal;
		protected String _hROvertimeRateTypeCombo = String.Empty;
		protected String _hREmployeeLeaveTypeCombo = String.Empty;
		protected double _hREmployeeTCSrlDtlOffWorkNumber;
		protected String _hREmployeeOffWorkTypeCombo = String.Empty;
		protected int _hREmployeeTCSrlDtlRiceCheckNumber;
		protected double _hREmployeeTCSrlDtlOvertimeNightHour;
		protected double _hREmployeeTCSrlDtlWorkingHourReal;
		protected double _hREmployeeTCSrlDtlHourByTimeCard;
		protected int _hREmployeeTCSrlDtlEarlyOutTimeCount;
		protected int _hREmployeeTCSrlDtlLateInTimeCount;
		
        #endregion

        #region Public properties
		public int HREmployeeTCSrlDtlID
		{
			get { return _hREmployeeTCSrlDtlID; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlID)
				{
					_hREmployeeTCSrlDtlID = value;
					NotifyChanged("HREmployeeTCSrlDtlID");
				}
			}
		}
		public String AAStatus
		{
			get { return _aAStatus; }
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus = value;
					NotifyChanged("AAStatus");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get { return _fK_HREmployeeID; }
			set
			{
				if (value != this._fK_HREmployeeID)
				{
					_fK_HREmployeeID = value;
					NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public int FK_HREmployeeTimeCardID
		{
			get { return _fK_HREmployeeTimeCardID; }
			set
			{
				if (value != this._fK_HREmployeeTimeCardID)
				{
					_fK_HREmployeeTimeCardID = value;
					NotifyChanged("FK_HREmployeeTimeCardID");
				}
			}
		}
		public int FK_ShiftID
		{
			get { return _fK_ShiftID; }
			set
			{
				if (value != this._fK_ShiftID)
				{
					_fK_ShiftID = value;
					NotifyChanged("FK_ShiftID");
				}
			}
		}
		public int FK_HREmployeeLeaveTypeID
		{
			get { return _fK_HREmployeeLeaveTypeID; }
			set
			{
				if (value != this._fK_HREmployeeLeaveTypeID)
				{
					_fK_HREmployeeLeaveTypeID = value;
					NotifyChanged("FK_HREmployeeLeaveTypeID");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlStartDatetime
		{
			get { return _hREmployeeTCSrlDtlStartDatetime; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlStartDatetime)
				{
					_hREmployeeTCSrlDtlStartDatetime = value;
					NotifyChanged("HREmployeeTCSrlDtlStartDatetime");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlEndDatetime
		{
			get { return _hREmployeeTCSrlDtlEndDatetime; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlEndDatetime)
				{
					_hREmployeeTCSrlDtlEndDatetime = value;
					NotifyChanged("HREmployeeTCSrlDtlEndDatetime");
				}
			}
		}
		public double HREmployeeTCSrlDtlWorkingHour
		{
			get { return _hREmployeeTCSrlDtlWorkingHour; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlWorkingHour)
				{
					_hREmployeeTCSrlDtlWorkingHour = value;
					NotifyChanged("HREmployeeTCSrlDtlWorkingHour");
				}
			}
		}
		public double HREmployeeTCSrlDtlShiftCount
		{
			get { return _hREmployeeTCSrlDtlShiftCount; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlShiftCount)
				{
					_hREmployeeTCSrlDtlShiftCount = value;
					NotifyChanged("HREmployeeTCSrlDtlShiftCount");
				}
			}
		}
		public double HREmployeeTCSrlDtlOvertimeHour
		{
			get { return _hREmployeeTCSrlDtlOvertimeHour; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlOvertimeHour)
				{
					_hREmployeeTCSrlDtlOvertimeHour = value;
					NotifyChanged("HREmployeeTCSrlDtlOvertimeHour");
				}
			}
		}
		public String HRTCSrlTypeCombo
		{
			get { return _hRTCSrlTypeCombo; }
			set
			{
				if (value != this._hRTCSrlTypeCombo)
				{
					_hRTCSrlTypeCombo = value;
					NotifyChanged("HRTCSrlTypeCombo");
				}
			}
		}
		public String AACreatedUser
		{
			get { return _aACreatedUser; }
			set
			{
				if (value != this._aACreatedUser)
				{
					_aACreatedUser = value;
					NotifyChanged("AACreatedUser");
				}
			}
		}
		public String AAUpdatedUser
		{
			get { return _aAUpdatedUser; }
			set
			{
				if (value != this._aAUpdatedUser)
				{
					_aAUpdatedUser = value;
					NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get { return _aACreatedDate; }
			set
			{
				if (value != this._aACreatedDate)
				{
					_aACreatedDate = value;
					NotifyChanged("AACreatedDate");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get { return _aAUpdatedDate; }
			set
			{
				if (value != this._aAUpdatedDate)
				{
					_aAUpdatedDate = value;
					NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public double HREmployeeTCSrlDtlLateInTime
		{
			get { return _hREmployeeTCSrlDtlLateInTime; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlLateInTime)
				{
					_hREmployeeTCSrlDtlLateInTime = value;
					NotifyChanged("HREmployeeTCSrlDtlLateInTime");
				}
			}
		}
		public double HREmployeeTCSrlDtlEarlyOutTime
		{
			get { return _hREmployeeTCSrlDtlEarlyOutTime; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlEarlyOutTime)
				{
					_hREmployeeTCSrlDtlEarlyOutTime = value;
					NotifyChanged("HREmployeeTCSrlDtlEarlyOutTime");
				}
			}
		}
		public double HREmployeeTCSrlDtlTotalMissHour
		{
			get { return _hREmployeeTCSrlDtlTotalMissHour; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlTotalMissHour)
				{
					_hREmployeeTCSrlDtlTotalMissHour = value;
					NotifyChanged("HREmployeeTCSrlDtlTotalMissHour");
				}
			}
		}
		public String HREmployeeTCSrlDtlDesc
		{
			get { return _hREmployeeTCSrlDtlDesc; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlDesc)
				{
					_hREmployeeTCSrlDtlDesc = value;
					NotifyChanged("HREmployeeTCSrlDtlDesc");
				}
			}
		}
		public double HREmployeeTCSrlDtlOvertimeShiftCount
		{
			get { return _hREmployeeTCSrlDtlOvertimeShiftCount; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlOvertimeShiftCount)
				{
					_hREmployeeTCSrlDtlOvertimeShiftCount = value;
					NotifyChanged("HREmployeeTCSrlDtlOvertimeShiftCount");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlStartDatetime2
		{
			get { return _hREmployeeTCSrlDtlStartDatetime2; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlStartDatetime2)
				{
					_hREmployeeTCSrlDtlStartDatetime2 = value;
					NotifyChanged("HREmployeeTCSrlDtlStartDatetime2");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlStartDatetime3
		{
			get { return _hREmployeeTCSrlDtlStartDatetime3; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlStartDatetime3)
				{
					_hREmployeeTCSrlDtlStartDatetime3 = value;
					NotifyChanged("HREmployeeTCSrlDtlStartDatetime3");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlStartDatetime4
		{
			get { return _hREmployeeTCSrlDtlStartDatetime4; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlStartDatetime4)
				{
					_hREmployeeTCSrlDtlStartDatetime4 = value;
					NotifyChanged("HREmployeeTCSrlDtlStartDatetime4");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlEndDatetime2
		{
			get { return _hREmployeeTCSrlDtlEndDatetime2; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlEndDatetime2)
				{
					_hREmployeeTCSrlDtlEndDatetime2 = value;
					NotifyChanged("HREmployeeTCSrlDtlEndDatetime2");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlEndDatetime3
		{
			get { return _hREmployeeTCSrlDtlEndDatetime3; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlEndDatetime3)
				{
					_hREmployeeTCSrlDtlEndDatetime3 = value;
					NotifyChanged("HREmployeeTCSrlDtlEndDatetime3");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlEndDatetime4
		{
			get { return _hREmployeeTCSrlDtlEndDatetime4; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlEndDatetime4)
				{
					_hREmployeeTCSrlDtlEndDatetime4 = value;
					NotifyChanged("HREmployeeTCSrlDtlEndDatetime4");
				}
			}
		}
		public Nullable<DateTime> HREmployeeTCSrlDtlInDatetime
		{
			get { return _hREmployeeTCSrlDtlInDatetime; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlInDatetime)
				{
					_hREmployeeTCSrlDtlInDatetime = value;
					NotifyChanged("HREmployeeTCSrlDtlInDatetime");
				}
			}
		}
		public int FK_HROvertimeRateID
		{
			get { return _fK_HROvertimeRateID; }
			set
			{
				if (value != this._fK_HROvertimeRateID)
				{
					_fK_HROvertimeRateID = value;
					NotifyChanged("FK_HROvertimeRateID");
				}
			}
		}
		public double HREmployeeTCSrlDtlOvertimeRate
		{
			get { return _hREmployeeTCSrlDtlOvertimeRate; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlOvertimeRate)
				{
					_hREmployeeTCSrlDtlOvertimeRate = value;
					NotifyChanged("HREmployeeTCSrlDtlOvertimeRate");
				}
			}
		}
		public double HREmployeeTCSrlDtlOvertimeHourCal
		{
			get { return _hREmployeeTCSrlDtlOvertimeHourCal; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlOvertimeHourCal)
				{
					_hREmployeeTCSrlDtlOvertimeHourCal = value;
					NotifyChanged("HREmployeeTCSrlDtlOvertimeHourCal");
				}
			}
		}
		public String HROvertimeRateTypeCombo
		{
			get { return _hROvertimeRateTypeCombo; }
			set
			{
				if (value != this._hROvertimeRateTypeCombo)
				{
					_hROvertimeRateTypeCombo = value;
					NotifyChanged("HROvertimeRateTypeCombo");
				}
			}
		}
		public String HREmployeeLeaveTypeCombo
		{
			get { return _hREmployeeLeaveTypeCombo; }
			set
			{
				if (value != this._hREmployeeLeaveTypeCombo)
				{
					_hREmployeeLeaveTypeCombo = value;
					NotifyChanged("HREmployeeLeaveTypeCombo");
				}
			}
		}
		public double HREmployeeTCSrlDtlOffWorkNumber
		{
			get { return _hREmployeeTCSrlDtlOffWorkNumber; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlOffWorkNumber)
				{
					_hREmployeeTCSrlDtlOffWorkNumber = value;
					NotifyChanged("HREmployeeTCSrlDtlOffWorkNumber");
				}
			}
		}
		public String HREmployeeOffWorkTypeCombo
		{
			get { return _hREmployeeOffWorkTypeCombo; }
			set
			{
				if (value != this._hREmployeeOffWorkTypeCombo)
				{
					_hREmployeeOffWorkTypeCombo = value;
					NotifyChanged("HREmployeeOffWorkTypeCombo");
				}
			}
		}
		public int HREmployeeTCSrlDtlRiceCheckNumber
		{
			get { return _hREmployeeTCSrlDtlRiceCheckNumber; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlRiceCheckNumber)
				{
					_hREmployeeTCSrlDtlRiceCheckNumber = value;
					NotifyChanged("HREmployeeTCSrlDtlRiceCheckNumber");
				}
			}
		}
		public double HREmployeeTCSrlDtlOvertimeNightHour
		{
			get { return _hREmployeeTCSrlDtlOvertimeNightHour; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlOvertimeNightHour)
				{
					_hREmployeeTCSrlDtlOvertimeNightHour = value;
					NotifyChanged("HREmployeeTCSrlDtlOvertimeNightHour");
				}
			}
		}
		public double HREmployeeTCSrlDtlWorkingHourReal
		{
			get { return _hREmployeeTCSrlDtlWorkingHourReal; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlWorkingHourReal)
				{
					_hREmployeeTCSrlDtlWorkingHourReal = value;
					NotifyChanged("HREmployeeTCSrlDtlWorkingHourReal");
				}
			}
		}
		public double HREmployeeTCSrlDtlHourByTimeCard
		{
			get { return _hREmployeeTCSrlDtlHourByTimeCard; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlHourByTimeCard)
				{
					_hREmployeeTCSrlDtlHourByTimeCard = value;
					NotifyChanged("HREmployeeTCSrlDtlHourByTimeCard");
				}
			}
		}
		public int HREmployeeTCSrlDtlEarlyOutTimeCount
		{
			get { return _hREmployeeTCSrlDtlEarlyOutTimeCount; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlEarlyOutTimeCount)
				{
					_hREmployeeTCSrlDtlEarlyOutTimeCount = value;
					NotifyChanged("HREmployeeTCSrlDtlEarlyOutTimeCount");
				}
			}
		}
		public int HREmployeeTCSrlDtlLateInTimeCount
		{
			get { return _hREmployeeTCSrlDtlLateInTimeCount; }
			set
			{
				if (value != this._hREmployeeTCSrlDtlLateInTimeCount)
				{
					_hREmployeeTCSrlDtlLateInTimeCount = value;
					NotifyChanged("HREmployeeTCSrlDtlLateInTimeCount");
				}
			}
		}
		
        #endregion
    }
    #endregion
}