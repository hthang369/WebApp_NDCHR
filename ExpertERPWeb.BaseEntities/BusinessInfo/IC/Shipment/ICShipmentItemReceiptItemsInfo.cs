using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICShipmentItemReceiptItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICShipmentItemReceiptItemsInfo
    //Created Date:Friday, June 17, 2011
    //-----------------------------------------------------------

    public class ICShipmentItemReceiptItemsInfo : BusinessObject
    {
        public ICShipmentItemReceiptItemsInfo()
        {
        }
        #region Variables
        protected int _iCShipmentItemReceiptItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICShipmentItemID;
        protected int _fK_ICReceiptItemID;
        protected double _iCShipmentItemReceiptItemQty;
        #endregion

        #region Public properties
        public int ICShipmentItemReceiptItemID
        {
            get { return _iCShipmentItemReceiptItemID; }
            set
            {
                if (value != this._iCShipmentItemReceiptItemID)
                {
                    _iCShipmentItemReceiptItemID = value;
                    NotifyChanged("ICShipmentItemReceiptItemID");
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
        public int FK_ICShipmentItemID
        {
            get { return _fK_ICShipmentItemID; }
            set
            {
                if (value != this._fK_ICShipmentItemID)
                {
                    _fK_ICShipmentItemID = value;
                    NotifyChanged("FK_ICShipmentItemID");
                }
            }
        }
        public int FK_ICReceiptItemID
        {
            get { return _fK_ICReceiptItemID; }
            set
            {
                if (value != this._fK_ICReceiptItemID)
                {
                    _fK_ICReceiptItemID = value;
                    NotifyChanged("FK_ICReceiptItemID");
                }
            }
        }
        public double ICShipmentItemReceiptItemQty
        {
            get { return _iCShipmentItemReceiptItemQty; }
            set
            {
                if (value != this._iCShipmentItemReceiptItemQty)
                {
                    _iCShipmentItemReceiptItemQty = value;
                    NotifyChanged("ICShipmentItemReceiptItemQty");
                }
            }
        }
        #endregion
    }
    #endregion
}