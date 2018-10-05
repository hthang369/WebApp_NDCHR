using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region PPProductionCostFactors
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:PPProductionCostFactorsInfo
	//Created Date:Wednesday, January 7, 2015
	//-----------------------------------------------------------
	
	public class PPProductionCostFactorsInfo:BusinessObject
	{
		public PPProductionCostFactorsInfo()
		{
		}
		#region Variables
		protected int _pPProductionCostFactorID;
		protected String _aAStatus=DefaultAAStatus;
		protected String _pPProductionCostFactorNo=String.Empty;
		protected String _pPProductionCostFactorName=String.Empty;
		protected String _pPProductionCostFactorDesc=String.Empty;
		protected String _pPProductionCostFactorTypeCombo=String.Empty;
		protected String _pPAccountListNo=String.Empty;
		protected String _pPProductionCostFactorConsolidateTypeCombo=String.Empty;
		protected int _fK_PPCostFactorID;
		protected int _pPYear;
		protected int _pPPeriod;
		#endregion

		#region Public properties
		public int PPProductionCostFactorID
		{
			get{return _pPProductionCostFactorID;}
			set
			{
				if (value != this._pPProductionCostFactorID)
				{
				_pPProductionCostFactorID=value;
				NotifyChanged("PPProductionCostFactorID");
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
		public String PPProductionCostFactorNo
		{
			get{return _pPProductionCostFactorNo;}
			set
			{
				if (value != this._pPProductionCostFactorNo)
				{
				_pPProductionCostFactorNo=value;
				NotifyChanged("PPProductionCostFactorNo");
				}
			}
		}
		public String PPProductionCostFactorName
		{
			get{return _pPProductionCostFactorName;}
			set
			{
				if (value != this._pPProductionCostFactorName)
				{
				_pPProductionCostFactorName=value;
				NotifyChanged("PPProductionCostFactorName");
				}
			}
		}
		public String PPProductionCostFactorDesc
		{
			get{return _pPProductionCostFactorDesc;}
			set
			{
				if (value != this._pPProductionCostFactorDesc)
				{
				_pPProductionCostFactorDesc=value;
				NotifyChanged("PPProductionCostFactorDesc");
				}
			}
		}
		public String PPProductionCostFactorTypeCombo
		{
			get{return _pPProductionCostFactorTypeCombo;}
			set
			{
				if (value != this._pPProductionCostFactorTypeCombo)
				{
				_pPProductionCostFactorTypeCombo=value;
				NotifyChanged("PPProductionCostFactorTypeCombo");
				}
			}
		}
		public String PPAccountListNo
		{
			get{return _pPAccountListNo;}
			set
			{
				if (value != this._pPAccountListNo)
				{
				_pPAccountListNo=value;
				NotifyChanged("PPAccountListNo");
				}
			}
		}
		public String PPProductionCostFactorConsolidateTypeCombo
		{
			get{return _pPProductionCostFactorConsolidateTypeCombo;}
			set
			{
				if (value != this._pPProductionCostFactorConsolidateTypeCombo)
				{
				_pPProductionCostFactorConsolidateTypeCombo=value;
				NotifyChanged("PPProductionCostFactorConsolidateTypeCombo");
				}
			}
		}
		public int FK_PPCostFactorID
		{
			get{return _fK_PPCostFactorID;}
			set
			{
				if (value != this._fK_PPCostFactorID)
				{
				_fK_PPCostFactorID=value;
				NotifyChanged("FK_PPCostFactorID");
				}
			}
		}
		public int PPYear
		{
			get{return _pPYear;}
			set
			{
				if (value != this._pPYear)
				{
				_pPYear=value;
				NotifyChanged("PPYear");
				}
			}
		}
		public int PPPeriod
		{
			get{return _pPPeriod;}
			set
			{
				if (value != this._pPPeriod)
				{
				_pPPeriod=value;
				NotifyChanged("PPPeriod");
				}
			}
		}
		#endregion
	}
	#endregion
}