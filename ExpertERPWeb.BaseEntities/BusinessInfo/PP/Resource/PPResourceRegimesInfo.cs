using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPResourceRegimes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPResourceRegimesInfo
	//Created Date:Tuesday, February 14, 2017
	//-----------------------------------------------------------
	
	public class PPResourceRegimesInfo:BusinessObject
	{
		public PPResourceRegimesInfo()
		{
		}
		#region Variables
		protected int _pPResourceRegimeID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _pPResourceRegimeNo=String.Empty;
		protected String _pPResourceRegimeName=String.Empty;
		#endregion

		#region Public properties
		public int PPResourceRegimeID
		{
			get{return _pPResourceRegimeID;}
			set
			{
				if (value != this._pPResourceRegimeID)
				{
				_pPResourceRegimeID=value;
				NotifyChanged("PPResourceRegimeID");
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
		public String PPResourceRegimeNo
		{
			get{return _pPResourceRegimeNo;}
			set
			{
				if (value != this._pPResourceRegimeNo)
				{
				_pPResourceRegimeNo=value;
				NotifyChanged("PPResourceRegimeNo");
				}
			}
		}
		public String PPResourceRegimeName
		{
			get{return _pPResourceRegimeName;}
			set
			{
				if (value != this._pPResourceRegimeName)
				{
				_pPResourceRegimeName=value;
				NotifyChanged("PPResourceRegimeName");
				}
			}
		}
		#endregion
	}
	#endregion
}