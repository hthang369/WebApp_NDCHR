using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleOppItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleOppItemsInfo
	//Created Date:23 Tháng Bảy 2012
	//-----------------------------------------------------------
	
	public class ARSaleOppItemsInfo:BusinessObject
	{
		public ARSaleOppItemsInfo()
		{
		}
		#region Variables
		protected int _aRSaleOppItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected String _aRSaleOppItemNo=String.Empty;
		protected int _aRSaleOppItemQty;
		protected double _aRSaleOppItemUnitPrice;
		protected double _aRSaleOppItemAmt;
		protected int _fK_ARSaleOppID;
		protected int _fK_ICProductID;
		#endregion

		#region Public properties
		public int ARSaleOppItemID
		{
			get{return _aRSaleOppItemID;}
			set
			{
				if (value != this._aRSaleOppItemID)
				{
				_aRSaleOppItemID=value;
				NotifyChanged("ARSaleOppItemID");
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
		public String ARSaleOppItemNo
		{
			get{return _aRSaleOppItemNo;}
			set
			{
				if (value != this._aRSaleOppItemNo)
				{
				_aRSaleOppItemNo=value;
				NotifyChanged("ARSaleOppItemNo");
				}
			}
		}
		public int ARSaleOppItemQty
		{
			get{return _aRSaleOppItemQty;}
			set
			{
				if (value != this._aRSaleOppItemQty)
				{
				_aRSaleOppItemQty=value;
				NotifyChanged("ARSaleOppItemQty");
				}
			}
		}
		public double ARSaleOppItemUnitPrice
		{
			get{return _aRSaleOppItemUnitPrice;}
			set
			{
				if (value != this._aRSaleOppItemUnitPrice)
				{
				_aRSaleOppItemUnitPrice=value;
				NotifyChanged("ARSaleOppItemUnitPrice");
				}
			}
		}
		public double ARSaleOppItemAmt
		{
			get{return _aRSaleOppItemAmt;}
			set
			{
				if (value != this._aRSaleOppItemAmt)
				{
				_aRSaleOppItemAmt=value;
				NotifyChanged("ARSaleOppItemAmt");
				}
			}
		}
		public int FK_ARSaleOppID
		{
			get{return _fK_ARSaleOppID;}
			set
			{
				if (value != this._fK_ARSaleOppID)
				{
				_fK_ARSaleOppID=value;
				NotifyChanged("FK_ARSaleOppID");
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
		#endregion
	}
	#endregion
}