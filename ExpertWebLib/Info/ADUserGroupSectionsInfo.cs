using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region ADUserGroupSections
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: ADUserGroupSectionsInfo
    //Created Date: Friday, 03 Aug 2018
    //-----------------------------------------------------------

    public class ADUserGroupSectionsInfo : BusinessObject
    {
        public ADUserGroupSectionsInfo()
        {
        }
        #region Variables
        protected int _aDUserGroupSectionID;
        protected int _aDUserGroupID;
        protected String _aDUserGroupSectionName = String.Empty;
        protected String _aDUserGroupSectionDesc = String.Empty;
        protected int _aDUserGroupSectionSortOrder;
        protected int _fK_ADParentUserGroupSectionID;
        
        #endregion

        #region Public properties
        public int ADUserGroupSectionID
        {
            get { return _aDUserGroupSectionID; }
            set
            {
                if (value != this._aDUserGroupSectionID)
                {
                    _aDUserGroupSectionID = value;
                    NotifyChanged("ADUserGroupSectionID");
                }
            }
        }
        public int ADUserGroupID
        {
            get { return _aDUserGroupID; }
            set
            {
                if (value != this._aDUserGroupID)
                {
                    _aDUserGroupID = value;
                    NotifyChanged("ADUserGroupID");
                }
            }
        }
        public String ADUserGroupSectionName
        {
            get { return _aDUserGroupSectionName; }
            set
            {
                if (value != this._aDUserGroupSectionName)
                {
                    _aDUserGroupSectionName = value;
                    NotifyChanged("ADUserGroupSectionName");
                }
            }
        }
        public String ADUserGroupSectionDesc
        {
            get { return _aDUserGroupSectionDesc; }
            set
            {
                if (value != this._aDUserGroupSectionDesc)
                {
                    _aDUserGroupSectionDesc = value;
                    NotifyChanged("ADUserGroupSectionDesc");
                }
            }
        }
        public int ADUserGroupSectionSortOrder
        {
            get { return _aDUserGroupSectionSortOrder; }
            set
            {
                if (value != this._aDUserGroupSectionSortOrder)
                {
                    _aDUserGroupSectionSortOrder = value;
                    NotifyChanged("ADUserGroupSectionSortOrder");
                }
            }
        }
        public int FK_ADParentUserGroupSectionID
        {
            get { return _fK_ADParentUserGroupSectionID; }
            set
            {
                if (value != this._fK_ADParentUserGroupSectionID)
                {
                    _fK_ADParentUserGroupSectionID = value;
                    NotifyChanged("FK_ADParentUserGroupSectionID");
                }
            }
        }
        
        #endregion
    }
    #endregion
}