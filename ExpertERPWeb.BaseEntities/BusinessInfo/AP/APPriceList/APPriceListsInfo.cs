
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region APPriceLists
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.57)
    //Class: APPriceListsInfo
    //Created Date: Wednesday, 08 Jun 2016
    //-----------------------------------------------------------

    public class APPriceListsInfo : BusinessObject
    {
        public APPriceListsInfo()
        {
        }
        #region Variables
        protected int _aPPriceListID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected int _fK_GECurrencyID;
        protected int _fK_APSupplierID;
        protected String _aPPriceListNo = String.Empty;
        protected String _aPPriceListName = String.Empty;
        protected String _aPPriceListDesc = String.Empty;
        protected String _aPPriceListInfo = String.Empty;
        protected Nullable<DateTime> _aPPriceListStartDate;
        protected Nullable<DateTime> _aPPriceListEndDate;
        protected String _aPPriceListOF01Combo = String.Empty;
        protected String _aPPriceListOF02Combo = String.Empty;
        protected String _aPPriceListOF03Combo = String.Empty;
        protected String _aPPriceListOF04Combo = String.Empty;
        protected String _aPPriceListOF05Combo = String.Empty;
        protected String _aPPriceListOF06Combo = String.Empty;
        protected String _aPPriceListOF07Combo = String.Empty;
        protected String _aPPriceListOF08Combo = String.Empty;
        protected String _aPPriceListOF09Combo = String.Empty;
        protected String _aPPriceListOF10Combo = String.Empty;
        protected bool _aPPriceListActiveCheck = true;
        protected double _aPPriceListExcRate;
        protected String _aAOrgDocNo = String.Empty;
        protected String _approvalStatusCombo = DefaultStatus;
        protected String _aPPriceListObjectCombo = String.Empty;
        protected String _aPPriceListTypeCombo = String.Empty;
        protected int _fK_ADOFID;
        protected int _fK_ARCustomerGroupID;
        protected int _fK_ADOFItemID;
        protected Nullable<DateTime> _aPPriceListDate;

        #endregion

        #region Public properties
        public int APPriceListID
        {
            get { return _aPPriceListID; }
            set
            {
                if (value != this._aPPriceListID)
                {
                    _aPPriceListID = value;
                    NotifyChanged("APPriceListID");
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
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                    NotifyChanged("FK_APSupplierID");
                }
            }
        }
        public String APPriceListNo
        {
            get { return _aPPriceListNo; }
            set
            {
                if (value != this._aPPriceListNo)
                {
                    _aPPriceListNo = value;
                    NotifyChanged("APPriceListNo");
                }
            }
        }
        public String APPriceListName
        {
            get { return _aPPriceListName; }
            set
            {
                if (value != this._aPPriceListName)
                {
                    _aPPriceListName = value;
                    NotifyChanged("APPriceListName");
                }
            }
        }
        public String APPriceListDesc
        {
            get { return _aPPriceListDesc; }
            set
            {
                if (value != this._aPPriceListDesc)
                {
                    _aPPriceListDesc = value;
                    NotifyChanged("APPriceListDesc");
                }
            }
        }
        public String APPriceListInfo
        {
            get { return _aPPriceListInfo; }
            set
            {
                if (value != this._aPPriceListInfo)
                {
                    _aPPriceListInfo = value;
                    NotifyChanged("APPriceListInfo");
                }
            }
        }
        public Nullable<DateTime> APPriceListStartDate
        {
            get { return _aPPriceListStartDate; }
            set
            {
                if (value != this._aPPriceListStartDate)
                {
                    _aPPriceListStartDate = value;
                    NotifyChanged("APPriceListStartDate");
                }
            }
        }
        public Nullable<DateTime> APPriceListEndDate
        {
            get { return _aPPriceListEndDate; }
            set
            {
                if (value != this._aPPriceListEndDate)
                {
                    _aPPriceListEndDate = value;
                    NotifyChanged("APPriceListEndDate");
                }
            }
        }
        public String APPriceListOF01Combo
        {
            get { return _aPPriceListOF01Combo; }
            set
            {
                if (value != this._aPPriceListOF01Combo)
                {
                    _aPPriceListOF01Combo = value;
                    NotifyChanged("APPriceListOF01Combo");
                }
            }
        }
        public String APPriceListOF02Combo
        {
            get { return _aPPriceListOF02Combo; }
            set
            {
                if (value != this._aPPriceListOF02Combo)
                {
                    _aPPriceListOF02Combo = value;
                    NotifyChanged("APPriceListOF02Combo");
                }
            }
        }
        public String APPriceListOF03Combo
        {
            get { return _aPPriceListOF03Combo; }
            set
            {
                if (value != this._aPPriceListOF03Combo)
                {
                    _aPPriceListOF03Combo = value;
                    NotifyChanged("APPriceListOF03Combo");
                }
            }
        }
        public String APPriceListOF04Combo
        {
            get { return _aPPriceListOF04Combo; }
            set
            {
                if (value != this._aPPriceListOF04Combo)
                {
                    _aPPriceListOF04Combo = value;
                    NotifyChanged("APPriceListOF04Combo");
                }
            }
        }
        public String APPriceListOF05Combo
        {
            get { return _aPPriceListOF05Combo; }
            set
            {
                if (value != this._aPPriceListOF05Combo)
                {
                    _aPPriceListOF05Combo = value;
                    NotifyChanged("APPriceListOF05Combo");
                }
            }
        }
        public String APPriceListOF06Combo
        {
            get { return _aPPriceListOF06Combo; }
            set
            {
                if (value != this._aPPriceListOF06Combo)
                {
                    _aPPriceListOF06Combo = value;
                    NotifyChanged("APPriceListOF06Combo");
                }
            }
        }
        public String APPriceListOF07Combo
        {
            get { return _aPPriceListOF07Combo; }
            set
            {
                if (value != this._aPPriceListOF07Combo)
                {
                    _aPPriceListOF07Combo = value;
                    NotifyChanged("APPriceListOF07Combo");
                }
            }
        }
        public String APPriceListOF08Combo
        {
            get { return _aPPriceListOF08Combo; }
            set
            {
                if (value != this._aPPriceListOF08Combo)
                {
                    _aPPriceListOF08Combo = value;
                    NotifyChanged("APPriceListOF08Combo");
                }
            }
        }
        public String APPriceListOF09Combo
        {
            get { return _aPPriceListOF09Combo; }
            set
            {
                if (value != this._aPPriceListOF09Combo)
                {
                    _aPPriceListOF09Combo = value;
                    NotifyChanged("APPriceListOF09Combo");
                }
            }
        }
        public String APPriceListOF10Combo
        {
            get { return _aPPriceListOF10Combo; }
            set
            {
                if (value != this._aPPriceListOF10Combo)
                {
                    _aPPriceListOF10Combo = value;
                    NotifyChanged("APPriceListOF10Combo");
                }
            }
        }
        public bool APPriceListActiveCheck
        {
            get { return _aPPriceListActiveCheck; }
            set
            {
                if (value != this._aPPriceListActiveCheck)
                {
                    _aPPriceListActiveCheck = value;
                    NotifyChanged("APPriceListActiveCheck");
                }
            }
        }
        public double APPriceListExcRate
        {
            get { return _aPPriceListExcRate; }
            set
            {
                if (value != this._aPPriceListExcRate)
                {
                    _aPPriceListExcRate = value;
                    NotifyChanged("APPriceListExcRate");
                }
            }
        }
        public String AAOrgDocNo
        {
            get { return _aAOrgDocNo; }
            set
            {
                if (value != this._aAOrgDocNo)
                {
                    _aAOrgDocNo = value;
                    NotifyChanged("AAOrgDocNo");
                }
            }
        }
        public String ApprovalStatusCombo
        {
            get { return _approvalStatusCombo; }
            set
            {
                if (value != this._approvalStatusCombo)
                {
                    _approvalStatusCombo = value;
                    NotifyChanged("ApprovalStatusCombo");
                }
            }
        }
        public String APPriceListObjectCombo
        {
            get { return _aPPriceListObjectCombo; }
            set
            {
                if (value != this._aPPriceListObjectCombo)
                {
                    _aPPriceListObjectCombo = value;
                    NotifyChanged("APPriceListObjectCombo");
                }
            }
        }
        public String APPriceListTypeCombo
        {
            get { return _aPPriceListTypeCombo; }
            set
            {
                if (value != this._aPPriceListTypeCombo)
                {
                    _aPPriceListTypeCombo = value;
                    NotifyChanged("APPriceListTypeCombo");
                }
            }
        }
        public int FK_ADOFID
        {
            get { return _fK_ADOFID; }
            set
            {
                if (value != this._fK_ADOFID)
                {
                    _fK_ADOFID = value;
                    NotifyChanged("FK_ADOFID");
                }
            }
        }
        public int FK_ARCustomerGroupID
        {
            get { return _fK_ARCustomerGroupID; }
            set
            {
                if (value != this._fK_ARCustomerGroupID)
                {
                    _fK_ARCustomerGroupID = value;
                    NotifyChanged("FK_ARCustomerGroupID");
                }
            }
        }
        public int FK_ADOFItemID
        {
            get { return _fK_ADOFItemID; }
            set
            {
                if (value != this._fK_ADOFItemID)
                {
                    _fK_ADOFItemID = value;
                    NotifyChanged("FK_ADOFItemID");
                }
            }
        }
        public Nullable<DateTime> APPriceListDate
        {
            get { return _aPPriceListDate; }
            set
            {
                if (value != this._aPPriceListDate)
                {
                    _aPPriceListDate = value;
                    NotifyChanged("APPriceListDate");
                }
            }
        }

        #endregion
    }
    #endregion
}