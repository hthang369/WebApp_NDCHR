using System;

namespace ExpertWebLib
{
    public class STModuleTablesInfo : BusinessObject
    {
        protected int _sTModuleTableID;
        protected int _sTModuleID;
        protected string _sTModuleTableName = string.Empty;
        protected int _sTModuleTableType;
        protected int _sTModuleTableLevelIndex;

        public int STModuleTableID
        {
            get
            {
                return this._sTModuleTableID;
            }
            set
            {
                if (value != this._sTModuleTableID)
                {
                    this._sTModuleTableID = value;
                    string[] propertyNames = new string[] { "STModuleTableID" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public int STModuleID
        {
            get
            {
                return this._sTModuleID;
            }
            set
            {
                if (value != this._sTModuleID)
                {
                    this._sTModuleID = value;
                    string[] propertyNames = new string[] { "STModuleID" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string STModuleTableName
        {
            get
            {
                return this._sTModuleTableName;
            }
            set
            {
                if (value != this._sTModuleTableName)
                {
                    this._sTModuleTableName = value;
                    string[] propertyNames = new string[] { "STModuleTableName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public int STModuleTableType
        {
            get
            {
                return this._sTModuleTableType;
            }
            set
            {
                if (value != this._sTModuleTableType)
                {
                    this._sTModuleTableType = value;
                    string[] propertyNames = new string[] { "STModuleTableType" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public int STModuleTableLevelIndex
        {
            get
            {
                return this._sTModuleTableLevelIndex;
            }
            set
            {
                if (value != this._sTModuleTableLevelIndex)
                {
                    this._sTModuleTableLevelIndex = value;
                    string[] propertyNames = new string[] { "STModuleTableLevelIndex" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }
    }
}
