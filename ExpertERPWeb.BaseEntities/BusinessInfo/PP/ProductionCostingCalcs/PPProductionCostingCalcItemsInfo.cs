
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPProductionCostingCalcItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.80)
    //Class: PPProductionCostingCalcItemsInfo
    //Created Date: Tuesday, 08 Nov 2016
    //-----------------------------------------------------------

    public class PPProductionCostingCalcItemsInfo : BusinessObject
    {
        public PPProductionCostingCalcItemsInfo()
        {
        }
        #region Variables
		protected int _pPProductionCostingCalcItemID;
		protected String _aAStatus = DefaultAAStatus;
		protected int _fK_PPProductionCostingCalcID;
		protected int _fK_ICProductID;
		protected int _fK_PPCostFactorID;
		protected int _fK_PPCostCenterID;
		protected int _fK_PPProductionCostingCalcCostCenterID;
		protected int _fK_PPProductionCostingCalcAllocateID;
		protected double _pPProductionCostingCalcItemAmt;
		protected double _pPProductionCostingCalcItemQty;
		protected String _pPProductionCostFactorAllocateMthCombo = String.Empty;
		protected int _fK_PPProductionCostingCalcResultID;
		
        #endregion

        #region Public properties
		public int PPProductionCostingCalcItemID
		{
			get { return _pPProductionCostingCalcItemID; }
			set
			{
				if (value != this._pPProductionCostingCalcItemID)
				{
					_pPProductionCostingCalcItemID = value;
					NotifyChanged("PPProductionCostingCalcItemID");
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
		public int FK_PPProductionCostingCalcID
		{
			get { return _fK_PPProductionCostingCalcID; }
			set
			{
				if (value != this._fK_PPProductionCostingCalcID)
				{
					_fK_PPProductionCostingCalcID = value;
					NotifyChanged("FK_PPProductionCostingCalcID");
				}
			}
		}
		public int FK_ICProductID
		{
			get { return _fK_ICProductID; }
			set
			{
				if (value != this._fK_ICProductID)
				{
					_fK_ICProductID = value;
					NotifyChanged("FK_ICProductID");
				}
			}
		}
		public int FK_PPCostFactorID
		{
			get { return _fK_PPCostFactorID; }
			set
			{
				if (value != this._fK_PPCostFactorID)
				{
					_fK_PPCostFactorID = value;
					NotifyChanged("FK_PPCostFactorID");
				}
			}
		}
		public int FK_PPCostCenterID
		{
			get { return _fK_PPCostCenterID; }
			set
			{
				if (value != this._fK_PPCostCenterID)
				{
					_fK_PPCostCenterID = value;
					NotifyChanged("FK_PPCostCenterID");
				}
			}
		}
		public int FK_PPProductionCostingCalcCostCenterID
		{
			get { return _fK_PPProductionCostingCalcCostCenterID; }
			set
			{
				if (value != this._fK_PPProductionCostingCalcCostCenterID)
				{
					_fK_PPProductionCostingCalcCostCenterID = value;
					NotifyChanged("FK_PPProductionCostingCalcCostCenterID");
				}
			}
		}
		public int FK_PPProductionCostingCalcAllocateID
		{
			get { return _fK_PPProductionCostingCalcAllocateID; }
			set
			{
				if (value != this._fK_PPProductionCostingCalcAllocateID)
				{
					_fK_PPProductionCostingCalcAllocateID = value;
					NotifyChanged("FK_PPProductionCostingCalcAllocateID");
				}
			}
		}
		public double PPProductionCostingCalcItemAmt
		{
			get { return _pPProductionCostingCalcItemAmt; }
			set
			{
				if (value != this._pPProductionCostingCalcItemAmt)
				{
					_pPProductionCostingCalcItemAmt = value;
					NotifyChanged("PPProductionCostingCalcItemAmt");
				}
			}
		}
		public double PPProductionCostingCalcItemQty
		{
			get { return _pPProductionCostingCalcItemQty; }
			set
			{
				if (value != this._pPProductionCostingCalcItemQty)
				{
					_pPProductionCostingCalcItemQty = value;
					NotifyChanged("PPProductionCostingCalcItemQty");
				}
			}
		}
		public String PPProductionCostFactorAllocateMthCombo
		{
			get { return _pPProductionCostFactorAllocateMthCombo; }
			set
			{
				if (value != this._pPProductionCostFactorAllocateMthCombo)
				{
					_pPProductionCostFactorAllocateMthCombo = value;
					NotifyChanged("PPProductionCostFactorAllocateMthCombo");
				}
			}
		}
		public int FK_PPProductionCostingCalcResultID
		{
			get { return _fK_PPProductionCostingCalcResultID; }
			set
			{
				if (value != this._fK_PPProductionCostingCalcResultID)
				{
					_fK_PPProductionCostingCalcResultID = value;
					NotifyChanged("FK_PPProductionCostingCalcResultID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}