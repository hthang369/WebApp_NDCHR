
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPCostCenterChilds
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.73)
    //Class: PPCostCenterChildsInfo
    //Created Date: Monday, 19 Sep 2016
    //-----------------------------------------------------------

    public class PPCostCenterChildsInfo : BusinessObject
    {
        public PPCostCenterChildsInfo()
        {
        }
        #region Variables
		protected int _pPCostCenterChildID;
		protected int _fK_PPCostCenterID;
		protected int _fK_PPCostCenterParentID;
		protected double _pPCostCenterChildPct;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		
        #endregion

        #region Public properties
		public int PPCostCenterChildID
		{
			get { return _pPCostCenterChildID; }
			set
			{
				if (value != this._pPCostCenterChildID)
				{
					_pPCostCenterChildID = value;
					NotifyChanged("PPCostCenterChildID");
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
		public double PPCostCenterChildPct
		{
			get { return _pPCostCenterChildPct; }
			set
			{
				if (value != this._pPCostCenterChildPct)
				{
					_pPCostCenterChildPct = value;
					NotifyChanged("PPCostCenterChildPct");
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
		
        #endregion
    }
    #endregion
}