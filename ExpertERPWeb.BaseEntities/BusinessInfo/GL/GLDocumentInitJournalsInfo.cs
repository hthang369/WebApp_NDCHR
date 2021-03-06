using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLDocumentInitJournals
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v1.0.22)
    //Class: GLDocumentInitJournalsInfo
    //Created Date: Friday, 28 Apr 2017
    //-----------------------------------------------------------

    public class GLDocumentInitJournalsInfo : BusinessObject
    {
        public GLDocumentInitJournalsInfo()
        {
        }
        #region Variables
        protected int _gLDocumentInitJournalID;
        protected bool _aASelected = true;
        protected String _aAStatus = DefaultAAStatus;
        protected String _gLDocumentInitJournalNo = String.Empty;
        protected String _gLDocumentInitJournalName = String.Empty;
        protected Nullable<DateTime> _gLDocumentInitJournalDate;
        protected String _gLDocumentInitJournalDesc = String.Empty;
        protected String _gLDocumentInitJournalTypeCombo = String.Empty;

        #endregion

        #region Public properties
        public int GLDocumentInitJournalID
        {
            get { return _gLDocumentInitJournalID; }
            set
            {
                if (value != this._gLDocumentInitJournalID)
                {
                    _gLDocumentInitJournalID = value;
                    NotifyChanged("GLDocumentInitJournalID");
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
        public String GLDocumentInitJournalNo
        {
            get { return _gLDocumentInitJournalNo; }
            set
            {
                if (value != this._gLDocumentInitJournalNo)
                {
                    _gLDocumentInitJournalNo = value;
                    NotifyChanged("GLDocumentInitJournalNo");
                }
            }
        }
        public String GLDocumentInitJournalName
        {
            get { return _gLDocumentInitJournalName; }
            set
            {
                if (value != this._gLDocumentInitJournalName)
                {
                    _gLDocumentInitJournalName = value;
                    NotifyChanged("GLDocumentInitJournalName");
                }
            }
        }
        public Nullable<DateTime> GLDocumentInitJournalDate
        {
            get { return _gLDocumentInitJournalDate; }
            set
            {
                if (value != this._gLDocumentInitJournalDate)
                {
                    _gLDocumentInitJournalDate = value;
                    NotifyChanged("GLDocumentInitJournalDate");
                }
            }
        }
        public String GLDocumentInitJournalDesc
        {
            get { return _gLDocumentInitJournalDesc; }
            set
            {
                if (value != this._gLDocumentInitJournalDesc)
                {
                    _gLDocumentInitJournalDesc = value;
                    NotifyChanged("GLDocumentInitJournalDesc");
                }
            }
        }
        public String GLDocumentInitJournalTypeCombo
        {
            get { return _gLDocumentInitJournalTypeCombo; }
            set
            {
                if (value != this._gLDocumentInitJournalTypeCombo)
                {
                    _gLDocumentInitJournalTypeCombo = value;
                    NotifyChanged("GLDocumentInitJournalTypeCombo");
                }
            }
        }

        #endregion
    }
    #endregion
}