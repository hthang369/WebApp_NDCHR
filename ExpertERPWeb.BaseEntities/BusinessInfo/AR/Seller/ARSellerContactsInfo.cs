using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerContacts
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSellerContactsInfo
	//Created Date:Friday, March 14, 2008
	//-----------------------------------------------------------
	
	public class ARSellerContactsInfo:BusinessObject
	{
		public ARSellerContactsInfo()
		{
		}
		#region Variables
		protected int _aRSellerContactID;
		protected String _aAStatus=DefaultStatus;
		protected String _aRSellerContactName=String.Empty;
		protected int _fK_ARSellerID;
		protected DateTime _aRSellerContactBirthday=DateTime.MaxValue;
		protected String _aRSellerContactFirstName=String.Empty;
		protected String _aRSellerContactLastName=String.Empty;
		protected String _aRSellerContactTitle=String.Empty;
		protected String _aRSellerContactHeaderLetter=String.Empty;
		protected String _aRSellerContactHeaderMessage=String.Empty;
		protected String _aRSellerContactEmail1=String.Empty;
		protected String _aRSellerContactEmail2=String.Empty;
		protected String _aRSellerContactWebsite=String.Empty;
		protected String _aRSellerContactPhonePrivate=String.Empty;
		protected String _aRSellerContactPhone=String.Empty;
		protected String _aRSellerContactPhone1=String.Empty;
		protected String _aRSellerContactCellPhone1=String.Empty;
		protected String _aRSellerContactCellPhone=String.Empty;
		protected String _aRSellerContactCellPhonePrivate=String.Empty;
		protected String _aRSellerContactFax=String.Empty;
		protected String _aRContactType=String.Empty;
		protected String _aRSellerContactTypeDisplay=String.Empty;
		protected String _aRSellerContactInformation=String.Empty;
		protected String _aRSellerContactDepartment=String.Empty;
		protected String _aRSellerContactRoom=String.Empty;
		protected String _aRSellerContactAddressLine1=String.Empty;
		protected String _aRSellerContactAddressLine2=String.Empty;
		protected String _aRSellerContactAddressLine3=String.Empty;
		protected String _aRSellerContactAddressStreet=String.Empty;
		protected String _aRSellerContactAddressCity=String.Empty;
		protected String _aRSellerContactAddressPostalCode=String.Empty;
		protected String _aRSellerContactAddressStateProvince=String.Empty;
		protected String _aRSellerContactAddressZipCode=String.Empty;
		protected String _aRSellerContactAddressCountry=String.Empty;
		#endregion

		#region Public properties
		public int ARSellerContactID
		{
			get{return _aRSellerContactID;}
			set
			{
				if (value != this._aRSellerContactID)
				{
				_aRSellerContactID=value;
				NotifyChanged("ARSellerContactID");
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
		public String ARSellerContactName
		{
			get{return _aRSellerContactName;}
			set
			{
				if (value != this._aRSellerContactName)
				{
				_aRSellerContactName=value;
				NotifyChanged("ARSellerContactName");
				}
			}
		}
		public int FK_ARSellerID
		{
			get{return _fK_ARSellerID;}
			set
			{
				if (value != this._fK_ARSellerID)
				{
				_fK_ARSellerID=value;
				NotifyChanged("FK_ARSellerID");
				}
			}
		}
		public DateTime ARSellerContactBirthday
		{
			get{return _aRSellerContactBirthday;}
			set
			{
				if (value != this._aRSellerContactBirthday)
				{
				_aRSellerContactBirthday=value;
				NotifyChanged("ARSellerContactBirthday");
				}
			}
		}
		public String ARSellerContactFirstName
		{
			get{return _aRSellerContactFirstName;}
			set
			{
				if (value != this._aRSellerContactFirstName)
				{
				_aRSellerContactFirstName=value;
				NotifyChanged("ARSellerContactFirstName");
				}
			}
		}
		public String ARSellerContactLastName
		{
			get{return _aRSellerContactLastName;}
			set
			{
				if (value != this._aRSellerContactLastName)
				{
				_aRSellerContactLastName=value;
				NotifyChanged("ARSellerContactLastName");
				}
			}
		}
		public String ARSellerContactTitle
		{
			get{return _aRSellerContactTitle;}
			set
			{
				if (value != this._aRSellerContactTitle)
				{
				_aRSellerContactTitle=value;
				NotifyChanged("ARSellerContactTitle");
				}
			}
		}
		public String ARSellerContactHeaderLetter
		{
			get{return _aRSellerContactHeaderLetter;}
			set
			{
				if (value != this._aRSellerContactHeaderLetter)
				{
				_aRSellerContactHeaderLetter=value;
				NotifyChanged("ARSellerContactHeaderLetter");
				}
			}
		}
		public String ARSellerContactHeaderMessage
		{
			get{return _aRSellerContactHeaderMessage;}
			set
			{
				if (value != this._aRSellerContactHeaderMessage)
				{
				_aRSellerContactHeaderMessage=value;
				NotifyChanged("ARSellerContactHeaderMessage");
				}
			}
		}
		public String ARSellerContactEmail1
		{
			get{return _aRSellerContactEmail1;}
			set
			{
				if (value != this._aRSellerContactEmail1)
				{
				_aRSellerContactEmail1=value;
				NotifyChanged("ARSellerContactEmail1");
				}
			}
		}
		public String ARSellerContactEmail2
		{
			get{return _aRSellerContactEmail2;}
			set
			{
				if (value != this._aRSellerContactEmail2)
				{
				_aRSellerContactEmail2=value;
				NotifyChanged("ARSellerContactEmail2");
				}
			}
		}
		public String ARSellerContactWebsite
		{
			get{return _aRSellerContactWebsite;}
			set
			{
				if (value != this._aRSellerContactWebsite)
				{
				_aRSellerContactWebsite=value;
				NotifyChanged("ARSellerContactWebsite");
				}
			}
		}
		public String ARSellerContactPhonePrivate
		{
			get{return _aRSellerContactPhonePrivate;}
			set
			{
				if (value != this._aRSellerContactPhonePrivate)
				{
				_aRSellerContactPhonePrivate=value;
				NotifyChanged("ARSellerContactPhonePrivate");
				}
			}
		}
		public String ARSellerContactPhone
		{
			get{return _aRSellerContactPhone;}
			set
			{
				if (value != this._aRSellerContactPhone)
				{
				_aRSellerContactPhone=value;
				NotifyChanged("ARSellerContactPhone");
				}
			}
		}
		public String ARSellerContactPhone1
		{
			get{return _aRSellerContactPhone1;}
			set
			{
				if (value != this._aRSellerContactPhone1)
				{
				_aRSellerContactPhone1=value;
				NotifyChanged("ARSellerContactPhone1");
				}
			}
		}
		public String ARSellerContactCellPhone1
		{
			get{return _aRSellerContactCellPhone1;}
			set
			{
				if (value != this._aRSellerContactCellPhone1)
				{
				_aRSellerContactCellPhone1=value;
				NotifyChanged("ARSellerContactCellPhone1");
				}
			}
		}
		public String ARSellerContactCellPhone
		{
			get{return _aRSellerContactCellPhone;}
			set
			{
				if (value != this._aRSellerContactCellPhone)
				{
				_aRSellerContactCellPhone=value;
				NotifyChanged("ARSellerContactCellPhone");
				}
			}
		}
		public String ARSellerContactCellPhonePrivate
		{
			get{return _aRSellerContactCellPhonePrivate;}
			set
			{
				if (value != this._aRSellerContactCellPhonePrivate)
				{
				_aRSellerContactCellPhonePrivate=value;
				NotifyChanged("ARSellerContactCellPhonePrivate");
				}
			}
		}
		public String ARSellerContactFax
		{
			get{return _aRSellerContactFax;}
			set
			{
				if (value != this._aRSellerContactFax)
				{
				_aRSellerContactFax=value;
				NotifyChanged("ARSellerContactFax");
				}
			}
		}
		public String ARContactType
		{
			get{return _aRContactType;}
			set
			{
				if (value != this._aRContactType)
				{
				_aRContactType=value;
				NotifyChanged("ARContactType");
				}
			}
		}
		public String ARSellerContactTypeDisplay
		{
			get{return _aRSellerContactTypeDisplay;}
			set
			{
				if (value != this._aRSellerContactTypeDisplay)
				{
				_aRSellerContactTypeDisplay=value;
				NotifyChanged("ARSellerContactTypeDisplay");
				}
			}
		}
		public String ARSellerContactInformation
		{
			get{return _aRSellerContactInformation;}
			set
			{
				if (value != this._aRSellerContactInformation)
				{
				_aRSellerContactInformation=value;
				NotifyChanged("ARSellerContactInformation");
				}
			}
		}
		public String ARSellerContactDepartment
		{
			get{return _aRSellerContactDepartment;}
			set
			{
				if (value != this._aRSellerContactDepartment)
				{
				_aRSellerContactDepartment=value;
				NotifyChanged("ARSellerContactDepartment");
				}
			}
		}
		public String ARSellerContactRoom
		{
			get{return _aRSellerContactRoom;}
			set
			{
				if (value != this._aRSellerContactRoom)
				{
				_aRSellerContactRoom=value;
				NotifyChanged("ARSellerContactRoom");
				}
			}
		}
		public String ARSellerContactAddressLine1
		{
			get{return _aRSellerContactAddressLine1;}
			set
			{
				if (value != this._aRSellerContactAddressLine1)
				{
				_aRSellerContactAddressLine1=value;
				NotifyChanged("ARSellerContactAddressLine1");
				}
			}
		}
		public String ARSellerContactAddressLine2
		{
			get{return _aRSellerContactAddressLine2;}
			set
			{
				if (value != this._aRSellerContactAddressLine2)
				{
				_aRSellerContactAddressLine2=value;
				NotifyChanged("ARSellerContactAddressLine2");
				}
			}
		}
		public String ARSellerContactAddressLine3
		{
			get{return _aRSellerContactAddressLine3;}
			set
			{
				if (value != this._aRSellerContactAddressLine3)
				{
				_aRSellerContactAddressLine3=value;
				NotifyChanged("ARSellerContactAddressLine3");
				}
			}
		}
		public String ARSellerContactAddressStreet
		{
			get{return _aRSellerContactAddressStreet;}
			set
			{
				if (value != this._aRSellerContactAddressStreet)
				{
				_aRSellerContactAddressStreet=value;
				NotifyChanged("ARSellerContactAddressStreet");
				}
			}
		}
		public String ARSellerContactAddressCity
		{
			get{return _aRSellerContactAddressCity;}
			set
			{
				if (value != this._aRSellerContactAddressCity)
				{
				_aRSellerContactAddressCity=value;
				NotifyChanged("ARSellerContactAddressCity");
				}
			}
		}
		public String ARSellerContactAddressPostalCode
		{
			get{return _aRSellerContactAddressPostalCode;}
			set
			{
				if (value != this._aRSellerContactAddressPostalCode)
				{
				_aRSellerContactAddressPostalCode=value;
				NotifyChanged("ARSellerContactAddressPostalCode");
				}
			}
		}
		public String ARSellerContactAddressStateProvince
		{
			get{return _aRSellerContactAddressStateProvince;}
			set
			{
				if (value != this._aRSellerContactAddressStateProvince)
				{
				_aRSellerContactAddressStateProvince=value;
				NotifyChanged("ARSellerContactAddressStateProvince");
				}
			}
		}
		public String ARSellerContactAddressZipCode
		{
			get{return _aRSellerContactAddressZipCode;}
			set
			{
				if (value != this._aRSellerContactAddressZipCode)
				{
				_aRSellerContactAddressZipCode=value;
				NotifyChanged("ARSellerContactAddressZipCode");
				}
			}
		}
		public String ARSellerContactAddressCountry
		{
			get{return _aRSellerContactAddressCountry;}
			set
			{
				if (value != this._aRSellerContactAddressCountry)
				{
				_aRSellerContactAddressCountry=value;
				NotifyChanged("ARSellerContactAddressCountry");
				}
			}
		}
		#endregion
	}
	#endregion
}