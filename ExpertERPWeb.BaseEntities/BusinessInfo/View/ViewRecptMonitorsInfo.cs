using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewRecptMonitors
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ViewRecptMonitorsInfo
	//Created Date:Wednesday, January 7, 2015
	//-----------------------------------------------------------
	
	public class ViewRecptMonitorsInfo:BusinessObject
	{
		public ViewRecptMonitorsInfo()
		{
		}
		#region Variables
		protected int _viewRecptMonitorID;
		protected int _fK_ICProductID;
		protected double _pOQty;
		protected double _pOQtyPct;
		protected double _pOReceiptQty;
		protected double _pOReceiptQtyPct;
		protected double _produceQty;
		protected double _produceQtyPct;
		protected double _completeQty;
		protected double _completeQtyPct;
		protected String _productName=String.Empty;
		protected double _processQty;
		protected double _produceReceiptQty;
		protected double _produceReceiptQtyPct;
		protected int _fK_ICProductParentID;
		protected String _productNo=String.Empty;
		protected String _productParentNo=String.Empty;
		protected String _productParentName=String.Empty;
		protected double _length;
		protected double _width;
		protected double _height;
		protected double _cBM;
		protected double _cBMInParent;
		protected int _period;
		protected int _year;
		protected double _wMO;
		protected double _needToShipQty;
		protected double _shippedQty;
		protected double _shippedPct;
		protected double _needToShipRQty;
		protected double _needToShipRPct;
		protected String _iCProductStkUOM=String.Empty;
		protected int _day;
		protected int _fK_ICStockID;
		protected String _iCStockNo=String.Empty;
		protected double _shippedAmt;
		#endregion

		#region Public properties
		public int ViewRecptMonitorID
		{
			get{return _viewRecptMonitorID;}
			set
			{
				if (value != this._viewRecptMonitorID)
				{
				_viewRecptMonitorID=value;
				NotifyChanged("ViewRecptMonitorID");
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
		public double POQty
		{
			get{return _pOQty;}
			set
			{
				if (value != this._pOQty)
				{
				_pOQty=value;
				NotifyChanged("POQty");
				}
			}
		}
		public double POQtyPct
		{
			get{return _pOQtyPct;}
			set
			{
				if (value != this._pOQtyPct)
				{
				_pOQtyPct=value;
				NotifyChanged("POQtyPct");
				}
			}
		}
		public double POReceiptQty
		{
			get{return _pOReceiptQty;}
			set
			{
				if (value != this._pOReceiptQty)
				{
				_pOReceiptQty=value;
				NotifyChanged("POReceiptQty");
				}
			}
		}
		public double POReceiptQtyPct
		{
			get{return _pOReceiptQtyPct;}
			set
			{
				if (value != this._pOReceiptQtyPct)
				{
				_pOReceiptQtyPct=value;
				NotifyChanged("POReceiptQtyPct");
				}
			}
		}
		public double ProduceQty
		{
			get{return _produceQty;}
			set
			{
				if (value != this._produceQty)
				{
				_produceQty=value;
				NotifyChanged("ProduceQty");
				}
			}
		}
		public double ProduceQtyPct
		{
			get{return _produceQtyPct;}
			set
			{
				if (value != this._produceQtyPct)
				{
				_produceQtyPct=value;
				NotifyChanged("ProduceQtyPct");
				}
			}
		}
		public double CompleteQty
		{
			get{return _completeQty;}
			set
			{
				if (value != this._completeQty)
				{
				_completeQty=value;
				NotifyChanged("CompleteQty");
				}
			}
		}
		public double CompleteQtyPct
		{
			get{return _completeQtyPct;}
			set
			{
				if (value != this._completeQtyPct)
				{
				_completeQtyPct=value;
				NotifyChanged("CompleteQtyPct");
				}
			}
		}
		public String ProductName
		{
			get{return _productName;}
			set
			{
				if (value != this._productName)
				{
				_productName=value;
				NotifyChanged("ProductName");
				}
			}
		}
		public double ProcessQty
		{
			get{return _processQty;}
			set
			{
				if (value != this._processQty)
				{
				_processQty=value;
				NotifyChanged("ProcessQty");
				}
			}
		}
		public double ProduceReceiptQty
		{
			get{return _produceReceiptQty;}
			set
			{
				if (value != this._produceReceiptQty)
				{
				_produceReceiptQty=value;
				NotifyChanged("ProduceReceiptQty");
				}
			}
		}
		public double ProduceReceiptQtyPct
		{
			get{return _produceReceiptQtyPct;}
			set
			{
				if (value != this._produceReceiptQtyPct)
				{
				_produceReceiptQtyPct=value;
				NotifyChanged("ProduceReceiptQtyPct");
				}
			}
		}
		public int FK_ICProductParentID
		{
			get{return _fK_ICProductParentID;}
			set
			{
				if (value != this._fK_ICProductParentID)
				{
				_fK_ICProductParentID=value;
				NotifyChanged("FK_ICProductParentID");
				}
			}
		}
		public String ProductNo
		{
			get{return _productNo;}
			set
			{
				if (value != this._productNo)
				{
				_productNo=value;
				NotifyChanged("ProductNo");
				}
			}
		}
		public String ProductParentNo
		{
			get{return _productParentNo;}
			set
			{
				if (value != this._productParentNo)
				{
				_productParentNo=value;
				NotifyChanged("ProductParentNo");
				}
			}
		}
		public String ProductParentName
		{
			get{return _productParentName;}
			set
			{
				if (value != this._productParentName)
				{
				_productParentName=value;
				NotifyChanged("ProductParentName");
				}
			}
		}
		public double Length
		{
			get{return _length;}
			set
			{
				if (value != this._length)
				{
				_length=value;
				NotifyChanged("Length");
				}
			}
		}
		public double Width
		{
			get{return _width;}
			set
			{
				if (value != this._width)
				{
				_width=value;
				NotifyChanged("Width");
				}
			}
		}
		public double Height
		{
			get{return _height;}
			set
			{
				if (value != this._height)
				{
				_height=value;
				NotifyChanged("Height");
				}
			}
		}
		public double CBM
		{
			get{return _cBM;}
			set
			{
				if (value != this._cBM)
				{
				_cBM=value;
				NotifyChanged("CBM");
				}
			}
		}
		public double CBMInParent
		{
			get{return _cBMInParent;}
			set
			{
				if (value != this._cBMInParent)
				{
				_cBMInParent=value;
				NotifyChanged("CBMInParent");
				}
			}
		}
		public int Period
		{
			get{return _period;}
			set
			{
				if (value != this._period)
				{
				_period=value;
				NotifyChanged("Period");
				}
			}
		}
		public int Year
		{
			get{return _year;}
			set
			{
				if (value != this._year)
				{
				_year=value;
				NotifyChanged("Year");
				}
			}
		}
		public double WMO
		{
			get{return _wMO;}
			set
			{
				if (value != this._wMO)
				{
				_wMO=value;
				NotifyChanged("WMO");
				}
			}
		}
		public double NeedToShipQty
		{
			get{return _needToShipQty;}
			set
			{
				if (value != this._needToShipQty)
				{
				_needToShipQty=value;
				NotifyChanged("NeedToShipQty");
				}
			}
		}
		public double ShippedQty
		{
			get{return _shippedQty;}
			set
			{
				if (value != this._shippedQty)
				{
				_shippedQty=value;
				NotifyChanged("ShippedQty");
				}
			}
		}
		public double ShippedPct
		{
			get{return _shippedPct;}
			set
			{
				if (value != this._shippedPct)
				{
				_shippedPct=value;
				NotifyChanged("ShippedPct");
				}
			}
		}
		public double NeedToShipRQty
		{
			get{return _needToShipRQty;}
			set
			{
				if (value != this._needToShipRQty)
				{
				_needToShipRQty=value;
				NotifyChanged("NeedToShipRQty");
				}
			}
		}
		public double NeedToShipRPct
		{
			get{return _needToShipRPct;}
			set
			{
				if (value != this._needToShipRPct)
				{
				_needToShipRPct=value;
				NotifyChanged("NeedToShipRPct");
				}
			}
		}
		public String ICProductStkUOM
		{
			get{return _iCProductStkUOM;}
			set
			{
				if (value != this._iCProductStkUOM)
				{
				_iCProductStkUOM=value;
				NotifyChanged("ICProductStkUOM");
				}
			}
		}
		public int Day
		{
			get{return _day;}
			set
			{
				if (value != this._day)
				{
				_day=value;
				NotifyChanged("Day");
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
		public String ICStockNo
		{
			get{return _iCStockNo;}
			set
			{
				if (value != this._iCStockNo)
				{
				_iCStockNo=value;
				NotifyChanged("ICStockNo");
				}
			}
		}
		public double ShippedAmt
		{
			get{return _shippedAmt;}
			set
			{
				if (value != this._shippedAmt)
				{
				_shippedAmt=value;
				NotifyChanged("ShippedAmt");
				}
			}
		}
		#endregion
	}
	#endregion
}