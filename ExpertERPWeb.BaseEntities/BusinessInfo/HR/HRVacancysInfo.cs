using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRVacancys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRVacancysInfo
	//Created Date:24 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRVacancysInfo:BusinessObject
	{
		public HRVacancysInfo()
		{
		}
		#region Variables
		protected int _hRVacancyID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _hRVacancyNo=String.Empty;
		protected String _hRVacancyName=String.Empty;
		protected Nullable<DateTime> _hRVacancyDate;
		protected String _hRVacancyDesc=String.Empty;
		protected String _hRVacancyStatusCombo=DefaultStatus;
		protected String _hRVacancyGenderCombo=String.Empty;
		protected int _fK_HRLevelID;
		protected int _hRVacancyYearOfExp;
		protected double _hRVacancyFromSal;
		protected double _hRVacancyToSal;
		protected int _hRVacancyQty;
		protected String _hRVacancyJobReq=String.Empty;
		protected String _hRVacancyJobDesc=String.Empty;
		protected int _hRVacancyFromAge;
		protected int _hRVacancyToAge;
		protected String _hRVacancyJobCombo=String.Empty;
		protected Nullable<DateTime> _hRVacancyFromDate;
		protected Nullable<DateTime> _hRVacancyToDate;
		protected String _hRVacancyWrkLocation=String.Empty;
		protected int _fK_HRRecruitPlnID;
		protected int _fK_HRDepartmentID;
		protected int _fK_HRSectionID;
		protected int _fK_HRPositionID;
		#endregion

		#region Public properties
		public int HRVacancyID
		{
			get{return _hRVacancyID;}
			set
			{
				if (value != this._hRVacancyID)
				{
				_hRVacancyID=value;
				NotifyChanged("HRVacancyID");
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
		public String HRVacancyNo
		{
			get{return _hRVacancyNo;}
			set
			{
				if (value != this._hRVacancyNo)
				{
				_hRVacancyNo=value;
				NotifyChanged("HRVacancyNo");
				}
			}
		}
		public String HRVacancyName
		{
			get{return _hRVacancyName;}
			set
			{
				if (value != this._hRVacancyName)
				{
				_hRVacancyName=value;
				NotifyChanged("HRVacancyName");
				}
			}
		}
		public Nullable<DateTime> HRVacancyDate
		{
			get{return _hRVacancyDate;}
			set
			{
				if (value != this._hRVacancyDate)
				{
				_hRVacancyDate=value;
				NotifyChanged("HRVacancyDate");
				}
			}
		}
		public String HRVacancyDesc
		{
			get{return _hRVacancyDesc;}
			set
			{
				if (value != this._hRVacancyDesc)
				{
				_hRVacancyDesc=value;
				NotifyChanged("HRVacancyDesc");
				}
			}
		}
		public String HRVacancyStatusCombo
		{
			get{return _hRVacancyStatusCombo;}
			set
			{
				if (value != this._hRVacancyStatusCombo)
				{
				_hRVacancyStatusCombo=value;
				NotifyChanged("HRVacancyStatusCombo");
				}
			}
		}
		public String HRVacancyGenderCombo
		{
			get{return _hRVacancyGenderCombo;}
			set
			{
				if (value != this._hRVacancyGenderCombo)
				{
				_hRVacancyGenderCombo=value;
				NotifyChanged("HRVacancyGenderCombo");
				}
			}
		}
		public int FK_HRLevelID
		{
			get{return _fK_HRLevelID;}
			set
			{
				if (value != this._fK_HRLevelID)
				{
				_fK_HRLevelID=value;
				NotifyChanged("FK_HRLevelID");
				}
			}
		}
		public int HRVacancyYearOfExp
		{
			get{return _hRVacancyYearOfExp;}
			set
			{
				if (value != this._hRVacancyYearOfExp)
				{
				_hRVacancyYearOfExp=value;
				NotifyChanged("HRVacancyYearOfExp");
				}
			}
		}
		public double HRVacancyFromSal
		{
			get{return _hRVacancyFromSal;}
			set
			{
				if (value != this._hRVacancyFromSal)
				{
				_hRVacancyFromSal=value;
				NotifyChanged("HRVacancyFromSal");
				}
			}
		}
		public double HRVacancyToSal
		{
			get{return _hRVacancyToSal;}
			set
			{
				if (value != this._hRVacancyToSal)
				{
				_hRVacancyToSal=value;
				NotifyChanged("HRVacancyToSal");
				}
			}
		}
		public int HRVacancyQty
		{
			get{return _hRVacancyQty;}
			set
			{
				if (value != this._hRVacancyQty)
				{
				_hRVacancyQty=value;
				NotifyChanged("HRVacancyQty");
				}
			}
		}
		public String HRVacancyJobReq
		{
			get{return _hRVacancyJobReq;}
			set
			{
				if (value != this._hRVacancyJobReq)
				{
				_hRVacancyJobReq=value;
				NotifyChanged("HRVacancyJobReq");
				}
			}
		}
		public String HRVacancyJobDesc
		{
			get{return _hRVacancyJobDesc;}
			set
			{
				if (value != this._hRVacancyJobDesc)
				{
				_hRVacancyJobDesc=value;
				NotifyChanged("HRVacancyJobDesc");
				}
			}
		}
		public int HRVacancyFromAge
		{
			get{return _hRVacancyFromAge;}
			set
			{
				if (value != this._hRVacancyFromAge)
				{
				_hRVacancyFromAge=value;
				NotifyChanged("HRVacancyFromAge");
				}
			}
		}
		public int HRVacancyToAge
		{
			get{return _hRVacancyToAge;}
			set
			{
				if (value != this._hRVacancyToAge)
				{
				_hRVacancyToAge=value;
				NotifyChanged("HRVacancyToAge");
				}
			}
		}
		public String HRVacancyJobCombo
		{
			get{return _hRVacancyJobCombo;}
			set
			{
				if (value != this._hRVacancyJobCombo)
				{
				_hRVacancyJobCombo=value;
				NotifyChanged("HRVacancyJobCombo");
				}
			}
		}
		public Nullable<DateTime> HRVacancyFromDate
		{
			get{return _hRVacancyFromDate;}
			set
			{
				if (value != this._hRVacancyFromDate)
				{
				_hRVacancyFromDate=value;
				NotifyChanged("HRVacancyFromDate");
				}
			}
		}
		public Nullable<DateTime> HRVacancyToDate
		{
			get{return _hRVacancyToDate;}
			set
			{
				if (value != this._hRVacancyToDate)
				{
				_hRVacancyToDate=value;
				NotifyChanged("HRVacancyToDate");
				}
			}
		}
		public String HRVacancyWrkLocation
		{
			get{return _hRVacancyWrkLocation;}
			set
			{
				if (value != this._hRVacancyWrkLocation)
				{
				_hRVacancyWrkLocation=value;
				NotifyChanged("HRVacancyWrkLocation");
				}
			}
		}
		public int FK_HRRecruitPlnID
		{
			get{return _fK_HRRecruitPlnID;}
			set
			{
				if (value != this._fK_HRRecruitPlnID)
				{
				_fK_HRRecruitPlnID=value;
				NotifyChanged("FK_HRRecruitPlnID");
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
		#endregion
	}
	#endregion
}