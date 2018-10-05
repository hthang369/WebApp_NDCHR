using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APPmtTerms
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:APPmtTermsInfo
	//Created Date:Tuesday, May 15, 2012
	//-----------------------------------------------------------
	
	public class APPmtTermsInfo:BusinessObject
	{
		public APPmtTermsInfo()
		{
		}
		#region Variables
		protected int _aPPmtTermID;
		protected String _aPPmtTermNo=String.Empty;
		protected String _aPPmtTermName=String.Empty;
		protected String _aPPmtTermDesc=String.Empty;
		protected String _aPPmtTermCalDiscWithTax=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected double _aPPmtTermOverDueRatePct;
		protected double _aPPmtTermPenaltyRatePct;
		#endregion

		#region Public properties
		public int APPmtTermID
		{
			get{return _aPPmtTermID;}
			set
			{
				if (value != this._aPPmtTermID)
				{
				_aPPmtTermID=value;
				NotifyChanged("APPmtTermID");
				}
			}
		}
		public String APPmtTermNo
		{
			get{return _aPPmtTermNo;}
			set
			{
				if (value != this._aPPmtTermNo)
				{
				_aPPmtTermNo=value;
				NotifyChanged("APPmtTermNo");
				}
			}
		}
		public String APPmtTermName
		{
			get{return _aPPmtTermName;}
			set
			{
				if (value != this._aPPmtTermName)
				{
				_aPPmtTermName=value;
				NotifyChanged("APPmtTermName");
				}
			}
		}
		public String APPmtTermDesc
		{
			get{return _aPPmtTermDesc;}
			set
			{
				if (value != this._aPPmtTermDesc)
				{
				_aPPmtTermDesc=value;
				NotifyChanged("APPmtTermDesc");
				}
			}
		}
		public String APPmtTermCalDiscWithTax
		{
			get{return _aPPmtTermCalDiscWithTax;}
			set
			{
				if (value != this._aPPmtTermCalDiscWithTax)
				{
				_aPPmtTermCalDiscWithTax=value;
				NotifyChanged("APPmtTermCalDiscWithTax");
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
		public double APPmtTermOverDueRatePct
		{
			get{return _aPPmtTermOverDueRatePct;}
			set
			{
				if (value != this._aPPmtTermOverDueRatePct)
				{
				_aPPmtTermOverDueRatePct=value;
				NotifyChanged("APPmtTermOverDueRatePct");
				}
			}
		}
		public double APPmtTermPenaltyRatePct
		{
			get{return _aPPmtTermPenaltyRatePct;}
			set
			{
				if (value != this._aPPmtTermPenaltyRatePct)
				{
				_aPPmtTermPenaltyRatePct=value;
				NotifyChanged("APPmtTermPenaltyRatePct");
				}
			}
		}
		#endregion
	}
	#endregion
}