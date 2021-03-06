using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLTranCfgItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLTranCfgItemsInfo
	//Created Date:Friday, December 28, 2012
	//-----------------------------------------------------------
	
	public class GLTranCfgItemsInfo:BusinessObject
	{
		public GLTranCfgItemsInfo()
		{
		}
		#region Variables
		protected int _gLTranCfgItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_GLTranCfgID;
		protected String _gLTranCfgItemDesc=String.Empty;
		protected int _fK_GLDebitAccountID;
		protected int _fK_GLCreditAccountID;
		protected int _fK_GLVATDebitAccountID;
		protected int _fK_GLVATCreditAccountID;
		protected int _fK_ICProductID;
		protected int _fK_ARCustomerID;
		protected int _fK_APSupplierID;
		protected double _gLTranCfgItemRatePct;
		#endregion

		#region Public properties
		public int GLTranCfgItemID
		{
			get{return _gLTranCfgItemID;}
			set
			{
				if (value != this._gLTranCfgItemID)
				{
				_gLTranCfgItemID=value;
				NotifyChanged("GLTranCfgItemID");
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
		public int FK_GLTranCfgID
		{
			get{return _fK_GLTranCfgID;}
			set
			{
				if (value != this._fK_GLTranCfgID)
				{
				_fK_GLTranCfgID=value;
				NotifyChanged("FK_GLTranCfgID");
				}
			}
		}
		public String GLTranCfgItemDesc
		{
			get{return _gLTranCfgItemDesc;}
			set
			{
				if (value != this._gLTranCfgItemDesc)
				{
				_gLTranCfgItemDesc=value;
				NotifyChanged("GLTranCfgItemDesc");
				}
			}
		}
		public int FK_GLDebitAccountID
		{
			get{return _fK_GLDebitAccountID;}
			set
			{
				if (value != this._fK_GLDebitAccountID)
				{
				_fK_GLDebitAccountID=value;
				NotifyChanged("FK_GLDebitAccountID");
				}
			}
		}
		public int FK_GLCreditAccountID
		{
			get{return _fK_GLCreditAccountID;}
			set
			{
				if (value != this._fK_GLCreditAccountID)
				{
				_fK_GLCreditAccountID=value;
				NotifyChanged("FK_GLCreditAccountID");
				}
			}
		}
		public int FK_GLVATDebitAccountID
		{
			get{return _fK_GLVATDebitAccountID;}
			set
			{
				if (value != this._fK_GLVATDebitAccountID)
				{
				_fK_GLVATDebitAccountID=value;
				NotifyChanged("FK_GLVATDebitAccountID");
				}
			}
		}
		public int FK_GLVATCreditAccountID
		{
			get{return _fK_GLVATCreditAccountID;}
			set
			{
				if (value != this._fK_GLVATCreditAccountID)
				{
				_fK_GLVATCreditAccountID=value;
				NotifyChanged("FK_GLVATCreditAccountID");
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
		public int FK_ARCustomerID
		{
			get{return _fK_ARCustomerID;}
			set
			{
				if (value != this._fK_ARCustomerID)
				{
				_fK_ARCustomerID=value;
				NotifyChanged("FK_ARCustomerID");
				}
			}
		}
		public int FK_APSupplierID
		{
			get{return _fK_APSupplierID;}
			set
			{
				if (value != this._fK_APSupplierID)
				{
				_fK_APSupplierID=value;
				NotifyChanged("FK_APSupplierID");
				}
			}
		}
		public double GLTranCfgItemRatePct
		{
			get{return _gLTranCfgItemRatePct;}
			set
			{
				if (value != this._gLTranCfgItemRatePct)
				{
				_gLTranCfgItemRatePct=value;
				NotifyChanged("GLTranCfgItemRatePct");
				}
			}
		}
		#endregion
	}
	#endregion
}