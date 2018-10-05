
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPNormRMs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.83)
    //Class: PPNormRMsInfo
    //Created Date: Tuesday, 03 Jan 2017
    //-----------------------------------------------------------

    public class PPNormRMsInfo : BusinessObject
    {
        public PPNormRMsInfo()
        {
        }
        #region Variables
        protected int _pPNormRMID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_PPNormID;
        protected int _fK_ICProductID;
        protected double _pPNormRMQty;
        protected String _pPNormRMDesc = String.Empty;
        protected int _fK_PPPhaseCfgID;
        protected bool _pPNormRMIsMajorMaterial = true;
        protected double _pPNormRMLossPct;
        protected String _pPNormRMPictureLink = String.Empty;
        protected int _fK_PPWorkCenterID;
        protected int _fK_ICStockUOMID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected double _pPNormRMStkQty;
        protected double _pPNormRMRQty;
        protected double _pPNormRMRStkQty;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected double _pPNormRMWTot;
        protected double _pPNormRMVTot;
        protected double _pPNormRMFact;
        protected int _pPNormRMAllocatePct;
        protected int _fK_GEAnalysisID;
        protected int _fK_ADOFID;
        protected int _fK_ADOFItemID;
        protected String _pPNormRMRevision = String.Empty;
        protected bool _pPNormRMIsMainProductionCheck = true;
        protected double _pPNormRMLayout;

        #endregion

        #region Public properties
        public int PPNormRMID
        {
            get { return _pPNormRMID; }
            set
            {
                if (value != this._pPNormRMID)
                {
                    _pPNormRMID = value;
                    NotifyChanged("PPNormRMID");
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
        public double PPNormRMQty
        {
            get { return _pPNormRMQty; }
            set
            {
                if (value != this._pPNormRMQty)
                {
                    _pPNormRMQty = value;
                    NotifyChanged("PPNormRMQty");
                }
            }
        }
        public String PPNormRMDesc
        {
            get { return _pPNormRMDesc; }
            set
            {
                if (value != this._pPNormRMDesc)
                {
                    _pPNormRMDesc = value;
                    NotifyChanged("PPNormRMDesc");
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
        public bool PPNormRMIsMajorMaterial
        {
            get { return _pPNormRMIsMajorMaterial; }
            set
            {
                if (value != this._pPNormRMIsMajorMaterial)
                {
                    _pPNormRMIsMajorMaterial = value;
                    NotifyChanged("PPNormRMIsMajorMaterial");
                }
            }
        }
        public double PPNormRMLossPct
        {
            get { return _pPNormRMLossPct; }
            set
            {
                if (value != this._pPNormRMLossPct)
                {
                    _pPNormRMLossPct = value;
                    NotifyChanged("PPNormRMLossPct");
                }
            }
        }
        public String PPNormRMPictureLink
        {
            get { return _pPNormRMPictureLink; }
            set
            {
                if (value != this._pPNormRMPictureLink)
                {
                    _pPNormRMPictureLink = value;
                    NotifyChanged("PPNormRMPictureLink");
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
        public int FK_ICStockUOMID
        {
            get { return _fK_ICStockUOMID; }
            set
            {
                if (value != this._fK_ICStockUOMID)
                {
                    _fK_ICStockUOMID = value;
                    NotifyChanged("FK_ICStockUOMID");
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
        public double PPNormRMStkQty
        {
            get { return _pPNormRMStkQty; }
            set
            {
                if (value != this._pPNormRMStkQty)
                {
                    _pPNormRMStkQty = value;
                    NotifyChanged("PPNormRMStkQty");
                }
            }
        }
        public double PPNormRMRQty
        {
            get { return _pPNormRMRQty; }
            set
            {
                if (value != this._pPNormRMRQty)
                {
                    _pPNormRMRQty = value;
                    NotifyChanged("PPNormRMRQty");
                }
            }
        }
        public double PPNormRMRStkQty
        {
            get { return _pPNormRMRStkQty; }
            set
            {
                if (value != this._pPNormRMRStkQty)
                {
                    _pPNormRMRStkQty = value;
                    NotifyChanged("PPNormRMRStkQty");
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
        public double PPNormRMWTot
        {
            get { return _pPNormRMWTot; }
            set
            {
                if (value != this._pPNormRMWTot)
                {
                    _pPNormRMWTot = value;
                    NotifyChanged("PPNormRMWTot");
                }
            }
        }
        public double PPNormRMVTot
        {
            get { return _pPNormRMVTot; }
            set
            {
                if (value != this._pPNormRMVTot)
                {
                    _pPNormRMVTot = value;
                    NotifyChanged("PPNormRMVTot");
                }
            }
        }
        public double PPNormRMFact
        {
            get { return _pPNormRMFact; }
            set
            {
                if (value != this._pPNormRMFact)
                {
                    _pPNormRMFact = value;
                    NotifyChanged("PPNormRMFact");
                }
            }
        }
        public int PPNormRMAllocatePct
        {
            get { return _pPNormRMAllocatePct; }
            set
            {
                if (value != this._pPNormRMAllocatePct)
                {
                    _pPNormRMAllocatePct = value;
                    NotifyChanged("PPNormRMAllocatePct");
                }
            }
        }
        public int FK_GEAnalysisID
        {
            get { return _fK_GEAnalysisID; }
            set
            {
                if (value != this._fK_GEAnalysisID)
                {
                    _fK_GEAnalysisID = value;
                    NotifyChanged("FK_GEAnalysisID");
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
        public String PPNormRMRevision
        {
            get { return _pPNormRMRevision; }
            set
            {
                if (value != this._pPNormRMRevision)
                {
                    _pPNormRMRevision = value;
                    NotifyChanged("PPNormRMRevision");
                }
            }
        }
        public bool PPNormRMIsMainProductionCheck
        {
            get { return _pPNormRMIsMainProductionCheck; }
            set
            {
                if (value != this._pPNormRMIsMainProductionCheck)
                {
                    _pPNormRMIsMainProductionCheck = value;
                    NotifyChanged("PPNormRMIsMainProductionCheck");
                }
            }
        }
        public double PPNormRMLayout
        {
            get { return _pPNormRMLayout; }
            set
            {
                if (value != this._pPNormRMLayout)
                {
                    _pPNormRMLayout = value;
                    NotifyChanged("PPNormRMLayout");
                }
            }
        }

        #endregion
    }
    #endregion
}