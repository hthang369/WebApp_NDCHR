using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRCandidateDegrees
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRCandidateDegreesInfo
	//Created Date:24 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRCandidateDegreesInfo:BusinessObject
	{
		public HRCandidateDegreesInfo()
		{
		}
		#region Variables
		protected int _hRCandidateDegreeID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected int _fK_HRCandidateID;
		protected String _hRCandidateDegreeName=String.Empty;
		protected String _hRCandidateDegreeDescription=String.Empty;
		protected String _hRCandidateDregreeSchoolName=String.Empty;
		protected Nullable<DateTime> _hRCandidateDegreeStartDate;
		protected Nullable<DateTime> _hRCandidateDegreeFinishDate;
		protected String _hRCandidateDegreeTypeCombo=String.Empty;
		protected String _hRCandidateDegreeDocServerPath=String.Empty;
		protected String _hRCandidateDegreeDocLocalPath=String.Empty;
		protected String _hRCandidateRateCombo=String.Empty;
		protected String _hRCandidateDegreeNameTypeCombo=String.Empty;
		#endregion

		#region Public properties
		public int HRCandidateDegreeID
		{
			get{return _hRCandidateDegreeID;}
			set
			{
				if (value != this._hRCandidateDegreeID)
				{
				_hRCandidateDegreeID=value;
				NotifyChanged("HRCandidateDegreeID");
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
		public int FK_HRCandidateID
		{
			get{return _fK_HRCandidateID;}
			set
			{
				if (value != this._fK_HRCandidateID)
				{
				_fK_HRCandidateID=value;
				NotifyChanged("FK_HRCandidateID");
				}
			}
		}
		public String HRCandidateDegreeName
		{
			get{return _hRCandidateDegreeName;}
			set
			{
				if (value != this._hRCandidateDegreeName)
				{
				_hRCandidateDegreeName=value;
				NotifyChanged("HRCandidateDegreeName");
				}
			}
		}
		public String HRCandidateDegreeDescription
		{
			get{return _hRCandidateDegreeDescription;}
			set
			{
				if (value != this._hRCandidateDegreeDescription)
				{
				_hRCandidateDegreeDescription=value;
				NotifyChanged("HRCandidateDegreeDescription");
				}
			}
		}
		public String HRCandidateDregreeSchoolName
		{
			get{return _hRCandidateDregreeSchoolName;}
			set
			{
				if (value != this._hRCandidateDregreeSchoolName)
				{
				_hRCandidateDregreeSchoolName=value;
				NotifyChanged("HRCandidateDregreeSchoolName");
				}
			}
		}
		public Nullable<DateTime> HRCandidateDegreeStartDate
		{
			get{return _hRCandidateDegreeStartDate;}
			set
			{
				if (value != this._hRCandidateDegreeStartDate)
				{
				_hRCandidateDegreeStartDate=value;
				NotifyChanged("HRCandidateDegreeStartDate");
				}
			}
		}
		public Nullable<DateTime> HRCandidateDegreeFinishDate
		{
			get{return _hRCandidateDegreeFinishDate;}
			set
			{
				if (value != this._hRCandidateDegreeFinishDate)
				{
				_hRCandidateDegreeFinishDate=value;
				NotifyChanged("HRCandidateDegreeFinishDate");
				}
			}
		}
		public String HRCandidateDegreeTypeCombo
		{
			get{return _hRCandidateDegreeTypeCombo;}
			set
			{
				if (value != this._hRCandidateDegreeTypeCombo)
				{
				_hRCandidateDegreeTypeCombo=value;
				NotifyChanged("HRCandidateDegreeTypeCombo");
				}
			}
		}
		public String HRCandidateDegreeDocServerPath
		{
			get{return _hRCandidateDegreeDocServerPath;}
			set
			{
				if (value != this._hRCandidateDegreeDocServerPath)
				{
				_hRCandidateDegreeDocServerPath=value;
				NotifyChanged("HRCandidateDegreeDocServerPath");
				}
			}
		}
		public String HRCandidateDegreeDocLocalPath
		{
			get{return _hRCandidateDegreeDocLocalPath;}
			set
			{
				if (value != this._hRCandidateDegreeDocLocalPath)
				{
				_hRCandidateDegreeDocLocalPath=value;
				NotifyChanged("HRCandidateDegreeDocLocalPath");
				}
			}
		}
		public String HRCandidateRateCombo
		{
			get{return _hRCandidateRateCombo;}
			set
			{
				if (value != this._hRCandidateRateCombo)
				{
				_hRCandidateRateCombo=value;
				NotifyChanged("HRCandidateRateCombo");
				}
			}
		}
		public String HRCandidateDegreeNameTypeCombo
		{
			get{return _hRCandidateDegreeNameTypeCombo;}
			set
			{
				if (value != this._hRCandidateDegreeNameTypeCombo)
				{
				_hRCandidateDegreeNameTypeCombo=value;
				NotifyChanged("HRCandidateDegreeNameTypeCombo");
				}
			}
		}
		#endregion
	}
	#endregion
}