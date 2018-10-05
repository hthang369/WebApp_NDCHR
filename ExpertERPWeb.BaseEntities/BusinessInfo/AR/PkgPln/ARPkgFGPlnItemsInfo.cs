using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARPkgFGPlnItems
	//-----------------------------------------------------------
	//Generated By: Expert Studio
	//Class:ARPkgFGPlnItemsInfo
	//Created Date:Monday, November 19, 2012
	//-----------------------------------------------------------
	
	public class ARPkgFGPlnItemsInfo:BusinessObject
	{
		public ARPkgFGPlnItemsInfo()
		{
		}
		#region Variables
		protected int _aRPkgFGPlnItemID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ARPkgPlnID;
		protected int _fK_ICProductID;
		protected double _aRPkgFGPlnItemHTSQty;
		protected double _aRPkgFGPlnItemInvQty;
		protected double _aRPkgFGPlnItemEstProductionQty;
		protected double _aRPkgFGPlnItemAvailableQty;
		protected double _aRPkgFGPlnItemAllocatedQty;
		protected double _aRPkgFGPlnItemCanShpQty;
		protected double _aRPkgFGPlnItemQty;
		#endregion

		#region Public properties
		public int ARPkgFGPlnItemID
		{
			get{return _aRPkgFGPlnItemID;}
			set
			{
				if (value != this._aRPkgFGPlnItemID)
				{
				_aRPkgFGPlnItemID=value;
				NotifyChanged("ARPkgFGPlnItemID");
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
		public int FK_ARPkgPlnID
		{
			get{return _fK_ARPkgPlnID;}
			set
			{
				if (value != this._fK_ARPkgPlnID)
				{
				_fK_ARPkgPlnID=value;
				NotifyChanged("FK_ARPkgPlnID");
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
		public double ARPkgFGPlnItemHTSQty
		{
			get{return _aRPkgFGPlnItemHTSQty;}
			set
			{
				if (value != this._aRPkgFGPlnItemHTSQty)
				{
				_aRPkgFGPlnItemHTSQty=value;
				NotifyChanged("ARPkgFGPlnItemHTSQty");
				}
			}
		}
		public double ARPkgFGPlnItemInvQty
		{
			get{return _aRPkgFGPlnItemInvQty;}
			set
			{
				if (value != this._aRPkgFGPlnItemInvQty)
				{
				_aRPkgFGPlnItemInvQty=value;
				NotifyChanged("ARPkgFGPlnItemInvQty");
				}
			}
		}
		public double ARPkgFGPlnItemEstProductionQty
		{
			get{return _aRPkgFGPlnItemEstProductionQty;}
			set
			{
				if (value != this._aRPkgFGPlnItemEstProductionQty)
				{
				_aRPkgFGPlnItemEstProductionQty=value;
				NotifyChanged("ARPkgFGPlnItemEstProductionQty");
				}
			}
		}
		public double ARPkgFGPlnItemAvailableQty
		{
			get{return _aRPkgFGPlnItemAvailableQty;}
			set
			{
				if (value != this._aRPkgFGPlnItemAvailableQty)
				{
				_aRPkgFGPlnItemAvailableQty=value;
				NotifyChanged("ARPkgFGPlnItemAvailableQty");
				}
			}
		}
		public double ARPkgFGPlnItemAllocatedQty
		{
			get{return _aRPkgFGPlnItemAllocatedQty;}
			set
			{
				if (value != this._aRPkgFGPlnItemAllocatedQty)
				{
				_aRPkgFGPlnItemAllocatedQty=value;
				NotifyChanged("ARPkgFGPlnItemAllocatedQty");
				}
			}
		}
		public double ARPkgFGPlnItemCanShpQty
		{
			get{return _aRPkgFGPlnItemCanShpQty;}
			set
			{
				if (value != this._aRPkgFGPlnItemCanShpQty)
				{
				_aRPkgFGPlnItemCanShpQty=value;
				NotifyChanged("ARPkgFGPlnItemCanShpQty");
				}
			}
		}
		public double ARPkgFGPlnItemQty
		{
			get{return _aRPkgFGPlnItemQty;}
			set
			{
				if (value != this._aRPkgFGPlnItemQty)
				{
				_aRPkgFGPlnItemQty=value;
				NotifyChanged("ARPkgFGPlnItemQty");
				}
			}
		}
		#endregion
	}
	#endregion
}