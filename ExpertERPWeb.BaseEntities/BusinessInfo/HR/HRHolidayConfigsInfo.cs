using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRHolidayConfigs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRHolidayConfigsInfo
	//Created Date:26 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRHolidayConfigsInfo:BusinessObject
	{
		public HRHolidayConfigsInfo()
		{
		}
		#region Variables
		protected int _hRHolidayConfigID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _hRHolidayConfigName=String.Empty;
		protected String _hRHolidayConfigDesc=String.Empty;
		protected Nullable<DateTime> _hRHolidayConfigDate;
		protected String _hRHolidayConfigTypeCombo=String.Empty;
		protected double _hRHolidayConfigDefaultRate;
		protected bool _aASelected=true;
		protected String _aAOrgDocNo=String.Empty;
		#endregion

		#region Public properties
		public int HRHolidayConfigID
		{
			get{return _hRHolidayConfigID;}
			set
			{
				if (value != this._hRHolidayConfigID)
				{
				_hRHolidayConfigID=value;
				NotifyChanged("HRHolidayConfigID");
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
		public String HRHolidayConfigName
		{
			get{return _hRHolidayConfigName;}
			set
			{
				if (value != this._hRHolidayConfigName)
				{
				_hRHolidayConfigName=value;
				NotifyChanged("HRHolidayConfigName");
				}
			}
		}
		public String HRHolidayConfigDesc
		{
			get{return _hRHolidayConfigDesc;}
			set
			{
				if (value != this._hRHolidayConfigDesc)
				{
				_hRHolidayConfigDesc=value;
				NotifyChanged("HRHolidayConfigDesc");
				}
			}
		}
		public Nullable<DateTime> HRHolidayConfigDate
		{
			get{return _hRHolidayConfigDate;}
			set
			{
				if (value != this._hRHolidayConfigDate)
				{
				_hRHolidayConfigDate=value;
				NotifyChanged("HRHolidayConfigDate");
				}
			}
		}
		public String HRHolidayConfigTypeCombo
		{
			get{return _hRHolidayConfigTypeCombo;}
			set
			{
				if (value != this._hRHolidayConfigTypeCombo)
				{
				_hRHolidayConfigTypeCombo=value;
				NotifyChanged("HRHolidayConfigTypeCombo");
				}
			}
		}
		public double HRHolidayConfigDefaultRate
		{
			get{return _hRHolidayConfigDefaultRate;}
			set
			{
				if (value != this._hRHolidayConfigDefaultRate)
				{
				_hRHolidayConfigDefaultRate=value;
				NotifyChanged("HRHolidayConfigDefaultRate");
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
		public String AAOrgDocNo
		{
			get{return _aAOrgDocNo;}
			set
			{
				if (value != this._aAOrgDocNo)
				{
				_aAOrgDocNo=value;
				NotifyChanged("AAOrgDocNo");
				}
			}
		}
		#endregion
	}
	#endregion
}