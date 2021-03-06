using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLPeriodEquipmentAllocates
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class: GLPeriodEquipmentAllocatesInfo
    //Created Date: 11 Mar 2015
    //-----------------------------------------------------------

    public class GLPeriodEquipmentAllocatesInfo : BusinessObject
    {
        public GLPeriodEquipmentAllocatesInfo()
        {
        }
        #region Variables
		protected int _gLPeriodEquipmentAllocateID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aAPostStatus=DefaultStatus;
		protected String _aALastPostNo=String.Empty;
		protected Nullable<DateTime> _aALastPostDate;
		protected String _approvalStatusCombo=DefaultStatus;
		protected String _gLPeriodEquipmentAllocateNo=String.Empty;
		protected String _gLPeriodEquipmentAllocateName=String.Empty;
		protected String _gLPeriodEquipmentAllocateDesc=String.Empty;
		protected int _gLPeriodEquipmentAllocatePeriod;
		protected int _gLPeriodEquipmentAllocateYear;
		protected Nullable<DateTime> _gLPeriodEquipmentAllocateDate;
		protected Nullable<DateTime> _gLPeriodEquipmentAllocateJrnDate;
		
        #endregion

        #region Public properties
		public int GLPeriodEquipmentAllocateID
		{
			get{return _gLPeriodEquipmentAllocateID;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocateID)
				{
					_gLPeriodEquipmentAllocateID=value;
					NotifyChanged("GLPeriodEquipmentAllocateID");
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
		public String AAPostStatus
		{
			get{return _aAPostStatus;}
			set
			{
				if (value != this._aAPostStatus)
				{
					_aAPostStatus=value;
					NotifyChanged("AAPostStatus");
				}
			}
		}
		public String AALastPostNo
		{
			get{return _aALastPostNo;}
			set
			{
				if (value != this._aALastPostNo)
				{
					_aALastPostNo=value;
					NotifyChanged("AALastPostNo");
				}
			}
		}
		public Nullable<DateTime> AALastPostDate
		{
			get{return _aALastPostDate;}
			set
			{
				if (value != this._aALastPostDate)
				{
					_aALastPostDate=value;
					NotifyChanged("AALastPostDate");
				}
			}
		}
		public String ApprovalStatusCombo
		{
			get{return _approvalStatusCombo;}
			set
			{
				if (value != this._approvalStatusCombo)
				{
					_approvalStatusCombo=value;
					NotifyChanged("ApprovalStatusCombo");
				}
			}
		}
		public String GLPeriodEquipmentAllocateNo
		{
			get{return _gLPeriodEquipmentAllocateNo;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocateNo)
				{
					_gLPeriodEquipmentAllocateNo=value;
					NotifyChanged("GLPeriodEquipmentAllocateNo");
				}
			}
		}
		public String GLPeriodEquipmentAllocateName
		{
			get{return _gLPeriodEquipmentAllocateName;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocateName)
				{
					_gLPeriodEquipmentAllocateName=value;
					NotifyChanged("GLPeriodEquipmentAllocateName");
				}
			}
		}
		public String GLPeriodEquipmentAllocateDesc
		{
			get{return _gLPeriodEquipmentAllocateDesc;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocateDesc)
				{
					_gLPeriodEquipmentAllocateDesc=value;
					NotifyChanged("GLPeriodEquipmentAllocateDesc");
				}
			}
		}
		public int GLPeriodEquipmentAllocatePeriod
		{
			get{return _gLPeriodEquipmentAllocatePeriod;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocatePeriod)
				{
					_gLPeriodEquipmentAllocatePeriod=value;
					NotifyChanged("GLPeriodEquipmentAllocatePeriod");
				}
			}
		}
		public int GLPeriodEquipmentAllocateYear
		{
			get{return _gLPeriodEquipmentAllocateYear;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocateYear)
				{
					_gLPeriodEquipmentAllocateYear=value;
					NotifyChanged("GLPeriodEquipmentAllocateYear");
				}
			}
		}
		public Nullable<DateTime> GLPeriodEquipmentAllocateDate
		{
			get{return _gLPeriodEquipmentAllocateDate;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocateDate)
				{
					_gLPeriodEquipmentAllocateDate=value;
					NotifyChanged("GLPeriodEquipmentAllocateDate");
				}
			}
		}
		public Nullable<DateTime> GLPeriodEquipmentAllocateJrnDate
		{
			get{return _gLPeriodEquipmentAllocateJrnDate;}
			set
			{
				if (value != this._gLPeriodEquipmentAllocateJrnDate)
				{
					_gLPeriodEquipmentAllocateJrnDate=value;
					NotifyChanged("GLPeriodEquipmentAllocateJrnDate");
				}
			}
		}
		
        #endregion
    }
    #endregion
}