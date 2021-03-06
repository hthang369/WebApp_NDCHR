using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICRequestReceiptPOs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICRequestReceiptPOsInfo
	//Created Date:Friday, April 17, 2015
	//-----------------------------------------------------------
	
	public class ICRequestReceiptPOsInfo:BusinessObject
	{
		public ICRequestReceiptPOsInfo()
		{
		}
		#region Variables
		protected int _iCRequestReceiptPOID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPOID;
		protected int _fK_ICRequestReceiptID;
		#endregion

		#region Public properties
		public int ICRequestReceiptPOID
		{
			get{return _iCRequestReceiptPOID;}
			set
			{
				if (value != this._iCRequestReceiptPOID)
				{
				_iCRequestReceiptPOID=value;
				NotifyChanged("ICRequestReceiptPOID");
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
		public int FK_APPOID
		{
			get{return _fK_APPOID;}
			set
			{
				if (value != this._fK_APPOID)
				{
				_fK_APPOID=value;
				NotifyChanged("FK_APPOID");
				}
			}
		}
		public int FK_ICRequestReceiptID
		{
			get{return _fK_ICRequestReceiptID;}
			set
			{
				if (value != this._fK_ICRequestReceiptID)
				{
				_fK_ICRequestReceiptID=value;
				NotifyChanged("FK_ICRequestReceiptID");
				}
			}
		}
		#endregion
	}
	#endregion
}