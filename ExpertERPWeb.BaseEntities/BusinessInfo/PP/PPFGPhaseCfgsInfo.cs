using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPFGPhaseCfgs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPFGPhaseCfgsInfo
	//Created Date:Friday, December 16, 2011
	//-----------------------------------------------------------
	
	public class PPFGPhaseCfgsInfo:BusinessObject
	{
		public PPFGPhaseCfgsInfo()
		{
		}
		#region Variables
		protected int _pPFGPhaseCfgID;
		protected int _fK_ICProductID;
		protected int _fK_PPPhaseCfgID;
		protected double _pPFGPhaseRMPct;
		protected double _pPFGPhaseOverheadPct;
		protected double _pPFGPhaseLabourPct;
		#endregion

		#region Public properties
		public int PPFGPhaseCfgID
		{
			get{return _pPFGPhaseCfgID;}
			set
			{
				if (value != this._pPFGPhaseCfgID)
				{
				_pPFGPhaseCfgID=value;
				NotifyChanged("PPFGPhaseCfgID");
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
		public double PPFGPhaseRMPct
		{
			get{return _pPFGPhaseRMPct;}
			set
			{
				if (value != this._pPFGPhaseRMPct)
				{
				_pPFGPhaseRMPct=value;
				NotifyChanged("PPFGPhaseRMPct");
				}
			}
		}
		public double PPFGPhaseOverheadPct
		{
			get{return _pPFGPhaseOverheadPct;}
			set
			{
				if (value != this._pPFGPhaseOverheadPct)
				{
				_pPFGPhaseOverheadPct=value;
				NotifyChanged("PPFGPhaseOverheadPct");
				}
			}
		}
		public double PPFGPhaseLabourPct
		{
			get{return _pPFGPhaseLabourPct;}
			set
			{
				if (value != this._pPFGPhaseLabourPct)
				{
				_pPFGPhaseLabourPct=value;
				NotifyChanged("PPFGPhaseLabourPct");
				}
			}
		}
		#endregion
	}
	#endregion
}