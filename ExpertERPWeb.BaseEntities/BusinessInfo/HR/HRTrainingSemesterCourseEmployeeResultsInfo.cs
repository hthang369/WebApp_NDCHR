using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRTrainingSemesterCourseEmployeeResults
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRTrainingSemesterCourseEmployeeResultsInfo
	//Created Date:24 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRTrainingSemesterCourseEmployeeResultsInfo:BusinessObject
	{
		public HRTrainingSemesterCourseEmployeeResultsInfo()
		{
		}
		#region Variables
		protected int _hRTrainingSemesterCourseEmployeeResultID;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAStatus=DefaultAAStatus;
		protected String _hRTrainingSemesterCourseEmployeeResultDesc=String.Empty;
		protected int _fK_HRTrainingID;
		protected int _fK_HRTrainingSemesterID;
		protected int _fK_HREmployeeID;
		protected int _fK_HRCourseID;
		protected int _fK_HRTrainingSemesterCourseID;
		protected int _fK_HRTrainingSemesterEmployeeID;
		protected int _fK_HRTrainingSemesterCourseEmployeeID;
		protected double _hRTrainingSemesterCourseEmployeeResultPresentTotQty;
		protected double _hRTrainingSemesterCourseEmployeeResultAbsentTotQty;
		protected double _hRTrainingSemesterCourseEmployeeResultScore;
		protected String _hRTrainingSemesterCourseEmployeeResultComment=String.Empty;
		protected bool _hRTrainingSemesterCourseEmployeeResultIsPass=true;
		#endregion

		#region Public properties
		public int HRTrainingSemesterCourseEmployeeResultID
		{
			get{return _hRTrainingSemesterCourseEmployeeResultID;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeResultID)
				{
				_hRTrainingSemesterCourseEmployeeResultID=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeResultID");
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
		public String HRTrainingSemesterCourseEmployeeResultDesc
		{
			get{return _hRTrainingSemesterCourseEmployeeResultDesc;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeResultDesc)
				{
				_hRTrainingSemesterCourseEmployeeResultDesc=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeResultDesc");
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
		public double HRTrainingSemesterCourseEmployeeResultPresentTotQty
		{
			get{return _hRTrainingSemesterCourseEmployeeResultPresentTotQty;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeResultPresentTotQty)
				{
				_hRTrainingSemesterCourseEmployeeResultPresentTotQty=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeResultPresentTotQty");
				}
			}
		}
		public double HRTrainingSemesterCourseEmployeeResultAbsentTotQty
		{
			get{return _hRTrainingSemesterCourseEmployeeResultAbsentTotQty;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeResultAbsentTotQty)
				{
				_hRTrainingSemesterCourseEmployeeResultAbsentTotQty=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeResultAbsentTotQty");
				}
			}
		}
		public double HRTrainingSemesterCourseEmployeeResultScore
		{
			get{return _hRTrainingSemesterCourseEmployeeResultScore;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeResultScore)
				{
				_hRTrainingSemesterCourseEmployeeResultScore=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeResultScore");
				}
			}
		}
		public String HRTrainingSemesterCourseEmployeeResultComment
		{
			get{return _hRTrainingSemesterCourseEmployeeResultComment;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeResultComment)
				{
				_hRTrainingSemesterCourseEmployeeResultComment=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeResultComment");
				}
			}
		}
		public bool HRTrainingSemesterCourseEmployeeResultIsPass
		{
			get{return _hRTrainingSemesterCourseEmployeeResultIsPass;}
			set
			{
				if (value != this._hRTrainingSemesterCourseEmployeeResultIsPass)
				{
				_hRTrainingSemesterCourseEmployeeResultIsPass=value;
				NotifyChanged("HRTrainingSemesterCourseEmployeeResultIsPass");
				}
			}
		}
		#endregion
	}
	#endregion
}