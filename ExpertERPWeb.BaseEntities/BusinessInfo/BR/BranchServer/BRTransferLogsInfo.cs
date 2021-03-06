using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region BRTransferLogs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:BRTransferLogsInfo
	//Created Date:Monday, June 16, 2008
	//-----------------------------------------------------------
	
	public class BRTransferLogsInfo:BusinessObject
	{
		public BRTransferLogsInfo()
		{
		}
		#region Variables
		protected int _bRTransferLogID;
		protected String _aANumberString=String.Empty;
		protected int _aANumberInt;
		protected String _aAStatus=DefaultAAStatus;
		protected String _bRTransferLogNo=String.Empty;
		protected String _bRTransferLogName=String.Empty;
		protected String _bRTransferLogDesc=String.Empty;
		protected String _bRBranchServerName=String.Empty;
		protected String _bRBranchTransferLog=String.Empty;
		#endregion

		#region Public properties
		public int BRTransferLogID
		{
			get{return _bRTransferLogID;}
			set
			{
				if (value != this._bRTransferLogID)
				{
				_bRTransferLogID=value;
				NotifyChanged("BRTransferLogID");
				}
			}
		}
		public String AANumberString
		{
			get{return _aANumberString;}
			set
			{
				if (value != this._aANumberString)
				{
				_aANumberString=value;
				NotifyChanged("AANumberString");
				}
			}
		}
		public int AANumberInt
		{
			get{return _aANumberInt;}
			set
			{
				if (value != this._aANumberInt)
				{
				_aANumberInt=value;
				NotifyChanged("AANumberInt");
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
		public String BRTransferLogNo
		{
			get{return _bRTransferLogNo;}
			set
			{
				if (value != this._bRTransferLogNo)
				{
				_bRTransferLogNo=value;
				NotifyChanged("BRTransferLogNo");
				}
			}
		}
		public String BRTransferLogName
		{
			get{return _bRTransferLogName;}
			set
			{
				if (value != this._bRTransferLogName)
				{
				_bRTransferLogName=value;
				NotifyChanged("BRTransferLogName");
				}
			}
		}
		public String BRTransferLogDesc
		{
			get{return _bRTransferLogDesc;}
			set
			{
				if (value != this._bRTransferLogDesc)
				{
				_bRTransferLogDesc=value;
				NotifyChanged("BRTransferLogDesc");
				}
			}
		}
		public String BRBranchServerName
		{
			get{return _bRBranchServerName;}
			set
			{
				if (value != this._bRBranchServerName)
				{
				_bRBranchServerName=value;
				NotifyChanged("BRBranchServerName");
				}
			}
		}
		public String BRBranchTransferLog
		{
			get{return _bRBranchTransferLog;}
			set
			{
				if (value != this._bRBranchTransferLog)
				{
				_bRBranchTransferLog=value;
				NotifyChanged("BRBranchTransferLog");
				}
			}
		}
		#endregion
	}
	#endregion
}