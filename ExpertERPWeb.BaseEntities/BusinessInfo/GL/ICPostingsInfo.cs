using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICPostings
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICPostingsInfo
    //Created Date:23 Tháng Bảy 2011
    //-----------------------------------------------------------

    public class ICPostingsInfo : BusinessObject
    {
        public ICPostingsInfo()
        {
        }
        #region Variables
        protected int _iCPostingID;
        protected bool _aASelected = true;
        protected String _iCPostingNo = String.Empty;
        protected Nullable<DateTime> _iCPostingDate;
        protected String _iCPostingObjectName = String.Empty;
        protected double _iCPostingPrice;
        protected String _postingStatus = DefaultStatus;
        protected String _iCPostingSourceLedger = String.Empty;
        protected String _iCPostingDesc = String.Empty;
        protected String _iCPostingSourceLedgerDisplay = String.Empty;
        #endregion

        #region Public properties
        public int ICPostingID
        {
            get { return _iCPostingID; }
            set
            {
                if (value != this._iCPostingID)
                {
                    _iCPostingID = value;
                    NotifyChanged("ICPostingID");
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
        public String ICPostingNo
        {
            get { return _iCPostingNo; }
            set
            {
                if (value != this._iCPostingNo)
                {
                    _iCPostingNo = value;
                    NotifyChanged("ICPostingNo");
                }
            }
        }
        public Nullable<DateTime> ICPostingDate
        {
            get { return _iCPostingDate; }
            set
            {
                if (value != this._iCPostingDate)
                {
                    _iCPostingDate = value;
                    NotifyChanged("ICPostingDate");
                }
            }
        }
        public String ICPostingObjectName
        {
            get { return _iCPostingObjectName; }
            set
            {
                if (value != this._iCPostingObjectName)
                {
                    _iCPostingObjectName = value;
                    NotifyChanged("ICPostingObjectName");
                }
            }
        }
        public double ICPostingPrice
        {
            get { return _iCPostingPrice; }
            set
            {
                if (value != this._iCPostingPrice)
                {
                    _iCPostingPrice = value;
                    NotifyChanged("ICPostingPrice");
                }
            }
        }
        public String PostingStatus
        {
            get { return _postingStatus; }
            set
            {
                if (value != this._postingStatus)
                {
                    _postingStatus = value;
                    NotifyChanged("PostingStatus");
                }
            }
        }
        public String ICPostingSourceLedger
        {
            get { return _iCPostingSourceLedger; }
            set
            {
                if (value != this._iCPostingSourceLedger)
                {
                    _iCPostingSourceLedger = value;
                    NotifyChanged("ICPostingSourceLedger");
                }
            }
        }
        public String ICPostingDesc
        {
            get { return _iCPostingDesc; }
            set
            {
                if (value != this._iCPostingDesc)
                {
                    _iCPostingDesc = value;
                    NotifyChanged("ICPostingDesc");
                }
            }
        }
        public String ICPostingSourceLedgerDisplay
        {
            get { return _iCPostingSourceLedgerDisplay; }
            set
            {
                if (value != this._iCPostingSourceLedgerDisplay)
                {
                    _iCPostingSourceLedgerDisplay = value;
                    NotifyChanged("ICPostingSourceLedgerDisplay");
                }
            }
        }
        #endregion
    }
    #endregion
}