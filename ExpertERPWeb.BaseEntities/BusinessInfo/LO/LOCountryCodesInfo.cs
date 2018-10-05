using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOCountryCodes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOCountryCodesInfo
	//Created Date:Tuesday, March 03, 2009
	//-----------------------------------------------------------
	
	public class LOCountryCodesInfo:BusinessObject
	{
		public LOCountryCodesInfo()
		{
		}
		#region Variables
		protected int _lOCountryCodeID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _lOCountryCodeNo=String.Empty;
		protected String _lOCountryCodeName=String.Empty;
		protected String _lOCountryCodeDesc=String.Empty;
		protected String _lOCountryCodeOF01Combo=String.Empty;
		protected String _lOCountryCodeOF02Combo=String.Empty;
		protected String _lOCountryCodeOF03Combo=String.Empty;
		protected String _lOCountryCodeOF04Combo=String.Empty;
		protected String _lOCountryCodeOF05Combo=String.Empty;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		#endregion

		#region Public properties
		public int LOCountryCodeID
		{
			get{return _lOCountryCodeID;}
			set
			{
				if (value != this._lOCountryCodeID)
				{
				_lOCountryCodeID=value;
				NotifyChanged("LOCountryCodeID");
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
		public String LOCountryCodeNo
		{
			get{return _lOCountryCodeNo;}
			set
			{
				if (value != this._lOCountryCodeNo)
				{
				_lOCountryCodeNo=value;
				NotifyChanged("LOCountryCodeNo");
				}
			}
		}
		public String LOCountryCodeName
		{
			get{return _lOCountryCodeName;}
			set
			{
				if (value != this._lOCountryCodeName)
				{
				_lOCountryCodeName=value;
				NotifyChanged("LOCountryCodeName");
				}
			}
		}
		public String LOCountryCodeDesc
		{
			get{return _lOCountryCodeDesc;}
			set
			{
				if (value != this._lOCountryCodeDesc)
				{
				_lOCountryCodeDesc=value;
				NotifyChanged("LOCountryCodeDesc");
				}
			}
		}
		public String LOCountryCodeOF01Combo
		{
			get{return _lOCountryCodeOF01Combo;}
			set
			{
				if (value != this._lOCountryCodeOF01Combo)
				{
				_lOCountryCodeOF01Combo=value;
				NotifyChanged("LOCountryCodeOF01Combo");
				}
			}
		}
		public String LOCountryCodeOF02Combo
		{
			get{return _lOCountryCodeOF02Combo;}
			set
			{
				if (value != this._lOCountryCodeOF02Combo)
				{
				_lOCountryCodeOF02Combo=value;
				NotifyChanged("LOCountryCodeOF02Combo");
				}
			}
		}
		public String LOCountryCodeOF03Combo
		{
			get{return _lOCountryCodeOF03Combo;}
			set
			{
				if (value != this._lOCountryCodeOF03Combo)
				{
				_lOCountryCodeOF03Combo=value;
				NotifyChanged("LOCountryCodeOF03Combo");
				}
			}
		}
		public String LOCountryCodeOF04Combo
		{
			get{return _lOCountryCodeOF04Combo;}
			set
			{
				if (value != this._lOCountryCodeOF04Combo)
				{
				_lOCountryCodeOF04Combo=value;
				NotifyChanged("LOCountryCodeOF04Combo");
				}
			}
		}
		public String LOCountryCodeOF05Combo
		{
			get{return _lOCountryCodeOF05Combo;}
			set
			{
				if (value != this._lOCountryCodeOF05Combo)
				{
				_lOCountryCodeOF05Combo=value;
				NotifyChanged("LOCountryCodeOF05Combo");
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
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		#endregion
	}
	#endregion
}