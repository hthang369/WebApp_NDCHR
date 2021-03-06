using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRTrainingSemesterCourseEmployeeTimeCards
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRTrainingSemesterCourseEmployeeTimeCardsInfo
	//Created Date:24 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRTrainingSemesterCourseEmployeeTimeCardsInfo:BusinessObject
	{
		public HRTrainingSemesterCourseEmployeeTimeCardsInfo()
		{
		}
		#region Variables
		protected int _hRTrainingSemesterCourseEmployeeTimeCardID;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _hRTrainingSemesterCourseEmployeeTimeCardDesc=String.Empty;
		protected Nullable<DateTime> _hRTrainingSemesterCourseEmployeeTimeCardDate;
		protected int _fK_HRTrainingID;
		protected int _fK_HRTrainingSemesterID;
		protected int _fK_HREmployeeID;
		protected int _fK_HRCourseID;
		protected int _fK_HRTrainingSemesterCourseID;
		protected int _fK_HRTrainingSemesterEmployeeID;
		protected int _fK_HRTrainingSemesterCourseEmployeeID;
		protected double _hRTrainingSemesterCourseEmployeeTimeCardScore;
		protected String _hRTrainingSemesterCourseEmployeeTimeCardComment=String.Empty;
		protected String _hRTrainingSemesterCourseEmployeeTimeCardTypeCombo=String.Empty;
		#endregion

		#region Public properties
		public int HRTrainingSemesterCourseEmployeeTimeCardID
		{
			get{return _hRTrainingSemesterCourseEmployeeTimeCardID;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeTimeCardID)
				{
				_hRTrainingSemesterCourseEmployeeTimeCardID=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeTimeCardID");
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
		public String HRTrainingSemesterCourseEmployeeTimeCardDesc
		{
			get{return _hRTrainingSemesterCourseEmployeeTimeCardDesc;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeTimeCardDesc)
				{
				_hRTrainingSemesterCourseEmployeeTimeCardDesc=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeTimeCardDesc");
				}
			}
		}
		public Nullable<DateTime> HRTrainingSemesterCourseEmployeeTimeCardDate
		{
			get{return _hRTrainingSemesterCourseEmployeeTimeCardDate;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeTimeCardDate)
				{
				_hRTrainingSemesterCourseEmployeeTimeCardDate=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeTimeCardDate");
				}
			}
		}
		public int FK_HRTrainingID
		{
			get{return _fK_HRTrainingID;}
			set
			{
				if (value != this._fK_HRTrainingID)
				{
				_fK_HRTrainingID=value;
				NotifyChanged("FK_HRTrainingID");
				}
			}
		}
		public int FK_HRTrainingSemesterID
		{
			get{return _fK_HRTrainingSemesterID;}
			set
			{
				if (value != this._fK_HRTrainingSemesterID)
				{
				_fK_HRTrainingSemesterID=value;
				NotifyChanged("FK_HRTrainingSemesterID");
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
		public int FK_HRCourseID
		{
			get{return _fK_HRCourseID;}
			set
			{
				if (value != this._fK_HRCourseID)
				{
				_fK_HRCourseID=value;
				NotifyChanged("FK_HRCourseID");
				}
			}
		}
		public int FK_HRTrainingSemesterCourseID
		{
			get{return _fK_HRTrainingSemesterCourseID;}
			set
			{
				if (value != this._fK_HRTrainingSemesterCourseID)
				{
				_fK_HRTrainingSemesterCourseID=value;
				NotifyChanged("FK_HRTrainingSemesterCourseID");
				}
			}
		}
		public int FK_HRTrainingSemesterEmployeeID
		{
			get{return _fK_HRTrainingSemesterEmployeeID;}
			set
			{
				if (value != this._fK_HRTrainingSemesterEmployeeID)
				{
				_fK_HRTrainingSemesterEmployeeID=value;
				NotifyChanged("FK_HRTrainingSemesterEmployeeID");
				}
			}
		}
		public int FK_HRTrainingSemesterCourseEmployeeID
		{
			get{return _fK_HRTrainingSemesterCourseEmployeeID;}
			set
			{
				if (value != this._fK_HRTrainingSemesterCourseEmployeeID)
				{
				_fK_HRTrainingSemesterCourseEmployeeID=value;
				NotifyChanged("FK_HRTrainingSemesterCourseEmployeeID");
				}
			}
		}
		public double HRTrainingSemesterCourseEmployeeTimeCardScore
		{
			get{return _hRTrainingSemesterCourseEmployeeTimeCardScore;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeTimeCardScore)
				{
				_hRTrainingSemesterCourseEmployeeTimeCardScore=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeTimeCardScore");
				}
			}
		}
		public String HRTrainingSemesterCourseEmployeeTimeCardComment
		{
			get{return _hRTrainingSemesterCourseEmployeeTimeCardComment;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeTimeCardComment)
				{
				_hRTrainingSemesterCourseEmployeeTimeCardComment=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeTimeCardComment");
				}
			}
		}
		public String HRTrainingSemesterCourseEmployeeTimeCardTypeCombo
		{
			get{return _hRTrainingSemesterCourseEmployeeTimeCardTypeCombo;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeTimeCardTypeCombo)
				{
				_hRTrainingSemesterCourseEmployeeTimeCardTypeCombo=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeTimeCardTypeCombo");
				}
			}
		}
		#endregion
	}
	#endregion
}