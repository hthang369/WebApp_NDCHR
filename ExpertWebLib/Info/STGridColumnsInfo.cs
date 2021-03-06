using System;
using System.Text;
using System.Collections.Generic;

namespace ExpertWebLib
{
    #region STGridColumns
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.Net ♫ Hồռ؏ ₤ĩռᶋ (v2.0.96)
    //Class: STGridColumnsInfo
    //Created Date: Friday, 03 Aug 2018
    //-----------------------------------------------------------

    public class STGridColumnsInfo : BusinessObject
    {
        public STGridColumnsInfo()
        {
        }
        #region Variables
        protected int _sTGridColumnID;
        protected int _fK_STFieldID;
        protected String _sTGridColumnName = String.Empty;
        protected String _sTGridColumnCaption = String.Empty;
        protected String _sTGridColumnTableName = String.Empty;
        protected bool _sTGridColumnEnable = true;
        protected int _sTGridColumnTabIndex;
        protected String _sTGridColumnRepository = String.Empty;
        protected String _sTGridColumnRepoDsplMem = String.Empty;
        protected bool _sTGridColumnVisible = true;
        protected String _sTGridColumnFieldGroup = String.Empty;
        protected int _sTGridColumnW;
        protected String _sTGridColumnRepoCol1 = String.Empty;
        protected String _sTGridColumnRepoCol1Caption = String.Empty;
        protected String _sTGridColumnRepoCol2 = String.Empty;
        protected String _sTGridColumnRepoCol2Caption = String.Empty;
        protected String _sTGridColumnRepoCol3 = String.Empty;
        protected String _sTGridColumnRepoCol3Caption = String.Empty;
        protected String _sTGridColumnRepoCol4 = String.Empty;
        protected String _sTGridColumnRepoCol4Caption = String.Empty;
        protected String _sTGridColumnRepoCol5 = String.Empty;
        protected String _sTGridColumnRepoCol5Caption = String.Empty;
        protected String _sTGridColumnRepoSelectType = String.Empty;
        protected String _sTGridColumnRepoSelectTypeValue = String.Empty;
        
        #endregion

