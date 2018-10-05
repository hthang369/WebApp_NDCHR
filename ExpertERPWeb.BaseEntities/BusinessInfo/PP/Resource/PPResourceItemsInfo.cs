 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPResourceItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.8)
    //Class: PPResourceItemsInfo
    //Created Date: Tuesday, 27 Jun 2017
    //-----------------------------------------------------------

    public class PPResourceItemsInfo : BusinessObject
    {
        public PPResourceItemsInfo()
        {
        }
        #region Variables
		protected int _pPResourceItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected String _pPResourceItemNo = String.Empty;
		protected int _fK_PPResourceID;
		protected int _fK_PPResourceToolID;
		protected double _pPResourceItemProductivityQty;
		protected double _pPResourceItemProductivityStkQty;
		protected String _pPResourceItemRegimeCombo = String.Empty;
		protected int _fK_PPPhaseCfgID;
		protected int _fK_PPWorkCenterID;
		protected int _fK_PPResourceRegimeID;
		protected int _fK_PPResourceItemivityUOMID;
		protected double _pPResourceItemivityQty;
		protected double _pPResourceItemSetupQty;
		
        #endregion

        #region Public properties
		public int PPResourceItemID
		{
			get { return _pPResourceItemID; }
			set
			{
				if (value != this._pPResourceItemID)
				{
					_pPResourceItemID = value;
					NotifyChanged("PPResourceItemID");
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
		public String PPResourceItemNo
		{
			get { return _pPResourceItemNo; }
			set
			{
				if (value != this._pPResourceItemNo)
				{
					_pPResourceItemNo = value;
					NotifyChanged("PPResourceItemNo");
				}
			}
		}
		public int FK_PPResourceID
		{
			get { return _fK_PPResourceID; }
			set
			{
				if (value != this._fK_PPResourceID)
				{
					_fK_PPResourceID = value;
					NotifyChanged("FK_PPResourceID");
				}
			}
		}
		public int FK_PPResourceToolID
		{
			get { return _fK_PPResourceToolID; }
			set
			{
				if (value != this._fK_PPResourceToolID)
				{
					_fK_PPResourceToolID = value;
					NotifyChanged("FK_PPResourceToolID");
				}
			}
		}
		public double PPResourceItemProductivityQty
		{
			get { return _pPResourceItemProductivityQty; }
			set
			{
				if (value != this._pPResourceItemProductivityQty)
				{
					_pPResourceItemProductivityQty = value;
					NotifyChanged("PPResourceItemProductivityQty");
				}
			}
		}
		public double PPResourceItemProductivityStkQty
		{
			get { return _pPResourceItemProductivityStkQty; }
			set
			{
				if (value != this._pPResourceItemProductivityStkQty)
				{
					_pPResourceItemProductivityStkQty = value;
					NotifyChanged("PPResourceItemProductivityStkQty");
				}
			}
		}
		public String PPResourceItemRegimeCombo
		{
			get { return _pPResourceItemRegimeCombo; }
			set
			{
				if (value != this._pPResourceItemRegimeCombo)
				{
					_pPResourceItemRegimeCombo = value;
					NotifyChanged("PPResourceItemRegimeCombo");
				}
			}
		}
		public int FK_PPPhaseCfgID
		{
			get { return _fK_PPPhaseCfgID; }
			set
			{
				if (value != this._fK_PPPhaseCfgID)
				{
					_fK_PPPhaseCfgID = value;
					NotifyChanged("FK_PPPhaseCfgID");
				}
			}
		}
		public int FK_PPWorkCenterID
		{
			get { return _fK_PPWorkCenterID; }
			set
			{
				if (value != this._fK_PPWorkCenterID)
				{
					_fK_PPWorkCenterID = value;
					NotifyChanged("FK_PPWorkCenterID");
				}
			}
		}
		public int FK_PPResourceRegimeID
		{
			get { return _fK_PPResourceRegimeID; }
			set
			{
				if (value != this._fK_PPResourceRegimeID)
				{
					_fK_PPResourceRegimeID = value;
					NotifyChanged("FK_PPResourceRegimeID");
				}
			}
		}
		public int FK_PPResourceItemivityUOMID
		{
			get { return _fK_PPResourceItemivityUOMID; }
			set
			{
				if (value != this._fK_PPResourceItemivityUOMID)
				{
					_fK_PPResourceItemivityUOMID = value;
					NotifyChanged("FK_PPResourceItemivityUOMID");
				}
			}
		}
		public double PPResourceItemivityQty
		{
			get { return _pPResourceItemivityQty; }
			set
			{
				if (value != this._pPResourceItemivityQty)
				{
					_pPResourceItemivityQty = value;
					NotifyChanged("PPResourceItemivityQty");
				}
			}
		}
		public double PPResourceItemSetupQty
		{
			get { return _pPResourceItemSetupQty; }
			set
			{
				if (value != this._pPResourceItemSetupQty)
				{
					_pPResourceItemSetupQty = value;
					NotifyChanged("PPResourceItemSetupQty");
				}
			}
		}
		
        #endregion
    }
    #endregion
}