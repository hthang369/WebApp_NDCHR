using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICShipmentTypes
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICShipmentTypesInfo
    //Created Date:Friday, August 19, 2011
    //-----------------------------------------------------------

    public class ICShipmentTypesInfo : BusinessObject
    {
        public ICShipmentTypesInfo()
        {
        }
        #region Variables
        protected int _iCShipmentTypeID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _iCShipmentTypeDesc = String.Empty;
        protected int _fK_ICStockID;
        protected String _iCShipmentTypeNo = String.Empty;
        protected String _iCShipmentTypeName = String.Empty;
        protected int _fK_GLDebitAccountID;
        protected int _fK_GLCreditAccountID;
        #endregion

        #region Public properties
        public int ICShipmentTypeID
        {
            get { return _iCShipmentTypeID; }
            set
            {
                if (value != this._iCShipmentTypeID)
                {
                    _iCShipmentTypeID = value;
                    NotifyChanged("ICShipmentTypeID");
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
        public String ICShipmentTypeDesc
        {
            get { return _iCShipmentTypeDesc; }
            set
            {
                if (value != this._iCShipmentTypeDesc)
                {
                    _iCShipmentTypeDesc = value;
                    NotifyChanged("ICShipmentTypeDesc");
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
        public String ICShipmentTypeNo
        {
            get { return _iCShipmentTypeNo; }
            set
            {
                if (value != this._iCShipmentTypeNo)
                {
                    _iCShipmentTypeNo = value;
                    NotifyChanged("ICShipmentTypeNo");
                }
            }
        }
        public String ICShipmentTypeName
        {
            get { return _iCShipmentTypeName; }
            set
            {
                if (value != this._iCShipmentTypeName)
                {
                    _iCShipmentTypeName = value;
                    NotifyChanged("ICShipmentTypeName");
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