using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region BRPOSShifts
    //-----------------------------------------------------------
    //Generated By: Expert Studio
    //Class:BRPOSShiftsInfo
    //Created Date:Thursday, November 18, 2010
    //-----------------------------------------------------------

    public class BRPOSShiftsInfo : BusinessObject
    {
        public BRPOSShiftsInfo()
        {
        }
        #region Variables
        protected int _bRPOSShiftID;
        protected String _bRPOSShiftNo = String.Empty;
        protected String _bRPOSShiftName = String.Empty;
        protected String _bRPOSShiftDesc = String.Empty;
        protected Nullable<DateTime> _bRPOSShiftStartTime;
        protected Nullable<DateTime> _bRPOSShiftEndTime;
        protected String _aAStatus = DefaultAAStatus;
        #endregion

        #region Public properties
        public int BRPOSShiftID
        {
            get { return _bRPOSShiftID; }
            set
            {
                if (value != this._bRPOSShiftID)
                {
                    _bRPOSShiftID = value;
                    NotifyChanged("BRPOSShiftID");
                }
            }
        }
        public String BRPOSShiftNo
        {
            get { return _bRPOSShiftNo; }
            set
            {
                if (value != this._bRPOSShiftNo)
                {
                    _bRPOSShiftNo = value;
                    NotifyChanged("BRPOSShiftNo");
                }
            }
        }
        public String BRPOSShiftName
        {
            get { return _bRPOSShiftName; }
            set
            {
                if (value != this._bRPOSShiftName)
                {
                    _bRPOSShiftName = value;
                    NotifyChanged("BRPOSShiftName");
                }
            }
        }
        public String BRPOSShiftDesc
        {
            get { return _bRPOSShiftDesc; }
            set
            {
                if (value != this._bRPOSShiftDesc)
                {
                    _bRPOSShiftDesc = value;
                    NotifyChanged("BRPOSShiftDesc");
                }
            }
        }
        public Nullable<DateTime> BRPOSShiftStartTime
        {
            get { return _bRPOSShiftStartTime; }
            set
            {
                if (value != this._bRPOSShiftStartTime)
                {
                    _bRPOSShiftStartTime = value;
                    NotifyChanged("BRPOSShiftStartTime");
                }
            }
        }
        public Nullable<DateTime> BRPOSShiftEndTime
        {
            get { return _bRPOSShiftEndTime; }
            set
            {
                if (value != this._bRPOSShiftEndTime)
                {
                    _bRPOSShiftEndTime = value;
                    NotifyChanged("BRPOSShiftEndTime");
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
        #endregion
    }
    #endregion
}