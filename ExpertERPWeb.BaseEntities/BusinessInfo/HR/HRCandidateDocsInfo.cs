
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region HRCandidateDocs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.89)
    //Class: HRCandidateDocsInfo
    //Created Date: Wednesday, 19 Jul 2017
    //-----------------------------------------------------------

    public class HRCandidateDocsInfo : BusinessObject
    {
        public HRCandidateDocsInfo()
        {
        }
        #region Variables
		protected int _hRCandidateDocID;
		protected DateTime _aACreatedDate = DateTime.Now;
		protected String _aACreatedUser = String.Empty;
		protected DateTime _aAUpdatedDate = DateTime.Now;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _hRCandidateDocNo = String.Empty;
		protected String _hRCandidateDocDesc = String.Empty;
		protected String _hRCandidateDocUser = String.Empty;
		protected Nullable<DateTime> _hRCandidateDocDate;
		protected String _hRCandidateDocServerPath = String.Empty;
		protected int _fK_HRCandidateID;
		protected int _fK_ADUserID;
		
        #endregion

        #region Public properties
		public int HRCandidateDocID
		{
			get { return _hRCandidateDocID; }
			set
			{
				if (value != this._hRCandidateDocID)
				{
					_hRCandidateDocID = value;
					NotifyChanged("HRCandidateDocID");
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
		public String HRCandidateDocNo
		{
			get { return _hRCandidateDocNo; }
			set
			{
				if (value != this._hRCandidateDocNo)
				{
					_hRCandidateDocNo = value;
					NotifyChanged("HRCandidateDocNo");
				}
			}
		}
		public String HRCandidateDocDesc
		{
			get { return _hRCandidateDocDesc; }
			set
			{
				if (value != this._hRCandidateDocDesc)
				{
					_hRCandidateDocDesc = value;
					NotifyChanged("HRCandidateDocDesc");
				}
			}
		}
		public String HRCandidateDocUser
		{
			get { return _hRCandidateDocUser; }
			set
			{
				if (value != this._hRCandidateDocUser)
				{
					_hRCandidateDocUser = value;
					NotifyChanged("HRCandidateDocUser");
				}
			}
		}
		public Nullable<DateTime> HRCandidateDocDate
		{
			get { return _hRCandidateDocDate; }
			set
			{
				if (value != this._hRCandidateDocDate)
				{
					_hRCandidateDocDate = value;
					NotifyChanged("HRCandidateDocDate");
				}
			}
		}
		public String HRCandidateDocServerPath
		{
			get { return _hRCandidateDocServerPath; }
			set
			{
				if (value != this._hRCandidateDocServerPath)
				{
					_hRCandidateDocServerPath = value;
					NotifyChanged("HRCandidateDocServerPath");
				}
			}
		}
		public int FK_HRCandidateID
		{
			get { return _fK_HRCandidateID; }
			set
			{
				if (value != this._fK_HRCandidateID)
				{
					_fK_HRCandidateID = value;
					NotifyChanged("FK_HRCandidateID");
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