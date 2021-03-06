using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region BRPOSs
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:BRPOSsInfo
	//Created Date:Friday, December 16, 2011
	//-----------------------------------------------------------
	
	public class BRPOSsInfo:BusinessObject
	{
		public BRPOSsInfo()
		{
		}
		#region Variables
		protected int _bRPOSID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected int _fK_GELanguageID;
		protected int _fK_GECurrencyID;
		protected int _fK_ARCustomerID;
		protected int _fK_GEShpMthID;
		protected int _fK_ARSellerID;
		protected int _fK_ICStockID;
		protected int _fK_ARPriceListID;
		protected int _fK_BRBranchID;
		protected String _bRSalePriceCombo=String.Empty;
		protected double _bRSellerComAmt;
		protected double _bRSellerComPct;
		protected String _bRPOSStatusCombo=DefaultStatus;
		protected String _bRPOSTypeCombo=String.Empty;
		protected String _bRPOSPmtTerm=String.Empty;
		protected String _bRPOSPmtMthCombo=String.Empty;
		protected String _bRPOSNo=String.Empty;
		protected String _bRPOSName=String.Empty;
		protected String _bRPOSDesc=String.Empty;
		protected bool _bRPOSOnHoldCheck=true;
		protected String _bRPOSText=String.Empty;
		protected Nullable<DateTime> _bRPOSDate;
		protected int _bRPOSFiscPer;
		protected int _bRPOSFiscYr;
		protected Nullable<DateTime> _bRPOSShpDate;
		protected Nullable<DateTime> _bRPOSExpireDate;
		protected double _bRPOSDiscPct;
		protected double _bRPOSDiscAmt;
		protected String _bRPOSRef=String.Empty;
		protected String _bRPOSCusRef=String.Empty;
		protected String _bRPOSComment=String.Empty;
		protected double _bRPOSWeight;
		protected double _bRPOSVol;
		protected bool _bRPOSActive=true;
		protected String _bRPOSTxNo=String.Empty;
		protected double _bRPOSExcRate;
		protected double _bRPOSAmt;
		protected double _bRPOSCAmt;
		protected String _bRPOSOF01Combo=String.Empty;
		protected String _bRPOSOF02Combo=String.Empty;
		protected String _bRPOSOF03Combo=String.Empty;
		protected String _bRPOSOF04Combo=String.Empty;
		protected String _bRPOSOF05Combo=String.Empty;
		protected String _bRPOSOF06Combo=String.Empty;
		protected String _bRPOSOF07Combo=String.Empty;
		protected String _bRPOSOF08Combo=String.Empty;
		protected String _bRPOSOF09Combo=String.Empty;
		protected String _bRPOSOF10Combo=String.Empty;
		protected String _bRPOSPrj=String.Empty;
		protected String _bRPOSCustomerName=String.Empty;
		protected String _bRPOSCustomerDesc=String.Empty;
		protected int _fK_ARCustomerConBTID;
		protected String _bRPOSBTConName=String.Empty;
		protected String _bRPOSBTConFName=String.Empty;
		protected String _bRPOSBTConLName=String.Empty;
		protected String _bRPOSBTConTitle=String.Empty;
		protected String _bRPOSBTConHLet=String.Empty;
		protected String _bRPOSBTConHMsg=String.Empty;
		protected String _bRPOSBTConEmail=String.Empty;
		protected String _bRPOSBTConEmail1=String.Empty;
		protected String _bRPOSBTConPhone=String.Empty;
		protected String _bRPOSBTConCPhone=String.Empty;
		protected String _bRPOSBTConFax=String.Empty;
		protected String _bRPOSBTConInfo=String.Empty;
		protected String _bRPOSBTConDept=String.Empty;
		protected String _bRPOSBTConRoom=String.Empty;
		protected String _bRPOSBTAddL1=String.Empty;
		protected String _bRPOSBTAddL2=String.Empty;
		protected String _bRPOSBTAddL3=String.Empty;
		protected String _bRPOSBTAddStr=String.Empty;
		protected String _bRPOSBTAddCity=String.Empty;
		protected String _bRPOSBTAddPCode=String.Empty;
		protected String _bRPOSBTAddStProv=String.Empty;
		protected String _bRPOSBTAddZCode=String.Empty;
		protected String _bRPOSBTAddCountry=String.Empty;
		protected int _fK_ARCustomerConCMID;
		protected String _bRPOSCMConName=String.Empty;
		protected Nullable<DateTime> _bRPOSCMConBday;
		protected String _bRPOSCMConFName=String.Empty;
		protected String _bRPOSCMConLName=String.Empty;
		protected String _bRPOSCMConTitle=String.Empty;
		protected String _bRPOSCMConHLet=String.Empty;
		protected String _bRPOSCMConHMsg=String.Empty;
		protected String _bRPOSCMConEmail=String.Empty;
		protected String _bRPOSCMConEmail1=String.Empty;
		protected String _bRPOSCMConPhone=String.Empty;
		protected String _bRPOSCMConFax=String.Empty;
		protected String _bRPOSCMConCPhone=String.Empty;
		protected String _bRPOSCMConInfo=String.Empty;
		protected String _bRPOSCMConDept=String.Empty;
		protected String _bRPOSCMConRoom=String.Empty;
		protected String _bRPOSCMAddL1=String.Empty;
		protected String _bRPOSCMAddL2=String.Empty;
		protected String _bRPOSCMAddL3=String.Empty;
		protected String _bRPOSCMAddStr=String.Empty;
		protected String _bRPOSCMAddCity=String.Empty;
		protected String _bRPOSCMAddPCode=String.Empty;
		protected String _bRPOSCMAddStProv=String.Empty;
		protected String _bRPOSCMAddZCode=String.Empty;
		protected String _bRPOSCMAddCountry=String.Empty;
		protected int _fK_ARCustomerConSTID;
		protected String _bRPOSSTConName=String.Empty;
		protected Nullable<DateTime> _bRPOSSTConBday;
		protected String _bRPOSSTConFName=String.Empty;
		protected String _bRPOSSTConLName=String.Empty;
		protected String _bRPOSSTConTitle=String.Empty;
		protected String _bRPOSSTConHLet=String.Empty;
		protected String _bRPOSSTConHMsg=String.Empty;
		protected String _bRPOSSTConEmail=String.Empty;
		protected String _bRPOSSTConEmail1=String.Empty;
		protected String _bRPOSSTConPhone=String.Empty;
		protected String _bRPOSSTConCPhone=String.Empty;
		protected String _bRPOSSTConFax=String.Empty;
		protected String _bRPOSSTConInfo=String.Empty;
		protected String _bRPOSSTConDept=String.Empty;
		protected String _bRPOSSTConRoom=String.Empty;
		protected String _bRPOSSTAddL1=String.Empty;
		protected String _bRPOSSTAddL2=String.Empty;
		protected String _bRPOSSTAddL3=String.Empty;
		protected String _bRPOSSTAddStr=String.Empty;
		protected String _bRPOSSTAddCity=String.Empty;
		protected String _bRPOSSTAddPCode=String.Empty;
		protected String _bRPOSSTAddStProv=String.Empty;
		protected String _bRPOSSTAddZCode=String.Empty;
		protected String _bRPOSSTAddCountry=String.Empty;
		protected double _bRPOSShpAmt;
		protected double _bRPOSItmPriceTot;
		protected double _bRPOSItmDiscAmtTot;
		protected double _bRPOSItmAmtTot;
		protected double _bRPOSTxAmtTot;
		protected double _bRPOSNetAmtTot;
		protected double _bRPOSAmtTot;
		protected double _bRPOSMiscChargeAmt;
		protected double _bRPOSCostTot;
		protected double _bRPOSMargPct;
		protected double _bRPOSAmtDue;
		protected double _bRPOSChangeDue;
		protected double _bRPOSPmtTot;
		protected double _bRPOSCreditCard;
		protected double _bRPOSDebitCard;
		protected double _bRPOSAccount;
		protected int _fK_BRPOSShiftID;
		protected double _bRPOSSalePointTotal;
		#endregion

		#region Public properties
		public int BRPOSID
		{
			get{return _bRPOSID;}
			set
			{
				if (value != this._bRPOSID)
				{
				_bRPOSID=value;
				NotifyChanged("BRPOSID");
				}
			}
		}
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		public String BRSalePriceCombo
		{
			get{return _bRSalePriceCombo;}
			set
			{
				if (value != this._bRSalePriceCombo)
				{
				_bRSalePriceCombo=value;
				NotifyChanged("BRSalePriceCombo");
				}
			}
		}
		public double BRSellerComAmt
		{
			get{return _bRSellerComAmt;}
			set
			{
				if (value != this._bRSellerComAmt)
				{
				_bRSellerComAmt=value;
				NotifyChanged("BRSellerComAmt");
				}
			}
		}
		public double BRSellerComPct
		{
			get{return _bRSellerComPct;}
			set
			{
				if (value != this._bRSellerComPct)
				{
				_bRSellerComPct=value;
				NotifyChanged("BRSellerComPct");
				}
			}
		}
		public String BRPOSStatusCombo
		{
			get{return _bRPOSStatusCombo;}
			set
			{
				if (value != this._bRPOSStatusCombo)
				{
				_bRPOSStatusCombo=value;
				NotifyChanged("BRPOSStatusCombo");
				}
			}
		}
		public String BRPOSTypeCombo
		{
			get{return _bRPOSTypeCombo;}
			set
			{
				if (value != this._bRPOSTypeCombo)
				{
				_bRPOSTypeCombo=value;
				NotifyChanged("BRPOSTypeCombo");
				}
			}
		}
		public String BRPOSPmtTerm
		{
			get{return _bRPOSPmtTerm;}
			set
			{
				if (value != this._bRPOSPmtTerm)
				{
				_bRPOSPmtTerm=value;
				NotifyChanged("BRPOSPmtTerm");
				}
			}
		}
		public String BRPOSPmtMthCombo
		{
			get{return _bRPOSPmtMthCombo;}
			set
			{
				if (value != this._bRPOSPmtMthCombo)
				{
				_bRPOSPmtMthCombo=value;
				NotifyChanged("BRPOSPmtMthCombo");
				}
			}
		}
		public String BRPOSNo
		{
			get{return _bRPOSNo;}
			set
			{
				if (value != this._bRPOSNo)
				{
				_bRPOSNo=value;
				NotifyChanged("BRPOSNo");
				}
			}
		}
		public String BRPOSName
		{
			get{return _bRPOSName;}
			set
			{
				if (value != this._bRPOSName)
				{
				_bRPOSName=value;
				NotifyChanged("BRPOSName");
				}
			}
		}
		public String BRPOSDesc
		{
			get{return _bRPOSDesc;}
			set
			{
				if (value != this._bRPOSDesc)
				{
				_bRPOSDesc=value;
				NotifyChanged("BRPOSDesc");
				}
			}
		}
		public bool BRPOSOnHoldCheck
		{
			get{return _bRPOSOnHoldCheck;}
			set
			{
				if (value != this._bRPOSOnHoldCheck)
				{
				_bRPOSOnHoldCheck=value;
				NotifyChanged("BRPOSOnHoldCheck");
				}
			}
		}
		public String BRPOSText
		{
			get{return _bRPOSText;}
			set
			{
				if (value != this._bRPOSText)
				{
				_bRPOSText=value;
				NotifyChanged("BRPOSText");
				}
			}
		}
		public Nullable<DateTime> BRPOSDate
		{
			get{return _bRPOSDate;}
			set
			{
				if (value != this._bRPOSDate)
				{
				_bRPOSDate=value;
				NotifyChanged("BRPOSDate");
				}
			}
		}
		public int BRPOSFiscPer
		{
			get{return _bRPOSFiscPer;}
			set
			{
				if (value != this._bRPOSFiscPer)
				{
				_bRPOSFiscPer=value;
				NotifyChanged("BRPOSFiscPer");
				}
			}
		}
		public int BRPOSFiscYr
		{
			get{return _bRPOSFiscYr;}
			set
			{
				if (value != this._bRPOSFiscYr)
				{
				_bRPOSFiscYr=value;
				NotifyChanged("BRPOSFiscYr");
				}
			}
		}
		public Nullable<DateTime> BRPOSShpDate
		{
			get{return _bRPOSShpDate;}
			set
			{
				if (value != this._bRPOSShpDate)
				{
				_bRPOSShpDate=value;
				NotifyChanged("BRPOSShpDate");
				}
			}
		}
		public Nullable<DateTime> BRPOSExpireDate
		{
			get{return _bRPOSExpireDate;}
			set
			{
				if (value != this._bRPOSExpireDate)
				{
				_bRPOSExpireDate=value;
				NotifyChanged("BRPOSExpireDate");
				}
			}
		}
		public double BRPOSDiscPct
		{
			get{return _bRPOSDiscPct;}
			set
			{
				if (value != this._bRPOSDiscPct)
				{
				_bRPOSDiscPct=value;
				NotifyChanged("BRPOSDiscPct");
				}
			}
		}
		public double BRPOSDiscAmt
		{
			get{return _bRPOSDiscAmt;}
			set
			{
				if (value != this._bRPOSDiscAmt)
				{
				_bRPOSDiscAmt=value;
				NotifyChanged("BRPOSDiscAmt");
				}
			}
		}
		public String BRPOSRef
		{
			get{return _bRPOSRef;}
			set
			{
				if (value != this._bRPOSRef)
				{
				_bRPOSRef=value;
				NotifyChanged("BRPOSRef");
				}
			}
		}
		public String BRPOSCusRef
		{
			get{return _bRPOSCusRef;}
			set
			{
				if (value != this._bRPOSCusRef)
				{
				_bRPOSCusRef=value;
				NotifyChanged("BRPOSCusRef");
				}
			}
		}
		public String BRPOSComment
		{
			get{return _bRPOSComment;}
			set
			{
				if (value != this._bRPOSComment)
				{
				_bRPOSComment=value;
				NotifyChanged("BRPOSComment");
				}
			}
		}
		public double BRPOSWeight
		{
			get{return _bRPOSWeight;}
			set
			{
				if (value != this._bRPOSWeight)
				{
				_bRPOSWeight=value;
				NotifyChanged("BRPOSWeight");
				}
			}
		}
		public double BRPOSVol
		{
			get{return _bRPOSVol;}
			set
			{
				if (value != this._bRPOSVol)
				{
				_bRPOSVol=value;
				NotifyChanged("BRPOSVol");
				}
			}
		}
		public bool BRPOSActive
		{
			get{return _bRPOSActive;}
			set
			{
				if (value != this._bRPOSActive)
				{
				_bRPOSActive=value;
				NotifyChanged("BRPOSActive");
				}
			}
		}
		public String BRPOSTxNo
		{
			get{return _bRPOSTxNo;}
			set
			{
				if (value != this._bRPOSTxNo)
				{
				_bRPOSTxNo=value;
				NotifyChanged("BRPOSTxNo");
				}
			}
		}
		public double BRPOSExcRate
		{
			get{return _bRPOSExcRate;}
			set
			{
				if (value != this._bRPOSExcRate)
				{
				_bRPOSExcRate=value;
				NotifyChanged("BRPOSExcRate");
				}
			}
		}
		public double BRPOSAmt
		{
			get{return _bRPOSAmt;}
			set
			{
				if (value != this._bRPOSAmt)
				{
				_bRPOSAmt=value;
				NotifyChanged("BRPOSAmt");
				}
			}
		}
		public double BRPOSCAmt
		{
			get{return _bRPOSCAmt;}
			set
			{
				if (value != this._bRPOSCAmt)
				{
				_bRPOSCAmt=value;
				NotifyChanged("BRPOSCAmt");
				}
			}
		}
		public String BRPOSOF01Combo
		{
			get{return _bRPOSOF01Combo;}
			set
			{
				if (value != this._bRPOSOF01Combo)
				{
				_bRPOSOF01Combo=value;
				NotifyChanged("BRPOSOF01Combo");
				}
			}
		}
		public String BRPOSOF02Combo
		{
			get{return _bRPOSOF02Combo;}
			set
			{
				if (value != this._bRPOSOF02Combo)
				{
				_bRPOSOF02Combo=value;
				NotifyChanged("BRPOSOF02Combo");
				}
			}
		}
		public String BRPOSOF03Combo
		{
			get{return _bRPOSOF03Combo;}
			set
			{
				if (value != this._bRPOSOF03Combo)
				{
				_bRPOSOF03Combo=value;
				NotifyChanged("BRPOSOF03Combo");
				}
			}
		}
		public String BRPOSOF04Combo
		{
			get{return _bRPOSOF04Combo;}
			set
			{
				if (value != this._bRPOSOF04Combo)
				{
				_bRPOSOF04Combo=value;
				NotifyChanged("BRPOSOF04Combo");
				}
			}
		}
		public String BRPOSOF05Combo
		{
			get{return _bRPOSOF05Combo;}
			set
			{
				if (value != this._bRPOSOF05Combo)
				{
				_bRPOSOF05Combo=value;
				NotifyChanged("BRPOSOF05Combo");
				}
			}
		}
		public String BRPOSOF06Combo
		{
			get{return _bRPOSOF06Combo;}
			set
			{
				if (value != this._bRPOSOF06Combo)
				{
				_bRPOSOF06Combo=value;
				NotifyChanged("BRPOSOF06Combo");
				}
			}
		}
		public String BRPOSOF07Combo
		{
			get{return _bRPOSOF07Combo;}
			set
			{
				if (value != this._bRPOSOF07Combo)
				{
				_bRPOSOF07Combo=value;
				NotifyChanged("BRPOSOF07Combo");
				}
			}
		}
		public String BRPOSOF08Combo
		{
			get{return _bRPOSOF08Combo;}
			set
			{
				if (value != this._bRPOSOF08Combo)
				{
				_bRPOSOF08Combo=value;
				NotifyChanged("BRPOSOF08Combo");
				}
			}
		}
		public String BRPOSOF09Combo
		{
			get{return _bRPOSOF09Combo;}
			set
			{
				if (value != this._bRPOSOF09Combo)
				{
				_bRPOSOF09Combo=value;
				NotifyChanged("BRPOSOF09Combo");
				}
			}
		}
		public String BRPOSOF10Combo
		{
			get{return _bRPOSOF10Combo;}
			set
			{
				if (value != this._bRPOSOF10Combo)
				{
				_bRPOSOF10Combo=value;
				NotifyChanged("BRPOSOF10Combo");
				}
			}
		}
		public String BRPOSPrj
		{
			get{return _bRPOSPrj;}
			set
			{
				if (value != this._bRPOSPrj)
				{
				_bRPOSPrj=value;
				NotifyChanged("BRPOSPrj");
				}
			}
		}
		public String BRPOSCustomerName
		{
			get{return _bRPOSCustomerName;}
			set
			{
				if (value != this._bRPOSCustomerName)
				{
				_bRPOSCustomerName=value;
				NotifyChanged("BRPOSCustomerName");
				}
			}
		}
		public String BRPOSCustomerDesc
		{
			get{return _bRPOSCustomerDesc;}
			set
			{
				if (value != this._bRPOSCustomerDesc)
				{
				_bRPOSCustomerDesc=value;
				NotifyChanged("BRPOSCustomerDesc");
				}
			}
		}
		public int FK_ARCustomerConBTID
		{
			get{return _fK_ARCustomerConBTID;}
			set
			{
				if (value != this._fK_ARCustomerConBTID)
				{
				_fK_ARCustomerConBTID=value;
				NotifyChanged("FK_ARCustomerConBTID");
				}
			}
		}
		public String BRPOSBTConName
		{
			get{return _bRPOSBTConName;}
			set
			{
				if (value != this._bRPOSBTConName)
				{
				_bRPOSBTConName=value;
				NotifyChanged("BRPOSBTConName");
				}
			}
		}
		public String BRPOSBTConFName
		{
			get{return _bRPOSBTConFName;}
			set
			{
				if (value != this._bRPOSBTConFName)
				{
				_bRPOSBTConFName=value;
				NotifyChanged("BRPOSBTConFName");
				}
			}
		}
		public String BRPOSBTConLName
		{
			get{return _bRPOSBTConLName;}
			set
			{
				if (value != this._bRPOSBTConLName)
				{
				_bRPOSBTConLName=value;
				NotifyChanged("BRPOSBTConLName");
				}
			}
		}
		public String BRPOSBTConTitle
		{
			get{return _bRPOSBTConTitle;}
			set
			{
				if (value != this._bRPOSBTConTitle)
				{
				_bRPOSBTConTitle=value;
				NotifyChanged("BRPOSBTConTitle");
				}
			}
		}
		public String BRPOSBTConHLet
		{
			get{return _bRPOSBTConHLet;}
			set
			{
				if (value != this._bRPOSBTConHLet)
				{
				_bRPOSBTConHLet=value;
				NotifyChanged("BRPOSBTConHLet");
				}
			}
		}
		public String BRPOSBTConHMsg
		{
			get{return _bRPOSBTConHMsg;}
			set
			{
				if (value != this._bRPOSBTConHMsg)
				{
				_bRPOSBTConHMsg=value;
				NotifyChanged("BRPOSBTConHMsg");
				}
			}
		}
		public String BRPOSBTConEmail
		{
			get{return _bRPOSBTConEmail;}
			set
			{
				if (value != this._bRPOSBTConEmail)
				{
				_bRPOSBTConEmail=value;
				NotifyChanged("BRPOSBTConEmail");
				}
			}
		}
		public String BRPOSBTConEmail1
		{
			get{return _bRPOSBTConEmail1;}
			set
			{
				if (value != this._bRPOSBTConEmail1)
				{
				_bRPOSBTConEmail1=value;
				NotifyChanged("BRPOSBTConEmail1");
				}
			}
		}
		public String BRPOSBTConPhone
		{
			get{return _bRPOSBTConPhone;}
			set
			{
				if (value != this._bRPOSBTConPhone)
				{
				_bRPOSBTConPhone=value;
				NotifyChanged("BRPOSBTConPhone");
				}
			}
		}
		public String BRPOSBTConCPhone
		{
			get{return _bRPOSBTConCPhone;}
			set
			{
				if (value != this._bRPOSBTConCPhone)
				{
				_bRPOSBTConCPhone=value;
				NotifyChanged("BRPOSBTConCPhone");
				}
			}
		}
		public String BRPOSBTConFax
		{
			get{return _bRPOSBTConFax;}
			set
			{
				if (value != this._bRPOSBTConFax)
				{
				_bRPOSBTConFax=value;
				NotifyChanged("BRPOSBTConFax");
				}
			}
		}
		public String BRPOSBTConInfo
		{
			get{return _bRPOSBTConInfo;}
			set
			{
				if (value != this._bRPOSBTConInfo)
				{
				_bRPOSBTConInfo=value;
				NotifyChanged("BRPOSBTConInfo");
				}
			}
		}
		public String BRPOSBTConDept
		{
			get{return _bRPOSBTConDept;}
			set
			{
				if (value != this._bRPOSBTConDept)
				{
				_bRPOSBTConDept=value;
				NotifyChanged("BRPOSBTConDept");
				}
			}
		}
		public String BRPOSBTConRoom
		{
			get{return _bRPOSBTConRoom;}
			set
			{
				if (value != this._bRPOSBTConRoom)
				{
				_bRPOSBTConRoom=value;
				NotifyChanged("BRPOSBTConRoom");
				}
			}
		}
		public String BRPOSBTAddL1
		{
			get{return _bRPOSBTAddL1;}
			set
			{
				if (value != this._bRPOSBTAddL1)
				{
				_bRPOSBTAddL1=value;
				NotifyChanged("BRPOSBTAddL1");
				}
			}
		}
		public String BRPOSBTAddL2
		{
			get{return _bRPOSBTAddL2;}
			set
			{
				if (value != this._bRPOSBTAddL2)
				{
				_bRPOSBTAddL2=value;
				NotifyChanged("BRPOSBTAddL2");
				}
			}
		}
		public String BRPOSBTAddL3
		{
			get{return _bRPOSBTAddL3;}
			set
			{
				if (value != this._bRPOSBTAddL3)
				{
				_bRPOSBTAddL3=value;
				NotifyChanged("BRPOSBTAddL3");
				}
			}
		}
		public String BRPOSBTAddStr
		{
			get{return _bRPOSBTAddStr;}
			set
			{
				if (value != this._bRPOSBTAddStr)
				{
				_bRPOSBTAddStr=value;
				NotifyChanged("BRPOSBTAddStr");
				}
			}
		}
		public String BRPOSBTAddCity
		{
			get{return _bRPOSBTAddCity;}
			set
			{
				if (value != this._bRPOSBTAddCity)
				{
				_bRPOSBTAddCity=value;
				NotifyChanged("BRPOSBTAddCity");
				}
			}
		}
		public String BRPOSBTAddPCode
		{
			get{return _bRPOSBTAddPCode;}
			set
			{
				if (value != this._bRPOSBTAddPCode)
				{
				_bRPOSBTAddPCode=value;
				NotifyChanged("BRPOSBTAddPCode");
				}
			}
		}
		public String BRPOSBTAddStProv
		{
			get{return _bRPOSBTAddStProv;}
			set
			{
				if (value != this._bRPOSBTAddStProv)
				{
				_bRPOSBTAddStProv=value;
				NotifyChanged("BRPOSBTAddStProv");
				}
			}
		}
		public String BRPOSBTAddZCode
		{
			get{return _bRPOSBTAddZCode;}
			set
			{
				if (value != this._bRPOSBTAddZCode)
				{
				_bRPOSBTAddZCode=value;
				NotifyChanged("BRPOSBTAddZCode");
				}
			}
		}
		public String BRPOSBTAddCountry
		{
			get{return _bRPOSBTAddCountry;}
			set
			{
				if (value != this._bRPOSBTAddCountry)
				{
				_bRPOSBTAddCountry=value;
				NotifyChanged("BRPOSBTAddCountry");
				}
			}
		}
		public int FK_ARCustomerConCMID
		{
			get{return _fK_ARCustomerConCMID;}
			set
			{
				if (value != this._fK_ARCustomerConCMID)
				{
				_fK_ARCustomerConCMID=value;
				NotifyChanged("FK_ARCustomerConCMID");
				}
			}
		}
		public String BRPOSCMConName
		{
			get{return _bRPOSCMConName;}
			set
			{
				if (value != this._bRPOSCMConName)
				{
				_bRPOSCMConName=value;
				NotifyChanged("BRPOSCMConName");
				}
			}
		}
		public Nullable<DateTime> BRPOSCMConBday
		{
			get{return _bRPOSCMConBday;}
			set
			{
				if (value != this._bRPOSCMConBday)
				{
				_bRPOSCMConBday=value;
				NotifyChanged("BRPOSCMConBday");
				}
			}
		}
		public String BRPOSCMConFName
		{
			get{return _bRPOSCMConFName;}
			set
			{
				if (value != this._bRPOSCMConFName)
				{
				_bRPOSCMConFName=value;
				NotifyChanged("BRPOSCMConFName");
				}
			}
		}
		public String BRPOSCMConLName
		{
			get{return _bRPOSCMConLName;}
			set
			{
				if (value != this._bRPOSCMConLName)
				{
				_bRPOSCMConLName=value;
				NotifyChanged("BRPOSCMConLName");
				}
			}
		}
		public String BRPOSCMConTitle
		{
			get{return _bRPOSCMConTitle;}
			set
			{
				if (value != this._bRPOSCMConTitle)
				{
				_bRPOSCMConTitle=value;
				NotifyChanged("BRPOSCMConTitle");
				}
			}
		}
		public String BRPOSCMConHLet
		{
			get{return _bRPOSCMConHLet;}
			set
			{
				if (value != this._bRPOSCMConHLet)
				{
				_bRPOSCMConHLet=value;
				NotifyChanged("BRPOSCMConHLet");
				}
			}
		}
		public String BRPOSCMConHMsg
		{
			get{return _bRPOSCMConHMsg;}
			set
			{
				if (value != this._bRPOSCMConHMsg)
				{
				_bRPOSCMConHMsg=value;
				NotifyChanged("BRPOSCMConHMsg");
				}
			}
		}
		public String BRPOSCMConEmail
		{
			get{return _bRPOSCMConEmail;}
			set
			{
				if (value != this._bRPOSCMConEmail)
				{
				_bRPOSCMConEmail=value;
				NotifyChanged("BRPOSCMConEmail");
				}
			}
		}
		public String BRPOSCMConEmail1
		{
			get{return _bRPOSCMConEmail1;}
			set
			{
				if (value != this._bRPOSCMConEmail1)
				{
				_bRPOSCMConEmail1=value;
				NotifyChanged("BRPOSCMConEmail1");
				}
			}
		}
		public String BRPOSCMConPhone
		{
			get{return _bRPOSCMConPhone;}
			set
			{
				if (value != this._bRPOSCMConPhone)
				{
				_bRPOSCMConPhone=value;
				NotifyChanged("BRPOSCMConPhone");
				}
			}
		}
		public String BRPOSCMConFax
		{
			get{return _bRPOSCMConFax;}
			set
			{
				if (value != this._bRPOSCMConFax)
				{
				_bRPOSCMConFax=value;
				NotifyChanged("BRPOSCMConFax");
				}
			}
		}
		public String BRPOSCMConCPhone
		{
			get{return _bRPOSCMConCPhone;}
			set
			{
				if (value != this._bRPOSCMConCPhone)
				{
				_bRPOSCMConCPhone=value;
				NotifyChanged("BRPOSCMConCPhone");
				}
			}
		}
		public String BRPOSCMConInfo
		{
			get{return _bRPOSCMConInfo;}
			set
			{
				if (value != this._bRPOSCMConInfo)
				{
				_bRPOSCMConInfo=value;
				NotifyChanged("BRPOSCMConInfo");
				}
			}
		}
		public String BRPOSCMConDept
		{
			get{return _bRPOSCMConDept;}
			set
			{
				if (value != this._bRPOSCMConDept)
				{
				_bRPOSCMConDept=value;
				NotifyChanged("BRPOSCMConDept");
				}
			}
		}
		public String BRPOSCMConRoom
		{
			get{return _bRPOSCMConRoom;}
			set
			{
				if (value != this._bRPOSCMConRoom)
				{
				_bRPOSCMConRoom=value;
				NotifyChanged("BRPOSCMConRoom");
				}
			}
		}
		public String BRPOSCMAddL1
		{
			get{return _bRPOSCMAddL1;}
			set
			{
				if (value != this._bRPOSCMAddL1)
				{
				_bRPOSCMAddL1=value;
				NotifyChanged("BRPOSCMAddL1");
				}
			}
		}
		public String BRPOSCMAddL2
		{
			get{return _bRPOSCMAddL2;}
			set
			{
				if (value != this._bRPOSCMAddL2)
				{
				_bRPOSCMAddL2=value;
				NotifyChanged("BRPOSCMAddL2");
				}
			}
		}
		public String BRPOSCMAddL3
		{
			get{return _bRPOSCMAddL3;}
			set
			{
				if (value != this._bRPOSCMAddL3)
				{
				_bRPOSCMAddL3=value;
				NotifyChanged("BRPOSCMAddL3");
				}
			}
		}
		public String BRPOSCMAddStr
		{
			get{return _bRPOSCMAddStr;}
			set
			{
				if (value != this._bRPOSCMAddStr)
				{
				_bRPOSCMAddStr=value;
				NotifyChanged("BRPOSCMAddStr");
				}
			}
		}
		public String BRPOSCMAddCity
		{
			get{return _bRPOSCMAddCity;}
			set
			{
				if (value != this._bRPOSCMAddCity)
				{
				_bRPOSCMAddCity=value;
				NotifyChanged("BRPOSCMAddCity");
				}
			}
		}
		public String BRPOSCMAddPCode
		{
			get{return _bRPOSCMAddPCode;}
			set
			{
				if (value != this._bRPOSCMAddPCode)
				{
				_bRPOSCMAddPCode=value;
				NotifyChanged("BRPOSCMAddPCode");
				}
			}
		}
		public String BRPOSCMAddStProv
		{
			get{return _bRPOSCMAddStProv;}
			set
			{
				if (value != this._bRPOSCMAddStProv)
				{
				_bRPOSCMAddStProv=value;
				NotifyChanged("BRPOSCMAddStProv");
				}
			}
		}
		public String BRPOSCMAddZCode
		{
			get{return _bRPOSCMAddZCode;}
			set
			{
				if (value != this._bRPOSCMAddZCode)
				{
				_bRPOSCMAddZCode=value;
				NotifyChanged("BRPOSCMAddZCode");
				}
			}
		}
		public String BRPOSCMAddCountry
		{
			get{return _bRPOSCMAddCountry;}
			set
			{
				if (value != this._bRPOSCMAddCountry)
				{
				_bRPOSCMAddCountry=value;
				NotifyChanged("BRPOSCMAddCountry");
				}
			}
		}
		public int FK_ARCustomerConSTID
		{
			get{return _fK_ARCustomerConSTID;}
			set
			{
				if (value != this._fK_ARCustomerConSTID)
				{
				_fK_ARCustomerConSTID=value;
				NotifyChanged("FK_ARCustomerConSTID");
				}
			}
		}
		public String BRPOSSTConName
		{
			get{return _bRPOSSTConName;}
			set
			{
				if (value != this._bRPOSSTConName)
				{
				_bRPOSSTConName=value;
				NotifyChanged("BRPOSSTConName");
				}
			}
		}
		public Nullable<DateTime> BRPOSSTConBday
		{
			get{return _bRPOSSTConBday;}
			set
			{
				if (value != this._bRPOSSTConBday)
				{
				_bRPOSSTConBday=value;
				NotifyChanged("BRPOSSTConBday");
				}
			}
		}
		public String BRPOSSTConFName
		{
			get{return _bRPOSSTConFName;}
			set
			{
				if (value != this._bRPOSSTConFName)
				{
				_bRPOSSTConFName=value;
				NotifyChanged("BRPOSSTConFName");
				}
			}
		}
		public String BRPOSSTConLName
		{
			get{return _bRPOSSTConLName;}
			set
			{
				if (value != this._bRPOSSTConLName)
				{
				_bRPOSSTConLName=value;
				NotifyChanged("BRPOSSTConLName");
				}
			}
		}
		public String BRPOSSTConTitle
		{
			get{return _bRPOSSTConTitle;}
			set
			{
				if (value != this._bRPOSSTConTitle)
				{
				_bRPOSSTConTitle=value;
				NotifyChanged("BRPOSSTConTitle");
				}
			}
		}
		public String BRPOSSTConHLet
		{
			get{return _bRPOSSTConHLet;}
			set
			{
				if (value != this._bRPOSSTConHLet)
				{
				_bRPOSSTConHLet=value;
				NotifyChanged("BRPOSSTConHLet");
				}
			}
		}
		public String BRPOSSTConHMsg
		{
			get{return _bRPOSSTConHMsg;}
			set
			{
				if (value != this._bRPOSSTConHMsg)
				{
				_bRPOSSTConHMsg=value;
				NotifyChanged("BRPOSSTConHMsg");
				}
			}
		}
		public String BRPOSSTConEmail
		{
			get{return _bRPOSSTConEmail;}
			set
			{
				if (value != this._bRPOSSTConEmail)
				{
				_bRPOSSTConEmail=value;
				NotifyChanged("BRPOSSTConEmail");
				}
			}
		}
		public String BRPOSSTConEmail1
		{
			get{return _bRPOSSTConEmail1;}
			set
			{
				if (value != this._bRPOSSTConEmail1)
				{
				_bRPOSSTConEmail1=value;
				NotifyChanged("BRPOSSTConEmail1");
				}
			}
		}
		public String BRPOSSTConPhone
		{
			get{return _bRPOSSTConPhone;}
			set
			{
				if (value != this._bRPOSSTConPhone)
				{
				_bRPOSSTConPhone=value;
				NotifyChanged("BRPOSSTConPhone");
				}
			}
		}
		public String BRPOSSTConCPhone
		{
			get{return _bRPOSSTConCPhone;}
			set
			{
				if (value != this._bRPOSSTConCPhone)
				{
				_bRPOSSTConCPhone=value;
				NotifyChanged("BRPOSSTConCPhone");
				}
			}
		}
		public String BRPOSSTConFax
		{
			get{return _bRPOSSTConFax;}
			set
			{
				if (value != this._bRPOSSTConFax)
				{
				_bRPOSSTConFax=value;
				NotifyChanged("BRPOSSTConFax");
				}
			}
		}
		public String BRPOSSTConInfo
		{
			get{return _bRPOSSTConInfo;}
			set
			{
				if (value != this._bRPOSSTConInfo)
				{
				_bRPOSSTConInfo=value;
				NotifyChanged("BRPOSSTConInfo");
				}
			}
		}
		public String BRPOSSTConDept
		{
			get{return _bRPOSSTConDept;}
			set
			{
				if (value != this._bRPOSSTConDept)
				{
				_bRPOSSTConDept=value;
				NotifyChanged("BRPOSSTConDept");
				}
			}
		}
		public String BRPOSSTConRoom
		{
			get{return _bRPOSSTConRoom;}
			set
			{
				if (value != this._bRPOSSTConRoom)
				{
				_bRPOSSTConRoom=value;
				NotifyChanged("BRPOSSTConRoom");
				}
			}
		}
		public String BRPOSSTAddL1
		{
			get{return _bRPOSSTAddL1;}
			set
			{
				if (value != this._bRPOSSTAddL1)
				{
				_bRPOSSTAddL1=value;
				NotifyChanged("BRPOSSTAddL1");
				}
			}
		}
		public String BRPOSSTAddL2
		{
			get{return _bRPOSSTAddL2;}
			set
			{
				if (value != this._bRPOSSTAddL2)
				{
				_bRPOSSTAddL2=value;
				NotifyChanged("BRPOSSTAddL2");
				}
			}
		}
		public String BRPOSSTAddL3
		{
			get{return _bRPOSSTAddL3;}
			set
			{
				if (value != this._bRPOSSTAddL3)
				{
				_bRPOSSTAddL3=value;
				NotifyChanged("BRPOSSTAddL3");
				}
			}
		}
		public String BRPOSSTAddStr
		{
			get{return _bRPOSSTAddStr;}
			set
			{
				if (value != this._bRPOSSTAddStr)
				{
				_bRPOSSTAddStr=value;
				NotifyChanged("BRPOSSTAddStr");
				}
			}
		}
		public String BRPOSSTAddCity
		{
			get{return _bRPOSSTAddCity;}
			set
			{
				if (value != this._bRPOSSTAddCity)
				{
				_bRPOSSTAddCity=value;
				NotifyChanged("BRPOSSTAddCity");
				}
			}
		}
		public String BRPOSSTAddPCode
		{
			get{return _bRPOSSTAddPCode;}
			set
			{
				if (value != this._bRPOSSTAddPCode)
				{
				_bRPOSSTAddPCode=value;
				NotifyChanged("BRPOSSTAddPCode");
				}
			}
		}
		public String BRPOSSTAddStProv
		{
			get{return _bRPOSSTAddStProv;}
			set
			{
				if (value != this._bRPOSSTAddStProv)
				{
				_bRPOSSTAddStProv=value;
				NotifyChanged("BRPOSSTAddStProv");
				}
			}
		}
		public String BRPOSSTAddZCode
		{
			get{return _bRPOSSTAddZCode;}
			set
			{
				if (value != this._bRPOSSTAddZCode)
				{
				_bRPOSSTAddZCode=value;
				NotifyChanged("BRPOSSTAddZCode");
				}
			}
		}
		public String BRPOSSTAddCountry
		{
			get{return _bRPOSSTAddCountry;}
			set
			{
				if (value != this._bRPOSSTAddCountry)
				{
				_bRPOSSTAddCountry=value;
				NotifyChanged("BRPOSSTAddCountry");
				}
			}
		}
		public double BRPOSShpAmt
		{
			get{return _bRPOSShpAmt;}
			set
			{
				if (value != this._bRPOSShpAmt)
				{
				_bRPOSShpAmt=value;
				NotifyChanged("BRPOSShpAmt");
				}
			}
		}
		public double BRPOSItmPriceTot
		{
			get{return _bRPOSItmPriceTot;}
			set
			{
				if (value != this._bRPOSItmPriceTot)
				{
				_bRPOSItmPriceTot=value;
				NotifyChanged("BRPOSItmPriceTot");
				}
			}
		}
		public double BRPOSItmDiscAmtTot
		{
			get{return _bRPOSItmDiscAmtTot;}
			set
			{
				if (value != this._bRPOSItmDiscAmtTot)
				{
				_bRPOSItmDiscAmtTot=value;
				NotifyChanged("BRPOSItmDiscAmtTot");
				}
			}
		}
		public double BRPOSItmAmtTot
		{
			get{return _bRPOSItmAmtTot;}
			set
			{
				if (value != this._bRPOSItmAmtTot)
				{
				_bRPOSItmAmtTot=value;
				NotifyChanged("BRPOSItmAmtTot");
				}
			}
		}
		public double BRPOSTxAmtTot
		{
			get{return _bRPOSTxAmtTot;}
			set
			{
				if (value != this._bRPOSTxAmtTot)
				{
				_bRPOSTxAmtTot=value;
				NotifyChanged("BRPOSTxAmtTot");
				}
			}
		}
		public double BRPOSNetAmtTot
		{
			get{return _bRPOSNetAmtTot;}
			set
			{
				if (value != this._bRPOSNetAmtTot)
				{
				_bRPOSNetAmtTot=value;
				NotifyChanged("BRPOSNetAmtTot");
				}
			}
		}
		public double BRPOSAmtTot
		{
			get{return _bRPOSAmtTot;}
			set
			{
				if (value != this._bRPOSAmtTot)
				{
				_bRPOSAmtTot=value;
				NotifyChanged("BRPOSAmtTot");
				}
			}
		}
		public double BRPOSMiscChargeAmt
		{
			get{return _bRPOSMiscChargeAmt;}
			set
			{
				if (value != this._bRPOSMiscChargeAmt)
				{
				_bRPOSMiscChargeAmt=value;
				NotifyChanged("BRPOSMiscChargeAmt");
				}
			}
		}
		public double BRPOSCostTot
		{
			get{return _bRPOSCostTot;}
			set
			{
				if (value != this._bRPOSCostTot)
				{
				_bRPOSCostTot=value;
				NotifyChanged("BRPOSCostTot");
				}
			}
		}
		public double BRPOSMargPct
		{
			get{return _bRPOSMargPct;}
			set
			{
				if (value != this._bRPOSMargPct)
				{
				_bRPOSMargPct=value;
				NotifyChanged("BRPOSMargPct");
				}
			}
		}
		public double BRPOSAmtDue
		{
			get{return _bRPOSAmtDue;}
			set
			{
				if (value != this._bRPOSAmtDue)
				{
				_bRPOSAmtDue=value;
				NotifyChanged("BRPOSAmtDue");
				}
			}
		}
		public double BRPOSChangeDue
		{
			get{return _bRPOSChangeDue;}
			set
			{
				if (value != this._bRPOSChangeDue)
				{
				_bRPOSChangeDue=value;
				NotifyChanged("BRPOSChangeDue");
				}
			}
		}
		public double BRPOSPmtTot
		{
			get{return _bRPOSPmtTot;}
			set
			{
				if (value != this._bRPOSPmtTot)
				{
				_bRPOSPmtTot=value;
				NotifyChanged("BRPOSPmtTot");
				}
			}
		}
		public double BRPOSCreditCard
		{
			get{return _bRPOSCreditCard;}
			set
			{
				if (value != this._bRPOSCreditCard)
				{
				_bRPOSCreditCard=value;
				NotifyChanged("BRPOSCreditCard");
				}
			}
		}
		public double BRPOSDebitCard
		{
			get{return _bRPOSDebitCard;}
			set
			{
				if (value != this._bRPOSDebitCard)
				{
				_bRPOSDebitCard=value;
				NotifyChanged("BRPOSDebitCard");
				}
			}
		}
		public double BRPOSAccount
		{
			get{return _bRPOSAccount;}
			set
			{
				if (value != this._bRPOSAccount)
				{
				_bRPOSAccount=value;
				NotifyChanged("BRPOSAccount");
				}
			}
		}
		public int FK_BRPOSShiftID
		{
			get{return _fK_BRPOSShiftID;}
			set
			{
				if (value != this._fK_BRPOSShiftID)
				{
				_fK_BRPOSShiftID=value;
				NotifyChanged("FK_BRPOSShiftID");
				}
			}
		}
		public double BRPOSSalePointTotal
		{
			get{return _bRPOSSalePointTotal;}
			set
			{
				if (value != this._bRPOSSalePointTotal)
				{
				_bRPOSSalePointTotal=value;
				NotifyChanged("BRPOSSalePointTotal");
				}
			}
		}
		#endregion
	}
	#endregion
}