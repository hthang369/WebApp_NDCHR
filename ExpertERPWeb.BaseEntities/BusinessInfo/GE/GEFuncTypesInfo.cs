using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEFuncTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEFuncTypesInfo
	//Created Date:Monday, April 03, 2017
	//-----------------------------------------------------------
	
	public class GEFuncTypesInfo:BusinessObject
	{
		public GEFuncTypesInfo()
		{
		}
		#region Variables
		protected int _gEFuncTypeID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _gEFuncTypeNo=String.Empty;
		protected String _gEFuncTypeName=String.Empty;
		protected String _gEFuncTypeDesc=String.Empty;
		protected int _gEFuncTypeSortOrder;
		#endregion

		#region Public properties
		public int GEFuncTypeID
		{
			get{return _gEFuncTypeID;}
			set
			{
				if (value != this._gEFuncTypeID)
				{
				_gEFuncTypeID=value;
				NotifyChanged("GEFuncTypeID");
				}
			}
		}
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		public String GEFuncTypeNo
		{
			get{return _gEFuncTypeNo;}
			set
			{
				if (value != this._gEFuncTypeNo)
				{
				_gEFuncTypeNo=value;
				NotifyChanged("GEFuncTypeNo");
				}
			}
		}
		public String GEFuncTypeName
		{
			get{return _gEFuncTypeName;}
			set
			{
				if (value != this._gEFuncTypeName)
				{
				_gEFuncTypeName=value;
				NotifyChanged("GEFuncTypeName");
				}
			}
		}
		public String GEFuncTypeDesc
		{
			get{return _gEFuncTypeDesc;}
			set
			{
				if (value != this._gEFuncTypeDesc)
				{
				_gEFuncTypeDesc=value;
				NotifyChanged("GEFuncTypeDesc");
				}
			}
		}
		public int GEFuncTypeSortOrder
		{
			get{return _gEFuncTypeSortOrder;}
			set
			{
				if (value != this._gEFuncTypeSortOrder)
				{
				_gEFuncTypeSortOrder=value;
				NotifyChanged("GEFuncTypeSortOrder");
				}
			}
		}
		#endregion
	}
	#endregion
}