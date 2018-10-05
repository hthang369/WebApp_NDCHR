using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewChartPurchaseAnalysisStatistics
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewChartPurchaseAnalysisStatisticsInfo
	//Created Date:17 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class ViewChartPurchaseAnalysisStatisticsInfo:BusinessObject
	{
		public ViewChartPurchaseAnalysisStatisticsInfo()
		{
		}
		#region Variables
		protected int _viewChartPurchaseAnalysisStatisticID;
		protected String _viewChartPurchaseAnalysisStatisticNo=String.Empty;
		protected String _viewChartPurchaseAnalysisStatisticName=String.Empty;
		protected String _viewChartPurchaseAnalysisStatisticSupplierGroup=String.Empty;
        protected String _viewChartPurchaseAnalysisStatisticAnnualTotal;
		protected String _viewChartPurchaseAnalysisStatisticTime=String.Empty;
		protected double _viewChartPurchaseAnalysisStatisticRevenues;
		protected double _viewChartPurchaseAnalysisStatisticProfit;
		protected int _viewChartPurchaseAnalysisStatisticYear;
		protected String _viewChartPurchaseAnalysisStatisticKey=String.Empty;
		#endregion

		#region Public properties
		public int ViewChartPurchaseAnalysisStatisticID
		{
			get{return _viewChartPurchaseAnalysisStatisticID;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticID)
				{
				_viewChartPurchaseAnalysisStatisticID=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticID");
				}
			}
		}
		public String ViewChartPurchaseAnalysisStatisticNo
		{
			get{return _viewChartPurchaseAnalysisStatisticNo;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticNo)
				{
				_viewChartPurchaseAnalysisStatisticNo=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticNo");
				}
			}
		}
		public String ViewChartPurchaseAnalysisStatisticName
		{
			get{return _viewChartPurchaseAnalysisStatisticName;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticName)
				{
				_viewChartPurchaseAnalysisStatisticName=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticName");
				}
			}
		}
		public String ViewChartPurchaseAnalysisStatisticSupplierGroup
		{
			get{return _viewChartPurchaseAnalysisStatisticSupplierGroup;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticSupplierGroup)
				{
				_viewChartPurchaseAnalysisStatisticSupplierGroup=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticSupplierGroup");
				}
			}
		}
        public String ViewChartPurchaseAnalysisStatisticAnnualTotal
        {
            get { return _viewChartPurchaseAnalysisStatisticAnnualTotal; }
            set
            {
                if (value != this._viewChartPurchaseAnalysisStatisticAnnualTotal)
                {
                    _viewChartPurchaseAnalysisStatisticAnnualTotal = value;
                    NotifyChanged("ViewChartPurchaseAnalysisStatisticAnnualTotal");
                }
            }
        }
		public String ViewChartPurchaseAnalysisStatisticTime
		{
			get{return _viewChartPurchaseAnalysisStatisticTime;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticTime)
				{
				_viewChartPurchaseAnalysisStatisticTime=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticTime");
				}
			}
		}
		public double ViewChartPurchaseAnalysisStatisticRevenues
		{
			get{return _viewChartPurchaseAnalysisStatisticRevenues;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticRevenues)
				{
				_viewChartPurchaseAnalysisStatisticRevenues=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticRevenues");
				}
			}
		}
		public double ViewChartPurchaseAnalysisStatisticProfit
		{
			get{return _viewChartPurchaseAnalysisStatisticProfit;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticProfit)
				{
				_viewChartPurchaseAnalysisStatisticProfit=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticProfit");
				}
			}
		}
		public int ViewChartPurchaseAnalysisStatisticYear
		{
			get{return _viewChartPurchaseAnalysisStatisticYear;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticYear)
				{
				_viewChartPurchaseAnalysisStatisticYear=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticYear");
				}
			}
		}
		public String ViewChartPurchaseAnalysisStatisticKey
		{
			get{return _viewChartPurchaseAnalysisStatisticKey;}
			set
			{
				if (value != this._viewChartPurchaseAnalysisStatisticKey)
				{
				_viewChartPurchaseAnalysisStatisticKey=value;
				NotifyChanged("ViewChartPurchaseAnalysisStatisticKey");
				}
			}
		}
		#endregion
	}
	#endregion
}