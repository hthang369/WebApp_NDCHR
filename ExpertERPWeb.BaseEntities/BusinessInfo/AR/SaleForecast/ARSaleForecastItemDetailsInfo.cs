using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region ARSaleForecastItemDetails
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:ARSaleForecastItemDetailsInfo
	//Created Date:Wednesday, December 23, 2015
	//-----------------------------------------------------------
	
	public class ARSaleForecastItemDetailsInfo:BusinessObject
	{
		public ARSaleForecastItemDetailsInfo()
		{
		}
		#region Variables
		protected int _aRSaleForecastItemDetailID;
		protected DateTime _aACreatedDate=DateTime.Now;
		protected String _aACreatedUser=String.Empty;
		protected DateTime _aAUpdatedDate=DateTime.Now;
		protected String _aAUpdatedUser=String.Empty;
		protected String _aAStatus=DefaultAAStatus;
		protected bool _aASelected=true;
		protected int _fK_ARSaleForecastItemID;
		protected String _aRSaleForecastItemDetailGroupCombo=String.Empty;
		protected String _aRSaleForecastItemDetailTypeCombo=String.Empty;
		protected int _aRSaleForecastItemDetailTypeValue;
		protected int _aRSaleForecastItemDetailTypeParentValue;
		protected double _aRSaleForecastItemDetailValue;
		protected String _aRSaleForecastItemDetailDesc=String.Empty;
		#endregion

		#region Public properties
		public int ARSaleForecastItemDetailID
		{
			get{return _aRSaleForecastItemDetailID;}
			set
			{
				if (value != this._aRSaleForecastItemDetailID)
				{
				_aRSaleForecastItemDetailID=value;
				NotifyChanged("ARSaleForecastItemDetailID");
				}
			}
		}
		public DateTime AACreatedDate
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
		public DateTime AAUpdatedDate
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
		public int FK_ARSaleForecastItemID
		{
			get{return _fK_ARSaleForecastItemID;}
			set
			{
				if (value != this._fK_ARSaleForecastItemID)
				{
				_fK_ARSaleForecastItemID=value;
				NotifyChanged("FK_ARSaleForecastItemID");
				}
			}
		}
		public String ARSaleForecastItemDetailGroupCombo
		{
			get{return _aRSaleForecastItemDetailGroupCombo;}
			set
			{
				if (value != this._aRSaleForecastItemDetailGroupCombo)
				{
				_aRSaleForecastItemDetailGroupCombo=value;
				NotifyChanged("ARSaleForecastItemDetailGroupCombo");
				}
			}
		}
		public String ARSaleForecastItemDetailTypeCombo
		{
			get{return _aRSaleForecastItemDetailTypeCombo;}
			set
			{
				if (value != this._aRSaleForecastItemDetailTypeCombo)
				{
				_aRSaleForecastItemDetailTypeCombo=value;
				NotifyChanged("ARSaleForecastItemDetailTypeCombo");
				}
			}
		}
		public int ARSaleForecastItemDetailTypeValue
		{
			get{return _aRSaleForecastItemDetailTypeValue;}
			set
			{
				if (value != this._aRSaleForecastItemDetailTypeValue)
				{
				_aRSaleForecastItemDetailTypeValue=value;
				NotifyChanged("ARSaleForecastItemDetailTypeValue");
				}
			}
		}
		public int ARSaleForecastItemDetailTypeParentValue
		{
			get{return _aRSaleForecastItemDetailTypeParentValue;}
			set
			{
				if (value != this._aRSaleForecastItemDetailTypeParentValue)
				{
				_aRSaleForecastItemDetailTypeParentValue=value;
				NotifyChanged("ARSaleForecastItemDetailTypeParentValue");
				}
			}
		}
		public double ARSaleForecastItemDetailValue
		{
			get{return _aRSaleForecastItemDetailValue;}
			set
			{
				if (value != this._aRSaleForecastItemDetailValue)
				{
				_aRSaleForecastItemDetailValue=value;
				NotifyChanged("ARSaleForecastItemDetailValue");
				}
			}
		}
		public String ARSaleForecastItemDetailDesc
		{
			get{return _aRSaleForecastItemDetailDesc;}
			set
			{
				if (value != this._aRSaleForecastItemDetailDesc)
				{
				_aRSaleForecastItemDetailDesc=value;
				NotifyChanged("ARSaleForecastItemDetailDesc");
				}
			}
		}
		#endregion
	}
	#endregion
}