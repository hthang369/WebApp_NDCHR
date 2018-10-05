using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPRoutingCustomerReqDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPRoutingCustomerReqDocsInfo
	//Created Date:Tuesday, July 29, 2014
	//-----------------------------------------------------------
	
	public class PPRoutingCustomerReqDocsInfo:BusinessObject
	{
		public PPRoutingCustomerReqDocsInfo()
		{
		}
		#region Variables
		protected int _pPRoutingCustomerReqDocID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _pPRoutingCustomerReqDocNo=String.Empty;
		protected String _pPRoutingCustomerReqDocDesc=String.Empty;
		protected String _pPRoutingCustomerReqDocUser=String.Empty;
		protected Nullable<DateTime> _pPRoutingCustomerReqDocDate;
		protected String _pPRoutingCustomerReqDocServerPath=String.Empty;
		protected int _fK_PPRoutingID;
		protected int _fK_ADUserID;
		protected String _pPRoutingCustomerReqDocName=String.Empty;
		protected String _pPRoutingCustomerReqDocServerFileName=String.Empty;
		protected String _pPRoutingCustomerReqDocFileName=String.Empty;
		protected String _pPRoutingCustomerReqDocClientPath=String.Empty;
		#endregion

		#region Public properties
		public int PPRoutingCustomerReqDocID
		{
			get{return _pPRoutingCustomerReqDocID;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocID)
				{
				_pPRoutingCustomerReqDocID=value;
				NotifyChanged("PPRoutingCustomerReqDocID");
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
		public String PPRoutingCustomerReqDocNo
		{
			get{return _pPRoutingCustomerReqDocNo;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocNo)
				{
				_pPRoutingCustomerReqDocNo=value;
				NotifyChanged("PPRoutingCustomerReqDocNo");
				}
			}
		}
		public String PPRoutingCustomerReqDocDesc
		{
			get{return _pPRoutingCustomerReqDocDesc;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocDesc)
				{
				_pPRoutingCustomerReqDocDesc=value;
				NotifyChanged("PPRoutingCustomerReqDocDesc");
				}
			}
		}
		public String PPRoutingCustomerReqDocUser
		{
			get{return _pPRoutingCustomerReqDocUser;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocUser)
				{
				_pPRoutingCustomerReqDocUser=value;
				NotifyChanged("PPRoutingCustomerReqDocUser");
				}
			}
		}
		public Nullable<DateTime> PPRoutingCustomerReqDocDate
		{
			get{return _pPRoutingCustomerReqDocDate;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocDate)
				{
				_pPRoutingCustomerReqDocDate=value;
				NotifyChanged("PPRoutingCustomerReqDocDate");
				}
			}
		}
		public String PPRoutingCustomerReqDocServerPath
		{
			get{return _pPRoutingCustomerReqDocServerPath;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocServerPath)
				{
				_pPRoutingCustomerReqDocServerPath=value;
				NotifyChanged("PPRoutingCustomerReqDocServerPath");
				}
			}
		}
		public int FK_PPRoutingID
		{
			get{return _fK_PPRoutingID;}
			set
			{
				if (value != this._fK_PPRoutingID)
				{
				_fK_PPRoutingID=value;
				NotifyChanged("FK_PPRoutingID");
				}
			}
		}
		public int FK_ADUserID
		{
			get{return _fK_ADUserID;}
			set
			{
				if (value != this._fK_ADUserID)
				{
				_fK_ADUserID=value;
				NotifyChanged("FK_ADUserID");
				}
			}
		}
		public String PPRoutingCustomerReqDocName
		{
			get{return _pPRoutingCustomerReqDocName;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocName)
				{
				_pPRoutingCustomerReqDocName=value;
				NotifyChanged("PPRoutingCustomerReqDocName");
				}
			}
		}
		public String PPRoutingCustomerReqDocServerFileName
		{
			get{return _pPRoutingCustomerReqDocServerFileName;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocServerFileName)
				{
				_pPRoutingCustomerReqDocServerFileName=value;
				NotifyChanged("PPRoutingCustomerReqDocServerFileName");
				}
			}
		}
		public String PPRoutingCustomerReqDocFileName
		{
			get{return _pPRoutingCustomerReqDocFileName;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocFileName)
				{
				_pPRoutingCustomerReqDocFileName=value;
				NotifyChanged("PPRoutingCustomerReqDocFileName");
				}
			}
		}
		public String PPRoutingCustomerReqDocClientPath
		{
			get{return _pPRoutingCustomerReqDocClientPath;}
			set
			{
				if (value != this._pPRoutingCustomerReqDocClientPath)
				{
				_pPRoutingCustomerReqDocClientPath=value;
				NotifyChanged("PPRoutingCustomerReqDocClientPath");
				}
			}
		}
		#endregion
	}
	#endregion
}