using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPFGCostings
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPFGCostingsInfo
    //Created Date:19 Tha�ng M���i Hai 2011
    //-----------------------------------------------------------

    public class PPFGCostingsInfo : BusinessObject
    {
        public PPFGCostingsInfo()
        {
        }
        #region Variables
        protected int _pPFGCostingID;
        protected int _pPPeriod;
        protected int _pPYear;
        protected int _fK_ICProductID;
        protected double _pPFGQty;
        protected double _pPInComFGBeginCost;
        protected double _pPFGRMCost;
        protected double _pPFGLabourCost;
        protected double _pPFGOverheadCost;
        protected double _pPInComFGEndCost;
        protected double _pPFGCostTot;
        protected double _pPFGUnitCost;
        #endregion

        #region Public properties
        public int PPFGCostingID
        {
            get { return _pPFGCostingID; }
            set
            {
                if (value != this._pPFGCostingID)
                {
                    _pPFGCostingID = value;
                    NotifyChanged("PPFGCostingID");
                }
            }
        }
        public int PPPeriod
        {
            get { return _pPPeriod; }
            set
            {
                if (value != this._pPPeriod)
                {
                    _pPPeriod = value;
                    NotifyChanged("PPPeriod");
                }
            }
        }
        public int PPYear
        {
            get { return _pPYear; }
            set
            {
                if (value != this._pPYear)
                {
                    _pPYear = value;
                    NotifyChanged("PPYear");
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
        public double PPFGQty
        {
            get { return _pPFGQty; }
            set
            {
                if (value != this._pPFGQty)
                {
                    _pPFGQty = value;
                    NotifyChanged("PPFGQty");
                }
            }
        }
        public double PPInComFGBeginCost
        {
            get { return _pPInComFGBeginCost; }
            set
            {
                if (value != this._pPInComFGBeginCost)
                {
                    _pPInComFGBeginCost = value;
                    NotifyChanged("PPInComFGBeginCost");
                }
            }
        }
        public double PPFGRMCost
        {
            get { return _pPFGRMCost; }
            set
            {
                if (value != this._pPFGRMCost)
                {
                    _pPFGRMCost = value;
                    NotifyChanged("PPFGRMCost");
                }
            }
        }
        public double PPFGLabourCost
        {
            get { return _pPFGLabourCost; }
            set
            {
                if (value != this._pPFGLabourCost)
                {
                    _pPFGLabourCost = value;
                    NotifyChanged("PPFGLabourCost");
                }
            }
        }
        public double PPFGOverheadCost
        {
            get { return _pPFGOverheadCost; }
            set
            {
                if (value != this._pPFGOverheadCost)
                {
                    _pPFGOverheadCost = value;
                    NotifyChanged("PPFGOverheadCost");
                }
            }
        }
        public double PPInComFGEndCost
        {
            get { return _pPInComFGEndCost; }
            set
            {
                if (value != this._pPInComFGEndCost)
                {
                    _pPInComFGEndCost = value;
                    NotifyChanged("PPInComFGEndCost");
                }
            }
        }
        public double PPFGCostTot
        {
            get { return _pPFGCostTot; }
            set
            {
                if (value != this._pPFGCostTot)
                {
                    _pPFGCostTot = value;
                    NotifyChanged("PPFGCostTot");
                }
            }
        }
        public double PPFGUnitCost
        {
            get { return _pPFGUnitCost; }
            set
            {
                if (value != this._pPFGUnitCost)
                {
                    _pPFGUnitCost = value;
                    NotifyChanged("PPFGUnitCost");
                }
            }
        }
        #endregion
    }
    #endregion
}