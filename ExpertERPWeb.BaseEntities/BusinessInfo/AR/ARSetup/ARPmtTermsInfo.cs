using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARPmtTerms
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARPmtTermsInfo
	//Created Date:Friday, May 11, 2012
	//-----------------------------------------------------------
	
	public class ARPmtTermsInfo:BusinessObject
	{
		public ARPmtTermsInfo()
		{
		}
		#region Variables
		protected int _aRPmtTermID;
		protected String _aRPmtTermNo=String.Empty;
		protected String _aRPmtTermName=String.Empty;
		protected String _aRPmtTermDesc=String.Empty;
		protected String _aRPmtTermCalDiscWithTax=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected double _aRPmtTermOverDueRatePct;
		protected double _aRPmtTermPenaltyRatePct;
		#endregion

		#region Public properties
		public int ARPmtTermID
		{
			get{return _aRPmtTermID;}
			set
			{
				if (value != this._aRPmtTermID)
				{
				_aRPmtTermID=value;
				NotifyChanged("ARPmtTermID");
				}
			}
		}
		public String ARPmtTermNo
		{
			get{return _aRPmtTermNo;}
			set
			{
				if (value != this._aRPmtTermNo)
				{
				_aRPmtTermNo=value;
				NotifyChanged("ARPmtTermNo");
				}
			}
		}
		public String ARPmtTermName
		{
			get{return _aRPmtTermName;}
			set
			{
				if (value != this._aRPmtTermName)
				{
				_aRPmtTermName=value;
				NotifyChanged("ARPmtTermName");
				}
			}
		}
		public String ARPmtTermDesc
		{
			get{return _aRPmtTermDesc;}
			set
			{
				if (value != this._aRPmtTermDesc)
				{
				_aRPmtTermDesc=value;
				NotifyChanged("ARPmtTermDesc");
				}
			}
		}
		public String ARPmtTermCalDiscWithTax
		{
			get{return _aRPmtTermCalDiscWithTax;}
			set
			{
				if (value != this._aRPmtTermCalDiscWithTax)
				{
				_aRPmtTermCalDiscWithTax=value;
				NotifyChanged("ARPmtTermCalDiscWithTax");
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
		public double ARPmtTermOverDueRatePct
		{
			get{return _aRPmtTermOverDueRatePct;}
			set
			{
				if (value != this._aRPmtTermOverDueRatePct)
				{
				_aRPmtTermOverDueRatePct=value;
				NotifyChanged("ARPmtTermOverDueRatePct");
				}
			}
		}
		public double ARPmtTermPenaltyRatePct
		{
			get{return _aRPmtTermPenaltyRatePct;}
			set
			{
				if (value != this._aRPmtTermPenaltyRatePct)
				{
				_aRPmtTermPenaltyRatePct=value;
				NotifyChanged("ARPmtTermPenaltyRatePct");
				}
			}
		}
		#endregion
	}
	#endregion
}