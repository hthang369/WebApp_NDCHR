using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRSectionNoxiouCfs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRSectionNoxiouCfsInfo
	//Created Date:Thursday, August 31, 2017
	//-----------------------------------------------------------
	
	public class HRSectionNoxiouCfsInfo:BusinessObject
	{
		public HRSectionNoxiouCfsInfo()
		{
		}
		#region Variables
		protected int _hRSectionNoxiouCfID;
		protected String _hRSectionNoxiouCfDesc=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected bool _aAselected=true;
		protected int _hRSectionNoxiouCfNumberDay;
		protected int _fK_HRSectionID;
		protected int _fK_HREmployeeLeaveConfigID;
		#endregion

		#region Public properties
		public int HRSectionNoxiouCfID
		{
			get{return _hRSectionNoxiouCfID;}
			set
			{
				if (value != this._hRSectionNoxiouCfID)
				{
				_hRSectionNoxiouCfID=value;
				NotifyChanged("HRSectionNoxiouCfID");
				}
			}
		}
		public String HRSectionNoxiouCfDesc
		{
			get{return _hRSectionNoxiouCfDesc;}
			set
			{
				if (value != this._hRSectionNoxiouCfDesc)
				{
				_hRSectionNoxiouCfDesc=value;
				NotifyChanged("HRSectionNoxiouCfDesc");
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
		public bool AAselected
		{
			get{return _aAselected;}
			set
			{
				if (value != this._aAselected)
				{
				_aAselected=value;
				NotifyChanged("AAselected");
				}
			}
		}
		public int HRSectionNoxiouCfNumberDay
		{
			get{return _hRSectionNoxiouCfNumberDay;}
			set
			{
				if (value != this._hRSectionNoxiouCfNumberDay)
				{
				_hRSectionNoxiouCfNumberDay=value;
				NotifyChanged("HRSectionNoxiouCfNumberDay");
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