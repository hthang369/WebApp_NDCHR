using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationPriceLists
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationPriceListsInfo
	//Created Date:21 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationPriceListsInfo:BusinessObject
	{
		public ACCostSimulationPriceListsInfo()
		{
		}
		#region Variables
		protected int _aCCostSimulationPriceListID;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aCCostSimulationPriceListNo=String.Empty;
		protected String _aCCostSimulationPriceListName=String.Empty;
		protected String _aCCostSimulationPriceListDesc=String.Empty;
		protected Nullable<DateTime> _aCCostSimulationPriceListDate;
		protected String _aCCostSimulationPriceListInfo=String.Empty;
		protected Nullable<DateTime> _aCCostSimulationPriceListStartDate;
		protected Nullable<DateTime> _aCCostSimulationPriceListEndDate;
		protected bool _aCCostSimulationPriceListActiveCheck=true;
		protected int _fK_GECurrencyID;
		protected double _aCCostSimulationPriceListExcRate;
		#endregion

		#region Public properties
		public int ACCostSimulationPriceListID
		{
			get{return _aCCostSimulationPriceListID;}
			set
			{
				if (value != this._aCCostSimulationPriceListID)
				{
				_aCCostSimulationPriceListID=value;
				NotifyChanged("ACCostSimulationPriceListID");
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
		public String ACCostSimulationPriceListNo
		{
			get{return _aCCostSimulationPriceListNo;}
			set
			{
				if (value != this._aCCostSimulationPriceListNo)
				{
				_aCCostSimulationPriceListNo=value;
				NotifyChanged("ACCostSimulationPriceListNo");
				}
			}
		}
		public String ACCostSimulationPriceListName
		{
			get{return _aCCostSimulationPriceListName;}
			set
			{
				if (value != this._aCCostSimulationPriceListName)
				{
				_aCCostSimulationPriceListName=value;
				NotifyChanged("ACCostSimulationPriceListName");
				}
			}
		}
		public String ACCostSimulationPriceListDesc
		{
			get{return _aCCostSimulationPriceListDesc;}
			set
			{
				if (value != this._aCCostSimulationPriceListDesc)
				{
				_aCCostSimulationPriceListDesc=value;
				NotifyChanged("ACCostSimulationPriceListDesc");
				}
			}
		}
		public Nullable<DateTime> ACCostSimulationPriceListDate
		{
			get{return _aCCostSimulationPriceListDate;}
			set
			{
				if (value != this._aCCostSimulationPriceListDate)
				{
				_aCCostSimulationPriceListDate=value;
				NotifyChanged("ACCostSimulationPriceListDate");
				}
			}
		}
		public String ACCostSimulationPriceListInfo
		{
			get{return _aCCostSimulationPriceListInfo;}
			set
			{
				if (value != this._aCCostSimulationPriceListInfo)
				{
				_aCCostSimulationPriceListInfo=value;
				NotifyChanged("ACCostSimulationPriceListInfo");
				}
			}
		}
		public Nullable<DateTime> ACCostSimulationPriceListStartDate
		{
			get{return _aCCostSimulationPriceListStartDate;}
			set
			{
				if (value != this._aCCostSimulationPriceListStartDate)
				{
				_aCCostSimulationPriceListStartDate=value;
				NotifyChanged("ACCostSimulationPriceListStartDate");
				}
			}
		}
		public Nullable<DateTime> ACCostSimulationPriceListEndDate
		{
			get{return _aCCostSimulationPriceListEndDate;}
			set
			{
				if (value != this._aCCostSimulationPriceListEndDate)
				{
				_aCCostSimulationPriceListEndDate=value;
				NotifyChanged("ACCostSimulationPriceListEndDate");
				}
			}
		}
		public bool ACCostSimulationPriceListActiveCheck
		{
			get{return _aCCostSimulationPriceListActiveCheck;}
			set
			{
				if (value != this._aCCostSimulationPriceListActiveCheck)
				{
				_aCCostSimulationPriceListActiveCheck=value;
				NotifyChanged("ACCostSimulationPriceListActiveCheck");
				}
			}
		}
		public int FK_GECurrencyID
		{
			get{return _fK_GECurrencyID;}
			set
			{
				if (value != this._fK_GECurrencyID)
				{
				_fK_GECurrencyID=value;
				NotifyChanged("FK_GECurrencyID");
				}
			}
		}
		public double ACCostSimulationPriceListExcRate
		{
			get{return _aCCostSimulationPriceListExcRate;}
			set
			{
				if (value != this._aCCostSimulationPriceListExcRate)
				{
				_aCCostSimulationPriceListExcRate=value;
				NotifyChanged("ACCostSimulationPriceListExcRate");
				}
			}
		}
		#endregion
	}
	#endregion
}