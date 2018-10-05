using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductPlnFeedbacks
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPProductPlnFeedbacksInfo
	//Created Date:18 Tháng Sáu 2013
	//-----------------------------------------------------------
	
	public class PPProductPlnFeedbacksInfo:BusinessObject
	{
		public PPProductPlnFeedbacksInfo()
		{
		}
		#region Variables
		protected int _pPProductPlnFeedbackID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_PPPhaseCfgID;
		protected int _fK_PPProductPlnItemID;
		protected double _pPProductPlnFeedbackTotalFinishQty;
		protected double _pPProductPlnFeedbackTotalerrorQty;
		protected double _pPProductPlnFeedbackRuntime;
		protected double _pPProductPlnFeedbackProcessQty;
		protected String _pPProductPlnFeedbackPerformanceStatusCombo=DefaultStatus;
		protected String _pPProductPlnFeedbackReportedFinishCombo=String.Empty;
		protected int _fK_PPProductPlnID;
		#endregion

		#region Public properties
		public int PPProductPlnFeedbackID
		{
			get{return _pPProductPlnFeedbackID;}
			set
			{
				if (value != this._pPProductPlnFeedbackID)
				{
				_pPProductPlnFeedbackID=value;
				NotifyChanged("PPProductPlnFeedbackID");
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
		public int FK_PPPhaseCfgID
		{
			get{return _fK_PPPhaseCfgID;}
			set
			{
				if (value != this._fK_PPPhaseCfgID)
				{
				_fK_PPPhaseCfgID=value;
				NotifyChanged("FK_PPPhaseCfgID");
				}
			}
		}
		public int FK_PPProductPlnItemID
		{
			get{return _fK_PPProductPlnItemID;}
			set
			{
				if (value != this._fK_PPProductPlnItemID)
				{
				_fK_PPProductPlnItemID=value;
				NotifyChanged("FK_PPProductPlnItemID");
				}
			}
		}
		public double PPProductPlnFeedbackTotalFinishQty
		{
			get{return _pPProductPlnFeedbackTotalFinishQty;}
			set
			{
				if (value != this._pPProductPlnFeedbackTotalFinishQty)
				{
				_pPProductPlnFeedbackTotalFinishQty=value;
				NotifyChanged("PPProductPlnFeedbackTotalFinishQty");
				}
			}
		}
		public double PPProductPlnFeedbackTotalerrorQty
		{
			get{return _pPProductPlnFeedbackTotalerrorQty;}
			set
			{
				if (value != this._pPProductPlnFeedbackTotalerrorQty)
				{
				_pPProductPlnFeedbackTotalerrorQty=value;
				NotifyChanged("PPProductPlnFeedbackTotalerrorQty");
				}
			}
		}
		public double PPProductPlnFeedbackRuntime
		{
			get{return _pPProductPlnFeedbackRuntime;}
			set
			{
				if (value != this._pPProductPlnFeedbackRuntime)
				{
				_pPProductPlnFeedbackRuntime=value;
				NotifyChanged("PPProductPlnFeedbackRuntime");
				}
			}
		}
		public double PPProductPlnFeedbackProcessQty
		{
			get{return _pPProductPlnFeedbackProcessQty;}
			set
			{
				if (value != this._pPProductPlnFeedbackProcessQty)
				{
				_pPProductPlnFeedbackProcessQty=value;
				NotifyChanged("PPProductPlnFeedbackProcessQty");
				}
			}
		}
		public String PPProductPlnFeedbackPerformanceStatusCombo
		{
			get{return _pPProductPlnFeedbackPerformanceStatusCombo;}
			set
			{
				if (value != this._pPProductPlnFeedbackPerformanceStatusCombo)
				{
				_pPProductPlnFeedbackPerformanceStatusCombo=value;
				NotifyChanged("PPProductPlnFeedbackPerformanceStatusCombo");
				}
			}
		}
		public String PPProductPlnFeedbackReportedFinishCombo
		{
			get{return _pPProductPlnFeedbackReportedFinishCombo;}
			set
			{
				if (value != this._pPProductPlnFeedbackReportedFinishCombo)
				{
				_pPProductPlnFeedbackReportedFinishCombo=value;
				NotifyChanged("PPProductPlnFeedbackReportedFinishCombo");
				}
			}
		}
		public int FK_PPProductPlnID
		{
			get{return _fK_PPProductPlnID;}
			set
			{
				if (value != this._fK_PPProductPlnID)
				{
				_fK_PPProductPlnID=value;
				NotifyChanged("FK_PPProductPlnID");
				}
			}
		}
		#endregion
	}
	#endregion
}