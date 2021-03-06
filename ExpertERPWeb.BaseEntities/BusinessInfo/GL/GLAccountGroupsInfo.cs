using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLAccountGroups
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLAccountGroupsInfo
	//Created Date:Wednesday, March 21, 2012
	//-----------------------------------------------------------
	
	public class GLAccountGroupsInfo:BusinessObject
	{
		public GLAccountGroupsInfo()
		{
		}
		#region Variables
		protected int _gLAccountGroupID;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected String _gLAccountGroupNo=String.Empty;
		protected String _gLAccountGroupDesc=String.Empty;
		protected String _gLAccountGroupName=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		#endregion

		#region Public properties
		public int GLAccountGroupID
		{
			get{return _gLAccountGroupID;}
			set
			{
				if (value != this._gLAccountGroupID)
				{
				_gLAccountGroupID=value;
				NotifyChanged("GLAccountGroupID");
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
		public String GLAccountGroupNo
		{
			get{return _gLAccountGroupNo;}
			set
			{
				if (value != this._gLAccountGroupNo)
				{
				_gLAccountGroupNo=value;
				NotifyChanged("GLAccountGroupNo");
				}
			}
		}
		public String GLAccountGroupDesc
		{
			get{return _gLAccountGroupDesc;}
			set
			{
				if (value != this._gLAccountGroupDesc)
				{
				_gLAccountGroupDesc=value;
				NotifyChanged("GLAccountGroupDesc");
				}
			}
		}
		public String GLAccountGroupName
		{
			get{return _gLAccountGroupName;}
			set
			{
				if (value != this._gLAccountGroupName)
				{
				_gLAccountGroupName=value;
				NotifyChanged("GLAccountGroupName");
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