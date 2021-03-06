using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICReceiptPInvoices
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH
    //Class: ICReceiptPInvoicesInfo
    //Created Date: 18 Apr 2015
    //-----------------------------------------------------------

    public class ICReceiptPInvoicesInfo : BusinessObject
    {
        public ICReceiptPInvoicesInfo()
        {
        }
        #region Variables
		protected int _iCReceiptPInvoiceID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_APPInvoiceID;
		protected int _fK_ICReceiptID;
		
        #endregion

        #region Public properties
		public int ICReceiptPInvoiceID
		{
			get{return _iCReceiptPInvoiceID;}
			set
			{
				if (value != this._iCReceiptPInvoiceID)
				{
					_iCReceiptPInvoiceID=value;
					NotifyChanged("ICReceiptPInvoiceID");
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus=value;
					NotifyChanged("AAStatus");
				}
			}
		}
		public int FK_APPInvoiceID
		{
			get{return _fK_APPInvoiceID;}
			set
			{
				if (value != this._fK_APPInvoiceID)
				{
					_fK_APPInvoiceID=value;
					NotifyChanged("FK_APPInvoiceID");
				}
			}
		}
		public int FK_ICReceiptID
		{
			get{return _fK_ICReceiptID;}
			set
			{
				if (value != this._fK_ICReceiptID)
				{
					_fK_ICReceiptID=value;
					NotifyChanged("FK_ICReceiptID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}