using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLVoucherExs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLVoucherExsInfo
	//Created Date:Tuesday, June 10, 2014
	//-----------------------------------------------------------
	
	public class GLVoucherExsInfo:BusinessObject
	{
		public GLVoucherExsInfo()
		{
		}
		#region Variables
		protected int _gLVoucherExID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_BRBranchID;
		protected String _gLVoucherExNo=String.Empty;
		protected String _gLVoucherExName=String.Empty;
		protected String _gLVoucherExDesc=String.Empty;
		protected DateTime _gLVoucherExDate=DateTime.Now;
		protected int _fK_GECurrencyID;
		protected int _fK_HREmployeeID;
		protected bool _aASelected=true;
		protected double _gLVoucherExExcRate;
		protected double _gLVoucherExFAmtTot;
		protected double _gLVoucherExDebitAmtTot;
		protected double _gLVoucherExCreditAmtTot;
		protected double _gLVoucherExDebitFAmtTot;
		protected double _gLVoucherExCreditFAmtTot;
		#endregion

		#region Public properties
		public int GLVoucherExID
		{
			get{return _gLVoucherExID;}
			set
			{
				if (value != this._gLVoucherExID)
				{
				_gLVoucherExID=value;
				NotifyChanged("GLVoucherExID");
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
		public int FK_BRBranchID
		{
			get{return _fK_BRBranchID;}
			set
			{
				if (value != this._fK_BRBranchID)
				{
				_fK_BRBranchID=value;
				NotifyChanged("FK_BRBranchID");
				}
			}
		}
		public String GLVoucherExNo
		{
			get{return _gLVoucherExNo;}
			set
			{
				if (value != this._gLVoucherExNo)
				{
				_gLVoucherExNo=value;
				NotifyChanged("GLVoucherExNo");
				}
			}
		}
		public String GLVoucherExName
		{
			get{return _gLVoucherExName;}
			set
			{
				if (value != this._gLVoucherExName)
				{
				_gLVoucherExName=value;
				NotifyChanged("GLVoucherExName");
				}
			}
		}
		public String GLVoucherExDesc
		{
			get{return _gLVoucherExDesc;}
			set
			{
				if (value != this._gLVoucherExDesc)
				{
				_gLVoucherExDesc=value;
				NotifyChanged("GLVoucherExDesc");
				}
			}
		}
		public DateTime GLVoucherExDate
		{
			get{return _gLVoucherExDate;}
			set
			{
				if (value != this._gLVoucherExDate)
				{
				_gLVoucherExDate=value;
				NotifyChanged("GLVoucherExDate");
				}
			}
		}
		public int FK_GECurrencyID
		{
			get{return _fK_GECurrencyID;}
			set
			{
				if (value != this._fK_GECurrencyID)
				{
				_fK_GECurrencyID=value;
				NotifyChanged("FK_GECurrencyID");
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
		public double GLVoucherExExcRate
		{
			get{return _gLVoucherExExcRate;}
			set
			{
				if (value != this._gLVoucherExExcRate)
				{
				_gLVoucherExExcRate=value;
				NotifyChanged("GLVoucherExExcRate");
				}
			}
		}
		public double GLVoucherExFAmtTot
		{
			get{return _gLVoucherExFAmtTot;}
			set
			{
				if (value != this._gLVoucherExFAmtTot)
				{
				_gLVoucherExFAmtTot=value;
				NotifyChanged("GLVoucherExFAmtTot");
				}
			}
		}
		public double GLVoucherExDebitAmtTot
		{
			get{return _gLVoucherExDebitAmtTot;}
			set
			{
				if (value != this._gLVoucherExDebitAmtTot)
				{
				_gLVoucherExDebitAmtTot=value;
				NotifyChanged("GLVoucherExDebitAmtTot");
				}
			}
		}
		public double GLVoucherExCreditAmtTot
		{
			get{return _gLVoucherExCreditAmtTot;}
			set
			{
				if (value != this._gLVoucherExCreditAmtTot)
				{
				_gLVoucherExCreditAmtTot=value;
				NotifyChanged("GLVoucherExCreditAmtTot");
				}
			}
		}
		public double GLVoucherExDebitFAmtTot
		{
			get{return _gLVoucherExDebitFAmtTot;}
			set
			{
				if (value != this._gLVoucherExDebitFAmtTot)
				{
				_gLVoucherExDebitFAmtTot=value;
				NotifyChanged("GLVoucherExDebitFAmtTot");
				}
			}
		}
		public double GLVoucherExCreditFAmtTot
		{
			get{return _gLVoucherExCreditFAmtTot;}
			set
			{
				if (value != this._gLVoucherExCreditFAmtTot)
				{
				_gLVoucherExCreditFAmtTot=value;
				NotifyChanged("GLVoucherExCreditFAmtTot");
				}
			}
		}
		#endregion
	}
	#endregion
}