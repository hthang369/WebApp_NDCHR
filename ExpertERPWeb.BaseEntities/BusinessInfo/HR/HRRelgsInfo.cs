using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRRelgs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRRelgsInfo
	//Created Date:09 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class HRRelgsInfo:BusinessObject
	{
		public HRRelgsInfo()
		{
		}
		#region Variables
		protected int _hRRelgID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _hRRelgNo=String.Empty;
		protected String _hRRelgName=String.Empty;
		protected String _hRRelgDesc=String.Empty;
		#endregion

		#region Public properties
		public int HRRelgID
		{
			get{return _hRRelgID;}
			set
			{
				if (value != this._hRRelgID)
				{
				_hRRelgID=value;
				NotifyChanged("HRRelgID");
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
		public String HRRelgNo
		{
			get{return _hRRelgNo;}
			set
			{
				if (value != this._hRRelgNo)
				{
				_hRRelgNo=value;
				NotifyChanged("HRRelgNo");
				}
			}
		}
		public String HRRelgName
		{
			get{return _hRRelgName;}
			set
			{
				if (value != this._hRRelgName)
				{
				_hRRelgName=value;
				NotifyChanged("HRRelgName");
				}
			}
		}
		public String HRRelgDesc
		{
			get{return _hRRelgDesc;}
			set
			{
				if (value != this._hRRelgDesc)
				{
				_hRRelgDesc=value;
				NotifyChanged("HRRelgDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}