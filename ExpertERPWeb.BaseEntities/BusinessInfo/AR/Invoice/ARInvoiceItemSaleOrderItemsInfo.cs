using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARInvoiceItemSaleOrderItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARInvoiceItemSaleOrderItemsInfo
	//Created Date:Monday, January 19, 2015
	//-----------------------------------------------------------
	
	public class ARInvoiceItemSaleOrderItemsInfo:BusinessObject
	{
		public ARInvoiceItemSaleOrderItemsInfo()
		{
		}
		#region Variables
		protected int _aRInvoiceItemSaleOrderItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_ARInvoiceItemID;
		protected int _fK_ARSOItemID;
		#endregion

		#region Public properties
		public int ARInvoiceItemSaleOrderItemID
		{
			get{return _aRInvoiceItemSaleOrderItemID;}
			set
			{
				if (value != this._aRInvoiceItemSaleOrderItemID)
				{
				_aRInvoiceItemSaleOrderItemID=value;
				NotifyChanged("ARInvoiceItemSaleOrderItemID");
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
		public int FK_ARSOItemID
		{
			get{return _fK_ARSOItemID;}
			set
			{
				if (value != this._fK_ARSOItemID)
				{
				_fK_ARSOItemID=value;
				NotifyChanged("FK_ARSOItemID");
				}
			}
		}
		#endregion
	}
	#endregion
}