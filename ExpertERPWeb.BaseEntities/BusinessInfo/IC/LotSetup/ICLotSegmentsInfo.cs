using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ICLotSegments
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ICLotSegmentsInfo
	//Created Date:Monday, November 10, 2014
	//-----------------------------------------------------------
	
	public class ICLotSegmentsInfo:BusinessObject
	{
		public ICLotSegmentsInfo()
		{
		}
		#region Variables
		protected int _iCLotSegmentID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected int _fK_ICLotID;
		protected String _iCLotSegmentName=String.Empty;
		protected String _iCLotSegmentDesc=String.Empty;
		protected String _iCLotSegmentTypeCombo=String.Empty;
		protected String _iCLotSegmentValue=String.Empty;
		protected String _iCLotSegmentTableName=String.Empty;
		protected String _iCLotSegmentColumnName=String.Empty;
		protected String _iCLotSegmentSeperatorCombo=String.Empty;
		protected String _iCLotSegmentFormat=String.Empty;
		protected String _iCLotSegmentRelationColumnName=String.Empty;
		protected int _iCLotSegmentSortOrder;
		#endregion

		#region Public properties
		public int ICLotSegmentID
		{
			get{return _iCLotSegmentID;}
			set
			{
				if (value != this._iCLotSegmentID)
				{
				_iCLotSegmentID=value;
				NotifyChanged("ICLotSegmentID");
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
		public int FK_ICLotID
		{
			get{return _fK_ICLotID;}
			set
			{
				if (value != this._fK_ICLotID)
				{
				_fK_ICLotID=value;
				NotifyChanged("FK_ICLotID");
				}
			}
		}
		public String ICLotSegmentName
		{
			get{return _iCLotSegmentName;}
			set
			{
				if (value != this._iCLotSegmentName)
				{
				_iCLotSegmentName=value;
				NotifyChanged("ICLotSegmentName");
				}
			}
		}
		public String ICLotSegmentDesc
		{
			get{return _iCLotSegmentDesc;}
			set
			{
				if (value != this._iCLotSegmentDesc)
				{
				_iCLotSegmentDesc=value;
				NotifyChanged("ICLotSegmentDesc");
				}
			}
		}
		public String ICLotSegmentTypeCombo
		{
			get{return _iCLotSegmentTypeCombo;}
			set
			{
				if (value != this._iCLotSegmentTypeCombo)
				{
				_iCLotSegmentTypeCombo=value;
				NotifyChanged("ICLotSegmentTypeCombo");
				}
			}
		}
		public String ICLotSegmentValue
		{
			get{return _iCLotSegmentValue;}
			set
			{
				if (value != this._iCLotSegmentValue)
				{
				_iCLotSegmentValue=value;
				NotifyChanged("ICLotSegmentValue");
				}
			}
		}
		public String ICLotSegmentTableName
		{
			get{return _iCLotSegmentTableName;}
			set
			{
				if (value != this._iCLotSegmentTableName)
				{
				_iCLotSegmentTableName=value;
				NotifyChanged("ICLotSegmentTableName");
				}
			}
		}
		public String ICLotSegmentColumnName
		{
			get{return _iCLotSegmentColumnName;}
			set
			{
				if (value != this._iCLotSegmentColumnName)
				{
				_iCLotSegmentColumnName=value;
				NotifyChanged("ICLotSegmentColumnName");
				}
			}
		}
		public String ICLotSegmentSeperatorCombo
		{
			get{return _iCLotSegmentSeperatorCombo;}
			set
			{
				if (value != this._iCLotSegmentSeperatorCombo)
				{
				_iCLotSegmentSeperatorCombo=value;
				NotifyChanged("ICLotSegmentSeperatorCombo");
				}
			}
		}
		public String ICLotSegmentFormat
		{
			get{return _iCLotSegmentFormat;}
			set
			{
				if (value != this._iCLotSegmentFormat)
				{
				_iCLotSegmentFormat=value;
				NotifyChanged("ICLotSegmentFormat");
				}
			}
		}
		public String ICLotSegmentRelationColumnName
		{
			get{return _iCLotSegmentRelationColumnName;}
			set
			{
				if (value != this._iCLotSegmentRelationColumnName)
				{
				_iCLotSegmentRelationColumnName=value;
				NotifyChanged("ICLotSegmentRelationColumnName");
				}
			}
		}
		public int ICLotSegmentSortOrder
		{
			get{return _iCLotSegmentSortOrder;}
			set
			{
				if (value != this._iCLotSegmentSortOrder)
				{
				_iCLotSegmentSortOrder=value;
				NotifyChanged("ICLotSegmentSortOrder");
				}
			}
		}
		#endregion
	}
	#endregion
}