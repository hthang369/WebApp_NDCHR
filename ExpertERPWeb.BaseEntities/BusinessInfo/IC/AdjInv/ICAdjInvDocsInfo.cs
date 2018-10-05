using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICAdjInvDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICAdjInvDocsInfo
	//Created Date:Thursday, November 8, 2012
	//-----------------------------------------------------------
	
	public class ICAdjInvDocsInfo:BusinessObject
	{
		public ICAdjInvDocsInfo()
		{
		}
		#region Variables
		protected int _iCAdjInvDocID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _iCAdjInvDocNo=String.Empty;
		protected String _iCAdjInvDocDesc=String.Empty;
		protected int _fK_ADUserID;
		protected Nullable<DateTime> _iCAdjInvDocDate;
		protected String _iCAdjInvDocServerPath=String.Empty;
		protected int _fK_ICAdjInvID;
		protected String _iCAdjInvDocName=String.Empty;
		protected String _iCAdjInvDocServerFileName=String.Empty;
		protected String _iCAdjInvDocFileName=String.Empty;
		protected String _iCAdjInvDocClientPath=String.Empty;
		#endregion

		#region Public properties
		public int ICAdjInvDocID
		{
			get{return _iCAdjInvDocID;}
			set
			{
				if (value != this._iCAdjInvDocID)
				{
				_iCAdjInvDocID=value;
				NotifyChanged("ICAdjInvDocID");
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
		public String ICAdjInvDocNo
		{
			get{return _iCAdjInvDocNo;}
			set
			{
				if (value != this._iCAdjInvDocNo)
				{
				_iCAdjInvDocNo=value;
				NotifyChanged("ICAdjInvDocNo");
				}
			}
		}
		public String ICAdjInvDocDesc
		{
			get{return _iCAdjInvDocDesc;}
			set
			{
				if (value != this._iCAdjInvDocDesc)
				{
				_iCAdjInvDocDesc=value;
				NotifyChanged("ICAdjInvDocDesc");
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
		public Nullable<DateTime> ICAdjInvDocDate
		{
			get{return _iCAdjInvDocDate;}
			set
			{
				if (value != this._iCAdjInvDocDate)
				{
				_iCAdjInvDocDate=value;
				NotifyChanged("ICAdjInvDocDate");
				}
			}
		}
		public String ICAdjInvDocServerPath
		{
			get{return _iCAdjInvDocServerPath;}
			set
			{
				if (value != this._iCAdjInvDocServerPath)
				{
				_iCAdjInvDocServerPath=value;
				NotifyChanged("ICAdjInvDocServerPath");
				}
			}
		}
		public int FK_ICAdjInvID
		{
			get{return _fK_ICAdjInvID;}
			set
			{
				if (value != this._fK_ICAdjInvID)
				{
				_fK_ICAdjInvID=value;
				NotifyChanged("FK_ICAdjInvID");
				}
			}
		}
		public String ICAdjInvDocName
		{
			get{return _iCAdjInvDocName;}
			set
			{
				if (value != this._iCAdjInvDocName)
				{
				_iCAdjInvDocName=value;
				NotifyChanged("ICAdjInvDocName");
				}
			}
		}
		public String ICAdjInvDocServerFileName
		{
			get{return _iCAdjInvDocServerFileName;}
			set
			{
				if (value != this._iCAdjInvDocServerFileName)
				{
				_iCAdjInvDocServerFileName=value;
				NotifyChanged("ICAdjInvDocServerFileName");
				}
			}
		}
		public String ICAdjInvDocFileName
		{
			get{return _iCAdjInvDocFileName;}
			set
			{
				if (value != this._iCAdjInvDocFileName)
				{
				_iCAdjInvDocFileName=value;
				NotifyChanged("ICAdjInvDocFileName");
				}
			}
		}
		public String ICAdjInvDocClientPath
		{
			get{return _iCAdjInvDocClientPath;}
			set
			{
				if (value != this._iCAdjInvDocClientPath)
				{
				_iCAdjInvDocClientPath=value;
				NotifyChanged("ICAdjInvDocClientPath");
				}
			}
		}
		#endregion
	}
	#endregion
}