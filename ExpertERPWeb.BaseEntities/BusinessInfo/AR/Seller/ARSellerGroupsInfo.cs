using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerGroups
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARSellerGroupsInfo
	//Created Date:Friday, April 27, 2012
	//-----------------------------------------------------------
	
	public class ARSellerGroupsInfo:BusinessObject
	{
		public ARSellerGroupsInfo()
		{
		}
		#region Variables
		protected int _aRSellerGroupID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aRSellerGroupNo=String.Empty;
		protected String _aRSellerGroupName=String.Empty;
		protected String _aRSellerGroupDesc=String.Empty;
		protected String _aRSellerGroupRemark=String.Empty;
		protected double _aRSellerGroupATSAmt;
		protected double _aRSellerGroupPTSAmt;
		#endregion

		#region Public properties
		public int ARSellerGroupID
		{
			get{return _aRSellerGroupID;}
			set
			{
				if (value != this._aRSellerGroupID)
				{
				_aRSellerGroupID=value;
				NotifyChanged("ARSellerGroupID");
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
		public String ARSellerGroupNo
		{
			get{return _aRSellerGroupNo;}
			set
			{
				if (value != this._aRSellerGroupNo)
				{
				_aRSellerGroupNo=value;
				NotifyChanged("ARSellerGroupNo");
				}
			}
		}
		public String ARSellerGroupName
		{
			get{return _aRSellerGroupName;}
			set
			{
				if (value != this._aRSellerGroupName)
				{
				_aRSellerGroupName=value;
				NotifyChanged("ARSellerGroupName");
				}
			}
		}
		public String ARSellerGroupDesc
		{
			get{return _aRSellerGroupDesc;}
			set
			{
				if (value != this._aRSellerGroupDesc)
				{
				_aRSellerGroupDesc=value;
				NotifyChanged("ARSellerGroupDesc");
				}
			}
		}
		public String ARSellerGroupRemark
		{
			get{return _aRSellerGroupRemark;}
			set
			{
				if (value != this._aRSellerGroupRemark)
				{
				_aRSellerGroupRemark=value;
				NotifyChanged("ARSellerGroupRemark");
				}
			}
		}
		public double ARSellerGroupATSAmt
		{
			get{return _aRSellerGroupATSAmt;}
			set
			{
				if (value != this._aRSellerGroupATSAmt)
				{
				_aRSellerGroupATSAmt=value;
				NotifyChanged("ARSellerGroupATSAmt");
				}
			}
		}
		public double ARSellerGroupPTSAmt
		{
			get{return _aRSellerGroupPTSAmt;}
			set
			{
				if (value != this._aRSellerGroupPTSAmt)
				{
				_aRSellerGroupPTSAmt=value;
				NotifyChanged("ARSellerGroupPTSAmt");
				}
			}
		}
		#endregion
	}
	#endregion
}