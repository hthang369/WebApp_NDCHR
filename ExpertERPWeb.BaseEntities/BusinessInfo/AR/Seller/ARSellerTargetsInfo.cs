using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSellerTargets
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSellerTargetsInfo
	//Created Date:Friday, April 27, 2012
	//-----------------------------------------------------------
	
	public class ARSellerTargetsInfo:BusinessObject
	{
		public ARSellerTargetsInfo()
		{
		}
		#region Variables
		protected int _aRSellerTargetID;
		protected Nullable<DateTime> _aACreatedDate;
		protected String _aACreatedUser=String.Empty;
		protected Nullable<DateTime> _aAUpdatedDate;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _aRSellerTargetYear;
		protected int _aRSellerTargetPeriod;
		protected double _aRSellerTargetAmt;
		protected int _fK_ARSellerID;
		protected String _aRSellerTargetDesc=String.Empty;
		#endregion

		#region Public properties
		public int ARSellerTargetID
		{
			get{return _aRSellerTargetID;}
			set
			{
				if (value != this._aRSellerTargetID)
				{
				_aRSellerTargetID=value;
				NotifyChanged("ARSellerTargetID");
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
		public int ARSellerTargetYear
		{
			get{return _aRSellerTargetYear;}
			set
			{
				if (value != this._aRSellerTargetYear)
				{
				_aRSellerTargetYear=value;
				NotifyChanged("ARSellerTargetYear");
				}
			}
		}
		public int ARSellerTargetPeriod
		{
			get{return _aRSellerTargetPeriod;}
			set
			{
				if (value != this._aRSellerTargetPeriod)
				{
				_aRSellerTargetPeriod=value;
				NotifyChanged("ARSellerTargetPeriod");
				}
			}
		}
		public double ARSellerTargetAmt
		{
			get{return _aRSellerTargetAmt;}
			set
			{
				if (value != this._aRSellerTargetAmt)
				{
				_aRSellerTargetAmt=value;
				NotifyChanged("ARSellerTargetAmt");
				}
			}
		}
		public int FK_ARSellerID
		{
			get{return _fK_ARSellerID;}
			set
			{
				if (value != this._fK_ARSellerID)
				{
				_fK_ARSellerID=value;
				NotifyChanged("FK_ARSellerID");
				}
			}
		}
		public String ARSellerTargetDesc
		{
			get{return _aRSellerTargetDesc;}
			set
			{
				if (value != this._aRSellerTargetDesc)
				{
				_aRSellerTargetDesc=value;
				NotifyChanged("ARSellerTargetDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}