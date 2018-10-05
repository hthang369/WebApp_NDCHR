using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARContractSchPmts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARContractSchPmtsInfo
	//Created Date:Sunday, July 19, 2009
	//-----------------------------------------------------------
	
	public class ARContractSchPmtsInfo:BusinessObject
	{
		public ARContractSchPmtsInfo()
		{
		}
		#region Variables
		protected int _aRContractSchPmtID;
		protected int _fK_ARContractID;
		protected int _fK_ICProductID;
		protected double _aRContractSchPmtPct;
		protected double _aRContractSchPmtItemPrice;
		protected double _aRContactSchPmtItemTxAmt;
		protected double _aRContactSchPmtItemDiscAmt;
		protected double _aRContractSchPmtItemAmtTot;
		protected double _aRContractSchPmtAmtTot;
		protected DateTime _aRContractSchPmtEstDate=DateTime.MaxValue;
		protected String _aRContactSchPmtStatus=DefaultStatus;
		#endregion

		#region Public properties
		public int ARContractSchPmtID
		{
			get{return _aRContractSchPmtID;}
			set
			{
				if (value != this._aRContractSchPmtID)
				{
				_aRContractSchPmtID=value;
				NotifyChanged("ARContractSchPmtID");
				}
			}
		}
		public int FK_ARContractID
		{
			get{return _fK_ARContractID;}
			set
			{
				if (value != this._fK_ARContractID)
				{
				_fK_ARContractID=value;
				NotifyChanged("FK_ARContractID");
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
		public double ARContractSchPmtPct
		{
			get{return _aRContractSchPmtPct;}
			set
			{
				if (value != this._aRContractSchPmtPct)
				{
				_aRContractSchPmtPct=value;
				NotifyChanged("ARContractSchPmtPct");
				}
			}
		}
		public double ARContractSchPmtItemPrice
		{
			get{return _aRContractSchPmtItemPrice;}
			set
			{
				if (value != this._aRContractSchPmtItemPrice)
				{
				_aRContractSchPmtItemPrice=value;
				NotifyChanged("ARContractSchPmtItemPrice");
				}
			}
		}
		public double ARContactSchPmtItemTxAmt
		{
			get{return _aRContactSchPmtItemTxAmt;}
			set
			{
				if (value != this._aRContactSchPmtItemTxAmt)
				{
				_aRContactSchPmtItemTxAmt=value;
				NotifyChanged("ARContactSchPmtItemTxAmt");
				}
			}
		}
		public double ARContactSchPmtItemDiscAmt
		{
			get{return _aRContactSchPmtItemDiscAmt;}
			set
			{
				if (value != this._aRContactSchPmtItemDiscAmt)
				{
				_aRContactSchPmtItemDiscAmt=value;
				NotifyChanged("ARContactSchPmtItemDiscAmt");
				}
			}
		}
		public double ARContractSchPmtItemAmtTot
		{
			get{return _aRContractSchPmtItemAmtTot;}
			set
			{
				if (value != this._aRContractSchPmtItemAmtTot)
				{
				_aRContractSchPmtItemAmtTot=value;
				NotifyChanged("ARContractSchPmtItemAmtTot");
				}
			}
		}
		public double ARContractSchPmtAmtTot
		{
			get{return _aRContractSchPmtAmtTot;}
			set
			{
				if (value != this._aRContractSchPmtAmtTot)
				{
				_aRContractSchPmtAmtTot=value;
				NotifyChanged("ARContractSchPmtAmtTot");
				}
			}
		}
		public DateTime ARContractSchPmtEstDate
		{
			get{return _aRContractSchPmtEstDate;}
			set
			{
				if (value != this._aRContractSchPmtEstDate)
				{
				_aRContractSchPmtEstDate=value;
				NotifyChanged("ARContractSchPmtEstDate");
				}
			}
		}
		public String ARContactSchPmtStatus
		{
			get{return _aRContactSchPmtStatus;}
			set
			{
				if (value != this._aRContactSchPmtStatus)
				{
				_aRContactSchPmtStatus=value;
				NotifyChanged("ARContactSchPmtStatus");
				}
			}
		}
		#endregion
	}
	#endregion
}