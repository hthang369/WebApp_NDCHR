using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region APSupBals
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:APSupBalsInfo
    //Created Date:Th�� Sa�u, Tha�ng T� 20, 2012
    //-----------------------------------------------------------

    public class APSupBalsInfo : BusinessObject
    {
        public APSupBalsInfo()
        {
        }
        #region Variables
        protected int _aPSupBalID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _aPSupBalYear;
        protected int _aPSupBalPeriod;
        protected int _fK_APSupplierID;
        protected double _aPSupBalCreditLimit;
        protected double _aPSupBalBegin;
        protected double _aPSupBalEnd;
        protected double _aPSupBalOutStand;
        protected double _aPSupBalSupPmtAmt;
        protected double _aPSupBalPOAmt;
        protected double _aPSupBalReceiptAmt;
        protected double _aPSupBalPInvoiceAmt;
        protected String _aPSupBalCalcType = String.Empty;
        protected int _aPSupBalOpenPInvCount;
        protected int _aPSupBalPeriodOpenPInvCount;
        protected int _aPSupBalOpenPOCount;
        protected int _aPSupBalPeriodOpenPOCount;
        protected double _aPSupBalDebitNoteAmt;
        #endregion

        #region Public properties
        public int APSupBalID
        {
            get { return _aPSupBalID; }
            set
            {
                if (value != this._aPSupBalID)
                {
                    _aPSupBalID = value;
                    NotifyChanged("APSupBalID");
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if (value != this._aAStatus)
                {
                    _aAStatus = value;
                    NotifyChanged("AAStatus");
                }
            }
        }
        public int APSupBalYear
        {
            get { return _aPSupBalYear; }
            set
            {
                if (value != this._aPSupBalYear)
                {
                    _aPSupBalYear = value;
                    NotifyChanged("APSupBalYear");
                }
            }
        }
        public int APSupBalPeriod
        {
            get { return _aPSupBalPeriod; }
            set
            {
                if (value != this._aPSupBalPeriod)
                {
                    _aPSupBalPeriod = value;
                    NotifyChanged("APSupBalPeriod");
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
        public double APSupBalCreditLimit
        {
            get { return _aPSupBalCreditLimit; }
            set
            {
                if (value != this._aPSupBalCreditLimit)
                {
                    _aPSupBalCreditLimit = value;
                    NotifyChanged("APSupBalCreditLimit");
                }
            }
        }
        public double APSupBalBegin
        {
            get { return _aPSupBalBegin; }
            set
            {
                if (value != this._aPSupBalBegin)
                {
                    _aPSupBalBegin = value;
                    NotifyChanged("APSupBalBegin");
                }
            }
        }
        public double APSupBalEnd
        {
            get { return _aPSupBalEnd; }
            set
            {
                if (value != this._aPSupBalEnd)
                {
                    _aPSupBalEnd = value;
                    NotifyChanged("APSupBalEnd");
                }
            }
        }
        public double APSupBalOutStand
        {
            get { return _aPSupBalOutStand; }
            set
            {
                if (value != this._aPSupBalOutStand)
                {
                    _aPSupBalOutStand = value;
                    NotifyChanged("APSupBalOutStand");
                }
            }
        }
        public double APSupBalSupPmtAmt
        {
            get { return _aPSupBalSupPmtAmt; }
            set
            {
                if (value != this._aPSupBalSupPmtAmt)
                {
                    _aPSupBalSupPmtAmt = value;
                    NotifyChanged("APSupBalSupPmtAmt");
                }
            }
        }
        public double APSupBalPOAmt
        {
            get { return _aPSupBalPOAmt; }
            set
            {
                if (value != this._aPSupBalPOAmt)
                {
                    _aPSupBalPOAmt = value;
                    NotifyChanged("APSupBalPOAmt");
                }
            }
        }
        public double APSupBalReceiptAmt
        {
            get { return _aPSupBalReceiptAmt; }
            set
            {
                if (value != this._aPSupBalReceiptAmt)
                {
                    _aPSupBalReceiptAmt = value;
                    NotifyChanged("APSupBalReceiptAmt");
                }
            }
        }
        public double APSupBalPInvoiceAmt
        {
            get { return _aPSupBalPInvoiceAmt; }
            set
            {
                if (value != this._aPSupBalPInvoiceAmt)
                {
                    _aPSupBalPInvoiceAmt = value;
                    NotifyChanged("APSupBalPInvoiceAmt");
                }
            }
        }
        public String APSupBalCalcType
        {
            get { return _aPSupBalCalcType; }
            set
            {
                if (value != this._aPSupBalCalcType)
                {
                    _aPSupBalCalcType = value;
                    NotifyChanged("APSupBalCalcType");
                }
            }
        }
        public int APSupBalOpenPInvCount
        {
            get { return _aPSupBalOpenPInvCount; }
            set
            {
                if (value != this._aPSupBalOpenPInvCount)
                {
                    _aPSupBalOpenPInvCount = value;
                    NotifyChanged("APSupBalOpenPInvCount");
                }
            }
        }
        public int APSupBalPeriodOpenPInvCount
        {
            get { return _aPSupBalPeriodOpenPInvCount; }
            set
            {
                if (value != this._aPSupBalPeriodOpenPInvCount)
                {
                    _aPSupBalPeriodOpenPInvCount = value;
                    NotifyChanged("APSupBalPeriodOpenPInvCount");
                }
            }
        }
        public int APSupBalOpenPOCount
        {
            get { return _aPSupBalOpenPOCount; }
            set
            {
                if (value != this._aPSupBalOpenPOCount)
                {
                    _aPSupBalOpenPOCount = value;
                    NotifyChanged("APSupBalOpenPOCount");
                }
            }
        }
        public int APSupBalPeriodOpenPOCount
        {
            get { return _aPSupBalPeriodOpenPOCount; }
            set
            {
                if (value != this._aPSupBalPeriodOpenPOCount)
                {
                    _aPSupBalPeriodOpenPOCount = value;
                    NotifyChanged("APSupBalPeriodOpenPOCount");
                }
            }
        }
        public double APSupBalDebitNoteAmt
        {
            get { return _aPSupBalDebitNoteAmt; }
            set
            {
                if (value != this._aPSupBalDebitNoteAmt)
                {
                    _aPSupBalDebitNoteAmt = value;
                    NotifyChanged("APSupBalDebitNoteAmt");
                }
            }
        }
        #endregion
    }
    #endregion
}