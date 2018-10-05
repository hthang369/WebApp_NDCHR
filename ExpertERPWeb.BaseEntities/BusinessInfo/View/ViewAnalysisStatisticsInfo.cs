using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewAnalysisStatistics
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewAnalysisStatisticsInfo
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class ViewAnalysisStatisticsInfo:BusinessObject
	{
		public ViewAnalysisStatisticsInfo()
		{
		}
		#region Variables
		protected int _viewAnalysisStatisticID;
		protected String _viewAnalysisStatisticDocNo=String.Empty;
		protected Nullable<DateTime> _viewAnalysisStatisticDocDate;
		protected double _viewAnalysisStatisticQty;
		protected double _viewAnalysisStatisticUnitPrice;
		protected double _viewAnalysisStatisticFUnitPrice;
		protected double _viewAnalysisStatisticPrice;
		protected double _viewAnalysisStatisticFPrice;
		protected String _viewAnalysisStatisticTypeCombo=String.Empty;
		protected int _fK_ICProductID;
		protected String _iCProductName=String.Empty;
		protected int _fK_APSupplierID;
		protected String _aPSupplierName=String.Empty;
		protected int _fK_ARCustomerID;
		protected String _aRCustomerName=String.Empty;
		protected int _fK_ICProductDimention1ID;
		protected int _fK_ICProductDimention2ID;
		protected int _fK_ICProductDimention3ID;
		protected int _fK_ICProductDimention4ID;
		protected int _fK_ICProductDimention5ID;
		#endregion

		#region Public properties
		public int ViewAnalysisStatisticID
		{
			get{return _viewAnalysisStatisticID;}
			set
			{
				if (value != this._viewAnalysisStatisticID)
				{
				_viewAnalysisStatisticID=value;
				NotifyChanged("ViewAnalysisStatisticID");
				}
			}
		}
		public String ViewAnalysisStatisticDocNo
		{
			get{return _viewAnalysisStatisticDocNo;}
			set
			{
				if (value != this._viewAnalysisStatisticDocNo)
				{
				_viewAnalysisStatisticDocNo=value;
				NotifyChanged("ViewAnalysisStatisticDocNo");
				}
			}
		}
		public Nullable<DateTime> ViewAnalysisStatisticDocDate
		{
			get{return _viewAnalysisStatisticDocDate;}
			set
			{
				if (value != this._viewAnalysisStatisticDocDate)
				{
				_viewAnalysisStatisticDocDate=value;
				NotifyChanged("ViewAnalysisStatisticDocDate");
				}
			}
		}
		public double ViewAnalysisStatisticQty
		{
			get{return _viewAnalysisStatisticQty;}
			set
			{
				if (value != this._viewAnalysisStatisticQty)
				{
				_viewAnalysisStatisticQty=value;
				NotifyChanged("ViewAnalysisStatisticQty");
				}
			}
		}
		public double ViewAnalysisStatisticUnitPrice
		{
			get{return _viewAnalysisStatisticUnitPrice;}
			set
			{
				if (value != this._viewAnalysisStatisticUnitPrice)
				{
				_viewAnalysisStatisticUnitPrice=value;
				NotifyChanged("ViewAnalysisStatisticUnitPrice");
				}
			}
		}
		public double ViewAnalysisStatisticFUnitPrice
		{
			get{return _viewAnalysisStatisticFUnitPrice;}
			set
			{
				if (value != this._viewAnalysisStatisticFUnitPrice)
				{
				_viewAnalysisStatisticFUnitPrice=value;
				NotifyChanged("ViewAnalysisStatisticFUnitPrice");
				}
			}
		}
		public double ViewAnalysisStatisticPrice
		{
			get{return _viewAnalysisStatisticPrice;}
			set
			{
				if (value != this._viewAnalysisStatisticPrice)
				{
				_viewAnalysisStatisticPrice=value;
				NotifyChanged("ViewAnalysisStatisticPrice");
				}
			}
		}
		public double ViewAnalysisStatisticFPrice
		{
			get{return _viewAnalysisStatisticFPrice;}
			set
			{
				if (value != this._viewAnalysisStatisticFPrice)
				{
				_viewAnalysisStatisticFPrice=value;
				NotifyChanged("ViewAnalysisStatisticFPrice");
				}
			}
		}
		public String ViewAnalysisStatisticTypeCombo
		{
			get{return _viewAnalysisStatisticTypeCombo;}
			set
			{
				if (value != this._viewAnalysisStatisticTypeCombo)
				{
				_viewAnalysisStatisticTypeCombo=value;
				NotifyChanged("ViewAnalysisStatisticTypeCombo");
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
		public int FK_APSupplierID
		{
			get{return _fK_APSupplierID;}
			set
			{
				if (value != this._fK_APSupplierID)
				{
				_fK_APSupplierID=value;
				NotifyChanged("FK_APSupplierID");
				}
			}
		}
		public String APSupplierName
		{
			get{return _aPSupplierName;}
			set
			{
				if (value != this._aPSupplierName)
				{
				_aPSupplierName=value;
				NotifyChanged("APSupplierName");
				}
			}
		}
		public int FK_ARCustomerID
		{
			get{return _fK_ARCustomerID;}
			set
			{
				if (value != this._fK_ARCustomerID)
				{
				_fK_ARCustomerID=value;
				NotifyChanged("FK_ARCustomerID");
				}
			}
		}
		public String ARCustomerName
		{
			get{return _aRCustomerName;}
			set
			{
				if (value != this._aRCustomerName)
				{
				_aRCustomerName=value;
				NotifyChanged("ARCustomerName");
				}
			}
		}
		public int FK_ICProductDimention1ID
		{
			get{return _fK_ICProductDimention1ID;}
			set
			{
				if (value != this._fK_ICProductDimention1ID)
				{
				_fK_ICProductDimention1ID=value;
				NotifyChanged("FK_ICProductDimention1ID");
				}
			}
		}
		public int FK_ICProductDimention2ID
		{
			get{return _fK_ICProductDimention2ID;}
			set
			{
				if (value != this._fK_ICProductDimention2ID)
				{
				_fK_ICProductDimention2ID=value;
				NotifyChanged("FK_ICProductDimention2ID");
				}
			}
		}
		public int FK_ICProductDimention3ID
		{
			get{return _fK_ICProductDimention3ID;}
			set
			{
				if (value != this._fK_ICProductDimention3ID)
				{
				_fK_ICProductDimention3ID=value;
				NotifyChanged("FK_ICProductDimention3ID");
				}
			}
		}
		public int FK_ICProductDimention4ID
		{
			get{return _fK_ICProductDimention4ID;}
			set
			{
				if (value != this._fK_ICProductDimention4ID)
				{
				_fK_ICProductDimention4ID=value;
				NotifyChanged("FK_ICProductDimention4ID");
				}
			}
		}
		public int FK_ICProductDimention5ID
		{
			get{return _fK_ICProductDimention5ID;}
			set
			{
				if (value != this._fK_ICProductDimention5ID)
				{
				_fK_ICProductDimention5ID=value;
				NotifyChanged("FK_ICProductDimention5ID");
				}
			}
		}
		#endregion
	}
	#endregion
}