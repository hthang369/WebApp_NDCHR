
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLContractTypes
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.70)
    //Class: GLContractTypesInfo
    //Created Date: Thursday, 25 Aug 2016
    //-----------------------------------------------------------

    public class GLContractTypesInfo : BusinessObject
    {
        public GLContractTypesInfo()
        {
        }
        #region Variables
		protected int _gLContractTypeID;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aACreatedUser = String.Empty;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _gLContractTypeNo = String.Empty;
		protected String _gLContractTypeName = String.Empty;
		protected Nullable<DateTime> _gLContractTypeDate;
		protected String _gLContractTypeDesc = String.Empty;
		
        #endregion

        #region Public properties
		public int GLContractTypeID
		{
			get { return _gLContractTypeID; }
			set
			{
				if (value != this._gLContractTypeID)
				{
					_gLContractTypeID = value;
					NotifyChanged("GLContractTypeID");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get { return _aACreatedDate; }
			set
			{
				if (value != this._aACreatedDate)
				{
					_aACreatedDate = value;
					NotifyChanged("AACreatedDate");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get { return _aAUpdatedDate; }
			set
			{
				if (value != this._aAUpdatedDate)
				{
					_aAUpdatedDate = value;
					NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String AACreatedUser
		{
			get { return _aACreatedUser; }
			set
			{
				if (value != this._aACreatedUser)
				{
					_aACreatedUser = value;
					NotifyChanged("AACreatedUser");
				}
			}
		}
		public String AAUpdatedUser
		{
			get { return _aAUpdatedUser; }
			set
			{
				if (value != this._aAUpdatedUser)
				{
					_aAUpdatedUser = value;
					NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public String AAStatus
		{
			get { return _aAStatus; }
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus = value;
					NotifyChanged("AAStatus");
				}
			}
		}
		public bool AASelected
		{
			get { return _aASelected; }
			set
			{
				if (value != this._aASelected)
				{
					_aASelected = value;
					NotifyChanged("AASelected");
				}
			}
		}
		public String GLContractTypeNo
		{
			get { return _gLContractTypeNo; }
			set
			{
				if (value != this._gLContractTypeNo)
				{
					_gLContractTypeNo = value;
					NotifyChanged("GLContractTypeNo");
				}
			}
		}
		public String GLContractTypeName
		{
			get { return _gLContractTypeName; }
			set
			{
				if (value != this._gLContractTypeName)
				{
					_gLContractTypeName = value;
					NotifyChanged("GLContractTypeName");
				}
			}
		}
		public Nullable<DateTime> GLContractTypeDate
		{
			get { return _gLContractTypeDate; }
			set
			{
				if (value != this._gLContractTypeDate)
				{
					_gLContractTypeDate = value;
					NotifyChanged("GLContractTypeDate");
				}
			}
		}
		public String GLContractTypeDesc
		{
			get { return _gLContractTypeDesc; }
			set
			{
				if (value != this._gLContractTypeDesc)
				{
					_gLContractTypeDesc = value;
					NotifyChanged("GLContractTypeDesc");
				}
			}
		}
		
        #endregion
    }
    #endregion
}