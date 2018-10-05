using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICReceiptItemSaleReturnItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICReceiptItemSaleReturnItemsInfo
	//Created Date:27 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ICReceiptItemSaleReturnItemsInfo:BusinessObject
	{
		public ICReceiptItemSaleReturnItemsInfo()
		{
		}
		#region Variables
		protected int _iCReceiptItemSaleReturnItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARSaleReturnItemID;
		protected int _fK_ICReceiptItemID;
		#endregion

		#region Public properties
		public int ICReceiptItemSaleReturnItemID
		{
			get{return _iCReceiptItemSaleReturnItemID;}
			set
			{
				if (value != this._iCReceiptItemSaleReturnItemID)
				{
				_iCReceiptItemSaleReturnItemID=value;
				NotifyChanged("ICReceiptItemSaleReturnItemID");
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
		public int FK_ARSaleReturnItemID
		{
			get{return _fK_ARSaleReturnItemID;}
			set
			{
				if (value != this._fK_ARSaleReturnItemID)
				{
				_fK_ARSaleReturnItemID=value;
				NotifyChanged("FK_ARSaleReturnItemID");
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