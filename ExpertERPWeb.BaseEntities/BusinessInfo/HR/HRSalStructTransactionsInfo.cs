using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRSalStructTransactions
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET ? H??? �i?? (v2.0.60)
    //Class: HRSalStructTransactionsInfo
    //Created Date: Tuesday, 12 Dec 2017
    //-----------------------------------------------------------

    public class HRSalStructTransactionsInfo : BusinessObject
    {
        public HRSalStructTransactionsInfo()
        {
        }
        #region Variables
        protected int _hRSalStructTransactionID;
        protected String _hRSalStructTransactionNo = String.Empty;
        protected String _hRSalStructTransactionName = String.Empty;
        protected Nullable<DateTime> _hRSalStructTransactionDate;
        protected String _hRSalStructTransactionDesc = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected bool _aASelected = true;
        protected bool _hRSalStructTransactionColVisible = true;
        protected int _hRSalStructTransactionSortOrder;

        #endregion

        #region Public properties
        public int HRSalStructTransactionID
        {
            get { return _hRSalStructTransactionID; }
            set
            {
                if (value != this._hRSalStructTransactionID)
                {
                    _hRSalStructTransactionID = value;
                    NotifyChanged("HRSalStructTransactionID");
                }
            }
        }
        public String HRSalStructTransactionNo
        {
            get { return _hRSalStructTransactionNo; }
            set
            {
                if (value != this._hRSalStructTransactionNo)
                {
                    _hRSalStructTransactionNo = value;
                    NotifyChanged("HRSalStructTransactionNo");
                }
            }
        }
        public String HRSalStructTransactionName
        {
            get { return _hRSalStructTransactionName; }
            set
            {
                if (value != this._hRSalStructTransactionName)
                {
                    _hRSalStructTransactionName = value;
                    NotifyChanged("HRSalStructTransactionName");
                }
            }
        }
        public Nullable<DateTime> HRSalStructTransactionDate
        {
            get { return _hRSalStructTransactionDate; }
            set
            {
                if (value != this._hRSalStructTransactionDate)
                {
                    _hRSalStructTransactionDate = value;
                    NotifyChanged("HRSalStructTransactionDate");
                }
            }
        }
        public String HRSalStructTransactionDesc
        {
            get { return _hRSalStructTransactionDesc; }
            set
            {
                if (value != this._hRSalStructTransactionDesc)
                {
                    _hRSalStructTransactionDesc = value;
                    NotifyChanged("HRSalStructTransactionDesc");
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
        public bool HRSalStructTransactionColVisible
        {
            get { return _hRSalStructTransactionColVisible; }
            set
            {
                if (value != this._hRSalStructTransactionColVisible)
                {
                    _hRSalStructTransactionColVisible = value;
                    NotifyChanged("HRSalStructTransactionColVisible");
                }
            }
        }
        public int HRSalStructTransactionSortOrder
        {
            get { return _hRSalStructTransactionSortOrder; }
            set
            {
                if (value != this._hRSalStructTransactionSortOrder)
                {
                    _hRSalStructTransactionSortOrder = value;
                    NotifyChanged("HRSalStructTransactionSortOrder");
                }
            }
        }

        #endregion
    }
    #endregion
}