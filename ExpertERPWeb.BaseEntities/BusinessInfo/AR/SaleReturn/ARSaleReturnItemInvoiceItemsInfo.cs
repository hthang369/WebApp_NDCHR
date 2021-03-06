using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleReturnItemInvoiceItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleReturnItemInvoiceItemsInfo
	//Created Date:27 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ARSaleReturnItemInvoiceItemsInfo:BusinessObject
	{
		public ARSaleReturnItemInvoiceItemsInfo()
		{
		}
		#region Variables
		protected int _aRSaleReturnItemInvoiceItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARInvoiceItemID;
		protected int _fK_ARSaleReturnItemID;
		#endregion

		#region Public properties
		public int ARSaleReturnItemInvoiceItemID
		{
			get{return _aRSaleReturnItemInvoiceItemID;}
			set
			{
				if (value != this._aRSaleReturnItemInvoiceItemID)
				{
				_aRSaleReturnItemInvoiceItemID=value;
				NotifyChanged("ARSaleReturnItemInvoiceItemID");
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
		public int FK_ARInvoiceItemID
		{
			get{return _fK_ARInvoiceItemID;}
			set
			{
				if (value != this._fK_ARInvoiceItemID)
				{
				_fK_ARInvoiceItemID=value;
				NotifyChanged("FK_ARInvoiceItemID");
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
		#endregion
	}
	#endregion
}