        #region Public properties
        public int STGridColumnID
        {
            get { return _sTGridColumnID; }
            set
            {
                if (value != this._sTGridColumnID)
                {
                    _sTGridColumnID = value;
                    NotifyChanged("STGridColumnID");
                }
            }
        }
        public int FK_STFieldID
        {
            get { return _fK_STFieldID; }
            set
            {
                if (value != this._fK_STFieldID)
                {
                    _fK_STFieldID = value;
                    NotifyChanged("FK_STFieldID");
                }
            }
        }
        public String STGridColumnName
        {
            get { return _sTGridColumnName; }
            set
            {
                if (value != this._sTGridColumnName)
                {
                    _sTGridColumnName = value;
                    NotifyChanged("STGridColumnName");
                }
            }
        }
        public String STGridColumnCaption
        {
            get { return _sTGridColumnCaption; }
            set
            {
                if (value != this._sTGridColumnCaption)
                {
                    _sTGridColumnCaption = value;
                    NotifyChanged("STGridColumnCaption");
                }
            }
        }
        public String STGridColumnTableName
        {
            get { return _sTGridColumnTableName; }
            set
            {
                if (value != this._sTGridColumnTableName)
                {
                    _sTGridColumnTableName = value;
                    NotifyChanged("STGridColumnTableName");
                }
            }
        }
        public bool STGridColumnEnable
        {
            get { return _sTGridColumnEnable; }
            set
            {
                if (value != this._sTGridColumnEnable)
                {
                    _sTGridColumnEnable = value;
                    NotifyChanged("STGridColumnEnable");
                }
            }
        }
        public int STGridColumnTabIndex
        {
            get { return _sTGridColumnTabIndex; }
            set
            {
                if (value != this._sTGridColumnTabIndex)
                {
                    _sTGridColumnTabIndex = value;
                    NotifyChanged("STGridColumnTabIndex");
                }
            }
        }
        public String STGridColumnRepository
        {
            get { return _sTGridColumnRepository; }
            set
            {
                if (value != this._sTGridColumnRepository)
                {
                    _sTGridColumnRepository = value;
                    NotifyChanged("STGridColumnRepository");
                }
            }
        }
        public String STGridColumnRepoDsplMem
        {
            get { return _sTGridColumnRepoDsplMem; }
            set
            {
                if (value != this._sTGridColumnRepoDsplMem)
                {
                    _sTGridColumnRepoDsplMem = value;
                    NotifyChanged("STGridColumnRepoDsplMem");
                }
            }
        }
        public bool STGridColumnVisible
        {
            get { return _sTGridColumnVisible; }
            set
            {
                if (value != this._sTGridColumnVisible)
                {
                    _sTGridColumnVisible = value;
                    NotifyChanged("STGridColumnVisible");
                }
            }
        }
        public String STGridColumnFieldGroup
        {
            get { return _sTGridColumnFieldGroup; }
            set
            {
                if (value != this._sTGridColumnFieldGroup)
                {
                    _sTGridColumnFieldGroup = value;
                    NotifyChanged("STGridColumnFieldGroup");
                }
            }
        }
        public int STGridColumnW
        {
            get { return _sTGridColumnW; }
            set
            {
                if (value != this._sTGridColumnW)
                {
                    _sTGridColumnW = value;
                    NotifyChanged("STGridColumnW");
                }
            }
        }
        public String STGridColumnRepoCol1
        {
            get { return _sTGridColumnRepoCol1; }
            set
            {
                if (value != this._sTGridColumnRepoCol1)
                {
                    _sTGridColumnRepoCol1 = value;
                    NotifyChanged("STGridColumnRepoCol1");
                }
            }
        }
        public String STGridColumnRepoCol1Caption
        {
            get { return _sTGridColumnRepoCol1Caption; }
            set
            {
                if (value != this._sTGridColumnRepoCol1Caption)
                {
                    _sTGridColumnRepoCol1Caption = value;
                    NotifyChanged("STGridColumnRepoCol1Caption");
                }
            }
        }
        public String STGridColumnRepoCol2
        {
            get { return _sTGridColumnRepoCol2; }
            set
            {
                if (value != this._sTGridColumnRepoCol2)
                {
                    _sTGridColumnRepoCol2 = value;
                    NotifyChanged("STGridColumnRepoCol2");
                }
            }
        }
        public String STGridColumnRepoCol2Caption
        {
            get { return _sTGridColumnRepoCol2Caption; }
            set
            {
                if (value != this._sTGridColumnRepoCol2Caption)
                {
                    _sTGridColumnRepoCol2Caption = value;
                    NotifyChanged("STGridColumnRepoCol2Caption");
                }
            }
        }
        public String STGridColumnRepoCol3
        {
            get { return _sTGridColumnRepoCol3; }
            set
            {
                if (value != this._sTGridColumnRepoCol3)
                {
                    _sTGridColumnRepoCol3 = value;
                    NotifyChanged("STGridColumnRepoCol3");
                }
            }
        }
        public String STGridColumnRepoCol3Caption
        {
            get { return _sTGridColumnRepoCol3Caption; }
            set
            {
                if (value != this._sTGridColumnRepoCol3Caption)
                {
                    _sTGridColumnRepoCol3Caption = value;
                    NotifyChanged("STGridColumnRepoCol3Caption");
                }
            }
        }
        public String STGridColumnRepoCol4
        {
            get { return _sTGridColumnRepoCol4; }
            set
            {
                if (value != this._sTGridColumnRepoCol4)
                {
                    _sTGridColumnRepoCol4 = value;
                    NotifyChanged("STGridColumnRepoCol4");
                }
            }
        }
        public String STGridColumnRepoCol4Caption
        {
            get { return _sTGridColumnRepoCol4Caption; }
            set
            {
                if (value != this._sTGridColumnRepoCol4Caption)
                {
                    _sTGridColumnRepoCol4Caption = value;
                    NotifyChanged("STGridColumnRepoCol4Caption");
                }
            }
        }
        public String STGridColumnRepoCol5
        {
            get { return _sTGridColumnRepoCol5; }
            set
            {
                if (value != this._sTGridColumnRepoCol5)
                {
                    _sTGridColumnRepoCol5 = value;
                    NotifyChanged("STGridColumnRepoCol5");
                }
            }
        }
        public String STGridColumnRepoCol5Caption
        {
            get { return _sTGridColumnRepoCol5Caption; }
            set
            {
                if (value != this._sTGridColumnRepoCol5Caption)
                {
                    _sTGridColumnRepoCol5Caption = value;
                    NotifyChanged("STGridColumnRepoCol5Caption");
                }
            }
        }
        public String STGridColumnRepoSelectType
        {
            get { return _sTGridColumnRepoSelectType; }
            set
            {
                if (value != this._sTGridColumnRepoSelectType)
                {
                    _sTGridColumnRepoSelectType = value;
                    NotifyChanged("STGridColumnRepoSelectType");
                }
            }
        }
        public String STGridColumnRepoSelectTypeValue
        {
            get { return _sTGridColumnRepoSelectTypeValue; }
            set
            {
                if (value != this._sTGridColumnRepoSelectTypeValue)
                {
                    _sTGridColumnRepoSelectTypeValue = value;
                    NotifyChanged("STGridColumnRepoSelectTypeValue");
                }
            }
        }
        
        #endregion
    }
    #endregion
}