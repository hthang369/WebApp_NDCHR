using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PRSlrAdjs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PRSlrAdjsInfo
	//Created Date:25 Tháng Mười 2013
	//-----------------------------------------------------------
	
	public class PRSlrAdjsInfo:BusinessObject
	{
		public PRSlrAdjsInfo()
		{
		}
		#region Variables
		protected int _pRSlrAdjID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _approvalStatusCombo=DefaultStatus;
		protected Nullable<DateTime> _pRSlrAdjDate;
		protected String _pRSlrAdjNo=String.Empty;
		protected String _pRSlrAdjName=String.Empty;
		protected String _pRSlrAdjDesc=String.Empty;
		protected Nullable<DateTime> _pRSlrAdjEffectDate;
		protected String _pRSlrAdjStatusCombo=DefaultStatus;
		#endregion

		#region Public properties
		public int PRSlrAdjID
		{
			get{return _pRSlrAdjID;}
			set
			{
				if (value != this._pRSlrAdjID)
				{
				_pRSlrAdjID=value;
				NotifyChanged("PRSlrAdjID");
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
		public String ApprovalStatusCombo
		{
			get{return _approvalStatusCombo;}
			set
			{
				if (value != this._approvalStatusCombo)
				{
				_approvalStatusCombo=value;
				NotifyChanged("ApprovalStatusCombo");
				}
			}
		}
		public Nullable<DateTime> PRSlrAdjDate
		{
			get{return _pRSlrAdjDate;}
			set
			{
				if (value != this._pRSlrAdjDate)
				{
				_pRSlrAdjDate=value;
				NotifyChanged("PRSlrAdjDate");
				}
			}
		}
		public String PRSlrAdjNo
		{
			get{return _pRSlrAdjNo;}
			set
			{
				if (value != this._pRSlrAdjNo)
				{
				_pRSlrAdjNo=value;
				NotifyChanged("PRSlrAdjNo");
				}
			}
		}
		public String PRSlrAdjName
		{
			get{return _pRSlrAdjName;}
			set
			{
				if (value != this._pRSlrAdjName)
				{
				_pRSlrAdjName=value;
				NotifyChanged("PRSlrAdjName");
				}
			}
		}
		public String PRSlrAdjDesc
		{
			get{return _pRSlrAdjDesc;}
			set
			{
				if (value != this._pRSlrAdjDesc)
				{
				_pRSlrAdjDesc=value;
				NotifyChanged("PRSlrAdjDesc");
				}
			}
		}
		public Nullable<DateTime> PRSlrAdjEffectDate
		{
			get{return _pRSlrAdjEffectDate;}
			set
			{
				if (value != this._pRSlrAdjEffectDate)
				{
				_pRSlrAdjEffectDate=value;
				NotifyChanged("PRSlrAdjEffectDate");
				}
			}
		}
		public String PRSlrAdjStatusCombo
		{
			get{return _pRSlrAdjStatusCombo;}
			set
			{
				if (value != this._pRSlrAdjStatusCombo)
				{
				_pRSlrAdjStatusCombo=value;
				NotifyChanged("PRSlrAdjStatusCombo");
				}
			}
		}
		#endregion
	}
	#endregion
}