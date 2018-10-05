using System;

namespace ExpertWebLib
{
    public class STRptsInfo : BusinessObject
    {
        protected int _sTRptID;
        protected string _sTRptNo = string.Empty;
        protected string _sTRptName = string.Empty;
        protected string _sTRptFileName = string.Empty;
        protected string _sTRptDesc = string.Empty;
        protected string _sTRptGroup = string.Empty;
        protected string _sTRptType = string.Empty;

        public int STRptID
        {
            get
            {
                return this._sTRptID;
            }
            set
            {
                if (value != this._sTRptID)
                {
                    this._sTRptID = value;
                    string[] propertyNames = new string[] { "STRptID" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string STRptNo
        {
            get
            {
                return this._sTRptNo;
            }
            set
            {
                if (value != this._sTRptNo)
                {
                    this._sTRptNo = value;
                    string[] propertyNames = new string[] { "STRptNo" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string STRptName
        {
            get
            {
                return this._sTRptName;
            }
            set
            {
                if (value != this._sTRptName)
                {
                    this._sTRptName = value;
                    string[] propertyNames = new string[] { "STRptName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string STRptFileName
        {
            get
            {
                return this._sTRptFileName;
            }
            set
            {
                if (value != this._sTRptFileName)
                {
                    this._sTRptFileName = value;
                    string[] propertyNames = new string[] { "STRptFileName" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string STRptDesc
        {
            get
            {
                return this._sTRptDesc;
            }
            set
            {
                if (value != this._sTRptDesc)
                {
                    this._sTRptDesc = value;
                    string[] propertyNames = new string[] { "STRptDesc" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string STRptGroup
        {
            get
            {
                return this._sTRptGroup;
            }
            set
            {
                if (value != this._sTRptGroup)
                {
                    this._sTRptGroup = value;
                    string[] propertyNames = new string[] { "STRptGroup" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }

        public string STRptType
        {
            get
            {
                return this._sTRptType;
            }
            set
            {
                if (value != this._sTRptType)
                {
                    this._sTRptType = value;
                    string[] propertyNames = new string[] { "STRptType" };
                    this.NotifyChanged(propertyNames);
                }
            }
        }
    }
}
