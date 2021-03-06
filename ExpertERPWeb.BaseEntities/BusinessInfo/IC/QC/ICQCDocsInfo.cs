
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ICQCDocs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.59)
    //Class: ICQCDocsInfo
    //Created Date: Monday, 13 Jun 2016
    //-----------------------------------------------------------

    public class ICQCDocsInfo : BusinessObject
    {
        public ICQCDocsInfo()
        {
        }
        #region Variables
		protected int _iCQCDocID;
		protected DateTime _aACreatedDate = DateTime.Now;
		protected String _aACreatedUser = String.Empty;
		protected DateTime _aAUpdatedDate = DateTime.Now;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _iCQCDocNo = String.Empty;
		protected String _iCQCDocDesc = String.Empty;
		protected String _iCQCDocUser = String.Empty;
		protected Nullable<DateTime> _iCQCDocDate;
		protected String _iCQCDocServerPath = String.Empty;
		protected int _fK_ICQCID;
		protected int _fK_ADUserID;
		
        #endregion

        #region Public properties
		public int ICQCDocID
		{
			get { return _iCQCDocID; }
			set
			{
				if (value != this._iCQCDocID)
				{
					_iCQCDocID = value;
					NotifyChanged("ICQCDocID");
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
		public String ICQCDocNo
		{
			get { return _iCQCDocNo; }
			set
			{
				if (value != this._iCQCDocNo)
				{
					_iCQCDocNo = value;
					NotifyChanged("ICQCDocNo");
				}
			}
		}
		public String ICQCDocDesc
		{
			get { return _iCQCDocDesc; }
			set
			{
				if (value != this._iCQCDocDesc)
				{
					_iCQCDocDesc = value;
					NotifyChanged("ICQCDocDesc");
				}
			}
		}
		public String ICQCDocUser
		{
			get { return _iCQCDocUser; }
			set
			{
				if (value != this._iCQCDocUser)
				{
					_iCQCDocUser = value;
					NotifyChanged("ICQCDocUser");
				}
			}
		}
		public Nullable<DateTime> ICQCDocDate
		{
			get { return _iCQCDocDate; }
			set
			{
				if (value != this._iCQCDocDate)
				{
					_iCQCDocDate = value;
					NotifyChanged("ICQCDocDate");
				}
			}
		}
		public String ICQCDocServerPath
		{
			get { return _iCQCDocServerPath; }
			set
			{
				if (value != this._iCQCDocServerPath)
				{
					_iCQCDocServerPath = value;
					NotifyChanged("ICQCDocServerPath");
				}
			}
		}
		public int FK_ICQCID
		{
			get { return _fK_ICQCID; }
			set
			{
				if (value != this._fK_ICQCID)
				{
					_fK_ICQCID = value;
					NotifyChanged("FK_ICQCID");
				}
			}
		}
		public int FK_ADUserID
		{
			get { return _fK_ADUserID; }
			set
			{
				if (value != this._fK_ADUserID)
				{
					_fK_ADUserID = value;
					NotifyChanged("FK_ADUserID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}