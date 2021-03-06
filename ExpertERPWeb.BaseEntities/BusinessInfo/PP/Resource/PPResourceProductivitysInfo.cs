 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPResourceProductivitys
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v2.0.8)
    //Class: PPResourceProductivitysInfo
    //Created Date: Tuesday, 27 Jun 2017
    //-----------------------------------------------------------

    public class PPResourceProductivitysInfo : BusinessObject
    {
        public PPResourceProductivitysInfo()
        {
        }
        #region Variables
		protected int _pPResourceProductivityID;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected int _fK_ADOFID;
		protected int _fK_ADOFItemID;
		protected double _pPResourceProductivityQty;
		protected String _pPResourceProductivityDesc = String.Empty;
		protected int _fK_PPResourceID;
		protected int _fK_ICProductID;
		protected int _fK_PPResourceItemID;
		protected double _pPResourceProductivityStkQty;
		protected String _pPResourceProductivityRegimeCombo = String.Empty;
		protected int _fK_ICProductUOMID;
		protected int _fK_PPResourceRegimeID;
		protected int _fK_PPResourceUOMID;
		protected double _pPResourceProductivitySetupQty;
		protected String _pPResourceProductivityIOF01Combo = String.Empty;
		protected String _pPResourceProductivityIOF02Combo = String.Empty;
		protected String _pPResourceProductivityIOF03Combo = String.Empty;
		protected String _pPResourceProductivityIOF04Combo = String.Empty;
		protected String _pPResourceProductivityIOF05Combo = String.Empty;
		protected String _pPResourceProductivityIOF06Combo = String.Empty;
		protected String _pPResourceProductivityIOF07Combo = String.Empty;
		protected String _pPResourceProductivityIOF08Combo = String.Empty;
		protected String _pPResourceProductivityIOF09Combo = String.Empty;
		protected String _pPResourceProductivityIOF10Combo = String.Empty;
		
        #endregion

        #region Public properties
		public int PPResourceProductivityID
		{
			get { return _pPResourceProductivityID; }
			set
			{
				if (value != this._pPResourceProductivityID)
				{
					_pPResourceProductivityID = value;
					NotifyChanged("PPResourceProductivityID");
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
		public int FK_ADOFID
		{
			get { return _fK_ADOFID; }
			set
			{
				if (value != this._fK_ADOFID)
				{
					_fK_ADOFID = value;
					NotifyChanged("FK_ADOFID");
				}
			}
		}
		public int FK_ADOFItemID
		{
			get { return _fK_ADOFItemID; }
			set
			{
				if (value != this._fK_ADOFItemID)
				{
					_fK_ADOFItemID = value;
					NotifyChanged("FK_ADOFItemID");
				}
			}
		}
		public double PPResourceProductivityQty
		{
			get { return _pPResourceProductivityQty; }
			set
			{
				if (value != this._pPResourceProductivityQty)
				{
					_pPResourceProductivityQty = value;
					NotifyChanged("PPResourceProductivityQty");
				}
			}
		}
		public String PPResourceProductivityDesc
		{
			get { return _pPResourceProductivityDesc; }
			set
			{
				if (value != this._pPResourceProductivityDesc)
				{
					_pPResourceProductivityDesc = value;
					NotifyChanged("PPResourceProductivityDesc");
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
		public int FK_ICProductID
		{
			get { return _fK_ICProductID; }
			set
			{
				if (value != this._fK_ICProductID)
				{
					_fK_ICProductID = value;
					NotifyChanged("FK_ICProductID");
				}
			}
		}
		public int FK_PPResourceItemID
		{
			get { return _fK_PPResourceItemID; }
			set
			{
				if (value != this._fK_PPResourceItemID)
				{
					_fK_PPResourceItemID = value;
					NotifyChanged("FK_PPResourceItemID");
				}
			}
		}
		public double PPResourceProductivityStkQty
		{
			get { return _pPResourceProductivityStkQty; }
			set
			{
				if (value != this._pPResourceProductivityStkQty)
				{
					_pPResourceProductivityStkQty = value;
					NotifyChanged("PPResourceProductivityStkQty");
				}
			}
		}
		public String PPResourceProductivityRegimeCombo
		{
			get { return _pPResourceProductivityRegimeCombo; }
			set
			{
				if (value != this._pPResourceProductivityRegimeCombo)
				{
					_pPResourceProductivityRegimeCombo = value;
					NotifyChanged("PPResourceProductivityRegimeCombo");
				}
			}
		}
		public int FK_ICProductUOMID
		{
			get { return _fK_ICProductUOMID; }
			set
			{
				if (value != this._fK_ICProductUOMID)
				{
					_fK_ICProductUOMID = value;
					NotifyChanged("FK_ICProductUOMID");
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
		public int FK_PPResourceUOMID
		{
			get { return _fK_PPResourceUOMID; }
			set
			{
				if (value != this._fK_PPResourceUOMID)
				{
					_fK_PPResourceUOMID = value;
					NotifyChanged("FK_PPResourceUOMID");
				}
			}
		}
		public double PPResourceProductivitySetupQty
		{
			get { return _pPResourceProductivitySetupQty; }
			set
			{
				if (value != this._pPResourceProductivitySetupQty)
				{
					_pPResourceProductivitySetupQty = value;
					NotifyChanged("PPResourceProductivitySetupQty");
				}
			}
		}
		public String PPResourceProductivityIOF01Combo
		{
			get { return _pPResourceProductivityIOF01Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF01Combo)
				{
					_pPResourceProductivityIOF01Combo = value;
					NotifyChanged("PPResourceProductivityIOF01Combo");
				}
			}
		}
		public String PPResourceProductivityIOF02Combo
		{
			get { return _pPResourceProductivityIOF02Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF02Combo)
				{
					_pPResourceProductivityIOF02Combo = value;
					NotifyChanged("PPResourceProductivityIOF02Combo");
				}
			}
		}
		public String PPResourceProductivityIOF03Combo
		{
			get { return _pPResourceProductivityIOF03Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF03Combo)
				{
					_pPResourceProductivityIOF03Combo = value;
					NotifyChanged("PPResourceProductivityIOF03Combo");
				}
			}
		}
		public String PPResourceProductivityIOF04Combo
		{
			get { return _pPResourceProductivityIOF04Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF04Combo)
				{
					_pPResourceProductivityIOF04Combo = value;
					NotifyChanged("PPResourceProductivityIOF04Combo");
				}
			}
		}
		public String PPResourceProductivityIOF05Combo
		{
			get { return _pPResourceProductivityIOF05Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF05Combo)
				{
					_pPResourceProductivityIOF05Combo = value;
					NotifyChanged("PPResourceProductivityIOF05Combo");
				}
			}
		}
		public String PPResourceProductivityIOF06Combo
		{
			get { return _pPResourceProductivityIOF06Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF06Combo)
				{
					_pPResourceProductivityIOF06Combo = value;
					NotifyChanged("PPResourceProductivityIOF06Combo");
				}
			}
		}
		public String PPResourceProductivityIOF07Combo
		{
			get { return _pPResourceProductivityIOF07Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF07Combo)
				{
					_pPResourceProductivityIOF07Combo = value;
					NotifyChanged("PPResourceProductivityIOF07Combo");
				}
			}
		}
		public String PPResourceProductivityIOF08Combo
		{
			get { return _pPResourceProductivityIOF08Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF08Combo)
				{
					_pPResourceProductivityIOF08Combo = value;
					NotifyChanged("PPResourceProductivityIOF08Combo");
				}
			}
		}
		public String PPResourceProductivityIOF09Combo
		{
			get { return _pPResourceProductivityIOF09Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF09Combo)
				{
					_pPResourceProductivityIOF09Combo = value;
					NotifyChanged("PPResourceProductivityIOF09Combo");
				}
			}
		}
		public String PPResourceProductivityIOF10Combo
		{
			get { return _pPResourceProductivityIOF10Combo; }
			set
			{
				if (value != this._pPResourceProductivityIOF10Combo)
				{
					_pPResourceProductivityIOF10Combo = value;
					NotifyChanged("PPResourceProductivityIOF10Combo");
				}
			}
		}
		
        #endregion
    }
    #endregion
}