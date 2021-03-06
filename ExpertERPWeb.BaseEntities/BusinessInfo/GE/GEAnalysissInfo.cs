using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GEAnalysiss
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:GEAnalysissInfo
	//Created Date:Wednesday, January 07, 2015
	//-----------------------------------------------------------
	
	public class GEAnalysissInfo:BusinessObject
	{
		public GEAnalysissInfo()
		{
		}
		#region Variables
		protected int _gEAnalysisID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _gEAnalysisNo=String.Empty;
		protected String _gEAnalysisName=String.Empty;
		protected String _gEAnalysisDesc=String.Empty;
		protected Nullable<DateTime> _gEAnalysisDate;
		#endregion

		#region Public properties
		public int GEAnalysisID
		{
			get{return _gEAnalysisID;}
			set
			{
				if (value != this._gEAnalysisID)
				{
				_gEAnalysisID=value;
				NotifyChanged("GEAnalysisID");
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
		public String GEAnalysisNo
		{
			get{return _gEAnalysisNo;}
			set
			{
				if (value != this._gEAnalysisNo)
				{
				_gEAnalysisNo=value;
				NotifyChanged("GEAnalysisNo");
				}
			}
		}
		public String GEAnalysisName
		{
			get{return _gEAnalysisName;}
			set
			{
				if (value != this._gEAnalysisName)
				{
				_gEAnalysisName=value;
				NotifyChanged("GEAnalysisName");
				}
			}
		}
		public String GEAnalysisDesc
		{
			get{return _gEAnalysisDesc;}
			set
			{
				if (value != this._gEAnalysisDesc)
				{
				_gEAnalysisDesc=value;
				NotifyChanged("GEAnalysisDesc");
				}
			}
		}
		public Nullable<DateTime> GEAnalysisDate
		{
			get{return _gEAnalysisDate;}
			set
			{
				if (value != this._gEAnalysisDate)
				{
				_gEAnalysisDate=value;
				NotifyChanged("GEAnalysisDate");
				}
			}
		}
		#endregion
	}
	#endregion
}