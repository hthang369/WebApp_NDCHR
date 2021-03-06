using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOCarGroups
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:LOCarGroupsInfo
	//Created Date:10 Tháng Giêng 2013
	//-----------------------------------------------------------
	
	public class LOCarGroupsInfo:BusinessObject
	{
		public LOCarGroupsInfo()
		{
		}
		#region Variables
		protected int _lOCarGroupID;
		protected String _lOCarGroupNo=String.Empty;
		protected String _lOCarGroupName=String.Empty;
		protected String _lOCarGroupDesc=String.Empty;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAStatus=DefaultAAStatus;
		#endregion

		#region Public properties
		public int LOCarGroupID
		{
			get{return _lOCarGroupID;}
			set
			{
				if (value != this._lOCarGroupID)
				{
				_lOCarGroupID=value;
				NotifyChanged("LOCarGroupID");
				}
			}
		}
		public String LOCarGroupNo
		{
			get{return _lOCarGroupNo;}
			set
			{
				if (value != this._lOCarGroupNo)
				{
				_lOCarGroupNo=value;
				NotifyChanged("LOCarGroupNo");
				}
			}
		}
		public String LOCarGroupName
		{
			get{return _lOCarGroupName;}
			set
			{
				if (value != this._lOCarGroupName)
				{
				_lOCarGroupName=value;
				NotifyChanged("LOCarGroupName");
				}
			}
		}
		public String LOCarGroupDesc
		{
			get{return _lOCarGroupDesc;}
			set
			{
				if (value != this._lOCarGroupDesc)
				{
				_lOCarGroupDesc=value;
				NotifyChanged("LOCarGroupDesc");
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