using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICInventoryStockSlotSeries
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICInventoryStockSlotSeriesInfo
    //Created Date:Monday, March 24, 2008
    //-----------------------------------------------------------

    public class ICInventoryStockSlotSeriesInfo : BusinessObject
    {
        public ICInventoryStockSlotSeriesInfo()
        {
        }
        #region Variables
        protected int _iCInventoryStockSlotSerieID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICInventoryStockSlotID;
        protected int _fK_ICProductID;
        protected int _fK_ICProductSerieID;
        protected double _iCInventoryStockSlotSerieQuantity;
        protected double _iCInventoryStockSlotSerieProposalQuantity;
        protected double _iCInventoryStockSlotSerieSaleOrderQuantity;
        protected double _iCInventoryStockSlotSeriePurchaseOrderQuantity;
        #endregion

        #region Public properties
        public int ICInventoryStockSlotSerieID
        {
            get { return _iCInventoryStockSlotSerieID; }
            set
            {
                if (value != this._iCInventoryStockSlotSerieID)
                {
                    _iCInventoryStockSlotSerieID = value;
                    NotifyChanged("ICInventoryStockSlotSerieID");
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
        public int FK_ICInventoryStockSlotID
        {
            get { return _fK_ICInventoryStockSlotID; }
            set
            {
                if (value != this._fK_ICInventoryStockSlotID)
                {
                    _fK_ICInventoryStockSlotID = value;
                    NotifyChanged("FK_ICInventoryStockSlotID");
                }
            }
        }
        public int FK_ICProductID
        {
            get { return _fK_ICProductID; }
            set
            {
                if (value != this._fK_ICProductID)
                {
                    _fK_ICProductID = value;
                    NotifyChanged("FK_ICProductID");
                }
            }
        }
        public int FK_ICProductSerieID
        {
            get { return _fK_ICProductSerieID; }
            set
            {
                if (value != this._fK_ICProductSerieID)
                {
                    _fK_ICProductSerieID = value;
                    NotifyChanged("FK_ICProductSerieID");
                }
            }
        }
        public double ICInventoryStockSlotSerieQuantity
        {
            get { return _iCInventoryStockSlotSerieQuantity; }
            set
            {
                if (value != this._iCInventoryStockSlotSerieQuantity)
                {
                    _iCInventoryStockSlotSerieQuantity = value;
                    NotifyChanged("ICInventoryStockSlotSerieQuantity");
                }
            }
        }
        public double ICInventoryStockSlotSerieProposalQuantity
        {
            get { return _iCInventoryStockSlotSerieProposalQuantity; }
            set
            {
                if (value != this._iCInventoryStockSlotSerieProposalQuantity)
                {
                    _iCInventoryStockSlotSerieProposalQuantity = value;
                    NotifyChanged("ICInventoryStockSlotSerieProposalQuantity");
                }
            }
        }
        public double ICInventoryStockSlotSerieSaleOrderQuantity
        {
            get { return _iCInventoryStockSlotSerieSaleOrderQuantity; }
            set
            {
                if (value != this._iCInventoryStockSlotSerieSaleOrderQuantity)
                {
                    _iCInventoryStockSlotSerieSaleOrderQuantity = value;
                    NotifyChanged("ICInventoryStockSlotSerieSaleOrderQuantity");
                }
            }
        }
        public double ICInventoryStockSlotSeriePurchaseOrderQuantity
        {
            get { return _iCInventoryStockSlotSeriePurchaseOrderQuantity; }
            set
            {
                if (value != this._iCInventoryStockSlotSeriePurchaseOrderQuantity)
                {
                    _iCInventoryStockSlotSeriePurchaseOrderQuantity = value;
                    NotifyChanged("ICInventoryStockSlotSeriePurchaseOrderQuantity");
                }
            }
        }
        #endregion
    }
    #endregion
}