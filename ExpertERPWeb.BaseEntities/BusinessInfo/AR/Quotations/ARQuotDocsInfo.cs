using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARQuotDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARQuotDocsInfo
	//Created Date:14 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class ARQuotDocsInfo:BusinessObject
	{
		public ARQuotDocsInfo()
		{
		}
		#region Variables
		protected int _aRQuotDocID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aRQuotDocNo=String.Empty;
		protected String _aRQuotDocDesc=String.Empty;
		protected String _aRQuotDocUser=String.Empty;
		protected Nullable<DateTime> _aRQuotDocDate;
		protected String _aRQuotDocServerPath=String.Empty;
		protected int _fK_ARQuotID;
		protected int _fK_ADUserID;
		#endregion

		#region Public properties
		public int ARQuotDocID
		{
			get{return _aRQuotDocID;}
			set
			{
				if (value != this._aRQuotDocID)
				{
				_aRQuotDocID=value;
				NotifyChanged("ARQuotDocID");
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
		public String ARQuotDocNo
		{
			get{return _aRQuotDocNo;}
			set
			{
				if (value != this._aRQuotDocNo)
				{
				_aRQuotDocNo=value;
				NotifyChanged("ARQuotDocNo");
				}
			}
		}
		public String ARQuotDocDesc
		{
			get{return _aRQuotDocDesc;}
			set
			{
				if (value != this._aRQuotDocDesc)
				{
				_aRQuotDocDesc=value;
				NotifyChanged("ARQuotDocDesc");
				}
			}
		}
		public String ARQuotDocUser
		{
			get{return _aRQuotDocUser;}
			set
			{
				if (value != this._aRQuotDocUser)
				{
				_aRQuotDocUser=value;
				NotifyChanged("ARQuotDocUser");
				}
			}
		}
		public Nullable<DateTime> ARQuotDocDate
		{
			get{return _aRQuotDocDate;}
			set
			{
				if (value != this._aRQuotDocDate)
				{
				_aRQuotDocDate=value;
				NotifyChanged("ARQuotDocDate");
				}
			}
		}
		public String ARQuotDocServerPath
		{
			get{return _aRQuotDocServerPath;}
			set
			{
				if (value != this._aRQuotDocServerPath)
				{
				_aRQuotDocServerPath=value;
				NotifyChanged("ARQuotDocServerPath");
				}
			}
		}
		public int FK_ARQuotID
		{
			get{return _fK_ARQuotID;}
			set
			{
				if (value != this._fK_ARQuotID)
				{
				_fK_ARQuotID=value;
				NotifyChanged("FK_ARQuotID");
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
		#endregion
	}
	#endregion
}