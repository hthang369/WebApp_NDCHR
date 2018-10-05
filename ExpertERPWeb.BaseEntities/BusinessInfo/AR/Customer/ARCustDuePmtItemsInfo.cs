using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustDuePmtItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustDuePmtItemsInfo
	//Created Date:10 Tháng Năm 2012
	//-----------------------------------------------------------
	
	public class ARCustDuePmtItemsInfo:BusinessObject
	{
		public ARCustDuePmtItemsInfo()
		{
		}
		#region Variables
		protected int _aRCustDuePmtItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aRCustDuePmtItemDesc=String.Empty;
		protected int _aRCustDuePmtItemDate;
		protected int _fK_ARCustomerID;
		protected int _fK_ICProductID;
		#endregion

		#region Public properties
		public int ARCustDuePmtItemID
		{
			get{return _aRCustDuePmtItemID;}
			set
			{
				if (value != this._aRCustDuePmtItemID)
				{
				_aRCustDuePmtItemID=value;
				NotifyChanged("ARCustDuePmtItemID");
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
		public String ARCustDuePmtItemDesc
		{
			get{return _aRCustDuePmtItemDesc;}
			set
			{
				if (value != this._aRCustDuePmtItemDesc)
				{
				_aRCustDuePmtItemDesc=value;
				NotifyChanged("ARCustDuePmtItemDesc");
				}
			}
		}
		public int ARCustDuePmtItemDate
		{
			get{return _aRCustDuePmtItemDate;}
			set
			{
				if (value != this._aRCustDuePmtItemDate)
				{
				_aRCustDuePmtItemDate=value;
				NotifyChanged("ARCustDuePmtItemDate");
				}
			}
		}
		public int FK_ARCustomerID
		{
			get{return _fK_ARCustomerID;}
			set
			{
				if (value != this._fK_ARCustomerID)
				{
				_fK_ARCustomerID=value;
				NotifyChanged("FK_ARCustomerID");
				}
			}
		}
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				NotifyChanged("FK_ICProductID");
				}
			}
		}
		#endregion
	}
	#endregion
}