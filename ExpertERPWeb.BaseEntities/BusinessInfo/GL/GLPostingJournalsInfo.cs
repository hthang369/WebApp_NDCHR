using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region GLPostingJournals
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:GLPostingJournalsInfo
	//Created Date:15 Tháng Mười 2013
	//-----------------------------------------------------------
	
	public class GLPostingJournalsInfo:BusinessObject
	{
		public GLPostingJournalsInfo()
		{
		}
		#region Variables
		protected int _gLPostingJournalID;
		protected Nullable<DateTime> _gLPostingJournalDate;
		protected String _gLPostingJournalNo=String.Empty;
		protected int _fK_GECurrencyID;
		protected double _gLPostingJournalExRate;
		protected int _fK_BRBranchID;
		protected int _fK_BRAgentID;
		protected int _fK_ICBrandID;
		protected int _fK_GLDebitAccountID;
		protected int _fK_GLCreditAccountID;
		protected String _gLPostingJournalDesc=String.Empty;
		protected double _gLPostingJournalAmt;
		protected double _gLPostingJournalFAmt;
		protected int _fK_ARCustomerID;
		protected int _fK_APSupplierID;
		protected int _fK_HREmployeeID;
		protected int _fK_ICProductID;
		protected int _fK_FAAssetID;
		protected int _gLPostingJournalYear;
		protected int _gLPostingJournalPeriod;
		protected int _fK_GLJobID;
		protected String _gLPostingJournalDocumentNo=String.Empty;
		protected String _gLPostingJournalSubLedger=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected String _gLPostingJournalSubLedgerTypeCombo=String.Empty;
		protected String _gLPostingJournalInvNo=String.Empty;
		protected String _gLPostingJournalInvSerie=String.Empty;
		protected Nullable<DateTime> _gLPostingJournalInvDate;
		protected String _gLPostingJournalObjectName=String.Empty;
		protected String _gLPostingJournalObjectTaxCode=String.Empty;
		protected String _gLPostingJournalObjectAdd=String.Empty;
		protected int _fK_ICProductGroupID;
		protected int _fK_HRDepartmentID;
		protected int _fK_GLBankID;
		protected double _gLPostingJournalItemAmt;
		protected double _gLPostingJournalItemUPrice;
		protected double _gLPostingJournalItemQty;
		protected int _fK_TXTaxCodeID;
		protected int _fK_GLCostCenterID;
		protected String _gLSourceLeger=String.Empty;
		protected String _gLPostingJournalHDesc=String.Empty;
		protected int _fK_GLConsolidateGroupID;
		protected int _fK_PPWOID;
		protected int _fK_PPPhaseID;
		protected String _gLPostingJournalTKNo=String.Empty;
		protected String _gLPostingJournalBookingNo=String.Empty;
		protected int _fK_PMProjectID;
		protected bool _aASelected=true;
		protected Nullable<DateTime> _gLPostingJournalExchangeDate;
		protected Nullable<DateTime> _gLPostingJournalDocDate;
		protected int _fK_GLCostDistID;
		protected int _fK_GLProfitDistID;
		protected double _gLPostingJournalTempAmt;
		protected Nullable<DateTime> _gLPostingJournalDueDate;
		protected String _gLSourceLedger=String.Empty;
		protected int _fK_GLCostAllocateID;
		protected int _fK_GLCostCenter1ID;
		protected int _fK_GLCostCenter2ID;
		protected int _fK_GLCostCenter3ID;
		protected int _fK_GLCostCenter4ID;
		protected int _fK_GLCostCenter5ID;
		protected String _gLObjectName=String.Empty;
		protected String _gLObjectVATTaxCode=String.Empty;
		protected String _gLObjectDesc=String.Empty;
		protected String _aACompanyTypeCombo=String.Empty;
		protected String _gLPostingJournalMapDebitAccountNo=String.Empty;
		protected String _gLPostingJournalMapCreditAccountNo=String.Empty;
		protected String _gLPostingJournalUNCNo=String.Empty;
		protected int _fK_GLPostingHistoryID;
		#endregion

		#region Public properties
		public int GLPostingJournalID
		{
			get{return _gLPostingJournalID;}
			set
			{
				if (value != this._gLPostingJournalID)
				{
				_gLPostingJournalID=value;
				NotifyChanged("GLPostingJournalID");
				}
			}
		}
		public Nullable<DateTime> GLPostingJournalDate
		{
			get{return _gLPostingJournalDate;}
			set
			{
				if (value != this._gLPostingJournalDate)
				{
				_gLPostingJournalDate=value;
				NotifyChanged("GLPostingJournalDate");
				}
			}
		}
		public String GLPostingJournalNo
		{
			get{return _gLPostingJournalNo;}
			set
			{
				if (value != this._gLPostingJournalNo)
				{
				_gLPostingJournalNo=value;
				NotifyChanged("GLPostingJournalNo");
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
		public double GLPostingJournalExRate
		{
			get{return _gLPostingJournalExRate;}
			set
			{
				if (value != this._gLPostingJournalExRate)
				{
				_gLPostingJournalExRate=value;
				NotifyChanged("GLPostingJournalExRate");
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
		public int FK_BRAgentID
		{
			get{return _fK_BRAgentID;}
			set
			{
				if (value != this._fK_BRAgentID)
				{
				_fK_BRAgentID=value;
				NotifyChanged("FK_BRAgentID");
				}
			}
		}
		public int FK_ICBrandID
		{
			get{return _fK_ICBrandID;}
			set
			{
				if (value != this._fK_ICBrandID)
				{
				_fK_ICBrandID=value;
				NotifyChanged("FK_ICBrandID");
				}
			}
		}
		public int FK_GLDebitAccountID
		{
			get{return _fK_GLDebitAccountID;}
			set
			{
				if (value != this._fK_GLDebitAccountID)
				{
				_fK_GLDebitAccountID=value;
				NotifyChanged("FK_GLDebitAccountID");
				}
			}
		}
		public int FK_GLCreditAccountID
		{
			get{return _fK_GLCreditAccountID;}
			set
			{
				if (value != this._fK_GLCreditAccountID)
				{
				_fK_GLCreditAccountID=value;
				NotifyChanged("FK_GLCreditAccountID");
				}
			}
		}
		public String GLPostingJournalDesc
		{
			get{return _gLPostingJournalDesc;}
			set
			{
				if (value != this._gLPostingJournalDesc)
				{
				_gLPostingJournalDesc=value;
				NotifyChanged("GLPostingJournalDesc");
				}
			}
		}
		public double GLPostingJournalAmt
		{
			get{return _gLPostingJournalAmt;}
			set
			{
				if (value != this._gLPostingJournalAmt)
				{
				_gLPostingJournalAmt=value;
				NotifyChanged("GLPostingJournalAmt");
				}
			}
		}
		public double GLPostingJournalFAmt
		{
			get{return _gLPostingJournalFAmt;}
			set
			{
				if (value != this._gLPostingJournalFAmt)
				{
				_gLPostingJournalFAmt=value;
				NotifyChanged("GLPostingJournalFAmt");
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
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				NotifyChanged("FK_ICProductID");
				}
			}
		}
		public int FK_FAAssetID
		{
			get{return _fK_FAAssetID;}
			set
			{
				if (value != this._fK_FAAssetID)
				{
				_fK_FAAssetID=value;
				NotifyChanged("FK_FAAssetID");
				}
			}
		}
		public int GLPostingJournalYear
		{
			get{return _gLPostingJournalYear;}
			set
			{
				if (value != this._gLPostingJournalYear)
				{
				_gLPostingJournalYear=value;
				NotifyChanged("GLPostingJournalYear");
				}
			}
		}
		public int GLPostingJournalPeriod
		{
			get{return _gLPostingJournalPeriod;}
			set
			{
				if (value != this._gLPostingJournalPeriod)
				{
				_gLPostingJournalPeriod=value;
				NotifyChanged("GLPostingJournalPeriod");
				}
			}
		}
		public int FK_GLJobID
		{
			get{return _fK_GLJobID;}
			set
			{
				if (value != this._fK_GLJobID)
				{
				_fK_GLJobID=value;
				NotifyChanged("FK_GLJobID");
				}
			}
		}
		public String GLPostingJournalDocumentNo
		{
			get{return _gLPostingJournalDocumentNo;}
			set
			{
				if (value != this._gLPostingJournalDocumentNo)
				{
				_gLPostingJournalDocumentNo=value;
				NotifyChanged("GLPostingJournalDocumentNo");
				}
			}
		}
		public String GLPostingJournalSubLedger
		{
			get{return _gLPostingJournalSubLedger;}
			set
			{
				if (value != this._gLPostingJournalSubLedger)
				{
				_gLPostingJournalSubLedger=value;
				NotifyChanged("GLPostingJournalSubLedger");
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
		public String GLPostingJournalSubLedgerTypeCombo
		{
			get{return _gLPostingJournalSubLedgerTypeCombo;}
			set
			{
				if (value != this._gLPostingJournalSubLedgerTypeCombo)
				{
				_gLPostingJournalSubLedgerTypeCombo=value;
				NotifyChanged("GLPostingJournalSubLedgerTypeCombo");
				}
			}
		}
		public String GLPostingJournalInvNo
		{
			get{return _gLPostingJournalInvNo;}
			set
			{
				if (value != this._gLPostingJournalInvNo)
				{
				_gLPostingJournalInvNo=value;
				NotifyChanged("GLPostingJournalInvNo");
				}
			}
		}
		public String GLPostingJournalInvSerie
		{
			get{return _gLPostingJournalInvSerie;}
			set
			{
				if (value != this._gLPostingJournalInvSerie)
				{
				_gLPostingJournalInvSerie=value;
				NotifyChanged("GLPostingJournalInvSerie");
				}
			}
		}
		public Nullable<DateTime> GLPostingJournalInvDate
		{
			get{return _gLPostingJournalInvDate;}
			set
			{
				if (value != this._gLPostingJournalInvDate)
				{
				_gLPostingJournalInvDate=value;
				NotifyChanged("GLPostingJournalInvDate");
				}
			}
		}
		public String GLPostingJournalObjectName
		{
			get{return _gLPostingJournalObjectName;}
			set
			{
				if (value != this._gLPostingJournalObjectName)
				{
				_gLPostingJournalObjectName=value;
				NotifyChanged("GLPostingJournalObjectName");
				}
			}
		}
		public String GLPostingJournalObjectTaxCode
		{
			get{return _gLPostingJournalObjectTaxCode;}
			set
			{
				if (value != this._gLPostingJournalObjectTaxCode)
				{
				_gLPostingJournalObjectTaxCode=value;
				NotifyChanged("GLPostingJournalObjectTaxCode");
				}
			}
		}
		public String GLPostingJournalObjectAdd
		{
			get{return _gLPostingJournalObjectAdd;}
			set
			{
				if (value != this._gLPostingJournalObjectAdd)
				{
				_gLPostingJournalObjectAdd=value;
				NotifyChanged("GLPostingJournalObjectAdd");
				}
			}
		}
		public int FK_ICProductGroupID
		{
			get{return _fK_ICProductGroupID;}
			set
			{
				if (value != this._fK_ICProductGroupID)
				{
				_fK_ICProductGroupID=value;
				NotifyChanged("FK_ICProductGroupID");
				}
			}
		}
		public int FK_HRDepartmentID
		{
			get{return _fK_HRDepartmentID;}
			set
			{
				if (value != this._fK_HRDepartmentID)
				{
				_fK_HRDepartmentID=value;
				NotifyChanged("FK_HRDepartmentID");
				}
			}
		}
		public int FK_GLBankID
		{
			get{return _fK_GLBankID;}
			set
			{
				if (value != this._fK_GLBankID)
				{
				_fK_GLBankID=value;
				NotifyChanged("FK_GLBankID");
				}
			}
		}
		public double GLPostingJournalItemAmt
		{
			get{return _gLPostingJournalItemAmt;}
			set
			{
				if (value != this._gLPostingJournalItemAmt)
				{
				_gLPostingJournalItemAmt=value;
				NotifyChanged("GLPostingJournalItemAmt");
				}
			}
		}
		public double GLPostingJournalItemUPrice
		{
			get{return _gLPostingJournalItemUPrice;}
			set
			{
				if (value != this._gLPostingJournalItemUPrice)
				{
				_gLPostingJournalItemUPrice=value;
				NotifyChanged("GLPostingJournalItemUPrice");
				}
			}
		}
		public double GLPostingJournalItemQty
		{
			get{return _gLPostingJournalItemQty;}
			set
			{
				if (value != this._gLPostingJournalItemQty)
				{
				_gLPostingJournalItemQty=value;
				NotifyChanged("GLPostingJournalItemQty");
				}
			}
		}
		public int FK_TXTaxCodeID
		{
			get{return _fK_TXTaxCodeID;}
			set
			{
				if (value != this._fK_TXTaxCodeID)
				{
				_fK_TXTaxCodeID=value;
				NotifyChanged("FK_TXTaxCodeID");
				}
			}
		}
		public int FK_GLCostCenterID
		{
			get{return _fK_GLCostCenterID;}
			set
			{
				if (value != this._fK_GLCostCenterID)
				{
				_fK_GLCostCenterID=value;
				NotifyChanged("FK_GLCostCenterID");
				}
			}
		}
		public String GLSourceLeger
		{
			get{return _gLSourceLeger;}
			set
			{
				if (value != this._gLSourceLeger)
				{
				_gLSourceLeger=value;
				NotifyChanged("GLSourceLeger");
				}
			}
		}
		public String GLPostingJournalHDesc
		{
			get{return _gLPostingJournalHDesc;}
			set
			{
				if (value != this._gLPostingJournalHDesc)
				{
				_gLPostingJournalHDesc=value;
				NotifyChanged("GLPostingJournalHDesc");
				}
			}
		}
		public int FK_GLConsolidateGroupID
		{
			get{return _fK_GLConsolidateGroupID;}
			set
			{
				if (value != this._fK_GLConsolidateGroupID)
				{
				_fK_GLConsolidateGroupID=value;
				NotifyChanged("FK_GLConsolidateGroupID");
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
		public int FK_PPPhaseID
		{
			get{return _fK_PPPhaseID;}
			set
			{
				if (value != this._fK_PPPhaseID)
				{
				_fK_PPPhaseID=value;
				NotifyChanged("FK_PPPhaseID");
				}
			}
		}
		public String GLPostingJournalTKNo
		{
			get{return _gLPostingJournalTKNo;}
			set
			{
				if (value != this._gLPostingJournalTKNo)
				{
				_gLPostingJournalTKNo=value;
				NotifyChanged("GLPostingJournalTKNo");
				}
			}
		}
		public String GLPostingJournalBookingNo
		{
			get{return _gLPostingJournalBookingNo;}
			set
			{
				if (value != this._gLPostingJournalBookingNo)
				{
				_gLPostingJournalBookingNo=value;
				NotifyChanged("GLPostingJournalBookingNo");
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
		public Nullable<DateTime> GLPostingJournalExchangeDate
		{
			get{return _gLPostingJournalExchangeDate;}
			set
			{
				if (value != this._gLPostingJournalExchangeDate)
				{
				_gLPostingJournalExchangeDate=value;
				NotifyChanged("GLPostingJournalExchangeDate");
				}
			}
		}
		public Nullable<DateTime> GLPostingJournalDocDate
		{
			get{return _gLPostingJournalDocDate;}
			set
			{
				if (value != this._gLPostingJournalDocDate)
				{
				_gLPostingJournalDocDate=value;
				NotifyChanged("GLPostingJournalDocDate");
				}
			}
		}
		public int FK_GLCostDistID
		{
			get{return _fK_GLCostDistID;}
			set
			{
				if (value != this._fK_GLCostDistID)
				{
				_fK_GLCostDistID=value;
				NotifyChanged("FK_GLCostDistID");
				}
			}
		}
		public int FK_GLProfitDistID
		{
			get{return _fK_GLProfitDistID;}
			set
			{
				if (value != this._fK_GLProfitDistID)
				{
				_fK_GLProfitDistID=value;
				NotifyChanged("FK_GLProfitDistID");
				}
			}
		}
		public double GLPostingJournalTempAmt
		{
			get{return _gLPostingJournalTempAmt;}
			set
			{
				if (value != this._gLPostingJournalTempAmt)
				{
				_gLPostingJournalTempAmt=value;
				NotifyChanged("GLPostingJournalTempAmt");
				}
			}
		}
		public Nullable<DateTime> GLPostingJournalDueDate
		{
			get{return _gLPostingJournalDueDate;}
			set
			{
				if (value != this._gLPostingJournalDueDate)
				{
				_gLPostingJournalDueDate=value;
				NotifyChanged("GLPostingJournalDueDate");
				}
			}
		}
		public String GLSourceLedger
		{
			get{return _gLSourceLedger;}
			set
			{
				if (value != this._gLSourceLedger)
				{
				_gLSourceLedger=value;
				NotifyChanged("GLSourceLedger");
				}
			}
		}
		public int FK_GLCostAllocateID
		{
			get{return _fK_GLCostAllocateID;}
			set
			{
				if (value != this._fK_GLCostAllocateID)
				{
				_fK_GLCostAllocateID=value;
				NotifyChanged("FK_GLCostAllocateID");
				}
			}
		}
		public int FK_GLCostCenter1ID
		{
			get{return _fK_GLCostCenter1ID;}
			set
			{
				if (value != this._fK_GLCostCenter1ID)
				{
				_fK_GLCostCenter1ID=value;
				NotifyChanged("FK_GLCostCenter1ID");
				}
			}
		}
		public int FK_GLCostCenter2ID
		{
			get{return _fK_GLCostCenter2ID;}
			set
			{
				if (value != this._fK_GLCostCenter2ID)
				{
				_fK_GLCostCenter2ID=value;
				NotifyChanged("FK_GLCostCenter2ID");
				}
			}
		}
		public int FK_GLCostCenter3ID
		{
			get{return _fK_GLCostCenter3ID;}
			set
			{
				if (value != this._fK_GLCostCenter3ID)
				{
				_fK_GLCostCenter3ID=value;
				NotifyChanged("FK_GLCostCenter3ID");
				}
			}
		}
		public int FK_GLCostCenter4ID
		{
			get{return _fK_GLCostCenter4ID;}
			set
			{
				if (value != this._fK_GLCostCenter4ID)
				{
				_fK_GLCostCenter4ID=value;
				NotifyChanged("FK_GLCostCenter4ID");
				}
			}
		}
		public int FK_GLCostCenter5ID
		{
			get{return _fK_GLCostCenter5ID;}
			set
			{
				if (value != this._fK_GLCostCenter5ID)
				{
				_fK_GLCostCenter5ID=value;
				NotifyChanged("FK_GLCostCenter5ID");
				}
			}
		}
		public String GLObjectName
		{
			get{return _gLObjectName;}
			set
			{
				if (value != this._gLObjectName)
				{
				_gLObjectName=value;
				NotifyChanged("GLObjectName");
				}
			}
		}
		public String GLObjectVATTaxCode
		{
			get{return _gLObjectVATTaxCode;}
			set
			{
				if (value != this._gLObjectVATTaxCode)
				{
				_gLObjectVATTaxCode=value;
				NotifyChanged("GLObjectVATTaxCode");
				}
			}
		}
		public String GLObjectDesc
		{
			get{return _gLObjectDesc;}
			set
			{
				if (value != this._gLObjectDesc)
				{
				_gLObjectDesc=value;
				NotifyChanged("GLObjectDesc");
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
		public String GLPostingJournalMapDebitAccountNo
		{
			get{return _gLPostingJournalMapDebitAccountNo;}
			set
			{
				if (value != this._gLPostingJournalMapDebitAccountNo)
				{
				_gLPostingJournalMapDebitAccountNo=value;
				NotifyChanged("GLPostingJournalMapDebitAccountNo");
				}
			}
		}
		public String GLPostingJournalMapCreditAccountNo
		{
			get{return _gLPostingJournalMapCreditAccountNo;}
			set
			{
				if (value != this._gLPostingJournalMapCreditAccountNo)
				{
				_gLPostingJournalMapCreditAccountNo=value;
				NotifyChanged("GLPostingJournalMapCreditAccountNo");
				}
			}
		}
		public String GLPostingJournalUNCNo
		{
			get{return _gLPostingJournalUNCNo;}
			set
			{
				if (value != this._gLPostingJournalUNCNo)
				{
				_gLPostingJournalUNCNo=value;
				NotifyChanged("GLPostingJournalUNCNo");
				}
			}
		}
		public int FK_GLPostingHistoryID
		{
			get{return _fK_GLPostingHistoryID;}
			set
			{
				if (value != this._fK_GLPostingHistoryID)
				{
				_fK_GLPostingHistoryID=value;
				NotifyChanged("FK_GLPostingHistoryID");
				}
			}
		}
		#endregion
	}
	#endregion
}