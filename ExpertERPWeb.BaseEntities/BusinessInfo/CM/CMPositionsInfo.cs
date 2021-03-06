using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMPositions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMPositionsInfo
	//Created Date:30 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMPositionsInfo:BusinessObject
	{
		public CMPositionsInfo()
		{
		}
		#region Variables
		protected int _cMPositionID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _cMPositionNo=String.Empty;
		protected String _cMPositionName=String.Empty;
		protected String _cMPositionInfo=String.Empty;
		protected String _cMPositionDesc=String.Empty;
		protected String _cMPositionRemark=String.Empty;
		#endregion

		#region Public properties
		public int CMPositionID
		{
			get{return _cMPositionID;}
			set
			{
				if (value != this._cMPositionID)
				{
				_cMPositionID=value;
				NotifyChanged("CMPositionID");
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
		public String CMPositionNo
		{
			get{return _cMPositionNo;}
			set
			{
				if (value != this._cMPositionNo)
				{
				_cMPositionNo=value;
				NotifyChanged("CMPositionNo");
				}
			}
		}
		public String CMPositionName
		{
			get{return _cMPositionName;}
			set
			{
				if (value != this._cMPositionName)
				{
				_cMPositionName=value;
				NotifyChanged("CMPositionName");
				}
			}
		}
		public String CMPositionInfo
		{
			get{return _cMPositionInfo;}
			set
			{
				if (value != this._cMPositionInfo)
				{
				_cMPositionInfo=value;
				NotifyChanged("CMPositionInfo");
				}
			}
		}
		public String CMPositionDesc
		{
			get{return _cMPositionDesc;}
			set
			{
				if (value != this._cMPositionDesc)
				{
				_cMPositionDesc=value;
				NotifyChanged("CMPositionDesc");
				}
			}
		}
		public String CMPositionRemark
		{
			get{return _cMPositionRemark;}
			set
			{
				if (value != this._cMPositionRemark)
				{
				_cMPositionRemark=value;
				NotifyChanged("CMPositionRemark");
				}
			}
		}
		#endregion
	}
	#endregion
}