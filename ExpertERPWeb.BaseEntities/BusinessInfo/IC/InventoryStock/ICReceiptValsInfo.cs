using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICReceiptVals
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICReceiptValsInfo
	//Created Date:05 November 2014
	//-----------------------------------------------------------
	
	public class ICReceiptValsInfo:BusinessObject
	{
		public ICReceiptValsInfo()
		{
		}
		#region Variables
		protected int _iCReceiptValID;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICTransactionItemID;
		protected String _iCTransactionType=String.Empty;
		protected double _iCReceiptValQty;
		protected double _iCReceiptValShpQty;
		protected double _iCReceiptValRQty;
		protected double _iCReceiptValCostTot;
		protected double _iCReceiptValUnitCost;
		protected Nullable<DateTime> _iCReceiptValDate;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _iCReceiptValStkQty;
		protected double _iCReceiptValRStkQty;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _iCReceiptValWTot;
		protected double _iCReceiptValVTot;
		#endregion

		#region Public properties
		public int ICReceiptValID
		{
			get{return _iCReceiptValID;}
			set
			{
				if (value != this._iCReceiptValID)
				{
				_iCReceiptValID=value;
				NotifyChanged("ICReceiptValID");
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
		public int FK_ICTransactionItemID
		{
			get{return _fK_ICTransactionItemID;}
			set
			{
				if (value != this._fK_ICTransactionItemID)
				{
				_fK_ICTransactionItemID=value;
				NotifyChanged("FK_ICTransactionItemID");
				}
			}
		}
		public String ICTransactionType
		{
			get{return _iCTransactionType;}
			set
			{
				if (value != this._iCTransactionType)
				{
				_iCTransactionType=value;
				NotifyChanged("ICTransactionType");
				}
			}
		}
		public double ICReceiptValQty
		{
			get{return _iCReceiptValQty;}
			set
			{
				if (value != this._iCReceiptValQty)
				{
				_iCReceiptValQty=value;
				NotifyChanged("ICReceiptValQty");
				}
			}
		}
		public double ICReceiptValShpQty
		{
			get{return _iCReceiptValShpQty;}
			set
			{
				if (value != this._iCReceiptValShpQty)
				{
				_iCReceiptValShpQty=value;
				NotifyChanged("ICReceiptValShpQty");
				}
			}
		}
		public double ICReceiptValRQty
		{
			get{return _iCReceiptValRQty;}
			set
			{
				if (value != this._iCReceiptValRQty)
				{
				_iCReceiptValRQty=value;
				NotifyChanged("ICReceiptValRQty");
				}
			}
		}
		public double ICReceiptValCostTot
		{
			get{return _iCReceiptValCostTot;}
			set
			{
				if (value != this._iCReceiptValCostTot)
				{
				_iCReceiptValCostTot=value;
				NotifyChanged("ICReceiptValCostTot");
				}
			}
		}
		public double ICReceiptValUnitCost
		{
			get{return _iCReceiptValUnitCost;}
			set
			{
				if (value != this._iCReceiptValUnitCost)
				{
				_iCReceiptValUnitCost=value;
				NotifyChanged("ICReceiptValUnitCost");
				}
			}
		}
		public Nullable<DateTime> ICReceiptValDate
		{
			get{return _iCReceiptValDate;}
			set
			{
				if (value != this._iCReceiptValDate)
				{
				_iCReceiptValDate=value;
				NotifyChanged("ICReceiptValDate");
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
		public int FK_ICStkUOMID
		{
			get{return _fK_ICStkUOMID;}
			set
			{
				if (value != this._fK_ICStkUOMID)
				{
				_fK_ICStkUOMID=value;
				NotifyChanged("FK_ICStkUOMID");
				}
			}
		}
		public double ICReceiptValStkQty
		{
			get{return _iCReceiptValStkQty;}
			set
			{
				if (value != this._iCReceiptValStkQty)
				{
				_iCReceiptValStkQty=value;
				NotifyChanged("ICReceiptValStkQty");
				}
			}
		}
		public double ICReceiptValRStkQty
		{
			get{return _iCReceiptValRStkQty;}
			set
			{
				if (value != this._iCReceiptValRStkQty)
				{
				_iCReceiptValRStkQty=value;
				NotifyChanged("ICReceiptValRStkQty");
				}
			}
		}
		public int FK_ICWeightUOMID
		{
			get{return _fK_ICWeightUOMID;}
			set
			{
				if (value != this._fK_ICWeightUOMID)
				{
				_fK_ICWeightUOMID=value;
				NotifyChanged("FK_ICWeightUOMID");
				}
			}
		}
		public int FK_ICVolumeUOMID
		{
			get{return _fK_ICVolumeUOMID;}
			set
			{
				if (value != this._fK_ICVolumeUOMID)
				{
				_fK_ICVolumeUOMID=value;
				NotifyChanged("FK_ICVolumeUOMID");
				}
			}
		}
		public double ICReceiptValWTot
		{
			get{return _iCReceiptValWTot;}
			set
			{
				if (value != this._iCReceiptValWTot)
				{
				_iCReceiptValWTot=value;
				NotifyChanged("ICReceiptValWTot");
				}
			}
		}
		public double ICReceiptValVTot
		{
			get{return _iCReceiptValVTot;}
			set
			{
				if (value != this._iCReceiptValVTot)
				{
				_iCReceiptValVTot=value;
				NotifyChanged("ICReceiptValVTot");
				}
			}
		}
		#endregion
	}
	#endregion
}