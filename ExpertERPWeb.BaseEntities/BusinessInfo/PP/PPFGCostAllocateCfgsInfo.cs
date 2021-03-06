using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPFGCostAllocateCfgs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:PPFGCostAllocateCfgsInfo
    //Created Date:23 Tha�ng Ta�m 2012
    //-----------------------------------------------------------

    public class PPFGCostAllocateCfgsInfo : BusinessObject
    {
        public PPFGCostAllocateCfgsInfo()
        {
        }
        #region Variables
        protected int _pPFGCostAllocateCfgID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected String _pPFGCostAllocateCfgName = String.Empty;
        protected String _pPFGCostAllocateCfgDesc = String.Empty;
        protected int _fK_GLCostAccountID;
        protected int _fK_GLAllocateAccountID;
        protected String _pPFGCostAllocateTypeCombo = String.Empty;
        protected String _pPFGCostAllocateCfgNo = String.Empty;
        protected int _fK_ICProductGroupID;
        #endregion

        #region Public properties
        public int PPFGCostAllocateCfgID
        {
            get { return _pPFGCostAllocateCfgID; }
            set
            {
                if (value != this._pPFGCostAllocateCfgID)
                {
                    _pPFGCostAllocateCfgID = value;
                    NotifyChanged("PPFGCostAllocateCfgID");
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
        public String PPFGCostAllocateCfgName
        {
            get { return _pPFGCostAllocateCfgName; }
            set
            {
                if (value != this._pPFGCostAllocateCfgName)
                {
                    _pPFGCostAllocateCfgName = value;
                    NotifyChanged("PPFGCostAllocateCfgName");
                }
            }
        }
        public String PPFGCostAllocateCfgDesc
        {
            get { return _pPFGCostAllocateCfgDesc; }
            set
            {
                if (value != this._pPFGCostAllocateCfgDesc)
                {
                    _pPFGCostAllocateCfgDesc = value;
                    NotifyChanged("PPFGCostAllocateCfgDesc");
                }
            }
        }
        public int FK_GLCostAccountID
        {
            get { return _fK_GLCostAccountID; }
            set
            {
                if (value != this._fK_GLCostAccountID)
                {
                    _fK_GLCostAccountID = value;
                    NotifyChanged("FK_GLCostAccountID");
                }
            }
        }
        public int FK_GLAllocateAccountID
        {
            get { return _fK_GLAllocateAccountID; }
            set
            {
                if (value != this._fK_GLAllocateAccountID)
                {
                    _fK_GLAllocateAccountID = value;
                    NotifyChanged("FK_GLAllocateAccountID");
                }
            }
        }
        public String PPFGCostAllocateTypeCombo
        {
            get { return _pPFGCostAllocateTypeCombo; }
            set
            {
                if (value != this._pPFGCostAllocateTypeCombo)
                {
                    _pPFGCostAllocateTypeCombo = value;
                    NotifyChanged("PPFGCostAllocateTypeCombo");
                }
            }
        }
        public String PPFGCostAllocateCfgNo
        {
            get { return _pPFGCostAllocateCfgNo; }
            set
            {
                if (value != this._pPFGCostAllocateCfgNo)
                {
                    _pPFGCostAllocateCfgNo = value;
                    NotifyChanged("PPFGCostAllocateCfgNo");
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
        #endregion
    }
    #endregion
}