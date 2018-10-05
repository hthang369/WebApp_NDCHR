using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARCustomerProductReqItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v1.0.21)
    //Class: ARCustomerProductReqItemsInfo
    //Created Date: Thursday, 20 Apr 2017
    //-----------------------------------------------------------

    public class ARCustomerProductReqItemsInfo : BusinessObject
    {
        public ARCustomerProductReqItemsInfo()
        {
        }
        #region Variables
        protected int _aRCustomerProductReqItemID;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_ICProductID;
        protected String _aRCustomerProductReqItemNo = String.Empty;
        protected String _aRCustomerProductReqItemName = String.Empty;
        protected String _aRCustomerProductReqItemDesc = String.Empty;
        protected int _fK_ARCustomerReqID;
        protected String _aRCustomerProductReqItemAction = String.Empty;
        protected double _aRCustomerProductReqItemQty;
        protected String _aRCustomerProductReqItemAccessoryCombo = String.Empty;
        protected String _aRCustomerProductReqItemBindingRemark = String.Empty;
        protected double _aRCustomerProductReqItemDeliveryAdvance;
        protected String _aRCustomerProductReqItemDeliveryPayment = String.Empty;
        protected String _aRCustomerProductReqItemDeliveryPaymentCombo = String.Empty;
        protected String _aRCustomerProductReqItemDeliveryShipTo = String.Empty;
        protected String _aRCustomerProductReqItemDeliveryTerm = String.Empty;
        protected String _aRCustomerProductReqItemDeliveryZone = String.Empty;
        protected Nullable<DateTime> _aRCustomerProductReqItemDigitalDate;
        protected String _aRCustomerProductReqItemDigitalName = String.Empty;
        protected double _aRCustomerProductReqItemDimensionHeight;
        protected double _aRCustomerProductReqItemDimensionLength;
        protected double _aRCustomerProductReqItemDimensionWidth;
        protected String _aRCustomerProductReqItemExtraCostPayment = String.Empty;
        protected double _aRCustomerProductReqItemExtraCostPrice;
        protected String _aRCustomerProductReqItemExtraCostRemark = String.Empty;
        protected String _aRCustomerProductReqItemExtraCostTitle = String.Empty;
        protected String _aRCustomerProductReqItemForecastCombo = String.Empty;
        protected String _aRCustomerProductReqItemGluingCombo = String.Empty;
        protected String _aRCustomerProductReqItemInkTechCombo = String.Empty;
        protected Nullable<DateTime> _aRCustomerProductReqItemINNActualDate;
        protected Nullable<DateTime> _aRCustomerProductReqItemINNExpectedDate;
        protected Nullable<DateTime> _aRCustomerProductReqItemINNReceiptDate;
        protected Nullable<DateTime> _aRCustomerProductReqItemMarketingIssueDate;
        protected Nullable<DateTime> _aRCustomerProductReqItemMarketingRequestDate;
        protected Nullable<DateTime> _aRCustomerProductReqItemMockDate;
        protected String _aRCustomerProductReqItemMockName = String.Empty;
        protected String _aRCustomerProductReqItemOtherAttachedCombo = String.Empty;
        protected String _aRCustomerProductReqItemOtherRemark = String.Empty;
        protected String _aRCustomerProductReqItemPackingCombo = String.Empty;
        protected double _aRCustomerProductReqItemPageAddQty;
        protected String _aRCustomerProductReqItemPageExtent = String.Empty;
        protected double _aRCustomerProductReqItemPageTotalQty;
        protected String _aRCustomerProductReqItemPaperName = String.Empty;
        protected String _aRCustomerProductReqItemPrintAttachedCombo = String.Empty;
        protected String _aRCustomerProductReqItemPrintBarcode = String.Empty;
        protected String _aRCustomerProductReqItemPrintFinishingCombo = String.Empty;
        protected String _aRCustomerProductReqItemPrintingFinishing = String.Empty;
        protected double _aRCustomerProductReqItemPrintingNumber;
        protected double _aRCustomerProductReqItemPrintingSpecial;
        protected String _aRCustomerProductReqItemPrintInkName = String.Empty;
        protected String _aRCustomerProductReqItemPrintProcessInkCombo = String.Empty;
        protected String _aRCustomerProductReqItemPrintRemark = String.Empty;
        protected String _aRCustomerProductReqItemPrintTechCombo = String.Empty;
        protected Nullable<DateTime> _aRCustomerProductReqItemSampleCartonDate;
        protected String _aRCustomerProductReqItemSampleCartonName = String.Empty;
        protected Nullable<DateTime> _aRCustomerProductReqItemStdDate;
        protected String _aRCustomerProductReqItemStdName = String.Empty;
        protected String _aRCustomerProductReqItemStyleBottomCombo = String.Empty;
        protected String _aRCustomerProductReqItemStyleTopCombo = String.Empty;
        protected String _aRCustomerProductReqItemTypeCombo = String.Empty;
        protected int _fK_ICUOMID;

        #endregion

        #region Public properties
        public int ARCustomerProductReqItemID
        {
            get { return _aRCustomerProductReqItemID; }
            set
            {
                if (value != this._aRCustomerProductReqItemID)
                {
                    _aRCustomerProductReqItemID = value;
                    NotifyChanged("ARCustomerProductReqItemID");
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
        public String ARCustomerProductReqItemNo
        {
            get { return _aRCustomerProductReqItemNo; }
            set
            {
                if (value != this._aRCustomerProductReqItemNo)
                {
                    _aRCustomerProductReqItemNo = value;
                    NotifyChanged("ARCustomerProductReqItemNo");
                }
            }
        }
        public String ARCustomerProductReqItemName
        {
            get { return _aRCustomerProductReqItemName; }
            set
            {
                if (value != this._aRCustomerProductReqItemName)
                {
                    _aRCustomerProductReqItemName = value;
                    NotifyChanged("ARCustomerProductReqItemName");
                }
            }
        }
        public String ARCustomerProductReqItemDesc
        {
            get { return _aRCustomerProductReqItemDesc; }
            set
            {
                if (value != this._aRCustomerProductReqItemDesc)
                {
                    _aRCustomerProductReqItemDesc = value;
                    NotifyChanged("ARCustomerProductReqItemDesc");
                }
            }
        }
        public int FK_ARCustomerReqID
        {
            get { return _fK_ARCustomerReqID; }
            set
            {
                if (value != this._fK_ARCustomerReqID)
                {
                    _fK_ARCustomerReqID = value;
                    NotifyChanged("FK_ARCustomerReqID");
                }
            }
        }
        public String ARCustomerProductReqItemAction
        {
            get { return _aRCustomerProductReqItemAction; }
            set
            {
                if (value != this._aRCustomerProductReqItemAction)
                {
                    _aRCustomerProductReqItemAction = value;
                    NotifyChanged("ARCustomerProductReqItemAction");
                }
            }
        }
        public double ARCustomerProductReqItemQty
        {
            get { return _aRCustomerProductReqItemQty; }
            set
            {
                if (value != this._aRCustomerProductReqItemQty)
                {
                    _aRCustomerProductReqItemQty = value;
                    NotifyChanged("ARCustomerProductReqItemQty");
                }
            }
        }
        public String ARCustomerProductReqItemAccessoryCombo
        {
            get { return _aRCustomerProductReqItemAccessoryCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemAccessoryCombo)
                {
                    _aRCustomerProductReqItemAccessoryCombo = value;
                    NotifyChanged("ARCustomerProductReqItemAccessoryCombo");
                }
            }
        }
        public String ARCustomerProductReqItemBindingRemark
        {
            get { return _aRCustomerProductReqItemBindingRemark; }
            set
            {
                if (value != this._aRCustomerProductReqItemBindingRemark)
                {
                    _aRCustomerProductReqItemBindingRemark = value;
                    NotifyChanged("ARCustomerProductReqItemBindingRemark");
                }
            }
        }
        public double ARCustomerProductReqItemDeliveryAdvance
        {
            get { return _aRCustomerProductReqItemDeliveryAdvance; }
            set
            {
                if (value != this._aRCustomerProductReqItemDeliveryAdvance)
                {
                    _aRCustomerProductReqItemDeliveryAdvance = value;
                    NotifyChanged("ARCustomerProductReqItemDeliveryAdvance");
                }
            }
        }
        public String ARCustomerProductReqItemDeliveryPayment
        {
            get { return _aRCustomerProductReqItemDeliveryPayment; }
            set
            {
                if (value != this._aRCustomerProductReqItemDeliveryPayment)
                {
                    _aRCustomerProductReqItemDeliveryPayment = value;
                    NotifyChanged("ARCustomerProductReqItemDeliveryPayment");
                }
            }
        }
        public String ARCustomerProductReqItemDeliveryPaymentCombo
        {
            get { return _aRCustomerProductReqItemDeliveryPaymentCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemDeliveryPaymentCombo)
                {
                    _aRCustomerProductReqItemDeliveryPaymentCombo = value;
                    NotifyChanged("ARCustomerProductReqItemDeliveryPaymentCombo");
                }
            }
        }
        public String ARCustomerProductReqItemDeliveryShipTo
        {
            get { return _aRCustomerProductReqItemDeliveryShipTo; }
            set
            {
                if (value != this._aRCustomerProductReqItemDeliveryShipTo)
                {
                    _aRCustomerProductReqItemDeliveryShipTo = value;
                    NotifyChanged("ARCustomerProductReqItemDeliveryShipTo");
                }
            }
        }
        public String ARCustomerProductReqItemDeliveryTerm
        {
            get { return _aRCustomerProductReqItemDeliveryTerm; }
            set
            {
                if (value != this._aRCustomerProductReqItemDeliveryTerm)
                {
                    _aRCustomerProductReqItemDeliveryTerm = value;
                    NotifyChanged("ARCustomerProductReqItemDeliveryTerm");
                }
            }
        }
        public String ARCustomerProductReqItemDeliveryZone
        {
            get { return _aRCustomerProductReqItemDeliveryZone; }
            set
            {
                if (value != this._aRCustomerProductReqItemDeliveryZone)
                {
                    _aRCustomerProductReqItemDeliveryZone = value;
                    NotifyChanged("ARCustomerProductReqItemDeliveryZone");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemDigitalDate
        {
            get { return _aRCustomerProductReqItemDigitalDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemDigitalDate)
                {
                    _aRCustomerProductReqItemDigitalDate = value;
                    NotifyChanged("ARCustomerProductReqItemDigitalDate");
                }
            }
        }
        public String ARCustomerProductReqItemDigitalName
        {
            get { return _aRCustomerProductReqItemDigitalName; }
            set
            {
                if (value != this._aRCustomerProductReqItemDigitalName)
                {
                    _aRCustomerProductReqItemDigitalName = value;
                    NotifyChanged("ARCustomerProductReqItemDigitalName");
                }
            }
        }
        public double ARCustomerProductReqItemDimensionHeight
        {
            get { return _aRCustomerProductReqItemDimensionHeight; }
            set
            {
                if (value != this._aRCustomerProductReqItemDimensionHeight)
                {
                    _aRCustomerProductReqItemDimensionHeight = value;
                    NotifyChanged("ARCustomerProductReqItemDimensionHeight");
                }
            }
        }
        public double ARCustomerProductReqItemDimensionLength
        {
            get { return _aRCustomerProductReqItemDimensionLength; }
            set
            {
                if (value != this._aRCustomerProductReqItemDimensionLength)
                {
                    _aRCustomerProductReqItemDimensionLength = value;
                    NotifyChanged("ARCustomerProductReqItemDimensionLength");
                }
            }
        }
        public double ARCustomerProductReqItemDimensionWidth
        {
            get { return _aRCustomerProductReqItemDimensionWidth; }
            set
            {
                if (value != this._aRCustomerProductReqItemDimensionWidth)
                {
                    _aRCustomerProductReqItemDimensionWidth = value;
                    NotifyChanged("ARCustomerProductReqItemDimensionWidth");
                }
            }
        }
        public String ARCustomerProductReqItemExtraCostPayment
        {
            get { return _aRCustomerProductReqItemExtraCostPayment; }
            set
            {
                if (value != this._aRCustomerProductReqItemExtraCostPayment)
                {
                    _aRCustomerProductReqItemExtraCostPayment = value;
                    NotifyChanged("ARCustomerProductReqItemExtraCostPayment");
                }
            }
        }
        public double ARCustomerProductReqItemExtraCostPrice
        {
            get { return _aRCustomerProductReqItemExtraCostPrice; }
            set
            {
                if (value != this._aRCustomerProductReqItemExtraCostPrice)
                {
                    _aRCustomerProductReqItemExtraCostPrice = value;
                    NotifyChanged("ARCustomerProductReqItemExtraCostPrice");
                }
            }
        }
        public String ARCustomerProductReqItemExtraCostRemark
        {
            get { return _aRCustomerProductReqItemExtraCostRemark; }
            set
            {
                if (value != this._aRCustomerProductReqItemExtraCostRemark)
                {
                    _aRCustomerProductReqItemExtraCostRemark = value;
                    NotifyChanged("ARCustomerProductReqItemExtraCostRemark");
                }
            }
        }
        public String ARCustomerProductReqItemExtraCostTitle
        {
            get { return _aRCustomerProductReqItemExtraCostTitle; }
            set
            {
                if (value != this._aRCustomerProductReqItemExtraCostTitle)
                {
                    _aRCustomerProductReqItemExtraCostTitle = value;
                    NotifyChanged("ARCustomerProductReqItemExtraCostTitle");
                }
            }
        }
        public String ARCustomerProductReqItemForecastCombo
        {
            get { return _aRCustomerProductReqItemForecastCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemForecastCombo)
                {
                    _aRCustomerProductReqItemForecastCombo = value;
                    NotifyChanged("ARCustomerProductReqItemForecastCombo");
                }
            }
        }
        public String ARCustomerProductReqItemGluingCombo
        {
            get { return _aRCustomerProductReqItemGluingCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemGluingCombo)
                {
                    _aRCustomerProductReqItemGluingCombo = value;
                    NotifyChanged("ARCustomerProductReqItemGluingCombo");
                }
            }
        }
        public String ARCustomerProductReqItemInkTechCombo
        {
            get { return _aRCustomerProductReqItemInkTechCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemInkTechCombo)
                {
                    _aRCustomerProductReqItemInkTechCombo = value;
                    NotifyChanged("ARCustomerProductReqItemInkTechCombo");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemINNActualDate
        {
            get { return _aRCustomerProductReqItemINNActualDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemINNActualDate)
                {
                    _aRCustomerProductReqItemINNActualDate = value;
                    NotifyChanged("ARCustomerProductReqItemINNActualDate");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemINNExpectedDate
        {
            get { return _aRCustomerProductReqItemINNExpectedDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemINNExpectedDate)
                {
                    _aRCustomerProductReqItemINNExpectedDate = value;
                    NotifyChanged("ARCustomerProductReqItemINNExpectedDate");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemINNReceiptDate
        {
            get { return _aRCustomerProductReqItemINNReceiptDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemINNReceiptDate)
                {
                    _aRCustomerProductReqItemINNReceiptDate = value;
                    NotifyChanged("ARCustomerProductReqItemINNReceiptDate");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemMarketingIssueDate
        {
            get { return _aRCustomerProductReqItemMarketingIssueDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemMarketingIssueDate)
                {
                    _aRCustomerProductReqItemMarketingIssueDate = value;
                    NotifyChanged("ARCustomerProductReqItemMarketingIssueDate");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemMarketingRequestDate
        {
            get { return _aRCustomerProductReqItemMarketingRequestDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemMarketingRequestDate)
                {
                    _aRCustomerProductReqItemMarketingRequestDate = value;
                    NotifyChanged("ARCustomerProductReqItemMarketingRequestDate");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemMockDate
        {
            get { return _aRCustomerProductReqItemMockDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemMockDate)
                {
                    _aRCustomerProductReqItemMockDate = value;
                    NotifyChanged("ARCustomerProductReqItemMockDate");
                }
            }
        }
        public String ARCustomerProductReqItemMockName
        {
            get { return _aRCustomerProductReqItemMockName; }
            set
            {
                if (value != this._aRCustomerProductReqItemMockName)
                {
                    _aRCustomerProductReqItemMockName = value;
                    NotifyChanged("ARCustomerProductReqItemMockName");
                }
            }
        }
        public String ARCustomerProductReqItemOtherAttachedCombo
        {
            get { return _aRCustomerProductReqItemOtherAttachedCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemOtherAttachedCombo)
                {
                    _aRCustomerProductReqItemOtherAttachedCombo = value;
                    NotifyChanged("ARCustomerProductReqItemOtherAttachedCombo");
                }
            }
        }
        public String ARCustomerProductReqItemOtherRemark
        {
            get { return _aRCustomerProductReqItemOtherRemark; }
            set
            {
                if (value != this._aRCustomerProductReqItemOtherRemark)
                {
                    _aRCustomerProductReqItemOtherRemark = value;
                    NotifyChanged("ARCustomerProductReqItemOtherRemark");
                }
            }
        }
        public String ARCustomerProductReqItemPackingCombo
        {
            get { return _aRCustomerProductReqItemPackingCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemPackingCombo)
                {
                    _aRCustomerProductReqItemPackingCombo = value;
                    NotifyChanged("ARCustomerProductReqItemPackingCombo");
                }
            }
        }
        public double ARCustomerProductReqItemPageAddQty
        {
            get { return _aRCustomerProductReqItemPageAddQty; }
            set
            {
                if (value != this._aRCustomerProductReqItemPageAddQty)
                {
                    _aRCustomerProductReqItemPageAddQty = value;
                    NotifyChanged("ARCustomerProductReqItemPageAddQty");
                }
            }
        }
        public String ARCustomerProductReqItemPageExtent
        {
            get { return _aRCustomerProductReqItemPageExtent; }
            set
            {
                if (value != this._aRCustomerProductReqItemPageExtent)
                {
                    _aRCustomerProductReqItemPageExtent = value;
                    NotifyChanged("ARCustomerProductReqItemPageExtent");
                }
            }
        }
        public double ARCustomerProductReqItemPageTotalQty
        {
            get { return _aRCustomerProductReqItemPageTotalQty; }
            set
            {
                if (value != this._aRCustomerProductReqItemPageTotalQty)
                {
                    _aRCustomerProductReqItemPageTotalQty = value;
                    NotifyChanged("ARCustomerProductReqItemPageTotalQty");
                }
            }
        }
        public String ARCustomerProductReqItemPaperName
        {
            get { return _aRCustomerProductReqItemPaperName; }
            set
            {
                if (value != this._aRCustomerProductReqItemPaperName)
                {
                    _aRCustomerProductReqItemPaperName = value;
                    NotifyChanged("ARCustomerProductReqItemPaperName");
                }
            }
        }
        public String ARCustomerProductReqItemPrintAttachedCombo
        {
            get { return _aRCustomerProductReqItemPrintAttachedCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintAttachedCombo)
                {
                    _aRCustomerProductReqItemPrintAttachedCombo = value;
                    NotifyChanged("ARCustomerProductReqItemPrintAttachedCombo");
                }
            }
        }
        public String ARCustomerProductReqItemPrintBarcode
        {
            get { return _aRCustomerProductReqItemPrintBarcode; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintBarcode)
                {
                    _aRCustomerProductReqItemPrintBarcode = value;
                    NotifyChanged("ARCustomerProductReqItemPrintBarcode");
                }
            }
        }
        public String ARCustomerProductReqItemPrintFinishingCombo
        {
            get { return _aRCustomerProductReqItemPrintFinishingCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintFinishingCombo)
                {
                    _aRCustomerProductReqItemPrintFinishingCombo = value;
                    NotifyChanged("ARCustomerProductReqItemPrintFinishingCombo");
                }
            }
        }
        public String ARCustomerProductReqItemPrintingFinishing
        {
            get { return _aRCustomerProductReqItemPrintingFinishing; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintingFinishing)
                {
                    _aRCustomerProductReqItemPrintingFinishing = value;
                    NotifyChanged("ARCustomerProductReqItemPrintingFinishing");
                }
            }
        }
        public double ARCustomerProductReqItemPrintingNumber
        {
            get { return _aRCustomerProductReqItemPrintingNumber; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintingNumber)
                {
                    _aRCustomerProductReqItemPrintingNumber = value;
                    NotifyChanged("ARCustomerProductReqItemPrintingNumber");
                }
            }
        }
        public double ARCustomerProductReqItemPrintingSpecial
        {
            get { return _aRCustomerProductReqItemPrintingSpecial; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintingSpecial)
                {
                    _aRCustomerProductReqItemPrintingSpecial = value;
                    NotifyChanged("ARCustomerProductReqItemPrintingSpecial");
                }
            }
        }
        public String ARCustomerProductReqItemPrintInkName
        {
            get { return _aRCustomerProductReqItemPrintInkName; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintInkName)
                {
                    _aRCustomerProductReqItemPrintInkName = value;
                    NotifyChanged("ARCustomerProductReqItemPrintInkName");
                }
            }
        }
        public String ARCustomerProductReqItemPrintProcessInkCombo
        {
            get { return _aRCustomerProductReqItemPrintProcessInkCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintProcessInkCombo)
                {
                    _aRCustomerProductReqItemPrintProcessInkCombo = value;
                    NotifyChanged("ARCustomerProductReqItemPrintProcessInkCombo");
                }
            }
        }
        public String ARCustomerProductReqItemPrintRemark
        {
            get { return _aRCustomerProductReqItemPrintRemark; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintRemark)
                {
                    _aRCustomerProductReqItemPrintRemark = value;
                    NotifyChanged("ARCustomerProductReqItemPrintRemark");
                }
            }
        }
        public String ARCustomerProductReqItemPrintTechCombo
        {
            get { return _aRCustomerProductReqItemPrintTechCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemPrintTechCombo)
                {
                    _aRCustomerProductReqItemPrintTechCombo = value;
                    NotifyChanged("ARCustomerProductReqItemPrintTechCombo");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemSampleCartonDate
        {
            get { return _aRCustomerProductReqItemSampleCartonDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemSampleCartonDate)
                {
                    _aRCustomerProductReqItemSampleCartonDate = value;
                    NotifyChanged("ARCustomerProductReqItemSampleCartonDate");
                }
            }
        }
        public String ARCustomerProductReqItemSampleCartonName
        {
            get { return _aRCustomerProductReqItemSampleCartonName; }
            set
            {
                if (value != this._aRCustomerProductReqItemSampleCartonName)
                {
                    _aRCustomerProductReqItemSampleCartonName = value;
                    NotifyChanged("ARCustomerProductReqItemSampleCartonName");
                }
            }
        }
        public Nullable<DateTime> ARCustomerProductReqItemStdDate
        {
            get { return _aRCustomerProductReqItemStdDate; }
            set
            {
                if (value != this._aRCustomerProductReqItemStdDate)
                {
                    _aRCustomerProductReqItemStdDate = value;
                    NotifyChanged("ARCustomerProductReqItemStdDate");
                }
            }
        }
        public String ARCustomerProductReqItemStdName
        {
            get { return _aRCustomerProductReqItemStdName; }
            set
            {
                if (value != this._aRCustomerProductReqItemStdName)
                {
                    _aRCustomerProductReqItemStdName = value;
                    NotifyChanged("ARCustomerProductReqItemStdName");
                }
            }
        }
        public String ARCustomerProductReqItemStyleBottomCombo
        {
            get { return _aRCustomerProductReqItemStyleBottomCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemStyleBottomCombo)
                {
                    _aRCustomerProductReqItemStyleBottomCombo = value;
                    NotifyChanged("ARCustomerProductReqItemStyleBottomCombo");
                }
            }
        }
        public String ARCustomerProductReqItemStyleTopCombo
        {
            get { return _aRCustomerProductReqItemStyleTopCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemStyleTopCombo)
                {
                    _aRCustomerProductReqItemStyleTopCombo = value;
                    NotifyChanged("ARCustomerProductReqItemStyleTopCombo");
                }
            }
        }
        public String ARCustomerProductReqItemTypeCombo
        {
            get { return _aRCustomerProductReqItemTypeCombo; }
            set
            {
                if (value != this._aRCustomerProductReqItemTypeCombo)
                {
                    _aRCustomerProductReqItemTypeCombo = value;
                    NotifyChanged("ARCustomerProductReqItemTypeCombo");
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

        #endregion
    }
    #endregion
}