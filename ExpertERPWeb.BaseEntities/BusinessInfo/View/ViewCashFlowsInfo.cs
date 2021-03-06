using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewCashFlows
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ViewCashFlowsInfo
    //Created Date:27 April 2013
    //-----------------------------------------------------------

    public class ViewCashFlowsInfo : BusinessObject
    {
        public ViewCashFlowsInfo()
        {
        }
        #region Variables
        protected double _startAmt;
        protected double _inAmt;
        protected double _outAmt;
        protected double _endAmt;
        protected DateTime _fromDate = DateTime.Now;
        protected DateTime _toDate = DateTime.Now;
        protected int _viewCashFlowID;
        protected double _pmtReqAmt;
        protected double _endByPmtReqAmt;
        protected String _aAViewByTypeCombo = String.Empty;
        protected int _year;
        protected int _period;
        protected int _weekCount;
        protected double _sOAmt;
        protected double _aRShpPlanAmt;
        protected double _invoiceAmt;
        protected double _pOAmt;
        protected double _pInvoiceAmt;
        protected double _voucherAmt;
        protected double _fixCostAmt;
        protected double _variableCostAmt;
        #endregion

        #region Public properties
        public double StartAmt
        {
            get { return _startAmt; }
            set
            {
                if (value != this._startAmt)
                {
                    _startAmt = value;
                    NotifyChanged("StartAmt");
                }
            }
        }
        public double InAmt
        {
            get { return _inAmt; }
            set
            {
                if (value != this._inAmt)
                {
                    _inAmt = value;
                    NotifyChanged("InAmt");
                }
            }
        }
        public double OutAmt
        {
            get { return _outAmt; }
            set
            {
                if (value != this._outAmt)
                {
                    _outAmt = value;
                    NotifyChanged("OutAmt");
                }
            }
        }
        public double EndAmt
        {
            get { return _endAmt; }
            set
            {
                if (value != this._endAmt)
                {
                    _endAmt = value;
                    NotifyChanged("EndAmt");
                }
            }
        }
        public DateTime FromDate
        {
            get { return _fromDate; }
            set
            {
                if (value != this._fromDate)
                {
                    _fromDate = value;
                    NotifyChanged("FromDate");
                }
            }
        }
        public DateTime ToDate
        {
            get { return _toDate; }
            set
            {
                if (value != this._toDate)
                {
                    _toDate = value;
                    NotifyChanged("ToDate");
                }
            }
        }
        public int ViewCashFlowID
        {
            get { return _viewCashFlowID; }
            set
            {
                if (value != this._viewCashFlowID)
                {
                    _viewCashFlowID = value;
                    NotifyChanged("ViewCashFlowID");
                }
            }
        }
        public double PmtReqAmt
        {
            get { return _pmtReqAmt; }
            set
            {
                if (value != this._pmtReqAmt)
                {
                    _pmtReqAmt = value;
                    NotifyChanged("PmtReqAmt");
                }
            }
        }
        public double EndByPmtReqAmt
        {
            get { return _endByPmtReqAmt; }
            set
            {
                if (value != this._endByPmtReqAmt)
                {
                    _endByPmtReqAmt = value;
                    NotifyChanged("EndByPmtReqAmt");
                }
            }
        }
        public String AAViewByTypeCombo
        {
            get { return _aAViewByTypeCombo; }
            set
            {
                if (value != this._aAViewByTypeCombo)
                {
                    _aAViewByTypeCombo = value;
                    NotifyChanged("AAViewByTypeCombo");
                }
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value != this._year)
                {
                    _year = value;
                    NotifyChanged("Year");
                }
            }
        }
        public int Period
        {
            get { return _period; }
            set
            {
                if (value != this._period)
                {
                    _period = value;
                    NotifyChanged("Period");
                }
            }
        }
        public int WeekCount
        {
            get { return _weekCount; }
            set
            {
                if (value != this._weekCount)
                {
                    _weekCount = value;
                    NotifyChanged("WeekCount");
                }
            }
        }
        public double SOAmt
        {
            get { return _sOAmt; }
            set
            {
                if (value != this._sOAmt)
                {
                    _sOAmt = value;
                    NotifyChanged("SOAmt");
                }
            }
        }
        public double ARShpPlanAmt
        {
            get { return _aRShpPlanAmt; }
            set
            {
                if (value != this._aRShpPlanAmt)
                {
                    _aRShpPlanAmt = value;
                    NotifyChanged("ARShpPlanAmt");
                }
            }
        }
        public double InvoiceAmt
        {
            get { return _invoiceAmt; }
            set
            {
                if (value != this._invoiceAmt)
                {
                    _invoiceAmt = value;
                    NotifyChanged("InvoiceAmt");
                }
            }
        }
        public double POAmt
        {
            get { return _pOAmt; }
            set
            {
                if (value != this._pOAmt)
                {
                    _pOAmt = value;
                    NotifyChanged("POAmt");
                }
            }
        }
        public double PInvoiceAmt
        {
            get { return _pInvoiceAmt; }
            set
            {
                if (value != this._pInvoiceAmt)
                {
                    _pInvoiceAmt = value;
                    NotifyChanged("PInvoiceAmt");
                }
            }
        }
        public double VoucherAmt
        {
            get { return _voucherAmt; }
            set
            {
                if (value != this._voucherAmt)
                {
                    _voucherAmt = value;
                    NotifyChanged("VoucherAmt");
                }
            }
        }
        public double FixCostAmt
        {
            get { return _fixCostAmt; }
            set
            {
                if (value != this._fixCostAmt)
                {
                    _fixCostAmt = value;
                    NotifyChanged("FixCostAmt");
                }
            }
        }
        public double VariableCostAmt
        {
            get { return _variableCostAmt; }
            set
            {
                if (value != this._variableCostAmt)
                {
                    _variableCostAmt = value;
                    NotifyChanged("VariableCostAmt");
                }
            }
        }
        #endregion
    }
    #endregion
}