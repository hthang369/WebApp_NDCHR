using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICUOMCalculators
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ICUOMCalculatorsInfo
	//Created Date:Tuesday, April 14, 2015
	//-----------------------------------------------------------
	
	public class ICUOMCalculatorsInfo:BusinessObject
	{
		public ICUOMCalculatorsInfo()
		{
		}
		#region Variables
		protected int _iCUOMCalculatorID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _iCUOMCalculatorNo=String.Empty;
		protected String _iCUOMCalculatorName=String.Empty;
		protected String _iCUOMCalculatorDesc=String.Empty;
		#endregion

		#region Public properties
		public int ICUOMCalculatorID
		{
			get{return _iCUOMCalculatorID;}
			set
			{
				if (value != this._iCUOMCalculatorID)
				{
				_iCUOMCalculatorID=value;
				NotifyChanged("ICUOMCalculatorID");
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
		public String ICUOMCalculatorNo
		{
			get{return _iCUOMCalculatorNo;}
			set
			{
				if (value != this._iCUOMCalculatorNo)
				{
				_iCUOMCalculatorNo=value;
				NotifyChanged("ICUOMCalculatorNo");
				}
			}
		}
		public String ICUOMCalculatorName
		{
			get{return _iCUOMCalculatorName;}
			set
			{
				if (value != this._iCUOMCalculatorName)
				{
				_iCUOMCalculatorName=value;
				NotifyChanged("ICUOMCalculatorName");
				}
			}
		}
		public String ICUOMCalculatorDesc
		{
			get{return _iCUOMCalculatorDesc;}
			set
			{
				if (value != this._iCUOMCalculatorDesc)
				{
				_iCUOMCalculatorDesc=value;
				NotifyChanged("ICUOMCalculatorDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}