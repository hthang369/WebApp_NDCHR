
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPCostAllocationFactorAllocates
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.80)
    //Class: PPCostAllocationFactorAllocatesInfo
    //Created Date: Thursday, 10 Nov 2016
    //-----------------------------------------------------------

    public class PPCostAllocationFactorAllocatesInfo : BusinessObject
    {
        public PPCostAllocationFactorAllocatesInfo()
        {
        }
        #region Variables
		protected int _pPCostAllocationFactorAllocateID;
		protected int _fK_PPCostCenterID;
		protected int _fK_PPCostFactorID;
		protected String _pPCostAllocationFactorAllocateMthCombo = String.Empty;
		protected int _pPCostAllocationFactorAllocateOrder;
		protected int _fK_PPCostCenterParentID;
		protected int _fK_ICProductFGID;
		
        #endregion

        #region Public properties
		public int PPCostAllocationFactorAllocateID
		{
			get { return _pPCostAllocationFactorAllocateID; }
			set
			{
				if (value != this._pPCostAllocationFactorAllocateID)
				{
					_pPCostAllocationFactorAllocateID = value;
					NotifyChanged("PPCostAllocationFactorAllocateID");
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
		public String PPCostAllocationFactorAllocateMthCombo
		{
			get { return _pPCostAllocationFactorAllocateMthCombo; }
			set
			{
				if (value != this._pPCostAllocationFactorAllocateMthCombo)
				{
					_pPCostAllocationFactorAllocateMthCombo = value;
					NotifyChanged("PPCostAllocationFactorAllocateMthCombo");
				}
			}
		}
		public int PPCostAllocationFactorAllocateOrder
		{
			get { return _pPCostAllocationFactorAllocateOrder; }
			set
			{
				if (value != this._pPCostAllocationFactorAllocateOrder)
				{
					_pPCostAllocationFactorAllocateOrder = value;
					NotifyChanged("PPCostAllocationFactorAllocateOrder");
				}
			}
		}
		public int FK_PPCostCenterParentID
		{
			get { return _fK_PPCostCenterParentID; }
			set
			{
				if (value != this._fK_PPCostCenterParentID)
				{
					_fK_PPCostCenterParentID = value;
					NotifyChanged("FK_PPCostCenterParentID");
				}
			}
		}
		public int FK_ICProductFGID
		{
			get { return _fK_ICProductFGID; }
			set
			{
				if (value != this._fK_ICProductFGID)
				{
					_fK_ICProductFGID = value;
					NotifyChanged("FK_ICProductFGID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}