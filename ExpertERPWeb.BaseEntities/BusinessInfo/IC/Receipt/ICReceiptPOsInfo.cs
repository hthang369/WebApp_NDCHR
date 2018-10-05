﻿using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICReceiptPOs
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:ICReceiptPOsInfo
    //Created Date:13 Tháng Năm 2011
    //-----------------------------------------------------------

    public class ICReceiptPOsInfo : BusinessObject
    {
        public ICReceiptPOsInfo()
        {
        }
        #region Variables
        protected int _iCReceiptPOID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_APPOID;
        protected int _fK_ICReceiptID;
        #endregion

        #region Public properties
        public int ICReceiptPOID
        {
            get { return _iCReceiptPOID; }
            set
            {
                if (value != this._iCReceiptPOID)
                {
                    _iCReceiptPOID = value;
                    NotifyChanged("ICReceiptPOID");
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
        public int FK_APPOID
        {
            get { return _fK_APPOID; }
            set
            {
                if (value != this._fK_APPOID)
                {
                    _fK_APPOID = value;
                    NotifyChanged("FK_APPOID");
                }
            }
        }
        public int FK_ICReceiptID
        {
            get { return _fK_ICReceiptID; }
            set
            {
                if (value != this._fK_ICReceiptID)
                {
                    _fK_ICReceiptID = value;
                    NotifyChanged("FK_ICReceiptID");
                }
            }
        }
        #endregion
    }
    #endregion
}