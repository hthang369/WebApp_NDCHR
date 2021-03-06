using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARInvoiceComments
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ARInvoiceCommentsInfo
    //Created Date:02 Tháng Bảy 2012
    //-----------------------------------------------------------

    public class ARInvoiceCommentsInfo : BusinessObject
    {
        public ARInvoiceCommentsInfo()
        {
        }
        #region Variables
        protected int _aRInvoiceCommentID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ADUserID;
        protected Nullable<DateTime> _issueDate;
        protected int _fK_ARInvoiceID;
        protected String _commentRemark = String.Empty;
        protected int _fK_ADApprovalProcID;
        protected int _fK_ADApprovalProcStepID;
        #endregion

        #region Public properties
        public int ARInvoiceCommentID
        {
            get { return _aRInvoiceCommentID; }
            set
            {
                if (value != this._aRInvoiceCommentID)
                {
                    _aRInvoiceCommentID = value;
                    NotifyChanged("ARInvoiceCommentID");
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
        public int FK_ADUserID
        {
            get { return _fK_ADUserID; }
            set
            {
                if (value != this._fK_ADUserID)
                {
                    _fK_ADUserID = value;
                    NotifyChanged("FK_ADUserID");
                }
            }
        }
        public Nullable<DateTime> IssueDate
        {
            get { return _issueDate; }
            set
            {
                if (value != this._issueDate)
                {
                    _issueDate = value;
                    NotifyChanged("IssueDate");
                }
            }
        }
        public int FK_ARInvoiceID
        {
            get { return _fK_ARInvoiceID; }
            set
            {
                if (value != this._fK_ARInvoiceID)
                {
                    _fK_ARInvoiceID = value;
                    NotifyChanged("FK_ARInvoiceID");
                }
            }
        }
        public String CommentRemark
        {
            get { return _commentRemark; }
            set
            {
                if (value != this._commentRemark)
                {
                    _commentRemark = value;
                    NotifyChanged("CommentRemark");
                }
            }
        }
        public int FK_ADApprovalProcID
        {
            get { return _fK_ADApprovalProcID; }
            set
            {
                if (value != this._fK_ADApprovalProcID)
                {
                    _fK_ADApprovalProcID = value;
                    NotifyChanged("FK_ADApprovalProcID");
                }
            }
        }
        public int FK_ADApprovalProcStepID
        {
            get { return _fK_ADApprovalProcStepID; }
            set
            {
                if (value != this._fK_ADApprovalProcStepID)
                {
                    _fK_ADApprovalProcStepID = value;
                    NotifyChanged("FK_ADApprovalProcStepID");
                }
            }
        }
        #endregion
    }
    #endregion
}