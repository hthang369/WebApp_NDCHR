
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewPOMonitors
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.63)
    //Class: ViewPOMonitorsInfo
    //Created Date: Monday, 11 Jul 2016
    //-----------------------------------------------------------

    public class ViewPOMonitorsInfo : BusinessObject
    {
        public ViewPOMonitorsInfo()
        {
        }
        #region Variables
        protected int _viewPOMonitorID;
        protected int _fK_APPOID;
        protected int _fK_APSupplierID;
        protected int _fK_APPOItemID;
        protected int _fK_ICProductID;
        protected double _viewPOMonitorQty;
        protected double _viewPOMonitorRQty;
        protected double _viewPOMonitorQty1;
        protected double _viewPOMonitorQty2;
        protected double _viewPOMonitorQty4;
        protected double _viewPOMonitorRcpPct;
        protected Nullable<DateTime> _viewPOMonitorArrivalDate;
        protected Nullable<DateTime> _viewPOMonitorLastDate;
        protected String _viewPOMonitorSerialNo = String.Empty;
        protected Nullable<DateTime> _viewPOMonitorSerialDate;
        protected double _viewPOMonitorReceiptQty;
        protected double _viewPOMonitorPInvoiceQty;
        protected double _viewPOMonitorPurchaseReturnQty;
        protected double _viewPOMonitorShipmentQty;
        protected double _viewPOMonitorCreditNoteQty;
        protected int _fK_ICUOMID;
        protected int _fK_HRDepartmentID;
        protected double _viewPOMonitorReceiptRQty;
        protected double _viewPOMonitorPInvoiceRQty;
        protected String _viewPOMonitorComment = String.Empty;
        protected String _viewPOMonitorStatus = DefaultStatus;
        protected int _fK_APPRID;

        #endregion

        #region Public properties
        public int ViewPOMonitorID
        {
            get { return _viewPOMonitorID; }
            set
            {
                if (value != this._viewPOMonitorID)
                {
                    _viewPOMonitorID = value;
                    NotifyChanged("ViewPOMonitorID");
                }
            }
        }
        public int FK_APPOID
        {
            get { return _fK_APPOID; }
            set
            {
                if (value != this._fK_APPOID)
                {
                    _fK_APPOID = value;
                    NotifyChanged("FK_APPOID");
                }
            }
        }
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                    NotifyChanged("FK_APSupplierID");
                }
            }
        }
        public int FK_APPOItemID
        {
            get { return _fK_APPOItemID; }
            set
            {
                if (value != this._fK_APPOItemID)
                {
                    _fK_APPOItemID = value;
                    NotifyChanged("FK_APPOItemID");
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
        public double ViewPOMonitorQty
        {
            get { return _viewPOMonitorQty; }
            set
            {
                if (value != this._viewPOMonitorQty)
                {
                    _viewPOMonitorQty = value;
                    NotifyChanged("ViewPOMonitorQty");
                }
            }
        }
        public double ViewPOMonitorRQty
        {
            get { return _viewPOMonitorRQty; }
            set
            {
                if (value != this._viewPOMonitorRQty)
                {
                    _viewPOMonitorRQty = value;
                    NotifyChanged("ViewPOMonitorRQty");
                }
            }
        }
        public double ViewPOMonitorQty1
        {
            get { return _viewPOMonitorQty1; }
            set
            {
                if (value != this._viewPOMonitorQty1)
                {
                    _viewPOMonitorQty1 = value;
                    NotifyChanged("ViewPOMonitorQty1");
                }
            }
        }
        public double ViewPOMonitorQty2
        {
            get { return _viewPOMonitorQty2; }
            set
            {
                if (value != this._viewPOMonitorQty2)
                {
                    _viewPOMonitorQty2 = value;
                    NotifyChanged("ViewPOMonitorQty2");
                }
            }
        }
        public double ViewPOMonitorQty4
        {
            get { return _viewPOMonitorQty4; }
            set
            {
                if (value != this._viewPOMonitorQty4)
                {
                    _viewPOMonitorQty4 = value;
                    NotifyChanged("ViewPOMonitorQty4");
                }
            }
        }
        public double ViewPOMonitorRcpPct
        {
            get { return _viewPOMonitorRcpPct; }
            set
            {
                if (value != this._viewPOMonitorRcpPct)
                {
                    _viewPOMonitorRcpPct = value;
                    NotifyChanged("ViewPOMonitorRcpPct");
                }
            }
        }
        public Nullable<DateTime> ViewPOMonitorArrivalDate
        {
            get { return _viewPOMonitorArrivalDate; }
            set
            {
                if (value != this._viewPOMonitorArrivalDate)
                {
                    _viewPOMonitorArrivalDate = value;
                    NotifyChanged("ViewPOMonitorArrivalDate");
                }
            }
        }
        public Nullable<DateTime> ViewPOMonitorLastDate
        {
            get { return _viewPOMonitorLastDate; }
            set
            {
                if (value != this._viewPOMonitorLastDate)
                {
                    _viewPOMonitorLastDate = value;
                    NotifyChanged("ViewPOMonitorLastDate");
                }
            }
        }
        public String ViewPOMonitorSerialNo
        {
            get { return _viewPOMonitorSerialNo; }
            set
            {
                if (value != this._viewPOMonitorSerialNo)
                {
                    _viewPOMonitorSerialNo = value;
                    NotifyChanged("ViewPOMonitorSerialNo");
                }
            }
        }
        public Nullable<DateTime> ViewPOMonitorSerialDate
        {
            get { return _viewPOMonitorSerialDate; }
            set
            {
                if (value != this._viewPOMonitorSerialDate)
                {
                    _viewPOMonitorSerialDate = value;
                    NotifyChanged("ViewPOMonitorSerialDate");
                }
            }
        }
        public double ViewPOMonitorReceiptQty
        {
            get { return _viewPOMonitorReceiptQty; }
            set
            {
                if (value != this._viewPOMonitorReceiptQty)
                {
                    _viewPOMonitorReceiptQty = value;
                    NotifyChanged("ViewPOMonitorReceiptQty");
                }
            }
        }
        public double ViewPOMonitorPInvoiceQty
        {
            get { return _viewPOMonitorPInvoiceQty; }
            set
            {
                if (value != this._viewPOMonitorPInvoiceQty)
                {
                    _viewPOMonitorPInvoiceQty = value;
                    NotifyChanged("ViewPOMonitorPInvoiceQty");
                }
            }
        }
        public double ViewPOMonitorPurchaseReturnQty
        {
            get { return _viewPOMonitorPurchaseReturnQty; }
            set
            {
                if (value != this._viewPOMonitorPurchaseReturnQty)
                {
                    _viewPOMonitorPurchaseReturnQty = value;
                    NotifyChanged("ViewPOMonitorPurchaseReturnQty");
                }
            }
        }
        public double ViewPOMonitorShipmentQty
        {
            get { return _viewPOMonitorShipmentQty; }
            set
            {
                if (value != this._viewPOMonitorShipmentQty)
                {
                    _viewPOMonitorShipmentQty = value;
                    NotifyChanged("ViewPOMonitorShipmentQty");
                }
            }
        }
        public double ViewPOMonitorCreditNoteQty
        {
            get { return _viewPOMonitorCreditNoteQty; }
            set
            {
                if (value != this._viewPOMonitorCreditNoteQty)
                {
                    _viewPOMonitorCreditNoteQty = value;
                    NotifyChanged("ViewPOMonitorCreditNoteQty");
                }
            }
        }
        public int FK_ICUOMID
        {
            get { return _fK_ICUOMID; }
            set
            {
                if (value != this._fK_ICUOMID)
                {
                    _fK_ICUOMID = value;
                    NotifyChanged("FK_ICUOMID");
                }
            }
        }
        public int FK_HRDepartmentID
        {
            get { return _fK_HRDepartmentID; }
            set
            {
                if (value != this._fK_HRDepartmentID)
                {
                    _fK_HRDepartmentID = value;
                    NotifyChanged("FK_HRDepartmentID");
                }
            }
        }
        public double ViewPOMonitorReceiptRQty
        {
            get { return _viewPOMonitorReceiptRQty; }
            set
            {
                if (value != this._viewPOMonitorReceiptRQty)
                {
                    _viewPOMonitorReceiptRQty = value;
                    NotifyChanged("ViewPOMonitorReceiptRQty");
                }
            }
        }
        public double ViewPOMonitorPInvoiceRQty
        {
            get { return _viewPOMonitorPInvoiceRQty; }
            set
            {
                if (value != this._viewPOMonitorPInvoiceRQty)
                {
                    _viewPOMonitorPInvoiceRQty = value;
                    NotifyChanged("ViewPOMonitorPInvoiceRQty");
                }
            }
        }
        public String ViewPOMonitorComment
        {
            get { return _viewPOMonitorComment; }
            set
            {
                if (value != this._viewPOMonitorComment)
                {
                    _viewPOMonitorComment = value;
                    NotifyChanged("ViewPOMonitorComment");
                }
            }
        }
        public String ViewPOMonitorStatus
        {
            get { return _viewPOMonitorStatus; }
            set
            {
                if (value != this._viewPOMonitorStatus)
                {
                    _viewPOMonitorStatus = value;
                    NotifyChanged("ViewPOMonitorStatus");
                }
            }
        }
        public int FK_APPRID
        {
            get { return _fK_APPRID; }
            set
            {
                if (value != this._fK_APPRID)
                {
                    _fK_APPRID = value;
                    NotifyChanged("FK_APPRID");
                }
            }
        }

        #endregion
    }
    #endregion
}