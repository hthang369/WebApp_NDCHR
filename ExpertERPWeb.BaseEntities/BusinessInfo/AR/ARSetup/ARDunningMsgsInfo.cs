using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARDunningMsgs
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARDunningMsgsInfo
	//Created Date:Tuesday, April 24, 2012
	//-----------------------------------------------------------
	
	public class ARDunningMsgsInfo:BusinessObject
	{
		public ARDunningMsgsInfo()
		{
		}
		#region Variables
		protected int _aRDunningMsgID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aRDunningMsgNo=String.Empty;
		protected String _aRDunningMsgCurrent=String.Empty;
		protected String _aRDunningMsg1To30=String.Empty;
		protected String _aRDunningMsg30To60=String.Empty;
		protected String _aRDunningMsg60To90=String.Empty;
		protected String _aRDunningMsgOver90=String.Empty;
		#endregion

		#region Public properties
		public int ARDunningMsgID
		{
			get{return _aRDunningMsgID;}
			set
			{
				if (value != this._aRDunningMsgID)
				{
				_aRDunningMsgID=value;
				NotifyChanged("ARDunningMsgID");
				}
			}
		}
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		public String ARDunningMsgNo
		{
			get{return _aRDunningMsgNo;}
			set
			{
				if (value != this._aRDunningMsgNo)
				{
				_aRDunningMsgNo=value;
				NotifyChanged("ARDunningMsgNo");
				}
			}
		}
		public String ARDunningMsgCurrent
		{
			get{return _aRDunningMsgCurrent;}
			set
			{
				if (value != this._aRDunningMsgCurrent)
				{
				_aRDunningMsgCurrent=value;
				NotifyChanged("ARDunningMsgCurrent");
				}
			}
		}
		public String ARDunningMsg1To30
		{
			get{return _aRDunningMsg1To30;}
			set
			{
				if (value != this._aRDunningMsg1To30)
				{
				_aRDunningMsg1To30=value;
				NotifyChanged("ARDunningMsg1To30");
				}
			}
		}
		public String ARDunningMsg30To60
		{
			get{return _aRDunningMsg30To60;}
			set
			{
				if (value != this._aRDunningMsg30To60)
				{
				_aRDunningMsg30To60=value;
				NotifyChanged("ARDunningMsg30To60");
				}
			}
		}
		public String ARDunningMsg60To90
		{
			get{return _aRDunningMsg60To90;}
			set
			{
				if (value != this._aRDunningMsg60To90)
				{
				_aRDunningMsg60To90=value;
				NotifyChanged("ARDunningMsg60To90");
				}
			}
		}
		public String ARDunningMsgOver90
		{
			get{return _aRDunningMsgOver90;}
			set
			{
				if (value != this._aRDunningMsgOver90)
				{
				_aRDunningMsgOver90=value;
				NotifyChanged("ARDunningMsgOver90");
				}
			}
		}
		#endregion
	}
	#endregion
}