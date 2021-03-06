
 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewInvoiceMonitors
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v1.0.7)
    //Class: ViewInvoiceMonitorsInfo
    //Created Date: Tuesday, 14 Feb 2017
    //-----------------------------------------------------------

    public class ViewInvoiceMonitorsInfo : BusinessObject
    {
        public ViewInvoiceMonitorsInfo()
        {
        }
        #region Variables
		protected int _viewInvoiceMonitorID;
		protected int _fK_ARSOID;
		protected int _fK_ICProductID;
		protected int _fK_ARCustomerID;
		protected int _fK_ICStockID;
		protected Nullable<DateTime> _viewInvoiceMonitorDate;
		protected Nullable<DateTime> _viewInvoiceMonitorShpDate;
		protected double _viewInvoiceMonitorQty;
		protected double _viewInvoiceMonitorRQty;
		protected double _viewInvoiceMonitorShipmentQty;
		protected double _viewInvoiceMonitorShipmentPct;
		protected String _viewInvoiceMonitorPerformance = String.Empty;
		protected int _fK_ARShpPlanID;
		protected int _fK_PPPkgOrderID;
		protected int _fK_ICShipmentID;
		protected double _viewInvoiceMonitorSOQty;
		protected double _viewInvoiceMonitorSORQty;
		protected double _viewInvoiceMonitorPkgOrderQty;
		protected double _viewInvoiceMonitorPkgOrderRQty;
		protected double _viewInvoiceMonitorShipmentRQty;
		protected double _viewInvoiceMonitorShpPlanQty;
		protected double _viewInvoiceMonitorShpPlanRQty;
		protected int _fK_ARInvoiceID;
		protected String _viewInvoiceMonitorComment = String.Empty;
		protected int _fK_ARInvoiceItemID;
		protected String _viewInvoiceMonitorNo = String.Empty;
		protected String _viewInvoiceMonitorName = String.Empty;
		protected String _viewInvoiceMonitorSONo = String.Empty;
		protected String _viewInvoiceMonitorShpNo = String.Empty;
		protected String _viewInvoiceMonitorProductNo = String.Empty;
		protected String _viewInvoiceMonitorProductName = String.Empty;
		protected String _viewInvoiceMonitorUOMNo = String.Empty;
		protected String _viewInvoiceMonitorUOMName = String.Empty;
		protected String _viewInvoiceMonitorCustomerNo = String.Empty;
		protected String _viewInvoiceMonitorCustomerName = String.Empty;
		protected String _viewInvoiceMonitorCustomerBTAddL1 = String.Empty;
		protected String _viewInvoiceMonitorTaxCodeNo = String.Empty;
		protected String _viewInvoiceMonitorTaxCodeName = String.Empty;
		protected double _viewInvoiceMonitorTaxCodePct;
		protected double _viewInvoiceMonitorUnitPrice;
		protected double _viewInvoiceMonitorFUnitPrice;
		protected double _viewInvoiceMonitorPrice;
		protected double _viewInvoiceMonitorFPrice;
		protected double _viewInvoiceMonitorAmtTot;
		protected double _viewInvoiceMonitorFAmtTot;
		protected double _viewInvoiceMonitorTxAmt;
		protected double _viewInvoiceMonitorFTxAmt;
		protected String _viewInvoiceMonitorInvNo = String.Empty;
		protected Nullable<DateTime> _viewInvoiceMonitorInvDate;
		protected String _viewInvoiceMonitorInvSerie = String.Empty;
		
        #endregion

        #region Public properties
		public int ViewInvoiceMonitorID
		{
			get { return _viewInvoiceMonitorID; }
			set
			{
				if (value != this._viewInvoiceMonitorID)
				{
					_viewInvoiceMonitorID = value;
					NotifyChanged("ViewInvoiceMonitorID");
				}
			}
		}
		public int FK_ARSOID
		{
			get { return _fK_ARSOID; }
			set
			{
				if (value != this._fK_ARSOID)
				{
					_fK_ARSOID = value;
					NotifyChanged("FK_ARSOID");
				}
			}
		}
		public int FK_ICProductID
		{
			get { return _fK_ICProductID; }
			set
			{
				if (value != this._fK_ICProductID)
				{
					_fK_ICProductID = value;
					NotifyChanged("FK_ICProductID");
				}
			}
		}
		public int FK_ARCustomerID
		{
			get { return _fK_ARCustomerID; }
			set
			{
				if (value != this._fK_ARCustomerID)
				{
					_fK_ARCustomerID = value;
					NotifyChanged("FK_ARCustomerID");
				}
			}
		}
		public int FK_ICStockID
		{
			get { return _fK_ICStockID; }
			set
			{
				if (value != this._fK_ICStockID)
				{
					_fK_ICStockID = value;
					NotifyChanged("FK_ICStockID");
				}
			}
		}
		public Nullable<DateTime> ViewInvoiceMonitorDate
		{
			get { return _viewInvoiceMonitorDate; }
			set
			{
				if (value != this._viewInvoiceMonitorDate)
				{
					_viewInvoiceMonitorDate = value;
					NotifyChanged("ViewInvoiceMonitorDate");
				}
			}
		}
		public Nullable<DateTime> ViewInvoiceMonitorShpDate
		{
			get { return _viewInvoiceMonitorShpDate; }
			set
			{
				if (value != this._viewInvoiceMonitorShpDate)
				{
					_viewInvoiceMonitorShpDate = value;
					NotifyChanged("ViewInvoiceMonitorShpDate");
				}
			}
		}
		public double ViewInvoiceMonitorQty
		{
			get { return _viewInvoiceMonitorQty; }
			set
			{
				if (value != this._viewInvoiceMonitorQty)
				{
					_viewInvoiceMonitorQty = value;
					NotifyChanged("ViewInvoiceMonitorQty");
				}
			}
		}
		public double ViewInvoiceMonitorRQty
		{
			get { return _viewInvoiceMonitorRQty; }
			set
			{
				if (value != this._viewInvoiceMonitorRQty)
				{
					_viewInvoiceMonitorRQty = value;
					NotifyChanged("ViewInvoiceMonitorRQty");
				}
			}
		}
		public double ViewInvoiceMonitorShipmentQty
		{
			get { return _viewInvoiceMonitorShipmentQty; }
			set
			{
				if (value != this._viewInvoiceMonitorShipmentQty)
				{
					_viewInvoiceMonitorShipmentQty = value;
					NotifyChanged("ViewInvoiceMonitorShipmentQty");
				}
			}
		}
		public double ViewInvoiceMonitorShipmentPct
		{
			get { return _viewInvoiceMonitorShipmentPct; }
			set
			{
				if (value != this._viewInvoiceMonitorShipmentPct)
				{
					_viewInvoiceMonitorShipmentPct = value;
					NotifyChanged("ViewInvoiceMonitorShipmentPct");
				}
			}
		}
		public String ViewInvoiceMonitorPerformance
		{
			get { return _viewInvoiceMonitorPerformance; }
			set
			{
				if (value != this._viewInvoiceMonitorPerformance)
				{
					_viewInvoiceMonitorPerformance = value;
					NotifyChanged("ViewInvoiceMonitorPerformance");
				}
			}
		}
		public int FK_ARShpPlanID
		{
			get { return _fK_ARShpPlanID; }
			set
			{
				if (value != this._fK_ARShpPlanID)
				{
					_fK_ARShpPlanID = value;
					NotifyChanged("FK_ARShpPlanID");
				}
			}
		}
		public int FK_PPPkgOrderID
		{
			get { return _fK_PPPkgOrderID; }
			set
			{
				if (value != this._fK_PPPkgOrderID)
				{
					_fK_PPPkgOrderID = value;
					NotifyChanged("FK_PPPkgOrderID");
				}
			}
		}
		public int FK_ICShipmentID
		{
			get { return _fK_ICShipmentID; }
			set
			{
				if (value != this._fK_ICShipmentID)
				{
					_fK_ICShipmentID = value;
					NotifyChanged("FK_ICShipmentID");
				}
			}
		}
		public double ViewInvoiceMonitorSOQty
		{
			get { return _viewInvoiceMonitorSOQty; }
			set
			{
				if (value != this._viewInvoiceMonitorSOQty)
				{
					_viewInvoiceMonitorSOQty = value;
					NotifyChanged("ViewInvoiceMonitorSOQty");
				}
			}
		}
		public double ViewInvoiceMonitorSORQty
		{
			get { return _viewInvoiceMonitorSORQty; }
			set
			{
				if (value != this._viewInvoiceMonitorSORQty)
				{
					_viewInvoiceMonitorSORQty = value;
					NotifyChanged("ViewInvoiceMonitorSORQty");
				}
			}
		}
		public double ViewInvoiceMonitorPkgOrderQty
		{
			get { return _viewInvoiceMonitorPkgOrderQty; }
			set
			{
				if (value != this._viewInvoiceMonitorPkgOrderQty)
				{
					_viewInvoiceMonitorPkgOrderQty = value;
					NotifyChanged("ViewInvoiceMonitorPkgOrderQty");
				}
			}
		}
		public double ViewInvoiceMonitorPkgOrderRQty
		{
			get { return _viewInvoiceMonitorPkgOrderRQty; }
			set
			{
				if (value != this._viewInvoiceMonitorPkgOrderRQty)
				{
					_viewInvoiceMonitorPkgOrderRQty = value;
					NotifyChanged("ViewInvoiceMonitorPkgOrderRQty");
				}
			}
		}
		public double ViewInvoiceMonitorShipmentRQty
		{
			get { return _viewInvoiceMonitorShipmentRQty; }
			set
			{
				if (value != this._viewInvoiceMonitorShipmentRQty)
				{
					_viewInvoiceMonitorShipmentRQty = value;
					NotifyChanged("ViewInvoiceMonitorShipmentRQty");
				}
			}
		}
		public double ViewInvoiceMonitorShpPlanQty
		{
			get { return _viewInvoiceMonitorShpPlanQty; }
			set
			{
				if (value != this._viewInvoiceMonitorShpPlanQty)
				{
					_viewInvoiceMonitorShpPlanQty = value;
					NotifyChanged("ViewInvoiceMonitorShpPlanQty");
				}
			}
		}
		public double ViewInvoiceMonitorShpPlanRQty
		{
			get { return _viewInvoiceMonitorShpPlanRQty; }
			set
			{
				if (value != this._viewInvoiceMonitorShpPlanRQty)
				{
					_viewInvoiceMonitorShpPlanRQty = value;
					NotifyChanged("ViewInvoiceMonitorShpPlanRQty");
				}
			}
		}
		public int FK_ARInvoiceID
		{
			get { return _fK_ARInvoiceID; }
			set
			{
				if (value != this._fK_ARInvoiceID)
				{
					_fK_ARInvoiceID = value;
					NotifyChanged("FK_ARInvoiceID");
				}
			}
		}
		public String ViewInvoiceMonitorComment
		{
			get { return _viewInvoiceMonitorComment; }
			set
			{
				if (value != this._viewInvoiceMonitorComment)
				{
					_viewInvoiceMonitorComment = value;
					NotifyChanged("ViewInvoiceMonitorComment");
				}
			}
		}
		public int FK_ARInvoiceItemID
		{
			get { return _fK_ARInvoiceItemID; }
			set
			{
				if (value != this._fK_ARInvoiceItemID)
				{
					_fK_ARInvoiceItemID = value;
					NotifyChanged("FK_ARInvoiceItemID");
				}
			}
		}
		public String ViewInvoiceMonitorNo
		{
			get { return _viewInvoiceMonitorNo; }
			set
			{
				if (value != this._viewInvoiceMonitorNo)
				{
					_viewInvoiceMonitorNo = value;
					NotifyChanged("ViewInvoiceMonitorNo");
				}
			}
		}
		public String ViewInvoiceMonitorName
		{
			get { return _viewInvoiceMonitorName; }
			set
			{
				if (value != this._viewInvoiceMonitorName)
				{
					_viewInvoiceMonitorName = value;
					NotifyChanged("ViewInvoiceMonitorName");
				}
			}
		}
		public String ViewInvoiceMonitorSONo
		{
			get { return _viewInvoiceMonitorSONo; }
			set
			{
				if (value != this._viewInvoiceMonitorSONo)
				{
					_viewInvoiceMonitorSONo = value;
					NotifyChanged("ViewInvoiceMonitorSONo");
				}
			}
		}
		public String ViewInvoiceMonitorShpNo
		{
			get { return _viewInvoiceMonitorShpNo; }
			set
			{
				if (value != this._viewInvoiceMonitorShpNo)
				{
					_viewInvoiceMonitorShpNo = value;
					NotifyChanged("ViewInvoiceMonitorShpNo");
				}
			}
		}
		public String ViewInvoiceMonitorProductNo
		{
			get { return _viewInvoiceMonitorProductNo; }
			set
			{
				if (value != this._viewInvoiceMonitorProductNo)
				{
					_viewInvoiceMonitorProductNo = value;
					NotifyChanged("ViewInvoiceMonitorProductNo");
				}
			}
		}
		public String ViewInvoiceMonitorProductName
		{
			get { return _viewInvoiceMonitorProductName; }
			set
			{
				if (value != this._viewInvoiceMonitorProductName)
				{
					_viewInvoiceMonitorProductName = value;
					NotifyChanged("ViewInvoiceMonitorProductName");
				}
			}
		}
		public String ViewInvoiceMonitorUOMNo
		{
			get { return _viewInvoiceMonitorUOMNo; }
			set
			{
				if (value != this._viewInvoiceMonitorUOMNo)
				{
					_viewInvoiceMonitorUOMNo = value;
					NotifyChanged("ViewInvoiceMonitorUOMNo");
				}
			}
		}
		public String ViewInvoiceMonitorUOMName
		{
			get { return _viewInvoiceMonitorUOMName; }
			set
			{
				if (value != this._viewInvoiceMonitorUOMName)
				{
					_viewInvoiceMonitorUOMName = value;
					NotifyChanged("ViewInvoiceMonitorUOMName");
				}
			}
		}
		public String ViewInvoiceMonitorCustomerNo
		{
			get { return _viewInvoiceMonitorCustomerNo; }
			set
			{
				if (value != this._viewInvoiceMonitorCustomerNo)
				{
					_viewInvoiceMonitorCustomerNo = value;
					NotifyChanged("ViewInvoiceMonitorCustomerNo");
				}
			}
		}
		public String ViewInvoiceMonitorCustomerName
		{
			get { return _viewInvoiceMonitorCustomerName; }
			set
			{
				if (value != this._viewInvoiceMonitorCustomerName)
				{
					_viewInvoiceMonitorCustomerName = value;
					NotifyChanged("ViewInvoiceMonitorCustomerName");
				}
			}
		}
		public String ViewInvoiceMonitorCustomerBTAddL1
		{
			get { return _viewInvoiceMonitorCustomerBTAddL1; }
			set
			{
				if (value != this._viewInvoiceMonitorCustomerBTAddL1)
				{
					_viewInvoiceMonitorCustomerBTAddL1 = value;
					NotifyChanged("ViewInvoiceMonitorCustomerBTAddL1");
				}
			}
		}
		public String ViewInvoiceMonitorTaxCodeNo
		{
			get { return _viewInvoiceMonitorTaxCodeNo; }
			set
			{
				if (value != this._viewInvoiceMonitorTaxCodeNo)
				{
					_viewInvoiceMonitorTaxCodeNo = value;
					NotifyChanged("ViewInvoiceMonitorTaxCodeNo");
				}
			}
		}
		public String ViewInvoiceMonitorTaxCodeName
		{
			get { return _viewInvoiceMonitorTaxCodeName; }
			set
			{
				if (value != this._viewInvoiceMonitorTaxCodeName)
				{
					_viewInvoiceMonitorTaxCodeName = value;
					NotifyChanged("ViewInvoiceMonitorTaxCodeName");
				}
			}
		}
		public double ViewInvoiceMonitorTaxCodePct
		{
			get { return _viewInvoiceMonitorTaxCodePct; }
			set
			{
				if (value != this._viewInvoiceMonitorTaxCodePct)
				{
					_viewInvoiceMonitorTaxCodePct = value;
					NotifyChanged("ViewInvoiceMonitorTaxCodePct");
				}
			}
		}
		public double ViewInvoiceMonitorUnitPrice
		{
			get { return _viewInvoiceMonitorUnitPrice; }
			set
			{
				if (value != this._viewInvoiceMonitorUnitPrice)
				{
					_viewInvoiceMonitorUnitPrice = value;
					NotifyChanged("ViewInvoiceMonitorUnitPrice");
				}
			}
		}
		public double ViewInvoiceMonitorFUnitPrice
		{
			get { return _viewInvoiceMonitorFUnitPrice; }
			set
			{
				if (value != this._viewInvoiceMonitorFUnitPrice)
				{
					_viewInvoiceMonitorFUnitPrice = value;
					NotifyChanged("ViewInvoiceMonitorFUnitPrice");
				}
			}
		}
		public double ViewInvoiceMonitorPrice
		{
			get { return _viewInvoiceMonitorPrice; }
			set
			{
				if (value != this._viewInvoiceMonitorPrice)
				{
					_viewInvoiceMonitorPrice = value;
					NotifyChanged("ViewInvoiceMonitorPrice");
				}
			}
		}
		public double ViewInvoiceMonitorFPrice
		{
			get { return _viewInvoiceMonitorFPrice; }
			set
			{
				if (value != this._viewInvoiceMonitorFPrice)
				{
					_viewInvoiceMonitorFPrice = value;
					NotifyChanged("ViewInvoiceMonitorFPrice");
				}
			}
		}
		public double ViewInvoiceMonitorAmtTot
		{
			get { return _viewInvoiceMonitorAmtTot; }
			set
			{
				if (value != this._viewInvoiceMonitorAmtTot)
				{
					_viewInvoiceMonitorAmtTot = value;
					NotifyChanged("ViewInvoiceMonitorAmtTot");
				}
			}
		}
		public double ViewInvoiceMonitorFAmtTot
		{
			get { return _viewInvoiceMonitorFAmtTot; }
			set
			{
				if (value != this._viewInvoiceMonitorFAmtTot)
				{
					_viewInvoiceMonitorFAmtTot = value;
					NotifyChanged("ViewInvoiceMonitorFAmtTot");
				}
			}
		}
		public double ViewInvoiceMonitorTxAmt
		{
			get { return _viewInvoiceMonitorTxAmt; }
			set
			{
				if (value != this._viewInvoiceMonitorTxAmt)
				{
					_viewInvoiceMonitorTxAmt = value;
					NotifyChanged("ViewInvoiceMonitorTxAmt");
				}
			}
		}
		public double ViewInvoiceMonitorFTxAmt
		{
			get { return _viewInvoiceMonitorFTxAmt; }
			set
			{
				if (value != this._viewInvoiceMonitorFTxAmt)
				{
					_viewInvoiceMonitorFTxAmt = value;
					NotifyChanged("ViewInvoiceMonitorFTxAmt");
				}
			}
		}
		public String ViewInvoiceMonitorInvNo
		{
			get { return _viewInvoiceMonitorInvNo; }
			set
			{
				if (value != this._viewInvoiceMonitorInvNo)
				{
					_viewInvoiceMonitorInvNo = value;
					NotifyChanged("ViewInvoiceMonitorInvNo");
				}
			}
		}
		public Nullable<DateTime> ViewInvoiceMonitorInvDate
		{
			get { return _viewInvoiceMonitorInvDate; }
			set
			{
				if (value != this._viewInvoiceMonitorInvDate)
				{
					_viewInvoiceMonitorInvDate = value;
					NotifyChanged("ViewInvoiceMonitorInvDate");
				}
			}
		}
		public String ViewInvoiceMonitorInvSerie
		{
			get { return _viewInvoiceMonitorInvSerie; }
			set
			{
				if (value != this._viewInvoiceMonitorInvSerie)
				{
					_viewInvoiceMonitorInvSerie = value;
					NotifyChanged("ViewInvoiceMonitorInvSerie");
				}
			}
		}
		
        #endregion
    }
    #endregion
}