using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICReceiptTypes
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICReceiptTypesInfo
    //Created Date:Friday, August 19, 2011
    //-----------------------------------------------------------

    public class ICReceiptTypesInfo : BusinessObject
    {
        public ICReceiptTypesInfo()
        {
        }
        #region Variables
        protected int _iCReceiptTypeID;
        protected String _iCReceiptTypeDesc = String.Empty;
        protected int _fK_ICStockID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _iCReceiptTypeNo = String.Empty;
        protected String _iCReceiptTypeName = String.Empty;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        #endregion

        #region Public properties
        public int ICReceiptTypeID
        {
            get { return _iCReceiptTypeID; }
            set
            {
                if (value != this._iCReceiptTypeID)
                {
                    _iCReceiptTypeID = value;
                    NotifyChanged("ICReceiptTypeID");
                }
            }
        }
        public String ICReceiptTypeDesc
        {
            get { return _iCReceiptTypeDesc; }
            set
            {
                if (value != this._iCReceiptTypeDesc)
                {
                    _iCReceiptTypeDesc = value;
                    NotifyChanged("ICReceiptTypeDesc");
                }
            }
        }
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                    NotifyChanged("FK_ICStockID");
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
        public String ICReceiptTypeNo
        {
            get { return _iCReceiptTypeNo; }
            set
            {
                if (value != this._iCReceiptTypeNo)
                {
                    _iCReceiptTypeNo = value;
                    NotifyChanged("ICReceiptTypeNo");
                }
            }
        }
        public String ICReceiptTypeName
        {
            get { return _iCReceiptTypeName; }
            set
            {
                if (value != this._iCReceiptTypeName)
                {
                    _iCReceiptTypeName = value;
                    NotifyChanged("ICReceiptTypeName");
                }
            }
        }
        public int FK_GLDebitAccountID
        {
            get { return _fK_GLDebitAccountID; }
            set
            {
                if (value != this._fK_GLDebitAccountID)
                {
                    _fK_GLDebitAccountID = value;
                    NotifyChanged("FK_GLDebitAccountID");
                }
            }
        }
        public int FK_GLCreditAccountID
        {
            get { return _fK_GLCreditAccountID; }
            set
            {
                if (value != this._fK_GLCreditAccountID)
                {
                    _fK_GLCreditAccountID = value;
                    NotifyChanged("FK_GLCreditAccountID");
                }
            }
        }
        #endregion
    }
    #endregion
}