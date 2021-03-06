using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region CMRules
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:CMRulesInfo
	//Created Date:Friday, April 10, 2009
	//-----------------------------------------------------------
	
	public class CMRulesInfo:BusinessObject
	{
		public CMRulesInfo()
		{
		}
		#region Variables
		protected int _cMRuleID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _cMRuleNo=String.Empty;
		protected String _cMRuleName=String.Empty;
		protected String _cMRuleDecs=String.Empty;
		protected String _cMRuleStatusCombo=DefaultStatus;
		protected String _cMRuleContent=String.Empty;
		protected String _cMRuleReviewBy=String.Empty;
		protected DateTime _cMRuleReviewDate=DateTime.MaxValue;
		protected String _cMRuleApprovedBy=String.Empty;
		protected DateTime _cMRuleApprovedDate=DateTime.MaxValue;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected DateTime _aACreatedDate=DateTime.MaxValue;
		protected DateTime _aAUpdatedDate=DateTime.MaxValue;
		#endregion

		#region Public properties
		public int CMRuleID
		{
			get{return _cMRuleID;}
			set
			{
				if (value != this._cMRuleID)
				{
				_cMRuleID=value;
				NotifyChanged("CMRuleID");
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
		public String CMRuleNo
		{
			get{return _cMRuleNo;}
			set
			{
				if (value != this._cMRuleNo)
				{
				_cMRuleNo=value;
				NotifyChanged("CMRuleNo");
				}
			}
		}
		public String CMRuleName
		{
			get{return _cMRuleName;}
			set
			{
				if (value != this._cMRuleName)
				{
				_cMRuleName=value;
				NotifyChanged("CMRuleName");
				}
			}
		}
		public String CMRuleDecs
		{
			get{return _cMRuleDecs;}
			set
			{
				if (value != this._cMRuleDecs)
				{
				_cMRuleDecs=value;
				NotifyChanged("CMRuleDecs");
				}
			}
		}
		public String CMRuleStatusCombo
		{
			get{return _cMRuleStatusCombo;}
			set
			{
				if (value != this._cMRuleStatusCombo)
				{
				_cMRuleStatusCombo=value;
				NotifyChanged("CMRuleStatusCombo");
				}
			}
		}
		public String CMRuleContent
		{
			get{return _cMRuleContent;}
			set
			{
				if (value != this._cMRuleContent)
				{
				_cMRuleContent=value;
				NotifyChanged("CMRuleContent");
				}
			}
		}
		public String CMRuleReviewBy
		{
			get{return _cMRuleReviewBy;}
			set
			{
				if (value != this._cMRuleReviewBy)
				{
				_cMRuleReviewBy=value;
				NotifyChanged("CMRuleReviewBy");
				}
			}
		}
		public DateTime CMRuleReviewDate
		{
			get{return _cMRuleReviewDate;}
			set
			{
				if (value != this._cMRuleReviewDate)
				{
				_cMRuleReviewDate=value;
				NotifyChanged("CMRuleReviewDate");
				}
			}
		}
		public String CMRuleApprovedBy
		{
			get{return _cMRuleApprovedBy;}
			set
			{
				if (value != this._cMRuleApprovedBy)
				{
				_cMRuleApprovedBy=value;
				NotifyChanged("CMRuleApprovedBy");
				}
			}
		}
		public DateTime CMRuleApprovedDate
		{
			get{return _cMRuleApprovedDate;}
			set
			{
				if (value != this._cMRuleApprovedDate)
				{
				_cMRuleApprovedDate=value;
				NotifyChanged("CMRuleApprovedDate");
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