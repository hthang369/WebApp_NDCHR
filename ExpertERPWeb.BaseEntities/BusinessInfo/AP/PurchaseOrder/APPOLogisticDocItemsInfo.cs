using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPOLogisticDocItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPOLogisticDocItemsInfo
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class APPOLogisticDocItemsInfo:BusinessObject
	{
		public APPOLogisticDocItemsInfo()
		{
		}
		#region Variables
		protected int _aPPOLogisticDocItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aPPOLogisticDocItemName=String.Empty;
		protected String _aPPOLogisticDocItemType=String.Empty;
		protected String _aPPOLogisticDocItemServerPath=String.Empty;
		protected int _fK_ADUserID;
		protected int _fK_APPOID;
		protected Nullable<DateTime> _aPPOLogisticDocItemDate;
		protected String _aPPOLogisticDocItemFileLocalPath=String.Empty;
		protected String _aPPOLogisticDocItemDesc=String.Empty;
		#endregion

		#region Public properties
		public int APPOLogisticDocItemID
		{
			get{return _aPPOLogisticDocItemID;}
			set
			{
				if (value != this._aPPOLogisticDocItemID)
				{
				_aPPOLogisticDocItemID=value;
				NotifyChanged("APPOLogisticDocItemID");
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
		public String APPOLogisticDocItemName
		{
			get{return _aPPOLogisticDocItemName;}
			set
			{
				if (value != this._aPPOLogisticDocItemName)
				{
				_aPPOLogisticDocItemName=value;
				NotifyChanged("APPOLogisticDocItemName");
				}
			}
		}
		public String APPOLogisticDocItemType
		{
			get{return _aPPOLogisticDocItemType;}
			set
			{
				if (value != this._aPPOLogisticDocItemType)
				{
				_aPPOLogisticDocItemType=value;
				NotifyChanged("APPOLogisticDocItemType");
				}
			}
		}
		public String APPOLogisticDocItemServerPath
		{
			get{return _aPPOLogisticDocItemServerPath;}
			set
			{
				if (value != this._aPPOLogisticDocItemServerPath)
				{
				_aPPOLogisticDocItemServerPath=value;
				NotifyChanged("APPOLogisticDocItemServerPath");
				}
			}
		}
		public int FK_ADUserID
		{
			get{return _fK_ADUserID;}
			set
			{
				if (value != this._fK_ADUserID)
				{
				_fK_ADUserID=value;
				NotifyChanged("FK_ADUserID");
				}
			}
		}
		public int FK_APPOID
		{
			get{return _fK_APPOID;}
			set
			{
				if (value != this._fK_APPOID)
				{
				_fK_APPOID=value;
				NotifyChanged("FK_APPOID");
				}
			}
		}
		public Nullable<DateTime> APPOLogisticDocItemDate
		{
			get{return _aPPOLogisticDocItemDate;}
			set
			{
				if (value != this._aPPOLogisticDocItemDate)
				{
				_aPPOLogisticDocItemDate=value;
				NotifyChanged("APPOLogisticDocItemDate");
				}
			}
		}
		public String APPOLogisticDocItemFileLocalPath
		{
			get{return _aPPOLogisticDocItemFileLocalPath;}
			set
			{
				if (value != this._aPPOLogisticDocItemFileLocalPath)
				{
				_aPPOLogisticDocItemFileLocalPath=value;
				NotifyChanged("APPOLogisticDocItemFileLocalPath");
				}
			}
		}
		public String APPOLogisticDocItemDesc
		{
			get{return _aPPOLogisticDocItemDesc;}
			set
			{
				if (value != this._aPPOLogisticDocItemDesc)
				{
				_aPPOLogisticDocItemDesc=value;
				NotifyChanged("APPOLogisticDocItemDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}