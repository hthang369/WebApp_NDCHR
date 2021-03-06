using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ACCostSimulationMethodItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.8)
    //Class: ACCostSimulationMethodItemsInfo
    //Created Date: Thursday, 29 Jun 2017
    //-----------------------------------------------------------

    public class ACCostSimulationMethodItemsInfo : BusinessObject
    {
        public ACCostSimulationMethodItemsInfo()
        {
        }
        #region Variables
        protected int _aCCostSimulationMethodItemID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ACCostSimulationMethodID;
        protected int _fK_ACCostSimulationFactorID;
        protected int _fK_ACCostSimulationMethodCatalogID;
        protected int _aCCostSimulationMethodItemSortOrder;

        #endregion

        #region Public properties
        public int ACCostSimulationMethodItemID
        {
            get { return _aCCostSimulationMethodItemID; }
            set
            {
                if (value != this._aCCostSimulationMethodItemID)
                {
                    _aCCostSimulationMethodItemID = value;
                    NotifyChanged("ACCostSimulationMethodItemID");
                }
            }
        }
        public Nullable<DateTime> AACreatedDate
        {
            get { return _aACreatedDate; }
            set
            {
                if (value != this._aACreatedDate)
                {
                    _aACreatedDate = value;
                    NotifyChanged("AACreatedDate");
                }
            }
        }
        public String AACreatedUser
        {
            get { return _aACreatedUser; }
            set
            {
                if (value != this._aACreatedUser)
                {
                    _aACreatedUser = value;
                    NotifyChanged("AACreatedUser");
                }
            }
        }
        public Nullable<DateTime> AAUpdatedDate
        {
            get { return _aAUpdatedDate; }
            set
            {
                if (value != this._aAUpdatedDate)
                {
                    _aAUpdatedDate = value;
                    NotifyChanged("AAUpdatedDate");
                }
            }
        }
        public String AAUpdatedUser
        {
            get { return _aAUpdatedUser; }
            set
            {
                if (value != this._aAUpdatedUser)
                {
                    _aAUpdatedUser = value;
                    NotifyChanged("AAUpdatedUser");
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
        public bool AASelected
        {
            get { return _aASelected; }
            set
            {
                if (value != this._aASelected)
                {
                    _aASelected = value;
                    NotifyChanged("AASelected");
                }
            }
        }
        public int FK_ACCostSimulationMethodID
        {
            get { return _fK_ACCostSimulationMethodID; }
            set
            {
                if (value != this._fK_ACCostSimulationMethodID)
                {
                    _fK_ACCostSimulationMethodID = value;
                    NotifyChanged("FK_ACCostSimulationMethodID");
                }
            }
        }
        public int FK_ACCostSimulationFactorID
        {
            get { return _fK_ACCostSimulationFactorID; }
            set
            {
                if (value != this._fK_ACCostSimulationFactorID)
                {
                    _fK_ACCostSimulationFactorID = value;
                    NotifyChanged("FK_ACCostSimulationFactorID");
                }
            }
        }
        public int FK_ACCostSimulationMethodCatalogID
        {
            get { return _fK_ACCostSimulationMethodCatalogID; }
            set
            {
                if (value != this._fK_ACCostSimulationMethodCatalogID)
                {
                    _fK_ACCostSimulationMethodCatalogID = value;
                    NotifyChanged("FK_ACCostSimulationMethodCatalogID");
                }
            }
        }
        public int ACCostSimulationMethodItemSortOrder
        {
            get { return _aCCostSimulationMethodItemSortOrder; }
            set
            {
                if (value != this._aCCostSimulationMethodItemSortOrder)
                {
                    _aCCostSimulationMethodItemSortOrder = value;
                    NotifyChanged("ACCostSimulationMethodItemSortOrder");
                }
            }
        }

        #endregion
    }
    #endregion
}