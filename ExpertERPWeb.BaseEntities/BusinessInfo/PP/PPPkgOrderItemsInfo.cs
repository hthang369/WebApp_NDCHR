
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPPkgOrderItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.56)
    //Class: PPPkgOrderItemsInfo
    //Created Date: Friday, 03 Jun 2016
    //-----------------------------------------------------------

    public class PPPkgOrderItemsInfo : BusinessObject
    {
        public PPPkgOrderItemsInfo()
        {
        }
        #region Variables
        protected int _pPPkgOrderItemID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICStockID;
        protected int _fK_ICProductID;
        protected double _pPPkgOrderItemEstQty;
        protected double _pPPkgOrderItemActQty;
        protected double _pPPkgOrderItemUnitPkgCBM;
        protected double _pPPkgOrderItemEstPkgCBM;
        protected double _pPPkgOrderItemActPkgCBM;
        protected double _pPPkgOrderItemAllocateQty;
        protected double _pPPkgOrderItemAvaiQty;
        protected int _fK_PPPkgOrderID;
        protected double _pPPkgOrderItemUnitPrice;
        protected double _pPPkgOrderItemEstPkgPrice;
        protected double _pPPkgOrderItemActPkgPrice;
        protected String _pPPkgOrderItemSerialNo = String.Empty;
        protected int _fK_ICStockSlotID;
        protected double _pPPkgOrderItemRQty;
        protected double _pPPkgOrderItemCheckQty;
        protected double _pPPkgOrderItemCheckPkgCBM;
        protected double _pPPkgOrderItemCheckPrice;
        protected int _fK_ARSOID;
        protected int _fK_ICUOMID;
        protected int _fK_ICStkUOMID;
        protected double _pPPkgOrderItemQty;
        protected double _pPPkgOrderItemStkQty;
        protected double _pPPkgOrderItemRStkQty;
        protected int _fK_ICWeightUOMID;
        protected int _fK_ICVolumeUOMID;
        protected double _pPPkgOrderItemWTot;
        protected double _pPPkgOrderItemVTot;
        protected double _pPPkgOrderItemFact;
        protected double _pPPkgOrderItemExcQty;
        protected double _pPPkgOrderItemOrgQty;
        protected int _fK_ICOrgUOMID;
        protected int _fK_ARSOItemID;
        protected int _fK_ARShpPlanItemID;
        protected double _pPPkgOrderItemContQty;
        protected double _pPPkgOrderItemCQty;
        protected double _pPPkgOrderItemFUnitPrice;
        protected double _pPPkgOrderItemAdjFUnitPrice01;
        protected double _pPPkgOrderItemAdjFUnitPrice02;
        protected double _pPPkgOrderItemAdjFUnitPrice03;
        protected double _pPPkgOrderItemAdjFUnitPrice04;
        protected double _pPPkgOrderItemAdjFUnitPrice05;
        protected double _pPPkgOrderItemAdjUnitPrice01;
        protected double _pPPkgOrderItemAdjUnitPrice02;
        protected double _pPPkgOrderItemAdjUnitPrice03;
        protected double _pPPkgOrderItemAdjUnitPrice04;
        protected double _pPPkgOrderItemAdjUnitPrice05;
        protected double _pPPkgOrderItemOrgFUnitPrice;
        protected double _pPPkgOrderItemOrgUnitPrice;
        protected String _pPPkgOrderItemDesc = String.Empty;

        #endregion

        #region Public properties
        public int PPPkgOrderItemID
        {
            get { return _pPPkgOrderItemID; }
            set
            {
                if (value != this._pPPkgOrderItemID)
                {
                    _pPPkgOrderItemID = value;
                    NotifyChanged("PPPkgOrderItemID");
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
        public double PPPkgOrderItemEstQty
        {
            get { return _pPPkgOrderItemEstQty; }
            set
            {
                if (value != this._pPPkgOrderItemEstQty)
                {
                    _pPPkgOrderItemEstQty = value;
                    NotifyChanged("PPPkgOrderItemEstQty");
                }
            }
        }
        public double PPPkgOrderItemActQty
        {
            get { return _pPPkgOrderItemActQty; }
            set
            {
                if (value != this._pPPkgOrderItemActQty)
                {
                    _pPPkgOrderItemActQty = value;
                    NotifyChanged("PPPkgOrderItemActQty");
                }
            }
        }
        public double PPPkgOrderItemUnitPkgCBM
        {
            get { return _pPPkgOrderItemUnitPkgCBM; }
            set
            {
                if (value != this._pPPkgOrderItemUnitPkgCBM)
                {
                    _pPPkgOrderItemUnitPkgCBM = value;
                    NotifyChanged("PPPkgOrderItemUnitPkgCBM");
                }
            }
        }
        public double PPPkgOrderItemEstPkgCBM
        {
            get { return _pPPkgOrderItemEstPkgCBM; }
            set
            {
                if (value != this._pPPkgOrderItemEstPkgCBM)
                {
                    _pPPkgOrderItemEstPkgCBM = value;
                    NotifyChanged("PPPkgOrderItemEstPkgCBM");
                }
            }
        }
        public double PPPkgOrderItemActPkgCBM
        {
            get { return _pPPkgOrderItemActPkgCBM; }
            set
            {
                if (value != this._pPPkgOrderItemActPkgCBM)
                {
                    _pPPkgOrderItemActPkgCBM = value;
                    NotifyChanged("PPPkgOrderItemActPkgCBM");
                }
            }
        }
        public double PPPkgOrderItemAllocateQty
        {
            get { return _pPPkgOrderItemAllocateQty; }
            set
            {
                if (value != this._pPPkgOrderItemAllocateQty)
                {
                    _pPPkgOrderItemAllocateQty = value;
                    NotifyChanged("PPPkgOrderItemAllocateQty");
                }
            }
        }
        public double PPPkgOrderItemAvaiQty
        {
            get { return _pPPkgOrderItemAvaiQty; }
            set
            {
                if (value != this._pPPkgOrderItemAvaiQty)
                {
                    _pPPkgOrderItemAvaiQty = value;
                    NotifyChanged("PPPkgOrderItemAvaiQty");
                }
            }
        }
        public int FK_PPPkgOrderID
        {
            get { return _fK_PPPkgOrderID; }
            set
            {
                if (value != this._fK_PPPkgOrderID)
                {
                    _fK_PPPkgOrderID = value;
                    NotifyChanged("FK_PPPkgOrderID");
                }
            }
        }
        public double PPPkgOrderItemUnitPrice
        {
            get { return _pPPkgOrderItemUnitPrice; }
            set
            {
                if (value != this._pPPkgOrderItemUnitPrice)
                {
                    _pPPkgOrderItemUnitPrice = value;
                    NotifyChanged("PPPkgOrderItemUnitPrice");
                }
            }
        }
        public double PPPkgOrderItemEstPkgPrice
        {
            get { return _pPPkgOrderItemEstPkgPrice; }
            set
            {
                if (value != this._pPPkgOrderItemEstPkgPrice)
                {
                    _pPPkgOrderItemEstPkgPrice = value;
                    NotifyChanged("PPPkgOrderItemEstPkgPrice");
                }
            }
        }
        public double PPPkgOrderItemActPkgPrice
        {
            get { return _pPPkgOrderItemActPkgPrice; }
            set
            {
                if (value != this._pPPkgOrderItemActPkgPrice)
                {
                    _pPPkgOrderItemActPkgPrice = value;
                    NotifyChanged("PPPkgOrderItemActPkgPrice");
                }
            }
        }
        public String PPPkgOrderItemSerialNo
        {
            get { return _pPPkgOrderItemSerialNo; }
            set
            {
                if (value != this._pPPkgOrderItemSerialNo)
                {
                    _pPPkgOrderItemSerialNo = value;
                    NotifyChanged("PPPkgOrderItemSerialNo");
                }
            }
        }
        public int FK_ICStockSlotID
        {
            get { return _fK_ICStockSlotID; }
            set
            {
                if (value != this._fK_ICStockSlotID)
                {
                    _fK_ICStockSlotID = value;
                    NotifyChanged("FK_ICStockSlotID");
                }
            }
        }
        public double PPPkgOrderItemRQty
        {
            get { return _pPPkgOrderItemRQty; }
            set
            {
                if (value != this._pPPkgOrderItemRQty)
                {
                    _pPPkgOrderItemRQty = value;
                    NotifyChanged("PPPkgOrderItemRQty");
                }
            }
        }
        public double PPPkgOrderItemCheckQty
        {
            get { return _pPPkgOrderItemCheckQty; }
            set
            {
                if (value != this._pPPkgOrderItemCheckQty)
                {
                    _pPPkgOrderItemCheckQty = value;
                    NotifyChanged("PPPkgOrderItemCheckQty");
                }
            }
        }
        public double PPPkgOrderItemCheckPkgCBM
        {
            get { return _pPPkgOrderItemCheckPkgCBM; }
            set
            {
                if (value != this._pPPkgOrderItemCheckPkgCBM)
                {
                    _pPPkgOrderItemCheckPkgCBM = value;
                    NotifyChanged("PPPkgOrderItemCheckPkgCBM");
                }
            }
        }
        public double PPPkgOrderItemCheckPrice
        {
            get { return _pPPkgOrderItemCheckPrice; }
            set
            {
                if (value != this._pPPkgOrderItemCheckPrice)
                {
                    _pPPkgOrderItemCheckPrice = value;
                    NotifyChanged("PPPkgOrderItemCheckPrice");
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
        public double PPPkgOrderItemQty
        {
            get { return _pPPkgOrderItemQty; }
            set
            {
                if (value != this._pPPkgOrderItemQty)
                {
                    _pPPkgOrderItemQty = value;
                    NotifyChanged("PPPkgOrderItemQty");
                }
            }
        }
        public double PPPkgOrderItemStkQty
        {
            get { return _pPPkgOrderItemStkQty; }
            set
            {
                if (value != this._pPPkgOrderItemStkQty)
                {
                    _pPPkgOrderItemStkQty = value;
                    NotifyChanged("PPPkgOrderItemStkQty");
                }
            }
        }
        public double PPPkgOrderItemRStkQty
        {
            get { return _pPPkgOrderItemRStkQty; }
            set
            {
                if (value != this._pPPkgOrderItemRStkQty)
                {
                    _pPPkgOrderItemRStkQty = value;
                    NotifyChanged("PPPkgOrderItemRStkQty");
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
        public double PPPkgOrderItemWTot
        {
            get { return _pPPkgOrderItemWTot; }
            set
            {
                if (value != this._pPPkgOrderItemWTot)
                {
                    _pPPkgOrderItemWTot = value;
                    NotifyChanged("PPPkgOrderItemWTot");
                }
            }
        }
        public double PPPkgOrderItemVTot
        {
            get { return _pPPkgOrderItemVTot; }
            set
            {
                if (value != this._pPPkgOrderItemVTot)
                {
                    _pPPkgOrderItemVTot = value;
                    NotifyChanged("PPPkgOrderItemVTot");
                }
            }
        }
        public double PPPkgOrderItemFact
        {
            get { return _pPPkgOrderItemFact; }
            set
            {
                if (value != this._pPPkgOrderItemFact)
                {
                    _pPPkgOrderItemFact = value;
                    NotifyChanged("PPPkgOrderItemFact");
                }
            }
        }
        public double PPPkgOrderItemExcQty
        {
            get { return _pPPkgOrderItemExcQty; }
            set
            {
                if (value != this._pPPkgOrderItemExcQty)
                {
                    _pPPkgOrderItemExcQty = value;
                    NotifyChanged("PPPkgOrderItemExcQty");
                }
            }
        }
        public double PPPkgOrderItemOrgQty
        {
            get { return _pPPkgOrderItemOrgQty; }
            set
            {
                if (value != this._pPPkgOrderItemOrgQty)
                {
                    _pPPkgOrderItemOrgQty = value;
                    NotifyChanged("PPPkgOrderItemOrgQty");
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
        public double PPPkgOrderItemContQty
        {
            get { return _pPPkgOrderItemContQty; }
            set
            {
                if (value != this._pPPkgOrderItemContQty)
                {
                    _pPPkgOrderItemContQty = value;
                    NotifyChanged("PPPkgOrderItemContQty");
                }
            }
        }
        public double PPPkgOrderItemCQty
        {
            get { return _pPPkgOrderItemCQty; }
            set
            {
                if (value != this._pPPkgOrderItemCQty)
                {
                    _pPPkgOrderItemCQty = value;
                    NotifyChanged("PPPkgOrderItemCQty");
                }
            }
        }
        public double PPPkgOrderItemFUnitPrice
        {
            get { return _pPPkgOrderItemFUnitPrice; }
            set
            {
                if (value != this._pPPkgOrderItemFUnitPrice)
                {
                    _pPPkgOrderItemFUnitPrice = value;
                    NotifyChanged("PPPkgOrderItemFUnitPrice");
                }
            }
        }
        public double PPPkgOrderItemAdjFUnitPrice01
        {
            get { return _pPPkgOrderItemAdjFUnitPrice01; }
            set
            {
                if (value != this._pPPkgOrderItemAdjFUnitPrice01)
                {
                    _pPPkgOrderItemAdjFUnitPrice01 = value;
                    NotifyChanged("PPPkgOrderItemAdjFUnitPrice01");
                }
            }
        }
        public double PPPkgOrderItemAdjFUnitPrice02
        {
            get { return _pPPkgOrderItemAdjFUnitPrice02; }
            set
            {
                if (value != this._pPPkgOrderItemAdjFUnitPrice02)
                {
                    _pPPkgOrderItemAdjFUnitPrice02 = value;
                    NotifyChanged("PPPkgOrderItemAdjFUnitPrice02");
                }
            }
        }
        public double PPPkgOrderItemAdjFUnitPrice03
        {
            get { return _pPPkgOrderItemAdjFUnitPrice03; }
            set
            {
                if (value != this._pPPkgOrderItemAdjFUnitPrice03)
                {
                    _pPPkgOrderItemAdjFUnitPrice03 = value;
                    NotifyChanged("PPPkgOrderItemAdjFUnitPrice03");
                }
            }
        }
        public double PPPkgOrderItemAdjFUnitPrice04
        {
            get { return _pPPkgOrderItemAdjFUnitPrice04; }
            set
            {
                if (value != this._pPPkgOrderItemAdjFUnitPrice04)
                {
                    _pPPkgOrderItemAdjFUnitPrice04 = value;
                    NotifyChanged("PPPkgOrderItemAdjFUnitPrice04");
                }
            }
        }
        public double PPPkgOrderItemAdjFUnitPrice05
        {
            get { return _pPPkgOrderItemAdjFUnitPrice05; }
            set
            {
                if (value != this._pPPkgOrderItemAdjFUnitPrice05)
                {
                    _pPPkgOrderItemAdjFUnitPrice05 = value;
                    NotifyChanged("PPPkgOrderItemAdjFUnitPrice05");
                }
            }
        }
        public double PPPkgOrderItemAdjUnitPrice01
        {
            get { return _pPPkgOrderItemAdjUnitPrice01; }
            set
            {
                if (value != this._pPPkgOrderItemAdjUnitPrice01)
                {
                    _pPPkgOrderItemAdjUnitPrice01 = value;
                    NotifyChanged("PPPkgOrderItemAdjUnitPrice01");
                }
            }
        }
        public double PPPkgOrderItemAdjUnitPrice02
        {
            get { return _pPPkgOrderItemAdjUnitPrice02; }
            set
            {
                if (value != this._pPPkgOrderItemAdjUnitPrice02)
                {
                    _pPPkgOrderItemAdjUnitPrice02 = value;
                    NotifyChanged("PPPkgOrderItemAdjUnitPrice02");
                }
            }
        }
        public double PPPkgOrderItemAdjUnitPrice03
        {
            get { return _pPPkgOrderItemAdjUnitPrice03; }
            set
            {
                if (value != this._pPPkgOrderItemAdjUnitPrice03)
                {
                    _pPPkgOrderItemAdjUnitPrice03 = value;
                    NotifyChanged("PPPkgOrderItemAdjUnitPrice03");
                }
            }
        }
        public double PPPkgOrderItemAdjUnitPrice04
        {
            get { return _pPPkgOrderItemAdjUnitPrice04; }
            set
            {
                if (value != this._pPPkgOrderItemAdjUnitPrice04)
                {
                    _pPPkgOrderItemAdjUnitPrice04 = value;
                    NotifyChanged("PPPkgOrderItemAdjUnitPrice04");
                }
            }
        }
        public double PPPkgOrderItemAdjUnitPrice05
        {
            get { return _pPPkgOrderItemAdjUnitPrice05; }
            set
            {
                if (value != this._pPPkgOrderItemAdjUnitPrice05)
                {
                    _pPPkgOrderItemAdjUnitPrice05 = value;
                    NotifyChanged("PPPkgOrderItemAdjUnitPrice05");
                }
            }
        }
        public double PPPkgOrderItemOrgFUnitPrice
        {
            get { return _pPPkgOrderItemOrgFUnitPrice; }
            set
            {
                if (value != this._pPPkgOrderItemOrgFUnitPrice)
                {
                    _pPPkgOrderItemOrgFUnitPrice = value;
                    NotifyChanged("PPPkgOrderItemOrgFUnitPrice");
                }
            }
        }
        public double PPPkgOrderItemOrgUnitPrice
        {
            get { return _pPPkgOrderItemOrgUnitPrice; }
            set
            {
                if (value != this._pPPkgOrderItemOrgUnitPrice)
                {
                    _pPPkgOrderItemOrgUnitPrice = value;
                    NotifyChanged("PPPkgOrderItemOrgUnitPrice");
                }
            }
        }
        public String PPPkgOrderItemDesc
        {
            get { return _pPPkgOrderItemDesc; }
            set
            {
                if (value != this._pPPkgOrderItemDesc)
                {
                    _pPPkgOrderItemDesc = value;
                    NotifyChanged("PPPkgOrderItemDesc");
                }
            }
        }

        #endregion
    }
    #endregion
}