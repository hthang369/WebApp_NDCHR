using System;

namespace ExpertWebLib
{
    public class GEUserAuditsInfo : BusinessObject
    {
        protected int _gEUserAuditID;
        protected string _aAStatus = BusinessObject.DefaultAAStatus;
        protected int _aDUserID;
        protected string _aDUserName = string.Empty;
        protected string _gEUserAuditModuleName = string.Empty;
        protected DateTime _gEUserAuditBeginDate = DateTime.MaxValue;
        protected string _gEUserAuditAction = string.Empty;
        protected string _gEUserAuditParameter = string.Empty;
        protected string _gEUserAuditPCName = string.Empty;
        protected string _gEUserAuditIP = string.Empty;

        public int GEUserAuditID
        {
            get
            {
                return this._gEUserAuditID;
            }
            set
            {
                if (value != this._gEUserAuditID)
                {
                    this._gEUserAuditID = value;
                    string[] propertyNames = new string[] { "GEUserAuditID" };
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

        public int ADUserID
        {
            get
            {
                return this._aDUserID;
            }
            set
            {
                if (value != this._aDUserID)
                {
                    this._aDUserID = value;
                    string[] propertyNames = new string[] { "ADUserID" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string ADUserName
        {
            get
            {
                return this._aDUserName;
            }
            set
            {
                if (value != this._aDUserName)
                {
                    this._aDUserName = value;
                    string[] propertyNames = new string[] { "ADUserName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string GEUserAuditModuleName
        {
            get
            {
                return this._gEUserAuditModuleName;
            }
            set
            {
                if (value != this._gEUserAuditModuleName)
                {
                    this._gEUserAuditModuleName = value;
                    string[] propertyNames = new string[] { "GEUserAuditModuleName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public DateTime GEUserAuditBeginDate
        {
            get
            {
                return this._gEUserAuditBeginDate;
            }
            set
            {
                if (value != this._gEUserAuditBeginDate)
                {
                    this._gEUserAuditBeginDate = value;
                    string[] propertyNames = new string[] { "GEUserAuditBeginDate" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string GEUserAuditAction
        {
            get
            {
                return this._gEUserAuditAction;
            }
            set
            {
                if (value != this._gEUserAuditAction)
                {
                    this._gEUserAuditAction = value;
                    string[] propertyNames = new string[] { "GEUserAuditAction" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string GEUserAuditParameter
        {
            get
            {
                return this._gEUserAuditParameter;
            }
            set
            {
                if (value != this._gEUserAuditParameter)
                {
                    this._gEUserAuditParameter = value;
                    string[] propertyNames = new string[] { "GEUserAuditParameter" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string GEUserAuditPCName
        {
            get
            {
                return this._gEUserAuditPCName;
            }
            set
            {
                if (value != this._gEUserAuditPCName)
                {
                    this._gEUserAuditPCName = value;
                    string[] propertyNames = new string[] { "GEUserAuditPCName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string GEUserAuditIP
        {
            get
            {
                return this._gEUserAuditIP;
            }
            set
            {
                if (value != this._gEUserAuditIP)
                {
                    this._gEUserAuditIP = value;
                    string[] propertyNames = new string[] { "GEUserAuditIP" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }
    }
}
