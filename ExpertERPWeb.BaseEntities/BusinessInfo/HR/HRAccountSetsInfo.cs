
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRAccountSets
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.81)
    //Class: HRAccountSetsInfo
    //Created Date: Friday, 02 Dec 2016
    //-----------------------------------------------------------

    public class HRAccountSetsInfo : BusinessObject
    {
        public HRAccountSetsInfo()
        {
        }
        #region Variables
		protected int _hRAccountSetID;
		protected String _aAStatus = DefaultAAStatus;
		protected String _aACreatedUser = String.Empty;
		protected String _aAUpdatedUser = String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected bool _aASelected = true;
		protected String _hRAccountSetNo = String.Empty;
		protected String _hRAccountSetName = String.Empty;
		protected Nullable<DateTime> _hRAccountSetDate;
		protected String _hRAccountSetDesc = String.Empty;
		protected int _fK_GLAccountSalaryID;
		protected int _fK_GLAccountOverTimeID;
		protected int _fK_GLAccountOffWorkAnnualID;
		protected int _fK_GLAccountAllowanceBonusYearID;
		protected int _fK_GLAccountAllowanceBonusID;
		protected int _fK_GLAccountShiftRiceID;
		protected int _fK_GLAccountShiftRiceOvertimeID;
		protected int _fK_GLAccountInsuranceID;
		protected int _fK_GLAccountDeductUniformID;
		protected String _aAOrgDocNo = String.Empty;
		protected int _fK_GLCostCenterID;
		protected int _fK_GLCostDistID;
		protected int _fK_PPCostCenterID;
		
        #endregion

        #region Public properties
		public int HRAccountSetID
		{
			get { return _hRAccountSetID; }
			set
			{
				if (value != this._hRAccountSetID)
				{
					_hRAccountSetID = value;
					NotifyChanged("HRAccountSetID");
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
		public String HRAccountSetNo
		{
			get { return _hRAccountSetNo; }
			set
			{
				if (value != this._hRAccountSetNo)
				{
					_hRAccountSetNo = value;
					NotifyChanged("HRAccountSetNo");
				}
			}
		}
		public String HRAccountSetName
		{
			get { return _hRAccountSetName; }
			set
			{
				if (value != this._hRAccountSetName)
				{
					_hRAccountSetName = value;
					NotifyChanged("HRAccountSetName");
				}
			}
		}
		public Nullable<DateTime> HRAccountSetDate
		{
			get { return _hRAccountSetDate; }
			set
			{
				if (value != this._hRAccountSetDate)
				{
					_hRAccountSetDate = value;
					NotifyChanged("HRAccountSetDate");
				}
			}
		}
		public String HRAccountSetDesc
		{
			get { return _hRAccountSetDesc; }
			set
			{
				if (value != this._hRAccountSetDesc)
				{
					_hRAccountSetDesc = value;
					NotifyChanged("HRAccountSetDesc");
				}
			}
		}
		public int FK_GLAccountSalaryID
		{
			get { return _fK_GLAccountSalaryID; }
			set
			{
				if (value != this._fK_GLAccountSalaryID)
				{
					_fK_GLAccountSalaryID = value;
					NotifyChanged("FK_GLAccountSalaryID");
				}
			}
		}
		public int FK_GLAccountOverTimeID
		{
			get { return _fK_GLAccountOverTimeID; }
			set
			{
				if (value != this._fK_GLAccountOverTimeID)
				{
					_fK_GLAccountOverTimeID = value;
					NotifyChanged("FK_GLAccountOverTimeID");
				}
			}
		}
		public int FK_GLAccountOffWorkAnnualID
		{
			get { return _fK_GLAccountOffWorkAnnualID; }
			set
			{
				if (value != this._fK_GLAccountOffWorkAnnualID)
				{
					_fK_GLAccountOffWorkAnnualID = value;
					NotifyChanged("FK_GLAccountOffWorkAnnualID");
				}
			}
		}
		public int FK_GLAccountAllowanceBonusYearID
		{
			get { return _fK_GLAccountAllowanceBonusYearID; }
			set
			{
				if (value != this._fK_GLAccountAllowanceBonusYearID)
				{
					_fK_GLAccountAllowanceBonusYearID = value;
					NotifyChanged("FK_GLAccountAllowanceBonusYearID");
				}
			}
		}
		public int FK_GLAccountAllowanceBonusID
		{
			get { return _fK_GLAccountAllowanceBonusID; }
			set
			{
				if (value != this._fK_GLAccountAllowanceBonusID)
				{
					_fK_GLAccountAllowanceBonusID = value;
					NotifyChanged("FK_GLAccountAllowanceBonusID");
				}
			}
		}
		public int FK_GLAccountShiftRiceID
		{
			get { return _fK_GLAccountShiftRiceID; }
			set
			{
				if (value != this._fK_GLAccountShiftRiceID)
				{
					_fK_GLAccountShiftRiceID = value;
					NotifyChanged("FK_GLAccountShiftRiceID");
				}
			}
		}
		public int FK_GLAccountShiftRiceOvertimeID
		{
			get { return _fK_GLAccountShiftRiceOvertimeID; }
			set
			{
				if (value != this._fK_GLAccountShiftRiceOvertimeID)
				{
					_fK_GLAccountShiftRiceOvertimeID = value;
					NotifyChanged("FK_GLAccountShiftRiceOvertimeID");
				}
			}
		}
		public int FK_GLAccountInsuranceID
		{
			get { return _fK_GLAccountInsuranceID; }
			set
			{
				if (value != this._fK_GLAccountInsuranceID)
				{
					_fK_GLAccountInsuranceID = value;
					NotifyChanged("FK_GLAccountInsuranceID");
				}
			}
		}
		public int FK_GLAccountDeductUniformID
		{
			get { return _fK_GLAccountDeductUniformID; }
			set
			{
				if (value != this._fK_GLAccountDeductUniformID)
				{
					_fK_GLAccountDeductUniformID = value;
					NotifyChanged("FK_GLAccountDeductUniformID");
				}
			}
		}
		public String AAOrgDocNo
		{
			get { return _aAOrgDocNo; }
			set
			{
				if (value != this._aAOrgDocNo)
				{
					_aAOrgDocNo = value;
					NotifyChanged("AAOrgDocNo");
				}
			}
		}
		public int FK_GLCostCenterID
		{
			get { return _fK_GLCostCenterID; }
			set
			{
				if (value != this._fK_GLCostCenterID)
				{
					_fK_GLCostCenterID = value;
					NotifyChanged("FK_GLCostCenterID");
				}
			}
		}
		public int FK_GLCostDistID
		{
			get { return _fK_GLCostDistID; }
			set
			{
				if (value != this._fK_GLCostDistID)
				{
					_fK_GLCostDistID = value;
					NotifyChanged("FK_GLCostDistID");
				}
			}
		}
		public int FK_PPCostCenterID
		{
			get { return _fK_PPCostCenterID; }
			set
			{
				if (value != this._fK_PPCostCenterID)
				{
					_fK_PPCostCenterID = value;
					NotifyChanged("FK_PPCostCenterID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}