using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICInventoryStockHistorys
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICInventoryStockHistorysInfo
    //Created Date:Monday, December 06, 2010
    //-----------------------------------------------------------

    public class ICInventoryStockHistorysInfo : BusinessObject
    {
        public ICInventoryStockHistorysInfo()
        {
        }
        #region Variables
        protected int _iCInventoryStockHistoryID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ICInventoryStockID;
        protected double _iCInventoryStockQtyOrg;
        protected double _iCInventoryStockQtyNew;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aACreatedUser = String.Empty;
        #endregion

        #region Public properties
        public int ICInventoryStockHistoryID
        {
            get { return _iCInventoryStockHistoryID; }
            set
            {
                if (value != this._iCInventoryStockHistoryID)
                {
                    _iCInventoryStockHistoryID = value;
                    NotifyChanged("ICInventoryStockHistoryID");
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
        public int FK_ICInventoryStockID
        {
            get { return _fK_ICInventoryStockID; }
            set
            {
                if (value != this._fK_ICInventoryStockID)
                {
                    _fK_ICInventoryStockID = value;
                    NotifyChanged("FK_ICInventoryStockID");
                }
            }
        }
        public double ICInventoryStockQtyOrg
        {
            get { return _iCInventoryStockQtyOrg; }
            set
            {
                if (value != this._iCInventoryStockQtyOrg)
                {
                    _iCInventoryStockQtyOrg = value;
                    NotifyChanged("ICInventoryStockQtyOrg");
                }
            }
        }
        public double ICInventoryStockQtyNew
        {
            get { return _iCInventoryStockQtyNew; }
            set
            {
                if (value != this._iCInventoryStockQtyNew)
                {
                    _iCInventoryStockQtyNew = value;
                    NotifyChanged("ICInventoryStockQtyNew");
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
        #endregion
    }
    #endregion
}