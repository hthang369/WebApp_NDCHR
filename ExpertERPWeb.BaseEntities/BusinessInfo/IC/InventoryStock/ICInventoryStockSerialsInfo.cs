using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICInventoryStockSerials
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICInventoryStockSerialsInfo
	//Created Date:Wednesday, July 16, 2008
	//-----------------------------------------------------------
	
	public class ICInventoryStockSerialsInfo:BusinessObject
	{
		public ICInventoryStockSerialsInfo()
		{
		}
        #region Variables
        protected int _iCInventoryStockSerialID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICInventoryStockID;
        protected int _fK_ICProductID;
        protected int _fK_ICStockID;
        protected String _iCInventoryStockSerialProductSerialNo = String.Empty;
        protected double _iCInventoryStockSerialQuantity;
        protected double _iCInventoryStockSerialProposalQuantity;
        protected double _iCInventoryStockSerialSaleOrderQuantity;
        protected double _iCInventoryStockSerialPurchaseOrderQuantity;
		protected int _fK_ICUOMID;
		protected double _iCInventoryStockSerialStkQuantity;
        #endregion

		#region Public properties
		public int ICInventoryStockSerialID
		{
			get{return _iCInventoryStockSerialID;}
			set
			{
				if (value != this._iCInventoryStockSerialID)
				{
				_iCInventoryStockSerialID=value;
				NotifyChanged("ICInventoryStockSerialID");
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
		public int FK_ICInventoryStockID
		{
			get{return _fK_ICInventoryStockID;}
			set
			{
				if (value != this._fK_ICInventoryStockID)
				{
				_fK_ICInventoryStockID=value;
				NotifyChanged("FK_ICInventoryStockID");
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
		public String ICInventoryStockSerialProductSerialNo
		{
			get{return _iCInventoryStockSerialProductSerialNo;}
			set
			{
				if (value != this._iCInventoryStockSerialProductSerialNo)
				{
				_iCInventoryStockSerialProductSerialNo=value;
				NotifyChanged("ICInventoryStockSerialProductSerialNo");
				}
			}
		}
		public double ICInventoryStockSerialQuantity
		{
			get{return _iCInventoryStockSerialQuantity;}
			set
			{
				if (value != this._iCInventoryStockSerialQuantity)
				{
				_iCInventoryStockSerialQuantity=value;
				NotifyChanged("ICInventoryStockSerialQuantity");
				}
			}
		}
		public double ICInventoryStockSerialProposalQuantity
		{
			get{return _iCInventoryStockSerialProposalQuantity;}
			set
			{
				if (value != this._iCInventoryStockSerialProposalQuantity)
				{
				_iCInventoryStockSerialProposalQuantity=value;
				NotifyChanged("ICInventoryStockSerialProposalQuantity");
				}
			}
		}
		public double ICInventoryStockSerialSaleOrderQuantity
		{
			get{return _iCInventoryStockSerialSaleOrderQuantity;}
			set
			{
				if (value != this._iCInventoryStockSerialSaleOrderQuantity)
				{
				_iCInventoryStockSerialSaleOrderQuantity=value;
				NotifyChanged("ICInventoryStockSerialSaleOrderQuantity");
				}
			}
		}
		public double ICInventoryStockSerialPurchaseOrderQuantity
		{
			get{return _iCInventoryStockSerialPurchaseOrderQuantity;}
			set
			{
				if (value != this._iCInventoryStockSerialPurchaseOrderQuantity)
				{
				_iCInventoryStockSerialPurchaseOrderQuantity=value;
				NotifyChanged("ICInventoryStockSerialPurchaseOrderQuantity");
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
		public double ICInventoryStockSerialStkQuantity
		{
			get{return _iCInventoryStockSerialStkQuantity;}
			set
			{
				if (value != this._iCInventoryStockSerialStkQuantity)
				{
				_iCInventoryStockSerialStkQuantity=value;
				NotifyChanged("ICInventoryStockSerialStkQuantity");
				}
			}
		}
		#endregion
	}
	#endregion
}