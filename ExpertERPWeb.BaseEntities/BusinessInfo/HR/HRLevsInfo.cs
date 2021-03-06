using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRLevs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRLevsInfo
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HRLevsInfo:BusinessObject
	{
		public HRLevsInfo()
		{
		}
		#region Variables
		protected int _hRLevID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _hRLevNo=String.Empty;
		protected String _hRLevName=String.Empty;
		protected String _hRLevDesc=String.Empty;
		#endregion

		#region Public properties
		public int HRLevID
		{
			get{return _hRLevID;}
			set
			{
				if (value != this._hRLevID)
				{
				_hRLevID=value;
				NotifyChanged("HRLevID");
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
		public String HRLevNo
		{
			get{return _hRLevNo;}
			set
			{
				if (value != this._hRLevNo)
				{
				_hRLevNo=value;
				NotifyChanged("HRLevNo");
				}
			}
		}
		public String HRLevName
		{
			get{return _hRLevName;}
			set
			{
				if (value != this._hRLevName)
				{
				_hRLevName=value;
				NotifyChanged("HRLevName");
				}
			}
		}
		public String HRLevDesc
		{
			get{return _hRLevDesc;}
			set
			{
				if (value != this._hRLevDesc)
				{
				_hRLevDesc=value;
				NotifyChanged("HRLevDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}