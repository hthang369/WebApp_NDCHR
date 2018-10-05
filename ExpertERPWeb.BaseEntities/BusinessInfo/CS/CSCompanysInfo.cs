
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region CSCompanys
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.66)
    //Class: CSCompanysInfo
    //Created Date: Monday, 08 Aug 2016
    //-----------------------------------------------------------

    public class CSCompanysInfo : BusinessObject
    {
        public CSCompanysInfo()
        {
        }
        #region Variables
        protected int _cSCompanyID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_GECurrencyID;
        protected int _fK_GELanguageID;
        protected int _fK_BRBranchID;
        protected int _fK_ICStockID;
        protected String _cSCompanyDesc = String.Empty;
        protected String _cSCompanyLicenceNumber = String.Empty;
        protected Nullable<DateTime> _cSCompanyLicenceDate;
        protected String _cSCompanyVersionNumber = String.Empty;
        protected DateTime _cSCompanyVersionDate = DateTime.Now;
        protected String _cSCompanyAddressStreet = String.Empty;
        protected String _cSCompanyAddressLine1 = String.Empty;
        protected String _cSCompanyAddressLine2 = String.Empty;
        protected String _cSCompanyAddressLine3 = String.Empty;
        protected String _cSCompanyAddressCity = String.Empty;
        protected String _cSCompanyAddressPostalCode = String.Empty;
        protected String _cSCompanyAddressStateProvince = String.Empty;
        protected String _cSCompanyAddressZipCode = String.Empty;
        protected String _cSCompanyAddressCountry = String.Empty;
        protected String _cSCompanyEmail = String.Empty;
        protected String _cSCompanyWebsite = String.Empty;
        protected String _cSCompanyCellPhone = String.Empty;
        protected String _cSCompanyPhone = String.Empty;
        protected String _cSCompanyFax = String.Empty;
        protected String _cSCompanyInformation = String.Empty;
        protected byte[] _cSCompanyLogo;
        protected String _cSCompanyTaxNumber = String.Empty;
        protected String _cSCompanyBankName = String.Empty;
        protected String _cSCompanyBankCode = String.Empty;
        protected String _cSCompanyManager = String.Empty;
        protected bool _cSCompanyAllowNegativeInventory = true;
        protected String _cSCompanyNumDecSeparator = String.Empty;
        protected String _cSCompanyNumGroupSeparator = String.Empty;
        protected String _cSCompanyDateFormat = String.Empty;
        protected String _cSCompanyFileServerPath = String.Empty;
        protected String _cSCompanyFTP = String.Empty;
        protected String _cSCompanyFTPUserName = String.Empty;
        protected String _cSCompanyFTPPassword = String.Empty;
        protected bool _cSCompanyIsUserAudit = true;
        protected int _cSCompanyWarantyDefaultExpireDays;
        protected int _cSCompanyWarantyDefaultMainDays;
        protected int _cSCompanyWarantyDefaultWarningDays;
        protected int _cSCompanyCurrentYear;
        protected int _cSCompanyPreYear;
        protected String _cSCompanyTreasurer = String.Empty;
        protected String _cSCompanyCFO = String.Empty;
        protected String _cSCompanyAccPolicyNo = String.Empty;
        protected double _cSCompanyCurrency;
        protected int _cSCompanyBeginDay;
        protected int _cSCompanyBeginPeriod;
        protected Nullable<DateTime> _cSCompanyInputDataDate;
        protected int _fK_HRTreasurerID;
        protected bool _cSCompanyIsObjHistory = true;

        #endregion

        #region Public properties
        public int CSCompanyID
        {
            get { return _cSCompanyID; }
            set
            {
                if (value != this._cSCompanyID)
                {
                    _cSCompanyID = value;
                    NotifyChanged("CSCompanyID");
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
        public int FK_ICStockID
        {
            get { return _fK_ICStockID; }
            set
            {
                if (value != this._fK_ICStockID)
                {
                    _fK_ICStockID = value;
                    NotifyChanged("FK_ICStockID");
                }
            }
        }
        public String CSCompanyDesc
        {
            get { return _cSCompanyDesc; }
            set
            {
                if (value != this._cSCompanyDesc)
                {
                    _cSCompanyDesc = value;
                    NotifyChanged("CSCompanyDesc");
                }
            }
        }
        public String CSCompanyLicenceNumber
        {
            get { return _cSCompanyLicenceNumber; }
            set
            {
                if (value != this._cSCompanyLicenceNumber)
                {
                    _cSCompanyLicenceNumber = value;
                    NotifyChanged("CSCompanyLicenceNumber");
                }
            }
        }
        public Nullable<DateTime> CSCompanyLicenceDate
        {
            get { return _cSCompanyLicenceDate; }
            set
            {
                if (value != this._cSCompanyLicenceDate)
                {
                    _cSCompanyLicenceDate = value;
                    NotifyChanged("CSCompanyLicenceDate");
                }
            }
        }
        public String CSCompanyVersionNumber
        {
            get { return _cSCompanyVersionNumber; }
            set
            {
                if (value != this._cSCompanyVersionNumber)
                {
                    _cSCompanyVersionNumber = value;
                    NotifyChanged("CSCompanyVersionNumber");
                }
            }
        }
        public DateTime CSCompanyVersionDate
        {
            get { return _cSCompanyVersionDate; }
            set
            {
                if (value != this._cSCompanyVersionDate)
                {
                    _cSCompanyVersionDate = value;
                    NotifyChanged("CSCompanyVersionDate");
                }
            }
        }
        public String CSCompanyAddressStreet
        {
            get { return _cSCompanyAddressStreet; }
            set
            {
                if (value != this._cSCompanyAddressStreet)
                {
                    _cSCompanyAddressStreet = value;
                    NotifyChanged("CSCompanyAddressStreet");
                }
            }
        }
        public String CSCompanyAddressLine1
        {
            get { return _cSCompanyAddressLine1; }
            set
            {
                if (value != this._cSCompanyAddressLine1)
                {
                    _cSCompanyAddressLine1 = value;
                    NotifyChanged("CSCompanyAddressLine1");
                }
            }
        }
        public String CSCompanyAddressLine2
        {
            get { return _cSCompanyAddressLine2; }
            set
            {
                if (value != this._cSCompanyAddressLine2)
                {
                    _cSCompanyAddressLine2 = value;
                    NotifyChanged("CSCompanyAddressLine2");
                }
            }
        }
        public String CSCompanyAddressLine3
        {
            get { return _cSCompanyAddressLine3; }
            set
            {
                if (value != this._cSCompanyAddressLine3)
                {
                    _cSCompanyAddressLine3 = value;
                    NotifyChanged("CSCompanyAddressLine3");
                }
            }
        }
        public String CSCompanyAddressCity
        {
            get { return _cSCompanyAddressCity; }
            set
            {
                if (value != this._cSCompanyAddressCity)
                {
                    _cSCompanyAddressCity = value;
                    NotifyChanged("CSCompanyAddressCity");
                }
            }
        }
        public String CSCompanyAddressPostalCode
        {
            get { return _cSCompanyAddressPostalCode; }
            set
            {
                if (value != this._cSCompanyAddressPostalCode)
                {
                    _cSCompanyAddressPostalCode = value;
                    NotifyChanged("CSCompanyAddressPostalCode");
                }
            }
        }
        public String CSCompanyAddressStateProvince
        {
            get { return _cSCompanyAddressStateProvince; }
            set
            {
                if (value != this._cSCompanyAddressStateProvince)
                {
                    _cSCompanyAddressStateProvince = value;
                    NotifyChanged("CSCompanyAddressStateProvince");
                }
            }
        }
        public String CSCompanyAddressZipCode
        {
            get { return _cSCompanyAddressZipCode; }
            set
            {
                if (value != this._cSCompanyAddressZipCode)
                {
                    _cSCompanyAddressZipCode = value;
                    NotifyChanged("CSCompanyAddressZipCode");
                }
            }
        }
        public String CSCompanyAddressCountry
        {
            get { return _cSCompanyAddressCountry; }
            set
            {
                if (value != this._cSCompanyAddressCountry)
                {
                    _cSCompanyAddressCountry = value;
                    NotifyChanged("CSCompanyAddressCountry");
                }
            }
        }
        public String CSCompanyEmail
        {
            get { return _cSCompanyEmail; }
            set
            {
                if (value != this._cSCompanyEmail)
                {
                    _cSCompanyEmail = value;
                    NotifyChanged("CSCompanyEmail");
                }
            }
        }
        public String CSCompanyWebsite
        {
            get { return _cSCompanyWebsite; }
            set
            {
                if (value != this._cSCompanyWebsite)
                {
                    _cSCompanyWebsite = value;
                    NotifyChanged("CSCompanyWebsite");
                }
            }
        }
        public String CSCompanyCellPhone
        {
            get { return _cSCompanyCellPhone; }
            set
            {
                if (value != this._cSCompanyCellPhone)
                {
                    _cSCompanyCellPhone = value;
                    NotifyChanged("CSCompanyCellPhone");
                }
            }
        }
        public String CSCompanyPhone
        {
            get { return _cSCompanyPhone; }
            set
            {
                if (value != this._cSCompanyPhone)
                {
                    _cSCompanyPhone = value;
                    NotifyChanged("CSCompanyPhone");
                }
            }
        }
        public String CSCompanyFax
        {
            get { return _cSCompanyFax; }
            set
            {
                if (value != this._cSCompanyFax)
                {
                    _cSCompanyFax = value;
                    NotifyChanged("CSCompanyFax");
                }
            }
        }
        public String CSCompanyInformation
        {
            get { return _cSCompanyInformation; }
            set
            {
                if (value != this._cSCompanyInformation)
                {
                    _cSCompanyInformation = value;
                    NotifyChanged("CSCompanyInformation");
                }
            }
        }
        public byte[] CSCompanyLogo
        {
            get { return _cSCompanyLogo; }
            set
            {
                if (value != this._cSCompanyLogo)
                {
                    _cSCompanyLogo = value;
                    NotifyChanged("CSCompanyLogo");
                }
            }
        }
        public String CSCompanyTaxNumber
        {
            get { return _cSCompanyTaxNumber; }
            set
            {
                if (value != this._cSCompanyTaxNumber)
                {
                    _cSCompanyTaxNumber = value;
                    NotifyChanged("CSCompanyTaxNumber");
                }
            }
        }
        public String CSCompanyBankName
        {
            get { return _cSCompanyBankName; }
            set
            {
                if (value != this._cSCompanyBankName)
                {
                    _cSCompanyBankName = value;
                    NotifyChanged("CSCompanyBankName");
                }
            }
        }
        public String CSCompanyBankCode
        {
            get { return _cSCompanyBankCode; }
            set
            {
                if (value != this._cSCompanyBankCode)
                {
                    _cSCompanyBankCode = value;
                    NotifyChanged("CSCompanyBankCode");
                }
            }
        }
        public String CSCompanyManager
        {
            get { return _cSCompanyManager; }
            set
            {
                if (value != this._cSCompanyManager)
                {
                    _cSCompanyManager = value;
                    NotifyChanged("CSCompanyManager");
                }
            }
        }
        public bool CSCompanyAllowNegativeInventory
        {
            get { return _cSCompanyAllowNegativeInventory; }
            set
            {
                if (value != this._cSCompanyAllowNegativeInventory)
                {
                    _cSCompanyAllowNegativeInventory = value;
                    NotifyChanged("CSCompanyAllowNegativeInventory");
                }
            }
        }
        public String CSCompanyNumDecSeparator
        {
            get { return _cSCompanyNumDecSeparator; }
            set
            {
                if (value != this._cSCompanyNumDecSeparator)
                {
                    _cSCompanyNumDecSeparator = value;
                    NotifyChanged("CSCompanyNumDecSeparator");
                }
            }
        }
        public String CSCompanyNumGroupSeparator
        {
            get { return _cSCompanyNumGroupSeparator; }
            set
            {
                if (value != this._cSCompanyNumGroupSeparator)
                {
                    _cSCompanyNumGroupSeparator = value;
                    NotifyChanged("CSCompanyNumGroupSeparator");
                }
            }
        }
        public String CSCompanyDateFormat
        {
            get { return _cSCompanyDateFormat; }
            set
            {
                if (value != this._cSCompanyDateFormat)
                {
                    _cSCompanyDateFormat = value;
                    NotifyChanged("CSCompanyDateFormat");
                }
            }
        }
        public String CSCompanyFileServerPath
        {
            get { return _cSCompanyFileServerPath; }
            set
            {
                if (value != this._cSCompanyFileServerPath)
                {
                    _cSCompanyFileServerPath = value;
                    NotifyChanged("CSCompanyFileServerPath");
                }
            }
        }
        public String CSCompanyFTP
        {
            get { return _cSCompanyFTP; }
            set
            {
                if (value != this._cSCompanyFTP)
                {
                    _cSCompanyFTP = value;
                    NotifyChanged("CSCompanyFTP");
                }
            }
        }
        public String CSCompanyFTPUserName
        {
            get { return _cSCompanyFTPUserName; }
            set
            {
                if (value != this._cSCompanyFTPUserName)
                {
                    _cSCompanyFTPUserName = value;
                    NotifyChanged("CSCompanyFTPUserName");
                }
            }
        }
        public String CSCompanyFTPPassword
        {
            get { return _cSCompanyFTPPassword; }
            set
            {
                if (value != this._cSCompanyFTPPassword)
                {
                    _cSCompanyFTPPassword = value;
                    NotifyChanged("CSCompanyFTPPassword");
                }
            }
        }
        public bool CSCompanyIsUserAudit
        {
            get { return _cSCompanyIsUserAudit; }
            set
            {
                if (value != this._cSCompanyIsUserAudit)
                {
                    _cSCompanyIsUserAudit = value;
                    NotifyChanged("CSCompanyIsUserAudit");
                }
            }
        }
        public int CSCompanyWarantyDefaultExpireDays
        {
            get { return _cSCompanyWarantyDefaultExpireDays; }
            set
            {
                if (value != this._cSCompanyWarantyDefaultExpireDays)
                {
                    _cSCompanyWarantyDefaultExpireDays = value;
                    NotifyChanged("CSCompanyWarantyDefaultExpireDays");
                }
            }
        }
        public int CSCompanyWarantyDefaultMainDays
        {
            get { return _cSCompanyWarantyDefaultMainDays; }
            set
            {
                if (value != this._cSCompanyWarantyDefaultMainDays)
                {
                    _cSCompanyWarantyDefaultMainDays = value;
                    NotifyChanged("CSCompanyWarantyDefaultMainDays");
                }
            }
        }
        public int CSCompanyWarantyDefaultWarningDays
        {
            get { return _cSCompanyWarantyDefaultWarningDays; }
            set
            {
                if (value != this._cSCompanyWarantyDefaultWarningDays)
                {
                    _cSCompanyWarantyDefaultWarningDays = value;
                    NotifyChanged("CSCompanyWarantyDefaultWarningDays");
                }
            }
        }
        public int CSCompanyCurrentYear
        {
            get { return _cSCompanyCurrentYear; }
            set
            {
                if (value != this._cSCompanyCurrentYear)
                {
                    _cSCompanyCurrentYear = value;
                    NotifyChanged("CSCompanyCurrentYear");
                }
            }
        }
        public int CSCompanyPreYear
        {
            get { return _cSCompanyPreYear; }
            set
            {
                if (value != this._cSCompanyPreYear)
                {
                    _cSCompanyPreYear = value;
                    NotifyChanged("CSCompanyPreYear");
                }
            }
        }
        public String CSCompanyTreasurer
        {
            get { return _cSCompanyTreasurer; }
            set
            {
                if (value != this._cSCompanyTreasurer)
                {
                    _cSCompanyTreasurer = value;
                    NotifyChanged("CSCompanyTreasurer");
                }
            }
        }
        public String CSCompanyCFO
        {
            get { return _cSCompanyCFO; }
            set
            {
                if (value != this._cSCompanyCFO)
                {
                    _cSCompanyCFO = value;
                    NotifyChanged("CSCompanyCFO");
                }
            }
        }
        public String CSCompanyAccPolicyNo
        {
            get { return _cSCompanyAccPolicyNo; }
            set
            {
                if (value != this._cSCompanyAccPolicyNo)
                {
                    _cSCompanyAccPolicyNo = value;
                    NotifyChanged("CSCompanyAccPolicyNo");
                }
            }
        }
        public double CSCompanyCurrency
        {
            get { return _cSCompanyCurrency; }
            set
            {
                if (value != this._cSCompanyCurrency)
                {
                    _cSCompanyCurrency = value;
                    NotifyChanged("CSCompanyCurrency");
                }
            }
        }
        public int CSCompanyBeginDay
        {
            get { return _cSCompanyBeginDay; }
            set
            {
                if (value != this._cSCompanyBeginDay)
                {
                    _cSCompanyBeginDay = value;
                    NotifyChanged("CSCompanyBeginDay");
                }
            }
        }
        public int CSCompanyBeginPeriod
        {
            get { return _cSCompanyBeginPeriod; }
            set
            {
                if (value != this._cSCompanyBeginPeriod)
                {
                    _cSCompanyBeginPeriod = value;
                    NotifyChanged("CSCompanyBeginPeriod");
                }
            }
        }
        public Nullable<DateTime> CSCompanyInputDataDate
        {
            get { return _cSCompanyInputDataDate; }
            set
            {
                if (value != this._cSCompanyInputDataDate)
                {
                    _cSCompanyInputDataDate = value;
                    NotifyChanged("CSCompanyInputDataDate");
                }
            }
        }
        public int FK_HRTreasurerID
        {
            get { return _fK_HRTreasurerID; }
            set
            {
                if (value != this._fK_HRTreasurerID)
                {
                    _fK_HRTreasurerID = value;
                    NotifyChanged("FK_HRTreasurerID");
                }
            }
        }
        public bool CSCompanyIsObjHistory
        {
            get { return _cSCompanyIsObjHistory; }
            set
            {
                if (value != this._cSCompanyIsObjHistory)
                {
                    _cSCompanyIsObjHistory = value;
                    NotifyChanged("CSCompanyIsObjHistory");
                }
            }
        }

        #endregion
    }
    #endregion
}