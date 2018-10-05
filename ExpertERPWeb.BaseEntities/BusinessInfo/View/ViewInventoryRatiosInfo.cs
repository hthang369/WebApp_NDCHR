using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewInventoryRatios
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ViewInventoryRatiosInfo
    //Created Date:28 Tháng Tư 2012
    //-----------------------------------------------------------

    public class ViewInventoryRatiosInfo : BusinessObject
    {
        public ViewInventoryRatiosInfo()
        {
        }
        #region Variables
        protected int _viewInventoryRatioID;
        protected double _inventoryTurnOver;
        protected double _dayOfInventory;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected double _beginQty;
        protected double _endQty;
        protected double _cOGS;
        protected double _beginAmt;
        protected double _endAmt;
        #endregion

        #region Public properties
        public int ViewInventoryRatioID
        {
            get { return _viewInventoryRatioID; }
            set
            {
                if (value != this._viewInventoryRatioID)
                {
                    _viewInventoryRatioID = value;
                    NotifyChanged("ViewInventoryRatioID");
                }
            }
        }
        public double InventoryTurnOver
        {
            get { return _inventoryTurnOver; }
            set
            {
                if (value != this._inventoryTurnOver)
                {
                    _inventoryTurnOver = value;
                    NotifyChanged("InventoryTurnOver");
                }
            }
        }
        public double DayOfInventory
        {
            get { return _dayOfInventory; }
            set
            {
                if (value != this._dayOfInventory)
                {
                    _dayOfInventory = value;
                    NotifyChanged("DayOfInventory");
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
        public double BeginQty
        {
            get { return _beginQty; }
            set
            {
                if (value != this._beginQty)
                {
                    _beginQty = value;
                    NotifyChanged("BeginQty");
                }
            }
        }
        public double EndQty
        {
            get { return _endQty; }
            set
            {
                if (value != this._endQty)
                {
                    _endQty = value;
                    NotifyChanged("EndQty");
                }
            }
        }
        public double COGS
        {
            get { return _cOGS; }
            set
            {
                if (value != this._cOGS)
                {
                    _cOGS = value;
                    NotifyChanged("COGS");
                }
            }
        }
        public double BeginAmt
        {
            get { return _beginAmt; }
            set
            {
                if (value != this._beginAmt)
                {
                    _beginAmt = value;
                    NotifyChanged("BeginAmt");
                }
            }
        }
        public double EndAmt
        {
            get { return _endAmt; }
            set
            {
                if (value != this._endAmt)
                {
                    _endAmt = value;
                    NotifyChanged("EndAmt");
                }
            }
        }
        #endregion
    }
    #endregion
}