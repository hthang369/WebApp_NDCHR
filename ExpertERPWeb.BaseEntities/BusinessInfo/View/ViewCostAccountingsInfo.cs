using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ViewCostAccountings
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ViewCostAccountingsInfo
	//Created Date:23 Tháng Năm 2014
	//-----------------------------------------------------------
	
	public class ViewCostAccountingsInfo:BusinessObject
	{
		public ViewCostAccountingsInfo()
		{
		}
		#region Variables
		protected int _viewCostAccountingID;
		protected int _fK_GLAccountID;
		protected String _gLAccountNo=String.Empty;
		protected String _gLAccountName=String.Empty;
		protected int _fK_GLCostCenterID;
		protected String _gLCostCenterNo=String.Empty;
		protected String _gLCostCenterName=String.Empty;
		protected int _fK_GLCostDistID;
		protected String _gLCostDistNo=String.Empty;
		protected String _gLCostDistName=String.Empty;
		protected int _fK_GLCostCenterParentID;
		protected String _gLCostCenterParentNo=String.Empty;
		protected String _gLCostCenterParentName=String.Empty;
		protected Nullable<DateTime> _viewCostAccountingFromDate;
		protected Nullable<DateTime> _viewCostAccountingToDate;
		protected double _gLJournalDebitNoteAmt;
		protected double _gLJournalCreditNoteAmt;
		protected double _gLJournalAmt;
		#endregion

		#region Public properties
		public int ViewCostAccountingID
		{
			get{return _viewCostAccountingID;}
			set
			{
				if (value != this._viewCostAccountingID)
				{
				_viewCostAccountingID=value;
				NotifyChanged("ViewCostAccountingID");
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
		public String GLAccountNo
		{
			get{return _gLAccountNo;}
			set
			{
				if (value != this._gLAccountNo)
				{
				_gLAccountNo=value;
				NotifyChanged("GLAccountNo");
				}
			}
		}
		public String GLAccountName
		{
			get{return _gLAccountName;}
			set
			{
				if (value != this._gLAccountName)
				{
				_gLAccountName=value;
				NotifyChanged("GLAccountName");
				}
			}
		}
		public int FK_GLCostCenterID
		{
			get{return _fK_GLCostCenterID;}
			set
			{
				if (value != this._fK_GLCostCenterID)
				{
				_fK_GLCostCenterID=value;
				NotifyChanged("FK_GLCostCenterID");
				}
			}
		}
		public String GLCostCenterNo
		{
			get{return _gLCostCenterNo;}
			set
			{
				if (value != this._gLCostCenterNo)
				{
				_gLCostCenterNo=value;
				NotifyChanged("GLCostCenterNo");
				}
			}
		}
		public String GLCostCenterName
		{
			get{return _gLCostCenterName;}
			set
			{
				if (value != this._gLCostCenterName)
				{
				_gLCostCenterName=value;
				NotifyChanged("GLCostCenterName");
				}
			}
		}
		public int FK_GLCostDistID
		{
			get{return _fK_GLCostDistID;}
			set
			{
				if (value != this._fK_GLCostDistID)
				{
				_fK_GLCostDistID=value;
				NotifyChanged("FK_GLCostDistID");
				}
			}
		}
		public String GLCostDistNo
		{
			get{return _gLCostDistNo;}
			set
			{
				if (value != this._gLCostDistNo)
				{
				_gLCostDistNo=value;
				NotifyChanged("GLCostDistNo");
				}
			}
		}
		public String GLCostDistName
		{
			get{return _gLCostDistName;}
			set
			{
				if (value != this._gLCostDistName)
				{
				_gLCostDistName=value;
				NotifyChanged("GLCostDistName");
				}
			}
		}
		public int FK_GLCostCenterParentID
		{
			get{return _fK_GLCostCenterParentID;}
			set
			{
				if (value != this._fK_GLCostCenterParentID)
				{
				_fK_GLCostCenterParentID=value;
				NotifyChanged("FK_GLCostCenterParentID");
				}
			}
		}
		public String GLCostCenterParentNo
		{
			get{return _gLCostCenterParentNo;}
			set
			{
				if (value != this._gLCostCenterParentNo)
				{
				_gLCostCenterParentNo=value;
				NotifyChanged("GLCostCenterParentNo");
				}
			}
		}
		public String GLCostCenterParentName
		{
			get{return _gLCostCenterParentName;}
			set
			{
				if (value != this._gLCostCenterParentName)
				{
				_gLCostCenterParentName=value;
				NotifyChanged("GLCostCenterParentName");
				}
			}
		}
		public Nullable<DateTime> ViewCostAccountingFromDate
		{
			get{return _viewCostAccountingFromDate;}
			set
			{
				if (value != this._viewCostAccountingFromDate)
				{
				_viewCostAccountingFromDate=value;
				NotifyChanged("ViewCostAccountingFromDate");
				}
			}
		}
		public Nullable<DateTime> ViewCostAccountingToDate
		{
			get{return _viewCostAccountingToDate;}
			set
			{
				if (value != this._viewCostAccountingToDate)
				{
				_viewCostAccountingToDate=value;
				NotifyChanged("ViewCostAccountingToDate");
				}
			}
		}
		public double GLJournalDebitNoteAmt
		{
			get{return _gLJournalDebitNoteAmt;}
			set
			{
				if (value != this._gLJournalDebitNoteAmt)
				{
				_gLJournalDebitNoteAmt=value;
				NotifyChanged("GLJournalDebitNoteAmt");
				}
			}
		}
		public double GLJournalCreditNoteAmt
		{
			get{return _gLJournalCreditNoteAmt;}
			set
			{
				if (value != this._gLJournalCreditNoteAmt)
				{
				_gLJournalCreditNoteAmt=value;
				NotifyChanged("GLJournalCreditNoteAmt");
				}
			}
		}
		public double GLJournalAmt
		{
			get{return _gLJournalAmt;}
			set
			{
				if (value != this._gLJournalAmt)
				{
				_gLJournalAmt=value;
				NotifyChanged("GLJournalAmt");
				}
			}
		}
		#endregion
	}
	#endregion
}