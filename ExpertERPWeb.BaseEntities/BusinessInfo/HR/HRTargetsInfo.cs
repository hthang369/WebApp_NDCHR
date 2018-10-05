using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRTargets
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRTargetsInfo
	//Created Date:Tuesday, July 10, 2018
	//-----------------------------------------------------------
	
	public class HRTargetsInfo:BusinessObject
	{
		public HRTargetsInfo()
		{
		}
		#region Variables
		protected int _hRTargetID;
		protected String _hRTargetNo=String.Empty;
		protected String _hRTargetName=String.Empty;
		protected Nullable<DateTime> _hRTargetDate;
		protected String _hRTargetDesc=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _hRTargetUOM=String.Empty;
		protected bool _aASeleted=true;
		#endregion

		#region Public properties
		public int HRTargetID
		{
			get{return _hRTargetID;}
			set
			{
				if (value != this._hRTargetID)
				{
				_hRTargetID=value;
				NotifyChanged("HRTargetID");
				}
			}
		}
		public String HRTargetNo
		{
			get{return _hRTargetNo;}
			set
			{
				if (value != this._hRTargetNo)
				{
				_hRTargetNo=value;
				NotifyChanged("HRTargetNo");
				}
			}
		}
		public String HRTargetName
		{
			get{return _hRTargetName;}
			set
			{
				if (value != this._hRTargetName)
				{
				_hRTargetName=value;
				NotifyChanged("HRTargetName");
				}
			}
		}
		public Nullable<DateTime> HRTargetDate
		{
			get{return _hRTargetDate;}
			set
			{
				if (value != this._hRTargetDate)
				{
				_hRTargetDate=value;
				NotifyChanged("HRTargetDate");
				}
			}
		}
		public String HRTargetDesc
		{
			get{return _hRTargetDesc;}
			set
			{
				if (value != this._hRTargetDesc)
				{
				_hRTargetDesc=value;
				NotifyChanged("HRTargetDesc");
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
		public String HRTargetUOM
		{
			get{return _hRTargetUOM;}
			set
			{
				if (value != this._hRTargetUOM)
				{
				_hRTargetUOM=value;
				NotifyChanged("HRTargetUOM");
				}
			}
		}
		public bool AASeleted
		{
			get{return _aASeleted;}
			set
			{
				if (value != this._aASeleted)
				{
				_aASeleted=value;
				NotifyChanged("AASeleted");
				}
			}
		}
		#endregion
	}
	#endregion
}