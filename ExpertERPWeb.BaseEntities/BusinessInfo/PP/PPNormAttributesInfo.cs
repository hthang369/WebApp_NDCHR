using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPNormAttributes
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPNormAttributesInfo
	//Created Date:Saturday, May 9, 2015
	//-----------------------------------------------------------
	
	public class PPNormAttributesInfo:BusinessObject
	{
		public PPNormAttributesInfo()
		{
		}
		#region Variables
		protected int _pPNormAttributeID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_PPNormRMID;
		protected int _fK_ICAttributeID;
		protected String _pPNormAttributeValue=String.Empty;
		#endregion

		#region Public properties
		public int PPNormAttributeID
		{
			get{return _pPNormAttributeID;}
			set
			{
				if (value != this._pPNormAttributeID)
				{
				_pPNormAttributeID=value;
				NotifyChanged("PPNormAttributeID");
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
		public int FK_PPNormRMID
		{
			get{return _fK_PPNormRMID;}
			set
			{
				if (value != this._fK_PPNormRMID)
				{
				_fK_PPNormRMID=value;
				NotifyChanged("FK_PPNormRMID");
				}
			}
		}
		public int FK_ICAttributeID
		{
			get{return _fK_ICAttributeID;}
			set
			{
				if (value != this._fK_ICAttributeID)
				{
				_fK_ICAttributeID=value;
				NotifyChanged("FK_ICAttributeID");
				}
			}
		}
		public String PPNormAttributeValue
		{
			get{return _pPNormAttributeValue;}
			set
			{
				if (value != this._pPNormAttributeValue)
				{
				_pPNormAttributeValue=value;
				NotifyChanged("PPNormAttributeValue");
				}
			}
		}
		#endregion
	}
	#endregion
}