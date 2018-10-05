using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRBonusAllowances
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:HRBonusAllowancesInfo
	//Created Date:26 Tháng Chín 2013
	//-----------------------------------------------------------
	
	public class HRBonusAllowancesInfo:BusinessObject
	{
		public HRBonusAllowancesInfo()
		{
		}
		#region Variables
		protected int _hRBonusAllowanceID;
		protected bool _aASelected=true;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _hRBonusAllowanceNo=String.Empty;
		protected String _hRBonusAllowanceName=String.Empty;
		protected Nullable<DateTime> _hRBonusAllowanceDate;
		protected String _hRBonusAllowanceDesc=String.Empty;
		protected double _hRBonusAllowanceAmt;
		protected String _hRBonusAllowanceTypeCombo=String.Empty;
		protected DateTime _hRBonusAllowanceAppStartDate=DefaultDate;
		protected DateTime _hRBonusAllowanceAppEndDate=DateTime.Now;
		protected int _fK_HREmployeeID;
		protected int _fK_HRPayrollTypeID;
		protected int _hRBonusAllowanceYear;
		protected int _hRBonusAllowanceMonth;
		protected String _aAOrgDocNo=String.Empty;
		#endregion

		#region Public properties
		public int HRBonusAllowanceID
		{
			get{return _hRBonusAllowanceID;}
			set
			{
				if (value != this._hRBonusAllowanceID)
				{
				_hRBonusAllowanceID=value;
				NotifyChanged("HRBonusAllowanceID");
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
		public Nullable<DateTime> HRBonusAllowanceDate
		{
			get{return _hRBonusAllowanceDate;}
			set
			{
				if (value != this._hRBonusAllowanceDate)
				{
				_hRBonusAllowanceDate=value;
				NotifyChanged("HRBonusAllowanceDate");
				}
			}
		}
		public String HRBonusAllowanceDesc
		{
			get{return _hRBonusAllowanceDesc;}
			set
			{
				if (value != this._hRBonusAllowanceDesc)
				{
				_hRBonusAllowanceDesc=value;
				NotifyChanged("HRBonusAllowanceDesc");
				}
			}
		}
		public double HRBonusAllowanceAmt
		{
			get{return _hRBonusAllowanceAmt;}
			set
			{
				if (value != this._hRBonusAllowanceAmt)
				{
				_hRBonusAllowanceAmt=value;
				NotifyChanged("HRBonusAllowanceAmt");
				}
			}
		}
		public String HRBonusAllowanceTypeCombo
		{
			get{return _hRBonusAllowanceTypeCombo;}
			set
			{
				if (value != this._hRBonusAllowanceTypeCombo)
				{
				_hRBonusAllowanceTypeCombo=value;
				NotifyChanged("HRBonusAllowanceTypeCombo");
				}
			}
		}
		public DateTime HRBonusAllowanceAppStartDate
		{
			get{return _hRBonusAllowanceAppStartDate;}
			set
			{
				if (value != this._hRBonusAllowanceAppStartDate)
				{
				_hRBonusAllowanceAppStartDate=value;
				NotifyChanged("HRBonusAllowanceAppStartDate");
				}
			}
		}
		public DateTime HRBonusAllowanceAppEndDate
		{
			get{return _hRBonusAllowanceAppEndDate;}
			set
			{
				if (value != this._hRBonusAllowanceAppEndDate)
				{
				_hRBonusAllowanceAppEndDate=value;
				NotifyChanged("HRBonusAllowanceAppEndDate");
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
		public int HRBonusAllowanceYear
		{
			get{return _hRBonusAllowanceYear;}
			set
			{
				if (value != this._hRBonusAllowanceYear)
				{
				_hRBonusAllowanceYear=value;
				NotifyChanged("HRBonusAllowanceYear");
				}
			}
		}
		public int HRBonusAllowanceMonth
		{
			get{return _hRBonusAllowanceMonth;}
			set
			{
				if (value != this._hRBonusAllowanceMonth)
				{
				_hRBonusAllowanceMonth=value;
				NotifyChanged("HRBonusAllowanceMonth");
				}
			}
		}
		public String AAOrgDocNo
		{
			get{return _aAOrgDocNo;}
			set
			{
				if (value != this._aAOrgDocNo)
				{
				_aAOrgDocNo=value;
				NotifyChanged("AAOrgDocNo");
				}
			}
		}
		#endregion
	}
	#endregion
}