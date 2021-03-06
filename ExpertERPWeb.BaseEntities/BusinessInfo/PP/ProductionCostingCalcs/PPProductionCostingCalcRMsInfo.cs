using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPProductionCostingCalcRMs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.19)
    //Class: PPProductionCostingCalcRMsInfo
    //Created Date: Monday, 31 Jul 2017
    //-----------------------------------------------------------

    public class PPProductionCostingCalcRMsInfo : BusinessObject
    {
        public PPProductionCostingCalcRMsInfo()
        {
        }
        #region Variables
        protected int _pPProductionCostingCalcRMID;
        protected double _pPProductionCostingCalcRMShipmentQty;
        protected int _fK_ICProductID;
        protected int _fK_PPCostFactorID;
        protected int _fK_PPCostCenterID;
        protected double _pPProductionCostingCalcRMValUnitCost;
        protected int _fK_PPProductionCostingCalcs;
        protected double _pPProductionCostingCalcRMAllocationAmt;
        protected double _pPProductionCostingCalcRMNormAllocationAmt;
        protected double _pPProductionCostingCalcAmtTot;
        protected int _fK_ICProductFGID;
        protected int _fK_PPProductionCostingCalcResultID;

        #endregion

        #region Public properties
        public int PPProductionCostingCalcRMID
        {
            get { return _pPProductionCostingCalcRMID; }
            set
            {
                if (value != this._pPProductionCostingCalcRMID)
                {
                    _pPProductionCostingCalcRMID = value;
                    NotifyChanged("PPProductionCostingCalcRMID");
                }
            }
        }
        public double PPProductionCostingCalcRMShipmentQty
        {
            get { return _pPProductionCostingCalcRMShipmentQty; }
            set
            {
                if (value != this._pPProductionCostingCalcRMShipmentQty)
                {
                    _pPProductionCostingCalcRMShipmentQty = value;
                    NotifyChanged("PPProductionCostingCalcRMShipmentQty");
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
        public int FK_PPCostFactorID
        {
            get { return _fK_PPCostFactorID; }
            set
            {
                if (value != this._fK_PPCostFactorID)
                {
                    _fK_PPCostFactorID = value;
                    NotifyChanged("FK_PPCostFactorID");
                }
            }
        }
        public int FK_PPCostCenterID
        {
            get { return _fK_PPCostCenterID; }
            set
            {
                if (value != this._fK_PPCostCenterID)
                {
                    _fK_PPCostCenterID = value;
                    NotifyChanged("FK_PPCostCenterID");
                }
            }
        }
        public double PPProductionCostingCalcRMValUnitCost
        {
            get { return _pPProductionCostingCalcRMValUnitCost; }
            set
            {
                if (value != this._pPProductionCostingCalcRMValUnitCost)
                {
                    _pPProductionCostingCalcRMValUnitCost = value;
                    NotifyChanged("PPProductionCostingCalcRMValUnitCost");
                }
            }
        }
        public int FK_PPProductionCostingCalcs
        {
            get { return _fK_PPProductionCostingCalcs; }
            set
            {
                if (value != this._fK_PPProductionCostingCalcs)
                {
                    _fK_PPProductionCostingCalcs = value;
                    NotifyChanged("FK_PPProductionCostingCalcs");
                }
            }
        }
        public double PPProductionCostingCalcRMAllocationAmt
        {
            get { return _pPProductionCostingCalcRMAllocationAmt; }
            set
            {
                if (value != this._pPProductionCostingCalcRMAllocationAmt)
                {
                    _pPProductionCostingCalcRMAllocationAmt = value;
                    NotifyChanged("PPProductionCostingCalcRMAllocationAmt");
                }
            }
        }
        public double PPProductionCostingCalcRMNormAllocationAmt
        {
            get { return _pPProductionCostingCalcRMNormAllocationAmt; }
            set
            {
                if (value != this._pPProductionCostingCalcRMNormAllocationAmt)
                {
                    _pPProductionCostingCalcRMNormAllocationAmt = value;
                    NotifyChanged("PPProductionCostingCalcRMNormAllocationAmt");
                }
            }
        }
        public double PPProductionCostingCalcAmtTot
        {
            get { return _pPProductionCostingCalcAmtTot; }
            set
            {
                if (value != this._pPProductionCostingCalcAmtTot)
                {
                    _pPProductionCostingCalcAmtTot = value;
                    NotifyChanged("PPProductionCostingCalcAmtTot");
                }
            }
        }
        public int FK_ICProductFGID
        {
            get { return _fK_ICProductFGID; }
            set
            {
                if (value != this._fK_ICProductFGID)
                {
                    _fK_ICProductFGID = value;
                    NotifyChanged("FK_ICProductFGID");
                }
            }
        }
        public int FK_PPProductionCostingCalcResultID
        {
            get { return _fK_PPProductionCostingCalcResultID; }
            set
            {
                if (value != this._fK_PPProductionCostingCalcResultID)
                {
                    _fK_PPProductionCostingCalcResultID = value;
                    NotifyChanged("FK_PPProductionCostingCalcResultID");
                }
            }
        }

        #endregion
    }
    #endregion
}