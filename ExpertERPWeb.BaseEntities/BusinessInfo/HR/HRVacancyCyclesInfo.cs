using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRVacancyCycles
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRVacancyCyclesInfo
	//Created Date:25 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRVacancyCyclesInfo:BusinessObject
	{
		public HRVacancyCyclesInfo()
		{
		}
		#region Variables
		protected int _hRVacancyCycleID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected int _hRVacancyCycleSort;
		protected double _hRVacancyCycleRate;
		protected String _hRVacancyCycleRemark=String.Empty;
		protected String _hRVacancyMthCombo=String.Empty;
		protected int _fK_HRVacancyID;
		protected int _fK_HRRecruitCycleID;
		#endregion

		#region Public properties
		public int HRVacancyCycleID
		{
			get{return _hRVacancyCycleID;}
			set
			{
				if (value != this._hRVacancyCycleID)
				{
				_hRVacancyCycleID=value;
				NotifyChanged("HRVacancyCycleID");
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
		public int HRVacancyCycleSort
		{
			get{return _hRVacancyCycleSort;}
			set
			{
				if (value != this._hRVacancyCycleSort)
				{
				_hRVacancyCycleSort=value;
				NotifyChanged("HRVacancyCycleSort");
				}
			}
		}
		public double HRVacancyCycleRate
		{
			get{return _hRVacancyCycleRate;}
			set
			{
				if (value != this._hRVacancyCycleRate)
				{
				_hRVacancyCycleRate=value;
				NotifyChanged("HRVacancyCycleRate");
				}
			}
		}
		public String HRVacancyCycleRemark
		{
			get{return _hRVacancyCycleRemark;}
			set
			{
				if (value != this._hRVacancyCycleRemark)
				{
				_hRVacancyCycleRemark=value;
				NotifyChanged("HRVacancyCycleRemark");
				}
			}
		}
		public String HRVacancyMthCombo
		{
			get{return _hRVacancyMthCombo;}
			set
			{
				if (value != this._hRVacancyMthCombo)
				{
				_hRVacancyMthCombo=value;
				NotifyChanged("HRVacancyMthCombo");
				}
			}
		}
		public int FK_HRVacancyID
		{
			get{return _fK_HRVacancyID;}
			set
			{
				if (value != this._fK_HRVacancyID)
				{
				_fK_HRVacancyID=value;
				NotifyChanged("FK_HRVacancyID");
				}
			}
		}
		public int FK_HRRecruitCycleID
		{
			get{return _fK_HRRecruitCycleID;}
			set
			{
				if (value != this._fK_HRRecruitCycleID)
				{
				_fK_HRRecruitCycleID=value;
				NotifyChanged("FK_HRRecruitCycleID");
				}
			}
		}
		#endregion
	}
	#endregion
}