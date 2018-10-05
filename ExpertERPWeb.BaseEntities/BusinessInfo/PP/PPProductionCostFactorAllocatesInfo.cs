using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCostFactorAllocates
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPProductionCostFactorAllocatesInfo
	//Created Date:Wednesday, January 7, 2015
	//-----------------------------------------------------------
	
	public class PPProductionCostFactorAllocatesInfo:BusinessObject
	{
		public PPProductionCostFactorAllocatesInfo()
		{
		}
		#region Variables
		protected int _pPProductionCostFactorAllocateID;
		protected int _fK_PPCostCenterID;
		protected int _fK_PPCostFactorID;
		protected String _pPCostFactorAllocateMthCombo=String.Empty;
		protected int _fK_PPCostFactorAllocateID;
		protected int _fK_PPProductionCostCenterID;
		protected int _fK_PPProductionCostFactorID;
		protected int _pPYear;
		protected int _pPPeriod;
		protected int _pPProductionCostFactorAllocateOrder;
		#endregion

		#region Public properties
		public int PPProductionCostFactorAllocateID
		{
			get{return _pPProductionCostFactorAllocateID;}
			set
			{
				if (value != this._pPProductionCostFactorAllocateID)
				{
				_pPProductionCostFactorAllocateID=value;
				NotifyChanged("PPProductionCostFactorAllocateID");
				}
			}
		}
		public int FK_PPCostCenterID
		{
			get{return _fK_PPCostCenterID;}
			set
			{
				if (value != this._fK_PPCostCenterID)
				{
				_fK_PPCostCenterID=value;
				NotifyChanged("FK_PPCostCenterID");
				}
			}
		}
		public int FK_PPCostFactorID
		{
			get{return _fK_PPCostFactorID;}
			set
			{
				if (value != this._fK_PPCostFactorID)
				{
				_fK_PPCostFactorID=value;
				NotifyChanged("FK_PPCostFactorID");
				}
			}
		}
		public String PPCostFactorAllocateMthCombo
		{
			get{return _pPCostFactorAllocateMthCombo;}
			set
			{
				if (value != this._pPCostFactorAllocateMthCombo)
				{
				_pPCostFactorAllocateMthCombo=value;
				NotifyChanged("PPCostFactorAllocateMthCombo");
				}
			}
		}
		public int FK_PPCostFactorAllocateID
		{
			get{return _fK_PPCostFactorAllocateID;}
			set
			{
				if (value != this._fK_PPCostFactorAllocateID)
				{
				_fK_PPCostFactorAllocateID=value;
				NotifyChanged("FK_PPCostFactorAllocateID");
				}
			}
		}
		public int FK_PPProductionCostCenterID
		{
			get{return _fK_PPProductionCostCenterID;}
			set
			{
				if (value != this._fK_PPProductionCostCenterID)
				{
				_fK_PPProductionCostCenterID=value;
				NotifyChanged("FK_PPProductionCostCenterID");
				}
			}
		}
		public int FK_PPProductionCostFactorID
		{
			get{return _fK_PPProductionCostFactorID;}
			set
			{
				if (value != this._fK_PPProductionCostFactorID)
				{
				_fK_PPProductionCostFactorID=value;
				NotifyChanged("FK_PPProductionCostFactorID");
				}
			}
		}
		public int PPYear
		{
			get{return _pPYear;}
			set
			{
				if (value != this._pPYear)
				{
				_pPYear=value;
				NotifyChanged("PPYear");
				}
			}
		}
		public int PPPeriod
		{
			get{return _pPPeriod;}
			set
			{
				if (value != this._pPPeriod)
				{
				_pPPeriod=value;
				NotifyChanged("PPPeriod");
				}
			}
		}
		public int PPProductionCostFactorAllocateOrder
		{
			get{return _pPProductionCostFactorAllocateOrder;}
			set
			{
				if (value != this._pPProductionCostFactorAllocateOrder)
				{
				_pPProductionCostFactorAllocateOrder=value;
				NotifyChanged("PPProductionCostFactorAllocateOrder");
				}
			}
		}
		#endregion
	}
	#endregion
}