using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STToolbarFunctions
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STToolbarFunctionsInfo
    //Created Date: Monday, 06 Aug 2018
    //-----------------------------------------------------------

    public class STToolbarFunctionsInfo : BusinessObject
    {
        public STToolbarFunctionsInfo()
        {
        }
        #region Variables
        protected int _sTToolbarFunctionID;
        protected String _sTToolbarFunctionIDString = String.Empty;
        protected int _sTToolbarID;
        protected String _sTToolbarFunctionName = String.Empty;
        protected String _sTToolbarFunctionFullName = String.Empty;
        protected String _sTToolbarFunctionClass = String.Empty;
        protected int _sTToolbarFunctionSortOrder;
        
        #endregion

        #region Public properties
        public int STToolbarFunctionID
        {
            get { return _sTToolbarFunctionID; }
            set
            {
                if (value != this._sTToolbarFunctionID)
                {
                    _sTToolbarFunctionID = value;
                    NotifyChanged("STToolbarFunctionID");
                }
            }
        }
        public String STToolbarFunctionIDString
        {
            get { return _sTToolbarFunctionIDString; }
            set
            {
                if (value != this._sTToolbarFunctionIDString)
                {
                    _sTToolbarFunctionIDString = value;
                    NotifyChanged("STToolbarFunctionIDString");
                }
            }
        }
        public int STToolbarID
        {
            get { return _sTToolbarID; }
            set
            {
                if (value != this._sTToolbarID)
                {
                    _sTToolbarID = value;
                    NotifyChanged("STToolbarID");
                }
            }
        }
        public String STToolbarFunctionName
        {
            get { return _sTToolbarFunctionName; }
            set
            {
                if (value != this._sTToolbarFunctionName)
                {
                    _sTToolbarFunctionName = value;
                    NotifyChanged("STToolbarFunctionName");
                }
            }
        }
        public String STToolbarFunctionFullName
        {
            get { return _sTToolbarFunctionFullName; }
            set
            {
                if (value != this._sTToolbarFunctionFullName)
                {
                    _sTToolbarFunctionFullName = value;
                    NotifyChanged("STToolbarFunctionFullName");
                }
            }
        }
        public String STToolbarFunctionClass
        {
            get { return _sTToolbarFunctionClass; }
            set
            {
                if (value != this._sTToolbarFunctionClass)
                {
                    _sTToolbarFunctionClass = value;
                    NotifyChanged("STToolbarFunctionClass");
                }
            }
        }
        public int STToolbarFunctionSortOrder
        {
            get { return _sTToolbarFunctionSortOrder; }
            set
            {
                if (value != this._sTToolbarFunctionSortOrder)
                {
                    _sTToolbarFunctionSortOrder = value;
                    NotifyChanged("STToolbarFunctionSortOrder");
                }
            }
        }
        
        #endregion
    }
    #endregion
}