
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region APCreditNoteItemPInvoiceItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.72)
    //Class: APCreditNoteItemPInvoiceItemsInfo
    //Created Date: Tuesday, 06 Sep 2016
    //-----------------------------------------------------------

    public class APCreditNoteItemPInvoiceItemsInfo : BusinessObject
    {
        public APCreditNoteItemPInvoiceItemsInfo()
        {
        }
        #region Variables
        protected int _aPCreditNoteItemPInvoiceItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APCreditNoteItemID;
        protected int _fK_APPInvoiceItemID;

        #endregion

        #region Public properties
        public int APCreditNoteItemPInvoiceItemID
        {
            get { return _aPCreditNoteItemPInvoiceItemID; }
            set
            {
                if (value != this._aPCreditNoteItemPInvoiceItemID)
                {
                    _aPCreditNoteItemPInvoiceItemID = value;
                    NotifyChanged("APCreditNoteItemPInvoiceItemID");
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
        public int FK_APCreditNoteItemID
        {
            get { return _fK_APCreditNoteItemID; }
            set
            {
                if (value != this._fK_APCreditNoteItemID)
                {
                    _fK_APCreditNoteItemID = value;
                    NotifyChanged("FK_APCreditNoteItemID");
                }
            }
        }
        public int FK_APPInvoiceItemID
        {
            get { return _fK_APPInvoiceItemID; }
            set
            {
                if (value != this._fK_APPInvoiceItemID)
                {
                    _fK_APPInvoiceItemID = value;
                    NotifyChanged("FK_APPInvoiceItemID");
                }
            }
        }

        #endregion
    }
    #endregion
}