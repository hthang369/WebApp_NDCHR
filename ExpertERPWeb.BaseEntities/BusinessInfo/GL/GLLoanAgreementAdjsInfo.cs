
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLLoanAgreementAdjs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.80)
    //Class: GLLoanAgreementAdjsInfo
    //Created Date: Wednesday, 16 Nov 2016
    //-----------------------------------------------------------

    public class GLLoanAgreementAdjsInfo : BusinessObject
    {
        public GLLoanAgreementAdjsInfo()
        {
        }
        #region Variables
		protected int _gLLoanAgreementAdjID;
		protected String _gLLoanAgreementAdjNo = String.Empty;
		protected String _gLLoanAgreementAdjName = String.Empty;
		protected Nullable<DateTime> _gLLoanAgreementAdjDate;
		protected String _gLLoanAgreementAdjDesc = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAModule = String.Empty;
		
        #endregion

        #region Public properties
		public int GLLoanAgreementAdjID
		{
			get { return _gLLoanAgreementAdjID; }
			set
			{
				if (value != this._gLLoanAgreementAdjID)
				{
					_gLLoanAgreementAdjID = value;
					NotifyChanged("GLLoanAgreementAdjID");
				}
			}
		}
		public String GLLoanAgreementAdjNo
		{
			get { return _gLLoanAgreementAdjNo; }
			set
			{
				if (value != this._gLLoanAgreementAdjNo)
				{
					_gLLoanAgreementAdjNo = value;
					NotifyChanged("GLLoanAgreementAdjNo");
				}
			}
		}
		public String GLLoanAgreementAdjName
		{
			get { return _gLLoanAgreementAdjName; }
			set
			{
				if (value != this._gLLoanAgreementAdjName)
				{
					_gLLoanAgreementAdjName = value;
					NotifyChanged("GLLoanAgreementAdjName");
				}
			}
		}
		public Nullable<DateTime> GLLoanAgreementAdjDate
		{
			get { return _gLLoanAgreementAdjDate; }
			set
			{
				if (value != this._gLLoanAgreementAdjDate)
				{
					_gLLoanAgreementAdjDate = value;
					NotifyChanged("GLLoanAgreementAdjDate");
				}
			}
		}
		public String GLLoanAgreementAdjDesc
		{
			get { return _gLLoanAgreementAdjDesc; }
			set
			{
				if (value != this._gLLoanAgreementAdjDesc)
				{
					_gLLoanAgreementAdjDesc = value;
					NotifyChanged("GLLoanAgreementAdjDesc");
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
		public String AAModule
		{
			get { return _aAModule; }
			set
			{
				if (value != this._aAModule)
				{
					_aAModule = value;
					NotifyChanged("AAModule");
				}
			}
		}
		
        #endregion
    }
    #endregion
}