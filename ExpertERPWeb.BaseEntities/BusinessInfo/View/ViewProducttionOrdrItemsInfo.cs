using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewProducttionOrdrItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ViewProducttionOrdrItemsInfo
    //Created Date:18 Tháng Mười Một 2012
    //-----------------------------------------------------------

    public class ViewProducttionOrdrItemsInfo : BusinessObject
    {
        public ViewProducttionOrdrItemsInfo()
        {
        }
        #region Variables
        protected int _viewProductionOrdrItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_PPProductionOrdrID;
        protected int _fK_ICProductShpID;
        protected double _iCShipmentItemQty;
        protected int _fK_ICStockShpID;
        protected int _fK_PPPhaseCfgShpID;
        protected int _fK_ICProductWOShpID;
        protected String _iCShipmentItemDesc = String.Empty;
        protected int _fK_ICProductRcpID;
        protected double _iCReceiptItemQty;
        protected int _fK_ICStockRcpId;
        protected int _fK_PPPhaseCfgRcpID;
        protected int _fK_ICProductWORcpID;
        protected String _iCReceiptItemDesc = String.Empty;
        #endregion

        #region Public properties
        public int ViewProductionOrdrItemID
        {
            get { return _viewProductionOrdrItemID; }
            set
            {
                if (value != this._viewProductionOrdrItemID)
                {
                    _viewProductionOrdrItemID = value;
                    NotifyChanged("ViewProductionOrdrItemID");
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
        public int FK_PPProductionOrdrID
        {
            get { return _fK_PPProductionOrdrID; }
            set
            {
                if (value != this._fK_PPProductionOrdrID)
                {
                    _fK_PPProductionOrdrID = value;
                    NotifyChanged("FK_PPProductionOrdrID");
                }
            }
        }
        public int FK_ICProductShpID
        {
            get { return _fK_ICProductShpID; }
            set
            {
                if (value != this._fK_ICProductShpID)
                {
                    _fK_ICProductShpID = value;
                    NotifyChanged("FK_ICProductShpID");
                }
            }
        }
        public double ICShipmentItemQty
        {
            get { return _iCShipmentItemQty; }
            set
            {
                if (value != this._iCShipmentItemQty)
                {
                    _iCShipmentItemQty = value;
                    NotifyChanged("ICShipmentItemQty");
                }
            }
        }
        public int FK_ICStockShpID
        {
            get { return _fK_ICStockShpID; }
            set
            {
                if (value != this._fK_ICStockShpID)
                {
                    _fK_ICStockShpID = value;
                    NotifyChanged("FK_ICStockShpID");
                }
            }
        }
        public int FK_PPPhaseCfgShpID
        {
            get { return _fK_PPPhaseCfgShpID; }
            set
            {
                if (value != this._fK_PPPhaseCfgShpID)
                {
                    _fK_PPPhaseCfgShpID = value;
                    NotifyChanged("FK_PPPhaseCfgShpID");
                }
            }
        }
        public int FK_ICProductWOShpID
        {
            get { return _fK_ICProductWOShpID; }
            set
            {
                if (value != this._fK_ICProductWOShpID)
                {
                    _fK_ICProductWOShpID = value;
                    NotifyChanged("FK_ICProductWOShpID");
                }
            }
        }
        public String ICShipmentItemDesc
        {
            get { return _iCShipmentItemDesc; }
            set
            {
                if (value != this._iCShipmentItemDesc)
                {
                    _iCShipmentItemDesc = value;
                    NotifyChanged("ICShipmentItemDesc");
                }
            }
        }
        public int FK_ICProductRcpID
        {
            get { return _fK_ICProductRcpID; }
            set
            {
                if (value != this._fK_ICProductRcpID)
                {
                    _fK_ICProductRcpID = value;
                    NotifyChanged("FK_ICProductRcpID");
                }
            }
        }
        public double ICReceiptItemQty
        {
            get { return _iCReceiptItemQty; }
            set
            {
                if (value != this._iCReceiptItemQty)
                {
                    _iCReceiptItemQty = value;
                    NotifyChanged("ICReceiptItemQty");
                }
            }
        }
        public int FK_ICStockRcpId
        {
            get { return _fK_ICStockRcpId; }
            set
            {
                if (value != this._fK_ICStockRcpId)
                {
                    _fK_ICStockRcpId = value;
                    NotifyChanged("FK_ICStockRcpId");
                }
            }
        }
        public int FK_PPPhaseCfgRcpID
        {
            get { return _fK_PPPhaseCfgRcpID; }
            set
            {
                if (value != this._fK_PPPhaseCfgRcpID)
                {
                    _fK_PPPhaseCfgRcpID = value;
                    NotifyChanged("FK_PPPhaseCfgRcpID");
                }
            }
        }
        public int FK_ICProductWORcpID
        {
            get { return _fK_ICProductWORcpID; }
            set
            {
                if (value != this._fK_ICProductWORcpID)
                {
                    _fK_ICProductWORcpID = value;
                    NotifyChanged("FK_ICProductWORcpID");
                }
            }
        }
        public String ICReceiptItemDesc
        {
            get { return _iCReceiptItemDesc; }
            set
            {
                if (value != this._iCReceiptItemDesc)
                {
                    _iCReceiptItemDesc = value;
                    NotifyChanged("ICReceiptItemDesc");
                }
            }
        }
        #endregion
    }
    #endregion
}