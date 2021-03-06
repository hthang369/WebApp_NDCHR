using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSalePointItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSalePointItemsInfo
	//Created Date:Friday, December 16, 2011
	//-----------------------------------------------------------
	
	public class ARSalePointItemsInfo:BusinessObject
	{
		public ARSalePointItemsInfo()
		{
		}
		#region Variables
		protected int _aRSalePointItemID;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected String _aACreatedUser=String.Empty;
		protected String _aAUpdatedUser=String.Empty;
		protected Nullable<DateTime> _aACreatedDate;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected int _fK_ARSalePointListID;
		protected int _fK_ICProductID;
		protected String _aRSalePointItemName=String.Empty;
		protected double _aRSalePointItemValue;
		protected Nullable<DateTime> _aRSalePointItemFromDate;
		protected Nullable<DateTime> _aRSalePointItemToDate;
		protected double _aRSalePointItemFromQuantity;
		#endregion

		#region Public properties
		public int ARSalePointItemID
		{
			get{return _aRSalePointItemID;}
			set
			{
				if (value != this._aRSalePointItemID)
				{
				_aRSalePointItemID=value;
				NotifyChanged("ARSalePointItemID");
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
		public int FK_ARSalePointListID
		{
			get{return _fK_ARSalePointListID;}
			set
			{
				if (value != this._fK_ARSalePointListID)
				{
				_fK_ARSalePointListID=value;
				NotifyChanged("FK_ARSalePointListID");
				}
			}
		}
		public int FK_ICProductID
		{
			get{return _fK_ICProductID;}
			set
			{
				if (value != this._fK_ICProductID)
				{
				_fK_ICProductID=value;
				NotifyChanged("FK_ICProductID");
				}
			}
		}
		public String ARSalePointItemName
		{
			get{return _aRSalePointItemName;}
			set
			{
				if (value != this._aRSalePointItemName)
				{
				_aRSalePointItemName=value;
				NotifyChanged("ARSalePointItemName");
				}
			}
		}
		public double ARSalePointItemValue
		{
			get{return _aRSalePointItemValue;}
			set
			{
				if (value != this._aRSalePointItemValue)
				{
				_aRSalePointItemValue=value;
				NotifyChanged("ARSalePointItemValue");
				}
			}
		}
		public Nullable<DateTime> ARSalePointItemFromDate
		{
			get{return _aRSalePointItemFromDate;}
			set
			{
				if (value != this._aRSalePointItemFromDate)
				{
				_aRSalePointItemFromDate=value;
				NotifyChanged("ARSalePointItemFromDate");
				}
			}
		}
		public Nullable<DateTime> ARSalePointItemToDate
		{
			get{return _aRSalePointItemToDate;}
			set
			{
				if (value != this._aRSalePointItemToDate)
				{
				_aRSalePointItemToDate=value;
				NotifyChanged("ARSalePointItemToDate");
				}
			}
		}
		public double ARSalePointItemFromQuantity
		{
			get{return _aRSalePointItemFromQuantity;}
			set
			{
				if (value != this._aRSalePointItemFromQuantity)
				{
				_aRSalePointItemFromQuantity=value;
				NotifyChanged("ARSalePointItemFromQuantity");
				}
			}
		}
		#endregion
	}
	#endregion
}