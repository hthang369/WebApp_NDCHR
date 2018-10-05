using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLOBCostAllocates
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.23)
    //Class: GLOBCostAllocatesInfo
    //Created Date: 06 Jan 2009
    //-----------------------------------------------------------

    public class GLOBCostAllocatesInfo : BusinessObject
    {
        public GLOBCostAllocatesInfo()
        {
        }
        #region Variables
		protected int _gLOBCostAllocateID;
		protected String _gLOBCostAllocateNo=String.Empty;
		protected String _gLOBCostAllocateName=String.Empty;
		protected String _gLOBCostAllocateDesc=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected Nullable<DateTime> _gLOBCostAllocateDate;
		protected String _aAPostStatus=DefaultStatus;
		protected String _aALastPostNo=String.Empty;
		protected Nullable<DateTime> _aALastPostDate;
		protected int _fK_BRBranchID;
		protected Nullable<DateTime> _gLOBCostAllocateJrnDate;
		
        #endregion

        #region Public properties
		public int GLOBCostAllocateID
		{
			get{return _gLOBCostAllocateID;}
			set
			{
				if (value != this._gLOBCostAllocateID)
				{
					_gLOBCostAllocateID=value;
					NotifyChanged("GLOBCostAllocateID");
				}
			}
		}
		public String GLOBCostAllocateNo
		{
			get{return _gLOBCostAllocateNo;}
			set
			{
				if (value != this._gLOBCostAllocateNo)
				{
					_gLOBCostAllocateNo=value;
					NotifyChanged("GLOBCostAllocateNo");
				}
			}
		}
		public String GLOBCostAllocateName
		{
			get{return _gLOBCostAllocateName;}
			set
			{
				if (value != this._gLOBCostAllocateName)
				{
					_gLOBCostAllocateName=value;
					NotifyChanged("GLOBCostAllocateName");
				}
			}
		}
		public String GLOBCostAllocateDesc
		{
			get{return _gLOBCostAllocateDesc;}
			set
			{
				if (value != this._gLOBCostAllocateDesc)
				{
					_gLOBCostAllocateDesc=value;
					NotifyChanged("GLOBCostAllocateDesc");
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
		public Nullable<DateTime> GLOBCostAllocateDate
		{
			get{return _gLOBCostAllocateDate;}
			set
			{
				if (value != this._gLOBCostAllocateDate)
				{
					_gLOBCostAllocateDate=value;
					NotifyChanged("GLOBCostAllocateDate");
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
		public int FK_BRBranchID
		{
			get{return _fK_BRBranchID;}
			set
			{
				if (value != this._fK_BRBranchID)
				{
					_fK_BRBranchID=value;
					NotifyChanged("FK_BRBranchID");
				}
			}
		}
		public Nullable<DateTime> GLOBCostAllocateJrnDate
		{
			get{return _gLOBCostAllocateJrnDate;}
			set
			{
				if (value != this._gLOBCostAllocateJrnDate)
				{
					_gLOBCostAllocateJrnDate=value;
					NotifyChanged("GLOBCostAllocateJrnDate");
				}
			}
		}
		
        #endregion
    }
    #endregion
}