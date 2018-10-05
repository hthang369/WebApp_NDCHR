using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRAnnualLeaveOthers
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRAnnualLeaveOthersInfo
	//Created Date:Thursday, August 31, 2017
	//-----------------------------------------------------------
	
	public class HRAnnualLeaveOthersInfo:BusinessObject
	{
		public HRAnnualLeaveOthersInfo()
		{
		}
		#region Variables
		protected int _hRAnnualLeaveOtherID;
		protected String _aAStatus=DefaultAAStatus;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected bool _aASelected=true;
		protected int _fK_HREmployeeID;
		protected int _fK_HRDepartmentID;
		protected int _fK_HRPositionID;
		protected double _hRAnnualLeaveOtherNumberYear;
		protected double _hRAnnualLeaveOtherNumberVale;
		protected int _fK_HREmployeeLeaveConfigID;
		#endregion

		#region Public properties
		public int HRAnnualLeaveOtherID
		{
			get{return _hRAnnualLeaveOtherID;}
			set
			{
				if (value != this._hRAnnualLeaveOtherID)
				{
				_hRAnnualLeaveOtherID=value;
				NotifyChanged("HRAnnualLeaveOtherID");
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
		public double HRAnnualLeaveOtherNumberYear
		{
			get{return _hRAnnualLeaveOtherNumberYear;}
			set
			{
				if (value != this._hRAnnualLeaveOtherNumberYear)
				{
				_hRAnnualLeaveOtherNumberYear=value;
				NotifyChanged("HRAnnualLeaveOtherNumberYear");
				}
			}
		}
		public double HRAnnualLeaveOtherNumberVale
		{
			get{return _hRAnnualLeaveOtherNumberVale;}
			set
			{
				if (value != this._hRAnnualLeaveOtherNumberVale)
				{
				_hRAnnualLeaveOtherNumberVale=value;
				NotifyChanged("HRAnnualLeaveOtherNumberVale");
				}
			}
		}
		public int FK_HREmployeeLeaveConfigID
		{
			get{return _fK_HREmployeeLeaveConfigID;}
			set
			{
				if (value != this._fK_HREmployeeLeaveConfigID)
				{
				_fK_HREmployeeLeaveConfigID=value;
				NotifyChanged("FK_HREmployeeLeaveConfigID");
				}
			}
		}
		#endregion
	}
	#endregion
}