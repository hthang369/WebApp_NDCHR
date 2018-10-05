using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewRcpShpTrfs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ViewRcpShpTrfsInfo
    //Created Date:11 Tháng Ba 2013
    //-----------------------------------------------------------

    public class ViewRcpShpTrfsInfo : BusinessObject
    {
        public ViewRcpShpTrfsInfo()
        {
        }
        #region Variables
        protected int _viewRcpShpTrfID;
        protected String _viewRcpShpTrfNo = String.Empty;
        protected String _viewRcpShpTrfName = String.Empty;
        protected String _viewRcpShpTrfTypeCombo = String.Empty;
        protected int _fK_PPWOID;
        protected int _fK_ICTransferID;
        protected int _fK_PPProductionOrdrID;
        protected int _fK_ICStockID;
        protected int _fK_ICProductID;
        protected double _qty;
        protected int _fK_ARSOID;
        #endregion

        #region Public properties
        public int ViewRcpShpTrfID
        {
            get { return _viewRcpShpTrfID; }
            set
            {
                if (value != this._viewRcpShpTrfID)
                {
                    _viewRcpShpTrfID = value;
                    NotifyChanged("ViewRcpShpTrfID");
                }
            }
        }
        public String ViewRcpShpTrfNo
        {
            get { return _viewRcpShpTrfNo; }
            set
            {
                if (value != this._viewRcpShpTrfNo)
                {
                    _viewRcpShpTrfNo = value;
                    NotifyChanged("ViewRcpShpTrfNo");
                }
            }
        }
        public String ViewRcpShpTrfName
        {
            get { return _viewRcpShpTrfName; }
            set
            {
                if (value != this._viewRcpShpTrfName)
                {
                    _viewRcpShpTrfName = value;
                    NotifyChanged("ViewRcpShpTrfName");
                }
            }
        }
        public String ViewRcpShpTrfTypeCombo
        {
            get { return _viewRcpShpTrfTypeCombo; }
            set
            {
                if (value != this._viewRcpShpTrfTypeCombo)
                {
                    _viewRcpShpTrfTypeCombo = value;
                    NotifyChanged("ViewRcpShpTrfTypeCombo");
                }
            }
        }
        public int FK_PPWOID
        {
            get { return _fK_PPWOID; }
            set
            {
                if (value != this._fK_PPWOID)
                {
                    _fK_PPWOID = value;
                    NotifyChanged("FK_PPWOID");
                }
            }
        }
        public int FK_ICTransferID
        {
            get { return _fK_ICTransferID; }
            set
            {
                if (value != this._fK_ICTransferID)
                {
                    _fK_ICTransferID = value;
                    NotifyChanged("FK_ICTransferID");
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
        public double Qty
        {
            get { return _qty; }
            set
            {
                if (value != this._qty)
                {
                    _qty = value;
                    NotifyChanged("Qty");
                }
            }
        }
        public int FK_ARSOID
        {
            get { return _fK_ARSOID; }
            set
            {
                if (value != this._fK_ARSOID)
                {
                    _fK_ARSOID = value;
                    NotifyChanged("FK_ARSOID");
                }
            }
        }
        #endregion
    }
    #endregion
}