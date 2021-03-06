using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPPhaseCfgStocks
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPPhaseCfgStocksInfo
	//Created Date:28 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class PPPhaseCfgStocksInfo:BusinessObject
	{
		public PPPhaseCfgStocksInfo()
		{
		}
		#region Variables
		protected int _pPPhaseCfgStockID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected String _pPPhaseCfgStockNo=String.Empty;
		protected String _pPPhaseCfgStockName=String.Empty;
		protected int _fK_ICStockID;
		protected int _fK_PPPhaseCfgID;
		protected String _aAOrgDocNo=String.Empty;
		protected bool _aASelected=true;
		#endregion

		#region Public properties
		public int PPPhaseCfgStockID
		{
			get{return _pPPhaseCfgStockID;}
			set
			{
				if (value != this._pPPhaseCfgStockID)
				{
				_pPPhaseCfgStockID=value;
				NotifyChanged("PPPhaseCfgStockID");
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
		public String PPPhaseCfgStockNo
		{
			get{return _pPPhaseCfgStockNo;}
			set
			{
				if (value != this._pPPhaseCfgStockNo)
				{
				_pPPhaseCfgStockNo=value;
				NotifyChanged("PPPhaseCfgStockNo");
				}
			}
		}
		public String PPPhaseCfgStockName
		{
			get{return _pPPhaseCfgStockName;}
			set
			{
				if (value != this._pPPhaseCfgStockName)
				{
				_pPPhaseCfgStockName=value;
				NotifyChanged("PPPhaseCfgStockName");
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
		public int FK_PPPhaseCfgID
		{
			get{return _fK_PPPhaseCfgID;}
			set
			{
				if (value != this._fK_PPPhaseCfgID)
				{
				_fK_PPPhaseCfgID=value;
				NotifyChanged("FK_PPPhaseCfgID");
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
		#endregion
	}
	#endregion
}