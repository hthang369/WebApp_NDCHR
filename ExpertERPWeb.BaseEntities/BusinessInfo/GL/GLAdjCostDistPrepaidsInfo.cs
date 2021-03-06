using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLAdjCostDistPrepaids
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLAdjCostDistPrepaidsInfo
	//Created Date:11 July 2015
	//-----------------------------------------------------------
	
	public class GLAdjCostDistPrepaidsInfo:BusinessObject
	{
		public GLAdjCostDistPrepaidsInfo()
		{
		}
		#region Variables
		protected int _gLAdjCostDistPrepaidID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _gLAdjCostDistPrepaidNo=String.Empty;
		protected String _gLAdjCostDistPrepaidName=String.Empty;
		protected String _gLAdjCostDistPrepaidDesc=String.Empty;
		protected Nullable<DateTime> _gLAdjCostDistPrepaidDate;
		#endregion

		#region Public properties
		public int GLAdjCostDistPrepaidID
		{
			get{return _gLAdjCostDistPrepaidID;}
			set
			{
				if (value != this._gLAdjCostDistPrepaidID)
				{
				_gLAdjCostDistPrepaidID=value;
				NotifyChanged("GLAdjCostDistPrepaidID");
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
		public String GLAdjCostDistPrepaidNo
		{
			get{return _gLAdjCostDistPrepaidNo;}
			set
			{
				if (value != this._gLAdjCostDistPrepaidNo)
				{
				_gLAdjCostDistPrepaidNo=value;
				NotifyChanged("GLAdjCostDistPrepaidNo");
				}
			}
		}
		public String GLAdjCostDistPrepaidName
		{
			get{return _gLAdjCostDistPrepaidName;}
			set
			{
				if (value != this._gLAdjCostDistPrepaidName)
				{
				_gLAdjCostDistPrepaidName=value;
				NotifyChanged("GLAdjCostDistPrepaidName");
				}
			}
		}
		public String GLAdjCostDistPrepaidDesc
		{
			get{return _gLAdjCostDistPrepaidDesc;}
			set
			{
				if (value != this._gLAdjCostDistPrepaidDesc)
				{
				_gLAdjCostDistPrepaidDesc=value;
				NotifyChanged("GLAdjCostDistPrepaidDesc");
				}
			}
		}
		public Nullable<DateTime> GLAdjCostDistPrepaidDate
		{
			get{return _gLAdjCostDistPrepaidDate;}
			set
			{
				if (value != this._gLAdjCostDistPrepaidDate)
				{
				_gLAdjCostDistPrepaidDate=value;
				NotifyChanged("GLAdjCostDistPrepaidDate");
				}
			}
		}
		#endregion
	}
	#endregion
}