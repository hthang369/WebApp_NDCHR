using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STToolbars
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STToolbarsInfo
    //Created Date: Monday, 06 Aug 2018
    //-----------------------------------------------------------

    public class STToolbarsInfo : BusinessObject
    {
        public STToolbarsInfo()
        {
        }
        #region Variables
        protected int _sTToolbarID;
        protected String _sTToolbarIDString = String.Empty;
        protected int _sTModuleID;
        protected int _sTUserGroupID;
        protected String _sTToolbarName = String.Empty;
        protected String _sTToolbarDesc = String.Empty;
        protected String _sTToolbarTag = String.Empty;
        protected String _sTToolbarStyle = String.Empty;
        protected String _sTToolbarCaption = String.Empty;
        protected String _sTToolbarGroup = String.Empty;
        protected int _sTToolbarOrder;
        protected int _sTToolbarParentID;
        
        #endregion

        #region Public properties
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
        public String STToolbarIDString
        {
            get { return _sTToolbarIDString; }
            set
            {
                if (value != this._sTToolbarIDString)
                {
                    _sTToolbarIDString = value;
                    NotifyChanged("STToolbarIDString");
                }
            }
        }
        public int STModuleID
        {
            get { return _sTModuleID; }
            set
            {
                if (value != this._sTModuleID)
                {
                    _sTModuleID = value;
                    NotifyChanged("STModuleID");
                }
            }
        }
        public int STUserGroupID
        {
            get { return _sTUserGroupID; }
            set
            {
                if (value != this._sTUserGroupID)
                {
                    _sTUserGroupID = value;
                    NotifyChanged("STUserGroupID");
                }
            }
        }
        public String STToolbarName
        {
            get { return _sTToolbarName; }
            set
            {
                if (value != this._sTToolbarName)
                {
                    _sTToolbarName = value;
                    NotifyChanged("STToolbarName");
                }
            }
        }
        public String STToolbarDesc
        {
            get { return _sTToolbarDesc; }
            set
            {
                if (value != this._sTToolbarDesc)
                {
                    _sTToolbarDesc = value;
                    NotifyChanged("STToolbarDesc");
                }
            }
        }
        public String STToolbarTag
        {
            get { return _sTToolbarTag; }
            set
            {
                if (value != this._sTToolbarTag)
                {
                    _sTToolbarTag = value;
                    NotifyChanged("STToolbarTag");
                }
            }
        }
        public String STToolbarStyle
        {
            get { return _sTToolbarStyle; }
            set
            {
                if (value != this._sTToolbarStyle)
                {
                    _sTToolbarStyle = value;
                    NotifyChanged("STToolbarStyle");
                }
            }
        }
        public String STToolbarCaption
        {
            get { return _sTToolbarCaption; }
            set
            {
                if (value != this._sTToolbarCaption)
                {
                    _sTToolbarCaption = value;
                    NotifyChanged("STToolbarCaption");
                }
            }
        }
        public String STToolbarGroup
        {
            get { return _sTToolbarGroup; }
            set
            {
                if (value != this._sTToolbarGroup)
                {
                    _sTToolbarGroup = value;
                    NotifyChanged("STToolbarGroup");
                }
            }
        }
        public int STToolbarOrder
        {
            get { return _sTToolbarOrder; }
            set
            {
                if (value != this._sTToolbarOrder)
                {
                    _sTToolbarOrder = value;
                    NotifyChanged("STToolbarOrder");
                }
            }
        }
        public int STToolbarParentID
        {
            get { return _sTToolbarParentID; }
            set
            {
                if (value != this._sTToolbarParentID)
                {
                    _sTToolbarParentID = value;
                    NotifyChanged("STToolbarParentID");
                }
            }
        }
        
        #endregion
    }
    #endregion
}