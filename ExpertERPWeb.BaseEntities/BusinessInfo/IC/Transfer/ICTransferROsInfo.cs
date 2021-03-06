using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICTransferROs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICTransferROsInfo
	//Created Date:04 Tháng Ba 2013
	//-----------------------------------------------------------
	
	public class ICTransferROsInfo:BusinessObject
	{
		public ICTransferROsInfo()
		{
		}
		#region Variables
		protected int _iCTransferROID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ICTransferID;
		protected int _fK_ICROID;
		#endregion

		#region Public properties
		public int ICTransferROID
		{
			get{return _iCTransferROID;}
			set
			{
				if (value != this._iCTransferROID)
				{
				_iCTransferROID=value;
				NotifyChanged("ICTransferROID");
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
		public int FK_ICTransferID
		{
			get{return _fK_ICTransferID;}
			set
			{
				if (value != this._fK_ICTransferID)
				{
				_fK_ICTransferID=value;
				NotifyChanged("FK_ICTransferID");
				}
			}
		}
		public int FK_ICROID
		{
			get{return _fK_ICROID;}
			set
			{
				if (value != this._fK_ICROID)
				{
				_fK_ICROID=value;
				NotifyChanged("FK_ICROID");
				}
			}
		}
		#endregion
	}
	#endregion
}