using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICLots
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICLotsInfo
	//Created Date:Monday, November 03, 2014
	//-----------------------------------------------------------
	
	public class ICLotsInfo:BusinessObject
	{
		public ICLotsInfo()
		{
		}
		#region Variables
		protected int _iCLotID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _iCLotNo=String.Empty;
		protected String _iCLotName=String.Empty;
		protected String _iCLotDesc=String.Empty;
		protected String _iCLotTrackingMethodCombo=String.Empty;
		protected bool _iCLotIsTrackExpireDate=true;
		protected String _iCLotAssignmentMethodCombo=String.Empty;
		protected String _iCLotIssueMethodCombo=String.Empty;
		protected String _iCLotTrackWhenCombo=String.Empty;
		#endregion

		#region Public properties
		public int ICLotID
		{
			get{return _iCLotID;}
			set
			{
				if (value != this._iCLotID)
				{
				_iCLotID=value;
				NotifyChanged("ICLotID");
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
		public String ICLotNo
		{
			get{return _iCLotNo;}
			set
			{
				if (value != this._iCLotNo)
				{
				_iCLotNo=value;
				NotifyChanged("ICLotNo");
				}
			}
		}
		public String ICLotName
		{
			get{return _iCLotName;}
			set
			{
				if (value != this._iCLotName)
				{
				_iCLotName=value;
				NotifyChanged("ICLotName");
				}
			}
		}
		public String ICLotDesc
		{
			get{return _iCLotDesc;}
			set
			{
				if (value != this._iCLotDesc)
				{
				_iCLotDesc=value;
				NotifyChanged("ICLotDesc");
				}
			}
		}
		public String ICLotTrackingMethodCombo
		{
			get{return _iCLotTrackingMethodCombo;}
			set
			{
				if (value != this._iCLotTrackingMethodCombo)
				{
				_iCLotTrackingMethodCombo=value;
				NotifyChanged("ICLotTrackingMethodCombo");
				}
			}
		}
		public bool ICLotIsTrackExpireDate
		{
			get{return _iCLotIsTrackExpireDate;}
			set
			{
				if (value != this._iCLotIsTrackExpireDate)
				{
				_iCLotIsTrackExpireDate=value;
				NotifyChanged("ICLotIsTrackExpireDate");
				}
			}
		}
		public String ICLotAssignmentMethodCombo
		{
			get{return _iCLotAssignmentMethodCombo;}
			set
			{
				if (value != this._iCLotAssignmentMethodCombo)
				{
				_iCLotAssignmentMethodCombo=value;
				NotifyChanged("ICLotAssignmentMethodCombo");
				}
			}
		}
		public String ICLotIssueMethodCombo
		{
			get{return _iCLotIssueMethodCombo;}
			set
			{
				if (value != this._iCLotIssueMethodCombo)
				{
				_iCLotIssueMethodCombo=value;
				NotifyChanged("ICLotIssueMethodCombo");
				}
			}
		}
		public String ICLotTrackWhenCombo
		{
			get{return _iCLotTrackWhenCombo;}
			set
			{
				if (value != this._iCLotTrackWhenCombo)
				{
				_iCLotTrackWhenCombo=value;
				NotifyChanged("ICLotTrackWhenCombo");
				}
			}
		}
		#endregion
	}
	#endregion
}