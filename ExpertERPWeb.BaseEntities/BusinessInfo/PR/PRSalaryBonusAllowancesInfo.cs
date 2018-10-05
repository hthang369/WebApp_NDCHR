using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PRSalaryBonusAllowances
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:PRSalaryBonusAllowancesInfo
	//Created Date:Wednesday, August 13, 2014
	//-----------------------------------------------------------
	
	public class PRSalaryBonusAllowancesInfo:BusinessObject
	{
		public PRSalaryBonusAllowancesInfo()
		{
		}
		#region Variables
		protected int _pRSalaryBonusAllowanceID;
		protected bool _aASelected=true;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected int _fK_HREmployeeID;
		protected Nullable<DateTime> _pRSalaryBonusAllowanceFromDate;
		protected Nullable<DateTime> _pRSalaryBonusAllowanceToDate;
		protected int _fK_HRPayrollTypeID;
		protected String _hRPayrollTypeName=String.Empty;
		protected String _hRPayrollTypeAttributeCombo=String.Empty;
		protected String _hRPayrollTypeTaxableCombo=String.Empty;
		protected int _fK_HRBonusAllowanceID;
		protected String _hRBonusAllowanceNo=String.Empty;
		protected String _hRBonusAllowanceName=String.Empty;
		protected double _pRSalaryBonusAllowanceAmt;
		#endregion

		#region Public properties
		public int PRSalaryBonusAllowanceID
		{
			get{return _pRSalaryBonusAllowanceID;}
			set
			{
				if (value != this._pRSalaryBonusAllowanceID)
				{
				_pRSalaryBonusAllowanceID=value;
				NotifyChanged("PRSalaryBonusAllowanceID");
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
		public Nullable<DateTime> PRSalaryBonusAllowanceFromDate
		{
			get{return _pRSalaryBonusAllowanceFromDate;}
			set
			{
				if (value != this._pRSalaryBonusAllowanceFromDate)
				{
				_pRSalaryBonusAllowanceFromDate=value;
				NotifyChanged("PRSalaryBonusAllowanceFromDate");
				}
			}
		}
		public Nullable<DateTime> PRSalaryBonusAllowanceToDate
		{
			get{return _pRSalaryBonusAllowanceToDate;}
			set
			{
				if (value != this._pRSalaryBonusAllowanceToDate)
				{
				_pRSalaryBonusAllowanceToDate=value;
				NotifyChanged("PRSalaryBonusAllowanceToDate");
				}
			}
		}
		public int FK_HRPayrollTypeID
		{
			get{return _fK_HRPayrollTypeID;}
			set
			{
				if (value != this._fK_HRPayrollTypeID)
				{
				_fK_HRPayrollTypeID=value;
				NotifyChanged("FK_HRPayrollTypeID");
				}
			}
		}
		public String HRPayrollTypeName
		{
			get{return _hRPayrollTypeName;}
			set
			{
				if (value != this._hRPayrollTypeName)
				{
				_hRPayrollTypeName=value;
				NotifyChanged("HRPayrollTypeName");
				}
			}
		}
		public String HRPayrollTypeAttributeCombo
		{
			get{return _hRPayrollTypeAttributeCombo;}
			set
			{
				if (value != this._hRPayrollTypeAttributeCombo)
				{
				_hRPayrollTypeAttributeCombo=value;
				NotifyChanged("HRPayrollTypeAttributeCombo");
				}
			}
		}
		public String HRPayrollTypeTaxableCombo
		{
			get{return _hRPayrollTypeTaxableCombo;}
			set
			{
				if (value != this._hRPayrollTypeTaxableCombo)
				{
				_hRPayrollTypeTaxableCombo=value;
				NotifyChanged("HRPayrollTypeTaxableCombo");
				}
			}
		}
		public int FK_HRBonusAllowanceID
		{
			get{return _fK_HRBonusAllowanceID;}
			set
			{
				if (value != this._fK_HRBonusAllowanceID)
				{
				_fK_HRBonusAllowanceID=value;
				NotifyChanged("FK_HRBonusAllowanceID");
				}
			}
		}
		public String HRBonusAllowanceNo
		{
			get{return _hRBonusAllowanceNo;}
			set
			{
				if (value != this._hRBonusAllowanceNo)
				{
				_hRBonusAllowanceNo=value;
				NotifyChanged("HRBonusAllowanceNo");
				}
			}
		}
		public String HRBonusAllowanceName
		{
			get{return _hRBonusAllowanceName;}
			set
			{
				if (value != this._hRBonusAllowanceName)
				{
				_hRBonusAllowanceName=value;
				NotifyChanged("HRBonusAllowanceName");
				}
			}
		}
		public double PRSalaryBonusAllowanceAmt
		{
			get{return _pRSalaryBonusAllowanceAmt;}
			set
			{
				if (value != this._pRSalaryBonusAllowanceAmt)
				{
				_pRSalaryBonusAllowanceAmt=value;
				NotifyChanged("PRSalaryBonusAllowanceAmt");
				}
			}
		}
		#endregion
	}
	#endregion
}