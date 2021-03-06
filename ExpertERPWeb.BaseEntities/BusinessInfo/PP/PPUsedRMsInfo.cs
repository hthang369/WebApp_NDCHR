using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPUsedRMs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPUsedRMsInfo
	//Created Date:23 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class PPUsedRMsInfo:BusinessObject
	{
		public PPUsedRMsInfo()
		{
		}
		#region Variables
		protected int _pPUsedRMID;
		protected int _fK_ICFGProductID;
		protected int _fK_ICRMProductID;
		protected int _fK_PPPhaseCfgID;
		protected int _fK_PPWOID;
		protected double _pPUsedRMQty;
		protected double _pPUsedRMCost;
		protected int _pPPeriod;
		protected int _pPYear;
		#endregion

		#region Public properties
		public int PPUsedRMID
		{
			get{return _pPUsedRMID;}
			set
			{
				if (value != this._pPUsedRMID)
				{
				_pPUsedRMID=value;
				NotifyChanged("PPUsedRMID");
				}
			}
		}
		public int FK_ICFGProductID
		{
			get{return _fK_ICFGProductID;}
			set
			{
				if (value != this._fK_ICFGProductID)
				{
				_fK_ICFGProductID=value;
				NotifyChanged("FK_ICFGProductID");
				}
			}
		}
		public int FK_ICRMProductID
		{
			get{return _fK_ICRMProductID;}
			set
			{
				if (value != this._fK_ICRMProductID)
				{
				_fK_ICRMProductID=value;
				NotifyChanged("FK_ICRMProductID");
				}
			}
		}
		public int FK_PPPhaseCfgID
		{
			get{return _fK_PPPhaseCfgID;}
			set
			{
				if (value != this._fK_PPPhaseCfgID)
				{
				_fK_PPPhaseCfgID=value;
				NotifyChanged("FK_PPPhaseCfgID");
				}
			}
		}
		public int FK_PPWOID
		{
			get{return _fK_PPWOID;}
			set
			{
				if (value != this._fK_PPWOID)
				{
				_fK_PPWOID=value;
				NotifyChanged("FK_PPWOID");
				}
			}
		}
		public double PPUsedRMQty
		{
			get{return _pPUsedRMQty;}
			set
			{
				if (value != this._pPUsedRMQty)
				{
				_pPUsedRMQty=value;
				NotifyChanged("PPUsedRMQty");
				}
			}
		}
		public double PPUsedRMCost
		{
			get{return _pPUsedRMCost;}
			set
			{
				if (value != this._pPUsedRMCost)
				{
				_pPUsedRMCost=value;
				NotifyChanged("PPUsedRMCost");
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
		#endregion
	}
	#endregion
}