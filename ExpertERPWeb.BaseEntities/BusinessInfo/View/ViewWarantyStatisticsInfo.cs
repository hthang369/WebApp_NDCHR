using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ViewWarantyStatistics
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ViewWarantyStatisticsInfo
    //Created Date:23 Tháng Năm 2012
    //-----------------------------------------------------------

    public class ViewWarantyStatisticsInfo : BusinessObject
    {
        public ViewWarantyStatisticsInfo()
        {
        }
        #region Variables
        protected int _viewWarantyStatisticID;
        protected int _fK_ICProductGroupID;
        protected int _fK_APSupplierID;
        protected int _fK_ARCustomerGroupID;
        protected double _productQty;
        protected Nullable<DateTime> _fromDate;
        protected Nullable<DateTime> _toDate;
        protected String _productGroupNo = String.Empty;
        protected String _supplierNo = String.Empty;
        protected String _customerGroupNo = String.Empty;
        protected int _fK_ICProductID;
        protected int _fK_ARCustomerID;
        protected String _productNo = String.Empty;
        protected String _customerNo = String.Empty;
        #endregion

        #region Public properties
        public int ViewWarantyStatisticID
        {
            get { return _viewWarantyStatisticID; }
            set
            {
                if (value != this._viewWarantyStatisticID)
                {
                    _viewWarantyStatisticID = value;
                    NotifyChanged("ViewWarantyStatisticID");
                }
            }
        }
        public int FK_ICProductGroupID
        {
            get { return _fK_ICProductGroupID; }
            set
            {
                if (value != this._fK_ICProductGroupID)
                {
                    _fK_ICProductGroupID = value;
                    NotifyChanged("FK_ICProductGroupID");
                }
            }
        }
        public int FK_APSupplierID
        {
            get { return _fK_APSupplierID; }
            set
            {
                if (value != this._fK_APSupplierID)
                {
                    _fK_APSupplierID = value;
                    NotifyChanged("FK_APSupplierID");
                }
            }
        }
        public int FK_ARCustomerGroupID
        {
            get { return _fK_ARCustomerGroupID; }
            set
            {
                if (value != this._fK_ARCustomerGroupID)
                {
                    _fK_ARCustomerGroupID = value;
                    NotifyChanged("FK_ARCustomerGroupID");
                }
            }
        }
        public double ProductQty
        {
            get { return _productQty; }
            set
            {
                if (value != this._productQty)
                {
                    _productQty = value;
                    NotifyChanged("ProductQty");
                }
            }
        }
        public Nullable<DateTime> FromDate
        {
            get { return _fromDate; }
            set
            {
                if (value != this._fromDate)
                {
                    _fromDate = value;
                    NotifyChanged("FromDate");
                }
            }
        }
        public Nullable<DateTime> ToDate
        {
            get { return _toDate; }
            set
            {
                if (value != this._toDate)
                {
                    _toDate = value;
                    NotifyChanged("ToDate");
                }
            }
        }
        public String ProductGroupNo
        {
            get { return _productGroupNo; }
            set
            {
                if (value != this._productGroupNo)
                {
                    _productGroupNo = value;
                    NotifyChanged("ProductGroupNo");
                }
            }
        }
        public String SupplierNo
        {
            get { return _supplierNo; }
            set
            {
                if (value != this._supplierNo)
                {
                    _supplierNo = value;
                    NotifyChanged("SupplierNo");
                }
            }
        }
        public String CustomerGroupNo
        {
            get { return _customerGroupNo; }
            set
            {
                if (value != this._customerGroupNo)
                {
                    _customerGroupNo = value;
                    NotifyChanged("CustomerGroupNo");
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
        public int FK_ARCustomerID
        {
            get { return _fK_ARCustomerID; }
            set
            {
                if (value != this._fK_ARCustomerID)
                {
                    _fK_ARCustomerID = value;
                    NotifyChanged("FK_ARCustomerID");
                }
            }
        }
        public String ProductNo
        {
            get { return _productNo; }
            set
            {
                if (value != this._productNo)
                {
                    _productNo = value;
                    NotifyChanged("ProductNo");
                }
            }
        }
        public String CustomerNo
        {
            get { return _customerNo; }
            set
            {
                if (value != this._customerNo)
                {
                    _customerNo = value;
                    NotifyChanged("CustomerNo");
                }
            }
        }
        #endregion
    }
    #endregion
}