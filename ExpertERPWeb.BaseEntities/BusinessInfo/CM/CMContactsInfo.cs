using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region CMContacts
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:CMContactsInfo
    //Created Date:30 Tháng Bảy 2012
    //-----------------------------------------------------------

    public class CMContactsInfo : BusinessObject
    {
        public CMContactsInfo()
        {
        }
        #region Variables
        protected int _cMContactID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected String _cMContactNo = String.Empty;
        protected String _cMContactVocative = String.Empty;
        protected String _cMContactLastName = String.Empty;
        protected String _cMContactFirstName = String.Empty;
        protected String _cMContactName = String.Empty;
        protected int _fK_CMAccountID;
        protected int _fK_CMPositionID;
        protected int _fK_CMSpecialityID;
        protected String _cMContactOfficePhone = String.Empty;
        protected String _cMContactHomePhone = String.Empty;
        protected String _cMContactMobile = String.Empty;
        protected String _cMContactOtherMobile = String.Empty;
        protected String _cMContactAgencyAddress = String.Empty;
        protected String _cMContactHomeAddress = String.Empty;
        protected String _cMContactFax = String.Empty;
        protected String _cMContactEmail = String.Empty;
        protected String _cMLeadOfficeEmail = String.Empty;
        protected byte[] _cMContactPicture;
        protected String _cMContactWebsite = String.Empty;
        protected String _cMContactAssistant = String.Empty;
        protected String _cMContactAssistantPhone = String.Empty;
        protected int _fK_CMClassificationID;
        protected int _fK_CMOriginID;
        protected Nullable<DateTime> _cMContactBDate;
        protected String _cMContactDesc = String.Empty;
        protected int _fK_CMCampaignID;
        protected bool _cMContactIsPublic = true;
        protected bool _cMContactNotCall = true;
        protected Nullable<DateTime> _cMContactDate;
        protected bool _cMContactIsActived = true;
        protected int _fK_ARSellerID;
        protected String _cMLeadSkype = String.Empty;
        protected String _cMLeadYahoo = String.Empty;
        protected String _cMLeadFacebook = String.Empty;
        protected int _fK_CMRegionID;
        protected double _cMContactCostAmt;
        #endregion

        #region Public properties
        public int CMContactID
        {
            get { return _cMContactID; }
            set
            {
                if (value != this._cMContactID)
                {
                    _cMContactID = value;
                    NotifyChanged("CMContactID");
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
        public String CMContactNo
        {
            get { return _cMContactNo; }
            set
            {
                if (value != this._cMContactNo)
                {
                    _cMContactNo = value;
                    NotifyChanged("CMContactNo");
                }
            }
        }
        public String CMContactVocative
        {
            get { return _cMContactVocative; }
            set
            {
                if (value != this._cMContactVocative)
                {
                    _cMContactVocative = value;
                    NotifyChanged("CMContactVocative");
                }
            }
        }
        public String CMContactLastName
        {
            get { return _cMContactLastName; }
            set
            {
                if (value != this._cMContactLastName)
                {
                    _cMContactLastName = value;
                    NotifyChanged("CMContactLastName");
                }
            }
        }
        public String CMContactFirstName
        {
            get { return _cMContactFirstName; }
            set
            {
                if (value != this._cMContactFirstName)
                {
                    _cMContactFirstName = value;
                    NotifyChanged("CMContactFirstName");
                }
            }
        }
        public String CMContactName
        {
            get { return _cMContactName; }
            set
            {
                if (value != this._cMContactName)
                {
                    _cMContactName = value;
                    NotifyChanged("CMContactName");
                }
            }
        }
        public int FK_CMAccountID
        {
            get { return _fK_CMAccountID; }
            set
            {
                if (value != this._fK_CMAccountID)
                {
                    _fK_CMAccountID = value;
                    NotifyChanged("FK_CMAccountID");
                }
            }
        }
        public int FK_CMPositionID
        {
            get { return _fK_CMPositionID; }
            set
            {
                if (value != this._fK_CMPositionID)
                {
                    _fK_CMPositionID = value;
                    NotifyChanged("FK_CMPositionID");
                }
            }
        }
        public int FK_CMSpecialityID
        {
            get { return _fK_CMSpecialityID; }
            set
            {
                if (value != this._fK_CMSpecialityID)
                {
                    _fK_CMSpecialityID = value;
                    NotifyChanged("FK_CMSpecialityID");
                }
            }
        }
        public String CMContactOfficePhone
        {
            get { return _cMContactOfficePhone; }
            set
            {
                if (value != this._cMContactOfficePhone)
                {
                    _cMContactOfficePhone = value;
                    NotifyChanged("CMContactOfficePhone");
                }
            }
        }
        public String CMContactHomePhone
        {
            get { return _cMContactHomePhone; }
            set
            {
                if (value != this._cMContactHomePhone)
                {
                    _cMContactHomePhone = value;
                    NotifyChanged("CMContactHomePhone");
                }
            }
        }
        public String CMContactMobile
        {
            get { return _cMContactMobile; }
            set
            {
                if (value != this._cMContactMobile)
                {
                    _cMContactMobile = value;
                    NotifyChanged("CMContactMobile");
                }
            }
        }
        public String CMContactOtherMobile
        {
            get { return _cMContactOtherMobile; }
            set
            {
                if (value != this._cMContactOtherMobile)
                {
                    _cMContactOtherMobile = value;
                    NotifyChanged("CMContactOtherMobile");
                }
            }
        }
        public String CMContactAgencyAddress
        {
            get { return _cMContactAgencyAddress; }
            set
            {
                if (value != this._cMContactAgencyAddress)
                {
                    _cMContactAgencyAddress = value;
                    NotifyChanged("CMContactAgencyAddress");
                }
            }
        }
        public String CMContactHomeAddress
        {
            get { return _cMContactHomeAddress; }
            set
            {
                if (value != this._cMContactHomeAddress)
                {
                    _cMContactHomeAddress = value;
                    NotifyChanged("CMContactHomeAddress");
                }
            }
        }
        public String CMContactFax
        {
            get { return _cMContactFax; }
            set
            {
                if (value != this._cMContactFax)
                {
                    _cMContactFax = value;
                    NotifyChanged("CMContactFax");
                }
            }
        }
        public String CMContactEmail
        {
            get { return _cMContactEmail; }
            set
            {
                if (value != this._cMContactEmail)
                {
                    _cMContactEmail = value;
                    NotifyChanged("CMContactEmail");
                }
            }
        }
        public String CMLeadOfficeEmail
        {
            get { return _cMLeadOfficeEmail; }
            set
            {
                if (value != this._cMLeadOfficeEmail)
                {
                    _cMLeadOfficeEmail = value;
                    NotifyChanged("CMLeadOfficeEmail");
                }
            }
        }
        public byte[] CMContactPicture
        {
            get { return _cMContactPicture; }
            set
            {
                if (value != this._cMContactPicture)
                {
                    _cMContactPicture = value;
                    NotifyChanged("CMContactPicture");
                }
            }
        }
        public String CMContactWebsite
        {
            get { return _cMContactWebsite; }
            set
            {
                if (value != this._cMContactWebsite)
                {
                    _cMContactWebsite = value;
                    NotifyChanged("CMContactWebsite");
                }
            }
        }
        public String CMContactAssistant
        {
            get { return _cMContactAssistant; }
            set
            {
                if (value != this._cMContactAssistant)
                {
                    _cMContactAssistant = value;
                    NotifyChanged("CMContactAssistant");
                }
            }
        }
        public String CMContactAssistantPhone
        {
            get { return _cMContactAssistantPhone; }
            set
            {
                if (value != this._cMContactAssistantPhone)
                {
                    _cMContactAssistantPhone = value;
                    NotifyChanged("CMContactAssistantPhone");
                }
            }
        }
        public int FK_CMClassificationID
        {
            get { return _fK_CMClassificationID; }
            set
            {
                if (value != this._fK_CMClassificationID)
                {
                    _fK_CMClassificationID = value;
                    NotifyChanged("FK_CMClassificationID");
                }
            }
        }
        public int FK_CMOriginID
        {
            get { return _fK_CMOriginID; }
            set
            {
                if (value != this._fK_CMOriginID)
                {
                    _fK_CMOriginID = value;
                    NotifyChanged("FK_CMOriginID");
                }
            }
        }
        public Nullable<DateTime> CMContactBDate
        {
            get { return _cMContactBDate; }
            set
            {
                if (value != this._cMContactBDate)
                {
                    _cMContactBDate = value;
                    NotifyChanged("CMContactBDate");
                }
            }
        }
        public String CMContactDesc
        {
            get { return _cMContactDesc; }
            set
            {
                if (value != this._cMContactDesc)
                {
                    _cMContactDesc = value;
                    NotifyChanged("CMContactDesc");
                }
            }
        }
        public int FK_CMCampaignID
        {
            get { return _fK_CMCampaignID; }
            set
            {
                if (value != this._fK_CMCampaignID)
                {
                    _fK_CMCampaignID = value;
                    NotifyChanged("FK_CMCampaignID");
                }
            }
        }
        public bool CMContactIsPublic
        {
            get { return _cMContactIsPublic; }
            set
            {
                if (value != this._cMContactIsPublic)
                {
                    _cMContactIsPublic = value;
                    NotifyChanged("CMContactIsPublic");
                }
            }
        }
        public bool CMContactNotCall
        {
            get { return _cMContactNotCall; }
            set
            {
                if (value != this._cMContactNotCall)
                {
                    _cMContactNotCall = value;
                    NotifyChanged("CMContactNotCall");
                }
            }
        }
        public Nullable<DateTime> CMContactDate
        {
            get { return _cMContactDate; }
            set
            {
                if (value != this._cMContactDate)
                {
                    _cMContactDate = value;
                    NotifyChanged("CMContactDate");
                }
            }
        }
        public bool CMContactIsActived
        {
            get { return _cMContactIsActived; }
            set
            {
                if (value != this._cMContactIsActived)
                {
                    _cMContactIsActived = value;
                    NotifyChanged("CMContactIsActived");
                }
            }
        }
        public int FK_ARSellerID
        {
            get { return _fK_ARSellerID; }
            set
            {
                if (value != this._fK_ARSellerID)
                {
                    _fK_ARSellerID = value;
                    NotifyChanged("FK_ARSellerID");
                }
            }
        }
        public String CMLeadSkype
        {
            get { return _cMLeadSkype; }
            set
            {
                if (value != this._cMLeadSkype)
                {
                    _cMLeadSkype = value;
                    NotifyChanged("CMLeadSkype");
                }
            }
        }
        public String CMLeadYahoo
        {
            get { return _cMLeadYahoo; }
            set
            {
                if (value != this._cMLeadYahoo)
                {
                    _cMLeadYahoo = value;
                    NotifyChanged("CMLeadYahoo");
                }
            }
        }
        public String CMLeadFacebook
        {
            get { return _cMLeadFacebook; }
            set
            {
                if (value != this._cMLeadFacebook)
                {
                    _cMLeadFacebook = value;
                    NotifyChanged("CMLeadFacebook");
                }
            }
        }
        public int FK_CMRegionID
        {
            get { return _fK_CMRegionID; }
            set
            {
                if (value != this._fK_CMRegionID)
                {
                    _fK_CMRegionID = value;
                    NotifyChanged("FK_CMRegionID");
                }
            }
        }
        public double CMContactCostAmt
        {
            get { return _cMContactCostAmt; }
            set
            {
                if (value != this._cMContactCostAmt)
                {
                    _cMContactCostAmt = value;
                    NotifyChanged("CMContactCostAmt");
                }
            }
        }
        #endregion
    }
    #endregion
}