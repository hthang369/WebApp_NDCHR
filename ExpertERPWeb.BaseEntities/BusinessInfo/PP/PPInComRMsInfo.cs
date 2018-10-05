using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPInComRMs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPInComRMsInfo
	//Created Date:Thursday, August 23, 2012
	//-----------------------------------------------------------
	
	public class PPInComRMsInfo:BusinessObject
	{
		public PPInComRMsInfo()
		{
		}
		#region Variables
		protected int _pPInComRMID;
		protected int _fK_ICProductID;
		protected int _fK_ICReceiptID;
		protected int _fK_ICReceiptItemID;
		protected int _fK_PPPhaseCfgID;
		protected double _pPInComQty;
		protected double _pPInComFGQty;
		protected double _pPPhaseCfgFactor;
		protected double _pPInComFGUnitPrice;
		protected double _pPInComFGPhaseQty;
		protected double _pPInComAllocateFGQty;
		protected double _pPBeginInComRMCost;
		protected double _pPInComRMDirectCost;
		protected double _pPInComRMIndirectCost;
		protected double _pPUsedRMDirectCost;
		protected double _pPUsedRMIndirectCost;
		protected double _pPUsedRMCost;
		protected double _pPInComRMCost;
		protected int _pPPeriod;
		protected int _pPYear;
		#endregion

		#region Public properties
		public int PPInComRMID
		{
			get{return _pPInComRMID;}
			set
			{
				if (value != this._pPInComRMID)
				{
				_pPInComRMID=value;
				NotifyChanged("PPInComRMID");
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
		public int FK_ICReceiptID
		{
			get{return _fK_ICReceiptID;}
			set
			{
				if (value != this._fK_ICReceiptID)
				{
				_fK_ICReceiptID=value;
				NotifyChanged("FK_ICReceiptID");
				}
			}
		}
		public int FK_ICReceiptItemID
		{
			get{return _fK_ICReceiptItemID;}
			set
			{
				if (value != this._fK_ICReceiptItemID)
				{
				_fK_ICReceiptItemID=value;
				NotifyChanged("FK_ICReceiptItemID");
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
		public double PPInComQty
		{
			get{return _pPInComQty;}
			set
			{
				if (value != this._pPInComQty)
				{
				_pPInComQty=value;
				NotifyChanged("PPInComQty");
				}
			}
		}
		public double PPInComFGQty
		{
			get{return _pPInComFGQty;}
			set
			{
				if (value != this._pPInComFGQty)
				{
				_pPInComFGQty=value;
				NotifyChanged("PPInComFGQty");
				}
			}
		}
		public double PPPhaseCfgFactor
		{
			get{return _pPPhaseCfgFactor;}
			set
			{
				if (value != this._pPPhaseCfgFactor)
				{
				_pPPhaseCfgFactor=value;
				NotifyChanged("PPPhaseCfgFactor");
				}
			}
		}
		public double PPInComFGUnitPrice
		{
			get{return _pPInComFGUnitPrice;}
			set
			{
				if (value != this._pPInComFGUnitPrice)
				{
				_pPInComFGUnitPrice=value;
				NotifyChanged("PPInComFGUnitPrice");
				}
			}
		}
		public double PPInComFGPhaseQty
		{
			get{return _pPInComFGPhaseQty;}
			set
			{
				if (value != this._pPInComFGPhaseQty)
				{
				_pPInComFGPhaseQty=value;
				NotifyChanged("PPInComFGPhaseQty");
				}
			}
		}
		public double PPInComAllocateFGQty
		{
			get{return _pPInComAllocateFGQty;}
			set
			{
				if (value != this._pPInComAllocateFGQty)
				{
				_pPInComAllocateFGQty=value;
				NotifyChanged("PPInComAllocateFGQty");
				}
			}
		}
		public double PPBeginInComRMCost
		{
			get{return _pPBeginInComRMCost;}
			set
			{
				if (value != this._pPBeginInComRMCost)
				{
				_pPBeginInComRMCost=value;
				NotifyChanged("PPBeginInComRMCost");
				}
			}
		}
		public double PPInComRMDirectCost
		{
			get{return _pPInComRMDirectCost;}
			set
			{
				if (value != this._pPInComRMDirectCost)
				{
				_pPInComRMDirectCost=value;
				NotifyChanged("PPInComRMDirectCost");
				}
			}
		}
		public double PPInComRMIndirectCost
		{
			get{return _pPInComRMIndirectCost;}
			set
			{
				if (value != this._pPInComRMIndirectCost)
				{
				_pPInComRMIndirectCost=value;
				NotifyChanged("PPInComRMIndirectCost");
				}
			}
		}
		public double PPUsedRMDirectCost
		{
			get{return _pPUsedRMDirectCost;}
			set
			{
				if (value != this._pPUsedRMDirectCost)
				{
				_pPUsedRMDirectCost=value;
				NotifyChanged("PPUsedRMDirectCost");
				}
			}
		}
		public double PPUsedRMIndirectCost
		{
			get{return _pPUsedRMIndirectCost;}
			set
			{
				if (value != this._pPUsedRMIndirectCost)
				{
				_pPUsedRMIndirectCost=value;
				NotifyChanged("PPUsedRMIndirectCost");
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
		public double PPInComRMCost
		{
			get{return _pPInComRMCost;}
			set
			{
				if (value != this._pPInComRMCost)
				{
				_pPInComRMCost=value;
				NotifyChanged("PPInComRMCost");
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