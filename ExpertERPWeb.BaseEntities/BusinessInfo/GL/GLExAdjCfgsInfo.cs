using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region GLExAdjCfgs
    //-----------------------------------------------------------
    //Generated By: GMC Studio
    //Class: GLExAdjCfgsInfo
    //Created Date: 25 Mar 2015
    //-----------------------------------------------------------

    public class GLExAdjCfgsInfo : BusinessObject
    {
        public GLExAdjCfgsInfo()
        {
        }
        #region Variables
		protected int _gLExAdjCfgID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _gLExAdjCfgNo=String.Empty;
		protected String _gLExAdjCfgName=String.Empty;
		protected Nullable<DateTime> _gLExAdjCfgDate;
		protected int _fK_GLProfitAccountID;
		protected int _fK_GLLossAccountID;
		
        #endregion

        #region Public properties
		public int GLExAdjCfgID
		{
			get{return _gLExAdjCfgID;}
			set
			{
				if (value != this._gLExAdjCfgID)
				{
					_gLExAdjCfgID=value;
					NotifyChanged("GLExAdjCfgID");
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
		public String GLExAdjCfgNo
		{
			get{return _gLExAdjCfgNo;}
			set
			{
				if (value != this._gLExAdjCfgNo)
				{
					_gLExAdjCfgNo=value;
					NotifyChanged("GLExAdjCfgNo");
				}
			}
		}
		public String GLExAdjCfgName
		{
			get{return _gLExAdjCfgName;}
			set
			{
				if (value != this._gLExAdjCfgName)
				{
					_gLExAdjCfgName=value;
					NotifyChanged("GLExAdjCfgName");
				}
			}
		}
		public Nullable<DateTime> GLExAdjCfgDate
		{
			get{return _gLExAdjCfgDate;}
			set
			{
				if (value != this._gLExAdjCfgDate)
				{
					_gLExAdjCfgDate=value;
					NotifyChanged("GLExAdjCfgDate");
				}
			}
		}
		public int FK_GLProfitAccountID
		{
			get{return _fK_GLProfitAccountID;}
			set
			{
				if (value != this._fK_GLProfitAccountID)
				{
					_fK_GLProfitAccountID=value;
					NotifyChanged("FK_GLProfitAccountID");
				}
			}
		}
		public int FK_GLLossAccountID
		{
			get{return _fK_GLLossAccountID;}
			set
			{
				if (value != this._fK_GLLossAccountID)
				{
					_fK_GLLossAccountID=value;
					NotifyChanged("FK_GLLossAccountID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}