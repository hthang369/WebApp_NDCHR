 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPProductionOrdrEstFGs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.18)
    //Class: PPProductionOrdrEstFGsInfo
    //Created Date: Friday, 21 Jul 2017
    //-----------------------------------------------------------

    public class PPProductionOrdrEstFGsInfo : BusinessObject
    {
        public PPProductionOrdrEstFGsInfo()
        {
        }
        #region Variables
		protected int _pPProductionOrdrEstFGID;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected int _fK_ICProductID;
		protected int _fK_ICStockID;
		protected int _fK_PPProductionOrdrID;
		protected int _fK_PPWOID;
		protected int _fK_PPPhaseCfgID;
		protected double _pPProductionOrdrEstFGQty;
		protected double _pPProductionOrdrEstFGMFQty;
		protected double _pPProductionOrdrEstFGMFRQty;
		protected double _pPProductionOrdrEstFGQCQty;
		protected double _pPProductionOrdrEstFGRQty;
		protected int _fK_PPWorkCenterID;
		protected int _fK_PPRoutingID;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _pPProductionOrdrEstFGStkQty;
		protected double _pPProductionOrdrEstFGRStkQty;
		protected int _fK_ICWeightUOMID;
		protected int _fK_ICVolumeUOMID;
		protected double _pPProductionOrdrEstFGWTot;
		protected double _pPProductionOrdrEstFGVTot;
		protected double _pPProductionOrdrEstFGFact;
		protected double _pPProductionOrdrEstFGExcQty;
		protected double _pPProductionOrdrEstFGOrgQty;
		protected int _fK_ICOrgUOMID;
		protected double _pPProductionOrdrEstFGCQty;
		protected int _fK_PPNormID;
		protected String _pPProductionOrdrEstFGLotNo = String.Empty;
		protected int _fK_ARSOID;
		protected int _fK_ARSOItemID;
		protected int _fK_ARShpPlanItemID;
		protected double _pPProductionOrdrEstFGNCRQty;
		protected String _pPProductionOrdrEstFGDesc = String.Empty;
		protected String _pPProductionOrdrEstFGNote = String.Empty;
		protected double _pPProductionOrdrEstFGSetupQty;
		protected Nullable<DateTime> _pPProductionOrdrEstEndDate;
		protected int _fK_PPResourceID;
		protected int _fK_PPResourceGroupID;
		protected int _fK_ICNCRStockID;
		protected int _fK_ICSetupStockID;
		protected double _pPProductionOrdrEstFGNCRRQty;
		protected double _pPProductionOrdrEstFGSetupRQty;
		
        #endregion

        #region Public properties
		public int PPProductionOrdrEstFGID
		{
			get { return _pPProductionOrdrEstFGID; }
			set
			{
				if (value != this._pPProductionOrdrEstFGID)
				{
					_pPProductionOrdrEstFGID = value;
					NotifyChanged("PPProductionOrdrEstFGID");
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
		public int FK_ICProductID
		{
			get { return _fK_ICProductID; }
			set
			{
				if (value != this._fK_ICProductID)
				{
					_fK_ICProductID = value;
					NotifyChanged("FK_ICProductID");
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
		public int FK_PPProductionOrdrID
		{
			get { return _fK_PPProductionOrdrID; }
			set
			{
				if (value != this._fK_PPProductionOrdrID)
				{
					_fK_PPProductionOrdrID = value;
					NotifyChanged("FK_PPProductionOrdrID");
				}
			}
		}
		public int FK_PPWOID
		{
			get { return _fK_PPWOID; }
			set
			{
				if (value != this._fK_PPWOID)
				{
					_fK_PPWOID = value;
					NotifyChanged("FK_PPWOID");
				}
			}
		}
		public int FK_PPPhaseCfgID
		{
			get { return _fK_PPPhaseCfgID; }
			set
			{
				if (value != this._fK_PPPhaseCfgID)
				{
					_fK_PPPhaseCfgID = value;
					NotifyChanged("FK_PPPhaseCfgID");
				}
			}
		}
		public double PPProductionOrdrEstFGQty
		{
			get { return _pPProductionOrdrEstFGQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGQty)
				{
					_pPProductionOrdrEstFGQty = value;
					NotifyChanged("PPProductionOrdrEstFGQty");
				}
			}
		}
		public double PPProductionOrdrEstFGMFQty
		{
			get { return _pPProductionOrdrEstFGMFQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGMFQty)
				{
					_pPProductionOrdrEstFGMFQty = value;
					NotifyChanged("PPProductionOrdrEstFGMFQty");
				}
			}
		}
		public double PPProductionOrdrEstFGMFRQty
		{
			get { return _pPProductionOrdrEstFGMFRQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGMFRQty)
				{
					_pPProductionOrdrEstFGMFRQty = value;
					NotifyChanged("PPProductionOrdrEstFGMFRQty");
				}
			}
		}
		public double PPProductionOrdrEstFGQCQty
		{
			get { return _pPProductionOrdrEstFGQCQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGQCQty)
				{
					_pPProductionOrdrEstFGQCQty = value;
					NotifyChanged("PPProductionOrdrEstFGQCQty");
				}
			}
		}
		public double PPProductionOrdrEstFGRQty
		{
			get { return _pPProductionOrdrEstFGRQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGRQty)
				{
					_pPProductionOrdrEstFGRQty = value;
					NotifyChanged("PPProductionOrdrEstFGRQty");
				}
			}
		}
		public int FK_PPWorkCenterID
		{
			get { return _fK_PPWorkCenterID; }
			set
			{
				if (value != this._fK_PPWorkCenterID)
				{
					_fK_PPWorkCenterID = value;
					NotifyChanged("FK_PPWorkCenterID");
				}
			}
		}
		public int FK_PPRoutingID
		{
			get { return _fK_PPRoutingID; }
			set
			{
				if (value != this._fK_PPRoutingID)
				{
					_fK_PPRoutingID = value;
					NotifyChanged("FK_PPRoutingID");
				}
			}
		}
		public int FK_ICUOMID
		{
			get { return _fK_ICUOMID; }
			set
			{
				if (value != this._fK_ICUOMID)
				{
					_fK_ICUOMID = value;
					NotifyChanged("FK_ICUOMID");
				}
			}
		}
		public int FK_ICStkUOMID
		{
			get { return _fK_ICStkUOMID; }
			set
			{
				if (value != this._fK_ICStkUOMID)
				{
					_fK_ICStkUOMID = value;
					NotifyChanged("FK_ICStkUOMID");
				}
			}
		}
		public double PPProductionOrdrEstFGStkQty
		{
			get { return _pPProductionOrdrEstFGStkQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGStkQty)
				{
					_pPProductionOrdrEstFGStkQty = value;
					NotifyChanged("PPProductionOrdrEstFGStkQty");
				}
			}
		}
		public double PPProductionOrdrEstFGRStkQty
		{
			get { return _pPProductionOrdrEstFGRStkQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGRStkQty)
				{
					_pPProductionOrdrEstFGRStkQty = value;
					NotifyChanged("PPProductionOrdrEstFGRStkQty");
				}
			}
		}
		public int FK_ICWeightUOMID
		{
			get { return _fK_ICWeightUOMID; }
			set
			{
				if (value != this._fK_ICWeightUOMID)
				{
					_fK_ICWeightUOMID = value;
					NotifyChanged("FK_ICWeightUOMID");
				}
			}
		}
		public int FK_ICVolumeUOMID
		{
			get { return _fK_ICVolumeUOMID; }
			set
			{
				if (value != this._fK_ICVolumeUOMID)
				{
					_fK_ICVolumeUOMID = value;
					NotifyChanged("FK_ICVolumeUOMID");
				}
			}
		}
		public double PPProductionOrdrEstFGWTot
		{
			get { return _pPProductionOrdrEstFGWTot; }
			set
			{
				if (value != this._pPProductionOrdrEstFGWTot)
				{
					_pPProductionOrdrEstFGWTot = value;
					NotifyChanged("PPProductionOrdrEstFGWTot");
				}
			}
		}
		public double PPProductionOrdrEstFGVTot
		{
			get { return _pPProductionOrdrEstFGVTot; }
			set
			{
				if (value != this._pPProductionOrdrEstFGVTot)
				{
					_pPProductionOrdrEstFGVTot = value;
					NotifyChanged("PPProductionOrdrEstFGVTot");
				}
			}
		}
		public double PPProductionOrdrEstFGFact
		{
			get { return _pPProductionOrdrEstFGFact; }
			set
			{
				if (value != this._pPProductionOrdrEstFGFact)
				{
					_pPProductionOrdrEstFGFact = value;
					NotifyChanged("PPProductionOrdrEstFGFact");
				}
			}
		}
		public double PPProductionOrdrEstFGExcQty
		{
			get { return _pPProductionOrdrEstFGExcQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGExcQty)
				{
					_pPProductionOrdrEstFGExcQty = value;
					NotifyChanged("PPProductionOrdrEstFGExcQty");
				}
			}
		}
		public double PPProductionOrdrEstFGOrgQty
		{
			get { return _pPProductionOrdrEstFGOrgQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGOrgQty)
				{
					_pPProductionOrdrEstFGOrgQty = value;
					NotifyChanged("PPProductionOrdrEstFGOrgQty");
				}
			}
		}
		public int FK_ICOrgUOMID
		{
			get { return _fK_ICOrgUOMID; }
			set
			{
				if (value != this._fK_ICOrgUOMID)
				{
					_fK_ICOrgUOMID = value;
					NotifyChanged("FK_ICOrgUOMID");
				}
			}
		}
		public double PPProductionOrdrEstFGCQty
		{
			get { return _pPProductionOrdrEstFGCQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGCQty)
				{
					_pPProductionOrdrEstFGCQty = value;
					NotifyChanged("PPProductionOrdrEstFGCQty");
				}
			}
		}
		public int FK_PPNormID
		{
			get { return _fK_PPNormID; }
			set
			{
				if (value != this._fK_PPNormID)
				{
					_fK_PPNormID = value;
					NotifyChanged("FK_PPNormID");
				}
			}
		}
		public String PPProductionOrdrEstFGLotNo
		{
			get { return _pPProductionOrdrEstFGLotNo; }
			set
			{
				if (value != this._pPProductionOrdrEstFGLotNo)
				{
					_pPProductionOrdrEstFGLotNo = value;
					NotifyChanged("PPProductionOrdrEstFGLotNo");
				}
			}
		}
		public int FK_ARSOID
		{
			get { return _fK_ARSOID; }
			set
			{
				if (value != this._fK_ARSOID)
				{
					_fK_ARSOID = value;
					NotifyChanged("FK_ARSOID");
				}
			}
		}
		public int FK_ARSOItemID
		{
			get { return _fK_ARSOItemID; }
			set
			{
				if (value != this._fK_ARSOItemID)
				{
					_fK_ARSOItemID = value;
					NotifyChanged("FK_ARSOItemID");
				}
			}
		}
		public int FK_ARShpPlanItemID
		{
			get { return _fK_ARShpPlanItemID; }
			set
			{
				if (value != this._fK_ARShpPlanItemID)
				{
					_fK_ARShpPlanItemID = value;
					NotifyChanged("FK_ARShpPlanItemID");
				}
			}
		}
		public double PPProductionOrdrEstFGNCRQty
		{
			get { return _pPProductionOrdrEstFGNCRQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGNCRQty)
				{
					_pPProductionOrdrEstFGNCRQty = value;
					NotifyChanged("PPProductionOrdrEstFGNCRQty");
				}
			}
		}
		public String PPProductionOrdrEstFGDesc
		{
			get { return _pPProductionOrdrEstFGDesc; }
			set
			{
				if (value != this._pPProductionOrdrEstFGDesc)
				{
					_pPProductionOrdrEstFGDesc = value;
					NotifyChanged("PPProductionOrdrEstFGDesc");
				}
			}
		}
		public String PPProductionOrdrEstFGNote
		{
			get { return _pPProductionOrdrEstFGNote; }
			set
			{
				if (value != this._pPProductionOrdrEstFGNote)
				{
					_pPProductionOrdrEstFGNote = value;
					NotifyChanged("PPProductionOrdrEstFGNote");
				}
			}
		}
		public double PPProductionOrdrEstFGSetupQty
		{
			get { return _pPProductionOrdrEstFGSetupQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGSetupQty)
				{
					_pPProductionOrdrEstFGSetupQty = value;
					NotifyChanged("PPProductionOrdrEstFGSetupQty");
				}
			}
		}
		public Nullable<DateTime> PPProductionOrdrEstEndDate
		{
			get { return _pPProductionOrdrEstEndDate; }
			set
			{
				if (value != this._pPProductionOrdrEstEndDate)
				{
					_pPProductionOrdrEstEndDate = value;
					NotifyChanged("PPProductionOrdrEstEndDate");
				}
			}
		}
		public int FK_PPResourceID
		{
			get { return _fK_PPResourceID; }
			set
			{
				if (value != this._fK_PPResourceID)
				{
					_fK_PPResourceID = value;
					NotifyChanged("FK_PPResourceID");
				}
			}
		}
		public int FK_PPResourceGroupID
		{
			get { return _fK_PPResourceGroupID; }
			set
			{
				if (value != this._fK_PPResourceGroupID)
				{
					_fK_PPResourceGroupID = value;
					NotifyChanged("FK_PPResourceGroupID");
				}
			}
		}
		public int FK_ICNCRStockID
		{
			get { return _fK_ICNCRStockID; }
			set
			{
				if (value != this._fK_ICNCRStockID)
				{
					_fK_ICNCRStockID = value;
					NotifyChanged("FK_ICNCRStockID");
				}
			}
		}
		public int FK_ICSetupStockID
		{
			get { return _fK_ICSetupStockID; }
			set
			{
				if (value != this._fK_ICSetupStockID)
				{
					_fK_ICSetupStockID = value;
					NotifyChanged("FK_ICSetupStockID");
				}
			}
		}
		public double PPProductionOrdrEstFGNCRRQty
		{
			get { return _pPProductionOrdrEstFGNCRRQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGNCRRQty)
				{
					_pPProductionOrdrEstFGNCRRQty = value;
					NotifyChanged("PPProductionOrdrEstFGNCRRQty");
				}
			}
		}
		public double PPProductionOrdrEstFGSetupRQty
		{
			get { return _pPProductionOrdrEstFGSetupRQty; }
			set
			{
				if (value != this._pPProductionOrdrEstFGSetupRQty)
				{
					_pPProductionOrdrEstFGSetupRQty = value;
					NotifyChanged("PPProductionOrdrEstFGSetupRQty");
				}
			}
		}
		
        #endregion
    }
    #endregion
}