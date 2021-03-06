using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLVoucherComments
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLVoucherCommentsInfo
	//Created Date:25 Tháng Mười Hai 2012
	//-----------------------------------------------------------
	
	public class GLVoucherCommentsInfo:BusinessObject
	{
		public GLVoucherCommentsInfo()
		{
		}
		#region Variables
		protected int _gLVoucherCommentID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected int _fK_GLVoucherID;
		protected String _gLVoucherUserGroupStageStatusCombo=DefaultStatus;
		protected String _gLVoucherApproveStageStatusCombo=DefaultStatus;
		protected int _fK_ADUserID;
		protected String _gLVoucherCommentDesc=String.Empty;
		#endregion

		#region Public properties
		public int GLVoucherCommentID
		{
			get{return _gLVoucherCommentID;}
			set
			{
				if (value != this._gLVoucherCommentID)
				{
				_gLVoucherCommentID=value;
				NotifyChanged("GLVoucherCommentID");
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
		public int FK_GLVoucherID
		{
			get{return _fK_GLVoucherID;}
			set
			{
				if (value != this._fK_GLVoucherID)
				{
				_fK_GLVoucherID=value;
				NotifyChanged("FK_GLVoucherID");
				}
			}
		}
		public String GLVoucherUserGroupStageStatusCombo
		{
			get{return _gLVoucherUserGroupStageStatusCombo;}
			set
			{
				if (value != this._gLVoucherUserGroupStageStatusCombo)
				{
				_gLVoucherUserGroupStageStatusCombo=value;
				NotifyChanged("GLVoucherUserGroupStageStatusCombo");
				}
			}
		}
		public String GLVoucherApproveStageStatusCombo
		{
			get{return _gLVoucherApproveStageStatusCombo;}
			set
			{
				if (value != this._gLVoucherApproveStageStatusCombo)
				{
				_gLVoucherApproveStageStatusCombo=value;
				NotifyChanged("GLVoucherApproveStageStatusCombo");
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
		public String GLVoucherCommentDesc
		{
			get{return _gLVoucherCommentDesc;}
			set
			{
				if (value != this._gLVoucherCommentDesc)
				{
				_gLVoucherCommentDesc=value;
				NotifyChanged("GLVoucherCommentDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}