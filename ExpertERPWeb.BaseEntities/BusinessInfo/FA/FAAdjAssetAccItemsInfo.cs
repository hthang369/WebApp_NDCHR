using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region FAAdjAssetAccItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:FAAdjAssetAccItemsInfo
    //Created Date:Thursday, September 3, 2015
    //-----------------------------------------------------------

    public class FAAdjAssetAccItemsInfo : BusinessObject
    {
        public FAAdjAssetAccItemsInfo()
        {
        }
        #region Variables
        protected int _fAAdjAssetAccItemID;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected String _aAStatus = DefaultAAStatus;
        protected bool _aASelected = true;
        protected int _fK_FAAdjAssetAccID;
        protected int _fK_FAAssetID;
        protected int _fK_GLAssetAccountLastID;
        protected int _fK_GLDeprAccountLastID;
        protected int _fK_GLAssetAccountNewID;
        protected int _fK_GLDeprAccountNewID;
        protected String _fAAdjAssetAccItemDesc = String.Empty;
        protected double _fAAdjAssetAccItemOrgAmt;
        protected double _fAAdjAssetAccItemFOrgAmt;
        protected double _fAAdjAssetAccItemAccumDeprAmt;
        protected double _fAAdjAssetAccItemFAccumDeprAmt;
        protected int _fK_GECurrencyID;
        protected double _fAAdjAssetAccItemExcRate;
        #endregion

        #region Public properties
        public int FAAdjAssetAccItemID
        {
            get { return _fAAdjAssetAccItemID; }
            set
            {
                if (value != this._fAAdjAssetAccItemID)
                {
                    _fAAdjAssetAccItemID = value;
                    NotifyChanged("FAAdjAssetAccItemID");
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
        public int FK_FAAdjAssetAccID
        {
            get { return _fK_FAAdjAssetAccID; }
            set
            {
                if (value != this._fK_FAAdjAssetAccID)
                {
                    _fK_FAAdjAssetAccID = value;
                    NotifyChanged("FK_FAAdjAssetAccID");
                }
            }
        }
        public int FK_FAAssetID
        {
            get { return _fK_FAAssetID; }
            set
            {
                if (value != this._fK_FAAssetID)
                {
                    _fK_FAAssetID = value;
                    NotifyChanged("FK_FAAssetID");
                }
            }
        }
        public int FK_GLAssetAccountLastID
        {
            get { return _fK_GLAssetAccountLastID; }
            set
            {
                if (value != this._fK_GLAssetAccountLastID)
                {
                    _fK_GLAssetAccountLastID = value;
                    NotifyChanged("FK_GLAssetAccountLastID");
                }
            }
        }
        public int FK_GLDeprAccountLastID
        {
            get { return _fK_GLDeprAccountLastID; }
            set
            {
                if (value != this._fK_GLDeprAccountLastID)
                {
                    _fK_GLDeprAccountLastID = value;
                    NotifyChanged("FK_GLDeprAccountLastID");
                }
            }
        }
        public int FK_GLAssetAccountNewID
        {
            get { return _fK_GLAssetAccountNewID; }
            set
            {
                if (value != this._fK_GLAssetAccountNewID)
                {
                    _fK_GLAssetAccountNewID = value;
                    NotifyChanged("FK_GLAssetAccountNewID");
                }
            }
        }
        public int FK_GLDeprAccountNewID
        {
            get { return _fK_GLDeprAccountNewID; }
            set
            {
                if (value != this._fK_GLDeprAccountNewID)
                {
                    _fK_GLDeprAccountNewID = value;
                    NotifyChanged("FK_GLDeprAccountNewID");
                }
            }
        }
        public String FAAdjAssetAccItemDesc
        {
            get { return _fAAdjAssetAccItemDesc; }
            set
            {
                if (value != this._fAAdjAssetAccItemDesc)
                {
                    _fAAdjAssetAccItemDesc = value;
                    NotifyChanged("FAAdjAssetAccItemDesc");
                }
            }
        }
        public double FAAdjAssetAccItemOrgAmt
        {
            get { return _fAAdjAssetAccItemOrgAmt; }
            set
            {
                if (value != this._fAAdjAssetAccItemOrgAmt)
                {
                    _fAAdjAssetAccItemOrgAmt = value;
                    NotifyChanged("FAAdjAssetAccItemOrgAmt");
                }
            }
        }
        public double FAAdjAssetAccItemFOrgAmt
        {
            get { return _fAAdjAssetAccItemFOrgAmt; }
            set
            {
                if (value != this._fAAdjAssetAccItemFOrgAmt)
                {
                    _fAAdjAssetAccItemFOrgAmt = value;
                    NotifyChanged("FAAdjAssetAccItemFOrgAmt");
                }
            }
        }
        public double FAAdjAssetAccItemAccumDeprAmt
        {
            get { return _fAAdjAssetAccItemAccumDeprAmt; }
            set
            {
                if (value != this._fAAdjAssetAccItemAccumDeprAmt)
                {
                    _fAAdjAssetAccItemAccumDeprAmt = value;
                    NotifyChanged("FAAdjAssetAccItemAccumDeprAmt");
                }
            }
        }
        public double FAAdjAssetAccItemFAccumDeprAmt
        {
            get { return _fAAdjAssetAccItemFAccumDeprAmt; }
            set
            {
                if (value != this._fAAdjAssetAccItemFAccumDeprAmt)
                {
                    _fAAdjAssetAccItemFAccumDeprAmt = value;
                    NotifyChanged("FAAdjAssetAccItemFAccumDeprAmt");
                }
            }
        }
        public int FK_GECurrencyID
        {
            get { return _fK_GECurrencyID; }
            set
            {
                if (value != this._fK_GECurrencyID)
                {
                    _fK_GECurrencyID = value;
                    NotifyChanged("FK_GECurrencyID");
                }
            }
        }
        public double FAAdjAssetAccItemExcRate
        {
            get { return _fAAdjAssetAccItemExcRate; }
            set
            {
                if (value != this._fAAdjAssetAccItemExcRate)
                {
                    _fAAdjAssetAccItemExcRate = value;
                    NotifyChanged("FAAdjAssetAccItemExcRate");
                }
            }
        }
        #endregion
    }
    #endregion
}