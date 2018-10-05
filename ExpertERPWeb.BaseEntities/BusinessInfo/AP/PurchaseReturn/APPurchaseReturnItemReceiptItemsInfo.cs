using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPurchaseReturnItemReceiptItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPurchaseReturnItemReceiptItemsInfo
	//Created Date:04 Tháng Chín 2012
	//-----------------------------------------------------------
	
	public class APPurchaseReturnItemReceiptItemsInfo:BusinessObject
	{
		public APPurchaseReturnItemReceiptItemsInfo()
		{
		}
		#region Variables
		protected int _aPPurchaseReturnItemReceiptItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPurchaseReturnItemID;
		protected int _fK_ICReceiptItemID;
		#endregion

		#region Public properties
		public int APPurchaseReturnItemReceiptItemID
		{
			get{return _aPPurchaseReturnItemReceiptItemID;}
			set
			{
				if (value != this._aPPurchaseReturnItemReceiptItemID)
				{
				_aPPurchaseReturnItemReceiptItemID=value;
				NotifyChanged("APPurchaseReturnItemReceiptItemID");
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
		public int FK_APPurchaseReturnItemID
		{
			get{return _fK_APPurchaseReturnItemID;}
			set
			{
				if (value != this._fK_APPurchaseReturnItemID)
				{
				_fK_APPurchaseReturnItemID=value;
				NotifyChanged("FK_APPurchaseReturnItemID");
				}
			}
		}
		public int FK_ICReceiptItemID
		{
			get{return _fK_ICReceiptItemID;}
			set
			{
				if (value != this._fK_ICReceiptItemID)
				{
				_fK_ICReceiptItemID=value;
				NotifyChanged("FK_ICReceiptItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}