using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region LOAdvanceConsignments
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class:LOAdvanceConsignmentsInfo
    //Created Date:Tuesday, March 10, 2009
    //-----------------------------------------------------------

    public class LOAdvanceConsignmentsInfo : BusinessObject
    {
        public LOAdvanceConsignmentsInfo()
        {
        }
        #region Variables
        protected int _lOAdvanceConsignmentID;
        protected String _aAStatus = DefaultAAStatus;
        protected int _fK_LOConsignmentID;
        protected int _fK_LOAdvanceID;
        protected String _lOAdvanceConsignmentStatus = DefaultStatus;
        protected double _lOAdvanceConsignmentAmount;
        protected double _lOAdvanceConsignmentLastPaymentAmount;
        protected double _lOAdvanceConsignmentRemainAmount;
        protected String _lOAdvanceConsignmentDesc = String.Empty;
        protected DateTime _lOAdvanceConsignmentPaymentDate = DateTime.MaxValue;
        protected String _aACreatedUser = String.Empty;
        protected String _aAUpdatedUser = String.Empty;
        protected DateTime _aACreatedDate = DateTime.MaxValue;
        protected DateTime _aAUpdatedDate = DateTime.MaxValue;
        #endregion

        #region Public properties
        public int LOAdvanceConsignmentID
        {
            get { return _lOAdvanceConsignmentID; }
            set
            {
                if (value != this._lOAdvanceConsignmentID)
                {
                    _lOAdvanceConsignmentID = value;
                    NotifyChanged("LOAdvanceConsignmentID");
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
        public int FK_LOConsignmentID
        {
            get { return _fK_LOConsignmentID; }
            set
            {
                if (value != this._fK_LOConsignmentID)
                {
                    _fK_LOConsignmentID = value;
                    NotifyChanged("FK_LOConsignmentID");
                }
            }
        }
        public int FK_LOAdvanceID
        {
            get { return _fK_LOAdvanceID; }
            set
            {
                if (value != this._fK_LOAdvanceID)
                {
                    _fK_LOAdvanceID = value;
                    NotifyChanged("FK_LOAdvanceID");
                }
            }
        }
        public String LOAdvanceConsignmentStatus
        {
            get { return _lOAdvanceConsignmentStatus; }
            set
            {
                if (value != this._lOAdvanceConsignmentStatus)
                {
                    _lOAdvanceConsignmentStatus = value;
                    NotifyChanged("LOAdvanceConsignmentStatus");
                }
            }
        }
        public double LOAdvanceConsignmentAmount
        {
            get { return _lOAdvanceConsignmentAmount; }
            set
            {
                if (value != this._lOAdvanceConsignmentAmount)
                {
                    _lOAdvanceConsignmentAmount = value;
                    NotifyChanged("LOAdvanceConsignmentAmount");
                }
            }
        }
        public double LOAdvanceConsignmentLastPaymentAmount
        {
            get { return _lOAdvanceConsignmentLastPaymentAmount; }
            set
            {
                if (value != this._lOAdvanceConsignmentLastPaymentAmount)
                {
                    _lOAdvanceConsignmentLastPaymentAmount = value;
                    NotifyChanged("LOAdvanceConsignmentLastPaymentAmount");
                }
            }
        }
        public double LOAdvanceConsignmentRemainAmount
        {
            get { return _lOAdvanceConsignmentRemainAmount; }
            set
            {
                if (value != this._lOAdvanceConsignmentRemainAmount)
                {
                    _lOAdvanceConsignmentRemainAmount = value;
                    NotifyChanged("LOAdvanceConsignmentRemainAmount");
                }
            }
        }
        public String LOAdvanceConsignmentDesc
        {
            get { return _lOAdvanceConsignmentDesc; }
            set
            {
                if (value != this._lOAdvanceConsignmentDesc)
                {
                    _lOAdvanceConsignmentDesc = value;
                    NotifyChanged("LOAdvanceConsignmentDesc");
                }
            }
        }
        public DateTime LOAdvanceConsignmentPaymentDate
        {
            get { return _lOAdvanceConsignmentPaymentDate; }
            set
            {
                if (value != this._lOAdvanceConsignmentPaymentDate)
                {
                    _lOAdvanceConsignmentPaymentDate = value;
                    NotifyChanged("LOAdvanceConsignmentPaymentDate");
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
        public DateTime AACreatedDate
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
        public DateTime AAUpdatedDate
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
        #endregion
    }
    #endregion
}