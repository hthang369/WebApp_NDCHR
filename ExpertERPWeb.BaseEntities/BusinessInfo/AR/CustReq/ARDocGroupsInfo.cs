using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARDocGroups
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARDocGroupsInfo
	//Created Date:Monday, January 05, 2015
	//-----------------------------------------------------------
	
	public class ARDocGroupsInfo:BusinessObject
	{
		public ARDocGroupsInfo()
		{
		}
		#region Variables
		protected int _aRDocGroupID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aRDocGroupNo=String.Empty;
		protected String _aRDocGroupName=String.Empty;
		protected String _aRDocGroupDesc=String.Empty;
		#endregion

		#region Public properties
		public int ARDocGroupID
		{
			get{return _aRDocGroupID;}
			set
			{
				if (value != this._aRDocGroupID)
				{
				_aRDocGroupID=value;
				NotifyChanged("ARDocGroupID");
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
		public String ARDocGroupNo
		{
			get{return _aRDocGroupNo;}
			set
			{
				if (value != this._aRDocGroupNo)
				{
				_aRDocGroupNo=value;
				NotifyChanged("ARDocGroupNo");
				}
			}
		}
		public String ARDocGroupName
		{
			get{return _aRDocGroupName;}
			set
			{
				if (value != this._aRDocGroupName)
				{
				_aRDocGroupName=value;
				NotifyChanged("ARDocGroupName");
				}
			}
		}
		public String ARDocGroupDesc
		{
			get{return _aRDocGroupDesc;}
			set
			{
				if (value != this._aRDocGroupDesc)
				{
				_aRDocGroupDesc=value;
				NotifyChanged("ARDocGroupDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}