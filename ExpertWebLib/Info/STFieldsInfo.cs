using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STFields
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STFieldsInfo
    //Created Date: Friday, 03 Aug 2018
    //-----------------------------------------------------------

    public class STFieldsInfo : BusinessObject
    {
        public STFieldsInfo()
        {
        }
        #region Variables
        protected int _sTFieldID;
        protected String _sTFieldName = String.Empty;
        protected String _sTFieldText = String.Empty;
        protected String _sTFieldHint = String.Empty;
        protected String _sTFieldType = String.Empty;
        protected int _sTScreenID;
        protected int _sTUserGroupID;
        protected int _sTFieldLocationX;
        protected int _sTFieldLocationY;
        protected int _sTFieldSizeHeight;
        protected int _sTFieldSizeWidth;
        protected int _sTFieldBackColor;
        protected int _sTFieldForeColor;
        protected bool _sTFieldEnabled = true;
        protected String _sTFieldTag = String.Empty;
        protected String _sTFieldDataSource = String.Empty;
        protected String _sTFieldDataMember = String.Empty;
        protected String _sTFieldBindingPropertyName = String.Empty;
        protected int _sTFieldTabIndex;
        protected String _sTFieldFontName = String.Empty;
        protected double _sTFieldFontSize;
        protected String _sTFieldFontStyle = String.Empty;
        protected String _sTFieldTextEditStyle = String.Empty;
        protected String _sTFieldEditMask = String.Empty;
        protected String _sTFieldMaskType = String.Empty;
        protected String _sTFieldTextAlign = String.Empty;
        protected String _sTFieldDateTimeFormat = String.Empty;
        protected String _sTFieldQueryBuilder = String.Empty;
        protected String _sTFieldDock = String.Empty;
        protected String _sTFieldItemCollection = String.Empty;
        protected String _sTFieldGridControlType = String.Empty;
        protected String _sTFieldStatus = DefaultStatus;
        protected String _sTFieldDataStatus = DefaultStatus;
        protected String _sTFieldCharacterCase = String.Empty;
        protected String _sTFieldDisplayMember = String.Empty;
        protected String _sTFieldValueMember = String.Empty;
        protected String _sTFieldCheckedStyle = String.Empty;
        protected bool _sTFieldReadOnly = false;
        protected String _sTFieldGroup = String.Empty;
        protected String _sTFieldError = String.Empty;
        protected String _sTFieldScrollBars = String.Empty;
        protected String _sTFieldBorderStyle = String.Empty;
        protected String _sTFieldRightToLeft = String.Empty;
        protected String _sTFieldFieldRelation = String.Empty;
        protected String _sTFieldFieldParent = String.Empty;
        protected bool _sTFieldAllowDummy = true;
        protected String _sTFieldDummyText = String.Empty;
        protected String _sTFieldSelectType = String.Empty;
        protected String _sTFieldSelectTypeValue = String.Empty;
        protected bool _sTFieldAllowNew = true;
        protected String _sTFieldClassInvoke = String.Empty;
        protected bool _sTFieldAllowFilter = true;
        protected int _sTFieldParentID;
        protected String _sTFieldTableName = String.Empty;
        protected int _sTFieldZOrder;
        protected int _sTFieldAnchor;
        protected int _sTFieldEventCount;
        
        #endregion

        #region Public properties
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
        public String STFieldName
        {
            get { return _sTFieldName; }
            set
            {
                if (value != this._sTFieldName)
                {
                    _sTFieldName = value;
                    NotifyChanged("STFieldName");
                }
            }
        }
        public String STFieldText
        {
            get { return _sTFieldText; }
            set
            {
                if (value != this._sTFieldText)
                {
                    _sTFieldText = value;
                    NotifyChanged("STFieldText");
                }
            }
        }
        public String STFieldHint
        {
            get { return _sTFieldHint; }
            set
            {
                if (value != this._sTFieldHint)
                {
                    _sTFieldHint = value;
                    NotifyChanged("STFieldHint");
                }
            }
        }
        public String STFieldType
        {
            get { return _sTFieldType; }
            set
            {
                if (value != this._sTFieldType)
                {
                    _sTFieldType = value;
                    NotifyChanged("STFieldType");
                }
            }
        }
        public int STScreenID
        {
            get { return _sTScreenID; }
            set
            {
                if (value != this._sTScreenID)
                {
                    _sTScreenID = value;
                    NotifyChanged("STScreenID");
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
        public int STFieldLocationX
        {
            get { return _sTFieldLocationX; }
            set
            {
                if (value != this._sTFieldLocationX)
                {
                    _sTFieldLocationX = value;
                    NotifyChanged("STFieldLocationX");
                }
            }
        }
        public int STFieldLocationY
        {
            get { return _sTFieldLocationY; }
            set
            {
                if (value != this._sTFieldLocationY)
                {
                    _sTFieldLocationY = value;
                    NotifyChanged("STFieldLocationY");
                }
            }
        }
        public int STFieldSizeHeight
        {
            get { return _sTFieldSizeHeight; }
            set
            {
                if (value != this._sTFieldSizeHeight)
                {
                    _sTFieldSizeHeight = value;
                    NotifyChanged("STFieldSizeHeight");
                }
            }
        }
        public int STFieldSizeWidth
        {
            get { return _sTFieldSizeWidth; }
            set
            {
                if (value != this._sTFieldSizeWidth)
                {
                    _sTFieldSizeWidth = value;
                    NotifyChanged("STFieldSizeWidth");
                }
            }
        }
        public int STFieldBackColor
        {
            get { return _sTFieldBackColor; }
            set
            {
                if (value != this._sTFieldBackColor)
                {
                    _sTFieldBackColor = value;
                    NotifyChanged("STFieldBackColor");
                }
            }
        }
        public int STFieldForeColor
        {
            get { return _sTFieldForeColor; }
            set
            {
                if (value != this._sTFieldForeColor)
                {
                    _sTFieldForeColor = value;
                    NotifyChanged("STFieldForeColor");
                }
            }
        }
        public bool STFieldEnabled
        {
            get { return _sTFieldEnabled; }
            set
            {
                if (value != this._sTFieldEnabled)
                {
                    _sTFieldEnabled = value;
                    NotifyChanged("STFieldEnabled");
                }
            }
        }
        public String STFieldTag
        {
            get { return _sTFieldTag; }
            set
            {
                if (value != this._sTFieldTag)
                {
                    _sTFieldTag = value;
                    NotifyChanged("STFieldTag");
                }
            }
        }
        public String STFieldDataSource
        {
            get { return _sTFieldDataSource; }
            set
            {
                if (value != this._sTFieldDataSource)
                {
                    _sTFieldDataSource = value;
                    NotifyChanged("STFieldDataSource");
                }
            }
        }
        public String STFieldDataMember
        {
            get { return _sTFieldDataMember; }
            set
            {
                if (value != this._sTFieldDataMember)
                {
                    _sTFieldDataMember = value;
                    NotifyChanged("STFieldDataMember");
                }
            }
        }
        public String STFieldBindingPropertyName
        {
            get { return _sTFieldBindingPropertyName; }
            set
            {
                if (value != this._sTFieldBindingPropertyName)
                {
                    _sTFieldBindingPropertyName = value;
                    NotifyChanged("STFieldBindingPropertyName");
                }
            }
        }
        public int STFieldTabIndex
        {
            get { return _sTFieldTabIndex; }
            set
            {
                if (value != this._sTFieldTabIndex)
                {
                    _sTFieldTabIndex = value;
                    NotifyChanged("STFieldTabIndex");
                }
            }
        }
        public String STFieldFontName
        {
            get { return _sTFieldFontName; }
            set
            {
                if (value != this._sTFieldFontName)
                {
                    _sTFieldFontName = value;
                    NotifyChanged("STFieldFontName");
                }
            }
        }
        public double STFieldFontSize
        {
            get { return _sTFieldFontSize; }
            set
            {
                if (value != this._sTFieldFontSize)
                {
                    _sTFieldFontSize = value;
                    NotifyChanged("STFieldFontSize");
                }
            }
        }
        public String STFieldFontStyle
        {
            get { return _sTFieldFontStyle; }
            set
            {
                if (value != this._sTFieldFontStyle)
                {
                    _sTFieldFontStyle = value;
                    NotifyChanged("STFieldFontStyle");
                }
            }
        }
        public String STFieldTextEditStyle
        {
            get { return _sTFieldTextEditStyle; }
            set
            {
                if (value != this._sTFieldTextEditStyle)
                {
                    _sTFieldTextEditStyle = value;
                    NotifyChanged("STFieldTextEditStyle");
                }
            }
        }
        public String STFieldEditMask
        {
            get { return _sTFieldEditMask; }
            set
            {
                if (value != this._sTFieldEditMask)
                {
                    _sTFieldEditMask = value;
                    NotifyChanged("STFieldEditMask");
                }
            }
        }
        public String STFieldMaskType
        {
            get { return _sTFieldMaskType; }
            set
            {
                if (value != this._sTFieldMaskType)
                {
                    _sTFieldMaskType = value;
                    NotifyChanged("STFieldMaskType");
                }
            }
        }
        public String STFieldTextAlign
        {
            get { return _sTFieldTextAlign; }
            set
            {
                if (value != this._sTFieldTextAlign)
                {
                    _sTFieldTextAlign = value;
                    NotifyChanged("STFieldTextAlign");
                }
            }
        }
        public String STFieldDateTimeFormat
        {
            get { return _sTFieldDateTimeFormat; }
            set
            {
                if (value != this._sTFieldDateTimeFormat)
                {
                    _sTFieldDateTimeFormat = value;
                    NotifyChanged("STFieldDateTimeFormat");
                }
            }
        }
        public String STFieldQueryBuilder
        {
            get { return _sTFieldQueryBuilder; }
            set
            {
                if (value != this._sTFieldQueryBuilder)
                {
                    _sTFieldQueryBuilder = value;
                    NotifyChanged("STFieldQueryBuilder");
                }
            }
        }
        public String STFieldDock
        {
            get { return _sTFieldDock; }
            set
            {
                if (value != this._sTFieldDock)
                {
                    _sTFieldDock = value;
                    NotifyChanged("STFieldDock");
                }
            }
        }
        public String STFieldItemCollection
        {
            get { return _sTFieldItemCollection; }
            set
            {
                if (value != this._sTFieldItemCollection)
                {
                    _sTFieldItemCollection = value;
                    NotifyChanged("STFieldItemCollection");
                }
            }
        }
        public String STFieldGridControlType
        {
            get { return _sTFieldGridControlType; }
            set
            {
                if (value != this._sTFieldGridControlType)
                {
                    _sTFieldGridControlType = value;
                    NotifyChanged("STFieldGridControlType");
                }
            }
        }
        public String STFieldStatus
        {
            get { return _sTFieldStatus; }
            set
            {
                if (value != this._sTFieldStatus)
                {
                    _sTFieldStatus = value;
                    NotifyChanged("STFieldStatus");
                }
            }
        }
        public String STFieldDataStatus
        {
            get { return _sTFieldDataStatus; }
            set
            {
                if (value != this._sTFieldDataStatus)
                {
                    _sTFieldDataStatus = value;
                    NotifyChanged("STFieldDataStatus");
                }
            }
        }
        public String STFieldCharacterCase
        {
            get { return _sTFieldCharacterCase; }
            set
            {
                if (value != this._sTFieldCharacterCase)
                {
                    _sTFieldCharacterCase = value;
                    NotifyChanged("STFieldCharacterCase");
                }
            }
        }
        public String STFieldDisplayMember
        {
            get { return _sTFieldDisplayMember; }
            set
            {
                if (value != this._sTFieldDisplayMember)
                {
                    _sTFieldDisplayMember = value;
                    NotifyChanged("STFieldDisplayMember");
                }
            }
        }
        public String STFieldValueMember
        {
            get { return _sTFieldValueMember; }
            set
            {
                if (value != this._sTFieldValueMember)
                {
                    _sTFieldValueMember = value;
                    NotifyChanged("STFieldValueMember");
                }
            }
        }
        public String STFieldCheckedStyle
        {
            get { return _sTFieldCheckedStyle; }
            set
            {
                if (value != this._sTFieldCheckedStyle)
                {
                    _sTFieldCheckedStyle = value;
                    NotifyChanged("STFieldCheckedStyle");
                }
            }
        }
        public bool STFieldReadOnly
        {
            get { return _sTFieldReadOnly; }
            set
            {
                if (value != this._sTFieldReadOnly)
                {
                    _sTFieldReadOnly = value;
                    NotifyChanged("STFieldReadOnly");
                }
            }
        }
        public String STFieldGroup
        {
            get { return _sTFieldGroup; }
            set
            {
                if (value != this._sTFieldGroup)
                {
                    _sTFieldGroup = value;
                    NotifyChanged("STFieldGroup");
                }
            }
        }
        public String STFieldError
        {
            get { return _sTFieldError; }
            set
            {
                if (value != this._sTFieldError)
                {
                    _sTFieldError = value;
                    NotifyChanged("STFieldError");
                }
            }
        }
        public String STFieldScrollBars
        {
            get { return _sTFieldScrollBars; }
            set
            {
                if (value != this._sTFieldScrollBars)
                {
                    _sTFieldScrollBars = value;
                    NotifyChanged("STFieldScrollBars");
                }
            }
        }
        public String STFieldBorderStyle
        {
            get { return _sTFieldBorderStyle; }
            set
            {
                if (value != this._sTFieldBorderStyle)
                {
                    _sTFieldBorderStyle = value;
                    NotifyChanged("STFieldBorderStyle");
                }
            }
        }
        public String STFieldRightToLeft
        {
            get { return _sTFieldRightToLeft; }
            set
            {
                if (value != this._sTFieldRightToLeft)
                {
                    _sTFieldRightToLeft = value;
                    NotifyChanged("STFieldRightToLeft");
                }
            }
        }
        public String STFieldFieldRelation
        {
            get { return _sTFieldFieldRelation; }
            set
            {
                if (value != this._sTFieldFieldRelation)
                {
                    _sTFieldFieldRelation = value;
                    NotifyChanged("STFieldFieldRelation");
                }
            }
        }
        public String STFieldFieldParent
        {
            get { return _sTFieldFieldParent; }
            set
            {
                if (value != this._sTFieldFieldParent)
                {
                    _sTFieldFieldParent = value;
                    NotifyChanged("STFieldFieldParent");
                }
            }
        }
        public bool STFieldAllowDummy
        {
            get { return _sTFieldAllowDummy; }
            set
            {
                if (value != this._sTFieldAllowDummy)
                {
                    _sTFieldAllowDummy = value;
                    NotifyChanged("STFieldAllowDummy");
                }
            }
        }
        public String STFieldDummyText
        {
            get { return _sTFieldDummyText; }
            set
            {
                if (value != this._sTFieldDummyText)
                {
                    _sTFieldDummyText = value;
                    NotifyChanged("STFieldDummyText");
                }
            }
        }
        public String STFieldSelectType
        {
            get { return _sTFieldSelectType; }
            set
            {
                if (value != this._sTFieldSelectType)
                {
                    _sTFieldSelectType = value;
                    NotifyChanged("STFieldSelectType");
                }
            }
        }
        public String STFieldSelectTypeValue
        {
            get { return _sTFieldSelectTypeValue; }
            set
            {
                if (value != this._sTFieldSelectTypeValue)
                {
                    _sTFieldSelectTypeValue = value;
                    NotifyChanged("STFieldSelectTypeValue");
                }
            }
        }
        public bool STFieldAllowNew
        {
            get { return _sTFieldAllowNew; }
            set
            {
                if (value != this._sTFieldAllowNew)
                {
                    _sTFieldAllowNew = value;
                    NotifyChanged("STFieldAllowNew");
                }
            }
        }
        public String STFieldClassInvoke
        {
            get { return _sTFieldClassInvoke; }
            set
            {
                if (value != this._sTFieldClassInvoke)
                {
                    _sTFieldClassInvoke = value;
                    NotifyChanged("STFieldClassInvoke");
                }
            }
        }
        public bool STFieldAllowFilter
        {
            get { return _sTFieldAllowFilter; }
            set
            {
                if (value != this._sTFieldAllowFilter)
                {
                    _sTFieldAllowFilter = value;
                    NotifyChanged("STFieldAllowFilter");
                }
            }
        }
        public int STFieldParentID
        {
            get { return _sTFieldParentID; }
            set
            {
                if (value != this._sTFieldParentID)
                {
                    _sTFieldParentID = value;
                    NotifyChanged("STFieldParentID");
                }
            }
        }
        public String STFieldTableName
        {
            get { return _sTFieldTableName; }
            set
            {
                if (value != this._sTFieldTableName)
                {
                    _sTFieldTableName = value;
                    NotifyChanged("STFieldTableName");
                }
            }
        }
        public int STFieldZOrder
        {
            get { return _sTFieldZOrder; }
            set
            {
                if (value != this._sTFieldZOrder)
                {
                    _sTFieldZOrder = value;
                    NotifyChanged("STFieldZOrder");
                }
            }
        }
        public int STFieldAnchor
        {
            get { return _sTFieldAnchor; }
            set
            {
                if (value != this._sTFieldAnchor)
                {
                    _sTFieldAnchor = value;
                    NotifyChanged("STFieldAnchor");
                }
            }
        }
        public int STFieldEventCount
        {
            get { return _sTFieldEventCount; }
            set
            {
                if (value != this._sTFieldEventCount)
                {
                    _sTFieldEventCount = value;
                    NotifyChanged("STFieldEventCount");
                }
            }
        }
        
        #endregion
    }
    #endregion
}