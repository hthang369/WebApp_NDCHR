using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCostFactorItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPProductionCostFactorItemsInfo
	//Created Date:Wednesday, January 7, 2015
	//-----------------------------------------------------------
	
	public class PPProductionCostFactorItemsInfo:BusinessObject
	{
		public PPProductionCostFactorItemsInfo()
		{
		}
		#region Variables
		protected int _pPProductionCostFactorItemID;
		protected int _fK_GLAccountID;
		protected int _fK_PPCostFactorItemID;
		protected int _fK_PPCostFactorID;
		protected int _fK_PPProductionCostFactorID;
		#endregion

		#region Public properties
		public int PPProductionCostFactorItemID
		{
			get{return _pPProductionCostFactorItemID;}
			set
			{
				if (value != this._pPProductionCostFactorItemID)
				{
				_pPProductionCostFactorItemID=value;
				NotifyChanged("PPProductionCostFactorItemID");
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
		public int FK_PPCostFactorItemID
		{
			get{return _fK_PPCostFactorItemID;}
			set
			{
				if (value != this._fK_PPCostFactorItemID)
				{
				_fK_PPCostFactorItemID=value;
				NotifyChanged("FK_PPCostFactorItemID");
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
		#endregion
	}
	#endregion
}