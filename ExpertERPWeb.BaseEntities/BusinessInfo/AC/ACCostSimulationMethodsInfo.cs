using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationMethods
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationMethodsInfo
	//Created Date:22 Tháng Mười 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationMethodsInfo:BusinessObject
	{
		public ACCostSimulationMethodsInfo()
		{
		}
		#region Variables
		protected int _aCCostSimulationMethodID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aCCostSimulationMethodNo=String.Empty;
		protected String _aCCostSimulationMethodName=String.Empty;
		protected Nullable<DateTime> _aCCostSimulationMethodDate;
		protected String _aCCostSimulationMethodDesc=String.Empty;
		#endregion

		#region Public properties
		public int ACCostSimulationMethodID
		{
			get{return _aCCostSimulationMethodID;}
			set
			{
				if (value != this._aCCostSimulationMethodID)
				{
				_aCCostSimulationMethodID=value;
				NotifyChanged("ACCostSimulationMethodID");
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
		public String ACCostSimulationMethodNo
		{
			get{return _aCCostSimulationMethodNo;}
			set
			{
				if (value != this._aCCostSimulationMethodNo)
				{
				_aCCostSimulationMethodNo=value;
				NotifyChanged("ACCostSimulationMethodNo");
				}
			}
		}
		public String ACCostSimulationMethodName
		{
			get{return _aCCostSimulationMethodName;}
			set
			{
				if (value != this._aCCostSimulationMethodName)
				{
				_aCCostSimulationMethodName=value;
				NotifyChanged("ACCostSimulationMethodName");
				}
			}
		}
		public Nullable<DateTime> ACCostSimulationMethodDate
		{
			get{return _aCCostSimulationMethodDate;}
			set
			{
				if (value != this._aCCostSimulationMethodDate)
				{
				_aCCostSimulationMethodDate=value;
				NotifyChanged("ACCostSimulationMethodDate");
				}
			}
		}
		public String ACCostSimulationMethodDesc
		{
			get{return _aCCostSimulationMethodDesc;}
			set
			{
				if (value != this._aCCostSimulationMethodDesc)
				{
				_aCCostSimulationMethodDesc=value;
				NotifyChanged("ACCostSimulationMethodDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}