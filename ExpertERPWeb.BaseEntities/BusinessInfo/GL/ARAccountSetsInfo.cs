using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARAccountSets
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ARAccountSetsInfo
    //Created Date:29 Tha�ng Ba�y 2013
    //-----------------------------------------------------------

    public class ARAccountSetsInfo : BusinessObject
    {
        public ARAccountSetsInfo()
        {
        }
        #region Variables
        protected int _aRAccountSetID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aRAccountSetNo = String.Empty;
        protected String _aRAccountSetName = String.Empty;
        protected String _aRAccountSetDesc = String.Empty;
        protected int _fK_GLReceivableAccountID;
        protected int _fK_GLReceiptDiscountAccountID;
        protected int _fK_GLPrepaymentAccountID;
        protected Nullable<DateTime> _aRAccountSetDate;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_GLSaleAccountID;
        protected bool _aADefault = true;
        protected bool _aASelected = true;
        protected String _aAOrgDocNo = String.Empty;
        #endregion

        #region Public properties
        public int ARAccountSetID
        {
            get { return _aRAccountSetID; }
            set
            {
                if (value != this._aRAccountSetID)
                {
                    _aRAccountSetID = value;
                    NotifyChanged("ARAccountSetID");
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
        public String ARAccountSetNo
        {
            get { return _aRAccountSetNo; }
            set
            {
                if (value != this._aRAccountSetNo)
                {
                    _aRAccountSetNo = value;
                    NotifyChanged("ARAccountSetNo");
                }
            }
        }
        public String ARAccountSetName
        {
            get { return _aRAccountSetName; }
            set
            {
                if (value != this._aRAccountSetName)
                {
                    _aRAccountSetName = value;
                    NotifyChanged("ARAccountSetName");
                }
            }
        }
        public String ARAccountSetDesc
        {
            get { return _aRAccountSetDesc; }
            set
            {
                if (value != this._aRAccountSetDesc)
                {
                    _aRAccountSetDesc = value;
                    NotifyChanged("ARAccountSetDesc");
                }
            }
        }
        public int FK_GLReceivableAccountID
        {
            get { return _fK_GLReceivableAccountID; }
            set
            {
                if (value != this._fK_GLReceivableAccountID)
                {
                    _fK_GLReceivableAccountID = value;
                    NotifyChanged("FK_GLReceivableAccountID");
                }
            }
        }
        public int FK_GLReceiptDiscountAccountID
        {
            get { return _fK_GLReceiptDiscountAccountID; }
            set
            {
                if (value != this._fK_GLReceiptDiscountAccountID)
                {
                    _fK_GLReceiptDiscountAccountID = value;
                    NotifyChanged("FK_GLReceiptDiscountAccountID");
                }
            }
        }
        public int FK_GLPrepaymentAccountID
        {
            get { return _fK_GLPrepaymentAccountID; }
            set
            {
                if (value != this._fK_GLPrepaymentAccountID)
                {
                    _fK_GLPrepaymentAccountID = value;
                    NotifyChanged("FK_GLPrepaymentAccountID");
                }
            }
        }
        public Nullable<DateTime> ARAccountSetDate
        {
            get { return _aRAccountSetDate; }
            set
            {
                if (value != this._aRAccountSetDate)
                {
                    _aRAccountSetDate = value;
                    NotifyChanged("ARAccountSetDate");
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
        public int FK_GLSaleAccountID
        {
            get { return _fK_GLSaleAccountID; }
            set
            {
                if (value != this._fK_GLSaleAccountID)
                {
                    _fK_GLSaleAccountID = value;
                    NotifyChanged("FK_GLSaleAccountID");
                }
            }
        }
        public bool AADefault
        {
            get { return _aADefault; }
            set
            {
                if (value != this._aADefault)
                {
                    _aADefault = value;
                    NotifyChanged("AADefault");
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
        public String AAOrgDocNo
        {
            get { return _aAOrgDocNo; }
            set
            {
                if (value != this._aAOrgDocNo)
                {
                    _aAOrgDocNo = value;
                    NotifyChanged("AAOrgDocNo");
                }
            }
        }
        #endregion
    }
    #endregion
}