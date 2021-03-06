using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEFuncParams
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GEFuncParamsInfo
	//Created Date:Monday, April 03, 2017
	//-----------------------------------------------------------
	
	public class GEFuncParamsInfo:BusinessObject
	{
		public GEFuncParamsInfo()
		{
		}
		#region Variables
		protected int _gEFuncParamID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_GEFuncID;
		protected String _gEFuncParamNo=String.Empty;
		protected String _gEFuncParamName=String.Empty;
		protected String _gEFuncParamDesc=String.Empty;
		protected String _gEFuncParamTableName=String.Empty;
		protected String _gEFuncParamColumnName=String.Empty;
		protected String _gEFuncParamDisplayColumnName=String.Empty;
		protected String _gEFuncParamDisplayTableName=String.Empty;
		#endregion

		#region Public properties
		public int GEFuncParamID
		{
			get{return _gEFuncParamID;}
			set
			{
				if (value != this._gEFuncParamID)
				{
				_gEFuncParamID=value;
				NotifyChanged("GEFuncParamID");
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
		public int FK_GEFuncID
		{
			get{return _fK_GEFuncID;}
			set
			{
				if (value != this._fK_GEFuncID)
				{
				_fK_GEFuncID=value;
				NotifyChanged("FK_GEFuncID");
				}
			}
		}
		public String GEFuncParamNo
		{
			get{return _gEFuncParamNo;}
			set
			{
				if (value != this._gEFuncParamNo)
				{
				_gEFuncParamNo=value;
				NotifyChanged("GEFuncParamNo");
				}
			}
		}
		public String GEFuncParamName
		{
			get{return _gEFuncParamName;}
			set
			{
				if (value != this._gEFuncParamName)
				{
				_gEFuncParamName=value;
				NotifyChanged("GEFuncParamName");
				}
			}
		}
		public String GEFuncParamDesc
		{
			get{return _gEFuncParamDesc;}
			set
			{
				if (value != this._gEFuncParamDesc)
				{
				_gEFuncParamDesc=value;
				NotifyChanged("GEFuncParamDesc");
				}
			}
		}
		public String GEFuncParamTableName
		{
			get{return _gEFuncParamTableName;}
			set
			{
				if (value != this._gEFuncParamTableName)
				{
				_gEFuncParamTableName=value;
				NotifyChanged("GEFuncParamTableName");
				}
			}
		}
		public String GEFuncParamColumnName
		{
			get{return _gEFuncParamColumnName;}
			set
			{
				if (value != this._gEFuncParamColumnName)
				{
				_gEFuncParamColumnName=value;
				NotifyChanged("GEFuncParamColumnName");
				}
			}
		}
		public String GEFuncParamDisplayColumnName
		{
			get{return _gEFuncParamDisplayColumnName;}
			set
			{
				if (value != this._gEFuncParamDisplayColumnName)
				{
				_gEFuncParamDisplayColumnName=value;
				NotifyChanged("GEFuncParamDisplayColumnName");
				}
			}
		}
		public String GEFuncParamDisplayTableName
		{
			get{return _gEFuncParamDisplayTableName;}
			set
			{
				if (value != this._gEFuncParamDisplayTableName)
				{
				_gEFuncParamDisplayTableName=value;
				NotifyChanged("GEFuncParamDisplayTableName");
				}
			}
		}
		#endregion
	}
	#endregion
}