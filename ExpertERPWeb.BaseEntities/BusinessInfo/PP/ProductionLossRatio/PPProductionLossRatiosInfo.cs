using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionLossRatios
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPProductionLossRatiosInfo
	//Created Date:Monday, November 14, 2016
	//-----------------------------------------------------------
	
	public class PPProductionLossRatiosInfo:BusinessObject
	{
		public PPProductionLossRatiosInfo()
		{
		}
		#region Variables
		protected int _pPProductionLossRatioID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected Nullable<DateTime> _pPProductionLossRatioFromDate;
		protected Nullable<DateTime> _pPProductionLossRatioToDate;
		protected bool _pPProductionLossRatioActiveCheck=true;
		protected int _fK_ICProductID;
		#endregion

		#region Public properties
		public int PPProductionLossRatioID
		{
			get{return _pPProductionLossRatioID;}
			set
			{
				if (value != this._pPProductionLossRatioID)
				{
				_pPProductionLossRatioID=value;
				NotifyChanged("PPProductionLossRatioID");
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
		public Nullable<DateTime> PPProductionLossRatioFromDate
		{
			get{return _pPProductionLossRatioFromDate;}
			set
			{
				if (value != this._pPProductionLossRatioFromDate)
				{
				_pPProductionLossRatioFromDate=value;
				NotifyChanged("PPProductionLossRatioFromDate");
				}
			}
		}
		public Nullable<DateTime> PPProductionLossRatioToDate
		{
			get{return _pPProductionLossRatioToDate;}
			set
			{
				if (value != this._pPProductionLossRatioToDate)
				{
				_pPProductionLossRatioToDate=value;
				NotifyChanged("PPProductionLossRatioToDate");
				}
			}
		}
		public bool PPProductionLossRatioActiveCheck
		{
			get{return _pPProductionLossRatioActiveCheck;}
			set
			{
				if (value != this._pPProductionLossRatioActiveCheck)
				{
				_pPProductionLossRatioActiveCheck=value;
				NotifyChanged("PPProductionLossRatioActiveCheck");
				}
			}
		}
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				NotifyChanged("FK_ICProductID");
				}
			}
		}
		#endregion
	}
	#endregion
}