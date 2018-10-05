using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLNations
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GLNationsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class GLNationsInfo:BusinessObject
	{
		public GLNationsInfo()
		{
		}
		#region Variables
		protected int _gLNationID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected String _gLNationNo=String.Empty;
		protected String _gLNationName=String.Empty;
		protected String _gLNationDesc=String.Empty;
		protected String _gLNationNOF01Combo=String.Empty;
		protected String _gLNationNOF02Combo=String.Empty;
		protected String _gLNationNOF03Combo=String.Empty;
		protected String _gLNationNOF04Combo=String.Empty;
		protected String _gLNationNOF05Combo=String.Empty;
		protected String _gLNationOOF01Combo=String.Empty;
		protected String _gLNationOOF02Combo=String.Empty;
		protected String _gLNationOOF03Combo=String.Empty;
		protected String _gLNationOOF04Combo=String.Empty;
		protected String _gLNationOOF05Combo=String.Empty;
		protected String _gLNationOOF06Combo=String.Empty;
		protected String _gLNationOOF07Combo=String.Empty;
		protected String _gLNationOOF08Combo=String.Empty;
		protected String _gLNationOOF09Combo=String.Empty;
		protected String _gLNationOOF10Combo=String.Empty;
		#endregion

		#region Public properties
		public int GLNationID
		{
			get{return _gLNationID;}
			set
			{
				if (value != this._gLNationID)
				{
				_gLNationID=value;
				NotifyChanged("GLNationID");
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
		public String GLNationNo
		{
			get{return _gLNationNo;}
			set
			{
				if (value != this._gLNationNo)
				{
				_gLNationNo=value;
				NotifyChanged("GLNationNo");
				}
			}
		}
		public String GLNationName
		{
			get{return _gLNationName;}
			set
			{
				if (value != this._gLNationName)
				{
				_gLNationName=value;
				NotifyChanged("GLNationName");
				}
			}
		}
		public String GLNationDesc
		{
			get{return _gLNationDesc;}
			set
			{
				if (value != this._gLNationDesc)
				{
				_gLNationDesc=value;
				NotifyChanged("GLNationDesc");
				}
			}
		}
		public String GLNationNOF01Combo
		{
			get{return _gLNationNOF01Combo;}
			set
			{
				if (value != this._gLNationNOF01Combo)
				{
				_gLNationNOF01Combo=value;
				NotifyChanged("GLNationNOF01Combo");
				}
			}
		}
		public String GLNationNOF02Combo
		{
			get{return _gLNationNOF02Combo;}
			set
			{
				if (value != this._gLNationNOF02Combo)
				{
				_gLNationNOF02Combo=value;
				NotifyChanged("GLNationNOF02Combo");
				}
			}
		}
		public String GLNationNOF03Combo
		{
			get{return _gLNationNOF03Combo;}
			set
			{
				if (value != this._gLNationNOF03Combo)
				{
				_gLNationNOF03Combo=value;
				NotifyChanged("GLNationNOF03Combo");
				}
			}
		}
		public String GLNationNOF04Combo
		{
			get{return _gLNationNOF04Combo;}
			set
			{
				if (value != this._gLNationNOF04Combo)
				{
				_gLNationNOF04Combo=value;
				NotifyChanged("GLNationNOF04Combo");
				}
			}
		}
		public String GLNationNOF05Combo
		{
			get{return _gLNationNOF05Combo;}
			set
			{
				if (value != this._gLNationNOF05Combo)
				{
				_gLNationNOF05Combo=value;
				NotifyChanged("GLNationNOF05Combo");
				}
			}
		}
		public String GLNationOOF01Combo
		{
			get{return _gLNationOOF01Combo;}
			set
			{
				if (value != this._gLNationOOF01Combo)
				{
				_gLNationOOF01Combo=value;
				NotifyChanged("GLNationOOF01Combo");
				}
			}
		}
		public String GLNationOOF02Combo
		{
			get{return _gLNationOOF02Combo;}
			set
			{
				if (value != this._gLNationOOF02Combo)
				{
				_gLNationOOF02Combo=value;
				NotifyChanged("GLNationOOF02Combo");
				}
			}
		}
		public String GLNationOOF03Combo
		{
			get{return _gLNationOOF03Combo;}
			set
			{
				if (value != this._gLNationOOF03Combo)
				{
				_gLNationOOF03Combo=value;
				NotifyChanged("GLNationOOF03Combo");
				}
			}
		}
		public String GLNationOOF04Combo
		{
			get{return _gLNationOOF04Combo;}
			set
			{
				if (value != this._gLNationOOF04Combo)
				{
				_gLNationOOF04Combo=value;
				NotifyChanged("GLNationOOF04Combo");
				}
			}
		}
		public String GLNationOOF05Combo
		{
			get{return _gLNationOOF05Combo;}
			set
			{
				if (value != this._gLNationOOF05Combo)
				{
				_gLNationOOF05Combo=value;
				NotifyChanged("GLNationOOF05Combo");
				}
			}
		}
		public String GLNationOOF06Combo
		{
			get{return _gLNationOOF06Combo;}
			set
			{
				if (value != this._gLNationOOF06Combo)
				{
				_gLNationOOF06Combo=value;
				NotifyChanged("GLNationOOF06Combo");
				}
			}
		}
		public String GLNationOOF07Combo
		{
			get{return _gLNationOOF07Combo;}
			set
			{
				if (value != this._gLNationOOF07Combo)
				{
				_gLNationOOF07Combo=value;
				NotifyChanged("GLNationOOF07Combo");
				}
			}
		}
		public String GLNationOOF08Combo
		{
			get{return _gLNationOOF08Combo;}
			set
			{
				if (value != this._gLNationOOF08Combo)
				{
				_gLNationOOF08Combo=value;
				NotifyChanged("GLNationOOF08Combo");
				}
			}
		}
		public String GLNationOOF09Combo
		{
			get{return _gLNationOOF09Combo;}
			set
			{
				if (value != this._gLNationOOF09Combo)
				{
				_gLNationOOF09Combo=value;
				NotifyChanged("GLNationOOF09Combo");
				}
			}
		}
		public String GLNationOOF10Combo
		{
			get{return _gLNationOOF10Combo;}
			set
			{
				if (value != this._gLNationOOF10Combo)
				{
				_gLNationOOF10Combo=value;
				NotifyChanged("GLNationOOF10Combo");
				}
			}
		}
		#endregion
	}
	#endregion
}