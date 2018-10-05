using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOPorts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOPortsInfo
	//Created Date:Tuesday, March 03, 2009
	//-----------------------------------------------------------
	
	public class LOPortsInfo:BusinessObject
	{
		public LOPortsInfo()
		{
		}
		#region Variables
		protected int _lOPortID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _lOPortTypeCombo=String.Empty;
		protected String _lOPortNo=String.Empty;
		protected String _lOPortName=String.Empty;
		protected String _lOPortDesc=String.Empty;
		protected bool _lOPortActiveCheck=true;
		protected String _lOPortInformation=String.Empty;
		protected String _lOPortAddressLine1=String.Empty;
		protected String _lOPortAddressLine2=String.Empty;
		protected String _lOPortAddressLine3=String.Empty;
		protected String _lOPortAddressCity=String.Empty;
		protected String _lOPortAddressProvince=String.Empty;
		protected String _lOPortAddressCountry=String.Empty;
		protected String _lOPortAddressZipCode=String.Empty;
		protected String _lOPortOF01Combo=String.Empty;
		protected String _lOPortOF02Combo=String.Empty;
		protected String _lOPortOF03Combo=String.Empty;
		protected String _lOPortOF04Combo=String.Empty;
		protected String _lOPortOF05Combo=String.Empty;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		#endregion

		#region Public properties
		public int LOPortID
		{
			get{return _lOPortID;}
			set
			{
				if (value != this._lOPortID)
				{
				_lOPortID=value;
				NotifyChanged("LOPortID");
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
		public String LOPortTypeCombo
		{
			get{return _lOPortTypeCombo;}
			set
			{
				if (value != this._lOPortTypeCombo)
				{
				_lOPortTypeCombo=value;
				NotifyChanged("LOPortTypeCombo");
				}
			}
		}
		public String LOPortNo
		{
			get{return _lOPortNo;}
			set
			{
				if (value != this._lOPortNo)
				{
				_lOPortNo=value;
				NotifyChanged("LOPortNo");
				}
			}
		}
		public String LOPortName
		{
			get{return _lOPortName;}
			set
			{
				if (value != this._lOPortName)
				{
				_lOPortName=value;
				NotifyChanged("LOPortName");
				}
			}
		}
		public String LOPortDesc
		{
			get{return _lOPortDesc;}
			set
			{
				if (value != this._lOPortDesc)
				{
				_lOPortDesc=value;
				NotifyChanged("LOPortDesc");
				}
			}
		}
		public bool LOPortActiveCheck
		{
			get{return _lOPortActiveCheck;}
			set
			{
				if (value != this._lOPortActiveCheck)
				{
				_lOPortActiveCheck=value;
				NotifyChanged("LOPortActiveCheck");
				}
			}
		}
		public String LOPortInformation
		{
			get{return _lOPortInformation;}
			set
			{
				if (value != this._lOPortInformation)
				{
				_lOPortInformation=value;
				NotifyChanged("LOPortInformation");
				}
			}
		}
		public String LOPortAddressLine1
		{
			get{return _lOPortAddressLine1;}
			set
			{
				if (value != this._lOPortAddressLine1)
				{
				_lOPortAddressLine1=value;
				NotifyChanged("LOPortAddressLine1");
				}
			}
		}
		public String LOPortAddressLine2
		{
			get{return _lOPortAddressLine2;}
			set
			{
				if (value != this._lOPortAddressLine2)
				{
				_lOPortAddressLine2=value;
				NotifyChanged("LOPortAddressLine2");
				}
			}
		}
		public String LOPortAddressLine3
		{
			get{return _lOPortAddressLine3;}
			set
			{
				if (value != this._lOPortAddressLine3)
				{
				_lOPortAddressLine3=value;
				NotifyChanged("LOPortAddressLine3");
				}
			}
		}
		public String LOPortAddressCity
		{
			get{return _lOPortAddressCity;}
			set
			{
				if (value != this._lOPortAddressCity)
				{
				_lOPortAddressCity=value;
				NotifyChanged("LOPortAddressCity");
				}
			}
		}
		public String LOPortAddressProvince
		{
			get{return _lOPortAddressProvince;}
			set
			{
				if (value != this._lOPortAddressProvince)
				{
				_lOPortAddressProvince=value;
				NotifyChanged("LOPortAddressProvince");
				}
			}
		}
		public String LOPortAddressCountry
		{
			get{return _lOPortAddressCountry;}
			set
			{
				if (value != this._lOPortAddressCountry)
				{
				_lOPortAddressCountry=value;
				NotifyChanged("LOPortAddressCountry");
				}
			}
		}
		public String LOPortAddressZipCode
		{
			get{return _lOPortAddressZipCode;}
			set
			{
				if (value != this._lOPortAddressZipCode)
				{
				_lOPortAddressZipCode=value;
				NotifyChanged("LOPortAddressZipCode");
				}
			}
		}
		public String LOPortOF01Combo
		{
			get{return _lOPortOF01Combo;}
			set
			{
				if (value != this._lOPortOF01Combo)
				{
				_lOPortOF01Combo=value;
				NotifyChanged("LOPortOF01Combo");
				}
			}
		}
		public String LOPortOF02Combo
		{
			get{return _lOPortOF02Combo;}
			set
			{
				if (value != this._lOPortOF02Combo)
				{
				_lOPortOF02Combo=value;
				NotifyChanged("LOPortOF02Combo");
				}
			}
		}
		public String LOPortOF03Combo
		{
			get{return _lOPortOF03Combo;}
			set
			{
				if (value != this._lOPortOF03Combo)
				{
				_lOPortOF03Combo=value;
				NotifyChanged("LOPortOF03Combo");
				}
			}
		}
		public String LOPortOF04Combo
		{
			get{return _lOPortOF04Combo;}
			set
			{
				if (value != this._lOPortOF04Combo)
				{
				_lOPortOF04Combo=value;
				NotifyChanged("LOPortOF04Combo");
				}
			}
		}
		public String LOPortOF05Combo
		{
			get{return _lOPortOF05Combo;}
			set
			{
				if (value != this._lOPortOF05Combo)
				{
				_lOPortOF05Combo=value;
				NotifyChanged("LOPortOF05Combo");
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