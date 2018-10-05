using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARPostings
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ARPostingsInfo
    //Created Date:23 Tháng Bảy 2011
    //-----------------------------------------------------------

    public class ARPostingsInfo : BusinessObject
    {
        public ARPostingsInfo()
        {
        }
        #region Variables
        protected int _aRPostingID;
        protected bool _aASelected = true;
        protected String _aRPostingNo = String.Empty;
        protected Nullable<DateTime> _aRPostingDate;
        protected String _aRPostingObjectName = String.Empty;
        protected double _aRPostingPrice;
        protected String _postingStatus = DefaultStatus;
        protected String _aRPostingSourceLedger = String.Empty;
        protected String _aRPostingDesc = String.Empty;
        protected String _aRPostingSourceLedgerDisplay = String.Empty;
        #endregion

        #region Public properties
        public int ARPostingID
        {
            get { return _aRPostingID; }
            set
            {
                if (value != this._aRPostingID)
                {
                    _aRPostingID = value;
                    NotifyChanged("ARPostingID");
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
        public String ARPostingNo
        {
            get { return _aRPostingNo; }
            set
            {
                if (value != this._aRPostingNo)
                {
                    _aRPostingNo = value;
                    NotifyChanged("ARPostingNo");
                }
            }
        }
        public Nullable<DateTime> ARPostingDate
        {
            get { return _aRPostingDate; }
            set
            {
                if (value != this._aRPostingDate)
                {
                    _aRPostingDate = value;
                    NotifyChanged("ARPostingDate");
                }
            }
        }
        public String ARPostingObjectName
        {
            get { return _aRPostingObjectName; }
            set
            {
                if (value != this._aRPostingObjectName)
                {
                    _aRPostingObjectName = value;
                    NotifyChanged("ARPostingObjectName");
                }
            }
        }
        public double ARPostingPrice
        {
            get { return _aRPostingPrice; }
            set
            {
                if (value != this._aRPostingPrice)
                {
                    _aRPostingPrice = value;
                    NotifyChanged("ARPostingPrice");
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
        public String ARPostingSourceLedger
        {
            get { return _aRPostingSourceLedger; }
            set
            {
                if (value != this._aRPostingSourceLedger)
                {
                    _aRPostingSourceLedger = value;
                    NotifyChanged("ARPostingSourceLedger");
                }
            }
        }
        public String ARPostingDesc
        {
            get { return _aRPostingDesc; }
            set
            {
                if (value != this._aRPostingDesc)
                {
                    _aRPostingDesc = value;
                    NotifyChanged("ARPostingDesc");
                }
            }
        }
        public String ARPostingSourceLedgerDisplay
        {
            get { return _aRPostingSourceLedgerDisplay; }
            set
            {
                if (value != this._aRPostingSourceLedgerDisplay)
                {
                    _aRPostingSourceLedgerDisplay = value;
                    NotifyChanged("ARPostingSourceLedgerDisplay");
                }
            }
        }
        #endregion
    }
    #endregion
}