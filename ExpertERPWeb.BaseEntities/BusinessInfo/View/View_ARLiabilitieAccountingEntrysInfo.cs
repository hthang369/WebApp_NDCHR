
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region View_ARLiabilitieAccountingEntrys
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.58)
    //Class: View_ARLiabilitieAccountingEntrysInfo
    //Created Date: Thursday, 09 Jun 2016
    //-----------------------------------------------------------

    public class View_ARLiabilitieAccountingEntrysInfo : BusinessObject
    {
        public View_ARLiabilitieAccountingEntrysInfo()
        {
        }
        #region Variables
		protected int _view_ARLiabilitieAccountingEntryID;
		protected String _gLAccountNo = String.Empty;
		protected String _gLAccountName = String.Empty;
		protected String _contraAccNo = String.Empty;
		protected String _contraAccName = String.Empty;
		protected String _balanceDesc = String.Empty;
		protected String _gECurrencyNo = String.Empty;
		protected double _debitAmt;
		protected double _creditAmt;
		protected double _debitFAmt;
		protected double _creditFAmt;
		protected double _arisingDebitAmt;
		protected double _arisingCreditAmt;
		protected double _arisingFDebitAmt;
		protected double _arisingFCreditAmt;
		protected String _dataType = String.Empty;
		
        #endregion

        #region Public properties
		public int View_ARLiabilitieAccountingEntryID
		{
			get { return _view_ARLiabilitieAccountingEntryID; }
			set
			{
				if (value != this._view_ARLiabilitieAccountingEntryID)
				{
					_view_ARLiabilitieAccountingEntryID = value;
					NotifyChanged("View_ARLiabilitieAccountingEntryID");
				}
			}
		}
		public String GLAccountNo
		{
			get { return _gLAccountNo; }
			set
			{
				if (value != this._gLAccountNo)
				{
					_gLAccountNo = value;
					NotifyChanged("GLAccountNo");
				}
			}
		}
		public String GLAccountName
		{
			get { return _gLAccountName; }
			set
			{
				if (value != this._gLAccountName)
				{
					_gLAccountName = value;
					NotifyChanged("GLAccountName");
				}
			}
		}
		public String ContraAccNo
		{
			get { return _contraAccNo; }
			set
			{
				if (value != this._contraAccNo)
				{
					_contraAccNo = value;
					NotifyChanged("ContraAccNo");
				}
			}
		}
		public String ContraAccName
		{
			get { return _contraAccName; }
			set
			{
				if (value != this._contraAccName)
				{
					_contraAccName = value;
					NotifyChanged("ContraAccName");
				}
			}
		}
		public String BalanceDesc
		{
			get { return _balanceDesc; }
			set
			{
				if (value != this._balanceDesc)
				{
					_balanceDesc = value;
					NotifyChanged("BalanceDesc");
				}
			}
		}
		public String GECurrencyNo
		{
			get { return _gECurrencyNo; }
			set
			{
				if (value != this._gECurrencyNo)
				{
					_gECurrencyNo = value;
					NotifyChanged("GECurrencyNo");
				}
			}
		}
		public double DebitAmt
		{
			get { return _debitAmt; }
			set
			{
				if (value != this._debitAmt)
				{
					_debitAmt = value;
					NotifyChanged("DebitAmt");
				}
			}
		}
		public double CreditAmt
		{
			get { return _creditAmt; }
			set
			{
				if (value != this._creditAmt)
				{
					_creditAmt = value;
					NotifyChanged("CreditAmt");
				}
			}
		}
		public double DebitFAmt
		{
			get { return _debitFAmt; }
			set
			{
				if (value != this._debitFAmt)
				{
					_debitFAmt = value;
					NotifyChanged("DebitFAmt");
				}
			}
		}
		public double CreditFAmt
		{
			get { return _creditFAmt; }
			set
			{
				if (value != this._creditFAmt)
				{
					_creditFAmt = value;
					NotifyChanged("CreditFAmt");
				}
			}
		}
		public double ArisingDebitAmt
		{
			get { return _arisingDebitAmt; }
			set
			{
				if (value != this._arisingDebitAmt)
				{
					_arisingDebitAmt = value;
					NotifyChanged("ArisingDebitAmt");
				}
			}
		}
		public double ArisingCreditAmt
		{
			get { return _arisingCreditAmt; }
			set
			{
				if (value != this._arisingCreditAmt)
				{
					_arisingCreditAmt = value;
					NotifyChanged("ArisingCreditAmt");
				}
			}
		}
		public double ArisingFDebitAmt
		{
			get { return _arisingFDebitAmt; }
			set
			{
				if (value != this._arisingFDebitAmt)
				{
					_arisingFDebitAmt = value;
					NotifyChanged("ArisingFDebitAmt");
				}
			}
		}
		public double ArisingFCreditAmt
		{
			get { return _arisingFCreditAmt; }
			set
			{
				if (value != this._arisingFCreditAmt)
				{
					_arisingFCreditAmt = value;
					NotifyChanged("ArisingFCreditAmt");
				}
			}
		}
		public String DataType
		{
			get { return _dataType; }
			set
			{
				if (value != this._dataType)
				{
					_dataType = value;
					NotifyChanged("DataType");
				}
			}
		}
		
        #endregion
    }
    #endregion
}