using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLPeriodTransferItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:GLPeriodTransferItemsInfo
    //Created Date:11 March 2013
    //-----------------------------------------------------------

    public class GLPeriodTransferItemsInfo : BusinessObject
    {
        public GLPeriodTransferItemsInfo()
        {
        }
        #region Variables
        protected int _gLPeriodTransferItemID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_GLFromAccountID;
        protected int _fK_GLToAccountID;
        protected double _amt;
        protected double _debitAmt;
        protected double _debitFAmt;
        protected double _creditAmt;
        protected double _creditFAmt;
        protected String _gLPeriodTransferItemDesc = String.Empty;
        protected int _fK_GLPeriodTransferID;
        protected int _actionOrdr;
        protected String _gLPeriodTransferTypeCombo = String.Empty;
        #endregion

        #region Public properties
        public int GLPeriodTransferItemID
        {
            get { return _gLPeriodTransferItemID; }
            set
            {
                if (value != this._gLPeriodTransferItemID)
                {
                    _gLPeriodTransferItemID = value;
                    NotifyChanged("GLPeriodTransferItemID");
                }
            }
        }
        public Nullable<DateTime> AACreatedDate
        {
            get { return _aACreatedDate; }
            set
            {
                if (value != this._aACreatedDate)
                {
                    _aACreatedDate = value;
                    NotifyChanged("AACreatedDate");
                }
            }
        }
        public String AACreatedUser
        {
            get { return _aACreatedUser; }
            set
            {
                if (value != this._aACreatedUser)
                {
                    _aACreatedUser = value;
                    NotifyChanged("AACreatedUser");
                }
            }
        }
        public Nullable<DateTime> AAUpdatedDate
        {
            get { return _aAUpdatedDate; }
            set
            {
                if (value != this._aAUpdatedDate)
                {
                    _aAUpdatedDate = value;
                    NotifyChanged("AAUpdatedDate");
                }
            }
        }
        public String AAUpdatedUser
        {
            get { return _aAUpdatedUser; }
            set
            {
                if (value != this._aAUpdatedUser)
                {
                    _aAUpdatedUser = value;
                    NotifyChanged("AAUpdatedUser");
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
        public bool AASelected
        {
            get { return _aASelected; }
            set
            {
                if (value != this._aASelected)
                {
                    _aASelected = value;
                    NotifyChanged("AASelected");
                }
            }
        }
        public int FK_GLFromAccountID
        {
            get { return _fK_GLFromAccountID; }
            set
            {
                if (value != this._fK_GLFromAccountID)
                {
                    _fK_GLFromAccountID = value;
                    NotifyChanged("FK_GLFromAccountID");
                }
            }
        }
        public int FK_GLToAccountID
        {
            get { return _fK_GLToAccountID; }
            set
            {
                if (value != this._fK_GLToAccountID)
                {
                    _fK_GLToAccountID = value;
                    NotifyChanged("FK_GLToAccountID");
                }
            }
        }
        public double Amt
        {
            get { return _amt; }
            set
            {
                if (value != this._amt)
                {
                    _amt = value;
                    NotifyChanged("Amt");
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
        public String GLPeriodTransferItemDesc
        {
            get { return _gLPeriodTransferItemDesc; }
            set
            {
                if (value != this._gLPeriodTransferItemDesc)
                {
                    _gLPeriodTransferItemDesc = value;
                    NotifyChanged("GLPeriodTransferItemDesc");
                }
            }
        }
        public int FK_GLPeriodTransferID
        {
            get { return _fK_GLPeriodTransferID; }
            set
            {
                if (value != this._fK_GLPeriodTransferID)
                {
                    _fK_GLPeriodTransferID = value;
                    NotifyChanged("FK_GLPeriodTransferID");
                }
            }
        }
        public int ActionOrdr
        {
            get { return _actionOrdr; }
            set
            {
                if (value != this._actionOrdr)
                {
                    _actionOrdr = value;
                    NotifyChanged("ActionOrdr");
                }
            }
        }
        public String GLPeriodTransferTypeCombo
        {
            get { return _gLPeriodTransferTypeCombo; }
            set
            {
                if (value != this._gLPeriodTransferTypeCombo)
                {
                    _gLPeriodTransferTypeCombo = value;
                    NotifyChanged("GLPeriodTransferTypeCombo");
                }
            }
        }
        #endregion
    }
    #endregion
}