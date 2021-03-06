
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region ARFlowChartDocs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.71)
    //Class: ARFlowChartDocsInfo
    //Created Date: Saturday, 27 Aug 2016
    //-----------------------------------------------------------

    public class ARFlowChartDocsInfo : BusinessObject
    {
        public ARFlowChartDocsInfo()
        {
        }
        #region Variables
		protected int _aRFlowChartDocID;
		protected DateTime _aACreatedDate = DateTime.Now;
		protected String _aACreatedUser = String.Empty;
		protected DateTime _aAUpdatedDate = DateTime.Now;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _aRFlowChartDocNo = String.Empty;
		protected String _aRFlowChartDocDesc = String.Empty;
		protected String _aRFlowChartDocUser = String.Empty;
		protected Nullable<DateTime> _aRFlowChartDocDate;
		protected String _aRFlowChartDocServerPath = String.Empty;
		protected int _fK_ARFlowChartID;
		protected int _fK_ADUserID;
		
        #endregion

        #region Public properties
		public int ARFlowChartDocID
		{
			get { return _aRFlowChartDocID; }
			set
			{
				if (value != this._aRFlowChartDocID)
				{
					_aRFlowChartDocID = value;
					NotifyChanged("ARFlowChartDocID");
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
		public String ARFlowChartDocNo
		{
			get { return _aRFlowChartDocNo; }
			set
			{
				if (value != this._aRFlowChartDocNo)
				{
					_aRFlowChartDocNo = value;
					NotifyChanged("ARFlowChartDocNo");
				}
			}
		}
		public String ARFlowChartDocDesc
		{
			get { return _aRFlowChartDocDesc; }
			set
			{
				if (value != this._aRFlowChartDocDesc)
				{
					_aRFlowChartDocDesc = value;
					NotifyChanged("ARFlowChartDocDesc");
				}
			}
		}
		public String ARFlowChartDocUser
		{
			get { return _aRFlowChartDocUser; }
			set
			{
				if (value != this._aRFlowChartDocUser)
				{
					_aRFlowChartDocUser = value;
					NotifyChanged("ARFlowChartDocUser");
				}
			}
		}
		public Nullable<DateTime> ARFlowChartDocDate
		{
			get { return _aRFlowChartDocDate; }
			set
			{
				if (value != this._aRFlowChartDocDate)
				{
					_aRFlowChartDocDate = value;
					NotifyChanged("ARFlowChartDocDate");
				}
			}
		}
		public String ARFlowChartDocServerPath
		{
			get { return _aRFlowChartDocServerPath; }
			set
			{
				if (value != this._aRFlowChartDocServerPath)
				{
					_aRFlowChartDocServerPath = value;
					NotifyChanged("ARFlowChartDocServerPath");
				}
			}
		}
		public int FK_ARFlowChartID
		{
			get { return _fK_ARFlowChartID; }
			set
			{
				if (value != this._fK_ARFlowChartID)
				{
					_fK_ARFlowChartID = value;
					NotifyChanged("FK_ARFlowChartID");
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