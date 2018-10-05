using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICStockTypes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICStockTypesInfo
	//Created Date:12 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class ICStockTypesInfo:BusinessObject
	{
		public ICStockTypesInfo()
		{
		}
		#region Variables
		protected int _iCStockTypeID;
		protected String _iCStockTypeNo=String.Empty;
		protected String _iCStockTypeName=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected bool _aASelected=true;
		protected String _aAOrgDocNo=String.Empty;
		#endregion

		#region Public properties
		public int ICStockTypeID
		{
			get{return _iCStockTypeID;}
			set
			{
				if (value != this._iCStockTypeID)
				{
				_iCStockTypeID=value;
				NotifyChanged("ICStockTypeID");
				}
			}
		}
		public String ICStockTypeNo
		{
			get{return _iCStockTypeNo;}
			set
			{
				if (value != this._iCStockTypeNo)
				{
				_iCStockTypeNo=value;
				NotifyChanged("ICStockTypeNo");
				}
			}
		}
		public String ICStockTypeName
		{
			get{return _iCStockTypeName;}
			set
			{
				if (value != this._iCStockTypeName)
				{
				_iCStockTypeName=value;
				NotifyChanged("ICStockTypeName");
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
		public String AAOrgDocNo
		{
			get{return _aAOrgDocNo;}
			set
			{
				if (value != this._aAOrgDocNo)
				{
				_aAOrgDocNo=value;
				NotifyChanged("AAOrgDocNo");
				}
			}
		}
		#endregion
	}
	#endregion
}