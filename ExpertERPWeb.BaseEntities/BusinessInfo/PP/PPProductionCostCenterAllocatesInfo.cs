using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCostCenterAllocates
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPProductionCostCenterAllocatesInfo
	//Created Date:Wednesday, January 7, 2015
	//-----------------------------------------------------------
	
	public class PPProductionCostCenterAllocatesInfo:BusinessObject
	{
		public PPProductionCostCenterAllocatesInfo()
		{
		}
		#region Variables
		protected int _pPProductionCostCenterAllocateID;
		protected int _fK_PPCostCenterID;
		protected int _fK_PPCostFactorID;
		protected int _fK_GLAccountID;
		protected int _fK_ICProductID;
		protected double _pPProductionCostCenterAllocateAmt;
		protected String _pPProductionCostCenterAllocateTypeCombo=String.Empty;
		protected int _fK_PPProductionCostCenterParentID;
		protected int _fK_PPProductionCostCenterID;
		protected int _fK_PPProductionCostFactorID;
		protected int _pPYear;
		protected int _pPPeriod;
		#endregion

		#region Public properties
		public int PPProductionCostCenterAllocateID
		{
			get{return _pPProductionCostCenterAllocateID;}
			set
			{
				if (value != this._pPProductionCostCenterAllocateID)
				{
				_pPProductionCostCenterAllocateID=value;
				NotifyChanged("PPProductionCostCenterAllocateID");
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
		public int FK_GLAccountID
		{
			get{return _fK_GLAccountID;}
			set
			{
				if (value != this._fK_GLAccountID)
				{
				_fK_GLAccountID=value;
				NotifyChanged("FK_GLAccountID");
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
		public double PPProductionCostCenterAllocateAmt
		{
			get{return _pPProductionCostCenterAllocateAmt;}
			set
			{
				if (value != this._pPProductionCostCenterAllocateAmt)
				{
				_pPProductionCostCenterAllocateAmt=value;
				NotifyChanged("PPProductionCostCenterAllocateAmt");
				}
			}
		}
		public String PPProductionCostCenterAllocateTypeCombo
		{
			get{return _pPProductionCostCenterAllocateTypeCombo;}
			set
			{
				if (value != this._pPProductionCostCenterAllocateTypeCombo)
				{
				_pPProductionCostCenterAllocateTypeCombo=value;
				NotifyChanged("PPProductionCostCenterAllocateTypeCombo");
				}
			}
		}
		public int FK_PPProductionCostCenterParentID
		{
			get{return _fK_PPProductionCostCenterParentID;}
			set
			{
				if (value != this._fK_PPProductionCostCenterParentID)
				{
				_fK_PPProductionCostCenterParentID=value;
				NotifyChanged("FK_PPProductionCostCenterParentID");
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
		#endregion
	}
	#endregion
}