using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICShipmentSOs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICShipmentSOsInfo
    //Created Date:Thursday, October 15, 2009
    //-----------------------------------------------------------

    public class ICShipmentSOsInfo : BusinessObject
    {
        public ICShipmentSOsInfo()
        {
        }
        #region Variables
        protected int _iCShipmentSOID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_ARSOID;
        protected int _fK_ICShipmentID;
        #endregion

        #region Public properties
        public int ICShipmentSOID
        {
            get { return _iCShipmentSOID; }
            set
            {
                if (value != this._iCShipmentSOID)
                {
                    _iCShipmentSOID = value;
                    NotifyChanged("ICShipmentSOID");
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
        public int FK_ICShipmentID
        {
            get { return _fK_ICShipmentID; }
            set
            {
                if (value != this._fK_ICShipmentID)
                {
                    _fK_ICShipmentID = value;
                    NotifyChanged("FK_ICShipmentID");
                }
            }
        }
        #endregion
    }
    #endregion
}