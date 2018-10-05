
using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GEPolicyDefineRewardCfgs
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH (v2.1.88)
    //Class: GEPolicyDefineRewardCfgsInfo
    //Created Date: Tuesday, 04 Apr 2017
    //-----------------------------------------------------------

    public class GEPolicyDefineRewardCfgsInfo : BusinessObject
    {
        public GEPolicyDefineRewardCfgsInfo()
        {
        }
        #region Variables
		protected int _gEPolicyDefineRewardCfgID;
		protected String _gEPolicyDefineRewardCfgDesc = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected int _fK_ICProductID;
		protected double _gEPolicyDefineRewardCfgQty;
		protected int _fK_ICUOMID;
		protected int _fK_ICStkUOMID;
		protected double _gEPolicyDefineRewardCfgStkQty;
		protected int _fK_GEPolicyMthCfgID;
		
        #endregion

        #region Public properties
		public int GEPolicyDefineRewardCfgID
		{
			get { return _gEPolicyDefineRewardCfgID; }
			set
			{
				if (value != this._gEPolicyDefineRewardCfgID)
				{
					_gEPolicyDefineRewardCfgID = value;
					NotifyChanged("GEPolicyDefineRewardCfgID");
				}
			}
		}
		public String GEPolicyDefineRewardCfgDesc
		{
			get { return _gEPolicyDefineRewardCfgDesc; }
			set
			{
				if (value != this._gEPolicyDefineRewardCfgDesc)
				{
					_gEPolicyDefineRewardCfgDesc = value;
					NotifyChanged("GEPolicyDefineRewardCfgDesc");
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
		public double GEPolicyDefineRewardCfgQty
		{
			get { return _gEPolicyDefineRewardCfgQty; }
			set
			{
				if (value != this._gEPolicyDefineRewardCfgQty)
				{
					_gEPolicyDefineRewardCfgQty = value;
					NotifyChanged("GEPolicyDefineRewardCfgQty");
				}
			}
		}
		public int FK_ICUOMID
		{
			get { return _fK_ICUOMID; }
			set
			{
				if (value != this._fK_ICUOMID)
				{
					_fK_ICUOMID = value;
					NotifyChanged("FK_ICUOMID");
				}
			}
		}
		public int FK_ICStkUOMID
		{
			get { return _fK_ICStkUOMID; }
			set
			{
				if (value != this._fK_ICStkUOMID)
				{
					_fK_ICStkUOMID = value;
					NotifyChanged("FK_ICStkUOMID");
				}
			}
		}
		public double GEPolicyDefineRewardCfgStkQty
		{
			get { return _gEPolicyDefineRewardCfgStkQty; }
			set
			{
				if (value != this._gEPolicyDefineRewardCfgStkQty)
				{
					_gEPolicyDefineRewardCfgStkQty = value;
					NotifyChanged("GEPolicyDefineRewardCfgStkQty");
				}
			}
		}
		public int FK_GEPolicyMthCfgID
		{
			get { return _fK_GEPolicyMthCfgID; }
			set
			{
				if (value != this._fK_GEPolicyMthCfgID)
				{
					_fK_GEPolicyMthCfgID = value;
					NotifyChanged("FK_GEPolicyMthCfgID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}