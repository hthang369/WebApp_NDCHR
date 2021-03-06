using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region LOCustomers
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:LOCustomersInfo
	//Created Date:Tuesday, February 17, 2009
	//-----------------------------------------------------------
	
	public class LOCustomersInfo:BusinessObject
	{
		public LOCustomersInfo()
		{
		}
		#region Variables
		protected int _lOCustomerID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _lOCustomerNo=String.Empty;
		protected String _lOCustomerName=String.Empty;
		protected String _lOCustomerDesc=String.Empty;
		protected bool _lOCustomerActiveCheck=true;
		protected bool _lOCustomerOnHoldCheck=true;
		protected String _lOCustomerReminderCheck=String.Empty;
		protected double _lOCustomerDiscount;
		protected double _lOCustomerCreditLimit;
		protected String _lOCustomerInformation=String.Empty;
		protected String _lOCustomerAddressStreet=String.Empty;
		protected String _lOCustomerAddressLine1=String.Empty;
		protected String _lOCustomerAddressLine2=String.Empty;
		protected String _lOCustomerAddressLine3=String.Empty;
		protected String _lOCustomerAddressCity=String.Empty;
		protected String _lOCustomerAddressStateProvince=String.Empty;
		protected String _lOCustomerAddressPostalCode=String.Empty;
		protected String _lOCustomerAddressZipCode=String.Empty;
		protected String _lOCustomerAddressCountry=String.Empty;
		protected String _lOCustomerTel1=String.Empty;
		protected String _lOCustomerTel2=String.Empty;
		protected String _lOCustomerFax1=String.Empty;
		protected String _lOCustomerFax2=String.Empty;
		protected String _lOCustomerBankName=String.Empty;
		protected String _lOCustomerBankAccountName=String.Empty;
		protected String _lOCustomerBankAccountNo=String.Empty;
		protected String _lOCustomerWebsite=String.Empty;
		protected String _lOCustomerContactName=String.Empty;
		protected DateTime _lOCustomerContactBirthday=DateTime.MaxValue;
		protected String _lOCustomerContactTitle=String.Empty;
		protected String _lOCustomerContactHeaderLetter=String.Empty;
		protected String _lOCustomerContactHeaderMessage=String.Empty;
		protected String _lOCustomerContactEmail1=String.Empty;
		protected String _lOCustomerContactEmail2=String.Empty;
		protected String _lOCustomerContactPhone1=String.Empty;
		protected String _lOCustomerContactPhone2=String.Empty;
		protected String _lOCustomerContactMobiPhone=String.Empty;
		protected String _lOCustomerContactMobiPhone2=String.Empty;
		protected String _lOCustomerContactInformation=String.Empty;
		protected String _lOCustomerContactPosition=String.Empty;
		protected String _lOCustometContactDepartment=String.Empty;
		protected String _lOCustomerContactRoom=String.Empty;
		protected String _lOCustomerType=String.Empty;
		protected String _lOCustomerOF01Combo=String.Empty;
		protected String _lOCustomerOF02Combo=String.Empty;
		protected String _lOCustomerOF03Combo=String.Empty;
		protected String _lOCustomerOF04Combo=String.Empty;
		protected String _lOCustomerOF05Combo=String.Empty;
		protected String _lOCustomerOF06Combo=String.Empty;
		protected String _lOCustomerOF07Combo=String.Empty;
		protected String _lOCustomerOF08Combo=String.Empty;
		protected String _lOCustomerOF09Combo=String.Empty;
		protected String _lOCustomerOF10Combo=String.Empty;
		protected String _aAACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		#endregion

		#region Public properties
		public int LOCustomerID
		{
			get{return _lOCustomerID;}
			set
			{
				if (value != this._lOCustomerID)
				{
				_lOCustomerID=value;
				NotifyChanged("LOCustomerID");
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
		public String LOCustomerNo
		{
			get{return _lOCustomerNo;}
			set
			{
				if (value != this._lOCustomerNo)
				{
				_lOCustomerNo=value;
				NotifyChanged("LOCustomerNo");
				}
			}
		}
		public String LOCustomerName
		{
			get{return _lOCustomerName;}
			set
			{
				if (value != this._lOCustomerName)
				{
				_lOCustomerName=value;
				NotifyChanged("LOCustomerName");
				}
			}
		}
		public String LOCustomerDesc
		{
			get{return _lOCustomerDesc;}
			set
			{
				if (value != this._lOCustomerDesc)
				{
				_lOCustomerDesc=value;
				NotifyChanged("LOCustomerDesc");
				}
			}
		}
		public bool LOCustomerActiveCheck
		{
			get{return _lOCustomerActiveCheck;}
			set
			{
				if (value != this._lOCustomerActiveCheck)
				{
				_lOCustomerActiveCheck=value;
				NotifyChanged("LOCustomerActiveCheck");
				}
			}
		}
		public bool LOCustomerOnHoldCheck
		{
			get{return _lOCustomerOnHoldCheck;}
			set
			{
				if (value != this._lOCustomerOnHoldCheck)
				{
				_lOCustomerOnHoldCheck=value;
				NotifyChanged("LOCustomerOnHoldCheck");
				}
			}
		}
		public String LOCustomerReminderCheck
		{
			get{return _lOCustomerReminderCheck;}
			set
			{
				if (value != this._lOCustomerReminderCheck)
				{
				_lOCustomerReminderCheck=value;
				NotifyChanged("LOCustomerReminderCheck");
				}
			}
		}
		public double LOCustomerDiscount
		{
			get{return _lOCustomerDiscount;}
			set
			{
				if (value != this._lOCustomerDiscount)
				{
				_lOCustomerDiscount=value;
				NotifyChanged("LOCustomerDiscount");
				}
			}
		}
		public double LOCustomerCreditLimit
		{
			get{return _lOCustomerCreditLimit;}
			set
			{
				if (value != this._lOCustomerCreditLimit)
				{
				_lOCustomerCreditLimit=value;
				NotifyChanged("LOCustomerCreditLimit");
				}
			}
		}
		public String LOCustomerInformation
		{
			get{return _lOCustomerInformation;}
			set
			{
				if (value != this._lOCustomerInformation)
				{
				_lOCustomerInformation=value;
				NotifyChanged("LOCustomerInformation");
				}
			}
		}
		public String LOCustomerAddressStreet
		{
			get{return _lOCustomerAddressStreet;}
			set
			{
				if (value != this._lOCustomerAddressStreet)
				{
				_lOCustomerAddressStreet=value;
				NotifyChanged("LOCustomerAddressStreet");
				}
			}
		}
		public String LOCustomerAddressLine1
		{
			get{return _lOCustomerAddressLine1;}
			set
			{
				if (value != this._lOCustomerAddressLine1)
				{
				_lOCustomerAddressLine1=value;
				NotifyChanged("LOCustomerAddressLine1");
				}
			}
		}
		public String LOCustomerAddressLine2
		{
			get{return _lOCustomerAddressLine2;}
			set
			{
				if (value != this._lOCustomerAddressLine2)
				{
				_lOCustomerAddressLine2=value;
				NotifyChanged("LOCustomerAddressLine2");
				}
			}
		}
		public String LOCustomerAddressLine3
		{
			get{return _lOCustomerAddressLine3;}
			set
			{
				if (value != this._lOCustomerAddressLine3)
				{
				_lOCustomerAddressLine3=value;
				NotifyChanged("LOCustomerAddressLine3");
				}
			}
		}
		public String LOCustomerAddressCity
		{
			get{return _lOCustomerAddressCity;}
			set
			{
				if (value != this._lOCustomerAddressCity)
				{
				_lOCustomerAddressCity=value;
				NotifyChanged("LOCustomerAddressCity");
				}
			}
		}
		public String LOCustomerAddressStateProvince
		{
			get{return _lOCustomerAddressStateProvince;}
			set
			{
				if (value != this._lOCustomerAddressStateProvince)
				{
				_lOCustomerAddressStateProvince=value;
				NotifyChanged("LOCustomerAddressStateProvince");
				}
			}
		}
		public String LOCustomerAddressPostalCode
		{
			get{return _lOCustomerAddressPostalCode;}
			set
			{
				if (value != this._lOCustomerAddressPostalCode)
				{
				_lOCustomerAddressPostalCode=value;
				NotifyChanged("LOCustomerAddressPostalCode");
				}
			}
		}
		public String LOCustomerAddressZipCode
		{
			get{return _lOCustomerAddressZipCode;}
			set
			{
				if (value != this._lOCustomerAddressZipCode)
				{
				_lOCustomerAddressZipCode=value;
				NotifyChanged("LOCustomerAddressZipCode");
				}
			}
		}
		public String LOCustomerAddressCountry
		{
			get{return _lOCustomerAddressCountry;}
			set
			{
				if (value != this._lOCustomerAddressCountry)
				{
				_lOCustomerAddressCountry=value;
				NotifyChanged("LOCustomerAddressCountry");
				}
			}
		}
		public String LOCustomerTel1
		{
			get{return _lOCustomerTel1;}
			set
			{
				if (value != this._lOCustomerTel1)
				{
				_lOCustomerTel1=value;
				NotifyChanged("LOCustomerTel1");
				}
			}
		}
		public String LOCustomerTel2
		{
			get{return _lOCustomerTel2;}
			set
			{
				if (value != this._lOCustomerTel2)
				{
				_lOCustomerTel2=value;
				NotifyChanged("LOCustomerTel2");
				}
			}
		}
		public String LOCustomerFax1
		{
			get{return _lOCustomerFax1;}
			set
			{
				if (value != this._lOCustomerFax1)
				{
				_lOCustomerFax1=value;
				NotifyChanged("LOCustomerFax1");
				}
			}
		}
		public String LOCustomerFax2
		{
			get{return _lOCustomerFax2;}
			set
			{
				if (value != this._lOCustomerFax2)
				{
				_lOCustomerFax2=value;
				NotifyChanged("LOCustomerFax2");
				}
			}
		}
		public String LOCustomerBankName
		{
			get{return _lOCustomerBankName;}
			set
			{
				if (value != this._lOCustomerBankName)
				{
				_lOCustomerBankName=value;
				NotifyChanged("LOCustomerBankName");
				}
			}
		}
		public String LOCustomerBankAccountName
		{
			get{return _lOCustomerBankAccountName;}
			set
			{
				if (value != this._lOCustomerBankAccountName)
				{
				_lOCustomerBankAccountName=value;
				NotifyChanged("LOCustomerBankAccountName");
				}
			}
		}
		public String LOCustomerBankAccountNo
		{
			get{return _lOCustomerBankAccountNo;}
			set
			{
				if (value != this._lOCustomerBankAccountNo)
				{
				_lOCustomerBankAccountNo=value;
				NotifyChanged("LOCustomerBankAccountNo");
				}
			}
		}
		public String LOCustomerWebsite
		{
			get{return _lOCustomerWebsite;}
			set
			{
				if (value != this._lOCustomerWebsite)
				{
				_lOCustomerWebsite=value;
				NotifyChanged("LOCustomerWebsite");
				}
			}
		}
		public String LOCustomerContactName
		{
			get{return _lOCustomerContactName;}
			set
			{
				if (value != this._lOCustomerContactName)
				{
				_lOCustomerContactName=value;
				NotifyChanged("LOCustomerContactName");
				}
			}
		}
		public DateTime LOCustomerContactBirthday
		{
			get{return _lOCustomerContactBirthday;}
			set
			{
				if (value != this._lOCustomerContactBirthday)
				{
				_lOCustomerContactBirthday=value;
				NotifyChanged("LOCustomerContactBirthday");
				}
			}
		}
		public String LOCustomerContactTitle
		{
			get{return _lOCustomerContactTitle;}
			set
			{
				if (value != this._lOCustomerContactTitle)
				{
				_lOCustomerContactTitle=value;
				NotifyChanged("LOCustomerContactTitle");
				}
			}
		}
		public String LOCustomerContactHeaderLetter
		{
			get{return _lOCustomerContactHeaderLetter;}
			set
			{
				if (value != this._lOCustomerContactHeaderLetter)
				{
				_lOCustomerContactHeaderLetter=value;
				NotifyChanged("LOCustomerContactHeaderLetter");
				}
			}
		}
		public String LOCustomerContactHeaderMessage
		{
			get{return _lOCustomerContactHeaderMessage;}
			set
			{
				if (value != this._lOCustomerContactHeaderMessage)
				{
				_lOCustomerContactHeaderMessage=value;
				NotifyChanged("LOCustomerContactHeaderMessage");
				}
			}
		}
		public String LOCustomerContactEmail1
		{
			get{return _lOCustomerContactEmail1;}
			set
			{
				if (value != this._lOCustomerContactEmail1)
				{
				_lOCustomerContactEmail1=value;
				NotifyChanged("LOCustomerContactEmail1");
				}
			}
		}
		public String LOCustomerContactEmail2
		{
			get{return _lOCustomerContactEmail2;}
			set
			{
				if (value != this._lOCustomerContactEmail2)
				{
				_lOCustomerContactEmail2=value;
				NotifyChanged("LOCustomerContactEmail2");
				}
			}
		}
		public String LOCustomerContactPhone1
		{
			get{return _lOCustomerContactPhone1;}
			set
			{
				if (value != this._lOCustomerContactPhone1)
				{
				_lOCustomerContactPhone1=value;
				NotifyChanged("LOCustomerContactPhone1");
				}
			}
		}
		public String LOCustomerContactPhone2
		{
			get{return _lOCustomerContactPhone2;}
			set
			{
				if (value != this._lOCustomerContactPhone2)
				{
				_lOCustomerContactPhone2=value;
				NotifyChanged("LOCustomerContactPhone2");
				}
			}
		}
		public String LOCustomerContactMobiPhone
		{
			get{return _lOCustomerContactMobiPhone;}
			set
			{
				if (value != this._lOCustomerContactMobiPhone)
				{
				_lOCustomerContactMobiPhone=value;
				NotifyChanged("LOCustomerContactMobiPhone");
				}
			}
		}
		public String LOCustomerContactMobiPhone2
		{
			get{return _lOCustomerContactMobiPhone2;}
			set
			{
				if (value != this._lOCustomerContactMobiPhone2)
				{
				_lOCustomerContactMobiPhone2=value;
				NotifyChanged("LOCustomerContactMobiPhone2");
				}
			}
		}
		public String LOCustomerContactInformation
		{
			get{return _lOCustomerContactInformation;}
			set
			{
				if (value != this._lOCustomerContactInformation)
				{
				_lOCustomerContactInformation=value;
				NotifyChanged("LOCustomerContactInformation");
				}
			}
		}
		public String LOCustomerContactPosition
		{
			get{return _lOCustomerContactPosition;}
			set
			{
				if (value != this._lOCustomerContactPosition)
				{
				_lOCustomerContactPosition=value;
				NotifyChanged("LOCustomerContactPosition");
				}
			}
		}
		public String LOCustometContactDepartment
		{
			get{return _lOCustometContactDepartment;}
			set
			{
				if (value != this._lOCustometContactDepartment)
				{
				_lOCustometContactDepartment=value;
				NotifyChanged("LOCustometContactDepartment");
				}
			}
		}
		public String LOCustomerContactRoom
		{
			get{return _lOCustomerContactRoom;}
			set
			{
				if (value != this._lOCustomerContactRoom)
				{
				_lOCustomerContactRoom=value;
				NotifyChanged("LOCustomerContactRoom");
				}
			}
		}
		public String LOCustomerType
		{
			get{return _lOCustomerType;}
			set
			{
				if (value != this._lOCustomerType)
				{
				_lOCustomerType=value;
				NotifyChanged("LOCustomerType");
				}
			}
		}
		public String LOCustomerOF01Combo
		{
			get{return _lOCustomerOF01Combo;}
			set
			{
				if (value != this._lOCustomerOF01Combo)
				{
				_lOCustomerOF01Combo=value;
				NotifyChanged("LOCustomerOF01Combo");
				}
			}
		}
		public String LOCustomerOF02Combo
		{
			get{return _lOCustomerOF02Combo;}
			set
			{
				if (value != this._lOCustomerOF02Combo)
				{
				_lOCustomerOF02Combo=value;
				NotifyChanged("LOCustomerOF02Combo");
				}
			}
		}
		public String LOCustomerOF03Combo
		{
			get{return _lOCustomerOF03Combo;}
			set
			{
				if (value != this._lOCustomerOF03Combo)
				{
				_lOCustomerOF03Combo=value;
				NotifyChanged("LOCustomerOF03Combo");
				}
			}
		}
		public String LOCustomerOF04Combo
		{
			get{return _lOCustomerOF04Combo;}
			set
			{
				if (value != this._lOCustomerOF04Combo)
				{
				_lOCustomerOF04Combo=value;
				NotifyChanged("LOCustomerOF04Combo");
				}
			}
		}
		public String LOCustomerOF05Combo
		{
			get{return _lOCustomerOF05Combo;}
			set
			{
				if (value != this._lOCustomerOF05Combo)
				{
				_lOCustomerOF05Combo=value;
				NotifyChanged("LOCustomerOF05Combo");
				}
			}
		}
		public String LOCustomerOF06Combo
		{
			get{return _lOCustomerOF06Combo;}
			set
			{
				if (value != this._lOCustomerOF06Combo)
				{
				_lOCustomerOF06Combo=value;
				NotifyChanged("LOCustomerOF06Combo");
				}
			}
		}
		public String LOCustomerOF07Combo
		{
			get{return _lOCustomerOF07Combo;}
			set
			{
				if (value != this._lOCustomerOF07Combo)
				{
				_lOCustomerOF07Combo=value;
				NotifyChanged("LOCustomerOF07Combo");
				}
			}
		}
		public String LOCustomerOF08Combo
		{
			get{return _lOCustomerOF08Combo;}
			set
			{
				if (value != this._lOCustomerOF08Combo)
				{
				_lOCustomerOF08Combo=value;
				NotifyChanged("LOCustomerOF08Combo");
				}
			}
		}
		public String LOCustomerOF09Combo
		{
			get{return _lOCustomerOF09Combo;}
			set
			{
				if (value != this._lOCustomerOF09Combo)
				{
				_lOCustomerOF09Combo=value;
				NotifyChanged("LOCustomerOF09Combo");
				}
			}
		}
		public String LOCustomerOF10Combo
		{
			get{return _lOCustomerOF10Combo;}
			set
			{
				if (value != this._lOCustomerOF10Combo)
				{
				_lOCustomerOF10Combo=value;
				NotifyChanged("LOCustomerOF10Combo");
				}
			}
		}
		public String AAACreatedUser
		{
			get{return _aAACreatedUser;}
			set
			{
				if (value != this._aAACreatedUser)
				{
				_aAACreatedUser=value;
				NotifyChanged("AAACreatedUser");
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