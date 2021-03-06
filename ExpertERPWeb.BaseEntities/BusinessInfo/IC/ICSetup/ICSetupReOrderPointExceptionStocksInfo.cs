using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICSetupReOrderPointExceptionStocks
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICSetupReOrderPointExceptionStocksInfo
	//Created Date:25 Tháng Năm 2013
	//-----------------------------------------------------------
	
	public class ICSetupReOrderPointExceptionStocksInfo:BusinessObject
	{
		public ICSetupReOrderPointExceptionStocksInfo()
		{
		}
		#region Variables
		protected int _iCSetupReOrderPointExceptionStockID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ICStockID;
		protected String _iCSetupReOrderPointExceptionStockDesc=String.Empty;
		#endregion

		#region Public properties
		public int ICSetupReOrderPointExceptionStockID
		{
			get{return _iCSetupReOrderPointExceptionStockID;}
			set
			{
				if (value != this._iCSetupReOrderPointExceptionStockID)
				{
				_iCSetupReOrderPointExceptionStockID=value;
				NotifyChanged("ICSetupReOrderPointExceptionStockID");
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
		public int FK_ICStockID
		{
			get{return _fK_ICStockID;}
			set
			{
				if (value != this._fK_ICStockID)
				{
				_fK_ICStockID=value;
				NotifyChanged("FK_ICStockID");
				}
			}
		}
		public String ICSetupReOrderPointExceptionStockDesc
		{
			get{return _iCSetupReOrderPointExceptionStockDesc;}
			set
			{
				if (value != this._iCSetupReOrderPointExceptionStockDesc)
				{
				_iCSetupReOrderPointExceptionStockDesc=value;
				NotifyChanged("ICSetupReOrderPointExceptionStockDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}