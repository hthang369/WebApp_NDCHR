using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPConsolidateCostItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPConsolidateCostItemsInfo
	//Created Date:Thursday, May 05, 2011
	//-----------------------------------------------------------
	
	public class PPConsolidateCostItemsInfo:BusinessObject
	{
		public PPConsolidateCostItemsInfo()
		{
		}
		#region Variables
		protected int _pPConsolidateCostItemID;
		protected int _fK_PPConsolidateCostID;
		protected int _fK_WOID;
		protected double _pPConsolidateCostItemAmt;
		#endregion

		#region Public properties
		public int PPConsolidateCostItemID
		{
			get{return _pPConsolidateCostItemID;}
			set
			{
				if (value != this._pPConsolidateCostItemID)
				{
				_pPConsolidateCostItemID=value;
				NotifyChanged("PPConsolidateCostItemID");
				}
			}
		}
		public int FK_PPConsolidateCostID
		{
			get{return _fK_PPConsolidateCostID;}
			set
			{
				if (value != this._fK_PPConsolidateCostID)
				{
				_fK_PPConsolidateCostID=value;
				NotifyChanged("FK_PPConsolidateCostID");
				}
			}
		}
		public int FK_WOID
		{
			get{return _fK_WOID;}
			set
			{
				if (value != this._fK_WOID)
				{
				_fK_WOID=value;
				NotifyChanged("FK_WOID");
				}
			}
		}
		public double PPConsolidateCostItemAmt
		{
			get{return _pPConsolidateCostItemAmt;}
			set
			{
				if (value != this._pPConsolidateCostItemAmt)
				{
				_pPConsolidateCostItemAmt=value;
				NotifyChanged("PPConsolidateCostItemAmt");
				}
			}
		}
		#endregion
	}
	#endregion
}