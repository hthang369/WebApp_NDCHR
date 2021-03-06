using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PRSlrAdjItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PRSlrAdjItemsInfo
    //Created Date:21 Tháng Chín 2013
    //-----------------------------------------------------------

    public class PRSlrAdjItemsInfo : BusinessObject
    {
        public PRSlrAdjItemsInfo()
        {
        }
        #region Variables
        protected int _pRSlrAdjItemID;
        protected bool _aASelected = true;
        protected String _aAStatus = DefaultAAStatus;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected int _fK_PRSlrAdjID;
        protected String _pRSlrAdjItemDesc = String.Empty;
        protected int _fK_HREmployeeID;
        protected double _pRSlrAdjItemOldSalaryAmt;
        protected double _pRSlrAdjItemNewSalaryAmt;
        protected String _pRSlrAdjItemTypeCombo = String.Empty;
        protected String _pRSlrAdjItemSalaryTypeCombo = String.Empty;
        protected String _pRSlrAdjItemStatusCombo = DefaultStatus;
        protected int _fK_HREmployeeContractID;
        #endregion

        #region Public properties
        public int PRSlrAdjItemID
        {
            get { return _pRSlrAdjItemID; }
            set
            {
                if (value != this._pRSlrAdjItemID)
                {
                    _pRSlrAdjItemID = value;
                    NotifyChanged("PRSlrAdjItemID");
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
        public int FK_PRSlrAdjID
        {
            get { return _fK_PRSlrAdjID; }
            set
            {
                if (value != this._fK_PRSlrAdjID)
                {
                    _fK_PRSlrAdjID = value;
                    NotifyChanged("FK_PRSlrAdjID");
                }
            }
        }
        public String PRSlrAdjItemDesc
        {
            get { return _pRSlrAdjItemDesc; }
            set
            {
                if (value != this._pRSlrAdjItemDesc)
                {
                    _pRSlrAdjItemDesc = value;
                    NotifyChanged("PRSlrAdjItemDesc");
                }
            }
        }
        public int FK_HREmployeeID
        {
            get { return _fK_HREmployeeID; }
            set
            {
                if (value != this._fK_HREmployeeID)
                {
                    _fK_HREmployeeID = value;
                    NotifyChanged("FK_HREmployeeID");
                }
            }
        }
        public double PRSlrAdjItemOldSalaryAmt
        {
            get { return _pRSlrAdjItemOldSalaryAmt; }
            set
            {
                if (value != this._pRSlrAdjItemOldSalaryAmt)
                {
                    _pRSlrAdjItemOldSalaryAmt = value;
                    NotifyChanged("PRSlrAdjItemOldSalaryAmt");
                }
            }
        }
        public double PRSlrAdjItemNewSalaryAmt
        {
            get { return _pRSlrAdjItemNewSalaryAmt; }
            set
            {
                if (value != this._pRSlrAdjItemNewSalaryAmt)
                {
                    _pRSlrAdjItemNewSalaryAmt = value;
                    NotifyChanged("PRSlrAdjItemNewSalaryAmt");
                }
            }
        }
        public String PRSlrAdjItemTypeCombo
        {
            get { return _pRSlrAdjItemTypeCombo; }
            set
            {
                if (value != this._pRSlrAdjItemTypeCombo)
                {
                    _pRSlrAdjItemTypeCombo = value;
                    NotifyChanged("PRSlrAdjItemTypeCombo");
                }
            }
        }
        public String PRSlrAdjItemSalaryTypeCombo
        {
            get { return _pRSlrAdjItemSalaryTypeCombo; }
            set
            {
                if (value != this._pRSlrAdjItemSalaryTypeCombo)
                {
                    _pRSlrAdjItemSalaryTypeCombo = value;
                    NotifyChanged("PRSlrAdjItemSalaryTypeCombo");
                }
            }
        }
        public String PRSlrAdjItemStatusCombo
        {
            get { return _pRSlrAdjItemStatusCombo; }
            set
            {
                if (value != this._pRSlrAdjItemStatusCombo)
                {
                    _pRSlrAdjItemStatusCombo = value;
                    NotifyChanged("PRSlrAdjItemStatusCombo");
                }
            }
        }
        public int FK_HREmployeeContractID
        {
            get { return _fK_HREmployeeContractID; }
            set
            {
                if (value != this._fK_HREmployeeContractID)
                {
                    _fK_HREmployeeContractID = value;
                    NotifyChanged("FK_HREmployeeContractID");
                }
            }
        }
        #endregion
    }
    #endregion
}