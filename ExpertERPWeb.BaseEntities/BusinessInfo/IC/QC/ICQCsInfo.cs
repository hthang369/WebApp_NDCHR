using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICQCs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class: ICQCsInfo
    //Created Date: 11 Mar 2015
    //-----------------------------------------------------------

    public class ICQCsInfo : BusinessObject
    {
        public ICQCsInfo()
        {
        }
        #region Variables
		protected int _iCQCID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_GELanguageID;
		protected int _fK_GECurrencyID;
		protected int _fK_GEShpMthID;
		protected int _fK_APSupplierID;
		protected int _fK_ARSellerID;
		protected int _fK_ARPriceListID;
		protected int _fK_BRBranchID;
		protected int _fK_ICStockID;
		protected String _iCQCStatusCombo=DefaultStatus;
		protected String _iCPmtMthCombo=String.Empty;
		protected String _iCQCNo=String.Empty;
		protected String _iCQCName=String.Empty;
		protected String _iCQCDesc=String.Empty;
		protected String _iCQCText=String.Empty;
		protected Nullable<DateTime> _iCQCDate;
		protected double _iCQCDiscPct;
		protected String _iCQCTxNo=String.Empty;
		protected double _iCQCExcRate;
		protected double _iCQCTxAmtTot;
		protected double _iCQCNetAmtTot;
		protected double _iCQCAmtTot;
		protected double _iCQCCostTot;
		protected int _fK_HREmployeeID;
		protected int _fK_PPWOID;
		protected String _aAPostStatus=DefaultStatus;
		protected int _fK_PMProjectID;
		protected int _fK_ARCustomerID;
		protected String _aALastPostNo=String.Empty;
		protected Nullable<DateTime> _aALastPostDate;
		protected String _iCQCContractNo=String.Empty;
		protected Nullable<DateTime> _iCQCContractDate;
		protected double _iCQCTxFAmtTot;
		protected double _iCQCNetFAmtTot;
		protected double _iCQCRAmtTot;
		protected double _iCQCRFAmtTot;
		protected int _fK_ARContractID;
		protected String _iCQCApprovalStatusCombo=DefaultStatus;
		protected String _approvalStatusCombo=DefaultStatus;
		protected String _iCQCInvNo=String.Empty;
		protected String _iCQCInvSerie=String.Empty;
		protected int _fK_GLTranCfgID;
		protected String _iCQCLotNo=String.Empty;
		protected String _aACompanyTypeCombo=String.Empty;
		protected String _aAThueRemark=String.Empty;
		protected String _aAOrgDocNo=String.Empty;
		protected String _iCQCTypeCombo=String.Empty;
		protected Nullable<DateTime> _iCQCJrnDate;
		
        #endregion

        #region Public properties
		public int ICQCID
		{
			get{return _iCQCID;}
			set
			{
				if (value != this._iCQCID)
				{
					_iCQCID=value;
					NotifyChanged("ICQCID");
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
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
					_aASelected=value;
					NotifyChanged("AASelected");
				}
			}
		}
		public int FK_GELanguageID
		{
			get{return _fK_GELanguageID;}
			set
			{
				if (value != this._fK_GELanguageID)
				{
					_fK_GELanguageID=value;
					NotifyChanged("FK_GELanguageID");
				}
			}
		}
		public int FK_GECurrencyID
		{
			get{return _fK_GECurrencyID;}
			set
			{
				if (value != this._fK_GECurrencyID)
				{
					_fK_GECurrencyID=value;
					NotifyChanged("FK_GECurrencyID");
				}
			}
		}
		public int FK_GEShpMthID
		{
			get{return _fK_GEShpMthID;}
			set
			{
				if (value != this._fK_GEShpMthID)
				{
					_fK_GEShpMthID=value;
					NotifyChanged("FK_GEShpMthID");
				}
			}
		}
		public int FK_APSupplierID
		{
			get{return _fK_APSupplierID;}
			set
			{
				if (value != this._fK_APSupplierID)
				{
					_fK_APSupplierID=value;
					NotifyChanged("FK_APSupplierID");
				}
			}
		}
		public int FK_ARSellerID
		{
			get{return _fK_ARSellerID;}
			set
			{
				if (value != this._fK_ARSellerID)
				{
					_fK_ARSellerID=value;
					NotifyChanged("FK_ARSellerID");
				}
			}
		}
		public int FK_ARPriceListID
		{
			get{return _fK_ARPriceListID;}
			set
			{
				if (value != this._fK_ARPriceListID)
				{
					_fK_ARPriceListID=value;
					NotifyChanged("FK_ARPriceListID");
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
		public int FK_ICStockID
		{
			get{return _fK_ICStockID;}
			set
			{
				if (value != this._fK_ICStockID)
				{
					_fK_ICStockID=value;
					NotifyChanged("FK_ICStockID");
				}
			}
		}
		public String ICQCStatusCombo
		{
			get{return _iCQCStatusCombo;}
			set
			{
				if (value != this._iCQCStatusCombo)
				{
					_iCQCStatusCombo=value;
					NotifyChanged("ICQCStatusCombo");
				}
			}
		}
		public String ICPmtMthCombo
		{
			get{return _iCPmtMthCombo;}
			set
			{
				if (value != this._iCPmtMthCombo)
				{
					_iCPmtMthCombo=value;
					NotifyChanged("ICPmtMthCombo");
				}
			}
		}
		public String ICQCNo
		{
			get{return _iCQCNo;}
			set
			{
				if (value != this._iCQCNo)
				{
					_iCQCNo=value;
					NotifyChanged("ICQCNo");
				}
			}
		}
		public String ICQCName
		{
			get{return _iCQCName;}
			set
			{
				if (value != this._iCQCName)
				{
					_iCQCName=value;
					NotifyChanged("ICQCName");
				}
			}
		}
		public String ICQCDesc
		{
			get{return _iCQCDesc;}
			set
			{
				if (value != this._iCQCDesc)
				{
					_iCQCDesc=value;
					NotifyChanged("ICQCDesc");
				}
			}
		}
		public String ICQCText
		{
			get{return _iCQCText;}
			set
			{
				if (value != this._iCQCText)
				{
					_iCQCText=value;
					NotifyChanged("ICQCText");
				}
			}
		}
		public Nullable<DateTime> ICQCDate
		{
			get{return _iCQCDate;}
			set
			{
				if (value != this._iCQCDate)
				{
					_iCQCDate=value;
					NotifyChanged("ICQCDate");
				}
			}
		}
		public double ICQCDiscPct
		{
			get{return _iCQCDiscPct;}
			set
			{
				if (value != this._iCQCDiscPct)
				{
					_iCQCDiscPct=value;
					NotifyChanged("ICQCDiscPct");
				}
			}
		}
		public String ICQCTxNo
		{
			get{return _iCQCTxNo;}
			set
			{
				if (value != this._iCQCTxNo)
				{
					_iCQCTxNo=value;
					NotifyChanged("ICQCTxNo");
				}
			}
		}
		public double ICQCExcRate
		{
			get{return _iCQCExcRate;}
			set
			{
				if (value != this._iCQCExcRate)
				{
					_iCQCExcRate=value;
					NotifyChanged("ICQCExcRate");
				}
			}
		}
		public double ICQCTxAmtTot
		{
			get{return _iCQCTxAmtTot;}
			set
			{
				if (value != this._iCQCTxAmtTot)
				{
					_iCQCTxAmtTot=value;
					NotifyChanged("ICQCTxAmtTot");
				}
			}
		}
		public double ICQCNetAmtTot
		{
			get{return _iCQCNetAmtTot;}
			set
			{
				if (value != this._iCQCNetAmtTot)
				{
					_iCQCNetAmtTot=value;
					NotifyChanged("ICQCNetAmtTot");
				}
			}
		}
		public double ICQCAmtTot
		{
			get{return _iCQCAmtTot;}
			set
			{
				if (value != this._iCQCAmtTot)
				{
					_iCQCAmtTot=value;
					NotifyChanged("ICQCAmtTot");
				}
			}
		}
		public double ICQCCostTot
		{
			get{return _iCQCCostTot;}
			set
			{
				if (value != this._iCQCCostTot)
				{
					_iCQCCostTot=value;
					NotifyChanged("ICQCCostTot");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get{return _fK_HREmployeeID;}
			set
			{
				if (value != this._fK_HREmployeeID)
				{
					_fK_HREmployeeID=value;
					NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public int FK_PPWOID
		{
			get{return _fK_PPWOID;}
			set
			{
				if (value != this._fK_PPWOID)
				{
					_fK_PPWOID=value;
					NotifyChanged("FK_PPWOID");
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
		public int FK_PMProjectID
		{
			get{return _fK_PMProjectID;}
			set
			{
				if (value != this._fK_PMProjectID)
				{
					_fK_PMProjectID=value;
					NotifyChanged("FK_PMProjectID");
				}
			}
		}
		public int FK_ARCustomerID
		{
			get{return _fK_ARCustomerID;}
			set
			{
				if (value != this._fK_ARCustomerID)
				{
					_fK_ARCustomerID=value;
					NotifyChanged("FK_ARCustomerID");
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
		public String ICQCContractNo
		{
			get{return _iCQCContractNo;}
			set
			{
				if (value != this._iCQCContractNo)
				{
					_iCQCContractNo=value;
					NotifyChanged("ICQCContractNo");
				}
			}
		}
		public Nullable<DateTime> ICQCContractDate
		{
			get{return _iCQCContractDate;}
			set
			{
				if (value != this._iCQCContractDate)
				{
					_iCQCContractDate=value;
					NotifyChanged("ICQCContractDate");
				}
			}
		}
		public double ICQCTxFAmtTot
		{
			get{return _iCQCTxFAmtTot;}
			set
			{
				if (value != this._iCQCTxFAmtTot)
				{
					_iCQCTxFAmtTot=value;
					NotifyChanged("ICQCTxFAmtTot");
				}
			}
		}
		public double ICQCNetFAmtTot
		{
			get{return _iCQCNetFAmtTot;}
			set
			{
				if (value != this._iCQCNetFAmtTot)
				{
					_iCQCNetFAmtTot=value;
					NotifyChanged("ICQCNetFAmtTot");
				}
			}
		}
		public double ICQCRAmtTot
		{
			get{return _iCQCRAmtTot;}
			set
			{
				if (value != this._iCQCRAmtTot)
				{
					_iCQCRAmtTot=value;
					NotifyChanged("ICQCRAmtTot");
				}
			}
		}
		public double ICQCRFAmtTot
		{
			get{return _iCQCRFAmtTot;}
			set
			{
				if (value != this._iCQCRFAmtTot)
				{
					_iCQCRFAmtTot=value;
					NotifyChanged("ICQCRFAmtTot");
				}
			}
		}
		public int FK_ARContractID
		{
			get{return _fK_ARContractID;}
			set
			{
				if (value != this._fK_ARContractID)
				{
					_fK_ARContractID=value;
					NotifyChanged("FK_ARContractID");
				}
			}
		}
		public String ICQCApprovalStatusCombo
		{
			get{return _iCQCApprovalStatusCombo;}
			set
			{
				if (value != this._iCQCApprovalStatusCombo)
				{
					_iCQCApprovalStatusCombo=value;
					NotifyChanged("ICQCApprovalStatusCombo");
				}
			}
		}
		public String ApprovalStatusCombo
		{
			get{return _approvalStatusCombo;}
			set
			{
				if (value != this._approvalStatusCombo)
				{
					_approvalStatusCombo=value;
					NotifyChanged("ApprovalStatusCombo");
				}
			}
		}
		public String ICQCInvNo
		{
			get{return _iCQCInvNo;}
			set
			{
				if (value != this._iCQCInvNo)
				{
					_iCQCInvNo=value;
					NotifyChanged("ICQCInvNo");
				}
			}
		}
		public String ICQCInvSerie
		{
			get{return _iCQCInvSerie;}
			set
			{
				if (value != this._iCQCInvSerie)
				{
					_iCQCInvSerie=value;
					NotifyChanged("ICQCInvSerie");
				}
			}
		}
		public int FK_GLTranCfgID
		{
			get{return _fK_GLTranCfgID;}
			set
			{
				if (value != this._fK_GLTranCfgID)
				{
					_fK_GLTranCfgID=value;
					NotifyChanged("FK_GLTranCfgID");
				}
			}
		}
		public String ICQCLotNo
		{
			get{return _iCQCLotNo;}
			set
			{
				if (value != this._iCQCLotNo)
				{
					_iCQCLotNo=value;
					NotifyChanged("ICQCLotNo");
				}
			}
		}
		public String AACompanyTypeCombo
		{
			get{return _aACompanyTypeCombo;}
			set
			{
				if (value != this._aACompanyTypeCombo)
				{
					_aACompanyTypeCombo=value;
					NotifyChanged("AACompanyTypeCombo");
				}
			}
		}
		public String AAThueRemark
		{
			get{return _aAThueRemark;}
			set
			{
				if (value != this._aAThueRemark)
				{
					_aAThueRemark=value;
					NotifyChanged("AAThueRemark");
				}
			}
		}
		public String AAOrgDocNo
		{
			get{return _aAOrgDocNo;}
			set
			{
				if (value != this._aAOrgDocNo)
				{
					_aAOrgDocNo=value;
					NotifyChanged("AAOrgDocNo");
				}
			}
		}
		public String ICQCTypeCombo
		{
			get{return _iCQCTypeCombo;}
			set
			{
				if (value != this._iCQCTypeCombo)
				{
					_iCQCTypeCombo=value;
					NotifyChanged("ICQCTypeCombo");
				}
			}
		}
		public Nullable<DateTime> ICQCJrnDate
		{
			get{return _iCQCJrnDate;}
			set
			{
				if (value != this._iCQCJrnDate)
				{
					_iCQCJrnDate=value;
					NotifyChanged("ICQCJrnDate");
				}
			}
		}
		
        #endregion
    }
    #endregion
}