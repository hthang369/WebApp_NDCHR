using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustReqAnalyzeCfgs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustReqAnalyzeCfgsInfo
	//Created Date:Tuesday, December 16, 2014
	//-----------------------------------------------------------
	
	public class ARCustReqAnalyzeCfgsInfo:BusinessObject
	{
		public ARCustReqAnalyzeCfgsInfo()
		{
		}
		#region Variables
		protected int _aRCustReqAnalyzeCfgID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aRCustReqAnalyzeCfgNo=String.Empty;
		protected String _aRCustReqAnalyzeCfgName=String.Empty;
		protected String _aRCustReqAnalyzeCfgDesc=String.Empty;
		protected bool _aRCustReqAnalyzeCfgDefaulCheck=true;
		protected int _fK_ARCustReqAnalyzeCfgID;
		protected int _aRCustReqAnalyzeCfgOrder;
		#endregion

		#region Public properties
		public int ARCustReqAnalyzeCfgID
		{
			get{return _aRCustReqAnalyzeCfgID;}
			set
			{
				if (value != this._aRCustReqAnalyzeCfgID)
				{
				_aRCustReqAnalyzeCfgID=value;
				NotifyChanged("ARCustReqAnalyzeCfgID");
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
		public String ARCustReqAnalyzeCfgNo
		{
			get{return _aRCustReqAnalyzeCfgNo;}
			set
			{
				if (value != this._aRCustReqAnalyzeCfgNo)
				{
				_aRCustReqAnalyzeCfgNo=value;
				NotifyChanged("ARCustReqAnalyzeCfgNo");
				}
			}
		}
		public String ARCustReqAnalyzeCfgName
		{
			get{return _aRCustReqAnalyzeCfgName;}
			set
			{
				if (value != this._aRCustReqAnalyzeCfgName)
				{
				_aRCustReqAnalyzeCfgName=value;
				NotifyChanged("ARCustReqAnalyzeCfgName");
				}
			}
		}
		public String ARCustReqAnalyzeCfgDesc
		{
			get{return _aRCustReqAnalyzeCfgDesc;}
			set
			{
				if (value != this._aRCustReqAnalyzeCfgDesc)
				{
				_aRCustReqAnalyzeCfgDesc=value;
				NotifyChanged("ARCustReqAnalyzeCfgDesc");
				}
			}
		}
		public bool ARCustReqAnalyzeCfgDefaulCheck
		{
			get{return _aRCustReqAnalyzeCfgDefaulCheck;}
			set
			{
				if (value != this._aRCustReqAnalyzeCfgDefaulCheck)
				{
				_aRCustReqAnalyzeCfgDefaulCheck=value;
				NotifyChanged("ARCustReqAnalyzeCfgDefaulCheck");
				}
			}
		}
		public int FK_ARCustReqAnalyzeCfgID
		{
			get{return _fK_ARCustReqAnalyzeCfgID;}
			set
			{
				if (value != this._fK_ARCustReqAnalyzeCfgID)
				{
				_fK_ARCustReqAnalyzeCfgID=value;
				NotifyChanged("FK_ARCustReqAnalyzeCfgID");
				}
			}
		}
		public int ARCustReqAnalyzeCfgOrder
		{
			get{return _aRCustReqAnalyzeCfgOrder;}
			set
			{
				if (value != this._aRCustReqAnalyzeCfgOrder)
				{
				_aRCustReqAnalyzeCfgOrder=value;
				NotifyChanged("ARCustReqAnalyzeCfgOrder");
				}
			}
		}
		#endregion
	}
	#endregion
}