 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ACCostSimulationProductColumns
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.10)
    //Class: ACCostSimulationProductColumnsInfo
    //Created Date: Monday, 03 Jul 2017
    //-----------------------------------------------------------

    public class ACCostSimulationProductColumnsInfo : BusinessObject
    {
        public ACCostSimulationProductColumnsInfo()
        {
        }
        #region Variables
		protected int _aCCostSimulationProductColumnID;
		protected String _aACreatedUser = String.Empty;
		protected String _aAUpdatedUser = String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected int _fK_ACCostSimulationID;
		protected int _fK_ACCostSimulationProductID;
		protected int _fK_ACCostSimulationMethodProductID;
		protected String _aCCostSimulationProductColumnColName = String.Empty;
		protected String _aCCostSimulationProductColumnColMap = String.Empty;
		protected String _aCCostSimulationProductColumnColDisplay = String.Empty;
		protected String _aCCostSimulationProductColumnType = String.Empty;
		protected String _aCCostSimulationProductColumnColValue = String.Empty;
		
        #endregion

        #region Public properties
		public int ACCostSimulationProductColumnID
		{
			get { return _aCCostSimulationProductColumnID; }
			set
			{
				if (value != this._aCCostSimulationProductColumnID)
				{
					_aCCostSimulationProductColumnID = value;
					NotifyChanged("ACCostSimulationProductColumnID");
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
		public int FK_ACCostSimulationID
		{
			get { return _fK_ACCostSimulationID; }
			set
			{
				if (value != this._fK_ACCostSimulationID)
				{
					_fK_ACCostSimulationID = value;
					NotifyChanged("FK_ACCostSimulationID");
				}
			}
		}
		public int FK_ACCostSimulationProductID
		{
			get { return _fK_ACCostSimulationProductID; }
			set
			{
				if (value != this._fK_ACCostSimulationProductID)
				{
					_fK_ACCostSimulationProductID = value;
					NotifyChanged("FK_ACCostSimulationProductID");
				}
			}
		}
		public int FK_ACCostSimulationMethodProductID
		{
			get { return _fK_ACCostSimulationMethodProductID; }
			set
			{
				if (value != this._fK_ACCostSimulationMethodProductID)
				{
					_fK_ACCostSimulationMethodProductID = value;
					NotifyChanged("FK_ACCostSimulationMethodProductID");
				}
			}
		}
		public String ACCostSimulationProductColumnColName
		{
			get { return _aCCostSimulationProductColumnColName; }
			set
			{
				if (value != this._aCCostSimulationProductColumnColName)
				{
					_aCCostSimulationProductColumnColName = value;
					NotifyChanged("ACCostSimulationProductColumnColName");
				}
			}
		}
		public String ACCostSimulationProductColumnColMap
		{
			get { return _aCCostSimulationProductColumnColMap; }
			set
			{
				if (value != this._aCCostSimulationProductColumnColMap)
				{
					_aCCostSimulationProductColumnColMap = value;
					NotifyChanged("ACCostSimulationProductColumnColMap");
				}
			}
		}
		public String ACCostSimulationProductColumnColDisplay
		{
			get { return _aCCostSimulationProductColumnColDisplay; }
			set
			{
				if (value != this._aCCostSimulationProductColumnColDisplay)
				{
					_aCCostSimulationProductColumnColDisplay = value;
					NotifyChanged("ACCostSimulationProductColumnColDisplay");
				}
			}
		}
		public String ACCostSimulationProductColumnType
		{
			get { return _aCCostSimulationProductColumnType; }
			set
			{
				if (value != this._aCCostSimulationProductColumnType)
				{
					_aCCostSimulationProductColumnType = value;
					NotifyChanged("ACCostSimulationProductColumnType");
				}
			}
		}
		public String ACCostSimulationProductColumnColValue
		{
			get { return _aCCostSimulationProductColumnColValue; }
			set
			{
				if (value != this._aCCostSimulationProductColumnColValue)
				{
					_aCCostSimulationProductColumnColValue = value;
					NotifyChanged("ACCostSimulationProductColumnColValue");
				}
			}
		}
		
        #endregion
    }
    #endregion
}