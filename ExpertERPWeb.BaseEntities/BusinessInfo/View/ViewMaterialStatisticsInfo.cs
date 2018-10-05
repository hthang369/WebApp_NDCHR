using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewMaterialStatistics
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ViewMaterialStatisticsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class ViewMaterialStatisticsInfo:BusinessObject
	{
		public ViewMaterialStatisticsInfo()
		{
		}
		#region Variables
		protected int _viewMaterialStatisticID;
		protected int _fK_ICProductID;
		protected double _materialQty;
		protected int _fK_ICProductGroupID;
		protected int _fK_ICProductTypeID;
		protected double _iCProductLenght;
		protected double _iCProductHeight;
		protected double _iCProductWidth;
		protected int _fK_ICProductFinishGoods;
		protected double _finishGoodsQty;
		protected double _normFGQty;
		protected int _fK_PPPhaseCfgID;
		protected String _pPProductionOrdrNo=String.Empty;
		protected Nullable<DateTime> _pPProductionOrdrDate;
		protected int _fK_PPWOID;
		protected int _fK_ICStockID;
		protected bool _aASelected=true;
		protected String _viewDetailInvTypeCombo=String.Empty;
		protected double _viewMaterialStatisticEstMaterialQty;
		protected double _viewMaterialStatisticLossPct;
		protected int _fK_ICUOMID;
		#endregion

		#region Public properties
		public int ViewMaterialStatisticID
		{
			get{return _viewMaterialStatisticID;}
			set
			{
				if (value != this._viewMaterialStatisticID)
				{
				_viewMaterialStatisticID=value;
				NotifyChanged("ViewMaterialStatisticID");
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
		public double MaterialQty
		{
			get{return _materialQty;}
			set
			{
				if (value != this._materialQty)
				{
				_materialQty=value;
				NotifyChanged("MaterialQty");
				}
			}
		}
		public int FK_ICProductGroupID
		{
			get{return _fK_ICProductGroupID;}
			set
			{
				if (value != this._fK_ICProductGroupID)
				{
				_fK_ICProductGroupID=value;
				NotifyChanged("FK_ICProductGroupID");
				}
			}
		}
		public int FK_ICProductTypeID
		{
			get{return _fK_ICProductTypeID;}
			set
			{
				if (value != this._fK_ICProductTypeID)
				{
				_fK_ICProductTypeID=value;
				NotifyChanged("FK_ICProductTypeID");
				}
			}
		}
		public double ICProductLenght
		{
			get{return _iCProductLenght;}
			set
			{
				if (value != this._iCProductLenght)
				{
				_iCProductLenght=value;
				NotifyChanged("ICProductLenght");
				}
			}
		}
		public double ICProductHeight
		{
			get{return _iCProductHeight;}
			set
			{
				if (value != this._iCProductHeight)
				{
				_iCProductHeight=value;
				NotifyChanged("ICProductHeight");
				}
			}
		}
		public double ICProductWidth
		{
			get{return _iCProductWidth;}
			set
			{
				if (value != this._iCProductWidth)
				{
				_iCProductWidth=value;
				NotifyChanged("ICProductWidth");
				}
			}
		}
		public int FK_ICProductFinishGoods
		{
			get{return _fK_ICProductFinishGoods;}
			set
			{
				if (value != this._fK_ICProductFinishGoods)
				{
				_fK_ICProductFinishGoods=value;
				NotifyChanged("FK_ICProductFinishGoods");
				}
			}
		}
		public double FinishGoodsQty
		{
			get{return _finishGoodsQty;}
			set
			{
				if (value != this._finishGoodsQty)
				{
				_finishGoodsQty=value;
				NotifyChanged("FinishGoodsQty");
				}
			}
		}
		public double NormFGQty
		{
			get{return _normFGQty;}
			set
			{
				if (value != this._normFGQty)
				{
				_normFGQty=value;
				NotifyChanged("NormFGQty");
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
		public String PPProductionOrdrNo
		{
			get{return _pPProductionOrdrNo;}
			set
			{
				if (value != this._pPProductionOrdrNo)
				{
				_pPProductionOrdrNo=value;
				NotifyChanged("PPProductionOrdrNo");
				}
			}
		}
		public Nullable<DateTime> PPProductionOrdrDate
		{
			get{return _pPProductionOrdrDate;}
			set
			{
				if (value != this._pPProductionOrdrDate)
				{
				_pPProductionOrdrDate=value;
				NotifyChanged("PPProductionOrdrDate");
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
		public int FK_ICStockID
		{
			get{return _fK_ICStockID;}
			set
			{
				if (value != this._fK_ICStockID)
				{
				_fK_ICStockID=value;
				NotifyChanged("FK_ICStockID");
				}
			}
		}
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
				_aASelected=value;
				NotifyChanged("AASelected");
				}
			}
		}
		public String ViewDetailInvTypeCombo
		{
			get{return _viewDetailInvTypeCombo;}
			set
			{
				if (value != this._viewDetailInvTypeCombo)
				{
				_viewDetailInvTypeCombo=value;
				NotifyChanged("ViewDetailInvTypeCombo");
				}
			}
		}
		public double ViewMaterialStatisticEstMaterialQty
		{
			get{return _viewMaterialStatisticEstMaterialQty;}
			set
			{
				if (value != this._viewMaterialStatisticEstMaterialQty)
				{
				_viewMaterialStatisticEstMaterialQty=value;
				NotifyChanged("ViewMaterialStatisticEstMaterialQty");
				}
			}
		}
		public double ViewMaterialStatisticLossPct
		{
			get{return _viewMaterialStatisticLossPct;}
			set
			{
				if (value != this._viewMaterialStatisticLossPct)
				{
				_viewMaterialStatisticLossPct=value;
				NotifyChanged("ViewMaterialStatisticLossPct");
				}
			}
		}
		public int FK_ICUOMID
		{
			get{return _fK_ICUOMID;}
			set
			{
				if (value != this._fK_ICUOMID)
				{
				_fK_ICUOMID=value;
				NotifyChanged("FK_ICUOMID");
				}
			}
		}
		#endregion
	}
	#endregion
}