using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewProductSales
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewProductSalesInfo
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class ViewProductSalesInfo:BusinessObject
	{
		public ViewProductSalesInfo()
		{
		}
		#region Variables
		protected int _viewPruductSaleID;
		protected int _fK_ICProductID;
		protected String _iCProductName=String.Empty;
		protected double _saleQty;
		protected double _returnTralaiQty;
		protected double _returnHuyQty;
		protected double _tralaiPct;
		protected double _huyPct;
		#endregion

		#region Public properties
		public int ViewPruductSaleID
		{
			get{return _viewPruductSaleID;}
			set
			{
				if (value != this._viewPruductSaleID)
				{
				_viewPruductSaleID=value;
				NotifyChanged("ViewPruductSaleID");
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
		public String ICProductName
		{
			get{return _iCProductName;}
			set
			{
				if (value != this._iCProductName)
				{
				_iCProductName=value;
				NotifyChanged("ICProductName");
				}
			}
		}
		public double SaleQty
		{
			get{return _saleQty;}
			set
			{
				if (value != this._saleQty)
				{
				_saleQty=value;
				NotifyChanged("SaleQty");
				}
			}
		}
		public double ReturnTralaiQty
		{
			get{return _returnTralaiQty;}
			set
			{
				if (value != this._returnTralaiQty)
				{
				_returnTralaiQty=value;
				NotifyChanged("ReturnTralaiQty");
				}
			}
		}
		public double ReturnHuyQty
		{
			get{return _returnHuyQty;}
			set
			{
				if (value != this._returnHuyQty)
				{
				_returnHuyQty=value;
				NotifyChanged("ReturnHuyQty");
				}
			}
		}
		public double TralaiPct
		{
			get{return _tralaiPct;}
			set
			{
				if (value != this._tralaiPct)
				{
				_tralaiPct=value;
				NotifyChanged("TralaiPct");
				}
			}
		}
		public double HuyPct
		{
			get{return _huyPct;}
			set
			{
				if (value != this._huyPct)
				{
				_huyPct=value;
				NotifyChanged("HuyPct");
				}
			}
		}
		#endregion
	}
	#endregion
}