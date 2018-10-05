using System;

namespace ExpertWebLib
{
    public class AAColumnAliasInfo : BusinessObject
    {
        protected int _aAColumnAliasID;
        protected string _aAStatus = BusinessObject.DefaultAAStatus;
        protected string _aAColumnAliasName = string.Empty;
        protected string _aAColumnAliasCaption = string.Empty;
        protected string _aATableName = string.Empty;

        public int AAColumnAliasID
        {
            get
            {
                return this._aAColumnAliasID;
            }
            set
            {
                if (value != this._aAColumnAliasID)
                {
                    this._aAColumnAliasID = value;
                    string[] propertyNames = new string[] { "AAColumnAliasID" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string AAStatus
        {
            get
            {
                return this._aAStatus;
            }
            set
            {
                if (value != this._aAStatus)
                {
                    this._aAStatus = value;
                    string[] propertyNames = new string[] { "AAStatus" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string AAColumnAliasName
        {
            get
            {
                return this._aAColumnAliasName;
            }
            set
            {
                if (value != this._aAColumnAliasName)
                {
                    this._aAColumnAliasName = value;
                    string[] propertyNames = new string[] { "AAColumnAliasName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string AAColumnAliasCaption
        {
            get
            {
                return this._aAColumnAliasCaption;
            }
            set
            {
                if (value != this._aAColumnAliasCaption)
                {
                    this._aAColumnAliasCaption = value;
                    string[] propertyNames = new string[] { "AAColumnAliasCaption" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string AATableName
        {
            get
            {
                return this._aATableName;
            }
            set
            {
                if (value != this._aATableName)
                {
                    this._aATableName = value;
                    string[] propertyNames = new string[] { "AATableName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }
    }
}
