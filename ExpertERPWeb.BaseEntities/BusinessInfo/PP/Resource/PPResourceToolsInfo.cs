using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPResourceTools
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPResourceToolsInfo
	//Created Date:Friday, January 06, 2017
	//-----------------------------------------------------------
	
	public class PPResourceToolsInfo:BusinessObject
	{
		public PPResourceToolsInfo()
		{
		}
		#region Variables
		protected int _pPResourceToolID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _pPResourceToolNo=String.Empty;
		protected String _pPResourceToolName=String.Empty;
		protected String _pPResourceToolDesc=String.Empty;
		#endregion

		#region Public properties
		public int PPResourceToolID
		{
			get{return _pPResourceToolID;}
			set
			{
				if (value != this._pPResourceToolID)
				{
				_pPResourceToolID=value;
				NotifyChanged("PPResourceToolID");
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
		public String PPResourceToolNo
		{
			get{return _pPResourceToolNo;}
			set
			{
				if (value != this._pPResourceToolNo)
				{
				_pPResourceToolNo=value;
				NotifyChanged("PPResourceToolNo");
				}
			}
		}
		public String PPResourceToolName
		{
			get{return _pPResourceToolName;}
			set
			{
				if (value != this._pPResourceToolName)
				{
				_pPResourceToolName=value;
				NotifyChanged("PPResourceToolName");
				}
			}
		}
		public String PPResourceToolDesc
		{
			get{return _pPResourceToolDesc;}
			set
			{
				if (value != this._pPResourceToolDesc)
				{
				_pPResourceToolDesc=value;
				NotifyChanged("PPResourceToolDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}