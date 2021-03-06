using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ACCostSimulationCfgParams
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v1.0.24)
    //Class: ACCostSimulationCfgParamsInfo
    //Created Date: Thursday, 11 May 2017
    //-----------------------------------------------------------

    public class ACCostSimulationCfgParamsInfo : BusinessObject
    {
        public ACCostSimulationCfgParamsInfo()
        {
        }
        #region Variables
        protected int _aCCostSimulationCfgParamID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aCCostSimulationCfgParamNo = String.Empty;
        protected Nullable<DateTime> _aCCostSimulationCfgParamDate;
        protected String _aCCostSimulationCfgParamTableName = String.Empty;
        protected String _aCCostSimulationCfgParamColumnName = String.Empty;
        protected String _aCCostSimulationCfgParamForeignColumnName = String.Empty;
        protected String _aCCostSimulationCfgParamParentTableName = String.Empty;
        protected String _aCCostSimulationCfgParamColumnNameDesc = String.Empty;

        #endregion

        #region Public properties
        public int ACCostSimulationCfgParamID
        {
            get { return _aCCostSimulationCfgParamID; }
            set
            {
                if (value != this._aCCostSimulationCfgParamID)
                {
                    _aCCostSimulationCfgParamID = value;
                    NotifyChanged("ACCostSimulationCfgParamID");
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
        public String ACCostSimulationCfgParamNo
        {
            get { return _aCCostSimulationCfgParamNo; }
            set
            {
                if (value != this._aCCostSimulationCfgParamNo)
                {
                    _aCCostSimulationCfgParamNo = value;
                    NotifyChanged("ACCostSimulationCfgParamNo");
                }
            }
        }
        public Nullable<DateTime> ACCostSimulationCfgParamDate
        {
            get { return _aCCostSimulationCfgParamDate; }
            set
            {
                if (value != this._aCCostSimulationCfgParamDate)
                {
                    _aCCostSimulationCfgParamDate = value;
                    NotifyChanged("ACCostSimulationCfgParamDate");
                }
            }
        }
        public String ACCostSimulationCfgParamTableName
        {
            get { return _aCCostSimulationCfgParamTableName; }
            set
            {
                if (value != this._aCCostSimulationCfgParamTableName)
                {
                    _aCCostSimulationCfgParamTableName = value;
                    NotifyChanged("ACCostSimulationCfgParamTableName");
                }
            }
        }
        public String ACCostSimulationCfgParamColumnName
        {
            get { return _aCCostSimulationCfgParamColumnName; }
            set
            {
                if (value != this._aCCostSimulationCfgParamColumnName)
                {
                    _aCCostSimulationCfgParamColumnName = value;
                    NotifyChanged("ACCostSimulationCfgParamColumnName");
                }
            }
        }
        public String ACCostSimulationCfgParamForeignColumnName
        {
            get { return _aCCostSimulationCfgParamForeignColumnName; }
            set
            {
                if (value != this._aCCostSimulationCfgParamForeignColumnName)
                {
                    _aCCostSimulationCfgParamForeignColumnName = value;
                    NotifyChanged("ACCostSimulationCfgParamForeignColumnName");
                }
            }
        }
        public String ACCostSimulationCfgParamParentTableName
        {
            get { return _aCCostSimulationCfgParamParentTableName; }
            set
            {
                if (value != this._aCCostSimulationCfgParamParentTableName)
                {
                    _aCCostSimulationCfgParamParentTableName = value;
                    NotifyChanged("ACCostSimulationCfgParamParentTableName");
                }
            }
        }
        public String ACCostSimulationCfgParamColumnNameDesc
        {
            get { return _aCCostSimulationCfgParamColumnNameDesc; }
            set
            {
                if (value != this._aCCostSimulationCfgParamColumnNameDesc)
                {
                    _aCCostSimulationCfgParamColumnNameDesc = value;
                    NotifyChanged("ACCostSimulationCfgParamColumnNameDesc");
                }
            }
        }

        #endregion
    }
    #endregion
}