using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPMPSWeeklyCalendars
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPMPSWeeklyCalendarsInfo
	//Created Date:Friday, November 25, 2016
	//-----------------------------------------------------------
	
	public class PPMPSWeeklyCalendarsInfo:BusinessObject
	{
		public PPMPSWeeklyCalendarsInfo()
		{
		}
		#region Variables
		protected int _pPMPSWeeklyCalendarID;
		protected string _aACreatedUser=string.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected string _aAUpdatedUser=string.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected string _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected string _pPMPSWeeklyCalendarNo=string.Empty;
		protected string _pPMPSWeeklyCalendarName=string.Empty;
		protected double _pPMPSWeeklyCalendarPct;
		protected int _fK_PPMPSID;
		protected int _pPMPSWeeklyCalendarYear;
		protected int _pPMPSWeeklyCalendarPeriod;
		#endregion

		#region Public properties
		public int PPMPSWeeklyCalendarID
		{
			get{return _pPMPSWeeklyCalendarID;}
			set
			{
				if (value != this._pPMPSWeeklyCalendarID)
				{
				_pPMPSWeeklyCalendarID=value;
				NotifyChanged("PPMPSWeeklyCalendarID");
				}
			}
		}
		public string AACreatedUser
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
		public string AAUpdatedUser
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
		public string AAStatus
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
		public string PPMPSWeeklyCalendarNo
		{
			get{return _pPMPSWeeklyCalendarNo;}
			set
			{
				if (value != this._pPMPSWeeklyCalendarNo)
				{
				_pPMPSWeeklyCalendarNo=value;
				NotifyChanged("PPMPSWeeklyCalendarNo");
				}
			}
		}
		public string PPMPSWeeklyCalendarName
		{
			get{return _pPMPSWeeklyCalendarName;}
			set
			{
				if (value != this._pPMPSWeeklyCalendarName)
				{
				_pPMPSWeeklyCalendarName=value;
				NotifyChanged("PPMPSWeeklyCalendarName");
				}
			}
		}
		public double PPMPSWeeklyCalendarPct
		{
			get{return _pPMPSWeeklyCalendarPct;}
			set
			{
				if (value != this._pPMPSWeeklyCalendarPct)
				{
				_pPMPSWeeklyCalendarPct=value;
				NotifyChanged("PPMPSWeeklyCalendarPct");
				}
			}
		}
		public int FK_PPMPSID
		{
			get{return _fK_PPMPSID;}
			set
			{
				if (value != this._fK_PPMPSID)
				{
				_fK_PPMPSID=value;
				NotifyChanged("FK_PPMPSID");
				}
			}
		}
		public int PPMPSWeeklyCalendarYear
		{
			get{return _pPMPSWeeklyCalendarYear;}
			set
			{
				if (value != this._pPMPSWeeklyCalendarYear)
				{
				_pPMPSWeeklyCalendarYear=value;
				NotifyChanged("PPMPSWeeklyCalendarYear");
				}
			}
		}
		public int PPMPSWeeklyCalendarPeriod
		{
			get{return _pPMPSWeeklyCalendarPeriod;}
			set
			{
				if (value != this._pPMPSWeeklyCalendarPeriod)
				{
				_pPMPSWeeklyCalendarPeriod=value;
				NotifyChanged("PPMPSWeeklyCalendarPeriod");
				}
			}
		}
		#endregion
	}
	#endregion
}