using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICBrands
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICBrandsInfo
    //Created Date:08 Tha�ng Sa�u 2011
    //-----------------------------------------------------------

    public class ICBrandsInfo : BusinessObject
    {
        public ICBrandsInfo()
        {
        }
        #region Variables
        protected int _iCBrandID;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.Now;
        protected DateTime _aAUpdatedDate = DateTime.Now;
        protected String _aAStatus = DefaultAAStatus;
        protected String _iCBrandNo = String.Empty;
        protected String _iCBrandName = String.Empty;
        protected String _iCBrandDesc = String.Empty;
        protected bool _iCBrandActiveCheck = true;
        protected String _iCBrandOF01Combo = String.Empty;
        protected String _iCBrandOF02Combo = String.Empty;
        protected String _iCBrandOF03Combo = String.Empty;
        protected String _iCBrandOF04Combo = String.Empty;
        protected String _iCBrandOF05Combo = String.Empty;
        protected String _iCBrandOF06Combo = String.Empty;
        protected String _iCBrandOF07Combo = String.Empty;
        protected String _iCBrandOF08Combo = String.Empty;
        protected String _iCBrandOF09Combo = String.Empty;
        protected String _iCBrandOF10Combo = String.Empty;
        protected String _iCBrandConName = String.Empty;
        protected Nullable<DateTime> _iCBrandConBday;
        protected String _iCBrandConFName = String.Empty;
        protected String _iCBrandConLName = String.Empty;
        protected String _iCBrandConTitle = String.Empty;
        protected String _iCBrandConHLet = String.Empty;
        protected String _iCBrandConHMsg = String.Empty;
        protected String _iCBrandConEmail = String.Empty;
        protected String _iCBrandConEmail1 = String.Empty;
        protected String _iCBrandConWebsite = String.Empty;
        protected String _iCBrandConPhonePriv = String.Empty;
        protected String _iCBrandConPhone = String.Empty;
        protected String _iCBrandConPhone1 = String.Empty;
        protected String _iCBrandConCPhone1 = String.Empty;
        protected String _iCBrandConCPhone = String.Empty;
        protected String _iCBrandConFax = String.Empty;
        protected String _iCBrandConInfo = String.Empty;
        protected String _iCBrandConDept = String.Empty;
        protected String _iCBrandConRoom = String.Empty;
        protected String _iCBrandAddStr = String.Empty;
        protected String _iCBrandAddL1 = String.Empty;
        protected String _iCBrandAddL2 = String.Empty;
        protected String _iCBrandAddL3 = String.Empty;
        protected String _iCBrandAddCity = String.Empty;
        protected String _iCBrandAddPCode = String.Empty;
        protected String _iCBrandAddStProv = String.Empty;
        protected String _iCBrandAddZCode = String.Empty;
        protected String _iCBrandAddCountry = String.Empty;
        #endregion

        #region Public properties
        public int ICBrandID
        {
            get { return _iCBrandID; }
            set
            {
                if (value != this._iCBrandID)
                {
                    _iCBrandID = value;
                    NotifyChanged("ICBrandID");
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
        public String ICBrandNo
        {
            get { return _iCBrandNo; }
            set
            {
                if (value != this._iCBrandNo)
                {
                    _iCBrandNo = value;
                    NotifyChanged("ICBrandNo");
                }
            }
        }
        public String ICBrandName
        {
            get { return _iCBrandName; }
            set
            {
                if (value != this._iCBrandName)
                {
                    _iCBrandName = value;
                    NotifyChanged("ICBrandName");
                }
            }
        }
        public String ICBrandDesc
        {
            get { return _iCBrandDesc; }
            set
            {
                if (value != this._iCBrandDesc)
                {
                    _iCBrandDesc = value;
                    NotifyChanged("ICBrandDesc");
                }
            }
        }
        public bool ICBrandActiveCheck
        {
            get { return _iCBrandActiveCheck; }
            set
            {
                if (value != this._iCBrandActiveCheck)
                {
                    _iCBrandActiveCheck = value;
                    NotifyChanged("ICBrandActiveCheck");
                }
            }
        }
        public String ICBrandOF01Combo
        {
            get { return _iCBrandOF01Combo; }
            set
            {
                if (value != this._iCBrandOF01Combo)
                {
                    _iCBrandOF01Combo = value;
                    NotifyChanged("ICBrandOF01Combo");
                }
            }
        }
        public String ICBrandOF02Combo
        {
            get { return _iCBrandOF02Combo; }
            set
            {
                if (value != this._iCBrandOF02Combo)
                {
                    _iCBrandOF02Combo = value;
                    NotifyChanged("ICBrandOF02Combo");
                }
            }
        }
        public String ICBrandOF03Combo
        {
            get { return _iCBrandOF03Combo; }
            set
            {
                if (value != this._iCBrandOF03Combo)
                {
                    _iCBrandOF03Combo = value;
                    NotifyChanged("ICBrandOF03Combo");
                }
            }
        }
        public String ICBrandOF04Combo
        {
            get { return _iCBrandOF04Combo; }
            set
            {
                if (value != this._iCBrandOF04Combo)
                {
                    _iCBrandOF04Combo = value;
                    NotifyChanged("ICBrandOF04Combo");
                }
            }
        }
        public String ICBrandOF05Combo
        {
            get { return _iCBrandOF05Combo; }
            set
            {
                if (value != this._iCBrandOF05Combo)
                {
                    _iCBrandOF05Combo = value;
                    NotifyChanged("ICBrandOF05Combo");
                }
            }
        }
        public String ICBrandOF06Combo
        {
            get { return _iCBrandOF06Combo; }
            set
            {
                if (value != this._iCBrandOF06Combo)
                {
                    _iCBrandOF06Combo = value;
                    NotifyChanged("ICBrandOF06Combo");
                }
            }
        }
        public String ICBrandOF07Combo
        {
            get { return _iCBrandOF07Combo; }
            set
            {
                if (value != this._iCBrandOF07Combo)
                {
                    _iCBrandOF07Combo = value;
                    NotifyChanged("ICBrandOF07Combo");
                }
            }
        }
        public String ICBrandOF08Combo
        {
            get { return _iCBrandOF08Combo; }
            set
            {
                if (value != this._iCBrandOF08Combo)
                {
                    _iCBrandOF08Combo = value;
                    NotifyChanged("ICBrandOF08Combo");
                }
            }
        }
        public String ICBrandOF09Combo
        {
            get { return _iCBrandOF09Combo; }
            set
            {
                if (value != this._iCBrandOF09Combo)
                {
                    _iCBrandOF09Combo = value;
                    NotifyChanged("ICBrandOF09Combo");
                }
            }
        }
        public String ICBrandOF10Combo
        {
            get { return _iCBrandOF10Combo; }
            set
            {
                if (value != this._iCBrandOF10Combo)
                {
                    _iCBrandOF10Combo = value;
                    NotifyChanged("ICBrandOF10Combo");
                }
            }
        }
        public String ICBrandConName
        {
            get { return _iCBrandConName; }
            set
            {
                if (value != this._iCBrandConName)
                {
                    _iCBrandConName = value;
                    NotifyChanged("ICBrandConName");
                }
            }
        }
        public Nullable<DateTime> ICBrandConBday
        {
            get { return _iCBrandConBday; }
            set
            {
                if (value != this._iCBrandConBday)
                {
                    _iCBrandConBday = value;
                    NotifyChanged("ICBrandConBday");
                }
            }
        }
        public String ICBrandConFName
        {
            get { return _iCBrandConFName; }
            set
            {
                if (value != this._iCBrandConFName)
                {
                    _iCBrandConFName = value;
                    NotifyChanged("ICBrandConFName");
                }
            }
        }
        public String ICBrandConLName
        {
            get { return _iCBrandConLName; }
            set
            {
                if (value != this._iCBrandConLName)
                {
                    _iCBrandConLName = value;
                    NotifyChanged("ICBrandConLName");
                }
            }
        }
        public String ICBrandConTitle
        {
            get { return _iCBrandConTitle; }
            set
            {
                if (value != this._iCBrandConTitle)
                {
                    _iCBrandConTitle = value;
                    NotifyChanged("ICBrandConTitle");
                }
            }
        }
        public String ICBrandConHLet
        {
            get { return _iCBrandConHLet; }
            set
            {
                if (value != this._iCBrandConHLet)
                {
                    _iCBrandConHLet = value;
                    NotifyChanged("ICBrandConHLet");
                }
            }
        }
        public String ICBrandConHMsg
        {
            get { return _iCBrandConHMsg; }
            set
            {
                if (value != this._iCBrandConHMsg)
                {
                    _iCBrandConHMsg = value;
                    NotifyChanged("ICBrandConHMsg");
                }
            }
        }
        public String ICBrandConEmail
        {
            get { return _iCBrandConEmail; }
            set
            {
                if (value != this._iCBrandConEmail)
                {
                    _iCBrandConEmail = value;
                    NotifyChanged("ICBrandConEmail");
                }
            }
        }
        public String ICBrandConEmail1
        {
            get { return _iCBrandConEmail1; }
            set
            {
                if (value != this._iCBrandConEmail1)
                {
                    _iCBrandConEmail1 = value;
                    NotifyChanged("ICBrandConEmail1");
                }
            }
        }
        public String ICBrandConWebsite
        {
            get { return _iCBrandConWebsite; }
            set
            {
                if (value != this._iCBrandConWebsite)
                {
                    _iCBrandConWebsite = value;
                    NotifyChanged("ICBrandConWebsite");
                }
            }
        }
        public String ICBrandConPhonePriv
        {
            get { return _iCBrandConPhonePriv; }
            set
            {
                if (value != this._iCBrandConPhonePriv)
                {
                    _iCBrandConPhonePriv = value;
                    NotifyChanged("ICBrandConPhonePriv");
                }
            }
        }
        public String ICBrandConPhone
        {
            get { return _iCBrandConPhone; }
            set
            {
                if (value != this._iCBrandConPhone)
                {
                    _iCBrandConPhone = value;
                    NotifyChanged("ICBrandConPhone");
                }
            }
        }
        public String ICBrandConPhone1
        {
            get { return _iCBrandConPhone1; }
            set
            {
                if (value != this._iCBrandConPhone1)
                {
                    _iCBrandConPhone1 = value;
                    NotifyChanged("ICBrandConPhone1");
                }
            }
        }
        public String ICBrandConCPhone1
        {
            get { return _iCBrandConCPhone1; }
            set
            {
                if (value != this._iCBrandConCPhone1)
                {
                    _iCBrandConCPhone1 = value;
                    NotifyChanged("ICBrandConCPhone1");
                }
            }
        }
        public String ICBrandConCPhone
        {
            get { return _iCBrandConCPhone; }
            set
            {
                if (value != this._iCBrandConCPhone)
                {
                    _iCBrandConCPhone = value;
                    NotifyChanged("ICBrandConCPhone");
                }
            }
        }
        public String ICBrandConFax
        {
            get { return _iCBrandConFax; }
            set
            {
                if (value != this._iCBrandConFax)
                {
                    _iCBrandConFax = value;
                    NotifyChanged("ICBrandConFax");
                }
            }
        }
        public String ICBrandConInfo
        {
            get { return _iCBrandConInfo; }
            set
            {
                if (value != this._iCBrandConInfo)
                {
                    _iCBrandConInfo = value;
                    NotifyChanged("ICBrandConInfo");
                }
            }
        }
        public String ICBrandConDept
        {
            get { return _iCBrandConDept; }
            set
            {
                if (value != this._iCBrandConDept)
                {
                    _iCBrandConDept = value;
                    NotifyChanged("ICBrandConDept");
                }
            }
        }
        public String ICBrandConRoom
        {
            get { return _iCBrandConRoom; }
            set
            {
                if (value != this._iCBrandConRoom)
                {
                    _iCBrandConRoom = value;
                    NotifyChanged("ICBrandConRoom");
                }
            }
        }
        public String ICBrandAddStr
        {
            get { return _iCBrandAddStr; }
            set
            {
                if (value != this._iCBrandAddStr)
                {
                    _iCBrandAddStr = value;
                    NotifyChanged("ICBrandAddStr");
                }
            }
        }
        public String ICBrandAddL1
        {
            get { return _iCBrandAddL1; }
            set
            {
                if (value != this._iCBrandAddL1)
                {
                    _iCBrandAddL1 = value;
                    NotifyChanged("ICBrandAddL1");
                }
            }
        }
        public String ICBrandAddL2
        {
            get { return _iCBrandAddL2; }
            set
            {
                if (value != this._iCBrandAddL2)
                {
                    _iCBrandAddL2 = value;
                    NotifyChanged("ICBrandAddL2");
                }
            }
        }
        public String ICBrandAddL3
        {
            get { return _iCBrandAddL3; }
            set
            {
                if (value != this._iCBrandAddL3)
                {
                    _iCBrandAddL3 = value;
                    NotifyChanged("ICBrandAddL3");
                }
            }
        }
        public String ICBrandAddCity
        {
            get { return _iCBrandAddCity; }
            set
            {
                if (value != this._iCBrandAddCity)
                {
                    _iCBrandAddCity = value;
                    NotifyChanged("ICBrandAddCity");
                }
            }
        }
        public String ICBrandAddPCode
        {
            get { return _iCBrandAddPCode; }
            set
            {
                if (value != this._iCBrandAddPCode)
                {
                    _iCBrandAddPCode = value;
                    NotifyChanged("ICBrandAddPCode");
                }
            }
        }
        public String ICBrandAddStProv
        {
            get { return _iCBrandAddStProv; }
            set
            {
                if (value != this._iCBrandAddStProv)
                {
                    _iCBrandAddStProv = value;
                    NotifyChanged("ICBrandAddStProv");
                }
            }
        }
        public String ICBrandAddZCode
        {
            get { return _iCBrandAddZCode; }
            set
            {
                if (value != this._iCBrandAddZCode)
                {
                    _iCBrandAddZCode = value;
                    NotifyChanged("ICBrandAddZCode");
                }
            }
        }
        public String ICBrandAddCountry
        {
            get { return _iCBrandAddCountry; }
            set
            {
                if (value != this._iCBrandAddCountry)
                {
                    _iCBrandAddCountry = value;
                    NotifyChanged("ICBrandAddCountry");
                }
            }
        }
        #endregion
    }
    #endregion
}