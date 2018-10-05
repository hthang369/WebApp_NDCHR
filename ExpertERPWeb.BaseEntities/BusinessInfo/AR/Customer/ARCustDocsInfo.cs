using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARCustDocs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARCustDocsInfo
	//Created Date:17 Tháng Tư 2012
	//-----------------------------------------------------------
	
	public class ARCustDocsInfo:BusinessObject
	{
		public ARCustDocsInfo()
		{
		}
		#region Variables
		protected int _aRCustDocID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aRCustDocNo=String.Empty;
		protected String _aRCustDocType=String.Empty;
		protected Nullable<DateTime> _aRCustDocDate;
		protected Nullable<DateTime> _aRCustDocDueDay;
		protected double _aRCustDocAmt;
		protected double _aRCustDocRAmt;
		protected double _aRCustDocPmtAmt;
		#endregion

		#region Public properties
		public int ARCustDocID
		{
			get{return _aRCustDocID;}
			set
			{
				if (value != this._aRCustDocID)
				{
				_aRCustDocID=value;
				NotifyChanged("ARCustDocID");
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
		public String ARCustDocNo
		{
			get{return _aRCustDocNo;}
			set
			{
				if (value != this._aRCustDocNo)
				{
				_aRCustDocNo=value;
				NotifyChanged("ARCustDocNo");
				}
			}
		}
		public String ARCustDocType
		{
			get{return _aRCustDocType;}
			set
			{
				if (value != this._aRCustDocType)
				{
				_aRCustDocType=value;
				NotifyChanged("ARCustDocType");
				}
			}
		}
		public Nullable<DateTime> ARCustDocDate
		{
			get{return _aRCustDocDate;}
			set
			{
				if (value != this._aRCustDocDate)
				{
				_aRCustDocDate=value;
				NotifyChanged("ARCustDocDate");
				}
			}
		}
		public Nullable<DateTime> ARCustDocDueDay
		{
			get{return _aRCustDocDueDay;}
			set
			{
				if (value != this._aRCustDocDueDay)
				{
				_aRCustDocDueDay=value;
				NotifyChanged("ARCustDocDueDay");
				}
			}
		}
		public double ARCustDocAmt
		{
			get{return _aRCustDocAmt;}
			set
			{
				if (value != this._aRCustDocAmt)
				{
				_aRCustDocAmt=value;
				NotifyChanged("ARCustDocAmt");
				}
			}
		}
		public double ARCustDocRAmt
		{
			get{return _aRCustDocRAmt;}
			set
			{
				if (value != this._aRCustDocRAmt)
				{
				_aRCustDocRAmt=value;
				NotifyChanged("ARCustDocRAmt");
				}
			}
		}
		public double ARCustDocPmtAmt
		{
			get{return _aRCustDocPmtAmt;}
			set
			{
				if (value != this._aRCustDocPmtAmt)
				{
				_aRCustDocPmtAmt=value;
				NotifyChanged("ARCustDocPmtAmt");
				}
			}
		}
		#endregion
	}
	#endregion
}