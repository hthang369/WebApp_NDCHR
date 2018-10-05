using System;

namespace ExpertWebLib
{
    public class AATableNameAliasInfo : BusinessObject
    {
        protected int _aATableNameAliasID;
        protected string _aAStatus = BusinessObject.DefaultAAStatus;
        protected string _aATableNameAliasCaption = string.Empty;
        protected string _aATableName = string.Empty;

        public int AATableNameAliasID
        {
            get
            {
                return this._aATableNameAliasID;
            }
            set
            {
                if (value != this._aATableNameAliasID)
                {
                    this._aATableNameAliasID = value;
                    string[] propertyNames = new string[] { "AATableNameAliasID" };
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

        public string AATableNameAliasCaption
        {
            get
            {
                return this._aATableNameAliasCaption;
            }
            set
            {
                if (value != this._aATableNameAliasCaption)
                {
                    this._aATableNameAliasCaption = value;
                    string[] propertyNames = new string[] { "AATableNameAliasCaption" };
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
