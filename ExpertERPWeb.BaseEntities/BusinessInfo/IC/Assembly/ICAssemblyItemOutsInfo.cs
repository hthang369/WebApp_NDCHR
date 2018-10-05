using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICAssemblyItemOuts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICAssemblyItemOutsInfo
	//Created Date:Tuesday, November 25, 2014
	//-----------------------------------------------------------
	
	public class ICAssemblyItemOutsInfo:BusinessObject
	{
		public ICAssemblyItemOutsInfo()
		{
		}
		#region Variables
		protected int _iCAssemblyItemOutID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_ICAssemblyID;
		protected int _fK_TXTaxCodeID;
		protected String _iCAssemblyItemOutSerialNo=String.Empty;
		protected bool _iCAssemblyItemOutIsStkItm=true;
		protected String _iCAssemblyItemOutUOM=String.Empty;
		protected String _iCAssemblyItemOutStkUOM=String.Empty;
		protected double _iCAssemblyItemOutUnitPrice;
		protected double _iCAssemblyItemOutUnitCost;
		protected double _iCAssemblyItemOutDiscPct;
		protected double _iCAssemblyItemOutTxPct;
		protected double _iCAssemblyItemOutQty;
		protected double _iCAssemblyItemOutStkQty;
		protected double _iCAssemblyItemOutRQty;
		protected double _iCAssemblyItemOutRStkQty;
		protected double _iCAssemblyItemOutPrice;
		protected double _iCAssemblyItemOutUnitVolumn;
		protected double _iCAssemblyItemOutUnitWeight;
		protected double _iCAssemblyItemOutTxAmt;
		protected double _iCAssemblyItemOutDiscAmt;
		protected double _iCAssemblyItemOutNetAmt;
		protected double _iCAssemblyItemOutAmtTot;
		protected double _iCAssemblyItemOutCostTot;
		protected double _iCAssemblyItemOutAmt;
		protected double _iCAssemblyItemOutCAmt;
		protected double _iCAssemblyItemOutWTot;
		protected double _iCAssemblyItemOutVTot;
		protected double _iCAssemblyItemOutRAmt;
		protected int _fK_ICStockSlotID;
		protected String _iCAssemblyItemOutLotNo=String.Empty;
		protected String _iCAssemblyItemOutDesc=String.Empty;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _iCAssemblyItemOutFact;
		#endregion

		#region Public properties
		public int ICAssemblyItemOutID
		{
			get{return _iCAssemblyItemOutID;}
			set
			{
				if (value != this._iCAssemblyItemOutID)
				{
				_iCAssemblyItemOutID=value;
				NotifyChanged("ICAssemblyItemOutID");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get{return _aACreatedDate;}
			set
			{
				if (value != this._aACreatedDate)
				{
				_aACreatedDate=value;
				NotifyChanged("AACreatedDate");
				}
			}
		}
		public String AACreatedUser
		{
			get{return _aACreatedUser;}
			set
			{
				if (value != this._aACreatedUser)
				{
				_aACreatedUser=value;
				NotifyChanged("AACreatedUser");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get{return _aAUpdatedDate;}
			set
			{
				if (value != this._aAUpdatedDate)
				{
				_aAUpdatedDate=value;
				NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String AAUpdatedUser
		{
			get{return _aAUpdatedUser;}
			set
			{
				if (value != this._aAUpdatedUser)
				{
				_aAUpdatedUser=value;
				NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
				_aAStatus=value;
				NotifyChanged("AAStatus");
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
		public int FK_ICAssemblyID
		{
			get{return _fK_ICAssemblyID;}
			set
			{
				if (value != this._fK_ICAssemblyID)
				{
				_fK_ICAssemblyID=value;
				NotifyChanged("FK_ICAssemblyID");
				}
			}
		}
		public int FK_TXTaxCodeID
		{
			get{return _fK_TXTaxCodeID;}
			set
			{
				if (value != this._fK_TXTaxCodeID)
				{
				_fK_TXTaxCodeID=value;
				NotifyChanged("FK_TXTaxCodeID");
				}
			}
		}
		public String ICAssemblyItemOutSerialNo
		{
			get{return _iCAssemblyItemOutSerialNo;}
			set
			{
				if (value != this._iCAssemblyItemOutSerialNo)
				{
				_iCAssemblyItemOutSerialNo=value;
				NotifyChanged("ICAssemblyItemOutSerialNo");
				}
			}
		}
		public bool ICAssemblyItemOutIsStkItm
		{
			get{return _iCAssemblyItemOutIsStkItm;}
			set
			{
				if (value != this._iCAssemblyItemOutIsStkItm)
				{
				_iCAssemblyItemOutIsStkItm=value;
				NotifyChanged("ICAssemblyItemOutIsStkItm");
				}
			}
		}
		public String ICAssemblyItemOutUOM
		{
			get{return _iCAssemblyItemOutUOM;}
			set
			{
				if (value != this._iCAssemblyItemOutUOM)
				{
				_iCAssemblyItemOutUOM=value;
				NotifyChanged("ICAssemblyItemOutUOM");
				}
			}
		}
		public String ICAssemblyItemOutStkUOM
		{
			get{return _iCAssemblyItemOutStkUOM;}
			set
			{
				if (value != this._iCAssemblyItemOutStkUOM)
				{
				_iCAssemblyItemOutStkUOM=value;
				NotifyChanged("ICAssemblyItemOutStkUOM");
				}
			}
		}
		public double ICAssemblyItemOutUnitPrice
		{
			get{return _iCAssemblyItemOutUnitPrice;}
			set
			{
				if (value != this._iCAssemblyItemOutUnitPrice)
				{
				_iCAssemblyItemOutUnitPrice=value;
				NotifyChanged("ICAssemblyItemOutUnitPrice");
				}
			}
		}
		public double ICAssemblyItemOutUnitCost
		{
			get{return _iCAssemblyItemOutUnitCost;}
			set
			{
				if (value != this._iCAssemblyItemOutUnitCost)
				{
				_iCAssemblyItemOutUnitCost=value;
				NotifyChanged("ICAssemblyItemOutUnitCost");
				}
			}
		}
		public double ICAssemblyItemOutDiscPct
		{
			get{return _iCAssemblyItemOutDiscPct;}
			set
			{
				if (value != this._iCAssemblyItemOutDiscPct)
				{
				_iCAssemblyItemOutDiscPct=value;
				NotifyChanged("ICAssemblyItemOutDiscPct");
				}
			}
		}
		public double ICAssemblyItemOutTxPct
		{
			get{return _iCAssemblyItemOutTxPct;}
			set
			{
				if (value != this._iCAssemblyItemOutTxPct)
				{
				_iCAssemblyItemOutTxPct=value;
				NotifyChanged("ICAssemblyItemOutTxPct");
				}
			}
		}
		public double ICAssemblyItemOutQty
		{
			get{return _iCAssemblyItemOutQty;}
			set
			{
				if (value != this._iCAssemblyItemOutQty)
				{
				_iCAssemblyItemOutQty=value;
				NotifyChanged("ICAssemblyItemOutQty");
				}
			}
		}
		public double ICAssemblyItemOutStkQty
		{
			get{return _iCAssemblyItemOutStkQty;}
			set
			{
				if (value != this._iCAssemblyItemOutStkQty)
				{
				_iCAssemblyItemOutStkQty=value;
				NotifyChanged("ICAssemblyItemOutStkQty");
				}
			}
		}
		public double ICAssemblyItemOutRQty
		{
			get{return _iCAssemblyItemOutRQty;}
			set
			{
				if (value != this._iCAssemblyItemOutRQty)
				{
				_iCAssemblyItemOutRQty=value;
				NotifyChanged("ICAssemblyItemOutRQty");
				}
			}
		}
		public double ICAssemblyItemOutRStkQty
		{
			get{return _iCAssemblyItemOutRStkQty;}
			set
			{
				if (value != this._iCAssemblyItemOutRStkQty)
				{
				_iCAssemblyItemOutRStkQty=value;
				NotifyChanged("ICAssemblyItemOutRStkQty");
				}
			}
		}
		public double ICAssemblyItemOutPrice
		{
			get{return _iCAssemblyItemOutPrice;}
			set
			{
				if (value != this._iCAssemblyItemOutPrice)
				{
				_iCAssemblyItemOutPrice=value;
				NotifyChanged("ICAssemblyItemOutPrice");
				}
			}
		}
		public double ICAssemblyItemOutUnitVolumn
		{
			get{return _iCAssemblyItemOutUnitVolumn;}
			set
			{
				if (value != this._iCAssemblyItemOutUnitVolumn)
				{
				_iCAssemblyItemOutUnitVolumn=value;
				NotifyChanged("ICAssemblyItemOutUnitVolumn");
				}
			}
		}
		public double ICAssemblyItemOutUnitWeight
		{
			get{return _iCAssemblyItemOutUnitWeight;}
			set
			{
				if (value != this._iCAssemblyItemOutUnitWeight)
				{
				_iCAssemblyItemOutUnitWeight=value;
				NotifyChanged("ICAssemblyItemOutUnitWeight");
				}
			}
		}
		public double ICAssemblyItemOutTxAmt
		{
			get{return _iCAssemblyItemOutTxAmt;}
			set
			{
				if (value != this._iCAssemblyItemOutTxAmt)
				{
				_iCAssemblyItemOutTxAmt=value;
				NotifyChanged("ICAssemblyItemOutTxAmt");
				}
			}
		}
		public double ICAssemblyItemOutDiscAmt
		{
			get{return _iCAssemblyItemOutDiscAmt;}
			set
			{
				if (value != this._iCAssemblyItemOutDiscAmt)
				{
				_iCAssemblyItemOutDiscAmt=value;
				NotifyChanged("ICAssemblyItemOutDiscAmt");
				}
			}
		}
		public double ICAssemblyItemOutNetAmt
		{
			get{return _iCAssemblyItemOutNetAmt;}
			set
			{
				if (value != this._iCAssemblyItemOutNetAmt)
				{
				_iCAssemblyItemOutNetAmt=value;
				NotifyChanged("ICAssemblyItemOutNetAmt");
				}
			}
		}
		public double ICAssemblyItemOutAmtTot
		{
			get{return _iCAssemblyItemOutAmtTot;}
			set
			{
				if (value != this._iCAssemblyItemOutAmtTot)
				{
				_iCAssemblyItemOutAmtTot=value;
				NotifyChanged("ICAssemblyItemOutAmtTot");
				}
			}
		}
		public double ICAssemblyItemOutCostTot
		{
			get{return _iCAssemblyItemOutCostTot;}
			set
			{
				if (value != this._iCAssemblyItemOutCostTot)
				{
				_iCAssemblyItemOutCostTot=value;
				NotifyChanged("ICAssemblyItemOutCostTot");
				}
			}
		}
		public double ICAssemblyItemOutAmt
		{
			get{return _iCAssemblyItemOutAmt;}
			set
			{
				if (value != this._iCAssemblyItemOutAmt)
				{
				_iCAssemblyItemOutAmt=value;
				NotifyChanged("ICAssemblyItemOutAmt");
				}
			}
		}
		public double ICAssemblyItemOutCAmt
		{
			get{return _iCAssemblyItemOutCAmt;}
			set
			{
				if (value != this._iCAssemblyItemOutCAmt)
				{
				_iCAssemblyItemOutCAmt=value;
				NotifyChanged("ICAssemblyItemOutCAmt");
				}
			}
		}
		public double ICAssemblyItemOutWTot
		{
			get{return _iCAssemblyItemOutWTot;}
			set
			{
				if (value != this._iCAssemblyItemOutWTot)
				{
				_iCAssemblyItemOutWTot=value;
				NotifyChanged("ICAssemblyItemOutWTot");
				}
			}
		}
		public double ICAssemblyItemOutVTot
		{
			get{return _iCAssemblyItemOutVTot;}
			set
			{
				if (value != this._iCAssemblyItemOutVTot)
				{
				_iCAssemblyItemOutVTot=value;
				NotifyChanged("ICAssemblyItemOutVTot");
				}
			}
		}
		public double ICAssemblyItemOutRAmt
		{
			get{return _iCAssemblyItemOutRAmt;}
			set
			{
				if (value != this._iCAssemblyItemOutRAmt)
				{
				_iCAssemblyItemOutRAmt=value;
				NotifyChanged("ICAssemblyItemOutRAmt");
				}
			}
		}
		public int FK_ICStockSlotID
		{
			get{return _fK_ICStockSlotID;}
			set
			{
				if (value != this._fK_ICStockSlotID)
				{
				_fK_ICStockSlotID=value;
				NotifyChanged("FK_ICStockSlotID");
				}
			}
		}
		public String ICAssemblyItemOutLotNo
		{
			get{return _iCAssemblyItemOutLotNo;}
			set
			{
				if (value != this._iCAssemblyItemOutLotNo)
				{
				_iCAssemblyItemOutLotNo=value;
				NotifyChanged("ICAssemblyItemOutLotNo");
				}
			}
		}
		public String ICAssemblyItemOutDesc
		{
			get{return _iCAssemblyItemOutDesc;}
			set
			{
				if (value != this._iCAssemblyItemOutDesc)
				{
				_iCAssemblyItemOutDesc=value;
				NotifyChanged("ICAssemblyItemOutDesc");
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
		public double ICAssemblyItemOutFact
		{
			get{return _iCAssemblyItemOutFact;}
			set
			{
				if (value != this._iCAssemblyItemOutFact)
				{
				_iCAssemblyItemOutFact=value;
				NotifyChanged("ICAssemblyItemOutFact");
				}
			}
		}
		#endregion
	}
	#endregion
}