using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLFinalUnionAssetConstructions
    //-----------------------------------------------------------
    //Generated By: SQLDBTools - LINHCLH
    //Class: GLFinalUnionAssetConstructionsInfo
    //Created Date: 31 Mar 2015
    //-----------------------------------------------------------

    public class GLFinalUnionAssetConstructionsInfo : BusinessObject
    {
        public GLFinalUnionAssetConstructionsInfo()
        {
        }
        #region Variables
		protected int _gLFinalUnionAssetConstructionID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _gLFinalUnionAssetConstructionNo=String.Empty;
		protected String _gLFinalUnionAssetConstructionName=String.Empty;
		protected String _gLFinalUnionAssetConstructionDesc=String.Empty;
		protected DateTime _gLFinalUnionAssetConstructionDate=DateTime.Now;
		protected String _aAPostStatus=DefaultStatus;
		protected String _aALastPostNo=String.Empty;
		protected Nullable<DateTime> _aALastPostDate;
		protected int _fK_GECurrencyID;
		protected double _gLFinalUnionAssetConstructionExcRate;
		
        #endregion

        #region Public properties
		public int GLFinalUnionAssetConstructionID
		{
			get{return _gLFinalUnionAssetConstructionID;}
			set
			{
				if (value != this._gLFinalUnionAssetConstructionID)
				{
					_gLFinalUnionAssetConstructionID=value;
					NotifyChanged("GLFinalUnionAssetConstructionID");
				}
			}
		}
		public Nullable<DateTime> AACreatedDate
		{
			get{return _aACreatedDate;}
			set
			{
				if (value != this._aACreatedDate)
				{
					_aACreatedDate=value;
					NotifyChanged("AACreatedDate");
				}
			}
		}
		public String AACreatedUser
		{
			get{return _aACreatedUser;}
			set
			{
				if (value != this._aACreatedUser)
				{
					_aACreatedUser=value;
					NotifyChanged("AACreatedUser");
				}
			}
		}
		public Nullable<DateTime> AAUpdatedDate
		{
			get{return _aAUpdatedDate;}
			set
			{
				if (value != this._aAUpdatedDate)
				{
					_aAUpdatedDate=value;
					NotifyChanged("AAUpdatedDate");
				}
			}
		}
		public String AAUpdatedUser
		{
			get{return _aAUpdatedUser;}
			set
			{
				if (value != this._aAUpdatedUser)
				{
					_aAUpdatedUser=value;
					NotifyChanged("AAUpdatedUser");
				}
			}
		}
		public String AAStatus
		{
			get{return _aAStatus;}
			set
			{
				if (value != this._aAStatus)
				{
					_aAStatus=value;
					NotifyChanged("AAStatus");
				}
			}
		}
		public bool AASelected
		{
			get{return _aASelected;}
			set
			{
				if (value != this._aASelected)
				{
					_aASelected=value;
					NotifyChanged("AASelected");
				}
			}
		}
		public String GLFinalUnionAssetConstructionNo
		{
			get{return _gLFinalUnionAssetConstructionNo;}
			set
			{
				if (value != this._gLFinalUnionAssetConstructionNo)
				{
					_gLFinalUnionAssetConstructionNo=value;
					NotifyChanged("GLFinalUnionAssetConstructionNo");
				}
			}
		}
		public String GLFinalUnionAssetConstructionName
		{
			get{return _gLFinalUnionAssetConstructionName;}
			set
			{
				if (value != this._gLFinalUnionAssetConstructionName)
				{
					_gLFinalUnionAssetConstructionName=value;
					NotifyChanged("GLFinalUnionAssetConstructionName");
				}
			}
		}
		public String GLFinalUnionAssetConstructionDesc
		{
			get{return _gLFinalUnionAssetConstructionDesc;}
			set
			{
				if (value != this._gLFinalUnionAssetConstructionDesc)
				{
					_gLFinalUnionAssetConstructionDesc=value;
					NotifyChanged("GLFinalUnionAssetConstructionDesc");
				}
			}
		}
		public DateTime GLFinalUnionAssetConstructionDate
		{
			get{return _gLFinalUnionAssetConstructionDate;}
			set
			{
				if (value != this._gLFinalUnionAssetConstructionDate)
				{
					_gLFinalUnionAssetConstructionDate=value;
					NotifyChanged("GLFinalUnionAssetConstructionDate");
				}
			}
		}
		public String AAPostStatus
		{
			get{return _aAPostStatus;}
			set
			{
				if (value != this._aAPostStatus)
				{
					_aAPostStatus=value;
					NotifyChanged("AAPostStatus");
				}
			}
		}
		public String AALastPostNo
		{
			get{return _aALastPostNo;}
			set
			{
				if (value != this._aALastPostNo)
				{
					_aALastPostNo=value;
					NotifyChanged("AALastPostNo");
				}
			}
		}
		public Nullable<DateTime> AALastPostDate
		{
			get{return _aALastPostDate;}
			set
			{
				if (value != this._aALastPostDate)
				{
					_aALastPostDate=value;
					NotifyChanged("AALastPostDate");
				}
			}
		}
		public int FK_GECurrencyID
		{
			get{return _fK_GECurrencyID;}
			set
			{
				if (value != this._fK_GECurrencyID)
				{
					_fK_GECurrencyID=value;
					NotifyChanged("FK_GECurrencyID");
				}
			}
		}
		public double GLFinalUnionAssetConstructionExcRate
		{
			get{return _gLFinalUnionAssetConstructionExcRate;}
			set
			{
				if (value != this._gLFinalUnionAssetConstructionExcRate)
				{
					_gLFinalUnionAssetConstructionExcRate=value;
					NotifyChanged("GLFinalUnionAssetConstructionExcRate");
				}
			}
		}
		
        #endregion
    }
    #endregion
}