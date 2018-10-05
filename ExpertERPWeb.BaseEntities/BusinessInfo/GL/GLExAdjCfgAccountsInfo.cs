using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLExAdjCfgAccounts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLExAdjCfgAccountsInfo
	//Created Date:23 Tháng Tám 2013
	//-----------------------------------------------------------
	
	public class GLExAdjCfgAccountsInfo:BusinessObject
	{
		public GLExAdjCfgAccountsInfo()
		{
		}
		#region Variables
		protected int _gLExAdjCfgAccountID;
		protected int _fK_GLExAdjCfgID;
		protected int _fK_GLAccountID;
		protected int _fK_GECurrencyID;
		protected String _gLAccountBalanceTypeCombo=String.Empty;
		#endregion

		#region Public properties
		public int GLExAdjCfgAccountID
		{
			get{return _gLExAdjCfgAccountID;}
			set
			{
				if (value != this._gLExAdjCfgAccountID)
				{
				_gLExAdjCfgAccountID=value;
				NotifyChanged("GLExAdjCfgAccountID");
				}
			}
		}
		public int FK_GLExAdjCfgID
		{
			get{return _fK_GLExAdjCfgID;}
			set
			{
				if (value != this._fK_GLExAdjCfgID)
				{
				_fK_GLExAdjCfgID=value;
				NotifyChanged("FK_GLExAdjCfgID");
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
		public int FK_GECurrencyID
		{
			get{return _fK_GECurrencyID;}
			set
			{
				if (value != this._fK_GECurrencyID)
				{
				_fK_GECurrencyID=value;
				NotifyChanged("FK_GECurrencyID");
				}
			}
		}
		public String GLAccountBalanceTypeCombo
		{
			get{return _gLAccountBalanceTypeCombo;}
			set
			{
				if (value != this._gLAccountBalanceTypeCombo)
				{
				_gLAccountBalanceTypeCombo=value;
				NotifyChanged("GLAccountBalanceTypeCombo");
				}
			}
		}
		#endregion
	}
	#endregion
}