using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSOItemAttrs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARSOItemAttrsInfo
	//Created Date:Wednesday, April 1, 2015
	//-----------------------------------------------------------
	
	public class ARSOItemAttrsInfo:BusinessObject
	{
		public ARSOItemAttrsInfo()
		{
		}
		#region Variables
		protected int _aRSOItemAttrID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ARSOID;
		protected int _fK_ARCustomerReqAttrID;
		protected String _aRSOItemAttrValue=String.Empty;
		protected String _aRSOItemAttrDesc=String.Empty;
		protected String _aRSOItemAttrGroup=String.Empty;
		protected int _fK_ICProductID;
		#endregion

		#region Public properties
		public int ARSOItemAttrID
		{
			get{return _aRSOItemAttrID;}
			set
			{
				if (value != this._aRSOItemAttrID)
				{
				_aRSOItemAttrID=value;
				NotifyChanged("ARSOItemAttrID");
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
		public int FK_ARSOID
		{
			get{return _fK_ARSOID;}
			set
			{
				if (value != this._fK_ARSOID)
				{
				_fK_ARSOID=value;
				NotifyChanged("FK_ARSOID");
				}
			}
		}
		public int FK_ARCustomerReqAttrID
		{
			get{return _fK_ARCustomerReqAttrID;}
			set
			{
				if (value != this._fK_ARCustomerReqAttrID)
				{
				_fK_ARCustomerReqAttrID=value;
				NotifyChanged("FK_ARCustomerReqAttrID");
				}
			}
		}
		public String ARSOItemAttrValue
		{
			get{return _aRSOItemAttrValue;}
			set
			{
				if (value != this._aRSOItemAttrValue)
				{
				_aRSOItemAttrValue=value;
				NotifyChanged("ARSOItemAttrValue");
				}
			}
		}
		public String ARSOItemAttrDesc
		{
			get{return _aRSOItemAttrDesc;}
			set
			{
				if (value != this._aRSOItemAttrDesc)
				{
				_aRSOItemAttrDesc=value;
				NotifyChanged("ARSOItemAttrDesc");
				}
			}
		}
		public String ARSOItemAttrGroup
		{
			get{return _aRSOItemAttrGroup;}
			set
			{
				if (value != this._aRSOItemAttrGroup)
				{
				_aRSOItemAttrGroup=value;
				NotifyChanged("ARSOItemAttrGroup");
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