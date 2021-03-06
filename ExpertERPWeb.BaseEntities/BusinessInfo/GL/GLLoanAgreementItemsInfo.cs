using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLLoanAgreementItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.12)
    //Class: GLLoanAgreementItemsInfo
    //Created Date: 30 Jan 2009
    //-----------------------------------------------------------

    public class GLLoanAgreementItemsInfo : BusinessObject
    {
        public GLLoanAgreementItemsInfo()
        {
        }
        #region Variables
		protected int _gLLoanAgreementItemID;
		protected int _fK_ARInvoiceID;
		protected int _fK_GLLoanAgreementID;
		protected String _aAStatus=DefaultAAStatus;
		
        #endregion

        #region Public properties
		public int GLLoanAgreementItemID
		{
			get{return _gLLoanAgreementItemID;}
			set
			{
				if (value != this._gLLoanAgreementItemID)
				{
					_gLLoanAgreementItemID=value;
					NotifyChanged("GLLoanAgreementItemID");
				}
			}
		}
		public int FK_ARInvoiceID
		{
			get{return _fK_ARInvoiceID;}
			set
			{
				if (value != this._fK_ARInvoiceID)
				{
					_fK_ARInvoiceID=value;
					NotifyChanged("FK_ARInvoiceID");
				}
			}
		}
		public int FK_GLLoanAgreementID
		{
			get{return _fK_GLLoanAgreementID;}
			set
			{
				if (value != this._fK_GLLoanAgreementID)
				{
					_fK_GLLoanAgreementID=value;
					NotifyChanged("FK_GLLoanAgreementID");
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
		
        #endregion
    }
    #endregion
}