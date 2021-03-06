using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ACCostSimulationMethodProducts
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.4)
    //Class: ACCostSimulationMethodProductsInfo
    //Created Date: Tuesday, 20 Jun 2017
    //-----------------------------------------------------------

    public class ACCostSimulationMethodProductsInfo : BusinessObject
    {
        public ACCostSimulationMethodProductsInfo()
        {
        }
        #region Variables
        protected int _aCCostSimulationMethodProductID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ACCostSimulationMethodID;
        protected String _aCCostSimulationMethodProductNo = String.Empty;
        protected String _aCCostSimulationMethodProductColName = String.Empty;
        protected Nullable<DateTime> _aCCostSimulationMethodProductDate;
        protected String _aCCostSimulationMethodProductTypeCombo = String.Empty;
        protected double _aCCostSimulationMethodProductValue;
        protected String _aCCostSimulationMethodProductParamTypeCombo = String.Empty;

        #endregion

        #region Public properties
        public int ACCostSimulationMethodProductID
        {
            get { return _aCCostSimulationMethodProductID; }
            set
            {
                if (value != this._aCCostSimulationMethodProductID)
                {
                    _aCCostSimulationMethodProductID = value;
                    NotifyChanged("ACCostSimulationMethodProductID");
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
        public String ACCostSimulationMethodProductNo
        {
            get { return _aCCostSimulationMethodProductNo; }
            set
            {
                if (value != this._aCCostSimulationMethodProductNo)
                {
                    _aCCostSimulationMethodProductNo = value;
                    NotifyChanged("ACCostSimulationMethodProductNo");
                }
            }
        }
        public String ACCostSimulationMethodProductColName
        {
            get { return _aCCostSimulationMethodProductColName; }
            set
            {
                if (value != this._aCCostSimulationMethodProductColName)
                {
                    _aCCostSimulationMethodProductColName = value;
                    NotifyChanged("ACCostSimulationMethodProductColName");
                }
            }
        }
        public Nullable<DateTime> ACCostSimulationMethodProductDate
        {
            get { return _aCCostSimulationMethodProductDate; }
            set
            {
                if (value != this._aCCostSimulationMethodProductDate)
                {
                    _aCCostSimulationMethodProductDate = value;
                    NotifyChanged("ACCostSimulationMethodProductDate");
                }
            }
        }
        public String ACCostSimulationMethodProductTypeCombo
        {
            get { return _aCCostSimulationMethodProductTypeCombo; }
            set
            {
                if (value != this._aCCostSimulationMethodProductTypeCombo)
                {
                    _aCCostSimulationMethodProductTypeCombo = value;
                    NotifyChanged("ACCostSimulationMethodProductTypeCombo");
                }
            }
        }
        public double ACCostSimulationMethodProductValue
        {
            get { return _aCCostSimulationMethodProductValue; }
            set
            {
                if (value != this._aCCostSimulationMethodProductValue)
                {
                    _aCCostSimulationMethodProductValue = value;
                    NotifyChanged("ACCostSimulationMethodProductValue");
                }
            }
        }
        public String ACCostSimulationMethodProductParamTypeCombo
        {
            get { return _aCCostSimulationMethodProductParamTypeCombo; }
            set
            {
                if (value != this._aCCostSimulationMethodProductParamTypeCombo)
                {
                    _aCCostSimulationMethodProductParamTypeCombo = value;
                    NotifyChanged("ACCostSimulationMethodProductParamTypeCombo");
                }
            }
        }

        #endregion
    }
    #endregion
}