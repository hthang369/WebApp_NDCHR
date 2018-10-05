using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationPriceListItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationPriceListItemsInfo
	//Created Date:21 Tháng Bảy 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationPriceListItemsInfo:BusinessObject
	{
		public ACCostSimulationPriceListItemsInfo()
		{
		}
		#region Variables
		protected int _aCCostSimulationPriceListItemID;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ACCostSimulationPriceListID;
		protected int _fK_ACCostSimulationFactorID;
		protected int _fK_GECurrencyID;
		protected String _aCCostSimulationPriceListItemDesc=String.Empty;
		protected String _aCCostSimulationPriceListItemSerialNo=String.Empty;
		protected String _aCCostSimulationPriceListItemLotNo=String.Empty;
		protected double _aCCostSimulationPriceListItemUnitPrice;
		protected double _aCCostSimulationPriceListItemFUnitPrice;
		protected Nullable<DateTime> _aCCostSimulationPriceListItemFromDate;
		protected Nullable<DateTime> _aCCostSimulationPriceListItemToDate;
		#endregion

		#region Public properties
		public int ACCostSimulationPriceListItemID
		{
			get{return _aCCostSimulationPriceListItemID;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemID)
				{
				_aCCostSimulationPriceListItemID=value;
				NotifyChanged("ACCostSimulationPriceListItemID");
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
		public int FK_ACCostSimulationPriceListID
		{
			get{return _fK_ACCostSimulationPriceListID;}
			set
			{
				if (value != this._fK_ACCostSimulationPriceListID)
				{
				_fK_ACCostSimulationPriceListID=value;
				NotifyChanged("FK_ACCostSimulationPriceListID");
				}
			}
		}
		public int FK_ACCostSimulationFactorID
		{
			get{return _fK_ACCostSimulationFactorID;}
			set
			{
				if (value != this._fK_ACCostSimulationFactorID)
				{
				_fK_ACCostSimulationFactorID=value;
				NotifyChanged("FK_ACCostSimulationFactorID");
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
		public String ACCostSimulationPriceListItemDesc
		{
			get{return _aCCostSimulationPriceListItemDesc;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemDesc)
				{
				_aCCostSimulationPriceListItemDesc=value;
				NotifyChanged("ACCostSimulationPriceListItemDesc");
				}
			}
		}
		public String ACCostSimulationPriceListItemSerialNo
		{
			get{return _aCCostSimulationPriceListItemSerialNo;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemSerialNo)
				{
				_aCCostSimulationPriceListItemSerialNo=value;
				NotifyChanged("ACCostSimulationPriceListItemSerialNo");
				}
			}
		}
		public String ACCostSimulationPriceListItemLotNo
		{
			get{return _aCCostSimulationPriceListItemLotNo;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemLotNo)
				{
				_aCCostSimulationPriceListItemLotNo=value;
				NotifyChanged("ACCostSimulationPriceListItemLotNo");
				}
			}
		}
		public double ACCostSimulationPriceListItemUnitPrice
		{
			get{return _aCCostSimulationPriceListItemUnitPrice;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemUnitPrice)
				{
				_aCCostSimulationPriceListItemUnitPrice=value;
				NotifyChanged("ACCostSimulationPriceListItemUnitPrice");
				}
			}
		}
		public double ACCostSimulationPriceListItemFUnitPrice
		{
			get{return _aCCostSimulationPriceListItemFUnitPrice;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemFUnitPrice)
				{
				_aCCostSimulationPriceListItemFUnitPrice=value;
				NotifyChanged("ACCostSimulationPriceListItemFUnitPrice");
				}
			}
		}
		public Nullable<DateTime> ACCostSimulationPriceListItemFromDate
		{
			get{return _aCCostSimulationPriceListItemFromDate;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemFromDate)
				{
				_aCCostSimulationPriceListItemFromDate=value;
				NotifyChanged("ACCostSimulationPriceListItemFromDate");
				}
			}
		}
		public Nullable<DateTime> ACCostSimulationPriceListItemToDate
		{
			get{return _aCCostSimulationPriceListItemToDate;}
			set
			{
				if (value != this._aCCostSimulationPriceListItemToDate)
				{
				_aCCostSimulationPriceListItemToDate=value;
				NotifyChanged("ACCostSimulationPriceListItemToDate");
				}
			}
		}
		#endregion
	}
	#endregion
}