 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPMDSs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.4)
    //Class: PPMDSsInfo
    //Created Date: Friday, 09 Jun 2017
    //-----------------------------------------------------------

    public class PPMDSsInfo : BusinessObject
    {
        public PPMDSsInfo()
        {
        }
        #region Variables
		protected int _pPMDSID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _pPMDSNo = String.Empty;
		protected String _pPMDSName = String.Empty;
		protected String _pPMDSDesc = String.Empty;
		protected Nullable<DateTime> _pPMDSDate;
		protected int _fK_HREmployeeID;
		protected Nullable<DateTime> _pPMDSStartDate;
		protected Nullable<DateTime> _pPMDSEndDate;
		protected String _pPMDSTOF01Combo = String.Empty;
		protected String _pPMDSTOF02Combo = String.Empty;
		protected String _pPMDSTOF03Combo = String.Empty;
		protected String _pPMDSTOF04Combo = String.Empty;
		protected String _pPMDSTOF05Combo = String.Empty;
		protected String _pPMDSTOF06Combo = String.Empty;
		protected String _pPMDSTOF07Combo = String.Empty;
		protected String _pPMDSTOF08Combo = String.Empty;
		protected String _pPMDSTOF09Combo = String.Empty;
		protected String _pPMDSTOF10Combo = String.Empty;
		protected String _pPMDSTimeTypeCombo = String.Empty;
		protected String _pPMDSViewTypeCombo = String.Empty;
		protected bool _pPMDSIsShowDiffCheck = true;
		protected int _pPMDSPeriod;
		protected int _pPMDSYear;
		
        #endregion

        #region Public properties
		public int PPMDSID
		{
			get { return _pPMDSID; }
			set
			{
				if (value != this._pPMDSID)
				{
					_pPMDSID = value;
					NotifyChanged("PPMDSID");
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
		public String PPMDSNo
		{
			get { return _pPMDSNo; }
			set
			{
				if (value != this._pPMDSNo)
				{
					_pPMDSNo = value;
					NotifyChanged("PPMDSNo");
				}
			}
		}
		public String PPMDSName
		{
			get { return _pPMDSName; }
			set
			{
				if (value != this._pPMDSName)
				{
					_pPMDSName = value;
					NotifyChanged("PPMDSName");
				}
			}
		}
		public String PPMDSDesc
		{
			get { return _pPMDSDesc; }
			set
			{
				if (value != this._pPMDSDesc)
				{
					_pPMDSDesc = value;
					NotifyChanged("PPMDSDesc");
				}
			}
		}
		public Nullable<DateTime> PPMDSDate
		{
			get { return _pPMDSDate; }
			set
			{
				if (value != this._pPMDSDate)
				{
					_pPMDSDate = value;
					NotifyChanged("PPMDSDate");
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
		public Nullable<DateTime> PPMDSStartDate
		{
			get { return _pPMDSStartDate; }
			set
			{
				if (value != this._pPMDSStartDate)
				{
					_pPMDSStartDate = value;
					NotifyChanged("PPMDSStartDate");
				}
			}
		}
		public Nullable<DateTime> PPMDSEndDate
		{
			get { return _pPMDSEndDate; }
			set
			{
				if (value != this._pPMDSEndDate)
				{
					_pPMDSEndDate = value;
					NotifyChanged("PPMDSEndDate");
				}
			}
		}
		public String PPMDSTOF01Combo
		{
			get { return _pPMDSTOF01Combo; }
			set
			{
				if (value != this._pPMDSTOF01Combo)
				{
					_pPMDSTOF01Combo = value;
					NotifyChanged("PPMDSTOF01Combo");
				}
			}
		}
		public String PPMDSTOF02Combo
		{
			get { return _pPMDSTOF02Combo; }
			set
			{
				if (value != this._pPMDSTOF02Combo)
				{
					_pPMDSTOF02Combo = value;
					NotifyChanged("PPMDSTOF02Combo");
				}
			}
		}
		public String PPMDSTOF03Combo
		{
			get { return _pPMDSTOF03Combo; }
			set
			{
				if (value != this._pPMDSTOF03Combo)
				{
					_pPMDSTOF03Combo = value;
					NotifyChanged("PPMDSTOF03Combo");
				}
			}
		}
		public String PPMDSTOF04Combo
		{
			get { return _pPMDSTOF04Combo; }
			set
			{
				if (value != this._pPMDSTOF04Combo)
				{
					_pPMDSTOF04Combo = value;
					NotifyChanged("PPMDSTOF04Combo");
				}
			}
		}
		public String PPMDSTOF05Combo
		{
			get { return _pPMDSTOF05Combo; }
			set
			{
				if (value != this._pPMDSTOF05Combo)
				{
					_pPMDSTOF05Combo = value;
					NotifyChanged("PPMDSTOF05Combo");
				}
			}
		}
		public String PPMDSTOF06Combo
		{
			get { return _pPMDSTOF06Combo; }
			set
			{
				if (value != this._pPMDSTOF06Combo)
				{
					_pPMDSTOF06Combo = value;
					NotifyChanged("PPMDSTOF06Combo");
				}
			}
		}
		public String PPMDSTOF07Combo
		{
			get { return _pPMDSTOF07Combo; }
			set
			{
				if (value != this._pPMDSTOF07Combo)
				{
					_pPMDSTOF07Combo = value;
					NotifyChanged("PPMDSTOF07Combo");
				}
			}
		}
		public String PPMDSTOF08Combo
		{
			get { return _pPMDSTOF08Combo; }
			set
			{
				if (value != this._pPMDSTOF08Combo)
				{
					_pPMDSTOF08Combo = value;
					NotifyChanged("PPMDSTOF08Combo");
				}
			}
		}
		public String PPMDSTOF09Combo
		{
			get { return _pPMDSTOF09Combo; }
			set
			{
				if (value != this._pPMDSTOF09Combo)
				{
					_pPMDSTOF09Combo = value;
					NotifyChanged("PPMDSTOF09Combo");
				}
			}
		}
		public String PPMDSTOF10Combo
		{
			get { return _pPMDSTOF10Combo; }
			set
			{
				if (value != this._pPMDSTOF10Combo)
				{
					_pPMDSTOF10Combo = value;
					NotifyChanged("PPMDSTOF10Combo");
				}
			}
		}
		public String PPMDSTimeTypeCombo
		{
			get { return _pPMDSTimeTypeCombo; }
			set
			{
				if (value != this._pPMDSTimeTypeCombo)
				{
					_pPMDSTimeTypeCombo = value;
					NotifyChanged("PPMDSTimeTypeCombo");
				}
			}
		}
		public String PPMDSViewTypeCombo
		{
			get { return _pPMDSViewTypeCombo; }
			set
			{
				if (value != this._pPMDSViewTypeCombo)
				{
					_pPMDSViewTypeCombo = value;
					NotifyChanged("PPMDSViewTypeCombo");
				}
			}
		}
		public bool PPMDSIsShowDiffCheck
		{
			get { return _pPMDSIsShowDiffCheck; }
			set
			{
				if (value != this._pPMDSIsShowDiffCheck)
				{
					_pPMDSIsShowDiffCheck = value;
					NotifyChanged("PPMDSIsShowDiffCheck");
				}
			}
		}
		public int PPMDSPeriod
		{
			get { return _pPMDSPeriod; }
			set
			{
				if (value != this._pPMDSPeriod)
				{
					_pPMDSPeriod = value;
					NotifyChanged("PPMDSPeriod");
				}
			}
		}
		public int PPMDSYear
		{
			get { return _pPMDSYear; }
			set
			{
				if (value != this._pPMDSYear)
				{
					_pPMDSYear = value;
					NotifyChanged("PPMDSYear");
				}
			}
		}
		
        #endregion
    }
    #endregion
}