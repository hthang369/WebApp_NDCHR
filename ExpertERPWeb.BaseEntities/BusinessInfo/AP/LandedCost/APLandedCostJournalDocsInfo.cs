using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region APLandedCostJournalDocs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:APLandedCostJournalDocsInfo
    //Created Date:Thursday, October 18, 2012
    //-----------------------------------------------------------

    public class APLandedCostJournalDocsInfo : BusinessObject
    {
        public APLandedCostJournalDocsInfo()
        {
        }
        #region Variables
        protected int _aPLandedCostJournalDocID;
        protected String _aPLandedCostJournalDocNo = String.Empty;
        protected Nullable<DateTime> _aPLandedCostJournalDocDate;
        protected int _fK_APLandedCostID;
        protected double _aPLandedCostJournalAmt;
        protected String _aPLandedCostJournalDocDesc = String.Empty;
        protected String _aPLandedCostJournalSourceLedge = String.Empty;
        protected int _fK_GLAccountID;
        #endregion

        #region Public properties
        public int APLandedCostJournalDocID
        {
            get { return _aPLandedCostJournalDocID; }
            set
            {
                if (value != this._aPLandedCostJournalDocID)
                {
                    _aPLandedCostJournalDocID = value;
                    NotifyChanged("APLandedCostJournalDocID");
                }
            }
        }
        public String APLandedCostJournalDocNo
        {
            get { return _aPLandedCostJournalDocNo; }
            set
            {
                if (value != this._aPLandedCostJournalDocNo)
                {
                    _aPLandedCostJournalDocNo = value;
                    NotifyChanged("APLandedCostJournalDocNo");
                }
            }
        }
        public Nullable<DateTime> APLandedCostJournalDocDate
        {
            get { return _aPLandedCostJournalDocDate; }
            set
            {
                if (value != this._aPLandedCostJournalDocDate)
                {
                    _aPLandedCostJournalDocDate = value;
                    NotifyChanged("APLandedCostJournalDocDate");
                }
            }
        }
        public int FK_APLandedCostID
        {
            get { return _fK_APLandedCostID; }
            set
            {
                if (value != this._fK_APLandedCostID)
                {
                    _fK_APLandedCostID = value;
                    NotifyChanged("FK_APLandedCostID");
                }
            }
        }
        public double APLandedCostJournalAmt
        {
            get { return _aPLandedCostJournalAmt; }
            set
            {
                if (value != this._aPLandedCostJournalAmt)
                {
                    _aPLandedCostJournalAmt = value;
                    NotifyChanged("APLandedCostJournalAmt");
                }
            }
        }
        public String APLandedCostJournalDocDesc
        {
            get { return _aPLandedCostJournalDocDesc; }
            set
            {
                if (value != this._aPLandedCostJournalDocDesc)
                {
                    _aPLandedCostJournalDocDesc = value;
                    NotifyChanged("APLandedCostJournalDocDesc");
                }
            }
        }
        public String APLandedCostJournalSourceLedge
        {
            get { return _aPLandedCostJournalSourceLedge; }
            set
            {
                if (value != this._aPLandedCostJournalSourceLedge)
                {
                    _aPLandedCostJournalSourceLedge = value;
                    NotifyChanged("APLandedCostJournalSourceLedge");
                }
            }
        }
        public int FK_GLAccountID
        {
            get { return _fK_GLAccountID; }
            set
            {
                if (value != this._fK_GLAccountID)
                {
                    _fK_GLAccountID = value;
                    NotifyChanged("FK_GLAccountID");
                }
            }
        }
        #endregion
    }
    #endregion
}