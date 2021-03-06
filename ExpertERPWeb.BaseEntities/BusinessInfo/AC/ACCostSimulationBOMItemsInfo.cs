using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ACCostSimulationBOMItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ACCostSimulationBOMItemsInfo
	//Created Date:Monday, July 21, 2014
	//-----------------------------------------------------------
	
	public class ACCostSimulationBOMItemsInfo:BusinessObject
	{
		public ACCostSimulationBOMItemsInfo()
		{
		}
		#region Variables
		protected int _aCCostSimulationBOMItemID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ICProductID;
		protected double _aCCostSimulationBOMItemQty;
		protected int _fK_ACCostSimulationBOMID;
		protected int _fK_ACCostSimulationFactorID;
		#endregion

		#region Public properties
		public int ACCostSimulationBOMItemID
		{
			get{return _aCCostSimulationBOMItemID;}
			set
			{
				if (value != this._aCCostSimulationBOMItemID)
				{
				_aCCostSimulationBOMItemID=value;
				NotifyChanged("ACCostSimulationBOMItemID");
				}
			}
		}
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				NotifyChanged("FK_ICProductID");
				}
			}
		}
		public double ACCostSimulationBOMItemQty
		{
			get{return _aCCostSimulationBOMItemQty;}
			set
			{
				if (value != this._aCCostSimulationBOMItemQty)
				{
				_aCCostSimulationBOMItemQty=value;
				NotifyChanged("ACCostSimulationBOMItemQty");
				}
			}
		}
		public int FK_ACCostSimulationBOMID
		{
			get{return _fK_ACCostSimulationBOMID;}
			set
			{
				if (value != this._fK_ACCostSimulationBOMID)
				{
				_fK_ACCostSimulationBOMID=value;
				NotifyChanged("FK_ACCostSimulationBOMID");
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
		#endregion
	}
	#endregion
}