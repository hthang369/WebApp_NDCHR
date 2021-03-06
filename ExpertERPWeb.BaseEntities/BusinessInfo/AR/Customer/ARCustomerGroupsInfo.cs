using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustomerGroups
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustomerGroupsInfo
	//Created Date:Saturday, August 20, 2011
	//-----------------------------------------------------------
	
	public class ARCustomerGroupsInfo:BusinessObject
	{
		public ARCustomerGroupsInfo()
		{
		}
		#region Variables
		protected int _aRCustomerGroupID;
		protected String _aRCustomerGroupNo=String.Empty;
		protected String _aRCustomerGroupName=String.Empty;
		protected String _aRCustomerGroupDesc=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		#endregion

		#region Public properties
		public int ARCustomerGroupID
		{
			get{return _aRCustomerGroupID;}
			set
			{
				if (value != this._aRCustomerGroupID)
				{
				_aRCustomerGroupID=value;
				NotifyChanged("ARCustomerGroupID");
				}
			}
		}
		public String ARCustomerGroupNo
		{
			get{return _aRCustomerGroupNo;}
			set
			{
				if (value != this._aRCustomerGroupNo)
				{
				_aRCustomerGroupNo=value;
				NotifyChanged("ARCustomerGroupNo");
				}
			}
		}
		public String ARCustomerGroupName
		{
			get{return _aRCustomerGroupName;}
			set
			{
				if (value != this._aRCustomerGroupName)
				{
				_aRCustomerGroupName=value;
				NotifyChanged("ARCustomerGroupName");
				}
			}
		}
		public String ARCustomerGroupDesc
		{
			get{return _aRCustomerGroupDesc;}
			set
			{
				if (value != this._aRCustomerGroupDesc)
				{
				_aRCustomerGroupDesc=value;
				NotifyChanged("ARCustomerGroupDesc");
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
		#endregion
	}
	#endregion
}