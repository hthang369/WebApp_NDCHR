using System;
using System.Text;
using System.Collections.Generic;
using ExpertWebLib;
namespace ExpertERP.BusinessEntities
{
	#region HRKPIRealityItems
	//-----------------------------------------------------------
	//Generated By: GMC Studio
	//Class:HRKPIRealityItemsInfo
	//Created Date:Tuesday, July 10, 2018
	//-----------------------------------------------------------
	
	public class HRKPIRealityItemsInfo:BusinessObject
	{
		public HRKPIRealityItemsInfo()
		{
		}
		#region Variables
		protected int _hRKPIRealityItemID;
		protected int _fK_HRKPIRealityID;
		protected int _fK_HREmployeeID;
		protected int _fK_HRPositionID;
		protected double _hRKPIRealityItemValue;
		protected Nullable<DateTime> _hRKPIRealityItemDate;
		#endregion

		#region Public properties
		public int HRKPIRealityItemID
		{
			get{return _hRKPIRealityItemID;}
			set
			{
				if (value != this._hRKPIRealityItemID)
				{
				_hRKPIRealityItemID=value;
				NotifyChanged("HRKPIRealityItemID");
				}
			}
		}
		public int FK_HRKPIRealityID
		{
			get{return _fK_HRKPIRealityID;}
			set
			{
				if (value != this._fK_HRKPIRealityID)
				{
				_fK_HRKPIRealityID=value;
				NotifyChanged("FK_HRKPIRealityID");
				}
			}
		}
		public int FK_HREmployeeID
		{
			get{return _fK_HREmployeeID;}
			set
			{
				if (value != this._fK_HREmployeeID)
				{
				_fK_HREmployeeID=value;
				NotifyChanged("FK_HREmployeeID");
				}
			}
		}
		public int FK_HRPositionID
		{
			get{return _fK_HRPositionID;}
			set
			{
				if (value != this._fK_HRPositionID)
				{
				_fK_HRPositionID=value;
				NotifyChanged("FK_HRPositionID");
				}
			}
		}
		public double HRKPIRealityItemValue
		{
			get{return _hRKPIRealityItemValue;}
			set
			{
				if (value != this._hRKPIRealityItemValue)
				{
				_hRKPIRealityItemValue=value;
				NotifyChanged("HRKPIRealityItemValue");
				}
			}
		}
		public Nullable<DateTime> HRKPIRealityItemDate
		{
			get{return _hRKPIRealityItemDate;}
			set
			{
				if (value != this._hRKPIRealityItemDate)
				{
				_hRKPIRealityItemDate=value;
				NotifyChanged("HRKPIRealityItemDate");
				}
			}
		}
		#endregion
	}
	#endregion
}