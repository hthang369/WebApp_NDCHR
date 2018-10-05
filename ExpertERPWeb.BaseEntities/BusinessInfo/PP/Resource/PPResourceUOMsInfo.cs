 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPResourceUOMs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.8)
    //Class: PPResourceUOMsInfo
    //Created Date: Tuesday, 27 Jun 2017
    //-----------------------------------------------------------

    public class PPResourceUOMsInfo : BusinessObject
    {
        public PPResourceUOMsInfo()
        {
        }
        #region Variables
		protected int _pPResourceUOMID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _pPResourceUOMNo = String.Empty;
		protected String _pPResourceUOMName = String.Empty;
		protected double _pPResourceUOMSQty;
		protected bool _pPResourceUOMDefault = true;
		
        #endregion

        #region Public properties
		public int PPResourceUOMID
		{
			get { return _pPResourceUOMID; }
			set
			{
				if (value != this._pPResourceUOMID)
				{
					_pPResourceUOMID = value;
					NotifyChanged("PPResourceUOMID");
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
		public String PPResourceUOMNo
		{
			get { return _pPResourceUOMNo; }
			set
			{
				if (value != this._pPResourceUOMNo)
				{
					_pPResourceUOMNo = value;
					NotifyChanged("PPResourceUOMNo");
				}
			}
		}
		public String PPResourceUOMName
		{
			get { return _pPResourceUOMName; }
			set
			{
				if (value != this._pPResourceUOMName)
				{
					_pPResourceUOMName = value;
					NotifyChanged("PPResourceUOMName");
				}
			}
		}
		public double PPResourceUOMSQty
		{
			get { return _pPResourceUOMSQty; }
			set
			{
				if (value != this._pPResourceUOMSQty)
				{
					_pPResourceUOMSQty = value;
					NotifyChanged("PPResourceUOMSQty");
				}
			}
		}
		public bool PPResourceUOMDefault
		{
			get { return _pPResourceUOMDefault; }
			set
			{
				if (value != this._pPResourceUOMDefault)
				{
					_pPResourceUOMDefault = value;
					NotifyChanged("PPResourceUOMDefault");
				}
			}
		}
		
        #endregion
    }
    #endregion
}