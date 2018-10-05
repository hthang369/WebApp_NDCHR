
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARShpPlans
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.83)
    //Class: ARShpPlansInfo
    //Created Date: Thursday, 05 Jan 2017
    //-----------------------------------------------------------

    public class ARShpPlansInfo : BusinessObject
    {
        public ARShpPlansInfo()
        {
        }
        #region Variables
        protected int _aRShpPlanID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aRShpPlanNo = String.Empty;
        protected String _aRShpPlanName = String.Empty;
        protected DateTime _aRShpPlanDate = DateTime.Now;
        protected String _aRShpPlanDesc = String.Empty;
        protected Nullable<DateTime> _aRShpPlanDueDate;
        protected int _aRShpPlanPeriod;
        protected int _aRShpPlanYear;
        protected String _aRShpPlanStatusCombo = DefaultStatus;
        protected int _fK_ARCustomerID;
        protected int _fK_ADUserID;
        protected double _aRShpPlanAmtTotal;
        protected double _aRShpPlanHTSAmtTotal;
        protected double _aRShpPlanATSAmtTotal;
        protected int _fK_HREmployeeID;
        protected int _fK_GLTranCfgID;
        protected int _fK_GLBankID;
        protected int _fK_GLOrgTranCfgID;

        #endregion

        #region Public properties
        public int ARShpPlanID
        {
            get { return _aRShpPlanID; }
            set
            {
                if (value != this._aRShpPlanID)
                {
                    _aRShpPlanID = value;
                    NotifyChanged("ARShpPlanID");
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
        public String ARShpPlanNo
        {
            get { return _aRShpPlanNo; }
            set
            {
                if (value != this._aRShpPlanNo)
                {
                    _aRShpPlanNo = value;
                    NotifyChanged("ARShpPlanNo");
                }
            }
        }
        public String ARShpPlanName
        {
            get { return _aRShpPlanName; }
            set
            {
                if (value != this._aRShpPlanName)
                {
                    _aRShpPlanName = value;
                    NotifyChanged("ARShpPlanName");
                }
            }
        }
        public DateTime ARShpPlanDate
        {
            get { return _aRShpPlanDate; }
            set
            {
                if (value != this._aRShpPlanDate)
                {
                    _aRShpPlanDate = value;
                    NotifyChanged("ARShpPlanDate");
                }
            }
        }
        public String ARShpPlanDesc
        {
            get { return _aRShpPlanDesc; }
            set
            {
                if (value != this._aRShpPlanDesc)
                {
                    _aRShpPlanDesc = value;
                    NotifyChanged("ARShpPlanDesc");
                }
            }
        }
        public Nullable<DateTime> ARShpPlanDueDate
        {
            get { return _aRShpPlanDueDate; }
            set
            {
                if (value != this._aRShpPlanDueDate)
                {
                    _aRShpPlanDueDate = value;
                    NotifyChanged("ARShpPlanDueDate");
                }
            }
        }
        public int ARShpPlanPeriod
        {
            get { return _aRShpPlanPeriod; }
            set
            {
                if (value != this._aRShpPlanPeriod)
                {
                    _aRShpPlanPeriod = value;
                    NotifyChanged("ARShpPlanPeriod");
                }
            }
        }
        public int ARShpPlanYear
        {
            get { return _aRShpPlanYear; }
            set
            {
                if (value != this._aRShpPlanYear)
                {
                    _aRShpPlanYear = value;
                    NotifyChanged("ARShpPlanYear");
                }
            }
        }
        public String ARShpPlanStatusCombo
        {
            get { return _aRShpPlanStatusCombo; }
            set
            {
                if (value != this._aRShpPlanStatusCombo)
                {
                    _aRShpPlanStatusCombo = value;
                    NotifyChanged("ARShpPlanStatusCombo");
                }
            }
        }
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
                }
            }
        }
        public int FK_ADUserID
        {
            get { return _fK_ADUserID; }
            set
            {
                if (value != this._fK_ADUserID)
                {
                    _fK_ADUserID = value;
                    NotifyChanged("FK_ADUserID");
                }
            }
        }
        public double ARShpPlanAmtTotal
        {
            get { return _aRShpPlanAmtTotal; }
            set
            {
                if (value != this._aRShpPlanAmtTotal)
                {
                    _aRShpPlanAmtTotal = value;
                    NotifyChanged("ARShpPlanAmtTotal");
                }
            }
        }
        public double ARShpPlanHTSAmtTotal
        {
            get { return _aRShpPlanHTSAmtTotal; }
            set
            {
                if (value != this._aRShpPlanHTSAmtTotal)
                {
                    _aRShpPlanHTSAmtTotal = value;
                    NotifyChanged("ARShpPlanHTSAmtTotal");
                }
            }
        }
        public double ARShpPlanATSAmtTotal
        {
            get { return _aRShpPlanATSAmtTotal; }
            set
            {
                if (value != this._aRShpPlanATSAmtTotal)
                {
                    _aRShpPlanATSAmtTotal = value;
                    NotifyChanged("ARShpPlanATSAmtTotal");
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public int FK_GLTranCfgID
        {
            get { return _fK_GLTranCfgID; }
            set
            {
                if (value != this._fK_GLTranCfgID)
                {
                    _fK_GLTranCfgID = value;
                    NotifyChanged("FK_GLTranCfgID");
                }
            }
        }
        public int FK_GLBankID
        {
            get { return _fK_GLBankID; }
            set
            {
                if (value != this._fK_GLBankID)
                {
                    _fK_GLBankID = value;
                    NotifyChanged("FK_GLBankID");
                }
            }
        }
        public int FK_GLOrgTranCfgID
        {
            get { return _fK_GLOrgTranCfgID; }
            set
            {
                if (value != this._fK_GLOrgTranCfgID)
                {
                    _fK_GLOrgTranCfgID = value;
                    NotifyChanged("FK_GLOrgTranCfgID");
                }
            }
        }

        #endregion
    }
    #endregion
}