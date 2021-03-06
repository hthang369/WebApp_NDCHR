using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STModuleConfigs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STModuleConfigsInfo
    //Created Date: Friday, 03 Aug 2018
    //-----------------------------------------------------------

    public class STModuleConfigsInfo : BusinessObject
    {
        public STModuleConfigsInfo()
        {
        }
        #region Variables
        protected int _sTModuleConfigID;
        protected int _fK_ADUserGroupID;
        protected int _fK_STModuleID;
        protected int _sTModuleConfigW;
        protected int _sTModuleConfigH;
        protected bool _sTModuleConfigDsplMenu = true;
        protected bool _sTModuleConfigDsplNav = true;
        protected bool _sTModuleConfigHomePage = true;
        
        #endregion

        #region Public properties
        public int STModuleConfigID
        {
            get { return _sTModuleConfigID; }
            set
            {
                if (value != this._sTModuleConfigID)
                {
                    _sTModuleConfigID = value;
                    NotifyChanged("STModuleConfigID");
                }
            }
        }
        public int FK_ADUserGroupID
        {
            get { return _fK_ADUserGroupID; }
            set
            {
                if (value != this._fK_ADUserGroupID)
                {
                    _fK_ADUserGroupID = value;
                    NotifyChanged("FK_ADUserGroupID");
                }
            }
        }
        public int FK_STModuleID
        {
            get { return _fK_STModuleID; }
            set
            {
                if (value != this._fK_STModuleID)
                {
                    _fK_STModuleID = value;
                    NotifyChanged("FK_STModuleID");
                }
            }
        }
        public int STModuleConfigW
        {
            get { return _sTModuleConfigW; }
            set
            {
                if (value != this._sTModuleConfigW)
                {
                    _sTModuleConfigW = value;
                    NotifyChanged("STModuleConfigW");
                }
            }
        }
        public int STModuleConfigH
        {
            get { return _sTModuleConfigH; }
            set
            {
                if (value != this._sTModuleConfigH)
                {
                    _sTModuleConfigH = value;
                    NotifyChanged("STModuleConfigH");
                }
            }
        }
        public bool STModuleConfigDsplMenu
        {
            get { return _sTModuleConfigDsplMenu; }
            set
            {
                if (value != this._sTModuleConfigDsplMenu)
                {
                    _sTModuleConfigDsplMenu = value;
                    NotifyChanged("STModuleConfigDsplMenu");
                }
            }
        }
        public bool STModuleConfigDsplNav
        {
            get { return _sTModuleConfigDsplNav; }
            set
            {
                if (value != this._sTModuleConfigDsplNav)
                {
                    _sTModuleConfigDsplNav = value;
                    NotifyChanged("STModuleConfigDsplNav");
                }
            }
        }
        public bool STModuleConfigHomePage
        {
            get { return _sTModuleConfigHomePage; }
            set
            {
                if (value != this._sTModuleConfigHomePage)
                {
                    _sTModuleConfigHomePage = value;
                    NotifyChanged("STModuleConfigHomePage");
                }
            }
        }
        
        #endregion
    }
    #endregion
}