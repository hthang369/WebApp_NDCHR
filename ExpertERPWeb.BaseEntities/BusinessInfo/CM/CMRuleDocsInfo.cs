using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMRuleDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMRuleDocsInfo
	//Created Date:Friday, April 10, 2009
	//-----------------------------------------------------------
	
	public class CMRuleDocsInfo:BusinessObject
	{
		public CMRuleDocsInfo()
		{
		}
		#region Variables
		protected int _cMRuleDocID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _cMRuleDocNo=String.Empty;
		protected String _cMRuleDocName=String.Empty;
		protected int _fK_CMRuleID;
		protected String _cMRuleDocDesc=String.Empty;
		protected String _cMRuleDocFileName=String.Empty;
		protected String _cMRuleDocLocalPath=String.Empty;
		protected String _cMRuleDocServerPath=String.Empty;
		protected String _cMRuleDocStatusCombo=DefaultStatus;
		protected DateTime _cMRuleDocApprovedDate=DateTime.MaxValue;
		protected String _cMRuleDocApprovedBy=String.Empty;
		protected String _cMRuleDocReviewBy=String.Empty;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		#endregion

		#region Public properties
		public int CMRuleDocID
		{
			get{return _cMRuleDocID;}
			set
			{
				if (value != this._cMRuleDocID)
				{
				_cMRuleDocID=value;
				NotifyChanged("CMRuleDocID");
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
		public String CMRuleDocNo
		{
			get{return _cMRuleDocNo;}
			set
			{
				if (value != this._cMRuleDocNo)
				{
				_cMRuleDocNo=value;
				NotifyChanged("CMRuleDocNo");
				}
			}
		}
		public String CMRuleDocName
		{
			get{return _cMRuleDocName;}
			set
			{
				if (value != this._cMRuleDocName)
				{
				_cMRuleDocName=value;
				NotifyChanged("CMRuleDocName");
				}
			}
		}
		public int FK_CMRuleID
		{
			get{return _fK_CMRuleID;}
			set
			{
				if (value != this._fK_CMRuleID)
				{
				_fK_CMRuleID=value;
				NotifyChanged("FK_CMRuleID");
				}
			}
		}
		public String CMRuleDocDesc
		{
			get{return _cMRuleDocDesc;}
			set
			{
				if (value != this._cMRuleDocDesc)
				{
				_cMRuleDocDesc=value;
				NotifyChanged("CMRuleDocDesc");
				}
			}
		}
		public String CMRuleDocFileName
		{
			get{return _cMRuleDocFileName;}
			set
			{
				if (value != this._cMRuleDocFileName)
				{
				_cMRuleDocFileName=value;
				NotifyChanged("CMRuleDocFileName");
				}
			}
		}
		public String CMRuleDocLocalPath
		{
			get{return _cMRuleDocLocalPath;}
			set
			{
				if (value != this._cMRuleDocLocalPath)
				{
				_cMRuleDocLocalPath=value;
				NotifyChanged("CMRuleDocLocalPath");
				}
			}
		}
		public String CMRuleDocServerPath
		{
			get{return _cMRuleDocServerPath;}
			set
			{
				if (value != this._cMRuleDocServerPath)
				{
				_cMRuleDocServerPath=value;
				NotifyChanged("CMRuleDocServerPath");
				}
			}
		}
		public String CMRuleDocStatusCombo
		{
			get{return _cMRuleDocStatusCombo;}
			set
			{
				if (value != this._cMRuleDocStatusCombo)
				{
				_cMRuleDocStatusCombo=value;
				NotifyChanged("CMRuleDocStatusCombo");
				}
			}
		}
		public DateTime CMRuleDocApprovedDate
		{
			get{return _cMRuleDocApprovedDate;}
			set
			{
				if (value != this._cMRuleDocApprovedDate)
				{
				_cMRuleDocApprovedDate=value;
				NotifyChanged("CMRuleDocApprovedDate");
				}
			}
		}
		public String CMRuleDocApprovedBy
		{
			get{return _cMRuleDocApprovedBy;}
			set
			{
				if (value != this._cMRuleDocApprovedBy)
				{
				_cMRuleDocApprovedBy=value;
				NotifyChanged("CMRuleDocApprovedBy");
				}
			}
		}
		public String CMRuleDocReviewBy
		{
			get{return _cMRuleDocReviewBy;}
			set
			{
				if (value != this._cMRuleDocReviewBy)
				{
				_cMRuleDocReviewBy=value;
				NotifyChanged("CMRuleDocReviewBy");
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