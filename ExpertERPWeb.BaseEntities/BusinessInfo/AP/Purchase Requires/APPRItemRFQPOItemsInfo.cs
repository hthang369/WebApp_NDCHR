using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPRItemRFQPOItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APPRItemRFQPOItemsInfo
	//Created Date:Wednesday, April 15, 2015
	//-----------------------------------------------------------
	
	public class APPRItemRFQPOItemsInfo:BusinessObject
	{
		public APPRItemRFQPOItemsInfo()
		{
		}
		#region Variables
		protected int _aPPRItemRFQPOItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPRItemRFQID;
		protected int _fK_APPOItemID;
		#endregion

		#region Public properties
		public int APPRItemRFQPOItemID
		{
			get{return _aPPRItemRFQPOItemID;}
			set
			{
				if (value != this._aPPRItemRFQPOItemID)
				{
				_aPPRItemRFQPOItemID=value;
				NotifyChanged("APPRItemRFQPOItemID");
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
		public int FK_APPRItemRFQID
		{
			get{return _fK_APPRItemRFQID;}
			set
			{
				if (value != this._fK_APPRItemRFQID)
				{
				_fK_APPRItemRFQID=value;
				NotifyChanged("FK_APPRItemRFQID");
				}
			}
		}
		public int FK_APPOItemID
		{
			get{return _fK_APPOItemID;}
			set
			{
				if (value != this._fK_APPOItemID)
				{
				_fK_APPOItemID=value;
				NotifyChanged("FK_APPOItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}