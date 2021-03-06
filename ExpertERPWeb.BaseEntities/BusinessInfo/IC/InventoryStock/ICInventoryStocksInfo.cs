using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICInventoryStocks
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICInventoryStocksInfo
	//Created Date:Friday, December 04, 2009
	//-----------------------------------------------------------
	
	public class ICInventoryStocksInfo:BusinessObject
	{
		public ICInventoryStocksInfo()
		{
		}
		#region Variables
		protected int _iCInventoryStockID;
        protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ICStockID;
		protected int _fK_ICProductID;
		protected double _iCInventoryStockQuantity;
		protected double _iCInventoryStockProposalQuantity;
		protected double _iCInventoryStockSaleOrderQuantity;
		protected double _iCInventoryStockPurchaseOrderQuantity;
		protected int _fK_ICUOMID;
		protected double _iCInventoryStockStkQuantity;
		#endregion

		#region Public properties
		public int ICInventoryStockID
		{
			get{return _iCInventoryStockID;}
			set
			{
				if (value != this._iCInventoryStockID)
				{
				_iCInventoryStockID=value;
				NotifyChanged("ICInventoryStockID");
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
		public double ICInventoryStockQuantity
		{
			get{return _iCInventoryStockQuantity;}
			set
			{
				if (value != this._iCInventoryStockQuantity)
				{
				_iCInventoryStockQuantity=value;
				NotifyChanged("ICInventoryStockQuantity");
				}
			}
		}
		public double ICInventoryStockProposalQuantity
		{
			get{return _iCInventoryStockProposalQuantity;}
			set
			{
				if (value != this._iCInventoryStockProposalQuantity)
				{
				_iCInventoryStockProposalQuantity=value;
				NotifyChanged("ICInventoryStockProposalQuantity");
				}
			}
		}
		public double ICInventoryStockSaleOrderQuantity
		{
			get{return _iCInventoryStockSaleOrderQuantity;}
			set
			{
				if (value != this._iCInventoryStockSaleOrderQuantity)
				{
				_iCInventoryStockSaleOrderQuantity=value;
				NotifyChanged("ICInventoryStockSaleOrderQuantity");
				}
			}
		}
		public double ICInventoryStockPurchaseOrderQuantity
		{
			get{return _iCInventoryStockPurchaseOrderQuantity;}
			set
			{
				if (value != this._iCInventoryStockPurchaseOrderQuantity)
				{
				_iCInventoryStockPurchaseOrderQuantity=value;
				NotifyChanged("ICInventoryStockPurchaseOrderQuantity");
				}
			}
		}
		public int FK_ICUOMID
		{
			get{return _fK_ICUOMID;}
			set
			{
				if (value != this._fK_ICUOMID)
				{
				_fK_ICUOMID=value;
				NotifyChanged("FK_ICUOMID");
				}
			}
		}
		public double ICInventoryStockStkQuantity
		{
			get{return _iCInventoryStockStkQuantity;}
			set
			{
				if (value != this._iCInventoryStockStkQuantity)
				{
				_iCInventoryStockStkQuantity=value;
				NotifyChanged("ICInventoryStockStkQuantity");
				}
			}
		}
		#endregion
	}
	#endregion
}