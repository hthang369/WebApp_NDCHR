 using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
    #region PPRoutingCustomerReqItems
    //-----------------------------------------------------------
    //Generated By: SQLDBTools.NET - LINHCLH (v1.0.12)
    //Class: PPRoutingCustomerReqItemsInfo
    //Created Date: Tuesday, 07 Mar 2017
    //-----------------------------------------------------------

    public class PPRoutingCustomerReqItemsInfo : BusinessObject
    {
        public PPRoutingCustomerReqItemsInfo()
        {
        }
        #region Variables
		protected int _pPRoutingCustomerReqItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser = String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser = String.Empty;
		protected String _aAStatus = DefaultAAStatus;
		protected bool _aASelected = true;
		protected int _fK_PPRoutingID;
		protected int _fK_ARCustomerReqAttrID;
		protected String _pPRoutingCustomerReqItemValue = String.Empty;
		protected String _pPRoutingCustomerReqItemDesc = String.Empty;
		protected String _pPRoutingCustomerReqItemGroup = String.Empty;
		protected int _fK_ICProductGroupID;
		protected int _fK_ICProductTypeID;
		
        #endregion

        #region Public properties
		public int PPRoutingCustomerReqItemID
		{
			get { return _pPRoutingCustomerReqItemID; }
			set
			{
				if (value != this._pPRoutingCustomerReqItemID)
				{
					_pPRoutingCustomerReqItemID = value;
					NotifyChanged("PPRoutingCustomerReqItemID");
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
		public int FK_PPRoutingID
		{
			get { return _fK_PPRoutingID; }
			set
			{
				if (value != this._fK_PPRoutingID)
				{
					_fK_PPRoutingID = value;
					NotifyChanged("FK_PPRoutingID");
				}
			}
		}
		public int FK_ARCustomerReqAttrID
		{
			get { return _fK_ARCustomerReqAttrID; }
			set
			{
				if (value != this._fK_ARCustomerReqAttrID)
				{
					_fK_ARCustomerReqAttrID = value;
					NotifyChanged("FK_ARCustomerReqAttrID");
				}
			}
		}
		public String PPRoutingCustomerReqItemValue
		{
			get { return _pPRoutingCustomerReqItemValue; }
			set
			{
				if (value != this._pPRoutingCustomerReqItemValue)
				{
					_pPRoutingCustomerReqItemValue = value;
					NotifyChanged("PPRoutingCustomerReqItemValue");
				}
			}
		}
		public String PPRoutingCustomerReqItemDesc
		{
			get { return _pPRoutingCustomerReqItemDesc; }
			set
			{
				if (value != this._pPRoutingCustomerReqItemDesc)
				{
					_pPRoutingCustomerReqItemDesc = value;
					NotifyChanged("PPRoutingCustomerReqItemDesc");
				}
			}
		}
		public String PPRoutingCustomerReqItemGroup
		{
			get { return _pPRoutingCustomerReqItemGroup; }
			set
			{
				if (value != this._pPRoutingCustomerReqItemGroup)
				{
					_pPRoutingCustomerReqItemGroup = value;
					NotifyChanged("PPRoutingCustomerReqItemGroup");
				}
			}
		}
		public int FK_ICProductGroupID
		{
			get { return _fK_ICProductGroupID; }
			set
			{
				if (value != this._fK_ICProductGroupID)
				{
					_fK_ICProductGroupID = value;
					NotifyChanged("FK_ICProductGroupID");
				}
			}
		}
		public int FK_ICProductTypeID
		{
			get { return _fK_ICProductTypeID; }
			set
			{
				if (value != this._fK_ICProductTypeID)
				{
					_fK_ICProductTypeID = value;
					NotifyChanged("FK_ICProductTypeID");
				}
			}
		}
		
        #endregion
    }
    #endregion
}