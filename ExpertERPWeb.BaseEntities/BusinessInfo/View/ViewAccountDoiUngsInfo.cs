using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewAccountDoiUngs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class: ViewAccountDoiUngsInfo
    //Created Date: 12 Mar 2015
    //-----------------------------------------------------------

    public class ViewAccountDoiUngsInfo : BusinessObject
    {
        public ViewAccountDoiUngsInfo()
        {
        }
        #region Variables
		protected int _viewAccountDoiUngID;
		protected int _accountID;
		protected String _accountNo=String.Empty;
		protected String _accountDoiUngName=String.Empty;
		protected double _debitAmt;
		protected double _debitFAmt;
		protected double _creditAmt;
		protected double _creditFAmt;
		protected Nullable<DateTime> _journalDate;
		protected String _documentNo=String.Empty;
		protected String _sourceLedger=String.Empty;
		protected String _accountDoiUngNo=String.Empty;
		protected int _fK_GECurrencyID;
		protected double _excRate;
		protected String _journalDesc=String.Empty;
		protected String _journalHDesc=String.Empty;
		protected double _beginDebitAmt;
		protected double _beginDebitFAmt;
		protected double _beginCreditAmt;
		protected double _beginCreditFAmt;
		protected double _endDebitAmt;
		protected double _endDebitFAmt;
		protected double _endCreditAmt;
		protected double _endCreditFAmt;
		protected int _fK_ICProductID;
		protected Nullable<DateTime> _journalDocDate;
		
        #endregion

        #region Public properties
		public int ViewAccountDoiUngID
		{
			get{return _viewAccountDoiUngID;}
			set
			{
				if (value != this._viewAccountDoiUngID)
				{
					_viewAccountDoiUngID=value;
					NotifyChanged("ViewAccountDoiUngID");
				}
			}
		}
		public int AccountID
		{
			get{return _accountID;}
			set
			{
				if (value != this._accountID)
				{
					_accountID=value;
					NotifyChanged("AccountID");
				}
			}
		}
		public String AccountNo
		{
			get{return _accountNo;}
			set
			{
				if (value != this._accountNo)
				{
					_accountNo=value;
					NotifyChanged("AccountNo");
				}
			}
		}
		public String AccountDoiUngName
		{
			get{return _accountDoiUngName;}
			set
			{
				if (value != this._accountDoiUngName)
				{
					_accountDoiUngName=value;
					NotifyChanged("AccountDoiUngName");
				}
			}
		}
		public double DebitAmt
		{
			get{return _debitAmt;}
			set
			{
				if (value != this._debitAmt)
				{
					_debitAmt=value;
					NotifyChanged("DebitAmt");
				}
			}
		}
		public double DebitFAmt
		{
			get{return _debitFAmt;}
			set
			{
				if (value != this._debitFAmt)
				{
					_debitFAmt=value;
					NotifyChanged("DebitFAmt");
				}
			}
		}
		public double CreditAmt
		{
			get{return _creditAmt;}
			set
			{
				if (value != this._creditAmt)
				{
					_creditAmt=value;
					NotifyChanged("CreditAmt");
				}
			}
		}
		public double CreditFAmt
		{
			get{return _creditFAmt;}
			set
			{
				if (value != this._creditFAmt)
				{
					_creditFAmt=value;
					NotifyChanged("CreditFAmt");
				}
			}
		}
		public Nullable<DateTime> JournalDate
		{
			get{return _journalDate;}
			set
			{
				if (value != this._journalDate)
				{
					_journalDate=value;
					NotifyChanged("JournalDate");
				}
			}
		}
		public String DocumentNo
		{
			get{return _documentNo;}
			set
			{
				if (value != this._documentNo)
				{
					_documentNo=value;
					NotifyChanged("DocumentNo");
				}
			}
		}
		public String SourceLedger
		{
			get{return _sourceLedger;}
			set
			{
				if (value != this._sourceLedger)
				{
					_sourceLedger=value;
					NotifyChanged("SourceLedger");
				}
			}
		}
		public String AccountDoiUngNo
		{
			get{return _accountDoiUngNo;}
			set
			{
				if (value != this._accountDoiUngNo)
				{
					_accountDoiUngNo=value;
					NotifyChanged("AccountDoiUngNo");
				}
			}
		}
		public int FK_GECurrencyID
		{
			get{return _fK_GECurrencyID;}
			set
			{
				if (value != this._fK_GECurrencyID)
				{
					_fK_GECurrencyID=value;
					NotifyChanged("FK_GECurrencyID");
				}
			}
		}
		public double ExcRate
		{
			get{return _excRate;}
			set
			{
				if (value != this._excRate)
				{
					_excRate=value;
					NotifyChanged("ExcRate");
				}
			}
		}
		public String JournalDesc
		{
			get{return _journalDesc;}
			set
			{
				if (value != this._journalDesc)
				{
					_journalDesc=value;
					NotifyChanged("JournalDesc");
				}
			}
		}
		public String JournalHDesc
		{
			get{return _journalHDesc;}
			set
			{
				if (value != this._journalHDesc)
				{
					_journalHDesc=value;
					NotifyChanged("JournalHDesc");
				}
			}
		}
		public double BeginDebitAmt
		{
			get{return _beginDebitAmt;}
			set
			{
				if (value != this._beginDebitAmt)
				{
					_beginDebitAmt=value;
					NotifyChanged("BeginDebitAmt");
				}
			}
		}
		public double BeginDebitFAmt
		{
			get{return _beginDebitFAmt;}
			set
			{
				if (value != this._beginDebitFAmt)
				{
					_beginDebitFAmt=value;
					NotifyChanged("BeginDebitFAmt");
				}
			}
		}
		public double BeginCreditAmt
		{
			get{return _beginCreditAmt;}
			set
			{
				if (value != this._beginCreditAmt)
				{
					_beginCreditAmt=value;
					NotifyChanged("BeginCreditAmt");
				}
			}
		}
		public double BeginCreditFAmt
		{
			get{return _beginCreditFAmt;}
			set
			{
				if (value != this._beginCreditFAmt)
				{
					_beginCreditFAmt=value;
					NotifyChanged("BeginCreditFAmt");
				}
			}
		}
		public double EndDebitAmt
		{
			get{return _endDebitAmt;}
			set
			{
				if (value != this._endDebitAmt)
				{
					_endDebitAmt=value;
					NotifyChanged("EndDebitAmt");
				}
			}
		}
		public double EndDebitFAmt
		{
			get{return _endDebitFAmt;}
			set
			{
				if (value != this._endDebitFAmt)
				{
					_endDebitFAmt=value;
					NotifyChanged("EndDebitFAmt");
				}
			}
		}
		public double EndCreditAmt
		{
			get{return _endCreditAmt;}
			set
			{
				if (value != this._endCreditAmt)
				{
					_endCreditAmt=value;
					NotifyChanged("EndCreditAmt");
				}
			}
		}
		public double EndCreditFAmt
		{
			get{return _endCreditFAmt;}
			set
			{
				if (value != this._endCreditFAmt)
				{
					_endCreditFAmt=value;
					NotifyChanged("EndCreditFAmt");
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
		public Nullable<DateTime> JournalDocDate
		{
			get{return _journalDocDate;}
			set
			{
				if (value != this._journalDocDate)
				{
					_journalDocDate=value;
					NotifyChanged("JournalDocDate");
				}
			}
		}
		
        #endregion
    }
    #endregion
}