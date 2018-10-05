using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLBudgetScnItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLBudgetScnItemsInfo
	//Created Date:21 Tháng Tám 2012
	//-----------------------------------------------------------
	
	public class GLBudgetScnItemsInfo:BusinessObject
	{
		public GLBudgetScnItemsInfo()
		{
		}
		#region Variables
		protected int _gLBudgetScnItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected double _gLBudgetScnItemEstAmtTot;
		protected double _gLBudgetScnItemEstAppAmtTot;
		protected double _gLBudgetScnItemActAmtTot;
		protected double _gLBudgetScnItemActAppAmtTot;
		protected double _gLBudgetScnItemDiffAmt;
		protected double _gLBudgetScnItemDiffPct;
		protected int _fK_GLAccountID;
		protected int _fK_GLBudgetScnID;
		#endregion

		#region Public properties
		public int GLBudgetScnItemID
		{
			get{return _gLBudgetScnItemID;}
			set
			{
				if (value != this._gLBudgetScnItemID)
				{
				_gLBudgetScnItemID=value;
				NotifyChanged("GLBudgetScnItemID");
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
		public double GLBudgetScnItemEstAmtTot
		{
			get{return _gLBudgetScnItemEstAmtTot;}
			set
			{
				if (value != this._gLBudgetScnItemEstAmtTot)
				{
				_gLBudgetScnItemEstAmtTot=value;
				NotifyChanged("GLBudgetScnItemEstAmtTot");
				}
			}
		}
		public double GLBudgetScnItemEstAppAmtTot
		{
			get{return _gLBudgetScnItemEstAppAmtTot;}
			set
			{
				if (value != this._gLBudgetScnItemEstAppAmtTot)
				{
				_gLBudgetScnItemEstAppAmtTot=value;
				NotifyChanged("GLBudgetScnItemEstAppAmtTot");
				}
			}
		}
		public double GLBudgetScnItemActAmtTot
		{
			get{return _gLBudgetScnItemActAmtTot;}
			set
			{
				if (value != this._gLBudgetScnItemActAmtTot)
				{
				_gLBudgetScnItemActAmtTot=value;
				NotifyChanged("GLBudgetScnItemActAmtTot");
				}
			}
		}
		public double GLBudgetScnItemActAppAmtTot
		{
			get{return _gLBudgetScnItemActAppAmtTot;}
			set
			{
				if (value != this._gLBudgetScnItemActAppAmtTot)
				{
				_gLBudgetScnItemActAppAmtTot=value;
				NotifyChanged("GLBudgetScnItemActAppAmtTot");
				}
			}
		}
		public double GLBudgetScnItemDiffAmt
		{
			get{return _gLBudgetScnItemDiffAmt;}
			set
			{
				if (value != this._gLBudgetScnItemDiffAmt)
				{
				_gLBudgetScnItemDiffAmt=value;
				NotifyChanged("GLBudgetScnItemDiffAmt");
				}
			}
		}
		public double GLBudgetScnItemDiffPct
		{
			get{return _gLBudgetScnItemDiffPct;}
			set
			{
				if (value != this._gLBudgetScnItemDiffPct)
				{
				_gLBudgetScnItemDiffPct=value;
				NotifyChanged("GLBudgetScnItemDiffPct");
				}
			}
		}
		public int FK_GLAccountID
		{
			get{return _fK_GLAccountID;}
			set
			{
				if (value != this._fK_GLAccountID)
				{
				_fK_GLAccountID=value;
				NotifyChanged("FK_GLAccountID");
				}
			}
		}
		public int FK_GLBudgetScnID
		{
			get{return _fK_GLBudgetScnID;}
			set
			{
				if (value != this._fK_GLBudgetScnID)
				{
				_fK_GLBudgetScnID=value;
				NotifyChanged("FK_GLBudgetScnID");
				}
			}
		}
		#endregion
	}
	#endregion
}