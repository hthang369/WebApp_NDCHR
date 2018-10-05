using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPRoutingNormLabours
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPRoutingNormLaboursInfo
	//Created Date:13 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class PPRoutingNormLaboursInfo:BusinessObject
	{
		public PPRoutingNormLaboursInfo()
		{
		}
		#region Variables
		protected int _pPRoutingNormLabourID;
		protected int _fK_PPRoutingID;
		protected int _fK_PPPhaseCfgID;
		protected double _pPRoutingNormLabourManMin;
		protected double _pPRoutingNormLabourManHour;
		protected double _pPRoutingNormLabourUnitCost;
		protected double _pPRoutingNormLabourCostTot;
		#endregion

		#region Public properties
		public int PPRoutingNormLabourID
		{
			get{return _pPRoutingNormLabourID;}
			set
			{
				if (value != this._pPRoutingNormLabourID)
				{
				_pPRoutingNormLabourID=value;
				NotifyChanged("PPRoutingNormLabourID");
				}
			}
		}
		public int FK_PPRoutingID
		{
			get{return _fK_PPRoutingID;}
			set
			{
				if (value != this._fK_PPRoutingID)
				{
				_fK_PPRoutingID=value;
				NotifyChanged("FK_PPRoutingID");
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
		public double PPRoutingNormLabourManMin
		{
			get{return _pPRoutingNormLabourManMin;}
			set
			{
				if (value != this._pPRoutingNormLabourManMin)
				{
				_pPRoutingNormLabourManMin=value;
				NotifyChanged("PPRoutingNormLabourManMin");
				}
			}
		}
		public double PPRoutingNormLabourManHour
		{
			get{return _pPRoutingNormLabourManHour;}
			set
			{
				if (value != this._pPRoutingNormLabourManHour)
				{
				_pPRoutingNormLabourManHour=value;
				NotifyChanged("PPRoutingNormLabourManHour");
				}
			}
		}
		public double PPRoutingNormLabourUnitCost
		{
			get{return _pPRoutingNormLabourUnitCost;}
			set
			{
				if (value != this._pPRoutingNormLabourUnitCost)
				{
				_pPRoutingNormLabourUnitCost=value;
				NotifyChanged("PPRoutingNormLabourUnitCost");
				}
			}
		}
		public double PPRoutingNormLabourCostTot
		{
			get{return _pPRoutingNormLabourCostTot;}
			set
			{
				if (value != this._pPRoutingNormLabourCostTot)
				{
				_pPRoutingNormLabourCostTot=value;
				NotifyChanged("PPRoutingNormLabourCostTot");
				}
			}
		}
		#endregion
	}
	#endregion
}