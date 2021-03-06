using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICUOMs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICUOMsInfo
	//Created Date:05 November 2014
	//-----------------------------------------------------------
	
	public class ICUOMsInfo:BusinessObject
	{
		public ICUOMsInfo()
		{
		}
		#region Variables
		protected int _iCUOMID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _iCUOMNo=String.Empty;
		protected String _iCUOMName=String.Empty;
		protected String _iCUOMDesc=String.Empty;
		protected String _iCUOMMethod=String.Empty;
		protected double _iCUOMFactor;
		protected int _fK_ICBaseUOMID;
		#endregion

		#region Public properties
		public int ICUOMID
		{
			get{return _iCUOMID;}
			set
			{
				if (value != this._iCUOMID)
				{
				_iCUOMID=value;
				NotifyChanged("ICUOMID");
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
		public String ICUOMNo
		{
			get{return _iCUOMNo;}
			set
			{
				if (value != this._iCUOMNo)
				{
				_iCUOMNo=value;
				NotifyChanged("ICUOMNo");
				}
			}
		}
		public String ICUOMName
		{
			get{return _iCUOMName;}
			set
			{
				if (value != this._iCUOMName)
				{
				_iCUOMName=value;
				NotifyChanged("ICUOMName");
				}
			}
		}
		public String ICUOMDesc
		{
			get{return _iCUOMDesc;}
			set
			{
				if (value != this._iCUOMDesc)
				{
				_iCUOMDesc=value;
				NotifyChanged("ICUOMDesc");
				}
			}
		}
		public String ICUOMMethod
		{
			get{return _iCUOMMethod;}
			set
			{
				if (value != this._iCUOMMethod)
				{
				_iCUOMMethod=value;
				NotifyChanged("ICUOMMethod");
				}
			}
		}
		public double ICUOMFactor
		{
			get{return _iCUOMFactor;}
			set
			{
				if (value != this._iCUOMFactor)
				{
				_iCUOMFactor=value;
				NotifyChanged("ICUOMFactor");
				}
			}
		}
		public int FK_ICBaseUOMID
		{
			get{return _fK_ICBaseUOMID;}
			set
			{
				if (value != this._fK_ICBaseUOMID)
				{
				_fK_ICBaseUOMID=value;
				NotifyChanged("FK_ICBaseUOMID");
				}
			}
		}
		#endregion
	}
	#endregion
}