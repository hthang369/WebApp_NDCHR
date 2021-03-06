using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewGLAccountArisings
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH
    //Class: ViewGLAccountArisingsInfo
    //Created Date: 28 Mar 2015
    //-----------------------------------------------------------

    public class ViewGLAccountArisingsInfo : BusinessObject
    {
        public ViewGLAccountArisingsInfo()
        {
        }
        #region Variables
		protected int _fK_GLAccountID;
		protected String _accountNo=String.Empty;
		protected String _accountName=String.Empty;
		protected double _creditAmt;
		protected double _debitAmt;
		protected double _arisingAmt;
		protected bool _isParent=true;
		protected int _fK_HREmployeeID;
		protected int _fK_ARCustomerID;
		protected int _fK_APSupplierID;
		protected int _fK_GECurrencyID;
		protected double _excRate;
		protected double _fCreditAmt;
		protected double _fDebitAmt;
		protected int _fK_GLLoanAgreementID;
		protected int _fK_BRBranchID;
		protected int _fK_FAAssetConstructionID;
		
        #endregion

        #region Public properties
		public int FK_GLAccountID
		{
			get{return _fK_GLAccountID;}
			set
			{
				if (value != this._fK_GLAccountID)
				{
					_fK_GLAccountID=value;
					NotifyChanged("FK_GLAccountID");
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
		public String AccountName
		{
			get{return _accountName;}
			set
			{
				if (value != this._accountName)
				{
					_accountName=value;
					NotifyChanged("AccountName");
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
		public double ArisingAmt
		{
			get{return _arisingAmt;}
			set
			{
				if (value != this._arisingAmt)
				{
					_arisingAmt=value;
					NotifyChanged("ArisingAmt");
				}
			}
		}
		public bool IsParent
		{
			get{return _isParent;}
			set
			{
				if (value != this._isParent)
				{
					_isParent=value;
					NotifyChanged("IsParent");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get{return _fK_HREmployeeID;}
			set
			{
				if (value != this._fK_HREmployeeID)
				{
					_fK_HREmployeeID=value;
					NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public int FK_ARCustomerID
		{
			get{return _fK_ARCustomerID;}
			set
			{
				if (value != this._fK_ARCustomerID)
				{
					_fK_ARCustomerID=value;
					NotifyChanged("FK_ARCustomerID");
				}
			}
		}
		public int FK_APSupplierID
		{
			get{return _fK_APSupplierID;}
			set
			{
				if (value != this._fK_APSupplierID)
				{
					_fK_APSupplierID=value;
					NotifyChanged("FK_APSupplierID");
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
		public double FCreditAmt
		{
			get{return _fCreditAmt;}
			set
			{
				if (value != this._fCreditAmt)
				{
					_fCreditAmt=value;
					NotifyChanged("FCreditAmt");
				}
			}
		}
		public double FDebitAmt
		{
			get{return _fDebitAmt;}
			set
			{
				if (value != this._fDebitAmt)
				{
					_fDebitAmt=value;
					NotifyChanged("FDebitAmt");
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
		public int FK_BRBranchID
		{
			get{return _fK_BRBranchID;}
			set
			{
				if (value != this._fK_BRBranchID)
				{
					_fK_BRBranchID=value;
					NotifyChanged("FK_BRBranchID");
				}
			}
		}
		public int FK_FAAssetConstructionID
		{
			get{return _fK_FAAssetConstructionID;}
			set
			{
				if (value != this._fK_FAAssetConstructionID)
				{
					_fK_FAAssetConstructionID=value;
					NotifyChanged("FK_FAAssetConstructionID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}