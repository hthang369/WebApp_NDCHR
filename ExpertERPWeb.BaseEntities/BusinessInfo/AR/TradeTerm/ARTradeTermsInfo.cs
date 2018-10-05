using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARTradeTerms
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARTradeTermsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class ARTradeTermsInfo:BusinessObject
	{
		public ARTradeTermsInfo()
		{
		}
		#region Variables
		protected int _aRTradeTermID;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected bool _aASelected=true;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aRTradeTermNo=String.Empty;
		protected String _aRTradeTermName=String.Empty;
		protected String _aRTradeTermDesc=String.Empty;
		protected String _aRTradeTermDateCalcTypeCombo=String.Empty;
		protected String _aRTradeTermMaturityTypeCombo=String.Empty;
		protected int _aRTradeTermDay;
		#endregion

		#region Public properties
		public int ARTradeTermID
		{
			get{return _aRTradeTermID;}
			set
			{
				if (value != this._aRTradeTermID)
				{
				_aRTradeTermID=value;
				NotifyChanged("ARTradeTermID");
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
		public String ARTradeTermNo
		{
			get{return _aRTradeTermNo;}
			set
			{
				if (value != this._aRTradeTermNo)
				{
				_aRTradeTermNo=value;
				NotifyChanged("ARTradeTermNo");
				}
			}
		}
		public String ARTradeTermName
		{
			get{return _aRTradeTermName;}
			set
			{
				if (value != this._aRTradeTermName)
				{
				_aRTradeTermName=value;
				NotifyChanged("ARTradeTermName");
				}
			}
		}
		public String ARTradeTermDesc
		{
			get{return _aRTradeTermDesc;}
			set
			{
				if (value != this._aRTradeTermDesc)
				{
				_aRTradeTermDesc=value;
				NotifyChanged("ARTradeTermDesc");
				}
			}
		}
		public String ARTradeTermDateCalcTypeCombo
		{
			get{return _aRTradeTermDateCalcTypeCombo;}
			set
			{
				if (value != this._aRTradeTermDateCalcTypeCombo)
				{
				_aRTradeTermDateCalcTypeCombo=value;
				NotifyChanged("ARTradeTermDateCalcTypeCombo");
				}
			}
		}
		public String ARTradeTermMaturityTypeCombo
		{
			get{return _aRTradeTermMaturityTypeCombo;}
			set
			{
				if (value != this._aRTradeTermMaturityTypeCombo)
				{
				_aRTradeTermMaturityTypeCombo=value;
				NotifyChanged("ARTradeTermMaturityTypeCombo");
				}
			}
		}
		public int ARTradeTermDay
		{
			get{return _aRTradeTermDay;}
			set
			{
				if (value != this._aRTradeTermDay)
				{
				_aRTradeTermDay=value;
				NotifyChanged("ARTradeTermDay");
				}
			}
		}
		#endregion
	}
	#endregion
}