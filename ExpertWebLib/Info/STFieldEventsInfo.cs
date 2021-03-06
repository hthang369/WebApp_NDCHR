using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STFieldEvents
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STFieldEventsInfo
    //Created Date: Monday, 06 Aug 2018
    //-----------------------------------------------------------

    public class STFieldEventsInfo : BusinessObject
    {
        public STFieldEventsInfo()
        {
        }
        #region Variables
        protected int _sTFieldEventID;
        protected int _sTFieldID;
        protected String _sTFieldEventName = String.Empty;
        protected String _sTFieldEventDelegateFunctionName = String.Empty;
        protected String _sTFieldEventDelegateFunctionFullName = String.Empty;
        protected String _sTFieldEventDelegateFunctionClass = String.Empty;
        
        #endregion

        #region Public properties
        public int STFieldEventID
        {
            get { return _sTFieldEventID; }
            set
            {
                if (value != this._sTFieldEventID)
                {
                    _sTFieldEventID = value;
                    NotifyChanged("STFieldEventID");
                }
            }
        }
        public int STFieldID
        {
            get { return _sTFieldID; }
            set
            {
                if (value != this._sTFieldID)
                {
                    _sTFieldID = value;
                    NotifyChanged("STFieldID");
                }
            }
        }
        public String STFieldEventName
        {
            get { return _sTFieldEventName; }
            set
            {
                if (value != this._sTFieldEventName)
                {
                    _sTFieldEventName = value;
                    NotifyChanged("STFieldEventName");
                }
            }
        }
        public String STFieldEventDelegateFunctionName
        {
            get { return _sTFieldEventDelegateFunctionName; }
            set
            {
                if (value != this._sTFieldEventDelegateFunctionName)
                {
                    _sTFieldEventDelegateFunctionName = value;
                    NotifyChanged("STFieldEventDelegateFunctionName");
                }
            }
        }
        public String STFieldEventDelegateFunctionFullName
        {
            get { return _sTFieldEventDelegateFunctionFullName; }
            set
            {
                if (value != this._sTFieldEventDelegateFunctionFullName)
                {
                    _sTFieldEventDelegateFunctionFullName = value;
                    NotifyChanged("STFieldEventDelegateFunctionFullName");
                }
            }
        }
        public String STFieldEventDelegateFunctionClass
        {
            get { return _sTFieldEventDelegateFunctionClass; }
            set
            {
                if (value != this._sTFieldEventDelegateFunctionClass)
                {
                    _sTFieldEventDelegateFunctionClass = value;
                    NotifyChanged("STFieldEventDelegateFunctionClass");
                }
            }
        }
        
        #endregion
    }
    #endregion
}