using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ACCostSimulationMethodItemParamFormulas
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.5)
    //Class: ACCostSimulationMethodItemParamFormulasInfo
    //Created Date: Tuesday, 20 Jun 2017
    //-----------------------------------------------------------

    public class ACCostSimulationMethodItemParamFormulasInfo : BusinessObject
    {
        public ACCostSimulationMethodItemParamFormulasInfo()
        {
        }
        #region Variables
        protected int _aCCostSimulationMethodItemParamFormulaID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ACCostSimulationMethodItemParamID;
        protected int _fK_ACCostSimulationMethodItemParamValueID;
        protected String _aCCostSimulationMethodItemParamFormulaOperCombo = String.Empty;
        protected int _aCCostSimulationMethodItemParamFormulaOrder;
        protected String _aCCostSimulationMethodItemParamFormulaFunc = String.Empty;

        #endregion

        #region Public properties
        public int ACCostSimulationMethodItemParamFormulaID
        {
            get { return _aCCostSimulationMethodItemParamFormulaID; }
            set
            {
                if (value != this._aCCostSimulationMethodItemParamFormulaID)
                {
                    _aCCostSimulationMethodItemParamFormulaID = value;
                    NotifyChanged("ACCostSimulationMethodItemParamFormulaID");
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
        public int FK_ACCostSimulationMethodItemParamID
        {
            get { return _fK_ACCostSimulationMethodItemParamID; }
            set
            {
                if (value != this._fK_ACCostSimulationMethodItemParamID)
                {
                    _fK_ACCostSimulationMethodItemParamID = value;
                    NotifyChanged("FK_ACCostSimulationMethodItemParamID");
                }
            }
        }
        public int FK_ACCostSimulationMethodItemParamValueID
        {
            get { return _fK_ACCostSimulationMethodItemParamValueID; }
            set
            {
                if (value != this._fK_ACCostSimulationMethodItemParamValueID)
                {
                    _fK_ACCostSimulationMethodItemParamValueID = value;
                    NotifyChanged("FK_ACCostSimulationMethodItemParamValueID");
                }
            }
        }
        public String ACCostSimulationMethodItemParamFormulaOperCombo
        {
            get { return _aCCostSimulationMethodItemParamFormulaOperCombo; }
            set
            {
                if (value != this._aCCostSimulationMethodItemParamFormulaOperCombo)
                {
                    _aCCostSimulationMethodItemParamFormulaOperCombo = value;
                    NotifyChanged("ACCostSimulationMethodItemParamFormulaOperCombo");
                }
            }
        }
        public int ACCostSimulationMethodItemParamFormulaOrder
        {
            get { return _aCCostSimulationMethodItemParamFormulaOrder; }
            set
            {
                if (value != this._aCCostSimulationMethodItemParamFormulaOrder)
                {
                    _aCCostSimulationMethodItemParamFormulaOrder = value;
                    NotifyChanged("ACCostSimulationMethodItemParamFormulaOrder");
                }
            }
        }
        public String ACCostSimulationMethodItemParamFormulaFunc
        {
            get { return _aCCostSimulationMethodItemParamFormulaFunc; }
            set
            {
                if (value != this._aCCostSimulationMethodItemParamFormulaFunc)
                {
                    _aCCostSimulationMethodItemParamFormulaFunc = value;
                    NotifyChanged("ACCostSimulationMethodItemParamFormulaFunc");
                }
            }
        }

        #endregion
    }
    #endregion
}