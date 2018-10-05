using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationFactors
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationFactorsInfo
	//Created Date:31 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationFactorsInfo:BusinessObject
	{
		public ACCostSimulationFactorsInfo()
		{
		}
		#region Variables
		protected int _aCCostSimulationFactorID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aCCostSimulationFactorNo=String.Empty;
		protected String _aCCostSimulationFactorName=String.Empty;
		protected Nullable<DateTime> _aCCostSimulationFactorDate;
		protected String _aCCostSimulationFactorDesc=String.Empty;
		protected int _fK_ACCostSimulationFactorParentID;
		protected bool _aCCostSimulationFactorActiveCheck=true;
		protected int _fK_ACProductionCostingFactorID;
		protected String _aCCostSimulationFactorRegEx=String.Empty;
		#endregion

		#region Public properties
		public int ACCostSimulationFactorID
		{
			get{return _aCCostSimulationFactorID;}
			set
			{
				if (value != this._aCCostSimulationFactorID)
				{
				_aCCostSimulationFactorID=value;
				NotifyChanged("ACCostSimulationFactorID");
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
		public String ACCostSimulationFactorNo
		{
			get{return _aCCostSimulationFactorNo;}
			set
			{
				if (value != this._aCCostSimulationFactorNo)
				{
				_aCCostSimulationFactorNo=value;
				NotifyChanged("ACCostSimulationFactorNo");
				}
			}
		}
		public String ACCostSimulationFactorName
		{
			get{return _aCCostSimulationFactorName;}
			set
			{
				if (value != this._aCCostSimulationFactorName)
				{
				_aCCostSimulationFactorName=value;
				NotifyChanged("ACCostSimulationFactorName");
				}
			}
		}
		public Nullable<DateTime> ACCostSimulationFactorDate
		{
			get{return _aCCostSimulationFactorDate;}
			set
			{
				if (value != this._aCCostSimulationFactorDate)
				{
				_aCCostSimulationFactorDate=value;
				NotifyChanged("ACCostSimulationFactorDate");
				}
			}
		}
		public String ACCostSimulationFactorDesc
		{
			get{return _aCCostSimulationFactorDesc;}
			set
			{
				if (value != this._aCCostSimulationFactorDesc)
				{
				_aCCostSimulationFactorDesc=value;
				NotifyChanged("ACCostSimulationFactorDesc");
				}
			}
		}
		public int FK_ACCostSimulationFactorParentID
		{
			get{return _fK_ACCostSimulationFactorParentID;}
			set
			{
				if (value != this._fK_ACCostSimulationFactorParentID)
				{
				_fK_ACCostSimulationFactorParentID=value;
				NotifyChanged("FK_ACCostSimulationFactorParentID");
				}
			}
		}
		public bool ACCostSimulationFactorActiveCheck
		{
			get{return _aCCostSimulationFactorActiveCheck;}
			set
			{
				if (value != this._aCCostSimulationFactorActiveCheck)
				{
				_aCCostSimulationFactorActiveCheck=value;
				NotifyChanged("ACCostSimulationFactorActiveCheck");
				}
			}
		}
		public int FK_ACProductionCostingFactorID
		{
			get{return _fK_ACProductionCostingFactorID;}
			set
			{
				if (value != this._fK_ACProductionCostingFactorID)
				{
				_fK_ACProductionCostingFactorID=value;
				NotifyChanged("FK_ACProductionCostingFactorID");
				}
			}
		}
		public String ACCostSimulationFactorRegEx
		{
			get{return _aCCostSimulationFactorRegEx;}
			set
			{
				if (value != this._aCCostSimulationFactorRegEx)
				{
				_aCCostSimulationFactorRegEx=value;
				NotifyChanged("ACCostSimulationFactorRegEx");
				}
			}
		}
		#endregion
	}
	#endregion
}