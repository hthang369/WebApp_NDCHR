using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewGLVouchers
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ViewGLVouchersInfo
    //Created Date:08 Tháng Mười Một 2012
    //-----------------------------------------------------------

    public class ViewGLVouchersInfo : BusinessObject
    {
        public ViewGLVouchersInfo()
        {
        }
        #region Variables
        protected int _viewGLVoucherID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_GLVoucherID;
        protected String _viewGLVoucherPmtPayToName = String.Empty;
        protected String _viewGLPmtPayToDesc = String.Empty;
        protected String _viewGLOutPmtDesc = String.Empty;
        protected double _viewGLPmtAmt;
        protected String _viewGLAccountNoCredit = String.Empty;
        protected String _viewGLAccountNoDebit = String.Empty;
        #endregion

        #region Public properties
        public int ViewGLVoucherID
        {
            get { return _viewGLVoucherID; }
            set
            {
                if (value != this._viewGLVoucherID)
                {
                    _viewGLVoucherID = value;
                    NotifyChanged("ViewGLVoucherID");
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
        public int FK_GLVoucherID
        {
            get { return _fK_GLVoucherID; }
            set
            {
                if (value != this._fK_GLVoucherID)
                {
                    _fK_GLVoucherID = value;
                    NotifyChanged("FK_GLVoucherID");
                }
            }
        }
        public String ViewGLVoucherPmtPayToName
        {
            get { return _viewGLVoucherPmtPayToName; }
            set
            {
                if (value != this._viewGLVoucherPmtPayToName)
                {
                    _viewGLVoucherPmtPayToName = value;
                    NotifyChanged("ViewGLVoucherPmtPayToName");
                }
            }
        }
        public String ViewGLPmtPayToDesc
        {
            get { return _viewGLPmtPayToDesc; }
            set
            {
                if (value != this._viewGLPmtPayToDesc)
                {
                    _viewGLPmtPayToDesc = value;
                    NotifyChanged("ViewGLPmtPayToDesc");
                }
            }
        }
        public String ViewGLOutPmtDesc
        {
            get { return _viewGLOutPmtDesc; }
            set
            {
                if (value != this._viewGLOutPmtDesc)
                {
                    _viewGLOutPmtDesc = value;
                    NotifyChanged("ViewGLOutPmtDesc");
                }
            }
        }
        public double ViewGLPmtAmt
        {
            get { return _viewGLPmtAmt; }
            set
            {
                if (value != this._viewGLPmtAmt)
                {
                    _viewGLPmtAmt = value;
                    NotifyChanged("ViewGLPmtAmt");
                }
            }
        }
        public String ViewGLAccountNoCredit
        {
            get { return _viewGLAccountNoCredit; }
            set
            {
                if (value != this._viewGLAccountNoCredit)
                {
                    _viewGLAccountNoCredit = value;
                    NotifyChanged("ViewGLAccountNoCredit");
                }
            }
        }
        public String ViewGLAccountNoDebit
        {
            get { return _viewGLAccountNoDebit; }
            set
            {
                if (value != this._viewGLAccountNoDebit)
                {
                    _viewGLAccountNoDebit = value;
                    NotifyChanged("ViewGLAccountNoDebit");
                }
            }
        }
        #endregion
    }
    #endregion
}