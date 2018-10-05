using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICStocks
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICStocksInfo
    //Created Date:29 Tháng Bảy 2013
    //-----------------------------------------------------------

    public class ICStocksInfo : BusinessObject
    {
        public ICStocksInfo()
        {
        }
        #region Variables
        protected int _iCStockID;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected int _fK_GELanguageID;
        protected int _fK_GECurrencyID;
        protected int _fK_ICStockParentID;
        protected int _fK_BRBranchID;
        protected String _iCStockNo = String.Empty;
        protected String _iCStockName = String.Empty;
        protected String _iCStockDesc = String.Empty;
        protected Nullable<DateTime> _iCStockDate;
        protected String _iCStockType = String.Empty;
        protected String _iCStockOF01Combo = String.Empty;
        protected String _iCStockOF02Combo = String.Empty;
        protected String _iCStockOF03Combo = String.Empty;
        protected String _iCStockOF04Combo = String.Empty;
        protected String _iCStockOF05Combo = String.Empty;
        protected String _iCStockOF06Combo = String.Empty;
        protected String _iCStockOF07Combo = String.Empty;
        protected String _iCStockOF08Combo = String.Empty;
        protected String _iCStockOF09Combo = String.Empty;
        protected String _iCStockOF10Combo = String.Empty;
        protected bool _iCStockActiveCheck = true;
        protected String _iCStockInfo = String.Empty;
        protected String _iCStockConName = String.Empty;
        protected Nullable<DateTime> _iCStockConBday;
        protected String _iCStockConFName = String.Empty;
        protected String _iCStockConLName = String.Empty;
        protected String _iCStockConTitle = String.Empty;
        protected String _iCStockConHLet = String.Empty;
        protected String _iCStockConHMsg = String.Empty;
        protected String _iCStockConEmail = String.Empty;
        protected String _iCStockConEmail1 = String.Empty;
        protected String _iCStockConWebsite = String.Empty;
        protected String _iCStockConPhonePriv = String.Empty;
        protected String _iCStockConPhone = String.Empty;
        protected String _iCStockConPhone1 = String.Empty;
        protected String _iCStockConCPhone = String.Empty;
        protected String _iCStockConCPhone1 = String.Empty;
        protected String _iCStockConFax = String.Empty;
        protected String _iCStockConInfo = String.Empty;
        protected String _iCStockConDept = String.Empty;
        protected String _iCStockConRoom = String.Empty;
        protected String _iCStockAddStr = String.Empty;
        protected String _iCStockAddL1 = String.Empty;
        protected String _iCStockAddL2 = String.Empty;
        protected String _iCStockAddL3 = String.Empty;
        protected String _iCStockAddCity = String.Empty;
        protected String _iCStockAddPCode = String.Empty;
        protected String _iCStockAddStProv = String.Empty;
        protected String _iCStockAddZCode = String.Empty;
        protected String _iCStockAddCountry = String.Empty;
        protected bool _aASelected = true;
        protected int _fK_ICStockTypeID;
        protected int _fK_GLInventoryAccountID;
        protected int _fK_GLCostAccountID;
        protected int _iCStockSortOrder;
        protected String _aAOrgDocNo = String.Empty;
        #endregion

        #region Public properties
        public int ICStockID
        {
            get { return _iCStockID; }
            set
            {
                if (value != this._iCStockID)
                {
                    _iCStockID = value;
                    NotifyChanged("ICStockID");
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
        public DateTime AACreatedDate
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
        public DateTime AAUpdatedDate
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
        public int FK_GELanguageID
        {
            get { return _fK_GELanguageID; }
            set
            {
                if (value != this._fK_GELanguageID)
                {
                    _fK_GELanguageID = value;
                    NotifyChanged("FK_GELanguageID");
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
        public int FK_ICStockParentID
        {
            get { return _fK_ICStockParentID; }
            set
            {
                if (value != this._fK_ICStockParentID)
                {
                    _fK_ICStockParentID = value;
                    NotifyChanged("FK_ICStockParentID");
                }
            }
        }
        public int FK_BRBranchID
        {
            get { return _fK_BRBranchID; }
            set
            {
                if (value != this._fK_BRBranchID)
                {
                    _fK_BRBranchID = value;
                    NotifyChanged("FK_BRBranchID");
                }
            }
        }
        public String ICStockNo
        {
            get { return _iCStockNo; }
            set
            {
                if (value != this._iCStockNo)
                {
                    _iCStockNo = value;
                    NotifyChanged("ICStockNo");
                }
            }
        }
        public String ICStockName
        {
            get { return _iCStockName; }
            set
            {
                if (value != this._iCStockName)
                {
                    _iCStockName = value;
                    NotifyChanged("ICStockName");
                }
            }
        }
        public String ICStockDesc
        {
            get { return _iCStockDesc; }
            set
            {
                if (value != this._iCStockDesc)
                {
                    _iCStockDesc = value;
                    NotifyChanged("ICStockDesc");
                }
            }
        }
        public Nullable<DateTime> ICStockDate
        {
            get { return _iCStockDate; }
            set
            {
                if (value != this._iCStockDate)
                {
                    _iCStockDate = value;
                    NotifyChanged("ICStockDate");
                }
            }
        }
        public String ICStockType
        {
            get { return _iCStockType; }
            set
            {
                if (value != this._iCStockType)
                {
                    _iCStockType = value;
                    NotifyChanged("ICStockType");
                }
            }
        }
        public String ICStockOF01Combo
        {
            get { return _iCStockOF01Combo; }
            set
            {
                if (value != this._iCStockOF01Combo)
                {
                    _iCStockOF01Combo = value;
                    NotifyChanged("ICStockOF01Combo");
                }
            }
        }
        public String ICStockOF02Combo
        {
            get { return _iCStockOF02Combo; }
            set
            {
                if (value != this._iCStockOF02Combo)
                {
                    _iCStockOF02Combo = value;
                    NotifyChanged("ICStockOF02Combo");
                }
            }
        }
        public String ICStockOF03Combo
        {
            get { return _iCStockOF03Combo; }
            set
            {
                if (value != this._iCStockOF03Combo)
                {
                    _iCStockOF03Combo = value;
                    NotifyChanged("ICStockOF03Combo");
                }
            }
        }
        public String ICStockOF04Combo
        {
            get { return _iCStockOF04Combo; }
            set
            {
                if (value != this._iCStockOF04Combo)
                {
                    _iCStockOF04Combo = value;
                    NotifyChanged("ICStockOF04Combo");
                }
            }
        }
        public String ICStockOF05Combo
        {
            get { return _iCStockOF05Combo; }
            set
            {
                if (value != this._iCStockOF05Combo)
                {
                    _iCStockOF05Combo = value;
                    NotifyChanged("ICStockOF05Combo");
                }
            }
        }
        public String ICStockOF06Combo
        {
            get { return _iCStockOF06Combo; }
            set
            {
                if (value != this._iCStockOF06Combo)
                {
                    _iCStockOF06Combo = value;
                    NotifyChanged("ICStockOF06Combo");
                }
            }
        }
        public String ICStockOF07Combo
        {
            get { return _iCStockOF07Combo; }
            set
            {
                if (value != this._iCStockOF07Combo)
                {
                    _iCStockOF07Combo = value;
                    NotifyChanged("ICStockOF07Combo");
                }
            }
        }
        public String ICStockOF08Combo
        {
            get { return _iCStockOF08Combo; }
            set
            {
                if (value != this._iCStockOF08Combo)
                {
                    _iCStockOF08Combo = value;
                    NotifyChanged("ICStockOF08Combo");
                }
            }
        }
        public String ICStockOF09Combo
        {
            get { return _iCStockOF09Combo; }
            set
            {
                if (value != this._iCStockOF09Combo)
                {
                    _iCStockOF09Combo = value;
                    NotifyChanged("ICStockOF09Combo");
                }
            }
        }
        public String ICStockOF10Combo
        {
            get { return _iCStockOF10Combo; }
            set
            {
                if (value != this._iCStockOF10Combo)
                {
                    _iCStockOF10Combo = value;
                    NotifyChanged("ICStockOF10Combo");
                }
            }
        }
        public bool ICStockActiveCheck
        {
            get { return _iCStockActiveCheck; }
            set
            {
                if (value != this._iCStockActiveCheck)
                {
                    _iCStockActiveCheck = value;
                    NotifyChanged("ICStockActiveCheck");
                }
            }
        }
        public String ICStockInfo
        {
            get { return _iCStockInfo; }
            set
            {
                if (value != this._iCStockInfo)
                {
                    _iCStockInfo = value;
                    NotifyChanged("ICStockInfo");
                }
            }
        }
        public String ICStockConName
        {
            get { return _iCStockConName; }
            set
            {
                if (value != this._iCStockConName)
                {
                    _iCStockConName = value;
                    NotifyChanged("ICStockConName");
                }
            }
        }
        public Nullable<DateTime> ICStockConBday
        {
            get { return _iCStockConBday; }
            set
            {
                if (value != this._iCStockConBday)
                {
                    _iCStockConBday = value;
                    NotifyChanged("ICStockConBday");
                }
            }
        }
        public String ICStockConFName
        {
            get { return _iCStockConFName; }
            set
            {
                if (value != this._iCStockConFName)
                {
                    _iCStockConFName = value;
                    NotifyChanged("ICStockConFName");
                }
            }
        }
        public String ICStockConLName
        {
            get { return _iCStockConLName; }
            set
            {
                if (value != this._iCStockConLName)
                {
                    _iCStockConLName = value;
                    NotifyChanged("ICStockConLName");
                }
            }
        }
        public String ICStockConTitle
        {
            get { return _iCStockConTitle; }
            set
            {
                if (value != this._iCStockConTitle)
                {
                    _iCStockConTitle = value;
                    NotifyChanged("ICStockConTitle");
                }
            }
        }
        public String ICStockConHLet
        {
            get { return _iCStockConHLet; }
            set
            {
                if (value != this._iCStockConHLet)
                {
                    _iCStockConHLet = value;
                    NotifyChanged("ICStockConHLet");
                }
            }
        }
        public String ICStockConHMsg
        {
            get { return _iCStockConHMsg; }
            set
            {
                if (value != this._iCStockConHMsg)
                {
                    _iCStockConHMsg = value;
                    NotifyChanged("ICStockConHMsg");
                }
            }
        }
        public String ICStockConEmail
        {
            get { return _iCStockConEmail; }
            set
            {
                if (value != this._iCStockConEmail)
                {
                    _iCStockConEmail = value;
                    NotifyChanged("ICStockConEmail");
                }
            }
        }
        public String ICStockConEmail1
        {
            get { return _iCStockConEmail1; }
            set
            {
                if (value != this._iCStockConEmail1)
                {
                    _iCStockConEmail1 = value;
                    NotifyChanged("ICStockConEmail1");
                }
            }
        }
        public String ICStockConWebsite
        {
            get { return _iCStockConWebsite; }
            set
            {
                if (value != this._iCStockConWebsite)
                {
                    _iCStockConWebsite = value;
                    NotifyChanged("ICStockConWebsite");
                }
            }
        }
        public String ICStockConPhonePriv
        {
            get { return _iCStockConPhonePriv; }
            set
            {
                if (value != this._iCStockConPhonePriv)
                {
                    _iCStockConPhonePriv = value;
                    NotifyChanged("ICStockConPhonePriv");
                }
            }
        }
        public String ICStockConPhone
        {
            get { return _iCStockConPhone; }
            set
            {
                if (value != this._iCStockConPhone)
                {
                    _iCStockConPhone = value;
                    NotifyChanged("ICStockConPhone");
                }
            }
        }
        public String ICStockConPhone1
        {
            get { return _iCStockConPhone1; }
            set
            {
                if (value != this._iCStockConPhone1)
                {
                    _iCStockConPhone1 = value;
                    NotifyChanged("ICStockConPhone1");
                }
            }
        }
        public String ICStockConCPhone
        {
            get { return _iCStockConCPhone; }
            set
            {
                if (value != this._iCStockConCPhone)
                {
                    _iCStockConCPhone = value;
                    NotifyChanged("ICStockConCPhone");
                }
            }
        }
        public String ICStockConCPhone1
        {
            get { return _iCStockConCPhone1; }
            set
            {
                if (value != this._iCStockConCPhone1)
                {
                    _iCStockConCPhone1 = value;
                    NotifyChanged("ICStockConCPhone1");
                }
            }
        }
        public String ICStockConFax
        {
            get { return _iCStockConFax; }
            set
            {
                if (value != this._iCStockConFax)
                {
                    _iCStockConFax = value;
                    NotifyChanged("ICStockConFax");
                }
            }
        }
        public String ICStockConInfo
        {
            get { return _iCStockConInfo; }
            set
            {
                if (value != this._iCStockConInfo)
                {
                    _iCStockConInfo = value;
                    NotifyChanged("ICStockConInfo");
                }
            }
        }
        public String ICStockConDept
        {
            get { return _iCStockConDept; }
            set
            {
                if (value != this._iCStockConDept)
                {
                    _iCStockConDept = value;
                    NotifyChanged("ICStockConDept");
                }
            }
        }
        public String ICStockConRoom
        {
            get { return _iCStockConRoom; }
            set
            {
                if (value != this._iCStockConRoom)
                {
                    _iCStockConRoom = value;
                    NotifyChanged("ICStockConRoom");
                }
            }
        }
        public String ICStockAddStr
        {
            get { return _iCStockAddStr; }
            set
            {
                if (value != this._iCStockAddStr)
                {
                    _iCStockAddStr = value;
                    NotifyChanged("ICStockAddStr");
                }
            }
        }
        public String ICStockAddL1
        {
            get { return _iCStockAddL1; }
            set
            {
                if (value != this._iCStockAddL1)
                {
                    _iCStockAddL1 = value;
                    NotifyChanged("ICStockAddL1");
                }
            }
        }
        public String ICStockAddL2
        {
            get { return _iCStockAddL2; }
            set
            {
                if (value != this._iCStockAddL2)
                {
                    _iCStockAddL2 = value;
                    NotifyChanged("ICStockAddL2");
                }
            }
        }
        public String ICStockAddL3
        {
            get { return _iCStockAddL3; }
            set
            {
                if (value != this._iCStockAddL3)
                {
                    _iCStockAddL3 = value;
                    NotifyChanged("ICStockAddL3");
                }
            }
        }
        public String ICStockAddCity
        {
            get { return _iCStockAddCity; }
            set
            {
                if (value != this._iCStockAddCity)
                {
                    _iCStockAddCity = value;
                    NotifyChanged("ICStockAddCity");
                }
            }
        }
        public String ICStockAddPCode
        {
            get { return _iCStockAddPCode; }
            set
            {
                if (value != this._iCStockAddPCode)
                {
                    _iCStockAddPCode = value;
                    NotifyChanged("ICStockAddPCode");
                }
            }
        }
        public String ICStockAddStProv
        {
            get { return _iCStockAddStProv; }
            set
            {
                if (value != this._iCStockAddStProv)
                {
                    _iCStockAddStProv = value;
                    NotifyChanged("ICStockAddStProv");
                }
            }
        }
        public String ICStockAddZCode
        {
            get { return _iCStockAddZCode; }
            set
            {
                if (value != this._iCStockAddZCode)
                {
                    _iCStockAddZCode = value;
                    NotifyChanged("ICStockAddZCode");
                }
            }
        }
        public String ICStockAddCountry
        {
            get { return _iCStockAddCountry; }
            set
            {
                if (value != this._iCStockAddCountry)
                {
                    _iCStockAddCountry = value;
                    NotifyChanged("ICStockAddCountry");
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
        public int FK_ICStockTypeID
        {
            get { return _fK_ICStockTypeID; }
            set
            {
                if (value != this._fK_ICStockTypeID)
                {
                    _fK_ICStockTypeID = value;
                    NotifyChanged("FK_ICStockTypeID");
                }
            }
        }
        public int FK_GLInventoryAccountID
        {
            get { return _fK_GLInventoryAccountID; }
            set
            {
                if (value != this._fK_GLInventoryAccountID)
                {
                    _fK_GLInventoryAccountID = value;
                    NotifyChanged("FK_GLInventoryAccountID");
                }
            }
        }
        public int FK_GLCostAccountID
        {
            get { return _fK_GLCostAccountID; }
            set
            {
                if (value != this._fK_GLCostAccountID)
                {
                    _fK_GLCostAccountID = value;
                    NotifyChanged("FK_GLCostAccountID");
                }
            }
        }
        public int ICStockSortOrder
        {
            get { return _iCStockSortOrder; }
            set
            {
                if (value != this._iCStockSortOrder)
                {
                    _iCStockSortOrder = value;
                    NotifyChanged("ICStockSortOrder");
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
        #endregion
    }
    #endregion
}