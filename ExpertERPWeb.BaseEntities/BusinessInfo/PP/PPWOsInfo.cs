 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPWOs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.4)
    //Class: PPWOsInfo
    //Created Date: Thursday, 15 Jun 2017
    //-----------------------------------------------------------

    public class PPWOsInfo : BusinessObject
    {
        public PPWOsInfo()
        {
        }
        #region Variables
		protected int _pPWOID;
		protected String _aAStatus = DefaultAAStatus;
		protected String _aACreatedUser = String.Empty;
		protected String _aAUpdatedUser = String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _pPWONo = String.Empty;
		protected String _pPWOName = String.Empty;
		protected String _pPWODesc = String.Empty;
		protected Nullable<DateTime> _pPWODate;
		protected String _pPWOStatus = DefaultStatus;
		protected Nullable<DateTime> _pPWOEstDate;
		protected Nullable<DateTime> _pPWOActDate;
		protected int _fK_HREmployeeID;
		protected int _fK_PPProductPlnID;
		protected int _fK_ARSOID;
		protected bool _aASelected = true;
		protected int _fK_PPMPSID;
		protected String _pPWOStatusCombo = DefaultStatus;
		protected int _fK_PPWBSID;
		protected Nullable<DateTime> _pPWOEstStartDate;
		protected Nullable<DateTime> _pPWOEstEndDate;
		protected Nullable<DateTime> _pPWOActStartDate;
		protected Nullable<DateTime> _pPWOActEndDate;
		protected String _aAModule = String.Empty;
		protected String _pPWOTypeCombo = String.Empty;
		
        #endregion

        #region Public properties
		public int PPWOID
		{
			get { return _pPWOID; }
			set
			{
				if (value != this._pPWOID)
				{
					_pPWOID = value;
					NotifyChanged("PPWOID");
				}
			}
		}
		public String AAStatus
		{
			get { return _aAStatus; }
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus = value;
					NotifyChanged("AAStatus");
				}
			}
		}
		public String AACreatedUser
		{
			get { return _aACreatedUser; }
			set
			{
				if (value != this._aACreatedUser)
				{
					_aACreatedUser = value;
					NotifyChanged("AACreatedUser");
				}
			}
		}
		public String AAUpdatedUser
		{
			get { return _aAUpdatedUser; }
			set
			{
				if (value != this._aAUpdatedUser)
				{
					_aAUpdatedUser = value;
					NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get { return _aACreatedDate; }
			set
			{
				if (value != this._aACreatedDate)
				{
					_aACreatedDate = value;
					NotifyChanged("AACreatedDate");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get { return _aAUpdatedDate; }
			set
			{
				if (value != this._aAUpdatedDate)
				{
					_aAUpdatedDate = value;
					NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String PPWONo
		{
			get { return _pPWONo; }
			set
			{
				if (value != this._pPWONo)
				{
					_pPWONo = value;
					NotifyChanged("PPWONo");
				}
			}
		}
		public String PPWOName
		{
			get { return _pPWOName; }
			set
			{
				if (value != this._pPWOName)
				{
					_pPWOName = value;
					NotifyChanged("PPWOName");
				}
			}
		}
		public String PPWODesc
		{
			get { return _pPWODesc; }
			set
			{
				if (value != this._pPWODesc)
				{
					_pPWODesc = value;
					NotifyChanged("PPWODesc");
				}
			}
		}
		public Nullable<DateTime> PPWODate
		{
			get { return _pPWODate; }
			set
			{
				if (value != this._pPWODate)
				{
					_pPWODate = value;
					NotifyChanged("PPWODate");
				}
			}
		}
		public String PPWOStatus
		{
			get { return _pPWOStatus; }
			set
			{
				if (value != this._pPWOStatus)
				{
					_pPWOStatus = value;
					NotifyChanged("PPWOStatus");
				}
			}
		}
		public Nullable<DateTime> PPWOEstDate
		{
			get { return _pPWOEstDate; }
			set
			{
				if (value != this._pPWOEstDate)
				{
					_pPWOEstDate = value;
					NotifyChanged("PPWOEstDate");
				}
			}
		}
		public Nullable<DateTime> PPWOActDate
		{
			get { return _pPWOActDate; }
			set
			{
				if (value != this._pPWOActDate)
				{
					_pPWOActDate = value;
					NotifyChanged("PPWOActDate");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get { return _fK_HREmployeeID; }
			set
			{
				if (value != this._fK_HREmployeeID)
				{
					_fK_HREmployeeID = value;
					NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public int FK_PPProductPlnID
		{
			get { return _fK_PPProductPlnID; }
			set
			{
				if (value != this._fK_PPProductPlnID)
				{
					_fK_PPProductPlnID = value;
					NotifyChanged("FK_PPProductPlnID");
				}
			}
		}
		public int FK_ARSOID
		{
			get { return _fK_ARSOID; }
			set
			{
				if (value != this._fK_ARSOID)
				{
					_fK_ARSOID = value;
					NotifyChanged("FK_ARSOID");
				}
			}
		}
		public bool AASelected
		{
			get { return _aASelected; }
			set
			{
				if (value != this._aASelected)
				{
					_aASelected = value;
					NotifyChanged("AASelected");
				}
			}
		}
		public int FK_PPMPSID
		{
			get { return _fK_PPMPSID; }
			set
			{
				if (value != this._fK_PPMPSID)
				{
					_fK_PPMPSID = value;
					NotifyChanged("FK_PPMPSID");
				}
			}
		}
		public String PPWOStatusCombo
		{
			get { return _pPWOStatusCombo; }
			set
			{
				if (value != this._pPWOStatusCombo)
				{
					_pPWOStatusCombo = value;
					NotifyChanged("PPWOStatusCombo");
				}
			}
		}
		public int FK_PPWBSID
		{
			get { return _fK_PPWBSID; }
			set
			{
				if (value != this._fK_PPWBSID)
				{
					_fK_PPWBSID = value;
					NotifyChanged("FK_PPWBSID");
				}
			}
		}
		public Nullable<DateTime> PPWOEstStartDate
		{
			get { return _pPWOEstStartDate; }
			set
			{
				if (value != this._pPWOEstStartDate)
				{
					_pPWOEstStartDate = value;
					NotifyChanged("PPWOEstStartDate");
				}
			}
		}
		public Nullable<DateTime> PPWOEstEndDate
		{
			get { return _pPWOEstEndDate; }
			set
			{
				if (value != this._pPWOEstEndDate)
				{
					_pPWOEstEndDate = value;
					NotifyChanged("PPWOEstEndDate");
				}
			}
		}
		public Nullable<DateTime> PPWOActStartDate
		{
			get { return _pPWOActStartDate; }
			set
			{
				if (value != this._pPWOActStartDate)
				{
					_pPWOActStartDate = value;
					NotifyChanged("PPWOActStartDate");
				}
			}
		}
		public Nullable<DateTime> PPWOActEndDate
		{
			get { return _pPWOActEndDate; }
			set
			{
				if (value != this._pPWOActEndDate)
				{
					_pPWOActEndDate = value;
					NotifyChanged("PPWOActEndDate");
				}
			}
		}
		public String AAModule
		{
			get { return _aAModule; }
			set
			{
				if (value != this._aAModule)
				{
					_aAModule = value;
					NotifyChanged("AAModule");
				}
			}
		}
		public String PPWOTypeCombo
		{
			get { return _pPWOTypeCombo; }
			set
			{
				if (value != this._pPWOTypeCombo)
				{
					_pPWOTypeCombo = value;
					NotifyChanged("PPWOTypeCombo");
				}
			}
		}
		
        #endregion
    }
    #endregion
}