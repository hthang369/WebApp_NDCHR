using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationCfgParamConditions
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationCfgParamConditionsInfo
	//Created Date:22 Tháng Mười 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationCfgParamConditionsInfo:BusinessObject
	{
		public ACCostSimulationCfgParamConditionsInfo()
		{
		}
		#region Variables
		protected int _aCCostSimulationCfgParamConditionID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ACCostSimulationCfgParamID;
		protected String _aCCostSimulationCfgParamConditionTypeCombo=String.Empty;
		protected String _aCCostSimulationCfgParamConditionColumnName=String.Empty;
		protected String _aCCostSimulationCfgParamConditionOperCombo=String.Empty;
		protected String _aCCostSimulationCfgParamConditionColumnValue=String.Empty;
		#endregion

		#region Public properties
		public int ACCostSimulationCfgParamConditionID
		{
			get{return _aCCostSimulationCfgParamConditionID;}
			set
			{
				if (value != this._aCCostSimulationCfgParamConditionID)
				{
				_aCCostSimulationCfgParamConditionID=value;
				NotifyChanged("ACCostSimulationCfgParamConditionID");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get{return _aACreatedDate;}
			set
			{
				if (value != this._aACreatedDate)
				{
				_aACreatedDate=value;
				NotifyChanged("AACreatedDate");
				}
			}
		}
		public String AACreatedUser
		{
			get{return _aACreatedUser;}
			set
			{
				if (value != this._aACreatedUser)
				{
				_aACreatedUser=value;
				NotifyChanged("AACreatedUser");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get{return _aAUpdatedDate;}
			set
			{
				if (value != this._aAUpdatedDate)
				{
				_aAUpdatedDate=value;
				NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String AAUpdatedUser
		{
			get{return _aAUpdatedUser;}
			set
			{
				if (value != this._aAUpdatedUser)
				{
				_aAUpdatedUser=value;
				NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
				_aAStatus=value;
				NotifyChanged("AAStatus");
				}
			}
		}
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
				_aASelected=value;
				NotifyChanged("AASelected");
				}
			}
		}
		public int FK_ACCostSimulationCfgParamID
		{
			get{return _fK_ACCostSimulationCfgParamID;}
			set
			{
				if (value != this._fK_ACCostSimulationCfgParamID)
				{
				_fK_ACCostSimulationCfgParamID=value;
				NotifyChanged("FK_ACCostSimulationCfgParamID");
				}
			}
		}
		public String ACCostSimulationCfgParamConditionTypeCombo
		{
			get{return _aCCostSimulationCfgParamConditionTypeCombo;}
			set
			{
				if (value != this._aCCostSimulationCfgParamConditionTypeCombo)
				{
				_aCCostSimulationCfgParamConditionTypeCombo=value;
				NotifyChanged("ACCostSimulationCfgParamConditionTypeCombo");
				}
			}
		}
		public String ACCostSimulationCfgParamConditionColumnName
		{
			get{return _aCCostSimulationCfgParamConditionColumnName;}
			set
			{
				if (value != this._aCCostSimulationCfgParamConditionColumnName)
				{
				_aCCostSimulationCfgParamConditionColumnName=value;
				NotifyChanged("ACCostSimulationCfgParamConditionColumnName");
				}
			}
		}
		public String ACCostSimulationCfgParamConditionOperCombo
		{
			get{return _aCCostSimulationCfgParamConditionOperCombo;}
			set
			{
				if (value != this._aCCostSimulationCfgParamConditionOperCombo)
				{
				_aCCostSimulationCfgParamConditionOperCombo=value;
				NotifyChanged("ACCostSimulationCfgParamConditionOperCombo");
				}
			}
		}
		public String ACCostSimulationCfgParamConditionColumnValue
		{
			get{return _aCCostSimulationCfgParamConditionColumnValue;}
			set
			{
				if (value != this._aCCostSimulationCfgParamConditionColumnValue)
				{
				_aCCostSimulationCfgParamConditionColumnValue=value;
				NotifyChanged("ACCostSimulationCfgParamConditionColumnValue");
				}
			}
		}
		#endregion
	}
	#endregion
}