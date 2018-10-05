using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLYears
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:GLYearsInfo
    //Created Date:05 Tha�ng Ba 2012
    //-----------------------------------------------------------

    public class GLYearsInfo : BusinessObject
    {
        public GLYearsInfo()
        {
        }
        #region Variables
        protected int _gLYearID;
        protected String _aACreatedUser = String.Empty;
        protected Nullable<DateTime> _aACreatedDate;
        protected String _aAUpdatedUser = String.Empty;
        protected Nullable<DateTime> _aAUpdatedDate;
        protected bool _aASelected = true;
        protected String _aAStatus = DefaultAAStatus;
        protected Nullable<DateTime> _gLYearStartDate;
        protected Nullable<DateTime> _gLYearEndDate;
        protected String _gLYearStatus = DefaultStatus;
        protected String _gLYearNo = String.Empty;
        protected int _gLYear;
        #endregion

        #region Public properties
        public int GLYearID
        {
            get { return _gLYearID; }
            set
            {
                if (value != this._gLYearID)
                {
                    _gLYearID = value;
                    NotifyChanged("GLYearID");
                }
            }
        }
        public String AACreatedUser
        {
            get { return _aACreatedUser; }
            set
            {
                if (value != this._aACreatedUser)
                {
                    _aACreatedUser = value;
                    NotifyChanged("AACreatedUser");
                }
            }
        }
        public Nullable<DateTime> AACreatedDate
        {
            get { return _aACreatedDate; }
            set
            {
                if (value != this._aACreatedDate)
                {
                    _aACreatedDate = value;
                    NotifyChanged("AACreatedDate");
                }
            }
        }
        public String AAUpdatedUser
        {
            get { return _aAUpdatedUser; }
            set
            {
                if (value != this._aAUpdatedUser)
                {
                    _aAUpdatedUser = value;
                    NotifyChanged("AAUpdatedUser");
                }
            }
        }
        public Nullable<DateTime> AAUpdatedDate
        {
            get { return _aAUpdatedDate; }
            set
            {
                if (value != this._aAUpdatedDate)
                {
                    _aAUpdatedDate = value;
                    NotifyChanged("AAUpdatedDate");
                }
            }
        }
        public bool AASelected
        {
            get { return _aASelected; }
            set
            {
                if (value != this._aASelected)
                {
                    _aASelected = value;
                    NotifyChanged("AASelected");
                }
            }
        }
        public String AAStatus
        {
            get { return _aAStatus; }
            set
            {
                if (value != this._aAStatus)
                {
                    _aAStatus = value;
                    NotifyChanged("AAStatus");
                }
            }
        }
        public Nullable<DateTime> GLYearStartDate
        {
            get { return _gLYearStartDate; }
            set
            {
                if (value != this._gLYearStartDate)
                {
                    _gLYearStartDate = value;
                    NotifyChanged("GLYearStartDate");
                }
            }
        }
        public Nullable<DateTime> GLYearEndDate
        {
            get { return _gLYearEndDate; }
            set
            {
                if (value != this._gLYearEndDate)
                {
                    _gLYearEndDate = value;
                    NotifyChanged("GLYearEndDate");
                }
            }
        }
        public String GLYearStatus
        {
            get { return _gLYearStatus; }
            set
            {
                if (value != this._gLYearStatus)
                {
                    _gLYearStatus = value;
                    NotifyChanged("GLYearStatus");
                }
            }
        }
        public String GLYearNo
        {
            get { return _gLYearNo; }
            set
            {
                if (value != this._gLYearNo)
                {
                    _gLYearNo = value;
                    NotifyChanged("GLYearNo");
                }
            }
        }
        public int GLYear
        {
            get { return _gLYear; }
            set
            {
                if (value != this._gLYear)
                {
                    _gLYear = value;
                    NotifyChanged("GLYear");
                }
            }
        }
        #endregion
    }
    #endregion
}