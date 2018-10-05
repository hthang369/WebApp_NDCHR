using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICShipmentItemSOItems
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:ICShipmentItemSOItemsInfo
    //Created Date:Wednesday, August 17, 2011
    //-----------------------------------------------------------

    public class ICShipmentItemSOItemsInfo : BusinessObject
    {
        public ICShipmentItemSOItemsInfo ( )
        {
        }
        #region Variables
        protected int _iCShipmentItemSOItemID;
        protected String _aAStatus=DefaultAAStatus;
        protected int _fK_ARSOItemID;
        protected int _fK_ICShipmentItemID;
        #endregion

        #region Public properties
        public int ICShipmentItemSOItemID
        {
            get { return _iCShipmentItemSOItemID; }
            set
            {
                if ( value!=this._iCShipmentItemSOItemID )
                {
                    _iCShipmentItemSOItemID=value;
                    NotifyChanged( "ICShipmentItemSOItemID" );
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if ( value!=this._aAStatus )
                {
                    _aAStatus=value;
                    NotifyChanged( "AAStatus" );
                }
            }
        }
        public int FK_ARSOItemID
        {
            get { return _fK_ARSOItemID; }
            set
            {
                if ( value!=this._fK_ARSOItemID )
                {
                    _fK_ARSOItemID=value;
                    NotifyChanged( "FK_ARSOItemID" );
                }
            }
        }
        public int FK_ICShipmentItemID
        {
            get { return _fK_ICShipmentItemID; }
            set
            {
                if ( value!=this._fK_ICShipmentItemID )
                {
                    _fK_ICShipmentItemID=value;
                    NotifyChanged( "FK_ICShipmentItemID" );
                }
            }
        }
        #endregion
    }
    #endregion
}