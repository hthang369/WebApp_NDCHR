using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMPhases
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMPhasesInfo
	//Created Date:27 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class CMPhasesInfo:BusinessObject
	{
		public CMPhasesInfo()
		{
		}
		#region Variables
		protected int _cMPhaseID;
		protected String _cMPhaseNo=String.Empty;
		protected String _cMPhaseName=String.Empty;
		protected String _cMPhaseDesc=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		#endregion

		#region Public properties
		public int CMPhaseID
		{
			get{return _cMPhaseID;}
			set
			{
				if (value != this._cMPhaseID)
				{
				_cMPhaseID=value;
				NotifyChanged("CMPhaseID");
				}
			}
		}
		public String CMPhaseNo
		{
			get{return _cMPhaseNo;}
			set
			{
				if (value != this._cMPhaseNo)
				{
				_cMPhaseNo=value;
				NotifyChanged("CMPhaseNo");
				}
			}
		}
		public String CMPhaseName
		{
			get{return _cMPhaseName;}
			set
			{
				if (value != this._cMPhaseName)
				{
				_cMPhaseName=value;
				NotifyChanged("CMPhaseName");
				}
			}
		}
		public String CMPhaseDesc
		{
			get{return _cMPhaseDesc;}
			set
			{
				if (value != this._cMPhaseDesc)
				{
				_cMPhaseDesc=value;
				NotifyChanged("CMPhaseDesc");
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
		#endregion
	}
	#endregion
}