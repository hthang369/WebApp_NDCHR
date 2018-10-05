using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICInventoryStatisticLogs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICInventoryStatisticLogsInfo
	//Created Date:Thursday, February 23, 2012
	//-----------------------------------------------------------
	
	public class ICInventoryStatisticLogsInfo:BusinessObject
	{
		public ICInventoryStatisticLogsInfo()
		{
		}
		#region Variables
		protected int _iCInventoryStatisticLogID;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected bool _aASelected=true;
		protected String _aAStatus=DefaultAAStatus;
		protected String _iCInventoryStatisticLogUser=String.Empty;
		protected Nullable<DateTime> _iCInventoryStatisticLogDate;
		protected int _iCInventoryStatisticLogPeriod;
		protected int _iCInventoryStatisticLogYear;
		#endregion

		#region Public properties
		public int ICInventoryStatisticLogID
		{
			get{return _iCInventoryStatisticLogID;}
			set
			{
				if (value != this._iCInventoryStatisticLogID)
				{
				_iCInventoryStatisticLogID=value;
				NotifyChanged("ICInventoryStatisticLogID");
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
		public String ICInventoryStatisticLogUser
		{
			get{return _iCInventoryStatisticLogUser;}
			set
			{
				if (value != this._iCInventoryStatisticLogUser)
				{
				_iCInventoryStatisticLogUser=value;
				NotifyChanged("ICInventoryStatisticLogUser");
				}
			}
		}
		public Nullable<DateTime> ICInventoryStatisticLogDate
		{
			get{return _iCInventoryStatisticLogDate;}
			set
			{
				if (value != this._iCInventoryStatisticLogDate)
				{
				_iCInventoryStatisticLogDate=value;
				NotifyChanged("ICInventoryStatisticLogDate");
				}
			}
		}
		public int ICInventoryStatisticLogPeriod
		{
			get{return _iCInventoryStatisticLogPeriod;}
			set
			{
				if (value != this._iCInventoryStatisticLogPeriod)
				{
				_iCInventoryStatisticLogPeriod=value;
				NotifyChanged("ICInventoryStatisticLogPeriod");
				}
			}
		}
		public int ICInventoryStatisticLogYear
		{
			get{return _iCInventoryStatisticLogYear;}
			set
			{
				if (value != this._iCInventoryStatisticLogYear)
				{
				_iCInventoryStatisticLogYear=value;
				NotifyChanged("ICInventoryStatisticLogYear");
				}
			}
		}
		#endregion
	}
	#endregion
}