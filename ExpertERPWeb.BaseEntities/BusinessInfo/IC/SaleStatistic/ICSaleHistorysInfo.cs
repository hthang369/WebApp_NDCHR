using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICSaleHistorys
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICSaleHistorysInfo
	//Created Date:30 Tháng Bảy 2011
	//-----------------------------------------------------------
	
	public class ICSaleHistorysInfo:BusinessObject
	{
		public ICSaleHistorysInfo()
		{
		}
		#region Variables
		protected int _iCSaleHistoryID;
		protected String _iCSaleHistoryType=String.Empty;
		protected double _iCSaleHistoryValue;
		#endregion

		#region Public properties
		public int ICSaleHistoryID
		{
			get{return _iCSaleHistoryID;}
			set
			{
				if (value != this._iCSaleHistoryID)
				{
				_iCSaleHistoryID=value;
				NotifyChanged("ICSaleHistoryID");
				}
			}
		}
		public String ICSaleHistoryType
		{
			get{return _iCSaleHistoryType;}
			set
			{
				if (value != this._iCSaleHistoryType)
				{
				_iCSaleHistoryType=value;
				NotifyChanged("ICSaleHistoryType");
				}
			}
		}
		public double ICSaleHistoryValue
		{
			get{return _iCSaleHistoryValue;}
			set
			{
				if (value != this._iCSaleHistoryValue)
				{
				_iCSaleHistoryValue=value;
				NotifyChanged("ICSaleHistoryValue");
				}
			}
		}
		#endregion
	}
	#endregion
}