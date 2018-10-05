using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region APSupplierCons
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:APSupplierConsInfo
	//Created Date:Tuesday, January 6, 2015
	//-----------------------------------------------------------
	
	public class APSupplierConsInfo:BusinessObject
	{
		public APSupplierConsInfo()
		{
		}
		#region Variables
		protected int _aPSupplierConID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aPSupplierConName=String.Empty;
		protected int _fK_APSupplierID;
		protected Nullable<DateTime> _aPSupplierConBday;
		protected String _aPSupplierConFName=String.Empty;
		protected String _aPSupplierConLName=String.Empty;
		protected String _aPSupplierConTitle=String.Empty;
		protected String _aPSupplierConHLet=String.Empty;
		protected String _aPSupplierConHrMsg=String.Empty;
		protected String _aPSupplierConEmail1=String.Empty;
		protected String _aPSupplierConEmail2=String.Empty;
		protected String _aPSupplierConPhone=String.Empty;
		protected String _aPSupplierConCellPhone=String.Empty;
		protected String _aPSupplierConFax=String.Empty;
		protected String _aPConType=String.Empty;
		protected String _aPSupplierConInfo=String.Empty;
		protected String _aPSupplierConDep=String.Empty;
		protected String _aPSupplierConRoom=String.Empty;
		protected String _aPSupplierConAddL1=String.Empty;
		protected String _aPSupplierConAddL2=String.Empty;
		protected String _aPSupplierConAddL3=String.Empty;
		protected String _aPSupplierConAddStr=String.Empty;
		protected String _aPSupplierConAddCity=String.Empty;
		protected String _aPSupplierConAddPCode=String.Empty;
		protected String _aPSupplierConAddStProv=String.Empty;
		protected String _aPSupplierConAddZCode=String.Empty;
		protected String _aPSupplierConAddCountry=String.Empty;
		protected String _aPSupplierConWebsite=String.Empty;
		protected bool _aPSupplierConDefault=true;
		protected String _aPSupplierConNo=String.Empty;
		#endregion

		#region Public properties
		public int APSupplierConID
		{
			get{return _aPSupplierConID;}
			set
			{
				if (value != this._aPSupplierConID)
				{
				_aPSupplierConID=value;
				NotifyChanged("APSupplierConID");
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
		public String APSupplierConName
		{
			get{return _aPSupplierConName;}
			set
			{
				if (value != this._aPSupplierConName)
				{
				_aPSupplierConName=value;
				NotifyChanged("APSupplierConName");
				}
			}
		}
		public int FK_APSupplierID
		{
			get{return _fK_APSupplierID;}
			set
			{
				if (value != this._fK_APSupplierID)
				{
				_fK_APSupplierID=value;
				NotifyChanged("FK_APSupplierID");
				}
			}
		}
		public Nullable<DateTime> APSupplierConBday
		{
			get{return _aPSupplierConBday;}
			set
			{
				if (value != this._aPSupplierConBday)
				{
				_aPSupplierConBday=value;
				NotifyChanged("APSupplierConBday");
				}
			}
		}
		public String APSupplierConFName
		{
			get{return _aPSupplierConFName;}
			set
			{
				if (value != this._aPSupplierConFName)
				{
				_aPSupplierConFName=value;
				NotifyChanged("APSupplierConFName");
				}
			}
		}
		public String APSupplierConLName
		{
			get{return _aPSupplierConLName;}
			set
			{
				if (value != this._aPSupplierConLName)
				{
				_aPSupplierConLName=value;
				NotifyChanged("APSupplierConLName");
				}
			}
		}
		public String APSupplierConTitle
		{
			get{return _aPSupplierConTitle;}
			set
			{
				if (value != this._aPSupplierConTitle)
				{
				_aPSupplierConTitle=value;
				NotifyChanged("APSupplierConTitle");
				}
			}
		}
		public String APSupplierConHLet
		{
			get{return _aPSupplierConHLet;}
			set
			{
				if (value != this._aPSupplierConHLet)
				{
				_aPSupplierConHLet=value;
				NotifyChanged("APSupplierConHLet");
				}
			}
		}
		public String APSupplierConHrMsg
		{
			get{return _aPSupplierConHrMsg;}
			set
			{
				if (value != this._aPSupplierConHrMsg)
				{
				_aPSupplierConHrMsg=value;
				NotifyChanged("APSupplierConHrMsg");
				}
			}
		}
		public String APSupplierConEmail1
		{
			get{return _aPSupplierConEmail1;}
			set
			{
				if (value != this._aPSupplierConEmail1)
				{
				_aPSupplierConEmail1=value;
				NotifyChanged("APSupplierConEmail1");
				}
			}
		}
		public String APSupplierConEmail2
		{
			get{return _aPSupplierConEmail2;}
			set
			{
				if (value != this._aPSupplierConEmail2)
				{
				_aPSupplierConEmail2=value;
				NotifyChanged("APSupplierConEmail2");
				}
			}
		}
		public String APSupplierConPhone
		{
			get{return _aPSupplierConPhone;}
			set
			{
				if (value != this._aPSupplierConPhone)
				{
				_aPSupplierConPhone=value;
				NotifyChanged("APSupplierConPhone");
				}
			}
		}
		public String APSupplierConCellPhone
		{
			get{return _aPSupplierConCellPhone;}
			set
			{
				if (value != this._aPSupplierConCellPhone)
				{
				_aPSupplierConCellPhone=value;
				NotifyChanged("APSupplierConCellPhone");
				}
			}
		}
		public String APSupplierConFax
		{
			get{return _aPSupplierConFax;}
			set
			{
				if (value != this._aPSupplierConFax)
				{
				_aPSupplierConFax=value;
				NotifyChanged("APSupplierConFax");
				}
			}
		}
		public String APConType
		{
			get{return _aPConType;}
			set
			{
				if (value != this._aPConType)
				{
				_aPConType=value;
				NotifyChanged("APConType");
				}
			}
		}
		public String APSupplierConInfo
		{
			get{return _aPSupplierConInfo;}
			set
			{
				if (value != this._aPSupplierConInfo)
				{
				_aPSupplierConInfo=value;
				NotifyChanged("APSupplierConInfo");
				}
			}
		}
		public String APSupplierConDep
		{
			get{return _aPSupplierConDep;}
			set
			{
				if (value != this._aPSupplierConDep)
				{
				_aPSupplierConDep=value;
				NotifyChanged("APSupplierConDep");
				}
			}
		}
		public String APSupplierConRoom
		{
			get{return _aPSupplierConRoom;}
			set
			{
				if (value != this._aPSupplierConRoom)
				{
				_aPSupplierConRoom=value;
				NotifyChanged("APSupplierConRoom");
				}
			}
		}
		public String APSupplierConAddL1
		{
			get{return _aPSupplierConAddL1;}
			set
			{
				if (value != this._aPSupplierConAddL1)
				{
				_aPSupplierConAddL1=value;
				NotifyChanged("APSupplierConAddL1");
				}
			}
		}
		public String APSupplierConAddL2
		{
			get{return _aPSupplierConAddL2;}
			set
			{
				if (value != this._aPSupplierConAddL2)
				{
				_aPSupplierConAddL2=value;
				NotifyChanged("APSupplierConAddL2");
				}
			}
		}
		public String APSupplierConAddL3
		{
			get{return _aPSupplierConAddL3;}
			set
			{
				if (value != this._aPSupplierConAddL3)
				{
				_aPSupplierConAddL3=value;
				NotifyChanged("APSupplierConAddL3");
				}
			}
		}
		public String APSupplierConAddStr
		{
			get{return _aPSupplierConAddStr;}
			set
			{
				if (value != this._aPSupplierConAddStr)
				{
				_aPSupplierConAddStr=value;
				NotifyChanged("APSupplierConAddStr");
				}
			}
		}
		public String APSupplierConAddCity
		{
			get{return _aPSupplierConAddCity;}
			set
			{
				if (value != this._aPSupplierConAddCity)
				{
				_aPSupplierConAddCity=value;
				NotifyChanged("APSupplierConAddCity");
				}
			}
		}
		public String APSupplierConAddPCode
		{
			get{return _aPSupplierConAddPCode;}
			set
			{
				if (value != this._aPSupplierConAddPCode)
				{
				_aPSupplierConAddPCode=value;
				NotifyChanged("APSupplierConAddPCode");
				}
			}
		}
		public String APSupplierConAddStProv
		{
			get{return _aPSupplierConAddStProv;}
			set
			{
				if (value != this._aPSupplierConAddStProv)
				{
				_aPSupplierConAddStProv=value;
				NotifyChanged("APSupplierConAddStProv");
				}
			}
		}
		public String APSupplierConAddZCode
		{
			get{return _aPSupplierConAddZCode;}
			set
			{
				if (value != this._aPSupplierConAddZCode)
				{
				_aPSupplierConAddZCode=value;
				NotifyChanged("APSupplierConAddZCode");
				}
			}
		}
		public String APSupplierConAddCountry
		{
			get{return _aPSupplierConAddCountry;}
			set
			{
				if (value != this._aPSupplierConAddCountry)
				{
				_aPSupplierConAddCountry=value;
				NotifyChanged("APSupplierConAddCountry");
				}
			}
		}
		public String APSupplierConWebsite
		{
			get{return _aPSupplierConWebsite;}
			set
			{
				if (value != this._aPSupplierConWebsite)
				{
				_aPSupplierConWebsite=value;
				NotifyChanged("APSupplierConWebsite");
				}
			}
		}
		public bool APSupplierConDefault
		{
			get{return _aPSupplierConDefault;}
			set
			{
				if (value != this._aPSupplierConDefault)
				{
				_aPSupplierConDefault=value;
				NotifyChanged("APSupplierConDefault");
				}
			}
		}
		public String APSupplierConNo
		{
			get{return _aPSupplierConNo;}
			set
			{
				if (value != this._aPSupplierConNo)
				{
				_aPSupplierConNo=value;
				NotifyChanged("APSupplierConNo");
				}
			}
		}
		#endregion
	}
	#endregion
}