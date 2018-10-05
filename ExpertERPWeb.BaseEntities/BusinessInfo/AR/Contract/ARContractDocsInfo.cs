using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARContractDocs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARContractDocsInfo
	//Created Date:Monday, January 19, 2015
	//-----------------------------------------------------------
	
	public class ARContractDocsInfo:BusinessObject
	{
		public ARContractDocsInfo()
		{
		}
		#region Variables
		protected int _aRContractDocID;
		protected String _aAUpdatedUser=String.Empty;
		protected bool _aASelected=true;
		protected Nullable<DateTime> _aRContractDocDate;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aRContractDocServerPath=String.Empty;
		protected String _aRContractDocFileName=String.Empty;
		protected String _aRContractDocDesc=String.Empty;
		protected int _fK_ADUserID;
		protected String _aRContractDocClientPath=String.Empty;
		protected String _aACreatedUser=String.Empty;
		protected String _aRContractDocNo=String.Empty;
		protected int _fK_ARContractID;
		protected String _aRContractDocName=String.Empty;
		protected String _aRContractDocServerFileName=String.Empty;
		#endregion

		#region Public properties
		public int ARContractDocID
		{
			get{return _aRContractDocID;}
			set
			{
				if (value != this._aRContractDocID)
				{
				_aRContractDocID=value;
				NotifyChanged("ARContractDocID");
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
		public Nullable<DateTime> ARContractDocDate
		{
			get{return _aRContractDocDate;}
			set
			{
				if (value != this._aRContractDocDate)
				{
				_aRContractDocDate=value;
				NotifyChanged("ARContractDocDate");
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
		public String ARContractDocServerPath
		{
			get{return _aRContractDocServerPath;}
			set
			{
				if (value != this._aRContractDocServerPath)
				{
				_aRContractDocServerPath=value;
				NotifyChanged("ARContractDocServerPath");
				}
			}
		}
		public String ARContractDocFileName
		{
			get{return _aRContractDocFileName;}
			set
			{
				if (value != this._aRContractDocFileName)
				{
				_aRContractDocFileName=value;
				NotifyChanged("ARContractDocFileName");
				}
			}
		}
		public String ARContractDocDesc
		{
			get{return _aRContractDocDesc;}
			set
			{
				if (value != this._aRContractDocDesc)
				{
				_aRContractDocDesc=value;
				NotifyChanged("ARContractDocDesc");
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
		public String ARContractDocClientPath
		{
			get{return _aRContractDocClientPath;}
			set
			{
				if (value != this._aRContractDocClientPath)
				{
				_aRContractDocClientPath=value;
				NotifyChanged("ARContractDocClientPath");
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
		public String ARContractDocNo
		{
			get{return _aRContractDocNo;}
			set
			{
				if (value != this._aRContractDocNo)
				{
				_aRContractDocNo=value;
				NotifyChanged("ARContractDocNo");
				}
			}
		}
		public int FK_ARContractID
		{
			get{return _fK_ARContractID;}
			set
			{
				if (value != this._fK_ARContractID)
				{
				_fK_ARContractID=value;
				NotifyChanged("FK_ARContractID");
				}
			}
		}
		public String ARContractDocName
		{
			get{return _aRContractDocName;}
			set
			{
				if (value != this._aRContractDocName)
				{
				_aRContractDocName=value;
				NotifyChanged("ARContractDocName");
				}
			}
		}
		public String ARContractDocServerFileName
		{
			get{return _aRContractDocServerFileName;}
			set
			{
				if (value != this._aRContractDocServerFileName)
				{
				_aRContractDocServerFileName=value;
				NotifyChanged("ARContractDocServerFileName");
				}
			}
		}
		#endregion
	}
	#endregion
}