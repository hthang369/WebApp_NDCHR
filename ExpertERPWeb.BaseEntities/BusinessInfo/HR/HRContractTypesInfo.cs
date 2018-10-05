using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRContractTypes
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.70)
    //Class: HRContractTypesInfo
    //Created Date: Tuesday, 30 Jan 2018
    //-----------------------------------------------------------

    public class HRContractTypesInfo : BusinessObject
    {
        public HRContractTypesInfo()
        {
        }
        #region Variables
		protected int _hRContractTypeID;
		protected String _hRContractTypeNo = String.Empty;
		protected String _hRContractTypeName = String.Empty;
		protected Nullable<DateTime> _hRContractTypeDate;
		protected String _hRContractTypeDesc = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected bool _aASelected = true;
		protected bool _hRContractTypeIsMainCheck = false;
		
        #endregion

        #region Public properties
		public int HRContractTypeID
		{
			get { return _hRContractTypeID; }
			set
			{
				if (value != this._hRContractTypeID)
				{
					_hRContractTypeID = value;
					NotifyChanged("HRContractTypeID");
				}
			}
		}
		public String HRContractTypeNo
		{
			get { return _hRContractTypeNo; }
			set
			{
				if (value != this._hRContractTypeNo)
				{
					_hRContractTypeNo = value;
					NotifyChanged("HRContractTypeNo");
				}
			}
		}
		public String HRContractTypeName
		{
			get { return _hRContractTypeName; }
			set
			{
				if (value != this._hRContractTypeName)
				{
					_hRContractTypeName = value;
					NotifyChanged("HRContractTypeName");
				}
			}
		}
		public Nullable<DateTime> HRContractTypeDate
		{
			get { return _hRContractTypeDate; }
			set
			{
				if (value != this._hRContractTypeDate)
				{
					_hRContractTypeDate = value;
					NotifyChanged("HRContractTypeDate");
				}
			}
		}
		public String HRContractTypeDesc
		{
			get { return _hRContractTypeDesc; }
			set
			{
				if (value != this._hRContractTypeDesc)
				{
					_hRContractTypeDesc = value;
					NotifyChanged("HRContractTypeDesc");
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
		public bool HRContractTypeIsMainCheck
		{
			get { return _hRContractTypeIsMainCheck; }
			set
			{
				if (value != this._hRContractTypeIsMainCheck)
				{
					_hRContractTypeIsMainCheck = value;
					NotifyChanged("HRContractTypeIsMainCheck");
				}
			}
		}
		
        #endregion
    }
    #endregion
}