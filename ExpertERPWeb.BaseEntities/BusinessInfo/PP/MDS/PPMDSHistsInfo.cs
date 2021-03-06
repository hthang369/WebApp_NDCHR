using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPMDSHists
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PPMDSHistsInfo
	//Created Date:Wednesday, October 01, 2014
	//-----------------------------------------------------------
	
	public class PPMDSHistsInfo:BusinessObject
	{
		public PPMDSHistsInfo()
		{
		}
		#region Variables
		protected int _pPMDSHistID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _pPMDSHistNo=String.Empty;
		protected String _pPMDSHistName=String.Empty;
		protected String _pPMDSHistDesc=String.Empty;
		protected Nullable<DateTime> _pPMDSHistDate;
		protected int _fK_HREmployeeID;
		protected Nullable<DateTime> _pPMDSHistStartDate;
		protected Nullable<DateTime> _pPMDSHistEndDate;
		#endregion

		#region Public properties
		public int PPMDSHistID
		{
			get{return _pPMDSHistID;}
			set
			{
				if (value != this._pPMDSHistID)
				{
				_pPMDSHistID=value;
				NotifyChanged("PPMDSHistID");
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
		public String PPMDSHistNo
		{
			get{return _pPMDSHistNo;}
			set
			{
				if (value != this._pPMDSHistNo)
				{
				_pPMDSHistNo=value;
				NotifyChanged("PPMDSHistNo");
				}
			}
		}
		public String PPMDSHistName
		{
			get{return _pPMDSHistName;}
			set
			{
				if (value != this._pPMDSHistName)
				{
				_pPMDSHistName=value;
				NotifyChanged("PPMDSHistName");
				}
			}
		}
		public String PPMDSHistDesc
		{
			get{return _pPMDSHistDesc;}
			set
			{
				if (value != this._pPMDSHistDesc)
				{
				_pPMDSHistDesc=value;
				NotifyChanged("PPMDSHistDesc");
				}
			}
		}
		public Nullable<DateTime> PPMDSHistDate
		{
			get{return _pPMDSHistDate;}
			set
			{
				if (value != this._pPMDSHistDate)
				{
				_pPMDSHistDate=value;
				NotifyChanged("PPMDSHistDate");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get{return _fK_HREmployeeID;}
			set
			{
				if (value != this._fK_HREmployeeID)
				{
				_fK_HREmployeeID=value;
				NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public Nullable<DateTime> PPMDSHistStartDate
		{
			get{return _pPMDSHistStartDate;}
			set
			{
				if (value != this._pPMDSHistStartDate)
				{
				_pPMDSHistStartDate=value;
				NotifyChanged("PPMDSHistStartDate");
				}
			}
		}
		public Nullable<DateTime> PPMDSHistEndDate
		{
			get{return _pPMDSHistEndDate;}
			set
			{
				if (value != this._pPMDSHistEndDate)
				{
				_pPMDSHistEndDate=value;
				NotifyChanged("PPMDSHistEndDate");
				}
			}
		}
		#endregion
	}
	#endregion
}