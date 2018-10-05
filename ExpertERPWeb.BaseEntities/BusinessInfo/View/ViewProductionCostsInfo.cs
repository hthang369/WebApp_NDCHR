using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewProductionCosts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewProductionCostsInfo
	//Created Date:13 May 2013
	//-----------------------------------------------------------
	
	public class ViewProductionCostsInfo:BusinessObject
	{
		public ViewProductionCostsInfo()
		{
		}
		#region Variables
		protected int _viewProductionCostID;
		protected int _fK_ICProductID;
		protected int _fK_ICProductGroupID;
		protected int _fK_ICProductColorSchemaID;
		protected int _fK_ICStockID;
		protected Nullable<DateTime> _viewProductionCostFromDate;
		protected Nullable<DateTime> _viewProductionCostToDate;
		protected double _viewProductionCostRcpQty;
		protected double _viewProductionCostRcpAmtTot;
		protected double _viewProductionCostRcpRMAmtTot;
		protected double _viewProductionCostRcpInDirectAmtTot;
		protected double _viewProductionCostShpQty;
		protected double _viewProductionCostShpUnitPrice;
		protected double _viewProductionCostRMUnitPrice;
		protected double _viewProductionCostShpAmtTot;
		#endregion

		#region Public properties
		public int ViewProductionCostID
		{
			get{return _viewProductionCostID;}
			set
			{
				if (value != this._viewProductionCostID)
				{
				_viewProductionCostID=value;
				NotifyChanged("ViewProductionCostID");
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
		public int FK_ICProductGroupID
		{
			get{return _fK_ICProductGroupID;}
			set
			{
				if (value != this._fK_ICProductGroupID)
				{
				_fK_ICProductGroupID=value;
				NotifyChanged("FK_ICProductGroupID");
				}
			}
		}
		public int FK_ICProductColorSchemaID
		{
			get{return _fK_ICProductColorSchemaID;}
			set
			{
				if (value != this._fK_ICProductColorSchemaID)
				{
				_fK_ICProductColorSchemaID=value;
				NotifyChanged("FK_ICProductColorSchemaID");
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
		public Nullable<DateTime> ViewProductionCostFromDate
		{
			get{return _viewProductionCostFromDate;}
			set
			{
				if (value != this._viewProductionCostFromDate)
				{
				_viewProductionCostFromDate=value;
				NotifyChanged("ViewProductionCostFromDate");
				}
			}
		}
		public Nullable<DateTime> ViewProductionCostToDate
		{
			get{return _viewProductionCostToDate;}
			set
			{
				if (value != this._viewProductionCostToDate)
				{
				_viewProductionCostToDate=value;
				NotifyChanged("ViewProductionCostToDate");
				}
			}
		}
		public double ViewProductionCostRcpQty
		{
			get{return _viewProductionCostRcpQty;}
			set
			{
				if (value != this._viewProductionCostRcpQty)
				{
				_viewProductionCostRcpQty=value;
				NotifyChanged("ViewProductionCostRcpQty");
				}
			}
		}
		public double ViewProductionCostRcpAmtTot
		{
			get{return _viewProductionCostRcpAmtTot;}
			set
			{
				if (value != this._viewProductionCostRcpAmtTot)
				{
				_viewProductionCostRcpAmtTot=value;
				NotifyChanged("ViewProductionCostRcpAmtTot");
				}
			}
		}
		public double ViewProductionCostRcpRMAmtTot
		{
			get{return _viewProductionCostRcpRMAmtTot;}
			set
			{
				if (value != this._viewProductionCostRcpRMAmtTot)
				{
				_viewProductionCostRcpRMAmtTot=value;
				NotifyChanged("ViewProductionCostRcpRMAmtTot");
				}
			}
		}
		public double ViewProductionCostRcpInDirectAmtTot
		{
			get{return _viewProductionCostRcpInDirectAmtTot;}
			set
			{
				if (value != this._viewProductionCostRcpInDirectAmtTot)
				{
				_viewProductionCostRcpInDirectAmtTot=value;
				NotifyChanged("ViewProductionCostRcpInDirectAmtTot");
				}
			}
		}
		public double ViewProductionCostShpQty
		{
			get{return _viewProductionCostShpQty;}
			set
			{
				if (value != this._viewProductionCostShpQty)
				{
				_viewProductionCostShpQty=value;
				NotifyChanged("ViewProductionCostShpQty");
				}
			}
		}
		public double ViewProductionCostShpUnitPrice
		{
			get{return _viewProductionCostShpUnitPrice;}
			set
			{
				if (value != this._viewProductionCostShpUnitPrice)
				{
				_viewProductionCostShpUnitPrice=value;
				NotifyChanged("ViewProductionCostShpUnitPrice");
				}
			}
		}
		public double ViewProductionCostRMUnitPrice
		{
			get{return _viewProductionCostRMUnitPrice;}
			set
			{
				if (value != this._viewProductionCostRMUnitPrice)
				{
				_viewProductionCostRMUnitPrice=value;
				NotifyChanged("ViewProductionCostRMUnitPrice");
				}
			}
		}
		public double ViewProductionCostShpAmtTot
		{
			get{return _viewProductionCostShpAmtTot;}
			set
			{
				if (value != this._viewProductionCostShpAmtTot)
				{
				_viewProductionCostShpAmtTot=value;
				NotifyChanged("ViewProductionCostShpAmtTot");
				}
			}
		}
		#endregion
	}
	#endregion
}